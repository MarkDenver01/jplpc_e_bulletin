Imports MySql.Data.MySqlClient
Public Class frmPhotoPostEdit
    Dim csstring As String = "server=localhost;uid=root;pwd=admin;database=ebulletindb;"
    Private Sub frmPhotoPostEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LoadRecords()
    End Sub

    Sub LoadRecords()
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "SELECT * FROM tblphotoannouncement ORDER BY id ASC"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            lvRead.Items.Clear()
            While dr.Read
                Dim lv As ListViewItem = lvRead.Items.Add(dr("id").ToString())
                lv.SubItems.Add(dr("photoentry1").ToString())
                lv.SubItems.Add(dr("postentry").ToString())
                lv.SubItems.Add(dr("sizeentry").ToString())
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
            MsgBox("No records found!", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If
        If lvRead.Items.Count > 0 Then
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "DELETE FROM tblphotoannouncement WHERE id ='" & lvRead.SelectedItems(0).Text & "'"
            cmd = New MySqlCommand(strSQL, con)
            cmd.ExecuteNonQuery()
            MsgBox("Record has been deleted", MsgBoxStyle.Information, "Delete")
            Call LoadRecords()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        End If

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If lvRead.Items.Count > 0 Then
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "SELECT * FROM tblphotoannouncement WHERE id ='" & lvRead.SelectedItems(0).Text & "'"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            If dr.Read Then
                frmPhotoPost.Label4.Text = dr("id").ToString()
                photoset1 = dr("photoentry1").ToString()
                photoset2 = dr("photoentry2").ToString()
                photoset3 = dr("photoentry3").ToString()
                photoset4 = dr("photoentry4").ToString()
                photoset5 = dr("photoentry5").ToString()
                frmPhotoPost.txtAnnouncement.Text = dr("postentry").ToString()
                frmPhotoPost.cboSize.Text = dr("sizeentry").ToString()
                frmPhotoPost.PictureBox2.ImageLocation = System.AppDomain.CurrentDomain.BaseDirectory & "Photos\images\" & photoset1
                frmPhotoPost.PictureBox3.ImageLocation = System.AppDomain.CurrentDomain.BaseDirectory & "Photos\images\" & photoset2
                frmPhotoPost.PictureBox4.ImageLocation = System.AppDomain.CurrentDomain.BaseDirectory & "Photos\images\" & photoset3
                frmPhotoPost.PictureBox5.ImageLocation = System.AppDomain.CurrentDomain.BaseDirectory & "Photos\images\" & photoset4
                frmPhotoPost.PictureBox6.ImageLocation = System.AppDomain.CurrentDomain.BaseDirectory & "Photos\images\" & photoset5
                frmPhotoPost.btnPost.Enabled = True
                frmPhotoPost.btnPost.Text = "UPDATE"

                frmPhotoPost.ShowDialog()
            End If
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        End If
    End Sub
End Class