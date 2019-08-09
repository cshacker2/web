Public Class ClassUtil
    Public Shared Function ConvertToDateTime(ByVal param As String) As String
        Dim paramInt As Integer = CInt(param)
        Dim paramString As String = ""
        Dim retString As String = ""

        If param.Length <= 4 Then
            paramString = paramInt.ToString("0000")
            retString = paramString.Insert(2, ":")
        ElseIf param.Length <= 6 Then
            paramString = paramInt.ToString("000000")
            retString = paramString.Insert(2, ":")
            retString = retString.Insert(5, ":")
        ElseIf param.Length <= 8 Then
            paramString = paramInt.ToString("00000000")
            retString = paramString.Insert(4, "-")
            retString = retString.Insert(7, "-")
        End If

        Return retString
    End Function
End Class
