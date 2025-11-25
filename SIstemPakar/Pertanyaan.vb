Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient
Imports System.Drawing.Drawing2D

Public Class Pertanyaan

    Dim listPertanyaan As New List(Of String)
    Dim jawaban(4) As String      ' Menyimpan YA/TIDAK
    Dim currentIndex As Integer = 0

    Private Sub Pertanyaan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen

        ' tampilkan user
        Label1.Text = CurrentUserName

        ' tampilkan foto user
        If CurrentUserFoto IsNot Nothing Then
            PictureBox1.Image = ByteArrayToImage(CurrentUserFoto)
        End If

        ' === Membuat PictureBox bulat ===
        Dim gp As New GraphicsPath()
        gp.AddEllipse(0, 0, PictureBox1.Width - 1, PictureBox1.Height - 1)
        PictureBox1.Region = New Region(gp)

        LoadPertanyaan()
        TampilkanPertanyaan(0)
        UpdateNavigasi()
    End Sub

    ' =============================
    ' LOAD PERTANYAAN DARI DATABASE
    ' =============================
    Private Sub LoadPertanyaan()
        Using conn As New SqlConnection(connStr)
            conn.Open()
            Dim query As String = "SELECT teks_pertanyaan FROM Pertanyaan ORDER BY pertanyaan_id ASC"

            Using cmd As New SqlCommand(query, conn)
                Dim rd = cmd.ExecuteReader()
                While rd.Read()
                    listPertanyaan.Add(rd("teks_pertanyaan").ToString())
                End While
            End Using
        End Using
    End Sub

    ' =============================
    ' FUNGSI TAMPIL PERTANYAAN
    ' =============================
    Private Sub TampilkanPertanyaan(index As Integer)
        currentIndex = index

        Label2.MaximumSize = New Size(700, 0)
        Label2.AutoSize = True
        Label2.TextAlign = ContentAlignment.MiddleCenter
        Label2.Text = listPertanyaan(index)

        UpdateNavigasi()
        UpdateNomorButton()
    End Sub

    ' =============================
    ' UPDATE NAVIGASI
    ' =============================
    Private Sub UpdateNavigasi()
        Button9.Enabled = (currentIndex > 0)                          ' geser kiri
        Button3.Enabled = (currentIndex < listPertanyaan.Count - 1)  ' geser kanan
    End Sub

    ' =============================
    ' HIGHLIGHT NOMOR BUTTON
    ' =============================
    Private Sub UpdateNomorButton()
        Button4.BackColor = If(currentIndex = 0, Color.LightBlue, Color.White)
        Button5.BackColor = If(currentIndex = 1, Color.LightBlue, Color.White)
        Button6.BackColor = If(currentIndex = 2, Color.LightBlue, Color.White)
        Button8.BackColor = If(currentIndex = 3, Color.LightBlue, Color.White)
        Button7.BackColor = If(currentIndex = 4, Color.LightBlue, Color.White)
    End Sub

    ' =============================
    ' BUTTON NOMOR
    ' =============================
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TampilkanPertanyaan(0)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TampilkanPertanyaan(1)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TampilkanPertanyaan(2)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TampilkanPertanyaan(3)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TampilkanPertanyaan(4)
    End Sub

    ' =============================
    ' BUTTON GESER KIRI / KANAN
    ' =============================
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If currentIndex > 0 Then
            TampilkanPertanyaan(currentIndex - 1)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If currentIndex < listPertanyaan.Count - 1 Then
            TampilkanPertanyaan(currentIndex + 1)
        End If
    End Sub

    ' =============================
    ' BUTTON YA – AUTO NEXT
    ' =============================
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        jawaban(currentIndex) = "ya"
        NextOrFinish()
    End Sub

    ' =============================
    ' BUTTON TIDAK – AUTO NEXT
    ' =============================
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        jawaban(currentIndex) = "tidak"
        NextOrFinish()
    End Sub

    ' =============================
    ' FUNGSI LANJUT / SELESAI
    ' =============================
    Private Sub NextOrFinish()

        ' jika masih ada pertanyaan → lanjut
        If currentIndex < listPertanyaan.Count - 1 Then
            currentIndex += 1
            TampilkanPertanyaan(currentIndex)
            Return
        End If

        ' jika sudah pertanyaan terakhir → cek jawaban
        For i = 0 To 4
            If jawaban(i) Is Nothing Then
                MessageBox.Show("Pertanyaan nomor " & (i + 1) & " belum dijawab!")
                Return
            End If
        Next

        ' buka halaman hasil
        Dim f As New Hasil(jawaban, CurrentUserID)
        f.Show()
        Me.Hide()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

End Class
