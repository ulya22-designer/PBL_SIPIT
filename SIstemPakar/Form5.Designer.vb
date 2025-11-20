<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        Button8 = New Button()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.SlateBlue
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Montagu Slab 144pt", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(80, 337)
        Button1.Name = "Button1"
        Button1.Size = New Size(121, 47)
        Button1.TabIndex = 14
        Button1.Text = "YA"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.Desktop
        Button2.Font = New Font("Montagu Slab 144pt", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = SystemColors.ButtonHighlight
        Button2.Location = New Point(471, 337)
        Button2.Name = "Button2"
        Button2.Size = New Size(155, 47)
        Button2.TabIndex = 15
        Button2.Text = "TIDAK"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Montagu Slab 144pt", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(583, 224)
        Button3.Name = "Button3"
        Button3.Size = New Size(43, 39)
        Button3.TabIndex = 18
        Button3.Text = ">"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Montagu Slab 144pt", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.Location = New Point(80, 109)
        Button4.Name = "Button4"
        Button4.Size = New Size(48, 39)
        Button4.TabIndex = 19
        Button4.Text = "01"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("Montagu Slab 144pt", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button5.Location = New Point(192, 109)
        Button5.Name = "Button5"
        Button5.Size = New Size(52, 39)
        Button5.TabIndex = 20
        Button5.Text = "02"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Font = New Font("Montagu Slab 144pt", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button6.Location = New Point(316, 109)
        Button6.Name = "Button6"
        Button6.Size = New Size(50, 39)
        Button6.TabIndex = 21
        Button6.Text = "03"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Font = New Font("Montagu Slab 144pt", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button7.Location = New Point(575, 109)
        Button7.Name = "Button7"
        Button7.Size = New Size(51, 39)
        Button7.TabIndex = 23
        Button7.Text = "05"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button8
        ' 
        Button8.Font = New Font("Montagu Slab 144pt", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button8.Location = New Point(441, 109)
        Button8.Name = "Button8"
        Button8.Size = New Size(59, 39)
        Button8.TabIndex = 22
        Button8.Text = "04"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Montagu Slab 144pt Medium", 14.25F, FontStyle.Bold)
        Label2.Location = New Point(272, 224)
        Label2.Name = "Label2"
        Label2.Size = New Size(133, 28)
        Label2.TabIndex = 24
        Label2.Text = "Pertanyaan?"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(19, 18)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(41, 29)
        PictureBox1.TabIndex = 26
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Montagu Slab 144pt Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(66, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(90, 23)
        Label1.TabIndex = 25
        Label1.Text = "Username"
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(720, 450)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(Button7)
        Controls.Add(Button8)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Form5"
        Text = "Questions"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
End Class
