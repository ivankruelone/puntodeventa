Imports MySql.Data.MySqlClient

Public Class VentaTemp

    Inherits Base
    'id, ean, precio, cantidad, iva, descuento_tasa, descuento, total, caja, iva_tasa

    Dim conn As Common.DbConnection
    Dim sql As String
    Dim comando As MySqlCommand
    Dim ventaTempReader As MySqlDataReader

    Dim b_encontrado As Boolean
    Dim s_caja As String
    Dim s_ean As String
    Dim d_precio As Decimal
    Dim i_cantidad As Integer
    Dim d_descuento_tasa As Decimal
    Dim d_descuento As Decimal
    Dim d_iva_tasa As Decimal
    Dim d_iva As Decimal
    Dim d_total As Decimal


    Public Property Encontrado() As Boolean
        Get
            Return b_encontrado
        End Get
        Set(ByVal value As Boolean)
            b_encontrado = value
        End Set
    End Property

    Public Property Caja() As String
        Get
            Return s_caja
        End Get
        Set(ByVal value As String)
            s_caja = value
        End Set
    End Property

    Public Property Ean() As String
        Get
            Return s_ean
        End Get
        Set(ByVal value As String)
            s_ean = value
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

    Public Property Cantidad() As Integer
        Get
            Return i_cantidad
        End Get
        Set(ByVal value As Integer)
            i_cantidad = value
        End Set
    End Property

    Public Property Descuento_tasa() As Decimal
        Get
            Return d_descuento_tasa
        End Get
        Set(ByVal value As Decimal)
            d_descuento_tasa = value
        End Set
    End Property

    Public Property Descuento() As Decimal
        Get
            Return d_descuento
        End Get
        Set(ByVal value As Decimal)
            d_descuento = value
        End Set
    End Property

    Public Property Iva_tasa() As Decimal
        Get
            Return d_iva_tasa
        End Get
        Set(ByVal value As Decimal)
            d_iva_tasa = value
        End Set
    End Property

    Public Property Iva() As Decimal
        Get
            Return d_iva
        End Get
        Set(ByVal value As Decimal)
            d_iva = value
        End Set
    End Property

    Public Property Total() As Decimal
        Get
            Return d_total
        End Get
        Set(ByVal value As Decimal)
            d_total = value
        End Set
    End Property

    Sub New()

    End Sub

    Public Function getVentaTemp(ByVal cajaPaso As String, ByVal eanPaso As String)
        sql = "SELECT caja, ean, cantidad FROM detalle_temp where ean = '" & eanPaso & "' and caja = '" & cajaPaso & "';"

        Try
            conn = New MySqlConnection(Inicio.cnString)
            conn.Open()
            comando = New MySqlCommand(sql, conn)
            ventaTempReader = comando.ExecuteReader()

            If ventaTempReader.HasRows = True Then

                While ventaTempReader.Read()
                    Me.Cantidad = ventaTempReader.GetString(2)
                    Me.Encontrado = True
                End While

                ventaTempReader.Close()
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

    Function agregaVentaTemp(ByVal cajaPaso As String, ByVal eanPaso As String, ByVal precioPaso As Decimal)

        Me.Caja = cajaPaso
        Me.Ean = eanPaso
        Me.Precio = precioPaso
        Me.Cantidad = 1

        Me.calculo()

        Return Me.save()
    End Function

    Function calculo()

        Me.Descuento_tasa = 0
        Me.Descuento = 0
        Me.Iva_tasa = 0
        Me.Iva = 0
        Me.Total = Me.Precio * Me.Cantidad

        Return Nothing
    End Function

    Function save()
        Dim sql As String = "Insert into detalle_temp (ean, precio, cantidad, iva, descuento_tasa, descuento, total, caja, iva_tasa) values " _
                            & "('" & Me.Ean & "', " & Me.Precio & ", " & Me.Cantidad & ", " & Me.Iva & ", " _
                            & Me.Descuento_tasa & ", " & Me.Descuento & ", " & Me.Total & ", '" & Me.Caja & "', " _
                            & Me.Iva_tasa & ") on duplicate key update precio = values(precio), cantidad = values(cantidad), " _
                            & "iva = values(iva), descuento_tasa = values(descuento_tasa), descuento = values(descuento), " _
                            & "total = values(total), iva_tasa = values(iva_tasa);"
        Dim res As Boolean = Me.executeQuery(sql)
        Return res
    End Function

    Function actualizaVentaTemp(ByVal cajaPaso As String, ByVal eanPaso As String, ByVal precioPaso As Decimal, ByVal cantidadPaso As Integer)

        Me.Caja = cajaPaso
        Me.Ean = eanPaso
        Me.Precio = precioPaso
        Me.Cantidad = cantidadPaso + 1
        Me.calculo()

        Return Me.save()

    End Function

    Function modificaVentaTemp(ByVal cajaPaso As String, ByVal eanPaso As String, ByVal precioPaso As Decimal, ByVal cantidadPaso As Integer)

        Me.Caja = cajaPaso
        Me.Ean = eanPaso
        Me.Precio = precioPaso
        Me.Cantidad = cantidadPaso
        Me.calculo()

        Return Me.save()

    End Function

    Function borraRegistro(ByVal cajaPaso As String, ByVal eanPaso As String)
        Dim sql As String = "Delete from detalle_temp where caja = '" & cajaPaso & "' and ean = '" & eanPaso & "';"
        Dim res As Boolean = Me.executeQuery(sql)
        Return res
    End Function

End Class
