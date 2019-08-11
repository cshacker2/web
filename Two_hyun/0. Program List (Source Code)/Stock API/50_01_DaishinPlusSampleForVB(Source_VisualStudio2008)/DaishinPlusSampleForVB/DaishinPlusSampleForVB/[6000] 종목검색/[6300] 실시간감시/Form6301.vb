Public Class Form6301
    Private _parent As Main
    Dim _Table As DataTable = New DataTable

    Dim _stgID As String
    Dim _monitorID As String
    Dim _index As Integer
    Private _arrCode As ArrayList = New ArrayList
    Dim _searchTime As String

    Private _marketEye As CPSYSDIBLib.MarketEye
    Public WithEvents _stockCur As DSCBO1Lib.StockCur
    Private _CssStgFind As CPSYSDIBLib.CssStgFind
    Private _CssWatchStgSubscribe As CPSYSDIBLib.CssWatchStgSubscribe
    Private _CssWatchStgControl As CPSYSDIBLib.CssWatchStgControl
    Private WithEvents _CssAlert As CPSYSDIBLib.CssAlert

    Private Sub Form6301_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.KeyPreview = True

        _parent = Me.ParentForm

        _CssWatchStgSubscribe = New CPSYSDIBLib.CssWatchStgSubscribe
        _marketEye = New CPSYSDIBLib.MarketEye
        _stockCur = New DSCBO1Lib.StockCur
        _CssStgFind = New CPSYSDIBLib.CssStgFind
        _CssWatchStgControl = New CPSYSDIBLib.CssWatchStgControl
        _CssAlert = New CPSYSDIBLib.CssAlert

        _stgID = ""
        _monitorID = ""
        _index = 1
        _searchTime = ""

        _Table.Columns.Add("종목코드")
        _Table.Columns.Add("순번")
        _Table.Columns.Add("상태")
        _Table.Columns.Add("종목명")
        _Table.Columns.Add("현재가")
        _Table.Columns.Add("전일대비")
        _Table.Columns.Add("거래량")
        _Table.Columns.Add("포착가")
        _Table.Columns.Add("포착후 수익률")
        _Table.Columns.Add("포착시간")

        DataGridView1.DataSource = _Table

        Dim button1 As New DataGridViewButtonColumn()
        DataGridView1.Columns.Add(button1)
        button1.HeaderText = "매수"
        button1.Text = "매수"
        button1.UseColumnTextForButtonValue = True

        Dim button2 As New DataGridViewButtonColumn()
        DataGridView1.Columns.Add(button2)
        button2.HeaderText = "매도"
        button2.Text = "매도"
        button2.UseColumnTextForButtonValue = True

        Dim button3 As New DataGridViewButtonColumn()
        DataGridView1.Columns.Add(button3)
        button3.HeaderText = "삭제"
        button3.Text = "삭제"
        button3.UseColumnTextForButtonValue = True

        DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.Columns("순번").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns("상태").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns("포착후 수익률").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns("종목명").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridView1.Columns("포착가").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns("현재가").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns("전일대비").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns("거래량").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns("종목코드").Visible = False
        DataGridView1.Refresh()
    End Sub

    Public Sub SetSTGInfo(ByVal id As String, ByVal name As String)
        Me.StopSTG()

        Me.Unsubscribe()

        _stgID = id
        TextBoxName.Text = name

        Me.RequestSTGList()
    End Sub

    Private Sub Form6301_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub ButtonHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHelp.Click
        _parent.ShowHelp("6301")
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        DataGridView1.ClearSelection()

        If e.RowIndex = -1 Then
            Return
        End If

        If DataGridView1.Columns(e.ColumnIndex).HeaderText = "매수" Then
            _parent.ShowStockOrder(Me, 0)
            _parent.ChangedStockCode(DataGridView1.Rows(e.RowIndex).Cells("종목코드").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("종목명").Value.ToString())
        ElseIf DataGridView1.Columns(e.ColumnIndex).HeaderText = "매도" Then
            _parent.ShowStockOrder(Me, 1)
            _parent.ChangedStockCode(DataGridView1.Rows(e.RowIndex).Cells("종목코드").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("종목명").Value.ToString())
        ElseIf DataGridView1.Columns(e.ColumnIndex).HeaderText = "삭제" Then
            _stockCur.SetInputValue(0, DataGridView1.Rows(e.RowIndex).Cells("종목코드").Value.ToString())
            _stockCur.Unsubscribe()

            _Table.Rows(e.RowIndex).Delete()

            For i As Integer = 0 To _Table.Rows.Count - 1
                _Table.Rows(i).Item("순번") = (i + 1).ToString()
            Next
            DataGridView1.Refresh()

            TextBoxCount.Text = _Table.Rows.Count.ToString()
        Else
            _parent.ChangedStockCode(DataGridView1.Rows(e.RowIndex).Cells("종목코드").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("종목명").Value.ToString())
        End If
    End Sub

    Private Sub DataGridView1_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles DataGridView1.DataBindingComplete
        DataGridView1.ClearSelection()
    End Sub

    Private Sub DataGridView1_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        If DataGridView1.Columns(e.ColumnIndex).HeaderText = "상태" And e.Value.ToString <> "" Then
            If e.Value.ToString() = "진입" Then
                DataGridView1.Rows(e.RowIndex).Cells("상태").Style.ForeColor = Color.Red
            ElseIf e.Value.ToString() = "퇴출" Then
                DataGridView1.Rows(e.RowIndex).Cells("상태").Style.ForeColor = Color.Blue
            End If
        ElseIf DataGridView1.Columns(e.ColumnIndex).HeaderText = "전일대비" And e.Value.ToString <> "" Then
            Dim value As Double = Convert.ToDouble(e.Value.ToString())
            If value > 0 Then
                DataGridView1.Rows(e.RowIndex).Cells("현재가").Style.ForeColor = Color.Red
            ElseIf value < 0 Then
                DataGridView1.Rows(e.RowIndex).Cells("현재가").Style.ForeColor = Color.Blue
            Else
                DataGridView1.Rows(e.RowIndex).Cells("현재가").Style.ForeColor = Color.Black
            End If
        ElseIf DataGridView1.Columns(e.ColumnIndex).HeaderText = "포착후 수익률" And e.Value.ToString <> "" Then
            Dim text As String = e.Value.ToString().Replace("%", "")
            Dim value As Double = Convert.ToDouble(text)
            If value > 0 Then
                DataGridView1.Rows(e.RowIndex).Cells("포착후 수익률").Style.ForeColor = Color.Red
            ElseIf value < 0 Then
                DataGridView1.Rows(e.RowIndex).Cells("포착후 수익률").Style.ForeColor = Color.Blue
            Else
                DataGridView1.Rows(e.RowIndex).Cells("포착후 수익률").Style.ForeColor = Color.Black
            End If
        End If
    End Sub

    Private Sub RequestMonitorID()
        If _CssWatchStgSubscribe.GetDibStatus() = 1 Then
            Trace.TraceInformation("DibRq 요청 수신대기 중 입니다. 수신이 완료된 후 다시 호출 하십시오.")
            ButtonStart.Text = "▶"
            ButtonStart.BackColor = Color.Blue
            LabelMonitor.Text = "감시 정지"
            Exit Sub
        End If

        If _stgID = "" Then
            MessageBox.Show("전략이 존재하지 않습니다. 전략조회 화면으로부터 연동이 되어야합니다.")
            ButtonStart.Text = "▶"
            ButtonStart.BackColor = Color.Blue
            LabelMonitor.Text = "감시 정지"
            Return
        End If

        _CssWatchStgSubscribe.SetInputValue(0, _stgID)

        Dim result As Integer = -1
        result = _CssWatchStgSubscribe.BlockRequest()

        LabelMsg1.Text = _CssWatchStgSubscribe.GetDibMsg1()
        LabelMsg2.Text = _CssWatchStgSubscribe.GetDibMsg2()

        If result = 0 Then
            _monitorID = _CssWatchStgSubscribe.GetHeaderValue(0).ToString()
        End If
    End Sub

    Private Sub StartSTG()
        If Convert.ToInt32(TextBoxCount.Text) > 200 Then
            MessageBox.Show("실시간 감시는 200종목으로 제한합니다. 200종목 이상의 전략은 감시를 수행할 수 없습니다.")
            Return
        End If

        If _stgID = "" Then
            MessageBox.Show("전략이 존재하지 않습니다. 전략화면으로부터 연동이 되어야합니다.")
            Return
        End If

        If Convert.ToInt32(_monitorID) < 0 Then
            MessageBox.Show("감시 일련번호가 존재하지 않습니다.")
            Return
        End If

        _CssAlert.Unsubscribe()

        _CssWatchStgControl.SetInputValue(0, _stgID)
        _CssWatchStgControl.SetInputValue(1, Convert.ToInt32(_monitorID))

        If LabelMonitor.Text = "감시 정지" Then
            _CssWatchStgControl.SetInputValue(2, Asc("1"))
            ButtonStart.Text = "■"
            ButtonStart.BackColor = Color.Red
            LabelMonitor.Text = "감시중"
        Else
            _CssWatchStgControl.SetInputValue(2, Asc("3"))
            ButtonStart.Text = "▶"
            ButtonStart.BackColor = Color.Blue
            LabelMonitor.Text = "감시 정지"
        End If

        Dim resultRQ As Integer = _CssWatchStgControl.BlockRequest()
        LabelMsg1.Text = _CssWatchStgControl.GetDibMsg1()
        LabelMsg2.Text = _CssWatchStgControl.GetDibMsg2()

        If resultRQ = 0 Then
            If _CssWatchStgControl.GetHeaderValue(0).ToString() = "1" Then
                ButtonStart.Text = "■"
                ButtonStart.BackColor = Color.Red
                LabelMonitor.Text = "감시중"
                LabelMsg1.Text = "감시중입니다."

                If _parent.GetRemainSB() > 0 Then
                    _CssAlert.Subscribe()
                End If
            Else
                LabelMsg1.Text = "감시가 정지되었습니다."
                ButtonStart.Text = "▶"
                ButtonStart.BackColor = Color.Blue
                LabelMonitor.Text = "감시 정지"
            End If
        End If
    End Sub

    Private Sub StopSTG()
        If _stgID = "" Or _monitorID = "" Then
            Return
        End If

        _CssAlert.Unsubscribe()

        _CssWatchStgControl.SetInputValue(0, _stgID)
        _CssWatchStgControl.SetInputValue(1, Convert.ToInt32(_monitorID))
        _CssWatchStgControl.SetInputValue(2, Asc("3"))

        Dim resultRQ As Integer = _CssWatchStgControl.BlockRequest()
        LabelMsg1.Text = _CssWatchStgControl.GetDibMsg1()
        LabelMsg2.Text = _CssWatchStgControl.GetDibMsg2()
        If resultRQ = 0 Then
            If _CssWatchStgControl.GetHeaderValue(0).ToString() = "1" Then
                ButtonStart.Text = "■"
                ButtonStart.BackColor = Color.Red
                LabelMonitor.Text = "감시중"
                LabelMsg1.Text = "감시중입니다."

                If _parent.GetRemainSB() > 0 Then
                    _CssAlert.Subscribe()
                End If
            Else
                LabelMsg1.Text = "감시가 정지되었습니다."
                ButtonStart.Text = "▶"
                ButtonStart.BackColor = Color.Blue
                LabelMonitor.Text = "감시 정지"
            End If
        End If
    End Sub

    Private Sub RequestSTGList()
        If _stgID = "" Then
            MessageBox.Show("전략이 존재하지 않습니다. 전략화면으로부터 연동이 되어야합니다.")
            Return
        End If

        _Table.Clear()
        DataGridView1.Refresh()

        TextBoxCount.Text = "0"
        _index = 1
        _arrCode.Clear()

        _CssStgFind.SetInputValue(0, _stgID)

        Me.JustRequest()
    End Sub

    Private Sub JustRequest()
        If _CssStgFind.GetDibStatus() = 1 Then
            Trace.TraceInformation("DibRq 요청 수신대기 중 입니다. 수신이 완료된 후 다시 호출 하십시오.")
            Exit Sub
        End If

        LabelMsg1.Text = ""
        LabelMsg2.Text = ""
        LabelContinue.Text = ""

        Dim result As Integer = -1
        result = _CssStgFind.BlockRequest()

        LabelMsg1.Text = _CssStgFind.GetDibMsg1()
        LabelMsg2.Text = _CssStgFind.GetDibMsg2()

        TextBoxCount.Text = _CssStgFind.GetHeaderValue(1).ToString()
        _searchTime = _CssStgFind.GetHeaderValue(2).ToString()

        If result = 0 Then
            For i As Integer = 0 To _CssStgFind.GetHeaderValue(0) - 1
                _arrCode.Add(_CssStgFind.GetDataValue(0, i))
            Next i

            If _CssStgFind.Continue = 1 Then
                Me.JustRequest()
                LabelMsg1.Text = "조회중입니다."
            Else
                If _arrCode.Count > 200 Then
                    MessageBox.Show("실시간 감시는 200종목으로 제한합니다. 200종목 이상의 전략은 감시를 수행할 수 없습니다.")
                    Return
                End If

                Me.Unsubscribe()

                Me.RequestMarketEye()
            End If
        End If
    End Sub

    Private Sub RequestMarketEye()
        _index = 1

        Dim items() As Integer = {0, 1, 2, 3, 4, 5, 6, 7, 10, 11, 17}
        _marketEye.SetInputValue(0, items)

        Dim sCodes(0 To _arrCode.Count - 1) As String

        For i As Integer = 0 To _arrCode.Count - 1
            sCodes(i) = _arrCode.Item(i)
        Next i

        _marketEye.SetInputValue(1, sCodes)

        Dim resultMarketEye As Int32 = _marketEye.BlockRequest()

        LabelMsg1.Text = _marketEye.GetDibMsg1()

        If resultMarketEye = 0 Then
            Dim sumProfit As Double = 0
            For j As Integer = 0 To _marketEye.GetHeaderValue(2) - 1
                Dim row As DataRow = _Table.NewRow
                row("순번") = _index.ToString()
                row("상태") = "진입"
                row("종목코드") = _marketEye.GetDataValue(0, j)
                row("종목명") = _marketEye.GetDataValue(10, j)
                row("현재가") = _marketEye.GetDataValue(4, j)
                row("포착가") = _marketEye.GetDataValue(4, j)
                row("전일대비") = _marketEye.GetDataValue(3, j)
                row("거래량") = _marketEye.GetDataValue(8, j)
                row("포착시간") = _searchTime

                Dim profit As Double = Convert.ToDouble(row("현재가").ToString()) - Convert.ToDouble(row("포착가").ToString())
                row("포착후 수익률") = (profit / Convert.ToDouble(row("포착가").ToString())).ToString("0.00%")
                sumProfit += profit / 100

                _Table.Rows.Add(row)
                _index += 1
            Next

            TextBoxProfit.Text = (sumProfit / _Table.Rows.Count / 100).ToString("0.00%")

            Dim text As String = TextBoxProfit.Text.Replace("%", "")
            Dim value As Double = Convert.ToDouble(text)
            If value > 0 Then
                TextBoxProfit.ForeColor = Color.Red
            ElseIf value < 0 Then
                TextBoxProfit.ForeColor = Color.Blue
            Else
                TextBoxProfit.ForeColor = Color.Black
            End If

            For j As Integer = 0 To _Table.Rows.Count - 1
                If _parent.GetRemainSB() > 0 Then
                    _stockCur.SetInputValue(0, _Table.Rows(j).Item("종목코드"))
                    _stockCur.Subscribe()
                End If
            Next

            LabelMsg1.Text = "조회가 완료되었습니다."
            TextBoxCount.Text = _Table.Rows.Count.ToString()

            DataGridView1.Refresh()

            RequestMonitorID()
        End If
    End Sub

    Private Sub Unsubscribe()
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            _stockCur.SetInputValue(0, DataGridView1.Rows(i).Cells("종목코드").Value.ToString())
            _stockCur.Unsubscribe()
        Next
    End Sub

    Private Sub _stockCur_Received() Handles _stockCur.Received
        Dim sumProfit As Double = 0
        Dim bChanged As Boolean = False

        For i As Integer = 0 To _Table.Rows.Count - 1
            If _Table.Rows(i).Item("종목코드").ToString().ToUpper() = _stockCur.GetHeaderValue(0).ToString().ToUpper() Then
                _Table.Rows(i).Item("현재가") = _stockCur.GetHeaderValue(13)
                _Table.Rows(i).Item("전일대비") = _stockCur.GetHeaderValue(2)
                _Table.Rows(i).Item("거래량") = _stockCur.GetHeaderValue(9)

                DataGridView1.Refresh()

                Dim profit As Double = Convert.ToDouble(_Table.Rows(i).Item("현재가").ToString()) - Convert.ToDouble(_Table.Rows(i).Item("포착가").ToString())
                _Table.Rows(i).Item("포착후 수익률") = (profit / Convert.ToDouble(_Table.Rows(i).Item("포착가").ToString())).ToString("0.00%")
                sumProfit += profit / 100

                bChanged = True
                Exit For
            End If
        Next i

        If bChanged Then
            TextBoxProfit.Text = (sumProfit / _Table.Rows.Count / 100).ToString("0.00%")

            Dim text As String = TextBoxProfit.Text.Replace("%", "")
            Dim value As Double = Convert.ToDouble(text)
            If value > 0 Then
                TextBoxProfit.ForeColor = Color.Red
            ElseIf value < 0 Then
                TextBoxProfit.ForeColor = Color.Blue
            Else
                TextBoxProfit.ForeColor = Color.Black
            End If
        End If
    End Sub

    Private Sub ButtonStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonStart.Click
        Me.StartSTG()
    End Sub

    Private Sub ButtonOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonOrder.Click
        If DataGridView1.Rows.Count <= 0 Then
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("전체 종목을 시장가로 1주씩 매수 주문합니다.", "대신증권", MessageBoxButtons.OKCancel)
        If result = Windows.Forms.DialogResult.OK Then
            For i As Integer = 0 To _Table.Rows.Count - 1
                _parent.SendStockOrder(True, _Table.Rows(i).Item("종목코드"), "1", "0", "03", "0")
            Next
        End If
    End Sub

    Private Sub CheckBoxDelete_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxDelete.CheckedChanged
        Me.ClearOut(True)
    End Sub

    Private Sub _CssAlert_Received() Handles _CssAlert.Received
        If _stgID = _CssAlert.GetHeaderValue(0).ToString() And _monitorID = _CssAlert.GetHeaderValue(1).ToString() Then
            Dim bNew = True
            Dim rowIndex = -1
            
            For i As Integer = 0 To _Table.Rows.Count - 1
                If _Table.Rows(i).Item("종목코드").ToString().ToUpper() = _CssAlert.GetHeaderValue(2).ToString().ToUpper() Then
                    _Table.Rows(i).Item("포착시간") = _CssAlert.GetHeaderValue(4).ToString()
                    _Table.Rows(i).Item("포착가") = _CssAlert.GetHeaderValue(5).ToString()
                    If _CssAlert.GetHeaderValue(3).ToString() = "1" Then
                        _Table.Rows(i).Item("상태") = "진입"
                    Else
                        _Table.Rows(i).Item("상태") = "퇴출"
                    End If

                    Dim profit As Double = Convert.ToDouble(_Table.Rows(i).Item("현재가").ToString()) - Convert.ToDouble(_Table.Rows(i).Item("포착가").ToString())
                    _Table.Rows(i).Item("포착후 수익률") = (profit / Convert.ToDouble(_Table.Rows(i).Item("포착가").ToString())).ToString("0.00%")

                    rowIndex = i
                    bNew = False
                    Exit For
                End If
            Next

            If bNew Then
                Dim row As DataRow = _Table.NewRow
                row("순번") = (_Table.Rows.Count + 1).ToString()
                If _CssAlert.GetHeaderValue(3).ToString() = "1" Then
                    row("상태") = "진입"
                Else
                    row("상태") = "퇴출"
                End If
                row("종목코드") = _CssAlert.GetHeaderValue(2).ToString()
                row("종목명") = _parent.FindStockName(_CssAlert.GetHeaderValue(2).ToString().ToUpper())
                row("현재가") = _CssAlert.GetHeaderValue(5).ToString()
                row("포착가") = _CssAlert.GetHeaderValue(5).ToString()
                row("전일대비") = ""
                row("거래량") = ""
                row("포착시간") = _CssAlert.GetHeaderValue(4).ToString()

                Dim profit As Double = Convert.ToDouble(row("현재가").ToString()) - Convert.ToDouble(row("포착가").ToString())
                row("포착후 수익률") = (profit / Convert.ToDouble(row("포착가").ToString())).ToString("0.00%")

                _Table.Rows.Add(row)

                _stockCur.SetInputValue(0, row("종목코드"))
                _stockCur.Subscribe()
            End If

            Dim sumProfit As Double = 0
            For i As Integer = 0 To _Table.Rows.Count - 1
                Dim profit As Double = Convert.ToDouble(_Table.Rows(i).Item("현재가").ToString()) - Convert.ToDouble(_Table.Rows(i).Item("포착가").ToString())
                _Table.Rows(i).Item("포착후 수익률") = (profit / Convert.ToDouble(_Table.Rows(i).Item("포착가").ToString())).ToString("0.00%")
                sumProfit += profit / 100

                _Table.Rows(i).Item("순번") = (i + 1).ToString()
            Next

            TextBoxProfit.Text = (sumProfit / _Table.Rows.Count / 100).ToString("0.00%")

            Dim text As String = TextBoxProfit.Text.Replace("%", "")
            Dim value As Double = Convert.ToDouble(text)
            If value > 0 Then
                TextBoxProfit.ForeColor = Color.Red
            ElseIf value < 0 Then
                TextBoxProfit.ForeColor = Color.Blue
            Else
                TextBoxProfit.ForeColor = Color.Black
            End If

            TextBoxCount.Text = _Table.Rows.Count.ToString()

            Me.ClearOut(True)
        End If
    End Sub

    Private Sub ClearOut(ByVal bRefresh As Boolean)
        If CheckBoxDelete.Checked = False Then
            If bRefresh Then
                DataGridView1.Refresh()
            End If
            Return
        End If

        Dim bDeleted As Boolean = False
        For i As Integer = _Table.Rows.Count - 1 To 0 Step -1
            If _Table.Rows(i).Item("상태").ToString() = "퇴출" Then
                _stockCur.SetInputValue(0, _Table.Rows(i).Item("종목코드").ToString().ToUpper())
                _stockCur.Unsubscribe()

                _Table.Rows(i).Delete()

                bDeleted = True
            End If
        Next

        If bDeleted Then
            For i As Integer = 0 To _Table.Rows.Count - 1
                _Table.Rows(i).Item("순번") = (i + 1).ToString()
            Next
        End If

        If bRefresh Then
            DataGridView1.Refresh()
        End If
    End Sub

    Private Sub Form6301_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Me.StopSTG()

        Me.Unsubscribe()
    End Sub

End Class