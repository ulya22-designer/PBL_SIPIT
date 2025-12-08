Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class adminPanel

    Private Sub adminPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Default saat form dibuka → tampilkan Pertanyaan
        LoadPertanyaan()
    End Sub

    ' ============================
    '  CENTER LABEL DI PANEL3
    ' ============================
    Private Sub CenterLabelTitle()
        Label3.Left = (Panel3.Width - Label3.Width) \ 2
    End Sub


    ' ======================================================
    '  FUNCTION PENGAMBIL DATA (DATA GRID VIEW)
    ' ======================================================
    Private Function GetData(query As String) As DataTable
        Dim dt As New DataTable()

        Try
            Using conn As SqlConnection = GetConnection()
                conn.Open()

                Using cmd As New SqlCommand(query, conn)
                    Using da As New SqlDataAdapter(cmd)
                        da.Fill(dt)
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal mengambil data: " & ex.Message)
        End Try

        Return dt
    End Function


    ' ======================================================
    '  LOAD DATA PERTANYAAN
    ' ======================================================
    Private Sub LoadPertanyaan()
        Label3.Text = "Pertanyaan"
        CenterLabelTitle()

        Dim query As String =
            "SELECT pertanyaan_id AS [ID], teks_pertanyaan AS [Pertanyaan] 
             FROM Pertanyaan"

        DataGridView1.DataSource = GetData(query)
    End Sub


    ' ======================================================
    '  LOAD DATA PROFESI
    ' ======================================================
    Private Sub LoadProfesi()
        Label3.Text = "Profesi"
        CenterLabelTitle()

        Dim query As String =
            "SELECT profesi_id AS [ID],
                    nama_profesi AS [Nama Profesi],
                    deskripsi AS [Deskripsi]
             FROM Profesi"

        DataGridView1.DataSource = GetData(query)
    End Sub


    ' ======================================================
    '  LOAD DATA ATURAN (JOIN PROFESI)
    ' ======================================================
    Private Sub LoadAturan()
        Label3.Text = "Aturan"
        CenterLabelTitle()

        Dim query As String =
        "SELECT A.rule_id AS [ID],
                P.nama_profesi AS [Profesi],
                A.o1_algoritma_dan_logika AS [O1 Logika],
                A.o2_desain_relasional AS [O2 Relasional],
                A.o3_arsitektur_dan_keamanan AS [O3 Keamanan],
                A.o4_analisis_kebutuhan_pengguna AS [O4 Analisis],
                A.o5_adaptif_dan_inovatif AS [O5 Inovatif],
                A.Keterangan
         FROM Aturan A
         JOIN Profesi P ON A.profesi_id = P.profesi_id"

        DataGridView1.DataSource = GetData(query)
    End Sub


    ' ======================================================
    '  EVENT PADA TOMBOL
    ' ======================================================

    ' Tombol PERTANYAAN
    Private Sub RoundedButton4_Click(sender As Object, e As EventArgs) Handles RoundedButton4.Click
        LoadPertanyaan()
    End Sub

    ' Tombol PROFESI
    Private Sub RoundedButton5_Click(sender As Object, e As EventArgs) Handles RoundedButton5.Click
        LoadProfesi()
    End Sub

    ' Tombol ATURAN
    Private Sub RoundedButton6_Click(sender As Object, e As EventArgs) Handles RoundedButton6.Click
        LoadAturan()
    End Sub


    ' ======================================================
    ' AUTO CENTER SAAT PANEL DI-RESIZE
    ' ======================================================
    Private Sub Panel3_Resize(sender As Object, e As EventArgs) Handles Panel3.Resize
        CenterLabelTitle()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim f As New landingPage()
        f.Show()
        Me.Hide()
    End Sub
End Class
