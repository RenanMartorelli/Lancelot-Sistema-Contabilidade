Public Class uct_dados_empresa
    Private Sub uct_dados_empresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If tipologin = "operador" Then
            txt_email.Enabled = False
            txt_endereço.Enabled = False
            txt_nome_empresa.Enabled = False
            txt_segmento.Enabled = False
            btn_adicionar_usuario.Enabled = False
            btn_editar_dados.Enabled = False
        End If
    End Sub
End Class
