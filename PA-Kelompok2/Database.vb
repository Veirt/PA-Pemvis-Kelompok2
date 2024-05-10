Imports MySql.Data.MySqlClient

Module Database
    Public CONN As MySqlConnection
    Public CMD As MySqlCommand
    Public RD As MySqlDataReader
    Public DA As MySqlDataAdapter
    Public DS As DataSet
    Public CONFIG As String
    Sub ConnectDatabase()
        Try
            CONFIG = "server=localhost;userid=root;password=;database=anime77"
            'Ganti nama database sesuaikan dengan nama database kalian
            CONN = New MySqlConnection(CONFIG)
            If CONN.State = ConnectionState.Closed Then
                CONN.Open()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Module
