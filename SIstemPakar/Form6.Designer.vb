<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        PictureBox2 = New PictureBox()
        Button2 = New Button()
        Button1 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(14, 17)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(41, 29)
        PictureBox1.TabIndex = 28
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Montagu Slab 144pt Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(61, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(90, 23)
        Label1.TabIndex = 27
        Label1.Text = "Username"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Cooper Black", 39.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(114, 208)
        Label3.Name = "Label3"
        Label3.Size = New Size(462, 61)
        Label3.TabIndex = 29
        Label3.Text = "HASIL PROFESI"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Montagu Slab 144pt Medium", 14.25F, FontStyle.Bold)
        Label2.Location = New Point(266, 278)
        Label2.Name = "Label2"
        Label2.Size = New Size(154, 28)
        Label2.TabIndex = 30
        Label2.Text = "KETERANGAN"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Location = New Point(222, 56)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(243, 133)
        PictureBox2.TabIndex = 31
        PictureBox2.TabStop = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.Desktop
        Button2.Cursor = Cursors.IBeam
        Button2.Font = New Font("Montagu Slab 144pt", 18F)
        Button2.ForeColor = SystemColors.ButtonHighlight
        Button2.Location = New Point(109, 406)
        Button2.Name = "Button2"
        Button2.Size = New Size(467, 38)
        Button2.TabIndex = 33
        Button2.Text = "Keluar"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.SlateBlue
        Button1.Cursor = Cursors.IBeam
        Button1.Font = New Font("Montagu Slab 144pt", 18F)
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(109, 355)
        Button1.Name = "Button1"
        Button1.Size = New Size(467, 38)
        Button1.TabIndex = 32
        Button1.Text = "Cetak Hasil"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(720, 494)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(PictureBox2)
        Controls.Add(Label2)
        Controls.Add(Label3)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Name = "Form6"
        Text = "Hasil"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
