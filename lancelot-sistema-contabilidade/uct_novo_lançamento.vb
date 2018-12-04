Imports MySql.Data.MySqlClient



Public Class uct_novo_lançamento

    Dim gambiarra
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

        If String.IsNullOrEmpty(txt_qtde.Text) Or String.IsNullOrEmpty(txt_valor_unitario.Text) Then
            MsgBox("Há algum campo vazio")
            Exit Sub
        End If

        If cmb_conta_debito.SelectedItem = cmb_conta_credito.SelectedItem Then
            MsgBox("Os tipos de conta de crédito e débito devem ser diferentes!")
            Exit Sub
        End If

        If cmb_conta_credito.SelectedItem = "Banco" Then 'Validação -> não pode tirar mais dinheiro do que o saldo do banco
            If CInt(txt_valor_total.Text) > chamar_saldo_banco() Then
                MsgBox("Não é possível realizar um crédito de um valor maior Do que saldo Do banco.")
                Exit Sub
            End If
        End If
        If cmb_conta_credito.SelectedItem = "Estoque" Then 'Validação -> não pode tirar mais produtos do que tem no estoque
            estoque = cmb_comp_credito.Text.ToString()
            MsgBox(estoque)
            If CInt(txt_qtde.Text) > chama_qntd_estoque() Then
                MsgBox("Não é possível realizar um crédito de estoque com uma quantidade maior Do que a disponível.")
                Exit Sub
            End If
        End If

        Try

            'Se estoque selecionado, então insira as informações na tabela Estoque como DÉBITO
            If cmb_conta_debito.SelectedItem = "Estoque" Then

                my_sql_connection.Open()
                query = "insert into lancelot.lancamento_estoque(DATA_CRIAÇÃO, NOME_PRODUTO, QTD, VALOR_UNI, VALOR_TOTAL, TIPO) VALUES ('" & CDate(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")) & "' ,'" & cmb_comp_debito.SelectedItem.ToString & "' , " & CInt(txt_qtde.Text) & " , " & CDbl(txt_valor_unitario.Text) & ", " & CDbl(txt_valor_total.Text) & " , '" & lbl_debito.Text & "')"
                cmd = New MySqlCommand(query, my_sql_connection)
                leitura = cmd.ExecuteReader

                my_sql_connection.Close()

                MsgBox("Débito no estoque cadastrado.")

                'Se Banco selecionado, então insira na tabela Banco como DÉBITO
            ElseIf cmb_conta_debito.SelectedItem = "Banco" Then
                Try
                    my_sql_connection.Open()
                    query = "insert into lancelot.lancamento_banco(NOME_BANCO, VALOR, TIPO, DATA_CRIACAO) VALUES ('" & cmb_comp_debito.SelectedItem.ToString & "' , '" & CDbl(txt_valor_total.Text) & "' , '" & lbl_debito.Text & "', '" & CDate(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")) & "')"
                    cmd = New MySqlCommand(query, my_sql_connection)
                    leitura = cmd.ExecuteReader

                    my_sql_connection.Close()

                    MsgBox("Débito no banco cadastrado")
                Catch
                    MsgBox("Erro ao registrar lançamento de débito no banco")
                Finally
                    'my_sql_connection.Dispose()
                End Try
            End If

            'Se Banco selecionado, insira na tabela Banco como CRÉDITO
            If cmb_conta_credito.SelectedItem = "Banco" Then
                my_sql_connection.Open()
                query = "insert into lancelot.lancamento_banco( NOME_BANCO, VALOR, TIPO, DATA_CRIACAO) VALUES ('" & cmb_comp_credito.SelectedItem.ToString & "' , '" & CDbl(txt_valor_total.Text) & "' , '" & lbl_credito.Text & "', '" & CDate(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")) & "')"
                cmd = New MySqlCommand(query, my_sql_connection)
                leitura = cmd.ExecuteReader

                my_sql_connection.Close()

                MsgBox("Crédito no banco cadastrado")

                'Se Estoque selecionado, insira na tabela Estoque como CRÉDITO
            ElseIf cmb_conta_credito.SelectedItem = "Estoque" Then


                'Call credito_estoque()
                Dim valor_custo_total As Double
                my_sql_connection.Open()
                my_sql_connection2.Open()
                If modo_estoque = "PEPS" Then
                    query = "select * from lancelot.lancamento_estoque WHERE NOME_PRODUTO= '" & cmb_comp_credito.SelectedItem.ToString & "' AND QTD > 0 ORDER BY DATA_CRIAÇÃO ASC"
                ElseIf modo_estoque = "UEPS" Then
                    query = "select * from lancelot.lancamento_estoque WHERE NOME_PRODUTO= '" & cmb_comp_credito.SelectedItem.ToString & "' AND QTD > 0 ORDER BY DATA_CRIAÇÃO DESC"
                End If
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

                        query = "update lancelot.lancamento_estoque set QTD=" & quant_restante_estoque & ",VALOR_TOTAL=" & (valor_uni * quant_restante_estoque) & " WHERE IDESTOQUE=" & id_lancamento & ""
                        cmd2 = New MySqlCommand(query, my_sql_connection2)
                        leitura2 = cmd2.ExecuteReader
                        leitura2.Close()
                        'my_sql_connection.Close()
                        'FIM DA CALL E ATUALIZA

                        'my_sql_connection.Open()

                        'leitura.Close()
                        'my_sql_connection.Close()

                    End While

                    leitura.Close()
                query = "insert into lancelot.lancamento_credito_estoque(DATA_CRIAÇÃO,MODO_ESTOQUE, NOME_PRODUTO, QTD, VALOR_UNI, CUSTO_TOTAL_PROD, VALOR_TOTAL, LUCRO) VALUES ('" & CDate(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")) & "','" & UCase(modo_estoque) & "','" & cmb_comp_credito.SelectedItem.ToString & "' , " & CInt(txt_qtde.Text) & " , " & CDbl(txt_valor_unitario.Text) & ", " & valor_custo_total & " ," & CDbl(txt_valor_total.Text) & ", " & CDbl(txt_valor_total.Text) - valor_custo_total & ")"
                cmd = New MySqlCommand(query, my_sql_connection)
                    leitura = cmd.ExecuteReader
                    my_sql_connection.Close()



                    'select tbestoque where produto ='" &cmb_comp_credito.selecteditem & "'"
                    'query = "insert into lancelot.lancamento_estoque(DATA_CRIAÇÃO, NOME_PRODUTO, QTD, VALOR_UNI, VALOR_TOTAL, TIPO) VALUES ('" & CDate(txt_data.Text) & "','" & cmb_comp_credito.SelectedItem.ToString & "' , '" & CInt(txt_qtde.Text) & "' , '" & CDbl(txt_valor_unitario.Text) & "', '" & CDbl(txt_valor_total.Text) & "' , '" & lbl_credito.Text & "')"
                    'cmd = New MySqlCommand(query, my_sql_connection)
                    'insert o comando na linha de comando do mysql
                    'leitura = cmd.ExecuteReader
                    'executa o comando lendo o banco
                    'my_sql_connection.Close()

                    MsgBox("Crédito de estoque cadastrado")

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

    Private Sub txt_qtde_TextChanged(sender As Object, e As EventArgs) Handles txt_qtde.TextChanged
        If Not String.IsNullOrEmpty(txt_valor_unitario.Text) And Not String.IsNullOrEmpty(txt_qtde.Text) Then
            txt_valor_total.Text = (CInt(txt_qtde.Text) * CDbl(txt_valor_unitario.Text))
        End If
    End Sub
    Private Sub txt_valor_unitario_TextChanged(sender As Object, e As EventArgs) Handles txt_valor_unitario.TextChanged
        If Not String.IsNullOrEmpty(txt_qtde.Text) And Not String.IsNullOrEmpty(txt_valor_unitario.Text) Then
            txt_valor_total.Text = (CInt(txt_qtde.Text) * CDbl(txt_valor_unitario.Text))
        End If
    End Sub
End Class
