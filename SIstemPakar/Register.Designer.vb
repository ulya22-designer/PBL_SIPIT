<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Register
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Register))
        Label6 = New Label()
        Label7 = New Label()
        Button2 = New Button()
        ErrorProvider1 = New ErrorProvider(components)
        PictureBox1 = New PictureBox()
        Label5 = New Label()
        Label3 = New Label()
        Label9 = New Label()
        Panel3 = New Panel()
        Panel4 = New Panel()
        PictureBox4 = New PictureBox()
        TextBox3 = New TextBox()
        Panel1 = New Panel()
        Panel2 = New Panel()
        PictureBox3 = New PictureBox()
        TextBox1 = New TextBox()
        Label11 = New Label()
        PictureBox5 = New PictureBox()
        RoundedButton1 = New RoundedButton()
        RoundedButton2 = New RoundedButton()
        PictureBox2 = New PictureBox()
        Label10 = New Label()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.FromArgb(CByte(154), CByte(152), CByte(189))
        Label6.Cursor = Cursors.Hand
        Label6.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold)
        Label6.ForeColor = SystemColors.Window
        Label6.Location = New Point(222, 146)
        Label6.Name = "Label6"
        Label6.Size = New Size(72, 24)
        Label6.TabIndex = 11
        Label6.Text = "LOGIN"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold)
        Label7.Location = New Point(79, 441)
        Label7.Name = "Label7"
        Label7.Size = New Size(0, 24)
        Label7.TabIndex = 10
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(46), CByte(48), CByte(97))
        Button2.Font = New Font("Microsoft Sans Serif", 9.0F)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(393, 348)
        Button2.Name = "Button2"
        Button2.Size = New Size(331, 36)
        Button2.TabIndex = 2
        Button2.Text = "Upload Foto (4:3)"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, -5)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(331, 481)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 14
        PictureBox1.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold)
        Label5.Location = New Point(223, 221)
        Label5.Name = "Label5"
        Label5.Size = New Size(84, 24)
        Label5.TabIndex = 9
        Label5.Text = "SIGN IN"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold)
        Label3.Location = New Point(393, 249)
        Label3.Name = "Label3"
        Label3.Size = New Size(100, 24)
        Label3.TabIndex = 3
        Label3.Text = "Password"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold)
        Label9.Location = New Point(393, 173)
        Label9.Name = "Label9"
        Label9.Size = New Size(105, 24)
        Label9.TabIndex = 4
        Label9.Text = "Username"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Transparent
        Panel3.Controls.Add(Panel4)
        Panel3.Controls.Add(PictureBox4)
        Panel3.Controls.Add(TextBox3)
        Panel3.Location = New Point(395, 264)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(378, 48)
        Panel3.TabIndex = 5
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(47), CByte(49), CByte(98))
        Panel4.Dock = DockStyle.Bottom
        Panel4.Location = New Point(0, 47)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(378, 1)
        Panel4.TabIndex = 0
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(335, 7)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(37, 36)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 1
        PictureBox4.TabStop = False
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = Color.FromArgb(CByte(249), CByte(234), CByte(255))
        TextBox3.BorderStyle = BorderStyle.None
        TextBox3.Font = New Font("Segoe UI", 12.0F)
        TextBox3.Location = New Point(3, 18)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(323, 22)
        TextBox3.TabIndex = 2
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(TextBox1)
        Panel1.Location = New Point(393, 191)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(378, 48)
        Panel1.TabIndex = 6
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(47), CByte(49), CByte(98))
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(0, 47)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(378, 1)
        Panel2.TabIndex = 0
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(335, 7)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(37, 36)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 1
        PictureBox3.TabStop = False
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.FromArgb(CByte(251), CByte(241), CByte(255))
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Font = New Font("Segoe UI", 12.0F)
        TextBox1.Location = New Point(2, 17)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(326, 22)
        TextBox1.TabIndex = 2
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold)
        Label11.Location = New Point(389, 321)
        Label11.Name = "Label11"
        Label11.Size = New Size(129, 24)
        Label11.TabIndex = 1
        Label11.Text = "Profile Photo"
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.Transparent
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(730, 348)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(37, 36)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 0
        PictureBox5.TabStop = False
        ' 
        ' RoundedButton1
        ' 
        RoundedButton1.BackColor = SystemColors.Desktop
        RoundedButton1.CornerRadius = 10
        RoundedButton1.FlatStyle = FlatStyle.Popup
        RoundedButton1.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RoundedButton1.ForeColor = SystemColors.Control
        RoundedButton1.Location = New Point(393, 405)
        RoundedButton1.Name = "RoundedButton1"
        RoundedButton1.Size = New Size(181, 40)
        RoundedButton1.TabIndex = 24
        RoundedButton1.Text = "Kembali"
        RoundedButton1.UseVisualStyleBackColor = False
        ' 
        ' RoundedButton2
        ' 
        RoundedButton2.BackColor = Color.SlateBlue
        RoundedButton2.CornerRadius = 10
        RoundedButton2.FlatStyle = FlatStyle.Popup
        RoundedButton2.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RoundedButton2.ForeColor = SystemColors.Control
        RoundedButton2.Location = New Point(585, 405)
        RoundedButton2.Name = "RoundedButton2"
        RoundedButton2.Size = New Size(182, 40)
        RoundedButton2.TabIndex = 23
        RoundedButton2.Text = "Register"
        RoundedButton2.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(556, 25)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(79, 76)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 7
        PictureBox2.TabStop = False
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Microsoft Sans Serif", 27.75F)
        Label10.Location = New Point(492, 104)
        Label10.Name = "Label10"
        Label10.Size = New Size(208, 42)
        Label10.TabIndex = 8
        Label10.Text = "REGISTER"
        ' 
        ' Register
        ' 
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(834, 467)
        Controls.Add(RoundedButton1)
        Controls.Add(RoundedButton2)
        Controls.Add(PictureBox5)
        Controls.Add(Label11)
        Controls.Add(Button2)
        Controls.Add(Label3)
        Controls.Add(Label9)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        Controls.Add(PictureBox2)
        Controls.Add(Label10)
        Controls.Add(Label5)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(PictureBox1)
        Name = "Register"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Register"
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents RoundedButton1 As RoundedButton
    Friend WithEvents RoundedButton2 As RoundedButton
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label10 As Label

End Class
