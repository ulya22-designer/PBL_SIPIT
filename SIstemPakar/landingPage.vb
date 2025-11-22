Public Class landingPage


    Private Sub LandingPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f As New login()
        f.Show()
        Me.Hide()   ' Menyembunyikan Landing Page
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub


End Class
