Imports MySql.Data.MySqlClient

Public Class frmListPhoto

    Dim csstring As String = "server=localhost;uid=root;pwd=admin;database=ebulletindb;"

    Private Sub frmListPhoto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LoadRecords()
    End Sub

    Sub LoadRecords()
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "SELECT * FROM tbleventphoto ORDER BY id ASC"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            lvRead.Items.Clear()
            While dr.Read
                Dim lv As ListViewItem = lvRead.Items.Add(dr("id").ToString())
                lv.SubItems.Add(dr("photos").ToString())
            End While
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If lvRead.Items.Count = 0 Then
            MsgBox("No records in photo list.", MsgBoxStyle.Critical, "No Records")
            Exit Sub
        End If
        If lvRead.SelectedItems.Count = 0 Then
            MsgBox("No record selected!", MsgBoxStyle.Critical, "No Selected Record")
            Exit Sub
        End If
        If lvRead.Items.Count > 0 Then
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "DELETE FROM tbleventphoto WHERE id ='" & lvRead.SelectedItems(0).Text & "'"
            cmd = New MySqlCommand(strSQL, con)
            cmd.ExecuteNonQuery()
            MsgBox("One photo has been deleted.", MsgBoxStyle.Information, "Success")
            Call LoadRecords()

            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        End If
    End Sub
End Class