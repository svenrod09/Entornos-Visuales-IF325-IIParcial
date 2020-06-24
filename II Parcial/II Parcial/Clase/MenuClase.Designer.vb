<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuClase
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
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.btnArreglos = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnMenu
        '
        Me.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnMenu.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenu.Location = New System.Drawing.Point(60, 103)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(97, 33)
        Me.btnMenu.TabIndex = 0
        Me.btnMenu.Text = "Ejemplo de un Menu"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'btnArreglos
        '
        Me.btnArreglos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnArreglos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnArreglos.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnArreglos.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArreglos.Location = New System.Drawing.Point(209, 103)
        Me.btnArreglos.Name = "btnArreglos"
        Me.btnArreglos.Size = New System.Drawing.Size(97, 33)
        Me.btnArreglos.TabIndex = 1
        Me.btnArreglos.Text = "Arreglos y Funciones"
        Me.btnArreglos.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(571, 48)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ejercicios Realizados en Clase"
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Montserrat SemiBold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.II_Parcial.My.Resources.Resources.backleftarrowcurvesymbol_79785
        Me.Button1.Location = New System.Drawing.Point(495, 313)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 40)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Regresar"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MenuClase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(620, 365)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnArreglos)
        Me.Controls.Add(Me.btnMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MenuClase"
        Me.Text = "MenuClase"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnMenu As Button
    Friend WithEvents btnArreglos As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
