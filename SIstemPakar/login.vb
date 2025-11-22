Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class login

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen

        TextBox2.UseSystemPasswordChar = True
    End Sub

    ' Tombol LOGIN
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim username As String = TextBox1.Text.Trim()
        Dim password As String = TextBox2.Text.Trim()

        ' Validasi sederhana
        If username = "" Or password = "" Then
            MessageBox.Show("Username dan Password harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Hash password input user
        Dim hashed As String = HashPassword(password)

        Using conn As New SqlConnection(connStr)
            conn.Open()

            Dim query As String = "SELECT * FROM [User] WHERE nama = @nama AND password = @password"
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@nama", username)
                cmd.Parameters.AddWithValue("@password", hashed)

                Dim rd As SqlDataReader = cmd.ExecuteReader()

                If rd.Read() Then

                    ' -----------------------------
                    ' SIMPAN DATA USER KE GLOBAL
                    ' -----------------------------
                    CurrentUserID = CInt(rd("user_id"))
                    CurrentUserName = rd("nama").ToString()

                    If Not IsDBNull(rd("foto")) Then
                        CurrentUserFoto = CType(rd("foto"), Byte())
                    Else
                        CurrentUserFoto = Nothing
                    End If
                    ' -----------------------------

                    MessageBox.Show("Login berhasil! Selamat datang " & username, "Sukses",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Dim f As New Home()
                    f.userId = CurrentUserID
                    f.Show()
                    Me.Hide()

                Else
                    MessageBox.Show("Username atau password salah!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If


            End Using
        End Using
    End Sub

    ' Tombol KELUAR → kembali ke landing page
    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim lp As New landingPage()
        lp.Show()
        Me.Hide()
    End Sub


    ' Label menuju REGISTER
    Private Sub lblRegister_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim reg As New register()
        reg.Show()
        Me.Hide()
    End Sub

End Class
