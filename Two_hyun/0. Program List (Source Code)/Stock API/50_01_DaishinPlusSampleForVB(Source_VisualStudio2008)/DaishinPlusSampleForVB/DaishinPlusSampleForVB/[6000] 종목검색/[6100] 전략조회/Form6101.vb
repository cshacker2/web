Public Class Form6101
    Private _parent As Main
    Dim _Table As DataTable = New DataTable
    Private _CssStgList As CPSYSDIBLib.CssStgList
    Private _arrURL As ArrayList = New ArrayList
    Private _index As Int32
    Private _bMy As Boolean

    Public Sub SetScreenType(ByVal type As String)
        If type = "나의 전략" Then
            Me.Text = "[6101] 나의 전략 (CpSysDib.CssStgList)"
            _bMy = True
        Else
            Me.Text = "[6102] 예제 전략 (CpSysDib.CssStgList)"
            _bMy = False
        End If
    End Sub

    Private Sub Form6101_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Me.Request()
    End Sub

    Private Sub Form6102_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.KeyPreview = True

        _parent = Me.ParentForm

        _CssStgList = New CPSYSDIBLib.CssStgList

        _index = 1

        _Table.Columns.Add("순번")
        _Table.Columns.Add("전략명")
        _Table.Columns.Add("전략ID")
        _Table.Columns.Add("평균 종목수")
        _Table.Columns.Add("평균 승률")
        _Table.Columns.Add("평균 수익률")
        _Table.Columns.Add("등록 일시")

        DataGridView1.DataSource = _Table

        Dim button1 As New DataGridViewButtonColumn()
        DataGridView1.Columns.Add(button1)
        button1.HeaderText = "검색 결과"
        button1.Text = "결과"
        button1.UseColumnTextForButtonValue = True

        Dim button2 As New DataGridViewButtonColumn()
        DataGridView1.Columns.Add(button2)
        button2.HeaderText = "실시간 감시"
        button2.Text = "감시"
        button2.UseColumnTextForButtonValue = True

        Dim button3 As New DataGridViewButtonColumn()
        DataGridView1.Columns.Add(button3)
        button3.HeaderText = "전략 URL"
        button3.Text = "URL"
        button3.UseColumnTextForButtonValue = True

        DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridView1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns(2).Visible = False
        DataGridView1.Refresh()
    End Sub

    Private Sub Form6102_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub DataGridView1_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles DataGridView1.DataBindingComplete
        DataGridView1.ClearSelection()
    End Sub

    Private Sub DataGridView1_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        If DataGridView1.Columns(e.ColumnIndex).HeaderText = "평균 수익률" Then
            Dim value As String = e.Value.Replace("%", "")
            If value <> "" Then
                If Convert.ToDouble(value) > 0 Then
                    e.CellStyle.ForeColor = Color.Red
                ElseIf Convert.ToDouble(value) < 0 Then
                    e.CellStyle.ForeColor = Color.Blue
                Else
                    e.CellStyle.ForeColor = Color.Black
                End If
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If DataGridView1.Columns(e.ColumnIndex).HeaderText = "전략 URL" Then
            If e.RowIndex >= _arrURL.Count Then
                Return
            End If

            Dim web As FormWeb = New FormWeb()
            web.Show()
            web.ShowWeb(DataGridView1.Rows(e.RowIndex).Cells("전략명").Value.ToString(), _arrURL(e.RowIndex).ToString())
        ElseIf DataGridView1.Columns(e.ColumnIndex).HeaderText = "검색 결과" Then
            _parent.ShowSTGResultList(DataGridView1.Rows(e.RowIndex).Cells("전략ID").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("전략명").Value.ToString())
        ElseIf DataGridView1.Columns(e.ColumnIndex).HeaderText = "실시간 감시" Then
            _parent.ShowSTGMonitor(DataGridView1.Rows(e.RowIndex).Cells("전략ID").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("전략명").Value.ToString())
        Else
            _parent.ChangeSTG(DataGridView1.Rows(e.RowIndex).Cells("전략ID").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("전략명").Value.ToString())
        End If

        DataGridView1.ClearSelection()
    End Sub

    Private Sub Request()
        _Table.Clear()
        DataGridView1.Refresh()
        TextBoxCount.Text = "0"
        _index = 1
        _arrURL.Clear()

        If _bMy Then
            _CssStgList.SetInputValue(0, Asc("1"))
        Else
            _CssStgList.SetInputValue(0, Asc("0"))
        End If

        Me.JustRequest()
    End Sub

    Private Sub JustRequest()
        If _CssStgList.GetDibStatus() = 1 Then
            Trace.TraceInformation("DibRq 요청 수신대기 중 입니다. 수신이 완료된 후 다시 호출 하십시오.")
            Exit Sub
        End If

        LabelMsg1.Text = ""
        LabelMsg2.Text = ""
        LabelContinue.Text = ""

        Dim result As Integer = -1
        result = _CssStgList.BlockRequest()

        LabelMsg1.Text = _CssStgList.GetDibMsg1()
        LabelMsg2.Text = _CssStgList.GetDibMsg2()

        If result = 0 Then
            For i As Integer = 0 To _CssStgList.GetHeaderValue(0) - 1
                Dim row As DataRow = _Table.NewRow

                row("순번") = _index.ToString()
                row("전략명") = _CssStgList.GetDataValue(0, i)
                row("전략ID") = _CssStgList.GetDataValue(1, i)
                row("등록 일시") = _CssStgList.GetDataValue(2, i)
                row("평균 종목수") = _CssStgList.GetDataValue(4, i)
                Dim value As Double = CDbl(_CssStgList.GetDataValue(5, i))
                If value = -999.99 Then
                    row("평균 승률") = ""
                Else
                    row("평균 승률") = value.ToString("0.00%")
                End If

                value = CDbl(_CssStgList.GetDataValue(6, i))
                If value = -999.99 Then
                    row("평균 수익률") = ""
                Else
                    row("평균 수익률") = value.ToString("0.00%")
                End If

                _arrURL.Add(_CssStgList.GetDataValue(7, i))

                _Table.Rows.Add(row)

                _index += 1
            Next i
        End If

        If _CssStgList.Continue = 1 Then
            Me.JustRequest()
        Else
            LabelMsg1.Text = "조회가 완료되었습니다."
            TextBoxCount.Text = _Table.Rows.Count.ToString()
            DataGridView1.Refresh()
        End If

    End Sub

    Private Sub ButtonHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHelp.Click
        _parent.ShowHelp("6101")
    End Sub

    Private Sub ButtonQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonQuery.Click
        Me.Request()
    End Sub

End Class