Imports MySql.Data.MySqlClient
Public Class uct_relatorio
    Dim tipo_relatorio As String
    Dim nome_produto_estoque As String
    Private Sub rdb_lancamentos_banco_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_lancamentos_banco.CheckedChanged
        tipo_relatorio = "lancamentos_banco"
        cmb_produtos.Visible = False
        dgv_lancamentos_banco.Rows.Clear()
        dgv_lancamentos_banco.Visible = True
        dgv_vendas_com_receita.Visible = False
        Call preenche_relatorio_lancamentos_banco()
    End Sub

    Private Sub rdb_vendas_com_receita_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_vendas_com_receita.CheckedChanged
        tipo_relatorio = "vendas_com_receita"
        cmb_produtos.Visible = True
        Call preenche_cmb()
    End Sub

    Private Sub rdb_produtos_em_estoque_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_produtos_em_estoque.CheckedChanged
        tipo_relatorio = "produtos_em_estoque"
        cmb_produtos.Visible = True
        Call preenche_cmb()
    End Sub

    Private Sub preenche_cmb()
        cmb_produtos.Items.Clear()

        Try
            Dim id As New Integer
            Dim nome_produto As String
            my_sql_connection.Open()
            query = "select NOME_PRODUTO from lancelot.cadastro_estoque"
            cmd = New MySqlCommand(query, my_sql_connection)
            leitura = cmd.ExecuteReader
            While leitura.Read
                nome_produto = leitura("NOME_PRODUTO").ToString


                With cmb_produtos
                    .Items.Add(nome_produto)
                End With
            End While
            my_sql_connection.Close()
        Catch ex As Exception
            MsgBox("Erro ao identificar os produtos em estoque")
        Finally
            my_sql_connection.Dispose()
        End Try
        cmb_produtos.Enabled = True
        cmb_produtos.BackColor = (Color.FromArgb(42, 42, 42))
    End Sub

    Private Sub uct_relatorio_Load(sender As Object, e As EventArgs) Handles Me.Load


        cmb_produtos.Enabled = False
        cmb_produtos.BackColor = Color.WhiteSmoke



    End Sub

    Private Sub cmb_produtos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_produtos.SelectedIndexChanged
        nome_produto_estoque = cmb_produtos.Text
        estoque = nome_produto_estoque

        dgv_lancamentos_banco.Visible = False
        dgv_produtos_em_estoque.Visible = False
        dgv_vendas_com_receita.Visible = False
        dgv_vendas_com_receita.Rows.Clear()
        dgv_produtos_em_estoque.Rows.Clear()


        If tipo_relatorio = "vendas_com_receita" Then
            dgv_vendas_com_receita.Visible = True
            Call preenche_relatorio_vendas_com_receita()
        ElseIf tipo_relatorio = "produtos_em_estoque" Then
            dgv_produtos_em_estoque.Visible = True
            Call preenche_relatorio_produtos_em_estoque()
        End If






    End Sub

    Private Sub preenche_relatorio_lancamentos_banco()
        Try
            Dim data_lancamento As String
            Dim valor_lancamento As Double
            Dim tipo_lancamento As String
            my_sql_connection.Open()
            query = "select DATA_CRIACAO,VALOR,TIPO from lancelot.lancamento_banco WHERE VALOR > 0 "
            cmd = New MySqlCommand(query, my_sql_connection)
            leitura = cmd.ExecuteReader
            While leitura.Read
                data_lancamento = leitura("DATA_CRIACAO").ToString
                valor_lancamento = leitura("VALOR")
                tipo_lancamento = leitura("TIPO").ToString



                dgv_lancamentos_banco.Rows.Add(data_lancamento, "Santander", tipo_lancamento, valor_lancamento)

            End While
            my_sql_connection.Close()
        Catch ex As Exception
            MsgBox("Erro ao gerar o relatório")
        Finally
            my_sql_connection.Dispose()
            dgv_lancamentos_banco.Rows.Add("", "SALDO TOTAL", "", chamar_saldo_banco())
        End Try
    End Sub

    Private Sub preenche_relatorio_produtos_em_estoque()
        Try
            Dim data_lancamento As String
            Dim quant As Integer
            Dim valor_uni As Double
            Dim valor_total As Double
            Dim nome_produto
            my_sql_connection.Open()
            query = "select DATA_CRIAÇÃO,NOME_PRODUTO,QTD,VALOR_UNI,VALOR_TOTAL from lancelot.lancamento_estoque WHERE NOME_PRODUTO='" & nome_produto_estoque & "' AND QTD > 0"
            cmd = New MySqlCommand(query, my_sql_connection)
            leitura = cmd.ExecuteReader
            While leitura.Read
                data_lancamento = leitura("DATA_CRIAÇÃO").ToString
                nome_produto = leitura("NOME_PRODUTO").ToString
                quant = leitura("QTD")
                valor_uni = leitura("VALOR_UNI")
                valor_total = leitura("VALOR_TOTAL")



                With dgv_produtos_em_estoque
                    .Rows.Add(data_lancamento, nome_produto, quant, valor_uni, valor_total)
                End With
            End While
            my_sql_connection.Close()
        Catch ex As Exception
            MsgBox("Erro ao gerar o relatório")
        Finally
            my_sql_connection.Dispose()
            dgv_produtos_em_estoque.Rows.Add("", "SALDO TOTAL DO ESTOQUE", "", "", chama_saldo_estoque())
            dgv_produtos_em_estoque.Rows.Add("", "QUANTIDADE ATUAL DO ESTOQUE", chama_qntd_estoque(), "", "")
        End Try
    End Sub

    Private Sub preenche_relatorio_vendas_com_receita()
        Try
            Dim data_lancamento As String
            Dim quant As Integer
            Dim valor_uni As Double
            Dim valor_total As Double
            Dim nome_produto As String
            Dim lucro As Double
            Dim custo_total_prod As Double
            my_sql_connection.Open()
            query = "select * from lancelot.lancamento_credito_estoque WHERE NOME_PRODUTO='" & nome_produto_estoque & "' "
            cmd = New MySqlCommand(query, my_sql_connection)
            leitura = cmd.ExecuteReader
            While leitura.Read
                data_lancamento = leitura("DATA_CRIAÇÃO").ToString
                nome_produto = leitura("NOME_PRODUTO").ToString
                quant = leitura("QTD")
                valor_uni = leitura("VALOR_UNI")
                valor_total = leitura("VALOR_TOTAL")
                lucro = leitura("LUCRO")
                custo_total_prod = leitura("CUSTO_TOTAL_PROD")



                With dgv_vendas_com_receita
                    .Rows.Add(data_lancamento, nome_produto, quant, valor_uni, custo_total_prod, valor_total, lucro)
                End With
            End While
            my_sql_connection.Close()
        Catch ex As Exception
            MsgBox("Erro ao gerar o relatório")
        Finally
            my_sql_connection.Dispose()
        End Try
    End Sub

End Class


