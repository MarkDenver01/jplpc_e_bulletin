Imports MySql.Data.MySqlClient
Public Class frmView
    Dim csstring As String = "server=localhost;uid=root;pwd=admin;database=ebulletindb;"
    Private Sub frmView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LoadRecords()
    End Sub

    Sub LoadRecords()
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "SELECT * FROM tblsentitems ORDER BY id ASC"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            lvRead.Items.Clear()
            While dr.Read
                Dim lv As ListViewItem = lvRead.Items.Add(dr("id").ToString())
                lv.SubItems.Add(dr("mnum").ToString())
                lv.SubItems.Add(dr("messages").ToString())
                lv.SubItems.Add(dr("datesent").ToString())
                lv.SubItems.Add(dr("name").ToString())
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

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "SELECT * FROM tblsentitems WHERE datesent >='" & Format(dtpFrom.Value, "yyyy-MM-dd") & "'AND datesent <='" & Format(dtpTo.Value, "yyyy-MM-dd") & "'"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            lvRead.Items.Clear()
            While dr.Read
                Dim lv As ListViewItem = lvRead.Items.Add(dr("id").ToString())
                lv.SubItems.Add(dr("mnum").ToString())
                lv.SubItems.Add(dr("messages").ToString())
                lv.SubItems.Add(dr("datesent").ToString())
                lv.SubItems.Add(dr("name").ToString())
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call LoadRecords()
    End Sub
End Class