Imports MySql.Data.MySqlClient

Public Class uct_criar_usuario
    Dim frm_menu_principal As frm_menu_principal
    Dim grau_acesso As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click

        Call conexao_banco()


        Try
            my_sql_connection.Open()
            query = "insert into lancelot.login(NAME, LAST_NAME, USER_NAME, SENHA, TIPO) VALUES ('" & txt_nome.Text & "','" & txt_sobrenome.Text & "','" & txt_usuario.Text & "','" & txt_senha.Text & "','" & grau_acesso & "')"
            cmd = New MySqlCommand(query, my_sql_connection) 'insere o comando na linha de comando do mysql
            leitura = cmd.ExecuteReader 'executa o comando lendo o banco
            MsgBox("Usuário criado!")
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
