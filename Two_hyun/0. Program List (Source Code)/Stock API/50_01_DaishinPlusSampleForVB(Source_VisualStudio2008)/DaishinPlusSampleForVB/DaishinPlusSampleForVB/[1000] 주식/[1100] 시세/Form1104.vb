Public Class Form1104
    Private _parent As Main

    Public WithEvents _StockBid As DSCBO1Lib.StockBid
    Public WithEvents _stockCur As DSCBO1Lib.StockCur

    Dim _timeTable As DataTable = New DataTable

    Private Sub Form1104_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Unsubscribe(TextBoxCode.Text)

        _parent.CloseStockSelector(Me)
    End Sub

    Private Sub Form1104_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.KeyPreview = True

        _parent = Me.ParentForm

        _StockBid = New DSCBO1Lib.StockBid
        _stockCur = New DSCBO1Lib.StockCur

        _timeTable.Columns.Add("시간")
        _timeTable.Columns.Add("현재가")
        _timeTable.Columns.Add("전일대비")
        _timeTable.Columns.Add("매도호가")
        _timeTable.Columns.Add("매수호가")
        _timeTable.Columns.Add("거래량")
        _timeTable.Columns.Add("순간체결량")
        _timeTable.Columns.Add("체결상태")
        _timeTable.Columns.Add("체결강도")
        _timeTable.Columns.Add("장구분")

        DataGridView1.DataSource = _timeTable
        DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Refresh()

        ComboBoxMethod.SelectedIndex = 0

        ButtonNext.Enabled = False

        TextBoxName.Text = _parent.stockName
        TextBoxCode.Text = _parent.stockCode
    End Sub

    Private Sub Form1104_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        _parent.ShowHelp("1104")
    End Sub

    Public Sub ChangedStockCode(ByVal code As String, ByVal name As String)
        Me.Unsubscribe(TextBoxCode.Text)

        TextBoxCode.Text = code
        TextBoxName.Text = name
    End Sub

    Private Sub ButtonQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonQuery.Click
        Me.Request()
    End Sub

    Private Sub Request()
        If TextBoxCode.Text.Length < 7 Then
            Exit Sub
        End If

        LabelMsg1.Text = ""
        LabelMsg2.Text = ""
        LabelContinue.Text = ""

        _timeTable.Clear()
        DataGridView1.Refresh()

        ButtonNext.Enabled = False

        _StockBid.SetInputValue(0, TextBoxCode.Text.ToUpper())
        _StockBid.SetInputValue(2, 20)
        If ComboBoxMethod.SelectedIndex = 0 Then
            _StockBid.SetInputValue(3, Asc("C"))
        Else
            _StockBid.SetInputValue(3, Asc("H"))
        End If

        Me.JustRequest()
    End Sub

    Private Sub ComboBoxMethod_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxMethod.SelectedIndexChanged
        Me.Request()
    End Sub

    Private Sub ButtonNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonNext.Click
        Me.JustRequest()
    End Sub

    Private Sub JustRequest()
        If _StockBid.GetDibStatus() = 1 Then
            Trace.TraceInformation("DibRq 요청 수신대기 중 입니다. 수신이 완료된 후 다시 호출 하십시오.")
            Exit Sub
        End If

        LabelMsg1.Text = ""
        LabelMsg2.Text = ""
        LabelContinue.Text = ""

        Dim result As Integer = -1
        result = _StockBid.BlockRequest

        LabelMsg1.Text = _StockBid.GetDibMsg1()
        LabelMsg2.Text = _StockBid.GetDibMsg2()
        If _StockBid.Continue = 1 Then
            LabelContinue.Text = "연속 데이터 있음"
            ButtonNext.Enabled = True
        Else
            LabelContinue.Text = "연속 데이터 없음"
            ButtonNext.Enabled = False
        End If

        If result = 0 Then
            LabelSell.Text = _StockBid.GetHeaderValue(3)
            LabelBuy.Text = _StockBid.GetHeaderValue(4)

            For i As Integer = 0 To _StockBid.GetHeaderValue(2) - 1
                If _StockBid.GetDataValue(6, i) <> 0 Then
                    Dim row As DataRow = _timeTable.NewRow

                    row(0) = ClassUtil.ConvertToDateTime(_StockBid.GetDataValue(9, i))
                    row(1) = _StockBid.GetDataValue(4, i)
                    row(2) = _StockBid.GetDataValue(1, i)
                    row(3) = _StockBid.GetDataValue(2, i)
                    row(4) = _StockBid.GetDataValue(3, i)
                    row(5) = _StockBid.GetDataValue(5, i)
                    row(6) = _StockBid.GetDataValue(6, i)

                    If Chr(_StockBid.GetDataValue(7, i)) = "1" Then
                        row(7) = "매수"
                    Else
                        row(7) = "매도"
                    End If

                    row(8) = (CDbl(_StockBid.GetDataValue(8, i)) / 100).ToString("0.00%")
                    
                    If Chr(_StockBid.GetDataValue(10, i)) = "1" Then
                        row(9) = "동시호가(예상)"
                        row(4) = "* " + _StockBid.GetDataValue(4, i).ToString
                    Else
                        row(9) = "장중(체결)"
                        row(4) = _StockBid.GetDataValue(4, i)
                    End If

                    _timeTable.Rows.Add(row)
                End If
            Next i

            DataGridView1.Refresh()
        End If

        If _parent.GetRemainSB() > 0 Then
            _stockCur.SetInputValue(0, TextBoxCode.Text.ToUpper())
            _stockCur.Subscribe()
        End If
    End Sub

    Private Sub _stockCur_Received() Handles _stockCur.Received
        If TextBoxCode.Text.ToUpper <> _stockCur.GetHeaderValue(0) Then
            Exit Sub
        End If

        Dim row As DataRow = _timeTable.NewRow

        row(0) = ClassUtil.ConvertToDateTime(_stockCur.GetHeaderValue(18))
        row(1) = _stockCur.GetHeaderValue(13)
        row(2) = _stockCur.GetHeaderValue(2)

        row(3) = _stockCur.GetHeaderValue(7)
        row(4) = _stockCur.GetHeaderValue(8)
        row(5) = _stockCur.GetHeaderValue(9)
        row(6) = _stockCur.GetHeaderValue(17)
        
        If ComboBoxMethod.SelectedIndex = 0 Then                    '체결가 비교
            If Chr(_stockCur.GetHeaderValue(14)) = "1" Then
                row(7) = "매수"
            Else
                row(7) = "매도"
            End If

            LabelSell.Text = _stockCur.GetHeaderValue(15)
            LabelBuy.Text = _stockCur.GetHeaderValue(16)
        Else                                                        '호가비교
            If _stockCur.GetHeaderValue(13) <= _stockCur.GetHeaderValue(8) Then
                row(7) = "매도"
            ElseIf _stockCur.GetHeaderValue(13) >= _stockCur.GetHeaderValue(7) Then
                row(7) = "매수"
            End If

            LabelSell.Text = _stockCur.GetHeaderValue(27)
            LabelBuy.Text = _stockCur.GetHeaderValue(28)
        End If

        If CInt(LabelBuy.Text) = 0 And CInt(LabelSell.Text) = 0 Then
            row(8) = "0%"
        ElseIf CInt(LabelSell.Text) = 0 Then
            row(8) = "500%"
        Else
            row(8) = (CDbl(LabelBuy.Text) / CDbl(LabelSell.Text)).ToString("0.00%")
        End If

        If Chr(_stockCur.GetHeaderValue(19)) = "1" Then
            row(9) = "동시호가(예상)"
        Else
            row(9) = "장중(체결)"
        End If

        _timeTable.Rows.InsertAt(row, 0)

        If CheckBoxTop.Checked Then
            DataGridView1.FirstDisplayedScrollingRowIndex = 0
            DataGridView1.ClearSelection()
            DataGridView1.Rows(0).Selected = True
        End If

        DataGridView1.Refresh()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        _parent.ShowStockSelector(Me)
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

    Private Sub DataGridView1_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        If e.ColumnIndex = 0 Or e.ColumnIndex = 7 Or e.ColumnIndex = 9 Or e.ColumnIndex = 10 Then
            If e.ColumnIndex = 7 Then
                If DataGridView1.Item(e.ColumnIndex, e.RowIndex).Value.ToString() = "매수" Then
                    DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.ForeColor = Color.Red
                Else
                    DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.ForeColor = Color.Blue
                End If
            End If
        ElseIf e.ColumnIndex = 2 Then
            If e.Value > 0 Then
                DataGridView1.Rows(e.RowIndex).Cells(1).Style.ForeColor = Color.Red
            ElseIf e.Value < 0 Then
                DataGridView1.Rows(e.RowIndex).Cells(1).Style.ForeColor = Color.Blue
            Else
                DataGridView1.Rows(e.RowIndex).Cells(1).Style.ForeColor = Color.Black
            End If
        End If
    End Sub

    Private Sub Unsubscribe(ByVal code As String)
        _stockCur.SetInputValue(0, code.ToUpper())
        _stockCur.Unsubscribe()
    End Sub

End Class