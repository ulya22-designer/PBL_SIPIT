<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CRUDaturan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CRUDaturan))
        Label7 = New Label()
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
        Label9 = New Label()
        Panel10 = New Panel()
        Panel11 = New Panel()
        TextBox5 = New TextBox()
        Label10 = New Label()
        Panel12 = New Panel()
        Panel13 = New Panel()
        TextBox6 = New TextBox()
        RoundedButton3 = New RoundedButton()
        RoundedButton2 = New RoundedButton()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel4.SuspendLayout()
        Panel10.SuspendLayout()
        Panel12.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(354, 98)
        Label7.Name = "Label7"
        Label7.Size = New Size(100, 33)
        Label7.TabIndex = 65
        Label7.Text = "Aturan"
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
        Label1.TabIndex = 59
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
        PictureBox1.TabIndex = 60
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
        Label2.TabIndex = 64
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
        Button3.TabIndex = 63
        Button3.Text = "Logout"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.MediumVioletRed
        Panel2.Location = New Point(494, 47)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(115, 3)
        Panel2.TabIndex = 61
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
        Label4.TabIndex = 62
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
        PictureBox4.TabIndex = 58
        PictureBox4.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold)
        Label3.Location = New Point(56, 158)
        Label3.Name = "Label3"
        Label3.Size = New Size(78, 24)
        Label3.TabIndex = 66
        Label3.Text = "ID Rule"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(TextBox1)
        Panel1.Location = New Point(56, 176)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(332, 48)
        Panel1.TabIndex = 67
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(47), CByte(49), CByte(98))
        Panel3.Dock = DockStyle.Bottom
        Panel3.Location = New Point(0, 47)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(332, 1)
        Panel3.TabIndex = 6
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.FromArgb(CByte(251), CByte(241), CByte(255))
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(2, 17)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(327, 22)
        TextBox1.TabIndex = 4
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold)
        Label5.Location = New Point(428, 158)
        Label5.Name = "Label5"
        Label5.Size = New Size(99, 24)
        Label5.TabIndex = 68
        Label5.Text = "ID Profesi"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Transparent
        Panel4.Controls.Add(Panel5)
        Panel4.Controls.Add(TextBox2)
        Panel4.Location = New Point(428, 176)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(332, 48)
        Panel4.TabIndex = 69
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(47), CByte(49), CByte(98))
        Panel5.Dock = DockStyle.Bottom
        Panel5.Location = New Point(0, 47)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(332, 1)
        Panel5.TabIndex = 6
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.FromArgb(CByte(251), CByte(241), CByte(255))
        TextBox2.BorderStyle = BorderStyle.None
        TextBox2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(2, 17)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(327, 22)
        TextBox2.TabIndex = 4
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold)
        Label9.Location = New Point(428, 245)
        Label9.Name = "Label9"
        Label9.Size = New Size(124, 24)
        Label9.TabIndex = 72
        Label9.Text = "Rule Pattern"
        ' 
        ' Panel10
        ' 
        Panel10.BackColor = Color.Transparent
        Panel10.Controls.Add(Panel11)
        Panel10.Controls.Add(TextBox5)
        Panel10.Location = New Point(428, 263)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(332, 48)
        Panel10.TabIndex = 73
        ' 
        ' Panel11
        ' 
        Panel11.BackColor = Color.FromArgb(CByte(47), CByte(49), CByte(98))
        Panel11.Dock = DockStyle.Bottom
        Panel11.Location = New Point(0, 47)
        Panel11.Name = "Panel11"
        Panel11.Size = New Size(332, 1)
        Panel11.TabIndex = 6
        ' 
        ' TextBox5
        ' 
        TextBox5.BackColor = Color.FromArgb(CByte(251), CByte(241), CByte(255))
        TextBox5.BorderStyle = BorderStyle.None
        TextBox5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox5.Location = New Point(2, 17)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(327, 22)
        TextBox5.TabIndex = 4
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold)
        Label10.Location = New Point(56, 238)
        Label10.Name = "Label10"
        Label10.Size = New Size(117, 24)
        Label10.TabIndex = 70
        Label10.Text = "Keterangan"
        ' 
        ' Panel12
        ' 
        Panel12.BackColor = Color.Transparent
        Panel12.Controls.Add(Panel13)
        Panel12.Controls.Add(TextBox6)
        Panel12.Location = New Point(56, 256)
        Panel12.Name = "Panel12"
        Panel12.Size = New Size(332, 48)
        Panel12.TabIndex = 71
        ' 
        ' Panel13
        ' 
        Panel13.BackColor = Color.FromArgb(CByte(47), CByte(49), CByte(98))
        Panel13.Dock = DockStyle.Bottom
        Panel13.Location = New Point(0, 47)
        Panel13.Name = "Panel13"
        Panel13.Size = New Size(332, 1)
        Panel13.TabIndex = 6
        ' 
        ' TextBox6
        ' 
        TextBox6.BackColor = Color.FromArgb(CByte(251), CByte(241), CByte(255))
        TextBox6.BorderStyle = BorderStyle.None
        TextBox6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox6.Location = New Point(2, 17)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(327, 22)
        TextBox6.TabIndex = 4
        ' 
        ' RoundedButton3
        ' 
        RoundedButton3.BackColor = Color.SlateBlue
        RoundedButton3.CornerRadius = 10
        RoundedButton3.FlatStyle = FlatStyle.Popup
        RoundedButton3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RoundedButton3.ForeColor = SystemColors.Control
        RoundedButton3.Location = New Point(273, 390)
        RoundedButton3.Name = "RoundedButton3"
        RoundedButton3.Size = New Size(119, 40)
        RoundedButton3.TabIndex = 75
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
        RoundedButton2.Location = New Point(428, 390)
        RoundedButton2.Name = "RoundedButton2"
        RoundedButton2.Size = New Size(119, 40)
        RoundedButton2.TabIndex = 74
        RoundedButton2.Text = "Batal"
        RoundedButton2.UseVisualStyleBackColor = False
        ' 
        ' CRUDaturan
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(834, 467)
        Controls.Add(RoundedButton3)
        Controls.Add(RoundedButton2)
        Controls.Add(Label9)
        Controls.Add(Panel10)
        Controls.Add(Label10)
        Controls.Add(Panel12)
        Controls.Add(Label5)
        Controls.Add(Panel4)
        Controls.Add(Label3)
        Controls.Add(Panel1)
        Controls.Add(Label7)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Controls.Add(Button3)
        Controls.Add(Panel2)
        Controls.Add(Label4)
        Controls.Add(PictureBox4)
        Name = "CRUDaturan"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CRUDaturan"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel10.ResumeLayout(False)
        Panel10.PerformLayout()
        Panel12.ResumeLayout(False)
        Panel12.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label7 As Label
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
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Panel13 As Panel
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents RoundedButton3 As RoundedButton
    Friend WithEvents RoundedButton2 As RoundedButton
End Class
