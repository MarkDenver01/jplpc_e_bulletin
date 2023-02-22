Imports MySql.Data.MySqlClient
Public Class frmPreview
    Dim csstring As String = "server=localhost;uid=root;pwd=admin;database=ebulletindb;"
    Dim starttime, endtime
    Dim fulltime As String
    Dim RanNum As New Random
    Dim DistMove As Integer = 10
    Dim TimerCount As Integer = 30
    Private Sub frmPreview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        'Blinking Running Message
        Timer2.Enabled = True
        Timer2.Interval = 5000
        Timer3.Enabled = True
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDate.Text = Format(Now, "MMMM dd, yyyy hhhh:mm:ss")
    End Sub
    Sub ITRECORDS1()
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Select section, roomno, starttime, endtime, subjects, days from tblschedule where section='" & "IT-111" & "'order by days asc"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            lvIT111.Items.Clear()
            While dr.Read
                Section1.Text = dr("section")
                lblIT1.Text = dr("roomno")
                starttime = dr("starttime")
                endtime = dr("endtime")
                fulltime = starttime & " - " & endtime
                Dim lv As ListViewItem = lvIT111.Items.Add(fulltime)
                lv.SubItems.Add(dr("subjects").ToString())
                lv.SubItems.Add(dr("days"))
            End While
            For Each lvi As ListViewItem In lvIT111.Items
                If lvi.SubItems(2).Text.ToLower = "1" Then
                    lvi.BackColor = Color.DarkOrchid
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "2" Then
                    lvi.BackColor = Color.DodgerBlue
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "3" Then
                    lvi.BackColor = Color.DarkGreen
                    lvi.ForeColor = Color.White
                End If
            Next
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Select section, roomno, starttime, endtime, subjects, days from tblschedule where section='" & "IT-112" & "'order by days asc"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            lvIT112.Items.Clear()
            While dr.Read
                Section2.Text = dr("section")
                lblIT2.Text = dr("roomno")
                starttime = dr("starttime")
                endtime = dr("endtime")
                fulltime = starttime & " - " & endtime
                Dim lv As ListViewItem = lvIT112.Items.Add(fulltime)
                lv.SubItems.Add(dr("subjects").ToString())
                lv.SubItems.Add(dr("days"))
            End While
            For Each lvi As ListViewItem In lvIT112.Items
                If lvi.SubItems(2).Text.ToLower = "1" Then
                    lvi.BackColor = Color.DarkOrchid
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "2" Then
                    lvi.BackColor = Color.DodgerBlue
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "3" Then
                    lvi.BackColor = Color.DarkGreen
                    lvi.ForeColor = Color.White
                End If
            Next
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Select section, roomno, starttime, endtime, subjects, days from tblschedule where section='" & "IT-113" & "'order by days asc"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            lvIT113.Items.Clear()
            While dr.Read
                Section3.Text = dr("section")
                lblIT3.Text = dr("roomno")
                starttime = dr("starttime")
                endtime = dr("endtime")
                fulltime = starttime & " - " & endtime
                Dim lv As ListViewItem = lvIT113.Items.Add(fulltime)
                lv.SubItems.Add(dr("subjects").ToString())
                lv.SubItems.Add(dr("days"))
            End While
            For Each lvi As ListViewItem In lvIT113.Items
                If lvi.SubItems(2).Text.ToLower = "1" Then
                    lvi.BackColor = Color.DarkOrchid
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "2" Then
                    lvi.BackColor = Color.DodgerBlue
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "3" Then
                    lvi.BackColor = Color.DarkGreen
                    lvi.ForeColor = Color.White
                End If
            Next
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Select section, roomno, starttime, endtime, subjects, days from tblschedule where section='" & "IT-114" & "'order by days asc"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            lvIT114.Items.Clear()
            While dr.Read
                Section4.Text = dr("section")
                lblIT4.Text = dr("roomno")
                starttime = dr("starttime")
                endtime = dr("endtime")
                fulltime = starttime & " - " & endtime
                Dim lv As ListViewItem = lvIT114.Items.Add(fulltime)
                lv.SubItems.Add(dr("subjects").ToString())
                lv.SubItems.Add(dr("days"))
            End While
            For Each lvi As ListViewItem In lvIT114.Items
                If lvi.SubItems(2).Text.ToLower = "1" Then
                    lvi.BackColor = Color.DarkOrchid
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "2" Then
                    lvi.BackColor = Color.DodgerBlue
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "3" Then
                    lvi.BackColor = Color.DarkGreen
                    lvi.ForeColor = Color.White
                End If
            Next
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Select section, roomno, starttime, endtime, subjects, days from tblschedule where section='" & "IT-115" & "'order by days asc"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            lvIT115.Items.Clear()
            While dr.Read
                Section5.Text = dr("section")
                lblIT5.Text = dr("roomno")
                starttime = dr("starttime")
                endtime = dr("endtime")
                fulltime = starttime & " - " & endtime
                Dim lv As ListViewItem = lvIT115.Items.Add(fulltime)
                lv.SubItems.Add(dr("subjects").ToString())
                lv.SubItems.Add(dr("days"))
            End While
            For Each lvi As ListViewItem In lvIT115.Items
                If lvi.SubItems(2).Text.ToLower = "1" Then
                    lvi.BackColor = Color.DarkOrchid
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "2" Then
                    lvi.BackColor = Color.DodgerBlue
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "3" Then
                    lvi.BackColor = Color.DarkGreen
                    lvi.ForeColor = Color.White
                End If
            Next
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Select section, roomno, starttime, endtime, subjects, days from tblschedule where section='" & "IT-116" & "'order by days asc"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            lvIT116.Items.Clear()
            While dr.Read
                Section6.Text = dr("section")
                lblIT6.Text = dr("roomno")
                starttime = dr("starttime")
                endtime = dr("endtime")
                fulltime = starttime & " - " & endtime
                Dim lv As ListViewItem = lvIT116.Items.Add(fulltime)
                lv.SubItems.Add(dr("subjects").ToString())
                lv.SubItems.Add(dr("days"))
            End While
            For Each lvi As ListViewItem In lvIT116.Items
                If lvi.SubItems(2).Text.ToLower = "1" Then
                    lvi.BackColor = Color.DarkOrchid
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "2" Then
                    lvi.BackColor = Color.DodgerBlue
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "3" Then
                    lvi.BackColor = Color.DarkGreen
                    lvi.ForeColor = Color.White
                End If
            Next
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Sub ITRECORDS2()
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "select section, roomno, starttime, endtime, subjects, days from tblschedule where section='" & "IT-117" & "'order by days asc"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            lvIT111.Items.Clear()
            While dr.Read
                Section1.Text = dr("section")
                lblIT1.Text = dr("roomno")
                starttime = dr("starttime")
                endtime = dr("endtime")
                fulltime = starttime & " - " & endtime
                Dim lv As ListViewItem = lvIT111.Items.Add(fulltime)
                lv.SubItems.Add(dr("subjects").ToString())
                lv.SubItems.Add(dr("days"))
            End While
            For Each lvi As ListViewItem In lvIT111.Items
                If lvi.SubItems(2).Text.ToLower = "1" Then
                    lvi.BackColor = Color.DarkOrchid
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "2" Then
                    lvi.BackColor = Color.DodgerBlue
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "3" Then
                    lvi.BackColor = Color.DarkGreen
                    lvi.ForeColor = Color.White
                End If
            Next
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "error")
        End Try
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "select section, roomno, starttime, endtime, subjects, days from tblschedule where section='" & "IT-118" & "'order by days asc"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            lvIT112.Items.Clear()
            While dr.Read
                Section2.Text = dr("section")
                lblIT2.Text = dr("roomno")
                starttime = dr("starttime")
                endtime = dr("endtime")
                fulltime = starttime & " - " & endtime
                Dim lv As ListViewItem = lvIT112.Items.Add(fulltime)
                lv.SubItems.Add(dr("subjects").ToString())
                lv.SubItems.Add(dr("days"))
            End While
            For Each lvi As ListViewItem In lvIT112.Items
                If lvi.SubItems(2).Text.ToLower = "1" Then
                    lvi.BackColor = Color.DarkOrchid
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "2" Then
                    lvi.BackColor = Color.DodgerBlue
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "3" Then
                    lvi.BackColor = Color.DarkGreen
                    lvi.ForeColor = Color.White
                End If
            Next
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "error")
        End Try
    End Sub

    ''''''''''''''''''''''''''''''''''''''''
    ''''''''''it 2nd year'''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''
    Sub ITRECORDS3()
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "select section, roomno, starttime, endtime, subjects, days from tblschedule where section='" & "IT-211" & "'order by days asc"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            lvIT111.Items.Clear()
            While dr.Read
                Section1.Text = dr("section")
                lblIT1.Text = dr("roomno")
                starttime = dr("starttime")
                endtime = dr("endtime")
                fulltime = starttime & " - " & endtime
                Dim lv As ListViewItem = lvIT111.Items.Add(fulltime)
                lv.SubItems.Add(dr("subjects").ToString())
                lv.SubItems.Add(dr("days"))
            End While
            For Each lvi As ListViewItem In lvIT111.Items
                If lvi.SubItems(2).Text.ToLower = "1" Then
                    lvi.BackColor = Color.DarkOrchid
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "2" Then
                    lvi.BackColor = Color.DodgerBlue
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "3" Then
                    lvi.BackColor = Color.DarkGreen
                    lvi.ForeColor = Color.White
                End If
            Next
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "error")
        End Try
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "select section, roomno, starttime, endtime, subjects, days from tblschedule where section='" & "IT-212" & "'order by days asc"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            lvIT112.Items.Clear()
            While dr.Read
                Section2.Text = dr("section")
                lblIT2.Text = dr("roomno")
                starttime = dr("starttime")
                endtime = dr("endtime")
                fulltime = starttime & " - " & endtime
                Dim lv As ListViewItem = lvIT112.Items.Add(fulltime)
                lv.SubItems.Add(dr("subjects").ToString())
                lv.SubItems.Add(dr("days"))
            End While
            For Each lvi As ListViewItem In lvIT112.Items
                If lvi.SubItems(2).Text.ToLower = "1" Then
                    lvi.BackColor = Color.DarkOrchid
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "2" Then
                    lvi.BackColor = Color.DodgerBlue
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "3" Then
                    lvi.BackColor = Color.DarkGreen
                    lvi.ForeColor = Color.White
                End If
            Next
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "error")
        End Try
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "select section, roomno, starttime, endtime, subjects, days from tblschedule where section='" & "IT-213" & "'order by days asc"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            lvIT113.Items.Clear()
            While dr.Read
                Section3.Text = dr("section")
                lblIT3.Text = dr("roomno")
                starttime = dr("starttime")
                endtime = dr("endtime")
                fulltime = starttime & " - " & endtime
                Dim lv As ListViewItem = lvIT113.Items.Add(fulltime)
                lv.SubItems.Add(dr("subjects").ToString())
                lv.SubItems.Add(dr("days"))
            End While
            For Each lvi As ListViewItem In lvIT113.Items
                If lvi.SubItems(2).Text.ToLower = "1" Then
                    lvi.BackColor = Color.DarkOrchid
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "2" Then
                    lvi.BackColor = Color.DodgerBlue
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "3" Then
                    lvi.BackColor = Color.DarkGreen
                    lvi.ForeColor = Color.White
                End If
            Next
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "error")
        End Try
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "select section, roomno, starttime, endtime, subjects, days from tblschedule where section='" & "IT-214" & "'order by days asc"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            lvIT114.Items.Clear()
            While dr.Read
                Section4.Text = dr("section")
                lblIT4.Text = dr("roomno")
                starttime = dr("starttime")
                endtime = dr("endtime")
                fulltime = starttime & " - " & endtime
                Dim lv As ListViewItem = lvIT114.Items.Add(fulltime)
                lv.SubItems.Add(dr("subjects").ToString())
                lv.SubItems.Add(dr("days"))
            End While
            For Each lvi As ListViewItem In lvIT114.Items
                If lvi.SubItems(2).Text.ToLower = "1" Then
                    lvi.BackColor = Color.DarkOrchid
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "2" Then
                    lvi.BackColor = Color.DodgerBlue
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "3" Then
                    lvi.BackColor = Color.DarkGreen
                    lvi.ForeColor = Color.White
                End If
            Next
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "error")
        End Try
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "select section, roomno, starttime, endtime, subjects, days from tblschedule where section='" & "IT-215" & "'order by days asc"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            lvIT115.Items.Clear()
            While dr.Read
                Section5.Text = dr("section")
                lblIT5.Text = dr("roomno")
                starttime = dr("starttime")
                endtime = dr("endtime")
                fulltime = starttime & " - " & endtime
                Dim lv As ListViewItem = lvIT115.Items.Add(fulltime)
                lv.SubItems.Add(dr("subjects").ToString())
                lv.SubItems.Add(dr("days"))
            End While
            For Each lvi As ListViewItem In lvIT115.Items
                If lvi.SubItems(2).Text.ToLower = "1" Then
                    lvi.BackColor = Color.DarkOrchid
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "2" Then
                    lvi.BackColor = Color.DodgerBlue
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "3" Then
                    lvi.BackColor = Color.DarkGreen
                    lvi.ForeColor = Color.White
                End If
            Next
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "error")
        End Try
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "select section, roomno, starttime, endtime, subjects, days from tblschedule where section='" & "IT-216" & "'order by days asc"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            lvIT116.Items.Clear()
            While dr.Read
                Section6.Text = dr("section")
                lblIT6.Text = dr("roomno")
                starttime = dr("starttime")
                endtime = dr("endtime")
                fulltime = starttime & " - " & endtime
                Dim lv As ListViewItem = lvIT116.Items.Add(fulltime)
                lv.SubItems.Add(dr("subjects").ToString())
                lv.SubItems.Add(dr("days"))
            End While
            For Each lvi As ListViewItem In lvIT116.Items
                If lvi.SubItems(2).Text.ToLower = "1" Then
                    lvi.BackColor = Color.DarkOrchid
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "2" Then
                    lvi.BackColor = Color.DodgerBlue
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "3" Then
                    lvi.BackColor = Color.DarkGreen
                    lvi.ForeColor = Color.White
                End If
            Next
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "error")
        End Try
    End Sub



    'it 3rd year
    Sub ITRECORDS4()
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "select section, roomno, starttime, endtime, subjects, days from tblschedule where section='" & "IT-311" & "'order by days asc"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            lvIT111.Items.Clear()
            While dr.Read
                Section1.Text = dr("section")
                lblIT1.Text = dr("roomno")
                starttime = dr("starttime")
                endtime = dr("endtime")
                fulltime = starttime & " - " & endtime
                Dim lv As ListViewItem = lvIT111.Items.Add(fulltime)
                lv.SubItems.Add(dr("subjects").ToString())
                lv.SubItems.Add(dr("days"))
            End While
            For Each lvi As ListViewItem In lvIT111.Items
                If lvi.SubItems(2).Text.ToLower = "1" Then
                    lvi.BackColor = Color.DarkOrchid
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "2" Then
                    lvi.BackColor = Color.DodgerBlue
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "3" Then
                    lvi.BackColor = Color.DarkGreen
                    lvi.ForeColor = Color.White
                End If
            Next
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "error")
        End Try
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "select section, roomno, starttime, endtime, subjects, days from tblschedule where section='" & "IT-312" & "'order by days asc"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            lvIT112.Items.Clear()
            While dr.Read
                Section2.Text = dr("section")
                lblIT2.Text = dr("roomno")
                starttime = dr("starttime")
                endtime = dr("endtime")
                fulltime = starttime & " - " & endtime
                Dim lv As ListViewItem = lvIT112.Items.Add(fulltime)
                lv.SubItems.Add(dr("subjects").ToString())
                lv.SubItems.Add(dr("days"))
            End While
            For Each lvi As ListViewItem In lvIT112.Items
                If lvi.SubItems(2).Text.ToLower = "1" Then
                    lvi.BackColor = Color.DarkOrchid
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "2" Then
                    lvi.BackColor = Color.DodgerBlue
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "3" Then
                    lvi.BackColor = Color.DarkGreen
                    lvi.ForeColor = Color.White
                End If
            Next
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "error")
        End Try
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "select section, roomno, starttime, endtime, subjects, days from tblschedule where section='" & "IT-313" & "'order by days asc"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            lvIT113.Items.Clear()
            While dr.Read
                Section3.Text = dr("section")
                lblIT3.Text = dr("roomno")
                starttime = dr("starttime")
                endtime = dr("endtime")
                fulltime = starttime & " - " & endtime
                Dim lv As ListViewItem = lvIT113.Items.Add(fulltime)
                lv.SubItems.Add(dr("subjects").ToString())
                lv.SubItems.Add(dr("days"))
            End While
            For Each lvi As ListViewItem In lvIT113.Items
                If lvi.SubItems(2).Text.ToLower = "1" Then
                    lvi.BackColor = Color.DarkOrchid
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "2" Then
                    lvi.BackColor = Color.DodgerBlue
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "3" Then
                    lvi.BackColor = Color.DarkGreen
                    lvi.ForeColor = Color.White
                End If
            Next
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "error")
        End Try
    End Sub

    'IT 4th YEAR
    Sub ITRECORDS5()
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "select section, roomno, starttime, endtime, subjects, days from tblschedule where section='" & "IT-411" & "'order by days asc"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            lvIT111.Items.Clear()
            While dr.Read
                Section1.Text = dr("section")
                lblIT1.Text = dr("roomno")
                starttime = dr("starttime")
                endtime = dr("endtime")
                fulltime = starttime & " - " & endtime
                Dim lv As ListViewItem = lvIT111.Items.Add(fulltime)
                lv.SubItems.Add(dr("subjects").ToString())
                lv.SubItems.Add(dr("days"))
            End While
            For Each lvi As ListViewItem In lvIT111.Items
                If lvi.SubItems(2).Text.ToLower = "1" Then
                    lvi.BackColor = Color.DarkOrchid
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "2" Then
                    lvi.BackColor = Color.DodgerBlue
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "3" Then
                    lvi.BackColor = Color.DarkGreen
                    lvi.ForeColor = Color.White
                End If
            Next
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "error")
        End Try
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "select section, roomno, starttime, endtime, subjects, days from tblschedule where section='" & "IT-412" & "'order by days asc"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            lvIT112.Items.Clear()
            While dr.Read
                Section2.Text = dr("section")
                lblIT2.Text = dr("roomno")
                starttime = dr("starttime")
                endtime = dr("endtime")
                fulltime = starttime & " - " & endtime
                Dim lv As ListViewItem = lvIT112.Items.Add(fulltime)
                lv.SubItems.Add(dr("subjects").ToString())
                lv.SubItems.Add(dr("days"))
            End While
            For Each lvi As ListViewItem In lvIT112.Items
                If lvi.SubItems(2).Text.ToLower = "1" Then
                    lvi.BackColor = Color.DarkOrchid
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "2" Then
                    lvi.BackColor = Color.DodgerBlue
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "3" Then
                    lvi.BackColor = Color.DarkGreen
                    lvi.ForeColor = Color.White
                End If
            Next
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "error")
        End Try
    End Sub

    'CS 1ST YEAR
    Sub CSRECORDS1()
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Select section, roomno, starttime, endtime, subjects, days from tblschedule where section='" & "CS-111" & "'order by days asc"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            lvIT111.Items.Clear()
            While dr.Read
                Section1.Text = dr("section")
                lblIT1.Text = dr("roomno")
                starttime = dr("starttime")
                endtime = dr("endtime")
                fulltime = starttime & " - " & endtime
                Dim lv As ListViewItem = lvIT111.Items.Add(fulltime)
                lv.SubItems.Add(dr("subjects").ToString())
                lv.SubItems.Add(dr("days"))
            End While
            For Each lvi As ListViewItem In lvIT111.Items
                If lvi.SubItems(2).Text.ToLower = "1" Then
                    lvi.BackColor = Color.DarkOrchid
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "2" Then
                    lvi.BackColor = Color.DodgerBlue
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "3" Then
                    lvi.BackColor = Color.DarkGreen
                    lvi.ForeColor = Color.White
                End If
            Next
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Select section, roomno, starttime, endtime, subjects, days from tblschedule where section='" & "CS-112" & "'order by days asc"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            lvIT112.Items.Clear()
            While dr.Read
                Section2.Text = dr("section")
                lblIT2.Text = dr("roomno")
                starttime = dr("starttime")
                endtime = dr("endtime")
                fulltime = starttime & " - " & endtime
                Dim lv As ListViewItem = lvIT112.Items.Add(fulltime)
                lv.SubItems.Add(dr("subjects").ToString())
                lv.SubItems.Add(dr("days"))
            End While
            For Each lvi As ListViewItem In lvIT112.Items
                If lvi.SubItems(2).Text.ToLower = "1" Then
                    lvi.BackColor = Color.DarkOrchid
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "2" Then
                    lvi.BackColor = Color.DodgerBlue
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "3" Then
                    lvi.BackColor = Color.DarkGreen
                    lvi.ForeColor = Color.White
                End If
            Next
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Select section, roomno, starttime, endtime, subjects, days from tblschedule where section='" & "CS-113" & "'order by days asc"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            lvIT113.Items.Clear()
            While dr.Read
                Section3.Text = dr("section")
                lblIT3.Text = dr("roomno")
                starttime = dr("starttime")
                endtime = dr("endtime")
                fulltime = starttime & " - " & endtime
                Dim lv As ListViewItem = lvIT113.Items.Add(fulltime)
                lv.SubItems.Add(dr("subjects").ToString())
                lv.SubItems.Add(dr("days"))
            End While
            For Each lvi As ListViewItem In lvIT113.Items
                If lvi.SubItems(2).Text.ToLower = "1" Then
                    lvi.BackColor = Color.DarkOrchid
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "2" Then
                    lvi.BackColor = Color.DodgerBlue
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "3" Then
                    lvi.BackColor = Color.DarkGreen
                    lvi.ForeColor = Color.White
                End If
            Next
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Select section, roomno, starttime, endtime, subjects, days from tblschedule where section='" & "CS-114" & "'order by days asc"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            lvIT114.Items.Clear()
            While dr.Read
                Section4.Text = dr("section")
                lblIT4.Text = dr("roomno")
                starttime = dr("starttime")
                endtime = dr("endtime")
                fulltime = starttime & " - " & endtime
                Dim lv As ListViewItem = lvIT114.Items.Add(fulltime)
                lv.SubItems.Add(dr("subjects").ToString())
                lv.SubItems.Add(dr("days"))
            End While
            For Each lvi As ListViewItem In lvIT114.Items
                If lvi.SubItems(2).Text.ToLower = "1" Then
                    lvi.BackColor = Color.DarkOrchid
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "2" Then
                    lvi.BackColor = Color.DodgerBlue
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "3" Then
                    lvi.BackColor = Color.DarkGreen
                    lvi.ForeColor = Color.White
                End If
            Next
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Select section, roomno, starttime, endtime, subjects, days from tblschedule where section='" & "CS-115" & "'order by days asc"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            lvIT115.Items.Clear()
            While dr.Read
                Section5.Text = dr("section")
                lblIT5.Text = dr("roomno")
                starttime = dr("starttime")
                endtime = dr("endtime")
                fulltime = starttime & " - " & endtime
                Dim lv As ListViewItem = lvIT115.Items.Add(fulltime)
                lv.SubItems.Add(dr("subjects").ToString())
                lv.SubItems.Add(dr("days"))
            End While
            For Each lvi As ListViewItem In lvIT115.Items
                If lvi.SubItems(2).Text.ToLower = "1" Then
                    lvi.BackColor = Color.DarkOrchid
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "2" Then
                    lvi.BackColor = Color.DodgerBlue
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "3" Then
                    lvi.BackColor = Color.DarkGreen
                    lvi.ForeColor = Color.White
                End If
            Next
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Select section, roomno, starttime, endtime, subjects, days from tblschedule where section='" & "CS-116" & "'order by days asc"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            lvIT116.Items.Clear()
            While dr.Read
                Section6.Text = dr("section")
                lblIT6.Text = dr("roomno")
                starttime = dr("starttime")
                endtime = dr("endtime")
                fulltime = starttime & " - " & endtime
                Dim lv As ListViewItem = lvIT116.Items.Add(fulltime)
                lv.SubItems.Add(dr("subjects").ToString())
                lv.SubItems.Add(dr("days"))
            End While
            For Each lvi As ListViewItem In lvIT116.Items
                If lvi.SubItems(2).Text.ToLower = "1" Then
                    lvi.BackColor = Color.DarkOrchid
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "2" Then
                    lvi.BackColor = Color.DodgerBlue
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "3" Then
                    lvi.BackColor = Color.DarkGreen
                    lvi.ForeColor = Color.White
                End If
            Next
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    'CS 2nd YEAR
    Sub CSRECORDS2()
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Select section, roomno, starttime, endtime, subjects, days from tblschedule where section='" & "CS-211" & "'order by days asc"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            lvIT111.Items.Clear()
            While dr.Read
                Section1.Text = dr("section")
                lblIT1.Text = dr("roomno")
                starttime = dr("starttime")
                endtime = dr("endtime")
                fulltime = starttime & " - " & endtime
                Dim lv As ListViewItem = lvIT111.Items.Add(fulltime)
                lv.SubItems.Add(dr("subjects").ToString())
                lv.SubItems.Add(dr("days"))
            End While
            For Each lvi As ListViewItem In lvIT111.Items
                If lvi.SubItems(2).Text.ToLower = "1" Then
                    lvi.BackColor = Color.DarkOrchid
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "2" Then
                    lvi.BackColor = Color.DodgerBlue
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "3" Then
                    lvi.BackColor = Color.DarkGreen
                    lvi.ForeColor = Color.White
                End If
            Next
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Select section, roomno, starttime, endtime, subjects, days from tblschedule where section='" & "CS-212" & "'order by days asc"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            lvIT112.Items.Clear()
            While dr.Read
                Section2.Text = dr("section")
                lblIT2.Text = dr("roomno")
                starttime = dr("starttime")
                endtime = dr("endtime")
                fulltime = starttime & " - " & endtime
                Dim lv As ListViewItem = lvIT112.Items.Add(fulltime)
                lv.SubItems.Add(dr("subjects").ToString())
                lv.SubItems.Add(dr("days"))
            End While
            For Each lvi As ListViewItem In lvIT112.Items
                If lvi.SubItems(2).Text.ToLower = "1" Then
                    lvi.BackColor = Color.DarkOrchid
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "2" Then
                    lvi.BackColor = Color.DodgerBlue
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "3" Then
                    lvi.BackColor = Color.DarkGreen
                    lvi.ForeColor = Color.White
                End If
            Next
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Select section, roomno, starttime, endtime, subjects, days from tblschedule where section='" & "CS-213" & "'order by days asc"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            lvIT113.Items.Clear()
            While dr.Read
                Section3.Text = dr("section")
                lblIT3.Text = dr("roomno")
                starttime = dr("starttime")
                endtime = dr("endtime")
                fulltime = starttime & " - " & endtime
                Dim lv As ListViewItem = lvIT113.Items.Add(fulltime)
                lv.SubItems.Add(dr("subjects").ToString())
                lv.SubItems.Add(dr("days"))
            End While
            For Each lvi As ListViewItem In lvIT113.Items
                If lvi.SubItems(2).Text.ToLower = "1" Then
                    lvi.BackColor = Color.DarkOrchid
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "2" Then
                    lvi.BackColor = Color.DodgerBlue
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "3" Then
                    lvi.BackColor = Color.DarkGreen
                    lvi.ForeColor = Color.White
                End If
            Next
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Select section, roomno, starttime, endtime, subjects, days from tblschedule where section='" & "CS-214" & "'order by days asc"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            lvIT114.Items.Clear()
            While dr.Read
                Section4.Text = dr("section")
                lblIT4.Text = dr("roomno")
                starttime = dr("starttime")
                endtime = dr("endtime")
                fulltime = starttime & " - " & endtime
                Dim lv As ListViewItem = lvIT114.Items.Add(fulltime)
                lv.SubItems.Add(dr("subjects").ToString())
                lv.SubItems.Add(dr("days"))
            End While
            For Each lvi As ListViewItem In lvIT114.Items
                If lvi.SubItems(2).Text.ToLower = "1" Then
                    lvi.BackColor = Color.DarkOrchid
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "2" Then
                    lvi.BackColor = Color.DodgerBlue
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "3" Then
                    lvi.BackColor = Color.DarkGreen
                    lvi.ForeColor = Color.White
                End If
            Next
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Select section, roomno, starttime, endtime, subjects, days from tblschedule where section='" & "CS-215" & "'order by days asc"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            lvIT115.Items.Clear()
            While dr.Read
                Section5.Text = dr("section")
                lblIT5.Text = dr("roomno")
                starttime = dr("starttime")
                endtime = dr("endtime")
                fulltime = starttime & " - " & endtime
                Dim lv As ListViewItem = lvIT115.Items.Add(fulltime)
                lv.SubItems.Add(dr("subjects").ToString())
                lv.SubItems.Add(dr("days"))
            End While
            For Each lvi As ListViewItem In lvIT115.Items
                If lvi.SubItems(2).Text.ToLower = "1" Then
                    lvi.BackColor = Color.DarkOrchid
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "2" Then
                    lvi.BackColor = Color.DodgerBlue
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "3" Then
                    lvi.BackColor = Color.DarkGreen
                    lvi.ForeColor = Color.White
                End If
            Next
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Select section, roomno, starttime, endtime, subjects, days from tblschedule where section='" & "CS-216" & "'order by days asc"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            lvIT116.Items.Clear()
            While dr.Read
                Section6.Text = dr("section")
                lblIT6.Text = dr("roomno")
                starttime = dr("starttime")
                endtime = dr("endtime")
                fulltime = starttime & " - " & endtime
                Dim lv As ListViewItem = lvIT116.Items.Add(fulltime)
                lv.SubItems.Add(dr("subjects").ToString())
                lv.SubItems.Add(dr("days"))
            End While
            For Each lvi As ListViewItem In lvIT116.Items
                If lvi.SubItems(2).Text.ToLower = "1" Then
                    lvi.BackColor = Color.DarkOrchid
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "2" Then
                    lvi.BackColor = Color.DodgerBlue
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "3" Then
                    lvi.BackColor = Color.DarkGreen
                    lvi.ForeColor = Color.White
                End If
            Next
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    'CS 3rd YEAR
    Sub CSRECORDS3()
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Select section, roomno, starttime, endtime, subjects, days from tblschedule where section='" & "CS-311" & "'order by days asc"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            lvIT111.Items.Clear()
            While dr.Read
                Section1.Text = dr("section")
                lblIT1.Text = dr("roomno")
                starttime = dr("starttime")
                endtime = dr("endtime")
                fulltime = starttime & " - " & endtime
                Dim lv As ListViewItem = lvIT111.Items.Add(fulltime)
                lv.SubItems.Add(dr("subjects").ToString())
                lv.SubItems.Add(dr("days"))
            End While
            For Each lvi As ListViewItem In lvIT111.Items
                If lvi.SubItems(2).Text.ToLower = "1" Then
                    lvi.BackColor = Color.DarkOrchid
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "2" Then
                    lvi.BackColor = Color.DodgerBlue
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "3" Then
                    lvi.BackColor = Color.DarkGreen
                    lvi.ForeColor = Color.White
                End If
            Next
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Select section, roomno, starttime, endtime, subjects, days from tblschedule where section='" & "CS-411" & "'order by days asc"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            lvIT112.Items.Clear()
            While dr.Read
                Section2.Text = dr("section")
                lblIT2.Text = dr("roomno")
                starttime = dr("starttime")
                endtime = dr("endtime")
                fulltime = starttime & " - " & endtime
                Dim lv As ListViewItem = lvIT112.Items.Add(fulltime)
                lv.SubItems.Add(dr("subjects").ToString())
                lv.SubItems.Add(dr("days"))
            End While
            For Each lvi As ListViewItem In lvIT112.Items
                If lvi.SubItems(2).Text.ToLower = "1" Then
                    lvi.BackColor = Color.DarkOrchid
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "2" Then
                    lvi.BackColor = Color.DodgerBlue
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "3" Then
                    lvi.BackColor = Color.DarkGreen
                    lvi.ForeColor = Color.White
                End If
            Next
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    'GE 1st YEAR
    Sub GERECORDS1()
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Select section, roomno, starttime, endtime, subjects, days from tblschedule where section='" & "GE-111" & "'order by days asc"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            lvIT111.Items.Clear()
            While dr.Read
                Section1.Text = dr("section")
                lblIT1.Text = dr("roomno")
                starttime = dr("starttime")
                endtime = dr("endtime")
                fulltime = starttime & " - " & endtime
                Dim lv As ListViewItem = lvIT111.Items.Add(fulltime)
                lv.SubItems.Add(dr("subjects").ToString())
                lv.SubItems.Add(dr("days"))
            End While
            For Each lvi As ListViewItem In lvIT111.Items
                If lvi.SubItems(2).Text.ToLower = "1" Then
                    lvi.BackColor = Color.DarkOrchid
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "2" Then
                    lvi.BackColor = Color.DodgerBlue
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "3" Then
                    lvi.BackColor = Color.DarkGreen
                    lvi.ForeColor = Color.White
                End If
            Next
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Select section, roomno, starttime, endtime, subjects, days from tblschedule where section='" & "GE-112" & "'order by days asc"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            lvIT112.Items.Clear()
            While dr.Read
                Section2.Text = dr("section")
                lblIT2.Text = dr("roomno")
                starttime = dr("starttime")
                endtime = dr("endtime")
                fulltime = starttime & " - " & endtime
                Dim lv As ListViewItem = lvIT112.Items.Add(fulltime)
                lv.SubItems.Add(dr("subjects").ToString())
                lv.SubItems.Add(dr("days"))
            End While
            For Each lvi As ListViewItem In lvIT112.Items
                If lvi.SubItems(2).Text.ToLower = "1" Then
                    lvi.BackColor = Color.DarkOrchid
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "2" Then
                    lvi.BackColor = Color.DodgerBlue
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "3" Then
                    lvi.BackColor = Color.DarkGreen
                    lvi.ForeColor = Color.White
                End If
            Next
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Select section, roomno, starttime, endtime, subjects, days from tblschedule where section='" & "GE-113" & "'order by days asc"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            lvIT113.Items.Clear()
            While dr.Read
                Section3.Text = dr("section")
                lblIT3.Text = dr("roomno")
                starttime = dr("starttime")
                endtime = dr("endtime")
                fulltime = starttime & " - " & endtime
                Dim lv As ListViewItem = lvIT113.Items.Add(fulltime)
                lv.SubItems.Add(dr("subjects").ToString())
                lv.SubItems.Add(dr("days"))
            End While
            For Each lvi As ListViewItem In lvIT113.Items
                If lvi.SubItems(2).Text.ToLower = "1" Then
                    lvi.BackColor = Color.DarkOrchid
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "2" Then
                    lvi.BackColor = Color.DodgerBlue
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "3" Then
                    lvi.BackColor = Color.DarkGreen
                    lvi.ForeColor = Color.White
                End If
            Next
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Select section, roomno, starttime, endtime, subjects, days from tblschedule where section='" & "GE-114" & "'order by days asc"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            lvIT114.Items.Clear()
            While dr.Read
                Section4.Text = dr("section")
                lblIT4.Text = dr("roomno")
                starttime = dr("starttime")
                endtime = dr("endtime")
                fulltime = starttime & " - " & endtime
                Dim lv As ListViewItem = lvIT114.Items.Add(fulltime)
                lv.SubItems.Add(dr("subjects").ToString())
                lv.SubItems.Add(dr("days"))
            End While
            For Each lvi As ListViewItem In lvIT114.Items
                If lvi.SubItems(2).Text.ToLower = "1" Then
                    lvi.BackColor = Color.DarkOrchid
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "2" Then
                    lvi.BackColor = Color.DodgerBlue
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "3" Then
                    lvi.BackColor = Color.DarkGreen
                    lvi.ForeColor = Color.White
                End If
            Next
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Select section, roomno, starttime, endtime, subjects, days from tblschedule where section='" & "GE-115" & "'order by days asc"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            lvIT115.Items.Clear()
            While dr.Read
                Section5.Text = dr("section")
                lblIT5.Text = dr("roomno")
                starttime = dr("starttime")
                endtime = dr("endtime")
                fulltime = starttime & " - " & endtime
                Dim lv As ListViewItem = lvIT115.Items.Add(fulltime)
                lv.SubItems.Add(dr("subjects").ToString())
                lv.SubItems.Add(dr("days"))
            End While
            For Each lvi As ListViewItem In lvIT115.Items
                If lvi.SubItems(2).Text.ToLower = "1" Then
                    lvi.BackColor = Color.DarkOrchid
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "2" Then
                    lvi.BackColor = Color.DodgerBlue
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "3" Then
                    lvi.BackColor = Color.DarkGreen
                    lvi.ForeColor = Color.White
                End If
            Next
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Select section, roomno, starttime, endtime, subjects, days from tblschedule where section='" & "GE-116" & "'order by days asc"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            lvIT116.Items.Clear()
            While dr.Read
                Section6.Text = dr("section")
                lblIT6.Text = dr("roomno")
                starttime = dr("starttime")
                endtime = dr("endtime")
                fulltime = starttime & " - " & endtime
                Dim lv As ListViewItem = lvIT116.Items.Add(fulltime)
                lv.SubItems.Add(dr("subjects").ToString())
                lv.SubItems.Add(dr("days"))
            End While
            For Each lvi As ListViewItem In lvIT116.Items
                If lvi.SubItems(2).Text.ToLower = "1" Then
                    lvi.BackColor = Color.DarkOrchid
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "2" Then
                    lvi.BackColor = Color.DodgerBlue
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "3" Then
                    lvi.BackColor = Color.DarkGreen
                    lvi.ForeColor = Color.White
                End If
            Next
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Sub GERECORDS2()
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Select section, roomno, starttime, endtime, subjects, days from tblschedule where section='" & "GE-117" & "'order by days asc"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            lvIT111.Items.Clear()
            While dr.Read
                Section1.Text = dr("section")
                lblIT1.Text = dr("roomno")
                starttime = dr("starttime")
                endtime = dr("endtime")
                fulltime = starttime & " - " & endtime
                Dim lv As ListViewItem = lvIT111.Items.Add(fulltime)
                lv.SubItems.Add(dr("subjects").ToString())
                lv.SubItems.Add(dr("days"))
            End While
            For Each lvi As ListViewItem In lvIT111.Items
                If lvi.SubItems(2).Text.ToLower = "1" Then
                    lvi.BackColor = Color.DarkOrchid
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "2" Then
                    lvi.BackColor = Color.DodgerBlue
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "3" Then
                    lvi.BackColor = Color.DarkGreen
                    lvi.ForeColor = Color.White
                End If
            Next
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Select section, roomno, starttime, endtime, subjects, days from tblschedule where section='" & "GE-118" & "'order by days asc"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            lvIT112.Items.Clear()
            While dr.Read
                Section2.Text = dr("section")
                lblIT2.Text = dr("roomno")
                starttime = dr("starttime")
                endtime = dr("endtime")
                fulltime = starttime & " - " & endtime
                Dim lv As ListViewItem = lvIT112.Items.Add(fulltime)
                lv.SubItems.Add(dr("subjects").ToString())
                lv.SubItems.Add(dr("days"))
            End While
            For Each lvi As ListViewItem In lvIT112.Items
                If lvi.SubItems(2).Text.ToLower = "1" Then
                    lvi.BackColor = Color.DarkOrchid
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "2" Then
                    lvi.BackColor = Color.DodgerBlue
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "3" Then
                    lvi.BackColor = Color.DarkGreen
                    lvi.ForeColor = Color.White
                End If
            Next
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Select section, roomno, starttime, endtime, subjects, days from tblschedule where section='" & "GE-119" & "'order by days asc"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            lvIT113.Items.Clear()
            While dr.Read
                Section3.Text = dr("section")
                lblIT3.Text = dr("roomno")
                starttime = dr("starttime")
                endtime = dr("endtime")
                fulltime = starttime & " - " & endtime
                Dim lv As ListViewItem = lvIT113.Items.Add(fulltime)
                lv.SubItems.Add(dr("subjects").ToString())
                lv.SubItems.Add(dr("days"))
            End While
            For Each lvi As ListViewItem In lvIT113.Items
                If lvi.SubItems(2).Text.ToLower = "1" Then
                    lvi.BackColor = Color.DarkOrchid
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "2" Then
                    lvi.BackColor = Color.DodgerBlue
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "3" Then
                    lvi.BackColor = Color.DarkGreen
                    lvi.ForeColor = Color.White
                End If
            Next
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    'GE 2nd YEAR
    Sub GERECORDS3()
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Select section, roomno, starttime, endtime, subjects, days from tblschedule where section='" & "GE-211" & "'order by days asc"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            lvIT111.Items.Clear()
            While dr.Read
                Section1.Text = dr("section")
                lblIT1.Text = dr("roomno")
                starttime = dr("starttime")
                endtime = dr("endtime")
                fulltime = starttime & " - " & endtime
                Dim lv As ListViewItem = lvIT111.Items.Add(fulltime)
                lv.SubItems.Add(dr("subjects").ToString())
                lv.SubItems.Add(dr("days"))
            End While
            For Each lvi As ListViewItem In lvIT111.Items
                If lvi.SubItems(2).Text.ToLower = "1" Then
                    lvi.BackColor = Color.DarkOrchid
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "2" Then
                    lvi.BackColor = Color.DodgerBlue
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "3" Then
                    lvi.BackColor = Color.DarkGreen
                    lvi.ForeColor = Color.White
                End If
            Next
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Select section, roomno, starttime, endtime, subjects, days from tblschedule where section='" & "GE-212" & "'order by days asc"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            lvIT112.Items.Clear()
            While dr.Read
                Section2.Text = dr("section")
                lblIT2.Text = dr("roomno")
                starttime = dr("starttime")
                endtime = dr("endtime")
                fulltime = starttime & " - " & endtime
                Dim lv As ListViewItem = lvIT112.Items.Add(fulltime)
                lv.SubItems.Add(dr("subjects").ToString())
                lv.SubItems.Add(dr("days"))
            End While
            For Each lvi As ListViewItem In lvIT112.Items
                If lvi.SubItems(2).Text.ToLower = "1" Then
                    lvi.BackColor = Color.DarkOrchid
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "2" Then
                    lvi.BackColor = Color.DodgerBlue
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "3" Then
                    lvi.BackColor = Color.DarkGreen
                    lvi.ForeColor = Color.White
                End If
            Next
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Select section, roomno, starttime, endtime, subjects, days from tblschedule where section='" & "GE-213" & "'order by days asc"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            lvIT113.Items.Clear()
            While dr.Read
                Section3.Text = dr("section")
                lblIT3.Text = dr("roomno")
                starttime = dr("starttime")
                endtime = dr("endtime")
                fulltime = starttime & " - " & endtime
                Dim lv As ListViewItem = lvIT113.Items.Add(fulltime)
                lv.SubItems.Add(dr("subjects").ToString())
                lv.SubItems.Add(dr("days"))
            End While
            For Each lvi As ListViewItem In lvIT113.Items
                If lvi.SubItems(2).Text.ToLower = "1" Then
                    lvi.BackColor = Color.DarkOrchid
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "2" Then
                    lvi.BackColor = Color.DodgerBlue
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "3" Then
                    lvi.BackColor = Color.DarkGreen
                    lvi.ForeColor = Color.White
                End If
            Next
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Select section, roomno, starttime, endtime, subjects, days from tblschedule where section='" & "GE-214" & "'order by days asc"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            lvIT114.Items.Clear()
            While dr.Read
                Section4.Text = dr("section")
                lblIT4.Text = dr("roomno")
                starttime = dr("starttime")
                endtime = dr("endtime")
                fulltime = starttime & " - " & endtime
                Dim lv As ListViewItem = lvIT114.Items.Add(fulltime)
                lv.SubItems.Add(dr("subjects").ToString())
                lv.SubItems.Add(dr("days"))
            End While
            For Each lvi As ListViewItem In lvIT114.Items
                If lvi.SubItems(2).Text.ToLower = "1" Then
                    lvi.BackColor = Color.DarkOrchid
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "2" Then
                    lvi.BackColor = Color.DodgerBlue
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "3" Then
                    lvi.BackColor = Color.DarkGreen
                    lvi.ForeColor = Color.White
                End If
            Next
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Select section, roomno, starttime, endtime, subjects, days from tblschedule where section='" & "GE-215" & "'order by days asc"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            lvIT115.Items.Clear()
            While dr.Read
                Section5.Text = dr("section")
                lblIT5.Text = dr("roomno")
                starttime = dr("starttime")
                endtime = dr("endtime")
                fulltime = starttime & " - " & endtime
                Dim lv As ListViewItem = lvIT115.Items.Add(fulltime)
                lv.SubItems.Add(dr("subjects").ToString())
                lv.SubItems.Add(dr("days"))
            End While
            For Each lvi As ListViewItem In lvIT115.Items
                If lvi.SubItems(2).Text.ToLower = "1" Then
                    lvi.BackColor = Color.DarkOrchid
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "2" Then
                    lvi.BackColor = Color.DodgerBlue
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "3" Then
                    lvi.BackColor = Color.DarkGreen
                    lvi.ForeColor = Color.White
                End If
            Next
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Select section, roomno, starttime, endtime, subjects, days from tblschedule where section='" & "GE-216" & "'order by days asc"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            lvIT114.Items.Clear()
            While dr.Read
                Section6.Text = dr("section")
                lblIT6.Text = dr("roomno")
                starttime = dr("starttime")
                endtime = dr("endtime")
                fulltime = starttime & " - " & endtime
                Dim lv As ListViewItem = lvIT116.Items.Add(fulltime)
                lv.SubItems.Add(dr("subjects").ToString())
                lv.SubItems.Add(dr("days"))
            End While
            For Each lvi As ListViewItem In lvIT116.Items
                If lvi.SubItems(2).Text.ToLower = "1" Then
                    lvi.BackColor = Color.DarkOrchid
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "2" Then
                    lvi.BackColor = Color.DodgerBlue
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "3" Then
                    lvi.BackColor = Color.DarkGreen
                    lvi.ForeColor = Color.White
                End If
            Next
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    'MEX 311/411/511
    Sub MEXRECORDS1()
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "select section, roomno, starttime, endtime, subjects, days from tblschedule where section='" & "MEX-311" & "'order by days asc"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            lvIT111.Items.Clear()
            While dr.Read
                Section1.Text = dr("section")
                lblIT1.Text = dr("roomno")
                starttime = dr("starttime")
                endtime = dr("endtime")
                fulltime = starttime & " - " & endtime
                Dim lv As ListViewItem = lvIT111.Items.Add(fulltime)
                lv.SubItems.Add(dr("subjects").ToString())
                lv.SubItems.Add(dr("days"))
            End While
            For Each lvi As ListViewItem In lvIT111.Items
                If lvi.SubItems(2).Text.ToLower = "1" Then
                    lvi.BackColor = Color.DarkOrchid
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "2" Then
                    lvi.BackColor = Color.DodgerBlue
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "3" Then
                    lvi.BackColor = Color.DarkGreen
                    lvi.ForeColor = Color.White
                End If
            Next
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Select section, roomno, starttime, endtime, subjects, days from tblschedule where section='" & "MEX-411" & "'order by days asc"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            lvIT112.Items.Clear()
            While dr.Read
                Section2.Text = dr("section")
                lblIT2.Text = dr("roomno")
                starttime = dr("starttime")
                endtime = dr("endtime")
                fulltime = starttime & " - " & endtime
                Dim lv As ListViewItem = lvIT112.Items.Add(fulltime)
                lv.SubItems.Add(dr("subjects").ToString())
                lv.SubItems.Add(dr("days"))
            End While
            For Each lvi As ListViewItem In lvIT112.Items
                If lvi.SubItems(2).Text.ToLower = "1" Then
                    lvi.BackColor = Color.DarkOrchid
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "2" Then
                    lvi.BackColor = Color.DodgerBlue
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "3" Then
                    lvi.BackColor = Color.DarkGreen
                    lvi.ForeColor = Color.White
                End If
            Next
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Select section, roomno, starttime, endtime, subjects, days from tblschedule where section='" & "MEX-511" & "'order by days asc"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            lvIT113.Items.Clear()
            While dr.Read
                Section3.Text = dr("section")
                lblIT3.Text = dr("roomno")
                starttime = dr("starttime")
                endtime = dr("endtime")
                fulltime = starttime & " - " & endtime
                Dim lv As ListViewItem = lvIT113.Items.Add(fulltime)
                lv.SubItems.Add(dr("subjects").ToString())
                lv.SubItems.Add(dr("days"))
            End While
            For Each lvi As ListViewItem In lvIT113.Items
                If lvi.SubItems(2).Text.ToLower = "1" Then
                    lvi.BackColor = Color.DarkOrchid
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "2" Then
                    lvi.BackColor = Color.DodgerBlue
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "3" Then
                    lvi.BackColor = Color.DarkGreen
                    lvi.ForeColor = Color.White
                End If
            Next
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    'IE 3rd YEAR/4th YEAR/5th YEAR
    Sub IERECORDS1()
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Select section, roomno, starttime, endtime, subjects, days from tblschedule where section='" & "IE-311" & "'order by days asc"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            lvIT111.Items.Clear()
            While dr.Read
                Section1.Text = dr("section")
                lblIT1.Text = dr("roomno")
                starttime = dr("starttime")
                endtime = dr("endtime")
                fulltime = starttime & " - " & endtime
                Dim lv As ListViewItem = lvIT111.Items.Add(fulltime)
                lv.SubItems.Add(dr("subjects").ToString())
                lv.SubItems.Add(dr("days"))
            End While
            For Each lvi As ListViewItem In lvIT111.Items
                If lvi.SubItems(2).Text.ToLower = "1" Then
                    lvi.BackColor = Color.DarkOrchid
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "2" Then
                    lvi.BackColor = Color.DodgerBlue
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "3" Then
                    lvi.BackColor = Color.DarkGreen
                    lvi.ForeColor = Color.White
                End If
            Next
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Select section, roomno, starttime, endtime, subjects, days from tblschedule where section='" & "IE-312" & "'order by days asc"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            lvIT112.Items.Clear()
            While dr.Read
                Section2.Text = dr("section")
                lblIT2.Text = dr("roomno")
                starttime = dr("starttime")
                endtime = dr("endtime")
                fulltime = starttime & " - " & endtime
                Dim lv As ListViewItem = lvIT112.Items.Add(fulltime)
                lv.SubItems.Add(dr("subjects").ToString())
                lv.SubItems.Add(dr("days"))
            End While
            For Each lvi As ListViewItem In lvIT112.Items
                If lvi.SubItems(2).Text.ToLower = "1" Then
                    lvi.BackColor = Color.DarkOrchid
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "2" Then
                    lvi.BackColor = Color.DodgerBlue
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "3" Then
                    lvi.BackColor = Color.DarkGreen
                    lvi.ForeColor = Color.White
                End If
            Next
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Select section, roomno, starttime, endtime, subjects, days from tblschedule where section='" & "IE-313" & "'order by days asc"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            lvIT113.Items.Clear()
            While dr.Read
                Section3.Text = dr("section")
                lblIT3.Text = dr("roomno")
                starttime = dr("starttime")
                endtime = dr("endtime")
                fulltime = starttime & " - " & endtime
                Dim lv As ListViewItem = lvIT113.Items.Add(fulltime)
                lv.SubItems.Add(dr("subjects").ToString())
                lv.SubItems.Add(dr("days"))
            End While
            For Each lvi As ListViewItem In lvIT113.Items
                If lvi.SubItems(2).Text.ToLower = "1" Then
                    lvi.BackColor = Color.DarkOrchid
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "2" Then
                    lvi.BackColor = Color.DodgerBlue
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "3" Then
                    lvi.BackColor = Color.DarkGreen
                    lvi.ForeColor = Color.White
                End If
            Next
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Select section, roomno, starttime, endtime, subjects, days from tblschedule where section='" & "IE-411" & "'order by days asc"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            lvIT114.Items.Clear()
            While dr.Read
                Section4.Text = dr("section")
                lblIT4.Text = dr("roomno")
                starttime = dr("starttime")
                endtime = dr("endtime")
                fulltime = starttime & " - " & endtime
                Dim lv As ListViewItem = lvIT114.Items.Add(fulltime)
                lv.SubItems.Add(dr("subjects").ToString())
                lv.SubItems.Add(dr("days"))
            End While
            For Each lvi As ListViewItem In lvIT114.Items
                If lvi.SubItems(2).Text.ToLower = "1" Then
                    lvi.BackColor = Color.DarkOrchid
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "2" Then
                    lvi.BackColor = Color.DodgerBlue
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "3" Then
                    lvi.BackColor = Color.DarkGreen
                    lvi.ForeColor = Color.White
                End If
            Next
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Select section, roomno, starttime, endtime, subjects, days from tblschedule where section='" & "IE-511" & "'order by days asc"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            lvIT115.Items.Clear()
            While dr.Read
                Section5.Text = dr("section")
                lblIT5.Text = dr("roomno")
                starttime = dr("starttime")
                endtime = dr("endtime")
                fulltime = starttime & " - " & endtime
                Dim lv As ListViewItem = lvIT115.Items.Add(fulltime)
                lv.SubItems.Add(dr("subjects").ToString())
                lv.SubItems.Add(dr("days"))
            End While
            For Each lvi As ListViewItem In lvIT115.Items
                If lvi.SubItems(2).Text.ToLower = "1" Then
                    lvi.BackColor = Color.DarkOrchid
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "2" Then
                    lvi.BackColor = Color.DodgerBlue
                    lvi.ForeColor = Color.White
                ElseIf lvi.SubItems(2).Text.ToLower = "3" Then
                    lvi.BackColor = Color.DarkGreen
                    lvi.ForeColor = Color.White
                End If
            Next
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Sub ClearList()
        lvIT111.Items.Clear()
        lvIT112.Items.Clear()
        lvIT113.Items.Clear()
        lvIT114.Items.Clear()
        lvIT115.Items.Clear()
        lvIT116.Items.Clear()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        'For index = 1 To 13
        '    If index = 1 Then
        '        Call ITRECORDS1()
        '    ElseIf index = 2 Then
        '        Call ITRECORDS2()
        '    ElseIf index = 3 Then
        '        Call ITRECORDS3()
        '    ElseIf index = 4 Then
        '        Call ITRECORDS4()
        '    ElseIf index = 5 Then
        '        Call ITRECORDS5()
        '    ElseIf index = 6 Then
        '        Call CSRECORDS1()
        '    ElseIf index = 7 Then
        '        Call CSRECORDS2()
        '    ElseIf index = 8 Then
        '        Call CSRECORDS3()
        '    ElseIf index = 9 Then
        '        Call GERECORDS1()
        '    ElseIf index = 10 Then
        '        Call GERECORDS2()
        '    ElseIf index = 11 Then
        '        Call GERECORDS3()
        '    ElseIf index = 12 Then
        '        Call MEXRECORDS1()
        '    ElseIf index = 13 Then
        '        Call IERECORDS1()
        '    End If
        'Next

        TimerCount = TimerCount - 1
        If TimerCount = 28 Then
            Call ITRECORDS1()
        ElseIf TimerCount = 27 Then
            Call ClearList()
        End If
        If TimerCount = 26 Then
            Call ITRECORDS2()
        ElseIf TimerCount = 25 Then
            Call ClearList()
        End If
        If TimerCount = 24 Then
            Call ITRECORDS3()
        ElseIf TimerCount = 23 Then
            Call ClearList()
        End If
        If TimerCount = 22 Then
            Call ITRECORDS4()
        ElseIf TimerCount = 21 Then
            Call ClearList()
        End If
        If TimerCount = 20 Then
            Call ITRECORDS5()
        ElseIf TimerCount = 19 Then
            Call ClearList()
        End If
        If TimerCount = 18 Then
            Call CSRECORDS1()
        ElseIf TimerCount = 17 Then
            Call ClearList()
        End If
        If TimerCount = 16 Then
            Call CSRECORDS2()
        ElseIf TimerCount = 15 Then
            Call ClearList()
        End If
        If TimerCount = 14 Then
            Call CSRECORDS3()
        ElseIf TimerCount = 23 Then
            Call ClearList()
        End If
        If TimerCount = 12 Then
            Call GERECORDS1()
        ElseIf TimerCount = 11 Then
            Call ClearList()
        End If
        If TimerCount = 10 Then
            Call GERECORDS2()
        ElseIf TimerCount = 9 Then
            Call ClearList()
        End If
        If TimerCount = 8 Then
            Call GERECORDS2()
        ElseIf TimerCount = 7 Then
            Call ClearList()
        End If
        If TimerCount = 6 Then
            Call GERECORDS3()
        ElseIf TimerCount = 5 Then
            Call ClearList()
        End If
        If TimerCount = 4 Then
            Call MEXRECORDS1()
        ElseIf TimerCount = 3 Then
            Call ClearList()
        End If
        If TimerCount = 1 Then
            Call IERECORDS1()
            Timer2.Enabled = False
            Call ClearList()
            If Timer2.Enabled = False Then
                TimerCount = 30
                Timer2.Enabled = True
                Timer2.Start()
            End If
        End If

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

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub lvIT114_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvIT114.SelectedIndexChanged

    End Sub
End Class