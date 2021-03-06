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
            lbl_id.Text = "1"
        Finally
            my_sql_connection.Dispose()
        End Try
    End Sub

    Private Sub btn_registrar_Click(sender As Object, e As EventArgs) Handles btn_registrar.Click
        If txt_nome_estoque.Text = "" Then
            MsgBox("Digite o nome do estoque a ser registrado", MsgBoxStyle.OkOnly, "Lancelot Contabilidade - Registrar novo estoque")
            Exit Sub
        End If

        Try
            my_sql_connection.Open()
            query = "select * from lancelot.cadastro_estoque where NOME_PRODUTO= '" & UCase(txt_nome_estoque.Text) & "'"
            cmd = New MySqlCommand(query, my_sql_connection)
            leitura = cmd.ExecuteReader
            Dim cont As Integer
            cont = 0
            While leitura.Read
                cont = cont + 1
            End While

            If cont = 1 Then
                MsgBox("Este produto já existe!", MsgBoxStyle.OkOnly, "Lancelot Contabilidade - Registrar novo estoque")
                my_sql_connection.Close()
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
            query = "insert into lancelot.cadastro_estoque(NOME_PRODUTO) VALUES ('" & UCase(txt_nome_estoque.Text) & "')"
            cmd = New MySqlCommand(query, my_sql_connection)
            leitura = cmd.ExecuteReader
            my_sql_connection.Close()
            MsgBox("Estoque registrado com sucesso", MsgBoxStyle.Information, "Lancelot - Registro de Estoque")
        Catch ex As Exception
            MsgBox("Falha ao registrar novo estoque.")
        Finally
            my_sql_connection.Dispose()
        End Try

        Dim frm_menu_principal As frm_menu_principal
        frm_menu_principal = Me.ParentForm
        frm_menu_principal.Finaliza_user_control(Me)
    End Sub
End Class
