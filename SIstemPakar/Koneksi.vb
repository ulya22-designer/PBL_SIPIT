Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Module Koneksi

    ' Connection string ke database
    Public connStr As String =
        Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="C:\Users\ululy\OneDrive\Desktop\ULYA SARA\Kuliah 2\Semester 3\Pemograman Visual\SIstemPakar\SIstemPakar\sipitDB.mdf";Integrated Security=True

    ' Function untuk mengambil koneksi baru
    Public Function GetConnection() As SqlConnection
        Return New SqlConnection(connStr)
    End Function

End Module
