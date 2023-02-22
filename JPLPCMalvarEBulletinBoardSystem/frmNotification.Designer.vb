<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNotification
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNotification))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboDepartment = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cboDepartment)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtMessage)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(13, 2)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(401, 366)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INPUT MESSAGE"
        '
        'txtMessage
        '
        Me.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMessage.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMessage.Location = New System.Drawing.Point(16, 116)
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(371, 230)
        Me.txtMessage.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select Department"
        '
        'cboDepartment
        '
        Me.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDepartment.FormattingEnabled = True
        Me.cboDepartment.Items.AddRange(New Object() {"COMPUTER SCIENCE/INFORMATION TECHNOLOGY", "ENGINEERING"})
        Me.cboDepartment.Location = New System.Drawing.Point(16, 59)
        Me.cboDepartment.Name = "cboDepartment"
        Me.cboDepartment.Size = New System.Drawing.Size(371, 28)
        Me.cboDepartment.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Message"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Firebrick
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(39, 375)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(170, 47)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "POST"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Firebrick
        Me.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Image = CType(resources.GetObject("btnClear.Image"), System.Drawing.Image)
        Me.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClear.Location = New System.Drawing.Point(215, 375)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(170, 47)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'frmNotification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(427, 429)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmNotification"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmNotification"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtMessage As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cboDepartment As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClear As Button
End Class
