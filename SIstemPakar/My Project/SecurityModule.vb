Imports System.Security.Cryptography
Imports System.Text

Module SecurityModule

    ' Fungsi untuk hashing password dengan SHA256
    Public Function HashPassword(ByVal password As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(password)
            Dim hash As Byte() = sha256.ComputeHash(bytes)

            Dim sb As New StringBuilder()
            For Each b In hash
                sb.Append(b.ToString("x2"))
            Next

            Return sb.ToString()
        End Using
    End Function

End Module
