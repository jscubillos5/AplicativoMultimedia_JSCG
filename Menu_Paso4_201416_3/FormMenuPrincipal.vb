Public Class FormMenuPrincipal
    Private Sub LinkLabelCopyright_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelCopyright.LinkClicked
        MessageBox.Show("Las imagenes usadas, en este sistema, son diseñadas por terceros y estan protegidas por derechos de autor, para más detalles lo invitamos ir a: https://www.freepikcompany.com/copyright", "Derechos de autor terceros")
        Process.Start("https://www.freepikcompany.com/copyright")
    End Sub
End Class
