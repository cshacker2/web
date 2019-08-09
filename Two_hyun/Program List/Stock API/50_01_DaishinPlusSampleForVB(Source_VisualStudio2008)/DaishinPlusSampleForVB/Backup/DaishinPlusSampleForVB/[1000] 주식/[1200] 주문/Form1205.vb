Public Class Form1205
    Private _parent As Main

    Dim _CpTd9065 As New CPTRADELib.CpTd9065

    Dim _Table As DataTable = New DataTable

    Private Sub Form1205_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        _parent.CloseStockSelector(Me)
    End Sub

    Private Sub Form1205_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub Form1205_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.KeyPreview = True

        _parent = Me.ParentForm

        ButtonNext.Enabled = False

        _Table.Columns.Add("예약번호")
        _Table.Columns.Add("처리상태")
        _Table.Columns.Add("시장구분")
        _Table.Columns.Add("주문구분")
        _Table.Columns.Add("종목명")
        _Table.Columns.Add("주문수량")
        _Table.Columns.Add("주문단가")
        _Table.Columns.Add("주문호가구분")
        _Table.Columns.Add("입력매체")
        _Table.Columns.Add("주문번호")
        _Table.Columns.Add("거부내용")

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

    Private Sub ButtonHelp1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHelp1.Click
        _parent.ShowHelp("1205")
    End Sub

    Private Sub Request()
        If _CpTd9065.GetDibStatus() = 1 Then
            Trace.TraceInformation("DibRq 요청 수신대기 중 입니다. 수신이 완료된 후 다시 호출 하십시오.")
            Exit Sub
        End If

        _Table.Clear()
        DataGridView1.Refresh()

        _CpTd9065.SetInputValue(0, TextBoxAccountNo1.Text + TextBoxAccountNo2.Text)
        _CpTd9065.SetInputValue(1, ComboBoxAccountKind.SelectedItem)
        _CpTd9065.SetInputValue(2, 20)

        ButtonNext.Enabled = False

        Me.JustRequest()
    End Sub

    Private Sub JustRequest()
        LabelMsg1.Text = ""
        LabelContinue.Text = ""

        Dim result As Integer = -1
        result = _CpTd9065.BlockRequest

        LabelMsg1.Text = _CpTd9065.GetDibMsg1()

        If _CpTd9065.Continue = 1 Then
            LabelContinue.Text = "연속 데이터 있음"
            ButtonNext.Enabled = True
        Else
            LabelContinue.Text = "연속 데이터 없음"
            ButtonNext.Enabled = False
        End If

        If result = 0 Then
            For i As Integer = 0 To _CpTd9065.GetHeaderValue(4) - 1
                Dim rowOrder As DataRow = _Table.NewRow

                rowOrder(0) = _CpTd9065.GetDataValue(6, i)
                rowOrder(1) = _CpTd9065.GetDataValue(12, i)
                rowOrder(2) = _CpTd9065.GetDataValue(0, i)
                rowOrder(3) = _CpTd9065.GetDataValue(1, i)
                rowOrder(4) = _CpTd9065.GetDataValue(8, i)
                rowOrder(5) = _CpTd9065.GetDataValue(3, i)
                rowOrder(6) = _CpTd9065.GetDataValue(9, i)
                rowOrder(7) = _CpTd9065.GetDataValue(4, i)
                rowOrder(8) = _CpTd9065.GetDataValue(5, i)
                rowOrder(9) = _CpTd9065.GetDataValue(11, i)
                rowOrder(10) = _CpTd9065.GetDataValue(14, i)

                _Table.Rows.Add(rowOrder)
            Next

            DataGridView1.Refresh()
        End If

    End Sub

    Private Sub DataGridView1_DataBindingComplete(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles DataGridView1.DataBindingComplete
        DataGridView1.ClearSelection()
    End Sub

    Private Sub ButtonNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonNext.Click
        Me.JustRequest()
    End Sub

    Public Sub ReceivedStockReservedOrder()
        Me.ButtonQuery_Click(Nothing, Nothing)
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = DataGridView1.SelectedRows(0)
            _parent.ChangedStockReservedOrderNo(row.Cells("예약번호").Value)
        End If
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = DataGridView1.SelectedRows(0)
            _parent.ChangedStockReservedOrderNo(row.Cells("예약번호").Value)
            Me.Close()
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

End Class