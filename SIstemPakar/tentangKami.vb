Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Drawing.Drawing2D

Public Class tentangKami

    Private chartProfesi As Chart

    Private Sub tentangKami_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisableMaximize(Me)

        Me.StartPosition = FormStartPosition.CenterScreen

        ' ==== Tampilkan user ====
        Label2.Text = CurrentUserName

        If CurrentUserFoto IsNot Nothing Then
            PictureBox1.Image = ByteArrayToImage(CurrentUserFoto)
        End If

        ' Bikin foto bulat
        Dim gp As New GraphicsPath()
        gp.AddEllipse(0, 0, PictureBox1.Width - 1, PictureBox1.Height - 1)
        PictureBox1.Region = New Region(gp)

        ' Isi teks
        IsiDeskripsiSIPIT()
        IsiDaftarProfesi()

        ' Buat chart manual
        BuatChartProfesi()

        ' Ambil data dari database ke chart
        LoadChartData()

    End Sub


    ' ============================================================
    '  DESKRIPSI SIPIT
    ' ============================================================
    Private Sub IsiDeskripsiSIPIT()
        Label1.Text =
            "SIPIT (Sistem Pakar IT) adalah aplikasi kecerdasan buatan sederhana " &
            "yang membantu pengguna mengetahui kecocokan profesi IT berdasarkan " &
            "jawaban dari beberapa pertanyaan kemampuan dan preferensi."
    End Sub


    ' ============================================================
    '  DAFTAR PROFESI
    ' ============================================================
    Private Sub IsiDaftarProfesi()

        Dim teks As String =
            "Daftar profesi dalam sistem SIPIT:" & Environment.NewLine & Environment.NewLine &
            "• SENIOR PROGRAMMER – Ahli dalam logika, algoritma, dan struktur software." & Environment.NewLine & Environment.NewLine &
            "• DATABASE ADMINISTRATOR – Menjaga keamanan, integritas, dan performa database." & Environment.NewLine & Environment.NewLine &
            "• SOFTWARE DEVELOPER – Membuat software yang stabil dan efisien." & Environment.NewLine & Environment.NewLine &
            "• SYSTEM ANALYST – Menganalisis kebutuhan bisnis dan merancang solusi teknologi."

        Label3.Text = teks

    End Sub


    ' ============================================================
    '  MEMBUAT CHART SECARA MANUAL (TANPA TOOLBOX)
    ' ============================================================
    Private Sub BuatChartProfesi()

        chartProfesi = New Chart()
        chartProfesi.Size = New Size(500, 350)
        chartProfesi.Location = New Point(50, 420)
        chartProfesi.BackColor = Color.WhiteSmoke
        chartProfesi.BorderlineDashStyle = ChartDashStyle.Solid
        chartProfesi.BorderlineColor = Color.Gray
        chartProfesi.BorderlineWidth = 1

        ' Tambah chart area
        Dim area As New ChartArea("AreaUtama")
        chartProfesi.ChartAreas.Add(area)

        ' Tambahkan ke form
        Me.Controls.Add(chartProfesi)

    End Sub


    ' ============================================================
    '  MENGISI DATA CHART DARI DATABASE
    ' ============================================================
    Private Sub LoadChartData()

        chartProfesi.Series.Clear()
        chartProfesi.Titles.Clear()

        chartProfesi.Titles.Add("Statistik Hasil Profesi Pengguna")

        Dim series As New Series("Profesi")
        series.ChartType = SeriesChartType.Pie
        series.IsValueShownAsLabel = True
        series.Font = New Font("Segoe UI", 10, FontStyle.Bold)

        chartProfesi.Series.Add(series)

        Using conn As New SqlConnection(connStr)
            conn.Open()

            Dim query As String =
                "SELECT P.nama_profesi, COUNT(H.profesi_id) AS jumlah " &
                "FROM Hasil_User H " &
                "LEFT JOIN Profesi P ON H.profesi_id = P.profesi_id " &
                "GROUP BY P.nama_profesi"

            Using cmd As New SqlCommand(query, conn)
                Dim rd As SqlDataReader = cmd.ExecuteReader()

                While rd.Read()
                    Dim nama As String = rd("nama_profesi").ToString()
                    Dim jumlah As Integer = CInt(rd("jumlah"))

                    series.Points.AddXY(nama, jumlah)
                End While
            End Using
        End Using

    End Sub


    ' ============================================================
    '  BUTTON KEMBALI
    ' ============================================================
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim f As New Home()
        f.userId = CurrentUserID
        f.Show()
        Me.Hide()
    End Sub

End Class
