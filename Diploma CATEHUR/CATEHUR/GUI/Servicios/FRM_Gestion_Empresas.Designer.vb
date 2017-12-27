<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_Gestion_Empresas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_Gestion_Empresas))
        Me.BTN_Alta = New System.Windows.Forms.Button
        Me.BTN_Baja = New System.Windows.Forms.Button
        Me.BTN_Modificacion = New System.Windows.Forms.Button
        Me.BTN_Salir = New System.Windows.Forms.Button
        Me.LBL_ID_Empresa = New System.Windows.Forms.Label
        Me.LBL_Razon_Social = New System.Windows.Forms.Label
        Me.TXT_ID_Empresa = New System.Windows.Forms.TextBox
        Me.TXT_Razon_Social = New System.Windows.Forms.TextBox
        Me.lblFecha = New System.Windows.Forms.Label
        Me.BTN_Cancelar = New System.Windows.Forms.Button
        Me.LBL_Nombre_Fantasia = New System.Windows.Forms.Label
        Me.TXT_Nombre_Fantasia = New System.Windows.Forms.TextBox
        Me.TXT_Direccion = New System.Windows.Forms.TextBox
        Me.LBL_Direccion = New System.Windows.Forms.Label
        Me.LBL_CUIT = New System.Windows.Forms.Label
        Me.TXT_CUIT = New System.Windows.Forms.TextBox
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.BTN_Aceptar = New System.Windows.Forms.Button
        Me.CMB_ID_Empresa = New System.Windows.Forms.ComboBox
        Me.LBL_Empresas_Existentes = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'BTN_Alta
        '
        Me.BTN_Alta.Location = New System.Drawing.Point(413, 34)
        Me.BTN_Alta.Name = "BTN_Alta"
        Me.BTN_Alta.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Alta.TabIndex = 8
        Me.BTN_Alta.Tag = "15"
        Me.BTN_Alta.Text = "Alta"
        Me.BTN_Alta.UseVisualStyleBackColor = True
        '
        'BTN_Baja
        '
        Me.BTN_Baja.Location = New System.Drawing.Point(413, 64)
        Me.BTN_Baja.Name = "BTN_Baja"
        Me.BTN_Baja.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Baja.TabIndex = 9
        Me.BTN_Baja.Tag = "16"
        Me.BTN_Baja.Text = "Baja"
        Me.BTN_Baja.UseVisualStyleBackColor = True
        '
        'BTN_Modificacion
        '
        Me.BTN_Modificacion.Location = New System.Drawing.Point(413, 94)
        Me.BTN_Modificacion.Name = "BTN_Modificacion"
        Me.BTN_Modificacion.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Modificacion.TabIndex = 10
        Me.BTN_Modificacion.Tag = "17"
        Me.BTN_Modificacion.Text = "Modificación"
        Me.BTN_Modificacion.UseVisualStyleBackColor = True
        '
        'BTN_Salir
        '
        Me.BTN_Salir.Location = New System.Drawing.Point(413, 154)
        Me.BTN_Salir.Name = "BTN_Salir"
        Me.BTN_Salir.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Salir.TabIndex = 12
        Me.BTN_Salir.Text = "Salir"
        Me.BTN_Salir.UseVisualStyleBackColor = True
        '
        'LBL_ID_Empresa
        '
        Me.LBL_ID_Empresa.AutoSize = True
        Me.LBL_ID_Empresa.Location = New System.Drawing.Point(12, 39)
        Me.LBL_ID_Empresa.Name = "LBL_ID_Empresa"
        Me.LBL_ID_Empresa.Size = New System.Drawing.Size(63, 13)
        Me.LBL_ID_Empresa.TabIndex = 4
        Me.LBL_ID_Empresa.Text = "Id Empresa:"
        '
        'LBL_Razon_Social
        '
        Me.LBL_Razon_Social.AutoSize = True
        Me.LBL_Razon_Social.Location = New System.Drawing.Point(12, 69)
        Me.LBL_Razon_Social.Name = "LBL_Razon_Social"
        Me.LBL_Razon_Social.Size = New System.Drawing.Size(73, 13)
        Me.LBL_Razon_Social.TabIndex = 5
        Me.LBL_Razon_Social.Text = "Razon Social:"
        '
        'TXT_ID_Empresa
        '
        Me.TXT_ID_Empresa.Location = New System.Drawing.Point(133, 36)
        Me.TXT_ID_Empresa.MaxLength = 7
        Me.TXT_ID_Empresa.Name = "TXT_ID_Empresa"
        Me.TXT_ID_Empresa.Size = New System.Drawing.Size(259, 20)
        Me.TXT_ID_Empresa.TabIndex = 1
        '
        'TXT_Razon_Social
        '
        Me.TXT_Razon_Social.Location = New System.Drawing.Point(133, 66)
        Me.TXT_Razon_Social.MaxLength = 50
        Me.TXT_Razon_Social.Name = "TXT_Razon_Social"
        Me.TXT_Razon_Social.Size = New System.Drawing.Size(259, 20)
        Me.TXT_Razon_Social.TabIndex = 2
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
        Me.BTN_Cancelar.Location = New System.Drawing.Point(413, 124)
        Me.BTN_Cancelar.Name = "BTN_Cancelar"
        Me.BTN_Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Cancelar.TabIndex = 11
        Me.BTN_Cancelar.Tag = ""
        Me.BTN_Cancelar.Text = "Cancelar"
        Me.BTN_Cancelar.UseVisualStyleBackColor = True
        '
        'LBL_Nombre_Fantasia
        '
        Me.LBL_Nombre_Fantasia.AutoSize = True
        Me.LBL_Nombre_Fantasia.Location = New System.Drawing.Point(12, 99)
        Me.LBL_Nombre_Fantasia.Name = "LBL_Nombre_Fantasia"
        Me.LBL_Nombre_Fantasia.Size = New System.Drawing.Size(105, 13)
        Me.LBL_Nombre_Fantasia.TabIndex = 12
        Me.LBL_Nombre_Fantasia.Text = "Nombre de Fantasia:"
        '
        'TXT_Nombre_Fantasia
        '
        Me.TXT_Nombre_Fantasia.Location = New System.Drawing.Point(133, 96)
        Me.TXT_Nombre_Fantasia.MaxLength = 50
        Me.TXT_Nombre_Fantasia.Name = "TXT_Nombre_Fantasia"
        Me.TXT_Nombre_Fantasia.Size = New System.Drawing.Size(259, 20)
        Me.TXT_Nombre_Fantasia.TabIndex = 3
        '
        'TXT_Direccion
        '
        Me.TXT_Direccion.Location = New System.Drawing.Point(133, 126)
        Me.TXT_Direccion.MaxLength = 50
        Me.TXT_Direccion.Name = "TXT_Direccion"
        Me.TXT_Direccion.Size = New System.Drawing.Size(259, 20)
        Me.TXT_Direccion.TabIndex = 4
        '
        'LBL_Direccion
        '
        Me.LBL_Direccion.AutoSize = True
        Me.LBL_Direccion.Location = New System.Drawing.Point(12, 129)
        Me.LBL_Direccion.Name = "LBL_Direccion"
        Me.LBL_Direccion.Size = New System.Drawing.Size(55, 13)
        Me.LBL_Direccion.TabIndex = 15
        Me.LBL_Direccion.Text = "Dirección:"
        '
        'LBL_CUIT
        '
        Me.LBL_CUIT.AutoSize = True
        Me.LBL_CUIT.Location = New System.Drawing.Point(12, 159)
        Me.LBL_CUIT.Name = "LBL_CUIT"
        Me.LBL_CUIT.Size = New System.Drawing.Size(35, 13)
        Me.LBL_CUIT.TabIndex = 16
        Me.LBL_CUIT.Text = "CUIT:"
        '
        'TXT_CUIT
        '
        Me.TXT_CUIT.Location = New System.Drawing.Point(133, 156)
        Me.TXT_CUIT.MaxLength = 8
        Me.TXT_CUIT.Name = "TXT_CUIT"
        Me.TXT_CUIT.Size = New System.Drawing.Size(259, 20)
        Me.TXT_CUIT.TabIndex = 6
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 184)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(494, 22)
        Me.StatusStrip1.TabIndex = 20
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'BTN_Aceptar
        '
        Me.BTN_Aceptar.Location = New System.Drawing.Point(413, 4)
        Me.BTN_Aceptar.Name = "BTN_Aceptar"
        Me.BTN_Aceptar.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Aceptar.TabIndex = 7
        Me.BTN_Aceptar.Tag = ""
        Me.BTN_Aceptar.Text = "Aceptar"
        Me.BTN_Aceptar.UseVisualStyleBackColor = True
        '
        'CMB_ID_Empresa
        '
        Me.CMB_ID_Empresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMB_ID_Empresa.FormattingEnabled = True
        Me.CMB_ID_Empresa.Location = New System.Drawing.Point(133, 6)
        Me.CMB_ID_Empresa.Name = "CMB_ID_Empresa"
        Me.CMB_ID_Empresa.Size = New System.Drawing.Size(259, 21)
        Me.CMB_ID_Empresa.TabIndex = 1
        '
        'LBL_Empresas_Existentes
        '
        Me.LBL_Empresas_Existentes.AutoSize = True
        Me.LBL_Empresas_Existentes.Location = New System.Drawing.Point(12, 9)
        Me.LBL_Empresas_Existentes.Name = "LBL_Empresas_Existentes"
        Me.LBL_Empresas_Existentes.Size = New System.Drawing.Size(107, 13)
        Me.LBL_Empresas_Existentes.TabIndex = 21
        Me.LBL_Empresas_Existentes.Text = "Empresas Existentes:"
        '
        'FRM_Gestion_Empresas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 206)
        Me.ControlBox = False
        Me.Controls.Add(Me.LBL_Empresas_Existentes)
        Me.Controls.Add(Me.CMB_ID_Empresa)
        Me.Controls.Add(Me.BTN_Aceptar)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TXT_CUIT)
        Me.Controls.Add(Me.LBL_CUIT)
        Me.Controls.Add(Me.LBL_Direccion)
        Me.Controls.Add(Me.TXT_Direccion)
        Me.Controls.Add(Me.TXT_Nombre_Fantasia)
        Me.Controls.Add(Me.LBL_Nombre_Fantasia)
        Me.Controls.Add(Me.BTN_Cancelar)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.TXT_Razon_Social)
        Me.Controls.Add(Me.TXT_ID_Empresa)
        Me.Controls.Add(Me.LBL_Razon_Social)
        Me.Controls.Add(Me.LBL_ID_Empresa)
        Me.Controls.Add(Me.BTN_Salir)
        Me.Controls.Add(Me.BTN_Modificacion)
        Me.Controls.Add(Me.BTN_Baja)
        Me.Controls.Add(Me.BTN_Alta)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRM_Gestion_Empresas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = ""
        Me.Text = "Gestión de Empresas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTN_Alta As System.Windows.Forms.Button
    Friend WithEvents BTN_Baja As System.Windows.Forms.Button
    Friend WithEvents BTN_Modificacion As System.Windows.Forms.Button
    Friend WithEvents BTN_Salir As System.Windows.Forms.Button
    Friend WithEvents LBL_ID_Empresa As System.Windows.Forms.Label
    Friend WithEvents LBL_Razon_Social As System.Windows.Forms.Label
    Friend WithEvents TXT_ID_Empresa As System.Windows.Forms.TextBox
    Friend WithEvents TXT_Razon_Social As System.Windows.Forms.TextBox
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents BTN_Cancelar As System.Windows.Forms.Button
    Friend WithEvents LBL_Nombre_Fantasia As System.Windows.Forms.Label
    Friend WithEvents TXT_Nombre_Fantasia As System.Windows.Forms.TextBox
    Friend WithEvents TXT_Direccion As System.Windows.Forms.TextBox
    Friend WithEvents LBL_Direccion As System.Windows.Forms.Label
    Friend WithEvents LBL_CUIT As System.Windows.Forms.Label
    Friend WithEvents TXT_CUIT As System.Windows.Forms.TextBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents BTN_Aceptar As System.Windows.Forms.Button
    Friend WithEvents CMB_ID_Empresa As System.Windows.Forms.ComboBox
    Friend WithEvents LBL_Empresas_Existentes As System.Windows.Forms.Label

End Class
