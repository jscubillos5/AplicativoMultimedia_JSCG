Public Class FormDataMiningImages

    Private i As Integer

    Private Sub FormDataMiningImages_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        TimerDataMiningImages.Stop()
        Hide()
        FormMenuPrincipal_JSCG.Show()
    End Sub

    Private Sub ButtonStart_Click(sender As Object, e As EventArgs) Handles ButtonStart.Click
        TimerDataMiningImages.Start()
        ButtonStart.Enabled = False
        ButtonStop.Enabled = True
    End Sub

    Private Sub ButtonStop_Click(sender As Object, e As EventArgs) Handles ButtonStop.Click
        TimerDataMiningImages.Stop()
        ButtonStart.Enabled = True
        ButtonStop.Enabled = False
    End Sub

    Private Sub FormDataMiningImages_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        i = 0
    End Sub

    Private Sub TimerDataMiningImages_Tick(sender As Object, e As EventArgs) Handles TimerDataMiningImages.Tick
        If i < ImageListFormDataMiningImages.Images.Count Then
            PictureBoxDataMinig.Image = ImageListFormDataMiningImages.Images(i)
            i += 1
        Else
            i = 0
        End If
    End Sub
End Class