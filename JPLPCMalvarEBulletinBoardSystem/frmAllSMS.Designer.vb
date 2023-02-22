<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAllSMS
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAllSMS))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rboAll = New System.Windows.Forms.RadioButton()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.rboFaculty = New System.Windows.Forms.RadioButton()
        Me.rboStudent = New System.Windows.Forms.RadioButton()
        Me.btnPost = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpWhen = New System.Windows.Forms.DateTimePicker()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtContent = New System.Windows.Forms.TextBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lblConnected = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lvRead = New System.Windows.Forms.ListView()
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ReplyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.sPort = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnFeedbackClear = New System.Windows.Forms.Button()
        Me.txtFeedback = New System.Windows.Forms.TextBox()
        Me.btnPostFeed = New System.Windows.Forms.Button()
        Me.txtSection = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lvMessage = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.rboAll)
        Me.GroupBox3.Controls.Add(Me.btnRefresh)
        Me.GroupBox3.Controls.Add(Me.rboFaculty)
        Me.GroupBox3.Controls.Add(Me.rboStudent)
        Me.GroupBox3.Controls.Add(Me.btnPost)
        Me.GroupBox3.Controls.Add(Me.GroupBox1)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.btnSearch)
        Me.GroupBox3.Controls.Add(Me.lblConnected)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(13, 11)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(267, 550)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Announcement"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(11, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(243, 17)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "-----------------------------------------------"
        '
        'rboAll
        '
        Me.rboAll.AutoSize = True
        Me.rboAll.ForeColor = System.Drawing.Color.White
        Me.rboAll.Location = New System.Drawing.Point(10, 18)
        Me.rboAll.Name = "rboAll"
        Me.rboAll.Size = New System.Drawing.Size(47, 21)
        Me.rboAll.TabIndex = 21
        Me.rboAll.TabStop = True
        Me.rboAll.Text = "ALL"
        Me.rboAll.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.Transparent
        Me.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRefresh.Location = New System.Drawing.Point(9, 105)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(247, 42)
        Me.btnRefresh.TabIndex = 20
        Me.btnRefresh.Text = "Reset"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'rboFaculty
        '
        Me.rboFaculty.AutoSize = True
        Me.rboFaculty.ForeColor = System.Drawing.Color.White
        Me.rboFaculty.Location = New System.Drawing.Point(179, 18)
        Me.rboFaculty.Name = "rboFaculty"
        Me.rboFaculty.Size = New System.Drawing.Size(78, 21)
        Me.rboFaculty.TabIndex = 19
        Me.rboFaculty.TabStop = True
        Me.rboFaculty.Text = "FACULTY"
        Me.rboFaculty.UseVisualStyleBackColor = True
        '
        'rboStudent
        '
        Me.rboStudent.AutoSize = True
        Me.rboStudent.ForeColor = System.Drawing.Color.White
        Me.rboStudent.Location = New System.Drawing.Point(80, 18)
        Me.rboStudent.Name = "rboStudent"
        Me.rboStudent.Size = New System.Drawing.Size(82, 21)
        Me.rboStudent.TabIndex = 18
        Me.rboStudent.TabStop = True
        Me.rboStudent.Text = "STUDENT"
        Me.rboStudent.UseVisualStyleBackColor = True
        '
        'btnPost
        '
        Me.btnPost.BackColor = System.Drawing.Color.Firebrick
        Me.btnPost.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.btnPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPost.ForeColor = System.Drawing.Color.White
        Me.btnPost.Image = CType(resources.GetObject("btnPost.Image"), System.Drawing.Image)
        Me.btnPost.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPost.Location = New System.Drawing.Point(9, 500)
        Me.btnPost.Name = "btnPost"
        Me.btnPost.Size = New System.Drawing.Size(247, 42)
        Me.btnPost.TabIndex = 16
        Me.btnPost.Text = "Post"
        Me.btnPost.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpWhen)
        Me.GroupBox1.Controls.Add(Me.Panel5)
        Me.GroupBox1.Controls.Add(Me.txtAddress)
        Me.GroupBox1.Controls.Add(Me.Panel4)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.txtContent)
        Me.GroupBox1.Controls.Add(Me.txtTitle)
        Me.GroupBox1.Controls.Add(Me.Panel3)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(10, 181)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(247, 313)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Post to Announcement"
        '
        'dtpWhen
        '
        Me.dtpWhen.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpWhen.Location = New System.Drawing.Point(61, 280)
        Me.dtpWhen.Name = "dtpWhen"
        Me.dtpWhen.Size = New System.Drawing.Size(178, 27)
        Me.dtpWhen.TabIndex = 12
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.IndianRed
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Label8)
        Me.Panel5.Location = New System.Drawing.Point(6, 280)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(56, 27)
        Me.Panel5.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(3, 4)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 17)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "When"
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.Color.Firebrick
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddress.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.ForeColor = System.Drawing.Color.White
        Me.txtAddress.Location = New System.Drawing.Point(61, 254)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(178, 27)
        Me.txtAddress.TabIndex = 11
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.IndianRed
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Location = New System.Drawing.Point(6, 254)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(56, 27)
        Me.Panel4.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(3, 4)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Where"
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.Firebrick
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.Color.White
        Me.txtName.Location = New System.Drawing.Point(61, 228)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(178, 27)
        Me.txtName.TabIndex = 9
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.IndianRed
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(6, 228)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(56, 27)
        Me.Panel2.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(5, 4)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Who"
        '
        'txtContent
        '
        Me.txtContent.BackColor = System.Drawing.Color.Firebrick
        Me.txtContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContent.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContent.ForeColor = System.Drawing.Color.White
        Me.txtContent.Location = New System.Drawing.Point(6, 47)
        Me.txtContent.Multiline = True
        Me.txtContent.Name = "txtContent"
        Me.txtContent.Size = New System.Drawing.Size(233, 182)
        Me.txtContent.TabIndex = 8
        '
        'txtTitle
        '
        Me.txtTitle.BackColor = System.Drawing.Color.Firebrick
        Me.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.ForeColor = System.Drawing.Color.White
        Me.txtTitle.Location = New System.Drawing.Point(53, 21)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(186, 27)
        Me.txtTitle.TabIndex = 7
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.IndianRed
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(6, 21)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(48, 27)
        Me.Panel3.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(5, 4)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "What"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(10, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(243, 17)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "-----------------------------------------------"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.Transparent
        Me.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.Location = New System.Drawing.Point(9, 57)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(247, 42)
        Me.btnSearch.TabIndex = 11
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'lblConnected
        '
        Me.lblConnected.AutoSize = True
        Me.lblConnected.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConnected.ForeColor = System.Drawing.Color.Red
        Me.lblConnected.Location = New System.Drawing.Point(72, 22)
        Me.lblConnected.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblConnected.Name = "lblConnected"
        Me.lblConnected.Size = New System.Drawing.Size(0, 17)
        Me.lblConnected.TabIndex = 5
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.lvRead)
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(288, 13)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(778, 548)
        Me.GroupBox4.TabIndex = 18
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "List of Messages"
        '
        'lvRead
        '
        Me.lvRead.BackColor = System.Drawing.Color.Firebrick
        Me.lvRead.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader12, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader14})
        Me.lvRead.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lvRead.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvRead.ForeColor = System.Drawing.Color.White
        Me.lvRead.FullRowSelect = True
        Me.lvRead.GridLines = True
        Me.lvRead.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvRead.Location = New System.Drawing.Point(8, 19)
        Me.lvRead.Name = "lvRead"
        Me.lvRead.Size = New System.Drawing.Size(763, 520)
        Me.lvRead.TabIndex = 0
        Me.lvRead.UseCompatibleStateImageBehavior = False
        Me.lvRead.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "SECTION"
        Me.ColumnHeader12.Width = 0
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "MOBILE NUMBER"
        Me.ColumnHeader8.Width = 157
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "DATE"
        Me.ColumnHeader9.Width = 127
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "MESSAGE"
        Me.ColumnHeader10.Width = 356
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "NAME"
        Me.ColumnHeader11.Width = 259
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "GROUP BY"
        Me.ColumnHeader14.Width = 145
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReplyToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(239, 48)
        '
        'ReplyToolStripMenuItem
        '
        Me.ReplyToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReplyToolStripMenuItem.Name = "ReplyToolStripMenuItem"
        Me.ReplyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.ReplyToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.ReplyToolStripMenuItem.Text = "Post to Announcement"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.DeleteToolStripMenuItem.Text = "Post to Feedback"
        '
        'sPort
        '
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.btnFeedbackClear)
        Me.GroupBox2.Controls.Add(Me.txtFeedback)
        Me.GroupBox2.Controls.Add(Me.btnPostFeed)
        Me.GroupBox2.Controls.Add(Me.txtSection)
        Me.GroupBox2.Controls.Add(Me.Panel1)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(1074, 11)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(267, 307)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Feedback"
        '
        'btnFeedbackClear
        '
        Me.btnFeedbackClear.BackColor = System.Drawing.Color.Firebrick
        Me.btnFeedbackClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.btnFeedbackClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFeedbackClear.ForeColor = System.Drawing.Color.White
        Me.btnFeedbackClear.Image = CType(resources.GetObject("btnFeedbackClear.Image"), System.Drawing.Image)
        Me.btnFeedbackClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFeedbackClear.Location = New System.Drawing.Point(9, 255)
        Me.btnFeedbackClear.Name = "btnFeedbackClear"
        Me.btnFeedbackClear.Size = New System.Drawing.Size(247, 42)
        Me.btnFeedbackClear.TabIndex = 17
        Me.btnFeedbackClear.Text = "Clear"
        Me.btnFeedbackClear.UseVisualStyleBackColor = False
        '
        'txtFeedback
        '
        Me.txtFeedback.BackColor = System.Drawing.Color.Firebrick
        Me.txtFeedback.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFeedback.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFeedback.ForeColor = System.Drawing.Color.White
        Me.txtFeedback.Location = New System.Drawing.Point(9, 44)
        Me.txtFeedback.Multiline = True
        Me.txtFeedback.Name = "txtFeedback"
        Me.txtFeedback.Size = New System.Drawing.Size(247, 156)
        Me.txtFeedback.TabIndex = 8
        '
        'btnPostFeed
        '
        Me.btnPostFeed.BackColor = System.Drawing.Color.Firebrick
        Me.btnPostFeed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.btnPostFeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPostFeed.ForeColor = System.Drawing.Color.White
        Me.btnPostFeed.Image = CType(resources.GetObject("btnPostFeed.Image"), System.Drawing.Image)
        Me.btnPostFeed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPostFeed.Location = New System.Drawing.Point(9, 207)
        Me.btnPostFeed.Name = "btnPostFeed"
        Me.btnPostFeed.Size = New System.Drawing.Size(247, 42)
        Me.btnPostFeed.TabIndex = 16
        Me.btnPostFeed.Text = "Post"
        Me.btnPostFeed.UseVisualStyleBackColor = False
        '
        'txtSection
        '
        Me.txtSection.BackColor = System.Drawing.Color.Firebrick
        Me.txtSection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSection.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSection.ForeColor = System.Drawing.Color.White
        Me.txtSection.Location = New System.Drawing.Point(71, 18)
        Me.txtSection.Name = "txtSection"
        Me.txtSection.Size = New System.Drawing.Size(185, 27)
        Me.txtSection.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.IndianRed
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(9, 18)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(63, 27)
        Me.Panel1.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(5, 2)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Section"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(72, 22)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 17)
        Me.Label7.TabIndex = 5
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.lvMessage)
        Me.GroupBox5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.White
        Me.GroupBox5.Location = New System.Drawing.Point(1074, 341)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Size = New System.Drawing.Size(267, 220)
        Me.GroupBox5.TabIndex = 20
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Notification Feedback Expiration"
        '
        'lvMessage
        '
        Me.lvMessage.BackColor = System.Drawing.Color.Firebrick
        Me.lvMessage.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader3})
        Me.lvMessage.GridLines = True
        Me.lvMessage.Location = New System.Drawing.Point(9, 25)
        Me.lvMessage.Name = "lvMessage"
        Me.lvMessage.Size = New System.Drawing.Size(247, 186)
        Me.lvMessage.TabIndex = 40
        Me.lvMessage.UseCompatibleStateImageBehavior = False
        Me.lvMessage.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "SECTION"
        Me.ColumnHeader1.Width = 81
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "DATE ENTRY"
        Me.ColumnHeader3.Width = 163
        '
        'frmAllSMS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1354, 568)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmAllSMS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SMS"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents lblConnected As Label
    Friend WithEvents rboFaculty As RadioButton
    Friend WithEvents rboStudent As RadioButton
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnPost As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents lvRead As ListView
    Friend WithEvents sPort As IO.Ports.SerialPort
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader14 As ColumnHeader
    Friend WithEvents rboAll As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtContent As TextBox
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnPostFeed As Button
    Friend WithEvents txtSection As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtFeedback As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents lvMessage As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ReplyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnFeedbackClear As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents dtpWhen As DateTimePicker
End Class
