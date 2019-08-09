Public Class Form1106

    Private _parent As Main

    Public WithEvents _StockJpbid2 As DSCBO1Lib.StockJpbid2
    Public WithEvents _StockJpbid As DSCBO1Lib.StockJpbid

    Dim _QuoteTable As DataTable = New DataTable

    Private _sender As Object

    Public Sub SetSender(ByVal sender As Object)
        _sender = sender
    End Sub

    Private Sub Form1106_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Unsubscribe(TextBoxCode.Text)

        _parent.CloseStockSelector(Me)
    End Sub

    Private Sub Form1106_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub Form1106_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.KeyPreview = True

        _sender = Nothing

        _parent = Me.ParentForm

        _StockJpbid2 = New DSCBO1Lib.StockJpbid2
        _StockJpbid = New DSCBO1Lib.StockJpbid

        _QuoteTable.Columns.Add("매도잔량")
        _QuoteTable.Columns.Add("호가")
        _QuoteTable.Columns.Add("매수잔량")

        For i As Integer = 0 To 19
            _QuoteTable.Rows.Add("", "", "")
        Next i

        DataGridView1.DataSource = _QuoteTable
        DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Refresh()

        TextBoxName.Text = _parent.stockName
        TextBoxCode.Text = _parent.stockCode
    End Sub

    Private Sub ButtonRQ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRQ.Click
        Me.Request()
    End Sub

    Private Sub Request()
        If _StockJpbid2.GetDibStatus() = 1 Then
            Trace.TraceInformation("DibRq 요청 수신대기 중 입니다. 수신이 완료된 후 다시 호출 하십시오.")
            Exit Sub
        End If

        If TextBoxCode.Text.Length < 7 Then
            MsgBox("종목을 선택해주세요")
            Exit Sub
        End If

        _QuoteTable.Clear()
        For i As Integer = 0 To 19
            _QuoteTable.Rows.Add("", "", "")
        Next i

        DataGridView1.Refresh()

        _StockJpbid2.SetInputValue(0, TextBoxCode.Text.ToUpper())

        Dim result As Integer = -1
        result = _StockJpbid2.BlockRequest

        If result = 0 Then
            LabelTime.Text = ClassUtil.ConvertToDateTime(_StockJpbid2.GetHeaderValue(3))
            LabelSell.Text = _StockJpbid2.GetHeaderValue(4)
            LabelBuy.Text = _StockJpbid2.GetHeaderValue(6)

            Dim IndexSell As Integer = 9
            Dim IndexBuy As Integer = 10

            For i As Integer = 0 To _StockJpbid2.GetHeaderValue(1) - 1
                _QuoteTable.Rows(IndexSell).Item("호가") = _StockJpbid2.GetDataValue(0, i)
                _QuoteTable.Rows(IndexBuy).Item("호가") = _StockJpbid2.GetDataValue(1, i)

                _QuoteTable.Rows(IndexSell).Item("매도잔량") = _StockJpbid2.GetDataValue(2, i)
                _QuoteTable.Rows(IndexBuy).Item("매수잔량") = _StockJpbid2.GetDataValue(3, i)

                IndexSell -= 1
                IndexBuy += 1
            Next i

            DataGridView1.Refresh()

            If _parent.GetRemainSB() > 0 Then
                _StockJpbid.SetInputValue(0, TextBoxCode.Text.ToUpper())
                _StockJpbid.SubscribeLatest()
            End If
        End If
    End Sub

    Private Sub ButtonSelectCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSelectCode.Click
        _parent.ShowStockSelector(Me)
    End Sub

    Public Sub ChangedStockCode(ByVal code As String, ByVal name As String)
        Me.Unsubscribe(TextBoxCode.Text)

        TextBoxCode.Text = code
        TextBoxName.Text = name
    End Sub

    Private Sub ButtonHelpRQ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHelpRQ.Click
        _parent.ShowHelp("11061")
    End Sub

    Private Sub ButtonHelpSB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHelpSB.Click
        _parent.ShowHelp("11062")
    End Sub

    Private Sub TextBoxCode_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBoxCode.TextChanged
        If TextBoxCode.Text.Length >= 7 Then
            TextBoxName.Text = _parent.FindStockName(TextBoxCode.Text.ToUpper)
            Me.Request()
        End If
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = DataGridView1.SelectedRows(0)
            _parent.ChangedStockQuote(row.Cells("호가").Value)
        End If
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = DataGridView1.SelectedRows(0)
            _parent.ChangedStockQuote(row.Cells("호가").Value)
            Me.Close()
        End If
    End Sub

    Private Sub DataGridView1_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        If e.RowIndex >= 0 And e.RowIndex <= 9 And (e.ColumnIndex = 0 Or e.ColumnIndex = 1) Then
            DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.BackColor = Color.FromArgb(217, 236, 255)
        ElseIf e.RowIndex >= 10 And e.RowIndex <= 19 And (e.ColumnIndex = 1 Or e.ColumnIndex = 2) Then
            DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.BackColor = Color.FromArgb(255, 230, 230)
        End If

        If e.ColumnIndex = 1 Then
            DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Else
            DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.Alignment = DataGridViewContentAlignment.MiddleRight
        End If
    End Sub

    Private Sub DataGridView1_DataBindingComplete(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles DataGridView1.DataBindingComplete
        DataGridView1.ClearSelection()
    End Sub

    Private Sub _StockJpbid_Received() Handles _StockJpbid.Received
        If TextBoxCode.Text.ToUpper <> _StockJpbid.GetHeaderValue(0) Then
            Exit Sub
        End If

        LabelTime.Text = ClassUtil.ConvertToDateTime(_StockJpbid.GetHeaderValue(1))
        LabelSell.Text = _StockJpbid.GetHeaderValue(23)
        LabelBuy.Text = _StockJpbid.GetHeaderValue(24)

        _QuoteTable.Rows(9).Item("호가") = _StockJpbid.GetHeaderValue(3)
        _QuoteTable.Rows(10).Item("호가") = _StockJpbid.GetHeaderValue(4)
        _QuoteTable.Rows(9).Item("매도잔량") = _StockJpbid.GetHeaderValue(5)
        _QuoteTable.Rows(10).Item("매수잔량") = _StockJpbid.GetHeaderValue(6)

        _QuoteTable.Rows(8).Item("호가") = _StockJpbid.GetHeaderValue(7)
        _QuoteTable.Rows(11).Item("호가") = _StockJpbid.GetHeaderValue(8)
        _QuoteTable.Rows(8).Item("매도잔량") = _StockJpbid.GetHeaderValue(9)
        _QuoteTable.Rows(11).Item("매수잔량") = _StockJpbid.GetHeaderValue(10)

        _QuoteTable.Rows(7).Item("호가") = _StockJpbid.GetHeaderValue(11)
        _QuoteTable.Rows(12).Item("호가") = _StockJpbid.GetHeaderValue(12)
        _QuoteTable.Rows(7).Item("매도잔량") = _StockJpbid.GetHeaderValue(13)
        _QuoteTable.Rows(12).Item("매수잔량") = _StockJpbid.GetHeaderValue(14)

        _QuoteTable.Rows(6).Item("호가") = _StockJpbid.GetHeaderValue(15)
        _QuoteTable.Rows(13).Item("호가") = _StockJpbid.GetHeaderValue(16)
        _QuoteTable.Rows(6).Item("매도잔량") = _StockJpbid.GetHeaderValue(17)
        _QuoteTable.Rows(13).Item("매수잔량") = _StockJpbid.GetHeaderValue(18)

        _QuoteTable.Rows(5).Item("호가") = _StockJpbid.GetHeaderValue(19)
        _QuoteTable.Rows(14).Item("호가") = _StockJpbid.GetHeaderValue(20)
        _QuoteTable.Rows(5).Item("매도잔량") = _StockJpbid.GetHeaderValue(21)
        _QuoteTable.Rows(14).Item("매수잔량") = _StockJpbid.GetHeaderValue(22)

        _QuoteTable.Rows(4).Item("호가") = _StockJpbid.GetHeaderValue(27)
        _QuoteTable.Rows(15).Item("호가") = _StockJpbid.GetHeaderValue(28)
        _QuoteTable.Rows(4).Item("매도잔량") = _StockJpbid.GetHeaderValue(29)
        _QuoteTable.Rows(15).Item("매수잔량") = _StockJpbid.GetHeaderValue(30)

        _QuoteTable.Rows(3).Item("호가") = _StockJpbid.GetHeaderValue(31)
        _QuoteTable.Rows(16).Item("호가") = _StockJpbid.GetHeaderValue(32)
        _QuoteTable.Rows(3).Item("매도잔량") = _StockJpbid.GetHeaderValue(33)
        _QuoteTable.Rows(16).Item("매수잔량") = _StockJpbid.GetHeaderValue(34)

        _QuoteTable.Rows(2).Item("호가") = _StockJpbid.GetHeaderValue(35)
        _QuoteTable.Rows(17).Item("호가") = _StockJpbid.GetHeaderValue(36)
        _QuoteTable.Rows(2).Item("매도잔량") = _StockJpbid.GetHeaderValue(37)
        _QuoteTable.Rows(17).Item("매수잔량") = _StockJpbid.GetHeaderValue(38)

        _QuoteTable.Rows(1).Item("호가") = _StockJpbid.GetHeaderValue(39)
        _QuoteTable.Rows(18).Item("호가") = _StockJpbid.GetHeaderValue(40)
        _QuoteTable.Rows(1).Item("매도잔량") = _StockJpbid.GetHeaderValue(41)
        _QuoteTable.Rows(18).Item("매수잔량") = _StockJpbid.GetHeaderValue(42)

        _QuoteTable.Rows(0).Item("호가") = _StockJpbid.GetHeaderValue(43)
        _QuoteTable.Rows(19).Item("호가") = _StockJpbid.GetHeaderValue(44)
        _QuoteTable.Rows(0).Item("매도잔량") = _StockJpbid.GetHeaderValue(45)
        _QuoteTable.Rows(19).Item("매수잔량") = _StockJpbid.GetHeaderValue(46)
    End Sub

    Private Sub Unsubscribe(ByVal code As String)
        _StockJpbid.SetInputValue(0, code.ToUpper())
        _StockJpbid.Unsubscribe()
    End Sub

End Class