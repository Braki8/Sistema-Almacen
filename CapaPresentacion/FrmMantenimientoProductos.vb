Public Class FrmMantenimientoProductos
    Private Sub btInsertar_Click(sender As Object, e As EventArgs) Handles btInsertar.Click
        CapDatos.MetodoProductos.INSERTARPRODUCTO(TxtCodigo.Text, txtNombre.Text, txtPrecio.Text, txtStock.Text, txtMarca.Text)
        MsgBox("PRODUCTO INSERTADO CORRECTAMENTE")
    End Sub

    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click

        FrmBusquedaProductos.Show()

    End Sub

    Private Sub btActualizar_Click(sender As Object, e As EventArgs) Handles btActualizar.Click
        CapDatos.MetodoProductos.ACTUALIZARPRODUCTO(TxtCodigo.Text, txtNombre.Text, txtPrecio.Text, txtStock.Text, txtMarca.Text)
        MsgBox("PRODUCTO ACTUALIZADO CORRECTAMENTE")
    End Sub

    Private Sub btEliminar_Click(sender As Object, e As EventArgs) Handles btEliminar.Click
        CapDatos.MetodoProductos.ELIMINARPRODUCTO(TxtCodigo.Text)
        MsgBox("PRODUCTO ELIMINADO CORRECTAMENTE")
    End Sub
End Class