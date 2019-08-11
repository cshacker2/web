
Public Class Form1101
    Private _parent As Main

    Public WithEvents _stockMst As DSCBO1Lib.StockMst
    Public WithEvents _stockCur As DSCBO1Lib.StockCur

    Dim _stockTable As DataTable = New DataTable

    Private Sub Form1101_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Unsubscribe(TextBoxCode.Text)

        _parent.CloseStockSelector(Me)
    End Sub

    Private Sub Form1101_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    
    Private Sub Form1101_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.KeyPreview = True

        _parent = Me.ParentForm
        _stockMst = New DSCBO1Lib.StockMst
        _stockCur = New DSCBO1Lib.StockCur

        _stockTable.Columns.Add("시간")
        _stockTable.Columns.Add("현재가")
        _stockTable.Columns.Add("전일대비")
        _stockTable.Columns.Add("시가")
        _stockTable.Columns.Add("고가")
        _stockTable.Columns.Add("저가")
        _stockTable.Columns.Add("거래량")
        _stockTable.Columns.Add("거래대금")
        _stockTable.Rows.Add("0", "0", "0", "0", "0", "0", "0", "0")

        DataGridView1.DataSource = _stockTable
        DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
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
        If _stockMst.GetDibStatus() = 1 Then
            Trace.TraceInformation("DibRq 요청 수신대기 중 입니다. 수신이 완료된 후 다시 호출 하십시오.")
            Exit Sub
        End If

        If TextBoxCode.Text.Length < 7 Then
            MsgBox("종목을 선택해주세요")
            Exit Sub
        End If

        LabelMsg1.Text = ""
        LabelMsg2.Text = ""
        
        _stockMst.SetInputValue(0, TextBoxCode.Text.ToUpper())
        _stockMst.Request()
    End Sub

    Private Sub _stockMst_Received_Received() Handles _stockMst.Received
        LabelMsg1.Text = _stockMst.GetDibMsg1()
        LabelMsg2.Text = _stockMst.GetDibMsg2()
        
        _stockTable.Clear()
        _stockTable.Rows.Add(ClassUtil.ConvertToDateTime(_stockMst.GetHeaderValue(4)), _stockMst.GetHeaderValue(11), _stockMst.GetHeaderValue(12), _stockMst.GetHeaderValue(13), _stockMst.GetHeaderValue(14), _stockMst.GetHeaderValue(15), _stockMst.GetHeaderValue(18), _stockMst.GetHeaderValue(19))

        DataGridView1.Refresh()

        ButtonReal.Text = "실시간(수신중)"
        _stockCur.SetInputValue(0, TextBoxCode.Text.ToUpper())
        _stockCur.Subscribe()
    End Sub

    Private Sub ButtonSelectCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSelectCode.Click
        _parent.ShowStockSelector(Me)
    End Sub

    Public Sub ChangedStockCode(ByVal code As String, ByVal name As String)
        Me.Unsubscribe(TextBoxCode.Text)

        TextBoxCode.Text = code
        TextBoxName.Text = name
    End Sub

    Private Sub ButtonReal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonReal.Click
        If _parent.GetRemainSB() <= 0 Then
            Return
        End If

        _stockCur.SetInputValue(0, TextBoxCode.Text.ToUpper())

        If ButtonReal.Text = "실시간(수신중)" Then
            ButtonReal.Text = "실시간(시작)"
            _stockCur.Unsubscribe()
        Else
            ButtonReal.Text = "실시간(수신중)"
            _stockCur.Subscribe()
        End If
    End Sub

    Private Sub _stockCur_Received() Handles _stockCur.Received
        If TextBoxCode.Text = _stockCur.GetHeaderValue(0) Then
            DataGridView1.Item(0, 0).Value = ClassUtil.ConvertToDateTime(_stockCur.GetHeaderValue(3))
            DataGridView1.Item(1, 0).Value = _stockCur.GetHeaderValue(13)
            DataGridView1.Item(2, 0).Value = _stockCur.GetHeaderValue(2)
            DataGridView1.Item(4, 0).Value = _stockCur.GetHeaderValue(5)
            DataGridView1.Item(5, 0).Value = _stockCur.GetHeaderValue(6)

            Dim market As CPE_MARKET_KIND = _parent.GetStockMarketKind(TextBoxCode.Text)

            DataGridView1.Item(6, 0).Value = _stockCur.GetHeaderValue(9)

            If market = CPE_MARKET_KIND.CPC_MARKET_KOSPI Then
                DataGridView1.Item(7, 0).Value = _stockCur.GetHeaderValue(10) * 10000
            ElseIf market = CPE_MARKET_KIND.CPC_MARKET_KOSDAQ Or market = CPE_MARKET_KIND.CPC_MARKET_FREEBOARD Then
                DataGridView1.Item(7, 0).Value = _stockCur.GetHeaderValue(10) * 1000
            Else
                DataGridView1.Item(7, 0).Value = _stockCur.GetHeaderValue(10)
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        _parent.ShowHelp("11011")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        _parent.ShowHelp("11012")
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
        If e.ColumnIndex = 0 Then
            DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        End If

        If DataGridView1.Item(2, e.RowIndex).Value > 0 Then
            DataGridView1.Rows(e.RowIndex).Cells(1).Style.ForeColor = Color.Red
        ElseIf DataGridView1.Item(2, e.RowIndex).Value < 0 Then
            DataGridView1.Rows(e.RowIndex).Cells(1).Style.ForeColor = Color.Blue
        Else
            DataGridView1.Rows(e.RowIndex).Cells(1).Style.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Unsubscribe(ByVal code As String)
        _stockCur.SetInputValue(0, code.ToUpper())
        _stockCur.Unsubscribe()
    End Sub

End Class