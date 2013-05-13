Imports MySql.Data.MySqlClient
Public Class Venta
    Public eanCambiaCantidad As String
    Public secCambiaCantidad As String
    Public descripcionCambiaCantidad As String
    Public cantidadCambiaCantidad As String
    Public precioCambiaCantidad As String

    Public totalPagar As Decimal

    Dim conn As Common.DbConnection
    Dim da As Common.DbDataAdapter
    Dim ds As DataSet = New DataSet
    Dim sqlQRY As String
    Public cliente As String

    Private Sub Venta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Inicio.nombreAplicacion & " - Venta"
        Me.LabelTipodeCambio.Text = Inicio.tipoCambio
        carga_productos()
    End Sub

    Public Sub carga_productos()

        sqlQRY = "SELECT p.sec, d.ean, p.descripcion, d.precio, d.cantidad, d.precio * d.cantidad, d.descuento, d.iva, d.total FROM detalle_temp d " _
            & " left join productos p on d.ean = p.ean;"

        conn = New MySqlConnection(Inicio.cnString)

        Try

            conn.Open()

            da = New MySqlDataAdapter(sqlQRY, conn)


            Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(da)

            ds.Clear()
            da.Fill(ds, "almacen")
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "almacen"

            DataGridView1.AllowUserToAddRows = False
            DataGridView1.AllowUserToDeleteRows = False
            DataGridView1.AllowUserToOrderColumns = True
            DataGridView1.ReadOnly = True

            DataGridView1.Columns(0).HeaderText = "Sec."
            DataGridView1.Columns(1).HeaderText = "EAN"
            DataGridView1.Columns(2).HeaderText = "Descripción"
            DataGridView1.Columns(3).HeaderText = "Precio"
            DataGridView1.Columns(4).HeaderText = "Can."
            DataGridView1.Columns(5).HeaderText = "Imp."
            DataGridView1.Columns(6).HeaderText = "Desc."
            DataGridView1.Columns(7).HeaderText = "IVA"
            DataGridView1.Columns(8).HeaderText = "Total"

            DataGridView1.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            DataGridView1.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            DataGridView1.Columns(2).Width = 190
            DataGridView1.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            DataGridView1.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            DataGridView1.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            DataGridView1.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            DataGridView1.Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            DataGridView1.Columns(8).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

            Me.DataGridView1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Me.DataGridView1.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Me.DataGridView1.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Me.DataGridView1.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Me.DataGridView1.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Me.DataGridView1.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            Me.DataGridView1.Columns(8).DefaultCellStyle.BackColor = Color.GreenYellow

            Me.calculaTotal()
        Catch ex As Common.DbException
            MsgBox(ex.ToString)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub calculaTotal()
        Dim total As Base = New Base
        Dim totalQry As Decimal = CDec(total.getParametro(sql:="select ifnull(sum(total), 0) from detalle_temp where caja = '" & Inicio.maquina & "';"))

        Me.totalPagar = totalQry

        LabelTotal.Text = FormatNumber(totalQry, 2).ToString()
        LabelDescuento.Text = FormatNumber(CDec(total.getParametro(sql:="select ifnull(sum(descuento), 0) from detalle_temp where caja = '" & Inicio.maquina & "';")), 2).ToString()
        LabelIVA.Text = FormatNumber(CDec(total.getParametro(sql:="select ifnull(sum(iva), 0) from detalle_temp where caja = '" & Inicio.maquina & "';")), 2).ToString()
        LabelTotalUSD.Text = FormatNumber((totalQry / CDec(Inicio.tipoCambio)), 2).ToString()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonCliente.Click
        Venta_cliente.Show()
    End Sub

    Public Sub Asigna_Cliente(ByVal cliente As Integer)
        TextBox1.Text = cliente
    End Sub

    Private Sub ean_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ean.KeyUp
        If e.KeyCode = Keys.Enter Then

            Dim _ean As String = ean.Text.Trim

            If _ean = "" Then
                MsgBox("Esta vacio.")
            Else
                Dim producto As Productos = New Productos(_ean)
                If producto.Encontrado = True Then

                    Dim ventaTemp As VentaTemp = New VentaTemp()
                    ventaTemp.getVentaTemp(Inicio.maquina, _ean)

                    If ventaTemp.Encontrado = True Then
                        ventaTemp.actualizaVentaTemp(Inicio.maquina, _ean, producto.Precio, ventaTemp.Cantidad)
                    Else
                        ventaTemp.agregaVentaTemp(Inicio.maquina, _ean, producto.Precio)
                    End If

                Else
                    MsgBox("Producto no encontrado.")
                End If

                carga_productos()

            End If
        End If
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If e.RowIndex >= 0 Then
            secCambiaCantidad = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString()
            eanCambiaCantidad = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString()
            descripcionCambiaCantidad = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString()
            precioCambiaCantidad = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString()
            cantidadCambiaCantidad = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString()
            Venta_cambia_cantidad.Show()
        End If
    End Sub

    Private Sub BotonPagar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonPagar.Click
        Venta_pagar.Show()
    End Sub

End Class
