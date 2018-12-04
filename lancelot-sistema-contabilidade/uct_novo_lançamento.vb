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
        If cmb_conta_credito.SelectedItem = "Banco" Then 'Validação -> não pode tirar mais dinheiro do que o saldo do banco
            If CInt(txt_valor_total.Text) > chamar_saldo_banco() Then
                MsgBox("Não é possível realizar um crédito de um valor maior do que saldo do banco.")
            End If
        End If

        If cmb_conta_credito.SelectedItem = "Estoque" Then 'Validação -> não pode tirar mais produtos do que tem no estoque
            estoque = cmb_comp_credito.Text.ToString()
            MsgBox(estoque)
            If CInt(txt_qtde.Text) > chama_qntd_estoque() Then
                MsgBox("Não é possível realizar um crédito de estoque com uma quantidade maior do que a disponível.")
            End If
        End If

        Try
            If cmb_conta_debito.SelectedItem = cmb_conta_credito.SelectedItem Then
                MsgBox("Os tipos de conta de crédito e débito devem ser diferentes!")
                Exit Sub
            End If
            If cmb_conta_debito.SelectedItem = "Estoque" Then

                my_sql_connection.Open()
                query = "insert into lancelot.lancamento_estoque(DATA_CRIAÇÃO,NOME_PRODUTO, QTD, VALOR_UNI, VALOR_TOTAL, TIPO) VALUES ('" & CDate(txt_data.Text) & "' ,'" & cmb_comp_debito.SelectedItem.ToString & "' , " & CInt(txt_qtde.Text) & " , " & CDbl(txt_valor_unitario.Text) & ", " & CDbl(txt_valor_total.Text) & " , '" & lbl_debito.Text & "')"

                cmd = New MySqlCommand(query, my_sql_connection)
                'insert o comando na linha de comando do mysql
                leitura = cmd.ExecuteReader
                'executa o comando lendo o banco


                my_sql_connection.Close()

                MsgBox("Dados Cadastrados.")

            ElseIf cmb_conta_debito.SelectedItem = "Banco" Then
                my_sql_connection.Open()
                query = "insert into lancelot.lancamento_banco(NOME_BANCO, VALOR, TIPO, DATA_CRIACAO) VALUES ('" & cmb_comp_debito.SelectedItem.ToString & "' , '" & CDbl(txt_valor_total.Text) & "' , '" & lbl_debito.Text & "', '" & CDate(txt_data.Text) & "')"
                cmd = New MySqlCommand(query, my_sql_connection)
                'insert o comando na linha de comando do mysql
                leitura = cmd.ExecuteReader
                'executa o comando lendo o banco

                my_sql_connection.Close()

                MsgBox("Dados Cadastrados.")

            End If


            If cmb_conta_credito.SelectedItem = "Banco" Then
                my_sql_connection.Open()
                query = "insert into lancelot.lancamento_banco( NOME_BANCO, VALOR, TIPO, DATA_CRIACAO) VALUES ('" & cmb_comp_credito.SelectedItem.ToString & "' , '" & CDbl(txt_valor_total.Text) & "' , '" & lbl_credito.Text & "', '" & CDate(txt_data.Text) & "')"
                cmd = New MySqlCommand(query, my_sql_connection)
                'insert o comando na linha de comando do mysql
                leitura = cmd.ExecuteReader
                'executa o comando lendo o banco

                my_sql_connection.Close()

                MsgBox("Dados Cadastrados.")

            ElseIf cmb_conta_credito.SelectedItem = "Estoque" Then
                my_sql_connection.Open()

                'select tbestoque where produto ='" &cmb_comp_credito.selecteditem & "'"




                query = "insert into lancelot.lancamento_estoque(DATA_CRIAÇÃO, NOME_PRODUTO, QTD, VALOR_UNI, VALOR_TOTAL, TIPO) VALUES ('" & CDate(txt_data.Text) & "','" & cmb_comp_credito.SelectedItem.ToString & "' , '" & CInt(txt_qtde.Text) & "' , '" & CDbl(txt_valor_unitario.Text) & "', '" & CDbl(txt_valor_total.Text) & "' , '" & lbl_credito.Text & "')"
                cmd = New MySqlCommand(query, my_sql_connection)
                'insert o comando na linha de comando do mysql
                leitura = cmd.ExecuteReader
                'executa o comando lendo o banco
                my_sql_connection.Close()

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

    Private Sub cmb_conta_debito_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_conta_debito.SelectedValueChanged
        Try

            If cmb_conta_debito.SelectedItem.ToString = ("Banco") Then
                cmb_comp_debito.Items.Clear()
                cmb_comp_debito.Items.Add("Santander")

            ElseIf cmb_conta_debito.SelectedItem.ToString = ("Estoque") Then
                cmb_comp_debito.Items.Clear()
                my_sql_connection.Open()
                query = "select * from lancelot.cadastro_estoque"
                cmd = New MySqlCommand(query, my_sql_connection)
                leitura = cmd.ExecuteReader
                While leitura.Read
                    Dim produto_nome = leitura.GetString("NOME_PRODUTO")
                    cmb_comp_debito.Items.Add(produto_nome)
                End While
                my_sql_connection.Close()
            End If
        Catch ex As Exception
            MsgBox("Erro na Conta Débito")
        Finally
            my_sql_connection.Dispose()
        End Try
    End Sub

    Private Sub cmb_conta_credito_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_conta_credito.SelectedIndexChanged
        'Try
        If cmb_conta_credito.SelectedItem.ToString = ("Banco") Then

            cmb_comp_credito.Items.Clear()
            cmb_comp_credito.Items.Add("Santander")

        ElseIf cmb_conta_credito.SelectedItem.ToString = ("Estoque") Then
            cmb_comp_credito.Items.Clear()
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

        ' Catch ex As Exception
        '   MsgBox("Erro na Conta Crédito")
        '  Finally
        '    my_sql_connection.Dispose()
        ' End Try
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
