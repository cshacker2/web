Public Class Form1202
    Private _parent As Main

    Dim _CpTdNew5331A As New CPTRADELib.CpTdNew5331A

    Dim _TablePrice As DataTable = New DataTable
    Dim _TableCount As DataTable = New DataTable

    Private Sub Form1202_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        _parent.CloseStockSelector(Me)
    End Sub

    Private Sub Form1202_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub Form1202_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.KeyPreview = True

        _parent = Me.ParentForm

        TextBoxPrice.Text = "0"

        _TablePrice.Columns.Add("증거금20%금액")
        _TablePrice.Columns.Add("증거금30%금액")
        _TablePrice.Columns.Add("증거금40%금액")
        _TablePrice.Columns.Add("증거금50%금액")
        _TablePrice.Columns.Add("증거금60%금액")
        _TablePrice.Columns.Add("증거금70%금액")
        _TablePrice.Columns.Add("증거금100%금액")
        _TablePrice.Columns.Add("현금가능금액")
        _TableCount.Columns.Add("증거금20%수량")
        _TableCount.Columns.Add("증거금30%수량")
        _TableCount.Columns.Add("증거금40%수량")
        _TableCount.Columns.Add("증거금50%수량")
        _TableCount.Columns.Add("증거금60%수량")
        _TableCount.Columns.Add("증거금70%수량")
        _TableCount.Columns.Add("증거금100%수량")
        _TableCount.Columns.Add("현금가능수량")

        DataGridView1.DataSource = _TablePrice
        DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Refresh()

        DataGridView2.DataSource = _TableCount
        DataGridView2.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader
        DataGridView2.AllowUserToResizeRows = False
        DataGridView2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView2.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView2.Refresh()

        ComboBoxTrade.SelectedIndex = 0
        ComboBoxQueryKind.SelectedIndex = 0

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

        TextBoxName.Text = _parent.stockName
        TextBoxCode.Text = _parent.stockCode

    End Sub

    Private Sub ComboBoxAccountKind_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxAccountKind.SelectedIndexChanged
        If TextBoxCode.Text.Length >= 7 Then
            _parent.ChangedAccountKind(ComboBoxAccountKind.SelectedItem)
            Me.Request()
        End If
    End Sub

    Private Sub ButtonQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonQuery.Click
        Me.Request()
    End Sub

    Private Sub ButtonBuyPrice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBuyPrice.Click
        _parent.ShowStockQuote(Me)
    End Sub

    Private Sub ButtonHelp1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHelp1.Click
        _parent.ShowHelp("1202")
    End Sub

    Private Sub Request()
        If _CpTdNew5331A.GetDibStatus() = 1 Then
            Trace.TraceInformation("DibRq 요청 수신대기 중 입니다. 수신이 완료된 후 다시 호출 하십시오.")
            Exit Sub
        End If

        If ComboBoxQueryKind.SelectedIndex = 1 Then
            If TextBoxPrice.Text = "0" Or TextBoxPrice.Text = "" Then
                MsgBox("주문단가를 입력하세요.")
                Exit Sub
            End If
        End If

        LabelMsg1.Text = ""

        _TablePrice.Clear()
        _TableCount.Clear()

        _CpTdNew5331A.SetInputValue(0, TextBoxAccountNo1.Text + TextBoxAccountNo2.Text)
        _CpTdNew5331A.SetInputValue(1, ComboBoxAccountKind.SelectedItem)
        _CpTdNew5331A.SetInputValue(2, TextBoxCode.Text.ToUpper())
        _CpTdNew5331A.SetInputValue(3, ComboBoxTrade.SelectedItem.Substring(0, 2))
        _CpTdNew5331A.SetInputValue(4, TextBoxPrice.Text)
        If CheckBoxCharge.Checked Then
            _CpTdNew5331A.SetInputValue(5, "Y")
        Else
            _CpTdNew5331A.SetInputValue(5, "N")
        End If

        If ComboBoxQueryKind.SelectedIndex = 0 Then
            _CpTdNew5331A.SetInputValue(6, Asc("1"))
        Else
            _CpTdNew5331A.SetInputValue(6, Asc("2"))
        End If

        Dim result As Integer = -1
        result = _CpTdNew5331A.BlockRequest

        LabelMsg1.Text = _CpTdNew5331A.GetDibMsg1()
        If result = 0 Then
            Dim rowPrice As DataRow = _TablePrice.NewRow

            rowPrice(0) = _CpTdNew5331A.GetHeaderValue(3)
            rowPrice(1) = _CpTdNew5331A.GetHeaderValue(4)
            rowPrice(2) = _CpTdNew5331A.GetHeaderValue(5)
            rowPrice(3) = _CpTdNew5331A.GetHeaderValue(6)
            rowPrice(4) = _CpTdNew5331A.GetHeaderValue(7)
            rowPrice(5) = _CpTdNew5331A.GetHeaderValue(8)
            rowPrice(6) = _CpTdNew5331A.GetHeaderValue(9)
            rowPrice(7) = _CpTdNew5331A.GetHeaderValue(10)

            _TablePrice.Rows.Add(rowPrice)
            DataGridView1.Refresh()

            Dim rowCount As DataRow = _TableCount.NewRow
            rowCount(0) = _CpTdNew5331A.GetHeaderValue(11)
            rowCount(1) = _CpTdNew5331A.GetHeaderValue(12)
            rowCount(2) = _CpTdNew5331A.GetHeaderValue(13)
            rowCount(3) = _CpTdNew5331A.GetHeaderValue(14)
            rowCount(4) = _CpTdNew5331A.GetHeaderValue(15)
            rowCount(5) = _CpTdNew5331A.GetHeaderValue(16)
            rowCount(6) = _CpTdNew5331A.GetHeaderValue(17)
            rowCount(7) = _CpTdNew5331A.GetHeaderValue(18)

            _TableCount.Rows.Add(rowCount)
            DataGridView2.Refresh()
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
            Me.Request()
        End If
    End Sub

    Private Sub DataGridView1_DataBindingComplete(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles DataGridView1.DataBindingComplete
        DataGridView1.ClearSelection()
    End Sub

    Private Sub DataGridView2_DataBindingComplete(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles DataGridView2.DataBindingComplete
        DataGridView2.ClearSelection()
    End Sub

    Private Sub ComboBoxQueryKind_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxQueryKind.SelectedIndexChanged
        If TextBoxCode.Text.Length >= 7 Then
            Me.Request()
        End If
    End Sub

    Private Sub DataGridView2_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        If DataGridView2.SelectedCells.Count > 0 Then
            Dim cell As DataGridViewCell = DataGridView2.SelectedCells(0)
            _parent.ChangedStockCount(cell.Value)
        End If
    End Sub

    Private Sub DataGridView2_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellDoubleClick
        If DataGridView2.SelectedCells.Count > 0 Then
            Dim cell As DataGridViewCell = DataGridView2.SelectedCells(0)
            _parent.ChangedStockCount(cell.Value)
            Me.Close()
        End If
    End Sub

    Public Sub ChangedStockQuote(ByVal price As String)
        TextBoxPrice.Text = price
    End Sub

End Class