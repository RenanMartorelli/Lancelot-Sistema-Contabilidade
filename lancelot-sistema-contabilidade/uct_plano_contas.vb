Imports MySql.Data.MySqlClient
Public Class uct_plano_contas
    Dim frm_menu_principal As frm_menu_principal
    Private Sub uct_plano_contas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv_plano_contas.Rows.Add("1", "Ativo")
        dgv_plano_contas.Rows.Add("1.1", "Ativo circulante")
        dgv_plano_contas.Rows.Add("1.1.1", "Bancos com movimento")
        dgv_plano_contas.Rows.Add("1.1.1.1", "Banco Santander")
        dgv_plano_contas.Rows.Add("1", "Ativo")
        dgv_plano_contas.Rows.Add("1.1", "Ativo circulante")
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
            MsgBox("VOCÊ NAO SABE FAZER NADA QUE N TENHA ERRO???")
        End Try

        'query pegando os tipos de estoque que tem e adicionando eles também
    End Sub

    Private Sub txt_valor_total_TextChanged(sender As Object, e As EventArgs) Handles txt_valor_total.TextChanged

    End Sub

    Private Sub btn_verificar_saldo_Click(sender As Object, e As EventArgs) Handles btn_verificar_saldo.Click
        Try
            Dim somatotal As Double
            Dim qntd As Integer
            If dgv_plano_contas.CurrentCell.Value = "Banco Santander" Then
                my_sql_connection.Open()
                query = "select * from lancelot.lancamento_banco"
                cmd = New MySqlCommand(query, my_sql_connection)
                leitura = cmd.ExecuteReader
                While leitura.Read
                    If leitura("TIPO") = "Débito" Then
                        somatotal += leitura("VALOR")
                    End If
                    If leitura("TIPO") = "Crédito" Then
                        somatotal -= leitura("VALOR")
                    End If
                End While
            End If
            txt_valor_total.Text = somatotal
            my_sql_connection.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn__Click(sender As Object, e As EventArgs) Handles btn_.Click
        frm_menu_principal = Me.ParentForm
        frm_menu_principal.chama_novo_estoque()
        frm_menu_principal.Finaliza_user_control(Me)
    End Sub
End Class
