Module ModuleGlobal

    Public CurrentUserID As Integer
    Public CurrentUserName As String
    Public CurrentUserFoto As Byte()

    ' Tambahan untuk role (user / admin)
    Public CurrentUserRole As String = "user"

    ' Helper untuk mengecek admin
    Public Function IsAdmin() As Boolean
        Return CurrentUserRole.Trim().ToLower() = "admin"
    End Function


    ' Konversi foto BLOB → Image
    Public Function ByteArrayToImage(bytes As Byte()) As Image
        If bytes Is Nothing Then
            Return Nothing
        End If

        Using ms As New IO.MemoryStream(bytes)
            Return Image.FromStream(ms)
        End Using
    End Function

End Module
