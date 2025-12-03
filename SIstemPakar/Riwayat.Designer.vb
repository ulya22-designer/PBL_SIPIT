<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Riwayat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Riwayat))
        PictureBox2 = New PictureBox()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        Button3 = New RoundedButton()
        RoundedButton1 = New RoundedButton()
        Panel2 = New Panel()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox3 = New PictureBox()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(370, 77)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(79, 76)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 29
        PictureBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(234, 167)
        Label1.Name = "Label1"
        Label1.Size = New Size(351, 42)
        Label1.TabIndex = 28
        Label1.Text = "RIWAYAT SURVEY"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(55, 224)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(719, 162)
        DataGridView1.TabIndex = 30
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.Desktop
        Button3.CornerRadius = 10
        Button3.FlatStyle = FlatStyle.Popup
        Button3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = SystemColors.Control
        Button3.Location = New Point(343, 402)
        Button3.Name = "Button3"
        Button3.Size = New Size(119, 40)
        Button3.TabIndex = 32
        Button3.Text = "Delete"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' RoundedButton1
        ' 
        RoundedButton1.BackColor = Color.FromArgb(CByte(46), CByte(48), CByte(97))
        RoundedButton1.CornerRadius = 10
        RoundedButton1.FlatStyle = FlatStyle.Popup
        RoundedButton1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RoundedButton1.ForeColor = SystemColors.Control
        RoundedButton1.Location = New Point(711, 18)
        RoundedButton1.Name = "RoundedButton1"
        RoundedButton1.Size = New Size(89, 32)
        RoundedButton1.TabIndex = 39
        RoundedButton1.Text = "Logout"
        RoundedButton1.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Blue
        Panel2.Location = New Point(621, 47)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(65, 3)
        Panel2.TabIndex = 35
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(46), CByte(48), CByte(97))
        Label6.Location = New Point(446, 20)
        Label6.Name = "Label6"
        Label6.Size = New Size(60, 22)
        Label6.TabIndex = 38
        Label6.Text = "Home"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Blue
        Label5.Location = New Point(619, 20)
        Label5.Name = "Label5"
        Label5.Size = New Size(69, 22)
        Label5.TabIndex = 37
        Label5.Text = "History"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(46), CByte(48), CByte(97))
        Label4.Location = New Point(536, 20)
        Label4.Name = "Label4"
        Label4.Size = New Size(61, 22)
        Label4.TabIndex = 36
        Label4.Text = "About"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(46), CByte(48), CByte(97))
        Label2.Location = New Point(69, 28)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 20)
        Label2.TabIndex = 33
        Label2.Text = "Username"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(28, 20)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(37, 33)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 34
        PictureBox1.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(-10, 298)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(209, 176)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 40
        PictureBox3.TabStop = False
        ' 
        ' Riwayat
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(834, 467)
        Controls.Add(RoundedButton1)
        Controls.Add(Panel2)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Controls.Add(Button3)
        Controls.Add(DataGridView1)
        Controls.Add(PictureBox2)
        Controls.Add(Label1)
        Controls.Add(PictureBox3)
        Name = "Riwayat"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Riwayat"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button3 As RoundedButton
    Friend WithEvents RoundedButton1 As RoundedButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
