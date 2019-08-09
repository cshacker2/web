Public Class Form1402
    Private _parent As Main

    Dim _CpTd0732 As New CPTRADELib.CpTd0732

    Dim _Table1 As DataTable = New DataTable
    Dim _Table2 As DataTable = New DataTable

    Private Sub Form1402_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub Form1402_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.KeyPreview = True

        _parent = Me.ParentForm

        _Table1.Columns.Add("장내현금매도")
        _Table1.Columns.Add("장내현금매수")
        _Table1.Columns.Add("현금수수료")
        _Table1.Columns.Add("현금제세금")
        _Table1.Columns.Add("현금정산금")
        _Table1.Columns.Add("현금거래세")

        _Table2.Columns.Add("장내현금매도")
        _Table2.Columns.Add("장내현금매수")
        _Table2.Columns.Add("현금수수료")
        _Table2.Columns.Add("현금제세금")
        _Table2.Columns.Add("현금정산금")
        _Table2.Columns.Add("현금거래세")

        DataGridView1.DataSource = _Table1
        DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Refresh()

        DataGridView2.DataSource = _Table2
        DataGridView2.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridView2.AllowUserToResizeRows = False
        DataGridView2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView2.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView2.Refresh()

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

    Private Sub ButtonHelp1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHelp1.Click
        _parent.ShowHelp("1402")
    End Sub

    Private Sub Request()
        If _CpTd0732.GetDibStatus() = 1 Then
            Trace.TraceInformation("DibRq 요청 수신대기 중 입니다. 수신이 완료된 후 다시 호출 하십시오.")
            Exit Sub
        End If

        _Table1.Clear()
        DataGridView1.Refresh()

        _Table2.Clear()
        DataGridView2.Refresh()

        _CpTd0732.SetInputValue(0, TextBoxAccountNo1.Text + TextBoxAccountNo2.Text)
        _CpTd0732.SetInputValue(1, ComboBoxAccountKind.SelectedItem)

        LabelMsg1.Text = ""

        TextBoxTotal.Text = ""
        TextBoxNot.Text = ""
        LabelD1.Text = ""
        LabelD2.Text = ""
        TextBoxD1.Text = ""
        TextBoxD2.Text = ""

        Dim result As Integer = -1
        result = _CpTd0732.BlockRequest

        LabelMsg1.Text = _CpTd0732.GetDibMsg1()

        If result = 0 Then
            TextBoxTotal.Text = _CpTd0732.GetHeaderValue(3)
            TextBoxNot.Text = _CpTd0732.GetHeaderValue(4)
            LabelD1.Text = ClassUtil.ConvertToDateTime(_CpTd0732.GetHeaderValue(63))
            LabelD2.Text = ClassUtil.ConvertToDateTime(_CpTd0732.GetHeaderValue(65))
            TextBoxD1.Text = _CpTd0732.GetHeaderValue(64)
            TextBoxD2.Text = _CpTd0732.GetHeaderValue(66)

            Dim row1 As DataRow = _Table1.NewRow

            row1(0) = _CpTd0732.GetHeaderValue(5)
            row1(1) = _CpTd0732.GetHeaderValue(6)
            row1(2) = _CpTd0732.GetHeaderValue(11)
            row1(3) = _CpTd0732.GetHeaderValue(12)
            row1(4) = _CpTd0732.GetHeaderValue(13)
            row1(5) = _CpTd0732.GetHeaderValue(31)

            _Table1.Rows.Add(row1)
            
            DataGridView1.Refresh()

            Dim row2 As DataRow = _Table2.NewRow

            row2(0) = _CpTd0732.GetHeaderValue(34)
            row2(1) = _CpTd0732.GetHeaderValue(35)
            row2(2) = _CpTd0732.GetHeaderValue(40)
            row2(3) = _CpTd0732.GetHeaderValue(41)
            row2(4) = _CpTd0732.GetHeaderValue(42)
            row2(5) = _CpTd0732.GetHeaderValue(60)

            _Table2.Rows.Add(row2)

            DataGridView2.Refresh()
        End If
    End Sub

    Private Sub DataGridView1_DataBindingComplete(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles DataGridView1.DataBindingComplete
        DataGridView1.ClearSelection()
    End Sub

    Private Sub DataGridView2_DataBindingComplete(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles DataGridView2.DataBindingComplete
        DataGridView2.ClearSelection()
    End Sub

    Public Sub ReceivedStockTrade()
        Me.ButtonQuery_Click(Nothing, Nothing)
    End Sub

End Class