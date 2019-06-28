Public Class FormDataMiningVideo
    Private Sub FormDataMiningVideo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim openFileDialog As OpenFileDialog = New OpenFileDialog
        With openFileDialog
            .Filter = "Vídeo (.mp4)|*.mp4"
            .Title = "Busque su archivo de Vídeo MP4"
        End With
        Dim result As DialogResult = openFileDialog.ShowDialog
        If result = Windows.Forms.DialogResult.OK Then
            AxWindowsMediaPlayerFormDataMiningVideo.URL = openFileDialog.FileName
        Else
            Close()
        End If
    End Sub

    Private Sub FormDataMiningVideo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        AxWindowsMediaPlayerFormDataMiningVideo.Ctlcontrols.stop()
        Hide()
        FormMenuPrincipal_JSCG.Show()
    End Sub
End Class