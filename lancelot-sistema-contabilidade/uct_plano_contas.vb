Public Class uct_plano_contas
    Dim frm_menu_principal As frm_menu_principal
    Private Sub uct_plano_contas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv_plano_contas.Rows.Add("1", "Ativo")
        dgv_plano_contas.Rows.Add("1.1", "Ativo circulante")
        dgv_plano_contas.Rows.Add("1.1.1", "Bancos com movimento")
        dgv_plano_contas.Rows.Add("1.1.1.1", "Banco Santander")
        dgv_plano_contas.Rows.Add("1", "Ativo")
        dgv_plano_contas.Rows.Add("1.1", "Ativo circulante")
        dgv_plano_contas.Rows.Add("1.1.2", "Estoque")

        'query pegando os tipos de estoque que tem e adicionando eles também
    End Sub

    Private Sub txt_valor_total_TextChanged(sender As Object, e As EventArgs) Handles txt_valor_total.TextChanged

    End Sub

    Private Sub btn_verificar_saldo_Click(sender As Object, e As EventArgs) Handles btn_verificar_saldo.Click

    End Sub

    Private Sub btn__Click(sender As Object, e As EventArgs) Handles btn_.Click
        frm_menu_principal = Me.ParentForm
        frm_menu_principal.chama_novo_estoque()
        frm_menu_principal.Finaliza_user_control(Me)
    End Sub
End Class
