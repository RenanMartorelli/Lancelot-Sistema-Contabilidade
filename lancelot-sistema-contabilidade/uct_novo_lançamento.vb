Imports MySql.Data.MySqlClient


Public Class uct_novo_lançamento
    Private Sub uct_novo_lançamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexao_banco()

            lbl_id_lancamento.Text = 1

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

            If cmb_conta_debito.SelectedItem = "Estoque" Then

                my_sql_connection.Open()                                                        'NOME_PRODUTO,          ,'" & cmb_comp_debito.SelectedItem & "' 
                query = "insert into lancelot.lancamento_estoque(DATA_CRIACAO,  QTD, VALOR_UNI, VALOR_TOTAL, TIPO) VALUES ('" & Now & "', '" & txt_qtde.Text & "' , '" & txt_valor_unitario.Text & "', '" & CDbl(txt_valor_total.Text) & "' , '" & lbl_debito.Text & "')"
                ' "
                cmd = New MySqlCommand(query, my_sql_connection)
                'insert o comando na linha de comando do mysql
                leitura = cmd.ExecuteReader
                'executa o comando lendo o banco


                my_sql_connection.Close()

                MsgBox("Dados Cadastrados.")

            ElseIf cmb_conta_debito.SelectedItem = "Banco" Then
                my_sql_connection.Open()
                query = "insert into lancelot.lancamento_banco(IDBANCO, NOME_BANCO, VALOR, TIPO, DATA_CRIACAO) VALUES ('" & lbl_id_lancamento.Text & "','" & cmb_comp_debito.SelectedItem & "' , '" & txt_valor_total.SelectedText & "' , '" & lbl_debito.Text & "', '" & txt_data.Text & "')"
                cmd = New MySqlCommand(query, my_sql_connection)
                'insert o comando na linha de comando do mysql
                leitura = cmd.ExecuteReader
                'executa o comando lendo o banco

                my_sql_connection.Close()

                MsgBox("Dados Cadastrados.")

            End If


            If cmb_conta_credito.SelectedItem = "Banco" Then
                my_sql_connection.Open()
                query = "insert into lancelot.lancamento_banco(IDBANCO, NOME_BANCO, VALOR, TIPO, DATA_CRIACAO) VALUES ('" & lbl_id_lancamento.Text & "','" & cmb_comp_credito.SelectedItem & "' , '" & txt_valor_total.SelectedText & "' , '" & lbl_credito.Text & "', '" & txt_data.Text & "')"
                cmd = New MySqlCommand(query, my_sql_connection)
                'insert o comando na linha de comando do mysql
                leitura = cmd.ExecuteReader
                'executa o comando lendo o banco

                my_sql_connection.Close()

                MsgBox("Dados Cadastrados.")

            ElseIf cmb_conta_credito.SelectedItem = "Estoque" Then
                my_sql_connection.Open()
                query = "insert into lancelot.lancamento_estoque(IDESTOQUE, DATA_CRIACAO, NOME_PRODUTO, QTD, VALOR_UNI, VALOR_TOTAL, TIPO) VALUES ('" & lbl_id_lancamento.Text & "','" & txt_data.Text & "','" & cmb_comp_credito.SelectedItem & "' , '" & txt_qtde.SelectedText & "' , '" & txt_valor_unitario.Text & "', '" & txt_valor_total.Text & "' , '" & lbl_credito.Text & "')"
                cmd = New MySqlCommand(query, my_sql_connection)
                'insert o comando na linha de comando do mysql
                leitura = cmd.ExecuteReader
                'executa o comando lendo o banco

            End If

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
                cmb_comp_debito.Items.Add("Produto A")
                cmb_comp_debito.Items.Add("Produto B")
            End If



        Catch ex As Exception
            MsgBox("Erro na Conta Débito.")
        End Try
    End Sub

    Private Sub cmb_conta_credito_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_conta_credito.SelectedIndexChanged

        If cmb_conta_credito.SelectedItem.ToString = ("Banco") Then
            cmb_comp_credito.Items.Clear()
            cmb_comp_credito.Items.Add("Santander")

        ElseIf cmb_conta_credito.SelectedItem.ToString = ("Estoque") Then
            cmb_comp_credito.Items.Clear()
            cmb_comp_credito.Items.Add("Produto A")
            cmb_comp_credito.Items.Add("Produto B")
        End If

    End Sub
End Class
