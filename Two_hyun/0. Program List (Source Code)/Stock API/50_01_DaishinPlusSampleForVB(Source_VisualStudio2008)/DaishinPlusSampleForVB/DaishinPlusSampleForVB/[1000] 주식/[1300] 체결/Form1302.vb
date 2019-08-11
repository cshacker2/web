Public Class Form1302
    Private _parent As Main

    Dim _CpTd5342 As New CPTRADELib.CpTd5342

    Dim _Table As DataTable = New DataTable

    Private Sub Form1302_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        _parent.CloseStockSelector(Me)
    End Sub

    Private Sub Form1302_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub Form1302_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.KeyPreview = True

        _parent = Me.ParentForm

        ButtonNext.Enabled = False

        _Table.Columns.Add("종목명")
        _Table.Columns.Add("거래구분")
        _Table.Columns.Add("매매구분")
        _Table.Columns.Add("체결수량")
        _Table.Columns.Add("수수료")
        _Table.Columns.Add("농특세")
        _Table.Columns.Add("거래세")
        _Table.Columns.Add("매수일")
        _Table.Columns.Add("약정금액")
        _Table.Columns.Add("결제금액")
        _Table.Columns.Add("정산금액")

        DataGridView1.DataSource = _Table
        DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Refresh()

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

        ComboBoxQueryKind.SelectedIndex = 0
        ComboBoxDay.SelectedIndex = 0
    End Sub

    Private Sub ComboBoxAccountKind_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxAccountKind.SelectedIndexChanged
        If TextBoxCode.Text.Length >= 7 Then
            _parent.ChangedAccountKind(ComboBoxAccountKind.SelectedItem)
            Me.Request(True)
        End If
    End Sub

    Private Sub ButtonQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonQuery.Click
        If ComboBoxQueryKind.SelectedIndex = 0 Then
            Me.Request(False)
        Else
            Me.Request(True)
        End If
    End Sub

    Private Sub ButtonHelp1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHelp1.Click
        _parent.ShowHelp("1302")
    End Sub

    Private Sub Request(ByVal bEach As Boolean)
        If _CpTd5342.GetDibStatus() = 1 Then
            Trace.TraceInformation("DibRq 요청 수신대기 중 입니다. 수신이 완료된 후 다시 호출 하십시오.")
            Exit Sub
        End If

        If bEach Then
            If TextBoxCode.Text.Length < 7 Then
                Exit Sub
            End If
        End If

        _Table.Clear()
        DataGridView1.Refresh()

        _CpTd5342.SetInputValue(0, TextBoxAccountNo1.Text + TextBoxAccountNo2.Text)
        _CpTd5342.SetInputValue(1, ComboBoxAccountKind.SelectedItem)
        _CpTd5342.SetInputValue(2, 20)

        If ComboBoxDay.SelectedIndex = 0 Then
            _CpTd5342.SetInputValue(3, "1")
        Else
            _CpTd5342.SetInputValue(3, "2")
        End If

        If bEach Then
            _CpTd5342.SetInputValue(4, TextBoxCode.Text.ToUpper())
        Else
            _CpTd5342.SetInputValue(4, "")
        End If

        ButtonNext.Enabled = False

        Me.JustRequest()
    End Sub

    Private Sub JustRequest()
        LabelMsg1.Text = ""
        LabelContinue.Text = ""

        TextBoxFrom.Text = ""
        TextBoxTo.Text = ""
        TextBoxSell.Text = ""
        TextBoxBuy.Text = ""

        Dim result As Integer = -1
        result = _CpTd5342.BlockRequest

        LabelMsg1.Text = _CpTd5342.GetDibMsg1()

        If _CpTd5342.Continue = 1 Then
            LabelContinue.Text = "연속 데이터 있음"
            ButtonNext.Enabled = True
        Else
            LabelContinue.Text = "연속 데이터 없음"
            ButtonNext.Enabled = False
        End If

        If result = 0 Then
            TextBoxFrom.Text = _CpTd5342.GetHeaderValue(3)
            TextBoxTo.Text = _CpTd5342.GetHeaderValue(4)
            TextBoxSell.Text = _CpTd5342.GetHeaderValue(9)
            TextBoxBuy.Text = _CpTd5342.GetHeaderValue(10)

            For i As Integer = 0 To _CpTd5342.GetHeaderValue(8) - 1
                Dim rowOrder As DataRow = _Table.NewRow

                rowOrder(0) = _CpTd5342.GetDataValue(1, i)
                rowOrder(1) = _CpTd5342.GetDataValue(20, i)
                rowOrder(2) = _CpTd5342.GetDataValue(10, i)
                rowOrder(3) = _CpTd5342.GetDataValue(3, i)
                rowOrder(4) = _CpTd5342.GetDataValue(4, i)
                rowOrder(5) = _CpTd5342.GetDataValue(5, i)
                rowOrder(6) = _CpTd5342.GetDataValue(12, i)
                rowOrder(7) = _CpTd5342.GetDataValue(13, i)
                rowOrder(8) = _CpTd5342.GetDataValue(22, i)
                rowOrder(9) = _CpTd5342.GetDataValue(23, i)
                rowOrder(10) = _CpTd5342.GetDataValue(24, i)

                _Table.Rows.Add(rowOrder)
            Next

            DataGridView1.Refresh()
        End If

    End Sub

    Private Sub ButtonSelectCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSelectCode.Click
        _parent.ShowStockSelector(Me)
    End Sub

    Public Sub ChangedStockCode(ByVal code As String, ByVal name As String)
        TextBoxName.Text = name
        TextBoxCode.Text = code
    End Sub

    Private Sub TextBoxCode_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBoxCode.TextChanged
        If TextBoxCode.Text.Length >= 7 Then
            TextBoxName.Text = _parent.FindStockName(TextBoxCode.Text.ToUpper)

            If ComboBoxQueryKind.SelectedIndex = 0 Then
                ComboBoxQueryKind.SelectedIndex = 1
            Else
                Me.Request(True)
            End If
        End If
    End Sub

    Private Sub DataGridView1_DataBindingComplete(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles DataGridView1.DataBindingComplete
        DataGridView1.ClearSelection()
    End Sub

    Private Sub ButtonNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonNext.Click
        Me.JustRequest()
    End Sub

    Private Sub ComboBoxQueryKind_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxQueryKind.SelectedIndexChanged
        If ComboBoxQueryKind.SelectedIndex = 0 Then
            Me.Request(False)
        Else
            Me.Request(True)
        End If
    End Sub

    Private Sub DataGridView1_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        If DataGridView1.Item(2, e.RowIndex).Value.ToString().Contains("매수") Then
            DataGridView1.Rows(e.RowIndex).Cells(2).Style.ForeColor = Color.Red
        Else
            DataGridView1.Rows(e.RowIndex).Cells(2).Style.ForeColor = Color.Blue
        End If
    End Sub

    Private Sub ComboBoxDay_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxDay.SelectedIndexChanged
        If ComboBoxDay.SelectedIndex = 0 Then
            Me.Request(False)
        Else
            Me.Request(True)
        End If
    End Sub

    Public Sub ReceivedStockTrade()
        Me.ButtonQuery_Click(Nothing, Nothing)
    End Sub

End Class