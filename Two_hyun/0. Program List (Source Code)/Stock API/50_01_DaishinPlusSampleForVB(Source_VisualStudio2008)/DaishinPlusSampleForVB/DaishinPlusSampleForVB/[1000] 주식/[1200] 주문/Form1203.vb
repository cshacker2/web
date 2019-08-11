Public Class Form1203
    Private _parent As Main

    Dim _CpTdNew5331B As New CPTRADELib.CpTdNew5331B

    Dim _TableCount As DataTable = New DataTable

    Private Sub Form1203_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        _parent.CloseStockSelector(Me)
    End Sub

    Private Sub Form1203_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub Form1203_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.KeyPreview = True

        _parent = Me.ParentForm

        ButtonNext.Enabled = False

        _TableCount.Columns.Add("종목명")
        _TableCount.Columns.Add("잔고수량")
        _TableCount.Columns.Add("전일매수체결수량")
        _TableCount.Columns.Add("전일매도체결수량")
        _TableCount.Columns.Add("지정수량")
        _TableCount.Columns.Add("금일매수체결수량")
        _TableCount.Columns.Add("금일매도체결수량")
        _TableCount.Columns.Add("매도가능수량")

        DataGridView1.DataSource = _TableCount
        DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader
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

        ComboBoxQueryKind.SelectedIndex = 1

        TextBoxName.Text = _parent.stockName
        TextBoxCode.Text = _parent.stockCode
    End Sub

    Private Sub ComboBoxAccountKind_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxAccountKind.SelectedIndexChanged
        If TextBoxCode.Text.Length >= 7 Then
            _parent.ChangedAccountKind(ComboBoxAccountKind.SelectedItem)
            Me.Request(True)
        End If
    End Sub

    Private Sub ButtonQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonQuery.Click
        If ComboBoxQueryKind.SelectedIndex = 0 Then
            Me.Request(True)
        Else
            Me.Request(False)
        End If
    End Sub

    Private Sub ButtonHelp1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHelp1.Click
        _parent.ShowHelp("1203")
    End Sub

    Private Sub Request(ByVal bEach As Boolean)
        If _CpTdNew5331B.GetDibStatus() = 1 Then
            Trace.TraceInformation("DibRq 요청 수신대기 중 입니다. 수신이 완료된 후 다시 호출 하십시오.")
            Exit Sub
        End If

        If bEach Then
            If TextBoxCode.Text.Length < 7 Then
                Exit Sub
            End If
        End If

        _TableCount.Clear()

        _CpTdNew5331B.SetInputValue(0, TextBoxAccountNo1.Text + TextBoxAccountNo2.Text)
        _CpTdNew5331B.SetInputValue(1, ComboBoxAccountKind.SelectedItem)
        If bEach Then
            _CpTdNew5331B.SetInputValue(2, TextBoxCode.Text.ToUpper())
        Else
            _CpTdNew5331B.SetInputValue(2, "")
        End If

        _CpTdNew5331B.SetInputValue(10, 20)

        ButtonNext.Enabled = False

        Me.JustRequest()
    End Sub

    Private Sub JustRequest()
        LabelMsg1.Text = ""
        LabelContinue.Text = ""

        Dim result As Integer = -1
        result = _CpTdNew5331B.BlockRequest

        LabelMsg1.Text = _CpTdNew5331B.GetDibMsg1()

        If _CpTdNew5331B.Continue = 1 Then
            LabelContinue.Text = "연속 데이터 있음"
            ButtonNext.Enabled = True
        Else
            LabelContinue.Text = "연속 데이터 없음"
            ButtonNext.Enabled = False
        End If

        If result = 0 Then
            For i As Integer = 0 To _CpTdNew5331B.GetHeaderValue(0) - 1
                Dim rowPrice As DataRow = _TableCount.NewRow

                rowPrice(0) = _CpTdNew5331B.GetDataValue(1, i)
                rowPrice(1) = _CpTdNew5331B.GetDataValue(6, i)
                rowPrice(2) = _CpTdNew5331B.GetDataValue(7, i)
                rowPrice(3) = _CpTdNew5331B.GetDataValue(8, i)
                rowPrice(4) = _CpTdNew5331B.GetDataValue(9, i)
                rowPrice(5) = _CpTdNew5331B.GetDataValue(10, i)
                rowPrice(6) = _CpTdNew5331B.GetDataValue(11, i)
                rowPrice(7) = _CpTdNew5331B.GetDataValue(12, i)

                _TableCount.Rows.Add(rowPrice)
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
                Me.Request(True)
            Else
                ComboBoxQueryKind.SelectedIndex = 1
            End If
        End If
    End Sub

    Private Sub DataGridView1_DataBindingComplete(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles DataGridView1.DataBindingComplete
        DataGridView1.ClearSelection()
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If DataGridView1.SelectedCells.Count > 0 Then
            Dim cell As DataGridViewCell = DataGridView1.SelectedCells(0)
            _parent.ChangedStockCount(cell.Value)
        End If
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If DataGridView1.SelectedCells.Count > 0 Then
            Dim cell As DataGridViewCell = DataGridView1.SelectedCells(0)
            _parent.ChangedStockCount(cell.Value)
            Me.Close()
        End If
    End Sub

    Private Sub ButtonNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonNext.Click
        Me.JustRequest()
    End Sub

    Private Sub ComboBoxQueryKind_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxQueryKind.SelectedIndexChanged
        If ComboBoxQueryKind.SelectedIndex = 0 Then
            Me.Request(True)
        Else
            Me.Request(False)
        End If
    End Sub

End Class