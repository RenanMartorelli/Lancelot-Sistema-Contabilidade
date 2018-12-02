﻿Imports MySql.Data.MySqlClient
Public Class uct_registra_estoque
    Private Sub uct_registra_estoque_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Dim id As New Integer
            my_sql_connection.Open()
            query = "select MAX(IDCADASTROESTOQUE) as IDCADASTROESTOQUE from lancelot.cadastro_estoque"
            cmd = New MySqlCommand(query, my_sql_connection)
            leitura = cmd.ExecuteReader
            While leitura.Read
                id = leitura("IDCADASTROESTOQUE")
                lbl_id.Text = id + 1
            End While
            my_sql_connection.Close()
        Catch ex As Exception
            MsgBox("DEU RUIM DOIDOS")
        End Try
    End Sub

    Private Sub btn_registrar_Click(sender As Object, e As EventArgs) Handles btn_registrar.Click
        Try
            my_sql_connection.Open()
            query = "insert into lancelot.cadastro_estoque(NOME_PRODUTO) VALUES ('" & txt_nome_estoque.Text & "')"
            cmd = New MySqlCommand(query, my_sql_connection)
            leitura = cmd.ExecuteReader
            my_sql_connection.Close()
            MsgBox("Estoque registrado com sucesso", MsgBoxStyle.Information, "Lancelot - Registro de Estoque")
        Catch ex As Exception
            MsgBox("Mais erros...VOCÊ PARECE BURRO MEO")
        End Try
    End Sub
End Class
