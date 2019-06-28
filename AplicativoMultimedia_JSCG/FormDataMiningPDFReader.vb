Public Class FormDataMiningPDFReader
    Private Sub FormDataMiningPDFReader_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim openFileDialog As OpenFileDialog = New OpenFileDialog
        With openFileDialog
            .Filter = "PDF Files(*.pdf)|*.pdf"
            .Title = "Busque su archivo PDF"
        End With
        Dim result As DialogResult = openFileDialog.ShowDialog
        If result = Windows.Forms.DialogResult.OK Then
            WebBrowserDataMiningPDFReader.Navigate(openFileDialog.FileName)
            WindowState = FormWindowState.Maximized
        Else
            Close()
        End If
    End Sub

    Private Sub FormDataMiningPDFReader_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Hide()
        FormMenuPrincipal_JSCG.Show()
    End Sub
End Class