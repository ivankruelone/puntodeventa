
Public Class Pruebas



    Private Sub Pruebas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim producto As Productos = New Productos()

        producto.buscaProducto("7501571200552")

        Label1.Text = producto.Encontrado

    End Sub
End Class