Public Class frm_menu_principal
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub

    Private Sub frm_menu_principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call pega_modo_estoque()
    End Sub

    Private Sub btn_dados_empresa_Click(sender As Object, e As EventArgs) Handles btn_dados_empresa.Click
        Dim uct_dados_empresa = New uct_dados_empresa
        pan_menu_principal.Controls.Add(uct_dados_empresa)
        uct_dados_empresa.BringToFront()

    End Sub


    Public Sub chama_novo_usuario()
        Dim uct_criar_usuario = New uct_criar_usuario
        pan_menu_principal.Controls.Add(uct_criar_usuario)
        uct_criar_usuario.BringToFront()
    End Sub

    Public Sub chama_novo_estoque()
        Dim uct_registra_estoque = New uct_registra_estoque
        pan_menu_principal.Controls.Add(uct_registra_estoque)
        uct_registra_estoque.BringToFront()
    End Sub


    Public Sub Finaliza_user_control(uct As UserControl)
        pan_menu_principal.Controls.Remove(uct) 'Remove o userControl imputado
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click




        ' COMPRA de ESTOQUE -> crédito no banco e débito no estoque.

        'registrando valores na tablea ESTOQUE: valor unitário, data, quantidade, total, 

        ' TABELA DE LANÇAMENTOS DO BANCO -> AQUI NÓS VERIFICAMOS O VALOR DE CADA LANÇAMENTO, ASSOCIANDO-O A UM BANCO

        ' TABELA DE LANÇAMENTOS DO ESTOQUE




        'DESCOBRIR O VALOR DE LUCRO PELO PEPS

        'PUXAR OS VALORES DA TABELA ORDER BY DATA A PARTIR MAIS VELHO















        ' QUERO SABER O SALDO QUE TEM NO MEU BANCO (DINHEIRO) - RESOLVEU
        ' QUERO SABER QUANTO (DINHEIRO) OU QUANTO (QUANTIDADE) TEM NO MEU ESTOQUE
        ' QUERO SABER O QUANTO QUE EU TENHO DE LUCRO COM CADA VENDA (UEPS PEPS E MEDIA)































        Dim uct_novo_lançamento = New uct_novo_lançamento
        pan_menu_principal.Controls.Add(uct_novo_lançamento)
        uct_novo_lançamento.BringToFront()
    End Sub

    Private Sub btn_plano_contas_Click(sender As Object, e As EventArgs) Handles btn_plano_contas.Click
        Dim uct_plano_contas As uct_plano_contas
        uct_plano_contas = New uct_plano_contas
        pan_menu_principal.Controls.Add(uct_plano_contas)
        uct_plano_contas.BringToFront()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim uct_relatorio As uct_relatorio
        uct_relatorio = New uct_relatorio
        pan_menu_principal.Controls.Add(uct_relatorio)
        uct_relatorio.BringToFront()
    End Sub

End Class