<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuEjemplo
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
        Me.PanelSuperior = New System.Windows.Forms.Panel()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnMaximizar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.PanelLateral = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelForm = New System.Windows.Forms.Panel()
        Me.TimerOcultarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.TimerMostrar = New System.Windows.Forms.Timer(Me.components)
        Me.btnEmpleados = New System.Windows.Forms.Button()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.btnProductos = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.PictureBox()
        Me.btnRestaurar = New System.Windows.Forms.Button()
        Me.PanelSuperior.SuspendLayout()
        Me.PanelLateral.SuspendLayout()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelSuperior
        '
        Me.PanelSuperior.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.PanelSuperior.Controls.Add(Me.btnRestaurar)
        Me.PanelSuperior.Controls.Add(Me.btnMinimizar)
        Me.PanelSuperior.Controls.Add(Me.btnMaximizar)
        Me.PanelSuperior.Controls.Add(Me.btnCerrar)
        Me.PanelSuperior.Location = New System.Drawing.Point(0, 0)
        Me.PanelSuperior.Name = "PanelSuperior"
        Me.PanelSuperior.Size = New System.Drawing.Size(700, 34)
        Me.PanelSuperior.TabIndex = 0
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnMinimizar.BackgroundImage = Global.II_Parcial.My.Resources.Resources.window_minimize_icon_144028
        Me.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimizar.FlatAppearance.BorderSize = 0
        Me.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnMinimizar.Location = New System.Drawing.Point(565, 0)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(41, 34)
        Me.btnMinimizar.TabIndex = 4
        Me.btnMinimizar.UseVisualStyleBackColor = False
        '
        'btnMaximizar
        '
        Me.btnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximizar.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnMaximizar.BackgroundImage = Global.II_Parcial.My.Resources.Resources._1492790945_39minimize_84242
        Me.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMaximizar.FlatAppearance.BorderSize = 0
        Me.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximizar.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnMaximizar.Location = New System.Drawing.Point(612, 0)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(41, 34)
        Me.btnMaximizar.TabIndex = 3
        Me.btnMaximizar.UseVisualStyleBackColor = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnCerrar.BackgroundImage = Global.II_Parcial.My.Resources.Resources._1487086345_cross_81577
        Me.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnCerrar.Location = New System.Drawing.Point(659, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(41, 34)
        Me.btnCerrar.TabIndex = 2
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'PanelLateral
        '
        Me.PanelLateral.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.PanelLateral.Controls.Add(Me.Panel3)
        Me.PanelLateral.Controls.Add(Me.btnEmpleados)
        Me.PanelLateral.Controls.Add(Me.Panel2)
        Me.PanelLateral.Controls.Add(Me.btnClientes)
        Me.PanelLateral.Controls.Add(Me.Panel1)
        Me.PanelLateral.Controls.Add(Me.btnProductos)
        Me.PanelLateral.Controls.Add(Me.btnMenu)
        Me.PanelLateral.Location = New System.Drawing.Point(0, 34)
        Me.PanelLateral.Name = "PanelLateral"
        Me.PanelLateral.Size = New System.Drawing.Size(139, 379)
        Me.PanelLateral.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.GrayText
        Me.Panel3.Location = New System.Drawing.Point(3, 198)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(9, 37)
        Me.Panel3.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GrayText
        Me.Panel2.Location = New System.Drawing.Point(3, 155)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(9, 37)
        Me.Panel2.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GrayText
        Me.Panel1.Location = New System.Drawing.Point(3, 112)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(9, 37)
        Me.Panel1.TabIndex = 2
        '
        'PanelForm
        '
        Me.PanelForm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelForm.Location = New System.Drawing.Point(139, 34)
        Me.PanelForm.Name = "PanelForm"
        Me.PanelForm.Size = New System.Drawing.Size(423, 379)
        Me.PanelForm.TabIndex = 2
        '
        'TimerOcultarMenu
        '
        '
        'TimerMostrar
        '
        '
        'btnEmpleados
        '
        Me.btnEmpleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnEmpleados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEmpleados.FlatAppearance.BorderSize = 0
        Me.btnEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmpleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmpleados.Image = Global.II_Parcial.My.Resources.Resources._3986745_building_company_skyscraper_skyscraper_icon_112331__1_
        Me.btnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEmpleados.Location = New System.Drawing.Point(12, 198)
        Me.btnEmpleados.Name = "btnEmpleados"
        Me.btnEmpleados.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnEmpleados.Size = New System.Drawing.Size(121, 37)
        Me.btnEmpleados.TabIndex = 5
        Me.btnEmpleados.Text = "Empleados"
        Me.btnEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEmpleados.UseVisualStyleBackColor = True
        '
        'btnClientes
        '
        Me.btnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClientes.FlatAppearance.BorderSize = 0
        Me.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientes.Image = Global.II_Parcial.My.Resources.Resources.users_group_customers_clients_icon_icons_com_72448__1_
        Me.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClientes.Location = New System.Drawing.Point(12, 155)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnClientes.Size = New System.Drawing.Size(121, 37)
        Me.btnClientes.TabIndex = 3
        Me.btnClientes.Text = "Clientes"
        Me.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClientes.UseVisualStyleBackColor = True
        '
        'btnProductos
        '
        Me.btnProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProductos.FlatAppearance.BorderSize = 0
        Me.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProductos.Image = Global.II_Parcial.My.Resources.Resources.shopcart1_121141__1_
        Me.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProductos.Location = New System.Drawing.Point(12, 112)
        Me.btnProductos.Name = "btnProductos"
        Me.btnProductos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnProductos.Size = New System.Drawing.Size(121, 37)
        Me.btnProductos.TabIndex = 1
        Me.btnProductos.Text = "Productos"
        Me.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnProductos.UseVisualStyleBackColor = True
        '
        'btnMenu
        '
        Me.btnMenu.BackgroundImage = Global.II_Parcial.My.Resources.Resources.Menu_icon_icon_icons_com_71858
        Me.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenu.Location = New System.Drawing.Point(0, 0)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(40, 40)
        Me.btnMenu.TabIndex = 0
        Me.btnMenu.TabStop = False
        '
        'btnRestaurar
        '
        Me.btnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestaurar.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnRestaurar.BackgroundImage = Global.II_Parcial.My.Resources.Resources.window_maximize_icon_144029
        Me.btnRestaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRestaurar.FlatAppearance.BorderSize = 0
        Me.btnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestaurar.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnRestaurar.Location = New System.Drawing.Point(612, 0)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(41, 34)
        Me.btnRestaurar.TabIndex = 5
        Me.btnRestaurar.UseVisualStyleBackColor = False
        Me.btnRestaurar.Visible = False
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 410)
        Me.Controls.Add(Me.PanelForm)
        Me.Controls.Add(Me.PanelLateral)
        Me.Controls.Add(Me.PanelSuperior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Menu"
        Me.PanelSuperior.ResumeLayout(False)
        Me.PanelLateral.ResumeLayout(False)
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelSuperior As Panel
    Friend WithEvents btnCerrar As Button
    Friend WithEvents PanelLateral As Panel
    Friend WithEvents PanelForm As Panel
    Friend WithEvents btnMaximizar As Button
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents btnMenu As PictureBox
    Friend WithEvents btnProductos As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnEmpleados As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnClientes As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TimerOcultarMenu As Timer
    Friend WithEvents TimerMostrar As Timer
    Friend WithEvents btnRestaurar As Button
End Class
