Module FormSettings
    Public Sub DisableMaximize(frm As Form)
        frm.MaximizeBox = False
        frm.FormBorderStyle = FormBorderStyle.FixedSingle
    End Sub
End Module
