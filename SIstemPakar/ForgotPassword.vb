Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class ForgotPassword

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' === SUBMIT ===

        Dim username As String = TextBox1.Text.Trim()
        Dim newpass As String = TextBox2.Text.Trim()
        Dim confirmpass As String = TextBox3.Text.Trim()

        ' Validasi field kosong
        If username = "" Or newpass = "" Or confirmpass = "" Then
            MessageBox.Show("Semua field harus diisi!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Validasi password cocok
        If newpass <> confirmpass Then
            MessageBox.Show("Password dan konfirmasi tidak sama!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Hash password baru (WAJIB karena login juga pakai hashing)
        Dim hashedPass As String = HashPassword(newpass)

        Dim conn As SqlConnection = GetConnection()

        Try
            conn.Open()

            ' CEK apakah username ada
            Dim checkCmd As New SqlCommand("
                SELECT COUNT(*) FROM [User] WHERE nama=@nama
            ", conn)

            checkCmd.Parameters.AddWithValue("@nama", username)

            Dim count As Integer = CInt(checkCmd.ExecuteScalar())

            If count = 0 Then
                MessageBox.Show("Username tidak ditemukan!", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' UPDATE PASSWORD
            Dim updateCmd As New SqlCommand("
                UPDATE [User] SET Password=@pass WHERE nama=@nama
            ", conn)

            updateCmd.Parameters.AddWithValue("@pass", hashedPass)
            updateCmd.Parameters.AddWithValue("@nama", username)
            updateCmd.ExecuteNonQuery()

            MessageBox.Show("Password berhasil direset!", "Sukses",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)

            Dim f As New login()
            f.Show()
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' === KEMBALI ===
        Dim f As New login()
        f.Show()
        Me.Close()
    End Sub

End Class
