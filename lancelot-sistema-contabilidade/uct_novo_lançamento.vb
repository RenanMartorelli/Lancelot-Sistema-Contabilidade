Public Class uct_novo_lançamento
    Private Sub uct_novo_lançamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexao_banco()
        Catch ex As Exception
            MsgBox("Erro ao Inicializar Formulário.")
        End Try




    End Sub
End Class
