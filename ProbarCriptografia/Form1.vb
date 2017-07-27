Public Class Form1
    Dim criptografia As New Criptografia.Criptografia

    Private Sub CerrarCMD_Click(sender As Object, e As EventArgs) Handles CerrarCMD.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

    Private Sub EncriptarCMD_Click(sender As Object, e As EventArgs) Handles EncriptarCMD.Click
        Try
            encriptar_texto()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub encriptar_texto()
        ValorEncriptadoTXT.Text = criptografia.encriptar(ValorTXT.Text)
    End Sub

    Private Sub DesencriptarCMD_Click(sender As Object, e As EventArgs) Handles DesencriptarCMD.Click
        Try
            desencriptar_text()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub desencriptar_text()
        ValorDesencriptadoTXT.Text = criptografia.desencriptar(ValorEncriptadoTXT.Text)
    End Sub
End Class
