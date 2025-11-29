Imports System.Drawing.Drawing2D

Public Class RoundedButton
    Inherits Button

    Public Property CornerRadius As Integer = 20

    Protected Overrides Sub OnPaint(pevent As PaintEventArgs)
        MyBase.OnPaint(pevent)

        Dim graphics As Graphics = pevent.Graphics
        graphics.SmoothingMode = SmoothingMode.AntiAlias

        Dim rect As Rectangle = New Rectangle(0, 0, Me.Width, Me.Height)
        Dim path As GraphicsPath = GetRoundPath(rect, CornerRadius)

        Me.Region = New Region(path)

        Using pen As New Pen(Me.BackColor, 1)
            graphics.DrawPath(pen, path)
        End Using
    End Sub

    Private Function GetRoundPath(rect As Rectangle, radius As Integer) As GraphicsPath
        Dim path As New GraphicsPath()
        Dim diameter As Integer = radius * 2

        path.StartFigure()
        path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90)
        path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90)
        path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90)
        path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90)
        path.CloseFigure()

        Return path
    End Function
End Class
