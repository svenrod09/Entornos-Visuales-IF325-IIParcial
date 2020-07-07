<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ParesImpares
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
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnIniciar = New System.Windows.Forms.Button()
        Me.errorValidacion = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtImpares = New System.Windows.Forms.TextBox()
        Me.txtPares = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSuma = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.errorValidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(227, 243)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 0
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(166, 21)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(100, 20)
        Me.txtCantidad.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cantidad de Números"
        '
        'btnIniciar
        '
        Me.btnIniciar.Location = New System.Drawing.Point(119, 66)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(75, 36)
        Me.btnIniciar.TabIndex = 3
        Me.btnIniciar.Text = "Iniciar"
        Me.btnIniciar.UseVisualStyleBackColor = True
        '
        'errorValidacion
        '
        Me.errorValidacion.ContainerControl = Me
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Cantidad de Impares"
        '
        'txtImpares
        '
        Me.txtImpares.Location = New System.Drawing.Point(33, 154)
        Me.txtImpares.Name = "txtImpares"
        Me.txtImpares.ReadOnly = True
        Me.txtImpares.Size = New System.Drawing.Size(100, 20)
        Me.txtImpares.TabIndex = 5
        '
        'txtPares
        '
        Me.txtPares.Location = New System.Drawing.Point(181, 154)
        Me.txtPares.Name = "txtPares"
        Me.txtPares.ReadOnly = True
        Me.txtPares.Size = New System.Drawing.Size(100, 20)
        Me.txtPares.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(178, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Cantidad de Pares"
        '
        'txtSuma
        '
        Me.txtSuma.Location = New System.Drawing.Point(181, 195)
        Me.txtSuma.Name = "txtSuma"
        Me.txtSuma.ReadOnly = True
        Me.txtSuma.Size = New System.Drawing.Size(100, 20)
        Me.txtSuma.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Suma de los Números"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(11, 243)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 10
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(315, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ParesImpares
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(315, 283)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSuma)
        Me.Controls.Add(Me.txtPares)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtImpares)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnIniciar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ParesImpares"
        Me.Text = "ParesImpares"
        CType(Me.errorValidacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSalir As Button
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnIniciar As Button
    Friend WithEvents errorValidacion As ErrorProvider
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSuma As TextBox
    Friend WithEvents txtPares As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtImpares As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents toolTip As ToolTip
End Class
