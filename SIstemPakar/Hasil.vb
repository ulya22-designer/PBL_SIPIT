Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports Microsoft.Data.SqlClient

Public Class Hasil

    Private jawabanUser() As String
    Private currentUserId As Integer

    ' === Constructor Baru ===
    Public Sub New(jawab() As String, uid As Integer)
        InitializeComponent()
        jawabanUser = jawab
        currentUserId = uid
    End Sub

    Public jawaban() As String      ' diterima dari form Pertanyaan
    Public userId As Integer        ' diterima dari login

    Private profesiIdHasil As Integer
    Private namaProfesi As String
    Private keteranganProfesi As String

    Private Sub Hasil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen

        ' tampilkan foto + nama
        Label1.Text = CurrentUserName
        If CurrentUserFoto IsNot Nothing Then
            PictureBox1.Image = ByteArrayToImage(CurrentUserFoto)
        End If

        ' Proses rule & tampilkan
        ProsesDiagnosis()
        SimpanKeDatabase()

    End Sub


    ' =============================================================
    ' ===============  PROSES MENENTUKAN PROFESI  =================
    ' =============================================================
    Private Sub ProsesDiagnosis()

        ' Convert "ya"/"tidak" ke 1/0 untuk rule
        Dim v1 = If(jawabanUser(0) = "ya", 1, 0)
        Dim v2 = If(jawabanUser(1) = "ya", 1, 0)
        Dim v3 = If(jawabanUser(2) = "ya", 1, 0)
        Dim v4 = If(jawabanUser(3) = "ya", 1, 0)
        Dim v5 = If(jawabanUser(4) = "ya", 1, 0)

        Using conn As New SqlConnection(connStr)
            conn.Open()

            Dim query As String =
                "SELECT TOP 1 A.profesi_id, P.nama_profesi, A.Keterangan
                 FROM Aturan A
                 JOIN Profesi P ON A.profesi_id = P.profesi_id
                 WHERE 
                    A.o1_algoritma_dan_logika = @v1 AND
                    A.o2_desain_relasional = @v2 AND
                    A.o3_arsitektur_dan_keamanan = @v3 AND
                    A.o4_analisis_kebutuhan_pengguna = @v4 AND
                    A.o5_adaptif_dan_inovatif = @v5"

            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@v1", v1)
                cmd.Parameters.AddWithValue("@v2", v2)
                cmd.Parameters.AddWithValue("@v3", v3)
                cmd.Parameters.AddWithValue("@v4", v4)
                cmd.Parameters.AddWithValue("@v5", v5)

                Dim rd = cmd.ExecuteReader()

                If rd.Read() Then
                    profesiIdHasil = CInt(rd("profesi_id"))
                    namaProfesi = rd("nama_profesi").ToString()
                    keteranganProfesi = rd("keterangan").ToString()
                Else
                    ' Default jika tidak ada rule yang cocok
                    profesiIdHasil = 5
                    namaProfesi = "Tidak Diketahui"
                    keteranganProfesi = "Sistem tidak dapat menentukan profesi Anda dengan pasti."
                End If
            End Using
        End Using

        ' tampilkan ke layar
        Label3.Text = namaProfesi
        Label2.Text = keteranganProfesi
        Label2.MaximumSize = New Size(600, 0)   ' Lebar maksimum agar text membungkus
        Label2.AutoSize = True
        Label2.TextAlign = ContentAlignment.MiddleCenter

    End Sub


    ' =============================================================
    ' ===============  SIMPAN KE DATABASE  =========================
    ' =============================================================
    Private Sub SimpanKeDatabase()
        Using conn As New SqlConnection(connStr)
            conn.Open()

            Dim query As String =
                "INSERT INTO Hasil_User (user_id, profesi_id, tanggal) 
                 VALUES (@uid, @pid, GETDATE())"

            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@uid", currentUserId)
                cmd.Parameters.AddWithValue("@pid", profesiIdHasil)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub


    ' =============================================================
    ' ===============  CETAK HASIL  ===============================
    ' =============================================================
    Private Sub ButtonCetak_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Dim fontJudul As New Font("Arial", 18, FontStyle.Bold)
        Dim fontNormal As New Font("Arial", 12)

        e.Graphics.DrawString("Hasil Tes Karir SIPIT", fontJudul, Brushes.Black, 100, 50)
        e.Graphics.DrawString("Nama: " & CurrentUserName, fontNormal, Brushes.Black, 100, 100)
        e.Graphics.DrawString("Profesi: " & namaProfesi, fontNormal, Brushes.Black, 100, 140)
        e.Graphics.DrawString("Keterangan:", fontNormal, Brushes.Black, 100, 180)
        e.Graphics.DrawString(keteranganProfesi, fontNormal, Brushes.Black, 100, 210)

    End Sub


    ' =============================================================
    ' ===============  KEMBALI KE HOME  ===========================
    ' =============================================================
    Private Sub ButtonKembali_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim h As New Home()
        h.Show()
        Me.Hide()
    End Sub

End Class
