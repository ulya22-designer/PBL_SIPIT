Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class CRUDprofesi

    ' Property untuk menentukan mode form: "tambah" atau "edit"
    Public Property mode As String

    ' Property untuk menampung data baris yang akan diedit
    Public Property profesiID As Integer
    Public Property namaProfesi As String
    Public Property deskripsi As String

    Private Sub CRUDprofesi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case mode
            Case "tambah"
                Me.Text = "Tambah Profesi"
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
            Case "edit"
                Me.Text = "Edit Profesi"
                TextBox1.Text = profesiID.ToString()
                TextBox2.Text = namaProfesi
                TextBox3.Text = deskripsi
            Case Else
                Me.Text = "CRUD Profesi"
        End Select
    End Sub

    ' ======================================================
    ' Tombol Simpan
    ' ======================================================
    Private Sub ButtonSimpan_Click(sender As Object, e As EventArgs) Handles RoundedButton3.Click
        ' Validasi input sederhana
        If String.IsNullOrWhiteSpace(TextBox2.Text) Or String.IsNullOrWhiteSpace(TextBox3.Text) Then
            MessageBox.Show("Nama profesi dan deskripsi harus diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using conn As SqlConnection = GetConnection()
                conn.Open()

                Dim cmd As SqlCommand

                If mode = "tambah" Then
                    ' Insert baru
                    cmd = New SqlCommand("INSERT INTO Profesi (nama_profesi, deskripsi) VALUES (@nama, @deskripsi)", conn)
                ElseIf mode = "edit" Then
                    ' Update existing
                    cmd = New SqlCommand("UPDATE Profesi SET nama_profesi = @nama, deskripsi = @deskripsi WHERE profesi_id = @id", conn)
                    cmd.Parameters.AddWithValue("@id", profesiID)
                Else
                    MessageBox.Show("Mode tidak valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                cmd.Parameters.AddWithValue("@nama", TextBox2.Text)
                cmd.Parameters.AddWithValue("@deskripsi", TextBox3.Text)

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
