Imports System.ComponentModel
Public Class entregaBolsaSolidaria
    Private matrizEntrega(,) As String
    Private identidad As String
    Private cantidadBolsas, contador As Integer
    Private index As Byte
    Private Sub entregaBolsaSolidaria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        desactivarControles()
        cantidadBolsas = 100
    End Sub
    'Verifica si ya se le entregó una bolsa solidaria a la persona
    Private Function verificarEntregado(idBuscada As String) As Integer
        'Definir variables
        Dim seEncontro As Integer
        ReDim matrizEntrega(cantidadBolsas, 5)

        For i = 0 To (cantidadBolsas - 1) Step 1
            If (matrizEntrega(i, 0) = idBuscada) Then
                seEncontro = 1
                MessageBox.Show("Ya se entregó una bolsa a esa persona", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                seEncontro = 0
                index = i
                Exit For
            End If
        Next
        Return seEncontro
    End Function
    'Guarda en el arreglo los datos ingresados
    Private Sub llenarArreglo()
        'Definir Variables
        Dim nombre, departamento, municipio, zonaResidencia As String
        Dim integrantesFamilia As Integer

        'Asigna el valor a las variables
        nombre = txtNombre.Text
        departamento = cmbDepartamento.SelectedItem
        municipio = txtMunicipio.Text
        integrantesFamilia = Val(txtIntegrantes.Text)
        zonaResidencia = txtZona.Text

        'Valida que los campos sean válidos y no estén vacíos
        If Me.ValidateChildren And txtIdentidad.Text <> String.Empty And departamento <> String.Empty And txtNombre.Text <> String.Empty And txtMunicipio.Text <> String.Empty And txtZona.Text <> String.Empty And txtIntegrantes.Text <> String.Empty And Val(txtIntegrantes.Text) <= 99 And IsNumeric(txtIntegrantes.Text) And Val(txtIntegrantes.Text) > 0 Then
            matrizEntrega(index, 0) = identidad
            matrizEntrega(index, 1) = nombre
            matrizEntrega(index, 2) = departamento
            matrizEntrega(index, 3) = municipio
            matrizEntrega(index, 4) = zonaResidencia
            matrizEntrega(index, 5) = integrantesFamilia
            asignarBolsa(integrantesFamilia)
            llenarDataGrid(index)
            limpiar()
        Else
            MessageBox.Show("Error al ingresar los datos", "Ingresar Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    'Asigna el tipo de bolsa que se le entregará a la persona dependiendo del número de integrantes de la familia
    Private Sub asignarBolsa(integrantesFamilia As Integer)
        'Definir variables
        Dim bolsa As String

        'Verifica el número de integrantes de la familia de la persona 
        If (integrantesFamilia <= 3) Then
            cmbTipodeBolsa.SelectedIndex = 0
            bolsa = cmbTipodeBolsa.SelectedItem
            MsgBox("La bolsa asignada es: " & bolsa)
        Else
            cmbTipodeBolsa.SelectedIndex = 1
            bolsa = cmbTipodeBolsa.SelectedItem
            MsgBox("La bolsa asignada es: " & bolsa)
        End If
    End Sub
    'Llena el datagrid con los datos que se almacenaron en el arreglo
    Private Sub llenarDataGrid(contador As Integer)
        dgvRegistro.Rows.Add()
        dgvRegistro(0, contador).Value = matrizEntrega(contador, 0)
        dgvRegistro(1, contador).Value = matrizEntrega(contador, 1)
        dgvRegistro(2, contador).Value = matrizEntrega(contador, 2)
        dgvRegistro(3, contador).Value = matrizEntrega(contador, 3)
        dgvRegistro(4, contador).Value = matrizEntrega(contador, 4)
        dgvRegistro(5, contador).Value = matrizEntrega(contador, 5)
    End Sub
    'Desactiva las cajas de texto, los botones, y las casillas
    Private Sub desactivarControles()
        btnVerificar.Enabled = True
        btnEntregar.Enabled = False
        cmbDepartamento.Enabled = False
        txtNombre.Enabled = False
        txtMunicipio.Enabled = False
        txtZona.Enabled = False
        txtIntegrantes.Enabled = False
        chkPobreza.Enabled = False
        chkExtremaPobreza.Enabled = False
        cmbTipodeBolsa.Enabled = False
    End Sub
    'Activa las cajas de texto, los botones, y las casillas
    Private Sub activarControles()
        btnVerificar.Enabled = False
        btnEntregar.Enabled = True
        cmbDepartamento.Enabled = True
        txtNombre.Enabled = True
        txtMunicipio.Enabled = True
        txtZona.Enabled = True
        txtIntegrantes.Enabled = True
        chkPobreza.Enabled = True
        chkExtremaPobreza.Enabled = True
    End Sub
    'Limpia las cajas de texto y las casillas, para ingresar nuevos datos
    Private Sub limpiar()
        txtIdentidad.Clear()
        txtNombre.Clear()
        txtMunicipio.Clear()
        txtZona.Clear()
        txtIntegrantes.Clear()
        chkPobreza.Checked = False
        chkExtremaPobreza.Checked = False
        desactivarControles()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub

    Private Sub txtIdentidad_TextChanged(sender As Object, e As EventArgs) Handles txtIdentidad.TextChanged

    End Sub

    Private Sub txtIdentidad_MouseHover(sender As Object, e As EventArgs) Handles txtIdentidad.MouseHover
        toolTip.SetToolTip(txtIdentidad, "Ingrese un número de identidad válido")
        toolTip.ToolTipTitle = "Identidad"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged

    End Sub

    Private Sub txtNombre_MouseHover(sender As Object, e As EventArgs) Handles txtNombre.MouseHover
        toolTip.SetToolTip(txtNombre, "Ingrese el nombre de la persona")
        toolTip.ToolTipTitle = "Nombre"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtMunicipio_TextChanged(sender As Object, e As EventArgs) Handles txtMunicipio.TextChanged
    End Sub

    Private Sub txtMunicipio_MouseHover(sender As Object, e As EventArgs) Handles txtMunicipio.MouseHover
        toolTip.SetToolTip(txtMunicipio, "Ingrese el municipio de residencia de la persona")
        toolTip.ToolTipTitle = "Municipio"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtZona_TextChanged(sender As Object, e As EventArgs) Handles txtZona.TextChanged

    End Sub

    Private Sub txtZona_MouseHover(sender As Object, e As EventArgs) Handles txtZona.MouseHover
        toolTip.SetToolTip(txtZona, "Ingrese el barrio o colonia donde vive la persona")
        toolTip.ToolTipTitle = "Zona de Residencia"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtIntegrantes_TextChanged(sender As Object, e As EventArgs) Handles txtIntegrantes.TextChanged

    End Sub

    Private Sub txtIntegrantes_MouseHover(sender As Object, e As EventArgs) Handles txtIntegrantes.MouseHover
        toolTip.SetToolTip(txtIntegrantes, "Ingrese el número de integrantes de la familia de la persona")
        toolTip.ToolTipTitle = "Integrantes de la Familia"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cmbDepartamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDepartamento.SelectedIndexChanged

    End Sub

    Private Sub cmbDepartamento_MouseHover(sender As Object, e As EventArgs) Handles cmbDepartamento.MouseHover
        toolTip.SetToolTip(cmbDepartamento, "Seleccione el departamento de residencia de la persona")
        toolTip.ToolTipTitle = "Departamento"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    'Valida que solo se seleccione una casilla a la vez
    Private Sub chkPobreza_CheckedChanged(sender As Object, e As EventArgs) Handles chkPobreza.CheckedChanged
        If chkPobreza.Checked = True Then
            chkExtremaPobreza.Checked = False
        End If
    End Sub

    Private Sub chkPobreza_MouseHover(sender As Object, e As EventArgs) Handles chkPobreza.MouseHover
        toolTip.SetToolTip(chkPobreza, "Seleccione el estado o situación actual de la persona")
        toolTip.ToolTipTitle = "Estado"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    'Valida que solo se seleccione una casilla a la vez
    Private Sub chkExtremaPobreza_CheckedChanged(sender As Object, e As EventArgs) Handles chkExtremaPobreza.CheckedChanged
        If chkExtremaPobreza.Checked = True Then
            chkPobreza.Checked = False
        End If
    End Sub

    Private Sub chkExtremaPobreza_MouseHover(sender As Object, e As EventArgs) Handles chkExtremaPobreza.MouseHover
        toolTip.SetToolTip(chkExtremaPobreza, "Seleccione el estado o situación actual de la persona")
        toolTip.ToolTipTitle = "Estado"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnVerificar_Click(sender As Object, e As EventArgs) Handles btnVerificar.Click
        'Definir variables
        Dim buscar As Integer

        'Asignar el valor a la variable
        identidad = txtIdentidad.Text

        'Valida que la caja de texto no esté vacía y que su longitud sea de 13 caracteres
        If txtIdentidad.Text <> String.Empty And txtIdentidad.TextLength = 13 Then
            'Llama a la función que busca la identidad en el arreglo
            buscar = verificarEntregado(identidad)

            If buscar = 0 Then
                activarControles()
            End If
        Else
            MessageBox.Show("Error: número de identidad incompleto", "Identidad", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub txtIdentidad_Validating(sender As Object, e As CancelEventArgs) Handles txtIdentidad.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Ingrese el número de identidad de la persona")
        End If
    End Sub

    Private Sub txtNombre_Validating(sender As Object, e As CancelEventArgs) Handles txtNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Ingrese el nombre de la persona")
        End If
    End Sub

    Private Sub txtMunicipio_Validating(sender As Object, e As CancelEventArgs) Handles txtMunicipio.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Ingrese el municipio donde reside la persona")
        End If
    End Sub

    Private Sub txtZona_Validating(sender As Object, e As CancelEventArgs) Handles txtZona.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Ingrese el barrio o colonia donde vive la persona")
        End If
    End Sub

    Private Sub txtIntegrantes_Validating(sender As Object, e As CancelEventArgs) Handles txtIntegrantes.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Ingrese el número de integrantes que tiene la familia de la persona")
        End If
    End Sub

    Private Sub btnEntregar_Click(sender As Object, e As EventArgs) Handles btnEntregar.Click
        llenarArreglo()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class