Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports Microsoft.Data.SqlClient
Imports System.IO
Imports System.Drawing.Drawing2D

Public Class Hasil

    ' ------------------ VARIABEL ------------------
    Private jawabanUser() As String           ' Menyimpan jawaban user dari form sebelumnya
    Private currentUserId As Integer          ' Menyimpan user_id aktif
    Private profesiIdHasil As Integer         ' Hasil ID profesi
    Private namaProfesi As String             ' Nama profesi hasil
    Private keteranganProfesi As String       ' Keterangan profesi


    ' ------------------ KONSTRUKTOR ------------------
    Public Sub New(jawab() As String, uid As Integer)
        InitializeComponent()
        jawabanUser = jawab
        currentUserId = uid
    End Sub


    ' ------------------ LOAD FORM ------------------
    Private Sub Hasil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisableMaximize(Me)
        Me.StartPosition = FormStartPosition.CenterScreen

        ' Foto profil bulat
        MakePictureBoxRound(PictureBox1)

        ' Tampilkan nama user
        Label1.Text = CurrentUserName

        ' Jika foto ada, tampilkan
        If CurrentUserFoto IsNot Nothing Then
            PictureBox1.Image = ByteArrayToImage(CurrentUserFoto)
        End If

        ' Proses hasil tes + simpan ke database
        ProsesDiagnosis()
        SimpanKeDatabase()
    End Sub


    ' ------------------ MEMBUAT GAMBAR BULAT ------------------
    Private Sub MakePictureBoxRound(pb As PictureBox)
        Dim gp As New GraphicsPath()
        gp.AddEllipse(0, 0, pb.Width - 1, pb.Height - 1)
        pb.Region = New Region(gp)
    End Sub


    ' ------------------ PROSES DIAGNOSIS ------------------
    Private Sub ProsesDiagnosis()
        ' Konversi YA/TIDAK menjadi 1/0 sesuai aturan DB
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

        ' Tampilkan ke label
        Label3.Text = namaProfesi
        Label2.Text = keteranganProfesi
        Label2.MaximumSize = New Size(600, 0)
        Label2.AutoSize = True
        Label2.TextAlign = ContentAlignment.MiddleCenter
    End Sub


    ' ------------------ SIMPAN HASIL KE DATABASE ------------------
    Private Sub SimpanKeDatabase()
        ' Jika user ID tidak valid → hentikan (hindari error foreign key)
        If currentUserId <= 0 Then Exit Sub

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


    ' ------------------ CETAK ------------------
    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage

        ' ===== FONT =====
        Dim fKopAtas As New Font("Times New Roman", 15, FontStyle.Bold)
        Dim fKopUtama As New Font("Times New Roman", 15, FontStyle.Bold)
        Dim fKopAlamat As New Font("Times New Roman", 11)
        Dim fJudul As New Font("Times New Roman", 18, FontStyle.Bold)
        Dim fNormal As New Font("Times New Roman", 13)

        Dim tanggalCetak As String = DateTime.Now.ToString("dd MMMM yyyy, HH:mm")
        Dim centerX As Single = e.PageBounds.Width / 2
        Dim posY As Integer = 35


        ' ===== LOGO PNJ =====
        Try
            Dim logo As Image = Image.FromFile("LOGO PNJ FIX 1.png")
            e.Graphics.DrawImage(logo, 55, 28, 120, 120)
        Catch
        End Try


        ' ===== KOP SURAT =====
        Dim kop1 = "KEMENTERIAN PENDIDIKAN TINGGI,"
        e.Graphics.DrawString(kop1, fKopAtas, Brushes.Black,
            centerX - e.Graphics.MeasureString(kop1, fKopAtas).Width / 2, posY)

        posY += 23
        Dim kop2 = "SAINS DAN TEKNOLOGI"
        e.Graphics.DrawString(kop2, fKopAtas, Brushes.Black,
            centerX - e.Graphics.MeasureString(kop2, fKopAtas).Width / 2, posY)

        posY += 25
        Dim kop3 = "POLITEKNIK NEGERI JAKARTA"
        e.Graphics.DrawString(kop3, fKopUtama, Brushes.Black,
            centerX - e.Graphics.MeasureString(kop3, fKopUtama).Width / 2, posY)

        posY += 25
        Dim kop4 = "Jalan Prof Dr. G.A. Siwabessy, Kampus UI, Depok 16425"
        e.Graphics.DrawString(kop4, fKopAlamat, Brushes.Black,
            centerX - e.Graphics.MeasureString(kop4, fKopAlamat).Width / 2, posY)

        posY += 18
        Dim kop5 = "Telepon (021) 7270036  Faksimile (021) 7270034"
        e.Graphics.DrawString(kop5, fKopAlamat, Brushes.Black,
            centerX - e.Graphics.MeasureString(kop5, fKopAlamat).Width / 2, posY)

        posY += 35
        e.Graphics.DrawLine(Pens.Black, 50, posY, e.PageBounds.Width - 50, posY)


        ' ===== JUDUL =====
        posY += 35
        Dim judul = "Hasil Tes Karir SIPIT"
        e.Graphics.DrawString(judul, fJudul, Brushes.Black,
            centerX - e.Graphics.MeasureString(judul, fJudul).Width / 2, posY)

        posY += 60
        e.Graphics.DrawString("Dicetak pada: " & tanggalCetak, fNormal, Brushes.Black, 100, posY)


        ' ===== IDENTITAS USER =====
        Dim colLabel = 100
        Dim colColon = 260
        Dim colValue = 280

        posY += 40
        e.Graphics.DrawString("Nama", fNormal, Brushes.Black, colLabel, posY)
        e.Graphics.DrawString(":", fNormal, Brushes.Black, colColon, posY)
        e.Graphics.DrawString(CurrentUserName, fNormal, Brushes.Black, colValue, posY)

        posY += 30
        e.Graphics.DrawString("Profesi", fNormal, Brushes.Black, colLabel, posY)
        e.Graphics.DrawString(":", fNormal, Brushes.Black, colColon, posY)
        e.Graphics.DrawString(namaProfesi, fNormal, Brushes.Black, colValue, posY)

        posY += 35
        e.Graphics.DrawString("Keterangan", fNormal, Brushes.Black, colLabel, posY)
        e.Graphics.DrawString(":", fNormal, Brushes.Black, colColon, posY)

        Dim rectKeterangan As New Rectangle(colValue, posY, 550, 170)
        e.Graphics.DrawString(keteranganProfesi, fNormal, Brushes.Black, rectKeterangan)


        ' ===== TABEL SURVEY =====
        posY += 80
        Dim fBoldTitle As New Font(fNormal.FontFamily, fNormal.Size, FontStyle.Bold)
        e.Graphics.DrawString("Tabel Hasil Jawaban Survey:", fBoldTitle, Brushes.Black, 100, posY)

        posY += 40

        Dim startX As Integer = 100
        Dim colNo As Integer = 30
        Dim colPertanyaan As Integer = 460
        Dim colJawaban As Integer = 200
        Dim rowHeight As Integer = 40

        Dim y As Integer = posY

        ' HEADER TABEL
        e.Graphics.DrawRectangle(Pens.Black, startX, y, colNo, rowHeight)
        e.Graphics.DrawRectangle(Pens.Black, startX + colNo, y, colPertanyaan, rowHeight)
        e.Graphics.DrawRectangle(Pens.Black, startX + colNo + colPertanyaan, y, colJawaban, rowHeight)

        Dim fBold As New Font("Arial", 10, FontStyle.Bold)
        Dim fmtHeader As New StringFormat With {
            .Alignment = StringAlignment.Center,
            .LineAlignment = StringAlignment.Center
        }

        e.Graphics.DrawString("No", fBold, Brushes.Black,
            New Rectangle(startX, y, colNo, rowHeight), fmtHeader)

        e.Graphics.DrawString("Pertanyaan", fBold, Brushes.Black,
            New Rectangle(startX + colNo, y, colPertanyaan, rowHeight), fmtHeader)

        e.Graphics.DrawString("Jawaban", fBold, Brushes.Black,
            New Rectangle(startX + colNo + colPertanyaan, y, colJawaban, rowHeight), fmtHeader)

        y += rowHeight

        Dim fmtIsi As New StringFormat With {
            .Alignment = StringAlignment.Near,
            .LineAlignment = StringAlignment.Near,
            .FormatFlags = StringFormatFlags.LineLimit
        }

        ' ISI TABEL
        Using conn As New SqlConnection(connStr)
            conn.Open()

            Dim query As String = "SELECT teks_pertanyaan FROM Pertanyaan ORDER BY pertanyaan_id"

            Using cmd As New SqlCommand(query, conn)
                Dim rd = cmd.ExecuteReader()
                Dim idx As Integer = 0

                While rd.Read() AndAlso idx < jawabanUser.Length

                    Dim teksPertanyaan As String = rd("teks_pertanyaan").ToString()
                    Dim teksJawaban As String = jawabanUser(idx).ToUpper()

                    Dim rectPertanyaan = New Rectangle(startX + colNo + 5, y + 5, colPertanyaan - 10, 999)
                    Dim rectJawaban = New Rectangle(startX + colNo + colPertanyaan + 5, y + 5, colJawaban - 10, 999)

                    Dim hPertanyaan = CInt(e.Graphics.MeasureString(teksPertanyaan, fNormal, rectPertanyaan.Width).Height)
                    Dim hJawaban = CInt(e.Graphics.MeasureString(teksJawaban, fNormal, rectJawaban.Width).Height)

                    Dim tinggiBaris = Math.Max(rowHeight, Math.Max(hPertanyaan + 10, hJawaban + 10))

                    e.Graphics.DrawRectangle(Pens.Black, startX, y, colNo, tinggiBaris)
                    e.Graphics.DrawRectangle(Pens.Black, startX + colNo, y, colPertanyaan, tinggiBaris)
                    e.Graphics.DrawRectangle(Pens.Black, startX + colNo + colPertanyaan, y, colJawaban, tinggiBaris)

                    e.Graphics.DrawString((idx + 1).ToString(), fNormal, Brushes.Black,
                        New Rectangle(startX, y, colNo, tinggiBaris), fmtHeader)

                    e.Graphics.DrawString(teksPertanyaan, fNormal, Brushes.Black, rectPertanyaan, fmtIsi)
                    e.Graphics.DrawString(teksJawaban, fNormal, Brushes.Black, rectJawaban, fmtIsi)

                    y += tinggiBaris
                    idx += 1
                End While
            End Using
        End Using

    End Sub


    ' ------------------ NAVIGASI ------------------
    Private Sub RoundedButton1_Click(sender As Object, e As EventArgs) Handles RoundedButton1.Click
        Dim f As New landingPage()
        f.Show()
        Me.Hide()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim f As New Home()
        f.Show()
        Me.Hide()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim f As New tentangKami()
        f.Show()
        Me.Hide()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Dim f As New Riwayat()
        f.Show()
        Me.Hide()
    End Sub

    Private Sub RoundedButton2_Click(sender As Object, e As EventArgs) Handles RoundedButton2.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

End Class
