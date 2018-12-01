Imports MySql.Data.MySqlClient
Module mod_banco_de_dados
    Public my_sql_connection As New MySqlConnection
    Public cmd As New MySqlCommand
    Public query, execute, comando As String
    Public da As MySqlDataAdapter
    Public leitura As MySqlDataReader 'pra ler

    'Modulo Teste do Titio Keizo
    Public sql As String
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public conexao = Application.StartupPath & "\Banco\banco.mdb\"

    Sub conecta_keizo()
        db = CreateObject("ADODB.connection")
        db.Open("Provider=Microsoft.JET.OLEDB.4.0;Data Source=" & conexao)
        MsgBox("Conexão Keizo Bem Sucedida.")
    End Sub
    'FIM do Teste do Titio Keizo

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


