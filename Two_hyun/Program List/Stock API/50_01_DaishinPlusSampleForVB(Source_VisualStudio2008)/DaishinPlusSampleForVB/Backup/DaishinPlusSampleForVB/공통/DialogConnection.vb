Imports System.Windows.Forms

Public Class DialogConnection
    Private _parent As Main

    Public Sub SetParent(ByVal parent As Object)
        _parent = parent
    End Sub

    Private Sub ButtonCancle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancle.Click
        Me.Close()
    End Sub

    Private Sub ButtonCybos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCybos.Click
        Dim path = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\daishin\starter", "path", Nothing)
        If path Is Nothing Then
            MsgBox("사이보스 플러스가 설치되어있지 않습니다.")
        Else
            Process.Start(path + "\ncStarter.exe", "/prj:cp")
            _parent.RequestConnection()
        End If

        Me.Close()
    End Sub

    Private Sub ButtonCreon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCreon.Click
        Dim path = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Creon\dstarter", "path", Nothing)
        If path Is Nothing Then
            MsgBox("크레온 플러스가 설치되어있지 않습니다.")
        Else
            Process.Start(path + "\coStarter.exe", "/prj:cp")
            _parent.RequestConnection()
        End If

        Me.Close()
    End Sub

End Class
