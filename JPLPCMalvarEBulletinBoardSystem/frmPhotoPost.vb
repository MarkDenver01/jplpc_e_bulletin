Imports System
Imports System.IO
Imports MySql.Data.MySqlClient
Public Class frmPhotoPost
    Dim csstring As String = "server=localhost;uid=root;pwd=admin;database=ebulletindb;"
    Private Sub frmPhotoPost_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnPost.Enabled = False

        If btnPost.Text = "UPDATE" Then
            btnPost.Enabled = True
        End If
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnU1.Click
        If cboSize.Text = "" Then
            MsgBox("Please select times of photo.", MsgBoxStyle.Information, "Information")
            Exit Sub
        End If

        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Select * from tblphotoannouncement where id > 4"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            If dr.Read Then
                MsgBox("Storage has been exceeded.", MsgBoxStyle.Critical, "Exceed")
                Exit Sub
            End If
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        OpenDialog.FileName = ""
        OpenDialog.Filter = "Picture Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
        OpenDialog.ShowDialog()
        If OpenDialog.SafeFileName = "" Or OpenDialog.SafeFileName = " " Or OpenDialog.FileName.ToString = "" Or OpenDialog.FileName.ToString = " " Then
            Exit Sub
        End If
        If Not Directory.Exists(System.AppDomain.CurrentDomain.BaseDirectory & "Photos\images") = True Then
            Directory.CreateDirectory(System.AppDomain.CurrentDomain.BaseDirectory & "Photos\images")
        End If
        Try
            If Not Directory.Exists(System.AppDomain.CurrentDomain.BaseDirectory & "Photos\images\" & OpenDialog.SafeFileName) Then
                File.Copy(OpenDialog.FileName.ToString, System.AppDomain.CurrentDomain.BaseDirectory & "Photos\images\" & OpenDialog.SafeFileName)
                photoset1 = OpenDialog.SafeFileName

                PictureBox2.ImageLocation = System.AppDomain.CurrentDomain.BaseDirectory & "Photos\images\" & OpenDialog.SafeFileName
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
                btnPost.Enabled = True
            Else
                MsgBox("There is already a file called " & photoset & " in the destination folder!", MsgBoxStyle.Critical, "Already Exist")
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("Already uploaded in the storage. Please change the name of the photo.", MsgBoxStyle.Exclamation, "Error")
            Return
        End Try
    End Sub

    Private Sub btnPost_Click(sender As Object, e As EventArgs) Handles btnPost.Click
        Try
            If btnPost.Text = "POST" Then
                If txtAnnouncement.Text = "" Then
                    MsgBox("Please add a message in the text field", MsgBoxStyle.Information, "Information")
                    Exit Sub
                End If

                con = New MySqlConnection(csstring)
                con.Open()
                strSQL = "insert into tblphotoannouncement(photoentry1, photoentry2, photoentry3, photoentry4, photoentry5, postentry, sizeentry) values('" & photoset1 & "','" &
                    photoset2 & "','" & _
                    photoset3 & "','" & _
                    photoset4 & "','" & _
                    photoset5 & "','" & _
                    txtAnnouncement.Text & "','" &
                    cboSize.Text & "')"
                cmd = New MySqlCommand(strSQL, con)
                cmd.ExecuteNonQuery()
                If con.State <> ConnectionState.Open Then
                    con.Close()
                End If
                Dim res As DialogResult
                res = MsgBox("[NOTE: The storage can accept 5 maximum photos only.]", vbYesNo + MsgBoxStyle.Information, "Save")
                If res = Windows.Forms.DialogResult.Yes Then
                    MsgBox("Announcement has been posted!", MsgBoxStyle.Information, "Save")
                    frmPhotoPostEdit.LoadRecords()
                    btnPost.Enabled = False
                    PictureBox2.ImageLocation = Nothing
                    PictureBox3.ImageLocation = Nothing
                    PictureBox4.ImageLocation = Nothing
                    PictureBox5.ImageLocation = Nothing
                    PictureBox6.ImageLocation = Nothing
                    txtAnnouncement.Text = ""
                    cboSize.SelectedIndex = -1
                    btnPost.Text = "POST"
                    Exit Sub
                End If
            ElseIf btnPost.Text = "UPDATE" Then
                con = New MySqlConnection(csstring)
                con.Open()
                strSQL = "UPDATE tblphotoannouncement set photoentry1 ='" & photoset & _
                    "', postentry ='" & txtAnnouncement.Text & _
                    "', sizeentry ='" & cboSize.Text & _
                    "'WHERE id ='" & Label4.Text & "'"
                cmd = New MySqlCommand(strSQL, con)
                cmd.ExecuteNonQuery()
                MsgBox("Record has been updated!", MsgBoxStyle.Information, "Information")
                Call frmPhotoPostEdit.LoadRecords()
                btnPost.Text = "POST"
                PictureBox2.ImageLocation = Nothing
                PictureBox3.ImageLocation = Nothing
                PictureBox4.ImageLocation = Nothing
                PictureBox5.ImageLocation = Nothing
                PictureBox6.ImageLocation = Nothing
                txtAnnouncement.Text = ""
                cboSize.SelectedIndex = -1
                btnPost.Enabled = False
                If con.State <> ConnectionState.Open Then
                    con.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub cboSize_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSize.SelectedIndexChanged
        If cboSize.Text = "1 times" Then
            PictureBox2.Visible = True
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            PictureBox6.Visible = False
            btnU1.Visible = True
            btnU2.Visible = False
            btnU3.Visible = False
            btnU4.Visible = False
            btnU5.Visible = False
        ElseIf cboSize.Text = "2 times" Then
            PictureBox2.Visible = True
            PictureBox3.Visible = True
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            PictureBox6.Visible = False
            btnU1.Visible = True
            btnU2.Visible = True
            btnU3.Visible = False
            btnU4.Visible = False
            btnU5.Visible = False
        ElseIf cboSize.Text = "3 times" Then
            PictureBox2.Visible = True
            PictureBox3.Visible = True
            PictureBox4.Visible = True
            PictureBox5.Visible = False
            PictureBox6.Visible = False
            btnU1.Visible = True
            btnU2.Visible = True
            btnU3.Visible = True
            btnU4.Visible = False
            btnU5.Visible = False
        ElseIf cboSize.Text = "4 times" Then
            PictureBox2.Visible = True
            PictureBox3.Visible = True
            PictureBox4.Visible = True
            PictureBox5.Visible = True
            PictureBox6.Visible = False
            btnU1.Visible = True
            btnU2.Visible = True
            btnU3.Visible = True
            btnU4.Visible = True
            btnU5.Visible = False
        ElseIf cboSize.Text = "5 times" Then
            PictureBox2.Visible = True
            PictureBox3.Visible = True
            PictureBox4.Visible = True
            PictureBox5.Visible = True
            PictureBox6.Visible = True
            btnU1.Visible = True
            btnU2.Visible = True
            btnU3.Visible = True
            btnU4.Visible = True
            btnU5.Visible = True
        End If
    End Sub

    Private Sub btnU2_Click(sender As Object, e As EventArgs) Handles btnU2.Click
        If cboSize.Text = "" Then
            MsgBox("Please select times of photo.", MsgBoxStyle.Information, "Information")
            Exit Sub
        End If

        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Select * from tblphotoannouncement where id > 4"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            If dr.Read Then
                MsgBox("Storage has been exceeded.", MsgBoxStyle.Critical, "Exceed")
                Exit Sub
            End If
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "Picture Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.SafeFileName = "" Or OpenFileDialog1.SafeFileName = " " Or OpenFileDialog1.FileName.ToString = "" Or OpenFileDialog1.FileName.ToString = " " Then
            Exit Sub
        End If
        If Not Directory.Exists(System.AppDomain.CurrentDomain.BaseDirectory & "Photos\images") = True Then
            Directory.CreateDirectory(System.AppDomain.CurrentDomain.BaseDirectory & "Photos\images")
        End If
        Try
            If Not Directory.Exists(System.AppDomain.CurrentDomain.BaseDirectory & "Photos\images\" & OpenFileDialog1.SafeFileName) Then
                File.Copy(OpenFileDialog1.FileName.ToString, System.AppDomain.CurrentDomain.BaseDirectory & "Photos\images\" & OpenFileDialog1.SafeFileName)
                photoset2 = OpenFileDialog1.SafeFileName

                PictureBox3.ImageLocation = System.AppDomain.CurrentDomain.BaseDirectory & "Photos\images\" & OpenFileDialog1.SafeFileName
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
                btnPost.Enabled = True
            Else
                MsgBox("There is already a file called " & photoset2 & " in the destination folder!", MsgBoxStyle.Critical, "Already Exist")
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("Already uploaded in the storage. Please change the name of the photo.", MsgBoxStyle.Exclamation, "Error")
            Return
        End Try
    End Sub

    Private Sub btnU3_Click(sender As Object, e As EventArgs) Handles btnU3.Click
        If cboSize.Text = "" Then
            MsgBox("Please select times of photo.", MsgBoxStyle.Information, "Information")
            Exit Sub
        End If

        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Select * from tblphotoannouncement where id > 4"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            If dr.Read Then
                MsgBox("Storage has been exceeded.", MsgBoxStyle.Critical, "Exceed")
                Exit Sub
            End If
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        OpenFileDialog2.FileName = ""
        OpenFileDialog2.Filter = "Picture Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
        OpenFileDialog2.ShowDialog()
        If OpenFileDialog2.SafeFileName = "" Or OpenFileDialog2.SafeFileName = " " Or OpenFileDialog2.FileName.ToString = "" Or OpenFileDialog2.FileName.ToString = " " Then
            Exit Sub
        End If
        If Not Directory.Exists(System.AppDomain.CurrentDomain.BaseDirectory & "Photos\images") = True Then
            Directory.CreateDirectory(System.AppDomain.CurrentDomain.BaseDirectory & "Photos\images")
        End If
        Try
            If Not Directory.Exists(System.AppDomain.CurrentDomain.BaseDirectory & "Photos\images\" & OpenFileDialog2.SafeFileName) Then
                File.Copy(OpenFileDialog2.FileName.ToString, System.AppDomain.CurrentDomain.BaseDirectory & "Photos\images\" & OpenFileDialog2.SafeFileName)
                photoset3 = OpenFileDialog2.SafeFileName

                PictureBox4.ImageLocation = System.AppDomain.CurrentDomain.BaseDirectory & "Photos\images\" & OpenFileDialog2.SafeFileName
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
                btnPost.Enabled = True
            Else
                MsgBox("There is already a file called " & photoset3 & " in the destination folder!", MsgBoxStyle.Critical, "Already Exist")
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("Already uploaded in the storage. Please change the name of the photo.", MsgBoxStyle.Exclamation, "Error")
            Return
        End Try
    End Sub

    Private Sub btnU4_Click(sender As Object, e As EventArgs) Handles btnU4.Click
        If cboSize.Text = "" Then
            MsgBox("Please select times of photo.", MsgBoxStyle.Information, "Information")
            Exit Sub
        End If

        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Select * from tblphotoannouncement where id > 4"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            If dr.Read Then
                MsgBox("Storage has been exceeded.", MsgBoxStyle.Critical, "Exceed")
                Exit Sub
            End If
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        OpenFileDialog3.FileName = ""
        OpenFileDialog3.Filter = "Picture Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
        OpenFileDialog3.ShowDialog()
        If OpenFileDialog3.SafeFileName = "" Or OpenFileDialog3.SafeFileName = " " Or OpenFileDialog3.FileName.ToString = "" Or OpenFileDialog3.FileName.ToString = " " Then
            Exit Sub
        End If
        If Not Directory.Exists(System.AppDomain.CurrentDomain.BaseDirectory & "Photos\images") = True Then
            Directory.CreateDirectory(System.AppDomain.CurrentDomain.BaseDirectory & "Photos\images")
        End If
        Try
            If Not Directory.Exists(System.AppDomain.CurrentDomain.BaseDirectory & "Photos\images\" & OpenFileDialog3.SafeFileName) Then
                File.Copy(OpenFileDialog3.FileName.ToString, System.AppDomain.CurrentDomain.BaseDirectory & "Photos\images\" & OpenFileDialog3.SafeFileName)
                photoset4 = OpenFileDialog3.SafeFileName

                PictureBox5.ImageLocation = System.AppDomain.CurrentDomain.BaseDirectory & "Photos\images\" & OpenFileDialog3.SafeFileName
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
                btnPost.Enabled = True
            Else
                MsgBox("There is already a file called " & photoset4 & " in the destination folder!", MsgBoxStyle.Critical, "Already Exist")
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("Already uploaded in the storage. Please change the name of the photo.", MsgBoxStyle.Exclamation, "Error")
            Return
        End Try
    End Sub

    Private Sub btnU5_Click(sender As Object, e As EventArgs) Handles btnU5.Click
        If cboSize.Text = "" Then
            MsgBox("Please select times of photo.", MsgBoxStyle.Information, "Information")
            Exit Sub
        End If

        Try
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "Select * from tblphotoannouncement where id > 4"
            cmd = New MySqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            If dr.Read Then
                MsgBox("Storage has been exceeded.", MsgBoxStyle.Critical, "Exceed")
                Exit Sub
            End If
            dr.Close()
            cmd.Dispose()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        OpenFileDialog4.FileName = ""
        OpenFileDialog4.Filter = "Picture Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
        OpenFileDialog4.ShowDialog()
        If OpenFileDialog4.SafeFileName = "" Or OpenFileDialog4.SafeFileName = " " Or OpenFileDialog4.FileName.ToString = "" Or OpenFileDialog4.FileName.ToString = " " Then
            Exit Sub
        End If
        If Not Directory.Exists(System.AppDomain.CurrentDomain.BaseDirectory & "Photos\images") = True Then
            Directory.CreateDirectory(System.AppDomain.CurrentDomain.BaseDirectory & "Photos\images")
        End If
        Try
            If Not Directory.Exists(System.AppDomain.CurrentDomain.BaseDirectory & "Photos\images\" & OpenFileDialog4.SafeFileName) Then
                File.Copy(OpenFileDialog4.FileName.ToString, System.AppDomain.CurrentDomain.BaseDirectory & "Photos\images\" & OpenFileDialog4.SafeFileName)
                photoset5 = OpenFileDialog4.SafeFileName

                PictureBox6.ImageLocation = System.AppDomain.CurrentDomain.BaseDirectory & "Photos\images\" & OpenFileDialog4.SafeFileName
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
                btnPost.Enabled = True
            Else
                MsgBox("There is already a file called " & photoset5 & " in the destination folder!", MsgBoxStyle.Critical, "Already Exist")
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("Already uploaded in the storage. Please change the name of the photo.", MsgBoxStyle.Exclamation, "Error")
            Return
        End Try
    End Sub
End Class