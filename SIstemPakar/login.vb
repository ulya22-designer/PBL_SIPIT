Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class login

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisableMaximize(Me)

        Me.StartPosition = FormStartPosition.CenterScreen
        TextBox2.UseSystemPasswordChar = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = TextBox1.Text.Trim()
        Dim password As String = TextBox2.Text.Trim()

        If username = "" Or password = "" Then
            MessageBox.Show("Username dan Password harus diisi!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim hashed As String = HashPassword(password)

        Using conn As New SqlConnection(connStr)
            conn.Open()

            Dim query As String = "
                SELECT * FROM [User]
                WHERE nama = @nama AND Password = @password
            "

            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@nama", username)
                cmd.Parameters.AddWithValue("@password", hashed)

                Dim rd As SqlDataReader = cmd.ExecuteReader()

                If rd.Read() Then

                    CurrentUserID = CInt(rd("user_id"))
                    CurrentUserName = rd("nama").ToString()

                    If Not IsDBNull(rd("foto")) Then
                        CurrentUserFoto = CType(rd("foto"), Byte())
                    Else
                        CurrentUserFoto = Nothing
                    End If

                    MessageBox.Show("Login berhasil! Selamat datang " & username,
                                    "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Dim f As New Home()
                    f.userId = CurrentUserID
                    f.Show()
                    Me.Hide()

                Else
                    MessageBox.Show("Username atau password salah!", "Gagal",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            End Using
        End Using

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim lp As New landingPage()
        lp.Show()
        Me.Hide()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim reg As New Register()
        reg.Show()
        Me.Hide()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Dim f As New ForgotPassword()
        f.Show()
        Me.Hide()
    End Sub

End Class
