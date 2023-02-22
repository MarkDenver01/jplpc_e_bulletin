Imports MySql.Data.MySqlClient
Public Class frmAnnouncementCenter
    Dim csstring As String = "server=localhost;uid=root;pwd=admin;database=ebulletindb;"
    Private Sub frmAnnouncementCenter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 10000
        Timer1.Start()
        Timer3.Enabled = True
        Timer2.Start()
    End Sub

    Private i As Integer = 1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim fileName As String = System.AppDomain.CurrentDomain.BaseDirectory & "Photos\" & i.ToString() & ".png"
        Try
            Me.BackgroundImage = Image.FromFile(fileName)
            Me.BackgroundImageLayout = ImageLayout.Stretch
            i += 1
            If (i > 3) Then
                i = 1
                If i = 3 Then
                    i = 1
                End If
            End If
        Catch ex As Exception
            Debug.Print(fileName)
            MsgBox(fileName & vbCrLf & vbCrLf & ex.ToString, "Error Image Loading")
        End Try
    End Sub

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

    Sub Announcement1()
        RunQuery("SELECT * FROM tblpost2 WHERE id ='" & "1" & "'")
        If ds.Tables(0).Rows.Count > 0 Then
            txtA1.Text = ds.Tables(0).Rows(0).Item("msg1").ToString()
            txtPosition.Text = ds.Tables(0).Rows(0).Item("status").ToString()
        End If
    End Sub

    Sub Announcement2()
        RunQuery("SELECT * FROM tblpost2 WHERE id ='" & "2" & "'")
        If ds.Tables(0).Rows.Count > 0 Then
            txtA1.Text = ds.Tables(0).Rows(0).Item("msg1").ToString()
            txtPosition.Text = ds.Tables(0).Rows(0).Item("status").ToString()
        End If
    End Sub

    Sub Announcement3()
        RunQuery("SELECT * FROM tblpost2 WHERE id ='" & "3" & "'")
        If ds.Tables(0).Rows.Count > 0 Then
            txtA1.Text = ds.Tables(0).Rows(0).Item("msg1").ToString()
            txtPosition.Text = ds.Tables(0).Rows(0).Item("status").ToString()
        End If
    End Sub

    Sub Announcement4()
        RunQuery("SELECT * FROM tblpost2 WHERE id ='" & "4" & "'")
        If ds.Tables(0).Rows.Count > 0 Then
            txtA1.Text = ds.Tables(0).Rows(0).Item("msg1").ToString()
            txtPosition.Text = ds.Tables(0).Rows(0).Item("status").ToString()
        End If
    End Sub

    Sub Announcement5()
        RunQuery("SELECT * FROM tblpost2 WHERE id ='" & "5" & "'")
        If ds.Tables(0).Rows.Count > 0 Then
            txtA1.Text = ds.Tables(0).Rows(0).Item("msg1").ToString()
            txtPosition.Text = ds.Tables(0).Rows(0).Item("status").ToString()
        End If
    End Sub

    Private Sub ChangeAnnouncement()
        Static Dim iAnnounce As Integer
        Select Case iAnnounce
            Case 0
                Announcement1()
                iAnnounce += 1
            Case 1
                Announcement2()
                iAnnounce += 1
            Case 2
                Announcement3()
                iAnnounce += 1
            Case 3
                Announcement4()
                iAnnounce += 1
            Case 4
                Announcement5()

                iAnnounce += 1
        End Select
    End Sub

    Sub loadPosition()
        con = New MySqlConnection(csstring)
        con.Open()
        strSQL = "SELECT * FROM tblPositionCenter WHERE status ='" & txtPosition.Text & "'"
        cmd = New MySqlCommand(strSQL, con)
        dr = cmd.ExecuteReader
        If dr.Read Then
            txtA1.Location = New Point(dr("posX"), dr("posY"))
        End If
        dr.Close()
        cmd.Dispose()
        If con.State <> ConnectionState.Open Then
            con.Close()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim max As Integer = 10000
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
        Timer2.Interval = number(i)
        i += 1
        Call ChangeAnnouncement()
        Call BirthdayRecords()
        Call loadPosition()
    End Sub
    Dim RanNum As New Random
    Dim DistMove As Integer = 10
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        txtRunningMessage.Left += DistMove

        If txtRunningMessage.Left + txtRunningMessage.Width > Me.ClientRectangle.Width Then
            txtRunningMessage.Left = Me.ClientRectangle.Width - txtRunningMessage.Width
            DistMove = Not DistMove
        ElseIf txtRunningMessage.Left < 0 Then
            txtRunningMessage.Left = 0
            DistMove = Not DistMove
        End If

        Label4.Left += DistMove
        If Label4.Left + Label4.Width > Me.ClientRectangle.Width Then
            Label4.Left = Me.ClientRectangle.Width - Label4.Width
            DistMove = Not DistMove
        ElseIf Label4.Left < 0 Then
            Label4.Left = 0
            DistMove = Not DistMove
        End If
        txtName.Left += DistMove
        If txtName.Left + txtName.Width > Me.ClientRectangle.Width Then
            txtName.Left = Me.ClientRectangle.Width - txtName.Width
            DistMove = Not DistMove
        ElseIf txtName.Left < 0 Then
            txtName.Left = 0
            DistMove = Not DistMove
        End If

    End Sub

    Private Sub BirthdayRecords()
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "SELECT * FROM tblbirthday WHERE dateofbirth < NOW()"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            If dr.Read Then
                txtName.Text = dr("name")
            End If
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

End Class