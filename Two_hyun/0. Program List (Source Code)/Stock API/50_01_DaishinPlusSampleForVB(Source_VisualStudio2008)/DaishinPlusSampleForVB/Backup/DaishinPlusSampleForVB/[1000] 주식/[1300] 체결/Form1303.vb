Public Class Form1303
    Private _parent As Main

    Dim _CpTd5339 As New CPTRADELib.CpTd5339

    Dim _Table As DataTable = New DataTable

    Private Sub Form1303_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        _parent.CloseStockSelector(Me)
    End Sub

    Private Sub Form1303_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub Form1303_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.KeyPreview = True

        _parent = Me.ParentForm

        ButtonNext.Enabled = False

        _Table.Columns.Add("주문번호")
        _Table.Columns.Add("원주문번호")
        _Table.Columns.Add("종목명")
        _Table.Columns.Add("주문구분내용")
        _Table.Columns.Add("주문수량")
        _Table.Columns.Add("주문단가")
        _Table.Columns.Add("체결수량")
        _Table.Columns.Add("정정취소가능수량")
        _Table.Columns.Add("매매")
        _Table.Columns.Add("구분")

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

        TextBoxName.Text = _parent.stockName
        TextBoxCode.Text = _parent.stockCode

        ComboBoxQueryKind.SelectedIndex = 1
    End Sub

    Private Sub ComboBoxAccountKind_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxAccountKind.SelectedIndexChanged
        If TextBoxCode.Text.Length >= 7 Then
            _parent.ChangedAccountKind(ComboBoxAccountKind.SelectedItem)
            Me.Request(True)
        End If
    End Sub

    Private Sub ButtonQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonQuery.Click
        If ComboBoxQueryKind.SelectedIndex = 1 Then
            Me.Request(True)
        Else
            Me.Request(False)
        End If
    End Sub

    Private Sub ButtonHelp1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHelp1.Click
        _parent.ShowHelp("1303")
    End Sub

    Private Sub Request(ByVal bEach As Boolean)
        If _CpTd5339.GetDibStatus() = 1 Then
            Trace.TraceInformation("DibRq 요청 수신대기 중 입니다. 수신이 완료된 후 다시 호출 하십시오.")
            Exit Sub
        End If

        If bEach Then
            If TextBoxCode.Text.Length < 7 Then
                Exit Sub
            End If
        End If

        _Table.Clear()

        _CpTd5339.SetInputValue(0, TextBoxAccountNo1.Text + TextBoxAccountNo2.Text)
        _CpTd5339.SetInputValue(1, ComboBoxAccountKind.SelectedItem)
        If bEach Then
            _CpTd5339.SetInputValue(3, TextBoxCode.Text.ToUpper())
        Else
            _CpTd5339.SetInputValue(3, "")
        End If

        _CpTd5339.SetInputValue(5, "1")
        _CpTd5339.SetInputValue(7, 20)

        ButtonNext.Enabled = False

        Me.JustRequest()
    End Sub

    Private Sub JustRequest()
        LabelMsg1.Text = ""
        LabelContinue.Text = ""

        Dim result As Integer = -1
        result = _CpTd5339.BlockRequest

        LabelMsg1.Text = _CpTd5339.GetDibMsg1()

        If _CpTd5339.Continue = 1 Then
            LabelContinue.Text = "연속 데이터 있음"
            ButtonNext.Enabled = True
        Else
            LabelContinue.Text = "연속 데이터 없음"
            ButtonNext.Enabled = False
        End If

        If result = 0 Then
            For i As Integer = 0 To _CpTd5339.GetHeaderValue(5) - 1
                Dim rowOrder As DataRow = _Table.NewRow

                rowOrder(0) = _CpTd5339.GetDataValue(1, i)
                rowOrder(1) = _CpTd5339.GetDataValue(2, i)
                rowOrder(2) = _CpTd5339.GetDataValue(4, i)
                rowOrder(3) = _CpTd5339.GetDataValue(5, i)
                rowOrder(4) = _CpTd5339.GetDataValue(6, i)
                rowOrder(5) = _CpTd5339.GetDataValue(7, i)
                rowOrder(6) = _CpTd5339.GetDataValue(8, i)
                rowOrder(7) = _CpTd5339.GetDataValue(11, i)
                If _CpTd5339.GetDataValue(13, i) = "1" Then
                    rowOrder(8) = "매도"
                Else
                    rowOrder(8) = "매수"
                End If

                If _CpTd5339.GetDataValue(21, i) = "01" Then
                    rowOrder(9) = "보통"
                ElseIf _CpTd5339.GetDataValue(21, i) = "03" Then
                    rowOrder(9) = "시장가"
                ElseIf _CpTd5339.GetDataValue(21, i) = "05" Then
                    rowOrder(9) = "조건부지정가"
                ElseIf _CpTd5339.GetDataValue(21, i) = "12" Then
                    rowOrder(9) = "최유리지정가"
                ElseIf _CpTd5339.GetDataValue(21, i) = "13" Then
                    rowOrder(9) = "최우선지정가"
                End If

                _Table.Rows.Add(rowOrder)
                DataGridView1.Refresh()
            Next
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

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = DataGridView1.SelectedRows(0)
            _parent.ChangedStockNoneTradeNo(row.Cells(0).Value, row.Cells(7).Value)
        End If
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = DataGridView1.SelectedRows(0)
            _parent.ChangedStockNoneTradeNo(row.Cells(0).Value, row.Cells(7).Value)
            Me.Close()
        End If
    End Sub

    Private Sub DataGridView1_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        If DataGridView1.Item("매매", e.RowIndex).Value.ToString().Contains("매수") Then
            DataGridView1.Rows(e.RowIndex).Cells("매매").Style.ForeColor = Color.Red
        Else
            DataGridView1.Rows(e.RowIndex).Cells("매매").Style.ForeColor = Color.Blue
        End If
    End Sub

    Private Sub ButtonNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonNext.Click
        Me.JustRequest()
    End Sub

    Private Sub ComboBoxQueryKind_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxQueryKind.SelectedIndexChanged
        If ComboBoxQueryKind.SelectedIndex = 1 Then
            Me.Request(True)
        Else
            Me.Request(False)
        End If
    End Sub

    Public Sub ReceivedStockTrade()
        Me.ButtonQuery_Click(Nothing, Nothing)
    End Sub

End Class