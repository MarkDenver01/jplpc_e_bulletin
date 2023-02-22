﻿Imports System
Imports System.IO
Imports MySql.Data.MySqlClient
Public Class frmAddPhoto
    Dim csstring As String = "server=localhost;uid=root;pwd=admin;database=ebulletindb;"
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        'Dim fdlg As OpenFileDialog = New OpenFileDialog()
        'fdlg.Title = "Choose a Profile Photo"
        'fdlg.InitialDirectory = "c:\"
        'fdlg.Filter = "Picture Files(*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
        'fdlg.FilterIndex = 2
        'fdlg.RestoreDirectory = True
        'If fdlg.ShowDialog() = DialogResult.OK Then
        '    If File.Exists(fdlg.FileName) = False Then
        '        MessageBox.Show("Sorry, The File You Specified Does Not Exist.")
        '    Else
        '        PictureBox1.ImageLocation = fdlg.FileName
        '        frmAnnouncement.PhotoEvent.ImageLocation = fdlg.FileName
        '    End If
        'End If
        ' If btnBrowse.Text = "BROWSE" Then
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Select * from tbleventphoto where id > 4"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            If dr.Read Then
                MsgBox("Storage has been exceeded.", MsgBoxStyle.Critical, "Exceed")
                Exit Sub
            End If
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        OpenDialog.FileName = ""
        OpenDialog.Filter = "Picture Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
        OpenDialog.ShowDialog()
        If OpenDialog.SafeFileName = "" Or OpenDialog.SafeFileName = " " Or OpenDialog.FileName.ToString = "" Or OpenDialog.FileName.ToString = " " Then
            Exit Sub
        End If
        If Not Directory.Exists(System.AppDomain.CurrentDomain.BaseDirectory & "Photos") = True Then
            Directory.CreateDirectory(System.AppDomain.CurrentDomain.BaseDirectory & "Photos")
        End If
        Try
            If Not Directory.Exists(System.AppDomain.CurrentDomain.BaseDirectory & "Photos\" & OpenDialog.SafeFileName) Then
                File.Copy(OpenDialog.FileName.ToString, System.AppDomain.CurrentDomain.BaseDirectory & "Photos\" & OpenDialog.SafeFileName)
                photoset = OpenDialog.SafeFileName
                PictureBox1.ImageLocation = System.AppDomain.CurrentDomain.BaseDirectory & "Photos\" & OpenDialog.SafeFileName
                con = New MySqlConnection(csstring)
                con.Open()
                strSQL = "insert into tbleventphoto(photos, dateentry, hours) values('" & photoset & "','" &
                    Format(Date.Today, "MMMM dd, yyyy") & "','" &
                    Format(Date.Now, "HH:mm:ss") & "')"
                cmd = New MySqlCommand(strSQL, con)
                cmd.ExecuteNonQuery()
                If con.State <> ConnectionState.Open Then
                    con.Close()
                End If
                Dim res As DialogResult
                res = MsgBox("[NOTE: The storage can accept 5 maximum photos only.]", vbYesNo + MsgBoxStyle.Information, "Save")
                If res = Windows.Forms.DialogResult.Yes Then
                    MsgBox("Event photo has been stored!", MsgBoxStyle.Information, "Photo Save")
                    Exit Sub
                End If
            Else
                MsgBox("There is already a file called " & photoset & " in the destination folder!", MsgBoxStyle.Critical, "Already Exist")
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        ' End If
    End Sub

    Private Sub frmAddPhoto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class