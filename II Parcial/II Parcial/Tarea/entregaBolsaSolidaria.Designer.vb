<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class entregaBolsaSolidaria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(entregaBolsaSolidaria))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkExtremaPobreza = New System.Windows.Forms.CheckBox()
        Me.chkPobreza = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtZona = New System.Windows.Forms.TextBox()
        Me.txtIntegrantes = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMunicipio = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbDepartamento = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIdentidad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnVerificar = New System.Windows.Forms.Button()
        Me.btnEntregar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.errorValidacion = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbTipodeBolsa = New System.Windows.Forms.ComboBox()
        Me.dgvRegistro = New System.Windows.Forms.DataGridView()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Departamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Municipio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Integrantes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.errorValidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRegistro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbTipodeBolsa)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.chkExtremaPobreza)
        Me.GroupBox1.Controls.Add(Me.chkPobreza)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtZona)
        Me.GroupBox1.Controls.Add(Me.txtIntegrantes)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtMunicipio)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmbDepartamento)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtIdentidad)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(348, 367)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso de Datos"
        '
        'chkExtremaPobreza
        '
        Me.chkExtremaPobreza.AutoSize = True
        Me.chkExtremaPobreza.Location = New System.Drawing.Point(231, 291)
        Me.chkExtremaPobreza.Name = "chkExtremaPobreza"
        Me.chkExtremaPobreza.Size = New System.Drawing.Size(106, 17)
        Me.chkExtremaPobreza.TabIndex = 14
        Me.chkExtremaPobreza.Text = "Extrema Pobreza"
        Me.chkExtremaPobreza.UseVisualStyleBackColor = True
        '
        'chkPobreza
        '
        Me.chkPobreza.AutoSize = True
        Me.chkPobreza.Location = New System.Drawing.Point(152, 290)
        Me.chkPobreza.Name = "chkPobreza"
        Me.chkPobreza.Size = New System.Drawing.Size(65, 17)
        Me.chkPobreza.TabIndex = 13
        Me.chkPobreza.Text = "Pobreza"
        Me.chkPobreza.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 291)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Estado"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 205)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Zona de Residencia"
        '
        'txtZona
        '
        Me.txtZona.Location = New System.Drawing.Point(152, 202)
        Me.txtZona.Name = "txtZona"
        Me.txtZona.Size = New System.Drawing.Size(158, 20)
        Me.txtZona.TabIndex = 10
        '
        'txtIntegrantes
        '
        Me.txtIntegrantes.Location = New System.Drawing.Point(152, 245)
        Me.txtIntegrantes.Name = "txtIntegrantes"
        Me.txtIntegrantes.Size = New System.Drawing.Size(100, 20)
        Me.txtIntegrantes.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 248)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Integrantes de Familia"
        '
        'txtMunicipio
        '
        Me.txtMunicipio.Location = New System.Drawing.Point(152, 159)
        Me.txtMunicipio.Name = "txtMunicipio"
        Me.txtMunicipio.Size = New System.Drawing.Size(158, 20)
        Me.txtMunicipio.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Municipio"
        '
        'cmbDepartamento
        '
        Me.cmbDepartamento.FormattingEnabled = True
        Me.cmbDepartamento.Items.AddRange(New Object() {"Atlántida", "Choluteca", "Colón", "Comayagua", "Copán", "Cortés", "El Paraíso", "Francisco Morazán", "Gracias a Dios", "Intibucá", "Islas de la Bahía", "La Paz", "Lempira", "Olancho", "Ocotepeque", "Santa Bárbara", "Valle", "Yoro"})
        Me.cmbDepartamento.Location = New System.Drawing.Point(152, 115)
        Me.cmbDepartamento.Name = "cmbDepartamento"
        Me.cmbDepartamento.Size = New System.Drawing.Size(158, 21)
        Me.cmbDepartamento.TabIndex = 5
        Me.cmbDepartamento.Text = "Seleccione un Departamento"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Departamento"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(152, 72)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(158, 20)
        Me.txtNombre.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre Completo"
        '
        'txtIdentidad
        '
        Me.txtIdentidad.Location = New System.Drawing.Point(152, 31)
        Me.txtIdentidad.Name = "txtIdentidad"
        Me.txtIdentidad.Size = New System.Drawing.Size(158, 20)
        Me.txtIdentidad.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Identidad"
        '
        'btnVerificar
        '
        Me.btnVerificar.Location = New System.Drawing.Point(383, 116)
        Me.btnVerificar.Name = "btnVerificar"
        Me.btnVerificar.Size = New System.Drawing.Size(75, 23)
        Me.btnVerificar.TabIndex = 1
        Me.btnVerificar.Text = "Verificar"
        Me.btnVerificar.UseVisualStyleBackColor = True
        '
        'btnEntregar
        '
        Me.btnEntregar.Location = New System.Drawing.Point(383, 164)
        Me.btnEntregar.Name = "btnEntregar"
        Me.btnEntregar.Size = New System.Drawing.Size(75, 23)
        Me.btnEntregar.TabIndex = 2
        Me.btnEntregar.Text = "Entregar"
        Me.btnEntregar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(383, 213)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 3
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'errorValidacion
        '
        Me.errorValidacion.ContainerControl = Me
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 331)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Tipo de Bolsa"
        '
        'cmbTipodeBolsa
        '
        Me.cmbTipodeBolsa.FormattingEnabled = True
        Me.cmbTipodeBolsa.Items.AddRange(New Object() {"Básica (azúcar, manteca, avena, harina de maíz, café, cereal fortificado, espague" &
                "ti, arroz blanco, frijoles, y kit de medicamentos del cuadro básico)", resources.GetString("cmbTipodeBolsa.Items")})
        Me.cmbTipodeBolsa.Location = New System.Drawing.Point(152, 328)
        Me.cmbTipodeBolsa.Name = "cmbTipodeBolsa"
        Me.cmbTipodeBolsa.Size = New System.Drawing.Size(158, 21)
        Me.cmbTipodeBolsa.TabIndex = 16
        '
        'dgvRegistro
        '
        Me.dgvRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRegistro.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.Nombre, Me.Departamento, Me.Municipio, Me.Direccion, Me.Integrantes})
        Me.dgvRegistro.Location = New System.Drawing.Point(487, 12)
        Me.dgvRegistro.Name = "dgvRegistro"
        Me.dgvRegistro.Size = New System.Drawing.Size(297, 367)
        Me.dgvRegistro.TabIndex = 4
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(724, 398)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'id
        '
        Me.id.HeaderText = "Identidad"
        Me.id.Name = "id"
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        '
        'Departamento
        '
        Me.Departamento.HeaderText = "Departamento"
        Me.Departamento.Name = "Departamento"
        '
        'Municipio
        '
        Me.Municipio.HeaderText = "Municipio"
        Me.Municipio.Name = "Municipio"
        '
        'Direccion
        '
        Me.Direccion.HeaderText = "Zona de Residencia"
        Me.Direccion.Name = "Direccion"
        '
        'Integrantes
        '
        Me.Integrantes.HeaderText = "Integrantes de la familia"
        Me.Integrantes.Name = "Integrantes"
        '
        'entregaBolsaSolidaria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 433)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.dgvRegistro)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnEntregar)
        Me.Controls.Add(Me.btnVerificar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "entregaBolsaSolidaria"
        Me.Text = "entregaBolsaSolidaria"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.errorValidacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRegistro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkExtremaPobreza As CheckBox
    Friend WithEvents chkPobreza As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtZona As TextBox
    Friend WithEvents txtIntegrantes As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMunicipio As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbDepartamento As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtIdentidad As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnVerificar As Button
    Friend WithEvents btnEntregar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents toolTip As ToolTip
    Friend WithEvents errorValidacion As ErrorProvider
    Friend WithEvents cmbTipodeBolsa As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents dgvRegistro As DataGridView
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Departamento As DataGridViewTextBoxColumn
    Friend WithEvents Municipio As DataGridViewTextBoxColumn
    Friend WithEvents Direccion As DataGridViewTextBoxColumn
    Friend WithEvents Integrantes As DataGridViewTextBoxColumn
End Class
