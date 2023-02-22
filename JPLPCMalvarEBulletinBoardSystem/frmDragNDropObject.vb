Imports System
Imports System.IO
Imports MySql.Data.MySqlClient
Public Class frmDragNDropObject
    Dim csstring As String = "server=localhost;uid=root;pwd=admin;database=ebulletindb;"

    Private Sub frmDragNDropObject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtMsg.Visible = False
        p1.Visible = False
        pl1.Visible = False
        btnUpload.Visible = False
        btnU1.Visible = False
        btnU2.Visible = False
        btnU3.Visible = False
        btnU4.Visible = False
        btnU5.Visible = False
        btnP1.Visible = False
        btnP2.Visible = False
        btnP3.Visible = False
        btnP4.Visible = False
        btnP5.Visible = False
        If trigger1 = True Then
            btnU1.Visible = True
        End If
        If trigger2 = True Then
            btnU2.Visible = True
        End If
        If trigger3 = True Then
            btnU3.Visible = True
        End If
        If trigger4 = True Then
            btnU4.Visible = True
        End If
        If trigger5 = True Then
            btnU5.Visible = True
        End If
        If img1 = True Then
            btnP1.Visible = True
        End If
        If img2 = True Then
            btnP2.Visible = True
        End If
        If img3 = True Then
            btnP3.Visible = True
        End If
        If img4 = True Then
            btnP4.Visible = True
        End If
        If img5 = True Then
            btnP5.Visible = True
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

        Select Case x1
            Case "txt1"

                'If txtMsg.Text = "" Then
                '    MsgBox("Please input the message", MsgBoxStyle.Critical, "Error")
                '    Exit Sub
                'End If
                con = New MySqlConnection(csstring)
                con.Open()
                strSQL = "INSERT INTO tbla1(msg1) VALUES('" & txtMsg.Text & "')"
                cmd = New MySqlCommand(strSQL, con)
                cmd.ExecuteNonQuery()
                If con.State <> ConnectionState.Open Then
                    con.Close()
                End If


                con = New MySqlConnection(csstring)
                con.Open()
                strSQL = "UPDATE tbltextlocation set txt1X = '" & frmAnnouncementDragnDrop.TextBox1.Location.X & _
                    "', txt1Y ='" & frmAnnouncementDragnDrop.TextBox1.Location.Y & _
                    "'WHERE status ='" & frmAnnouncementDragnDrop.status1 & "'"
                cmd = New MySqlCommand(strSQL, con)
                cmd.ExecuteNonQuery()
                If con.State <> ConnectionState.Open Then
                    con.Close()
                End If

                con = New MySqlConnection(csstring)
                con.Open()
                strSQL = "UPDATE tbltextsize set height = '" & frmAnnouncementDragnDrop.TextBox1.Size.Height & _
                    "', width='" & frmAnnouncementDragnDrop.TextBox1.Size.Width & _
                    "'WHERE status ='" & frmAnnouncementDragnDrop.status1 & "'"
                cmd = New MySqlCommand(strSQL, con)
                cmd.ExecuteNonQuery()
                If con.State <> ConnectionState.Open Then
                    con.Close()
                End If

                MsgBox("Record has been saved!", MsgBoxStyle.Information, "Save")
                trigger1 = False


            Case "txt2"

                'If txtMsg.Text = "" Then
                '    MsgBox("Please input the message", MsgBoxStyle.Critical, "Error")
                '    Exit Sub
                'End If
                con = New MySqlConnection(csstring)
                con.Open()
                strSQL = "INSERT INTO tbla2(msg1) VALUES('" & txtMsg.Text & "')"
                cmd = New MySqlCommand(strSQL, con)
                cmd.ExecuteNonQuery()
                If con.State <> ConnectionState.Open Then
                    con.Close()
                End If

                con = New MySqlConnection(csstring)
                con.Open()
                strSQL = "UPDATE tbltextlocation set txt1X = '" & frmAnnouncementDragnDrop.TextBox2.Location.X & _
                    "', txt1Y ='" & frmAnnouncementDragnDrop.TextBox2.Location.Y & _
                    "'WHERE status ='" & frmAnnouncementDragnDrop.status2 & "'"
                cmd = New MySqlCommand(strSQL, con)
                cmd.ExecuteNonQuery()
                If con.State <> ConnectionState.Open Then
                    con.Close()
                End If

                con = New MySqlConnection(csstring)
                con.Open()
                strSQL = "UPDATE tbltextsize set height = '" & frmAnnouncementDragnDrop.TextBox2.Size.Height & _
                    "', width='" & frmAnnouncementDragnDrop.TextBox2.Size.Width & _
                    "'WHERE status ='" & frmAnnouncementDragnDrop.status2 & "'"
                cmd = New MySqlCommand(strSQL, con)
                cmd.ExecuteNonQuery()
                If con.State <> ConnectionState.Open Then
                    con.Close()
                End If

                MsgBox("Record has been saved!", MsgBoxStyle.Information, "Save")
                trigger2 = False


            Case "txt3"

                'If txtMsg.Text = "" Then
                '    MsgBox("Please input the message", MsgBoxStyle.Critical, "Error")
                '    Exit Sub
                'End If
                con = New MySqlConnection(csstring)
                con.Open()
                strSQL = "INSERT INTO tbla3(msg1) VALUES('" & txtMsg.Text & "')"
                cmd = New MySqlCommand(strSQL, con)
                cmd.ExecuteNonQuery()
                If con.State <> ConnectionState.Open Then
                    con.Close()
                End If

                con = New MySqlConnection(csstring)
                con.Open()
                strSQL = "UPDATE tbltextlocation set txt1X = '" & frmAnnouncementDragnDrop.TextBox3.Location.X & _
                    "', txt1Y ='" & frmAnnouncementDragnDrop.TextBox3.Location.Y & _
                    "'WHERE status ='" & frmAnnouncementDragnDrop.status3 & "'"
                cmd = New MySqlCommand(strSQL, con)
                cmd.ExecuteNonQuery()
                If con.State <> ConnectionState.Open Then
                    con.Close()
                End If

                con = New MySqlConnection(csstring)
                con.Open()
                strSQL = "UPDATE tbltextsize set height = '" & frmAnnouncementDragnDrop.TextBox3.Size.Height & _
                    "', width='" & frmAnnouncementDragnDrop.TextBox3.Size.Width & _
                    "'WHERE status ='" & frmAnnouncementDragnDrop.status3 & "'"
                cmd = New MySqlCommand(strSQL, con)
                cmd.ExecuteNonQuery()
                If con.State <> ConnectionState.Open Then
                    con.Close()
                End If

                MsgBox("Record has been saved!", MsgBoxStyle.Information, "Save")
                trigger3 = False



            Case "txt4"

                'If txtMsg.Text = "" Then
                '    MsgBox("Please input the message", MsgBoxStyle.Critical, "Error")
                '    Exit Sub
                'End If
                con = New MySqlConnection(csstring)
                con.Open()
                strSQL = "INSERT INTO tbla4(msg1) VALUES('" & txtMsg.Text & "')"
                cmd = New MySqlCommand(strSQL, con)
                cmd.ExecuteNonQuery()
                If con.State <> ConnectionState.Open Then
                    con.Close()
                End If


                con = New MySqlConnection(csstring)
                con.Open()
                strSQL = "UPDATE tbltextlocation set txt1X = '" & frmAnnouncementDragnDrop.TextBox4.Location.X & _
                    "', txt1Y ='" & frmAnnouncementDragnDrop.TextBox4.Location.Y & _
                    "'WHERE status ='" & frmAnnouncementDragnDrop.status4 & "'"
                cmd = New MySqlCommand(strSQL, con)
                cmd.ExecuteNonQuery()
                If con.State <> ConnectionState.Open Then
                    con.Close()
                End If

                con = New MySqlConnection(csstring)
                con.Open()
                strSQL = "UPDATE tbltextsize set height = '" & frmAnnouncementDragnDrop.TextBox4.Size.Height & _
                    "', width='" & frmAnnouncementDragnDrop.TextBox4.Size.Width & _
                    "'WHERE status ='" & frmAnnouncementDragnDrop.status4 & "'"
                cmd = New MySqlCommand(strSQL, con)
                cmd.ExecuteNonQuery()
                If con.State <> ConnectionState.Open Then
                    con.Close()
                End If

                MsgBox("Record has been saved!", MsgBoxStyle.Information, "Save")
                trigger4 = False


            Case "txt5"

                'If txtMsg.Text = "" Then
                '    MsgBox("Please input the message", MsgBoxStyle.Critical, "Error")
                '    Exit Sub
                'End If
                con = New MySqlConnection(csstring)
                con.Open()
                strSQL = "INSERT INTO tbla5(msg1) VALUES('" & txtMsg.Text & "')"
                cmd = New MySqlCommand(strSQL, con)
                cmd.ExecuteNonQuery()
                If con.State <> ConnectionState.Open Then
                    con.Close()
                End If

                con = New MySqlConnection(csstring)
                con.Open()
                strSQL = "UPDATE tbltextlocation set txt1X = '" & frmAnnouncementDragnDrop.TextBox5.Location.X & _
                    "', txt1Y ='" & frmAnnouncementDragnDrop.TextBox5.Location.Y & _
                    "'WHERE status ='" & frmAnnouncementDragnDrop.status5 & "'"
                cmd = New MySqlCommand(strSQL, con)
                cmd.ExecuteNonQuery()
                If con.State <> ConnectionState.Open Then
                    con.Close()
                End If

                con = New MySqlConnection(csstring)
                con.Open()
                strSQL = "UPDATE tbltextsize set height = '" & frmAnnouncementDragnDrop.TextBox5.Size.Height & _
                    "', width='" & frmAnnouncementDragnDrop.TextBox5.Size.Width & _
                    "'WHERE status ='" & frmAnnouncementDragnDrop.status5 & "'"
                cmd = New MySqlCommand(strSQL, con)
                cmd.ExecuteNonQuery()
                If con.State <> ConnectionState.Open Then
                    con.Close()
                End If

                MsgBox("Record has been saved!", MsgBoxStyle.Information, "Save")
                trigger5 = False

            Case "pic1"
                con = New MySqlConnection(csstring)
                con.Open()
                strSQL = "INSERT INTO tblb1(img1) VALUES('" & photoget & "')"
                cmd = New MySqlCommand(strSQL, con)
                cmd.ExecuteNonQuery()
                If con.State <> ConnectionState.Open Then
                    con.Close()
                End If

                con = New MySqlConnection(csstring)
                con.Open()
                strSQL = "UPDATE tbltextlocation set txt1X = '" & frmAnnouncementDragnDrop.PictureBox1.Location.X & _
                    "', txt1Y ='" & frmAnnouncementDragnDrop.PictureBox1.Location.Y & _
                    "'WHERE status ='" & frmAnnouncementDragnDrop.stat1 & "'"
                cmd = New MySqlCommand(strSQL, con)
                cmd.ExecuteNonQuery()
                If con.State <> ConnectionState.Open Then
                    con.Close()
                End If

                con = New MySqlConnection(csstring)
                con.Open()
                strSQL = "UPDATE tbltextsize set height = '" & frmAnnouncementDragnDrop.PictureBox1.Size.Height & _
                    "', width='" & frmAnnouncementDragnDrop.PictureBox1.Size.Width & _
                    "'WHERE status ='" & frmAnnouncementDragnDrop.stat1 & "'"
                cmd = New MySqlCommand(strSQL, con)
                cmd.ExecuteNonQuery()
                If con.State <> ConnectionState.Open Then
                    con.Close()
                End If

                MsgBox("Record has been saved!", MsgBoxStyle.Information, "Save")
                img1 = False

            Case "pic2"
                con = New MySqlConnection(csstring)
                con.Open()
                strSQL = "INSERT INTO tblb2(img1) VALUES('" & photoget & "')"
                cmd = New MySqlCommand(strSQL, con)
                cmd.ExecuteNonQuery()
                If con.State <> ConnectionState.Open Then
                    con.Close()
                End If


                con = New MySqlConnection(csstring)
                con.Open()
                strSQL = "UPDATE tbltextlocation set txt1X = '" & frmAnnouncementDragnDrop.PictureBox2.Location.X & _
                    "', txt1Y ='" & frmAnnouncementDragnDrop.PictureBox2.Location.Y & _
                    "'WHERE status ='" & frmAnnouncementDragnDrop.stat2 & "'"
                cmd = New MySqlCommand(strSQL, con)
                cmd.ExecuteNonQuery()
                If con.State <> ConnectionState.Open Then
                    con.Close()
                End If

                con = New MySqlConnection(csstring)
                con.Open()
                strSQL = "UPDATE tbltextsize set height = '" & frmAnnouncementDragnDrop.PictureBox2.Size.Height & _
                    "', width='" & frmAnnouncementDragnDrop.PictureBox2.Size.Width & _
                    "'WHERE status ='" & frmAnnouncementDragnDrop.stat2 & "'"
                cmd = New MySqlCommand(strSQL, con)
                cmd.ExecuteNonQuery()
                If con.State <> ConnectionState.Open Then
                    con.Close()
                End If

                MsgBox("Record has been saved!", MsgBoxStyle.Information, "Save")
                img2 = False

            Case "pic3"
                con = New MySqlConnection(csstring)
                con.Open()
                strSQL = "INSERT INTO tblb3(img1) VALUES('" & photoget & "')"
                cmd = New MySqlCommand(strSQL, con)
                cmd.ExecuteNonQuery()
                If con.State <> ConnectionState.Open Then
                    con.Close()
                End If


                con = New MySqlConnection(csstring)
                con.Open()
                strSQL = "UPDATE tbltextlocation set txt1X = '" & frmAnnouncementDragnDrop.PictureBox3.Location.X & _
                    "', txt1Y ='" & frmAnnouncementDragnDrop.PictureBox3.Location.Y & _
                    "'WHERE status ='" & frmAnnouncementDragnDrop.stat3 & "'"
                cmd = New MySqlCommand(strSQL, con)
                cmd.ExecuteNonQuery()
                If con.State <> ConnectionState.Open Then
                    con.Close()
                End If

                con = New MySqlConnection(csstring)
                con.Open()
                strSQL = "UPDATE tbltextsize set height = '" & frmAnnouncementDragnDrop.PictureBox3.Size.Height & _
                    "', width='" & frmAnnouncementDragnDrop.PictureBox3.Size.Width & _
                    "'WHERE status ='" & frmAnnouncementDragnDrop.stat3 & "'"
                cmd = New MySqlCommand(strSQL, con)
                cmd.ExecuteNonQuery()
                If con.State <> ConnectionState.Open Then
                    con.Close()
                End If

                MsgBox("Record has been saved!", MsgBoxStyle.Information, "Save")
                img3 = False


            Case "pic4"
                con = New MySqlConnection(csstring)
                con.Open()
                strSQL = "INSERT INTO tblb1(img1) VALUES('" & photoget & "')"
                cmd = New MySqlCommand(strSQL, con)
                cmd.ExecuteNonQuery()
                If con.State <> ConnectionState.Open Then
                    con.Close()
                End If

                con = New MySqlConnection(csstring)
                con.Open()
                strSQL = "UPDATE tbltextlocation set txt1X = '" & frmAnnouncementDragnDrop.PictureBox4.Location.X & _
                    "', txt1Y ='" & frmAnnouncementDragnDrop.PictureBox4.Location.Y & _
                    "'WHERE status ='" & frmAnnouncementDragnDrop.stat4 & "'"
                cmd = New MySqlCommand(strSQL, con)
                cmd.ExecuteNonQuery()
                If con.State <> ConnectionState.Open Then
                    con.Close()
                End If

                con = New MySqlConnection(csstring)
                con.Open()
                strSQL = "UPDATE tbltextsize set height = '" & frmAnnouncementDragnDrop.PictureBox4.Size.Height & _
                    "', width='" & frmAnnouncementDragnDrop.PictureBox4.Size.Width & _
                    "'WHERE status ='" & frmAnnouncementDragnDrop.stat4 & "'"
                cmd = New MySqlCommand(strSQL, con)
                cmd.ExecuteNonQuery()
                If con.State <> ConnectionState.Open Then
                    con.Close()
                End If

                MsgBox("Record has been saved!", MsgBoxStyle.Information, "Save")
                img4 = False

            Case "pic5"
                con = New MySqlConnection(csstring)
                con.Open()
                strSQL = "INSERT INTO tblb1(img1) VALUES('" & photoget & "')"
                cmd = New MySqlCommand(strSQL, con)
                cmd.ExecuteNonQuery()
                If con.State <> ConnectionState.Open Then
                    con.Close()
                End If

                con = New MySqlConnection(csstring)
                con.Open()
                strSQL = "UPDATE tbltextlocation set txt1X = '" & frmAnnouncementDragnDrop.PictureBox5.Location.X & _
                    "', txt1Y ='" & frmAnnouncementDragnDrop.PictureBox5.Location.Y & _
                    "'WHERE status ='" & frmAnnouncementDragnDrop.stat5 & "'"
                cmd = New MySqlCommand(strSQL, con)
                cmd.ExecuteNonQuery()
                If con.State <> ConnectionState.Open Then
                    con.Close()
                End If

                con = New MySqlConnection(csstring)
                con.Open()
                strSQL = "UPDATE tbltextsize set height = '" & frmAnnouncementDragnDrop.PictureBox5.Size.Height & _
                    "', width='" & frmAnnouncementDragnDrop.PictureBox5.Size.Width & _
                    "'WHERE status ='" & frmAnnouncementDragnDrop.stat5 & "'"
                cmd = New MySqlCommand(strSQL, con)
                cmd.ExecuteNonQuery()
                If con.State <> ConnectionState.Open Then
                    con.Close()
                End If

                MsgBox("Record has been saved!", MsgBoxStyle.Information, "Save")
                img5 = False



        End Select

        If pal1 = True Then
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "UPDATE tbltextlocation set txt1X = '" & frmAnnouncementDragnDrop.Panel3.Location.X & _
                "', txt1Y ='" & frmAnnouncementDragnDrop.Panel3.Location.Y & _
                "'WHERE status ='" & frmAnnouncementDragnDrop.ps1 & "'"
            cmd = New MySqlCommand(strSQL, con)
            cmd.ExecuteNonQuery()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "UPDATE tbltextsize set height = '" & frmAnnouncementDragnDrop.Panel3.Size.Height & _
                "', width='" & frmAnnouncementDragnDrop.Panel3.Size.Width & _
                "'WHERE status ='" & frmAnnouncementDragnDrop.ps1 & "'"
            cmd = New MySqlCommand(strSQL, con)
            cmd.ExecuteNonQuery()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If

            pal1 = False
        End If

        If pal2 = True Then

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "UPDATE tbltextlocation set txt1X = '" & frmAnnouncementDragnDrop.Panel4.Location.X & _
                "', txt1Y ='" & frmAnnouncementDragnDrop.Panel4.Location.Y & _
                "'WHERE status ='" & frmAnnouncementDragnDrop.ps2 & "'"
            cmd = New MySqlCommand(strSQL, con)
            cmd.ExecuteNonQuery()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "UPDATE tbltextsize set height = '" & frmAnnouncementDragnDrop.Panel4.Size.Height & _
                "', width='" & frmAnnouncementDragnDrop.Panel4.Size.Width & _
                "'WHERE status ='" & frmAnnouncementDragnDrop.ps2 & "'"
            cmd = New MySqlCommand(strSQL, con)
            cmd.ExecuteNonQuery()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If

            pal2 = False
        End If

        If pal3 = True Then

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "UPDATE tbltextlocation set txt1X = '" & frmAnnouncementDragnDrop.Panel5.Location.X & _
                "', txt1Y ='" & frmAnnouncementDragnDrop.Panel5.Location.Y & _
                "'WHERE status ='" & frmAnnouncementDragnDrop.ps3 & "'"
            cmd = New MySqlCommand(strSQL, con)
            cmd.ExecuteNonQuery()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "UPDATE tbltextsize set height = '" & frmAnnouncementDragnDrop.Panel5.Size.Height & _
                "', width='" & frmAnnouncementDragnDrop.Panel5.Size.Width & _
                "'WHERE status ='" & frmAnnouncementDragnDrop.ps3 & "'"
            cmd = New MySqlCommand(strSQL, con)
            cmd.ExecuteNonQuery()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If

            pal3 = False
        End If

        If isLabel1 = True Then
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "UPDATE txttextlocation set txt1X = '" & frmAnnouncementDragnDrop.lbl1.Location.X & _
                "', txt1Y ='" & frmAnnouncementDragnDrop.lbl1.Location.Y & _
                "'WHERE status ='" & frmAnnouncementDragnDrop.strLbl1 & "'"
            cmd = New MySqlCommand(strSQL, con)
            cmd.ExecuteNonQuery()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        End If

        If isLabel2 = True Then
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "UPDATE txttextlocation set txt1X = '" & frmAnnouncementDragnDrop.lbl2.Location.X & _
                "', txt1Y ='" & frmAnnouncementDragnDrop.lbl2.Location.Y & _
                "'WHERE status ='" & frmAnnouncementDragnDrop.strLbl2 & "'"
            cmd = New MySqlCommand(strSQL, con)
            cmd.ExecuteNonQuery()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        End If


    End Sub

    Private Sub btnU1_Click(sender As Object, e As EventArgs) Handles btnU1.Click
        If btnU1.Text = "TextBox1" Then
            txtMsg.Visible = True
            x1 = "txt1"
            Button11.Text = "CANCEL"
        End If
    End Sub

    Private Sub btnU2_Click(sender As Object, e As EventArgs) Handles btnU2.Click
        If btnU2.Text = "TextBox2" Then
            txtMsg.Visible = True
            x1 = "txt2"
            Button11.Text = "CANCEL"
        End If
    End Sub

    Private Sub btnU3_Click(sender As Object, e As EventArgs) Handles btnU3.Click
        If btnU3.Text = "TextBox3" Then
            txtMsg.Visible = True
            x1 = "txt3"
            Button11.Text = "CANCEL"
        End If
    End Sub

    Private Sub btnU4_Click(sender As Object, e As EventArgs) Handles btnU4.Click
        If btnU4.Text = "TextBox4" Then
            txtMsg.Visible = True
            x1 = "txt4"
            Button11.Text = "CANCEL"
        End If
    End Sub

    Private Sub btnU5_Click(sender As Object, e As EventArgs) Handles btnU5.Click
        If btnU5.Text = "TextBox5" Then
            x1 = "txt5"
            txtMsg.Visible = True
            Button11.Text = "CANCEL"
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If Button11.Text = "CANCEL" Then
            Button11.Text = "RESET"
            txtMsg.Text = ""
            txtMsg.Visible = False

            pl1.Visible = False
            p1.Visible = False
            btnUpload.Visible = False

        ElseIf Button11.Text = "RESET" Then
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "TRUNCATE TABLE tbla1"
            cmd = New MySqlCommand(strSQL, con)
            cmd.ExecuteNonQuery()

            If con.State <> ConnectionState.Open Then
                con.Close()
            End If

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "TRUNCATE TABLE tbla2"
            cmd = New MySqlCommand(strSQL, con)
            cmd.ExecuteNonQuery()

            If con.State <> ConnectionState.Open Then
                con.Close()
            End If

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "TRUNCATE TABLE tbla3"
            cmd = New MySqlCommand(strSQL, con)
            cmd.ExecuteNonQuery()

            If con.State <> ConnectionState.Open Then
                con.Close()
            End If

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "TRUNCATE TABLE tbla4"
            cmd = New MySqlCommand(strSQL, con)
            cmd.ExecuteNonQuery()

            If con.State <> ConnectionState.Open Then
                con.Close()
            End If

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "TRUNCATE TABLE tbla5"
            cmd = New MySqlCommand(strSQL, con)
            cmd.ExecuteNonQuery()

            If con.State <> ConnectionState.Open Then
                con.Close()
            End If

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "TRUNCATE TABLE tblb1"
            cmd = New MySqlCommand(strSQL, con)
            cmd.ExecuteNonQuery()

            If con.State <> ConnectionState.Open Then
                con.Close()
            End If

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "TRUNCATE TABLE tblb2"
            cmd = New MySqlCommand(strSQL, con)
            cmd.ExecuteNonQuery()

            If con.State <> ConnectionState.Open Then
                con.Close()
            End If

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "TRUNCATE TABLE tblb3"
            cmd = New MySqlCommand(strSQL, con)
            cmd.ExecuteNonQuery()

            If con.State <> ConnectionState.Open Then
                con.Close()
            End If

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "TRUNCATE TABLE tblb4"
            cmd = New MySqlCommand(strSQL, con)
            cmd.ExecuteNonQuery()

            If con.State <> ConnectionState.Open Then
                con.Close()
            End If

            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "TRUNCATE TABLE tblb5"
            cmd = New MySqlCommand(strSQL, con)
            cmd.ExecuteNonQuery()

            If con.State <> ConnectionState.Open Then
                con.Close()
            End If


            MsgBox("Records has been truncated!", MsgBoxStyle.Information, "Truncate")
            txtMsg.Visible = False
            p1.Visible = False
            pl1.Visible = False
            btnUpload.Visible = False
            btnU1.Visible = False
            btnU2.Visible = False
            btnU3.Visible = False
            btnU4.Visible = False
            btnU5.Visible = False
            btnP1.Visible = False
            btnP2.Visible = False
            btnP3.Visible = False
            btnP4.Visible = False
            btnP5.Visible = False
        End If
    End Sub

    Private Sub btnP1_Click(sender As Object, e As EventArgs) Handles btnP1.Click
        If btnP1.Text = "PictureBox1" Then
            p1.Visible = True
            pl1.Visible = True
            btnUpload.Visible = True
            x1 = "pic1"
            Button11.Text = "CANCEL"
        End If
    End Sub

    Private Sub btnP2_Click(sender As Object, e As EventArgs) Handles btnP2.Click
        If btnP2.Text = "PictureBox2" Then
            p1.Visible = True
            pl1.Visible = True
            btnUpload.Visible = True
            x1 = "pic2"
            Button11.Text = "CANCEL"
        End If
    End Sub

    Private Sub btnP3_Click(sender As Object, e As EventArgs) Handles btnP3.Click
        If btnP3.Text = "PictureBox3" Then
            p1.Visible = True
            pl1.Visible = True
            btnUpload.Visible = True
            x1 = "pic3"
            Button11.Text = "CANCEL"
        End If
    End Sub

    Private Sub btnP4_Click(sender As Object, e As EventArgs) Handles btnP4.Click
        If btnP4.Text = "PictureBox4" Then
            p1.Visible = True
            pl1.Visible = True
            btnUpload.Visible = True
            x1 = "pic4"
            Button11.Text = "CANCEL"
        End If
    End Sub

    Private Sub btnP5_Click(sender As Object, e As EventArgs) Handles btnP5.Click
        If btnP5.Text = "PictureBox5" Then
            p1.Visible = True
            pl1.Visible = True
            btnUpload.Visible = True
            x1 = "pic5"
            Button11.Text = "CANCEL"
        End If
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        OpenDialog.FileName = ""
        OpenDialog.Filter = "Picture Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
        OpenDialog.ShowDialog()
        If OpenDialog.SafeFileName = "" Or OpenDialog.SafeFileName = " " Or OpenDialog.FileName.ToString = "" Or OpenDialog.FileName.ToString = " " Then
            Exit Sub
        End If
        If Not Directory.Exists(System.AppDomain.CurrentDomain.BaseDirectory & "Photos\img") = True Then
            Directory.CreateDirectory(System.AppDomain.CurrentDomain.BaseDirectory & "Photos\img")
        End If
        Try
            If Not Directory.Exists(System.AppDomain.CurrentDomain.BaseDirectory & "Photos\img\" & OpenDialog.SafeFileName) Then
                File.Copy(OpenDialog.FileName.ToString, System.AppDomain.CurrentDomain.BaseDirectory & "Photos\img\" & OpenDialog.SafeFileName)
                photoget = OpenDialog.SafeFileName

                p1.ImageLocation = System.AppDomain.CurrentDomain.BaseDirectory & "Photos\img\" & OpenDialog.SafeFileName
                'Dim i As Integer = 1

                'If i > 2 Then
                '    If i = 1 Then
                '        PictureBox2.ImageLocation = System.AppDomain.CurrentDomain.BaseDirectory & "Photos\images\" & OpenDialog.SafeFileName
                '        PictureBox3.ImageLocation = Nothing
                '        i += 1
                '        If i = 2 Then
                '            PictureBox2.ImageLocation = System.AppDomain.CurrentDomain.BaseDirectory & "Photos\images\" & OpenDialog.SafeFileName
                '            PictureBox3.ImageLocation = System.AppDomain.CurrentDomain.BaseDirectory & "Photos\images\" & OpenDialog.SafeFileName
                '        End If
                '    End If

                'End If


                'Dim img1 As String = System.AppDomain.CurrentDomain.BaseDirectory & "Photos\images\" & photoset & ""
                'Dim img2 As String = System.AppDomain.CurrentDomain.BaseDirectory & "Photos\images\" & photoset1 & ""

                'If cboSize.Text = "1 times" Then
                '    PictureBox2.ImageLocation = img1
                'ElseIf cboSize.Text = "2 times" Then
                '    PictureBox3.ImageLocation = img2
                'End If

            Else
                MsgBox("There is already a file called " & photoset & " in the destination folder!", MsgBoxStyle.Critical, "Already Exist")
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("Already uploaded in the storage. Please change the name of the photo.", MsgBoxStyle.Exclamation, "Error")
            Return
        End Try
    End Sub
End Class