Public Class landingPage

    ' Tombol Login
    Private Sub RoundedButton1_Click(sender As Object, e As EventArgs) Handles RoundedButton1.Click
        Dim f As New login
        f.Show()
        Hide() ' Sembunyikan landing page
    End Sub

    ' Tombol Exit
    Private Sub RoundedButton2_Click(sender As Object, e As EventArgs) Handles RoundedButton2.Click
        Application.Exit()
    End Sub

    Private Sub landingPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load event
    End Sub

End Class
