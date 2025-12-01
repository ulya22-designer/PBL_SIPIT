Public Class landingPage
    Private Sub LandingPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisableMaximize(Me)

    End Sub

    Private Sub RoundedButton1_Click(sender As Object, e As EventArgs) Handles RoundedButton1.Click
        Dim f As New login
        f.Show()
        Hide()   ' Menyembunyikan Landing Page
    End Sub

    Private Sub RoundedButton2_Click(sender As Object, e As EventArgs) Handles RoundedButton2.Click
        Application.Exit()
    End Sub
End Class
