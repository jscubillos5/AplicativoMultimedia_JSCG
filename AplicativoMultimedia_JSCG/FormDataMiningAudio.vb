Public Class FormDataMiningAudio
    Private Sub FormDataMiningAudio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim openFileDialog As OpenFileDialog = New OpenFileDialog
        With openFileDialog
            .Filter = "Music (.mp3)|*.mp3"
            .Title = "Busque su archivo de Audio MP3"
        End With
        Dim result As DialogResult = openFileDialog.ShowDialog
        If result = Windows.Forms.DialogResult.OK Then
            AxWindowsMediaPlayerFormDataMiningAudio.URL = openFileDialog.FileName
        Else
            Close()
        End If
    End Sub

    Private Sub FormDataMiningAudio_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        AxWindowsMediaPlayerFormDataMiningAudio.Ctlcontrols.stop()
        Hide()
        FormMenuPrincipal_JSCG.Show()
    End Sub
End Class