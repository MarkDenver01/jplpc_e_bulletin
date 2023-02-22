Imports MySql.Data.MySqlClient
Public Class frmPostAnnouncementEdit2
    Dim csstring As String = "server=localhost;uid=root;pwd=admin;database=ebulletindb;"
    Private Sub frmPostAnnouncementEdit2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LoadRecords()
    End Sub

    Sub LoadRecords()
        con = New MySqlConnection(csstring)
        con.Open()
        strSQL = "SELECT * FROM tblpost1 ORDER BY id ASC"
        cmd = New MySqlCommand(strSQL, con)
        dr = cmd.ExecuteReader
        lvRead.Items.Clear()
        While dr.Read
            Dim lv As ListViewItem = lvRead.Items.Add(dr("id").ToString())
            lv.SubItems.Add(dr("msg1").ToString())
            lv.SubItems.Add(dr("msg2").ToString())
            lv.SubItems.Add(dr("msg3").ToString())
            lv.SubItems.Add(dr("msg4").ToString())
            lv.SubItems.Add(dr("msg5").ToString())
        End While
        dr.Close()
        cmd.Dispose()
        If con.State <> ConnectionState.Open Then
            con.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If lvRead.Items.Count > 0 Then
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "DELETE FROM tblpost1 WHERE id ='" & lvRead.SelectedItems(0).Text & "'"
            cmd = New MySqlCommand(strSQL, con)
            cmd.ExecuteNonQuery()
            MsgBox("Record has been deleted!", MsgBoxStyle.Information, "Delete")
            Call LoadRecords()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        End If
    End Sub

    Private Sub btnUpdate3_Click(sender As Object, e As EventArgs) Handles btnUpdate3.Click
        If lvRead.Items.Count > 0 Then
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "SELECT * FROM tblpost1 WHERE id = '" & lvRead.SelectedItems(0).Text & "'"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            If dr.Read Then
                frmPostAnnouncement2.Label6.Text = dr("id").ToString()
                frmPostAnnouncement2.txtA1.Text = dr("msg1").ToString()
                frmPostAnnouncement2.txtA2.Text = dr("msg2").ToString()
                frmPostAnnouncement2.txtA3.Text = dr("msg3").ToString()
                frmPostAnnouncement2.txtA4.Text = dr("msg4").ToString()
                frmPostAnnouncement2.txtA5.Text = dr("msg5").ToString()
                frmPostAnnouncement2.btnPost.Text = "Update"
                frmPostAnnouncement2.ShowDialog()
            End If
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        End If
    End Sub
End Class