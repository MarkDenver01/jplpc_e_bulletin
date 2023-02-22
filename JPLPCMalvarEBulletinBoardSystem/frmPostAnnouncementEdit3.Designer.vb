<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPostAnnouncementEdit3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPostAnnouncementEdit3))
        Me.lvRead = New System.Windows.Forms.ListView()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnUpdate3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lvRead
        '
        Me.lvRead.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader1})
        Me.lvRead.FullRowSelect = True
        Me.lvRead.GridLines = True
        Me.lvRead.Location = New System.Drawing.Point(0, 0)
        Me.lvRead.Name = "lvRead"
        Me.lvRead.Size = New System.Drawing.Size(698, 398)
        Me.lvRead.TabIndex = 21
        Me.lvRead.UseCompatibleStateImageBehavior = False
        Me.lvRead.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "ID"
        Me.ColumnHeader4.Width = 1
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Post 1"
        Me.ColumnHeader1.Width = 691
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Firebrick
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(504, 405)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(186, 42)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Delete"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnUpdate3
        '
        Me.btnUpdate3.BackColor = System.Drawing.Color.Firebrick
        Me.btnUpdate3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.btnUpdate3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate3.ForeColor = System.Drawing.Color.White
        Me.btnUpdate3.Image = CType(resources.GetObject("btnUpdate3.Image"), System.Drawing.Image)
        Me.btnUpdate3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdate3.Location = New System.Drawing.Point(312, 406)
        Me.btnUpdate3.Name = "btnUpdate3"
        Me.btnUpdate3.Size = New System.Drawing.Size(186, 42)
        Me.btnUpdate3.TabIndex = 22
        Me.btnUpdate3.Text = "Edit"
        Me.btnUpdate3.UseVisualStyleBackColor = False
        '
        'frmPostAnnouncementEdit3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(698, 455)
        Me.Controls.Add(Me.lvRead)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnUpdate3)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmPostAnnouncementEdit3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPostAnnouncementEdit3"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lvRead As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnUpdate3 As System.Windows.Forms.Button
End Class
