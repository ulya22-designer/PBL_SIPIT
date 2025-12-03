Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient
Imports System.IO
Imports System.Drawing.Drawing2D

Public Class Home

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisableMaximize(Me)
        Me.StartPosition = FormStartPosition.CenterScreen

        MakePictureBoxRound(PictureBox1)
        LoadUserData()
    End Sub

    Private Sub MakePictureBoxRound(pb As PictureBox)
        Dim gp As New GraphicsPath()
        gp.AddEllipse(0, 0, pb.Width - 1, pb.Height - 1)
        pb.Region = New Region(gp)
    End Sub

    Private Sub LoadUserData()
        Label1.Text = CurrentUserName

        If CurrentUserFoto IsNot Nothing Then
            PictureBox1.Image = ByteArrayToImage(CurrentUserFoto)
        Else
            PictureBox1.Image = Nothing
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim f As New tentangKami()
        f.Show()
        Me.Hide()
    End Sub

    Private Sub RoundedButton1_Click(sender As Object, e As EventArgs) Handles RoundedButton1.Click
        Dim p As New Pertanyaan()
        p.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Dim f As New landingPage()
        f.Show()
        Me.Hide()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Dim r As New Riwayat()
        r.Show()
        Me.Hide()
    End Sub

End Class
