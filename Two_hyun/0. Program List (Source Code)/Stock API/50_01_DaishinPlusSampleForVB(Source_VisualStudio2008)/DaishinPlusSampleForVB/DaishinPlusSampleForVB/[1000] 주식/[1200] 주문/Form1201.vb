Public Class Form1201
    Dim _CpTd0311 As New CPTRADELib.CpTd0311
    Dim _CpTd0303 As New CPTRADELib.CpTd0303
    Dim _CpTd0314 As New CPTRADELib.CpTd0314

    Private _parent As Main

    Private Sub Form1201_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        _parent.CloseStockSelector(Me)
    End Sub

    Private Sub Form1201_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub Form1201_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.KeyPreview = True

        _parent = Me.ParentForm

        TextBoxName.Text = _parent.stockName
        TextBoxCode.Text = _parent.stockCode

        TextBoxBuyCount.Text = "0"
        TextBoxBuyPrice.Text = "0"

        TextBoxSellCount.Text = "0"
        TextBoxSellPrice.Text = "0"

        TextBoxModifyCount.Text = "0"
        TextBoxModifyPrice.Text = "0"

        TextBoxCancelCount.Text = "0"

        ComboBoxBuyCondition.SelectedIndex = 0
        ComboBoxBuyTrade.SelectedIndex = 0

        ComboBoxSellCondition.SelectedIndex = 0
        ComboBoxSellTrade.SelectedIndex = 0

        ComboBoxModifyCondition.SelectedIndex = 0
        ComboBoxModifyTrade.SelectedIndex = 0

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

    End Sub

    Private Sub ButtonSelectCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSelectCode.Click
        _parent.ShowStockSelector(Me)
    End Sub

    Public Sub ChangedStockCode(ByVal code As String, ByVal name As String)
        TextBoxCode.Text = code
        TextBoxName.Text = name
    End Sub

    Private Sub TextBoxCode_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBoxCode.TextChanged
        If TextBoxCode.Text.Length >= 7 Then
            TextBoxName.Text = _parent.FindStockName(TextBoxCode.Text.ToUpper)
        End If
    End Sub

    Private Sub ButtonBuyDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBuyDown.Click
        TextBoxBuyCount.Text = (CInt(TextBoxBuyCount.Text) - 1).ToString()

        If CInt(TextBoxBuyCount.Text) < 0 Then
            TextBoxBuyCount.Text = "0"
        End If
    End Sub

    Private Sub ButtonBuyUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBuyUp.Click
        TextBoxBuyCount.Text = (CInt(TextBoxBuyCount.Text) + 1).ToString()
    End Sub

    Private Sub ButtonBuyPrice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBuyPrice.Click
        _parent.ShowStockQuote(Me)
    End Sub

    Public Sub ChangeTab(ByVal index As Integer)
        TabControl1.SelectedIndex = index
    End Sub

    Public Sub ChangedStockQuote(ByVal price As String)
        If TabControl1.SelectedIndex = 0 Then
            TextBoxBuyPrice.Text = price
        ElseIf TabControl1.SelectedIndex = 1 Then
            TextBoxSellPrice.Text = price
        ElseIf TabControl1.SelectedIndex = 2 Then
            TextBoxModifyPrice.Text = price
        End If
    End Sub

    Public Sub ChangedStockCount(ByVal count As String)
        If TabControl1.SelectedIndex = 0 Then
            TextBoxBuyCount.Text = count
        ElseIf TabControl1.SelectedIndex = 1 Then
            TextBoxSellCount.Text = count
        ElseIf TabControl1.SelectedIndex = 2 Then
            TextBoxModifyCount.Text = count
        ElseIf TabControl1.SelectedIndex = 3 Then
            TextBoxCancelCount.Text = count
        End If
    End Sub

    Public Sub ChangedStockNoneTradeNo(ByVal no As String, ByVal count As String)
        If TabControl1.SelectedIndex = 2 Then
            TextBoxOriginNo.Text = no
            TextBoxModifyCount.Text = count
        ElseIf TabControl1.SelectedIndex = 3 Then
            TextBoxCancelOriginNo.Text = no
            TextBoxCancelCount.Text = count
        End If
    End Sub

    Private Sub ButtonHelp1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHelp1.Click
        _parent.ShowHelp("12011")
    End Sub

    Private Sub ButtonHelp3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        _parent.ShowHelp("12013")
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        _parent.ShowHelp("12011")
    End Sub

    Private Sub ButtonBuyAble_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBuyAble.Click
        _parent.ShowStockBuyAble()
    End Sub

    Private Sub ComboBoxAccountKind_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxAccountKind.SelectedIndexChanged
        _parent.ChangedAccountKind(ComboBoxAccountKind.SelectedItem)
    End Sub

    Private Sub ButtonSellAble_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSellAble.Click
        _parent.ShowStockSellAble()
    End Sub

    Private Sub ButtonSellDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSellDown.Click
        TextBoxSellCount.Text = (CInt(TextBoxSellCount.Text) - 1).ToString()

        If CInt(TextBoxBuyCount.Text) < 0 Then
            TextBoxSellCount.Text = "0"
        End If
    End Sub

    Private Sub ButtonSellUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSellUp.Click
        TextBoxSellCount.Text = (CInt(TextBoxSellCount.Text) + 1).ToString()
    End Sub

    Private Sub ButtonSellPrice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSellPrice.Click
        _parent.ShowStockQuote(Me)
    End Sub

    Private Sub ButtonOrderBuy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonOrderBuy.Click
        If _CpTd0311.GetDibStatus() = 1 Then
            Trace.TraceInformation("DibRq 요청 수신대기 중 입니다. 수신이 완료된 후 다시 호출 하십시오.")
            Exit Sub
        End If

        LabelMsg1.Text = ""

        _CpTd0311.SetInputValue(0, "2")                                                             ' 1:매도, 2:매수
        _CpTd0311.SetInputValue(1, TextBoxAccountNo1.Text + TextBoxAccountNo2.Text)                 ' 계좌번호
        _CpTd0311.SetInputValue(2, ComboBoxAccountKind.SelectedItem)                                ' 상품구분코드
        _CpTd0311.SetInputValue(3, TextBoxCode.Text.ToUpper())                                      ' 종목코드
        _CpTd0311.SetInputValue(4, TextBoxBuyCount.Text)                                            ' 매수수량
        _CpTd0311.SetInputValue(7, ComboBoxBuyCondition.SelectedItem.ToString().Substring(0, 1))    ' 주문조건구분코드(0:없음,1:IOC, 2:FOK)

        Dim trade As String = ComboBoxBuyTrade.SelectedItem.ToString().Substring(0, 2)
        _CpTd0311.SetInputValue(5, TextBoxBuyPrice.Text)                                            ' 매수단가
        _CpTd0311.SetInputValue(8, trade)                                                           ' 주문호가구분코드(01:보통)

        Dim result As Integer = -1
        result = _CpTd0311.BlockRequest

        LabelMsg1.Text = _CpTd0311.GetDibMsg1()
    End Sub

    Private Sub ButtonOrderSell_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonOrderSell.Click
        If _CpTd0311.GetDibStatus() = 1 Then
            Trace.TraceInformation("DibRq 요청 수신대기 중 입니다. 수신이 완료된 후 다시 호출 하십시오.")
            Exit Sub
        End If

        LabelMsg1.Text = ""

        _CpTd0311.SetInputValue(0, "1")                                                             ' 1:매도, 2:매수
        _CpTd0311.SetInputValue(1, TextBoxAccountNo1.Text + TextBoxAccountNo2.Text)                 ' 계좌번호
        _CpTd0311.SetInputValue(2, ComboBoxAccountKind.SelectedItem)                                ' 상품구분코드
        _CpTd0311.SetInputValue(3, TextBoxCode.Text.ToUpper())                                      ' 종목코드
        _CpTd0311.SetInputValue(4, TextBoxSellCount.Text)                                           ' 매도 수량
        _CpTd0311.SetInputValue(7, ComboBoxSellCondition.SelectedItem.ToString().Substring(0, 1))   ' 주문조건구분코드(0:없음,1:IOC, 2:FOK)
        
        Dim trade As String = ComboBoxSellTrade.SelectedItem.ToString().Substring(0, 2)
        _CpTd0311.SetInputValue(5, TextBoxSellPrice.Text)                                           ' 매도단가
        
        _CpTd0311.SetInputValue(8, trade)                                                           ' 주문호가구분코드(01:보통)

        Dim result As Integer = -1
        result = _CpTd0311.BlockRequest

        LabelMsg1.Text = _CpTd0311.GetDibMsg1()
    End Sub

    Private Sub ButtonHelpSell_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHelpSell.Click
        _parent.ShowHelp("12011")
    End Sub

    Private Sub ButtonHelpModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHelpModify.Click
        _parent.ShowHelp("12013")
    End Sub

    Private Sub ButtonModifyDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonModifyDown.Click
        TextBoxModifyCount.Text = (CInt(TextBoxModifyCount.Text) - 1).ToString()

        If CInt(TextBoxModifyCount.Text) < 0 Then
            TextBoxModifyCount.Text = "0"
        End If
    End Sub

    Private Sub ButtonModifyUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonModifyUp.Click
        TextBoxModifyCount.Text = (CInt(TextBoxModifyCount.Text) + 1).ToString()
    End Sub

    Private Sub ButtonModifyPrice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonModifyPrice.Click
        _parent.ShowStockQuote(Me)
    End Sub

    Private Sub ButtonOrderModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonOrderModify.Click
        If _CpTd0303.GetDibStatus() = 1 Then
            Trace.TraceInformation("DibRq 요청 수신대기 중 입니다. 수신이 완료된 후 다시 호출 하십시오.")
            Exit Sub
        End If

        If TextBoxOriginNo.Text = "" Then
            MsgBox("원주문번호를 입력하세요")
            Exit Sub
        End If

        LabelMsg1.Text = ""

        _CpTd0303.SetInputValue(1, TextBoxOriginNo.Text)
        _CpTd0303.SetInputValue(2, TextBoxAccountNo1.Text + TextBoxAccountNo2.Text)
        _CpTd0303.SetInputValue(3, ComboBoxAccountKind.SelectedItem)
        _CpTd0303.SetInputValue(4, TextBoxCode.Text.ToUpper())
        _CpTd0303.SetInputValue(5, TextBoxModifyCount.Text)
        _CpTd0303.SetInputValue(8, ComboBoxModifyCondition.SelectedItem.ToString().Substring(0, 1))
        
        Dim trade As String = ComboBoxModifyTrade.SelectedItem.ToString().Substring(0, 2)
        'If trade = "03" Or trade = "12" Or trade = "13" Then
        '_CpTd0303.SetInputValue(6, "0")
        'Else
        _CpTd0303.SetInputValue(6, TextBoxModifyPrice.Text)
        'End If

        _CpTd0303.SetInputValue(9, trade)

        Dim result As Integer = -1
        result = _CpTd0303.BlockRequest

        LabelMsg1.Text = _CpTd0303.GetDibMsg1()
    End Sub

    Private Sub ButtonModifyNoneTrade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonModifyNoneTrade.Click
        _parent.ShowStockNoneTrade()
    End Sub

    Private Sub TextBoxOriginNo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBoxOriginNo.GotFocus
        If TextBoxOriginNo.Text = "원주문번호" Then
            TextBoxOriginNo.Text = ""
        End If
    End Sub

    Private Sub ButtonCancelDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancelDown.Click
        TextBoxCancelCount.Text = (CInt(TextBoxCancelCount.Text) - 1).ToString()

        If CInt(TextBoxCancelCount.Text) < 0 Then
            TextBoxCancelCount.Text = "0"
        End If
    End Sub

    Private Sub ButtonCancelUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancelUp.Click
        TextBoxCancelCount.Text = (CInt(TextBoxCancelCount.Text) + 1).ToString()
    End Sub

    Private Sub ButtonCancelNoneTrade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancelNoneTrade.Click
        _parent.ShowStockNoneTrade()
    End Sub

    Private Sub TextBoxCancelOriginNo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBoxCancelOriginNo.GotFocus
        If TextBoxCancelOriginNo.Text = "원주문번호" Then
            TextBoxCancelOriginNo.Text = ""
        End If
    End Sub

    Private Sub ButtonHelpCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHelpCancel.Click
        _parent.ShowHelp("12014")
    End Sub

    Private Sub ButtonOrderCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonOrderCancel.Click
        If _CpTd0314.GetDibStatus() = 1 Then
            Trace.TraceInformation("DibRq 요청 수신대기 중 입니다. 수신이 완료된 후 다시 호출 하십시오.")
            Exit Sub
        End If

        If TextBoxCancelOriginNo.Text = "" Then
            MsgBox("원주문번호를 입력하세요")
            Exit Sub
        End If

        LabelMsg1.Text = ""

        _CpTd0314.SetInputValue(1, TextBoxCancelOriginNo.Text)
        _CpTd0314.SetInputValue(2, TextBoxAccountNo1.Text + TextBoxAccountNo2.Text)
        _CpTd0314.SetInputValue(3, ComboBoxAccountKind.SelectedItem)
        _CpTd0314.SetInputValue(4, TextBoxCode.Text.ToUpper())
        _CpTd0314.SetInputValue(5, TextBoxCancelCount.Text)

        Dim result As Integer = -1
        result = _CpTd0314.BlockRequest

        LabelMsg1.Text = _CpTd0314.GetDibMsg1()
    End Sub

    Public Sub SendStockOrder(ByVal bBuy As Boolean, ByVal productCode As String, ByVal quantity As String, ByVal price As String, ByVal trade As String, ByVal condition As String)
        _parent = Me.ParentForm

        _CpTd0311.SetInputValue(1, _parent.accountNo)                                               ' 계좌번호
        _CpTd0311.SetInputValue(2, _parent.accountGoodsStock)                                       ' 상품구분코드
        _CpTd0311.SetInputValue(3, productCode)                                                     ' 종목코드
        _CpTd0311.SetInputValue(4, quantity)                                                        ' 매수수량
        _CpTd0311.SetInputValue(7, condition)                                                       ' 주문조건구분코드(0:없음,1:IOC, 2:FOK)
        _CpTd0311.SetInputValue(5, price)                                                           ' 매수단가
        _CpTd0311.SetInputValue(8, trade)                                                           ' 주문호가구분코드(01:보통)

        If bBuy Then
            _CpTd0311.SetInputValue(0, "2")                                                         ' 1:매도, 2:매수
        Else
            _CpTd0311.SetInputValue(0, "1")                                                         ' 1:매도, 2:매수
        End If

        _CpTd0311.BlockRequest()
    End Sub

End Class