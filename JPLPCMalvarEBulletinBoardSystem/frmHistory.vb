﻿Imports MySql.Data.MySqlClient
Public Class frmHistory
    Dim csstring As String = "server=localhost;uid=root;pwd=admin;database=ebulletindb;"
    Private Sub frmHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LoadRecords()
    End Sub

    Sub LoadRecords()
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Select * from tblannouncement order by id desc"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            lvInfo.Items.Clear()
            While dr.Read
                Dim lv As ListViewItem = lvInfo.Items.Add(dr("id").ToString())
                lv.SubItems.Add(dr("message").ToString())
                lv.SubItems.Add(dr("dateentry").ToString())
                Dim tmpColor As New System.Drawing.Color
                tmpColor = Color.DarkGreen
                lvInfo.Items(0).BackColor = tmpColor
                lvInfo.Items(0).ForeColor = Color.White
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

    Private Sub dtpFilter_ValueChanged(sender As Object, e As EventArgs) Handles dtpFilter.ValueChanged
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Select * from tblannouncement where dateentry ='" & Format(dtpFilter.Value, "MMMM dd, yyyy") & "'order by id desc"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            lvInfo.Items.Clear()
            While dr.Read
                Dim lv As ListViewItem = lvInfo.Items.Add(dr("id").ToString())
                lv.SubItems.Add(dr("message").ToString())
                lv.SubItems.Add(dr("dateentry").ToString())
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

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Dim res As DialogResult
        res = MsgBox("Do you want to refresh the records?", vbYesNo + MsgBoxStyle.Information, "Refresh")
        If res = DialogResult.Yes Then
            MsgBox("Records has been refreshed.", MsgBoxStyle.Information, "Refresh")
            Call LoadRecords()
        End If
    End Sub
End Class