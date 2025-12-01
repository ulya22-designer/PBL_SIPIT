<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        ContextMenuStrip1 = New ContextMenuStrip(components)
        Label1 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        Button1 = New RoundedButton()
        Button3 = New RoundedButton()
        PictureBox1 = New PictureBox()
        Label6 = New Label()
        PictureBox2 = New PictureBox()
        Panel1 = New Panel()
        Panel2 = New Panel()
        PictureBox3 = New PictureBox()
        Panel3 = New Panel()
        Panel4 = New Panel()
        PictureBox4 = New PictureBox()
        Label5 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(20, 20)
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(524, 103)
        Label1.Name = "Label1"
        Label1.Size = New Size(133, 42)
        Label1.TabIndex = 1
        Label1.Text = "LOGIN"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold)
        Label2.Location = New Point(404, 171)
        Label2.Name = "Label2"
        Label2.Size = New Size(105, 24)
        Label2.TabIndex = 2
        Label2.Text = "Username"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.FromArgb(CByte(251), CByte(241), CByte(255))
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(2, 14)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(326, 22)
        TextBox1.TabIndex = 4
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.FromArgb(CByte(249), CByte(234), CByte(255))
        TextBox2.BorderStyle = BorderStyle.None
        TextBox2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(3, 15)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(323, 22)
        TextBox2.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold)
        Label3.Location = New Point(404, 267)
        Label3.Name = "Label3"
        Label3.Size = New Size(100, 24)
        Label3.TabIndex = 6
        Label3.Text = "Password"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.FromArgb(CByte(154), CByte(152), CByte(189))
        Label4.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.Window
        Label4.Location = New Point(220, 223)
        Label4.Name = "Label4"
        Label4.Size = New Size(84, 24)
        Label4.TabIndex = 11
        Label4.Text = "SIGN IN"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.SlateBlue
        Button1.CornerRadius = 10
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.Control
        Button1.Location = New Point(406, 369)
        Button1.Name = "Button1"
        Button1.Size = New Size(182, 40)
        Button1.TabIndex = 21
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.Desktop
        Button3.CornerRadius = 10
        Button3.FlatStyle = FlatStyle.Popup
        Button3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = SystemColors.Control
        Button3.Location = New Point(601, 369)
        Button3.Name = "Button3"
        Button3.Size = New Size(181, 40)
        Button3.TabIndex = 22
        Button3.Text = "Kembali"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-2, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(332, 474)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 23
        PictureBox1.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(232, 138)
        Label6.Name = "Label6"
        Label6.Size = New Size(72, 24)
        Label6.TabIndex = 24
        Label6.Text = "LOGIN"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(550, 24)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(79, 76)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 25
        PictureBox2.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(TextBox1)
        Panel1.Location = New Point(404, 189)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(378, 48)
        Panel1.TabIndex = 26
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(47), CByte(49), CByte(98))
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(0, 47)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(378, 1)
        Panel2.TabIndex = 6
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(335, 7)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(37, 36)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 5
        PictureBox3.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Transparent
        Panel3.Controls.Add(Panel4)
        Panel3.Controls.Add(PictureBox4)
        Panel3.Controls.Add(TextBox2)
        Panel3.Location = New Point(406, 282)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(378, 48)
        Panel3.TabIndex = 27
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(47), CByte(49), CByte(98))
        Panel4.Dock = DockStyle.Bottom
        Panel4.Location = New Point(0, 47)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(378, 1)
        Panel4.TabIndex = 6
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(335, 7)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(37, 36)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 5
        PictureBox4.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Montserrat SemiBold", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Blue
        Label5.Location = New Point(672, 342)
        Label5.Name = "Label5"
        Label5.Size = New Size(112, 16)
        Label5.TabIndex = 28
        Label5.Text = "Forgot Password"
        ' 
        ' login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Window
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(834, 467)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label5)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        Controls.Add(PictureBox2)
        Controls.Add(Label6)
        Controls.Add(Button3)
        Controls.Add(Button1)
        Controls.Add(Label4)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As RoundedButton
    Friend WithEvents Button3 As RoundedButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label5 As Label
End Class
