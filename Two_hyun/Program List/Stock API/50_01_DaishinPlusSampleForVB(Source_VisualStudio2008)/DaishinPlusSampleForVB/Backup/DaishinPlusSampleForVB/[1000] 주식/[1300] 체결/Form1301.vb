Public Class Form1301
    Private _parent As Main

    Dim _CpTd5341 As CPTRADELib.CpTd5341

    Dim _Table As DataTable = New DataTable

    Dim bQuery As Boolean = False

    Private Sub Form1301_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        _parent.CloseStockSelector(Me)
    End Sub

    Private Sub Form1301_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub Form1301_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.KeyPreview = True

        bQuery = False

        _parent = Me.ParentForm

        _CpTd5341 = New CPTRADELib.CpTd5341

        ButtonNext.Enabled = False

        _Table.Columns.Add("주문번호")
        _Table.Columns.Add("원주문번호")
        _Table.Columns.Add("종목명")
        _Table.Columns.Add("거래")
        _Table.Columns.Add("정정취소")
        _Table.Columns.Add("매매구분")
        _Table.Columns.Add("주문수량")
        _Table.Columns.Add("주문단가")
        _Table.Columns.Add("체결수량")
        _Table.Columns.Add("체결단가")

        DataGridView1.DataSource = _Table
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

        TextBoxName.Text = _parent.stockName
        TextBoxCode.Text = _parent.stockCode

        If selectedIndex <> -1 Then
            ComboBoxAccountKind.SelectedIndex = selectedIndex
        End If

        bQuery = True

        ComboBoxQueryKind.SelectedIndex = 0
    End Sub

    Private Sub ComboBoxAccountKind_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxAccountKind.SelectedIndexChanged
        If TextBoxCode.Text.Length >= 7 Then
            _parent.ChangedAccountKind(ComboBoxAccountKind.SelectedItem)
            Me.Request(True)
        End If
    End Sub

    Private Sub ButtonQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonQuery.Click
        If ComboBoxQueryKind.SelectedIndex = 0 Then
            Me.Request(False)
        Else
            Me.Request(True)
        End If
    End Sub

    Private Sub ButtonHelp1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHelp1.Click
        _parent.ShowHelp("1301")
    End Sub

    Private Sub Request(ByVal bEach As Boolean)
        If bQuery = False Then
            Return
        End If

        If _CpTd5341.GetDibStatus() = 1 Then
            Trace.TraceInformation("DibRq 요청 수신대기 중 입니다. 수신이 완료된 후 다시 호출 하십시오.")
            Exit Sub
        End If

        If bEach Then
            If TextBoxCode.Text.Length < 7 Then
                Exit Sub
            End If
        End If

        _Table.Clear()
        DataGridView1.Refresh()

        _CpTd5341.SetInputValue(0, TextBoxAccountNo1.Text + TextBoxAccountNo2.Text)
        _CpTd5341.SetInputValue(1, ComboBoxAccountKind.SelectedItem)
        If bEach Then
            _CpTd5341.SetInputValue(2, TextBoxCode.Text.ToUpper())
        Else
            _CpTd5341.SetInputValue(2, "")
        End If

        _CpTd5341.SetInputValue(3, 0)
        _CpTd5341.SetInputValue(4, Asc("1"))
        _CpTd5341.SetInputValue(5, 20)
        _CpTd5341.SetInputValue(6, Asc("2"))

        ButtonNext.Enabled = False

        Me.JustRequest()
    End Sub

    Private Sub JustRequest()
        LabelMsg1.Text = ""
        LabelContinue.Text = ""

        Dim result As Integer = -1
        Try
            result = _CpTd5341.BlockRequest
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        LabelMsg1.Text = _CpTd5341.GetDibMsg1()

        If _CpTd5341.Continue = 1 Then
            LabelContinue.Text = "연속 데이터 있음"
            ButtonNext.Enabled = True
        Else
            LabelContinue.Text = "연속 데이터 없음"
            ButtonNext.Enabled = False
        End If

        If result = 0 Then
            For i As Integer = 0 To _CpTd5341.GetHeaderValue(6) - 1
                Dim rowOrder As DataRow = _Table.NewRow

                rowOrder(0) = _CpTd5341.GetDataValue(1, i)
                rowOrder(1) = _CpTd5341.GetDataValue(2, i)
                rowOrder(2) = _CpTd5341.GetDataValue(4, i)

                If _CpTd5341.GetDataValue(35, i) = "1" Then
                    rowOrder(3) = "매도"
                Else
                    rowOrder(3) = "매수"
                End If

                rowOrder(4) = _CpTd5341.GetDataValue(13, i)
                rowOrder(5) = _CpTd5341.GetDataValue(6, i)
                rowOrder(6) = _CpTd5341.GetDataValue(7, i)
                rowOrder(7) = _CpTd5341.GetDataValue(8, i)
                rowOrder(8) = _CpTd5341.GetDataValue(10, i)
                rowOrder(9) = _CpTd5341.GetDataValue(11, i)

                _Table.Rows.Add(rowOrder)
            Next

            DataGridView1.Refresh()
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
                ComboBoxQueryKind.SelectedIndex = 1
            Else
                Me.Request(True)
            End If
        End If
    End Sub

    Private Sub DataGridView1_DataBindingComplete(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles DataGridView1.DataBindingComplete
        DataGridView1.ClearSelection()
    End Sub

    Private Sub ButtonNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonNext.Click
        Me.JustRequest()
    End Sub

    Private Sub ComboBoxQueryKind_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxQueryKind.SelectedIndexChanged
        If ComboBoxQueryKind.SelectedIndex = 0 Then
            Me.Request(False)
        Else
            Me.Request(True)
        End If
    End Sub

    Private Sub DataGridView1_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        If DataGridView1.Item(3, e.RowIndex).Value.ToString().Contains("매수") Then
            DataGridView1.Rows(e.RowIndex).Cells(3).Style.ForeColor = Color.Red
        Else
            DataGridView1.Rows(e.RowIndex).Cells(3).Style.ForeColor = Color.Blue
        End If

        If DataGridView1.Item(4, e.RowIndex).Value.ToString().Contains("정정") Then
            DataGridView1.Rows(e.RowIndex).Cells(4).Style.ForeColor = Color.Green
        ElseIf DataGridView1.Item(4, e.RowIndex).Value.ToString().Contains("취소") Then
            DataGridView1.Rows(e.RowIndex).Cells(4).Style.ForeColor = Color.FromArgb(236, 77, 0)
        End If
    End Sub

    Public Sub ReceivedStockTrade()
        Me.ButtonQuery_Click(Nothing, Nothing)
    End Sub

End Class