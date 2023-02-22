Imports MySql.Data.MySqlClient
Public Class frmPostAnnouncement2
    Dim csstring As String = "server=localhost;uid=root;pwd=admin;database=ebulletindb;"
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtA1.Text = ""
        txtA2.Text = ""
        txtA3.Text = ""
        txtA4.Text = ""
        txtA5.Text = ""
        btnPost.Text = "Post"
    End Sub

    Private Sub btnPost_Click(sender As Object, e As EventArgs) Handles btnPost.Click
        If btnPost.Text = "Post" Then
            If txtA1.Text = "" OrElse txtA2.Text = "" OrElse txtA3.Text = "" OrElse txtA4.Text = "" OrElse txtA5.Text = "" Then
                MsgBox("Please input the message in the text field.", MsgBoxStyle.Exclamation, "Warning")
                Exit Sub
            End If
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "INSERT INTO tblpost1(msg1, msg2, msg3, msg4, msg5) VALUES('" & txtA1.Text & "','" & _
                txtA2.Text & "','" & _
                txtA3.Text & "','" & _
                txtA4.Text & "','" & _
                txtA5.Text & "')"
            cmd = New MySqlCommand(strSQL, con)
            cmd.ExecuteNonQuery()
            MsgBox("Message has been posted to the bulletin board.", MsgBoxStyle.Information, "Information")
            Call frmPostAnnouncementEdit2.LoadRecords()
            txtA1.Text = ""
            txtA2.Text = ""
            txtA3.Text = ""
            txtA4.Text = ""
            txtA5.Text = ""
         
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        ElseIf btnPost.Text = "Update" Then
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "UPDATE tblpost1 set msg1 = '" & txtA1.Text & _
                "', msg2 ='" & txtA2.Text & _
                "', msg3 ='" & txtA3.Text & _
                "', msg4 = '" & txtA4.Text & _
                "', msg5 = '" & txtA5.Text & _
                "'WHERE id ='" & Label6.Text & "'"
            cmd = New MySqlCommand(strSQL, con)
            cmd.ExecuteNonQuery()
            MsgBox("Update has been record!", MsgBoxStyle.Information, "Information")
            frmPostAnnouncementEdit2.LoadRecords()
            btnPost.Text = "Post"
            txtA1.Text = ""
            txtA2.Text = ""
            txtA3.Text = ""
            txtA4.Text = ""
            txtA5.Text = ""
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        End If
    End Sub

    Private Sub frmPostAnnouncement2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class