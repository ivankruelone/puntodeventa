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

    Function getParametro(ByVal sql As String)
        Try
            Dim parametro As String
            conn = New MySqlConnection(Inicio.cnString)
            conn.Open()
            comando = New MySqlCommand(sql, conn)
            parametro = comando.ExecuteScalar()
            Return parametro
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conn.Close()
        End Try

    End Function

End Class