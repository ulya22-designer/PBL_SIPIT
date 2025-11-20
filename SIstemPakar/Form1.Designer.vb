<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label2 = New Label()
        Button2 = New Button()
        Button1 = New Button()
        PictureBox2 = New PictureBox()
        Label3 = New Label()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Cooper Black", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(112, 254)
        Label2.Name = "Label2"
        Label2.Size = New Size(467, 24)
        Label2.TabIndex = 14
        Label2.Text = "JELI MELIHAT PELUANG KARIR IT ANDA"
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.Desktop
        Button2.Cursor = Cursors.IBeam
        Button2.Font = New Font("Montagu Slab 144pt", 18F)
        Button2.ForeColor = SystemColors.ButtonHighlight
        Button2.Location = New Point(112, 359)
        Button2.Name = "Button2"
        Button2.Size = New Size(467, 38)
        Button2.TabIndex = 13
        Button2.Text = "Keluar"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.SlateBlue
        Button1.Cursor = Cursors.IBeam
        Button1.Font = New Font("Montagu Slab 144pt", 18F)
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(112, 308)
        Button1.Name = "Button1"
        Button1.Size = New Size(467, 38)
        Button1.TabIndex = 12
        Button1.Text = "Mulai"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Location = New Point(287, 48)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(123, 100)
        PictureBox2.TabIndex = 11
        PictureBox2.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Cooper Black", 39.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(262, 179)
        Label3.Name = "Label3"
        Label3.Size = New Size(141, 61)
        Label3.TabIndex = 10
        Label3.Text = "SIPI"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(720, 450)
        Controls.Add(Label2)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(PictureBox2)
        Controls.Add(Label3)
        Name = "Form1"
        Text = "Landing"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label

End Class
