<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Venta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Venta))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ean = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.LabelTipodeCambio = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LabelTotalUSD = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LabelDescuento = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.LabelIVA = New System.Windows.Forms.Label()
        Me.BotonCancelar = New System.Windows.Forms.Button()
        Me.BotonRecargas = New System.Windows.Forms.Button()
        Me.BotonBuscaPrecio = New System.Windows.Forms.Button()
        Me.BotonFidelizacion = New System.Windows.Forms.Button()
        Me.BotonPagar = New System.Windows.Forms.Button()
        Me.BotonCliente = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ean)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 70)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Codigo de Barras"
        '
        'ean
        '
        Me.ean.Location = New System.Drawing.Point(15, 28)
        Me.ean.Name = "ean"
        Me.ean.Size = New System.Drawing.Size(162, 20)
        Me.ean.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(22, 98)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(766, 353)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Productos"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(754, 328)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BotonCancelar)
        Me.GroupBox3.Controls.Add(Me.BotonRecargas)
        Me.GroupBox3.Controls.Add(Me.BotonBuscaPrecio)
        Me.GroupBox3.Controls.Add(Me.BotonFidelizacion)
        Me.GroupBox3.Controls.Add(Me.BotonPagar)
        Me.GroupBox3.Controls.Add(Me.BotonCliente)
        Me.GroupBox3.Location = New System.Drawing.Point(794, 22)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(138, 429)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Opciones"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TextBox1)
        Me.GroupBox4.Location = New System.Drawing.Point(228, 22)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(395, 70)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Cliente"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(6, 28)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(383, 20)
        Me.TextBox1.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.LabelTipodeCambio)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.LabelTotalUSD)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.LabelDescuento)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Controls.Add(Me.LabelTotal)
        Me.GroupBox5.Location = New System.Drawing.Point(22, 457)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(910, 127)
        Me.GroupBox5.TabIndex = 6
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Totales"
        '
        'LabelTipodeCambio
        '
        Me.LabelTipodeCambio.AutoSize = True
        Me.LabelTipodeCambio.Location = New System.Drawing.Point(458, 108)
        Me.LabelTipodeCambio.Name = "LabelTipodeCambio"
        Me.LabelTipodeCambio.Size = New System.Drawing.Size(39, 13)
        Me.LabelTipodeCambio.TabIndex = 8
        Me.LabelTipodeCambio.Text = "Label6"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(360, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Tipo de cambio = "
        '
        'LabelTotalUSD
        '
        Me.LabelTotalUSD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelTotalUSD.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotalUSD.ForeColor = System.Drawing.SystemColors.Highlight
        Me.LabelTotalUSD.Location = New System.Drawing.Point(668, 96)
        Me.LabelTotalUSD.Name = "LabelTotalUSD"
        Me.LabelTotalUSD.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelTotalUSD.Size = New System.Drawing.Size(236, 25)
        Me.LabelTotalUSD.TabIndex = 6
        Me.LabelTotalUSD.Text = "0"
        Me.LabelTotalUSD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Location = New System.Drawing.Point(596, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 29)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "USD"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(354, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 31)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "MXP"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(259, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "IVA"
        '
        'LabelDescuento
        '
        Me.LabelDescuento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelDescuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDescuento.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LabelDescuento.Location = New System.Drawing.Point(9, 23)
        Me.LabelDescuento.Name = "LabelDescuento"
        Me.LabelDescuento.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelDescuento.Size = New System.Drawing.Size(274, 38)
        Me.LabelDescuento.TabIndex = 2
        Me.LabelDescuento.Text = "0"
        Me.LabelDescuento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(219, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Descuentos"
        '
        'LabelTotal
        '
        Me.LabelTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotal.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LabelTotal.Location = New System.Drawing.Point(435, 16)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelTotal.Size = New System.Drawing.Size(469, 76)
        Me.LabelTotal.TabIndex = 0
        Me.LabelTotal.Text = "0"
        Me.LabelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelIVA
        '
        Me.LabelIVA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelIVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelIVA.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LabelIVA.Location = New System.Drawing.Point(31, 538)
        Me.LabelIVA.Name = "LabelIVA"
        Me.LabelIVA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelIVA.Size = New System.Drawing.Size(274, 38)
        Me.LabelIVA.TabIndex = 3
        Me.LabelIVA.Text = "0"
        Me.LabelIVA.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BotonCancelar
        '
        Me.BotonCancelar.BackColor = System.Drawing.Color.Tomato
        Me.BotonCancelar.Image = Global.puntodeventa.My.Resources.Resources.cancel
        Me.BotonCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BotonCancelar.Location = New System.Drawing.Point(6, 333)
        Me.BotonCancelar.Name = "BotonCancelar"
        Me.BotonCancelar.Size = New System.Drawing.Size(126, 42)
        Me.BotonCancelar.TabIndex = 8
        Me.BotonCancelar.Text = "Cancelar venta"
        Me.BotonCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BotonCancelar.UseVisualStyleBackColor = False
        '
        'BotonRecargas
        '
        Me.BotonRecargas.Image = Global.puntodeventa.My.Resources.Resources.smartphone
        Me.BotonRecargas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BotonRecargas.Location = New System.Drawing.Point(6, 76)
        Me.BotonRecargas.Name = "BotonRecargas"
        Me.BotonRecargas.Size = New System.Drawing.Size(126, 42)
        Me.BotonRecargas.TabIndex = 7
        Me.BotonRecargas.Text = "Recargas TAE"
        Me.BotonRecargas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BotonRecargas.UseVisualStyleBackColor = True
        '
        'BotonBuscaPrecio
        '
        Me.BotonBuscaPrecio.Image = Global.puntodeventa.My.Resources.Resources.diagram_v2_28
        Me.BotonBuscaPrecio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BotonBuscaPrecio.Location = New System.Drawing.Point(6, 172)
        Me.BotonBuscaPrecio.Name = "BotonBuscaPrecio"
        Me.BotonBuscaPrecio.Size = New System.Drawing.Size(126, 42)
        Me.BotonBuscaPrecio.TabIndex = 6
        Me.BotonBuscaPrecio.Text = "Buscar precio"
        Me.BotonBuscaPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BotonBuscaPrecio.UseVisualStyleBackColor = True
        '
        'BotonFidelizacion
        '
        Me.BotonFidelizacion.Image = Global.puntodeventa.My.Resources.Resources.credit_cards
        Me.BotonFidelizacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BotonFidelizacion.Location = New System.Drawing.Point(6, 124)
        Me.BotonFidelizacion.Name = "BotonFidelizacion"
        Me.BotonFidelizacion.Size = New System.Drawing.Size(126, 42)
        Me.BotonFidelizacion.TabIndex = 5
        Me.BotonFidelizacion.Text = "Fidelización"
        Me.BotonFidelizacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BotonFidelizacion.UseVisualStyleBackColor = True
        '
        'BotonPagar
        '
        Me.BotonPagar.BackColor = System.Drawing.Color.GreenYellow
        Me.BotonPagar.Image = Global.puntodeventa.My.Resources.Resources.payment1
        Me.BotonPagar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BotonPagar.Location = New System.Drawing.Point(6, 381)
        Me.BotonPagar.Name = "BotonPagar"
        Me.BotonPagar.Size = New System.Drawing.Size(126, 42)
        Me.BotonPagar.TabIndex = 4
        Me.BotonPagar.Text = "Pagar"
        Me.BotonPagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BotonPagar.UseVisualStyleBackColor = False
        '
        'BotonCliente
        '
        Me.BotonCliente.Image = Global.puntodeventa.My.Resources.Resources.clients
        Me.BotonCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BotonCliente.Location = New System.Drawing.Point(6, 28)
        Me.BotonCliente.Name = "BotonCliente"
        Me.BotonCliente.Size = New System.Drawing.Size(126, 42)
        Me.BotonCliente.TabIndex = 3
        Me.BotonCliente.Text = "Agregar Cliente"
        Me.BotonCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BotonCliente.UseVisualStyleBackColor = True
        '
        'Venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 596)
        Me.Controls.Add(Me.LabelIVA)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Venta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ean As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BotonCliente As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelTotal As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LabelDescuento As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabelIVA As System.Windows.Forms.Label
    Friend WithEvents LabelTotalUSD As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LabelTipodeCambio As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BotonPagar As System.Windows.Forms.Button
    Friend WithEvents BotonFidelizacion As System.Windows.Forms.Button
    Friend WithEvents BotonBuscaPrecio As System.Windows.Forms.Button
    Friend WithEvents BotonRecargas As System.Windows.Forms.Button
    Friend WithEvents BotonCancelar As System.Windows.Forms.Button

End Class
