<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegistroProductos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistroProductos))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtDocena = New System.Windows.Forms.TextBox()
        Me.txtPrecio1 = New System.Windows.Forms.TextBox()
        Me.txtNombre1 = New System.Windows.Forms.TextBox()
        Me.txtCodigo1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chkDescuento = New System.Windows.Forms.CheckBox()
        Me.errorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmbProductos = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenúToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmbDescuento = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.errorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.txtPrecio)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 109)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(230, 155)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registro de Producto"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(96, 31)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigo.TabIndex = 4
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(96, 113)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecio.TabIndex = 6
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(96, 72)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Precio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código"
        '
        'btnRegistrar
        '
        Me.btnRegistrar.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnRegistrar.BackgroundImage = CType(resources.GetObject("btnRegistrar.BackgroundImage"), System.Drawing.Image)
        Me.btnRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrar.Location = New System.Drawing.Point(282, 119)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(63, 61)
        Me.btnRegistrar.TabIndex = 1
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackgroundImage = CType(resources.GetObject("btnLimpiar.BackgroundImage"), System.Drawing.Image)
        Me.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnLimpiar.Location = New System.Drawing.Point(282, 196)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(63, 61)
        Me.btnLimpiar.TabIndex = 2
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnSalir.BackgroundImage = CType(resources.GetObject("btnSalir.BackgroundImage"), System.Drawing.Image)
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSalir.Location = New System.Drawing.Point(556, 383)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(99, 43)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtDocena)
        Me.GroupBox2.Controls.Add(Me.txtPrecio1)
        Me.GroupBox2.Controls.Add(Me.txtNombre1)
        Me.GroupBox2.Controls.Add(Me.txtCodigo1)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(390, 109)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(265, 212)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalles Producto"
        '
        'txtDocena
        '
        Me.txtDocena.Enabled = False
        Me.txtDocena.Location = New System.Drawing.Point(133, 177)
        Me.txtDocena.Name = "txtDocena"
        Me.txtDocena.ReadOnly = True
        Me.txtDocena.Size = New System.Drawing.Size(100, 20)
        Me.txtDocena.TabIndex = 7
        '
        'txtPrecio1
        '
        Me.txtPrecio1.Enabled = False
        Me.txtPrecio1.Location = New System.Drawing.Point(133, 130)
        Me.txtPrecio1.Name = "txtPrecio1"
        Me.txtPrecio1.ReadOnly = True
        Me.txtPrecio1.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecio1.TabIndex = 6
        '
        'txtNombre1
        '
        Me.txtNombre1.Enabled = False
        Me.txtNombre1.Location = New System.Drawing.Point(133, 84)
        Me.txtNombre1.Name = "txtNombre1"
        Me.txtNombre1.ReadOnly = True
        Me.txtNombre1.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre1.TabIndex = 5
        '
        'txtCodigo1
        '
        Me.txtCodigo1.Enabled = False
        Me.txtCodigo1.Location = New System.Drawing.Point(133, 40)
        Me.txtCodigo1.Name = "txtCodigo1"
        Me.txtCodigo1.ReadOnly = True
        Me.txtCodigo1.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigo1.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 180)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Precio por Docena"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 133)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Precio Producto"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Nombre Producto"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Código Producto"
        '
        'chkDescuento
        '
        Me.chkDescuento.AutoSize = True
        Me.chkDescuento.Location = New System.Drawing.Point(22, 285)
        Me.chkDescuento.Name = "chkDescuento"
        Me.chkDescuento.Size = New System.Drawing.Size(172, 17)
        Me.chkDescuento.TabIndex = 5
        Me.chkDescuento.Text = "Aplicar Descuento por Docena"
        Me.chkDescuento.UseVisualStyleBackColor = True
        '
        'errorProvider
        '
        Me.errorProvider.ContainerControl = Me
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmbProductos)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 334)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(515, 83)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Listado de Productos"
        '
        'cmbProductos
        '
        Me.cmbProductos.FormattingEnabled = True
        Me.cmbProductos.Location = New System.Drawing.Point(33, 39)
        Me.cmbProductos.Name = "cmbProductos"
        Me.cmbProductos.Size = New System.Drawing.Size(458, 21)
        Me.cmbProductos.TabIndex = 0
        Me.cmbProductos.Text = "Ver productos..."
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenúToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(666, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenúToolStripMenuItem
        '
        Me.MenúToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.MenúToolStripMenuItem.Name = "MenúToolStripMenuItem"
        Me.MenúToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenúToolStripMenuItem.Text = "Menú"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(96, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'cmbDescuento
        '
        Me.cmbDescuento.Enabled = False
        Me.cmbDescuento.FormattingEnabled = True
        Me.cmbDescuento.Items.AddRange(New Object() {"10%", "15%"})
        Me.cmbDescuento.Location = New System.Drawing.Point(212, 283)
        Me.cmbDescuento.Name = "cmbDescuento"
        Me.cmbDescuento.Size = New System.Drawing.Size(121, 21)
        Me.cmbDescuento.TabIndex = 8
        Me.cmbDescuento.Text = "Seleccione el tipo de descuento"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(69, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(544, 42)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "REGISTRO DE PRODUCTOS"
        '
        'RegistroProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(666, 438)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmbDescuento)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.chkDescuento)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "RegistroProductos"
        Me.Text = "RegistroProductos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.errorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDocena As TextBox
    Friend WithEvents txtPrecio1 As TextBox
    Friend WithEvents txtNombre1 As TextBox
    Friend WithEvents txtCodigo1 As TextBox
    Friend WithEvents chkDescuento As CheckBox
    Friend WithEvents errorProvider As ErrorProvider
    Friend WithEvents toolTip As ToolTip
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cmbProductos As ComboBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenúToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cmbDescuento As ComboBox
    Friend WithEvents Label8 As Label
End Class
