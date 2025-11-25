Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Module Koneksi
    ' Connection string ke file database yang kamu gunakan
    Public connStr As String =
    "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ariz7\source\repos\PBL_SIPIT\SIstemPakar\sipitDB.mdf;Integrated Security=True;Connect Timeout=30"


    ' Function untuk mengambil koneksi baru
    Public Function GetConnection() As SqlConnection
        Return New SqlConnection(connStr)
    End Function
End Module
