Public Class frmRunningMessage

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        frmPreview.txtRunningMessage.Text = txtMessage.Text
        frmAnnouncement.txtRunningMessage.Text = txtMessage.Text
        frmAnnouncement_Pic.txtRunningMessage.Text = txtMessage.Text
        frmAnnouncement_View.txtRunningMessage.Text = txtMessage.Text
        frmAnnouncementCenter.txtRunningMessage.Text = txtMessage.Text
        frmAnnouncementDragnDrop.txtRunningMessage.Text = txtMessage.Text
        MsgBox("Running message has been updated!", MsgBoxStyle.Information, "Updated")
    End Sub
End Class