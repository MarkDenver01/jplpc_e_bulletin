<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSMSNotification
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSMSNotification))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboFillSection = New System.Windows.Forms.ComboBox()
        Me.cboBulk = New System.Windows.Forms.ComboBox()
        Me.chkBulk = New System.Windows.Forms.CheckBox()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.txtSmsno = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtMsg = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lvRead = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.dtpWhen = New System.Windows.Forms.DateTimePicker()
        Me.txtWhere = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtContent = New System.Windows.Forms.TextBox()
        Me.btnApprove = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ReplyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToPhonebookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshRecordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.btnView)
        Me.GroupBox3.Controls.Add(Me.btnSend)
        Me.GroupBox3.Controls.Add(Me.GroupBox2)
        Me.GroupBox3.Controls.Add(Me.GroupBox1)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(7, 0)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(267, 487)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(7, 415)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(253, 17)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "-------------------------------------------------"
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.Color.Firebrick
        Me.btnView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnView.ForeColor = System.Drawing.Color.White
        Me.btnView.Image = CType(resources.GetObject("btnView.Image"), System.Drawing.Image)
        Me.btnView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnView.Location = New System.Drawing.Point(10, 438)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(247, 42)
        Me.btnView.TabIndex = 17
        Me.btnView.Text = "VIEW SENT ITEMS"
        Me.btnView.UseVisualStyleBackColor = False
        '
        'btnSend
        '
        Me.btnSend.BackColor = System.Drawing.Color.Firebrick
        Me.btnSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSend.ForeColor = System.Drawing.Color.White
        Me.btnSend.Image = CType(resources.GetObject("btnSend.Image"), System.Drawing.Image)
        Me.btnSend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSend.Location = New System.Drawing.Point(10, 368)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(247, 42)
        Me.btnSend.TabIndex = 16
        Me.btnSend.Text = "SEND"
        Me.btnSend.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboFillSection)
        Me.GroupBox2.Controls.Add(Me.cboBulk)
        Me.GroupBox2.Controls.Add(Me.chkBulk)
        Me.GroupBox2.Controls.Add(Me.btnSelect)
        Me.GroupBox2.Controls.Add(Me.txtSmsno)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(10, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(247, 84)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Enter Contact No."
        '
        'cboFillSection
        '
        Me.cboFillSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFillSection.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFillSection.FormattingEnabled = True
        Me.cboFillSection.Items.AddRange(New Object() {"Faculty", "Student"})
        Me.cboFillSection.Location = New System.Drawing.Point(123, 47)
        Me.cboFillSection.Name = "cboFillSection"
        Me.cboFillSection.Size = New System.Drawing.Size(117, 28)
        Me.cboFillSection.TabIndex = 4
        '
        'cboBulk
        '
        Me.cboBulk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBulk.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBulk.FormattingEnabled = True
        Me.cboBulk.Items.AddRange(New Object() {"Faculty", "Student"})
        Me.cboBulk.Location = New System.Drawing.Point(7, 47)
        Me.cboBulk.Name = "cboBulk"
        Me.cboBulk.Size = New System.Drawing.Size(110, 28)
        Me.cboBulk.TabIndex = 3
        '
        'chkBulk
        '
        Me.chkBulk.AutoSize = True
        Me.chkBulk.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBulk.Location = New System.Drawing.Point(6, 21)
        Me.chkBulk.Name = "chkBulk"
        Me.chkBulk.Size = New System.Drawing.Size(121, 24)
        Me.chkBulk.TabIndex = 2
        Me.chkBulk.Text = "Use Bulk SMS"
        Me.chkBulk.UseVisualStyleBackColor = True
        '
        'btnSelect
        '
        Me.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelect.Image = CType(resources.GetObject("btnSelect.Image"), System.Drawing.Image)
        Me.btnSelect.Location = New System.Drawing.Point(211, 49)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(29, 25)
        Me.btnSelect.TabIndex = 1
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'txtSmsno
        '
        Me.txtSmsno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSmsno.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSmsno.Location = New System.Drawing.Point(7, 48)
        Me.txtSmsno.Name = "txtSmsno"
        Me.txtSmsno.Size = New System.Drawing.Size(202, 27)
        Me.txtSmsno.TabIndex = 0
        Me.txtSmsno.Text = "+639"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtMsg)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(10, 110)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(247, 252)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Message"
        '
        'txtMsg
        '
        Me.txtMsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMsg.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMsg.Location = New System.Drawing.Point(5, 21)
        Me.txtMsg.MaxLength = 800
        Me.txtMsg.Multiline = True
        Me.txtMsg.Name = "txtMsg"
        Me.txtMsg.Size = New System.Drawing.Size(235, 225)
        Me.txtMsg.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.lvRead)
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(282, 0)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(845, 259)
        Me.GroupBox4.TabIndex = 17
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "List of Messages"
        '
        'lvRead
        '
        Me.lvRead.BackColor = System.Drawing.Color.Firebrick
        Me.lvRead.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvRead.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvRead.ForeColor = System.Drawing.Color.White
        Me.lvRead.FullRowSelect = True
        Me.lvRead.GridLines = True
        Me.lvRead.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvRead.Location = New System.Drawing.Point(8, 20)
        Me.lvRead.Name = "lvRead"
        Me.lvRead.Size = New System.Drawing.Size(830, 233)
        Me.lvRead.TabIndex = 0
        Me.lvRead.UseCompatibleStateImageBehavior = False
        Me.lvRead.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "NULL"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 0
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "INDEX"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 0
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "STATUS"
        Me.ColumnHeader1.Width = 101
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "NUMBER"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 150
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "DATE AND TIME"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 141
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "MESSAGE"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 429
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.dtpWhen)
        Me.GroupBox5.Controls.Add(Me.txtWhere)
        Me.GroupBox5.Controls.Add(Me.Panel5)
        Me.GroupBox5.Controls.Add(Me.Panel4)
        Me.GroupBox5.Controls.Add(Me.txtName)
        Me.GroupBox5.Controls.Add(Me.Panel2)
        Me.GroupBox5.Controls.Add(Me.Panel1)
        Me.GroupBox5.Controls.Add(Me.txtTitle)
        Me.GroupBox5.Controls.Add(Me.Panel3)
        Me.GroupBox5.Controls.Add(Me.txtContent)
        Me.GroupBox5.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.White
        Me.GroupBox5.Location = New System.Drawing.Point(282, 260)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Size = New System.Drawing.Size(844, 181)
        Me.GroupBox5.TabIndex = 18
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Edit for Announcement Content"
        '
        'dtpWhen
        '
        Me.dtpWhen.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpWhen.Location = New System.Drawing.Point(627, 149)
        Me.dtpWhen.Name = "dtpWhen"
        Me.dtpWhen.Size = New System.Drawing.Size(200, 27)
        Me.dtpWhen.TabIndex = 6
        '
        'txtWhere
        '
        Me.txtWhere.BackColor = System.Drawing.Color.Firebrick
        Me.txtWhere.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtWhere.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWhere.ForeColor = System.Drawing.Color.White
        Me.txtWhere.Location = New System.Drawing.Point(335, 149)
        Me.txtWhere.Name = "txtWhere"
        Me.txtWhere.Size = New System.Drawing.Size(228, 27)
        Me.txtWhere.TabIndex = 20
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.IndianRed
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Location = New System.Drawing.Point(562, 149)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(66, 27)
        Me.Panel5.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(7, 4)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "WHEN"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.IndianRed
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Location = New System.Drawing.Point(270, 149)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(66, 27)
        Me.Panel4.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(7, 4)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "WHERE"
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.Firebrick
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.Color.White
        Me.txtName.Location = New System.Drawing.Point(64, 149)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(207, 27)
        Me.txtName.TabIndex = 10
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.IndianRed
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Location = New System.Drawing.Point(9, 149)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(56, 27)
        Me.Panel2.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(7, 4)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "WHO"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.IndianRed
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(143, 19)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(684, 27)
        Me.Panel1.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(7, 4)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "BODY CONTENT"
        '
        'txtTitle
        '
        Me.txtTitle.BackColor = System.Drawing.Color.Firebrick
        Me.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.ForeColor = System.Drawing.Color.White
        Me.txtTitle.Location = New System.Drawing.Point(8, 44)
        Me.txtTitle.Multiline = True
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(136, 106)
        Me.txtTitle.TabIndex = 9
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.IndianRed
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Location = New System.Drawing.Point(8, 19)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(136, 27)
        Me.Panel3.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(7, 4)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "WHAT"
        '
        'txtContent
        '
        Me.txtContent.BackColor = System.Drawing.Color.Firebrick
        Me.txtContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContent.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContent.ForeColor = System.Drawing.Color.White
        Me.txtContent.Location = New System.Drawing.Point(143, 44)
        Me.txtContent.Multiline = True
        Me.txtContent.Name = "txtContent"
        Me.txtContent.Size = New System.Drawing.Size(684, 106)
        Me.txtContent.TabIndex = 0
        '
        'btnApprove
        '
        Me.btnApprove.BackColor = System.Drawing.Color.Firebrick
        Me.btnApprove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.btnApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApprove.ForeColor = System.Drawing.Color.White
        Me.btnApprove.Image = CType(resources.GetObject("btnApprove.Image"), System.Drawing.Image)
        Me.btnApprove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnApprove.Location = New System.Drawing.Point(880, 445)
        Me.btnApprove.Name = "btnApprove"
        Me.btnApprove.Size = New System.Drawing.Size(247, 42)
        Me.btnApprove.TabIndex = 17
        Me.btnApprove.Text = "POST"
        Me.btnApprove.UseVisualStyleBackColor = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReplyToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.DeleteAllToolStripMenuItem, Me.SaveToPhonebookToolStripMenuItem, Me.RefreshRecordsToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(217, 114)
        '
        'ReplyToolStripMenuItem
        '
        Me.ReplyToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReplyToolStripMenuItem.Name = "ReplyToolStripMenuItem"
        Me.ReplyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.ReplyToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.ReplyToolStripMenuItem.Text = "Reply"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'DeleteAllToolStripMenuItem
        '
        Me.DeleteAllToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteAllToolStripMenuItem.Name = "DeleteAllToolStripMenuItem"
        Me.DeleteAllToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DeleteAllToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.DeleteAllToolStripMenuItem.Text = "Delete All"
        '
        'SaveToPhonebookToolStripMenuItem
        '
        Me.SaveToPhonebookToolStripMenuItem.Name = "SaveToPhonebookToolStripMenuItem"
        Me.SaveToPhonebookToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToPhonebookToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.SaveToPhonebookToolStripMenuItem.Text = "Save to Phonebook"
        '
        'RefreshRecordsToolStripMenuItem
        '
        Me.RefreshRecordsToolStripMenuItem.Name = "RefreshRecordsToolStripMenuItem"
        Me.RefreshRecordsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.RefreshRecordsToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.RefreshRecordsToolStripMenuItem.Text = "Refresh Records"
        '
        'SerialPort1
        '
        '
        'Timer1
        '
        '
        'frmSMSNotification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1139, 491)
        Me.Controls.Add(Me.btnApprove)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmSMSNotification"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SMS Notification"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSmsno As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtMsg As System.Windows.Forms.TextBox
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lvRead As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtContent As System.Windows.Forms.TextBox
    Friend WithEvents btnApprove As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ReplyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents SaveToPhonebookToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents RefreshRecordsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cboBulk As ComboBox
    Friend WithEvents chkBulk As CheckBox
    Friend WithEvents cboFillSection As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnView As Button
    Friend WithEvents dtpWhen As DateTimePicker
    Friend WithEvents txtWhere As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label2 As Label
End Class
