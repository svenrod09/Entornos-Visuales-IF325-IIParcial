<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class facturaSencilla
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.chkDescuento = New System.Windows.Forms.CheckBox()
        Me.cmbDescuento = New System.Windows.Forms.ComboBox()
        Me.chkISV = New System.Windows.Forms.CheckBox()
        Me.cmbISV = New System.Windows.Forms.ComboBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.txtDescuento = New System.Windows.Forms.TextBox()
        Me.txtISV = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.errorValidacion = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.errorValidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Datos Requeridos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Precio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cantidad"
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(85, 47)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecio.TabIndex = 3
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(85, 93)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(100, 20)
        Me.txtCantidad.TabIndex = 4
        '
        'chkDescuento
        '
        Me.chkDescuento.AutoSize = True
        Me.chkDescuento.Location = New System.Drawing.Point(45, 131)
        Me.chkDescuento.Name = "chkDescuento"
        Me.chkDescuento.Size = New System.Drawing.Size(113, 17)
        Me.chkDescuento.TabIndex = 5
        Me.chkDescuento.Text = "Aplicar Descuento"
        Me.chkDescuento.UseVisualStyleBackColor = True
        '
        'cmbDescuento
        '
        Me.cmbDescuento.Enabled = False
        Me.cmbDescuento.FormattingEnabled = True
        Me.cmbDescuento.Items.AddRange(New Object() {"Tercera Edad (50%)", "Promocional (25%)", "Tarjeta de Crédito (20%)", "Estudiante (15%)", "Por Cantidad (10%)", "Fijo (5%)"})
        Me.cmbDescuento.Location = New System.Drawing.Point(45, 154)
        Me.cmbDescuento.Name = "cmbDescuento"
        Me.cmbDescuento.Size = New System.Drawing.Size(121, 21)
        Me.cmbDescuento.TabIndex = 6
        Me.cmbDescuento.Text = "Seleccione una opción"
        '
        'chkISV
        '
        Me.chkISV.AutoSize = True
        Me.chkISV.Location = New System.Drawing.Point(45, 190)
        Me.chkISV.Name = "chkISV"
        Me.chkISV.Size = New System.Drawing.Size(78, 17)
        Me.chkISV.TabIndex = 7
        Me.chkISV.Text = "Aplicar ISV"
        Me.chkISV.UseVisualStyleBackColor = True
        '
        'cmbISV
        '
        Me.cmbISV.Enabled = False
        Me.cmbISV.FormattingEnabled = True
        Me.cmbISV.Items.AddRange(New Object() {"15%", "17%"})
        Me.cmbISV.Location = New System.Drawing.Point(45, 213)
        Me.cmbISV.Name = "cmbISV"
        Me.cmbISV.Size = New System.Drawing.Size(121, 21)
        Me.cmbISV.TabIndex = 8
        Me.cmbISV.Text = "Seleccione una opción"
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(216, 90)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 9
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Enabled = False
        Me.btnNuevo.Location = New System.Drawing.Point(216, 152)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 10
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(215, 211)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 11
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 246)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Detalle Factura"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 280)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Sub-Total"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 324)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Descuento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(37, 361)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "ISV"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(30, 398)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Total"
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Location = New System.Drawing.Point(85, 277)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.ReadOnly = True
        Me.txtSubtotal.Size = New System.Drawing.Size(100, 20)
        Me.txtSubtotal.TabIndex = 17
        '
        'txtDescuento
        '
        Me.txtDescuento.Location = New System.Drawing.Point(85, 321)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.ReadOnly = True
        Me.txtDescuento.Size = New System.Drawing.Size(100, 20)
        Me.txtDescuento.TabIndex = 18
        '
        'txtISV
        '
        Me.txtISV.Location = New System.Drawing.Point(85, 358)
        Me.txtISV.Name = "txtISV"
        Me.txtISV.ReadOnly = True
        Me.txtISV.Size = New System.Drawing.Size(100, 20)
        Me.txtISV.TabIndex = 19
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(85, 395)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 20
        '
        'errorValidacion
        '
        Me.errorValidacion.ContainerControl = Me
        '
        'facturaSencilla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(303, 447)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtISV)
        Me.Controls.Add(Me.txtDescuento)
        Me.Controls.Add(Me.txtSubtotal)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.cmbISV)
        Me.Controls.Add(Me.chkISV)
        Me.Controls.Add(Me.cmbDescuento)
        Me.Controls.Add(Me.chkDescuento)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "facturaSencilla"
        Me.Text = "facturaSencilla"
        CType(Me.errorValidacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents chkDescuento As CheckBox
    Friend WithEvents cmbDescuento As ComboBox
    Friend WithEvents chkISV As CheckBox
    Friend WithEvents cmbISV As ComboBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents txtDescuento As TextBox
    Friend WithEvents txtISV As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents toolTip As ToolTip
    Friend WithEvents errorValidacion As ErrorProvider
End Class
