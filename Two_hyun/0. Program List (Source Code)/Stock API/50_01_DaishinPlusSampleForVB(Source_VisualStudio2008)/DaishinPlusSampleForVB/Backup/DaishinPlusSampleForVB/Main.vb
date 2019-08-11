

Public Class Main

    Public WithEvents _cpCybos As CPUTILLib.CpCybos
    Public _cpStockCodes As New CPUTILLib.CpStockCode
    Public _CpCodeMgr As New CPUTILLib.CpCodeMgr
    Public _CpTdUtil As New CPTRADELib.CpTdUtil
    Public WithEvents _CpConclusion As New DSCBO1Lib.CpConclusion

    Public _formStockCode As New FormStockCodes
    Public _stockTable As New DataTable

    Public _stockTradeTable As New DataTable

    Public screen1101 As Form1101
    Public screen1102 As Form1102
    Public screen1103 As Form1103
    Public screen1104 As Form1104
    Public screen1105 As Form1105
    Public screen1106 As Form1106

    Public screen1201 As Form1201
    Public screen1202 As Form1202
    Public screen1203 As Form1203
    Public screen1204 As Form1204
    Public screen1205 As Form1205

    Public screen1301 As Form1301
    Public screen1302 As Form1302
    Public screen1303 As Form1303
    Public screen1304 As Form1304

    Public screen1401 As Form1401
    Public screen1402 As Form1402

    Public screen6101 As Form6101
    Public screen6201 As Form6201
    Public screen6301 As Form6301

    Public formHelp As FormHelp

    Public stockCode As String
    Public stockName As String

    Public accountNo As String
    Public accountGoodsStock As String
    Public arrAccountGoodsStock() As String

    Private _checkedTradeInit As Boolean

    Private WithEvents _timerConnection As Timer
    Private _timerCount As Integer

    Private Sub Main_Disposed(ByVal sender As Object, ByVal e As System.EventArgs)
        _CpConclusion.Unsubscribe()
    End Sub

    Private Sub Main_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        _checkedTradeInit = False

        stockCode = "A003540"
        stockName = "대신증권"

        accountNo = ""
        accountGoodsStock = ""

        _timerCount = 0

        _cpCybos = Nothing
        _cpCybos = New CPUTILLib.CpCybos

    End Sub

    Private Sub Main_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.ChangeMainTitleConnection()
    End Sub

    Private Sub ChangeMainTitleConnection()

        _cpCybos = Nothing
        _cpCybos = New CPUTILLib.CpCybos

        If _cpCybos.IsConnect = 1 Then
            If _timerConnection IsNot Nothing Then
                _timerConnection.Stop()
                _timerConnection.Dispose()
                _timerConnection = Nothing

                MsgBox("대신증권 플러스에 연결되었습니다.", MsgBoxStyle.OkOnly)
            End If

            _timerCount = 0

            MenuStrip1.BackColor = Color.FromArgb(228, 254, 226)

            Me.Text = "대신증권 플러스 Sample for Visual Basic .Net (연결 완료)"

            Me.LoadStockCodes()
        Else
            Me.Text = "대신증권 플러스 Sample for Visual Basic .Net (연결 안됨)"
            If _timerCount = 0 Then
                Dim dialog As DialogConnection = New DialogConnection
                dialog.SetParent(Me)
                dialog.ShowDialog()
            End If
        End If
    End Sub

    Private Sub _cpCybos_OnDisconnect() Handles _cpCybos.OnDisconnect
        _cpCybos = Nothing

        MenuStrip1.BackColor = Color.FromArgb(255, 230, 230)

        MsgBox("대신증권 플러스 연결이 종료되었습니다.", MsgBoxStyle.OkOnly)

        Me.Text = "대신증권 플러스 Sample for Visual Basic .Net (연결 안됨)"
    End Sub

    Public Sub RequestConnection()
        _timerConnection = New Timer
        _timerConnection.Interval = 1000
        _timerConnection.Start()
        _timerCount = 0
    End Sub

    Private Sub _timerConnection_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles _timerConnection.Tick
        If (_timerCount > 180) Then
            _timerConnection.Stop()
            _timerConnection.Dispose()
            _timerConnection = Nothing
            _timerCount = 0
        End If

        _timerCount += 1

        Me.ChangeMainTitleConnection()
    End Sub

    'Load 주식 종목 마스터

    Public Sub LoadStockCodes()
        _stockTable.Columns.Clear()
        _stockTable.Columns.Add("순번")
        _stockTable.Columns.Add("종목코드")
        _stockTable.Columns.Add("종목명")

        _stockTable.Clear()
        For i As Integer = 0 To _cpStockCodes.GetCount() - 1
            _stockTable.Rows.Add((i + 1).ToString, _cpStockCodes.GetData(0, i), _cpStockCodes.GetData(1, i))
        Next
    End Sub

    'Show 주식종목 선택기

    Public Sub ShowStockSelector(ByVal sender As Object)
        If _formStockCode.Visible = True Then
            _formStockCode.Close()
        End If

        _formStockCode = New FormStockCodes
        _formStockCode.MdiParent = Me
        _formStockCode.StartPosition = FormStartPosition.Manual
        _formStockCode.Location = New Point(sender.Location.X + sender.Size.Width, sender.Location.Y)
        _formStockCode.TopMost = True
        _formStockCode.Show()
    End Sub

    Public Sub CloseStockSelector(ByVal child As Object)
        If _formStockCode.Visible = True Then
            _formStockCode.Visible = False
        End If
    End Sub

    Public Sub ChangedStockCode(ByVal code As String, ByVal name As String)
        stockCode = code
        stockName = name

        For Each childForm As Object In Me.MdiChildren
            If childForm.Text.Length >= 5 Then
                Dim title As String = childForm.Text.Substring(1, 4)
                If title = "1101" Or title = "1102" Or title = "1103" Or title = "1104" Or title = "1105" Or title = "1106" Or title = "1201" Or title = "1202" Or title = "1203" Or title = "1204" Or title = "1301" Or title = "1302" Or title = "1303" Then
                    childForm.ChangedStockCode(code, name)
                End If
            End If
        Next
    End Sub

    Private Sub TradeInit()
        If _checkedTradeInit Then
            Exit Sub
        End If

        Dim rv As Integer = _CpTdUtil.TradeInit(0)
        If rv = 0 Then
            _checkedTradeInit = True
            Dim arrAccount() As String = _CpTdUtil.AccountNumber
            If arrAccount.Count > 0 Then
                accountNo = arrAccount(0)
            End If

            arrAccountGoodsStock = _CpTdUtil.GoodsList(accountNo, 1)    '주식
            If arrAccountGoodsStock.Count > 0 Then
                accountGoodsStock = arrAccountGoodsStock(0)
            End If

            Me.StockTradeInit()
        ElseIf rv = -1 Then
            MsgBox("계좌 비밀번호 오류 포함 에러.")
            _checkedTradeInit = False
        ElseIf rv = 1 Then
            MsgBox("OTP/보안카드키가 잘못되었습니다.")
            _checkedTradeInit = False
        Else
            MsgBox("Error")
            _checkedTradeInit = False
        End If

    End Sub

    Public Sub ChangedAccountKind(ByVal kind As String)
        accountGoodsStock = kind
    End Sub

    'Show Help
    Public Sub ShowHelp(ByVal screen As String)
        formHelp = New FormHelp
        formHelp.MdiParent = Me
        formHelp.SetScreen(screen)
        formHelp.Show()
    End Sub

    '주식 메뉴
    Private Sub 주식현재가_단일종목_ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 주식현재가_단일종목_ToolStripMenuItem.Click
        screen1101 = New Form1101()
        screen1101.MdiParent = Me
        screen1101.Show()
    End Sub

    Private Sub 주식현재가복수종목ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 주식현재가복수종목ToolStripMenuItem.Click
        screen1102 = New Form1102()
        screen1102.MdiParent = Me
        screen1102.Show()
    End Sub

    Private Sub 투자주체별매매현황ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 투자주체별매매현황ToolStripMenuItem.Click
        screen1103 = New Form1103()
        screen1103.MdiParent = Me
        screen1103.Show()
    End Sub

    Private Sub 주식시간대별체결ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 주식시간대별체결ToolStripMenuItem.Click
        screen1104 = New Form1104()
        screen1104.MdiParent = Me
        screen1104.Show()
    End Sub

    Private Sub 주식일자별ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 주식일자별ToolStripMenuItem.Click
        screen1105 = New Form1105()
        screen1105.MdiParent = Me
        screen1105.Show()
    End Sub

    Private Sub 주식호가ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 주식호가ToolStripMenuItem.Click
        screen1106 = New Form1106()
        screen1106.MdiParent = Me
        screen1106.Show()
    End Sub

    Public Sub ShowStockQuote(ByVal sender As Object)
        If screen1106 IsNot Nothing Then
            If screen1106.Visible Then
                screen1106.Close()
            End If
        End If

        screen1106 = New Form1106()
        screen1106.MdiParent = Me
        screen1106.StartPosition = FormStartPosition.Manual

        If sender Is screen1201 Then
            If screen1201 IsNot Nothing Then
                If screen1201.Visible = True Then
                    screen1106.Location = New Point(screen1201.Location.X + screen1201.Size.Width, screen1201.Location.Y)
                Else
                    screen1106.Location = New Point(Me.Width - _formStockCode.Size.Width - screen1106.Size.Width - 30, 10)
                End If
            End If
        ElseIf sender Is screen1202 Then
            If screen1202 IsNot Nothing Then
                If screen1202.Visible = True Then
                    screen1106.Location = New Point(screen1202.Location.X + screen1202.Size.Width, screen1202.Location.Y)
                Else
                    screen1106.Location = New Point(Me.Width - _formStockCode.Size.Width - screen1106.Size.Width - 30, 10)
                End If
            End If
        ElseIf sender Is screen1204 Then
            If screen1204 IsNot Nothing Then
                If screen1204.Visible = True Then
                    screen1106.Location = New Point(screen1204.Location.X + screen1204.Size.Width, screen1204.Location.Y)
                Else
                    screen1106.Location = New Point(Me.Width - _formStockCode.Size.Width - screen1106.Size.Width - 30, 10)
                End If
            End If
        End If

        screen1106.TopMost = True
        screen1106.Show()
    End Sub

    Public Sub ChangedStockQuote(ByVal price As String)
        For Each childForm As Object In Me.MdiChildren
            If childForm.Text.Length >= 5 Then
                Dim title As String = childForm.Text.Substring(1, 4)
                If title = "1201" Or title = "1202" Or title = "1204" Then
                    childForm.ChangedStockQuote(price)
                End If
            End If
        Next
    End Sub

    Public Sub ChangedStockCount(ByVal count As String)
        For Each childForm As Object In Me.MdiChildren
            If childForm.Text.Length >= 5 Then
                Dim title As String = childForm.Text.Substring(1, 4)
                If title = "1201" Then
                    childForm.ChangedStockCount(count)
                End If
            End If
        Next
    End Sub

    Public Sub ChangedStockNoneTradeNo(ByVal no As String, ByVal count As String)
        For Each childForm As Object In Me.MdiChildren
            If childForm.Text.Length >= 5 Then
                Dim title As String = childForm.Text.Substring(1, 4)
                If title = "1201" Then
                    childForm.ChangedStockNoneTradeNo(no, count)
                End If
            End If
        Next
    End Sub

    Private Sub 주식현금주문ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 주식현금주문ToolStripMenuItem.Click
        Me.TradeInit()

        screen1201 = New Form1201()
        screen1201.MdiParent = Me
        screen1201.Show()
    End Sub

    Private Sub 금일계좌별주문체결ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 금일계좌별주문체결ToolStripMenuItem.Click
        Me.TradeInit()

        screen1301 = New Form1301()
        screen1301.MdiParent = Me
        screen1301.Show()
    End Sub

    Public Function GetStockMarketKind(ByVal code As String) As CPE_MARKET_KIND
        Dim market As CPE_MARKET_KIND = _CpCodeMgr.GetStockMarketKind(code)
        Return market
    End Function

    Private Sub 주식시세종합화면ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 주식시세종합화면ToolStripMenuItem.Click
        For Each childForm As Form In Me.MdiChildren
            childForm.Close()
        Next

        Dim xPos As Integer = 0
        Dim yPos As Integer = 0

        screen1106 = New Form1106()
        screen1106.MdiParent = Me
        screen1106.StartPosition = FormStartPosition.Manual
        screen1106.Location = New Point(xPos, yPos)
        screen1106.Show()

        screen1101 = New Form1101()
        screen1101.MdiParent = Me
        screen1101.StartPosition = FormStartPosition.Manual
        screen1101.Location = New Point(xPos + screen1106.Size.Width, yPos)
        screen1101.Show()

        screen1102 = New Form1102()
        screen1102.MdiParent = Me
        screen1102.StartPosition = FormStartPosition.Manual
        screen1102.Location = New Point(xPos + screen1106.Size.Width, yPos + screen1101.Size.Height)
        screen1102.Show()
        screen1102.Height = screen1106.Size.Height - screen1101.Size.Height

        screen1104 = New Form1104()
        screen1104.MdiParent = Me
        screen1104.StartPosition = FormStartPosition.Manual
        screen1104.Location = New Point(xPos + screen1106.Size.Width + screen1101.Size.Width, yPos)
        screen1104.Show()
        screen1104.Height = 480

        screen1105 = New Form1105()
        screen1105.MdiParent = Me
        screen1105.StartPosition = FormStartPosition.Manual
        screen1105.Location = New Point(xPos + screen1106.Size.Width + screen1101.Size.Width, yPos + screen1104.Size.Height)
        screen1105.Show()
        screen1105.Height = 420

        screen1103 = New Form1103()
        screen1103.MdiParent = Me
        screen1103.StartPosition = FormStartPosition.Manual
        screen1103.Location = New Point(xPos, yPos + screen1106.Size.Height)
        screen1103.Show()
        screen1103.Height = screen1103.Height / 2
    End Sub

    Private Sub 주식매수가능금액수량ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 주식매수가능금액수량ToolStripMenuItem.Click
        Me.TradeInit()

        screen1202 = New Form1202()
        screen1202.MdiParent = Me
        screen1202.Show()
    End Sub

    Private Sub 주식계좌별매도가능수량ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 주식계좌별매도가능수량ToolStripMenuItem.Click
        Me.TradeInit()

        screen1203 = New Form1203()
        screen1203.MdiParent = Me
        screen1203.Show()
    End Sub

    Public Function FindStockName(ByVal code As String)
        Dim retName As String = ""

        For i As Integer = 0 To _stockTable.Rows.Count - 1
            If _stockTable.Rows(i).Item("종목코드") = code Then
                retName = _stockTable.Rows(i).Item("종목명")
                Exit For
            End If
        Next

        Return retName
    End Function

    Public Sub ShowStockBuyAble()
        If screen1202 IsNot Nothing Then
            If screen1202.Visible Then
                screen1202.Close()
            End If
        End If

        screen1202 = New Form1202()
        screen1202.MdiParent = Me

        If screen1201 IsNot Nothing Then
            If screen1201.Visible = True Then
                screen1202.StartPosition = FormStartPosition.Manual
                screen1202.Location = New Point(screen1201.Location.X + screen1201.Size.Width, screen1201.Location.Y)
            End If
        End If

        screen1202.TopMost = True
        screen1202.Show()
    End Sub

    Public Sub ShowStockSellAble()
        If screen1203 IsNot Nothing Then
            If screen1203.Visible Then
                screen1203.Close()
            End If
        End If

        screen1203 = New Form1203()
        screen1203.MdiParent = Me

        If screen1201 IsNot Nothing Then
            If screen1201.Visible = True Then
                screen1203.StartPosition = FormStartPosition.Manual
                screen1203.Location = New Point(screen1201.Location.X + screen1201.Size.Width, screen1201.Location.Y)
            End If
        End If

        screen1203.TopMost = True
        screen1203.Show()
    End Sub

    Public Sub ShowStockNoneTrade()
        If screen1303 IsNot Nothing Then
            If screen1303.Visible Then
                screen1303.Close()
            End If
        End If

        screen1303 = New Form1303()
        screen1303.MdiParent = Me

        If screen1201 IsNot Nothing Then
            If screen1201.Visible = True Then
                screen1303.StartPosition = FormStartPosition.Manual
                screen1303.Location = New Point(screen1201.Location.X + screen1201.Size.Width, screen1201.Location.Y)
            End If
        End If

        screen1303.TopMost = True
        screen1303.Show()
    End Sub

    Private Sub StockTradeInit()
        _stockTradeTable.Columns.Clear()

        _stockTradeTable.Columns.Add("계좌명")
        _stockTradeTable.Columns.Add("계좌번호")
        _stockTradeTable.Columns.Add("계좌상품")
        _stockTradeTable.Columns.Add("종목명")
        _stockTradeTable.Columns.Add("종목코드")
        _stockTradeTable.Columns.Add("주문번호")
        _stockTradeTable.Columns.Add("원주문번호")
        _stockTradeTable.Columns.Add("체결가격")
        _stockTradeTable.Columns.Add("체결수량")
        _stockTradeTable.Columns.Add("매매")
        _stockTradeTable.Columns.Add("실시간")
        _stockTradeTable.Columns.Add("정정취소")
        _stockTradeTable.Columns.Add("주문구분")
        _stockTradeTable.Columns.Add("주문조건")
        _stockTradeTable.Columns.Add("장부가")
        _stockTradeTable.Columns.Add("체결기준잔고수량")

        _stockTradeTable.Clear()

        _CpConclusion.Subscribe()           '주식 체결 실시간

    End Sub

    Private Sub _CpConclusion_Received() Handles _CpConclusion.Received
        Dim row As DataRow = _stockTradeTable.NewRow

        row("계좌명") = _CpConclusion.GetHeaderValue(1)
        row("계좌번호") = _CpConclusion.GetHeaderValue(7)
        row("계좌상품") = _CpConclusion.GetHeaderValue(8)
        row("종목명") = _CpConclusion.GetHeaderValue(2)
        row("종목코드") = _CpConclusion.GetHeaderValue(9)
        row("주문번호") = _CpConclusion.GetHeaderValue(5)
        row("원주문번호") = _CpConclusion.GetHeaderValue(6)
        row("체결가격") = _CpConclusion.GetHeaderValue(4)
        row("체결수량") = _CpConclusion.GetHeaderValue(3)

        If _CpConclusion.GetHeaderValue(12) = "1" Then
            row("매매") = "매도"
        Else
            row("매매") = "매수"
        End If

        If _CpConclusion.GetHeaderValue(14) = "1" Then
            row("실시간") = "체결"
        ElseIf _CpConclusion.GetHeaderValue(14) = "2" Then
            row("실시간") = "확인"
        ElseIf _CpConclusion.GetHeaderValue(14) = "3" Then
            row("실시간") = "거부"
        ElseIf _CpConclusion.GetHeaderValue(14) = "4" Then
            row("실시간") = "접수"
        End If

        If _CpConclusion.GetHeaderValue(16) = "1" Then
            row("정정취소") = "정상"
        ElseIf _CpConclusion.GetHeaderValue(16) = "2" Then
            row("정정취소") = "정정"
        ElseIf _CpConclusion.GetHeaderValue(16) = "3" Then
            row("정정취소") = "취소"
        End If

        If _CpConclusion.GetHeaderValue(18) = "01" Then
            row("주문구분") = "보통"
        ElseIf _CpConclusion.GetHeaderValue(18) = "03" Then
            row("주문구분") = "시장가"
        ElseIf _CpConclusion.GetHeaderValue(18) = "05" Then
            row("주문구분") = "조건부지정가"
        ElseIf _CpConclusion.GetHeaderValue(18) = "12" Then
            row("주문구분") = "최유리지정가"
        ElseIf _CpConclusion.GetHeaderValue(18) = "13" Then
            row("주문구분") = "최우선지정가"
        End If

        If _CpConclusion.GetHeaderValue(19) = "0" Then
            row("주문조건") = "없음"
        ElseIf _CpConclusion.GetHeaderValue(19) = "1" Then
            row("주문조건") = "IOC"
        ElseIf _CpConclusion.GetHeaderValue(19) = "2" Then
            row("주문조건") = "FOK"
        End If

        row("장부가") = _CpConclusion.GetHeaderValue(21)
        row("체결기준잔고수량") = _CpConclusion.GetHeaderValue(23)

        _stockTradeTable.Rows.InsertAt(row, 0)

        For Each childForm As Object In Me.MdiChildren
            If childForm.Text.Length >= 5 Then
                Dim title As String = childForm.Text.Substring(1, 4)
                If title = "1301" Or title = "1302" Or title = "1303" Or title = "1304" Or title = "1401" Or title = "1402" Then
                    childForm.ReceivedStockTrade()
                End If
            End If
        Next
    End Sub

    Private Sub 주식주문종합화면ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 주식주문종합화면ToolStripMenuItem.Click
        For Each childForm As Form In Me.MdiChildren
            childForm.Close()
        Next

        Me.TradeInit()

        Dim xPos As Integer = 0
        Dim yPos As Integer = 0

        screen1201 = New Form1201()
        screen1201.MdiParent = Me
        screen1201.StartPosition = FormStartPosition.Manual
        screen1201.Location = New Point(xPos, yPos)
        screen1201.Show()

        screen1402 = New Form1402()
        screen1402.MdiParent = Me
        screen1402.StartPosition = FormStartPosition.Manual
        screen1402.Location = New Point(xPos, screen1201.Size.Height)
        screen1402.Show()

        screen1106 = New Form1106()
        screen1106.MdiParent = Me
        screen1106.StartPosition = FormStartPosition.Manual
        screen1106.Location = New Point(xPos + screen1201.Size.Width, yPos)
        screen1106.Show()

        screen1301 = New Form1301()
        screen1301.MdiParent = Me
        screen1301.StartPosition = FormStartPosition.Manual
        screen1301.Location = New Point(screen1201.Size.Width + screen1106.Size.Width, yPos)
        screen1301.Show()

        screen1304 = New Form1304()
        screen1304.MdiParent = Me
        screen1304.StartPosition = FormStartPosition.Manual
        screen1304.Location = New Point(xPos, screen1106.Size.Height)
        screen1304.Show()

        screen1401 = New Form1401()
        screen1401.MdiParent = Me
        screen1401.StartPosition = FormStartPosition.Manual
        screen1401.Location = New Point(screen1201.Size.Width + screen1106.Size.Width, screen1301.Size.Height)
        screen1401.Show()
    End Sub

    Private Sub 플러스접속ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 플러스접속ToolStripMenuItem.Click
        _cpCybos = Nothing
        _cpCybos = New CPUTILLib.CpCybos

        If _cpCybos.IsConnect = 1 Then
            MsgBox("대신증권 플러스에 이미 연결된 상태입니다.")
            Exit Sub
        End If

        If _timerConnection IsNot Nothing Then
            _timerConnection.Stop()
            _timerConnection.Dispose()
            _timerConnection = Nothing
        End If

        _timerCount = 0

        Me.ChangeMainTitleConnection()
    End Sub

    Private Sub 화면모두닫기ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 화면모두닫기ToolStripMenuItem.Click
        For Each childForm As Form In Me.MdiChildren
            childForm.Close()
        Next
    End Sub

    Private Sub 계좌별잔고현황ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 계좌별잔고현황ToolStripMenuItem.Click
        Me.TradeInit()

        screen1401 = New Form1401()
        screen1401.MdiParent = Me
        screen1401.Show()
    End Sub

    Private Sub 계좌별미체결잔량ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 계좌별미체결잔량ToolStripMenuItem.Click
        Me.TradeInit()

        screen1303 = New Form1303()
        screen1303.MdiParent = Me
        screen1303.Show()
    End Sub

    Private Sub 금일전일체결기준내역ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 금일전일체결기준내역ToolStripMenuItem.Click
        Me.TradeInit()

        screen1302 = New Form1302()
        screen1302.MdiParent = Me
        screen1302.Show()
    End Sub

    Private Sub 주식체결실시간ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 주식체결실시간ToolStripMenuItem.Click
        Me.TradeInit()

        screen1304 = New Form1304()
        screen1304.MdiParent = Me
        screen1304.Show()
    End Sub

    Private Sub 주식결제예정예수금가계산ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 주식결제예정예수금가계산ToolStripMenuItem.Click
        Me.TradeInit()

        screen1402 = New Form1402()
        screen1402.MdiParent = Me
        screen1402.Show()
    End Sub

    Private Sub 주식예약주문ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 주식예약주문ToolStripMenuItem.Click
        Me.TradeInit()

        screen1204 = New Form1204()
        screen1204.MdiParent = Me
        screen1204.Show()
    End Sub

    Private Sub 주식예약주문현황ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 주식예약주문현황ToolStripMenuItem.Click
        Me.TradeInit()

        screen1205 = New Form1205()
        screen1205.MdiParent = Me
        screen1205.Show()
    End Sub

    Public Sub ReceivedStockReservedOrder()
        For Each childForm As Object In Me.MdiChildren
            If childForm.Text.Length >= 5 Then
                Dim title As String = childForm.Text.Substring(1, 4)
                If title = "1205" Then
                    childForm.ReceivedStockReservedOrder()
                End If
            End If
        Next
    End Sub

    Public Sub ChangedStockReservedOrderNo(ByVal no As String)
        For Each childForm As Object In Me.MdiChildren
            If childForm.Text.Length >= 5 Then
                Dim title As String = childForm.Text.Substring(1, 4)
                If title = "1204" Then
                    childForm.ChangedStockReservedOrderNo(no)
                End If
            End If
        Next
    End Sub

    Public Sub ShowStockReservedOrderList()
        If screen1205 IsNot Nothing Then
            If screen1205.Visible Then
                screen1205.Close()
            End If
        End If

        screen1205 = New Form1205()
        screen1205.MdiParent = Me

        If screen1204 IsNot Nothing Then
            If screen1204.Visible = True Then
                screen1205.StartPosition = FormStartPosition.Manual
                screen1205.Location = New Point(screen1204.Location.X + screen1204.Size.Width, screen1204.Location.Y)
            End If
        End If

        screen1205.TopMost = True
        screen1205.Show()
    End Sub

    Private Sub 나의전략ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 나의전략ToolStripMenuItem.Click
        screen6101 = New Form6101()
        screen6101.MdiParent = Me
        screen6101.SetScreenType("나의 전략")
        screen6101.Show()
    End Sub

    Private Sub 예제전략ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 예제전략ToolStripMenuItem.Click
        screen6101 = New Form6101()
        screen6101.MdiParent = Me
        screen6101.SetScreenType("예제 전략")
        screen6101.Show()
    End Sub

    Private Sub 전략검색결과ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 전략검색결과ToolStripMenuItem1.Click
        screen6201 = New Form6201()
        screen6201.MdiParent = Me
        screen6201.Show()
    End Sub

    Public Sub ShowSTGResultList(ByVal id As String, ByVal name As String)
        screen6201 = New Form6201()
        screen6201.MdiParent = Me

        If screen6101 IsNot Nothing Then
            screen6201.StartPosition = FormStartPosition.Manual
            screen6201.Location = New Point(screen6101.Location.X, screen6101.Location.Y + screen6101.Size.Height)
        End If

        screen6201.TopMost = True
        screen6201.Show()
        screen6201.SetSTGInfo(id, name)
    End Sub

    Function GetRemainSB() As Integer
        Return _cpCybos.GetLimitRemainCount(CPUTILLib.LIMIT_TYPE.LT_SUBSCRIBE)
    End Function

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        _cpCybos.PlusDisconnect()
        MsgBox("대신증권 플러스 연결이 종료되었습니다.", MsgBoxStyle.OkOnly)
    End Sub

    Public Sub ShowStockOrder(ByVal sender As Object, ByVal tabIndex As Integer)
        Me.TradeInit()

        screen1201 = New Form1201()
        screen1201.MdiParent = Me
        screen1201.StartPosition = FormStartPosition.Manual

        If sender Is screen6201 Then
            screen1201.Location = New Point(screen6201.Location.X + screen6201.Size.Width, screen6201.Location.Y)
        ElseIf sender Is screen6301 Then
            screen1201.Location = New Point(screen6301.Location.X + screen6301.Size.Width, screen6301.Location.Y)
        End If

        screen1201.TopMost = True
        screen1201.Show()
        screen1201.ChangeTab(tabIndex)
    End Sub

    Public Sub SendStockOrder(ByVal bBuy As Boolean, ByVal productCode As String, ByVal quantity As String, ByVal price As String, ByVal trade As String, ByVal condition As String)
        Me.TradeInit()

        screen1201 = New Form1201()
        screen1201.MdiParent = Me
        screen1201.SendStockOrder(bBuy, productCode, quantity, price, trade, condition)
    End Sub

    Private Sub 실시간감시ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 실시간감시ToolStripMenuItem1.Click
        screen6301 = New Form6301()
        screen6301.MdiParent = Me
        screen6301.Show()
    End Sub

    Public Sub ShowSTGMonitor(ByVal id As String, ByVal name As String)
        screen6301 = New Form6301()
        screen6301.MdiParent = Me

        If screen6101 IsNot Nothing Then
            If screen6201 IsNot Nothing Then
                screen6301.StartPosition = FormStartPosition.Manual
                screen6301.Location = New Point(screen6201.Location.X, screen6201.Location.Y + screen6201.Size.Height)
            Else
                screen6301.StartPosition = FormStartPosition.Manual
                screen6301.Location = New Point(screen6101.Location.X, screen6101.Location.Y + screen6101.Size.Height)
            End If
        End If

        screen6301.TopMost = True
        screen6301.Show()
        screen6301.SetSTGInfo(id, name)
    End Sub

    Public Sub ChangeSTG(ByVal stgID As String, ByVal stgName As String)
        For Each childForm As Object In Me.MdiChildren
            If childForm.Text.Length >= 5 Then
                Dim title As String = childForm.Text.Substring(1, 4)
                If title = "6201" Or title = "6301" Then
                    childForm.SetSTGInfo(stgID, stgName)
                End If
            End If
        Next
    End Sub

    Private Sub 나의전략주문연동ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 나의전략주문연동ToolStripMenuItem.Click
        For Each childForm As Form In Me.MdiChildren
            childForm.Close()
        Next

        Me.TradeInit()

        Dim xPos As Integer = 0
        Dim yPos As Integer = 0
        Dim screenHeight As Integer = 320

        xPos = 970
        yPos = 0
        screen1201 = New Form1201()
        screen1201.MdiParent = Me
        screen1201.StartPosition = FormStartPosition.Manual
        screen1201.Location = New Point(xPos, yPos)
        screen1201.Show()

        yPos = screen1201.Height
        screen1301 = New Form1301()
        screen1301.MdiParent = Me
        screen1301.StartPosition = FormStartPosition.Manual
        screen1301.Location = New Point(xPos, yPos)
        screen1301.Show()
        screen1301.Height = screenHeight

        yPos += screen1301.Height
        screen1304 = New Form1304()
        screen1304.MdiParent = Me
        screen1304.StartPosition = FormStartPosition.Manual
        screen1304.Location = New Point(xPos, yPos)
        screen1304.Show()
        screen1304.Height = screenHeight - 40

        xPos += screen1201.Width
        yPos = 0
        screen1106 = New Form1106()
        screen1106.MdiParent = Me
        screen1106.StartPosition = FormStartPosition.Manual
        screen1106.Location = New Point(xPos, yPos)
        screen1106.Show()

        xPos = 0
        yPos = 0
        screen6101 = New Form6101()
        screen6101.MdiParent = Me
        screen6101.SetScreenType("나의 전략")
        screen6101.StartPosition = FormStartPosition.Manual
        screen6101.Location = New Point(xPos, yPos)
        screen6101.Show()
        screen6101.Height = screenHeight

        yPos += screen6101.Height
        screen6201 = New Form6201()
        screen6201.MdiParent = Me
        screen6201.StartPosition = FormStartPosition.Manual
        screen6201.Location = New Point(xPos, yPos)
        screen6201.Show()
        screen6201.Height = screenHeight

        yPos += screen6201.Height
        screen6301 = New Form6301()
        screen6301.MdiParent = Me
        screen6301.StartPosition = FormStartPosition.Manual
        screen6301.Location = New Point(xPos, yPos)
        screen6301.Show()
        screen6301.Height = screenHeight
    End Sub

    Private Sub 예제전략주문연동ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 예제전략주문연동ToolStripMenuItem.Click
        For Each childForm As Form In Me.MdiChildren
            childForm.Close()
        Next

        Me.TradeInit()

        Dim xPos As Integer = 0
        Dim yPos As Integer = 0
        Dim screenHeight As Integer = 320

        xPos = 970
        yPos = 0
        screen1201 = New Form1201()
        screen1201.MdiParent = Me
        screen1201.StartPosition = FormStartPosition.Manual
        screen1201.Location = New Point(xPos, yPos)
        screen1201.Show()

        yPos = screen1201.Height
        screen1301 = New Form1301()
        screen1301.MdiParent = Me
        screen1301.StartPosition = FormStartPosition.Manual
        screen1301.Location = New Point(xPos, yPos)
        screen1301.Show()
        screen1301.Height = screenHeight

        yPos += screen1301.Height
        screen1304 = New Form1304()
        screen1304.MdiParent = Me
        screen1304.StartPosition = FormStartPosition.Manual
        screen1304.Location = New Point(xPos, yPos)
        screen1304.Show()
        screen1304.Height = screenHeight - 50

        xPos += screen1201.Width
        yPos = 0
        screen1106 = New Form1106()
        screen1106.MdiParent = Me
        screen1106.StartPosition = FormStartPosition.Manual
        screen1106.Location = New Point(xPos, yPos)
        screen1106.Show()

        xPos = 0
        yPos = 0
        screen6101 = New Form6101()
        screen6101.MdiParent = Me
        screen6101.SetScreenType("예제 전략")
        screen6101.StartPosition = FormStartPosition.Manual
        screen6101.Location = New Point(xPos, yPos)
        screen6101.Show()
        screen6101.Height = screenHeight

        yPos += screen6101.Height
        screen6201 = New Form6201()
        screen6201.MdiParent = Me
        screen6201.StartPosition = FormStartPosition.Manual
        screen6201.Location = New Point(xPos, yPos)
        screen6201.Show()
        screen6201.Width = screen6101.Width
        screen6201.Height = screenHeight

        yPos += screen6201.Height
        screen6301 = New Form6301()
        screen6301.MdiParent = Me
        screen6301.StartPosition = FormStartPosition.Manual
        screen6301.Location = New Point(xPos, yPos)
        screen6301.Show()
        screen6301.Width = screen6101.Width
        screen6301.Height = screenHeight
    End Sub
End Class
