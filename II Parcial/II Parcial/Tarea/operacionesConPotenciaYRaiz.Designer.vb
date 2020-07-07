<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class operacionesConPotenciaYRaiz
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
        Me.txtValor1 = New System.Windows.Forms.TextBox()
        Me.txtValor2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkSuma = New System.Windows.Forms.CheckBox()
        Me.chkResta = New System.Windows.Forms.CheckBox()
        Me.chkMult = New System.Windows.Forms.CheckBox()
        Me.chkDiv = New System.Windows.Forms.CheckBox()
        Me.chkPot = New System.Windows.Forms.CheckBox()
        Me.chkRaiz = New System.Windows.Forms.CheckBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.errorValidacion = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.errorValidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Valor 1"
        '
        'txtValor1
        '
        Me.txtValor1.Location = New System.Drawing.Point(116, 30)
        Me.txtValor1.Name = "txtValor1"
        Me.txtValor1.Size = New System.Drawing.Size(100, 20)
        Me.txtValor1.TabIndex = 1
        '
        'txtValor2
        '
        Me.txtValor2.Location = New System.Drawing.Point(116, 77)
        Me.txtValor2.Name = "txtValor2"
        Me.txtValor2.Size = New System.Drawing.Size(100, 20)
        Me.txtValor2.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Valor 2"
        '
        'chkSuma
        '
        Me.chkSuma.AutoSize = True
        Me.chkSuma.Location = New System.Drawing.Point(44, 128)
        Me.chkSuma.Name = "chkSuma"
        Me.chkSuma.Size = New System.Drawing.Size(53, 17)
        Me.chkSuma.TabIndex = 4
        Me.chkSuma.Text = "Suma"
        Me.chkSuma.UseVisualStyleBackColor = True
        '
        'chkResta
        '
        Me.chkResta.AutoSize = True
        Me.chkResta.Location = New System.Drawing.Point(44, 160)
        Me.chkResta.Name = "chkResta"
        Me.chkResta.Size = New System.Drawing.Size(54, 17)
        Me.chkResta.TabIndex = 5
        Me.chkResta.Text = "Resta"
        Me.chkResta.UseVisualStyleBackColor = True
        '
        'chkMult
        '
        Me.chkMult.AutoSize = True
        Me.chkMult.Location = New System.Drawing.Point(44, 192)
        Me.chkMult.Name = "chkMult"
        Me.chkMult.Size = New System.Drawing.Size(90, 17)
        Me.chkMult.TabIndex = 6
        Me.chkMult.Text = "Multiplicación"
        Me.chkMult.UseVisualStyleBackColor = True
        '
        'chkDiv
        '
        Me.chkDiv.AutoSize = True
        Me.chkDiv.Location = New System.Drawing.Point(153, 128)
        Me.chkDiv.Name = "chkDiv"
        Me.chkDiv.Size = New System.Drawing.Size(63, 17)
        Me.chkDiv.TabIndex = 7
        Me.chkDiv.Text = "División"
        Me.chkDiv.UseVisualStyleBackColor = True
        '
        'chkPot
        '
        Me.chkPot.AutoSize = True
        Me.chkPot.Location = New System.Drawing.Point(153, 160)
        Me.chkPot.Name = "chkPot"
        Me.chkPot.Size = New System.Drawing.Size(68, 17)
        Me.chkPot.TabIndex = 8
        Me.chkPot.Text = "Potencia"
        Me.chkPot.UseVisualStyleBackColor = True
        '
        'chkRaiz
        '
        Me.chkRaiz.AutoSize = True
        Me.chkRaiz.Location = New System.Drawing.Point(153, 192)
        Me.chkRaiz.Name = "chkRaiz"
        Me.chkRaiz.Size = New System.Drawing.Size(49, 17)
        Me.chkRaiz.TabIndex = 9
        Me.chkRaiz.Text = "Raíz"
        Me.chkRaiz.UseVisualStyleBackColor = True
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(92, 229)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 10
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 275)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Resultado"
        '
        'txtResultado
        '
        Me.txtResultado.Enabled = False
        Me.txtResultado.Location = New System.Drawing.Point(116, 272)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(100, 20)
        Me.txtResultado.TabIndex = 12
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(23, 300)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 13
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(170, 300)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 14
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'errorValidacion
        '
        Me.errorValidacion.ContainerControl = Me
        '
        'operacionesConPotenciaYRaiz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(270, 335)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.chkRaiz)
        Me.Controls.Add(Me.chkPot)
        Me.Controls.Add(Me.chkDiv)
        Me.Controls.Add(Me.chkMult)
        Me.Controls.Add(Me.chkResta)
        Me.Controls.Add(Me.chkSuma)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtValor2)
        Me.Controls.Add(Me.txtValor1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "operacionesConPotenciaYRaiz"
        Me.Text = "operacionesConPotenciaYRaiz"
        CType(Me.errorValidacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtValor1 As TextBox
    Friend WithEvents txtValor2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents chkSuma As CheckBox
    Friend WithEvents chkResta As CheckBox
    Friend WithEvents chkMult As CheckBox
    Friend WithEvents chkDiv As CheckBox
    Friend WithEvents chkPot As CheckBox
    Friend WithEvents chkRaiz As CheckBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents toolTip As ToolTip
    Friend WithEvents errorValidacion As ErrorProvider
End Class
