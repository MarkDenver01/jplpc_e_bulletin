<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnnouncementCenter
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAnnouncementCenter))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.txtRunningMessage = New System.Windows.Forms.Label()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtA1 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.txtPosition = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Firebrick
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(-9, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1373, 48)
        Me.Panel1.TabIndex = 65
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(533, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(292, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ANNOUNCEMENTS/EVENTS"
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.Gray
        Me.Panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel13.Controls.Add(Me.txtRunningMessage)
        Me.Panel13.Controls.Add(Me.Panel14)
        Me.Panel13.Location = New System.Drawing.Point(259, 645)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(1105, 53)
        Me.Panel13.TabIndex = 68
        '
        'txtRunningMessage
        '
        Me.txtRunningMessage.AutoSize = True
        Me.txtRunningMessage.BackColor = System.Drawing.Color.Transparent
        Me.txtRunningMessage.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRunningMessage.ForeColor = System.Drawing.Color.White
        Me.txtRunningMessage.Location = New System.Drawing.Point(3, 3)
        Me.txtRunningMessage.Name = "txtRunningMessage"
        Me.txtRunningMessage.Size = New System.Drawing.Size(197, 30)
        Me.txtRunningMessage.TabIndex = 29
        Me.txtRunningMessage.Text = "SPECIAL MESSAGE"
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.LightCoral
        Me.Panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel14.Controls.Add(Me.Label20)
        Me.Panel14.Location = New System.Drawing.Point(-546, -1)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(270, 50)
        Me.Panel14.TabIndex = 28
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(7, 7)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(246, 32)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "RUNNING MESSAGE"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Brown
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.Panel5)
        Me.Panel8.Controls.Add(Me.txtName)
        Me.Panel8.Controls.Add(Me.Label4)
        Me.Panel8.Controls.Add(Me.lblDate)
        Me.Panel8.ForeColor = System.Drawing.Color.White
        Me.Panel8.Location = New System.Drawing.Point(-9, 697)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1373, 46)
        Me.Panel8.TabIndex = 66
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Maroon
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Panel9)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Location = New System.Drawing.Point(3, -1)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(312, 51)
        Me.Panel5.TabIndex = 47
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.LightCoral
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Controls.Add(Me.Label2)
        Me.Panel9.Location = New System.Drawing.Point(-546, -1)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(270, 50)
        Me.Panel9.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(7, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(246, 32)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "RUNNING MESSAGE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(24, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(271, 32)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "BIRTHDAY GREETINGS"
        '
        'txtName
        '
        Me.txtName.AutoSize = True
        Me.txtName.BackColor = System.Drawing.Color.Transparent
        Me.txtName.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.txtName.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.Color.Yellow
        Me.txtName.Location = New System.Drawing.Point(551, 6)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(76, 30)
        Me.txtName.TabIndex = 48
        Me.txtName.Text = "NAME"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(320, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(231, 30)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "HAPPY BIRTHDAY TO "
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Location = New System.Drawing.Point(566, -3)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(0, 30)
        Me.lblDate.TabIndex = 1
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Maroon
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Location = New System.Drawing.Point(0, 645)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(270, 53)
        Me.Panel6.TabIndex = 67
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.LightCoral
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.Label7)
        Me.Panel7.Location = New System.Drawing.Point(-546, -1)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(270, 50)
        Me.Panel7.TabIndex = 28
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(7, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(246, 32)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "RUNNING MESSAGE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(24, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(224, 32)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "SPECIAL MESSAGE"
        '
        'Timer1
        '
        '
        'txtA1
        '
        Me.txtA1.AutoSize = True
        Me.txtA1.BackColor = System.Drawing.Color.Transparent
        Me.txtA1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtA1.Location = New System.Drawing.Point(465, 65)
        Me.txtA1.Name = "txtA1"
        Me.txtA1.Size = New System.Drawing.Size(0, 32)
        Me.txtA1.TabIndex = 69
        Me.txtA1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer2
        '
        '
        'Timer3
        '
        '
        'txtPosition
        '
        Me.txtPosition.AutoSize = True
        Me.txtPosition.BackColor = System.Drawing.Color.Transparent
        Me.txtPosition.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPosition.Location = New System.Drawing.Point(-1000, -1000)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(56, 32)
        Me.txtPosition.TabIndex = 70
        Me.txtPosition.Text = "pos"
        Me.txtPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmAnnouncementCenter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1354, 733)
        Me.Controls.Add(Me.txtPosition)
        Me.Controls.Add(Me.txtA1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel13)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel6)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmAnnouncementCenter"
        Me.Text = "frm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents txtRunningMessage As System.Windows.Forms.Label
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents txtA1 As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPosition As System.Windows.Forms.Label
End Class
