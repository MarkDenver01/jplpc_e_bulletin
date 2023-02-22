<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPhotoPost
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPhotoPost))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboSize = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnU1 = New System.Windows.Forms.Button()
        Me.Panel20 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAnnouncement = New System.Windows.Forms.TextBox()
        Me.btnPost = New System.Windows.Forms.Button()
        Me.OpenDialog = New System.Windows.Forms.OpenFileDialog()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.btnU2 = New System.Windows.Forms.Button()
        Me.btnU3 = New System.Windows.Forms.Button()
        Me.btnU4 = New System.Windows.Forms.Button()
        Me.btnU5 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog3 = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog4 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel20.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnU5)
        Me.GroupBox1.Controls.Add(Me.btnU4)
        Me.GroupBox1.Controls.Add(Me.btnU3)
        Me.GroupBox1.Controls.Add(Me.btnU2)
        Me.GroupBox1.Controls.Add(Me.PictureBox6)
        Me.GroupBox1.Controls.Add(Me.PictureBox5)
        Me.GroupBox1.Controls.Add(Me.PictureBox4)
        Me.GroupBox1.Controls.Add(Me.PictureBox3)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.cboSize)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.btnU1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(606, 247)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Upload Photo"
        '
        'cboSize
        '
        Me.cboSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSize.FormattingEnabled = True
        Me.cboSize.Items.AddRange(New Object() {"1 times", "2 times", "3 times", "4 times", "5 times"})
        Me.cboSize.Location = New System.Drawing.Point(133, 63)
        Me.cboSize.Name = "cboSize"
        Me.cboSize.Size = New System.Drawing.Size(259, 28)
        Me.cboSize.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Select Pieces :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(28, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(364, 40)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(276, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Note : Maximum of 5 can be uploaded."
        '
        'btnU1
        '
        Me.btnU1.BackColor = System.Drawing.Color.Firebrick
        Me.btnU1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.btnU1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnU1.ForeColor = System.Drawing.Color.White
        Me.btnU1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnU1.Location = New System.Drawing.Point(28, 195)
        Me.btnU1.Name = "btnU1"
        Me.btnU1.Size = New System.Drawing.Size(99, 33)
        Me.btnU1.TabIndex = 18
        Me.btnU1.Text = "UPLOAD"
        Me.btnU1.UseVisualStyleBackColor = False
        '
        'Panel20
        '
        Me.Panel20.BackColor = System.Drawing.Color.Firebrick
        Me.Panel20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel20.Controls.Add(Me.Label2)
        Me.Panel20.Location = New System.Drawing.Point(638, 23)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(317, 33)
        Me.Panel20.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(220, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ADD ANNOUNCEMENT"
        '
        'txtAnnouncement
        '
        Me.txtAnnouncement.BackColor = System.Drawing.Color.White
        Me.txtAnnouncement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAnnouncement.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnnouncement.ForeColor = System.Drawing.Color.Black
        Me.txtAnnouncement.Location = New System.Drawing.Point(638, 55)
        Me.txtAnnouncement.Multiline = True
        Me.txtAnnouncement.Name = "txtAnnouncement"
        Me.txtAnnouncement.Size = New System.Drawing.Size(317, 147)
        Me.txtAnnouncement.TabIndex = 49
        '
        'btnPost
        '
        Me.btnPost.BackColor = System.Drawing.Color.Firebrick
        Me.btnPost.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.btnPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPost.ForeColor = System.Drawing.Color.White
        Me.btnPost.Image = CType(resources.GetObject("btnPost.Image"), System.Drawing.Image)
        Me.btnPost.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPost.Location = New System.Drawing.Point(638, 219)
        Me.btnPost.Name = "btnPost"
        Me.btnPost.Size = New System.Drawing.Size(317, 41)
        Me.btnPost.TabIndex = 20
        Me.btnPost.Text = "POST"
        Me.btnPost.UseVisualStyleBackColor = False
        '
        'OpenDialog
        '
        Me.OpenDialog.FileName = "OpenFileDialog1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(771, -73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 20)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Select Pieces :"
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(28, 97)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(99, 92)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 21
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Location = New System.Drawing.Point(133, 97)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(99, 92)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 22
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox4.Location = New System.Drawing.Point(238, 97)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(99, 92)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 23
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox5.Location = New System.Drawing.Point(343, 97)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(99, 92)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 24
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox6.Location = New System.Drawing.Point(448, 97)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(99, 92)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 25
        Me.PictureBox6.TabStop = False
        '
        'btnU2
        '
        Me.btnU2.BackColor = System.Drawing.Color.Firebrick
        Me.btnU2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.btnU2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnU2.ForeColor = System.Drawing.Color.White
        Me.btnU2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnU2.Location = New System.Drawing.Point(133, 195)
        Me.btnU2.Name = "btnU2"
        Me.btnU2.Size = New System.Drawing.Size(99, 33)
        Me.btnU2.TabIndex = 26
        Me.btnU2.Text = "UPLOAD"
        Me.btnU2.UseVisualStyleBackColor = False
        '
        'btnU3
        '
        Me.btnU3.BackColor = System.Drawing.Color.Firebrick
        Me.btnU3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.btnU3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnU3.ForeColor = System.Drawing.Color.White
        Me.btnU3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnU3.Location = New System.Drawing.Point(238, 195)
        Me.btnU3.Name = "btnU3"
        Me.btnU3.Size = New System.Drawing.Size(99, 33)
        Me.btnU3.TabIndex = 27
        Me.btnU3.Text = "UPLOAD"
        Me.btnU3.UseVisualStyleBackColor = False
        '
        'btnU4
        '
        Me.btnU4.BackColor = System.Drawing.Color.Firebrick
        Me.btnU4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.btnU4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnU4.ForeColor = System.Drawing.Color.White
        Me.btnU4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnU4.Location = New System.Drawing.Point(343, 195)
        Me.btnU4.Name = "btnU4"
        Me.btnU4.Size = New System.Drawing.Size(99, 33)
        Me.btnU4.TabIndex = 28
        Me.btnU4.Text = "UPLOAD"
        Me.btnU4.UseVisualStyleBackColor = False
        '
        'btnU5
        '
        Me.btnU5.BackColor = System.Drawing.Color.Firebrick
        Me.btnU5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.btnU5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnU5.ForeColor = System.Drawing.Color.White
        Me.btnU5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnU5.Location = New System.Drawing.Point(448, 195)
        Me.btnU5.Name = "btnU5"
        Me.btnU5.Size = New System.Drawing.Size(99, 33)
        Me.btnU5.TabIndex = 29
        Me.btnU5.Text = "UPLOAD"
        Me.btnU5.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog1"
        '
        'OpenFileDialog3
        '
        Me.OpenFileDialog3.FileName = "OpenFileDialog1"
        '
        'OpenFileDialog4
        '
        Me.OpenFileDialog4.FileName = "OpenFileDialog1"
        '
        'frmPhotoPost
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(967, 275)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnPost)
        Me.Controls.Add(Me.txtAnnouncement)
        Me.Controls.Add(Me.Panel20)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmPhotoPost"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPhotoPost"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel20.ResumeLayout(False)
        Me.Panel20.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnU1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel20 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboSize As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents txtAnnouncement As System.Windows.Forms.TextBox
    Friend WithEvents btnPost As System.Windows.Forms.Button
    Friend WithEvents OpenDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents btnU5 As System.Windows.Forms.Button
    Friend WithEvents btnU4 As System.Windows.Forms.Button
    Friend WithEvents btnU3 As System.Windows.Forms.Button
    Friend WithEvents btnU2 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents OpenFileDialog2 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents OpenFileDialog3 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents OpenFileDialog4 As System.Windows.Forms.OpenFileDialog
End Class
