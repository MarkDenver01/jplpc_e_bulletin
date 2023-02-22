Imports MySql.Data.MySqlClient
Public Class frmSchedule
    Dim timestart, timeend
    Dim timefull As String
    Dim csstring As String = "server=localhost;uid=root;pwd=admin;database=ebulletindb;"
    Private Sub frmSchedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LoadRecords()
            fillCombo(cboSubject, "Select distinct(description) from tblsubject")
            fillCombo(cboRoom, "Select distinct(room) from tblroom")
            fillCombo(cboSection, "Select distinct(section) from tblsection")
    End Sub
    Public Sub fillCombo(ByVal cmb As ComboBox, ByVal sSQL As String)
            con = New MySqlConnection(csstring)
            con.Open()
            cmd = New MySqlCommand(sSQL, con)
            dr = cmd.ExecuteReader()
            cmb.Items.Clear()
            While dr.Read()
                cmb.Items.AddRange(New Object() {dr(0).ToString()})
            End While
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
    End Sub
    Private Sub DuplicateRecord()
        con = New MySqlConnection(csstring)
        con.Open()
        strSQL = "Select * from tblschedule where starttime ='" & cboStart.Text.Trim & "'and endtime='" & cboEnd.Text.Trim & "'and subjects ='" & cboSubject.Text.Trim & "'AND days='" & cboDay.Text.Trim & "'AND roomno='" & cboRoom.Text.Trim & "'AND section='" & cboSection.Text.Trim & "'"
        cmd = New MySqlCommand(strSQL, con)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            MsgBox("Duplicate Record!", MsgBoxStyle.Critical, "Duplicate record")
        End If
        dr.Close()
        cmd.Dispose()
        If con.State <> ConnectionState.Open Then
            con.Close()
        End If
    End Sub
    Sub LoadRecords()
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Select * from tblSchedule"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            lvInfo.Items.Clear()
            While dr.Read
                Dim lv As ListViewItem = lvInfo.Items.Add(dr("schid").ToString())
                timestart = dr("starttime")
                timeend = dr("endtime")
                timefull = timestart + " - " + timeend
                lv.SubItems.Add(timefull)
                lv.SubItems.Add(dr("subjects").ToString())
                lv.SubItems.Add(dr("roomno").ToString())
                lv.SubItems.Add(dr("section").ToString())
                lv.SubItems.Add(dr("days").ToString())
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
    Sub ClearFields()
        txtschID.Text = ""
        cboEnd.SelectedIndex = -1
        cboRoom.SelectedIndex = -1
        cboSection.SelectedIndex = -1
        cboStart.SelectedIndex = -1
        cboSubject.SelectedIndex = -1
    End Sub
    Public Function RoomInUse() As Boolean
        con = New MySqlConnection(csstring)
        con.Open()
        strSQL = "Select *  from tblschedule where starttime='" & cboStart.Text.Trim & "'AND endtime='" & cboEnd.Text.Trim & "'AND days='" & cboDay.Text.Trim & "'AND roomno ='" & cboRoom.Text.Trim & "'"
        cmd = New MySqlCommand(strSQL, con)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Return True
        Else
            Return False
        End If
        dr.Close()
        cmd.Dispose()
        If con.State <> ConnectionState.Open Then
            con.Close()
        End If
    End Function
    Public Function DataInUse() As Boolean
        Dim temp As Boolean
        temp = False
        If RoomInUse() = True Then
            MsgBox(" " & cboRoom.Text & " in use!", MsgBoxStyle.Critical, "In-use")
            Call DisplayLabelConflictRoom()
            cboRoom.Focus()
            temp = True
        End If
        Return temp = True
    End Function
    Private Sub DisplayLabelConflictRoom()
        If lvInfo.Items.Count >= 1 Then
            txtStatus.Text = "Conflict schedule for room: " & cboRoom.Text
        Else
            txtStatus.Text = "No conflict"
        End If
    End Sub
    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        If txtschID.Text = "" OrElse cboEnd.Text = "" OrElse cboRoom.Text = "" OrElse cboSection.Text = "" OrElse cboStart.Text = "" OrElse cboSubject.Text = "" Then
            MsgBox("Please fill up all the required field(s)!", MsgBoxStyle.Critical, "Error")
        Else
            If btnGenerate.Text = "Generate" Then
                If DataInUse() = True Then
                    Call DuplicateRecord()
                Else
                    Try
                        con = New MySqlConnection(csstring)
                        con.Open()
                        strSQL = "Insert into tblschedule(schid, starttime, endtime, dateentry, subjects, roomno, section, days) values('" & txtschID.Text.Trim & "','" & _
                             cboStart.Text.Trim & "','" & _
                             cboEnd.Text.Trim & "','" & _
                             Format(Date.Now, "MMMM dd, yyyy") & "','" & _
                             cboSubject.Text.Trim & "','" & _
                             cboRoom.Text.Trim & "','" & _
                             cboSection.Text.Trim & "','" & _
                             cboDay.Text.Trim & "')"
                        cmd = New MySqlCommand(strSQL, con)
                        cmd.ExecuteNonQuery()
                        If con.State <> ConnectionState.Open Then
                            con.Close()
                        End If
                        MsgBox("Record has been added!", MsgBoxStyle.Information, "Added")
                        btnGenerate.Text = "Generate"
                        txtschID.Enabled = True
                        Call LoadRecords()
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                    End Try
                End If
            ElseIf btnGenerate.Text = "Update" Then
                con = New MySqlConnection(csstring)
                con.Open()
                strSQL = "Select * from tblschedule where starttime ='" & cboStart.Text.Trim & "'and endtime='" & cboEnd.Text.Trim & "'and subjects ='" & cboSubject.Text.Trim & "'AND days='" & cboDay.Text.Trim & "'AND roomno='" & cboRoom.Text.Trim & "'AND section='" & cboSection.Text.Trim & "'"
                cmd = New MySqlCommand(strSQL, con)
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    MsgBox("Duplicate Record!", MsgBoxStyle.Critical, "Duplicate record")
                    Exit Sub
                End If
                dr.Close()
                cmd.Dispose()
                If con.State <> ConnectionState.Open Then
                    con.Close()
                End If
                Try
                    con = New MySqlConnection(csstring)
                    con.Open()
                    strSQL = "update tblschedule set schid='" & txtschID.Text.Trim & _
                        "', starttime ='" & cboStart.Text.Trim & _
                        "', endtime ='" & cboEnd.Text.Trim & _
                        "', dateentry ='" & Format(Date.Now, "MMMM dd, yyyy") & _
                        "', subjects ='" & cboSubject.Text.Trim & _
                        "', roomno ='" & cboRoom.Text.Trim & _
                        "', section='" & cboSection.Text.Trim & _
                        "', days ='" & cboDay.Text.Trim & _
                        "'where schid ='" & txtschID.Text.Trim & "'"
                    cmd = New MySqlCommand(strSQL, con)
                    cmd.ExecuteNonQuery()
                    If con.State <> ConnectionState.Open Then
                        con.Close()
                    End If
                    MsgBox("Schedule has been updated!", MsgBoxStyle.Information, "Update")
                    Call LoadRecords()
                    btnGenerate.Text = "Generate"
                    txtschID.Enabled = True
                    Call ClearFields()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                End Try
            End If
        End If
    End Sub
    Private Sub cboSubject_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSubject.TextChanged
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Select description from tblsubject where description='" & cboSubject.Text.Trim & "'"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    cboSubject.Text = dr("description")
                End While
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
    Private Sub cboRoom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRoom.TextChanged
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Select room from tblroom where room='" & cboRoom.Text.Trim & "'"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    cboRoom.Text = dr("room")
                End While
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
    Private Sub cboSection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSection.TextChanged
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Select section from tblsection where section='" & cboSection.Text.Trim & "'"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    cboSection.Text = dr("section")
                End While
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

    Private Sub DELETEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DELETEToolStripMenuItem.Click
        Try
            If lvInfo.SelectedItems.Count > 0 Then
                con = New MySqlConnection(csstring)
                con.Open()
                strSQL = "Delete from tblschedule where schid ='" & lvInfo.SelectedItems(0).Text & "'"
                cmd = New MySqlCommand(strSQL, con)
                cmd.ExecuteNonQuery()
                If con.State <> ConnectionState.Open Then
                    con.Close()
                End If
                MsgBox("Succesffully deleted the records!", MsgBoxStyle.Information, "Delete Record")
                Call LoadRecords()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub lvInfo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvInfo.DoubleClick
        If lvInfo.SelectedItems.Count > 0 Then
            Try
                If lvInfo.SelectedItems.Count > 0 Then
                    con = New MySqlConnection(csstring)
                    con.Open()
                    strSQL = "Select * from tblschedule where schid='" & lvInfo.SelectedItems(0).Text & "'"
                    cmd = New MySqlCommand(strSQL, con)
                    dr = cmd.ExecuteReader
                    If dr.Read Then
                        txtschID.Text = dr("schid")
                        cboStart.Text = dr("starttime")
                        cboEnd.Text = dr("endtime")
                        cboDay.Text = dr("days")
                        txtschID.Enabled = False
                        btnGenerate.Text = "Update"
                    End If
                    dr.Close()
                    cmd.Dispose()
                    If con.State <> ConnectionState.Open Then
                        con.Close()
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub

    Private Sub txtSubject_TextChanged(sender As Object, e As EventArgs) Handles txtSubject.TextChanged
        If rboSubject.Checked = True Then
            Try
                con = New MySqlConnection(csstring)
                con.Open()
                strSQL = "Select * from tblschedule where subjects like '%" & txtSubject.Text.Trim & "%'"
                cmd = New MySqlCommand(strSQL, con)
                dr = cmd.ExecuteReader
                lvInfo.Items.Clear()
                While dr.Read
                    Dim lv As ListViewItem = lvInfo.Items.Add(dr("schid").ToString())
                    timestart = dr("starttime")
                    timeend = dr("endtime")
                    timefull = timestart + " - " + timeend
                    lv.SubItems.Add(timefull)
                    lv.SubItems.Add(dr("subjects").ToString())
                    lv.SubItems.Add(dr("roomno").ToString())
                    lv.SubItems.Add(dr("section").ToString())
                    lv.SubItems.Add(dr("days").ToString())
                End While
                dr.Close()
                cmd.Dispose()
                If con.State <> ConnectionState.Open Then
                    con.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub

    Private Sub rboSubject_CheckedChanged(sender As Object, e As EventArgs) Handles rboSubject.CheckedChanged
        If rboSubject.Checked = True Then
            rboSection.Checked = False
            txtSubject.Enabled = True
            txtSection.Enabled = False
            txtSection.Text = ""
        ElseIf rboSection.Checked = True Then
            rboSubject.Checked = False
            txtSection.Enabled = True
            txtSubject.Enabled = False
            txtSubject.Text = ""
        End If
    End Sub

    Private Sub rboSection_CheckedChanged(sender As Object, e As EventArgs) Handles rboSection.CheckedChanged
        If rboSection.Checked = True Then
            rboSubject.Checked = False
            txtSection.Enabled = True
            txtSubject.Enabled = False
            txtSubject.Text = ""
        ElseIf rboSubject.Checked = True Then
            rboSection.Checked = False
            txtSubject.Enabled = True
            txtSection.Enabled = False
            txtSection.Text = ""
        End If
    End Sub

    Private Sub txtSection_TextChanged(sender As Object, e As EventArgs) Handles txtSection.TextChanged
        If rboSection.Checked = True Then
            Try
                con = New MySqlConnection(csstring)
                con.Open()
                strSQL = "Select * from tblschedule where section like '%" & txtSection.Text.Trim & "%'"
                cmd = New MySqlCommand(strSQL, con)
                dr = cmd.ExecuteReader
                lvInfo.Items.Clear()
                While dr.Read
                    Dim lv As ListViewItem = lvInfo.Items.Add(dr("schid").ToString())
                    timestart = dr("starttime")
                    timeend = dr("endtime")
                    timefull = timestart + " - " + timeend
                    lv.SubItems.Add(timefull)
                    lv.SubItems.Add(dr("subjects").ToString())
                    lv.SubItems.Add(dr("roomno").ToString())
                    lv.SubItems.Add(dr("section").ToString())
                    lv.SubItems.Add(dr("days").ToString())
                End While
                dr.Close()
                cmd.Dispose()
                If con.State <> ConnectionState.Open Then
                    con.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Call ClearFields()
        btnGenerate.Text = "Generate"
        txtschID.Enabled = True
    End Sub
End Class