Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class CRUDpertanyaan

    ' Property untuk menentukan mode form: "tambah" atau "edit"
    Public Property mode As String

    ' Property untuk menampung data baris yang akan diedit
    Public Property pertanyaanID As Integer
    Public Property teksPertanyaan As String
    Public Property urutan As Integer

    ' Koneksi ke database
    Private Function GetConnection() As SqlConnection
        ' Ganti connection string sesuai database Anda
        Return New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True")
    End Function

    Private Sub CRUDpertanyaan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case mode
            Case "tambah"
                Me.Text = "Tambah Pertanyaan"
                ' Kosongkan semua TextBox
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
            Case "edit"
                Me.Text = "Edit Pertanyaan"
                ' Isi TextBox dengan data dari admin panel
                TextBox1.Text = pertanyaanID.ToString()
                TextBox2.Text = teksPertanyaan
                TextBox3.Text = urutan.ToString()
            Case Else
                Me.Text = "CRUD Pertanyaan"
        End Select
    End Sub

    ' ======================================================
    ' Tombol Simpan
    ' ======================================================
    Private Sub ButtonSimpan_Click(sender As Object, e As EventArgs) Handles RoundedButton3.Click
        ' Validasi input sederhana
        If String.IsNullOrWhiteSpace(TextBox2.Text) Or String.IsNullOrWhiteSpace(TextBox3.Text) Then
            MessageBox.Show("Pertanyaan dan urutan harus diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using conn As SqlConnection = GetConnection()
                conn.Open()

                Dim cmd As SqlCommand

                If mode = "tambah" Then
                    ' Insert baru
                    cmd = New SqlCommand("INSERT INTO Pertanyaan (teks_pertanyaan, urutan) VALUES (@teks, @urutan)", conn)
                ElseIf mode = "edit" Then
                    ' Update existing
                    cmd = New SqlCommand("UPDATE Pertanyaan SET teks_pertanyaan = @teks, urutan = @urutan WHERE pertanyaan_id = @id", conn)
                    cmd.Parameters.AddWithValue("@id", pertanyaanID)
                Else
                    MessageBox.Show("Mode tidak valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                cmd.Parameters.AddWithValue("@teks", TextBox2.Text)
                cmd.Parameters.AddWithValue("@urutan", Convert.ToInt32(TextBox3.Text))

                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Data berhasil disimpan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Kembali ke admin panel
            Dim f As New adminPanel()
            f.Show()
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ======================================================
    ' Tombol Batal
    ' ======================================================
    Private Sub ButtonBatal_Click(sender As Object, e As EventArgs) Handles RoundedButton2.Click
        ' Kembali ke admin panel tanpa menyimpan
        Dim f As New adminPanel()
        f.Show()
        Me.Hide()
    End Sub

End Class
