Public Class FormWeb

    Private Sub FormWeb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub

    Private Sub FormWeb_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Public Sub ShowWeb(ByVal title As String, ByVal url As String)
        Me.Text = title
        WebBrowser1.Navigate(url)
    End Sub
End Class