Public Class Form1102

    Private _parent As Main

    Public WithEvents _marketEye As CPSYSDIBLib.MarketEye
    Public WithEvents _stockCur As DSCBO1Lib.StockCur
    
    Dim _stockTable As DataTable = New DataTable

    Private Sub Form1102_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Unsubscribe()

        _parent.CloseStockSelector(Me)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        _parent.ShowHelp("1102")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        _parent.ShowHelp("11021")
    End Sub

    Private Sub Form1102_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub Form1102_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.KeyPreview = True

        _parent = Me.ParentForm

        _marketEye = New CPSYSDIBLib.MarketEye
        _stockCur = New DSCBO1Lib.StockCur

        _stockTable.Columns.Add("종목코드")
        _stockTable.Columns.Add("종목명")
        _stockTable.Columns.Add("시간")
        _stockTable.Columns.Add("현재가")
        _stockTable.Columns.Add("전일대비")
        _stockTable.Columns.Add("시가")
        _stockTable.Columns.Add("고가")
        _stockTable.Columns.Add("저가")
        _stockTable.Columns.Add("거래량")
        _stockTable.Columns.Add("거래대금")

        DataGridView1.DataSource = _stockTable
        DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Refresh()

        TextBoxName.Text = _parent.stockName
        TextBoxCode.Text = _parent.stockCode

        Me.Button5_Click(Button5, Nothing)
    End Sub

    Public Sub ChangedStockCode(ByVal code As String, ByVal name As String)
        TextBoxName.Text = name
        TextBoxCode.Text = code
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            If _stockTable.Rows.Count > 0 And DataGridView1.SelectedRows(0).Index < _stockTable.Rows.Count Then
                _stockTable.Rows.RemoveAt(DataGridView1.SelectedRows(0).Index)
                DataGridView1.Refresh()
            End If
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If _marketEye.GetDibStatus() = 1 Then
            Trace.TraceInformation("DibRq 요청 수신대기 중 입니다. 수신이 완료된 후 다시 호출 하십시오.")
            Exit Sub
        End If

        If _stockTable.Rows.Count <= 0 Then
            Return
        End If

        LabelMsg1.Text = ""
        
        Me.Unsubscribe()

        Dim items() As Integer = {0, 1, 2, 3, 4, 5, 6, 7, 10, 11, 17}
        _marketEye.SetInputValue(0, items)

        Dim sCodes(0 To _stockTable.Rows.Count - 1) As String

        For i As Integer = 0 To _stockTable.Rows.Count - 1
            sCodes(i) = _stockTable.Rows(i).Item("종목코드")
        Next i

        _marketEye.SetInputValue(1, sCodes)

        Dim result As Integer = -1
        result = _marketEye.BlockRequest

        LabelMsg1.Text = _marketEye.GetDibMsg1()

        If result = 0 Then
            For j As Integer = 0 To _marketEye.GetHeaderValue(2) - 1
                _stockTable.Rows(j).Item("종목코드") = _marketEye.GetDataValue(0, j)
                _stockTable.Rows(j).Item("종목명") = _marketEye.GetDataValue(10, j)
                _stockTable.Rows(j).Item("시간") = ClassUtil.ConvertToDateTime(_marketEye.GetDataValue(1, j))
                _stockTable.Rows(j).Item("현재가") = _marketEye.GetDataValue(4, j)
                _stockTable.Rows(j).Item("전일대비") = _marketEye.GetDataValue(3, j)
                _stockTable.Rows(j).Item("시가") = _marketEye.GetDataValue(5, j)
                _stockTable.Rows(j).Item("고가") = _marketEye.GetDataValue(6, j)
                _stockTable.Rows(j).Item("저가") = _marketEye.GetDataValue(7, j)
                _stockTable.Rows(j).Item("거래량") = _marketEye.GetDataValue(8, j)
                _stockTable.Rows(j).Item("거래대금") = _marketEye.GetDataValue(9, j)

                If _parent.GetRemainSB() > 0 Then
                    _stockCur.SetInputValue(0, _stockTable.Rows(j).Item(0))
                    _stockCur.Subscribe()
                End If
            Next

            DataGridView1.Refresh()

        End If
    End Sub

    Private Sub _stockCur_Received() Handles _stockCur.Received
        For i As Integer = 0 To _stockTable.Rows.Count - 1
            If _stockTable.Rows(i).Item(0) = _stockCur.GetHeaderValue(0) Then
                _stockTable.Rows(i).Item("현재가") = _stockCur.GetHeaderValue(13)
                _stockTable.Rows(i).Item("전일대비") = _stockCur.GetHeaderValue(2)
                _stockTable.Rows(i).Item("시간") = ClassUtil.ConvertToDateTime(_stockCur.GetHeaderValue(3))
                _stockTable.Rows(i).Item("고가") = _stockCur.GetHeaderValue(5)
                _stockTable.Rows(i).Item("저가") = _stockCur.GetHeaderValue(6)
                _stockTable.Rows(i).Item("거래량") = _stockCur.GetHeaderValue(9)

                Dim market As CPE_MARKET_KIND = _parent.GetStockMarketKind(_stockTable.Rows(i).Item(0))
                If market = CPE_MARKET_KIND.CPC_MARKET_KOSPI Then
                    _stockTable.Rows(i).Item("거래대금") = _stockCur.GetHeaderValue(10) * 10000
                ElseIf market = CPE_MARKET_KIND.CPC_MARKET_KOSDAQ Or market = CPE_MARKET_KIND.CPC_MARKET_FREEBOARD Then
                    _stockTable.Rows(i).Item("거래대금") = _stockCur.GetHeaderValue(10) * 1000
                Else
                    _stockTable.Rows(i).Item("거래대금") = _stockCur.GetHeaderValue(10)
                End If

                DataGridView1.Refresh()

                Exit For
            End If
        Next i

    End Sub

    Private Sub ButtonSelectCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSelectCode.Click
        _parent.ShowStockSelector(Me)
    End Sub

    Private Sub TextBoxCode_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBoxCode.TextChanged
        If TextBoxCode.Text.Length >= 7 Then
            TextBoxName.Text = _parent.FindStockName(TextBoxCode.Text.ToUpper)
            Dim bExist As Boolean = False

            For i As Integer = 0 To _stockTable.Rows.Count - 1
                If _stockTable.Rows(i).Item("종목코드") = TextBoxCode.Text Then
                    bExist = True
                    Exit For
                End If
            Next

            If bExist = False Then
                _stockTable.Rows.Add(TextBoxCode.Text.ToUpper(), TextBoxName.Text, "", "", "", "", "", "", "", "")
                DataGridView1.Refresh()

                Me.Button5_Click(Nothing, Nothing)
            End If
        End If
    End Sub

    Private Sub DataGridView1_DataBindingComplete(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles DataGridView1.DataBindingComplete
        DataGridView1.ClearSelection()
    End Sub

    Private Sub DataGridView1_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        If e.ColumnIndex = 0 Then
            DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        ElseIf e.ColumnIndex = 1 Then
            DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.Alignment = DataGridViewContentAlignment.MiddleLeft
        ElseIf e.ColumnIndex = 2 Then
            DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        End If

        If DataGridView1.Item(4, e.RowIndex).Value.ToString() <> "" Then
            If CDbl(DataGridView1.Item(4, e.RowIndex).Value) > 0 Then
                DataGridView1.Rows(e.RowIndex).Cells(3).Style.ForeColor = Color.Red
            ElseIf CDbl(DataGridView1.Item(4, e.RowIndex).Value) < 0 Then
                DataGridView1.Rows(e.RowIndex).Cells(3).Style.ForeColor = Color.Blue
            Else
                DataGridView1.Rows(e.RowIndex).Cells(3).Style.ForeColor = Color.Black
            End If
        End If
    End Sub

    Private Sub Unsubscribe()
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            _stockCur.SetInputValue(0, DataGridView1.Rows(i).Cells(0).Value)
            _stockCur.Unsubscribe()
        Next
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        _parent.ChangedStockCode(DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString())
    End Sub

End Class