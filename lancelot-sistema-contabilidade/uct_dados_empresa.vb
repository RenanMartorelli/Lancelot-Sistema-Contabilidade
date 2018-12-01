Public Class uct_dados_empresa
    Dim frm_menu_principal As frm_menu_principal
    Private Sub btn_adicionar_usuario_Click(sender As Object, e As EventArgs) Handles btn_adicionar_usuario.Click
        frm_menu_principal = Me.ParentForm
        frm_menu_principal.chama_novo_usuario()
    End Sub

    Private Sub uct_dados_empresa_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Query pegando as informações da empresa e colocando no Text dos inputs.
    End Sub

    Private Sub btn_editar_dados_Click(sender As Object, e As EventArgs) Handles btn_editar_dados.Click
        'Query update dos valores do input na tabela dados_empressa no BD
    End Sub
End Class
