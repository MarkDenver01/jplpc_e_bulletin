Imports MySql.Data.MySqlClient
Public Class frmSubjects
    Dim csstring As String = "server=localhost;uid=root;pwd=admin;database=ebulletindb;"
    Private Sub frmSubjects_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Sub ClearFields()
        txtSubject.Text = ""
        txtDescription.Text = ""
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim res As New DialogResult
        res = MsgBox("Are you sure you want to continue to add the subject?", vbYesNo + MsgBoxStyle.Information, "Add Room")
        If res = Windows.Forms.DialogResult.Yes Then
            Try
                con = New MySqlConnection(csstring)
                con.Open()
                strSQL = "select subjcode from tblsubject where subjcode=@dupe"
                cmd = New MySqlCommand(strSQL)
                cmd.Connection = con
                cmd.Parameters.Add(New MySqlParameter("@dupe", MySqlDbType.VarChar, 100, "subjcode"))
                cmd.Parameters("@dupe").Value = txtSubject
                dr = cmd.ExecuteReader
                If dr.Read() Then
                    MsgBox(" " & txtSubject.Text & " is already existed!", MsgBoxStyle.Critical, "Already Exist")
                    txtSubject.Text = ""
                    txtSubject.Focus()
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
                strSQL = "Insert into tblsubject(subjcode, description) values('" & txtSubject.Text.Trim & "','" & _
                    txtDescription.Text.Trim & "')"
                cmd = New MySqlCommand(strSQL, con)
                cmd.ExecuteNonQuery()
                If con.State <> ConnectionState.Open Then
                    con.Close()
                End If
                MsgBox(" " & txtSubject.Text & " has been added!", MsgBoxStyle.Information, "Save")
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