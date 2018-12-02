Imports MySql.Data.MySqlClient
Public Class uct_relatorio
    Dim tipo_relatorio As String
    Private Sub rdb_venda_bruta_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_venda_bruta.CheckedChanged
        tipo_relatorio = "venda_bruta"
        Call preenche_cmb()
    End Sub

    Private Sub rdb_vendas_lucro_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_vendas_lucro.CheckedChanged
        tipo_relatorio = "venda_com_lucros"
        Call preenche_cmb()
    End Sub

    Private Sub preenche_cmb()
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
            MsgBox("VOCÊ NAO SABE FAZER NADA QUE N TENHA ERRO?")
        End Try
        cmb_produtos.Enabled = True
        cmb_produtos.BackColor = (Color.FromArgb(42, 42, 42))
    End Sub

    Private Sub uct_relatorio_Load(sender As Object, e As EventArgs) Handles Me.Load


        cmb_produtos.Enabled = False
        cmb_produtos.BackColor = Color.WhiteSmoke



    End Sub

    Private Sub cmb_produtos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_produtos.SelectedIndexChanged
        Dim nome_produto = cmb_produtos.Text
        Try
            Dim data_lancamento As String
            Dim quant As Integer
            Dim valor_uni As Integer
            Dim valor_total As Integer
            my_sql_connection.Open()
            query = "select DATA_CRIAÇÃO,NOME_PRODUTO,QTD,VALOR_UNI,VALOR_TOTAL from lancelot.lancamento_estoque"
            cmd = New MySqlCommand(query, my_sql_connection)
            leitura = cmd.ExecuteReader
            While leitura.Read
                data_lancamento = leitura("DATA_CRIAÇÃO").ToString
                nome_produto = leitura("NOME_PRODUTO").ToString
                quant = leitura("QTD")
                valor_uni = leitura("VALOR_UNI")
                valor_total = leitura("VALOR_TOTAL")



                With dgv_relatório
                    .Rows.Add(data_lancamento, nome_produto, quant, valor_uni, valor_total)
                End With
            End While
            my_sql_connection.Close()
        Catch ex As Exception
            MsgBox("VOCÊ NAO SABE FAZER NADA QUE N TENHA ERRO?")
        End Try
        cmb_produtos.Enabled = True
        cmb_produtos.BackColor = (Color.FromArgb(42, 42, 42))
    End Sub


    Private Sub alheia()
        Try
            Dim data_lancamento As String
            Dim quant As Integer
            Dim valor_uni As Integer
            Dim valor_total As Integer
            my_sql_connection.Open()
            'query = "select * from lancelot.lancamento_estoque WHERE NOME_PRODUTO= '" & cmb_comp_cred.selectedItem.toString() & "' ORDER BY DATA_CRIAÇÃO ASC"
            Dim quant_produto_vendido = 60


            cmd = New MySqlCommand(query, my_sql_connection)
            leitura = cmd.ExecuteReader
            While leitura.Read
                'AQUI ENTRA OUTRO WHILE QUE VAI ATÉ A QUANTIDADE DE ITENS VENDIDOS CHEGAR EM 0
                Dim quant_restante_estoque = leitura("QTD")
                Dim id_lancamento = leitura("IDESTOQUE")
                'quant_produto_vendido -= quant_restante_estoque
                While quant_restante_estoque <> 0
                    'quantidade_vendida -= 1



                End While

                Call retira_e_atualiza_estoque(id_lancamento)


                With dgv_relatório
                    .Rows.Add(data_lancamento, nome_produto, quant, valor_uni, valor_total)
                End With
            End While
            my_sql_connection.Close()
        Catch ex As Exception
            MsgBox("VOCÊ NAO SABE FAZER NADA QUE N TENHA ERRO?")
        End Try
    End Sub

    Private Sub retira_e_atualiza_estoque(id_lancamento As Integer)
        my_sql_connection.Open()
        '  query = "update lancelot.lancamento_estoque set QTD='" & txt_nome_empresa.Text & "', EMAIL='" & txt_email.Text & "', ENDERECO='" & txt_endereço.Text & "', ATIVIDADE='" & txt_segmento.Text & "' "
        cmd = New MySqlCommand(query, my_sql_connection)

    End Sub
End Class


