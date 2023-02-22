Imports MySql.Data.MySqlClient
Public Class frmAddPhonebook
    Dim csstring As String = "server=localhost;uid=root;pwd=admin;database=ebulletindb;"
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If String.IsNullOrEmpty(txtName.Text) OrElse String.IsNullOrEmpty(txtMobile.Text) OrElse String.IsNullOrEmpty(txtSection.Text) OrElse String.IsNullOrEmpty(cboGroup.Text) Then
                MsgBox("The fields cannot be emptied.", MsgBoxStyle.Exclamation, "Warning")
                Exit Sub
            End If

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "select name from tblphonebookall where name=@name"
            cmd = New MySqlCommand(strSQL)
            cmd.Connection = con
            cmd.Parameters.Add(New MySqlParameter("@name", MySqlDbType.VarChar, 100, "name"))
            cmd.Parameters("@name").Value = txtName.Text
            dr = cmd.ExecuteReader
            If dr.Read() Then
                MsgBox(" " & txtName.Text & " is already existed!", MsgBoxStyle.Critical, "Already Exist")
                txtName.Text = ""
                txtName.Focus()
                If (dr IsNot Nothing) Then
                    dr.Close()
                End If
                Return
            End If
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "select mnum from tblphonebookall where mnum=@mnum"
            cmd = New MySqlCommand(strSQL)
            cmd.Connection = con
            cmd.Parameters.Add(New MySqlParameter("@mnum", MySqlDbType.VarChar, 100, "mnum"))
            cmd.Parameters("@mnum").Value = txtMobile.Text
            dr = cmd.ExecuteReader
            If dr.Read() Then
                MsgBox(" " & txtMobile.Text & " is already existed!", MsgBoxStyle.Critical, "Already Exist")
                txtName.Text = ""
                txtName.Focus()
                If (dr IsNot Nothing) Then
                    dr.Close()
                End If
                Return
            End If
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Insert into tblphonebookall(name, mnum, section, groupby ) values('" & txtName.Text.Trim & "','" &
                txtMobile.Text.Trim & "','" &
                txtSection.Text.Trim & "','" &
                cboGroup.Text.Trim & "')"
            cmd = New MySqlCommand(strSQL, con)
            cmd.ExecuteNonQuery()
            txtMobile.Text = ""
            txtName.Text = ""
            txtSection.Text = ""
            cboGroup.SelectedIndex = -1
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
            MsgBox(" " & txtName.Text & " has been save on phonebook!", MsgBoxStyle.Information, "Phonebook")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub cboGroup_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGroup.SelectedIndexChanged
        If cboGroup.Text = "Faculty" Then
            GroupBox1.Height = 165
            GroupBox1.Width = 290
            btnSave.Location = New Point(8, 171)
            btnCancel.Location = New Point(8, 209)
            Me.Height = 290
            Me.Width = 323
            Label3.Visible = False
            txtSection.Visible = False
            txtSection.Text = "N/A"
        ElseIf cboGroup.Text = "Student" Then
            GroupBox1.Height = 215
            GroupBox1.Width = 290
            Me.Height = 335
            Me.Width = 323
            btnSave.Location = New Point(8, 217)
            btnCancel.Location = New Point(8, 255)
            Label3.Visible = True
            txtSection.Visible = True
            txtSection.Text = ""
        End If
    End Sub
End Class