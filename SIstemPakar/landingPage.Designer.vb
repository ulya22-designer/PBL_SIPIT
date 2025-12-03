<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class landingPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(landingPage))
        Label2 = New Label()
        Label3 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox3 = New PictureBox()
        RoundedButton1 = New RoundedButton()
        RoundedButton2 = New RoundedButton()
        PictureBox4 = New PictureBox()
        PictureBox2 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(31, 235)
        Label2.Name = "Label2"
        Label2.Size = New Size(448, 25)
        Label2.TabIndex = 14
        Label2.Text = "JELI MELIHAT PELUANG KARIR IT ANDA"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Azeret Mono Medium", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(70, 21)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 25)
        Label3.TabIndex = 10
        Label3.Text = "SIPIT"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(31, 17)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(37, 37)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 15
        PictureBox1.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(-2, 297)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(209, 176)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 17
        PictureBox3.TabStop = False
        ' 
        ' RoundedButton1
        ' 
        RoundedButton1.Anchor = AnchorStyles.None
        RoundedButton1.BackColor = Color.SlateBlue
        RoundedButton1.CornerRadius = 10
        RoundedButton1.FlatStyle = FlatStyle.Popup
        RoundedButton1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RoundedButton1.ForeColor = SystemColors.Control
        RoundedButton1.Location = New Point(31, 297)
        RoundedButton1.Name = "RoundedButton1"
        RoundedButton1.Size = New Size(103, 40)
        RoundedButton1.TabIndex = 19
        RoundedButton1.Text = "Mulai"
        RoundedButton1.UseVisualStyleBackColor = False
        ' 
        ' RoundedButton2
        ' 
        RoundedButton2.Anchor = AnchorStyles.None
        RoundedButton2.BackColor = SystemColors.Desktop
        RoundedButton2.CornerRadius = 10
        RoundedButton2.FlatStyle = FlatStyle.Popup
        RoundedButton2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RoundedButton2.ForeColor = SystemColors.Control
        RoundedButton2.Location = New Point(140, 297)
        RoundedButton2.Name = "RoundedButton2"
        RoundedButton2.Size = New Size(103, 39)
        RoundedButton2.TabIndex = 20
        RoundedButton2.Text = "Keluar"
        RoundedButton2.UseVisualStyleBackColor = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.Transparent
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(12, 98)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(329, 134)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 21
        PictureBox4.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(417, -16)
        PictureBox2.Margin = New Padding(0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(427, 489)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 22
        PictureBox2.TabStop = False
        ' 
        ' landingPage
        ' 
        AutoScaleMode = AutoScaleMode.None
        AutoSize = True
        BackColor = SystemColors.Window
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(834, 467)
        Controls.Add(PictureBox4)
        Controls.Add(Label2)
        Controls.Add(RoundedButton2)
        Controls.Add(RoundedButton1)
        Controls.Add(PictureBox1)
        Controls.Add(Label3)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        MaximizeBox = False
        Name = "landingPage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Landing"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents RoundedButton1 As RoundedButton
    Friend WithEvents RoundedButton2 As RoundedButton
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox

End Class
