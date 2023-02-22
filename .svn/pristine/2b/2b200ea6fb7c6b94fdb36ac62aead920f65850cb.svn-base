Imports MySql.Data.MySqlClient
Public Class frmRoom
    Dim csstring As String = "server=localhost;uid=root;pwd=admin;database=ebulletindb;"
    Private Sub frmRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Sub ClearFields()
        txtRoomID.Text = ""
        txtRoom.Text = ""
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim res As New DialogResult
        res = MsgBox("Are you sure you want to continue to add the room?", vbYesNo + MsgBoxStyle.Information, "Add Room")
        If res = Windows.Forms.DialogResult.Yes Then
            Try
                con = New MySqlConnection(csstring)
                con.Open()
                strSQL = "select roomid from tblroom where roomid=@dupe"
                cmd = New MySqlCommand(strSQL)
                cmd.Connection = con
                cmd.Parameters.Add(New MySqlParameter("@dupe", MySqlDbType.VarChar, 100, "roomid"))
                cmd.Parameters("@dupe").Value = txtRoomID.Text
                dr = cmd.ExecuteReader
                If dr.Read() Then
                    MsgBox(" " & txtRoomID.Text & " is already existed!", MsgBoxStyle.Critical, "Already Exist")
                    txtRoomID.Text = ""
                    txtRoomID.Focus()
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
                strSQL = "Insert into tblroom(roomid, room) values('" & txtRoomID.Text.Trim & "','" & _
                    txtRoom.Text.Trim & "')"
                cmd = New MySqlCommand(strSQL, con)
                cmd.ExecuteNonQuery()
                If con.State <> ConnectionState.Open Then
                    con.Close()
                End If
                MsgBox(" " & txtRoom.Text & " has been added!", MsgBoxStyle.Information, "Save")
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