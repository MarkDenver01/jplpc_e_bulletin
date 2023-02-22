<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSection))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSection = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSectionID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtSection)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtSectionID)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(6, -4)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(249, 138)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'txtSection
        '
        Me.txtSection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSection.Location = New System.Drawing.Point(31, 94)
        Me.txtSection.Name = "txtSection"
        Me.txtSection.Size = New System.Drawing.Size(191, 25)
        Me.txtSection.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Section"
        '
        'txtSectionID
        '
        Me.txtSectionID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSectionID.Location = New System.Drawing.Point(31, 46)
        Me.txtSectionID.Name = "txtSectionID"
        Me.txtSectionID.Size = New System.Drawing.Size(191, 25)
        Me.txtSectionID.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Section ID"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Firebrick
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(6, 178)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(249, 34)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Firebrick
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(6, 141)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(249, 34)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'frmSection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(263, 218)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmSection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Section"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSection As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSectionID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class
