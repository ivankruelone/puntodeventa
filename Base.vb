Imports MySql.Data.MySqlClient

Public Class Base
    Dim conn As Common.DbConnection
    Dim comando As MySqlCommand

    Function executeQuery(ByVal sql As String)
        Try
            conn = New MySqlConnection(Inicio.cnString)
            conn.Open()
            comando = New MySqlCommand(sql, conn)
            comando.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conn.Close()
        End Try

    End Function
End Class