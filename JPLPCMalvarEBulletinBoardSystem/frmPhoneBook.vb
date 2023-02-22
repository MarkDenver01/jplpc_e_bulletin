﻿Imports MySql.Data.MySqlClient
Public Class frmPhoneBook
    Dim csstring As String = "server=localhost;uid=root;pwd=admin;database=ebulletindb;"
    Sub LoadRecords()
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Select * from tblphonebookall ORDER BY name ASC"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            lvPhoneBook.Items.Clear()
            While dr.Read
                Dim lv As ListViewItem = lvPhoneBook.Items.Add(dr("name").ToString())
                lv.SubItems.Add(dr("mnum").ToString())
                lv.SubItems.Add(dr("section").ToString())
                lv.SubItems.Add(dr("groupby").ToString())
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
    Private Sub tblPhoneBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LoadRecords()
    End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Select * from tblphonebookall where name like'%" & txtSearch.Text.Trim & "%'OR mnum like'%" & txtSearch.Text.Trim & "%'"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            lvPhoneBook.Items.Clear()
            While dr.Read
                Dim lv As ListViewItem = lvPhoneBook.Items.Add(dr("name").ToString())
                lv.SubItems.Add(dr("mnum").ToString())
                lv.SubItems.Add(dr("section").ToString())
                lv.SubItems.Add(dr("groupby").ToString())
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
    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        If lvPhoneBook.Items.Count = 0 Then
            MsgBox("No records on phonebook.", MsgBoxStyle.Critical, "No Records")
            Exit Sub
        End If
        If lvPhoneBook.SelectedItems.Count = 0 Then
            MsgBox("No record selected!", MsgBoxStyle.Critical, "No Selected Record")
            Exit Sub
        End If
        frmSMSNotification.txtSmsno.Text = TextBox1.Text
        Me.Close()
    End Sub
    Private Sub lvPhoneBook_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvPhoneBook.SelectedIndexChanged
        If lvPhoneBook.SelectedItems.Count > 0 Then
            TextBox1.Text = lvPhoneBook.SelectedItems(0).SubItems(1).Text
        End If
    End Sub

    Private Sub rboStudent_CheckedChanged(sender As Object, e As EventArgs) Handles rboStudent.CheckedChanged
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Select * from tblphonebookall where groupby ='" & "Student" & "'"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            lvPhoneBook.Items.Clear()
            While dr.Read
                Dim lv As ListViewItem = lvPhoneBook.Items.Add(dr("name").ToString())
                lv.SubItems.Add(dr("mnum").ToString())
                lv.SubItems.Add(dr("section").ToString())
                lv.SubItems.Add(dr("groupby").ToString())
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

    Private Sub rboFaculty_CheckedChanged(sender As Object, e As EventArgs) Handles rboFaculty.CheckedChanged
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Select * from tblphonebookall where groupby ='" & "Faculty" & "'"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            lvPhoneBook.Items.Clear()
            While dr.Read
                Dim lv As ListViewItem = lvPhoneBook.Items.Add(dr("name").ToString())
                lv.SubItems.Add(dr("mnum").ToString())
                lv.SubItems.Add(dr("section").ToString())
                lv.SubItems.Add(dr("groupby").ToString())
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

    Private Sub rboAll_CheckedChanged(sender As Object, e As EventArgs) Handles rboAll.CheckedChanged
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Select * from tblphonebookall ORDER BY name ASC"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            lvPhoneBook.Items.Clear()
            While dr.Read
                Dim lv As ListViewItem = lvPhoneBook.Items.Add(dr("name").ToString())
                lv.SubItems.Add(dr("mnum").ToString())
                lv.SubItems.Add(dr("section").ToString())
                lv.SubItems.Add(dr("groupby").ToString())
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
End Class