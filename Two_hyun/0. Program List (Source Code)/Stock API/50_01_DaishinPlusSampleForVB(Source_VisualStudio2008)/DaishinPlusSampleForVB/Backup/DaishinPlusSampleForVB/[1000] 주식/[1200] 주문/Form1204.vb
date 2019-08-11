Public Class Form1204
    Dim _CpTdNew9061 As New CPTRADELib.CpTdNew9061
    Dim _CpTdNew9064 As New CPTRADELib.CpTdNew9064
    
    Private _parent As Main

    Dim _Table As DataTable = New DataTable

    Private Sub Form1204_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        _parent.CloseStockSelector(Me)
    End Sub

    Private Sub Form1204_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub Form1204_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.KeyPreview = True

        _parent = Me.ParentForm

        _Table.Columns.Add("예약번호")
        _Table.Columns.Add("계좌명")
        _Table.Columns.Add("구분")
        _Table.Columns.Add("매매")
        _Table.Columns.Add("종목명")
        _Table.Columns.Add("주문수량")
        _Table.Columns.Add("호가구분")
        _Table.Columns.Add("주문가격")

        DataGridView1.DataSource = _Table
        DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Refresh()

        TextBoxName.Text = _parent.stockName
        TextBoxCode.Text = _parent.stockCode

        TextBoxBuyCount.Text = "0"
        TextBoxBuyPrice.Text = "0"

        TextBoxSellCount.Text = "0"
        TextBoxSellPrice.Text = "0"
        ComboBoxBuyTrade.SelectedIndex = 0

        ComboBoxSellTrade.SelectedIndex = 0

        TextBoxAccountNo1.Text = _parent.accountNo.Substring(0, 3)
        TextBoxAccountNo2.Text = _parent.accountNo.Substring(3, 6)

        Dim selectedIndex As Integer = -1
        For i As Integer = 0 To _parent.arrAccountGoodsStock.Count - 1
            ComboBoxAccountKind.Items.Add(_parent.arrAccountGoodsStock(i))
            If selectedIndex = -1 And _parent.arrAccountGoodsStock(i) = _parent.accountGoodsStock Then
                selectedIndex = i
            End If
        Next

        If selectedIndex <> -1 Then
            ComboBoxAccountKind.SelectedIndex = selectedIndex
        End If

    End Sub

    Private Sub ButtonSelectCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSelectCode.Click
        _parent.ShowStockSelector(Me)
    End Sub

    Public Sub ChangedStockCode(ByVal code As String, ByVal name As String)
        TextBoxCode.Text = code
        TextBoxName.Text = name
    End Sub

    Private Sub TextBoxCode_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBoxCode.TextChanged
        If TextBoxCode.Text.Length >= 7 Then
            TextBoxName.Text = _parent.FindStockName(TextBoxCode.Text.ToUpper)
        End If
    End Sub

    Private Sub ButtonBuyDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBuyDown.Click
        TextBoxBuyCount.Text = (CInt(TextBoxBuyCount.Text) - 1).ToString()

        If CInt(TextBoxBuyCount.Text) < 0 Then
            TextBoxBuyCount.Text = "0"
        End If
    End Sub

    Private Sub ButtonBuyUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBuyUp.Click
        TextBoxBuyCount.Text = (CInt(TextBoxBuyCount.Text) + 1).ToString()
    End Sub

    Private Sub ButtonBuyPrice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBuyPrice.Click
        _parent.ShowStockQuote(Me)
    End Sub

    Private Sub ButtonOrderBuy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonOrderBuy.Click
        If _CpTdNew9061.GetDibStatus() = 1 Then
            Trace.TraceInformation("DibRq 요청 수신대기 중 입니다. 수신이 완료된 후 다시 호출 하십시오.")
            Exit Sub
        End If

        LabelMsg1.Text = ""
        _Table.Clear()
        DataGridView1.Refresh()

        _CpTdNew9061.SetInputValue(0, TextBoxAccountNo1.Text + TextBoxAccountNo2.Text)
        _CpTdNew9061.SetInputValue(1, ComboBoxAccountKind.SelectedItem)
        _CpTdNew9061.SetInputValue(2, "2")
        _CpTdNew9061.SetInputValue(3, TextBoxCode.Text.ToUpper())
        _CpTdNew9061.SetInputValue(4, TextBoxBuyCount.Text)
        
        Dim trade As String = ComboBoxBuyTrade.SelectedItem.ToString().Substring(0, 2)
        _CpTdNew9061.SetInputValue(5, trade)

        If trade = "03" Then
            _CpTdNew9061.SetInputValue(6, "0")
        Else
            _CpTdNew9061.SetInputValue(6, TextBoxBuyPrice.Text)
        End If

        _CpTdNew9061.SetInputValue(7, Asc("1"))

        Dim result As Integer = -1
        result = _CpTdNew9061.BlockRequest

        LabelMsg1.Text = _CpTdNew9061.GetDibMsg1()
        If result = 0 Then
            Dim row As DataRow = _Table.NewRow

            row(0) = _CpTdNew9061.GetHeaderValue(0)
            row(1) = _CpTdNew9061.GetHeaderValue(1)
            row(2) = _CpTdNew9061.GetHeaderValue(2)
            row(3) = _CpTdNew9061.GetHeaderValue(3)
            row(4) = _CpTdNew9061.GetHeaderValue(4)
            row(5) = _CpTdNew9061.GetHeaderValue(5)
            row(6) = _CpTdNew9061.GetHeaderValue(6)
            row(7) = _CpTdNew9061.GetHeaderValue(7)

            _Table.Rows.Add(row)
            DataGridView1.Refresh()

            _parent.ReceivedStockReservedOrder()
        End If
    End Sub

    Public Sub ChangedStockQuote(ByVal price As String)
        If TabControl1.SelectedIndex = 0 Then
            TextBoxBuyPrice.Text = price
        ElseIf TabControl1.SelectedIndex = 1 Then
            TextBoxSellPrice.Text = price
        End If
    End Sub

    Public Sub ChangedStockCount(ByVal count As String)
        If TabControl1.SelectedIndex = 0 Then
            TextBoxBuyCount.Text = count
        ElseIf TabControl1.SelectedIndex = 1 Then
            TextBoxSellCount.Text = count
        End If
    End Sub

    Private Sub ComboBoxAccountKind_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxAccountKind.SelectedIndexChanged
        _parent.ChangedAccountKind(ComboBoxAccountKind.SelectedItem)
    End Sub

    Private Sub ButtonSellDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSellDown.Click
        TextBoxSellCount.Text = (CInt(TextBoxSellCount.Text) - 1).ToString()

        If CInt(TextBoxBuyCount.Text) < 0 Then
            TextBoxSellCount.Text = "0"
        End If
    End Sub

    Private Sub ButtonSellUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSellUp.Click
        TextBoxSellCount.Text = (CInt(TextBoxSellCount.Text) + 1).ToString()
    End Sub

    Private Sub ButtonSellPrice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSellPrice.Click
        _parent.ShowStockQuote(Me)
    End Sub

    Private Sub ButtonOrderSell_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonOrderSell.Click
        If _CpTdNew9061.GetDibStatus() = 1 Then
            Trace.TraceInformation("DibRq 요청 수신대기 중 입니다. 수신이 완료된 후 다시 호출 하십시오.")
            Exit Sub
        End If

        LabelMsg1.Text = ""
        _Table.Clear()
        DataGridView1.Refresh()

        _CpTdNew9061.SetInputValue(0, TextBoxAccountNo1.Text + TextBoxAccountNo2.Text)
        _CpTdNew9061.SetInputValue(1, ComboBoxAccountKind.SelectedItem)
        _CpTdNew9061.SetInputValue(2, "1")
        _CpTdNew9061.SetInputValue(3, TextBoxCode.Text.ToUpper())
        _CpTdNew9061.SetInputValue(4, TextBoxSellCount.Text)

        Dim trade As String = ComboBoxSellTrade.SelectedItem.ToString().Substring(0, 2)
        _CpTdNew9061.SetInputValue(5, trade)

        If trade = "03" Then
            _CpTdNew9061.SetInputValue(6, "0")
        Else
            _CpTdNew9061.SetInputValue(6, TextBoxSellPrice.Text)
        End If

        _CpTdNew9061.SetInputValue(7, Asc("1"))

        Dim result As Integer = -1
        result = _CpTdNew9061.BlockRequest

        LabelMsg1.Text = _CpTdNew9061.GetDibMsg1()
        If result = 0 Then
            Dim row As DataRow = _Table.NewRow

            row(0) = _CpTdNew9061.GetHeaderValue(0)
            row(1) = _CpTdNew9061.GetHeaderValue(1)
            row(2) = _CpTdNew9061.GetHeaderValue(2)
            row(3) = _CpTdNew9061.GetHeaderValue(3)
            row(4) = _CpTdNew9061.GetHeaderValue(4)
            row(5) = _CpTdNew9061.GetHeaderValue(5)
            row(6) = _CpTdNew9061.GetHeaderValue(6)
            row(7) = _CpTdNew9061.GetHeaderValue(7)

            _Table.Rows.Add(row)
            DataGridView1.Refresh()

            _parent.ReceivedStockReservedOrder()
        End If
    End Sub

    Private Sub ButtonHelpBuy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHelpBuy.Click
        _parent.ShowHelp("12041")
    End Sub

    Private Sub ButtonHelpSell_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHelpSell.Click
        _parent.ShowHelp("12041")
    End Sub

    Private Sub ButtonHelp3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHelp3.Click
        _parent.ShowHelp("12042")
    End Sub

    Private Sub ButtonCancelOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancelOrder.Click
        If _CpTdNew9064.GetDibStatus() = 1 Then
            Trace.TraceInformation("DibRq 요청 수신대기 중 입니다. 수신이 완료된 후 다시 호출 하십시오.")
            Exit Sub
        End If

        If TextBoxCancel.Text = "" Then
            MsgBox("예약번호를 입력하세요")
            Exit Sub
        End If

        LabelMsg1.Text = ""
        _Table.Clear()
        DataGridView1.Refresh()

        _CpTdNew9064.SetInputValue(0, TextBoxCancel.Text)
        _CpTdNew9064.SetInputValue(1, TextBoxAccountNo1.Text + TextBoxAccountNo2.Text)
        _CpTdNew9064.SetInputValue(2, ComboBoxAccountKind.SelectedItem)
        _CpTdNew9064.SetInputValue(3, TextBoxCode.Text.ToUpper())
        
        Dim result As Integer = -1
        result = _CpTdNew9064.BlockRequest

        LabelMsg1.Text = _CpTdNew9064.GetDibMsg1()
        If result = 0 Then
            Dim row As DataRow = _Table.NewRow

            row(0) = _CpTdNew9064.GetHeaderValue(0)
            row(1) = _CpTdNew9064.GetHeaderValue(1)
            row(2) = _CpTdNew9064.GetHeaderValue(2)
            row(3) = _CpTdNew9064.GetHeaderValue(3)
            row(4) = _CpTdNew9064.GetHeaderValue(4)
            row(5) = _CpTdNew9064.GetHeaderValue(5)
            row(6) = _CpTdNew9064.GetHeaderValue(6)
            row(7) = _CpTdNew9064.GetHeaderValue(7)

            _Table.Rows.Add(row)
            DataGridView1.Refresh()

            _parent.ReceivedStockReservedOrder()
        End If
    End Sub

    Private Sub DataGridView1_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        If e.ColumnIndex = 3 Then
            DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            If DataGridView1.Item(e.ColumnIndex, e.RowIndex).Value.ToString() = "매수" Then
                DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.ForeColor = Color.Red
            Else
                DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.ForeColor = Color.Blue
            End If
        End If
    End Sub

    Private Sub ButtonCancelQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancelQuery.Click
        _parent.ShowStockReservedOrderList()
    End Sub

    Public Sub ChangedStockReservedOrderNo(ByVal no As String)
        TextBoxCancel.Text = no
    End Sub

End Class