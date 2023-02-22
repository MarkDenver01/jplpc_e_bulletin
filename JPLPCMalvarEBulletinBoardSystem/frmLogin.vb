Imports MySql.Data.MySqlClient
Public Class frmLogin
    Dim csstring As String = "server=localhost;uid=root;pwd=admin;database=ebulletindb;"
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "" OrElse txtPassword.Text = "" Then
            MsgBox("Please input the username or password in the missing field!", MsgBoxStyle.Critical, "Empty Error")
        Else
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Select * from tbluserlog where username='" & txtUsername.Text.Trim & "'and password='" & txtPassword.Text.Trim & "'"
                cmd = New MySqlCommand(strSQL, con)
                dr = cmd.ExecuteReader
                If dr.Read Then
                    txtUsername.Text = dr("username")
                    txtPassword.Text = dr("password")
                    MsgBox("" & txtUsername.Text & " has been logged in successful!", MsgBoxStyle.Information, "Log in")
                    frmMain.ToolStripMenuItem3.Text = "ACCOUNT SETTINGS"
                    frmMain.AdministratorToolStripMenuItem.Text = "LOG OUT"
                    frmMain.NOTIFICATIONToolStripMenuItem.Visible = True
                    frmMain.MASTERENTRYToolStripMenuItem.Visible = True
                    frmMain.THEMESToolStripMenuItem.Visible = True
                    frmMain.EXITToolStripMenuItem.Visible = False
                    frmMain.lblNotify.Visible = True
                    txtUsername.Text = ""
                    txtPassword.Text = ""
                    Me.Close()
                Else
                    MsgBox("Access denied!", MsgBoxStyle.Critical, "Login failed")
                End If
                dr.Close()
                cmd.Dispose()
                If con.State <> ConnectionState.Open Then
                    con.Close()
                End If
        Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtUsername.Text = ""
        txtPassword.Text = ""
    End Sub
End Class