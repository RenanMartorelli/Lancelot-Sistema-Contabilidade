Imports MySql.Data.MySqlClient
Public Class uct_plano_contas
    Dim frm_menu_principal As frm_menu_principal
    Private Sub uct_plano_contas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If tipologin = "operador" Then
            btn_adicionar_novo_estoque.Enabled = False
        End If


        dgv_plano_contas.Rows.Add("1", "Ativo")
        dgv_plano_contas.Rows.Add("1.1", "Ativo circulante")
        dgv_plano_contas.Rows.Add("1.1.1", "Bancos com movimento")
        dgv_plano_contas.Rows.Add("1.1.1.1", "Banco Santander")
        dgv_plano_contas.Rows.Add("1.1.2", "Estoque")

        txt_qtde.Visible = False
        Label5.Visible = False

        Try
            Dim id As New Integer
            Dim nome_produto As String
            my_sql_connection.Open()
            query = "select IDCADASTROESTOQUE,NOME_PRODUTO from lancelot.cadastro_estoque"
            cmd = New MySqlCommand(query, my_sql_connection)
            leitura = cmd.ExecuteReader
            While leitura.Read
                id = leitura("IDCADASTROESTOQUE")
                nome_produto = leitura("NOME_PRODUTO").ToString
                With dgv_plano_contas
                    .Rows.Add("1.1.2." & id & "", nome_produto, id)
                End With
            End While
            my_sql_connection.Close()
        Catch ex As Exception
            MsgBox("Falha ao preencher o plano de contas.", MsgBoxStyle.OkOnly)
        Finally
            my_sql_connection.Dispose()
        End Try

        'query pegando os tipos de estoque que tem e adicionando eles também
    End Sub

    Private Sub txt_valor_total_TextChanged(sender As Object, e As EventArgs) Handles txt_valor_total.TextChanged

    End Sub

    Private Sub btn_verificar_saldo_Click(sender As Object, e As EventArgs) Handles btn_verificar_saldo.Click
        txt_qtde.Visible = False
        Label5.Visible = False
        With dgv_plano_contas
            If .CurrentCell.Value = "Banco Santander" Or .CurrentCell.Value = "Bancos com movimento" Then
                txt_valor_total.Text = chamar_saldo_banco()
            ElseIf .CurrentCell.Value = "Estoque" Then
                txt_valor_total.Text = chamar_saldo_estoque_total()
            Else
                Label5.Visible = True
                txt_qtde.Visible = True
                estoque = .CurrentCell.Value
                txt_valor_total.Text = chama_saldo_estoque()
                txt_qtde.Text = chama_qntd_estoque()
            End If
        End With
    End Sub

    Private Sub btn__Click(sender As Object, e As EventArgs) Handles btn_adicionar_novo_estoque.Click
        frm_menu_principal = Me.ParentForm
        frm_menu_principal.chama_novo_estoque()
        frm_menu_principal.Finaliza_user_control(Me)
    End Sub
End Class
