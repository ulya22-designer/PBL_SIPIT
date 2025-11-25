Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient
Imports System.Drawing.Drawing2D

Public Class Pertanyaan

    Dim listPertanyaan As New List(Of String)
    Dim jawaban(4) As String
    Dim currentIndex As Integer = 0

    ' warna default tombol YA/TIDAK
    Dim defaultYaColor As Color
    Dim defaultTidakColor As Color

    Private Sub Pertanyaan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen

        ' simpan warna awal tombol YA & TIDAK
        defaultYaColor = Button1.BackColor
        defaultTidakColor = Button2.BackColor

        Label1.Text = CurrentUserName

        If CurrentUserFoto IsNot Nothing Then
            PictureBox1.Image = ByteArrayToImage(CurrentUserFoto)
        End If

        ' foto bulat
        Dim gp As New GraphicsPath()
        gp.AddEllipse(0, 0, PictureBox1.Width - 1, PictureBox1.Height - 1)
        PictureBox1.Region = New Region(gp)

        LoadPertanyaan()
        TampilkanPertanyaan(0)
        UpdateNavigasi()
        UpdateNomorButton()

        Button10.Visible = False
    End Sub


    Private Sub LoadPertanyaan()
        Using conn As New SqlConnection(connStr)
            conn.Open()
            Dim query As String = "SELECT teks_pertanyaan FROM Pertanyaan ORDER BY pertanyaan_id ASC"

            Using cmd As New SqlCommand(query, conn)
                Dim rd = cmd.ExecuteReader()
                While rd.Read()
                    listPertanyaan.Add(rd("teks_pertanyaan").ToString())
                End While
            End Using
        End Using
    End Sub


    Private Sub TampilkanPertanyaan(index As Integer)
        currentIndex = index

        Label2.MaximumSize = New Size(700, 0)
        Label2.AutoSize = True
        Label2.TextAlign = ContentAlignment.MiddleCenter
        Label2.Text = listPertanyaan(index)

        UpdateNavigasi()
        UpdateNomorButton()
        UpdateSubmitButton()
        UpdateJawabanButton()
    End Sub


    Private Sub UpdateNavigasi()
        Button9.Enabled = (currentIndex > 0)
        Button3.Enabled = (currentIndex < listPertanyaan.Count - 1)
    End Sub


    Private Sub UpdateNomorButton()
        Dim buttons As Button() = {Button4, Button5, Button6, Button8, Button7}

        For i As Integer = 0 To 4
            If jawaban(i) IsNot Nothing Then
                buttons(i).BackColor = Color.LightGreen
            ElseIf i = currentIndex Then
                buttons(i).BackColor = Color.LightBlue
            Else
                buttons(i).BackColor = Color.White
            End If
        Next

        UpdateSubmitButton()
    End Sub


    ' =============================
    ' HIGHLIGHT YA/TIDAK 
    ' =============================
    Private Sub UpdateJawabanButton()

        ' reset ke warna default desain
        Button1.BackColor = defaultYaColor
        Button2.BackColor = defaultTidakColor

        If jawaban(currentIndex) = "ya" Then
            Button1.BackColor = Color.LightGreen
        ElseIf jawaban(currentIndex) = "tidak" Then
            Button2.BackColor = Color.LightCoral
        End If

    End Sub



    ' =============================
    ' SUBMIT BUTTON
    ' =============================
    Private Sub UpdateSubmitButton()

        Dim semuaTerisi As Boolean = True

        For i As Integer = 0 To 4
            If jawaban(i) Is Nothing Then
                semuaTerisi = False
                Exit For
            End If
        Next

        Button10.Visible = (semuaTerisi AndAlso currentIndex = 4)

    End Sub


    ' =============================
    ' BUTTON NOMOR
    ' =============================
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TampilkanPertanyaan(0)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TampilkanPertanyaan(1)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TampilkanPertanyaan(2)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TampilkanPertanyaan(3)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TampilkanPertanyaan(4)
    End Sub


    ' =============================
    ' NAVIGASI KIRI KANAN
    ' =============================
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If currentIndex > 0 Then
            TampilkanPertanyaan(currentIndex - 1)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If currentIndex < listPertanyaan.Count - 1 Then
            TampilkanPertanyaan(currentIndex + 1)
        End If
    End Sub


    ' =============================
    ' JAWAB YA
    ' =============================
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        jawaban(currentIndex) = "ya"
        UpdateJawabanButton()
        UpdateNomorButton()
        NextOrFinish()
    End Sub

    ' =============================
    ' JAWAB TIDAK
    ' =============================
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        jawaban(currentIndex) = "tidak"
        UpdateJawabanButton()
        UpdateNomorButton()
        NextOrFinish()
    End Sub


    Private Sub NextOrFinish()

        If currentIndex < listPertanyaan.Count - 1 Then
            currentIndex += 1
            TampilkanPertanyaan(currentIndex)
            Return
        End If

        UpdateSubmitButton()

    End Sub


    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

        For i = 0 To 4
            If jawaban(i) Is Nothing Then
                MessageBox.Show("Pertanyaan nomor " & (i + 1) & " belum dijawab!")
                Return
            End If
        Next

        Dim f As New Hasil(jawaban, CurrentUserID)
        f.Show()
        Me.Hide()

    End Sub

End Class
