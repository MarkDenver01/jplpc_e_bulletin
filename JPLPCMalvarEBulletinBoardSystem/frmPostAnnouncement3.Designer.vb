<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPostAnnouncement3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPostAnnouncement3))
        Me.txtA1 = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnPost = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtA1
        '
        Me.txtA1.BackColor = System.Drawing.Color.White
        Me.txtA1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtA1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtA1.ForeColor = System.Drawing.Color.Black
        Me.txtA1.Location = New System.Drawing.Point(0, 25)
        Me.txtA1.Multiline = True
        Me.txtA1.Name = "txtA1"
        Me.txtA1.Size = New System.Drawing.Size(504, 179)
        Me.txtA1.TabIndex = 58
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Firebrick
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(233, 26)
        Me.Panel4.TabIndex = 57
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(-1, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 25)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Announcement"
        '
        'btnPost
        '
        Me.btnPost.BackColor = System.Drawing.Color.Firebrick
        Me.btnPost.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.btnPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPost.ForeColor = System.Drawing.Color.White
        Me.btnPost.Image = CType(resources.GetObject("btnPost.Image"), System.Drawing.Image)
        Me.btnPost.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPost.Location = New System.Drawing.Point(51, 282)
        Me.btnPost.Name = "btnPost"
        Me.btnPost.Size = New System.Drawing.Size(201, 46)
        Me.btnPost.TabIndex = 62
        Me.btnPost.Text = "Post"
        Me.btnPost.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Firebrick
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(258, 282)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(201, 46)
        Me.btnCancel.TabIndex = 61
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(509, -3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 25)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Announcement"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(8, 210)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 20)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Select Position"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Top-Center", "Bottom-Center"})
        Me.ComboBox1.Location = New System.Drawing.Point(12, 233)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(240, 28)
        Me.ComboBox1.TabIndex = 64
        '
        'frmPostAnnouncement3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(504, 336)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPost)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.txtA1)
        Me.Controls.Add(Me.Panel4)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmPostAnnouncement3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPostAnnouncement3"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents txtA1 As System.Windows.Forms.TextBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnPost As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
