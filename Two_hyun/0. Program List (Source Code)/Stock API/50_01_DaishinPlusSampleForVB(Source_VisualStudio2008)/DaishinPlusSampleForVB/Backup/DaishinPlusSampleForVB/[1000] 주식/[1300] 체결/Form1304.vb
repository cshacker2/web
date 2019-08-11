Public Class Form1304
    Private _parent As Main

    Private Sub Form1304_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub Form1304_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.KeyPreview = True

        _parent = Me.ParentForm

        DataGridView1.DataSource = _parent._stockTradeTable
        DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Refresh()
    End Sub

    Public Sub ReceivedStockTrade()
        
        If CheckBoxTop.Checked Then
            DataGridView1.FirstDisplayedScrollingRowIndex = 0
            DataGridView1.ClearSelection()
            DataGridView1.Rows(0).Selected = True
        End If

        DataGridView1.Refresh()
    End Sub

    Private Sub ButtonHelp1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHelp1.Click
        _parent.ShowHelp("1304")
    End Sub

    Private Sub DataGridView1_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        If DataGridView1.Item("매매", e.RowIndex).Value.ToString().Contains("매수") Then
            DataGridView1.Rows(e.RowIndex).Cells("매매").Style.ForeColor = Color.Red
        Else
            DataGridView1.Rows(e.RowIndex).Cells("매매").Style.ForeColor = Color.Blue
        End If

        If DataGridView1.Item("실시간", e.RowIndex).Value.ToString().Contains("체결") Then
            DataGridView1.Rows(e.RowIndex).Cells("실시간").Style.ForeColor = Color.Red
        ElseIf DataGridView1.Item("실시간", e.RowIndex).Value.ToString().Contains("거부") Then
            DataGridView1.Rows(e.RowIndex).Cells("실시간").Style.ForeColor = Color.Red
        ElseIf DataGridView1.Item("실시간", e.RowIndex).Value.ToString().Contains("확인") Then
            DataGridView1.Rows(e.RowIndex).Cells("실시간").Style.ForeColor = Color.Green
        End If

        If DataGridView1.Item("정정취소", e.RowIndex).Value.ToString().Contains("정정") Then
            DataGridView1.Rows(e.RowIndex).Cells("정정취소").Style.ForeColor = Color.Green
        ElseIf DataGridView1.Item("정정취소", e.RowIndex).Value.ToString().Contains("취소") Then
            DataGridView1.Rows(e.RowIndex).Cells("정정취소").Style.ForeColor = Color.FromArgb(236, 77, 0)
        End If
    End Sub

End Class