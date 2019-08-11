Public Class Form1401
    Private _parent As Main

    Dim _CpTd6033 As New CPTRADELib.CpTd6033

    Dim _Table As DataTable = New DataTable

    Private Sub Form1401_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub Form1401_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.KeyPreview = True

        _parent = Me.ParentForm

        ButtonNext.Enabled = False

        _Table.Columns.Add("종목명")
        _Table.Columns.Add("결제잔고수량")
        _Table.Columns.Add("결제장부단가")
        _Table.Columns.Add("체결잔고수량")
        _Table.Columns.Add("평가금액")
        _Table.Columns.Add("평가손익")
        _Table.Columns.Add("수익률")
        _Table.Columns.Add("매도가능수량")
        _Table.Columns.Add("체결장부단가")
        _Table.Columns.Add("손익단가")

        DataGridView1.DataSource = _Table
        DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
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

        Dim a = ComboBoxAccountKind.Items.Count
        If selectedIndex <> -1 Then
            ComboBoxAccountKind.SelectedIndex = selectedIndex
        End If
    End Sub

    Private Sub ComboBoxAccountKind_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxAccountKind.SelectedIndexChanged
        _parent.ChangedAccountKind(ComboBoxAccountKind.SelectedItem)
        Me.Request()
    End Sub

    Private Sub ButtonQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonQuery.Click
        Me.Request()
    End Sub

    Private Sub ButtonNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonNext.Click
        Me.JustRequest()
    End Sub

    Private Sub ButtonHelp1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHelp1.Click
        _parent.ShowHelp("1401")
    End Sub

    Private Sub Request()
        If _CpTd6033.GetDibStatus() = 1 Then
            Trace.TraceInformation("DibRq 요청 수신대기 중 입니다. 수신이 완료된 후 다시 호출 하십시오.")
            Exit Sub
        End If

        _Table.Clear()
        DataGridView1.Refresh()

        _CpTd6033.SetInputValue(0, TextBoxAccountNo1.Text + TextBoxAccountNo2.Text)
        _CpTd6033.SetInputValue(1, ComboBoxAccountKind.SelectedItem)
        _CpTd6033.SetInputValue(2, 20)

        ButtonNext.Enabled = False

        Me.JustRequest()
    End Sub

    Private Sub JustRequest()
        LabelMsg1.Text = ""
        LabelContinue.Text = ""

        Dim result As Integer = -1
        result = _CpTd6033.BlockRequest

        LabelMsg1.Text = _CpTd6033.GetDibMsg1()

        If _CpTd6033.Continue = 1 Then
            LabelContinue.Text = "연속 데이터 있음"
            ButtonNext.Enabled = True
        Else
            LabelContinue.Text = "연속 데이터 없음"
            ButtonNext.Enabled = False
        End If

        If result = 0 Then
            TextBoxTotal.Text = _CpTd6033.GetHeaderValue(3)
            TextBoxProfit.Text = _CpTd6033.GetHeaderValue(4)
            If CDbl(TextBoxProfit.Text) > 0 Then
                TextBoxProfit.ForeColor = Color.Red
            ElseIf CDbl(TextBoxProfit.Text) < 0 Then
                TextBoxProfit.ForeColor = Color.Blue
            Else
                TextBoxProfit.ForeColor = Color.Black
            End If
            TextBoxD2.Text = _CpTd6033.GetHeaderValue(9)

            For i As Integer = 0 To _CpTd6033.GetHeaderValue(7) - 1
                Dim rowOrder As DataRow = _Table.NewRow

                rowOrder(0) = _CpTd6033.GetDataValue(0, i)
                rowOrder(1) = _CpTd6033.GetDataValue(3, i)
                rowOrder(2) = _CpTd6033.GetDataValue(4, i)
                rowOrder(3) = _CpTd6033.GetDataValue(7, i)
                rowOrder(4) = _CpTd6033.GetDataValue(9, i)
                rowOrder(5) = _CpTd6033.GetDataValue(10, i)
                rowOrder(6) = (CDbl(_CpTd6033.GetDataValue(11, i)) / 100).ToString("0.00%")
                rowOrder(7) = _CpTd6033.GetDataValue(15, i)
                rowOrder(8) = CInt(_CpTd6033.GetDataValue(17, i))
                rowOrder(9) = _CpTd6033.GetDataValue(18, i)

                _Table.Rows.Add(rowOrder)
            Next

            DataGridView1.Refresh()
        End If

    End Sub

    Private Sub DataGridView1_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        Dim percent As String = DataGridView1.Rows(e.RowIndex).Cells("수익률").Value
        percent = percent.Replace("%", "")

        If CDbl(percent) > 0 Then
            DataGridView1.Rows(e.RowIndex).Cells("평가손익").Style.ForeColor = Color.Red
            DataGridView1.Rows(e.RowIndex).Cells("수익률").Style.ForeColor = Color.Red
        ElseIf CDbl(percent) < 0 Then
            DataGridView1.Rows(e.RowIndex).Cells("평가손익").Style.ForeColor = Color.Blue
            DataGridView1.Rows(e.RowIndex).Cells("수익률").Style.ForeColor = Color.Blue
        Else
            DataGridView1.Rows(e.RowIndex).Cells("평가손익").Style.ForeColor = Color.Black
            DataGridView1.Rows(e.RowIndex).Cells("수익률").Style.ForeColor = Color.Black
        End If
    End Sub

    Private Sub DataGridView1_DataBindingComplete(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles DataGridView1.DataBindingComplete
        DataGridView1.ClearSelection()
    End Sub

    Public Sub ReceivedStockTrade()
        Me.ButtonQuery_Click(Nothing, Nothing)
    End Sub

End Class