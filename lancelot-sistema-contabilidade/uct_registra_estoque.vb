Imports MySql.Data.MySqlClient
Public Class uct_registra_estoque
    Private Sub uct_registra_estoque_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Dim id As New Integer
            my_sql_connection.Open()
            query = "select max(IDCADASTROESTOQUE) from lancelot.cadastro_estoque"
            cmd = New MySqlCommand(query, my_sql_connection)
            leitura = cmd.ExecuteReader
            While leitura.Read
                lbl_id.Text = leitura("IDCADASTROESTOQUE") + 1
            End While
        Catch ex As Exception
            MsgBox("DEU RUIM DOIDOS")
        End Try
    End Sub
End Class
