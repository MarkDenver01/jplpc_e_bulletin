﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NOTIFICATIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SMSNotificationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.POSTRECIEVINGSMSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MASTERENTRYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PhonebookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SCHEDULEOFEXAMINATIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EBULLETINCATEGORYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ANNOUNCEMENTSEVENTSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SCHEDULEOFEXAMINATIONToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RESETTERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RUNNINGMESSAGEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddRoomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddSectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ADDSUBJECTSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ADDPHOTOEVENTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ADDEVENTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DELETEPHOTOEVENTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SAPIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.COURSENOTICEBOARDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.THEMESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JANAUARYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MARCHToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministratorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblNotify = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ANNOUNCEMENTCONFIGURATIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Maroon
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NOTIFICATIONToolStripMenuItem, Me.MASTERENTRYToolStripMenuItem, Me.THEMESToolStripMenuItem, Me.ToolStripMenuItem3, Me.EXITToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1020, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NOTIFICATIONToolStripMenuItem
        '
        Me.NOTIFICATIONToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SMSNotificationToolStripMenuItem, Me.POSTRECIEVINGSMSToolStripMenuItem})
        Me.NOTIFICATIONToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.NOTIFICATIONToolStripMenuItem.Image = CType(resources.GetObject("NOTIFICATIONToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NOTIFICATIONToolStripMenuItem.Name = "NOTIFICATIONToolStripMenuItem"
        Me.NOTIFICATIONToolStripMenuItem.Size = New System.Drawing.Size(116, 20)
        Me.NOTIFICATIONToolStripMenuItem.Text = "NOTIFICATION"
        '
        'SMSNotificationToolStripMenuItem
        '
        Me.SMSNotificationToolStripMenuItem.Image = CType(resources.GetObject("SMSNotificationToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SMSNotificationToolStripMenuItem.Name = "SMSNotificationToolStripMenuItem"
        Me.SMSNotificationToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.SMSNotificationToolStripMenuItem.Text = "SMS NOTIFICATION"
        '
        'POSTRECIEVINGSMSToolStripMenuItem
        '
        Me.POSTRECIEVINGSMSToolStripMenuItem.Image = CType(resources.GetObject("POSTRECIEVINGSMSToolStripMenuItem.Image"), System.Drawing.Image)
        Me.POSTRECIEVINGSMSToolStripMenuItem.Name = "POSTRECIEVINGSMSToolStripMenuItem"
        Me.POSTRECIEVINGSMSToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.POSTRECIEVINGSMSToolStripMenuItem.Text = "POST/RECIEVING SMS"
        '
        'MASTERENTRYToolStripMenuItem
        '
        Me.MASTERENTRYToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ANNOUNCEMENTCONFIGURATIONToolStripMenuItem, Me.PhonebookToolStripMenuItem, Me.SCHEDULEOFEXAMINATIONToolStripMenuItem, Me.ViewHistoryToolStripMenuItem, Me.EBULLETINCATEGORYToolStripMenuItem, Me.RUNNINGMESSAGEToolStripMenuItem, Me.AddRoomToolStripMenuItem, Me.AddSectionToolStripMenuItem, Me.ADDSUBJECTSToolStripMenuItem, Me.ADDPHOTOEVENTToolStripMenuItem, Me.ADDEVENTToolStripMenuItem, Me.DELETEPHOTOEVENTToolStripMenuItem, Me.SAPIToolStripMenuItem, Me.COURSENOTICEBOARDToolStripMenuItem})
        Me.MASTERENTRYToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.MASTERENTRYToolStripMenuItem.Image = CType(resources.GetObject("MASTERENTRYToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MASTERENTRYToolStripMenuItem.Name = "MASTERENTRYToolStripMenuItem"
        Me.MASTERENTRYToolStripMenuItem.Size = New System.Drawing.Size(118, 20)
        Me.MASTERENTRYToolStripMenuItem.Text = "MANAGEMENT"
        '
        'PhonebookToolStripMenuItem
        '
        Me.PhonebookToolStripMenuItem.Image = CType(resources.GetObject("PhonebookToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PhonebookToolStripMenuItem.Name = "PhonebookToolStripMenuItem"
        Me.PhonebookToolStripMenuItem.Size = New System.Drawing.Size(269, 22)
        Me.PhonebookToolStripMenuItem.Text = "PHONEBOOK"
        '
        'SCHEDULEOFEXAMINATIONToolStripMenuItem
        '
        Me.SCHEDULEOFEXAMINATIONToolStripMenuItem.Image = CType(resources.GetObject("SCHEDULEOFEXAMINATIONToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SCHEDULEOFEXAMINATIONToolStripMenuItem.Name = "SCHEDULEOFEXAMINATIONToolStripMenuItem"
        Me.SCHEDULEOFEXAMINATIONToolStripMenuItem.Size = New System.Drawing.Size(269, 22)
        Me.SCHEDULEOFEXAMINATIONToolStripMenuItem.Text = "SCHEDULE OF EXAMINATION"
        '
        'ViewHistoryToolStripMenuItem
        '
        Me.ViewHistoryToolStripMenuItem.Image = CType(resources.GetObject("ViewHistoryToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ViewHistoryToolStripMenuItem.Name = "ViewHistoryToolStripMenuItem"
        Me.ViewHistoryToolStripMenuItem.Size = New System.Drawing.Size(269, 22)
        Me.ViewHistoryToolStripMenuItem.Text = "VIEW HISTORY"
        '
        'EBULLETINCATEGORYToolStripMenuItem
        '
        Me.EBULLETINCATEGORYToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ANNOUNCEMENTSEVENTSToolStripMenuItem, Me.SCHEDULEOFEXAMINATIONToolStripMenuItem1, Me.RESETTERToolStripMenuItem})
        Me.EBULLETINCATEGORYToolStripMenuItem.Image = CType(resources.GetObject("EBULLETINCATEGORYToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EBULLETINCATEGORYToolStripMenuItem.Name = "EBULLETINCATEGORYToolStripMenuItem"
        Me.EBULLETINCATEGORYToolStripMenuItem.Size = New System.Drawing.Size(269, 22)
        Me.EBULLETINCATEGORYToolStripMenuItem.Text = "E-BULLETIN CATEGORY"
        '
        'ANNOUNCEMENTSEVENTSToolStripMenuItem
        '
        Me.ANNOUNCEMENTSEVENTSToolStripMenuItem.Image = CType(resources.GetObject("ANNOUNCEMENTSEVENTSToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ANNOUNCEMENTSEVENTSToolStripMenuItem.Name = "ANNOUNCEMENTSEVENTSToolStripMenuItem"
        Me.ANNOUNCEMENTSEVENTSToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.ANNOUNCEMENTSEVENTSToolStripMenuItem.Text = "ANNOUNCEMENTS/EVENTS"
        '
        'SCHEDULEOFEXAMINATIONToolStripMenuItem1
        '
        Me.SCHEDULEOFEXAMINATIONToolStripMenuItem1.Image = CType(resources.GetObject("SCHEDULEOFEXAMINATIONToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.SCHEDULEOFEXAMINATIONToolStripMenuItem1.Name = "SCHEDULEOFEXAMINATIONToolStripMenuItem1"
        Me.SCHEDULEOFEXAMINATIONToolStripMenuItem1.Size = New System.Drawing.Size(234, 22)
        Me.SCHEDULEOFEXAMINATIONToolStripMenuItem1.Text = "SCHEDULE OF EXAMINATION"
        '
        'RESETTERToolStripMenuItem
        '
        Me.RESETTERToolStripMenuItem.Image = CType(resources.GetObject("RESETTERToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RESETTERToolStripMenuItem.Name = "RESETTERToolStripMenuItem"
        Me.RESETTERToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.RESETTERToolStripMenuItem.Text = "RESETTER"
        '
        'RUNNINGMESSAGEToolStripMenuItem
        '
        Me.RUNNINGMESSAGEToolStripMenuItem.Image = CType(resources.GetObject("RUNNINGMESSAGEToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RUNNINGMESSAGEToolStripMenuItem.Name = "RUNNINGMESSAGEToolStripMenuItem"
        Me.RUNNINGMESSAGEToolStripMenuItem.Size = New System.Drawing.Size(269, 22)
        Me.RUNNINGMESSAGEToolStripMenuItem.Text = "SPECIAL MESSAGE"
        '
        'AddRoomToolStripMenuItem
        '
        Me.AddRoomToolStripMenuItem.Image = CType(resources.GetObject("AddRoomToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AddRoomToolStripMenuItem.Name = "AddRoomToolStripMenuItem"
        Me.AddRoomToolStripMenuItem.Size = New System.Drawing.Size(269, 22)
        Me.AddRoomToolStripMenuItem.Text = "ADD ROOM"
        '
        'AddSectionToolStripMenuItem
        '
        Me.AddSectionToolStripMenuItem.Image = CType(resources.GetObject("AddSectionToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AddSectionToolStripMenuItem.Name = "AddSectionToolStripMenuItem"
        Me.AddSectionToolStripMenuItem.Size = New System.Drawing.Size(269, 22)
        Me.AddSectionToolStripMenuItem.Text = "ADD SECTION"
        '
        'ADDSUBJECTSToolStripMenuItem
        '
        Me.ADDSUBJECTSToolStripMenuItem.Image = CType(resources.GetObject("ADDSUBJECTSToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ADDSUBJECTSToolStripMenuItem.Name = "ADDSUBJECTSToolStripMenuItem"
        Me.ADDSUBJECTSToolStripMenuItem.Size = New System.Drawing.Size(269, 22)
        Me.ADDSUBJECTSToolStripMenuItem.Text = "ADD SUBJECTS"
        '
        'ADDPHOTOEVENTToolStripMenuItem
        '
        Me.ADDPHOTOEVENTToolStripMenuItem.Image = CType(resources.GetObject("ADDPHOTOEVENTToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ADDPHOTOEVENTToolStripMenuItem.Name = "ADDPHOTOEVENTToolStripMenuItem"
        Me.ADDPHOTOEVENTToolStripMenuItem.Size = New System.Drawing.Size(269, 22)
        Me.ADDPHOTOEVENTToolStripMenuItem.Text = "ADD PHOTO EVENT"
        '
        'ADDEVENTToolStripMenuItem
        '
        Me.ADDEVENTToolStripMenuItem.Image = CType(resources.GetObject("ADDEVENTToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ADDEVENTToolStripMenuItem.Name = "ADDEVENTToolStripMenuItem"
        Me.ADDEVENTToolStripMenuItem.Size = New System.Drawing.Size(269, 22)
        Me.ADDEVENTToolStripMenuItem.Text = "ADD EVENT"
        '
        'DELETEPHOTOEVENTToolStripMenuItem
        '
        Me.DELETEPHOTOEVENTToolStripMenuItem.Image = CType(resources.GetObject("DELETEPHOTOEVENTToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DELETEPHOTOEVENTToolStripMenuItem.Name = "DELETEPHOTOEVENTToolStripMenuItem"
        Me.DELETEPHOTOEVENTToolStripMenuItem.Size = New System.Drawing.Size(269, 22)
        Me.DELETEPHOTOEVENTToolStripMenuItem.Text = "DELETE PHOTO EVENT"
        '
        'SAPIToolStripMenuItem
        '
        Me.SAPIToolStripMenuItem.Image = CType(resources.GetObject("SAPIToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SAPIToolStripMenuItem.Name = "SAPIToolStripMenuItem"
        Me.SAPIToolStripMenuItem.Size = New System.Drawing.Size(269, 22)
        Me.SAPIToolStripMenuItem.Text = "SAPI"
        '
        'COURSENOTICEBOARDToolStripMenuItem
        '
        Me.COURSENOTICEBOARDToolStripMenuItem.Checked = True
        Me.COURSENOTICEBOARDToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.COURSENOTICEBOARDToolStripMenuItem.Image = CType(resources.GetObject("COURSENOTICEBOARDToolStripMenuItem.Image"), System.Drawing.Image)
        Me.COURSENOTICEBOARDToolStripMenuItem.Name = "COURSENOTICEBOARDToolStripMenuItem"
        Me.COURSENOTICEBOARDToolStripMenuItem.Size = New System.Drawing.Size(269, 22)
        Me.COURSENOTICEBOARDToolStripMenuItem.Text = "COURSE NOTICE BOARD"
        '
        'THEMESToolStripMenuItem
        '
        Me.THEMESToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JANAUARYToolStripMenuItem, Me.MARCHToolStripMenuItem})
        Me.THEMESToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.THEMESToolStripMenuItem.Image = CType(resources.GetObject("THEMESToolStripMenuItem.Image"), System.Drawing.Image)
        Me.THEMESToolStripMenuItem.Name = "THEMESToolStripMenuItem"
        Me.THEMESToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.THEMESToolStripMenuItem.Text = "THEMES"
        '
        'JANAUARYToolStripMenuItem
        '
        Me.JANAUARYToolStripMenuItem.Image = CType(resources.GetObject("JANAUARYToolStripMenuItem.Image"), System.Drawing.Image)
        Me.JANAUARYToolStripMenuItem.Name = "JANAUARYToolStripMenuItem"
        Me.JANAUARYToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.JANAUARYToolStripMenuItem.Text = "DEFAULT"
        '
        'MARCHToolStripMenuItem
        '
        Me.MARCHToolStripMenuItem.Image = CType(resources.GetObject("MARCHToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MARCHToolStripMenuItem.Name = "MARCHToolStripMenuItem"
        Me.MARCHToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MARCHToolStripMenuItem.Text = "GREEN THEME"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministratorToolStripMenuItem})
        Me.ToolStripMenuItem3.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem3.Image = CType(resources.GetObject("ToolStripMenuItem3.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(74, 20)
        Me.ToolStripMenuItem3.Text = "LOG IN"
        '
        'AdministratorToolStripMenuItem
        '
        Me.AdministratorToolStripMenuItem.Image = CType(resources.GetObject("AdministratorToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AdministratorToolStripMenuItem.Name = "AdministratorToolStripMenuItem"
        Me.AdministratorToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.AdministratorToolStripMenuItem.Text = "ADMINISTRATOR"
        '
        'EXITToolStripMenuItem
        '
        Me.EXITToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.EXITToolStripMenuItem.Image = CType(resources.GetObject("EXITToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem"
        Me.EXITToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.EXITToolStripMenuItem.Text = "EXIT"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Maroon
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripSplitButton1, Me.lblNotify})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 425)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1020, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel1.Image = CType(resources.GetObject("ToolStripStatusLabel1.Image"), System.Drawing.Image)
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(118, 17)
        Me.ToolStripStatusLabel1.Text = "DATE AND TIME :"
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(0, 17)
        Me.ToolStripSplitButton1.Text = "ToolStripSplitButton1"
        '
        'lblNotify
        '
        Me.lblNotify.ForeColor = System.Drawing.Color.White
        Me.lblNotify.Name = "lblNotify"
        Me.lblNotify.Size = New System.Drawing.Size(13, 17)
        Me.lblNotify.Text = "0"
        Me.lblNotify.Visible = False
        '
        'Timer1
        '
        '
        'ANNOUNCEMENTCONFIGURATIONToolStripMenuItem
        '
        Me.ANNOUNCEMENTCONFIGURATIONToolStripMenuItem.Name = "ANNOUNCEMENTCONFIGURATIONToolStripMenuItem"
        Me.ANNOUNCEMENTCONFIGURATIONToolStripMenuItem.Size = New System.Drawing.Size(269, 22)
        Me.ANNOUNCEMENTCONFIGURATIONToolStripMenuItem.Text = "ANNOUNCEMENT CONFIGURATION"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1020, 447)
        Me.ControlBox = False
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Electronic Bulletin Board System via SMS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents NOTIFICATIONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MASTERENTRYToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents EXITToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SMSNotificationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PhonebookToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewHistoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SCHEDULEOFEXAMINATIONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents THEMESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EBULLETINCATEGORYToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministratorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddRoomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddSectionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ADDSUBJECTSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSplitButton1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblNotify As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents JANAUARYToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MARCHToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RUNNINGMESSAGEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ANNOUNCEMENTSEVENTSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SCHEDULEOFEXAMINATIONToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ADDPHOTOEVENTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ADDEVENTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RESETTERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SAPIToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents POSTRECIEVINGSMSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DELETEPHOTOEVENTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents COURSENOTICEBOARDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ANNOUNCEMENTCONFIGURATIONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
