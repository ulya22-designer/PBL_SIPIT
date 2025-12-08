Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports Microsoft.Data.SqlClient

Public Class login

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisableMaximize(Me)
        Me.StartPosition = FormStartPosition.CenterScreen
        TextBox2.UseSystemPasswordChar = True
    End Sub

    ' ======================================================
    ' LOGIN BUTTON
    ' ======================================================
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim username As String = TextBox1.Text.Trim()
        Dim password As String = TextBox2.Text.Trim()

        If username = "" Or password = "" Then
            MessageBox.Show("Username dan Password harus diisi!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' HASH password input user untuk verifikasi
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

                    ' ======================================================
                    ' SET GLOBAL USER (ID, NAMA, FOTO)
                    ' ======================================================
                    CurrentUserID = CInt(rd("user_id"))
                    CurrentUserName = rd("nama").ToString()

                    If Not IsDBNull(rd("foto")) Then
                        CurrentUserFoto = CType(rd("foto"), Byte())
                    Else
                        CurrentUserFoto = Nothing
                    End If

                    ' ======================================================
                    ' SET GLOBAL ROLE
                    ' ======================================================
                    If Not IsDBNull(rd("role")) Then
                        CurrentUserRole = rd("role").ToString().Trim().ToLower()
                    Else
                        CurrentUserRole = "user"   ' fallback aman
                    End If

                    MessageBox.Show("Login berhasil! Selamat datang " & username,
                    "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)


                    ' ======================================================
                    ' ARAHKAN SESUAI ROLE
                    ' ======================================================
                    If CurrentUserRole = "admin" Then
                        Dim admin As New adminPanel()
                        admin.Show()
                    Else
                        Dim f As New Home()
                        f.Show()
                    End If

                    Me.Hide()

                Else
                    MessageBox.Show("Username atau password salah!", "Gagal",
                    MessageBoxButtons.OK, MessageBoxIcon.[Error])
                End If
            End Using
        End Using

    End Sub


    ' ======================================================
    ' HASH FUNCTION SHA-256
    ' ======================================================
    Private Function HashPassword(plain As String) As String
        Using sha As SHA256 = SHA256.Create()
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(plain)
            Dim hash As Byte() = sha.ComputeHash(bytes)
            Dim sb As New StringBuilder()

            For Each b As Byte In hash
                sb.Append(b.ToString("x2"))
            Next

            Return sb.ToString()
        End Using
    End Function


    ' ======================================================
    ' NAVIGASI
    ' ======================================================
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
