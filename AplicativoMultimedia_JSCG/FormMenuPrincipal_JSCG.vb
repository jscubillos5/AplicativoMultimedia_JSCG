Public Class FormMenuPrincipal_JSCG
    Private Sub DataMiningPDFReaderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataMiningPDFReaderToolStripMenuItem.Click
        Hide()
        Dim formDataMiningPDFReader = New FormDataMiningPDFReader
        formDataMiningPDFReader.ShowDialog()
    End Sub

    Private Sub DataMiningImagesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataMiningImagesToolStripMenuItem.Click
        Hide()
        Dim formDataMiningImages = New FormDataMiningImages
        formDataMiningImages.ShowDialog()
    End Sub

    Private Sub DataMiningAudioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataMiningAudioToolStripMenuItem.Click
        Hide()
        Dim formDataMiningAudio = New FormDataMiningAudio
        formDataMiningAudio.ShowDialog()
    End Sub

    Private Sub DataMiningVideoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataMiningVideoToolStripMenuItem.Click
        Hide()
        Dim formDataMiningVideo = New FormDataMiningVideo
        formDataMiningVideo.ShowDialog()
    End Sub
End Class
