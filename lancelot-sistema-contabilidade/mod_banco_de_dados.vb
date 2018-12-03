Imports MySql.Data.MySqlClient
Module mod_banco_de_dados

    Public my_sql_connection As New MySqlConnection
    Public cmd As New MySqlCommand
    Public query, execute, comando As String
    Public da As New MySqlDataAdapter
    Public leitura As MySqlDataReader 'pra ler
    Public tipologin As String


    Sub conexao_banco()
        my_sql_connection = New MySqlConnection
        my_sql_connection.ConnectionString = "server=bancodadoshousebar.mysql.database.azure.com; userid=vb_bar@bancodadoshousebar;password=Fabi5412;database=lancelot"
        Try
            my_sql_connection.Open()
            'MessageBox.Show("conexão ok!")
            my_sql_connection.Close()
        Catch ex As Exception
            MessageBox.Show("Erro na conexão")
        Finally
            my_sql_connection.Dispose()
        End Try
    End Sub

    Public Function chamar_saldo_banco()
        Dim somatotal As Double
        Try
            my_sql_connection.Open()
            query = "select * from lancelot.lancamento_banco"
            cmd = New MySqlCommand(query, my_sql_connection)
            leitura = cmd.ExecuteReader
            While leitura.Read
                If leitura("TIPO") = "Débito" Then
                    somatotal += leitura("VALOR")
                ElseIf leitura("TIPO") = "Crédito" Then
                    somatotal -= leitura("VALOR")
                End If
            End While
            my_sql_connection.Close()
        Catch ex As Exception
            MsgBox("Nao funcionou T.T")
        Finally
            my_sql_connection.Dispose()
        End Try
        Return somatotal
    End Function

End Module


