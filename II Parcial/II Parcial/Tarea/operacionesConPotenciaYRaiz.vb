Imports System.ComponentModel

Public Class operacionesConPotenciaYRaiz
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtValor1.Clear()
        txtValor2.Clear()
        txtResultado.Clear()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        'Definir variables
        Dim valor1 As Int16
        Dim valor2 As Int16
        'Validar el valor 1
        If txtValor1.Text = "" Then
            MsgBox("Escriba un numero en la casilla", vbInformation)
        ElseIf Not IsNumeric(txtValor1.Text) Then
            MsgBox("Ingrese un valor numerico", vbInformation)
            txtValor1.Text = ""
        ElseIf IsNumeric(valor1) Then
            valor1 = Val(txtValor1.Text)
            If valor1 = 0 Then
                MsgBox("Numero Cero", vbInformation)
            ElseIf valor1 > 0 Then
                MsgBox("Numero positivo", vbInformation)
            ElseIf valor1 < 0 Then
                MsgBox("Numero negativo", vbInformation)
            End If
        End If

        'Validar el valor 2
        If txtValor2.Text = "" Then
            MsgBox("Escriba un numero en la casilla", vbInformation)
        ElseIf Not IsNumeric(txtValor2.Text) Then
            MsgBox("Ingrese un valor numerico", vbInformation)
            txtValor2.Text = ""
        ElseIf IsNumeric(valor2) Then
            valor2 = Val(txtValor2.Text)
            If valor2 = 0 Then
                MsgBox("Numero Cero", vbInformation)
            ElseIf valor2 > 0 Then
                MsgBox("Numero positivo", vbInformation)
            ElseIf valor2 < 0 Then
                MsgBox("Numero negativo", vbInformation)
            End If
        End If

        'Verifica que el usuario haya seleccionado una casilla 
        If Me.chkSuma.Checked = False And Me.chkResta.Checked = False And Me.chkMult.Checked = False And Me.chkDiv.Checked = False And Me.chkPot.Checked = False And Me.chkRaiz.Checked = False Then
            MsgBox("Porfavor seleccione una casilla", vbInformation)
        End If

        'Salidas
        If Me.chkSuma.Checked = True Then
            suma(valor1, valor2)
        ElseIf Me.chkResta.Checked = True Then
            resta(valor1, valor2)
        ElseIf Me.chkMult.Checked = True Then
            multiplicar(valor1, valor2)
        ElseIf Me.chkDiv.Checked = True Then
            dividir(valor1, valor2)
            'Verifica si el valor 2 es "0" ya que no se puede dividir entre "0"
            If valor2 = 0 Then
                MsgBox("No se puede dividir entre cero")
            ElseIf valor2 <> 0 Then
                txtResultado.Text = 0
            End If
        ElseIf Me.chkPot.Checked = True Then
            potencia(valor1, valor2)
        ElseIf Me.chkRaiz.Checked = True Then
            raiz(valor1)
        End If
    End Sub

    Private Sub chkSuma_CheckedChanged(sender As Object, e As EventArgs) Handles chkSuma.CheckedChanged

    End Sub
    Private Sub suma(valor1, valor2)
        Dim resultado = valor1 + valor2
        txtResultado.Text = resultado
    End Sub
    Private Sub resta(valor1, valor2)
        Dim resultado = valor1 - valor2
        txtResultado.Text = resultado
    End Sub
    Private Sub multiplicar(valor1, valor2)
        Dim resultado = valor1 * valor2
        txtResultado.Text = resultado
    End Sub
    Private Sub dividir(valor1, valor2)
        Dim resultado = valor1 / valor2
        txtResultado.Text = resultado
    End Sub
    Private Sub potencia(valor1, valor2)
        Dim resultado = valor1 ^ valor2
        txtResultado.Text = resultado
    End Sub
    Private Sub raiz(valor1)
        Dim resultado = valor1 * 0.5
        txtResultado.Text = resultado
    End Sub

    Private Sub txtValor1_TextChanged(sender As Object, e As EventArgs) Handles txtValor1.TextChanged

    End Sub

    Private Sub txtValor1_MouseHover(sender As Object, e As EventArgs) Handles txtValor1.MouseHover
        toolTip.SetToolTip(txtValor1, "Ingrese un valor númerico")
        toolTip.ToolTipTitle = "Valor 1"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtValor2_TextChanged(sender As Object, e As EventArgs) Handles txtValor2.TextChanged

    End Sub

    Private Sub txtValor2_MouseHover(sender As Object, e As EventArgs) Handles txtValor2.MouseHover
        toolTip.SetToolTip(txtValor2, "Ingrese un valor númerico")
        toolTip.ToolTipTitle = "Valor 2"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtResultado_TextChanged(sender As Object, e As EventArgs) Handles txtResultado.TextChanged

    End Sub

    Private Sub txtResultado_MouseHover(sender As Object, e As EventArgs) Handles txtResultado.MouseHover
        toolTip.SetToolTip(txtResultado, "Muestra el resultado de la operación seleccionada")
        toolTip.ToolTipTitle = "Resultado"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtValor1_Validating(sender As Object, e As CancelEventArgs) Handles txtValor1.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Ingrese un valor númerico entero")
        End If
    End Sub

    Private Sub txtValor2_Validating(sender As Object, e As CancelEventArgs) Handles txtValor2.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Ingrese un valor númerico entero")
        End If
    End Sub
End Class