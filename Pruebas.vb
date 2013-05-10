
Public Class Pruebas



    Private Sub Pruebas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim producto As Productos = New Productos("7501571200552")

        If producto.Encontrado = True Then
            Label1.Text = producto.Precio
        Else
            MsgBox("No existe el producto")
        End If

    End Sub
End Class