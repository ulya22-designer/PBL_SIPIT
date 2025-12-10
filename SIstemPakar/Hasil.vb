Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports Microsoft.Data.SqlClient
Imports System.IO
Imports System.Drawing.Drawing2D

Public Class Hasil

    Private jawabanUser() As String
    Private currentUserId As Integer

    Private profesiIdHasil As Integer
    Private namaProfesi As String = ""
    Private keteranganProfesi As String = ""

    Public Sub New(jawab() As String, uid As Integer)
        InitializeComponent()
        jawabanUser = jawab
        currentUserId = uid
    End Sub


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



    ' ======================================================
    '   PROSES DIAGNOSIS
    ' ======================================================
    Private Sub ProsesDiagnosis()

        ' Convert jawaban user menjadi pola 1010...
        Dim userPattern As String = ""
        For i As Integer = 0 To jawabanUser.Length - 1
            userPattern &= If(jawabanUser(i).ToLower() = "ya", "1", "0")
        Next

        Using conn As New SqlConnection(connStr)
            conn.Open()

            Dim query As String =
                "SELECT A.rule_pattern, A.profesi_id, A.Keterangan, P.nama_profesi
                 FROM Aturan A
                 JOIN Profesi P ON A.profesi_id = P.profesi_id"

            Dim found As Boolean = False

            Using cmd As New SqlCommand(query, conn)
                Using rd As SqlDataReader = cmd.ExecuteReader()

                    While rd.Read()
                        Dim rulePattern As String = rd("rule_pattern").ToString()

                        If rulePattern = userPattern Then
                            profesiIdHasil = CInt(rd("profesi_id"))
                            namaProfesi = rd("nama_profesi").ToString()
                            keteranganProfesi = rd("Keterangan").ToString()
                            found = True
                            Exit While
                        End If
                    End While

                End Using
            End Using

            ' Jika tidak ditemukan → pakai default rule
            If Not found Then

                Dim q2 As String =
                    "SELECT TOP 1 A.profesi_id, A.Keterangan, P.nama_profesi
                     FROM Aturan A
                     JOIN Profesi P ON A.profesi_id = P.profesi_id
                     WHERE A.profesi_id = 5"

                Using cmd2 As New SqlCommand(q2, conn)
                    Using rd2 As SqlDataReader = cmd2.ExecuteReader()

                        If rd2.Read() Then
                            profesiIdHasil = CInt(rd2("profesi_id"))
                            namaProfesi = rd2("nama_profesi").ToString()
                            keteranganProfesi = rd2("Keterangan").ToString()
                        Else
                            profesiIdHasil = -1
                            namaProfesi = "Tidak Diketahui"
                            keteranganProfesi = "Sistem tidak dapat menentukan profesi Anda."
                        End If

                    End Using
                End Using

            End If
        End Using

        ' Update UI
        Label3.Text = namaProfesi
        Label2.Text = keteranganProfesi
        Label2.MaximumSize = New Size(600, 0)
        Label2.AutoSize = True
        Label2.TextAlign = ContentAlignment.MiddleCenter
    End Sub



    ' ======================================================
    '   SIMPAN KE DATABASE
    ' ======================================================
    Private Sub SimpanKeDatabase()
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



    ' ======================================================
    '   CETAK — PRINT
    ' ======================================================
    Private Sub RoundedButton2_Click(sender As Object, e As EventArgs) Handles RoundedButton2.Click
        Try
            PrintPreviewDialog1.Document = PrintDocument1
            PrintPreviewDialog1.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Gagal membuka preview: " & ex.Message)
        End Try
    End Sub



    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Dim fKopAtas As New Font("Times New Roman", 15, FontStyle.Bold)
        Dim fKopUtama As New Font("Times New Roman", 15, FontStyle.Bold)
        Dim fKopAlamat As New Font("Times New Roman", 11)
        Dim fJudul As New Font("Times New Roman", 18, FontStyle.Bold)
        Dim fNormal As New Font("Times New Roman", 13)

        Dim tanggalCetak As String = DateTime.Now.ToString("dd MMMM yyyy, HH:mm")
        Dim centerX As Single = e.PageBounds.Width / 2
        Dim posY As Integer = 35


        ' ====================
        ' LOGO & HEADER
        ' ====================
        Try
            Dim logo As Image = Image.FromFile("LOGO PNJ FIX 1.png")
            e.Graphics.DrawImage(logo, 55, 28, 120, 120)
        Catch
        End Try

        e.Graphics.DrawString("KEMENTERIAN PENDIDIKAN TINGGI,", fKopAtas, Brushes.Black,
                              centerX - 200, posY)

        posY += 23
        e.Graphics.DrawString("SAINS DAN TEKNOLOGI", fKopAtas, Brushes.Black,
                              centerX - 155, posY)

        posY += 25
        e.Graphics.DrawString("POLITEKNIK NEGERI JAKARTA", fKopUtama, Brushes.Black,
                              centerX - 190, posY)

        posY += 25
        e.Graphics.DrawString("Jalan Prof Dr. G.A. Siwabessy, Kampus UI, Depok 16425",
                              fKopAlamat, Brushes.Black, centerX - 230, posY)

        posY += 18
        e.Graphics.DrawString("Telepon (021) 7270036  Faksimile (021) 7270034",
                              fKopAlamat, Brushes.Black, centerX - 210, posY)

        posY += 35
        e.Graphics.DrawLine(Pens.Black, 50, posY, e.PageBounds.Width - 50, posY)


        ' ====================
        ' JUDUL
        ' ====================
        posY += 35
        e.Graphics.DrawString("Hasil Tes Karir SIPIT", fJudul, Brushes.Black,
                              centerX - 120, posY)

        posY += 60
        e.Graphics.DrawString("Dicetak pada: " & tanggalCetak, fNormal, Brushes.Black, 100, posY)


        ' ====================
        ' IDENTITAS
        ' ====================
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


        ' ======================================================
        '           TABEL HASIL SURVEY
        ' ======================================================
        posY += 220

        Dim fBoldTitle As New Font(fNormal.FontFamily, fNormal.Size, FontStyle.Bold)
        e.Graphics.DrawString("Tabel Hasil Jawaban Survey:", fBoldTitle, Brushes.Black, 100, posY)

        posY += 40

        Dim startX As Integer = 100
        Dim colNo As Integer = 30
        Dim colPertanyaan As Integer = 460
        Dim colJawaban As Integer = 200
        Dim rowHeight As Integer = 40
        Dim y As Integer = posY

        ' HEADER
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

        ' ISI TABEL
        Dim fmtIsi As New StringFormat With {
            .Alignment = StringAlignment.Near,
            .LineAlignment = StringAlignment.Near,
            .FormatFlags = StringFormatFlags.LineLimit
        }

        Using conn As New SqlConnection(connStr)
            conn.Open()

            Dim query As String = "SELECT teks_pertanyaan FROM Pertanyaan ORDER BY pertanyaan_id"

            Using cmd As New SqlCommand(query, conn)
                Using rd As SqlDataReader = cmd.ExecuteReader()

                    Dim idx As Integer = 0

                    While rd.Read() AndAlso idx < jawabanUser.Length

                        Dim teksPertanyaan As String = rd("teks_pertanyaan").ToString()
                        Dim teksJawaban As String = jawabanUser(idx).ToUpper()

                        Dim rectPertanyaan As New Rectangle(startX + colNo + 5, y + 5, colPertanyaan - 10, 999)
                        Dim rectJawaban As New Rectangle(startX + colNo + colPertanyaan + 5, y + 5, colJawaban - 10, 999)

                        Dim hPertanyaan = CInt(e.Graphics.MeasureString(teksPertanyaan, fNormal, rectPertanyaan.Width).Height)
                        Dim hJawaban = CInt(e.Graphics.MeasureString(teksJawaban, fNormal, rectJawaban.Width).Height)

                        Dim tinggiBaris As Integer = Math.Max(rowHeight, Math.Max(hPertanyaan + 10, hJawaban + 10))

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
        End Using

    End Sub



    ' ======================================================
    '   NAVIGASI
    ' ======================================================
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

End Class
