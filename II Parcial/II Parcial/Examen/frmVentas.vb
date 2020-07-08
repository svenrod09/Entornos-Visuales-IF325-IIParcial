Imports System.Data.SqlClient
Imports System.Configuration
Imports System.ComponentModel

Public Class frmVentas
    Private cn As New SqlConnection(ConfigurationManager.ConnectionStrings("Conexion").ConnectionString)
    Public Function D_Lista() As DataTable
        Dim cmd As New SqlCommand("select concat(cliente.nombre, ' ', cliente.apellido) as 'Nombre Completo', producto.nombreProducto as 'Nombre Producto', Venta.idVenta as 'Codigo Venta', Venta.cantidad as Cantidad, Venta.Precio as Precio, Venta.fechaVenta as Fecha
from factura.cliente, factura.producto, factura.Venta where Venta.idCliente = cliente.idCliente and Venta.idProducto = producto.idProducto
", cn)
        cn.Open()
        cmd.CommandType = CommandType.Text
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        cn.Close()
        Return dt
    End Function
    Sub mostrarTabla()
        Dim dt As DataTable = D_Lista()
        dtgDatos.DataSource = dt
    End Sub
    Private Sub bloquearControlesCliente()
        txtNombre.Enabled = False
        txtApellido.Enabled = False
        txtDireccion.Enabled = False
        btnActualizar.Enabled = False
        btnGuardar.Enabled = False
        btnEliminar.Enabled = False
    End Sub
    Private Sub activarControlesCliente()
        txtNombre.Enabled = True
        txtApellido.Enabled = True
        txtDireccion.Enabled = True
        btnActualizar.Enabled = True
        btnGuardar.Enabled = True
        btnEliminar.Enabled = True
    End Sub
    Private Sub bloquearControlesProducto()
        txtNombreProducto.Enabled = False
        txtDescripcion.Enabled = False
        btnActualizarProd.Enabled = False
        btnEliminarProd.Enabled = False
        btnGuardarProd.Enabled = False
    End Sub
    Private Sub activarControlesProducto()
        txtNombreProducto.Enabled = True
        txtDescripcion.Enabled = True
        btnActualizarProd.Enabled = True
        btnEliminarProd.Enabled = True
        btnGuardarProd.Enabled = True
    End Sub
    Private Sub bloquearControlesVenta()
        txtCliente.Enabled = False
        txtProducto.Enabled = False
        txtCantidad.Enabled = False
        txtPrecio.Enabled = False
        txtFecha.Enabled = False
    End Sub
    Private Sub activarControlesVenta()
        txtCliente.Enabled = False
        txtProducto.Enabled = False
        txtCantidad.Enabled = True
        txtPrecio.Enabled = True
        txtFecha.Enabled = False
    End Sub
    Public Sub insertarCliente()
        Dim codigo As Integer
        Dim nombre, apellido, direccion As String

        codigo = txtCodigo.Text
        nombre = txtNombre.Text
        apellido = txtApellido.Text
        direccion = txtDireccion.Text

        Dim cmd As New SqlCommand("insert into factura.cliente values (@idCliente, @nombre, @apellido, @direccion)", cn)
        cn.Open()
        cmd.CommandType = CommandType.Text
        With cmd.Parameters
            .AddWithValue("@idCliente", codigo)
            .AddWithValue("@nombre", nombre)
            .AddWithValue("@apellido", apellido)
            .AddWithValue("@direccion", direccion)
            cmd.ExecuteNonQuery()
            cn.Close()
            cmd.Parameters.Clear()
            MsgBox("Cliente registrado con éxtito", vbInformation)
        End With
    End Sub
    Private Function buscarCliente() As Integer
        Dim encontrado As Integer
        Try
            Dim cmd As New SqlCommand("select * from factura.cliente where idCliente = '" + txtCodigo.Text + "'", cn)
            Dim dr As SqlDataReader
            cn.Open()
            dr = cmd.ExecuteReader
            cmd.CommandType = CommandType.Text
            If dr.Read Then
                encontrado = 1
                dr.Close()
            Else
                encontrado = 0
                dr.Close()
            End If
            cn.Close()
        Catch ex As Exception
            MessageBox.Show("No se pudo buscar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return encontrado
    End Function
    Private Sub llenartxtClientes()
        Dim cmd As New SqlCommand("select * from factura.cliente where idCliente = '" + txtCodigo.Text + "'", cn)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        cn.Open()
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            txtCodigo.Text = dt.Rows(0)(0).ToString
            txtNombre.Text = dt.Rows(0)(1).ToString
            txtApellido.Text = dt.Rows(0)(2).ToString
            txtDireccion.Text = dt.Rows(0)(3).ToString
        Else
            txtCodigo.Text = " "
            txtNombre.Text = " "
            txtApellido.Text = " "
            txtDireccion.Text = " "
        End If
        cn.Close()
    End Sub
    Private Function validarCamposCliente() As Integer
        Dim validado As Integer
        If txtCodigo.Text <> String.Empty And IsNumeric(txtCodigo.Text) And txtCodigo.TextLength <= 3 And txtNombre.Text <> String.Empty And txtApellido.Text <> String.Empty And txtDireccion.Text <> String.Empty Then
            validado = 1
        Else
            validado = 0
        End If
        Return validado
    End Function
    Private Sub actualizarCliente()
        Try
            Dim cmd As New SqlCommand("update factura.cliente set Nombre = @nombre, Apellido = @apellido, Direccion = @direccion where idCliente = '" + txtCodigo.Text + "'", cn)
            cn.Open()
            cmd.CommandType = CommandType.Text
            With cmd.Parameters
                .AddWithValue("@nombre", txtNombre.Text)
                .AddWithValue("@apellido", txtApellido.Text)
                .AddWithValue("@direccion", txtDireccion.Text)
            End With
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
            MessageBox.Show("No se pudo actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub eliminarCliente()
        Try
            Dim cmd As New SqlCommand("delete from factura.cliente where idCliente = '" + txtCodigo.Text + "'", cn)
            cn.Open()
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cn.Close()
            MessageBox.Show("Se eliminó el cliente correctamente", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            limpiar()
        Catch ex As Exception
            MessageBox.Show("No se pudo eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Function buscarProducto() As Integer
        Dim encontrado As Integer
        Try
            Dim cmd As New SqlCommand("select * from factura.producto where idProducto = '" + txtCodigoProducto.Text + "'", cn)
            Dim dr As SqlDataReader
            cn.Open()
            dr = cmd.ExecuteReader
            cmd.CommandType = CommandType.Text
            If dr.Read Then
                encontrado = 1
                dr.Close()
            Else
                encontrado = 0
                dr.Close()
            End If
            cn.Close()
        Catch ex As Exception
            MessageBox.Show("No se pudo buscar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return encontrado
    End Function
    Public Sub insertarProducto()
        Dim codigo As Integer
        Dim nombre, descripcion As String

        codigo = txtCodigoProducto.Text
        nombre = txtNombreProducto.Text
        descripcion = txtDescripcion.Text

        Dim cmd As New SqlCommand("insert into factura.prodcuto values (@idProducto, @nombreProducto, @descripcion)", cn)
        cn.Open()
        cmd.CommandType = CommandType.Text
        With cmd.Parameters
            .AddWithValue("@idProducto", codigo)
            .AddWithValue("@nombreProducto", nombre)
            .AddWithValue("@descripcion", descripcion)
            cmd.ExecuteNonQuery()
            cn.Close()
            cmd.Parameters.Clear()
            MsgBox("Producto registrado con éxito", vbInformation)
        End With
    End Sub
    Private Sub llenartxtProducto()
        Dim cmd As New SqlCommand("select * from factura.producto where idProducto = '" + txtCodigoProducto.Text + "'", cn)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        cn.Open()
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            txtCodigoProducto.Text = dt.Rows(0)(0).ToString
            txtNombreProducto.Text = dt.Rows(0)(1).ToString
            txtDescripcion.Text = dt.Rows(0)(2).ToString
        Else
            txtCodigoProducto.Text = " "
            txtNombreProducto.Text = " "
            txtDescripcion.Text = " "
        End If
        cn.Close()
    End Sub
    Private Function validarCamposProducto() As Integer
        Dim validado As Integer
        If txtCodigoProducto.Text <> String.Empty And txtCodigoProducto.TextLength <= 3 And IsNumeric(txtCodigoProducto.Text) And txtNombreProducto.Text <> String.Empty And txtDescripcion.Text <> String.Empty Then
            validado = 1
        Else
            validado = 0
        End If
        Return validado
    End Function
    Private Sub actualizarProducto()
        Try
            Dim cmd As New SqlCommand("update factura.producto set NombreProducto = @nombreProducto, Descripcion = @descripcion where idProducto = '" + txtCodigoProducto.Text + "'", cn)
            cn.Open()
            cmd.CommandType = CommandType.Text
            With cmd.Parameters
                .AddWithValue("@nombre", txtNombreProducto.Text)
                .AddWithValue("@descripcion", txtDescripcion.Text)
            End With
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
            MessageBox.Show("No se pudo actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub eliminarProducto()
        Try
            Dim cmd As New SqlCommand("delete from factura.producto where idProducto = '" + txtCodigoProducto.Text + "'", cn)
            cn.Open()
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cn.Close()
            MessageBox.Show("Se eliminó el producto correctamente", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            limpiar()
        Catch ex As Exception
            MessageBox.Show("No se pudo eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub llenarProducto()
        Dim cmd As New SqlCommand("select * from factura.producto", cn)
        Dim producto As String
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        cn.Open()
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            producto = dt.Rows(0)(1).ToString
            txtProducto.Text = producto
        Else
            MsgBox("No hay productos")
        End If
        cn.Close()
    End Sub
    Private Sub llenartxtVenta()
        Dim nombre, apellido, cliente, producto As String

        nombre = txtNombre.Text
        apellido = txtApellido.Text
        producto = txtNombreProducto.Text
        cliente = nombre & " " & apellido

        txtCliente.Text = cliente
        txtProducto.Text = producto
    End Sub
    Private Sub eliminarVenta()
        Try
            Dim cmd As New SqlCommand("delete from factura.Venta where idVenta= '" + txtVenta.Text + "'", cn)
            cn.Open()
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cn.Close()
            MessageBox.Show("Se eliminó la venta correctamente", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            limpiar()
        Catch ex As Exception
            MessageBox.Show("No se pudo eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub llenarTablaVenta()
        Dim cmd As New SqlCommand("insert into factura.Venta values (@idVenta, @fechaVenta, @precio, @cantidad, @idCliente, @idProducto)", cn)
        cn.Open()
        cmd.CommandType = CommandType.Text
        With cmd.Parameters
            .AddWithValue("@idVenta", txtVenta.Text)
            .AddWithValue("@fechaVenta", txtFecha.Text)
            .AddWithValue("@precio", txtPrecio.Text)
            .AddWithValue("@cantidad", txtCantidad.Text)
            .AddWithValue("@idCliente", txtCodigo.Text)
            .AddWithValue("@idProducto", txtCodigoProducto.Text)
            cmd.ExecuteNonQuery()
            cn.Close()
            cmd.Parameters.Clear()
            MsgBox("Venta registrada con éxito", vbInformation)
        End With
    End Sub
    Private Function validarCamposVenta() As Integer
        Dim validado As Integer
        If txtVenta.Text <> String.Empty And txtVenta.TextLength <= 3 And IsNumeric(txtVenta.Text) And (txtCantidad.Text) And Val(txtCantidad.Text) - Val(Int(txtCantidad.Text)) = 0 And txtPrecio.Text <> String.Empty And IsNumeric(txtPrecio.Text) And txtFecha.Text <> String.Empty Then
            validado = 1
        Else
            validado = 0
        End If
        Return validado
    End Function
    Private Sub obtenerFecha()
        Dim fecha As Date = Date.Today
        txtFecha.Text = fecha
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If (validarCamposCliente() = 1) Then
            insertarCliente()
        Else
            MessageBox.Show("Revise los campos ingresados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If txtCodigo.Text <> String.Empty And IsNumeric(txtCodigo.Text) And txtCodigo.TextLength < 3 Then
            If (buscarCliente() = 0) Then
                MsgBox("No se ha encontrado el cliente, puede registralo", vbInformation)
                activarControlesCliente()
            Else
                MsgBox("El cliente se ha encontrado", vbInformation)
                activarControlesCliente()
                llenartxtClientes()
            End If
        Else
            MessageBox.Show("Error al buscar, revise los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        actualizarCliente()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        eliminarCliente()
    End Sub

    Private Sub frmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bloquearControlesCliente()
        bloquearControlesProducto()
        bloquearControlesVenta()
        obtenerFecha()
        mostrarTabla()
    End Sub
    Private Sub txtCodigo_Validating(sender As Object, e As CancelEventArgs) Handles txtCodigo.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 And IsNumeric(txtCodigo.Text) Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "No puede dejar campos vacíos ni ingresar datos que no sean números")
        End If
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged

    End Sub

    Private Sub txtNombre_Validating(sender As Object, e As CancelEventArgs) Handles txtNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "No puede dejar campos vacíos")
        End If
    End Sub

    Private Sub txtApellido_TextChanged(sender As Object, e As EventArgs) Handles txtApellido.TextChanged

    End Sub

    Private Sub txtApellido_Validating(sender As Object, e As CancelEventArgs) Handles txtApellido.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "No puede dejar campos vacíos")
        End If
    End Sub

    Private Sub txtDireccion_TextChanged(sender As Object, e As EventArgs) Handles txtDireccion.TextChanged

    End Sub

    Private Sub txtDireccion_Validating(sender As Object, e As CancelEventArgs) Handles txtDireccion.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "No puede dejar campos vacíos")
        End If
    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub btnBuscarProd_Click(sender As Object, e As EventArgs) Handles btnBuscarProd.Click
        If txtCodigoProducto.Text <> String.Empty And IsNumeric(txtCodigoProducto.Text) And txtCodigoProducto.TextLength < 3 Then
            If (buscarProducto() = 0) Then
                MsgBox("No se ha encontrado el producto, puede registralo", vbInformation)
                activarControlesProducto()
            Else
                MsgBox("El producto se ha encontrado", vbInformation)
                activarControlesProducto()
                llenartxtProducto()
                activarControlesVenta()
                llenartxtVenta()
            End If
        Else
            MessageBox.Show("Error al buscar, revise los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnGuardarProd_Click(sender As Object, e As EventArgs) Handles btnGuardarProd.Click
        If (validarCamposProducto() = 1) Then
            insertarProducto()
        Else
            MessageBox.Show("Revise los campos ingresados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnEliminarProd_Click(sender As Object, e As EventArgs) Handles btnEliminarProd.Click
        eliminarProducto()
    End Sub

    Private Sub btnActualizarProd_Click(sender As Object, e As EventArgs) Handles btnActualizarProd.Click
        actualizarProducto()
    End Sub

    Private Sub txtFecha_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)

    End Sub

    Private Sub txtFecha_TextChanged(sender As Object, e As EventArgs) Handles txtFecha.TextChanged
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        If (validarCamposVenta() = 1) Then
            llenarTablaVenta()
        Else
            MessageBox.Show("Revise los campos ingresados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub txtCodigoProducto_TextChanged(sender As Object, e As EventArgs) Handles txtCodigoProducto.TextChanged

    End Sub

    Private Sub txtCodigoProducto_Validating(sender As Object, e As CancelEventArgs) Handles txtCodigoProducto.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 And IsNumeric(txtCodigoProducto.Text) Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "No puede dejar campos vacíos ni ingresar datos que no sean números")
        End If
    End Sub

    Private Sub txtNombreProducto_TextChanged(sender As Object, e As EventArgs) Handles txtNombreProducto.TextChanged

    End Sub

    Private Sub txtNombreProducto_Validating(sender As Object, e As CancelEventArgs) Handles txtNombreProducto.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "No puede dejar campos vacíos")
        End If
    End Sub

    Private Sub txtDescripcion_TextChanged(sender As Object, e As EventArgs) Handles txtDescripcion.TextChanged

    End Sub

    Private Sub txtDescripcion_Validating(sender As Object, e As CancelEventArgs) Handles txtDescripcion.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "No puede dejar campos vacíos")
        End If
    End Sub

    Private Sub txtCliente_TextChanged(sender As Object, e As EventArgs) Handles txtCliente.TextChanged

    End Sub

    Private Sub txtCliente_Validating(sender As Object, e As CancelEventArgs) Handles txtCliente.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "No puede dejar campos vacíos")
        End If
    End Sub

    Private Sub txtFecha_Validating(sender As Object, e As CancelEventArgs) Handles txtFecha.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "No puede dejar campos vacíos")
        End If
    End Sub

    Private Sub txtPrecio_TextChanged(sender As Object, e As EventArgs) Handles txtPrecio.TextChanged

    End Sub

    Private Sub txtPrecio_Validating(sender As Object, e As CancelEventArgs) Handles txtPrecio.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 And IsNumeric(txtPrecio.Text) Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "No puede dejar campos vacíos ni ingresar datos que no sean números")
        End If
    End Sub

    Private Sub txtCantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged
    End Sub

    Private Sub txtCantidad_Validating(sender As Object, e As CancelEventArgs) Handles txtCantidad.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 And IsNumeric(txtCantidad.Text) Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "No puede dejar campos vacíos ni ingresar datos que no sean números")
        End If
    End Sub

    Private Sub txtProducto_TextChanged(sender As Object, e As EventArgs) Handles txtProducto.TextChanged

    End Sub

    Private Sub txtProducto_Validating(sender As Object, e As CancelEventArgs) Handles txtProducto.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "No puede dejar campos vacíos")
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub
    Private Sub limpiar()
        txtCodigo.Clear()
        txtNombre.Clear()
        txtApellido.Clear()
        txtDireccion.Clear()
        txtCodigoProducto.Clear()
        txtNombreProducto.Clear()
        txtDescripcion.Clear()
        txtCliente.Clear()
        txtProducto.Clear()
        txtCantidad.Clear()
        txtPrecio.Clear()
        txtVenta.Clear()
        bloquearControlesCliente()
        bloquearControlesProducto()
        bloquearControlesVenta()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged

    End Sub

    Private Sub txtCodigo_MouseHover(sender As Object, e As EventArgs) Handles txtCodigo.MouseHover
        toolTip.SetToolTip(txtCodigo, "Ingrese un código de cliente (no mayor a 3 números)")
        toolTip.ToolTipTitle = "Código de Cliente"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtNombre_MouseHover(sender As Object, e As EventArgs) Handles txtNombre.MouseHover
        toolTip.SetToolTip(txtNombre, "Ingrese el nombre del cliente")
        toolTip.ToolTipTitle = "Nombre del Cliente"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtApellido_MouseHover(sender As Object, e As EventArgs) Handles txtApellido.MouseHover
        toolTip.SetToolTip(txtApellido, "Ingrese el apellido del cliente")
        toolTip.ToolTipTitle = "Apellido del Cliente"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtDireccion_MouseHover(sender As Object, e As EventArgs) Handles txtDireccion.MouseHover
        toolTip.SetToolTip(txtDireccion, "Ingrese la dirección de residencia del cliente")
        toolTip.ToolTipTitle = "Direccion del Cliente"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtCodigoProducto_MouseHover(sender As Object, e As EventArgs) Handles txtCodigoProducto.MouseHover
        toolTip.SetToolTip(txtCodigoProducto, "Ingrese el código del producto (no mayor a 3 números)")
        toolTip.ToolTipTitle = "Código del producto"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtNombreProducto_MouseHover(sender As Object, e As EventArgs) Handles txtNombreProducto.MouseHover
        toolTip.SetToolTip(txtNombreProducto, "Ingrese el nombre del producto")
        toolTip.ToolTipTitle = "Nombre del producto"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtDescripcion_MouseHover(sender As Object, e As EventArgs) Handles txtDescripcion.MouseHover
        toolTip.SetToolTip(txtDescripcion, "Ingrese una breve descripción del producto")
        toolTip.ToolTipTitle = "Descripción del producto"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtCliente_MouseHover(sender As Object, e As EventArgs) Handles txtCliente.MouseHover
        toolTip.SetToolTip(txtCliente, "Muestra el nombre del cliente al que se le está vendiendo")
        toolTip.ToolTipTitle = "Nombre de Cliente Venta"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtProducto_MouseHover(sender As Object, e As EventArgs) Handles txtProducto.MouseHover
        toolTip.SetToolTip(txtProducto, "Muestra el nombre del producto que se está vendiendo")
        toolTip.ToolTipTitle = "Nombre de Producto Venta"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtFecha_MouseHover(sender As Object, e As EventArgs) Handles txtFecha.MouseHover
        toolTip.SetToolTip(txtFecha, "Muestra la fecha al momento de realizar la venta")
        toolTip.ToolTipTitle = "Fecha de Venta"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtPrecio_MouseHover(sender As Object, e As EventArgs) Handles txtPrecio.MouseHover
        toolTip.SetToolTip(txtPrecio, "Ingrese el precio del producto que se está vendiendo")
        toolTip.ToolTipTitle = "Precio de Venta"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtCantidad_MouseHover(sender As Object, e As EventArgs) Handles txtCantidad.MouseHover
        toolTip.SetToolTip(txtCantidad, "Ingrese la cantidad del producto que se está vendiendo (valor entero)")
        toolTip.ToolTipTitle = "Cantidad de Venta"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnEliminarVenta_Click(sender As Object, e As EventArgs) Handles btnEliminarVenta.Click
        eliminarVenta()
        mostrarTabla()
    End Sub

    Private Sub txtVenta_TextChanged(sender As Object, e As EventArgs) Handles txtVenta.TextChanged

    End Sub

    Private Sub txtVenta_Validating(sender As Object, e As CancelEventArgs) Handles txtVenta.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 And IsNumeric(txtVenta.Text) Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "No puede dejar campos vacíos ni ingresar datos que no sean números")
        End If
    End Sub

    Private Sub txtVenta_MouseHover(sender As Object, e As EventArgs) Handles txtVenta.MouseHover
        toolTip.SetToolTip(txtVenta, "Ingrese el código de la venta (no mayor a 3 números)")
        toolTip.ToolTipTitle = "Código de la venta"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub dtgDatos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgDatos.CellContentClick

    End Sub
End Class