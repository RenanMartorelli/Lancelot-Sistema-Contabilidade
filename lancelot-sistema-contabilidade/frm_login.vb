Imports MySql.Data.MySqlClient
Public Class frm_login
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_senha.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub txt_nome_TextChanged(sender As Object, e As EventArgs) Handles txt_nome.TextChanged

    End Sub

    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        Dim frm_menu_principal As frm_menu_principal
        frm_menu_principal = New frm_menu_principal()

        If txt_nome.Text = "admin" And txt_nome.Text = "admin" Then
            frm_menu_principal.Show()
        End If

        Try
            'ui bebe eu gosto mais de vc do que de mim
            my_sql_connection.Open()
            query = "select * from lancelot.login where USER_NAME= '" & txt_nome.Text & "' and SENHA= '" & txt_senha.Text & "' "
            cmd = New MySqlCommand(query, my_sql_connection)
            leitura = cmd.ExecuteReader
            Dim cont As Integer
            cont = 0
            While leitura.Read
                tipologin = leitura("TIPO").ToString
                cont = cont + 1
            End While

            If cont = 1 Then
                MsgBox("Usuário encontrado")
                frm_menu_principal.Show()
                my_sql_connection.Close()


            ElseIf cont = 0 Then
                MsgBox("Usuário ou senha inválidos")
                my_sql_connection.Close()
            End If

        Catch ex As Exception
            MsgBox("Erro ao pegar do banco")
        Finally
            my_sql_connection.Dispose()
        End Try
        Me.Visible = False
    End Sub

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call conexao_banco()
    End Sub
End Class
