Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient
Imports System.IO

Public Class Home

    Public Property userId As Integer     ' menerima user_id dari login

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        LoadUserData()
    End Sub

    ' ====== LOAD DATA USER (nama + foto) ======
    Private Sub LoadUserData()

        Using conn As New SqlConnection(connStr)
            conn.Open()

            Dim query As String = "SELECT nama, foto FROM [User] WHERE user_id = @id"

            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", userId)

                Dim rd As SqlDataReader = cmd.ExecuteReader()

                If rd.Read() Then
                    ' Set Username
                    Label1.Text = rd("nama").ToString()

                    ' Tampilkan foto jika ada
                    If Not IsDBNull(rd("foto")) Then
                        Dim imgBytes() As Byte = CType(rd("foto"), Byte())
                        Using ms As New MemoryStream(imgBytes)
                            PictureBox1.Image = Image.FromStream(ms)
                        End Using
                    Else
                        PictureBox1.Image = Nothing
                    End If
                End If

            End Using
        End Using

    End Sub


    ' ========== TOMBOL MULAI TES ==========
    Private Sub btnMulaiTes_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim p As New pertanyaan()
        'p.userId = CurrentUserID   ' kirim userId ke halaman pertanyaan
        p.Show()
        Me.Hide()
    End Sub


    ' ========== TOMBOL KELUAR ==========
    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim f As New login()
        f.Show()
        Me.Hide()
    End Sub

End Class
