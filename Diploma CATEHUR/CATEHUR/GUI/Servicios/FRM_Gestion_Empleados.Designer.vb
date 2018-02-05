<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_Gestion_Empleados
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_Gestion_Empleados))
        Me.BTN_Alta = New System.Windows.Forms.Button
        Me.BTN_Baja = New System.Windows.Forms.Button
        Me.BTN_Modificacion = New System.Windows.Forms.Button
        Me.BTN_Salir = New System.Windows.Forms.Button
        Me.LBL_Id_Empleado = New System.Windows.Forms.Label
        Me.LBL_Nombre_Empleado = New System.Windows.Forms.Label
        Me.TXT_Id_Empleado = New System.Windows.Forms.TextBox
        Me.TXT_Nombre_Empleado = New System.Windows.Forms.TextBox
        Me.lblFecha = New System.Windows.Forms.Label
        Me.BTN_Cancelar = New System.Windows.Forms.Button
        Me.LBL_Apellido_Empleado = New System.Windows.Forms.Label
        Me.TXT_Apellido_Empleado = New System.Windows.Forms.TextBox
        Me.TXT_Dni_Empleado = New System.Windows.Forms.TextBox
        Me.LBL_Dni_Empleado = New System.Windows.Forms.Label
        Me.LBL_Categoria = New System.Windows.Forms.Label
        Me.CMB_Categoria = New System.Windows.Forms.ComboBox
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.BTN_Aceptar = New System.Windows.Forms.Button
        Me.CMB_Id_Empleado = New System.Windows.Forms.ComboBox
        Me.LBL_Empresa = New System.Windows.Forms.Label
        Me.CMB_Empresa = New System.Windows.Forms.ComboBox
        Me.LBL_Empleados_Existentes = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'BTN_Alta
        '
        Me.BTN_Alta.Location = New System.Drawing.Point(435, 40)
        Me.BTN_Alta.Name = "BTN_Alta"
        Me.BTN_Alta.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Alta.TabIndex = 8
        Me.BTN_Alta.Tag = "12"
        Me.BTN_Alta.Text = "Alta"
        Me.BTN_Alta.UseVisualStyleBackColor = True
        '
        'BTN_Baja
        '
        Me.BTN_Baja.Location = New System.Drawing.Point(435, 76)
        Me.BTN_Baja.Name = "BTN_Baja"
        Me.BTN_Baja.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Baja.TabIndex = 9
        Me.BTN_Baja.Tag = "13"
        Me.BTN_Baja.Text = "Baja"
        Me.BTN_Baja.UseVisualStyleBackColor = True
        '
        'BTN_Modificacion
        '
        Me.BTN_Modificacion.Location = New System.Drawing.Point(435, 112)
        Me.BTN_Modificacion.Name = "BTN_Modificacion"
        Me.BTN_Modificacion.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Modificacion.TabIndex = 10
        Me.BTN_Modificacion.Tag = "14"
        Me.BTN_Modificacion.Text = "Modificación"
        Me.BTN_Modificacion.UseVisualStyleBackColor = True
        '
        'BTN_Salir
        '
        Me.BTN_Salir.Location = New System.Drawing.Point(435, 184)
        Me.BTN_Salir.Name = "BTN_Salir"
        Me.BTN_Salir.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Salir.TabIndex = 12
        Me.BTN_Salir.Text = "Salir"
        Me.BTN_Salir.UseVisualStyleBackColor = True
        '
        'LBL_Id_Empleado
        '
        Me.LBL_Id_Empleado.AutoSize = True
        Me.LBL_Id_Empleado.Location = New System.Drawing.Point(13, 45)
        Me.LBL_Id_Empleado.Name = "LBL_Id_Empleado"
        Me.LBL_Id_Empleado.Size = New System.Drawing.Size(69, 13)
        Me.LBL_Id_Empleado.TabIndex = 4
        Me.LBL_Id_Empleado.Text = "Id Empleado:"
        '
        'LBL_Nombre_Empleado
        '
        Me.LBL_Nombre_Empleado.AutoSize = True
        Me.LBL_Nombre_Empleado.Location = New System.Drawing.Point(12, 81)
        Me.LBL_Nombre_Empleado.Name = "LBL_Nombre_Empleado"
        Me.LBL_Nombre_Empleado.Size = New System.Drawing.Size(47, 13)
        Me.LBL_Nombre_Empleado.TabIndex = 5
        Me.LBL_Nombre_Empleado.Text = "Nombre:"
        '
        'TXT_Id_Empleado
        '
        Me.TXT_Id_Empleado.AcceptsTab = True
        Me.TXT_Id_Empleado.Location = New System.Drawing.Point(146, 42)
        Me.TXT_Id_Empleado.MaxLength = 7
        Me.TXT_Id_Empleado.Name = "TXT_Id_Empleado"
        Me.TXT_Id_Empleado.Size = New System.Drawing.Size(259, 20)
        Me.TXT_Id_Empleado.TabIndex = 1
        '
        'TXT_Nombre_Empleado
        '
        Me.TXT_Nombre_Empleado.Location = New System.Drawing.Point(146, 78)
        Me.TXT_Nombre_Empleado.MaxLength = 50
        Me.TXT_Nombre_Empleado.Name = "TXT_Nombre_Empleado"
        Me.TXT_Nombre_Empleado.Size = New System.Drawing.Size(259, 20)
        Me.TXT_Nombre_Empleado.TabIndex = 2
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(98, 252)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(0, 13)
        Me.lblFecha.TabIndex = 9
        '
        'BTN_Cancelar
        '
        Me.BTN_Cancelar.Location = New System.Drawing.Point(435, 148)
        Me.BTN_Cancelar.Name = "BTN_Cancelar"
        Me.BTN_Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Cancelar.TabIndex = 11
        Me.BTN_Cancelar.Text = "Cancelar"
        Me.BTN_Cancelar.UseVisualStyleBackColor = True
        '
        'LBL_Apellido_Empleado
        '
        Me.LBL_Apellido_Empleado.AutoSize = True
        Me.LBL_Apellido_Empleado.Location = New System.Drawing.Point(12, 117)
        Me.LBL_Apellido_Empleado.Name = "LBL_Apellido_Empleado"
        Me.LBL_Apellido_Empleado.Size = New System.Drawing.Size(47, 13)
        Me.LBL_Apellido_Empleado.TabIndex = 12
        Me.LBL_Apellido_Empleado.Text = "Apellido:"
        '
        'TXT_Apellido_Empleado
        '
        Me.TXT_Apellido_Empleado.Location = New System.Drawing.Point(146, 114)
        Me.TXT_Apellido_Empleado.MaxLength = 50
        Me.TXT_Apellido_Empleado.Name = "TXT_Apellido_Empleado"
        Me.TXT_Apellido_Empleado.Size = New System.Drawing.Size(259, 20)
        Me.TXT_Apellido_Empleado.TabIndex = 3
        '
        'TXT_Dni_Empleado
        '
        Me.TXT_Dni_Empleado.Location = New System.Drawing.Point(146, 150)
        Me.TXT_Dni_Empleado.MaxLength = 50
        Me.TXT_Dni_Empleado.Name = "TXT_Dni_Empleado"
        Me.TXT_Dni_Empleado.Size = New System.Drawing.Size(259, 20)
        Me.TXT_Dni_Empleado.TabIndex = 4
        '
        'LBL_Dni_Empleado
        '
        Me.LBL_Dni_Empleado.AutoSize = True
        Me.LBL_Dni_Empleado.Location = New System.Drawing.Point(13, 153)
        Me.LBL_Dni_Empleado.Name = "LBL_Dni_Empleado"
        Me.LBL_Dni_Empleado.Size = New System.Drawing.Size(29, 13)
        Me.LBL_Dni_Empleado.TabIndex = 15
        Me.LBL_Dni_Empleado.Text = "DNI:"
        '
        'LBL_Categoria
        '
        Me.LBL_Categoria.AutoSize = True
        Me.LBL_Categoria.Location = New System.Drawing.Point(12, 189)
        Me.LBL_Categoria.Name = "LBL_Categoria"
        Me.LBL_Categoria.Size = New System.Drawing.Size(57, 13)
        Me.LBL_Categoria.TabIndex = 16
        Me.LBL_Categoria.Text = "Categoría:"
        '
        'CMB_Categoria
        '
        Me.CMB_Categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMB_Categoria.FormattingEnabled = True
        Me.CMB_Categoria.Location = New System.Drawing.Point(146, 186)
        Me.CMB_Categoria.Name = "CMB_Categoria"
        Me.CMB_Categoria.Size = New System.Drawing.Size(259, 21)
        Me.CMB_Categoria.TabIndex = 5
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 259)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(520, 22)
        Me.StatusStrip1.TabIndex = 20
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'BTN_Aceptar
        '
        Me.BTN_Aceptar.Location = New System.Drawing.Point(435, 4)
        Me.BTN_Aceptar.Name = "BTN_Aceptar"
        Me.BTN_Aceptar.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Aceptar.TabIndex = 7
        Me.BTN_Aceptar.Text = "Aceptar"
        Me.BTN_Aceptar.UseVisualStyleBackColor = True
        '
        'CMB_Id_Empleado
        '
        Me.CMB_Id_Empleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMB_Id_Empleado.FormattingEnabled = True
        Me.CMB_Id_Empleado.Location = New System.Drawing.Point(146, 6)
        Me.CMB_Id_Empleado.Name = "CMB_Id_Empleado"
        Me.CMB_Id_Empleado.Size = New System.Drawing.Size(259, 21)
        Me.CMB_Id_Empleado.TabIndex = 1
        '
        'LBL_Empresa
        '
        Me.LBL_Empresa.AutoSize = True
        Me.LBL_Empresa.Location = New System.Drawing.Point(12, 225)
        Me.LBL_Empresa.Name = "LBL_Empresa"
        Me.LBL_Empresa.Size = New System.Drawing.Size(51, 13)
        Me.LBL_Empresa.TabIndex = 21
        Me.LBL_Empresa.Text = "Empresa:"
        '
        'CMB_Empresa
        '
        Me.CMB_Empresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMB_Empresa.FormattingEnabled = True
        Me.CMB_Empresa.Location = New System.Drawing.Point(146, 222)
        Me.CMB_Empresa.Name = "CMB_Empresa"
        Me.CMB_Empresa.Size = New System.Drawing.Size(259, 21)
        Me.CMB_Empresa.TabIndex = 22
        '
        'LBL_Empleados_Existentes
        '
        Me.LBL_Empleados_Existentes.AutoSize = True
        Me.LBL_Empleados_Existentes.Location = New System.Drawing.Point(12, 9)
        Me.LBL_Empleados_Existentes.Name = "LBL_Empleados_Existentes"
        Me.LBL_Empleados_Existentes.Size = New System.Drawing.Size(112, 13)
        Me.LBL_Empleados_Existentes.TabIndex = 23
        Me.LBL_Empleados_Existentes.Text = "Empleados existentes:"
        '
        'FRM_Gestion_Empleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 281)
        Me.ControlBox = False
        Me.Controls.Add(Me.LBL_Empleados_Existentes)
        Me.Controls.Add(Me.CMB_Empresa)
        Me.Controls.Add(Me.LBL_Empresa)
        Me.Controls.Add(Me.CMB_Id_Empleado)
        Me.Controls.Add(Me.BTN_Aceptar)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.CMB_Categoria)
        Me.Controls.Add(Me.LBL_Categoria)
        Me.Controls.Add(Me.LBL_Dni_Empleado)
        Me.Controls.Add(Me.TXT_Dni_Empleado)
        Me.Controls.Add(Me.TXT_Apellido_Empleado)
        Me.Controls.Add(Me.LBL_Apellido_Empleado)
        Me.Controls.Add(Me.BTN_Cancelar)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.TXT_Nombre_Empleado)
        Me.Controls.Add(Me.TXT_Id_Empleado)
        Me.Controls.Add(Me.LBL_Nombre_Empleado)
        Me.Controls.Add(Me.LBL_Id_Empleado)
        Me.Controls.Add(Me.BTN_Salir)
        Me.Controls.Add(Me.BTN_Modificacion)
        Me.Controls.Add(Me.BTN_Baja)
        Me.Controls.Add(Me.BTN_Alta)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRM_Gestion_Empleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión de Empleados"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTN_Alta As System.Windows.Forms.Button
    Friend WithEvents BTN_Baja As System.Windows.Forms.Button
    Friend WithEvents BTN_Modificacion As System.Windows.Forms.Button
    Friend WithEvents BTN_Salir As System.Windows.Forms.Button
    Friend WithEvents LBL_Id_Empleado As System.Windows.Forms.Label
    Friend WithEvents LBL_Nombre_Empleado As System.Windows.Forms.Label
    Friend WithEvents TXT_Id_Empleado As System.Windows.Forms.TextBox
    Friend WithEvents TXT_Nombre_Empleado As System.Windows.Forms.TextBox
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents BTN_Cancelar As System.Windows.Forms.Button
    Friend WithEvents LBL_Apellido_Empleado As System.Windows.Forms.Label
    Friend WithEvents TXT_Apellido_Empleado As System.Windows.Forms.TextBox
    Friend WithEvents TXT_Dni_Empleado As System.Windows.Forms.TextBox
    Friend WithEvents LBL_Dni_Empleado As System.Windows.Forms.Label
    Friend WithEvents LBL_Categoria As System.Windows.Forms.Label
    Friend WithEvents CMB_Categoria As System.Windows.Forms.ComboBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents BTN_Aceptar As System.Windows.Forms.Button
    Friend WithEvents CMB_Id_Empleado As System.Windows.Forms.ComboBox
    Friend WithEvents LBL_Empresa As System.Windows.Forms.Label
    Friend WithEvents CMB_Empresa As System.Windows.Forms.ComboBox
    Friend WithEvents LBL_Empleados_Existentes As System.Windows.Forms.Label

End Class
