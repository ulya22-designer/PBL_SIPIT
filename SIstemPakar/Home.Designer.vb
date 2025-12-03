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
        Label3 = New Label()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Panel2 = New Panel()
        PictureBox3 = New PictureBox()
        Button3 = New RoundedButton()
        RoundedButton1 = New RoundedButton()
        Label7 = New Label()
        PictureBox4 = New PictureBox()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Azeret Mono", 39.7499962F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(411, 230)
        Label3.Name = "Label3"
        Label3.Size = New Size(200, 71)
        Label3.TabIndex = 5
        Label3.Text = "SIPIT"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(445, 104)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(129, 133)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 16
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(30, 18)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(37, 33)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(46), CByte(48), CByte(97))
        Label1.Location = New Point(71, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(91, 20)
        Label1.TabIndex = 0
        Label1.Text = "Username"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(46), CByte(48), CByte(97))
        Label4.Location = New Point(538, 18)
        Label4.Name = "Label4"
        Label4.Size = New Size(61, 22)
        Label4.TabIndex = 18
        Label4.Text = "About"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(46), CByte(48), CByte(97))
        Label5.Location = New Point(621, 18)
        Label5.Name = "Label5"
        Label5.Size = New Size(69, 22)
        Label5.TabIndex = 19
        Label5.Text = "History"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Blue
        Label6.Location = New Point(448, 18)
        Label6.Name = "Label6"
        Label6.Size = New Size(60, 22)
        Label6.TabIndex = 20
        Label6.Text = "Home"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Blue
        Panel2.Location = New Point(444, 43)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(65, 3)
        Panel2.TabIndex = 18
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(-92, 85)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(359, 424)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 21
        PictureBox3.TabStop = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(46), CByte(48), CByte(97))
        Button3.CornerRadius = 10
        Button3.FlatStyle = FlatStyle.Popup
        Button3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = SystemColors.Control
        Button3.Location = New Point(713, 16)
        Button3.Name = "Button3"
        Button3.Size = New Size(89, 32)
        Button3.TabIndex = 24
        Button3.Text = "Logout"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' RoundedButton1
        ' 
        RoundedButton1.BackColor = Color.SlateBlue
        RoundedButton1.CornerRadius = 10
        RoundedButton1.FlatStyle = FlatStyle.Popup
        RoundedButton1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RoundedButton1.ForeColor = SystemColors.Control
        RoundedButton1.Location = New Point(443, 362)
        RoundedButton1.Name = "RoundedButton1"
        RoundedButton1.Size = New Size(131, 40)
        RoundedButton1.TabIndex = 23
        RoundedButton1.Text = "Mulai Tes"
        RoundedButton1.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(283, 310)
        Label7.Name = "Label7"
        Label7.Size = New Size(448, 25)
        Label7.TabIndex = 25
        Label7.Text = "JELI MELIHAT PELUANG KARIR IT ANDA"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.Transparent
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(664, 301)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(192, 186)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 26
        PictureBox4.TabStop = False
        ' 
        ' Home
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(834, 467)
        Controls.Add(Label7)
        Controls.Add(Button3)
        Controls.Add(RoundedButton1)
        Controls.Add(PictureBox3)
        Controls.Add(Panel2)
        Controls.Add(PictureBox2)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(Label3)
        Controls.Add(PictureBox4)
        Name = "Home"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Home"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Button3 As RoundedButton
    Friend WithEvents RoundedButton1 As RoundedButton
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox4 As PictureBox
End Class
