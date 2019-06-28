<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenuPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMenuPrincipal))
        Me.FormMenuPrincipalMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.DataMiningToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataMiningPDFReaderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataMiningImagesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataMiningAudioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataMiningVideoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormMenuPrincipalMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'FormMenuPrincipalMenuStrip
        '
        Me.FormMenuPrincipalMenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.FormMenuPrincipalMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataMiningToolStripMenuItem})
        Me.FormMenuPrincipalMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.FormMenuPrincipalMenuStrip.Name = "FormMenuPrincipalMenuStrip"
        Me.FormMenuPrincipalMenuStrip.Size = New System.Drawing.Size(800, 28)
        Me.FormMenuPrincipalMenuStrip.TabIndex = 0
        Me.FormMenuPrincipalMenuStrip.Text = "MenuStrip1"
        '
        'DataMiningToolStripMenuItem
        '
        Me.DataMiningToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataMiningPDFReaderToolStripMenuItem, Me.DataMiningImagesToolStripMenuItem, Me.DataMiningAudioToolStripMenuItem, Me.DataMiningVideoToolStripMenuItem})
        Me.DataMiningToolStripMenuItem.Name = "DataMiningToolStripMenuItem"
        Me.DataMiningToolStripMenuItem.Size = New System.Drawing.Size(133, 24)
        Me.DataMiningToolStripMenuItem.Text = "Mineria de datos"
        '
        'DataMiningPDFReaderToolStripMenuItem
        '
        Me.DataMiningPDFReaderToolStripMenuItem.Name = "DataMiningPDFReaderToolStripMenuItem"
        Me.DataMiningPDFReaderToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.DataMiningPDFReaderToolStripMenuItem.Text = "Lector PDF"
        '
        'DataMiningImagesToolStripMenuItem
        '
        Me.DataMiningImagesToolStripMenuItem.Name = "DataMiningImagesToolStripMenuItem"
        Me.DataMiningImagesToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.DataMiningImagesToolStripMenuItem.Text = "Imagenes"
        '
        'DataMiningAudioToolStripMenuItem
        '
        Me.DataMiningAudioToolStripMenuItem.Name = "DataMiningAudioToolStripMenuItem"
        Me.DataMiningAudioToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.DataMiningAudioToolStripMenuItem.Text = "Audio"
        '
        'DataMiningVideoToolStripMenuItem
        '
        Me.DataMiningVideoToolStripMenuItem.Name = "DataMiningVideoToolStripMenuItem"
        Me.DataMiningVideoToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.DataMiningVideoToolStripMenuItem.Text = "Video"
        '
        'FormMenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.FormMenuPrincipalMenuStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.FormMenuPrincipalMenuStrip
        Me.Name = "FormMenuPrincipal"
        Me.Text = "Paso 4 - Aplicativo Multimedia - 201416_3"
        Me.FormMenuPrincipalMenuStrip.ResumeLayout(False)
        Me.FormMenuPrincipalMenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FormMenuPrincipalMenuStrip As MenuStrip
    Friend WithEvents DataMiningToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataMiningPDFReaderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataMiningImagesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataMiningAudioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataMiningVideoToolStripMenuItem As ToolStripMenuItem
End Class
