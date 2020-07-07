<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuTareas
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.btnBolsaSolidaria = New System.Windows.Forms.Button()
        Me.btnParImpar = New System.Windows.Forms.Button()
        Me.btnRegistroProductos = New System.Windows.Forms.Button()
        Me.btnFactura = New System.Windows.Forms.Button()
        Me.btnOperaciones = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(82, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(446, 59)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ejercicios de Tarea"
        '
        'btnRegresar
        '
        Me.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegresar.FlatAppearance.BorderSize = 0
        Me.btnRegresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegresar.Font = New System.Drawing.Font("Montserrat SemiBold", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegresar.Image = Global.II_Parcial.My.Resources.Resources.backleftarrowcurvesymbol_79785
        Me.btnRegresar.Location = New System.Drawing.Point(504, 312)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(104, 41)
        Me.btnRegresar.TabIndex = 1
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'btnBolsaSolidaria
        '
        Me.btnBolsaSolidaria.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnBolsaSolidaria.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBolsaSolidaria.Location = New System.Drawing.Point(92, 108)
        Me.btnBolsaSolidaria.Name = "btnBolsaSolidaria"
        Me.btnBolsaSolidaria.Size = New System.Drawing.Size(80, 36)
        Me.btnBolsaSolidaria.TabIndex = 2
        Me.btnBolsaSolidaria.Text = "Bolsa Solidaria"
        Me.btnBolsaSolidaria.UseVisualStyleBackColor = True
        '
        'btnParImpar
        '
        Me.btnParImpar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnParImpar.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnParImpar.Location = New System.Drawing.Point(204, 108)
        Me.btnParImpar.Name = "btnParImpar"
        Me.btnParImpar.Size = New System.Drawing.Size(80, 36)
        Me.btnParImpar.TabIndex = 3
        Me.btnParImpar.Text = "Pares e Impares"
        Me.btnParImpar.UseVisualStyleBackColor = True
        '
        'btnRegistroProductos
        '
        Me.btnRegistroProductos.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnRegistroProductos.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistroProductos.Location = New System.Drawing.Point(319, 108)
        Me.btnRegistroProductos.Name = "btnRegistroProductos"
        Me.btnRegistroProductos.Size = New System.Drawing.Size(80, 36)
        Me.btnRegistroProductos.TabIndex = 4
        Me.btnRegistroProductos.Text = "Registro de Productos"
        Me.btnRegistroProductos.UseVisualStyleBackColor = True
        '
        'btnFactura
        '
        Me.btnFactura.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnFactura.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFactura.Location = New System.Drawing.Point(434, 108)
        Me.btnFactura.Name = "btnFactura"
        Me.btnFactura.Size = New System.Drawing.Size(80, 36)
        Me.btnFactura.TabIndex = 5
        Me.btnFactura.Text = "Factura Sencilla"
        Me.btnFactura.UseVisualStyleBackColor = True
        '
        'btnOperaciones
        '
        Me.btnOperaciones.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnOperaciones.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOperaciones.Location = New System.Drawing.Point(92, 177)
        Me.btnOperaciones.Name = "btnOperaciones"
        Me.btnOperaciones.Size = New System.Drawing.Size(80, 36)
        Me.btnOperaciones.TabIndex = 6
        Me.btnOperaciones.Text = "Operaciones Matemáticas"
        Me.btnOperaciones.UseVisualStyleBackColor = True
        '
        'MenuTareas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(620, 365)
        Me.Controls.Add(Me.btnOperaciones)
        Me.Controls.Add(Me.btnFactura)
        Me.Controls.Add(Me.btnRegistroProductos)
        Me.Controls.Add(Me.btnParImpar)
        Me.Controls.Add(Me.btnBolsaSolidaria)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MenuTareas"
        Me.Text = "MenuTareas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnRegresar As Button
    Friend WithEvents btnBolsaSolidaria As Button
    Friend WithEvents btnParImpar As Button
    Friend WithEvents btnRegistroProductos As Button
    Friend WithEvents btnFactura As Button
    Friend WithEvents btnOperaciones As Button
End Class
