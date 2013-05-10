Imports MySql.Data.MySqlClient

Public Class Productos
    'ean, sec, descripcion, sustancia, presentacion, precio, ultimocosto, iva, fisico, linea, 
    'sublinea, antibiotico, minimo, maximo, preorden, marca, imagen, alta, cambio

    Dim conn As Common.DbConnection
    Dim sql As String
    Dim comando As MySqlCommand
    Dim productoReader As MySqlDataReader

    Private s_ean As String
    Private i_sec As Integer
    Private s_descripcion As String
    Private b_encontrado As Boolean
    Private d_precio As Decimal

    Public Property Ean() As String
        Get
            Return s_ean
        End Get
        Set(ByVal value As String)
            s_ean = value
        End Set
    End Property

    Public Property Sec() As Integer
        Get
            Return i_sec
        End Get
        Set(ByVal value As Integer)
            i_sec = value
        End Set
    End Property

    Public Property Descripcion() As String
        Get
            Return s_descripcion
        End Get
        Set(ByVal value As String)
            s_descripcion = value
        End Set
    End Property

    Public Property Encontrado() As Boolean
        Get
            Return b_encontrado
        End Get
        Set(ByVal value As Boolean)
            b_encontrado = value
        End Set
    End Property

    Public Property Precio() As Decimal
        Get
            Return d_precio
        End Get
        Set(ByVal value As Decimal)
            d_precio = value
        End Set
    End Property

    Sub New()

    End Sub

    Sub New(ByVal ean_marcado As String)
        Me.getProducto(ean_marcado)
    End Sub

    Public Function getProducto(ByVal ean_marcado As String)

        sql = "SELECT ean, sec, descripcion, precio FROM productos a where ean = " & ean_marcado & ";"

        Try
            conn = New MySqlConnection(Inicio.cnString)
            conn.Open()
            comando = New MySqlCommand(sql, conn)
            productoReader = comando.ExecuteReader()

            If productoReader.HasRows = True Then
                While productoReader.Read()
                    Me.Ean = productoReader.GetInt64(0).ToString
                    Me.Sec = productoReader.GetInt32(1)
                    Me.Descripcion = productoReader.GetString(2)
                    Me.Precio = productoReader.GetDecimal(3)
                    Me.Encontrado = True
                End While
                productoReader.Close()
            Else
                Me.Encontrado = False
            End If

            Return Me

        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Encontrado = False
            Return Me
        Finally
            conn.Close()
        End Try

    End Function

End Class
