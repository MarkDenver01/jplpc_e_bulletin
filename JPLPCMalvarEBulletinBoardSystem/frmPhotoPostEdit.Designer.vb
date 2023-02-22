<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPhotoPostEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPhotoPostEdit))
        Me.lvRead = New System.Windows.Forms.ListView()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lvRead
        '
        Me.lvRead.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lvRead.FullRowSelect = True
        Me.lvRead.GridLines = True
        Me.lvRead.Location = New System.Drawing.Point(0, 0)
        Me.lvRead.Name = "lvRead"
        Me.lvRead.Size = New System.Drawing.Size(699, 428)
        Me.lvRead.TabIndex = 0
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
        Me.ColumnHeader1.Text = "Photos"
        Me.ColumnHeader1.Width = 275
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Post Entry"
        Me.ColumnHeader2.Width = 291
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Qty"
        Me.ColumnHeader3.Width = 120
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.Firebrick
        Me.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEdit.Location = New System.Drawing.Point(314, 434)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(186, 42)
        Me.btnEdit.TabIndex = 17
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Firebrick
        Me.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(506, 433)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(186, 42)
        Me.btnDelete.TabIndex = 18
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'frmPhotoPostEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(699, 483)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.lvRead)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmPhotoPostEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPhotoPostEdit"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lvRead As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
End Class
