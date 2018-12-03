Imports MySql.Data.MySqlClient
Public Class uct_dados_empresa
    Private Sub uct_dados_empresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If tipologin = "operador" Then
            txt_email.Enabled = False
            txt_endereço.Enabled = False
            txt_nome_empresa.Enabled = False
            txt_segmento.Enabled = False
            btn_adicionar_usuario.Enabled = False
            btn_editar_dados.Enabled = False
        End If

        Try
            my_sql_connection.Open()
            query = "select * from lancelot.cadastro_empresa"
            cmd = New MySqlCommand(query, my_sql_connection)
            leitura = cmd.ExecuteReader
            While leitura.Read
                txt_email.Text = leitura("EMAIL")
                txt_segmento.Text = leitura("ATIVIDADE")
                txt_endereço.Text = leitura("ENDERECO")
                txt_nome_empresa.Text = leitura("NOME_EMPRESA")
            End While
            my_sql_connection.Close()
        Catch ex As Exception
            MsgBox("DEU RUIM CLÃ")
        Finally
            my_sql_connection.Dispose()
        End Try
    End Sub
    Dim frm_menu_principal As frm_menu_principal
    Private Sub btn_adicionar_usuario_Click(sender As Object, e As EventArgs) Handles btn_adicionar_usuario.Click
        frm_menu_principal = Me.ParentForm
        frm_menu_principal.chama_novo_usuario()
    End Sub
    Private Sub btn_editar_dados_Click(sender As Object, e As EventArgs) Handles btn_editar_dados.Click
        'Query update dos valores do input na tabela dados_empressa no BD
        Try
            my_sql_connection.Open()
            query = "update lancelot.cadastro_empresa set NOME_EMPRESA='" & txt_nome_empresa.Text & "', EMAIL='" & txt_email.Text & "', ENDERECO='" & txt_endereço.Text & "', ATIVIDADE='" & txt_segmento.Text & "' "
            cmd = New MySqlCommand(query, my_sql_connection)
            leitura = cmd.ExecuteReader
            MsgBox("Dados atualizados com sucesso!")
            my_sql_connection.Close()
        Catch ex As Exception
            MsgBox("DEU RUIM CRÃ")
        Finally
            my_sql_connection.Dispose()
        End Try

    End Sub
End Class