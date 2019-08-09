Public Class FormHelp

    Public _screenNo As String

    Public Sub SetScreen(ByVal screen As String)
        _screenNo = screen
    End Sub

    Private Sub FormHelp_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.KeyPreview = True
    End Sub

    Private Sub FormHelp_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub FormHelp_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Dim title As String
        title = "(도움말) "

        If _screenNo = "11011" Then
            title += "주식현재가 (단일종목) 조회"
            WebBrowser1.Navigate("http://money2.daishin.com/e5/mboard/ptype_basic/HTS_Plus_Helper/DW_Basic_Read.aspx?boardseq=288&seq=3&page=6&searchString=&p=&v=&m=")
        ElseIf _screenNo = "11012" Then
            title += "관심종목 실시간"
            WebBrowser1.Navigate("http://money2.daishin.com/e5/mboard/ptype_basic/HTS_Plus_Helper/DW_Basic_Read.aspx?boardseq=288&seq=16&page=6&searchString=&p=&v=&m=")
        ElseIf _screenNo = "10001" Then
            title += "주식 종목정보 조회"
            WebBrowser1.Navigate("http://money2.daishin.com/e5/mboard/ptype_basic/HTS_Plus_Helper/DW_Basic_Read.aspx?boardseq=287&seq=5&page=1&searchString=&p=&v=&m=")
        ElseIf _screenNo = "1102" Then
            title += "주식현재가 (복수종목) 조회"
            WebBrowser1.Navigate("http://money2.daishin.com/e5/mboard/ptype_basic/HTS_Plus_Helper/DW_Basic_Read.aspx?boardseq=285&seq=131&page=1&searchString=marketeye&p=&v=&m=")
        ElseIf _screenNo = "11021" Then
            title += "주식현재가 (복수종목) 실시간"
            WebBrowser1.Navigate("http://money2.daishin.com/e5/mboard/ptype_basic/HTS_Plus_Helper/DW_Basic_Read.aspx?boardseq=288&seq=16&page=6&searchString=&p=&v=&m=")
        ElseIf _screenNo = "1103" Then
            title += "투자주체별 현황"
            WebBrowser1.Navigate("http://money2.daishin.com/e5/mboard/ptype_basic/HTS_Plus_Helper/DW_Basic_Read.aspx?boardseq=294&seq=242&page=1&searchString=&p=&v=&m=")
        ElseIf _screenNo = "1104" Then
            title += "주식 시간대별 체결"
            WebBrowser1.Navigate("http://money2.daishin.com/e5/mboard/ptype_basic/HTS_Plus_Helper/DW_Basic_Read.aspx?boardseq=288&seq=22&page=5&searchString=&p=&v=&m=")
        ElseIf _screenNo = "1105" Then
            title += "주식 일자별 주가"
            WebBrowser1.Navigate("http://money2.daishin.com/e5/mboard/ptype_basic/HTS_Plus_Helper/DW_Basic_Read.aspx?boardseq=288&seq=23&page=5&searchString=&p=&v=&m=")
        ElseIf _screenNo = "11061" Then
            title += "주식 호가 (조회)"
            WebBrowser1.Navigate("http://money2.daishin.com/e5/mboard/ptype_basic/HTS_Plus_Helper/DW_Basic_Read.aspx?boardseq=288&seq=20&page=5&searchString=&p=&v=&m=")
        ElseIf _screenNo = "11062" Then
            title += "주식 호가 (실시간)"
            WebBrowser1.Navigate("http://money2.daishin.com/e5/mboard/ptype_basic/HTS_Plus_Helper/DW_Basic_Read.aspx?boardseq=288&seq=21&page=5&searchString=&p=&v=&m=")
        ElseIf _screenNo = "12011" Then
            title += "주식 현금주문(매수/매도)"
            WebBrowser1.Navigate("http://money2.daishin.com/e5/mboard/ptype_basic/HTS_Plus_Helper/DW_Basic_Read.aspx?boardseq=291&seq=159&page=3&searchString=&p=&v=&m=")
        ElseIf _screenNo = "12013" Then
            title += "주식 현금주문(유형정정)"
            WebBrowser1.Navigate("http://money2.daishin.com/e5/mboard/ptype_basic/HTS_Plus_Helper/DW_Basic_Read.aspx?boardseq=291&seq=166&page=2&searchString=&p=&v=&m=")
        ElseIf _screenNo = "12014" Then
            title += "주식 현금주문(취소)"
            WebBrowser1.Navigate("http://money2.daishin.com/e5/mboard/ptype_basic/HTS_Plus_Helper/DW_Basic_Read.aspx?boardseq=291&seq=162&page=2&searchString=&p=&v=&m=")
        ElseIf _screenNo = "1202" Then
            title += "주식 계좌별 매수 가능금액/수량"
            WebBrowser1.Navigate("http://money2.daishin.com/e5/mboard/ptype_basic/HTS_Plus_Helper/DW_Basic_Read.aspx?boardseq=291&seq=171&page=2&searchString=&p=&v=&m=")
        ElseIf _screenNo = "1203" Then
            title += "주식 계좌별 매도 가능수량"
            WebBrowser1.Navigate("http://money2.daishin.com/e5/mboard/ptype_basic/HTS_Plus_Helper/DW_Basic_Read.aspx?boardseq=291&seq=172&page=2&searchString=&p=&v=&m=")
        ElseIf _screenNo = "12041" Then
            title += "주식 예약주문"
            WebBrowser1.Navigate("http://money2.daishin.com/e5/mboard/ptype_basic/HTS_Plus_Helper/DW_Basic_Read.aspx?boardseq=291&seq=187&page=1&searchString=&p=&v=&m=")
        ElseIf _screenNo = "12042" Then
            title += "주식 예약취소주문"
            WebBrowser1.Navigate("http://money2.daishin.com/e5/mboard/ptype_basic/HTS_Plus_Helper/DW_Basic_Read.aspx?boardseq=291&seq=188&page=1&searchString=&p=&v=&m=")
        ElseIf _screenNo = "1205" Then
            title += "주식 예약주문현황"
            WebBrowser1.Navigate("http://money2.daishin.com/e5/mboard/ptype_basic/HTS_Plus_Helper/DW_Basic_Read.aspx?boardseq=291&seq=189&page=1&searchString=&p=&v=&m=")
        ElseIf _screenNo = "1301" Then
            title += "금일 계좌별 주문/체결내역"
            WebBrowser1.Navigate("http://money2.daishin.com/e5/mboard/ptype_basic/HTS_Plus_Helper/DW_Basic_Read.aspx?boardseq=291&seq=174&page=2&searchString=&p=&v=&m=")
        ElseIf _screenNo = "1302" Then
            title += "금일/전일 체결기준 내역"
            WebBrowser1.Navigate("http://money2.daishin.com/e5/mboard/ptype_basic/HTS_Plus_Helper/DW_Basic_Read.aspx?boardseq=291&seq=175&page=2&searchString=&p=&v=&m=")
        ElseIf _screenNo = "1303" Then
            title += "계좌별 미체결잔량"
            WebBrowser1.Navigate("http://money2.daishin.com/e5/mboard/ptype_basic/HTS_Plus_Helper/DW_Basic_Read.aspx?boardseq=291&seq=173&page=2&searchString=&p=&v=&m=")
        ElseIf _screenNo = "1304" Then
            title += "주식 체결 실시간"
            WebBrowser1.Navigate("http://money2.daishin.com/e5/mboard/ptype_basic/HTS_Plus_Helper/DW_Basic_Read.aspx?boardseq=291&seq=155&page=3&searchString=&p=&v=&m=")
        ElseIf _screenNo = "1401" Then
            title += "계좌별 잔고 평가현황"
            WebBrowser1.Navigate("http://money2.daishin.com/e5/mboard/ptype_basic/HTS_Plus_Helper/DW_Basic_Read.aspx?boardseq=291&seq=176&page=2&searchString=&p=&v=&m=")
        ElseIf _screenNo = "1402" Then
            title += "주식 결제예정예수금 가계산"
            WebBrowser1.Navigate("http://money2.daishin.com/e5/mboard/ptype_basic/HTS_Plus_Helper/DW_Basic_Read.aspx?boardseq=291&seq=169&page=2&searchString=&p=&v=&m=")
        ElseIf _screenNo = "6101" Or _screenNo = "6102" Then
            title += "종목검색 전략명, 전략ID 리스트"
            WebBrowser1.Navigate("http://money2.daishin.com/e5/mboard/ptype_basic/HTS_Plus_Helper/DW_Basic_Read_Page.aspx?boardseq=284&seq=237&page=2&searchString=&p=8839&v=8642&m=9508")
        ElseIf _screenNo = "6201" Then
            title += "종목검색 검색 종목 리스트"
            WebBrowser1.Navigate("http://money2.daishin.com/e5/mboard/ptype_basic/HTS_Plus_Helper/DW_Basic_Read_Page.aspx?boardseq=284&seq=238&page=2&searchString=&p=8839&v=8642&m=9508")
        ElseIf _screenNo = "6301" Then
            title += "실시간 감시"
            WebBrowser1.Navigate("http://money2.daishin.com/e5/mboard/ptype_basic/HTS_Plus_Helper/DW_Basic_Read_Page.aspx?boardseq=284&seq=239&page=2&searchString=&p=8839&v=8642&m=9508")
        End If

        Me.Text = title

    End Sub

End Class