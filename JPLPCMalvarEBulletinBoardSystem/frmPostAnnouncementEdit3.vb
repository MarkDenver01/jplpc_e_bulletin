Imports MySql.Data.MySqlClient
Public Class frmPostAnnouncementEdit3
    Dim csstring As String = "server=localhost;uid=root;pwd=admin;database=ebulletindb;"
    Private Sub frmPostAnnouncementEdit3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LoadRecords()
    End Sub

    Sub LoadRecords()
        con = New MySqlConnection(csstring)
        con.Open()
        strSQL = "SELECT * FROM tblpost2 ORDER BY id ASC"
        cmd = New MySqlCommand(strSQL, con)
        dr = cmd.ExecuteReader
        lvRead.Items.Clear()
        While dr.Read
            Dim lv As ListViewItem = lvRead.Items.Add(dr("id").ToString())
            lv.SubItems.Add(dr("msg1").ToString())
        End While
        dr.Close()
        cmd.Dispose()
        If con.State <> ConnectionState.Open Then
            con.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If lvRead.Items.Count = 0 Then
            MsgBox("No record found!", MsgBoxStyle.Exclamation, "No Records")
            Exit Sub
        End If
        If lvRead.Items.Count > 0 Then
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "DELETE FROM tblpost2 WHERE id ='" & lvRead.SelectedItems(0).Text & "'"
            cmd = New MySqlCommand(strSQL, con)
            cmd.ExecuteNonQuery()
            MsgBox("Record has been deleted!", MsgBoxStyle.Information, "Information")
            Call LoadRecords()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        End If
    End Sub

    Private Sub btnUpdate3_Click(sender As Object, e As EventArgs) Handles btnUpdate3.Click
        If lvRead.Items.Count = 0 Then
            MsgBox("No records not found!", MsgBoxStyle.Information, "No Records")
            Exit Sub
        End If
        If lvRead.Items.Count > 0 Then
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "SELECT * FROM tblpost2 WHERE ID ='" & lvRead.SelectedItems(0).Text & "'"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            If dr.Read Then
                frmPostAnnouncement3.Label1.Text = dr("id").ToString()
                frmPostAnnouncement3.txtA1.Text = dr("msg1".ToString())
                frmPostAnnouncement3.btnPost.Text = "Update"
                frmPostAnnouncement3.ShowDialog()
            End If
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        End If
    End Sub
End Class