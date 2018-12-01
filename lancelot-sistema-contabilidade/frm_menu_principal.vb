Public Class frm_menu_principal
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub

    Private Sub frm_menu_principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'salve fatec. teste gitanderson 
    End Sub

    Private Sub btn_dados_empresa_Click(sender As Object, e As EventArgs) Handles btn_dados_empresa.Click
        Dim uct_criar_usuario = New uct_criar_usuario
        pan_menu_principal.Controls.Add(uct_criar_usuario)
        uct_criar_usuario.BringToFront()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim uct_novo_lançamento = New uct_novo_lançamento
        pan_menu_principal.Controls.Add(uct_novo_lançamento)
        uct_novo_lançamento.BringToFront()
    End Sub

End Class