Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports Microsoft.Data.SqlClient
Imports System.IO
Imports System.Drawing.Drawing2D

Public Class Hasil

    Private jawabanUser() As String
    Private currentUserId As Integer

    Public Sub New(jawab() As String, uid As Integer)
        InitializeComponent()
        jawabanUser = jawab
        currentUserId = uid
    End Sub

    Public jawaban() As String
    Public userId As Integer

    Private profesiIdHasil As Integer
    Private namaProfesi As String
    Private keteranganProfesi As String

    Private Sub Hasil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisableMaximize(Me)

        Me.StartPosition = FormStartPosition.CenterScreen

        MakePictureBoxRound(PictureBox1)

        Label1.Text = CurrentUserName
        If CurrentUserFoto IsNot Nothing Then
            PictureBox1.Image = ByteArrayToImage(CurrentUserFoto)
        End If

        ProsesDiagnosis()
        SimpanKeDatabase()
    End Sub

    Private Sub MakePictureBoxRound(pb As PictureBox)
        Dim gp As New GraphicsPath()
        gp.AddEllipse(0, 0, pb.Width - 1, pb.Height - 1)
        pb.Region = New Region(gp)
    End Sub

    Private Sub ProsesDiagnosis()

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
                    keteranganProfesi = rd("Keterangan").ToString()
                Else
                    profesiIdHasil = 5
                    namaProfesi = "Tidak Diketahui"
                    keteranganProfesi = "Sistem tidak dapat menentukan profesi Anda dengan pasti."
                End If
            End Using
        End Using

        Label3.Text = namaProfesi
        Label2.Text = keteranganProfesi
        Label2.MaximumSize = New Size(600, 0)
        Label2.AutoSize = True
        Label2.TextAlign = ContentAlignment.MiddleCenter

    End Sub

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

    Private Sub ButtonCetak_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Dim fontKopJudul As New Font("Arial", 16, FontStyle.Bold)
        Dim fontKopSub As New Font("Arial", 11, FontStyle.Regular)
        Dim fontJudul As New Font("Arial", 18, FontStyle.Bold)
        Dim fontNormal As New Font("Arial", 12)

        Dim tanggalCetak As String = DateTime.Now.ToString("dd MMMM yyyy, HH:mm")

        ' ============ LOGO PNJ (Sesuaikan Path Logo) ============
        Try
            Dim logo As Image = Image.FromFile("LOGO PNJ FIX 1.png")
            e.Graphics.DrawImage(logo, 50, 20, 80, 80)
        Catch ex As Exception
        End Try

        ' ================== KOP SURAT PNJ ==================
        e.Graphics.DrawString("POLITEKNIK NEGERI JAKARTA", fontKopJudul, Brushes.Black, 150, 25)
        e.Graphics.DrawString("JURUSAN TEKNIK INFORMATIKA DAN KOMPUTER", fontKopSub, Brushes.Black, 150, 50)
        e.Graphics.DrawString("Kampus PNJ · Kukusan · Depok", fontKopSub, Brushes.Black, 150, 70)

        ' garis bawah kop
        e.Graphics.DrawLine(Pens.Black, 50, 110, 750, 110)

        ' ================= ISI DOKUMEN =================
        e.Graphics.DrawString("Hasil Tes Karir SIPIT", fontJudul, Brushes.Black, 100, 150)
        e.Graphics.DrawString("Dicetak pada: " & tanggalCetak, fontNormal, Brushes.Black, 100, 190)

        e.Graphics.DrawString("Nama: " & CurrentUserName, fontNormal, Brushes.Black, 100, 230)
        e.Graphics.DrawString("Profesi: " & namaProfesi, fontNormal, Brushes.Black, 100, 260)

        e.Graphics.DrawString("Keterangan:", fontNormal, Brushes.Black, 100, 300)
        e.Graphics.DrawString(keteranganProfesi, fontNormal, Brushes.Black, 100, 330)

    End Sub

    Private Sub ButtonKembali_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim h As New Home()
        h.userId = currentUserId
        h.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
