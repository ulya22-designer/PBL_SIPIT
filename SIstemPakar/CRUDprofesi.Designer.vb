<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CRUDprofesi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CRUDprofesi))
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        Button3 = New RoundedButton()
        Panel2 = New Panel()
        Label4 = New Label()
        PictureBox4 = New PictureBox()
        Label3 = New Label()
        Panel1 = New Panel()
        Panel3 = New Panel()
        TextBox1 = New TextBox()
        Label5 = New Label()
        Panel4 = New Panel()
        Panel5 = New Panel()
        TextBox2 = New TextBox()
        Label6 = New Label()
        TextBox3 = New TextBox()
        Panel6 = New Panel()
        Panel7 = New Panel()
        RoundedButton3 = New RoundedButton()
        RoundedButton2 = New RoundedButton()
        Label7 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel4.SuspendLayout()
        Panel6.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(46), CByte(48), CByte(97))
        Label1.Location = New Point(61, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(57, 20)
        Label1.TabIndex = 43
        Label1.Text = "admin"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(18, 19)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(37, 33)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 44
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.MediumVioletRed
        Label2.Location = New Point(498, 23)
        Label2.Name = "Label2"
        Label2.Size = New Size(109, 20)
        Label2.TabIndex = 48
        Label2.Text = "Admin Panel"
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(46), CByte(48), CByte(97))
        Button3.CornerRadius = 10
        Button3.FlatStyle = FlatStyle.Popup
        Button3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = SystemColors.Control
        Button3.Location = New Point(717, 19)
        Button3.Name = "Button3"
        Button3.Size = New Size(89, 32)
        Button3.TabIndex = 47
        Button3.Text = "Logout"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.MediumVioletRed
        Panel2.Location = New Point(494, 47)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(115, 3)
        Panel2.TabIndex = 45
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(46), CByte(48), CByte(97))
        Label4.Location = New Point(632, 23)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 20)
        Label4.TabIndex = 46
        Label4.Text = "About"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.Transparent
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(658, 285)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(192, 186)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 42
        PictureBox4.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold)
        Label3.Location = New Point(94, 123)
        Label3.Name = "Label3"
        Label3.Size = New Size(29, 24)
        Label3.TabIndex = 49
        Label3.Text = "ID"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(TextBox1)
        Panel1.Location = New Point(94, 141)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(627, 48)
        Panel1.TabIndex = 50
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(47), CByte(49), CByte(98))
        Panel3.Dock = DockStyle.Bottom
        Panel3.Location = New Point(0, 47)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(627, 1)
        Panel3.TabIndex = 6
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.FromArgb(CByte(251), CByte(241), CByte(255))
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(2, 17)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(622, 22)
        TextBox1.TabIndex = 4
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold)
        Label5.Location = New Point(94, 205)
        Label5.Name = "Label5"
        Label5.Size = New Size(134, 24)
        Label5.TabIndex = 51
        Label5.Text = "Nama Profesi"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Transparent
        Panel4.Controls.Add(Panel5)
        Panel4.Controls.Add(TextBox2)
        Panel4.Location = New Point(94, 223)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(627, 48)
        Panel4.TabIndex = 52
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(47), CByte(49), CByte(98))
        Panel5.Dock = DockStyle.Bottom
        Panel5.Location = New Point(0, 47)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(627, 1)
        Panel5.TabIndex = 6
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.FromArgb(CByte(251), CByte(241), CByte(255))
        TextBox2.BorderStyle = BorderStyle.None
        TextBox2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(2, 17)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(622, 22)
        TextBox2.TabIndex = 4
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold)
        Label6.Location = New Point(94, 290)
        Label6.Name = "Label6"
        Label6.Size = New Size(95, 24)
        Label6.TabIndex = 53
        Label6.Text = "Deskripsi"
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = Color.FromArgb(CByte(251), CByte(241), CByte(255))
        TextBox3.BorderStyle = BorderStyle.None
        TextBox3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox3.Location = New Point(2, 17)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(622, 46)
        TextBox3.TabIndex = 4
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.Transparent
        Panel6.Controls.Add(Panel7)
        Panel6.Controls.Add(TextBox3)
        Panel6.Location = New Point(94, 308)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(627, 70)
        Panel6.TabIndex = 54
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.FromArgb(CByte(47), CByte(49), CByte(98))
        Panel7.Dock = DockStyle.Bottom
        Panel7.Location = New Point(0, 69)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(627, 1)
        Panel7.TabIndex = 6
        ' 
        ' RoundedButton3
        ' 
        RoundedButton3.BackColor = Color.SlateBlue
        RoundedButton3.CornerRadius = 10
        RoundedButton3.FlatStyle = FlatStyle.Popup
        RoundedButton3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RoundedButton3.ForeColor = SystemColors.Control
        RoundedButton3.Location = New Point(272, 405)
        RoundedButton3.Name = "RoundedButton3"
        RoundedButton3.Size = New Size(119, 40)
        RoundedButton3.TabIndex = 56
        RoundedButton3.Text = "Simpan"
        RoundedButton3.UseVisualStyleBackColor = False
        ' 
        ' RoundedButton2
        ' 
        RoundedButton2.BackColor = SystemColors.Desktop
        RoundedButton2.CornerRadius = 10
        RoundedButton2.FlatStyle = FlatStyle.Popup
        RoundedButton2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RoundedButton2.ForeColor = SystemColors.Control
        RoundedButton2.Location = New Point(427, 405)
        RoundedButton2.Name = "RoundedButton2"
        RoundedButton2.Size = New Size(119, 40)
        RoundedButton2.TabIndex = 55
        RoundedButton2.Text = "Batal"
        RoundedButton2.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(361, 81)
        Label7.Name = "Label7"
        Label7.Size = New Size(106, 33)
        Label7.TabIndex = 57
        Label7.Text = "Profesi"
        ' 
        ' CRUDprofesi
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(834, 467)
        Controls.Add(Label7)
        Controls.Add(RoundedButton3)
        Controls.Add(RoundedButton2)
        Controls.Add(Label6)
        Controls.Add(Panel6)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Panel4)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Controls.Add(Button3)
        Controls.Add(Panel2)
        Controls.Add(Label4)
        Controls.Add(PictureBox4)
        Name = "CRUDprofesi"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CRUDprofesi"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button3 As RoundedButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents RoundedButton3 As RoundedButton
    Friend WithEvents RoundedButton2 As RoundedButton
    Friend WithEvents Label7 As Label
End Class
