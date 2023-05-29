Public Class Form1
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles cmdCerrar.Click
        Dim numero As Integer

        Do
            numero = Integer.Parse(InputBox("Introduce el número 10 para cerrar:"))
            If numero <> 10 Then
                MessageBox.Show("Error: número incorrecto. Inténtalo de nuevo.")
            End If
        Loop While numero <> 10

        MessageBox.Show("¡Programa cerrado!")
        Me.Close()
    End Sub
End Class
