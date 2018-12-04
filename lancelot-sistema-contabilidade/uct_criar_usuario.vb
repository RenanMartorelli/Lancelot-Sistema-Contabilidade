Imports MySql.Data.MySqlClient

Public Class uct_criar_usuario
    Dim frm_menu_principal As frm_menu_principal
    Dim grau_acesso As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        Call conexao_banco()

        If txt_confirma_senha.Text = "" Or txt_nome.Text = "" Or txt_senha.Text = "" Or txt_sobrenome.Text = "" Or txt_usuario.Text = "" Or rdb_administrador.Checked = False Or rdb_operador.Checked = False Then
            If txt_confirma_senha.Text = "" Or txt_nome.Text = "" Or txt_senha.Text = "" Or txt_sobrenome.Text = "" Or txt_usuario.Text = "" Then
                MsgBox("Preencha todos os campos!", MsgBoxStyle.OkOnly, "Lancelot Contabilidade - Criar Usuário")
                Exit Sub
            End If
            If txt_confirma_senha.Text <> txt_senha.Text Then
                MsgBox("Os campos senha e confirmar senha não conferem!", MsgBoxStyle.OkOnly, "Lancelot Contabilidade - Criar Usuário")
                Exit Sub
            End If
            If rdb_administrador.Checked = False And rdb_operador.Checked = False Then
                MsgBox("Selecione o grau de acesso do novo usuário!", MsgBoxStyle.OkOnly, "Lancelot Contabilidade - Criar Usuário")
                Exit Sub
            End If
        End If

        Try
            my_sql_connection.Open()
            query = "select * from lancelot.login where USER_NAME= '" & txt_usuario.Text & "' and SENHA='" & txt_senha.Text & "'"
            cmd = New MySqlCommand(query, my_sql_connection)
            leitura = cmd.ExecuteReader
            Dim cont As Integer
            cont = 0
            While leitura.Read
                cont = cont + 1
            End While

            If cont = 1 Then
                MsgBox("Usuário já cadastrado!", MsgBoxStyle.OkOnly, "Lancelot Contabilidade - Criar usuário")
                my_sql_connection.Close()
                txt_usuario.Text = ""
                txt_senha.Text = ""
                txt_confirma_senha = ""
                Exit Sub
            ElseIf cont = 0 Then
                my_sql_connection.Close()
                Exit Try
            End If
        Catch ex As Exception
            MsgBox("Erro no processamento de validação de cadastro de estoque!")
        Finally
            my_sql_connection.Dispose()
        End Try

        Try
            my_sql_connection.Open()
            query = "insert into lancelot.login(NAME, LAST_NAME, USER_NAME, SENHA, TIPO) VALUES ('" & txt_nome.Text & "','" & txt_sobrenome.Text & "','" & txt_usuario.Text & "','" & txt_senha.Text & "','" & grau_acesso & "')"
            cmd = New MySqlCommand(query, my_sql_connection) 'insere o comando na linha de comando do mysql
            leitura = cmd.ExecuteReader 'executa o comando lendo o banco
            MsgBox("Usuário criado com sucesso!", MsgBoxStyle.OkOnly, "Lancelot Contabilidade - Criar Usuário")
        Catch ex As Exception
            MsgBox("Erro ao criar o usuáario!")
        Finally
            my_sql_connection.Dispose()
            frm_menu_principal = Me.ParentForm
            frm_menu_principal.Finaliza_user_control(Me)
        End Try
    End Sub

    Private Sub uct_criar_usuario_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub rdb_administrador_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_administrador.CheckedChanged
        grau_acesso = "administrador"
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_operador.CheckedChanged
        grau_acesso = "operador"
    End Sub
End Class
