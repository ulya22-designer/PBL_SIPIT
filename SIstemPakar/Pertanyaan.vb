Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient
Public Class Pertanyaan

    Dim listPertanyaan As New List(Of String)
    Dim jawaban(4) As String     ' Menyimpan YA/TIDAK
    Dim currentIndex As Integer = 0

    Private Sub Pertanyaan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen

        ' tampilkan user
        Label1.Text = CurrentUserName

        ' tampilkan foto
        If CurrentUserFoto IsNot Nothing Then
            PictureBox1.Image = ByteArrayToImage(CurrentUserFoto)
        End If

        LoadPertanyaan()
        TampilkanPertanyaan(0)
        UpdateNavigasi()
    End Sub

    '=============================
    ' LOAD PERTANYAAN DARI DATABASE
    '=============================
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

    '=============================
    ' FUNGSI TAMPIL PERTANYAAN
    '=============================
    Private Sub TampilkanPertanyaan(index As Integer)
        currentIndex = index

        ' --- Pengaturan Tampilan Label Pertanyaan ---
        Label2.MaximumSize = New Size(700, 0)   ' Lebar maksimum agar text membungkus
        Label2.AutoSize = True
        Label2.TextAlign = ContentAlignment.MiddleCenter

        Label2.Text = listPertanyaan(index)

        UpdateNavigasi()
        UpdateNomorButton()
    End Sub


    ' MENONAKTIFKAN / MENGAKTIFKAN BUTTON GESER
    Private Sub UpdateNavigasi()
        Button9.Enabled = (currentIndex > 0)
        Button3.Enabled = (currentIndex < 4)
    End Sub

    ' MEMBERI HIGHLIGHT BUTTON ANGKA
    Private Sub UpdateNomorButton()
        Button4.BackColor = If(currentIndex = 0, Color.LightBlue, Color.White)
        Button5.BackColor = If(currentIndex = 1, Color.LightBlue, Color.White)
        Button6.BackColor = If(currentIndex = 2, Color.LightBlue, Color.White)
        Button8.BackColor = If(currentIndex = 3, Color.LightBlue, Color.White)
        Button7.BackColor = If(currentIndex = 4, Color.LightBlue, Color.White)
    End Sub

    '=============================
    ' BUTTON NAVIGASI ANGKA
    '=============================
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TampilkanPertanyaan(0)
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TampilkanPertanyaan(1)
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TampilkanPertanyaan(2)
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TampilkanPertanyaan(3)
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TampilkanPertanyaan(4)
    End Sub

    '=============================
    ' BUTTON GESER KIRI / KANAN
    '=============================
    Private Sub btnKiri_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If currentIndex > 0 Then
            TampilkanPertanyaan(currentIndex - 1)
        End If
    End Sub

    Private Sub btnKanan_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If currentIndex < 4 Then
            TampilkanPertanyaan(currentIndex + 1)
        End If
    End Sub

    '=============================
    ' BUTTON YA / TIDAK
    '=============================
    Private Sub btnYa_Click(sender As Object, e As EventArgs) Handles Button1.Click
        jawaban(currentIndex) = "ya"
        MessageBox.Show("Jawaban disimpan!", "Info")
    End Sub

    Private Sub btnTidak_Click(sender As Object, e As EventArgs) Handles Button2.Click
        jawaban(currentIndex) = "tidak"
        MessageBox.Show("Jawaban disimpan!", "Info")
    End Sub

    '=============================
    ' BUTTON SELESAI TES
    '=============================
    Private Sub btnSelesai_Click(sender As Object, e As EventArgs) Handles Button10.Click

        ' cek apakah semua pertanyaan sudah dijawab
        For i = 0 To 4
            If jawaban(i) = Nothing Then
                MessageBox.Show("Pertanyaan nomor " & (i + 1) & " belum dijawab!")
                Return
            End If
        Next

        ' buka halaman hasil
        Dim f As New Hasil(jawaban, CurrentUserID)
        f.Show()
        Me.Hide()

    End Sub
End Class