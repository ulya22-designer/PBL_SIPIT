Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class adminPanel

    Private Sub adminPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPertanyaan()
    End Sub


    ' ======================================================
    '   CENTER LABEL TITLE
    ' ======================================================
    Private Sub CenterLabelTitle()
        Label3.Left = (Panel3.Width - Label3.Width) \ 2
    End Sub


    ' ======================================================
    '   FUNGSI GENERIK GET DATA
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
    '   LOAD DATA PERTANYAAN
    ' ======================================================
    Private Sub LoadPertanyaan()
        Label3.Text = "Pertanyaan"
        CenterLabelTitle()

        Dim query As String =
            "SELECT pertanyaan_id AS [ID],
                    teks_pertanyaan AS [Pertanyaan]
             FROM Pertanyaan
             ORDER BY pertanyaan_id"

        DataGridView1.DataSource = GetData(query)
    End Sub



    ' ======================================================
    '   LOAD DATA PROFESI
    ' ======================================================
    Private Sub LoadProfesi()
        Label3.Text = "Profesi"
        CenterLabelTitle()

        Dim query As String =
            "SELECT profesi_id AS [ID],
                    nama_profesi AS [Nama Profesi],
                    deskripsi AS [Deskripsi]
             FROM Profesi
             ORDER BY profesi_id"

        DataGridView1.DataSource = GetData(query)
    End Sub



    ' ======================================================
    '   LOAD DATA ATURAN (RULE PATTERN)
    ' ======================================================
    Private Sub LoadAturan()
        Label3.Text = "Aturan"
        CenterLabelTitle()

        Dim query As String =
        "SELECT 
             A.rule_id AS [ID],
             P.nama_profesi AS [Profesi],
             A.rule_pattern AS [Pola Rule],
             A.Keterangan AS [Keterangan]
         FROM Aturan A
         JOIN Profesi P ON A.profesi_id = P.profesi_id
         ORDER BY A.rule_id"

        DataGridView1.DataSource = GetData(query)
    End Sub



    ' ======================================================
    '   EVENT TOMBOL MENU
    ' ======================================================

    Private Sub RoundedButton4_Click(sender As Object, e As EventArgs) Handles RoundedButton4.Click
        LoadPertanyaan()
    End Sub

    Private Sub RoundedButton5_Click(sender As Object, e As EventArgs) Handles RoundedButton5.Click
        LoadProfesi()
    End Sub

    Private Sub RoundedButton6_Click(sender As Object, e As EventArgs) Handles RoundedButton6.Click
        LoadAturan()
    End Sub



    ' ======================================================
    '   ABOUT (Label 4)
    ' ======================================================
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim f As New tentangKamiAdmin()
        f.Show()
        Me.Hide()
    End Sub



    ' ======================================================
    '   NAVIGASI KEMBALI
    ' ======================================================
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim f As New landingPage()
        f.Show()
        Me.Hide()
    End Sub



    ' ======================================================
    '   AUTO-CENTER TITLE SAAT RESIZE PANEL
    ' ======================================================
    Private Sub Panel3_Resize(sender As Object, e As EventArgs) Handles Panel3.Resize
        CenterLabelTitle()
    End Sub

    Private Sub RoundedButton1_Click(sender As Object, e As EventArgs) Handles RoundedButton1.Click
        Dim f As New CRUDpertanyaan()
        f.Show()
        Me.Hide()
    End Sub
End Class
