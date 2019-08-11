Public Class Form1105
    Private _parent As Main

    Public WithEvents _StockWeek As DSCBO1Lib.StockWeek
    Public WithEvents _stockCur As DSCBO1Lib.StockCur

    Dim _DayTable As DataTable = New DataTable

    Private Sub Form1105_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Unsubscribe(TextBoxCode.Text)

        _parent.CloseStockSelector(Me)
    End Sub

    Private Sub Form1105_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub Form1105_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.KeyPreview = True

        _parent = Me.ParentForm

        _StockWeek = New DSCBO1Lib.StockWeek
        _stockCur = New DSCBO1Lib.StockCur

        _DayTable.Columns.Add("일자")
        _DayTable.Columns.Add("시가")
        _DayTable.Columns.Add("고가")
        _DayTable.Columns.Add("저가")
        _DayTable.Columns.Add("종가")
        _DayTable.Columns.Add("전일대비")
        _DayTable.Columns.Add("누적거래량")
        _DayTable.Columns.Add("외인보유")
        _DayTable.Columns.Add("외인전일대비")
        _DayTable.Columns.Add("외인비중")
        _DayTable.Columns.Add("등락률")
        _DayTable.Columns.Add("대비상태")
        _DayTable.Columns.Add("기관순매수")

        DataGridView1.DataSource = _DayTable
        DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Refresh()

        ButtonNext.Enabled = False

        TextBoxName.Text = _parent.stockName
        TextBoxCode.Text = _parent.stockCode
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        _parent.ShowHelp("1105")
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
        If _StockWeek.GetDibStatus() = 1 Then
            Trace.TraceInformation("DibRq 요청 수신대기 중 입니다. 수신이 완료된 후 다시 호출 하십시오.")
            Exit Sub
        End If

        LabelMsg1.Text = ""
        LabelMsg2.Text = ""
        LabelContinue.Text = ""

        _DayTable.Clear()
        DataGridView1.Refresh()

        ButtonNext.Enabled = False

        _StockWeek.SetInputValue(0, TextBoxCode.Text.ToUpper())

        Me.JustRequest()
    End Sub

    Private Sub ButtonNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonNext.Click
        Me.JustRequest()
    End Sub

    Private Sub JustRequest()
        If _StockWeek.GetDibStatus() = 1 Then
            Trace.TraceInformation("DibRq 요청 수신대기 중 입니다. 수신이 완료된 후 다시 호출 하십시오.")
            Exit Sub
        End If

        LabelMsg1.Text = ""
        LabelMsg2.Text = ""
        LabelContinue.Text = ""

        Dim result As Integer = -1
        result = _StockWeek.BlockRequest

        LabelMsg1.Text = _StockWeek.GetDibMsg1()
        LabelMsg2.Text = _StockWeek.GetDibMsg2()
        If _StockWeek.Continue = 1 Then
            LabelContinue.Text = "연속 데이터 있음"
            ButtonNext.Enabled = True
        Else
            LabelContinue.Text = "연속 데이터 없음"
            ButtonNext.Enabled = False
        End If

        If result = 0 Then
            For i As Integer = 0 To _StockWeek.GetHeaderValue(1) - 1
                Dim fieldCount = _StockWeek.Data
                Dim count As Integer = fieldCount.Count
                Dim row As DataRow = _DayTable.NewRow

                For j As Integer = 0 To count - 1
                    If j = 13 Then
                        Exit For
                    ElseIf j = 11 Then
                        If Chr(_StockWeek.GetDataValue(j, i)) = "1" Then
                            row(j) = "상한"
                        ElseIf Chr(_StockWeek.GetDataValue(j, i)) = "2" Then
                            row(j) = "상승"
                        ElseIf Chr(_StockWeek.GetDataValue(j, i)) = "3" Then
                            row(j) = "보합"
                        ElseIf Chr(_StockWeek.GetDataValue(j, i)) = "4" Then
                            row(j) = "하한"
                        ElseIf Chr(_StockWeek.GetDataValue(j, i)) = "5" Then
                            row(j) = "하락"
                        ElseIf Chr(_StockWeek.GetDataValue(j, i)) = "6" Then
                            row(j) = "기세상한"
                        ElseIf Chr(_StockWeek.GetDataValue(j, i)) = "7" Then
                            row(j) = "기세상승"
                        ElseIf Chr(_StockWeek.GetDataValue(j, i)) = "8" Then
                            row(j) = "기세하한"
                        ElseIf Chr(_StockWeek.GetDataValue(j, i)) = "9" Then
                            row(j) = "기세하락"
                        End If
                    ElseIf j = 0 Then
                        row(j) = ClassUtil.ConvertToDateTime(_StockWeek.GetDataValue(j, i))
                    Else
                        row(j) = _StockWeek.GetDataValue(j, i)
                    End If
                Next j

                _DayTable.Rows.Add(row)
            Next i

            DataGridView1.Refresh()
        End If

        If _parent.GetRemainSB() > 0 Then
            _stockCur.SetInputValue(0, TextBoxCode.Text.ToUpper())
            _stockCur.Subscribe()
        End If
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
        If e.ColumnIndex = 0 Or e.ColumnIndex = 11 Then
            DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            If e.ColumnIndex = 11 Then
                If DataGridView1.Item(e.ColumnIndex, e.RowIndex).Value.ToString() = "상한" Or DataGridView1.Item(e.ColumnIndex, e.RowIndex).Value.ToString() = "상승" Or DataGridView1.Item(e.ColumnIndex, e.RowIndex).Value.ToString() = "기세상한" Or DataGridView1.Item(e.ColumnIndex, e.RowIndex).Value.ToString() = "기세상승" Then
                    DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.ForeColor = Color.Red
                ElseIf DataGridView1.Item(e.ColumnIndex, e.RowIndex).Value.ToString() = "보합" Then
                    DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.ForeColor = Color.Black
                Else
                    DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.ForeColor = Color.Blue
                End If
            End If
        End If

        If DataGridView1.Item(5, e.RowIndex).Value > 0 Then
            DataGridView1.Rows(e.RowIndex).Cells(4).Style.ForeColor = Color.Red
        ElseIf DataGridView1.Item(5, e.RowIndex).Value < 0 Then
            DataGridView1.Rows(e.RowIndex).Cells(4).Style.ForeColor = Color.Blue
        Else
            DataGridView1.Rows(e.RowIndex).Cells(4).Style.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Unsubscribe(ByVal code As String)
        _stockCur.SetInputValue(0, code.ToUpper())
        _stockCur.Unsubscribe()
    End Sub

    Private Sub _stockCur_Received() Handles _stockCur.Received
        If TextBoxCode.Text.ToUpper <> _stockCur.GetHeaderValue(0) Then
            Exit Sub
        End If

        If _DayTable.Rows.Count <= 0 Then
            Exit Sub
        End If

        Dim row As DataRow = _DayTable.Rows(0)

        row(1) = _stockCur.GetHeaderValue(4)
        row(2) = _stockCur.GetHeaderValue(5)
        row(3) = _stockCur.GetHeaderValue(6)
        row(4) = _stockCur.GetHeaderValue(13)
        row(5) = _stockCur.GetHeaderValue(2)
        row(6) = _stockCur.GetHeaderValue(9)

        DataGridView1.Refresh()
    End Sub

End Class