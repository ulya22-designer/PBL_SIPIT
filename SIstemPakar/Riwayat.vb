Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient
Imports System.Drawing.Drawing2D

Public Class Riwayat
    Public Property userId As Integer
    Private Sub Riwayat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisableMaximize(Me)
        Me.StartPosition = FormStartPosition.CenterScreen

        ' ===== TAMPILKAN USERNAME =====
        Label2.Text = CurrentUserName

        ' ===== TAMPILKAN FOTO PROFIL =====
        If CurrentUserFoto IsNot Nothing Then
            PictureBox1.Image = ByteArrayToImage(CurrentUserFoto)
            MakePictureBoxRound(PictureBox1)
        End If

        LoadRiwayat()
        FormatGrid()
    End Sub


    ' =====================================================
    ' MEMBUAT FOTO PROFIL MENJADI BULAT
    ' =====================================================
    Private Sub MakePictureBoxRound(pb As PictureBox)
        Dim gp As New GraphicsPath()
        gp.AddEllipse(0, 0, pb.Width - 1, pb.Height - 1)
        pb.Region = New Region(gp)
    End Sub



    ' =====================================================
    ' LOAD RIWAYAT DARI DATABASE
    ' =====================================================
    Private Sub LoadRiwayat()
        Try
            Using conn As New SqlConnection(connStr)
                conn.Open()

                Dim query As String =
                    "SELECT 
                        HU.tanggal AS [Tanggal],
                        P.nama_profesi AS [Profesi],
                        P.deskripsi AS [Keterangan]
                     FROM Hasil_User HU
                     JOIN Profesi P ON HU.profesi_id = P.profesi_id
                     WHERE HU.user_id = @uid
                     ORDER BY HU.tanggal DESC"

                Using da As New SqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@uid", CurrentUserID)

                    Dim dt As New DataTable
                    da.Fill(dt)

                    ' tambah kolom No
                    If Not dt.Columns.Contains("No") Then
                        dt.Columns.Add("No", GetType(Integer))
                    End If

                    ' isi nomor urut 1..n
                    For i As Integer = 0 To dt.Rows.Count - 1
                        dt.Rows(i)("No") = i + 1
                    Next

                    DataGridView1.DataSource = dt

                    ' Kolom No jadi pertama
                    If DataGridView1.Columns.Contains("No") Then
                        DataGridView1.Columns("No").DisplayIndex = 0
                        DataGridView1.Columns("No").Width = 50
                        DataGridView1.Columns("No").DefaultCellStyle.Alignment =
                            DataGridViewContentAlignment.MiddleCenter
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal memuat riwayat: " & ex.Message)
        End Try
    End Sub



    ' =====================================================
    ' FORMAT DATAGRIDVIEW
    ' =====================================================
    Private Sub FormatGrid()
        With DataGridView1
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .DefaultCellStyle.WrapMode = DataGridViewTriState.True
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            .AllowUserToAddRows = False
            .ReadOnly = True
            .RowHeadersVisible = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect

            .ColumnHeadersDefaultCellStyle.Font = New Font("Times New Roman", 11, FontStyle.Bold)
            .DefaultCellStyle.Font = New Font("Times New Roman", 11)
        End With
    End Sub


    ' =====================================================
    ' DELETE satu baris + perbaiki nomor ulang
    ' =====================================================
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih baris dulu yang akan dihapus!")
            Exit Sub
        End If

        If MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi",
                           MessageBoxButtons.YesNo) = DialogResult.Yes Then

            ' hapus row
            DataGridView1.Rows.Remove(DataGridView1.SelectedRows(0))

            ' perbaiki nomor urut lagi
            For i As Integer = 0 To DataGridView1.Rows.Count - 1
                DataGridView1.Rows(i).Cells("No").Value = i + 1
            Next
        End If

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

    Private Sub RoundedButton1_Click(sender As Object, e As EventArgs) Handles RoundedButton1.Click
        Dim f As New landingPage()
        f.Show()
        Me.Hide()
    End Sub
End Class
