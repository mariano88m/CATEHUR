<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_GestionCliente
    Inherits DevComponents.DotNetBar.Metro.MetroForm

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
        Me.lbl_gestionClientes = New System.Windows.Forms.Label()
        Me.txt_cliente = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbl_nombreCliente = New DevComponents.DotNetBar.LabelX()
        Me.txt_dni = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbl_dni = New DevComponents.DotNetBar.LabelX()
        Me.txt_Direccion = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Lbl_telefono = New DevComponents.DotNetBar.LabelX()
        Me.txt_email = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbl_email = New DevComponents.DotNetBar.LabelX()
        Me.txt_telefono = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Lbl_direccion = New DevComponents.DotNetBar.LabelX()
        Me.Dt_Clientes = New System.Windows.Forms.DataGridView()
        Me.btn_alta = New DevComponents.DotNetBar.ButtonX()
        Me.btn_Modificar = New DevComponents.DotNetBar.ButtonX()
        Me.btn_baja = New DevComponents.DotNetBar.ButtonX()
        Me.btn_cerrar = New DevComponents.DotNetBar.ButtonX()
        Me.lbl_localidad = New DevComponents.DotNetBar.LabelX()
        Me.cmb_Localidad = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.lbl_nroCliente = New DevComponents.DotNetBar.LabelX()
        Me.lbl_idCliente = New DevComponents.DotNetBar.LabelX()
        CType(Me.Dt_Clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_gestionClientes
        '
        Me.lbl_gestionClientes.AutoSize = True
        Me.lbl_gestionClientes.Font = New System.Drawing.Font("Tempus Sans ITC", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_gestionClientes.Location = New System.Drawing.Point(295, 9)
        Me.lbl_gestionClientes.Name = "lbl_gestionClientes"
        Me.lbl_gestionClientes.Size = New System.Drawing.Size(226, 31)
        Me.lbl_gestionClientes.TabIndex = 1
        Me.lbl_gestionClientes.Text = "Gestion de Clientes"
        Me.lbl_gestionClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_cliente
        '
        Me.txt_cliente.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_cliente.Border.Class = "TextBoxBorder"
        Me.txt_cliente.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_cliente.ForeColor = System.Drawing.Color.Black
        Me.txt_cliente.Location = New System.Drawing.Point(128, 85)
        Me.txt_cliente.Name = "txt_cliente"
        Me.txt_cliente.Size = New System.Drawing.Size(201, 22)
        Me.txt_cliente.TabIndex = 35
        '
        'lbl_nombreCliente
        '
        '
        '
        '
        Me.lbl_nombreCliente.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_nombreCliente.Location = New System.Drawing.Point(12, 82)
        Me.lbl_nombreCliente.Name = "lbl_nombreCliente"
        Me.lbl_nombreCliente.Size = New System.Drawing.Size(110, 23)
        Me.lbl_nombreCliente.TabIndex = 34
        Me.lbl_nombreCliente.Text = "Nombre del Cliente"
        '
        'txt_dni
        '
        Me.txt_dni.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_dni.Border.Class = "TextBoxBorder"
        Me.txt_dni.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_dni.ForeColor = System.Drawing.Color.Black
        Me.txt_dni.Location = New System.Drawing.Point(128, 114)
        Me.txt_dni.Name = "txt_dni"
        Me.txt_dni.Size = New System.Drawing.Size(201, 22)
        Me.txt_dni.TabIndex = 37
        '
        'lbl_dni
        '
        '
        '
        '
        Me.lbl_dni.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_dni.Location = New System.Drawing.Point(12, 111)
        Me.lbl_dni.Name = "lbl_dni"
        Me.lbl_dni.Size = New System.Drawing.Size(110, 23)
        Me.lbl_dni.TabIndex = 36
        Me.lbl_dni.Text = "DNI / CUIT / CUIL"
        '
        'txt_Direccion
        '
        Me.txt_Direccion.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_Direccion.Border.Class = "TextBoxBorder"
        Me.txt_Direccion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_Direccion.ForeColor = System.Drawing.Color.Black
        Me.txt_Direccion.Location = New System.Drawing.Point(128, 143)
        Me.txt_Direccion.Name = "txt_Direccion"
        Me.txt_Direccion.Size = New System.Drawing.Size(201, 22)
        Me.txt_Direccion.TabIndex = 39
        '
        'Lbl_telefono
        '
        '
        '
        '
        Me.Lbl_telefono.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Lbl_telefono.Location = New System.Drawing.Point(12, 206)
        Me.Lbl_telefono.Name = "Lbl_telefono"
        Me.Lbl_telefono.Size = New System.Drawing.Size(110, 23)
        Me.Lbl_telefono.TabIndex = 38
        Me.Lbl_telefono.Text = "Telefono"
        '
        'txt_email
        '
        Me.txt_email.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_email.Border.Class = "TextBoxBorder"
        Me.txt_email.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_email.ForeColor = System.Drawing.Color.Black
        Me.txt_email.Location = New System.Drawing.Point(128, 175)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(201, 22)
        Me.txt_email.TabIndex = 41
        '
        'lbl_email
        '
        '
        '
        '
        Me.lbl_email.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_email.Location = New System.Drawing.Point(12, 175)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(110, 23)
        Me.lbl_email.TabIndex = 40
        Me.lbl_email.Text = "Email"
        '
        'txt_telefono
        '
        Me.txt_telefono.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_telefono.Border.Class = "TextBoxBorder"
        Me.txt_telefono.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_telefono.ForeColor = System.Drawing.Color.Black
        Me.txt_telefono.Location = New System.Drawing.Point(128, 206)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(201, 22)
        Me.txt_telefono.TabIndex = 43
        '
        'Lbl_direccion
        '
        '
        '
        '
        Me.Lbl_direccion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Lbl_direccion.Location = New System.Drawing.Point(12, 142)
        Me.Lbl_direccion.Name = "Lbl_direccion"
        Me.Lbl_direccion.Size = New System.Drawing.Size(110, 23)
        Me.Lbl_direccion.TabIndex = 42
        Me.Lbl_direccion.Text = "Direccion"
        '
        'Dt_Clientes
        '
        Me.Dt_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dt_Clientes.Location = New System.Drawing.Point(12, 236)
        Me.Dt_Clientes.Name = "Dt_Clientes"
        Me.Dt_Clientes.Size = New System.Drawing.Size(764, 182)
        Me.Dt_Clientes.TabIndex = 44
        '
        'btn_alta
        '
        Me.btn_alta.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_alta.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_alta.Location = New System.Drawing.Point(14, 435)
        Me.btn_alta.Name = "btn_alta"
        Me.btn_alta.Size = New System.Drawing.Size(75, 25)
        Me.btn_alta.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_alta.TabIndex = 45
        Me.btn_alta.Text = "Alta"
        '
        'btn_Modificar
        '
        Me.btn_Modificar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_Modificar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_Modificar.Location = New System.Drawing.Point(128, 435)
        Me.btn_Modificar.Name = "btn_Modificar"
        Me.btn_Modificar.Size = New System.Drawing.Size(75, 25)
        Me.btn_Modificar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_Modificar.TabIndex = 46
        Me.btn_Modificar.Text = "Modificar"
        '
        'btn_baja
        '
        Me.btn_baja.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_baja.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_baja.Location = New System.Drawing.Point(254, 435)
        Me.btn_baja.Name = "btn_baja"
        Me.btn_baja.Size = New System.Drawing.Size(75, 25)
        Me.btn_baja.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_baja.TabIndex = 47
        Me.btn_baja.Text = "Baja"
        '
        'btn_cerrar
        '
        Me.btn_cerrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_cerrar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_cerrar.Location = New System.Drawing.Point(583, 435)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(75, 25)
        Me.btn_cerrar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_cerrar.TabIndex = 48
        Me.btn_cerrar.Text = "Cerrar"
        '
        'lbl_localidad
        '
        '
        '
        '
        Me.lbl_localidad.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_localidad.Location = New System.Drawing.Point(339, 144)
        Me.lbl_localidad.Name = "lbl_localidad"
        Me.lbl_localidad.Size = New System.Drawing.Size(64, 23)
        Me.lbl_localidad.TabIndex = 49
        Me.lbl_localidad.Text = "Localidad"
        '
        'cmb_Localidad
        '
        Me.cmb_Localidad.DisplayMember = "Text"
        Me.cmb_Localidad.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_Localidad.FormattingEnabled = True
        Me.cmb_Localidad.ItemHeight = 16
        Me.cmb_Localidad.Location = New System.Drawing.Point(399, 145)
        Me.cmb_Localidad.Name = "cmb_Localidad"
        Me.cmb_Localidad.Size = New System.Drawing.Size(229, 22)
        Me.cmb_Localidad.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmb_Localidad.TabIndex = 50
        '
        'lbl_nroCliente
        '
        '
        '
        '
        Me.lbl_nroCliente.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_nroCliente.Location = New System.Drawing.Point(14, 53)
        Me.lbl_nroCliente.Name = "lbl_nroCliente"
        Me.lbl_nroCliente.Size = New System.Drawing.Size(110, 23)
        Me.lbl_nroCliente.TabIndex = 51
        Me.lbl_nroCliente.Text = "Nro. Cliente"
        '
        'lbl_idCliente
        '
        '
        '
        '
        Me.lbl_idCliente.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_idCliente.Location = New System.Drawing.Point(128, 53)
        Me.lbl_idCliente.Name = "lbl_idCliente"
        Me.lbl_idCliente.Size = New System.Drawing.Size(110, 23)
        Me.lbl_idCliente.TabIndex = 52
        '
        'Frm_GestionCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(790, 478)
        Me.Controls.Add(Me.lbl_idCliente)
        Me.Controls.Add(Me.lbl_nroCliente)
        Me.Controls.Add(Me.cmb_Localidad)
        Me.Controls.Add(Me.lbl_localidad)
        Me.Controls.Add(Me.btn_cerrar)
        Me.Controls.Add(Me.btn_baja)
        Me.Controls.Add(Me.btn_Modificar)
        Me.Controls.Add(Me.btn_alta)
        Me.Controls.Add(Me.Dt_Clientes)
        Me.Controls.Add(Me.txt_telefono)
        Me.Controls.Add(Me.Lbl_direccion)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.lbl_email)
        Me.Controls.Add(Me.txt_Direccion)
        Me.Controls.Add(Me.Lbl_telefono)
        Me.Controls.Add(Me.txt_dni)
        Me.Controls.Add(Me.lbl_dni)
        Me.Controls.Add(Me.txt_cliente)
        Me.Controls.Add(Me.lbl_nombreCliente)
        Me.Controls.Add(Me.lbl_gestionClientes)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Frm_GestionCliente"
        Me.Text = "MetroForm"
        CType(Me.Dt_Clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_gestionClientes As System.Windows.Forms.Label
    Friend WithEvents txt_cliente As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbl_nombreCliente As DevComponents.DotNetBar.LabelX
    Friend WithEvents txt_dni As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbl_dni As DevComponents.DotNetBar.LabelX
    Friend WithEvents txt_Direccion As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Lbl_telefono As DevComponents.DotNetBar.LabelX
    Friend WithEvents txt_email As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbl_email As DevComponents.DotNetBar.LabelX
    Friend WithEvents txt_telefono As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Lbl_direccion As DevComponents.DotNetBar.LabelX
    Friend WithEvents Dt_Clientes As System.Windows.Forms.DataGridView
    Friend WithEvents btn_alta As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn_Modificar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn_baja As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn_cerrar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lbl_localidad As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmb_Localidad As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents lbl_nroCliente As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbl_idCliente As DevComponents.DotNetBar.LabelX
End Class
