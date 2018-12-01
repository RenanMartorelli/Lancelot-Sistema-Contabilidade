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
    Dim frm_menu_principal As frm_menu_principal
    Private Sub btn_adicionar_usuario_Click(sender As Object, e As EventArgs) Handles btn_adicionar_usuario.Click
        frm_menu_principal = Me.ParentForm
        frm_menu_principal.chama_novo_usuario()
    End Sub
    Private Sub btn_editar_dados_Click(sender As Object, e As EventArgs) Handles btn_editar_dados.Click
        'Query update dos valores do input na tabela dados_empressa no BD
    End Sub
End Class
