Imports MySql.Data.MySqlClient

Public Class frmListBirthday
    Dim csstring As String = "server=localhost;uid=root;pwd=admin;database=ebulletindb;"
    Private Sub frmListBirthday_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LoadRecords()
    End Sub

    Sub LoadRecords()
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "SELECT * FROM tblbirthday ORDER BY id ASC"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            lvRead.Items.Clear()
            While dr.Read
                Dim lv As ListViewItem = lvRead.Items.Add(dr("id").ToString())
                lv.SubItems.Add(dr("name").ToString())
                lv.SubItems.Add(dr("dateofbirth").ToString())
            End While
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If lvRead.Items.Count = 0 Then
            MsgBox("No records found", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If

        If lvRead.SelectedItems.Count > 1 Then
            MsgBox("Please select 1 record only!", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If

        If lvRead.SelectedItems.Count = 0 Then
            MsgBox("No record selected!", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If

        If lvRead.Items.Count > 0 Then
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "DELETE FROM tblbirthday WHERE id ='" & lvRead.SelectedItems(0).Text & "'"
            cmd = New MySqlCommand(strSQL, con)
            cmd.ExecuteNonQuery()
            MsgBox("Record has been deleted!", MsgBoxStyle.Information, "Information")
            Call LoadRecords()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        End If

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If lvRead.Items.Count = 0 Then
            MsgBox("No records found", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If

        If lvRead.SelectedItems.Count > 1 Then
            MsgBox("Please select 1 record only!", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If

        If lvRead.SelectedItems.Count = 0 Then
            MsgBox("No record selected!", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If

        If lvRead.Items.Count > 0 Then
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "SELECT * FROM tblbirthday WHERE id ='" & lvRead.SelectedItems(0).Text & "'"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            If dr.Read Then
                frmConfiguration.id.Text = dr("id").ToString()
                frmConfiguration.TextBox1.Text = dr("name").ToString()
                frmConfiguration.DateTimePicker1.Value = dr("dateofbirth").ToString()
                frmConfiguration.Button1.Text = "UPDATE"
                Me.Close()
            End If
        End If
    End Sub


    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        con = New MySqlConnection(csstring)
        con.Open()
        strSQL = "SELECT * FROM tblbirthday WHERE name like'%" & txtName.Text & "%'"
        cmd = New MySqlCommand(strSQL, con)
        dr = cmd.ExecuteReader
        lvRead.Items.Clear()
        While dr.Read
            Dim lv As ListViewItem = lvRead.Items.Add(dr("id").ToString())
            lv.SubItems.Add(dr("name").ToString())
            lv.SubItems.Add(dr("dateofbirth").ToString())
        End While
        dr.Close()
        cmd.Dispose()
        If con.State <> ConnectionState.Open Then
            con.Close()
        End If
    End Sub
End Class