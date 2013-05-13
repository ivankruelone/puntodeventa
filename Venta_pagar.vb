Public Class Venta_pagar
    Private total As Decimal = Venta.totalPagar

    Private Sub Venta_pagar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TextPagar.Text = FormatNumber(Me.total, 2)
        Me.TextPagar.TextAlign = HorizontalAlignment.Right
        Me.TextPagar.Enabled = False
    End Sub
End Class