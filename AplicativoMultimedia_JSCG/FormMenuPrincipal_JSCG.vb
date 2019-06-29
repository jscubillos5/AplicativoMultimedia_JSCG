Public Class FormMenuPrincipal_JSCG

#Region "Métodos y eventos para controlar el formulario principal"
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

    Private Sub LinkLabelCopyright_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelCopyright.LinkClicked
        MessageBox.Show("Las imagenes usadas, en este sistema, son diseñadas por terceros y estan protegidas por derechos de autor, para más detalles lo invitamos ir a: https://www.freepikcompany.com/copyright", "Derechos de autor terceros")
        Process.Start("https://www.freepikcompany.com/copyright")
    End Sub

#End Region

End Class
