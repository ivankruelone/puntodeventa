Public Class Productos
    'ean, sec, descripcion, sustancia, presentacion, precio, ultimocosto, iva, fisico, linea, 
    'sublinea, antibiotico, minimo, maximo, preorden, marca, imagen, alta, cambio

    Private s_ean As String
    Private i_sec As Integer
    Private s_descripcion As String
    Private b_encontrado As Boolean

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

    Public Function buscaProducto(ByVal ean_marcado As String)

        If ean_marcado = "7501571200552" Then

            Me.s_ean = "7501571200552"
            Me.i_sec = 320
            Me.s_descripcion = "ICETAZOL 500 MG 10 TABS"
            Me.Encontrado = True
            Return Me
        Else
            Me.Encontrado = False
            Return Me

        End If


    End Function

End Class
