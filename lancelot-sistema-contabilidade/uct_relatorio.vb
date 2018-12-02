Public Class uct_relatorio
    Dim tipo_relatorio As String
    Private Sub rdb_venda_bruta_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_venda_bruta.CheckedChanged
        tipo_relatorio = "venda_bruta"
    End Sub

    Private Sub rdb_vendas_lucro_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_vendas_lucro.CheckedChanged
        tipo_relatorio = "venda_com_lucros"
    End Sub

    Private Sub uct_relatorio_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
End Class
