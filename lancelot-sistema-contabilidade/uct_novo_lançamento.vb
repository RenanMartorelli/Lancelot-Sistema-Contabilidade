Imports MySql.Data.MySqlClient


Public Class uct_novo_lançamento
    Private Sub uct_novo_lançamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexao_banco()

            With cmb_conta_credito
                .Items.Clear()
                .Items.Add("Banco")
                .Items.Add("Estoque")
            End With

            With cmb_conta_debito
                .Items.Clear()
                .Items.Add("Banco")
                .Items.Add("Estoque")
            End With



        Catch ex As Exception
            MsgBox("Erro ao Inicializar Formulário.")
        End Try
    End Sub



    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        Try

            'Se estoque selecionado, então insira as informações na tabela Estoque como DÉBITO
            If cmb_conta_debito.SelectedItem = "Estoque" Then

                my_sql_connection.Open()
                query = "insert into lancelot.lancamento_estoque(DATA_CRIAÇÃO,NOME_PRODUTO, QTD, VALOR_UNI, VALOR_TOTAL, TIPO) VALUES ('" & CDate(txt_data.Text) & "' ,'" & cmb_comp_debito.SelectedItem.ToString & "' , " & CInt(txt_qtde.Text) & " , " & CDbl(txt_valor_unitario.Text) & ", " & CDbl(txt_valor_total.Text) & " , '" & lbl_debito.Text & "')"
                cmd = New MySqlCommand(query, my_sql_connection)
                leitura = cmd.ExecuteReader

                my_sql_connection.Close()

                MsgBox("Dados Cadastrados.")

                'Se Banco selecionado, então insira na tabela Banco como DÉBITO
            ElseIf cmb_conta_debito.SelectedItem = "Banco" Then
                my_sql_connection.Open()
                query = "insert into lancelot.lancamento_banco(NOME_BANCO, VALOR, TIPO, DATA_CRIACAO) VALUES ('" & cmb_comp_debito.SelectedItem.ToString & "' , '" & CDbl(txt_valor_total.Text) & "' , '" & lbl_debito.Text & "', '" & CDate(txt_data.Text) & "')"
                cmd = New MySqlCommand(query, my_sql_connection)
                leitura = cmd.ExecuteReader

                my_sql_connection.Close()

                MsgBox("Dados Cadastrados.")

            End If

            'Se Banco selecionado, insira na tabela Banco como CRÉDITO
            If cmb_conta_credito.SelectedItem = "Banco" Then
                my_sql_connection.Open()
                query = "insert into lancelot.lancamento_banco( NOME_BANCO, VALOR, TIPO, DATA_CRIACAO) VALUES ('" & cmb_comp_credito.SelectedItem.ToString & "' , '" & CDbl(txt_valor_total.Text) & "' , '" & lbl_credito.Text & "', '" & CDate(txt_data.Text) & "')"
                cmd = New MySqlCommand(query, my_sql_connection)
                leitura = cmd.ExecuteReader

                my_sql_connection.Close()

                MsgBox("Dados Cadastrados.")

                'Se Estoque selecionado, insira na tabela Estoque como CRÉDITO
            ElseIf cmb_conta_credito.SelectedItem = "Estoque" Then


                'Call credito_estoque()

                my_sql_connection.Open()
                query = "select * from lancelot.lancamento_estoque WHERE NOME_PRODUTO= '" & cmb_comp_credito.SelectedItem.ToString & "' ORDER BY DATA_CRIAÇÃO ASC"
                cmd = New MySqlCommand(query, my_sql_connection)
                leitura = cmd.ExecuteReader

                Dim quant_produto_vendido = CInt(txt_qtde.Text)
                Dim zerou_vendas As Boolean
                zerou_vendas = False

                While leitura.Read
                    If zerou_vendas = True Then
                        Exit While
                    End If

                    Dim quant_restante_estoque = leitura("QTD")
                    Dim id_lancamento = leitura("IDESTOQUE")
                    Dim valor_uni = leitura("VALOR_UNI")
                    Dim valor_custo_total As Double

                    While quant_restante_estoque <> 0
                        If quant_produto_vendido = 0 Then
                            zerou_vendas = True
                            Exit While
                        End If

                        valor_custo_total += valor_uni
                        quant_produto_vendido -= 1
                        quant_restante_estoque -= 1

                    End While

                    'Call retira_e_atualiza_estoque(id_lancamento, quant_restante_estoque, valor_uni)
                    'my_sql_connection.Open()
                    leitura.Close()
                    query = "update lancelot.lancamento_estoque set QTD=" & quant_restante_estoque & ",VALOR_TOTAL=" & (valor_uni * quant_restante_estoque) & " WHERE IDESTOQUE=" & id_lancamento & ""
                    cmd = New MySqlCommand(query, my_sql_connection)
                    leitura = cmd.ExecuteReader
                    'my_sql_connection.Close()
                    'FIM DA CALL E ATUALIZA

                    'my_sql_connection.Open()
                    leitura.Close()
                    query = "insert into lancelot.lancamento_credito_estoque(DATA_CRIAÇÃO, NOME_PRODUTO, QTD, VALOR_UNI, CUSTO_TOTAL_PROD, VALOR_TOTAL, LUCRO) VALUES ('" & CDate(txt_data.Text) & "','" & cmb_comp_credito.SelectedItem.ToString & "' , " & CInt(txt_qtde.Text) & " , " & CDbl(txt_valor_unitario.Text) & ", " & valor_custo_total & " ," & CDbl(txt_valor_total.Text) & ", " & CDbl(txt_valor_total.Text) - valor_custo_total & ")"
                    cmd = New MySqlCommand(query, my_sql_connection)
                    leitura = cmd.ExecuteReader
                    'leitura.Close()
                    'my_sql_connection.Close()

                End While
                my_sql_connection.Close()



                'select tbestoque where produto ='" &cmb_comp_credito.selecteditem & "'"
                'query = "insert into lancelot.lancamento_estoque(DATA_CRIAÇÃO, NOME_PRODUTO, QTD, VALOR_UNI, VALOR_TOTAL, TIPO) VALUES ('" & CDate(txt_data.Text) & "','" & cmb_comp_credito.SelectedItem.ToString & "' , '" & CInt(txt_qtde.Text) & "' , '" & CDbl(txt_valor_unitario.Text) & "', '" & CDbl(txt_valor_total.Text) & "' , '" & lbl_credito.Text & "')"
                'cmd = New MySqlCommand(query, my_sql_connection)
                'insert o comando na linha de comando do mysql
                'leitura = cmd.ExecuteReader
                'executa o comando lendo o banco
                'my_sql_connection.Close()

                MsgBox("Dados Cadastrados.")

            End If

            txt_data.Text = ""
            txt_valor_total.Text = ""
            txt_valor_unitario.Text = ""
            txt_qtde.Text = ""
            cmb_conta_debito.Text = ""
            cmb_comp_debito.Text = ""
            cmb_conta_credito.Text = ""
            cmb_comp_credito.Text = ""

        Catch ex As Exception
            MsgBox("Erro ao Cadastrar Lançamento.")
        End Try
    End Sub

    Private Sub credito_estoque()
        Try
            'MsgBox("chamou funçao.")

            my_sql_connection.Open()
            query = "select * from lancelot.lancamento_estoque WHERE NOME_PRODUTO= '" & cmb_comp_credito.SelectedItem.ToString & "' ORDER BY DATA_CRIAÇÃO ASC"
            cmd = New MySqlCommand(query, my_sql_connection)
            leitura = cmd.ExecuteReader

            Dim quant_produto_vendido = CInt(txt_qtde.Text)
            Dim zerou_vendas As Boolean
            zerou_vendas = False

            While leitura.Read
                If zerou_vendas = True Then
                    Exit While
                End If

                Dim quant_restante_estoque = leitura("QTD")
                Dim id_lancamento = leitura("IDESTOQUE")
                Dim valor_uni = leitura("VALOR_UNI")
                Dim valor_custo_total As Double

                While quant_restante_estoque <> 0
                    If quant_produto_vendido = 0 Then
                        zerou_vendas = True
                        Exit While
                    End If

                    valor_custo_total += valor_uni
                    quant_produto_vendido -= 1
                    quant_restante_estoque -= 1

                End While

                Call retira_e_atualiza_estoque(id_lancamento, quant_restante_estoque, valor_uni)


                query = "insert into lancelot.lancamento_credito_estoque(DATA_CRIAÇÃO, NOME_PRODUTO, QTD, VALOR_UNI, CUSTO_TOTAL_PROD, VALOR_TOTAL, LUCRO) VALUES ('" & CDate(txt_data.Text) & "','" & cmb_comp_credito.SelectedItem.ToString & "' , " & CInt(txt_qtde.Text) & " , " & CDbl(txt_valor_unitario.Text) & ", " & valor_custo_total & " ," & CDbl(txt_valor_total.Text) & ", " & CDbl(txt_valor_total.Text) - valor_custo_total & ")"
                cmd = New MySqlCommand(query, my_sql_connection)
                leitura = cmd.ExecuteReader
                'executa o comando lendo o banco
                my_sql_connection.Close()

            End While
            my_sql_connection.Close()
        Catch ex As Exception
            MsgBox("Erro ao processar.")
        End Try
    End Sub





    Private Sub cmb_conta_debito_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_conta_debito.SelectedValueChanged
        Try

            If cmb_conta_debito.SelectedItem.ToString = ("Banco") Then
                cmb_comp_debito.Items.Clear()
                cmb_comp_debito.Items.Add("Santander")

            ElseIf cmb_conta_debito.SelectedItem.ToString = ("Estoque") Then
                my_sql_connection.Open()
                query = "select * from lancelot.cadastro_estoque"
                cmd = New MySqlCommand(query, my_sql_connection)
                leitura = cmd.ExecuteReader
                While leitura.Read
                    Dim produto_nome = leitura.GetString("NOME_PRODUTO")
                    cmb_comp_debito.Items.Add(produto_nome)
                End While

                ' insert na nova tabela os valores que escrevemos dinâmicamente
                my_sql_connection.Close()
            End If
        Catch ex As Exception
            MsgBox("Erro na Conta Débito")
        Finally
            my_sql_connection.Dispose()
        End Try
    End Sub

    Private Sub retira_e_atualiza_estoque(id_lancamento As Integer, quant_restante_estoque As Integer, valor_uni As Integer)
        my_sql_connection.Open()
        query = "update lancelot.lancamento_estoque set QTD=" & quant_restante_estoque & ",VALOR_TOTAL=" & (valor_uni * quant_restante_estoque) & " WHERE IDESTOQUE=" & id_lancamento & ""
        cmd = New MySqlCommand(query, my_sql_connection)
        my_sql_connection.Close()
    End Sub

    Private Sub cmb_conta_credito_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_conta_credito.SelectedIndexChanged
        Try
            If cmb_conta_credito.SelectedItem.ToString = ("Banco") Then
                cmb_comp_credito.Items.Clear()
                cmb_comp_credito.Items.Add("Santander")

            ElseIf cmb_conta_credito.SelectedItem.ToString = ("Estoque") Then
                my_sql_connection.Open()
                query = "select * from lancelot.cadastro_estoque"
                cmd = New MySqlCommand(query, my_sql_connection)
                leitura = cmd.ExecuteReader
                While leitura.Read
                    Dim produto_nome = leitura.GetString("NOME_PRODUTO")
                    cmb_comp_credito.Items.Add(produto_nome)
                End While
                my_sql_connection.Close()
            End If

        Catch ex As Exception
            MsgBox("Erro na Conta Crédito")
        Finally
            my_sql_connection.Dispose()
        End Try
    End Sub

    Private Sub txt_qtde_LostFocus(sender As Object, e As EventArgs) Handles txt_qtde.LostFocus
        total = CDbl(txt_qtde.Text) * CDbl(txt_valor_unitario.Text)
        txt_valor_total.Text = total

    End Sub
End Class
