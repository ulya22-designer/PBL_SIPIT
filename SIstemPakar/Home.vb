Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient
Imports System.IO
Imports System.Drawing.Drawing2D

Public Class Home

    Public Property userId As Integer     ' menerima user_id dari login

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen

        ' Membuat foto profil bulat
        MakePictureBoxRound(PictureBox1)

        ' Load data user
        LoadUserData()
    End Sub


    ' =====================================================
    ' FUNCTION MEMBUAT PICTUREBOX BULAT
    ' =====================================================
    Private Sub MakePictureBoxRound(pb As PictureBox)
        Dim gp As New GraphicsPath()
        gp.AddEllipse(0, 0, pb.Width - 1, pb.Height - 1)
        pb.Region = New Region(gp)
    End Sub


    ' =====================================================
    ' LOAD DATA USER (Nama + Foto)
    ' =====================================================
    Private Sub LoadUserData()

        Using conn As New SqlConnection(connStr)
            conn.Open()

            Dim query As String = "SELECT nama, foto FROM [User] WHERE user_id = @id"

            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", userId)

                Dim rd As SqlDataReader = cmd.ExecuteReader()

                If rd.Read() Then

                    ' tampilkan nama
                    Label1.Text = rd("nama").ToString()
                    CurrentUserName = rd("nama").ToString()

                    ' tampilkan foto profil
                    If Not IsDBNull(rd("foto")) Then
                        Dim imgBytes() As Byte = CType(rd("foto"), Byte())
                        CurrentUserFoto = imgBytes ' simpan global juga

                        Using ms As New MemoryStream(imgBytes)
                            PictureBox1.Image = Image.FromStream(ms)
                        End Using
                    Else
                        PictureBox1.Image = Nothing
                        CurrentUserFoto = Nothing
                    End If

                End If

            End Using
        End Using

        ' Simpan ID global biar halaman lain tahu siapa usernya
        CurrentUserID = userId

    End Sub



    ' =====================================================
    ' TOMBOL MULAI TES
    ' =====================================================
    Private Sub btnMulaiTes_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim p As New Pertanyaan()
        p.Show()
        Me.Hide()
    End Sub


    ' =====================================================
    ' TOMBOL ABOUT US (MENU BARU)
    ' =====================================================
    Private Sub ButtonAboutUs_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim f As New tentangKami()
        f.Show()
        Me.Hide()

    End Sub



    ' =====================================================
    ' TOMBOL KELUAR (KEMBALI KE LOGIN)
    ' =====================================================
    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim f As New login()
        f.Show()
        Me.Hide()
    End Sub


End Class
