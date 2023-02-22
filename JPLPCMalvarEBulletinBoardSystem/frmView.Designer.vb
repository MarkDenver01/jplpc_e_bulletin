<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmView
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmView))
        Me.lvRead = New System.Windows.Forms.ListView()
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lvRead
        '
        Me.lvRead.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader14, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader4, Me.ColumnHeader3})
        Me.lvRead.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvRead.FullRowSelect = True
        Me.lvRead.GridLines = True
        Me.lvRead.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvRead.Location = New System.Drawing.Point(14, 99)
        Me.lvRead.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lvRead.Name = "lvRead"
        Me.lvRead.Size = New System.Drawing.Size(988, 378)
        Me.lvRead.TabIndex = 2
        Me.lvRead.UseCompatibleStateImageBehavior = False
        Me.lvRead.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "ID"
        Me.ColumnHeader14.Width = 0
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Mobile Number"
        Me.ColumnHeader1.Width = 132
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Messages"
        Me.ColumnHeader2.Width = 574
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Sender Name"
        Me.ColumnHeader4.Width = 136
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Date Sent"
        Me.ColumnHeader3.Width = 131
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.btnView)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.dtpTo)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.dtpFrom)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(14, 14)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(989, 78)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filter Sent SMS"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Firebrick
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(735, 18)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(244, 49)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Reset"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.Color.Firebrick
        Me.btnView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnView.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.ForeColor = System.Drawing.Color.White
        Me.btnView.Image = CType(resources.GetObject("btnView.Image"), System.Drawing.Image)
        Me.btnView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnView.Location = New System.Drawing.Point(484, 18)
        Me.btnView.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(244, 49)
        Me.btnView.TabIndex = 18
        Me.btnView.Text = "Filter"
        Me.btnView.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(245, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Date To"
        '
        'dtpTo
        '
        Me.dtpTo.Location = New System.Drawing.Point(249, 45)
        Me.dtpTo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(224, 22)
        Me.dtpTo.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(14, 21)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Date From"
        '
        'dtpFrom
        '
        Me.dtpFrom.Location = New System.Drawing.Point(17, 45)
        Me.dtpFrom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(224, 22)
        Me.dtpFrom.TabIndex = 0
        '
        'frmView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1012, 492)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lvRead)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmView"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lvRead As ListView
    Friend WithEvents ColumnHeader14 As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents dtpFrom As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpTo As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnView As Button
End Class
