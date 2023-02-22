Imports MySql.Data.MySqlClient
Public Class frmPostAnnouncement3
    Dim csstring As String = "server=localhost;uid=root;pwd=admin;database=ebulletindb;"
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtA1.Text = ""
    End Sub

    Private Sub btnPost_Click(sender As Object, e As EventArgs) Handles btnPost.Click
        If ComboBox1.Text = "" Then
            MsgBox("Please select the position.", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If
        If btnPost.Text = "Post" Then
            If ComboBox1.Text = "Top-Center" Then
                con = New MySqlConnection(csstring)
                con.Open()
                strSQL = "UPDATE tblpositioncenter set posX='" & "474" & _
                    "',posY='" & "49" & _
                    "'WHERE status ='" & ComboBox1.Text & "'"
                cmd = New MySqlCommand(strSQL, con)
                cmd.ExecuteNonQuery()

                If con.State <> ConnectionState.Open Then
                    con.Close()
                End If

            ElseIf ComboBox1.Text = "Bottom-Center" Then
                con = New MySqlConnection(csstring)
                con.Open()
                strSQL = "UPDATE tblpositioncenter set posX='" & "474" & _
                 "',posY='" & "383" & _
                 "'WHERE status ='" & ComboBox1.Text & "'"
                cmd = New MySqlCommand(strSQL, con)
                cmd.ExecuteNonQuery()

                If con.State <> ConnectionState.Open Then
                    con.Close()
                End If

            End If

            If txtA1.Text = "" Then
                MsgBox("Please input the message.", MsgBoxStyle.Exclamation, "Warning")
                Exit Sub
            End If

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "INSERT INTO tblpost2(msg1, status) VALUES('" & txtA1.Text & "','" & ComboBox1.Text & "')"
            cmd = New MySqlCommand(strSQL, con)
            cmd.ExecuteNonQuery()
            MsgBox("Message has been posted in the bulletin board", MsgBoxStyle.Information, "Information")
            txtA1.Text = ""

            ComboBox1.SelectedIndex = -1
            frmPostAnnouncementEdit3.LoadRecords()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        ElseIf btnPost.Text = "Update" Then
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "UPDATE tblpost2 set msg1 ='" & txtA1.Text & _
                "'WHERE id = '" & Label1.Text & "'"
            cmd = New MySqlCommand(strSQL, con)
            cmd.ExecuteNonQuery()
            MsgBox("Record has been updated!", MsgBoxStyle.Information, "Information")
            frmPostAnnouncementEdit3.LoadRecords()
            txtA1.Text = ""
            btnPost.Text = "Post"
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Top-Center" Then
            frmAnnouncementCenter.txtA1.Location = New Point(474, 49)
        ElseIf ComboBox1.Text = "Bottom-Center" Then
            frmAnnouncementCenter.txtA1.Location = New Point(474, 383)
        End If
    End Sub
End Class