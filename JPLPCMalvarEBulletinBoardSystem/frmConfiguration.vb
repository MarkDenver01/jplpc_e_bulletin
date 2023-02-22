Imports MySql.Data.MySqlClient


Public Class frmConfiguration
    Dim csstring As String = "server=localhost;uid=root;pwd=admin;database=ebulletindb;"
    Public a1 As String = String.Empty
    Public a2 As String = String.Empty
    Public a3 As String = String.Empty
    Public a4 As String = String.Empty
    Public a5 As String = String.Empty
    Public TimerCount As Integer = 6
    Private Sub frmConfiguration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnStart.Enabled = False
        btnStop.Enabled = False
        lblR1.Text = "Not Running..."
        lblR2.Text = "Not Running..."
        lblR3.Text = "Not Running..."
        lblR4.Text = "Not Running..."
        lblR5.Text = "Not Running..."
    End Sub

    Private Sub btnPrev1_Click(sender As Object, e As EventArgs) Handles btnPrev1.Click
        frmAnnouncement_Pic.ShowDialog()
    End Sub

    Private Sub btnPrev5_Click(sender As Object, e As EventArgs) Handles btnPrev5.Click
        frmAnnouncement.ShowDialog()
    End Sub

    Private Sub btnPrev2_Click(sender As Object, e As EventArgs) Handles btnPrev2.Click
        frmAnnouncement_View.ShowDialog()
    End Sub

  
    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        

        Dim res As DialogResult
        res = MsgBox("Do you want to add Background music before you continue...", vbYesNo + MsgBoxStyle.Information, "Information")
        If res = Windows.Forms.DialogResult.Yes Then
            frmSAPI.ShowDialog()
        Else
            Timer1.Enabled = True
            Timer1.Interval = 30000
            Timer1.Start()
            MsgBox("Announcement Board will be started at 30 seconds", MsgBoxStyle.Information, "Activated")
        End If

    End Sub


    Dim temp1 As Integer = 10000
    Dim temp2 As Integer = 15000

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TimerCount = TimerCount - 1
        If TimerCount = 5 Then
            If a1 = "Ready" Then
                frmAnnouncement_View.Hide()
                frmAnnouncement.Hide()
                frmAnnouncementDragnDrop.Hide()
                frmAnnouncementCenter.Hide()
                frmAnnouncement_Pic.Show()
            Else
                frmAnnouncement_Pic.Hide()
            End If
        ElseIf TimerCount = 4 Then
            If a2 = "Ready" Then
                frmAnnouncement_Pic.Hide()
                frmAnnouncement.Hide()
                frmAnnouncementCenter.Hide()
                frmAnnouncementDragnDrop.Hide()
                frmAnnouncement_View.Show()
            Else
                frmAnnouncement_View.Hide()
            End If
        ElseIf TimerCount = 3 Then
            If a3 = "Ready" Then
                frmAnnouncement_Pic.Hide()
                frmAnnouncement.Hide()
                frmAnnouncement_View.Hide()
                frmAnnouncementDragnDrop.Hide()
                frmAnnouncementCenter.Show()
            Else
                frmAnnouncementCenter.Hide()
            End If
        ElseIf TimerCount = 2 Then
            If a4 = "Ready" Then
                frmAnnouncement.Hide()
                frmAnnouncement_Pic.Hide()
                frmAnnouncement_View.Hide()
                frmAnnouncementCenter.Hide()
                frmAnnouncementDragnDrop.Show()
            Else
                frmAnnouncementDragnDrop.Hide()
            End If
        ElseIf TimerCount = 1 Then
            If a5 = "Ready" Then
                frmAnnouncement_Pic.Hide()
                frmAnnouncement_View.Hide()
                frmAnnouncementDragnDrop.Hide()
                frmAnnouncementCenter.Hide()
                frmAnnouncement.Show()
            Else
                frmAnnouncement.Hide()
            End If
            Timer1.Enabled = False
            If Timer1.Enabled = False Then
                TimerCount = 6
                Timer1.Enabled = True
                Timer1.Start()
            End If
        End If
    End Sub


    Private Sub btnUpdate1_Click(sender As Object, e As EventArgs) Handles btnUpdate1.Click
        btnStart.Enabled = True
        btnStop.Enabled = True
        If btnUpdate1.Text = "Activate" Then
            a1 = "Ready"
            lblR1.Text = "Running..."
            btnUpdate1.Text = "Deactivate"
            MsgBox("Announcement Template 1 has been activated.", MsgBoxStyle.Information, "Information")
        Else
            If btnUpdate1.Text = "Deactivate" Then
                a1 = ""
                lblR1.Text = "Not Running..."
                MsgBox("Announcement Template 1 has been deactivated.", MsgBoxStyle.Information, "Information")
                btnUpdate1.Text = "Activate"
            End If
        End If
    End Sub

    Private Sub btnUpdate2_Click(sender As Object, e As EventArgs) Handles btnUpdate2.Click
        btnStart.Enabled = True
        btnStop.Enabled = True
        If btnUpdate2.Text = "Activate" Then
            a2 = "Ready"
            lblR2.Text = "Running..."
            btnUpdate2.Text = "Deactivate"
            MsgBox("Announcement Template 2 has been activated.", MsgBoxStyle.Information, "Information")
        Else
            If btnUpdate2.Text = "Deactivate" Then
                a2 = ""
                lblR2.Text = "Not Running..."
                MsgBox("Announcement Template 2 has been deactivated.", MsgBoxStyle.Information, "Information")
                btnUpdate2.Text = "Activate"
            End If
        End If
    End Sub

    Private Sub btnUpdate3_Click(sender As Object, e As EventArgs) Handles btnUpdate3.Click
        btnStart.Enabled = True
        btnStop.Enabled = True
        If btnUpdate3.Text = "Activate" Then
            a3 = "Ready"
            lblR3.Text = "Running..."
            btnUpdate3.Text = "Deactivate"
            MsgBox("Announcement Template 3 has been activated.", MsgBoxStyle.Information, "Information")
        Else
            If btnUpdate3.Text = "Deactivate" Then
                a3 = ""
                lblR3.Text = "Not Running..."
                MsgBox("Announcement Template 3 has been deactivated.", MsgBoxStyle.Information, "Information")
                btnUpdate3.Text = "Activate"
            End If
        End If
    End Sub

    Private Sub btnUpdate4_Click(sender As Object, e As EventArgs) Handles btnUpdate4.Click
        btnStart.Enabled = True
        btnStop.Enabled = True
        If btnUpdate4.Text = "Activate" Then
            a4 = "Ready"
            lblR4.Text = "Running..."
            btnUpdate4.Text = "Deactivate"
            MsgBox("Announcement Template 4 has been activated.", MsgBoxStyle.Information, "Information")
        Else
            If btnUpdate4.Text = "Deactivate" Then
                a4 = ""
                lblR4.Text = "Not Running..."
                MsgBox("Announcement Template 4 has been deactivated.", MsgBoxStyle.Information, "Information")
                btnUpdate4.Text = "Activate"
            End If
        End If
    End Sub

    Private Sub btnUpdate5_Click(sender As Object, e As EventArgs) Handles btnUpdate5.Click
        btnStart.Enabled = True
        btnStop.Enabled = True
        If btnUpdate5.Text = "Activate" Then
            a5 = "Ready"
            lblR5.Text = "Running..."
            btnUpdate5.Text = "Deactivate"
            MsgBox("Announcement Template 5 has been deactivated.", MsgBoxStyle.Information, "Information")
        Else
            If btnUpdate5.Text = "Deactivate" Then
                a5 = ""
                lblR5.Text = "Not Running..."
                MsgBox("Announcement Template 5 has been deactivated.", MsgBoxStyle.Information, "Information")
                btnUpdate5.Text = "Activate"
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        frmAnnouncement_View.Hide()
        frmAnnouncement_Pic.Hide()
        frmAnnouncement.Hide()
        btnStart.Enabled = False
        btnStop.Enabled = False
        btnUpdate1.Text = "Activate"
        btnUpdate2.Text = "Activate"
        btnUpdate3.Text = "Activate"
        btnUpdate4.Text = "Activate"
        btnUpdate5.Text = "Activate"
        a1 = ""
        a2 = ""
        a3 = ""
        a4 = ""
        a5 = ""
        Timer1.Stop()
        MsgBox("Announcement board has been stopped by the admin", MsgBoxStyle.Information, "Information")
    End Sub

    Private Sub btnPrev4_Click(sender As Object, e As EventArgs) Handles btnPrev4.Click
        frmAnnouncementDragnDrop.ShowDialog()
    End Sub

    Private Sub btnPrev3_Click(sender As Object, e As EventArgs) Handles btnPrev3.Click

        frmAnnouncementCenter.ShowDialog()
    End Sub

    Private Sub btnPost1_Click(sender As Object, e As EventArgs) Handles btnPost1.Click
        Dim res As DialogResult
        res = MsgBox("Note: Five photos ca be posted in the Electronic bulletin board. Do you want to proceed?", vbYesNo + MsgBoxStyle.Information, "Information")
        If res = Windows.Forms.DialogResult.Yes Then
            frmPhotoPost.ShowDialog()
        End If
    End Sub

    Private Sub btnView1_Click(sender As Object, e As EventArgs) Handles btnView1.Click
        Dim res As DialogResult
        res = MsgBox("Do you want to view the record?", vbYesNo + MsgBoxStyle.Information, "Information")
        If res = Windows.Forms.DialogResult.Yes Then
            frmPhotoPostEdit.ShowDialog()
        End If
    End Sub


    Private Sub btnView2_Click(sender As Object, e As EventArgs) Handles btnView2.Click
        Dim res As DialogResult
        res = MsgBox("Do you want to view the record?", vbYesNo + MsgBoxStyle.Information, "Information")
        If res = Windows.Forms.DialogResult.Yes Then
            frmPostAnnouncementEdit2.ShowDialog()
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btnPost2.Click
        Dim res As DialogResult
        res = MsgBox("Do you want to post a message?", vbYesNo + MsgBoxStyle.Information, "Information")
        If res = Windows.Forms.DialogResult.Yes Then
            frmPostAnnouncement2.ShowDialog()
        End If
    End Sub

    Private Sub btnView3_Click(sender As Object, e As EventArgs) Handles btnView3.Click
        Dim res As DialogResult
        res = MsgBox("Do you want to view the record?", vbYesNo + MsgBoxStyle.Information, "Information")
        If res = Windows.Forms.DialogResult.Yes Then
            frmPostAnnouncementEdit3.ShowDialog()

        End If
    End Sub

    Private Sub btnPost3_Click(sender As Object, e As EventArgs) Handles btnPost3.Click
        Dim res As DialogResult
        res = MsgBox("Do you want to post a message?", vbYesNo + MsgBoxStyle.Information, "Information")
        If res = Windows.Forms.DialogResult.Yes Then
            frmPostAnnouncement3.ShowDialog()
        End If
    End Sub

    Private Sub btnPost5_Click(sender As Object, e As EventArgs) Handles btnPost5.Click
        Dim res As DialogResult
        res = MsgBox("Do you want to post a message?", vbYesNo + MsgBoxStyle.Information, "Information")
        If res = Windows.Forms.DialogResult.Yes Then
            frmAllSMS.ShowDialog()
        End If
    End Sub

    Private Sub btnView5_Click(sender As Object, e As EventArgs) Handles btnView5.Click
        Dim res As DialogResult
        res = MsgBox("Do you want to view the record?", vbYesNo + MsgBoxStyle.Information, "Information")
        If res = Windows.Forms.DialogResult.Yes Then
            frmAllSMS.ShowDialog()

        End If
    End Sub

    Private Sub btnPost4_Click(sender As Object, e As EventArgs) Handles btnPost4.Click
        Dim res As DialogResult
        res = MsgBox("Do you want to post the record?", vbYesNo + MsgBoxStyle.Information, "Information")
        If res = Windows.Forms.DialogResult.Yes Then
            frmDragNDropObject.ShowDialog()

        End If
    End Sub

    Private Sub btnView4_Click(sender As Object, e As EventArgs) Handles btnView4.Click
        frmAnnouncementDragnDrop.ShowDialog()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Please filled up the name.", MsgBoxStyle.Information, "Empty")
            Exit Sub
        End If

        If Button1.Text = "SAVE" Then
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "INSERT INTO tblbirthday(name, dateofbirth) VALUES('" & TextBox1.Text & "','" & _
            Format(DateTimePicker1.Value, "yyyy-MM-dd HH:mm:ss") & "')"
            cmd = New MySqlCommand(strSQL, con)
            cmd.ExecuteNonQuery()
            MsgBox("Record has been saved!", MsgBoxStyle.Information, "Save")
            Call frmListBirthday.LoadRecords()
            TextBox1.Text = ""
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        ElseIf Button1.Text = "UPDATE" Then
            con = New MySqlConnection(csstring)
            con.Open()
            strSQL = "UPDATE tblbirthday set name ='" & TextBox1.Text & _
                "', dateofbirth ='" & Format(DateTimePicker1.Value, "yyyy-MM-dd HH:mm:ss") & _
                "'WHERE id = '" & id.Text & "'"
            cmd = New MySqlCommand(strSQL, con)
            cmd.ExecuteNonQuery()
            MsgBox("Records has been updated!", MsgBoxStyle.Information, "Information")
            Button1.Text = "SAVE"
            Call frmListBirthday.LoadRecords()
            If con.State <> ConnectionState.Open Then
                con.Close()
            End If
        End If
    End Sub

    Private Sub btnView_Click_1(sender As Object, e As EventArgs) Handles btnView.Click
        frmListBirthday.ShowDialog()
    End Sub
End Class