<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Hasil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Hasil))
        Label1 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        PrintDocument1 = New Printing.PrintDocument()
        RoundedButton1 = New RoundedButton()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        PictureBox1 = New PictureBox()
        RoundedButton2 = New RoundedButton()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        Panel1 = New Panel()
        Panel2 = New Panel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(76, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(91, 20)
        Label1.TabIndex = 27
        Label1.Text = "Username"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Microsoft Sans Serif", 39.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(73, 10)
        Label3.Name = "Label3"
        Label3.Size = New Size(424, 61)
        Label3.TabIndex = 29
        Label3.Text = "HASIL PROFESI"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold)
        Label2.Location = New Point(198, 19)
        Label2.Name = "Label2"
        Label2.Size = New Size(151, 24)
        Label2.TabIndex = 30
        Label2.Text = "KETERANGAN"
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' RoundedButton1
        ' 
        RoundedButton1.BackColor = Color.FromArgb(CByte(46), CByte(48), CByte(97))
        RoundedButton1.CornerRadius = 10
        RoundedButton1.FlatStyle = FlatStyle.Popup
        RoundedButton1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RoundedButton1.ForeColor = SystemColors.Control
        RoundedButton1.Location = New Point(710, 26)
        RoundedButton1.Name = "RoundedButton1"
        RoundedButton1.Size = New Size(89, 32)
        RoundedButton1.TabIndex = 38
        RoundedButton1.Text = "Logout"
        RoundedButton1.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(46), CByte(48), CByte(97))
        Label6.Location = New Point(445, 28)
        Label6.Name = "Label6"
        Label6.Size = New Size(56, 20)
        Label6.TabIndex = 37
        Label6.Text = "Home"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(46), CByte(48), CByte(97))
        Label5.Location = New Point(618, 28)
        Label5.Name = "Label5"
        Label5.Size = New Size(65, 20)
        Label5.TabIndex = 36
        Label5.Text = "History"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(46), CByte(48), CByte(97))
        Label4.Location = New Point(535, 28)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 20)
        Label4.TabIndex = 35
        Label4.Text = "About"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(28, 25)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(42, 33)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 28
        PictureBox1.TabStop = False
        ' 
        ' RoundedButton2
        ' 
        RoundedButton2.BackColor = Color.SlateBlue
        RoundedButton2.CornerRadius = 10
        RoundedButton2.FlatStyle = FlatStyle.Popup
        RoundedButton2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RoundedButton2.ForeColor = SystemColors.Control
        RoundedButton2.Location = New Point(319, 400)
        RoundedButton2.Name = "RoundedButton2"
        RoundedButton2.Size = New Size(182, 40)
        RoundedButton2.TabIndex = 39
        RoundedButton2.Text = "Cetak Hasil"
        RoundedButton2.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(352, 80)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(129, 116)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 40
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(-10, 301)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(209, 176)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 41
        PictureBox3.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(132, 216)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(570, 79)
        Panel1.TabIndex = 42
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Transparent
        Panel2.Controls.Add(Label2)
        Panel2.Location = New Point(132, 301)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(570, 67)
        Panel2.TabIndex = 43
        ' 
        ' Hasil
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(834, 467)
        Controls.Add(PictureBox2)
        Controls.Add(RoundedButton2)
        Controls.Add(RoundedButton1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Controls.Add(PictureBox3)
        Name = "Hasil"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Hasil"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents RoundedButton1 As RoundedButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RoundedButton2 As RoundedButton
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class
