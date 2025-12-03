Imports Microsoft.Data.SqlClient

Public Class ForgotPassword

    Private Sub ForgotPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisableMaximize(Me)
    End Sub

    ' Tombol Reset Password
    Private Sub RoundedButton1_Click(sender As Object, e As EventArgs) Handles RoundedButton1.Click
        Dim username = TextBox5.Text.Trim
        Dim newpass = TextBox4.Text.Trim
        Dim confirmpass = TextBox6.Text.Trim

        ' Validasi input
        If username = "" Or newpass = "" Or confirmpass = "" Then
            MessageBox.Show("Semua field harus diisi!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If newpass <> confirmpass Then
            MessageBox.Show("Password dan konfirmasi tidak sama!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim hashedPass = HashPassword(newpass)

        Try
            Using conn = GetConnection()
                conn.Open()

                ' Cek apakah user ada
                Dim checkQuery = "SELECT user_id FROM [User] WHERE nama=@nama"
                Dim checkCmd As New SqlCommand(checkQuery, conn)
                checkCmd.Parameters.AddWithValue("@nama", username)

                Dim userIdObj = checkCmd.ExecuteScalar()

                If userIdObj Is Nothing Then
                    MessageBox.Show("Username tidak ditemukan!", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                ' Update password
                Dim updateQuery = "
                    UPDATE [User] SET password=@pass WHERE user_id=@id
                "
                Dim updateCmd As New SqlCommand(updateQuery, conn)
                updateCmd.Parameters.AddWithValue("@pass", hashedPass)
                updateCmd.Parameters.AddWithValue("@id", CInt(userIdObj))
                updateCmd.ExecuteNonQuery()

                MessageBox.Show("Password berhasil direset!", "Berhasil",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)

                login.Show()
                Close()
            End Using

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        End Try
    End Sub

    ' Tombol kembali ke login
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        login.Show()
        Me.Close()
    End Sub

End Class
