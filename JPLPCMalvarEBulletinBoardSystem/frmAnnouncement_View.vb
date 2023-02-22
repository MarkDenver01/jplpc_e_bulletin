Imports MySql.Data.MySqlClient
Imports System.IO.Ports
Imports System.Threading
Imports System.Management
Imports System.Text.RegularExpressions
Imports System.IO
Imports System.Linq
Public Class frmAnnouncement_View
    Dim csstring As String = "server=localhost;uid=root;pwd=admin;database=ebulletindb;"

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
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
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
        Call ChangeAnnouncement()
        Call BirthdayRecords()
    End Sub

    Private Sub frmAnnouncement_View_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer3.Enabled = True
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

    Sub Announcement1()
        RunQuery("SELECT * FROM tblpost1 WHERE id ='" & "1" & "'")
        If ds.Tables(0).Rows.Count > 0 Then
            txtA1.Text = ds.Tables(0).Rows(0).Item("msg1").ToString()
            txtA2.Text = ds.Tables(0).Rows(0).Item("msg2").ToString()
            txtA3.Text = ds.Tables(0).Rows(0).Item("msg3").ToString()
            txtA4.Text = ds.Tables(0).Rows(0).Item("msg4").ToString()
            txtA5.Text = ds.Tables(0).Rows(0).Item("msg5").ToString()
        End If
    End Sub

    Sub Announcement2()
        RunQuery("SELECT * FROM tblpost1 WHERE id ='" & "2" & "'")
        If ds.Tables(0).Rows.Count > 0 Then
            txtA1.Text = ds.Tables(0).Rows(0).Item("msg1").ToString()
            txtA2.Text = ds.Tables(0).Rows(0).Item("msg2").ToString()
            txtA3.Text = ds.Tables(0).Rows(0).Item("msg3").ToString()
            txtA4.Text = ds.Tables(0).Rows(0).Item("msg4").ToString()
            txtA5.Text = ds.Tables(0).Rows(0).Item("msg5").ToString()
        End If
    End Sub

    Sub Announcement3()
        RunQuery("SELECT * FROM tblpost1 WHERE id ='" & "3" & "'")
        If ds.Tables(0).Rows.Count > 0 Then
            txtA1.Text = ds.Tables(0).Rows(0).Item("msg1").ToString()
            txtA2.Text = ds.Tables(0).Rows(0).Item("msg2").ToString()
            txtA3.Text = ds.Tables(0).Rows(0).Item("msg3").ToString()
            txtA4.Text = ds.Tables(0).Rows(0).Item("msg4").ToString()
            txtA5.Text = ds.Tables(0).Rows(0).Item("msg5").ToString()
        End If
    End Sub

    Sub Announcement4()
        RunQuery("SELECT * FROM tblpost1 WHERE id ='" & "4" & "'")
        If ds.Tables(0).Rows.Count > 0 Then
            txtA1.Text = ds.Tables(0).Rows(0).Item("msg1").ToString()
            txtA2.Text = ds.Tables(0).Rows(0).Item("msg2").ToString()
            txtA3.Text = ds.Tables(0).Rows(0).Item("msg3").ToString()
            txtA4.Text = ds.Tables(0).Rows(0).Item("msg4").ToString()
            txtA5.Text = ds.Tables(0).Rows(0).Item("msg5").ToString()
        End If
    End Sub

    Sub Announcement5()
        RunQuery("SELECT * FROM tblpost1 WHERE id ='" & "5" & "'")
        If ds.Tables(0).Rows.Count > 0 Then
            txtA1.Text = ds.Tables(0).Rows(0).Item("msg1").ToString()
            txtA2.Text = ds.Tables(0).Rows(0).Item("msg2").ToString()
            txtA3.Text = ds.Tables(0).Rows(0).Item("msg3").ToString()
            txtA4.Text = ds.Tables(0).Rows(0).Item("msg4").ToString()
            txtA5.Text = ds.Tables(0).Rows(0).Item("msg5").ToString()
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



End Class