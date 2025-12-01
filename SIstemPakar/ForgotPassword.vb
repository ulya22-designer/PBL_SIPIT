Imports Microsoft.Data.SqlClient

Public Class ForgotPassword

    Private Sub ForgotPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisableMaximize(Me)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' === KEMBALI KE LOGIN ===
        login.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' === RESET PASSWORD ===

        Dim username As String = TextBox1.Text.Trim()
        Dim newpass As String = TextBox2.Text.Trim()
        Dim confirmpass As String = TextBox3.Text.Trim()

        ' Validasi field
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

        Dim hashedPass As String = HashPassword(newpass)

        Try
            Using conn As SqlConnection = GetConnection()
                conn.Open()

                ' CEK USER
                Dim checkQuery As String = "SELECT user_id FROM [User] WHERE nama=@nama"
                Dim checkCmd As New SqlCommand(checkQuery, conn)
                checkCmd.Parameters.AddWithValue("@nama", username)

                Dim userIdObj = checkCmd.ExecuteScalar()

                If userIdObj Is Nothing Then
                    MessageBox.Show("Username tidak ditemukan!", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                ' UPDATE PASSWORD
                Dim updateQuery As String = "
                    UPDATE [User] SET password=@pass WHERE user_id=@id
                "

                Dim updateCmd As New SqlCommand(updateQuery, conn)
                updateCmd.Parameters.AddWithValue("@pass", hashedPass)
                updateCmd.Parameters.AddWithValue("@id", CInt(userIdObj))
                updateCmd.ExecuteNonQuery()

                MessageBox.Show("Password berhasil direset!", "Berhasil",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)

                login.Show()
                Me.Close()
            End Using

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        End Try
    End Sub

End Class
