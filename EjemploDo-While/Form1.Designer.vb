<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        cmdCerrar = New Button()
        lblTitulo = New Label()
        lblCerrar = New Label()
        SuspendLayout()
        ' 
        ' cmdCerrar
        ' 
        cmdCerrar.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        cmdCerrar.Location = New Point(167, 100)
        cmdCerrar.Name = "cmdCerrar"
        cmdCerrar.Size = New Size(146, 44)
        cmdCerrar.TabIndex = 0
        cmdCerrar.Text = "Ejecutar"
        cmdCerrar.UseVisualStyleBackColor = True
        ' 
        ' lblTitulo
        ' 
        lblTitulo.AutoSize = True
        lblTitulo.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblTitulo.Location = New Point(178, 60)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(135, 21)
        lblTitulo.TabIndex = 2
        lblTitulo.Text = "Cerrar programa"
        ' 
        ' lblCerrar
        ' 
        lblCerrar.AutoSize = True
        lblCerrar.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblCerrar.ForeColor = Color.Red
        lblCerrar.Location = New Point(180, 196)
        lblCerrar.Name = "lblCerrar"
        lblCerrar.Size = New Size(0, 21)
        lblCerrar.TabIndex = 3
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(489, 353)
        Controls.Add(lblCerrar)
        Controls.Add(lblTitulo)
        Controls.Add(cmdCerrar)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmdCerrar As Button
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblCerrar As Label
End Class
