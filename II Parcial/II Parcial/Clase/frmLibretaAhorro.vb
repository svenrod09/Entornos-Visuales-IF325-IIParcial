Imports System.ComponentModel

Public Class frmLibretaAhorro
    Private monto As Double
    'Procedimientos
    Private Sub activarControles()
        txtIdentidad.Enabled = False
        txtNombre.Enabled = False
        btnAperturar.Enabled = False
        txtMonto.Enabled() = True
        btnRetirar.Enabled = True
        btnDepositar.Enabled = True
        btnRegistrar.Enabled = False
        txtCiudad.Enabled = False
        txtEdad.Enabled = False
        txtSaldoApertura.Enabled = False
        cmbInteres.Enabled = False
    End Sub

    Private Sub desactivarControles()
        txtIdentidad.Enabled = True
        txtNombre.Enabled = True
        txtEdad.Enabled = True
        txtCiudad.Enabled = True
        cmbInteres.Enabled = True
        btnAperturar.Enabled = False
        btnRegistrar.Enabled = True
        txtMonto.Enabled = False
        btnRetirar.Enabled = False
        btnDepositar.Enabled = False
    End Sub

    Private Sub limpiar()
        desactivarControles()
        txtCiudad.Clear()
        txtEdad.Clear()
        txtNombre.Clear()
        txtSaldoApertura.Clear()
        txtIdentidad.Clear()
        txtSaldo.Clear()
        txtNombre.Clear()
        lstDepositos.Items.Clear()
        lstRetiros.Items.Clear()
    End Sub

    Private Sub frmLibretaAhorro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        desactivarControles()
    End Sub

    Private Sub mostrarSaldo()
        txtSaldo.Text = monto
    End Sub

    Private Sub btnAperturar_Click(sender As Object, e As EventArgs) Handles btnAperturar.Click
        Dim cliente As String
        cliente = txtIdentidad.Text
        monto = Val(txtNombre.Text)
        If (monto > 0 And validarRegistro(cliente) = 1) Then
            activarControles()
        Else
            MessageBox.Show("Monto mayor a 0", "Ingresar monto correcto", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function leer(mensaje As String)
        Dim cantidad As Double
        cantidad = InputBox("Ingrese un monto a " & mensaje, "Operación")
        mostrarSaldo()
        Return cantidad
    End Function

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub

    Private Sub btnDepositar_Click(sender As Object, e As EventArgs) Handles btnDepositar.Click
        Dim deposito As Double
        deposito = leer("Depositar")
        monto += deposito
        lstDepositos.Items.Add(deposito)
        mostrarSaldo()
    End Sub

    Private Sub btnRetirar_Click(sender As Object, e As EventArgs) Handles btnRetirar.Click
        Dim retiro As Double
        retiro = leer("Retirar")
        If (retiro > monto) Then
            MessageBox.Show("Saldo insuficiente", "Deposite mas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            monto -= retiro
            lstRetiros.Items.Add(retiro)
            mostrarSaldo()
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim cliente As String
        cliente = txtIdentidad.Text
        If Me.ValidateChildren And txtIdentidad.Text <> String.Empty And txtIdentidad.TextLength = 13 And txtNombre.Text <> String.Empty And txtEdad.Text <> String.Empty And txtSaldoApertura.Text <> String.Empty And Val(txtSaldoApertura.Text) >= 1000 Then
            If (validarRegistro(cliente) = 0) Then
                MsgBox("Cliente Registrado con éxito", vbInformation)
                activarControles()
            Else
                MsgBox("El cliente ya existe", vbInformation)
                activarControles()
                limpiar()
            End If
        Else
            MsgBox("Error al ingresar los datos", vbInformation)
        End If
    End Sub
    Private Function validarRegistro(idBuscada As String)
        Dim identidades(50) As String
        Dim encontrado As Integer
        For i = 1 To 50 Step 1
            If (idBuscada = identidades(i)) Then
                encontrado = 1
            Else
                encontrado = 0
                identidades(i) = idBuscada
                Exit For
            End If
        Next
        Return encontrado
    End Function

    Private Sub txtIdentidad_TextChanged(sender As Object, e As EventArgs) Handles txtIdentidad.TextChanged

    End Sub

    Private Sub txtIdentidad_Validating(sender As Object, e As CancelEventArgs) Handles txtIdentidad.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "No puede dejar campos vacíos")
        End If
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged

    End Sub

    Private Sub txtEdad_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtEdad.MaskInputRejected

    End Sub

    Private Sub txtNombre_Validating(sender As Object, e As CancelEventArgs) Handles txtNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "No puede dejar campos vacíos")
        End If
    End Sub

    Private Sub txtEdad_Validating(sender As Object, e As CancelEventArgs) Handles txtEdad.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "No puede dejar campos vacíos")
        End If
    End Sub

    Private Sub txtCiudad_TextChanged(sender As Object, e As EventArgs) Handles txtCiudad.TextChanged

    End Sub

    Private Sub txtCiudad_Validating(sender As Object, e As CancelEventArgs) Handles txtCiudad.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "No puede dejar campos vacíos")
        End If
    End Sub

    Private Sub txtSaldoApertura_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtSaldoApertura.MaskInputRejected

    End Sub

    Private Sub txtSaldoApertura_Validating(sender As Object, e As CancelEventArgs) Handles txtSaldoApertura.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "No puede dejar campos vacíos")
        End If
    End Sub

    Private Sub txtIdentidad_MouseHover(sender As Object, e As EventArgs) Handles txtIdentidad.MouseHover
        toolTip.SetToolTip(txtIdentidad, "Ingrese la identidad del cliente")
        toolTip.ToolTipTitle = "Identidad"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtNombre_MouseHover(sender As Object, e As EventArgs) Handles txtNombre.MouseHover
        toolTip.SetToolTip(txtNombre, "Ingrese el nombre completo del cliente")
        toolTip.ToolTipTitle = "Nombre"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtEdad_MouseHover(sender As Object, e As EventArgs) Handles txtEdad.MouseHover
        toolTip.SetToolTip(txtEdad, "Ingrese la edad del cliente")
        toolTip.ToolTipTitle = "Edad"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtPais_TextChanged(sender As Object, e As EventArgs) Handles txtPais.TextChanged

    End Sub

    Private Sub txtPais_MouseHover(sender As Object, e As EventArgs) Handles txtPais.MouseHover
        toolTip.SetToolTip(txtPais, "Ingrese el país de residencia del cliente")
        toolTip.ToolTipTitle = "País"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtCiudad_MouseHover(sender As Object, e As EventArgs) Handles txtCiudad.MouseHover
        toolTip.SetToolTip(txtCiudad, "Ingrese el la ciudad de residencia del cliente")
        toolTip.ToolTipTitle = "Ciudad"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtSaldoApertura_MouseHover(sender As Object, e As EventArgs) Handles txtSaldoApertura.MouseHover
        toolTip.SetToolTip(txtSaldoApertura, "Ingrese la cantidad de dinero para aperturar la cuenta (no debe ser inferior a 1000)")
        toolTip.ToolTipTitle = "Saldo de Apertura"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cmbInteres_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbInteres.SelectedIndexChanged

    End Sub

    Private Sub cmbInteres_MouseHover(sender As Object, e As EventArgs) Handles cmbInteres.MouseHover
        toolTip.SetToolTip(cmbInteres, "Ingrese el tipo de interés anual para la cuenta del cliente")
        toolTip.ToolTipTitle = "Intereses"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtMonto_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtMonto.MaskInputRejected

    End Sub

    Private Sub txtMonto_MouseHover(sender As Object, e As EventArgs) Handles txtMonto.MouseHover
        toolTip.SetToolTip(txtMonto, "Ingrese un monto para depositar o retirar")
        toolTip.ToolTipTitle = "Monto"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtSaldo_TextChanged(sender As Object, e As EventArgs) Handles txtSaldo.TextChanged

    End Sub

    Private Sub txtSaldo_MouseHover(sender As Object, e As EventArgs) Handles txtSaldo.MouseHover
        toolTip.SetToolTip(txtSaldo, "Muestra el saldo actual de la cuenta solicitada")
        toolTip.ToolTipTitle = "Saldo"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub lstRetiros_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstRetiros.SelectedIndexChanged

    End Sub

    Private Sub lstRetiros_MouseHover(sender As Object, e As EventArgs) Handles lstRetiros.MouseHover
        toolTip.SetToolTip(lstRetiros, "Muestra el historial de retiros")
        toolTip.ToolTipTitle = "Retiros"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub lstDepositos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstDepositos.SelectedIndexChanged

    End Sub

    Private Sub lstDepositos_MouseHover(sender As Object, e As EventArgs) Handles lstDepositos.MouseHover
        toolTip.SetToolTip(lstDepositos, "Muestra el historial de depósitos")
        toolTip.ToolTipTitle = "Depósitos"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class