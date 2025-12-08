Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.Data.SqlClient

Public Class register

    Private fotoBytes As Byte() = Nothing   ' Menyimpan foto yang di-upload

    Private Sub register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisableMaximize(Me)
        Me.StartPosition = FormStartPosition.CenterScreen
        TextBox3.UseSystemPasswordChar = True   ' Sembunyikan password
    End Sub

    ' ======================================================
    ' TOMBOL UPLOAD FOTO
    ' ======================================================
    Private Sub btnUploadFoto_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ofd As New OpenFileDialog()
        ofd.Title = "Pilih Foto Profil"
        ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"

        If ofd.ShowDialog() = DialogResult.OK Then
            ' Foto hanya disimpan sebagai byte
            fotoBytes = IO.File.ReadAllBytes(ofd.FileName)
        End If
    End Sub


    ' ======================================================
    ' TOMBOL REGISTER
    ' ======================================================
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles RoundedButton2.Click

        Dim username As String = TextBox1.Text.Trim()
        Dim password As String = TextBox3.Text.Trim()

        ' Validasi input
        If username = "" Or password = "" Then
            MessageBox.Show("Nama dan Password harus diisi!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' HASH PASSWORD
        Dim hashedPass As String = HashPassword(password)

        Using conn As New SqlConnection(connStr)
            conn.Open()

            ' >>> UPDATE QUERY: tambah kolom role
            Dim query As String = "
                INSERT INTO [User] (nama, password, foto, role)
                VALUES (@nama, @password, @foto, 'user')
            "

            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@nama", username)
                cmd.Parameters.AddWithValue("@password", hashedPass)

                ' Foto boleh kosong
                If fotoBytes IsNot Nothing Then
                    cmd.Parameters.Add("@foto", SqlDbType.VarBinary).Value = fotoBytes
                Else
                    cmd.Parameters.Add("@foto", SqlDbType.VarBinary).Value = DBNull.Value
                End If

                Try
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Registrasi berhasil!", "Sukses",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Dim f As New login()
                    f.Show()
                    Me.Hide()

                Catch ex As Exception
                    MessageBox.Show("Gagal Registrasi: " & ex.Message)
                End Try

            End Using
        End Using

    End Sub


    ' ======================================================
    ' NAVIGASI: Sudah punya akun → ke login
    ' ======================================================
    Private Sub lblSudahAkun_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim log As New login()
        log.Show()
        Me.Hide()
    End Sub

    ' Tombol Back
    Private Sub RoundedButton1_Click(sender As Object, e As EventArgs) Handles RoundedButton1.Click
        Dim log As New login()
        log.Show()
        Me.Hide()
    End Sub

End Class
