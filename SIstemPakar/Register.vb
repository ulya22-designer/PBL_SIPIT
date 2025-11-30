Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.Data.SqlClient

Public Class register

    Private fotoBytes As Byte() = Nothing   ' Menyimpan foto yang diupload

    Private Sub register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen

        TextBox3.UseSystemPasswordChar = True
    End Sub

    ' ============================
    ' 1. Tombol Upload Foto
    ' ============================
    Private Sub btnUploadFoto_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ofd As New OpenFileDialog()
        ofd.Title = "Pilih Foto Profil"
        ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"

        If ofd.ShowDialog() = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(ofd.FileName)
            fotoBytes = IO.File.ReadAllBytes(ofd.FileName) ' <-- Simpan dalam byte()
        End If
    End Sub


    ' ============================
    ' 2. Tombol REGISTER
    ' ============================
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim username As String = TextBox1.Text.Trim()
        Dim password As String = TextBox3.Text.Trim()

        ' Validasi sederhana
        If username = "" Or password = "" Then
            MessageBox.Show("Nama dan Password harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Hash password
        Dim hashedPass As String = HashPassword(password)

        ' Simpan ke database
        Using conn As New SqlConnection(connStr)
            conn.Open()

            Dim query As String = "INSERT INTO [User] (nama, password, foto) VALUES (@nama, @password, @foto)"

            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@nama", username)
                cmd.Parameters.AddWithValue("@password", hashedPass)

                If fotoBytes IsNot Nothing Then
                    cmd.Parameters.Add("@foto", SqlDbType.VarBinary).Value = fotoBytes
                Else
                    cmd.Parameters.Add("@foto", SqlDbType.VarBinary).Value = DBNull.Value
                End If

                Try
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Registrasi berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Kembali ke Login
                    Dim f As New login()
                    f.Show()
                    Me.Hide()

                Catch ex As Exception
                    MessageBox.Show("Gagal Registrasi: " & ex.Message)
                End Try

            End Using
        End Using

    End Sub


    ' ============================
    ' 3. Tombol KELUAR → kembali ke login
    ' ============================
    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim log As New login()
        log.Show()
        Me.Hide()
    End Sub


    ' ============================
    ' 4. Label "Sudah punya akun?"
    ' ============================
    Private Sub lblSudahAkun_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim log As New login()
        log.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub
End Class
