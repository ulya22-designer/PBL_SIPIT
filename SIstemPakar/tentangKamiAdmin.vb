Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Drawing.Drawing2D

Public Class tentangKamiAdmin

    Private chartProfesi As Chart

    Private Sub tentangKamiAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DisableMaximize(Me)

        Me.StartPosition = FormStartPosition.CenterScreen

        ' Buat chart dan ambil data
        BuatChartProfesi()
        LoadChartData()

    End Sub

    ' ==================== CHART ====================
    Private Sub BuatChartProfesi()

        chartProfesi = New Chart()
        chartProfesi.Dock = DockStyle.Fill
        chartProfesi.BackColor = Color.WhiteSmoke
        chartProfesi.BorderlineDashStyle = ChartDashStyle.Solid
        chartProfesi.BorderlineColor = Color.Gray
        chartProfesi.BorderlineWidth = 1

        Dim area As New ChartArea("AreaUtama")
        chartProfesi.ChartAreas.Add(area)

        Panel1.Controls.Clear()
        Panel1.Controls.Add(chartProfesi)

    End Sub


    ' ================== LOAD DATA DARI DATABASE ==================
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

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim f As New adminPanel()
        f.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim f As New landingPage()
        f.Show()
        Me.Hide()
    End Sub
End Class
