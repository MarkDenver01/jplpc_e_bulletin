<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListBirthday
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListBirthday))
        Me.lvRead = New System.Windows.Forms.ListView()
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox8.SuspendLayout()
        Me.SuspendLayout()
        '
        'lvRead
        '
        Me.lvRead.BackColor = System.Drawing.Color.Firebrick
        Me.lvRead.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader12, Me.ColumnHeader8, Me.ColumnHeader9})
        Me.lvRead.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvRead.ForeColor = System.Drawing.Color.White
        Me.lvRead.FullRowSelect = True
        Me.lvRead.GridLines = True
        Me.lvRead.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvRead.Location = New System.Drawing.Point(3, 87)
        Me.lvRead.Name = "lvRead"
        Me.lvRead.Size = New System.Drawing.Size(535, 376)
        Me.lvRead.TabIndex = 1
        Me.lvRead.UseCompatibleStateImageBehavior = False
        Me.lvRead.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "ID"
        Me.ColumnHeader12.Width = 0
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "NAME"
        Me.ColumnHeader8.Width = 321
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "DATE OF BIRTH"
        Me.ColumnHeader9.Width = 205
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.Firebrick
        Me.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEdit.Location = New System.Drawing.Point(60, 470)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(203, 42)
        Me.btnEdit.TabIndex = 4
        Me.btnEdit.Text = "EDIT"
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
        Me.btnDelete.Location = New System.Drawing.Point(269, 470)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(203, 42)
        Me.btnDelete.TabIndex = 5
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox8.Controls.Add(Me.txtName)
        Me.GroupBox8.Controls.Add(Me.Label7)
        Me.GroupBox8.ForeColor = System.Drawing.Color.White
        Me.GroupBox8.Location = New System.Drawing.Point(3, 1)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(535, 80)
        Me.GroupBox8.TabIndex = 22
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Search Engine Query"
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Location = New System.Drawing.Point(16, 46)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(275, 27)
        Me.txtName.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(13, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 15)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Name"
        '
        'frmListBirthday
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(541, 522)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.lvRead)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmListBirthday"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmListBirthday"
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lvRead As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
End Class
