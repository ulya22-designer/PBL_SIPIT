Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class adminPanel

    ' Menyimpan halaman yang sedang dibuka
    Private currentTab As String = "pertanyaan"

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
    '   MENGATUR VISIBILITAS BUTTON CRUD
    ' ======================================================
    Private Sub SetCRUDVisibility(show As Boolean)
        RoundedButton3.Visible = show   ' Tambah
        RoundedButton1.Visible = show   ' Edit
        RoundedButton2.Visible = show   ' Hapus
    End Sub



    ' ======================================================
    '   LOAD DATA PERTANYAAN (CRUD DIMATIKAN)
    ' ======================================================
    Private Sub LoadPertanyaan()
        currentTab = "pertanyaan"
        Label3.Text = "Pertanyaan"
        CenterLabelTitle()

        ' NONAKTIFKAN CRUD
        SetCRUDVisibility(False)

        Dim query As String =
            "SELECT pertanyaan_id AS [ID],
                    teks_pertanyaan AS [Pertanyaan]
             FROM Pertanyaan
             ORDER BY pertanyaan_id"

        DataGridView1.DataSource = GetData(query)
    End Sub



    ' ======================================================
    '   LOAD DATA PROFESI (CRUD DIMATIKAN)
    ' ======================================================
    Private Sub LoadProfesi()
        currentTab = "profesi"
        Label3.Text = "Profesi"
        CenterLabelTitle()

        ' NONAKTIFKAN CRUD
        SetCRUDVisibility(False)

        Dim query As String =
            "SELECT profesi_id AS [ID],
                    nama_profesi AS [Nama Profesi],
                    deskripsi AS [Deskripsi]
             FROM Profesi
             ORDER BY profesi_id"

        DataGridView1.DataSource = GetData(query)
    End Sub



    ' ======================================================
    '   LOAD DATA ATURAN (CRUD AKTIF)
    ' ======================================================
    Private Sub LoadAturan()
        currentTab = "aturan"
        Label3.Text = "Aturan"
        CenterLabelTitle()

        ' AKTIFKAN CRUD
        SetCRUDVisibility(True)

        Dim query As String =
        "SELECT 
             A.rule_id AS [ID],
             A.profesi_id AS [Profesi],
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
    '   BUTTON TAMBAH (HANYA ATURAN)
    ' ======================================================
    Private Sub RoundedButton3_Click(sender As Object, e As EventArgs) Handles RoundedButton3.Click

        Select Case currentTab

            Case "pertanyaan"
                MessageBox.Show("CRUD untuk Pertanyaan dinonaktifkan.")

            Case "profesi"
                MessageBox.Show("CRUD untuk Profesi dinonaktifkan.")

            Case "aturan"
                Dim f As New CRUDaturan()
                f.mode = "tambah"
                f.Show()
                Me.Hide()

        End Select

    End Sub



    ' ======================================================
    '   BUTTON EDIT (HANYA ATURAN)
    ' ======================================================
    Private Sub RoundedButton1_Click(sender As Object, e As EventArgs) Handles RoundedButton1.Click

        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih baris dulu.", "Peringatan")
            Return
        End If

        Dim selectedRow = DataGridView1.SelectedRows(0)

        Select Case currentTab

            Case "pertanyaan"
                MessageBox.Show("CRUD untuk Pertanyaan dinonaktifkan.")

            Case "profesi"
                MessageBox.Show("CRUD untuk Profesi dinonaktifkan.")

            Case "aturan"
                Dim f As New CRUDaturan()
                f.mode = "edit"
                f.ruleID = Convert.ToInt32(selectedRow.Cells("ID").Value)
                f.profesiID = selectedRow.Cells("Profesi").Value.ToString()
                f.rulePattern = selectedRow.Cells("Pola Rule").Value.ToString()
                f.keterangan = selectedRow.Cells("Keterangan").Value.ToString()
                f.Show()
                Me.Hide()

        End Select
    End Sub



    ' ======================================================
    '   BUTTON HAPUS (HANYA ATURAN)
    ' ======================================================
    Private Sub RoundedButton2_Click(sender As Object, e As EventArgs) Handles RoundedButton2.Click

        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih baris dulu.", "Peringatan")
            Return
        End If

        Dim selectedRow = DataGridView1.SelectedRows(0)
        Dim id = Convert.ToInt32(selectedRow.Cells("ID").Value)

        If MessageBox.Show("Yakin menghapus?", "Konfirmasi",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
            Return
        End If

        Try
            Using conn As SqlConnection = GetConnection()
                conn.Open()

                Select Case currentTab

                    Case "pertanyaan"
                        MessageBox.Show("CRUD untuk Pertanyaan dinonaktifkan.")

                    Case "profesi"
                        MessageBox.Show("CRUD untuk Profesi dinonaktifkan.")

                    Case "aturan"
                        Dim cmd As New SqlCommand("DELETE FROM Aturan WHERE rule_id = @id", conn)
                        cmd.Parameters.AddWithValue("@id", id)
                        cmd.ExecuteNonQuery()
                        MessageBox.Show("Aturan berhasil dihapus.")

                End Select

            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal menghapus: " & ex.Message)
        End Try

        ' Refresh
        Select Case currentTab
            Case "pertanyaan" : LoadPertanyaan()
            Case "profesi" : LoadProfesi()
            Case "aturan" : LoadAturan()
        End Select

    End Sub



    ' ======================================================
    '   ABOUT
    ' ======================================================
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim f As New tentangKamiAdmin()
        f.Show()
        Me.Hide()
    End Sub



    ' ======================================================
    '   BACK
    ' ======================================================
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim f As New landingPage()
        f.Show()
        Me.Hide()
    End Sub



    ' ======================================================
    '   AUTO-CENTER TITLE
    ' ======================================================
    Private Sub Panel3_Resize(sender As Object, e As EventArgs) Handles Panel3.Resize
        CenterLabelTitle()
    End Sub

End Class
