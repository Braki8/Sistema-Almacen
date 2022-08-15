<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantenimientoProductos
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
        Me.caja = New System.Windows.Forms.GroupBox()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btBuscar = New System.Windows.Forms.Button()
        Me.btNuevo = New System.Windows.Forms.Button()
        Me.btInsertar = New System.Windows.Forms.Button()
        Me.btActualizar = New System.Windows.Forms.Button()
        Me.btEliminar = New System.Windows.Forms.Button()
        Me.btCancelar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.caja.SuspendLayout()
        Me.SuspendLayout()
        '
        'caja
        '
        Me.caja.Controls.Add(Me.txtMarca)
        Me.caja.Controls.Add(Me.txtStock)
        Me.caja.Controls.Add(Me.txtPrecio)
        Me.caja.Controls.Add(Me.txtNombre)
        Me.caja.Controls.Add(Me.TxtCodigo)
        Me.caja.Controls.Add(Me.Label5)
        Me.caja.Controls.Add(Me.Label4)
        Me.caja.Controls.Add(Me.Label3)
        Me.caja.Controls.Add(Me.Label2)
        Me.caja.Controls.Add(Me.Label1)
        Me.caja.Location = New System.Drawing.Point(57, 101)
        Me.caja.Name = "caja"
        Me.caja.Size = New System.Drawing.Size(370, 261)
        Me.caja.TabIndex = 0
        Me.caja.TabStop = False
        Me.caja.Text = "Datos del Producto"
        '
        'txtMarca
        '
        Me.txtMarca.Location = New System.Drawing.Point(109, 182)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(211, 20)
        Me.txtMarca.TabIndex = 5
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(109, 143)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(211, 20)
        Me.txtStock.TabIndex = 4
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(109, 112)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(211, 20)
        Me.txtPrecio.TabIndex = 3
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(109, 76)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(211, 20)
        Me.txtNombre.TabIndex = 2
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Location = New System.Drawing.Point(109, 40)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(211, 20)
        Me.TxtCodigo.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(28, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Marca:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Stock:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Precio:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo:"
        '
        'btBuscar
        '
        Me.btBuscar.Location = New System.Drawing.Point(234, 397)
        Me.btBuscar.Name = "btBuscar"
        Me.btBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btBuscar.TabIndex = 1
        Me.btBuscar.Text = "BUSCAR"
        Me.btBuscar.UseVisualStyleBackColor = True
        '
        'btNuevo
        '
        Me.btNuevo.Location = New System.Drawing.Point(581, 127)
        Me.btNuevo.Name = "btNuevo"
        Me.btNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btNuevo.TabIndex = 2
        Me.btNuevo.Text = "Nuevo"
        Me.btNuevo.UseVisualStyleBackColor = True
        '
        'btInsertar
        '
        Me.btInsertar.Location = New System.Drawing.Point(581, 175)
        Me.btInsertar.Name = "btInsertar"
        Me.btInsertar.Size = New System.Drawing.Size(75, 23)
        Me.btInsertar.TabIndex = 3
        Me.btInsertar.Text = "Insertar"
        Me.btInsertar.UseVisualStyleBackColor = True
        '
        'btActualizar
        '
        Me.btActualizar.Location = New System.Drawing.Point(581, 227)
        Me.btActualizar.Name = "btActualizar"
        Me.btActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btActualizar.TabIndex = 4
        Me.btActualizar.Text = "Actualizar"
        Me.btActualizar.UseVisualStyleBackColor = True
        '
        'btEliminar
        '
        Me.btEliminar.Location = New System.Drawing.Point(581, 283)
        Me.btEliminar.Name = "btEliminar"
        Me.btEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btEliminar.TabIndex = 5
        Me.btEliminar.Text = "Eliminar"
        Me.btEliminar.UseVisualStyleBackColor = True
        '
        'btCancelar
        '
        Me.btCancelar.Location = New System.Drawing.Point(581, 339)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btCancelar.TabIndex = 6
        Me.btCancelar.Text = "Cancelar"
        Me.btCancelar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(114, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(244, 25)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Registro de productos"
        '
        'FrmMantenimientoProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btCancelar)
        Me.Controls.Add(Me.btEliminar)
        Me.Controls.Add(Me.btActualizar)
        Me.Controls.Add(Me.btInsertar)
        Me.Controls.Add(Me.btNuevo)
        Me.Controls.Add(Me.btBuscar)
        Me.Controls.Add(Me.caja)
        Me.Name = "FrmMantenimientoProductos"
        Me.Text = "FrmMantenimientoProductos"
        Me.caja.ResumeLayout(False)
        Me.caja.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents caja As GroupBox
    Friend WithEvents txtMarca As TextBox
    Friend WithEvents txtStock As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents TxtCodigo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btBuscar As Button
    Friend WithEvents btNuevo As Button
    Friend WithEvents btInsertar As Button
    Friend WithEvents btActualizar As Button
    Friend WithEvents btEliminar As Button
    Friend WithEvents btCancelar As Button
    Friend WithEvents Label6 As Label
End Class
