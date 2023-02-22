<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListPhoto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListPhoto))
        Me.lvRead = New System.Windows.Forms.ListView()
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lvRead
        '
        Me.lvRead.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader14, Me.ColumnHeader1})
        Me.lvRead.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvRead.FullRowSelect = True
        Me.lvRead.GridLines = True
        Me.lvRead.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvRead.Location = New System.Drawing.Point(0, 0)
        Me.lvRead.Name = "lvRead"
        Me.lvRead.Size = New System.Drawing.Size(596, 381)
        Me.lvRead.TabIndex = 1
        Me.lvRead.UseCompatibleStateImageBehavior = False
        Me.lvRead.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "ID"
        Me.ColumnHeader14.Width = 58
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "PHOTO"
        Me.ColumnHeader1.Width = 522
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Transparent
        Me.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(338, 389)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(247, 42)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'frmListPhoto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(596, 440)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.lvRead)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmListPhoto"
        Me.Text = "frmListPhoto"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lvRead As ListView
    Friend WithEvents ColumnHeader14 As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents btnDelete As Button
End Class
