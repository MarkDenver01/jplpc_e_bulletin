
Public Class frmSAPI
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        OpenFileDialog1.FileName = "Select Music"
        OpenFileDialog1.ShowDialog()
        If Windows.Forms.DialogResult.OK Then
            For Each songList As String In OpenFileDialog1.FileNames
                lbList.Items.Add(songList)
            Next
        End If
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        AxWindowsMediaPlayer1.URL = lbList.SelectedItem
        frmConfiguration.Timer1.Enabled = True
        frmConfiguration.Timer1.Interval = 30000
        frmConfiguration.Timer1.Start()
        MsgBox("Announcement Board will be started at 30 seconds", MsgBoxStyle.Information, "Activated")
        
        Me.Hide()
    End Sub

    Private Sub frmSAPI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class