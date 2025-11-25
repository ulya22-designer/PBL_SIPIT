<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        Button2 = New Button()
        Button1 = New Button()
        PictureBox2 = New PictureBox()
        Label3 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(88, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(91, 20)
        Label1.TabIndex = 0
        Label1.Text = "Username"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(27, 24)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(56, 51)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(140, 267)
        Label2.Name = "Label2"
        Label2.Size = New Size(414, 25)
        Label2.TabIndex = 9
        Label2.Text = "JELI MELIHAT PELUANG KARIR IT ANDA"
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.Desktop
        Button2.Cursor = Cursors.IBeam
        Button2.Font = New Font("Microsoft Sans Serif", 18F)
        Button2.ForeColor = SystemColors.ButtonHighlight
        Button2.Location = New Point(114, 366)
        Button2.Name = "Button2"
        Button2.Size = New Size(467, 38)
        Button2.TabIndex = 8
        Button2.Text = "Keluar"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.SlateBlue
        Button1.Cursor = Cursors.IBeam
        Button1.Font = New Font("Microsoft Sans Serif", 18F)
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(114, 315)
        Button1.Name = "Button1"
        Button1.Size = New Size(467, 38)
        Button1.TabIndex = 7
        Button1.Text = "Mulai Tes"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(293, 61)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(123, 100)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 6
        PictureBox2.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 39.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(277, 188)
        Label3.Name = "Label3"
        Label3.Size = New Size(159, 61)
        Label3.TabIndex = 5
        Label3.Text = "SIPIT"
        ' 
        ' Home
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(720, 450)
        Controls.Add(Label2)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(PictureBox2)
        Controls.Add(Label3)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Name = "Home"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Home"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
End Class
