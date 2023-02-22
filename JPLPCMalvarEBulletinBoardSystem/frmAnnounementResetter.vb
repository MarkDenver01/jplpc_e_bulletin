﻿Imports MySql.Data.MySqlClient
Public Class frmAnnounementResetter
    Dim csstring As String = "server=localhost;uid=root;pwd=admin;database=ebulletindb;"
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        If rboA1.Checked = True Then
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "TRUNCATE TABLE tblnewannouncement"
            cmd = New MySqlCommand(strSQL, con)
            cmd.ExecuteNonQuery()
            MsgBox("Records has been successfully resetted!", MsgBoxStyle.Information, "Success")
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        ElseIf rboAReset.Checked = True Then
            Dim announce As frmAnnouncement = New frmAnnouncement
            announce.txtAnnouncement3.Text = ""
            MsgBox("Records has been successfully resetted!", MsgBoxStyle.Information, "Success")
        ElseIf rboPhotoReset.Checked = True Then
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "TRUNCATE TABLE tbleventphoto"
            cmd = New MySqlCommand(strSQL, con)
            cmd.ExecuteNonQuery()
            MsgBox("Records has been successfully resetted!", MsgBoxStyle.Information, "Success")
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        ElseIf rboResetAll.Checked = True Then
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "TRUNCATE TABLE tblnewannouncement"
            cmd = New MySqlCommand(strSQL, con)
            cmd.ExecuteNonQuery()

            If con.State <> ConnectionState.Open Then
                con.Close()
            End If

            Dim announce As frmAnnouncement = New frmAnnouncement
            announce.txtAnnouncement3.Text = ""

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "TRUNCATE TABLE tbleventphoto"
            cmd = New MySqlCommand(strSQL, con)
            cmd.ExecuteNonQuery()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "TRUNCATE TABLE tblfeedback"
            cmd = New MySqlCommand(strSQL, con)
            cmd.ExecuteNonQuery()

            If con.State <> ConnectionState.Open Then
                con.Close()
            End If

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "TRUNCATE TABLE tblnotifcourse"
            cmd = New MySqlCommand(strSQL, con)
            cmd.ExecuteNonQuery()

            If con.State <> ConnectionState.Open Then
                con.Close()
            End If


            MsgBox("Records has been successfully resetted!", MsgBoxStyle.Information, "Success")

        ElseIf rboFeedback.Checked = True Then
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "TRUNCATE TABLE tblfeedback"
            cmd = New MySqlCommand(strSQL, con)
            cmd.ExecuteNonQuery()

            MsgBox("Records has been successfully resetted!", MsgBoxStyle.Information, "Success")

            If con.State <> ConnectionState.Open Then
                con.Close()
            End If

        ElseIf rboCourse.Checked = True Then

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "TRUNCATE TABLE tblnotifcourse"
            cmd = New MySqlCommand(strSQL, con)
            cmd.ExecuteNonQuery()

            MsgBox("Records has been successfully resetted!", MsgBoxStyle.Information, "Success")

            If con.State <> ConnectionState.Open Then
                con.Close()
            End If

        End If
    End Sub
End Class