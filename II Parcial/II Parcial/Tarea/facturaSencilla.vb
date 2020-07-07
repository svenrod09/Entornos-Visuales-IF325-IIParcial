Imports System.ComponentModel

Public Class facturaSencilla
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        'Definir variables
        Dim precio, cantidad, subtotal As Integer
        Dim descuento, isv, total As Double
        Dim valorDescuento(5), valorIsv(1) As Double

        'Asignar valor a los arreglos
        'Descuento
        valorDescuento(0) = 0.5
        valorDescuento(1) = 0.25
        valorDescuento(2) = 0.2
        valorDescuento(3) = 0.15
        valorDescuento(4) = 0.1
        valorDescuento(5) = 0.05
        'ISV
        valorIsv(0) = 0.15
        valorIsv(1) = 0.17

        'Validar que los valores ingresados en precio/cantidad sean númericos positivos
        'Verifica que no haya campos vacíos
        If txtPrecio.Text = "" Or txtCantidad.Text = "" Then
            MsgBox("No puede dejar campos vacíos", vbInformation)
            txtPrecio.Text = ""
            txtCantidad.Text = ""
            'Verifica que los valores ingresados sean números
        ElseIf Not IsNumeric(txtPrecio.Text) Or Not IsNumeric(txtCantidad.Text) Then
            MsgBox("Debe ingresar solo valores númericos", vbInformation)
            'Verifica que los valores ingresados sean positivos
        ElseIf IsNumeric(txtPrecio.Text) And IsNumeric(txtCantidad.Text) Then
            precio = Val(txtPrecio.Text)
            cantidad = Val(txtCantidad.Text)
            If precio <= 0 Or cantidad <= 0 Then
                MsgBox("Ingrese valores positivos", vbInformation)
            End If
        End If

        'Proceso
        subtotal = precio * cantidad
        descuento = 0
        isv = 0

        'Aplica los descuentos en caso de ser seleccionados
        Select Case cmbDescuento.SelectedIndex
            Case 0
                descuento = subtotal * valorDescuento(0)
            Case 1
                descuento = subtotal * valorDescuento(1)
            Case 2
                descuento = subtotal * valorDescuento(2)
            Case 3
                descuento = subtotal * valorDescuento(3)
            Case 4
                descuento = subtotal * valorDescuento(4)
            Case 5
                descuento = subtotal * valorDescuento(5)
        End Select

        'Aplica el ISV en caso de ser seleccionado
        Select Case cmbISV.SelectedIndex
            Case 0
                isv = subtotal * valorIsv(0)
            Case 1
                isv = subtotal * valorIsv(1)
        End Select

        'Calcula el total a pagar
        total = subtotal - descuento + isv

        'Salidas 
        txtSubtotal.Text = subtotal
        txtDescuento.Text = descuento
        txtISV.Text = isv
        txtTotal.Text = total
        btnNuevo.Enabled = True
    End Sub

    Private Sub chkDescuento_CheckedChanged(sender As Object, e As EventArgs) Handles chkDescuento.CheckedChanged
        If chkDescuento.Checked = True Then
            chkISV.Checked = False
            cmbDescuento.Enabled = True
        End If
    End Sub

    Private Sub chkISV_CheckedChanged(sender As Object, e As EventArgs) Handles chkISV.CheckedChanged
        If chkISV.Checked = True Then
            chkDescuento.Checked = False
            cmbISV.Enabled = True
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiar()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
    Private Sub limpiar()
        txtPrecio.Clear()
        txtCantidad.Clear()
        txtSubtotal.Clear()
        txtDescuento.Clear()
        txtISV.Clear()
        txtTotal.Clear()
    End Sub

    Private Sub txtPrecio_TextChanged(sender As Object, e As EventArgs) Handles txtPrecio.TextChanged

    End Sub

    Private Sub txtPrecio_MouseHover(sender As Object, e As EventArgs) Handles txtPrecio.MouseHover
        toolTip.SetToolTip(txtPrecio, "Ingrese el precio del producto")
        toolTip.ToolTipTitle = "Precio"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtCantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged
    End Sub

    Private Sub txtCantidad_MouseHover(sender As Object, e As EventArgs) Handles txtCantidad.MouseHover
        toolTip.SetToolTip(txtCantidad, "Ingrese la cantidad del producto")
        toolTip.ToolTipTitle = "Cantidad"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cmbDescuento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDescuento.SelectedIndexChanged

    End Sub

    Private Sub cmbDescuento_MouseHover(sender As Object, e As EventArgs) Handles cmbDescuento.MouseHover
        toolTip.SetToolTip(cmbDescuento, "Seleccione un tipo de descuento")
        toolTip.ToolTipTitle = "Descuento"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cmbISV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbISV.SelectedIndexChanged
    End Sub

    Private Sub cmbISV_MouseHover(sender As Object, e As EventArgs) Handles cmbISV.MouseHover
        toolTip.SetToolTip(cmbISV, "Seleccione un tipo de impuesto")
        toolTip.ToolTipTitle = "Impuesto"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtSubtotal_TextChanged(sender As Object, e As EventArgs) Handles txtSubtotal.TextChanged

    End Sub

    Private Sub txtSubtotal_MouseHover(sender As Object, e As EventArgs) Handles txtSubtotal.MouseHover
        toolTip.SetToolTip(txtSubtotal, "Muestra el valor del subtotal")
        toolTip.ToolTipTitle = "Subtotal"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtDescuento_TextChanged(sender As Object, e As EventArgs) Handles txtDescuento.TextChanged

    End Sub

    Private Sub txtDescuento_MouseHover(sender As Object, e As EventArgs) Handles txtDescuento.MouseHover
        toolTip.SetToolTip(txtDescuento, "Muestra el valor del descuento")
        toolTip.ToolTipTitle = "Descuento"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtISV_TextChanged(sender As Object, e As EventArgs) Handles txtISV.TextChanged
    End Sub

    Private Sub txtISV_MouseHover(sender As Object, e As EventArgs) Handles txtISV.MouseHover
        toolTip.SetToolTip(txtISV, "Muestra el valor del ISV")
        toolTip.ToolTipTitle = "ISV"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtTotal_TextChanged(sender As Object, e As EventArgs) Handles txtTotal.TextChanged

    End Sub

    Private Sub txtTotal_MouseHover(sender As Object, e As EventArgs) Handles txtTotal.MouseHover
        toolTip.SetToolTip(txtTotal, "Muestra el valor total de la venta")
        toolTip.ToolTipTitle = "Total"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub chkDescuento_MouseHover(sender As Object, e As EventArgs) Handles chkDescuento.MouseHover
        toolTip.SetToolTip(chkDescuento, "Seleccione un tipo de descuento")
        toolTip.ToolTipTitle = "Descuento"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub chkISV_MouseHover(sender As Object, e As EventArgs) Handles chkISV.MouseHover
        toolTip.SetToolTip(chkISV, "Seleccione un tipo de impuesto")
        toolTip.ToolTipTitle = "Impuesto"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtPrecio_Validating(sender As Object, e As CancelEventArgs) Handles txtPrecio.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Ingrese un precio")
        End If
    End Sub

    Private Sub txtCantidad_Validating(sender As Object, e As CancelEventArgs) Handles txtCantidad.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Ingrese una cantidad")
        End If
    End Sub
End Class