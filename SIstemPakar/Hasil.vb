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

    ' ======================================================
    ' FORM LOAD
    ' ======================================================
    Private Sub Hasil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisableMaximize(Me)
        Me.StartPosition = FormStartPosition.CenterScreen

        MakePictureBoxRound(PictureBox1)

        Label1.Text = CurrentUserName
        If CurrentUserFoto IsNot Nothing Then
            PictureBox1.Image = ByteArrayToImage(CurrentUserFoto)
        End If

        ' ===== SETUP LABEL (SEKALI SAJA) =====
        Label3.AutoSize = True
        Label3.TextAlign = ContentAlignment.MiddleCenter

        Label2.AutoSize = True
        Label2.MaximumSize = New Size(600, 0)
        Label2.TextAlign = ContentAlignment.MiddleCenter

        ProsesDiagnosis()
        SimpanKeDatabase()

        CenterLabel(Label3, Panel1)
        CenterLabel(Label2, Panel2)
    End Sub

    ' ======================================================
    ' UTIL
    ' ======================================================
    Private Sub MakePictureBoxRound(pb As PictureBox)
        Dim gp As New GraphicsPath()
        gp.AddEllipse(0, 0, pb.Width - 1, pb.Height - 1)
        pb.Region = New Region(gp)
    End Sub

    Private Sub CenterLabel(lbl As Label, pnl As Panel)
        If lbl Is Nothing OrElse pnl Is Nothing Then Exit Sub
        lbl.Left = (pnl.Width - lbl.Width) \ 2
        lbl.Top = (pnl.Height - lbl.Height) \ 2
    End Sub

    ' ======================================================
    ' PROSES DIAGNOSIS
    ' ======================================================
    Private Sub ProsesDiagnosis()

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
                        If rd("rule_pattern").ToString() = userPattern Then
                            profesiIdHasil = CInt(rd("profesi_id"))
                            namaProfesi = rd("nama_profesi").ToString()
                            keteranganProfesi = rd("Keterangan").ToString()
                            found = True
                            Exit While
                        End If
                    End While
                End Using
            End Using

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

        ' ===== UPDATE UI =====
        Label3.Text = namaProfesi
        Label2.Text = keteranganProfesi

        CenterLabel(Label3, Panel1)
        CenterLabel(Label2, Panel2)
    End Sub

    ' ======================================================
    ' SIMPAN DATABASE
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
    ' CETAK
    ' ======================================================
    Private Sub RoundedButton2_Click(sender As Object, e As EventArgs) Handles RoundedButton2.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    ' (ISI PrintDocument1_PrintPage TIDAK DIUBAH – SAMA SEPERTI PUNYA KAMU)

    ' ======================================================
    ' NAVIGASI
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

    ' ======================================================
    ' KEEP CENTER SAAT RESIZE
    ' ======================================================
    Private Sub Panel1_Resize(sender As Object, e As EventArgs) Handles Panel1.Resize
        CenterLabel(Label3, Panel1)
    End Sub

    Private Sub Panel2_Resize(sender As Object, e As EventArgs) Handles Panel2.Resize
        CenterLabel(Label2, Panel2)
    End Sub

    Private Sub Label3_SizeChanged(sender As Object, e As EventArgs) Handles Label3.SizeChanged
        CenterLabel(Label3, Panel1)
    End Sub

    Private Sub Label2_SizeChanged(sender As Object, e As EventArgs) Handles Label2.SizeChanged
        CenterLabel(Label2, Panel2)
    End Sub

End Class
