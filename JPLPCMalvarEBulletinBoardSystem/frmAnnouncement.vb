Imports MySql.Data.MySqlClient
Imports System.IO.Ports
Imports System.Threading
Imports System.Management
Imports System.Text.RegularExpressions
Imports System.IO
Imports System.Linq

Public Class frmAnnouncement
    Dim csstring As String = "server=localhost;uid=root;pwd=admin;database=ebulletindb;"
    Dim RanNum As New Random
    Dim DistMove As Integer = 10
    'Dim inc As Integer = 1
    'Dim inc2 As Integer = 11

    Dim rcvdata As String = ""
    Dim index As String = ""
    Dim strSelectedAssignCode As String

    'Private Sub frmAnnouncement_FormClosing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
    '    Try
    '        If sPort.IsOpen Then
    '            sPort.Close()
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    '    End Try
    'End Sub


    Private Sub frmAnnouncement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer7.Interval = 10000
        Timer7.Start()

        Timer1.Start()
        'Blinking Running Message
        Timer2.Interval = 10000
        Timer2.Start()
        Timer3.Enabled = True

        Timer6.Interval = 10000
        Timer6.Start()

        Timer5.Interval = 10000
        Timer5.Start()

        'DENVER <09-11-2017>: Loading announcements
        Timer4.Start()
        'Timer5.Start()
        ' Timer4.Interval = 10000
        'Timer4.Start()


        'Call SMS Configuration
        'Try
        '    smsConfig()
        'Catch ex As Exception
        '    MsgBox(ex.ToString, MsgBoxStyle.Critical, "Error")
        'End Try

    End Sub

    '<DENVER><11-18-2017><Get all announcements from database>
    Dim sortID As New List(Of String)()
    Dim sortTitle As New List(Of String)()
    Dim inc As Integer = 1
    Dim ds As DataSet = New DataSet
    Dim da As MySqlDataAdapter = New MySqlDataAdapter
    Dim dt As DataTable = New DataTable

    Public Sub RunQuery(ByVal Query As String)
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            cmd = New MySqlCommand(Query, con)
            da = New MySqlDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds)


            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    'DENVER <09-22-2017>: SMS Reader
    'Public Sub sPort_DataRecieved(ByVal sender As Object, ByVal e As SerialDataReceivedEventArgs) Handles sPort.DataReceived

    '    Try
    '        Dim dataIn As String = ""
    '        Dim numBytes As Integer = sPort.BytesToRead
    '        Thread.Sleep(300)
    '        For i As Integer = 1 To numBytes
    '            dataIn &= sPort.ReadExisting

    '        Next
    '        reciever(dataIn)
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    '    End Try

    'End Sub

    'Denver <09-22-2017>: Recieving SMS
    'Public Sub reciever(ByVal inData As String)
    '    rcvdata &= inData
    'End Sub


    'DENVER <09-23-2017>: SMS Configuration
    'Public Sub smsConfig()
    '    Try
    '        With sPort
    '            .PortName = "COM7"
    '            .BaudRate = 9600
    '            .Parity = Parity.None
    '            .DataBits = 8
    '            .StopBits = StopBits.One
    '            .Handshake = Handshake.None
    '            .RtsEnable = True
    '            .ReceivedBytesThreshold = 1
    '            .NewLine = vbCr
    '            .ReadTimeout = 1000
    '            .Open()
    '            splitMessages()
    '        End With
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    '    End Try
    'End Sub

    'Denver <09-22-2017>: Split Recieve Messages
    'Public Sub splitMessages()
    '    lvMessage.Items.Clear()
    '    Try
    '        With sPort
    '            rcvdata = ""
    '            .Write("AT" & vbCrLf)
    '            Threading.Thread.Sleep(1000)
    '            .Write("AT+CMGF=1" & vbCrLf)
    '            Threading.Thread.Sleep(1000)
    '            .Write("AT+CPMS=""SM""" & vbCrLf)
    '            Threading.Thread.Sleep(1000)
    '            .WriteLine("AT+CMGL=""REC UNREAD""" & vbCrLf) 'read unread messages
    '            Threading.Thread.Sleep(1000)
    '            .Write("AT+CMGL=""ALL""" & vbCrLf)
    '            Threading.Thread.Sleep(1000)
    '            rcvMessages()
    '            ' num += 1
    '        End With

    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    '    End Try
    'End Sub


    ''Denver <10-11-2017>:List to filtering all badwords
    'Public Shared Function badWords(ByVal inputText As String, ByVal badWordsFile As String) As String
    '    Dim fs As StreamReader = File.OpenText(badWordsFile)
    '    Dim bs As New Specialized.StringCollection
    '    Dim sb As New Text.StringBuilder(inputText)

    '    While fs.Peek <> -1
    '        sb = sb.Replace(fs.ReadLine.Trim, "*")

    '    End While

    '    fs.Close()
    '    Return sb.ToString

    'End Function


    'DENVER <09-23-2017>: Recieving Message
    'Public Sub rcvMessages()
    '    Dim lineText As String
    '    Dim i As Integer
    '    Dim arrayTextFile() As String
    '    lineText = rcvdata.ToString
    '    arrayTextFile = Split(lineText, "+CMGL", , CompareMethod.Text)

    '    For i = 3 To UBound(arrayTextFile)
    '        Dim input As String = arrayTextFile(i)
    '        Dim pattern As String = "(:   )|(,"")|("","")|(,)|(" + """)|(OK)"
    '        results = Regex.Split(input, pattern)

    '        con = New MySqlConnection(csstring)
    '        con.Open()
    '        strSQL = "SELECT * FROM tblphonebookall WHERE mnum ='" & results(6) & "'"
    '        cmd = New MySqlCommand(strSQL, con)
    '    dr = cmd.ExecuteReader

    '    While dr.Read
    '        getSection = dr("section")
    '        Dim lv As ListViewItem = lvMessage.Items.Add(getSection)
    '        With lv
    '            If getSection = "Faculty Member" Then
    '                .Remove()
    '            End If
    '            Dim myString As String = results(20)
    '            Dim regex As New Regex(String.Join("|", arrayString), RegexOptions.IgnoreCase)

    '            If regex.IsMatch(myString) Then
    '                .BackColor = Color.Maroon
    '                .ForeColor = Color.Maroon
    '            Else
    '                .SubItems.AddRange(New String() {myString.ToString()})
    '            End If
    '        End With
    '    End While

    '    dr.Close()
    '    cmd.Dispose()
    '    If con.State <> ConnectionState.Open Then
    '        con.Close()
    '    End If
    '    Next
    'End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDate.Text = Format(Now, "MMMM dd, yyyy hhhh:mm:ss")
    End Sub
    Sub photoeventslider1()
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Select * from tbleventphoto where id ='" & "1" & "'"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            If dr.Read Then
                PhotoEvent.ImageLocation = System.AppDomain.CurrentDomain.BaseDirectory & "Photos\" & dr("photos").ToString
            End If
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Sub photoeventslider2()
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Select * from tbleventphoto where id ='" & "2" & "'"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            If dr.Read Then
                PhotoEvent.ImageLocation = System.AppDomain.CurrentDomain.BaseDirectory & "Photos\" & dr("photos").ToString
            End If
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Sub photoeventslider3()
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Select * from tbleventphoto where id ='" & "3" & "'"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            If dr.Read Then
                PhotoEvent.ImageLocation = System.AppDomain.CurrentDomain.BaseDirectory & "Photos\" & dr("photos").ToString
            End If
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Sub photoeventslider4()
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Select * from tbleventphoto where id ='" & "4" & "'"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            If dr.Read Then
                PhotoEvent.ImageLocation = System.AppDomain.CurrentDomain.BaseDirectory & "Photos\" & dr("photos").ToString
            End If
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Sub photoeventslider5()
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Select * from tbleventphoto where id ='" & "5" & "'"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            If dr.Read Then
                PhotoEvent.ImageLocation = System.AppDomain.CurrentDomain.BaseDirectory & "Photos\" & dr("photos").ToString
            End If
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim max As Integer = 5000
        Dim rnd As New Random
        Dim rand As Integer = rnd.Next(10, max + 1)
        Dim i As Integer = 1
        Dim number(max - 1) As Integer
        For i = 0 To max - 1
            If number(i) = rand Then
                rand = rnd.Next(1, max + 1)
                i = -1
            ElseIf number(i) = 0 Then
                number(i) = rand
                rand = rnd.Next(1, max + 1)
                If i = max - 1 Then
                    Exit For
                End If
                i = -1
            End If
        Next
        Timer1.Interval = number(i)
        i += 1
        ChangeImage()
    End Sub

    Private Sub ChangeImage()
        Static Dim iImage1 As Integer
        Select Case iImage1
            Case 0
                PhotoEvent.Visible = True
                Call photoeventslider1()
                iImage1 += 1
            Case 1
                PhotoEvent.Visible = True
                Call photoeventslider2()
                iImage1 += 1
            Case 2
                PhotoEvent.Visible = True
                Call photoeventslider3()
                iImage1 += 1
            Case 3
                PhotoEvent.Visible = True
                Call photoeventslider4()
                iImage1 += 1
            Case 4
                PhotoEvent.Visible = True
                Call photoeventslider5()
                iImage1 = 0
        End Select
    End Sub
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        txtRunningMessage.Left += DistMove
        If txtRunningMessage.Left + txtRunningMessage.Width > Me.ClientRectangle.Width Then
            txtRunningMessage.Left = Me.ClientRectangle.Width - txtRunningMessage.Width
            DistMove = Not DistMove
        ElseIf txtRunningMessage.Left < 0 Then
            txtRunningMessage.Left = 0
            DistMove = Not DistMove
        End If
    End Sub


    'DENVER <09-11-2017>: GetAnnouncement POOL PROBLEM
    Sub Announcement1()
        RunQuery("SELECT * FROM tblnewannouncement WHERE id ='" & "1" & "'")
        If ds.Tables(0).Rows.Count > 0 Then
            txtTitle.Text = ds.Tables(0).Rows(0).Item("title").ToString()
            txtContent.Text = ds.Tables(0).Rows(0).Item("message").ToString()
            txtName.Text = ds.Tables(0).Rows(0).Item("name").ToString()
            txtDate.Text = ds.Tables(0).Rows(0).Item("dateentry").ToString()
            txtAddress.Text = ds.Tables(0).Rows(0).Item("address").ToString()
        End If

        RunQuery("SELECT * FROM tblcoursenotif WHERE id = '" & "1" & "'AND department = '" & "COMPUTER SCIENCE/INFORMATION TECHNOLOGY" & "'")
        If ds.Tables(0).Rows.Count > 0 Then
            txtCSIT.Text = ds.Tables(0).Rows(0).Item("message").ToString()
        End If

        RunQuery("SELECT * FROM tblcoursenotif WHERE id = '" & "1" & "'AND department = '" & "ENGINEERING" & "'")
        If ds.Tables(0).Rows.Count > 0 Then
            txtCSIT.Text = ds.Tables(0).Rows(0).Item("message").ToString()
        End If
    End Sub

    Sub Announcement2()
        RunQuery("SELECT * FROM tblnewannouncement WHERE id ='" & "2" & "'")
        If ds.Tables(0).Rows.Count > 0 Then
            txtTitle.Text = ds.Tables(0).Rows(0).Item("title").ToString()
            txtContent.Text = ds.Tables(0).Rows(0).Item("message").ToString()
            txtName.Text = ds.Tables(0).Rows(0).Item("name").ToString()
            txtDate.Text = ds.Tables(0).Rows(0).Item("dateentry").ToString()
            txtAddress.Text = ds.Tables(0).Rows(0).Item("address").ToString()
        End If

        RunQuery("SELECT * FROM tblcoursenotif WHERE id = '" & "2" & "'AND department = '" & "COMPUTER SCIENCE/INFORMATION TECHNOLOGY" & "'")
        If ds.Tables(0).Rows.Count > 0 Then
            txtCSIT.Text = ds.Tables(0).Rows(0).Item("message").ToString()
        End If

        RunQuery("SELECT * FROM tblcoursenotif WHERE id = '" & "2" & "'AND department = '" & "ENGINEERING" & "'")
        If ds.Tables(0).Rows.Count > 0 Then
            txtCSIT.Text = ds.Tables(0).Rows(0).Item("message").ToString()
        End If

    End Sub

    Sub Announcement3()
        RunQuery("SELECT * FROM tblnewannouncement WHERE id ='" & "3" & "'")
        If ds.Tables(0).Rows.Count > 0 Then
            txtTitle.Text = ds.Tables(0).Rows(0).Item("title").ToString()
            txtContent.Text = ds.Tables(0).Rows(0).Item("message").ToString()
            txtName.Text = ds.Tables(0).Rows(0).Item("name").ToString()
            txtDate.Text = ds.Tables(0).Rows(0).Item("dateentry").ToString()
            txtAddress.Text = ds.Tables(0).Rows(0).Item("address").ToString()
        End If

        RunQuery("SELECT * FROM tblcoursenotif WHERE id = '" & "3" & "'AND department = '" & "COMPUTER SCIENCE/INFORMATION TECHNOLOGY" & "'")
        If ds.Tables(0).Rows.Count > 0 Then
            txtCSIT.Text = ds.Tables(0).Rows(0).Item("message").ToString()
        End If

        RunQuery("SELECT * FROM tblcoursenotif WHERE id = '" & "3" & "'AND department = '" & "ENGINEERING" & "'")
        If ds.Tables(0).Rows.Count > 0 Then
            txtCSIT.Text = ds.Tables(0).Rows(0).Item("message").ToString()
        End If

    End Sub
    Sub Announcement4()
        RunQuery("SELECT * FROM tblnewannouncement WHERE id ='" & "4" & "'")
        If ds.Tables(0).Rows.Count > 0 Then
            txtTitle.Text = ds.Tables(0).Rows(0).Item("title").ToString()
            txtContent.Text = ds.Tables(0).Rows(0).Item("message").ToString()
            txtName.Text = ds.Tables(0).Rows(0).Item("name").ToString()
            txtDate.Text = ds.Tables(0).Rows(0).Item("dateentry").ToString()
            txtAddress.Text = ds.Tables(0).Rows(0).Item("address").ToString()
        End If
    End Sub

    Sub Announcement5()
        RunQuery("SELECT * FROM tblnewannouncement WHERE id ='" & "5" & "'")
        If ds.Tables(0).Rows.Count > 0 Then
            txtTitle.Text = ds.Tables(0).Rows(0).Item("title").ToString()
            txtContent.Text = ds.Tables(0).Rows(0).Item("message").ToString()
            txtName.Text = ds.Tables(0).Rows(0).Item("name").ToString()
            txtDate.Text = ds.Tables(0).Rows(0).Item("dateentry").ToString()
            txtAddress.Text = ds.Tables(0).Rows(0).Item("address").ToString()
        End If
    End Sub

    Sub Announcement6()
        RunQuery("SELECT * FROM tblnewannouncement WHERE id ='" & "6" & "'")
        If ds.Tables(0).Rows.Count > 0 Then
            txtTitle.Text = ds.Tables(0).Rows(0).Item("title").ToString()
            txtContent.Text = ds.Tables(0).Rows(0).Item("message").ToString()
            txtName.Text = ds.Tables(0).Rows(0).Item("name").ToString()
            txtDate.Text = ds.Tables(0).Rows(0).Item("dateentry").ToString()
            txtAddress.Text = ds.Tables(0).Rows(0).Item("address").ToString()
        End If
    End Sub

    Sub Announcement7()
        RunQuery("SELECT * FROM tblnewannouncement WHERE id ='" & "7" & "'")
        If ds.Tables(0).Rows.Count > 0 Then
            txtTitle.Text = ds.Tables(0).Rows(0).Item("title").ToString()
            txtContent.Text = ds.Tables(0).Rows(0).Item("message").ToString()
            txtName.Text = ds.Tables(0).Rows(0).Item("name").ToString()
            txtDate.Text = ds.Tables(0).Rows(0).Item("dateentry").ToString()
            txtAddress.Text = ds.Tables(0).Rows(0).Item("address").ToString()
        End If
    End Sub

    Sub Announcement8()
        RunQuery("SELECT * FROM tblnewannouncement WHERE id ='" & "8" & "'")
        If ds.Tables(0).Rows.Count > 0 Then
            txtTitle.Text = ds.Tables(0).Rows(0).Item("title").ToString()
            txtContent.Text = ds.Tables(0).Rows(0).Item("message").ToString()
            txtName.Text = ds.Tables(0).Rows(0).Item("name").ToString()
            txtDate.Text = ds.Tables(0).Rows(0).Item("dateentry").ToString()
            txtAddress.Text = ds.Tables(0).Rows(0).Item("address").ToString()
        End If
    End Sub

    Sub Announcement9()
        RunQuery("SELECT * FROM tblnewannouncement WHERE id ='" & "9" & "'")
        If ds.Tables(0).Rows.Count > 0 Then
            txtTitle.Text = ds.Tables(0).Rows(0).Item("title").ToString()
            txtContent.Text = ds.Tables(0).Rows(0).Item("message").ToString()
            txtName.Text = ds.Tables(0).Rows(0).Item("name").ToString()
            txtDate.Text = ds.Tables(0).Rows(0).Item("dateentry").ToString()
            txtAddress.Text = ds.Tables(0).Rows(0).Item("address").ToString()
        End If
    End Sub

    Sub Announcement10()
        RunQuery("SELECT * FROM tblnewannouncement WHERE id ='" & "10" & "'")
        If ds.Tables(0).Rows.Count > 0 Then
            txtTitle.Text = ds.Tables(0).Rows(0).Item("title").ToString()
            txtContent.Text = ds.Tables(0).Rows(0).Item("message").ToString()
            txtName.Text = ds.Tables(0).Rows(0).Item("name").ToString()
            txtDate.Text = ds.Tables(0).Rows(0).Item("dateentry").ToString()
            txtAddress.Text = ds.Tables(0).Rows(0).Item("address").ToString()
        End If
    End Sub


    Private Sub ChangeAnnouncement()
        Static Dim iAnnounce As Integer
        Select Case iAnnounce
            Case 0
                RunQuery("SELECT * FROM tblnewannouncement WHERE id ='" & "1" & "'")
                If ds.Tables(0).Rows.Count > 0 Then
                    txtTitle.Text = ds.Tables(0).Rows(0).Item("title").ToString()
                    txtContent.Text = ds.Tables(0).Rows(0).Item("message").ToString()
                    txtName.Text = ds.Tables(0).Rows(0).Item("name").ToString()
                    txtDate.Text = ds.Tables(0).Rows(0).Item("dateentry").ToString()
                    txtAddress.Text = ds.Tables(0).Rows(0).Item("address").ToString()
                End If

                RunQuery("SELECT * FROM tblnotifcourse WHERE id = '" & "1" & "'AND department = '" & "COMPUTER SCIENCE/INFORMATION TECHNOLOGY" & "'")
                If ds.Tables(0).Rows.Count > 0 Then
                    txtCSIT.Text = ds.Tables(0).Rows(0).Item("message").ToString()
                End If

                RunQuery("SELECT * FROM tblnotifcourse WHERE id = '" & "1" & "'AND department = '" & "ENGINEERING" & "'")
                If ds.Tables(0).Rows.Count > 0 Then
                    txtEngineering.Text = ds.Tables(0).Rows(0).Item("message").ToString()
                End If

                iAnnounce += 1
            Case 1
                RunQuery("SELECT * FROM tblnewannouncement WHERE id ='" & "2" & "'")
                If ds.Tables(0).Rows.Count > 0 Then
                    txtTitle.Text = ds.Tables(0).Rows(0).Item("title").ToString()
                    txtContent.Text = ds.Tables(0).Rows(0).Item("message").ToString()
                    txtName.Text = ds.Tables(0).Rows(0).Item("name").ToString()
                    txtDate.Text = ds.Tables(0).Rows(0).Item("dateentry").ToString()
                    txtAddress.Text = ds.Tables(0).Rows(0).Item("address").ToString()
                End If


                RunQuery("SELECT * FROM tblnotifcourse WHERE id = '" & "2" & "'AND department = '" & "COMPUTER SCIENCE/INFORMATION TECHNOLOGY" & "'")
                If ds.Tables(0).Rows.Count > 0 Then
                    txtCSIT.Text = ds.Tables(0).Rows(0).Item("message").ToString()
                End If

                RunQuery("SELECT * FROM tblnotifcourse WHERE id = '" & "2" & "'AND department = '" & "ENGINEERING" & "'")
                If ds.Tables(0).Rows.Count > 0 Then
                    txtEngineering.Text = ds.Tables(0).Rows(0).Item("message").ToString()
                End If

                iAnnounce += 1
            Case 2
                RunQuery("SELECT * FROM tblnewannouncement WHERE id ='" & "3" & "'")
                If ds.Tables(0).Rows.Count > 0 Then
                    txtTitle.Text = ds.Tables(0).Rows(0).Item("title").ToString()
                    txtContent.Text = ds.Tables(0).Rows(0).Item("message").ToString()
                    txtName.Text = ds.Tables(0).Rows(0).Item("name").ToString()
                    txtDate.Text = ds.Tables(0).Rows(0).Item("dateentry").ToString()
                    txtAddress.Text = ds.Tables(0).Rows(0).Item("address").ToString()
                End If


                RunQuery("SELECT * FROM tblnotifcourse WHERE id = '" & "3" & "'AND department = '" & "COMPUTER SCIENCE/INFORMATION TECHNOLOGY" & "'")
                If ds.Tables(0).Rows.Count > 0 Then
                    txtCSIT.Text = ds.Tables(0).Rows(0).Item("message").ToString()
                End If

                RunQuery("SELECT * FROM tblnotifcourse WHERE id = '" & "3" & "'AND department = '" & "ENGINEERING" & "'")
                If ds.Tables(0).Rows.Count > 0 Then
                    txtEngineering.Text = ds.Tables(0).Rows(0).Item("message").ToString()
                End If

                iAnnounce += 1
            Case 3
                RunQuery("SELECT * FROM tblnewannouncement WHERE id ='" & "4" & "'")
                If ds.Tables(0).Rows.Count > 0 Then
                    txtTitle.Text = ds.Tables(0).Rows(0).Item("title").ToString()
                    txtContent.Text = ds.Tables(0).Rows(0).Item("message").ToString()
                    txtName.Text = ds.Tables(0).Rows(0).Item("name").ToString()
                    txtDate.Text = ds.Tables(0).Rows(0).Item("dateentry").ToString()
                    txtAddress.Text = ds.Tables(0).Rows(0).Item("address").ToString()
                End If

                RunQuery("SELECT * FROM tblnotifcourse WHERE id = '" & "4" & "'AND department = '" & "COMPUTER SCIENCE/INFORMATION TECHNOLOGY" & "'")
                If ds.Tables(0).Rows.Count > 0 Then
                    txtCSIT.Text = ds.Tables(0).Rows(0).Item("message").ToString()
                End If

                RunQuery("SELECT * FROM tblnotifcourse WHERE id = '" & "4" & "'AND department = '" & "ENGINEERING" & "'")
                If ds.Tables(0).Rows.Count > 0 Then
                    txtEngineering.Text = ds.Tables(0).Rows(0).Item("message").ToString()
                End If


                iAnnounce += 1
            Case 4
                RunQuery("SELECT * FROM tblnewannouncement WHERE id ='" & "5" & "'")
                If ds.Tables(0).Rows.Count > 0 Then
                    txtTitle.Text = ds.Tables(0).Rows(0).Item("title").ToString()
                    txtContent.Text = ds.Tables(0).Rows(0).Item("message").ToString()
                    txtName.Text = ds.Tables(0).Rows(0).Item("name").ToString()
                    txtDate.Text = ds.Tables(0).Rows(0).Item("dateentry").ToString()
                    txtAddress.Text = ds.Tables(0).Rows(0).Item("address").ToString()
                End If


                RunQuery("SELECT * FROM tblnotifcourse WHERE id = '" & "5" & "'AND department = '" & "COMPUTER SCIENCE/INFORMATION TECHNOLOGY" & "'")
                If ds.Tables(0).Rows.Count > 0 Then
                    txtCSIT.Text = ds.Tables(0).Rows(0).Item("message").ToString()
                End If

                RunQuery("SELECT * FROM tblnotifcourse WHERE id = '" & "5" & "'AND department = '" & "ENGINEERING" & "'")
                If ds.Tables(0).Rows.Count > 0 Then
                    txtEngineering.Text = ds.Tables(0).Rows(0).Item("message").ToString()
                End If

                iAnnounce += 1
            Case 5
                RunQuery("SELECT * FROM tblnewannouncement WHERE id ='" & "6" & "'")
                If ds.Tables(0).Rows.Count > 0 Then
                    txtTitle.Text = ds.Tables(0).Rows(0).Item("title").ToString()
                    txtContent.Text = ds.Tables(0).Rows(0).Item("message").ToString()
                    txtName.Text = ds.Tables(0).Rows(0).Item("name").ToString()
                    txtDate.Text = ds.Tables(0).Rows(0).Item("dateentry").ToString()
                    txtAddress.Text = ds.Tables(0).Rows(0).Item("address").ToString()
                End If


                RunQuery("SELECT * FROM tblnotifcourse WHERE id = '" & "6" & "'AND department = '" & "COMPUTER SCIENCE/INFORMATION TECHNOLOGY" & "'")
                If ds.Tables(0).Rows.Count > 0 Then
                    txtCSIT.Text = ds.Tables(0).Rows(0).Item("message").ToString()
                End If

                RunQuery("SELECT * FROM tblnotifcourse WHERE id = '" & "6" & "'AND department = '" & "ENGINEERING" & "'")
                If ds.Tables(0).Rows.Count > 0 Then
                    txtEngineering.Text = ds.Tables(0).Rows(0).Item("message").ToString()
                End If

                iAnnounce += 1
            Case 6
                RunQuery("SELECT * FROM tblnewannouncement WHERE id ='" & "7" & "'")
                If ds.Tables(0).Rows.Count > 0 Then
                    txtTitle.Text = ds.Tables(0).Rows(0).Item("title").ToString()
                    txtContent.Text = ds.Tables(0).Rows(0).Item("message").ToString()
                    txtName.Text = ds.Tables(0).Rows(0).Item("name").ToString()
                    txtDate.Text = ds.Tables(0).Rows(0).Item("dateentry").ToString()
                    txtAddress.Text = ds.Tables(0).Rows(0).Item("address").ToString()
                End If

                RunQuery("SELECT * FROM tblnotifcourse WHERE id = '" & "7" & "'AND department = '" & "COMPUTER SCIENCE/INFORMATION TECHNOLOGY" & "'")
                If ds.Tables(0).Rows.Count > 0 Then
                    txtCSIT.Text = ds.Tables(0).Rows(0).Item("message").ToString()
                End If

                RunQuery("SELECT * FROM tblnotifcourse WHERE id = '" & "7" & "'AND department = '" & "ENGINEERING" & "'")
                If ds.Tables(0).Rows.Count > 0 Then
                    txtEngineering.Text = ds.Tables(0).Rows(0).Item("message").ToString()
                End If

                iAnnounce += 1
            Case 7
                RunQuery("SELECT * FROM tblnewannouncement WHERE id ='" & "8" & "'")
                If ds.Tables(0).Rows.Count > 0 Then
                    txtTitle.Text = ds.Tables(0).Rows(0).Item("title").ToString()
                    txtContent.Text = ds.Tables(0).Rows(0).Item("message").ToString()
                    txtName.Text = ds.Tables(0).Rows(0).Item("name").ToString()
                    txtDate.Text = ds.Tables(0).Rows(0).Item("dateentry").ToString()
                    txtAddress.Text = ds.Tables(0).Rows(0).Item("address").ToString()
                End If

                RunQuery("SELECT * FROM tblnotifcourse WHERE id = '" & "8" & "'AND department = '" & "COMPUTER SCIENCE/INFORMATION TECHNOLOGY" & "'")
                If ds.Tables(0).Rows.Count > 0 Then
                    txtCSIT.Text = ds.Tables(0).Rows(0).Item("message").ToString()
                End If

                RunQuery("SELECT * FROM tblnotifcourse WHERE id = '" & "8" & "'AND department = '" & "ENGINEERING" & "'")
                If ds.Tables(0).Rows.Count > 0 Then
                    txtEngineering.Text = ds.Tables(0).Rows(0).Item("message").ToString()
                End If

                iAnnounce += 1
            Case 8
                RunQuery("SELECT * FROM tblnewannouncement WHERE id ='" & "9" & "'")
                If ds.Tables(0).Rows.Count > 0 Then
                    txtTitle.Text = ds.Tables(0).Rows(0).Item("title").ToString()
                    txtContent.Text = ds.Tables(0).Rows(0).Item("message").ToString()
                    txtName.Text = ds.Tables(0).Rows(0).Item("name").ToString()
                    txtDate.Text = ds.Tables(0).Rows(0).Item("dateentry").ToString()
                    txtAddress.Text = ds.Tables(0).Rows(0).Item("address").ToString()
                End If

                RunQuery("SELECT * FROM tblnotifcourse WHERE id = '" & "9" & "'AND department = '" & "COMPUTER SCIENCE/INFORMATION TECHNOLOGY" & "'")
                If ds.Tables(0).Rows.Count > 0 Then
                    txtCSIT.Text = ds.Tables(0).Rows(0).Item("message").ToString()
                End If

                RunQuery("SELECT * FROM tblnotifcourse WHERE id = '" & "9" & "'AND department = '" & "ENGINEERING" & "'")
                If ds.Tables(0).Rows.Count > 0 Then
                    txtEngineering.Text = ds.Tables(0).Rows(0).Item("message").ToString()
                End If

                iAnnounce += 1
            Case 9
                RunQuery("SELECT * FROM tblnewannouncement WHERE id ='" & "10" & "'")
                If ds.Tables(0).Rows.Count > 0 Then
                    txtTitle.Text = ds.Tables(0).Rows(0).Item("title").ToString()
                    txtContent.Text = ds.Tables(0).Rows(0).Item("message").ToString()
                    txtName.Text = ds.Tables(0).Rows(0).Item("name").ToString()
                    txtDate.Text = ds.Tables(0).Rows(0).Item("dateentry").ToString()
                    txtAddress.Text = ds.Tables(0).Rows(0).Item("address").ToString()
                End If

                RunQuery("SELECT * FROM tblnotifcourse WHERE id = '" & "10" & "'AND department = '" & "COMPUTER SCIENCE/INFORMATION TECHNOLOGY" & "'")
                If ds.Tables(0).Rows.Count > 0 Then
                    txtCSIT.Text = ds.Tables(0).Rows(0).Item("message").ToString()
                End If

                RunQuery("SELECT * FROM tblnotifcourse WHERE id = '" & "10" & "'AND department = '" & "ENGINEERING" & "'")
                If ds.Tables(0).Rows.Count > 0 Then
                    txtEngineering.Text = ds.Tables(0).Rows(0).Item("message").ToString()
                End If

                iAnnounce = 0
        End Select
    End Sub

    ''<Denver><10-29-2017><Add New announcement>
    'Private Sub ChangeAnnouncement2()
    '    Static Dim iAnnounce2 As Integer
    '    Select Case iAnnounce2
    '        Case 0
    '            Call Announcement11()
    '            iAnnounce2 += 1
    '        Case 1
    '            Call Announcement12()
    '            iAnnounce2 += 1
    '        Case 2
    '            Call Announcement13()
    '            iAnnounce2 += 1
    '        Case 3
    '            Call Announcement14()
    '            iAnnounce2 += 1
    '        Case 4
    '            Call Announcement15()
    '            iAnnounce2 += 1
    '        Case 5
    '            Call Announcement16()
    '            iAnnounce2 += 1
    '        Case 6
    '            Call Announcement17()
    '            iAnnounce2 += 1
    '        Case 7
    '            Call Announcement18()
    '            iAnnounce2 += 1
    '        Case 8
    '            Call Announcement19()
    '            iAnnounce2 += 1
    '        Case 9
    '            Call Announcement20()
    '            iAnnounce2 = 0

    '    End Select
    'End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Dim max As Integer = 5000
        Dim rnd As New Random
        Dim rand As Integer = rnd.Next(10, max + 1)
        Dim i As Integer = 1
        Dim number(max - 1) As Integer
        For i = 0 To max - 1
            If number(i) = rand Then
                rand = rnd.Next(1, max + 1)
                i = -1
            ElseIf number(i) = 0 Then
                number(i) = rand
                rand = rnd.Next(1, max + 1)
                If i = max - 1 Then
                    Exit For
                End If
                i = -1
            End If
        Next
        Timer4.Interval = number(i)
        i += 1
        Call ChangeAnnouncement()
    End Sub

    'Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
    '    Dim max As Integer = 15000
    '    Dim rnd As New Random
    '    Dim rand As Integer = rnd.Next(10, max + 1)
    '    Dim i As Integer = 1
    '    Dim number(max - 1) As Integer
    '    For i = 0 To max - 1
    '        If number(i) = rand Then
    '            rand = rnd.Next(1, max + 1)
    '            i = -1
    '        ElseIf number(i) = 0 Then
    '            number(i) = rand
    '            rand = rnd.Next(1, max + 1)
    '            If i = max - 1 Then
    '                Exit For
    '            End If
    '            i = -1
    '        End If
    '    Next
    '    Timer5.Interval = number(i)
    '    i += 1
    '    Call ChangeAnnouncement2()
    'End Sub

    '<DENVER><10-29-2017><Implementation of truncate records every 24 hours>
    Private Sub truncateRecords()
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "DELETE FROM tblnewannouncement WHERE dateentry < NOW()"
            cmd = New MySqlCommand(strSQL, con)
            cmd.ExecuteNonQuery()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub loadFeedBack()
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "SELECT * FROM tblfeedback LIMIT 7"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            lvMessage.Items.Clear()
            While dr.Read
                Dim lv As ListViewItem = lvMessage.Items.Add(dr("id").ToString())
                lv.SubItems.Add(dr("section").ToString())
                lv.SubItems.Add(dr("message").ToString())
            End While
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        Call truncateRecords()
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        Call loadFeedBack()
    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        'Me.Hide()
        'frmAnnouncement_Pic.Show()
    End Sub
End Class