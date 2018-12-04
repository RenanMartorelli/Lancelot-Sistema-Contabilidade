Imports MySql.Data.MySqlClient
Module mod_banco_de_dados

    Public my_sql_connection, my_sql_connection2 As New MySqlConnection
    Public cmd, cmd2 As New MySqlCommand
    Public query, execute, comando As String
    Public da As New MySqlDataAdapter
    Public leitura, leitura2 As MySqlDataReader 'pra ler
    Public tipologin As String
    Public nome_conta As String
    Public estoque As String
    Public total As Double
    Public modo_estoque As String


    Sub conexao_banco()
        my_sql_connection = New MySqlConnection
        my_sql_connection.ConnectionString = "server=bancodadoshousebar.mysql.database.azure.com; userid=vb_bar@bancodadoshousebar;password=Fabi5412;database=lancelot"
        my_sql_connection2 = New MySqlConnection
        my_sql_connection2.ConnectionString = "server=bancodadoshousebar.mysql.database.azure.com; userid=vb_bar@bancodadoshousebar;password=Fabi5412;database=lancelot"
        Try
            my_sql_connection.Open()
            my_sql_connection2.Open()
            'MessageBox.Show("conexão ok!")
            my_sql_connection.Close()
            my_sql_connection2.Close()
        Catch ex As Exception
            MessageBox.Show("Erro na conexão")
        Finally
            my_sql_connection.Dispose()
            my_sql_connection2.Dispose()
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

    Public Function chamar_saldo_estoque_total()
        Dim somatotal As Double
        Try
            my_sql_connection.Open()
            query = "select * from lancelot.lancamento_estoque"
            cmd = New MySqlCommand(query, my_sql_connection)
            leitura = cmd.ExecuteReader
            While leitura.Read
                If leitura("TIPO") = "Débito" Then
                    somatotal += leitura("VALOR_TOTAL")
                ElseIf leitura("TIPO") = "Crédito" Then
                    somatotal -= leitura("VALOR_TOTAL")
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

    Public Function chama_saldo_estoque()
        Dim somatotal As Double
        Try
            my_sql_connection.Open()
            query = "select * from lancelot.lancamento_estoque where NOME_PRODUTO = '" & estoque & "'"
            cmd = New MySqlCommand(query, my_sql_connection)
            leitura = cmd.ExecuteReader
            While leitura.Read
                If leitura("TIPO") = "Débito" Then
                    somatotal += leitura("VALOR_TOTAL")
                ElseIf leitura("TIPO") = "Crédito" Then
                    somatotal -= leitura("VALOR_TOTAL")
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


    Public Sub pega_modo_estoque()
        Try
            my_sql_connection.Open()
            query = "Select MODO_ESTOQUE FROM lancelot.cadastro_empresa"
            cmd = New MySqlCommand(query, my_sql_connection)
            leitura = cmd.ExecuteReader
            While leitura.Read
                modo_estoque = leitura("MODO_ESTOQUE")
            End While
            my_sql_connection.Close()
        Catch ex As Exception
            MsgBox("Falha ao identificar o modo de estoque definido")
        Finally
            my_sql_connection.Dispose()
        End Try
    End Sub


    Public Function chama_qntd_estoque()
        Dim qntd As Integer
        Try
            my_sql_connection.Open()
            query = "select * from lancelot.lancamento_estoque where NOME_PRODUTO = '" & estoque & "'"
            cmd = New MySqlCommand(query, my_sql_connection)
            leitura = cmd.ExecuteReader
            While leitura.Read
                qntd += leitura("QTD")
            End While
            my_sql_connection.Close()
        Catch ex As Exception
            MsgBox("Nao funcionou T.T")
        Finally
            my_sql_connection.Dispose()
        End Try
        Return qntd
    End Function
End Module


