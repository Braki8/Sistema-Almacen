Imports System.Data.SqlClient
Public Class MetodoProductos

    Public Shared Function LISTARPRODUCTOS() As DataTable

        Using CN As New SqlConnection(My.Settings.conexion)
            Using DA As New SqlDataAdapter("Sp_ListarProductos", CN)
                Using TABLA As New DataTable
                    DA.Fill(TABLA)

                    Return TABLA
                End Using

            End Using
        End Using


    End Function

    Public Shared Function BUSCARPRODUCTOPORCODIGO(CODIGO As Integer) As DataTable

        Using CN As New SqlConnection(My.Settings.conexion)
            Using CMD As New SqlCommand("Sp_BuscarProductoPorCodigo", CN)
                CMD.CommandType = CommandType.StoredProcedure
                CMD.Parameters.AddWithValue("@CODIGO", CODIGO)
                Using DA As New SqlDataAdapter(CMD)
                    Using TABLA As New DataTable
                        DA.Fill(TABLA)

                        Return TABLA
                    End Using

                End Using

            End Using
        End Using


    End Function

    Public Shared Sub INSERTARPRODUCTO(CODIGO As Integer, NOMBRE As String, PRECIO As Decimal, STOCK As Integer, MARCA As String)
        Using CN As New SqlConnection(My.Settings.conexion)
            Using CMD As New SqlCommand("Sp_InsertarProductos", CN)
                CMD.CommandType = CommandType.StoredProcedure
                CMD.Parameters.AddWithValue("@CODIGO", CODIGO)
                CMD.Parameters.AddWithValue("@NOMBRE", NOMBRE)
                CMD.Parameters.AddWithValue("@PRECIO", PRECIO)
                CMD.Parameters.AddWithValue("@STOCK", STOCK)
                CMD.Parameters.AddWithValue("@MARCA", MARCA)

                CN.Open()
                CMD.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Shared Sub ACTUALIZARPRODUCTO(CODIGO As Integer, NOMBRE As String, PRECIO As Decimal, STOCK As Integer, MARCA As String)
        Using CN As New SqlConnection(My.Settings.conexion)
            Using CMD As New SqlCommand("Sp_ActualizarProducto", CN)
                CMD.CommandType = CommandType.StoredProcedure
                CMD.Parameters.AddWithValue("@CODIGO", CODIGO)
                CMD.Parameters.AddWithValue("@NOMBRE", NOMBRE)
                CMD.Parameters.AddWithValue("@PRECIO", PRECIO)
                CMD.Parameters.AddWithValue("@STOCK", STOCK)
                CMD.Parameters.AddWithValue("@MARCA", MARCA)

                CN.Open()
                CMD.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Shared Sub ELIMINARPRODUCTO(CODIGO As Integer)
        Using CN As New SqlConnection(My.Settings.conexion)
            Using CMD As New SqlCommand("Sp_EliminarProducto", CN)
                CMD.CommandType = CommandType.StoredProcedure
                CMD.Parameters.AddWithValue("@CODIGO", CODIGO)


                CN.Open()
                CMD.ExecuteNonQuery()
            End Using
        End Using
    End Sub

End Class
