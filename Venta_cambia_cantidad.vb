Public Class Venta_cambia_cantidad

    Private ReadOnly precio As Decimal = CDec(Venta.precioCambiaCantidad)

    Private Sub Venta_cambia_cantidad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = Venta.secCambiaCantidad
        TextBox2.Text = Venta.eanCambiaCantidad
        TextBox3.Text = Venta.descripcionCambiaCantidad
        TextBox4.Text = Venta.cantidadCambiaCantidad
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Cambiar()
    End Sub

    Private Sub TextBox4_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox4.KeyUp
        If e.KeyCode = Keys.Enter Then
            Me.Cambiar()
        End If
    End Sub

    Private Sub Cambiar()
        Dim cantidadNueva As Integer = TextBox4.Text
        Dim cambio As VentaTemp = New VentaTemp()
        cambio.modificaVentaTemp(Inicio.maquina, TextBox2.Text, precio, cantidadNueva)
        Venta.carga_productos()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim respuestamensaje As Integer = MsgBox("Esto eliminara este renglón, ¿ Estas seguro ?", vbYesNo, "Aviso")

        If respuestamensaje = 6 Then
            Dim borra As VentaTemp = New VentaTemp
            borra.borraRegistro(Inicio.maquina, TextBox2.Text)
            Venta.carga_productos()
            Me.Close()
        End If
    End Sub
End Class