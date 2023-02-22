Imports MySql.Data.MySqlClient
Imports System.IO.Ports
Imports System.Threading
Imports System.Management
Imports System.Text.RegularExpressions
Imports System.IO
Imports System.Linq

Public Class frmAllSMS
    ''' <summary>
    ''' Implementation of recieving/sending SMS via Database.
    ''' *********DENVER:09-20-2017**********
    ''' If there is a bug found please contact the developer @ mgregorio.kinpo.com.ph
    ''' or submit a report message on www.markdenvergregorio.pe.hu
    ''' Developer : Denver
    ''' Distribution of this code is probihited, please ask the developer and the client first to distribute this code
    ''' </summary>
    Dim csstring As String = "server=localhost;uid=root;pwd=admin;database=ebulletindb;"
    Dim rcvdata As String = ""
    Dim index As String = ""
    Dim strSelectedAssignCode As String
    Dim isAll As Boolean = False
    Dim isFaculty As Boolean = False
    Dim isStudent As Boolean = False


    Private Sub frmAllSMS_FormClosing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        Try
            If sPort.IsOpen Then
                sPort.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub frmAllSMS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Call SMS Configuration
        Try
            Call smsConfig()
            Call splitMessages()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Public Sub sPort_DataRecieved(ByVal sender As Object, ByVal e As SerialDataReceivedEventArgs) Handles sPort.DataReceived

        Try
            Dim dataIn As String = ""
            Dim numBytes As Integer = sPort.BytesToRead
            Thread.Sleep(300)
            For i As Integer = 1 To numBytes
                dataIn &= sPort.ReadExisting

            Next
            reciever(dataIn)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Public Sub reciever(ByVal inData As String)
        rcvdata &= inData
    End Sub

    '<Denver><09-25-2017><SMSConfiguration>
    Public Sub smsConfig()
        Try
            With sPort
                rcvdata = ""
                .PortName = "COM7"
                .BaudRate = 9600
                .Parity = Parity.None
                .DataBits = 8
                .StopBits = StopBits.One
                .Handshake = Handshake.None
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

    Public Sub splitMessages()
        lvRead.Items.Clear()
        Try
            With sPort
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

                If rboAll.Checked = True Then
                    Call AllRecords()
                ElseIf rboFaculty.Checked = True Then
                    Call FacultyRecords()
                ElseIf rboStudent.Checked = True Then
                    Call StudentRecords()
                Else
                    Call rcvMessages()
                End If

            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Public Sub rcvMessages()
        Dim lineText As String
        Dim i As Integer
        Dim arrayTextFile() As String
        lineText = rcvdata.ToString()
        arrayTextFile = Split(lineText, "+CMGL", , CompareMethod.Text)


        For i = 3 To UBound(arrayTextFile)
            Dim input As String = arrayTextFile(i)
            Dim pattern As String = "(:)|(,"")|("","")|(,)|(" + """)|(OK)"
            Dim result() As String
            result = Regex.Split(input, pattern)

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "SELECT * FROM tblphonebookall where mnum ='" & result(6) & "'"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            While dr.Read
                getSection = dr("section")
                'getFacultyDept = dr("facultydept")
                getGroupBy = dr("groupby")
                getName = dr("name")
                Dim lv As ListViewItem = lvRead.Items.Add(getSection)
                With lv
                    '.SubItems.Add(getFacultyDept)
                    .SubItems.Add(result(6))
                    .SubItems.Add(result(12))
                    Dim myMsg As String = result(20)
                    Dim regEx As New Regex(String.Join("|", arrayString), RegexOptions.IgnoreCase)

                    If regEx.IsMatch(myMsg) Then
                        .BackColor = Color.DarkGreen
                        .ForeColor = Color.DarkGreen
                    Else
                        .SubItems.AddRange(New String() {myMsg.ToString()})
                    End If

                    .SubItems.Add(getName)
                    .SubItems.Add(getGroupBy)
                End With
            End While

            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Next
    End Sub

    Sub AllRecords()
        Dim lineText As String
        Dim i As Integer
        Dim arrayTextFile() As String
        lineText = rcvdata.ToString()
        arrayTextFile = Split(lineText, "+CMGL", , CompareMethod.Text)


        For i = 3 To UBound(arrayTextFile)
            Dim input As String = arrayTextFile(i)
            Dim pattern As String = "(:)|(,"")|("","")|(,)|(" + """)|(OK)"
            Dim result() As String
            result = Regex.Split(input, pattern)

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "SELECT * FROM tblphonebookall where mnum ='" & result(6) & "'"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            While dr.Read
                getSection = dr("section")
                ' getFacultyDept = dr("facultydept")
                getGroupBy = dr("groupby")
                getName = dr("name")
                Dim lv As ListViewItem = lvRead.Items.Add(getSection)
                With lv
                    '.SubItems.Add(getFacultyDept)
                    .SubItems.Add(result(6))
                    .SubItems.Add(result(12))
                    Dim myMsg As String = result(20)
                    Dim regEx As New Regex(String.Join("|", arrayString), RegexOptions.IgnoreCase)

                    If regEx.IsMatch(myMsg) Then
                        .BackColor = Color.Maroon
                        .ForeColor = Color.Maroon
                    Else
                        .SubItems.AddRange(New String() {myMsg.ToString()})
                    End If

                    .SubItems.Add(getName)
                    .SubItems.Add(getGroupBy)
                End With
            End While
        Next
    End Sub

    Sub FacultyRecords()
        Dim lineText As String
        Dim i As Integer
        Dim arrayTextFile() As String
        lineText = rcvdata.ToString()
        arrayTextFile = Split(lineText, "+CMGL", , CompareMethod.Text)


        For i = 3 To UBound(arrayTextFile)
            Dim input As String = arrayTextFile(i)
            Dim pattern As String = "(:)|(,"")|("","")|(,)|(" + """)|(OK)"
            Dim result() As String
            result = Regex.Split(input, pattern)

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "SELECT * FROM tblphonebookall where mnum ='" & result(6) & "'and groupby ='" & "Faculty" & "'"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            While dr.Read
                getSection = dr("section")
                'getFacultyDept = dr("facultydept")
                getGroupBy = dr("groupby")
                getName = dr("name")
                Dim lv As ListViewItem = lvRead.Items.Add(getSection)
                With lv
                    '.SubItems.Add(getFacultyDept)
                    .SubItems.Add(result(6))
                    .SubItems.Add(result(12))
                    Dim myMsg As String = result(20)
                    Dim regEx As New Regex(String.Join("|", arrayString), RegexOptions.IgnoreCase)

                    If regEx.IsMatch(myMsg) Then
                        .BackColor = Color.Maroon
                        .ForeColor = Color.Maroon
                    Else
                        .SubItems.AddRange(New String() {myMsg.ToString()})
                    End If

                    .SubItems.Add(getName)
                    .SubItems.Add(getGroupBy)
                End With
            End While
        Next
    End Sub

    Sub StudentRecords()
        Dim lineText As String
        Dim i As Integer
        Dim arrayTextFile() As String
        lineText = rcvdata.ToString()
        arrayTextFile = Split(lineText, "+CMGL", , CompareMethod.Text)


        For i = 3 To UBound(arrayTextFile)
            Dim input As String = arrayTextFile(i)
            Dim pattern As String = "(:)|(,"")|("","")|(,)|(" + """)|(OK)"
            Dim result() As String
            result = Regex.Split(input, pattern)

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "SELECT * FROM tblphonebookall where mnum ='" & result(6) & "'and groupby ='" & "Student" & "'"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            While dr.Read
                getSection = dr("section")
                'getFacultyDept = dr("facultydept")
                getGroupBy = dr("groupby")
                getName = dr("name")
                Dim lv As ListViewItem = lvRead.Items.Add(getSection)
                With lv
                    ' .SubItems.Add(getFacultyDept)
                    .SubItems.Add(result(6))
                    .SubItems.Add(result(12))
                    Dim myMsg As String = result(20)
                    Dim regEx As New Regex(String.Join("|", arrayString), RegexOptions.IgnoreCase)

                    If regEx.IsMatch(myMsg) Then
                        .BackColor = Color.Maroon
                        .ForeColor = Color.Maroon
                    Else
                        .SubItems.AddRange(New String() {myMsg.ToString()})
                    End If

                    .SubItems.Add(getName)
                    .SubItems.Add(getGroupBy)
                End With
            End While
        Next
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If rboAll.Checked = True Then
            Call splitMessages()
        ElseIf rboFaculty.Checked = True Then
            Call splitMessages()
        ElseIf rboStudent.Checked = True Then
            Call splitMessages()
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        rboAll.Checked = False
        rboFaculty.Checked = False
        rboStudent.Checked = False
        txtContent.Text = ""
        Call splitMessages()
    End Sub

    Private Sub lvRead_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvRead.Click

    End Sub

    Private Sub btnPost_Click(sender As Object, e As EventArgs) Handles btnPost.Click
        Dim res As DialogResult
        res = MsgBox("Do you want to post the message to the announcement board?", vbYesNo + MsgBoxStyle.Information, "Post")
        If res = DialogResult.Yes Then
            If String.IsNullOrEmpty(txtTitle.Text) OrElse String.IsNullOrEmpty(txtContent.Text) OrElse String.IsNullOrEmpty(txtName.Text) OrElse String.IsNullOrEmpty(txtAddress.Text) Then
                MsgBox("Sorry, the system can't post the empty fields. Please complete the details.", MsgBoxStyle.Exclamation, "Warning")
                Exit Sub
            End If

            If getPostGroupBy = "Faculty" Then
                con = New MySqlConnection(csstring)
                con.Open()
                strSQL = "INSERT INTO tblnewannouncement(message, name, dateentry, title, address) VALUES('" & txtContent.Text & "','" &
                    txtName.Text & "','" &
                    Format(dtpWhen.Value, "yyyy-MM-dd HH:mm:ss") & "','" &
                    txtTitle.Text & "','" &
                    txtAddress.Text & "')"
                cmd = New MySqlCommand(strSQL, con)
                cmd.ExecuteNonQuery()
                MsgBox("The message will be posted in the announcement board.", MsgBoxStyle.Information, "Success")
                txtTitle.Text = ""
                txtContent.Text = ""
                txtAddress.Text = ""
                txtName.Text = ""
                If con.State <> ConnectionState.Open Then
                    con.Close()
                End If
            Else
                MsgBox("Sorry, the system can't post the message of the students", MsgBoxStyle.Exclamation, "Warning")
            End If
        End If
    End Sub

    Private Sub ReplyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReplyToolStripMenuItem.Click
        If getPostGroupBy = "Faculty" Then
            txtContent.Text = lvRead.FocusedItem.SubItems(3).Text.TrimStart
            txtName.Text = lvRead.FocusedItem.SubItems(4).Text

        Else
            MsgBox("Sorry, the system can't post the message of the students", MsgBoxStyle.Exclamation, "Warning")
        End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        If getPostGroupBy = "Student" Then
            txtSection.Text = lvRead.SelectedItems(0).Text
            txtFeedback.Text = lvRead.FocusedItem.SubItems(3).Text.TrimStart
        Else
            MsgBox("Sorry, the feedback is for the students only.", MsgBoxStyle.Exclamation, "Warning")
        End If
    End Sub

    Private Sub lvRead_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles lvRead.SelectedIndexChanged
        Try
            If lvRead.SelectedItems.Count > 0 Then
                getPostGroupBy = lvRead.FocusedItem.SubItems(5).Text
            End If
        Catch
            Return
        End Try
    End Sub

    Private Sub btnFeedbackClear_Click(sender As Object, e As EventArgs) Handles btnFeedbackClear.Click
        txtSection.Text = ""
        txtFeedback.Text = ""
    End Sub

    Private Sub btnPostFeed_Click(sender As Object, e As EventArgs) Handles btnPostFeed.Click
        Dim res As DialogResult
        res = MsgBox("Do you want to post the message in the feedback board?", vbYesNo + MsgBoxStyle.Information, "Post")
        If res = DialogResult.Yes Then
            If String.IsNullOrEmpty(txtSection.Text) OrElse String.IsNullOrEmpty(txtFeedback.Text) Then
                MsgBox("Sorry, the system can't post the empty section and message.", MsgBoxStyle.Exclamation, "Warning")
                Exit Sub
            End If

            If getPostGroupBy = "Student" Then
                con = New MySqlConnection(csstring)
                con.Open()
                strSQL = "INSERT INTO tblfeedback(section, message, dateentry) VALUES('" & txtSection.Text.Trim & "','" &
                    txtFeedback.Text.Trim & "','" &
                    Format(Date.Today, "yyyy-MM-dd") & "')"
                cmd = New MySqlCommand(strSQL, con)
                cmd.ExecuteNonQuery()
                MsgBox("The message will be posted in the feedback board.", MsgBoxStyle.Information, "Success")
                txtSection.Text = ""
                txtFeedback.Text = ""
                If con.State <> ConnectionState.Open Then
                    con.Close()
                End If
            Else
                MsgBox("Sorry, the system can't post the message of the students", MsgBoxStyle.Exclamation, "Warning")
            End If
        End If
    End Sub
End Class