Imports MySql.Data.MySqlClient
Public Class frmAnnouncementDragnDrop
    Inherits System.Windows.Forms.Form
    Dim csstring As String = "server=localhost;uid=root;pwd=admin;database=ebulletindb;"
    Private Sub ShortcutToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmDragNDropObject.Show()
    End Sub

    Public txt1X, txt1Y
    Dim p1, p2, p3, p4, p5
    Dim pa1, pa2, pa3
    Public status1 As String = String.Empty
    Public status2 As String = String.Empty
    Public status3 As String = String.Empty
    Public status4 As String = String.Empty
    Public status5 As String = String.Empty

    Public stat1 As String = String.Empty
    Public stat2 As String = String.Empty
    Public stat3 As String = String.Empty
    Public stat4 As String = String.Empty
    Public stat5 As String = String.Empty

    Public ps1 As String = String.Empty
    Public ps2 As String = String.Empty
    Public ps3 As String = String.Empty

    Public strLbl1 As String = String.Empty
    Public strLbl2 As String = String.Empty

    'Record Objects


    Sub resetObjectSize()
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Update tbltextsize set height ='" & "0" & _
                "', width = '" & "0" & _
                "'WHERE status ='" & "txt1" & "'"
            cmd = New MySqlCommand(strSQL, con)
            cmd.ExecuteNonQuery()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Update tbltextsize set height ='" & "0" & _
                "', width = '" & "0" & _
                "'WHERE status ='" & "txt2" & "'"
            cmd = New MySqlCommand(strSQL, con)
            cmd.ExecuteNonQuery()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Update tbltextsize set height ='" & "0" & _
                "', width = '" & "0" & _
                "'WHERE status ='" & "txt3" & "'"
            cmd = New MySqlCommand(strSQL, con)
            cmd.ExecuteNonQuery()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Update tbltextsize set height ='" & "0" & _
                "', width = '" & "0" & _
                "'WHERE status ='" & "txt4" & "'"
            cmd = New MySqlCommand(strSQL, con)
            cmd.ExecuteNonQuery()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Update tbltextsize set height ='" & "0" & _
                "', width = '" & "0" & _
                "'WHERE status ='" & "txt5" & "'"
            cmd = New MySqlCommand(strSQL, con)
            cmd.ExecuteNonQuery()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Update tbltextsize set height ='" & "0" & _
                "', width = '" & "0" & _
                "'WHERE status ='" & "pic1" & "'"
            cmd = New MySqlCommand(strSQL, con)
            cmd.ExecuteNonQuery()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Update tbltextsize set height ='" & "0" & _
                "', width = '" & "0" & _
                "'WHERE status ='" & "pic2" & "'"
            cmd = New MySqlCommand(strSQL, con)
            cmd.ExecuteNonQuery()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Update tbltextsize set height ='" & "0" & _
                "', width = '" & "0" & _
                "'WHERE status ='" & "pic3" & "'"
            cmd = New MySqlCommand(strSQL, con)
            cmd.ExecuteNonQuery()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Update tbltextsize set height ='" & "0" & _
                "', width = '" & "0" & _
                "'WHERE status ='" & "pic4" & "'"
            cmd = New MySqlCommand(strSQL, con)
            cmd.ExecuteNonQuery()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Update tbltextsize set height ='" & "0" & _
                "', width = '" & "0" & _
                "'WHERE status ='" & "pic5" & "'"
            cmd = New MySqlCommand(strSQL, con)
            cmd.ExecuteNonQuery()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Update tbltextsize set height ='" & "0" & _
                "', width = '" & "0" & _
                "'WHERE status ='" & "ps1" & "'"
            cmd = New MySqlCommand(strSQL, con)
            cmd.ExecuteNonQuery()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Update tbltextsize set height ='" & "0" & _
                "', width = '" & "0" & _
                "'WHERE status ='" & "ps2" & "'"
            cmd = New MySqlCommand(strSQL, con)
            cmd.ExecuteNonQuery()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Update tbltextsize set height ='" & "0" & _
                "', width = '" & "0" & _
                "'WHERE status ='" & "ps3" & "'"
            cmd = New MySqlCommand(strSQL, con)
            cmd.ExecuteNonQuery()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If


        Catch
            Return
        End Try
    End Sub
    Sub resetObjectsLoader()
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Update tbltextlocation set txt1X = '" & "-1000" & _
                "', txt1Y ='" & "-1000" & _
                "'WHERE status='" & "txt1" & "'"
            cmd = New MySqlCommand(strSQL, con)
            cmd.ExecuteNonQuery()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Update tbltextlocation set txt1X = '" & "-1000" & _
                "', txt1Y ='" & "-1000" & _
                "'WHERE status='" & "txt2" & "'"
            cmd = New MySqlCommand(strSQL, con)
            cmd.ExecuteNonQuery()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Update tbltextlocation set txt1X = '" & "-1000" & _
                "', txt1Y ='" & "-1000" & _
                "'WHERE status='" & "txt3" & "'"
            cmd = New MySqlCommand(strSQL, con)
            cmd.ExecuteNonQuery()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Update tbltextlocation set txt1X = '" & "-1000" & _
                "', txt1Y ='" & "-1000" & _
                "'WHERE status='" & "txt4" & "'"
            cmd = New MySqlCommand(strSQL, con)
            cmd.ExecuteNonQuery()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Update tbltextlocation set txt1X = '" & "-1000" & _
                "', txt1Y ='" & "-1000" & _
                "'WHERE status='" & "txt5" & "'"
            cmd = New MySqlCommand(strSQL, con)
            cmd.ExecuteNonQuery()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Update tbltextlocation set txt1X = '" & "-1000" & _
                "', txt1Y ='" & "-1000" & _
                "'WHERE status='" & "pic1" & "'"
            cmd = New MySqlCommand(strSQL, con)
            cmd.ExecuteNonQuery()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Update tbltextlocation set txt1X = '" & "-1000" & _
                "', txt1Y ='" & "-1000" & _
                "'WHERE status='" & "pic2" & "'"
            cmd = New MySqlCommand(strSQL, con)
            cmd.ExecuteNonQuery()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Update tbltextlocation set txt1X = '" & "-1000" & _
                "', txt1Y ='" & "-1000" & _
                "'WHERE status='" & "pic3" & "'"
            cmd = New MySqlCommand(strSQL, con)
            cmd.ExecuteNonQuery()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Update tbltextlocation set txt1X = '" & "-1000" & _
                "', txt1Y ='" & "-1000" & _
                "'WHERE status='" & "pic4" & "'"
            cmd = New MySqlCommand(strSQL, con)
            cmd.ExecuteNonQuery()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Update tbltextlocation set txt1X = '" & "-1000" & _
                "', txt1Y ='" & "-1000" & _
                "'WHERE status='" & "pic5" & "'"
            cmd = New MySqlCommand(strSQL, con)
            cmd.ExecuteNonQuery()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Update tbltextlocation set txt1X = '" & "-1000" & _
                "', txt1Y ='" & "-1000" & _
                "'WHERE status='" & "ps1" & "'"
            cmd = New MySqlCommand(strSQL, con)
            cmd.ExecuteNonQuery()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Update tbltextlocation set txt1X = '" & "-1000" & _
                "', txt1Y ='" & "-1000" & _
                "'WHERE status='" & "ps2" & "'"
            cmd = New MySqlCommand(strSQL, con)
            cmd.ExecuteNonQuery()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Update tbltextlocation set txt1X = '" & "-1000" & _
                "', txt1Y ='" & "-1000" & _
                "'WHERE status='" & "ps3" & "'"
            cmd = New MySqlCommand(strSQL, con)
            cmd.ExecuteNonQuery()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Update tbltextlocation set txt1X = '" & "-1000" & _
                "', txt1Y ='" & "-1000" & _
                "'WHERE status='" & "l1" & "'"
            cmd = New MySqlCommand(strSQL, con)
            cmd.ExecuteNonQuery()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Update tbltextlocation set txt1X = '" & "-1000" & _
                "', txt1Y ='" & "-1000" & _
                "'WHERE status='" & "l2" & "'"
            cmd = New MySqlCommand(strSQL, con)
            cmd.ExecuteNonQuery()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If

            MsgBox("Object has been refreshed!", MsgBoxStyle.Information, "Information")

        Catch
            Return
        End Try
    End Sub

    Private Sub frmAnnouncementDragnDrop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AllowDrop = True
        Panel2.Visible = False
        MenuStrip2.Visible = False
        Timer3.Enabled = True
        Timer1.Start()
        'Timer2.Interval = 10000
        'Timer2.Start()
    End Sub

    Sub LoadLocation()
        Try


            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "SELECT * FROM tbltextlocation WHERE status ='" & "txt1" & "'"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            If dr.Read Then
                TextBox1.Location = New Point(dr("txt1X"), dr("txt1Y"))
                TextBox1.Visible = True
            End If
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "SELECT * FROM tbltextlocation WHERE status ='" & "txt2" & "'"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            If dr.Read Then
                TextBox2.Location = New Point(dr("txt1X"), dr("txt1Y"))
                TextBox2.Visible = True
            End If
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "SELECT * FROM tbltextlocation WHERE status ='" & "txt3" & "'"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            If dr.Read Then
                TextBox3.Location = New Point(dr("txt1X"), dr("txt1Y"))
                TextBox3.Visible = True
            End If
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "SELECT * FROM tbltextlocation WHERE status ='" & "txt4" & "'"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            If dr.Read Then
                TextBox4.Location = New Point(dr("txt1X"), dr("txt1Y"))
                TextBox4.Visible = True
            End If
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If


            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "SELECT * FROM tbltextlocation WHERE status ='" & "txt5" & "'"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            If dr.Read Then
                TextBox5.Location = New Point(dr("txt1X"), dr("txt1Y"))
                TextBox5.Visible = True
            End If
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If

            '------------Panel
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "SELECT * FROM tbltextlocation WHERE status ='" & "pic1" & "'"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            If dr.Read Then
                PictureBox1.Location = New Point(dr("txt1X"), dr("txt1Y"))
                PictureBox1.Visible = True
            End If
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "SELECT * FROM tbltextlocation WHERE status ='" & "pic2" & "'"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            If dr.Read Then
                PictureBox2.Location = New Point(dr("txt1X"), dr("txt1Y"))
                PictureBox2.Visible = True
            End If
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "SELECT * FROM tbltextlocation WHERE status ='" & "pic3" & "'"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            If dr.Read Then
                PictureBox3.Location = New Point(dr("txt1X"), dr("txt1Y"))
                PictureBox3.Visible = True
            End If
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If


            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "SELECT * FROM tbltextlocation WHERE status ='" & "pic4" & "'"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            If dr.Read Then
                PictureBox4.Location = New Point(dr("txt1X"), dr("txt1Y"))
                PictureBox4.Visible = True
            End If
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If


            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "SELECT * FROM tbltextlocation WHERE status ='" & "pic5" & "'"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            If dr.Read Then
                PictureBox5.Location = New Point(dr("txt1X"), dr("txt1Y"))
                PictureBox5.Visible = True
            End If
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If


            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "SELECT * FROM tbltextlocation WHERE status ='" & "ps1" & "'"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            If dr.Read Then
                Panel3.Location = New Point(dr("txt1X"), dr("txt1Y"))
                Panel3.Visible = True
            End If
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "SELECT * FROM tbltextlocation WHERE status ='" & "ps2" & "'"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            If dr.Read Then
                Panel4.Location = New Point(dr("txt1X"), dr("txt1Y"))
                Panel4.Visible = True
            End If
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "SELECT * FROM tbltextlocation WHERE status ='" & "ps3" & "'"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            If dr.Read Then
                Panel5.Location = New Point(dr("txt1X"), dr("txt1Y"))
                Panel5.Visible = True
            End If
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "SELECT * FROM tbltextlocation WHERE status ='" & "l1" & "'"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            If dr.Read Then
                lbl1.Location = New Point(dr("txt1X"), dr("txt1Y"))
                lbl1.Visible = True
            End If
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "SELECT * FROM tbltextlocation WHERE status ='" & "l2" & "'"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            If dr.Read Then
                lbl2.Location = New Point(dr("txt1X"), dr("txt1Y"))
                lbl2.Visible = True
            End If
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If


            'Size object
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "SELECT * FROM tbltextsize WHERE status = '" & "txt1" & "'"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            If dr.Read Then
                TextBox1.Size = New Size(dr("width"), dr("height"))
            End If
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "SELECT * FROM tbltextsize WHERE status = '" & "txt2" & "'"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            If dr.Read Then
                TextBox2.Size = New Size(dr("width"), dr("height"))
            End If
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "SELECT * FROM tbltextsize WHERE status = '" & "txt3" & "'"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            If dr.Read Then
                TextBox3.Size = New Size(dr("width"), dr("height"))
            End If
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "SELECT * FROM tbltextsize WHERE status = '" & "txt4" & "'"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            If dr.Read Then
                TextBox4.Size = New Size(dr("width"), dr("height"))
            End If
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "SELECT * FROM tbltextsize WHERE status = '" & "txt5" & "'"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            If dr.Read Then
                TextBox5.Size = New Size(dr("width"), dr("height"))
            End If
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "SELECT * FROM tbltextsize WHERE status = '" & "pic1" & "'"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            If dr.Read Then
                PictureBox1.Size = New Size(dr("width"), dr("height"))
            End If
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "SELECT * FROM tbltextsize WHERE status = '" & "pic2" & "'"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            If dr.Read Then
                PictureBox2.Size = New Size(dr("width"), dr("height"))
            End If
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "SELECT * FROM tbltextsize WHERE status = '" & "pic3" & "'"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            If dr.Read Then
                PictureBox3.Size = New Size(dr("width"), dr("height"))
            End If
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "SELECT * FROM tbltextsize WHERE status = '" & "pic4" & "'"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            If dr.Read Then
                PictureBox4.Size = New Size(dr("width"), dr("height"))
            End If
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "SELECT * FROM tbltextsize WHERE status = '" & "pic5" & "'"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            If dr.Read Then
                PictureBox5.Size = New Size(dr("width"), dr("height"))
            End If
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "SELECT * FROM tbltextsize WHERE status = '" & "ps1" & "'"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            If dr.Read Then
                Panel3.Size = New Size(dr("width"), dr("height"))
            End If
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "SELECT * FROM tbltextsize WHERE status = '" & "ps2" & "'"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            If dr.Read Then
                Panel4.Size = New Size(dr("width"), dr("height"))
            End If
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "SELECT * FROM tbltextsize WHERE status = '" & "ps5" & "'"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            If dr.Read Then
                Panel5.Size = New Size(dr("width"), dr("height"))
            End If
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch
            Return
        End Try

    End Sub

    Private Sub Form2_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles MyBase.DragOver
        e.Effect = DragDropEffects.All

    End Sub

    Private Sub Form2_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles MyBase.DragDrop
        Dim newButton As TextBox = New TextBox
        If e.Data.GetDataPresent(newButton.GetType) Then
            newButton = CType(e.Data.GetData(newButton.GetType), TextBox)
            newButton.Location = Me.PointToClient(New Point(e.X, e.Y))
            Me.Controls.Add(newButton)
        End If



    End Sub
    Private Sub frmAnnouncementDragnDrop_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles MyBase.DragOver
        e.Effect = DragDropEffects.All
    End Sub







    Private Sub TextBoxesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TextBoxesToolStripMenuItem.Click

    End Sub

    Private Sub XToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XToolStripMenuItem.Click
        Panel2.Visible = False
        MenuStrip2.Visible = False
    End Sub

    Private Sub OToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OToolStripMenuItem.Click
        Panel2.Visible = True
        MenuStrip2.Visible = True
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        TextBox1.Visible = True
        TextBox1.Location = New Point(21, 116)
        frmDragNDropObject.btnU1.Visible = True
        trigger1 = True
        x1 = "txt1"
    End Sub

    Private Sub TextBox1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TextBox1.MouseMove
        Obj_resize.ResizeOBJ(sender, e, Me)
        txt1X = TextBox1.Location.X
        txt1Y = TextBox1.Location.Y
        status1 = "txt1"
    End Sub

    Private Sub PictureBox1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PictureBox1ToolStripMenuItem.Click
        PictureBox1.Visible = True
        x1 = "pic1"
        img1 = True
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        TextBox2.Visible = True
        TextBox2.Location = New Point(21, 175)
        frmDragNDropObject.btnU2.Visible = True
        trigger2 = True
        x1 = "txt2"
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        TextBox3.Visible = True
        TextBox3.Location = New Point(21, 223)
        frmDragNDropObject.btnU3.Visible = True
        trigger3 = True
        x1 = "txt3"
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        TextBox4.Visible = True
        TextBox4.Location = New Point(21, 271)
        frmDragNDropObject.btnU4.Visible = True
        trigger4 = True
        x1 = "txt4"
    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        TextBox5.Visible = True
        TextBox5.Location = New Point(21, 319)
        frmDragNDropObject.btnU5.Visible = True
        trigger5 = True
        x1 = "txt5"
    End Sub

    Private Sub PictureBox2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PictureBox2ToolStripMenuItem.Click
        PictureBox2.Visible = True
        img2 = True
        x1 = "pic2"
    End Sub

    Private Sub PictureBox3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PictureBox3ToolStripMenuItem.Click
        PictureBox3.Visible = True
        img3 = True
        x1 = "pic3"
    End Sub

    Private Sub PictureBox4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PictureBox4ToolStripMenuItem.Click
        PictureBox4.Visible = True
        img4 = True
        x1 = "pic4"
    End Sub

    Private Sub PictureBox5ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PictureBox5ToolStripMenuItem.Click
        PictureBox5.Visible = True
        img5 = True
        x1 = "pic5"
    End Sub

    Private Sub TextBox2_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TextBox2.MouseMove
        Obj_resize.ResizeOBJ(sender, e, Me)
        txt1X = TextBox2.Location.X
        txt1Y = TextBox2.Location.Y
        status2 = "txt2"
    End Sub

    Private Sub TextBox3_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TextBox3.MouseMove
        Obj_resize.ResizeOBJ(sender, e, Me)
        txt1X = TextBox3.Location.X
        txt1Y = TextBox3.Location.Y
        status3 = "txt3"
    End Sub

    Private Sub TextBox4_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TextBox4.MouseMove
        Obj_resize.ResizeOBJ(sender, e, Me)
        txt1X = TextBox4.Location.X
        txt1Y = TextBox4.Location.Y
        status4 = "txt4"
    End Sub

    Private Sub TextBox5_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TextBox5.MouseMove
        Obj_resize.ResizeOBJ(sender, e, Me)
        txt1X = TextBox5.Location.X
        txt1Y = TextBox5.Location.Y
        status5 = "txt5"
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        Obj_resize.ResizeOBJ(sender, e, Me)
        txt1X = PictureBox1.Location.X
        txt1Y = PictureBox1.Location.Y
        stat1 = "pic1"
    End Sub

    Private Sub PictureBox5_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox5.MouseMove
        Obj_resize.ResizeOBJ(sender, e, Me)
        txt1X = PictureBox5.Location.X
        txt1Y = PictureBox5.Location.Y
        stat5 = "pic5"
    End Sub

    Private Sub PictureBox4_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox4.MouseMove
        Obj_resize.ResizeOBJ(sender, e, Me)
        txt1X = PictureBox4.Location.X
        txt1Y = PictureBox4.Location.Y
        stat4 = "pic4"
    End Sub

    Private Sub PictureBox3_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox3.MouseMove
        Obj_resize.ResizeOBJ(sender, e, Me)
        txt1X = PictureBox3.Location.X
        txt1Y = PictureBox3.Location.Y
        stat3 = "pic3"
    End Sub

    Private Sub PictureBox2_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox2.MouseMove
        Obj_resize.ResizeOBJ(sender, e, Me)
        txt1X = PictureBox2.Location.X
        txt1Y = PictureBox2.Location.Y
        stat2 = "pic2"
    End Sub

    Private Sub PanelGreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PanelGreenToolStripMenuItem.Click
        Panel3.Visible = True
        pal1 = True
    End Sub

    Private Sub PanelMaroonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PanelMaroonToolStripMenuItem.Click
        Panel4.Visible = True
        pal2 = True
    End Sub

    Private Sub PanelOrangeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PanelOrangeToolStripMenuItem.Click
        Panel5.Visible = True
        pal3 = True
    End Sub



    Private Sub Panel3_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel3.MouseMove
        Obj_resize.ResizeOBJ(sender, e, Me)
        txt1X = Panel3.Location.X
        txt1Y = Panel3.Location.Y
        ps1 = "ps1"
    End Sub

    Private Sub Panel4_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel4.MouseMove
        Obj_resize.ResizeOBJ(sender, e, Me)
        txt1X = Panel4.Location.X
        txt1Y = Panel4.Location.Y
        ps2 = "ps2"
    End Sub

    Private Sub Panel5_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel5.MouseMove
        Obj_resize.ResizeOBJ(sender, e, Me)
        txt1X = Panel5.Location.X
        txt1Y = Panel5.Location.Y
        ps3 = "ps3"
    End Sub

    Private Sub RemoveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveToolStripMenuItem.Click
        TextBox1.Visible = False
        frmDragNDropObject.btnU1.Visible = False
        trigger1 = False
    End Sub


    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        TextBox2.Visible = False
        frmDragNDropObject.btnU2.Visible = False
        trigger2 = False
    End Sub

    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem7.Click
        TextBox3.Visible = False
        frmDragNDropObject.btnU3.Visible = False
        trigger3 = False
    End Sub

    Private Sub ToolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem8.Click
        TextBox4.Visible = False
        frmDragNDropObject.btnU4.Visible = False
        trigger4 = False
    End Sub

    Private Sub ToolStripMenuItem9_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem9.Click
        TextBox5.Visible = False
        frmDragNDropObject.btnU5.Visible = False
        trigger5 = False
    End Sub

    Private Sub ToolStripMenuItem10_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem10.Click
        PictureBox1.Visible = False
        frmDragNDropObject.btnP1.Visible = False
        img1 = False
    End Sub

    Private Sub ToolStripMenuItem11_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem11.Click
        PictureBox2.Visible = False
        frmDragNDropObject.btnP2.Visible = False
        img2 = False
    End Sub

    Private Sub ToolStripMenuItem12_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem12.Click
        PictureBox3.Visible = False
        frmDragNDropObject.btnP3.Visible = False
        img3 = False
    End Sub

    Private Sub ToolStripMenuItem13_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem13.Click
        PictureBox4.Visible = False
        frmDragNDropObject.btnP4.Visible = False
        img4 = False
    End Sub

    Private Sub ToolStripMenuItem14_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem14.Click
        PictureBox5.Visible = False
        frmDragNDropObject.btnP5.Visible = False
        img5 = False
    End Sub

    Dim RanNum As New Random
    Dim DistMove As Integer = 10
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        txtRunningMessage.Left += DistMove

        If txtRunningMessage.Left + txtRunningMessage.Width > Me.ClientRectangle.Width Then
            txtRunningMessage.Left = Me.ClientRectangle.Width - txtRunningMessage.Width
            DistMove = Not DistMove
        ElseIf txtRunningMessage.Left < 0 Then
            txtRunningMessage.Left = 0
            DistMove = Not DistMove
        End If

        Label4.Left += DistMove
        If Label4.Left + Label4.Width > Me.ClientRectangle.Width Then
            Label4.Left = Me.ClientRectangle.Width - Label4.Width
            DistMove = Not DistMove
        ElseIf Label4.Left < 0 Then
            Label4.Left = 0
            DistMove = Not DistMove
        End If
        txtName.Left += DistMove
        If txtName.Left + txtName.Width > Me.ClientRectangle.Width Then
            txtName.Left = Me.ClientRectangle.Width - txtName.Width
            DistMove = Not DistMove
        ElseIf txtName.Left < 0 Then
            txtName.Left = 0
            DistMove = Not DistMove
        End If

    End Sub

    Private Sub BirthdayRecords()
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "SELECT * FROM tblbirthday WHERE dateofbirth < NOW()"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            If dr.Read Then
                txtName.Text = dr("name")
            End If
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch
            Return
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim max As Integer = 5000
        Dim rnd As New Random
        Dim rand As Integer = rnd.Next(10, max + 1)
        Dim i As Integer = 1
        Dim number(max - 1) As Integer
        For i = 0 To max - 1
            If number(i) = rand Then
                rand = rnd.Next(1, max + 1)
                i = -1
            ElseIf number(i) = 0 Then
                number(i) = rand
                rand = rnd.Next(1, max + 1)
                If i = max - 1 Then
                    Exit For
                End If
                i = -1
            End If
        Next
        Timer1.Interval = number(i)
        i += 1
        Call ChangeAnnouncement()
        Call BirthdayRecords()

    End Sub

    Dim inc As Integer = 1
    Dim ds As DataSet = New DataSet
    Dim da As MySqlDataAdapter = New MySqlDataAdapter
    Dim dt As DataTable = New DataTable
    Public Sub RunQuery(ByVal Query As String)
        Try
            con = New MySqlConnection(csstring)
            con.Open()
            cmd = New MySqlCommand(Query, con)
            da = New MySqlDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds)


            da.Dispose()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch
            Return
        Finally
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Private Sub ChangeAnnouncement()
        Try


            Static Dim iAnnounce As Integer
            Select Case iAnnounce
                Case 0
                    RunQuery("SELECT * FROM tbla1 WHERE id ='" & "1" & "'")
                    If ds.Tables(0).Rows.Count > 0 Then
                        TextBox1.Text = ds.Tables(0).Rows(0).Item("msg1").ToString()
                    End If
                    'RunQuery("SELECT * FROM tblb1 WHERE id ='" & "1" & "'")
                    'If ds.Tables(0).Rows.Count > 0 Then
                    '    PictureBox1.ImageLocation = System.AppDomain.CurrentDomain.BaseDirectory & "Photos\img\" & ds.Tables(0).Rows(0).Item("img1").ToString
                    'End If

                    RunQuery("SELECT * FROM tbla2 WHERE id ='" & "1" & "'")
                    If ds.Tables(0).Rows.Count > 0 Then
                        TextBox2.Text = ds.Tables(0).Rows(0).Item("msg1").ToString()
                    End If
                    'RunQuery("SELECT * FROM tblb2 WHERE id ='" & "1" & "'")
                    'If ds.Tables(0).Rows.Count > 0 Then
                    '    PictureBox2.ImageLocation = System.AppDomain.CurrentDomain.BaseDirectory & "Photos\img\" & ds.Tables(0).Rows(0).Item("img1").ToString
                    'End If


                    RunQuery("SELECT * FROM tbla3 WHERE id ='" & "1" & "'")
                    If ds.Tables(0).Rows.Count > 0 Then
                        TextBox3.Text = ds.Tables(0).Rows(0).Item("msg1").ToString()
                    End If
                    'RunQuery("SELECT * FROM tblb3 WHERE id ='" & "1" & "'")
                    'If ds.Tables(0).Rows.Count > 0 Then
                    '    PictureBox3.ImageLocation = System.AppDomain.CurrentDomain.BaseDirectory & "Photos\img\" & ds.Tables(0).Rows(0).Item("img1").ToString
                    'End If

                    RunQuery("SELECT * FROM tbla4 WHERE id ='" & "1" & "'")
                    If ds.Tables(0).Rows.Count > 0 Then
                        TextBox4.Text = ds.Tables(0).Rows(0).Item("msg1").ToString()
                    End If
                    'RunQuery("SELECT * FROM tblb4 WHERE id ='" & "1" & "'")
                    'If ds.Tables(0).Rows.Count > 0 Then
                    '    PictureBox4.ImageLocation = System.AppDomain.CurrentDomain.BaseDirectory & "Photos\img\" & ds.Tables(0).Rows(0).Item("img1").ToString
                    'End If




                    RunQuery("SELECT * FROM tbla5 WHERE id ='" & "1" & "'")
                    If ds.Tables(0).Rows.Count > 0 Then
                        TextBox5.Text = ds.Tables(0).Rows(0).Item("msg1").ToString()
                    End If
                    'RunQuery("SELECT * FROM tblb5 WHERE id ='" & "1" & "'")
                    'If ds.Tables(0).Rows.Count > 0 Then
                    '    PictureBox5.ImageLocation = System.AppDomain.CurrentDomain.BaseDirectory & "Photos\img\" & ds.Tables(0).Rows(0).Item("img1").ToString
                    'End If


                    '-----New Image 1
                    con = New MySqlConnection(csstring)
                    con.Open()
                    strSQL = "SELECT * FROM tblb1 WHERE id ='" & "1" & "'"
                    cmd = New MySqlCommand(strSQL, con)
                    dr = cmd.ExecuteReader
                    If dr.Read Then
                        PictureBox1.ImageLocation = System.AppDomain.CurrentDomain.BaseDirectory & "Photos\img\" & dr("img1").ToString()
                    End If

                    dr.Close()
                    cmd.Dispose()
                    If con.State <> ConnectionState.Open Then
                        con.Close()
                    End If

                    con = New MySqlConnection(csstring)
                    con.Open()
                    strSQL = "SELECT * FROM tblb2 WHERE id ='" & "1" & "'"
                    cmd = New MySqlCommand(strSQL, con)
                    dr = cmd.ExecuteReader
                    If dr.Read Then
                        PictureBox2.ImageLocation = System.AppDomain.CurrentDomain.BaseDirectory & "Photos\img\" & dr("img1").ToString()
                    End If

                    dr.Close()
                    cmd.Dispose()
                    If con.State <> ConnectionState.Open Then
                        con.Close()
                    End If

                    con = New MySqlConnection(csstring)
                    con.Open()
                    strSQL = "SELECT * FROM tblb3 WHERE id ='" & "1" & "'"
                    cmd = New MySqlCommand(strSQL, con)
                    dr = cmd.ExecuteReader
                    If dr.Read Then
                        PictureBox3.ImageLocation = System.AppDomain.CurrentDomain.BaseDirectory & "Photos\img\" & dr("img1").ToString()
                    End If

                    dr.Close()
                    cmd.Dispose()
                    If con.State <> ConnectionState.Open Then
                        con.Close()
                    End If

                    con = New MySqlConnection(csstring)
                    con.Open()
                    strSQL = "SELECT * FROM tblb4 WHERE id ='" & "1" & "'"
                    cmd = New MySqlCommand(strSQL, con)
                    dr = cmd.ExecuteReader
                    If dr.Read Then
                        PictureBox4.ImageLocation = System.AppDomain.CurrentDomain.BaseDirectory & "Photos\img\" & dr("img1").ToString()
                    End If

                    dr.Close()
                    cmd.Dispose()
                    If con.State <> ConnectionState.Open Then
                        con.Close()
                    End If

                    con = New MySqlConnection(csstring)
                    con.Open()
                    strSQL = "SELECT * FROM tblb5 WHERE id ='" & "1" & "'"
                    cmd = New MySqlCommand(strSQL, con)
                    dr = cmd.ExecuteReader
                    If dr.Read Then
                        PictureBox5.ImageLocation = System.AppDomain.CurrentDomain.BaseDirectory & "Photos\img\" & dr("img1").ToString()
                    End If

                    dr.Close()
                    cmd.Dispose()
                    If con.State <> ConnectionState.Open Then
                        con.Close()
                    End If

                    RunQuery("SELECT * FROM tblf1 WHERE id ='" & "1" & "'")
                    If ds.Tables(0).Rows.Count > 0 Then
                        lbl1.Text = ds.Tables(0).Rows(0).Item("messageentry").ToString()
                    End If

                    RunQuery("SELECT * FROM tblf2 WHERE id ='" & "1" & "'")
                    If ds.Tables(0).Rows.Count > 0 Then
                        lbl2.Text = ds.Tables(0).Rows(0).Item("messageentry").ToString()
                    End If

                    iAnnounce += 1
                Case 1
                    RunQuery("SELECT * FROM tbla1 WHERE id ='" & "2" & "'")
                    If ds.Tables(0).Rows.Count > 0 Then
                        TextBox1.Text = ds.Tables(0).Rows(0).Item("msg1").ToString()
                    End If
                    'RunQuery("SELECT * FROM tblb1 WHERE id ='" & "2" & "'")
                    'If ds.Tables(0).Rows.Count > 0 Then
                    '    PictureBox1.ImageLocation = System.AppDomain.CurrentDomain.BaseDirectory & "Photos\img\" & ds.Tables(0).Rows(0).Item("img1").ToString
                    'End If
                    'RunQuery("SELECT * FROM tblb2 WHERE id ='" & "2" & "'")
                    'If ds.Tables(0).Rows.Count > 0 Then
                    '    PictureBox2.ImageLocation = System.AppDomain.CurrentDomain.BaseDirectory & "Photos\img\" & ds.Tables(0).Rows(0).Item("img1").ToString
                    'End If
                    'RunQuery("SELECT * FROM tblb3 WHERE id ='" & "2" & "'")
                    'If ds.Tables(0).Rows.Count > 0 Then
                    '    PictureBox3.ImageLocation = System.AppDomain.CurrentDomain.BaseDirectory & "Photos\img\" & ds.Tables(0).Rows(0).Item("img1").ToString
                    'End If
                    'RunQuery("SELECT * FROM tblb4 WHERE id ='" & "2" & "'")
                    'If ds.Tables(0).Rows.Count > 0 Then
                    '    PictureBox4.ImageLocation = System.AppDomain.CurrentDomain.BaseDirectory & "Photos\img\" & ds.Tables(0).Rows(0).Item("img1").ToString
                    'End If
                    'RunQuery("SELECT * FROM tblb5 WHERE id ='" & "2" & "'")
                    'If ds.Tables(0).Rows.Count > 0 Then
                    '    PictureBox5.ImageLocation = System.AppDomain.CurrentDomain.BaseDirectory & "Photos\img\" & ds.Tables(0).Rows(0).Item("img1").ToString
                    'End If

                    RunQuery("SELECT * FROM tbla2 WHERE id ='" & "2" & "'")
                    If ds.Tables(0).Rows.Count > 0 Then
                        TextBox2.Text = ds.Tables(0).Rows(0).Item("msg1").ToString()
                    End If


                    RunQuery("SELECT * FROM tbla3 WHERE id ='" & "2" & "'")
                    If ds.Tables(0).Rows.Count > 0 Then
                        TextBox3.Text = ds.Tables(0).Rows(0).Item("msg1").ToString()
                    End If


                    RunQuery("SELECT * FROM tbla4 WHERE id ='" & "2" & "'")
                    If ds.Tables(0).Rows.Count > 0 Then
                        TextBox4.Text = ds.Tables(0).Rows(0).Item("msg1").ToString()
                    End If


                    RunQuery("SELECT * FROM tbla5 WHERE id ='" & "2" & "'")
                    If ds.Tables(0).Rows.Count > 0 Then
                        TextBox5.Text = ds.Tables(0).Rows(0).Item("msg1").ToString()
                    End If

                    '-----New Image 1
                    con = New MySqlConnection(csstring)
                    con.Open()
                    strSQL = "SELECT * FROM tblb1 WHERE id ='" & "2" & "'"
                    cmd = New MySqlCommand(strSQL, con)
                    dr = cmd.ExecuteReader
                    If dr.Read Then
                        PictureBox1.ImageLocation = System.AppDomain.CurrentDomain.BaseDirectory & "Photos\img\" & dr("img1").ToString()
                    End If

                    dr.Close()
                    cmd.Dispose()
                    If con.State <> ConnectionState.Open Then
                        con.Close()
                    End If

                    con = New MySqlConnection(csstring)
                    con.Open()
                    strSQL = "SELECT * FROM tblb2 WHERE id ='" & "2" & "'"
                    cmd = New MySqlCommand(strSQL, con)
                    dr = cmd.ExecuteReader
                    If dr.Read Then
                        PictureBox2.ImageLocation = System.AppDomain.CurrentDomain.BaseDirectory & "Photos\img\" & dr("img1").ToString()
                    End If

                    dr.Close()
                    cmd.Dispose()
                    If con.State <> ConnectionState.Open Then
                        con.Close()
                    End If

                    con = New MySqlConnection(csstring)
                    con.Open()
                    strSQL = "SELECT * FROM tblb3 WHERE id ='" & "2" & "'"
                    cmd = New MySqlCommand(strSQL, con)
                    dr = cmd.ExecuteReader
                    If dr.Read Then
                        PictureBox3.ImageLocation = System.AppDomain.CurrentDomain.BaseDirectory & "Photos\img\" & dr("img1").ToString()
                    End If

                    dr.Close()
                    cmd.Dispose()
                    If con.State <> ConnectionState.Open Then
                        con.Close()
                    End If

                    con = New MySqlConnection(csstring)
                    con.Open()
                    strSQL = "SELECT * FROM tblb4 WHERE id ='" & "2" & "'"
                    cmd = New MySqlCommand(strSQL, con)
                    dr = cmd.ExecuteReader
                    If dr.Read Then
                        PictureBox4.ImageLocation = System.AppDomain.CurrentDomain.BaseDirectory & "Photos\img\" & dr("img1").ToString()
                    End If

                    dr.Close()
                    cmd.Dispose()
                    If con.State <> ConnectionState.Open Then
                        con.Close()
                    End If

                    con = New MySqlConnection(csstring)
                    con.Open()
                    strSQL = "SELECT * FROM tblb5 WHERE id ='" & "2" & "'"
                    cmd = New MySqlCommand(strSQL, con)
                    dr = cmd.ExecuteReader
                    If dr.Read Then
                        PictureBox5.ImageLocation = System.AppDomain.CurrentDomain.BaseDirectory & "Photos\img\" & dr("img1").ToString()
                    End If

                    dr.Close()
                    cmd.Dispose()
                    If con.State <> ConnectionState.Open Then
                        con.Close()
                    End If

                    RunQuery("SELECT * FROM tblf1 WHERE id ='" & "2" & "'")
                    If ds.Tables(0).Rows.Count > 0 Then
                        lbl1.Text = ds.Tables(0).Rows(0).Item("messageentry").ToString()
                    End If

                    RunQuery("SELECT * FROM tblf2 WHERE id ='" & "2" & "'")
                    If ds.Tables(0).Rows.Count > 0 Then
                        lbl2.Text = ds.Tables(0).Rows(0).Item("messageentry").ToString()
                    End If


                    iAnnounce += 1
                Case 2
                    RunQuery("SELECT * FROM tbla1 WHERE id ='" & "3" & "'")
                    If ds.Tables(0).Rows.Count > 0 Then
                        TextBox1.Text = ds.Tables(0).Rows(0).Item("msg1").ToString()
                    End If

                    RunQuery("SELECT * FROM tbla2 WHERE id ='" & "3" & "'")
                    If ds.Tables(0).Rows.Count > 0 Then
                        TextBox2.Text = ds.Tables(0).Rows(0).Item("msg1").ToString()
                    End If


                    RunQuery("SELECT * FROM tbla3 WHERE id ='" & "3" & "'")
                    If ds.Tables(0).Rows.Count > 0 Then
                        TextBox3.Text = ds.Tables(0).Rows(0).Item("msg1").ToString()
                    End If


                    RunQuery("SELECT * FROM tbla4 WHERE id ='" & "3" & "'")
                    If ds.Tables(0).Rows.Count > 0 Then
                        TextBox4.Text = ds.Tables(0).Rows(0).Item("msg1").ToString()
                    End If


                    RunQuery("SELECT * FROM tbla5 WHERE id ='" & "3" & "'")
                    If ds.Tables(0).Rows.Count > 0 Then
                        TextBox5.Text = ds.Tables(0).Rows(0).Item("msg1").ToString()
                    End If

                    'RunQuery("SELECT * FROM tblb1 WHERE id ='" & "3" & "'")
                    'If ds.Tables(0).Rows.Count > 0 Then
                    '    PictureBox1.ImageLocation = System.AppDomain.CurrentDomain.BaseDirectory & "Photos\img\" & ds.Tables(0).Rows(0).Item("img1").ToString
                    'End If
                    'RunQuery("SELECT * FROM tblb2 WHERE id ='" & "3" & "'")
                    'If ds.Tables(0).Rows.Count > 0 Then
                    '    PictureBox2.ImageLocation = System.AppDomain.CurrentDomain.BaseDirectory & "Photos\img\" & ds.Tables(0).Rows(0).Item("img1").ToString
                    'End If
                    'RunQuery("SELECT * FROM tblb3 WHERE id ='" & "3" & "'")
                    'If ds.Tables(0).Rows.Count > 0 Then
                    '    PictureBox3.ImageLocation = System.AppDomain.CurrentDomain.BaseDirectory & "Photos\img\" & ds.Tables(0).Rows(0).Item("img1").ToString
                    'End If
                    'RunQuery("SELECT * FROM tblb4 WHERE id ='" & "3" & "'")
                    'If ds.Tables(0).Rows.Count > 0 Then
                    '    PictureBox4.ImageLocation = System.AppDomain.CurrentDomain.BaseDirectory & "Photos\img\" & ds.Tables(0).Rows(0).Item("img1").ToString
                    'End If
                    'RunQuery("SELECT * FROM tblb5 WHERE id ='" & "3" & "'")
                    'If ds.Tables(0).Rows.Count > 0 Then
                    '    PictureBox5.ImageLocation = System.AppDomain.CurrentDomain.BaseDirectory & "Photos\img\" & ds.Tables(0).Rows(0).Item("img1").ToString
                    'End If

                    '-----New Image 1
                    con = New MySqlConnection(csstring)
                    con.Open()
                    strSQL = "SELECT * FROM tblb1 WHERE id ='" & "3" & "'"
                    cmd = New MySqlCommand(strSQL, con)
                    dr = cmd.ExecuteReader
                    If dr.Read Then
                        PictureBox1.ImageLocation = System.AppDomain.CurrentDomain.BaseDirectory & "Photos\img\" & dr("img1").ToString()
                    End If

                    dr.Close()
                    cmd.Dispose()
                    If con.State <> ConnectionState.Open Then
                        con.Close()
                    End If

                    con = New MySqlConnection(csstring)
                    con.Open()
                    strSQL = "SELECT * FROM tblb2 WHERE id ='" & "3" & "'"
                    cmd = New MySqlCommand(strSQL, con)
                    dr = cmd.ExecuteReader
                    If dr.Read Then
                        PictureBox2.ImageLocation = System.AppDomain.CurrentDomain.BaseDirectory & "Photos\img\" & dr("img1").ToString()
                    End If

                    dr.Close()
                    cmd.Dispose()
                    If con.State <> ConnectionState.Open Then
                        con.Close()
                    End If

                    con = New MySqlConnection(csstring)
                    con.Open()
                    strSQL = "SELECT * FROM tblb3 WHERE id ='" & "3" & "'"
                    cmd = New MySqlCommand(strSQL, con)
                    dr = cmd.ExecuteReader
                    If dr.Read Then
                        PictureBox3.ImageLocation = System.AppDomain.CurrentDomain.BaseDirectory & "Photos\img\" & dr("img1").ToString()
                    End If

                    dr.Close()
                    cmd.Dispose()
                    If con.State <> ConnectionState.Open Then
                        con.Close()
                    End If

                    con = New MySqlConnection(csstring)
                    con.Open()
                    strSQL = "SELECT * FROM tblb4 WHERE id ='" & "3" & "'"
                    cmd = New MySqlCommand(strSQL, con)
                    dr = cmd.ExecuteReader
                    If dr.Read Then
                        PictureBox4.ImageLocation = System.AppDomain.CurrentDomain.BaseDirectory & "Photos\img\" & dr("img1").ToString()
                    End If

                    dr.Close()
                    cmd.Dispose()
                    If con.State <> ConnectionState.Open Then
                        con.Close()
                    End If

                    con = New MySqlConnection(csstring)
                    con.Open()
                    strSQL = "SELECT * FROM tblb5 WHERE id ='" & "3" & "'"
                    cmd = New MySqlCommand(strSQL, con)
                    dr = cmd.ExecuteReader
                    If dr.Read Then
                        PictureBox5.ImageLocation = System.AppDomain.CurrentDomain.BaseDirectory & "Photos\img\" & dr("img1").ToString()
                    End If

                    dr.Close()
                    cmd.Dispose()
                    If con.State <> ConnectionState.Open Then
                        con.Close()
                    End If

                    RunQuery("SELECT * FROM tblf1 WHERE id ='" & "3" & "'")
                    If ds.Tables(0).Rows.Count > 0 Then
                        lbl1.Text = ds.Tables(0).Rows(0).Item("messageentry").ToString()
                    End If

                    RunQuery("SELECT * FROM tblf2 WHERE id ='" & "3" & "'")
                    If ds.Tables(0).Rows.Count > 0 Then
                        lbl2.Text = ds.Tables(0).Rows(0).Item("messageentry").ToString()
                    End If

                    iAnnounce += 1
                Case 3
                    RunQuery("SELECT * FROM tbla1 WHERE id ='" & "4" & "'")
                    If ds.Tables(0).Rows.Count > 0 Then
                        TextBox1.Text = ds.Tables(0).Rows(0).Item("msg1").ToString()
                    End If

                    RunQuery("SELECT * FROM tbla2 WHERE id ='" & "4" & "'")
                    If ds.Tables(0).Rows.Count > 0 Then
                        TextBox2.Text = ds.Tables(0).Rows(0).Item("msg1").ToString()
                    End If


                    RunQuery("SELECT * FROM tbla3 WHERE id ='" & "4" & "'")
                    If ds.Tables(0).Rows.Count > 0 Then
                        TextBox3.Text = ds.Tables(0).Rows(0).Item("msg1").ToString()
                    End If


                    RunQuery("SELECT * FROM tbla4 WHERE id ='" & "4" & "'")
                    If ds.Tables(0).Rows.Count > 0 Then
                        TextBox4.Text = ds.Tables(0).Rows(0).Item("msg1").ToString()
                    End If


                    RunQuery("SELECT * FROM tbla5 WHERE id ='" & "4" & "'")
                    If ds.Tables(0).Rows.Count > 0 Then
                        TextBox5.Text = ds.Tables(0).Rows(0).Item("msg1").ToString()
                    End If

                    'RunQuery("SELECT * FROM tblb1 WHERE id ='" & "4" & "'")
                    'If ds.Tables(0).Rows.Count > 0 Then
                    '    PictureBox1.ImageLocation = System.AppDomain.CurrentDomain.BaseDirectory & "Photos\img\" & ds.Tables(0).Rows(0).Item("img1").ToString
                    'End If
                    'RunQuery("SELECT * FROM tblb2 WHERE id ='" & "4" & "'")
                    'If ds.Tables(0).Rows.Count > 0 Then
                    '    PictureBox2.ImageLocation = System.AppDomain.CurrentDomain.BaseDirectory & "Photos\img\" & ds.Tables(0).Rows(0).Item("img1").ToString
                    'End If
                    'RunQuery("SELECT * FROM tblb3 WHERE id ='" & "4" & "'")
                    'If ds.Tables(0).Rows.Count > 0 Then
                    '    PictureBox3.ImageLocation = System.AppDomain.CurrentDomain.BaseDirectory & "Photos\img\" & ds.Tables(0).Rows(0).Item("img1").ToString
                    'End If
                    'RunQuery("SELECT * FROM tblb4 WHERE id ='" & "4" & "'")
                    'If ds.Tables(0).Rows.Count > 0 Then
                    '    PictureBox4.ImageLocation = System.AppDomain.CurrentDomain.BaseDirectory & "Photos\img\" & ds.Tables(0).Rows(0).Item("img1").ToString
                    'End If
                    'RunQuery("SELECT * FROM tblb5 WHERE id ='" & "4" & "'")
                    'If ds.Tables(0).Rows.Count > 0 Then
                    '    PictureBox5.ImageLocation = System.AppDomain.CurrentDomain.BaseDirectory & "Photos\img\" & ds.Tables(0).Rows(0).Item("img1").ToString
                    'End If

                    '-----New Image 1
                    con = New MySqlConnection(csstring)
                    con.Open()
                    strSQL = "SELECT * FROM tblb1 WHERE id ='" & "4" & "'"
                    cmd = New MySqlCommand(strSQL, con)
                    dr = cmd.ExecuteReader
                    If dr.Read Then
                        PictureBox1.ImageLocation = System.AppDomain.CurrentDomain.BaseDirectory & "Photos\img\" & dr("img1").ToString()
                    End If

                    dr.Close()
                    cmd.Dispose()
                    If con.State <> ConnectionState.Open Then
                        con.Close()
                    End If

                    con = New MySqlConnection(csstring)
                    con.Open()
                    strSQL = "SELECT * FROM tblb2 WHERE id ='" & "4" & "'"
                    cmd = New MySqlCommand(strSQL, con)
                    dr = cmd.ExecuteReader
                    If dr.Read Then
                        PictureBox2.ImageLocation = System.AppDomain.CurrentDomain.BaseDirectory & "Photos\img\" & dr("img1").ToString()
                    End If

                    dr.Close()
                    cmd.Dispose()
                    If con.State <> ConnectionState.Open Then
                        con.Close()
                    End If

                    con = New MySqlConnection(csstring)
                    con.Open()
                    strSQL = "SELECT * FROM tblb3 WHERE id ='" & "4" & "'"
                    cmd = New MySqlCommand(strSQL, con)
                    dr = cmd.ExecuteReader
                    If dr.Read Then
                        PictureBox3.ImageLocation = System.AppDomain.CurrentDomain.BaseDirectory & "Photos\img\" & dr("img1").ToString()
                    End If

                    dr.Close()
                    cmd.Dispose()
                    If con.State <> ConnectionState.Open Then
                        con.Close()
                    End If

                    con = New MySqlConnection(csstring)
                    con.Open()
                    strSQL = "SELECT * FROM tblb4 WHERE id ='" & "4" & "'"
                    cmd = New MySqlCommand(strSQL, con)
                    dr = cmd.ExecuteReader
                    If dr.Read Then
                        PictureBox4.ImageLocation = System.AppDomain.CurrentDomain.BaseDirectory & "Photos\img\" & dr("img1").ToString()
                    End If

                    dr.Close()
                    cmd.Dispose()
                    If con.State <> ConnectionState.Open Then
                        con.Close()
                    End If

                    con = New MySqlConnection(csstring)
                    con.Open()
                    strSQL = "SELECT * FROM tblb5 WHERE id ='" & "4" & "'"
                    cmd = New MySqlCommand(strSQL, con)
                    dr = cmd.ExecuteReader
                    If dr.Read Then
                        PictureBox5.ImageLocation = System.AppDomain.CurrentDomain.BaseDirectory & "Photos\img\" & dr("img1").ToString()
                    End If

                    dr.Close()
                    cmd.Dispose()
                    If con.State <> ConnectionState.Open Then
                        con.Close()
                    End If

                    RunQuery("SELECT * FROM tblf1 WHERE id ='" & "4" & "'")
                    If ds.Tables(0).Rows.Count > 0 Then
                        lbl1.Text = ds.Tables(0).Rows(0).Item("messageentry").ToString()
                    End If

                    RunQuery("SELECT * FROM tblf2 WHERE id ='" & "4" & "'")
                    If ds.Tables(0).Rows.Count > 0 Then
                        lbl2.Text = ds.Tables(0).Rows(0).Item("messageentry").ToString()
                    End If


                    iAnnounce += 1
                Case 4
                    RunQuery("SELECT * FROM tbla1 WHERE id ='" & "5" & "'")
                    If ds.Tables(0).Rows.Count > 0 Then
                        TextBox1.Text = ds.Tables(0).Rows(0).Item("msg1").ToString()
                    End If

                    RunQuery("SELECT * FROM tbla2 WHERE id ='" & "5" & "'")
                    If ds.Tables(0).Rows.Count > 0 Then
                        TextBox2.Text = ds.Tables(0).Rows(0).Item("msg1").ToString()
                    End If


                    RunQuery("SELECT * FROM tbla3 WHERE id ='" & "5" & "'")
                    If ds.Tables(0).Rows.Count > 0 Then
                        TextBox3.Text = ds.Tables(0).Rows(0).Item("msg1").ToString()
                    End If


                    RunQuery("SELECT * FROM tbla4 WHERE id ='" & "5" & "'")
                    If ds.Tables(0).Rows.Count > 0 Then
                        TextBox4.Text = ds.Tables(0).Rows(0).Item("msg1").ToString()
                    End If


                    RunQuery("SELECT * FROM tbla5 WHERE id ='" & "5" & "'")
                    If ds.Tables(0).Rows.Count > 0 Then
                        TextBox5.Text = ds.Tables(0).Rows(0).Item("msg1").ToString()
                    End If

                    'RunQuery("SELECT * FROM tblb1 WHERE id ='" & "5" & "'")
                    'If ds.Tables(0).Rows.Count > 0 Then
                    '    PictureBox1.ImageLocation = System.AppDomain.CurrentDomain.BaseDirectory & "Photos\img\" & ds.Tables(0).Rows(0).Item("img1").ToString
                    'End If
                    'RunQuery("SELECT * FROM tblb2 WHERE id ='" & "5" & "'")
                    'If ds.Tables(0).Rows.Count > 0 Then
                    '    PictureBox2.ImageLocation = System.AppDomain.CurrentDomain.BaseDirectory & "Photos\img\" & ds.Tables(0).Rows(0).Item("img1").ToString
                    'End If
                    'RunQuery("SELECT * FROM tblb3 WHERE id ='" & "5" & "'")
                    'If ds.Tables(0).Rows.Count > 0 Then
                    '    PictureBox3.ImageLocation = System.AppDomain.CurrentDomain.BaseDirectory & "Photos\img\" & ds.Tables(0).Rows(0).Item("img1").ToString
                    'End If
                    'RunQuery("SELECT * FROM tblb4 WHERE id ='" & "5" & "'")
                    'If ds.Tables(0).Rows.Count > 0 Then
                    '    PictureBox4.ImageLocation = System.AppDomain.CurrentDomain.BaseDirectory & "Photos\img\" & ds.Tables(0).Rows(0).Item("img1").ToString
                    'End If
                    'RunQuery("SELECT * FROM tblb5 WHERE id ='" & "5" & "'")
                    'If ds.Tables(0).Rows.Count > 0 Then
                    '    PictureBox5.ImageLocation = System.AppDomain.CurrentDomain.BaseDirectory & "Photos\img\" & ds.Tables(0).Rows(0).Item("img1").ToString
                    'End If


                    '-----New Image 1
                    con = New MySqlConnection(csstring)
                    con.Open()
                    strSQL = "SELECT * FROM tblb1 WHERE id ='" & "5" & "'"
                    cmd = New MySqlCommand(strSQL, con)
                    dr = cmd.ExecuteReader
                    If dr.Read Then
                        PictureBox1.ImageLocation = System.AppDomain.CurrentDomain.BaseDirectory & "Photos\img\" & dr("img1").ToString()
                    End If

                    dr.Close()
                    cmd.Dispose()
                    If con.State <> ConnectionState.Open Then
                        con.Close()
                    End If

                    con = New MySqlConnection(csstring)
                    con.Open()
                    strSQL = "SELECT * FROM tblb2 WHERE id ='" & "5" & "'"
                    cmd = New MySqlCommand(strSQL, con)
                    dr = cmd.ExecuteReader
                    If dr.Read Then
                        PictureBox2.ImageLocation = System.AppDomain.CurrentDomain.BaseDirectory & "Photos\img\" & dr("img1").ToString()
                    End If

                    dr.Close()
                    cmd.Dispose()
                    If con.State <> ConnectionState.Open Then
                        con.Close()
                    End If

                    con = New MySqlConnection(csstring)
                    con.Open()
                    strSQL = "SELECT * FROM tblb3 WHERE id ='" & "5" & "'"
                    cmd = New MySqlCommand(strSQL, con)
                    dr = cmd.ExecuteReader
                    If dr.Read Then
                        PictureBox3.ImageLocation = System.AppDomain.CurrentDomain.BaseDirectory & "Photos\img\" & dr("img1").ToString()
                    End If

                    dr.Close()
                    cmd.Dispose()
                    If con.State <> ConnectionState.Open Then
                        con.Close()
                    End If

                    con = New MySqlConnection(csstring)
                    con.Open()
                    strSQL = "SELECT * FROM tblb4 WHERE id ='" & "5" & "'"
                    cmd = New MySqlCommand(strSQL, con)
                    dr = cmd.ExecuteReader
                    If dr.Read Then
                        PictureBox4.ImageLocation = System.AppDomain.CurrentDomain.BaseDirectory & "Photos\img\" & dr("img1").ToString()
                    End If

                    dr.Close()
                    cmd.Dispose()
                    If con.State <> ConnectionState.Open Then
                        con.Close()
                    End If

                    con = New MySqlConnection(csstring)
                    con.Open()
                    strSQL = "SELECT * FROM tblb5 WHERE id ='" & "5" & "'"
                    cmd = New MySqlCommand(strSQL, con)
                    dr = cmd.ExecuteReader
                    If dr.Read Then
                        PictureBox5.ImageLocation = System.AppDomain.CurrentDomain.BaseDirectory & "Photos\img\" & dr("img1").ToString()
                    End If

                    dr.Close()
                    cmd.Dispose()
                    If con.State <> ConnectionState.Open Then
                        con.Close()
                    End If

                    RunQuery("SELECT * FROM tblf1 WHERE id ='" & "5" & "'")
                    If ds.Tables(0).Rows.Count > 0 Then
                        lbl1.Text = ds.Tables(0).Rows(0).Item("messageentry").ToString()
                    End If

                    RunQuery("SELECT * FROM tblf2 WHERE id ='" & "5" & "'")
                    If ds.Tables(0).Rows.Count > 0 Then
                        lbl2.Text = ds.Tables(0).Rows(0).Item("messageentry").ToString()
                    End If


                    iAnnounce += 1
            End Select
        Catch
            Return
        End Try
    End Sub



    Private Sub RToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RToolStripMenuItem.Click
        Call LoadLocation()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Label1ToolStripMenuItem.Click
        lbl1.Visible = True
        isLabel1 = True
    End Sub

    Private Sub lbl1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lbl1.MouseMove
        Obj_resize.ResizeOBJ(sender, e, Me)
        strLbl1 = "l1"
    End Sub

    Private Sub ToolStripMenuItem15_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem15.Click
        lbl1.Font = New Font("Times New Roman", 21)
    End Sub

    Private Sub ArialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArialToolStripMenuItem.Click
        lbl1.Font = New Font("Arial", 21)
    End Sub

    Private Sub CalibriToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalibriToolStripMenuItem.Click
        lbl1.Font = New Font("Calibri Light", 21)

    End Sub

    Private Sub MaturaMTScriptCapitalsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaturaMTScriptCapitalsToolStripMenuItem.Click
        lbl1.Font = New Font("Matura MT Script Capitals", 21)
    End Sub

    Private Sub LucidaCalligraphyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LucidaCalligraphyToolStripMenuItem.Click
        lbl1.Font = New Font("Lucida Calligraphy", 21)
    End Sub

    Private Sub RemoveToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RemoveToolStripMenuItem1.Click
        lbl1.Visible = False
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        con = New MySqlConnection(csstring)
        con.Open()
        strSQL = "INSERT INTO tblf1(messageentry) VALUES('" & lbl1.Text & "')"
        cmd = New MySqlCommand(strSQL, con)
        cmd.ExecuteNonQuery()
        MsgBox("Message saved!", MsgBoxStyle.Information, "Information")
        If con.State <> ConnectionState.Open Then
            con.Close()
        End If
    End Sub

    Private Sub Label2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Label2ToolStripMenuItem.Click
        lbl2.Visible = True
        isLabel2 = True
    End Sub

    Private Sub lbl2_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lbl2.MouseMove
        Obj_resize.ResizeOBJ(sender, e, Me)
        strLbl2 = "l2"
    End Sub

    Private Sub ToolStripMenuItem16_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem16.Click
        lbl2.Font = New Font("Times New Roman", 21)
    End Sub

    Private Sub ToolStripMenuItem17_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem17.Click
        lbl2.Font = New Font("Arial", 21)
    End Sub

    Private Sub ToolStripMenuItem18_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem18.Click
        lbl2.Font = New Font("Calibri Light", 21)
    End Sub

    Private Sub ToolStripMenuItem19_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem19.Click
        lbl2.Font = New Font("Matura MT Script Capitals", 21)
    End Sub

    Private Sub ToolStripMenuItem20_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem20.Click
        lbl2.Font = New Font("Lucida Calligraphy", 21)
    End Sub

    Private Sub ToolStripMenuItem22_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem22.Click
        lbl2.Visible = False
    End Sub

    Private Sub ToolStripMenuItem23_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem23.Click
        con = New MySqlConnection(csstring)
        con.Open()
        strSQL = "INSERT INTO tblf2(messageentry) VALUES('" & lbl2.Text & "')"
        cmd = New MySqlCommand(strSQL, con)
        cmd.ExecuteNonQuery()
        MsgBox("Message saved!", MsgBoxStyle.Information, "Information")
        If con.State <> ConnectionState.Open Then
            con.Close()
        End If
    End Sub

    Sub HideObjects()
        TextBox1.Visible = False
        TextBox2.Visible = False
        TextBox3.Visible = False
        TextBox4.Visible = False
        TextBox5.Visible = False
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        PictureBox5.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        Panel5.Visible = False
        lbl1.Visible = False
        lbl2.Visible = False
    End Sub

    Private Sub ToolStripMenuItem24_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem24.Click
        Call resetObjectSize()
        Call resetObjectsLoader()
        Call HideObjects()

    End Sub

    Private Sub ToolStripMenuItem26_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem26.Click
        lbl2.Font = New Font(FontHeight, 25)
    End Sub

    Private Sub ToolStripMenuItem29_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem29.Click
        lbl1.Font = New Font(FontHeight, 25)
    End Sub

    Private Sub ToolStripMenuItem30_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem30.Click
        lbl1.Font = New Font(FontHeight, 30)
    End Sub

    Private Sub ToolStripMenuItem31_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem31.Click
        lbl1.Font = New Font(FontHeight, 35)
    End Sub

    Private Sub ToolStripMenuItem32_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem32.Click
        lbl1.Font = New Font(FontHeight, 25)
    End Sub

    Private Sub ToolStripMenuItem33_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem33.Click
        lbl1.Font = New Font(FontHeight, 30)
    End Sub

    Private Sub ToolStripMenuItem34_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem34.Click
        lbl1.Font = New Font(FontHeight, 35)
    End Sub

    Private Sub ToolStripMenuItem35_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem35.Click
        lbl1.Font = New Font(FontHeight, 25)
    End Sub

    Private Sub ToolStripMenuItem36_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem36.Click
        lbl1.Font = New Font(FontHeight, 30)
    End Sub

    Private Sub ToolStripMenuItem37_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem37.Click
        lbl1.Font = New Font(FontHeight, 35)
    End Sub

    Private Sub ToolStripMenuItem38_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem38.Click
        lbl1.Font = New Font(FontHeight, 25)
    End Sub

    Private Sub ToolStripMenuItem39_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem39.Click
        lbl1.Font = New Font(FontHeight, 30)
    End Sub

    Private Sub ToolStripMenuItem40_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem40.Click
        lbl1.Font = New Font(FontHeight, 35)
    End Sub

    Private Sub ToolStripMenuItem41_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem41.Click
        lbl1.Font = New Font(FontHeight, 25)
    End Sub

    Private Sub ToolStripMenuItem42_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem42.Click
        lbl1.Font = New Font(FontHeight, 30)
    End Sub

    Private Sub ToolStripMenuItem43_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem43.Click
        lbl1.Font = New Font(FontHeight, 35)
    End Sub

    Private Sub ToolStripMenuItem27_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem27.Click
        lbl2.Font = New Font(FontHeight, 30)
    End Sub

    Private Sub ToolStripMenuItem28_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem28.Click
        lbl2.Font = New Font(FontHeight, 35)
    End Sub

    Private Sub ToolStripMenuItem44_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem44.Click
        lbl2.Font = New Font(FontHeight, 25)
    End Sub

    Private Sub ToolStripMenuItem45_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem45.Click
        lbl2.Font = New Font(FontHeight, 30)
    End Sub

    Private Sub ToolStripMenuItem46_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem46.Click
        lbl2.Font = New Font(FontHeight, 35)
    End Sub

    Private Sub ToolStripMenuItem47_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem47.Click
        lbl2.Font = New Font(FontHeight, 25)
    End Sub

    Private Sub ToolStripMenuItem48_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem48.Click
        lbl2.Font = New Font(FontHeight, 30)
    End Sub

    Private Sub ToolStripMenuItem49_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem49.Click
        lbl2.Font = New Font(FontHeight, 35)
    End Sub

    Private Sub ToolStripMenuItem50_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem50.Click
        lbl2.Font = New Font(FontHeight, 25)
    End Sub

    Private Sub ToolStripMenuItem51_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem51.Click
        lbl2.Font = New Font(FontHeight, 30)
    End Sub

    Private Sub ToolStripMenuItem52_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem52.Click
        lbl2.Font = New Font(FontHeight, 35)
    End Sub

    Private Sub ToolStripMenuItem53_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem53.Click
        lbl2.Font = New Font(FontHeight, 25)
    End Sub

    Private Sub ToolStripMenuItem54_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem54.Click
        lbl2.Font = New Font(FontHeight, 30)
    End Sub

    Private Sub ToolStripMenuItem55_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem55.Click
        lbl2.Font = New Font(FontHeight, 35)
    End Sub

    Private Sub ToolStripMenuItem25_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem25.Click
        Panel3.Visible = False
    End Sub

    Private Sub ToolStripMenuItem56_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem56.Click
        Panel4.Visible = False
    End Sub

    Private Sub ToolStripMenuItem57_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem57.Click
        Panel5.Visible = False
    End Sub
End Class