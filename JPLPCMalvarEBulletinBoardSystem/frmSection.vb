Imports MySql.Data.MySqlClient
Public Class frmSection
    Dim csstring As String = "server=localhost;uid=root;pwd=admin;database=ebulletindb;"
    Sub ClearFields()
        txtSection.Text = ""
        txtSectionID.Text = ""
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim res As New DialogResult
        res = MsgBox("Are you sure you want to continue to add the section?", vbYesNo + MsgBoxStyle.Information, "Add Room")
        If res = Windows.Forms.DialogResult.Yes Then
            Try
                con = New MySqlConnection(csstring)
                con.Open()
                strSQL = "select sectionid from tblsection where sectionid=@dupe"
                cmd = New MySqlCommand(strSQL)
                cmd.Connection = con
                cmd.Parameters.Add(New MySqlParameter("@dupe", MySqlDbType.VarChar, 100, "sectionid"))
                cmd.Parameters("@dupe").Value = txtSectionID
                dr = cmd.ExecuteReader
                If dr.Read() Then
                    MsgBox(" " & txtSectionID.Text & " is already existed!", MsgBoxStyle.Critical, "Already Exist")
                    txtSectionID.Text = ""
                    txtSectionID.Focus()
                    If (dr IsNot Nothing) Then
                        dr.Close()
                    End If
                    Return
                End If
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con = New MySqlConnection(csstring)
                con.Open()
                strSQL = "Insert into tblsection(sectionid, section) values('" & txtSectionID.Text.Trim & "','" & _
                    txtSection.Text.Trim & "')"
                cmd = New MySqlCommand(strSQL, con)
                cmd.ExecuteNonQuery()
                If con.State <> ConnectionState.Open Then
                    con.Close()
                End If
                MsgBox(" " & txtSection.Text & " has been added!", MsgBoxStyle.Information, "Save")
                Call ClearFields()
                Me.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Call ClearFields()
    End Sub
End Class