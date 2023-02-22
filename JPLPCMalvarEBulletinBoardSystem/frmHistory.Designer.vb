<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHistory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHistory))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lvInfo = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFilter = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lvInfo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(640, 457)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'lvInfo
        '
        Me.lvInfo.BackColor = System.Drawing.Color.Firebrick
        Me.lvInfo.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lvInfo.ForeColor = System.Drawing.Color.White
        Me.lvInfo.FullRowSelect = True
        Me.lvInfo.GridLines = True
        Me.lvInfo.Location = New System.Drawing.Point(5, 14)
        Me.lvInfo.Name = "lvInfo"
        Me.lvInfo.Size = New System.Drawing.Size(629, 437)
        Me.lvInfo.TabIndex = 2
        Me.lvInfo.UseCompatibleStateImageBehavior = False
        Me.lvInfo.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "ANNOUNCEMENT"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 476
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "DATE ENTRY"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 148
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.btnRefresh)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.dtpFilter)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(640, 64)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.Firebrick
        Me.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRefresh.Location = New System.Drawing.Point(461, 21)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(166, 34)
        Me.btnRefresh.TabIndex = 3
        Me.btnRefresh.Text = "REFRESH"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(15, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Filter Date"
        '
        'dtpFilter
        '
        Me.dtpFilter.Location = New System.Drawing.Point(18, 33)
        Me.dtpFilter.Name = "dtpFilter"
        Me.dtpFilter.Size = New System.Drawing.Size(279, 25)
        Me.dtpFilter.TabIndex = 0
        '
        'frmHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(664, 534)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Announcement History"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lvInfo As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpFilter As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnRefresh As Button
End Class
