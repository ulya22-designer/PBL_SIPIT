<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Register))
        TextBox1 = New TextBox()
        Label2 = New Label()
        Label4 = New Label()
        TextBox3 = New TextBox()
        Button3 = New Button()
        Button1 = New Button()
        Label1 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Button2 = New Button()
        ErrorProvider1 = New ErrorProvider(components)
        PictureBox1 = New PictureBox()
        Label5 = New Label()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(556, 160)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(236, 23)
        TextBox1.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold)
        Label2.Location = New Point(404, 160)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 24)
        Label2.TabIndex = 5
        Label2.Text = "Nama"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold)
        Label4.Location = New Point(404, 217)
        Label4.Name = "Label4"
        Label4.Size = New Size(100, 24)
        Label4.TabIndex = 17
        Label4.Text = "Password"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(556, 217)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(236, 23)
        TextBox3.TabIndex = 18
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.Desktop
        Button3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = SystemColors.ButtonHighlight
        Button3.Location = New Point(404, 374)
        Button3.Name = "Button3"
        Button3.Size = New Size(388, 31)
        Button3.TabIndex = 20
        Button3.Text = "Keluar"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.SlateBlue
        Button1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(404, 337)
        Button1.Name = "Button1"
        Button1.Size = New Size(388, 31)
        Button1.TabIndex = 19
        Button1.Text = "Simpan"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(508, 78)
        Label1.Name = "Label1"
        Label1.Size = New Size(208, 42)
        Label1.TabIndex = 21
        Label1.Text = "REGISTER"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.FromArgb(CByte(154), CByte(152), CByte(189))
        Label6.Cursor = Cursors.Hand
        Label6.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.Window
        Label6.Location = New Point(222, 146)
        Label6.Name = "Label6"
        Label6.Size = New Size(72, 24)
        Label6.TabIndex = 22
        Label6.Text = "LOGIN"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold)
        Label7.Location = New Point(79, 441)
        Label7.Name = "Label7"
        Label7.Size = New Size(0, 24)
        Label7.TabIndex = 23
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold)
        Label8.Location = New Point(404, 272)
        Label8.Name = "Label8"
        Label8.Size = New Size(105, 24)
        Label8.TabIndex = 24
        Label8.Text = "Foto Profil"
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Microsoft Sans Serif", 9.749998F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(556, 269)
        Button2.Name = "Button2"
        Button2.Size = New Size(236, 25)
        Button2.TabIndex = 26
        Button2.Text = "Upload Foto (4:3)"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-1, -5)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(331, 481)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 28
        PictureBox1.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(223, 221)
        Label5.Name = "Label5"
        Label5.Size = New Size(84, 24)
        Label5.TabIndex = 29
        Label5.Text = "SIGN IN"
        ' 
        ' Register
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(834, 467)
        Controls.Add(Label5)
        Controls.Add(Button2)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label1)
        Controls.Add(Button3)
        Controls.Add(Button1)
        Controls.Add(TextBox3)
        Controls.Add(Label4)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Name = "Register"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Register"
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
End Class
