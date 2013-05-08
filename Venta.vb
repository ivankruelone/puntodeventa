Imports MySql.Data.MySqlClient
Public Class Venta

    Dim conn As Common.DbConnection
    Dim da As Common.DbDataAdapter
    Dim ds As DataSet = New DataSet
    Dim sqlQRY As String
    Public cliente As String

    Private Sub Venta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Inicio.nombreAplicacion & " - Venta"
        carga_productos()
    End Sub

    Private Sub carga_productos()

        sqlQRY = "SELECT sec, susa1, costo, vtaddr, codigo FROM almacen a where tsec = 'G' limit 10;"

        conn = New MySqlConnection(Inicio.cnString)

        Try

            conn.Open()

            da = New MySqlDataAdapter(sqlQRY, conn)


            Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(da)


            da.Fill(ds, "almacen")

            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "almacen"

            DataGridView1.Columns(0).HeaderText = "Id."
            DataGridView1.Columns(1).HeaderText = "Descripción"
            DataGridView1.Columns(1).Width = 280
            DataGridView1.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            DataGridView1.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            DataGridView1.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            DataGridView1.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

            DataGridView1.Columns(0).ReadOnly = True

        Catch ex As Common.DbException
            MsgBox(ex.ToString)
        Finally

            conn.Close()
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Venta_cliente.Show()
    End Sub

    Public Sub Asigna_Cliente(ByVal cliente As Integer)
        TextBox1.Text = cliente
    End Sub

End Class
