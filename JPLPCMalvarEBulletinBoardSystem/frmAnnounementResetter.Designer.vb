<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnnounementResetter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAnnounementResetter))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rboAReset = New System.Windows.Forms.RadioButton()
        Me.rboA1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rboPhotoReset = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rboResetAll = New System.Windows.Forms.RadioButton()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rboFeedback = New System.Windows.Forms.RadioButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.rboCourse = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rboAReset)
        Me.GroupBox1.Controls.Add(Me.rboA1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(496, 98)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ANNOUNCEMENT AND EVENT"
        '
        'rboAReset
        '
        Me.rboAReset.AutoSize = True
        Me.rboAReset.Location = New System.Drawing.Point(287, 29)
        Me.rboAReset.Name = "rboAReset"
        Me.rboAReset.Size = New System.Drawing.Size(137, 21)
        Me.rboAReset.TabIndex = 2
        Me.rboAReset.TabStop = True
        Me.rboAReset.Text = "RESET ALL EVENTS"
        Me.rboAReset.UseVisualStyleBackColor = True
        '
        'rboA1
        '
        Me.rboA1.AutoSize = True
        Me.rboA1.Location = New System.Drawing.Point(36, 29)
        Me.rboA1.Name = "rboA1"
        Me.rboA1.Size = New System.Drawing.Size(200, 21)
        Me.rboA1.TabIndex = 0
        Me.rboA1.TabStop = True
        Me.rboA1.Text = "RESET ALL ANNOUNCEMENT"
        Me.rboA1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.rboPhotoReset)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(12, 116)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(235, 62)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "EVENT PHOTO"
        '
        'rboPhotoReset
        '
        Me.rboPhotoReset.AutoSize = True
        Me.rboPhotoReset.Location = New System.Drawing.Point(36, 26)
        Me.rboPhotoReset.Name = "rboPhotoReset"
        Me.rboPhotoReset.Size = New System.Drawing.Size(177, 21)
        Me.rboPhotoReset.TabIndex = 0
        Me.rboPhotoReset.TabStop = True
        Me.rboPhotoReset.Text = "RESET ALL EVENT PHOTO"
        Me.rboPhotoReset.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.rboResetAll)
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(263, 116)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(245, 62)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "ANNOUNCEMENT FORM"
        '
        'rboResetAll
        '
        Me.rboResetAll.AutoSize = True
        Me.rboResetAll.Location = New System.Drawing.Point(36, 29)
        Me.rboResetAll.Name = "rboResetAll"
        Me.rboResetAll.Size = New System.Drawing.Size(87, 21)
        Me.rboResetAll.TabIndex = 0
        Me.rboResetAll.TabStop = True
        Me.rboResetAll.Text = "RESET ALL"
        Me.rboResetAll.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.Firebrick
        Me.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.Image = CType(resources.GetObject("btnReset.Image"), System.Drawing.Image)
        Me.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReset.Location = New System.Drawing.Point(22, 256)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(235, 47)
        Me.btnReset.TabIndex = 7
        Me.btnReset.Text = "RESET"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Firebrick
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(263, 256)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(235, 47)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.rboFeedback)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(12, 188)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(235, 62)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "FEEDBACK"
        '
        'rboFeedback
        '
        Me.rboFeedback.AutoSize = True
        Me.rboFeedback.Location = New System.Drawing.Point(36, 26)
        Me.rboFeedback.Name = "rboFeedback"
        Me.rboFeedback.Size = New System.Drawing.Size(154, 21)
        Me.rboFeedback.TabIndex = 0
        Me.rboFeedback.TabStop = True
        Me.rboFeedback.Text = "RESET ALL FEEDBACK"
        Me.rboFeedback.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.rboCourse)
        Me.GroupBox5.ForeColor = System.Drawing.Color.White
        Me.GroupBox5.Location = New System.Drawing.Point(263, 188)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(245, 62)
        Me.GroupBox5.TabIndex = 7
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "COURSE NOTIFICATION"
        '
        'rboCourse
        '
        Me.rboCourse.AutoSize = True
        Me.rboCourse.Location = New System.Drawing.Point(36, 26)
        Me.rboCourse.Name = "rboCourse"
        Me.rboCourse.Size = New System.Drawing.Size(181, 21)
        Me.rboCourse.TabIndex = 0
        Me.rboCourse.TabStop = True
        Me.rboCourse.Text = "RESET ALL COURSE NOTIF"
        Me.rboCourse.UseVisualStyleBackColor = True
        '
        'frmAnnounementResetter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(521, 315)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmAnnounementResetter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Announcement Resetter Configuration"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rboAReset As System.Windows.Forms.RadioButton
    Friend WithEvents rboA1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rboPhotoReset As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents rboResetAll As System.Windows.Forms.RadioButton
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rboFeedback As RadioButton
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents rboCourse As RadioButton
End Class
