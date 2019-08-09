
Public Class FormStockCodes
    Private _main As Main

    Public _SearchTable As New DataTable

    Private Sub FormStockCodes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.KeyPreview = True

        _main = Me.MdiParent

        _SearchTable.Columns.Add("순번")
        _SearchTable.Columns.Add("종목코드")
        _SearchTable.Columns.Add("종목명")

        DataGridView1.DataSource = _main._stockTable
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Refresh()
    End Sub

    Private Sub FormStockCodes_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        _main.ChangedStockCode(DataGridView1.Rows(e.RowIndex).Cells("종목코드").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("종목명").Value.ToString())
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        _main.ChangedStockCode(DataGridView1.Rows(e.RowIndex).Cells("종목코드").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("종목명").Value.ToString())
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        _main.ShowHelp("10001")
    End Sub

    Private Sub DataGridView1_DataBindingComplete(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles DataGridView1.DataBindingComplete
        DataGridView1.ClearSelection()
    End Sub

    Private Sub TextBoxSearch_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBoxSearch.TextChanged
        If TextBoxSearch.Text.Length > 0 Then
            _SearchTable.Clear()

            Dim index As Integer = 1
            For i As Integer = 0 To _main._stockTable.Rows.Count - 1
                If _main._stockTable.Rows(i).Item("종목코드").Contains(TextBoxSearch.Text.ToUpper) Or _main._stockTable.Rows(i).Item("종목명").Contains(TextBoxSearch.Text.ToUpper) Then
                    _SearchTable.Rows.Add(index.ToString, _main._stockTable.Rows(i).Item("종목코드"), _main._stockTable.Rows(i).Item("종목명"))
                    index += 1
                End If
            Next

            DataGridView1.DataSource = _SearchTable
        Else
            DataGridView1.DataSource = _main._stockTable
        End If

        DataGridView1.Refresh()

    End Sub

    Private Sub ButtonClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClear.Click
        TextBoxSearch.Text = ""
    End Sub

End Class