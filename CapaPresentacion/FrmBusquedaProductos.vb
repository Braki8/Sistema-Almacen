Public Class FrmBusquedaProductos
    Private Sub FrmBusquedaProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DataGridView1.DataSource = CapDatos.MetodoProductos.LISTARPRODUCTOS
        TextBox2.Text = DataGridView1.RowCount - 1


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        If ComboBox1.SelectedItem = "NOMBRE" Then
            Dim Vista As New DataView(CapDatos.MetodoProductos.LISTARPRODUCTOS)
            Vista.RowFilter = "NOMBRE LIKE  '" & TextBox1.Text & "%'"
            DataGridView1.DataSource = Vista
            TextBox2.Text = DataGridView1.RowCount - 1
        End If

        If ComboBox1.SelectedItem = "MARCA" Then
            Dim Vista As New DataView(CapDatos.MetodoProductos.LISTARPRODUCTOS)
            Vista.RowFilter = "MARCA LIKE  '" & TextBox1.Text & "%'"
            DataGridView1.DataSource = Vista
            TextBox2.Text = DataGridView1.RowCount - 1
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If ComboBox1.SelectedItem = "CODIGO" Then
            DataGridView1.DataSource = CapDatos.MetodoProductos.BUSCARPRODUCTOPORCODIGO(TextBox1.Text)
            TextBox2.Text = DataGridView1.RowCount - 1

        End If


    End Sub

    Private Sub btRegistro_Click(sender As Object, e As EventArgs) Handles btRegistro.Click

        FrmMantenimientoProductos.Show()
        Me.Close()
    End Sub
End Class
