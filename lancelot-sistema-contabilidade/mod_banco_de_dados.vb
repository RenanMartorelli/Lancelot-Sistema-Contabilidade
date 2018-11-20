Imports MySql.Data.MySqlClient
Module mod_banco_de_dados
    Public my_sql_connection As New MySqlConnection
    Public cmd As New MySqlCommand
    Public query, execute, comando As String
    Public da As MySqlDataAdapter
    Public leitura As MySqlDataReader 'pra ler


    Sub conexao_banco()
        my_sql_connection = New MySqlConnection
        my_sql_connection.ConnectionString = "server=lancelot-contabilidade.mysql.database.azure.com; userid=lancelot_adm@lancelot-contabilidade;password=Fatec1234;database=lancelot"
        Try
            my_sql_connection.Open()
            MessageBox.Show("conexão ok!")
            my_sql_connection.Close()
        Catch ex As Exception
            MessageBox.Show("Erro na conexão")
        Finally
            my_sql_connection.Dispose()
        End Try
    End Sub

End Module


