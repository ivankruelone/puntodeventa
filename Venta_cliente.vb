Public Class Venta_cliente
    Public cliente_id As Integer = 5
    Private Sub Venta_cliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Inicio.nombreAplicacion & " - Venta agregar cliente"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Venta.cliente = Me.cliente_id
        Venta.Asigna_Cliente(Me.cliente_id)
        Me.Close()
    End Sub
End Class