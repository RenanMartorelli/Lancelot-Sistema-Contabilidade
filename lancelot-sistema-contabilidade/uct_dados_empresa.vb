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
            rdb_media.Enabled = False
            rdb_PEPS.Enabled = False
            rdb_UEPS.Enabled = False
        End If

        lbl_modo_estoque.Text = modo_estoque

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
            MsgBox("Falha ao carregar os dados da empresa")
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
        If String.IsNullOrEmpty(txt_email.Text) Or String.IsNullOrEmpty(txt_segmento.Text) Or String.IsNullOrEmpty(txt_nome_empresa.Text) Or String.IsNullOrEmpty(txt_endereço.Text) Then
            MsgBox("Há algum campo não preenchido!")
            Exit Sub
        End If
        Try
            my_sql_connection.Open()
            query = "update lancelot.cadastro_empresa set NOME_EMPRESA='" & txt_nome_empresa.Text & "', EMAIL='" & txt_email.Text & "', ENDERECO='" & txt_endereço.Text & "', ATIVIDADE='" & txt_segmento.Text & "' "
            cmd = New MySqlCommand(query, my_sql_connection)
            leitura = cmd.ExecuteReader
            MsgBox("Dados atualizados com sucesso!")
            my_sql_connection.Close()
        Catch ex As Exception
            MsgBox("Falha ao atualizar os dados da empresa")
        Finally
            my_sql_connection.Dispose()
        End Try

    End Sub

    Private Sub rdb_PEPS_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_PEPS.CheckedChanged
        If rdb_PEPS.Checked = True Then
            If confirmar_acao() Then
                modo_estoque = "PEPS"
                Call atualiza_modo_estoque()
                lbl_modo_estoque.Text = modo_estoque
            End If
        End If
    End Sub
    Private Sub rdb_UEPS_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_UEPS.CheckedChanged
        If rdb_UEPS.Checked = True Then
            If confirmar_acao() Then
                modo_estoque = "UEPS"
                Call atualiza_modo_estoque()
                lbl_modo_estoque.Text = modo_estoque
            End If
        End If
    End Sub
    Private Sub rdb_media_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_media.CheckedChanged
        If rdb_media.Checked = True Then
            If confirmar_acao() Then
                modo_estoque = "MÉDIA"
                Call atualiza_modo_estoque()
                lbl_modo_estoque.Text = modo_estoque
            End If
        End If
    End Sub
    Private Function confirmar_acao()
        Dim resp = MsgBox("Essa ação só pode ser feita na virada do ano, e ela afeta profundamente como esses dados serão retirados, para efeito de teste, deseja confirmar a ação?", MsgBoxStyle.YesNo)
        If resp = vbYes Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub atualiza_modo_estoque()
        Try
            my_sql_connection.Open()
            query = "update lancelot.cadastro_empresa set MODO_ESTOQUE='" & modo_estoque & "' "
            cmd = New MySqlCommand(query, my_sql_connection)
            leitura = cmd.ExecuteReader
            MsgBox("Modo de estoque atualizado com sucesso! Modo ativo: " & modo_estoque & "")
            my_sql_connection.Close()
        Catch ex As Exception
            MsgBox("Falha ao salvar o modo de estoque")
        Finally
            my_sql_connection.Dispose()
        End Try
    End Sub
End Class