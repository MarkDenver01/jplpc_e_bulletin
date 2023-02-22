Imports MySql.Data.MySqlClient
Public Class frmNotification
    Dim csstring As String = "server=localhost;uid=root;pwd=admin;database=ebulletindb;"
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim res As DialogResult
        res = MsgBox("Do you want to post this message?", vbYesNo + MsgBoxStyle.Information, "Post")
        If res = DialogResult.Yes Then
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "INSERT INTO tblnotifcourse(department, message, dateentry) VALUES('" & cboDepartment.Text & "','" &
                txtMessage.Text & "','" &
                Format(Date.Now, "yyyy-MM-dd HH:mm:ss") & "')"
            cmd = New MySqlCommand(strSQL, con)
            cmd.ExecuteNonQuery()
            MsgBox("The message has been posted in the e-bulletin board.", MsgBoxStyle.Information, "Success")
            txtMessage.Text = ""
            cboDepartment.SelectedIndex = -1
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cboDepartment.SelectedIndex = -1
        txtMessage.Text = ""
    End Sub
End Class