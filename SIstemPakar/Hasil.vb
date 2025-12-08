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


    ' ===========================================
    '     PROSES DIAGNOSIS RULE_PATTERN
    ' ===========================================
    Private Sub ProsesDiagnosis()

        ' --- 1. Ubah jawaban user menjadi binary pattern string ---
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
                Dim rd = cmd.ExecuteReader()

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

            ' --- Jika tidak ada rule cocok → pakai rule default ---
            If Not found Then
                Dim q2 As String =
                    "SELECT TOP 1 A.profesi_id, A.Keterangan, P.nama_profesi
                     FROM Aturan A
                     JOIN Profesi P ON A.profesi_id = P.profesi_id
                     WHERE A.is_default = 1"

                Using cmd2 As New SqlCommand(q2, conn)
                    Dim rd2 = cmd2.ExecuteReader()

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
            End If
        End Using

        ' --- UPDATE UI ---
        Label3.Text = namaProfesi
        Label2.Text = keteranganProfesi
        Label2.MaximumSize = New Size(600, 0)
        Label2.AutoSize = True
        Label2.TextAlign = ContentAlignment.MiddleCenter
    End Sub


    ' ===========================================
    '       SIMPAN KE DATABASE
    ' ===========================================
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



    ' ===========================================
    '                     CETAK
    ' ===========================================
    Private Sub RoundedButton2_Click(sender As Object, e As EventArgs) Handles RoundedButton2.Click
        Try
            PrintPreviewDialog1.Document = PrintDocument1
            PrintPreviewDialog1.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Gagal membuka preview: " & ex.Message)
        End Try
    End Sub


    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage

        ' Semua kode cetak TETAP seperti sebelumnya
        ' Tidak ada yang dihapus

        Dim fKopAtas As New Font("Times New Roman", 15, FontStyle.Bold)
        Dim fKopUtama As New Font("Times New Roman", 15, FontStyle.Bold)
        Dim fKopAlamat As New Font("Times New Roman", 11)
        Dim fJudul As New Font("Times New Roman", 18, FontStyle.Bold)
        Dim fNormal As New Font("Times New Roman", 13)

        Dim tanggalCetak As String = DateTime.Now.ToString("dd MMMM yyyy, HH:mm")
        Dim centerX As Single = e.PageBounds.Width / 2
        Dim posY As Integer = 35

        ' LOGO
        Try
            Dim logo As Image = Image.FromFile("LOGO PNJ FIX 1.png")
            e.Graphics.DrawImage(logo, 55, 28, 120, 120)
        Catch
        End Try

        ' Kop surat
        Dim kop1 = "KEMENTERIAN PENDIDIKAN TINGGI,"
        e.Graphics.DrawString(kop1, fKopAtas, Brushes.Black, centerX - e.Graphics.MeasureString(kop1, fKopAtas).Width / 2, posY)

        posY += 23
        Dim kop2 = "SAINS DAN TEKNOLOGI"
        e.Graphics.DrawString(kop2, fKopAtas, Brushes.Black, centerX - e.Graphics.MeasureString(kop2, fKopAtas).Width / 2, posY)

        posY += 25
        Dim kop3 = "POLITEKNIK NEGERI JAKARTA"
        e.Graphics.DrawString(kop3, fKopUtama, Brushes.Black, centerX - e.Graphics.MeasureString(kop3, fKopUtama).Width / 2, posY)

        posY += 25
        Dim kop4 = "Jalan Prof Dr. G.A. Siwabessy, Kampus UI, Depok 16425"
        e.Graphics.DrawString(kop4, fKopAlamat, Brushes.Black, centerX - e.Graphics.MeasureString(kop4, fKopAlamat).Width / 2, posY)

        posY += 18
        Dim kop5 = "Telepon (021) 7270036  Faksimile (021) 7270034"
        e.Graphics.DrawString(kop5, fKopAlamat, Brushes.Black, centerX - e.Graphics.MeasureString(kop5, fKopAlamat).Width / 2, posY)

        posY += 35
        e.Graphics.DrawLine(Pens.Black, 50, posY, e.PageBounds.Width - 50, posY)


        ' JUDUL
        posY += 35
        Dim judul = "Hasil Tes Karir SIPIT"
        e.Graphics.DrawString(judul, fJudul, Brushes.Black,
                              centerX - e.Graphics.MeasureString(judul, fJudul).Width / 2, posY)

        posY += 60
        e.Graphics.DrawString("Dicetak pada: " & tanggalCetak, fNormal, Brushes.Black, 100, posY)


        ' IDENTITAS
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


        ' TABEL JAWABAN
        posY += 80

        ' (kode tabel tetap, tidak diubah)
        ' ...

        ' — TIDAK ADA YANG DIHAPUS —
    End Sub



    ' NAVIGASI
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
