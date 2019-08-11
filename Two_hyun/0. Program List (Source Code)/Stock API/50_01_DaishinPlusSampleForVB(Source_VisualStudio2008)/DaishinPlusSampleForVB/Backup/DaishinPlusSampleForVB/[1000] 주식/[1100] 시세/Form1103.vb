Public Class Form1103

    Private _parent As Main

    Public WithEvents _CpSvr7254 As CPSYSDIBLib.CpSvr7254

    Dim _Table1 As DataTable = New DataTable
    Dim _Table2 As DataTable = New DataTable

    Private Sub Form1103_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.KeyPreview = True

        _parent = Me.ParentForm

        _CpSvr7254 = New CPSYSDIBLib.CpSvr7254

        Dim table As DataTable
        Dim grid As DataGridView

        For i As Integer = 0 To 13
            If i = 0 Then
                table = _Table1
                table.Columns.Add("일자")
                table.Columns.Add("개인")
                table.Columns.Add("외국인")
                table.Columns.Add("기관계")
                table.Columns.Add("금융투자")
                table.Columns.Add("보험")
                table.Columns.Add("투신")
                table.Columns.Add("은행")
                table.Columns.Add("기타금융")
                table.Columns.Add("연기금")
                table.Columns.Add("기타법인")
                table.Columns.Add("기타외인")
                table.Columns.Add("사모펀드")
                table.Columns.Add("국가지자체")
                table.Columns.Add("종가")
                grid = DataGridView1
            Else
                table = _Table2
                table.Columns.Clear()

                table.Columns.Add("일자")
                table.Columns.Add("매도수량")
                table.Columns.Add("매도수량비중")
                table.Columns.Add("매도금액")
                table.Columns.Add("매도금액비중")
                table.Columns.Add("매수수량")
                table.Columns.Add("매수수량비중")
                table.Columns.Add("매수금액")
                table.Columns.Add("매수금액비중")
                table.Columns.Add("일별순매수수량")
                table.Columns.Add("일별순매수금액")

                If i = 1 Then
                    grid = DataGridView2
                ElseIf i = 2 Then
                    grid = DataGridView3
                ElseIf i = 3 Then
                    grid = DataGridView4
                ElseIf i = 4 Then
                    grid = DataGridView5
                ElseIf i = 5 Then
                    grid = DataGridView6
                ElseIf i = 6 Then
                    grid = DataGridView7
                ElseIf i = 7 Then
                    grid = DataGridView8
                ElseIf i = 8 Then
                    grid = DataGridView9
                ElseIf i = 9 Then
                    grid = DataGridView10
                ElseIf i = 10 Then
                    grid = DataGridView11
                ElseIf i = 11 Then
                    grid = DataGridView12
                ElseIf i = 12 Then
                    grid = DataGridView13
                ElseIf i = 13 Then
                    grid = DataGridView14
                Else
                    Exit For
                End If
            End If

            grid.DataSource = table
            grid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            grid.AllowUserToResizeRows = False
            grid.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
            grid.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            grid.Refresh()
        Next i

        TextBoxName.Text = _parent.stockName
        TextBoxCode.Text = _parent.stockCode

        DateTimePickerFrom.Enabled = False
        DateTimePickerTo.Enabled = False

        ButtonNext.Enabled = False

        ComboBoxPeriod.SelectedIndex = 6
        ComboBoxData.SelectedIndex = 0
        ComboBoxTrade.SelectedIndex = 0

    End Sub

    Private Sub Form1103_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub Form1103_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        _parent.CloseStockSelector(Me)
    End Sub

    Public Sub ChangedStockCode(ByVal code As String, ByVal name As String)
        TextBoxCode.Text = code
        TextBoxName.Text = name
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        _parent.ShowHelp("1103")
    End Sub

    Private Sub RefreshCurrentTab()
        Dim table As DataTable
        Dim grid As DataGridView

        Dim i As Integer = TabControl1.SelectedIndex

        If i = 0 Then
            table = _Table1

            grid = DataGridView1
        Else
            table = _Table2

            If i = 1 Then
                grid = DataGridView2
            ElseIf i = 2 Then
                grid = DataGridView3
            ElseIf i = 3 Then
                grid = DataGridView4
            ElseIf i = 4 Then
                grid = DataGridView5
            ElseIf i = 5 Then
                grid = DataGridView6
            ElseIf i = 6 Then
                grid = DataGridView7
            ElseIf i = 7 Then
                grid = DataGridView8
            ElseIf i = 8 Then
                grid = DataGridView9
            ElseIf i = 9 Then
                grid = DataGridView10
            ElseIf i = 10 Then
                grid = DataGridView11
            ElseIf i = 11 Then
                grid = DataGridView12
            ElseIf i = 12 Then
                grid = DataGridView13
            ElseIf i = 13 Then
                grid = DataGridView14
            Else
                Exit Sub
            End If
        End If

        grid.Refresh()

    End Sub

    Private Sub ButtonQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonQuery.Click
        Me.Request()
    End Sub

    Private Sub Request()
        If _CpSvr7254.GetDibStatus() = 1 Then
            Trace.TraceInformation("DibRq 요청 수신대기 중 입니다. 수신이 완료된 후 다시 호출 하십시오.")
            Exit Sub
        End If

        LabelMsg1.Text = ""
        LabelMsg2.Text = ""
        LabelContinue.Text = ""

        If ComboBoxPeriod.SelectedIndex = -1 Or ComboBoxData.SelectedIndex = -1 Or ComboBoxTrade.SelectedIndex = -1 Then
            Exit Sub
        End If

        If TextBoxCode.Text.Length < 7 Then
            MsgBox("종목을 선택해주세요")
            Exit Sub
        End If

        If ComboBoxPeriod.SelectedIndex.ToString() = "0" Then
            If DateTimePickerFrom.Value.ToString("yyyyMMdd").Length < 8 Then
                MsgBox("조회 시작 날짜를 선택해주세요")
                Exit Sub
            End If

            If DateTimePickerTo.Value.ToString("yyyyMMdd").Length < 8 Then
                MsgBox("조회 끝 날짜를 선택해주세요")
                Exit Sub
            End If
        End If

        _Table1.Clear()
        _Table2.Clear()
        Me.RefreshCurrentTab()

        ButtonNext.Enabled = False

        _CpSvr7254.SetInputValue(0, TextBoxCode.Text.ToUpper())
        _CpSvr7254.SetInputValue(1, ComboBoxPeriod.SelectedIndex.ToString())
        _CpSvr7254.SetInputValue(2, DateTimePickerFrom.Value.ToString("yyyyMMdd"))
        _CpSvr7254.SetInputValue(3, DateTimePickerTo.Value.ToString("yyyyMMdd"))
        _CpSvr7254.SetInputValue(4, Asc(ComboBoxTrade.SelectedIndex.ToString()))
        _CpSvr7254.SetInputValue(5, TabControl1.SelectedIndex.ToString())
        _CpSvr7254.SetInputValue(6, Asc((ComboBoxData.SelectedIndex + 1).ToString()))

        Trace.TraceInformation("****************** RQ ******************")
        Trace.TraceInformation("기간 : " + ComboBoxPeriod.SelectedIndex.ToString())
        Trace.TraceInformation("From : " + DateTimePickerFrom.Value.ToString("yyyyMMdd"))
        Trace.TraceInformation("To : " + DateTimePickerTo.Value.ToString("yyyyMMdd"))
        Trace.TraceInformation("투자자 : " + TabControl1.SelectedIndex.ToString())
        Trace.TraceInformation("데이터구분 : " + (ComboBoxData.SelectedIndex + 1).ToString())
        Trace.TraceInformation("매매비중 : " + ComboBoxTrade.SelectedIndex.ToString())

        Me.JustRequest()
    End Sub

    Private Sub ComboBoxPeriod_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxPeriod.SelectedIndexChanged
        If ComboBoxPeriod.SelectedIndex = 0 Then
            DateTimePickerFrom.Enabled = True
            DateTimePickerTo.Enabled = True
        Else
            DateTimePickerFrom.Enabled = False
            DateTimePickerTo.Enabled = False
        End If

        If ComboBoxPeriod.SelectedIndex = 6 Then
            ComboBoxTrade.Enabled = True

            If ComboBoxTrade.SelectedIndex = 0 Then
                ComboBoxData.Enabled = True
            Else
                ComboBoxData.Enabled = False
            End If
        Else
            ComboBoxTrade.Enabled = False
            ComboBoxData.Enabled = True
        End If

        Me.Request()
    End Sub

    Private Sub ComboBoxTrade_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxTrade.SelectedIndexChanged
        If ComboBoxTrade.SelectedIndex = 0 Then
            ComboBoxData.Enabled = True
        Else
            ComboBoxData.Enabled = False
        End If

        Me.Request()
    End Sub

    Private Sub ComboBoxData_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxData.SelectedIndexChanged
        Me.Request()
    End Sub

    Private Sub ButtonNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonNext.Click
        Me.JustRequest()
    End Sub

    Private Sub JustRequest()
        If _CpSvr7254.GetDibStatus() = 1 Then
            Trace.TraceInformation("DibRq 요청 수신대기 중 입니다. 수신이 완료된 후 다시 호출 하십시오.")
            Exit Sub
        End If

        Dim result As Integer = -1
        result = _CpSvr7254.BlockRequest

        LabelMsg1.Text = _CpSvr7254.GetDibMsg1()
        LabelMsg2.Text = _CpSvr7254.GetDibMsg2()
        If _CpSvr7254.Continue = 1 Then
            LabelContinue.Text = "연속 데이터 있음"
            ButtonNext.Enabled = True
        Else
            LabelContinue.Text = "연속 데이터 없음"
            ButtonNext.Enabled = False
        End If

        If result = 0 Then
            Dim table As DataTable

            If TabControl1.SelectedIndex = 0 Then
                table = _Table1
            Else
                table = _Table2
            End If

            Dim fromDate As String = _CpSvr7254.GetHeaderValue(2)
            Dim toDate As String = _CpSvr7254.GetHeaderValue(3)
            If fromDate.Length >= 8 Then
                DateTimePickerFrom.Value = New Date(CInt(fromDate.Substring(0, 4)), CInt(fromDate.Substring(4, 2)), CInt(fromDate.Substring(6, 2)))
            End If

            If toDate.Length >= 8 Then
                DateTimePickerTo.Value = New Date(CInt(toDate.Substring(0, 4)), CInt(toDate.Substring(4, 2)), CInt(toDate.Substring(6, 2)))
            End If

            For i As Integer = 0 To _CpSvr7254.GetHeaderValue(1) - 1
                Dim fieldCount = _CpSvr7254.Data
                Dim count As Integer = fieldCount.Count
                Dim row As DataRow = table.NewRow

                For j As Integer = 0 To count - 1
                    If j = 15 And table.Equals(_Table1) = True Then
                        Exit For
                    ElseIf j = 11 And table.Equals(_Table2) = True Then
                        Exit For
                    ElseIf j = 0 Then
                        row(j) = ClassUtil.ConvertToDateTime(_CpSvr7254.GetDataValue(j, i))
                    Else
                        row(j) = _CpSvr7254.GetDataValue(j, i)
                    End If
                Next j

                table.Rows.Add(row)
            Next i

            RefreshCurrentTab()
        End If

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        Me.Request()
    End Sub

    Private Sub DateTimePickerFrom_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DateTimePickerFrom.TextChanged
        Me.Request()
    End Sub

    Private Sub DateTimePickerTo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DateTimePickerTo.TextChanged
        Me.Request()
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
        If e.ColumnIndex = 0 Then
            DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        End If
    End Sub
End Class