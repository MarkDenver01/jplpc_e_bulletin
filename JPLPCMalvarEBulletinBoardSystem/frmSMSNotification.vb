Imports System
Imports System.IO
Imports System.Threading
Imports System.Management
Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
Imports System.Collections.Generic
''' <summary>
''' Note: Distribution of this code is probihited. Please ask the developer or the client first.
''' ---10-28-2017---
''' If you found a bug please contact the developer immediately @ mgregorio.kinpo.com.ph
''' or visit in our website http://markdenvergregorio.pe.hu
''' </summary>
Public Class frmSMSNotification
    Dim rcvdata As String = ""
    Dim strSelectedAssignCode As String
    Dim index As String = ""
    Dim csstring As String = "server=localhost;uid=root;pwd=admin;database=ebulletindb;"

    Dim sortNumList As New SortedList(Of Integer, String)
    Dim sortNum As New List(Of String)()
    Dim sortFacultyName As New List(Of String)()
    Dim SortSectionName As New List(Of String)()
    Dim sortNumSection As New List(Of String)()

    Private Sub frmSMSNotification_FormClosing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        If SerialPort1.IsOpen Then
            SerialPort1.Close()
        End If

    End Sub

    Private Sub frmSMSNotification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'btnLoadMessages.Text = "Load Messages"
        'cboModem.Items.Clear()

        'Dim ports() As String
        'ports = Split(ModemsConnected(), "***")

        'For i As Integer = 0 To ports.Length - 2
        '    cboModem.Items.Add(ports(i))
        'Next
        Call SMSConfig()
        'Timer1.Interval = 5000
        'Timer1.Enabled = True
        'Timer1.Start()
        Call LoadMessages()

        cboBulk.Visible = False
        cboFillSection.Visible = False
        cboBulk.Location = New Point(7, 47)
        cboBulk.Width = 223
        cboBulk.SelectedIndex = -1
        cboFillSection.SelectedIndex = -1

        'Call populateDictionary()

    End Sub
    'Public Function ModemsConnected() As String
    '    Dim modems As String = ""
    '    Try
    '        Dim searcher As New Management.ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_POTSModem")

    '        For Each queryObject As ManagementObject In searcher.Get()
    '            If queryObject("Status") = "OK" Then
    '                modems = modems & (queryObject("AttachedTo") & " - " & queryObject("Description") & "***")

    '            End If
    '        Next
    '    Catch ex As Exception
    '        MsgBox("An error occured while querying for WMI data: ", MsgBoxStyle.Critical, "Error")
    '        Return ""

    '    End Try
    '    Return modems
    'End Function
    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles txtSmsno.Click
        txtSmsno.Text = ""
    End Sub
    Private Sub serialport1_datareceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Dim datain As String = ""
        Dim numbytes As Integer = SerialPort1.BytesToRead
        Thread.Sleep(300)
        For i As Integer = 1 To numbytes
            datain &= SerialPort1.ReadExisting
        Next
        test(datain)
    End Sub
    Private Sub test(ByVal indata As String)
        rcvdata &= indata
    End Sub
    'Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
    '    If Label1.Text = "Port" Then
    '        MsgBox("Please select port to connect.", MsgBoxStyle.Critical, "Validation")
    '        Exit Sub
    '    End If
    '    Try
    '        With SerialPort1
    '            .PortName = "COM19"
    '            .BaudRate = 9600
    '            .Parity = Ports.Parity.None
    '            .DataBits = 8
    '            .StopBits = Ports.StopBits.One
    '            .Handshake = Ports.Handshake.None
    '            .RtsEnable = True
    '            .ReceivedBytesThreshold = 1
    '            .NewLine = vbCr
    '            .ReadTimeout = 1000
    '            .Open()
    '        End With
    '        If SerialPort1.IsOpen Then
    '            lblConnected.Text = "Connected to"
    '        Else
    '            lblConnected.Text = "Error"
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    '    End Try
    'End Sub

    Sub SMSConfig()
        Try
            With SerialPort1
                .PortName = "COM7"
                .BaudRate = 9600
                .Parity = Ports.Parity.None
                .DataBits = 8
                .StopBits = Ports.StopBits.One
                .Handshake = Ports.Handshake.None
                .RtsEnable = True
                .ReceivedBytesThreshold = 1
                .NewLine = vbCr
                .ReadTimeout = 1000
                .Open()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Public Sub LoadMessages()
        lvRead.Items.Clear()
        txtContent.Text = ""
        Try
            With SerialPort1
                rcvdata = ""
                .Write("AT" & vbCrLf)
                Threading.Thread.Sleep(1000)
                .Write("AT+CMGF=1" & vbCrLf)
                Threading.Thread.Sleep(1000)
                .Write("AT+CPMS=""SM""" & vbCrLf)
                Threading.Thread.Sleep(1000)
                .WriteLine("AT+CMGL=""REC UNREAD""" & vbCrLf) 'read unread messages
                Threading.Thread.Sleep(1000)
                .Write("AT+CMGL=""ALL""" & vbCrLf)
                Threading.Thread.Sleep(1000)
                ReadMsg()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub ReadMsg()
        Try
            Dim lineoftext As String
            Dim i As Integer
            Dim arytextfile() As String
            lineoftext = rcvdata.ToString
            arytextfile = Split(lineoftext, "+CMGL", , CompareMethod.Text)
            For i = 3 To UBound(arytextfile)
                Dim input As String = arytextfile(i)
                Dim result() As String
                Dim pattern As String = "(:)|(,"")|("","")|(,)|(" + """)|(OK)"
                result = Regex.Split(input, pattern)
                Dim lvi As New ListViewItem

                'Dim strFilter As String
                'strFilter = "*"
                'For Each strFilter In list
                '    strFilter = lvRead.Items(0).SubItems(3).Text

                'Next
                'messageResult = result(10)
                'positionResult = messageResult.Length - 1
                'messageResult = messageResult.Remove(positionResult, 1)

                'For Each getFiltered As String In dictionary.Keys
                '    ' If lvRead.Items(0).SubItems(3).Text.Contains(getFiltered) Then

                '    If messageResult.Contains(getFiltered) Then

                '        Dim randomValue As Integer = (Rnd() * dictionary.Item(getFiltered).Length)
                '        Dim replacementWord As String = dictionary.Item(getFiltered)(randomValue)
                '        messageResult = messageResult.Replace(getFiltered, replacementWord)
                '    End If
                'Next

                With lvRead.Items.Add(result(2))
                    ' lvi.BackColor = Color.DarkRed
                    'index
                    .SubItems.AddRange(New String() {result(2)})
                    'status 
                    Dim status As String
                    If result(4) = "REC READ" Then
                        status = "READ"
                        .SubItems.AddRange(New String() {status})
                    ElseIf result(4) = "REC UNREAD" Then
                        status = "UNREAD"
                        .SubItems.AddRange(New String() {status})
                    End If
                    '.SubItems.AddRange(New String() {result(4)})

                    'number
                    'Dim my_string, position As String
                    'my_string = result(6)
                    'position = my_string.Length - 1
                    'my_string = my_string.Remove(position, 1)
                    '.SubItems.AddRange(New String() {result(2)})
                    'messsage
                    .SubItems.AddRange(New String() {result(6)})
                    .SubItems.AddRange(New String() {result(12)})
                    '.SubItems.AddRange(New String() {result(messageResult)})
                    '.SubItems.AddRange(New String() {result(strFilter)})
                    Dim mystring As String = result(20)
                    ' mystring = mystring.remove(0, 6)

                    ' .SubItems.AddRange(New String() {result(16)})

                    Dim regex As New Regex(String.Join("|", arrayString), RegexOptions.IgnoreCase)
                    If regex.IsMatch(mystring) Then
                        .BackColor = Color.DarkGreen
                        .ForeColor = Color.DarkGreen
                    Else
                        .SubItems.Add(mystring)
                    End If

                End With
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub


    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        If chkBulk.Checked = True Then
            If cboBulk.Text = "Faculty" Then

                If txtMsg.Text.Trim = "" Then
                    MsgBox("Please enter message to send.", MsgBoxStyle.OkOnly, "Validation")
                    Exit Sub
                End If

                For i As Integer = 0 To sortNum.Count - 1
                    With SerialPort1
                        .Write("AT" & vbCrLf)
                        .Write("AT+CMGF=1" & vbCrLf)
                        .Write("AT+CMGS=" & Chr(34) & sortNum(i) & Chr(34) & vbCrLf)
                        .Write(txtMsg.Text & Chr(26))

                    End With
                Next

                For x As Integer = 0 To sortNum.Count - 1
                    For z As Integer = 0 To sortFacultyName.Count - 1
                        con = New MySqlConnection(csstring)
                        con.Open()
                        strSQL = "Insert into tblsentitems(mnum, messages, datesent, name) VALUES('" & sortNum(x) & "','" &
                            txtMsg.Text & "','" &
                            Format(Date.Today, "yyyy-MM-dd") & "','" &
                            sortFacultyName(z).ToString() & "')"
                        cmd = New MySqlCommand(strSQL, con)
                        cmd.ExecuteNonQuery()
                        If con.State <> ConnectionState.Open Then
                            con.Close()
                        End If
                    Next
                Next
                MsgBox("Message has sent!", MsgBoxStyle.Information, "Success")
                sortFacultyName.Clear()
                sortNum.Clear()
            ElseIf cboBulk.Text = "Student" Then

                If txtMsg.Text.Trim = "" Then
                    MsgBox("Please enter message to send.", MsgBoxStyle.OkOnly, "Validation")
                    Exit Sub
                End If

                For i As Integer = 0 To sortNumSection.Count - 1
                    With SerialPort1
                        .Write("AT" & vbCrLf)
                        .Write("AT+CMGF=1" & vbCrLf)
                        .Write("AT+CMGS=" & Chr(34) & sortNumSection(i) & Chr(34) & vbCrLf)
                        .Write(txtMsg.Text & Chr(26))
                    End With
                Next

                For x As Integer = 0 To sortNumSection.Count - 1
                    For z As Integer = 0 To SortSectionName.Count - 1
                        con = New MySqlConnection(csstring)
                        con.Open()
                        strSQL = "Insert into tblsentitems(mnum, messages, datesent, name) VALUES('" & sortNumSection(x) & "','" &
                            txtMsg.Text & "','" &
                            Format(Date.Today, "yyyy-MM-dd") & "','" &
                            SortSectionName(z).ToString() & "')"
                        cmd = New MySqlCommand(strSQL, con)
                        cmd.ExecuteNonQuery()
                        If con.State <> ConnectionState.Open Then
                            con.Close()
                        End If
                    Next
                Next

                MsgBox("Message has sent!", MsgBoxStyle.Information, "Success")
                sortNumSection.Clear()
                SortSectionName.Clear()
            End If

        Else
            If txtSmsno.Text = "" Then
                MsgBox("Please enter contact number.", MsgBoxStyle.OkOnly, "Validation")
                Exit Sub
            End If
            If txtMsg.Text.Trim = "" Then
                MsgBox("Please enter message to send.", MsgBoxStyle.OkOnly, "Validation")
                Exit Sub
            End If
            Try
                With SerialPort1
                    .Write("AT" & vbCrLf)
                    Threading.Thread.Sleep(100)
                    .Write("AT+CMGF=1" & vbCrLf)
                    Threading.Thread.Sleep(100)
                    .Write("AT+CMGS=" & Chr(34) & txtSmsno.Text & Chr(34) & vbCrLf)
                    .Write(txtMsg.Text & Chr(26) & vbCrLf)
                    Threading.Thread.Sleep(100)
                End With
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Insert into tblsentitems(mnum, messages, datesent, name) VALUES('" & txtSmsno.Text & "','" &
                            txtMsg.Text & "','" &
                            Format(Date.Today, "yyyy-MM-dd") & "','" &
                             "No Name" & "')"
            cmd = New MySqlCommand(strSQL, con)
            cmd.ExecuteNonQuery()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If


            MsgBox("Message has sent!", MsgBoxStyle.Information, "Success")

            txtSmsno.Text = ""
            txtMsg.Text = ""
            txtSmsno.Focus()

        End If
    End Sub
    'Private Sub btnLoadMessages_Click(sender As Object, e As EventArgs) Handles btnLoadMessages.Click
    '    Call LoadMessages()
    'End Sub
    Private Sub lvRead_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvRead.Click
        Try
            txtContent.Text = lvRead.FocusedItem.SubItems(5).Text.TrimStart
        Catch
            Return
        End Try
    End Sub
    Private Sub ListView1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvRead.MouseDown
        Try
            If IsNothing(lvRead.FocusedItem) Then Exit Sub
            strSelectedAssignCode = lvRead.FocusedItem.Text
            If e.Button = MouseButtons.Right Then
                If lvRead.SelectedItems.Count > 0 Then
                    ContextMenuStrip1.Show(lvRead, New Point(e.X, e.Y))
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub lvRead_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles lvRead.SelectedIndexChanged
        Try
            'txtContent.Text = lvRead.FocusedItem.SubItems(5).Text
            With lvRead.FocusedItem
                index = .SubItems(0).Text
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    'Private Sub cboModem_SelectedIndexChanged(sender As Object, e As EventArgs)
    '    Label1.Text = Trim(Mid(cboModem.Text, 1, 5))
    'End Sub
    Private Sub ReplyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReplyToolStripMenuItem.Click
        txtSmsno.Text = lvRead.FocusedItem.SubItems(3).Text.TrimStart
        txtMsg.Focus()
    End Sub
    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        If MsgBox("Are you sure you want to delete this message?", vbYesNo + MsgBoxStyle.Information, "Delete") = MsgBoxResult.Yes Then
            Try
                With SerialPort1
                    .Write("AT")
                    Threading.Thread.Sleep(1)
                    .Write("AT+CMGF=1")
                    Threading.Thread.Sleep(1)
                    .Write("AT+CPMS=""SM""" & vbCrLf)
                    Threading.Thread.Sleep(1)
                    .Write("AT+CMGD=" & Val(index) & ",0")
                    Threading.Thread.Sleep(1)
                    LoadMessages()
                    MsgBox("Message deleted.", MsgBoxStyle.Information, "Delete")
                End With
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        Else
            Exit Sub
        End If
    End Sub
    Private Sub DeleteAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteAllToolStripMenuItem.Click
        If MsgBox("Are you sure you want to delete meesages all?", vbYesNo + MsgBoxStyle.Information, "Delete") = MsgBoxResult.Yes Then
            Try
                With SerialPort1
                    .Write("AT")
                    Threading.Thread.Sleep(1000)
                    .Write("AT+CMGF=1")
                    Threading.Thread.Sleep(1000)
                    .Write("AT+CPMS=""SM""" & vbCrLf)
                    Threading.Thread.Sleep(1000)

                    .Write("AT+CMGD=1,4")
                    Threading.Thread.Sleep(1000)
                    LoadMessages()
                    MsgBox("Messages deleted.", MsgBoxStyle.Information, "Delete")
                End With
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        Else
            Exit Sub
        End If
    End Sub
    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        frmPhoneBook.ShowDialog()
    End Sub
    Private Sub SaveToPhonebookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToPhonebookToolStripMenuItem.Click
        If lvRead.SelectedItems.Count > 0 Then
            frmAddPhonebook.txtMobile.Text = lvRead.FocusedItem.SubItems(3).Text
            frmAddPhonebook.ShowDialog()
        End If
    End Sub

    Private Sub btnApprove_Click(sender As Object, e As EventArgs) Handles btnApprove.Click

        If String.IsNullOrEmpty(txtTitle.Text) OrElse String.IsNullOrEmpty(txtContent.Text) Then
            MsgBox("Sorry, the system can't post the empty message", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If

        con = New MySqlConnection(csstring)
        con.Open()
        strSQL = "INSERT INTO tblnewannouncement(message, name, dateentry, title, address) VALUES('" & txtContent.Text & "','" &
            txtName.Text & "','" &
            Format(dtpWhen.Value, "yyyy-MM-dd HH:mm:ss") & "','" &
            txtTitle.Text & "','" &
            txtWhere.Text & "')"
        cmd = New MySqlCommand(strSQL, con)
        cmd.ExecuteNonQuery()
        MsgBox("The message will be posted in the announcement board.", MsgBoxStyle.Information, "Success")
        txtTitle.Text = ""
        txtContent.Text = ""
        txtName.Text = ""
        txtWhere.Text = ""
        If con.State <> ConnectionState.Open Then
            con.Close()
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Call LoadMessages()
    End Sub

    Private Sub RefreshRecordsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshRecordsToolStripMenuItem.Click
        Call LoadMessages()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub chkBulk_CheckedChanged(sender As Object, e As EventArgs) Handles chkBulk.CheckedChanged
        If chkBulk.Checked = True Then
            cboBulk.Visible = True
            cboBulk.Width = 223
            txtSmsno.Visible = False
            btnSelect.Visible = False
            cboFillSection.Visible = False
            cboBulk.SelectedIndex = -1
            cboFillSection.SelectedIndex = -1
        Else
            txtSmsno.Visible = True
            btnSelect.Visible = True
            cboBulk.Visible = False
            cboFillSection.Visible = False
            cboBulk.SelectedIndex = -1
            cboFillSection.SelectedIndex = -1

        End If
    End Sub

    Public Function getAllFacultyNumber() As List(Of String)
        con = New MySqlConnection(csstring)
        con.Open()
        strSQL = "SELECT * FROM tblphonebookall WHERE groupby ='" & "Student" & "'"
        cmd = New MySqlCommand(strSQL, con)
        dr = cmd.ExecuteReader
        'sortNumList.Clear()
        While dr.Read
            'sortNumList = New SortedList(Of Integer, String)
            'sortNumList.Add(dr("id"), dr("mnum"))
            sortNum = New List(Of String)()
            sortNum.Add(dr("mnum").ToString())

        End While


        dr.Close()
        cmd.Dispose()
        If con.State <> ConnectionState.Open Then
            con.Close()
        End If

        Return sortNum
    End Function

    Private Sub cboBulk_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBulk.SelectedIndexChanged
        If cboBulk.Text = "Faculty" Then
            cboFillSection.Visible = False
            cboBulk.Location = New Point(7, 47)
            cboBulk.Width = 223

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "SELECT * FROM tblphonebookall WHERE groupby ='" & cboBulk.Text & "'"
            cmd = New MySqlCommand(strSQL, con)
            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)
            For i As Integer = 0 To dt.Rows.Count - 1
                sortNum.Add(dt.Rows(i)("mnum").ToString())
                sortFacultyName.Add(dt.Rows(i)("name").ToString())
            Next

            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If


        ElseIf cboBulk.Text = "Student" Then
            cboFillSection.Visible = True
            cboBulk.Location = New Point(7, 47)
            cboBulk.Width = 110
            cboFillSection.Location = New Point(123, 47)

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "SELECT * FROM tblphonebookall WHERE groupby ='" & cboBulk.Text & "'"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            cboFillSection.Items.Clear()
            While dr.Read
                cboFillSection.Items.Add(dr("section"))
            End While
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If

        Else
            cboFillSection.Visible = False
            cboBulk.Location = New Point(7, 47)
            cboBulk.Width = 223
        End If
    End Sub

    Private Sub cboFillSection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFillSection.SelectedIndexChanged
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "SELECT * FROM tblphonebookall WHERE section ='" & cboFillSection.Text & "'"
            cmd = New MySqlCommand(strSQL, con)
            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)
            For i As Integer = 0 To dt.Rows.Count - 1
                sortNumSection.Add(dt.Rows(i)("mnum").ToString())
                SortSectionName.Add(dt.Rows(i)("name").ToString())
            Next

            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Dim res As DialogResult
        res = MsgBox("Do you want to view the SMS Sent Items?", vbYesNo + MsgBoxStyle.Information, "View")
        If res = DialogResult.Yes Then
            frmView.ShowDialog()
        End If
    End Sub
End Class