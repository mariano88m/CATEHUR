<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_GestionUsuario
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lbl_username = New DevComponents.DotNetBar.LabelX()
        Me.txt_contraseña = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbl_Contraseña = New DevComponents.DotNetBar.LabelX()
        Me.btn_Cerrar = New DevComponents.DotNetBar.ButtonX()
        Me.btn_BajaUsuario = New DevComponents.DotNetBar.ButtonX()
        Me.btn_AltaUsuario = New DevComponents.DotNetBar.ButtonX()
        Me.cmb_usuario = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.btn_modificarUsuario = New DevComponents.DotNetBar.ButtonX()
        Me.lbl_nombre = New DevComponents.DotNetBar.LabelX()
        Me.txt_nombre = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbl_apellido = New DevComponents.DotNetBar.LabelX()
        Me.txt_apellido = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbl_email = New DevComponents.DotNetBar.LabelX()
        Me.txt_email = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbl_domicilio = New DevComponents.DotNetBar.LabelX()
        Me.txt_domicilio = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbl_telefono = New DevComponents.DotNetBar.LabelX()
        Me.txt_telefono = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbl_tipoEmpleado = New DevComponents.DotNetBar.LabelX()
        Me.lbl_usuario = New DevComponents.DotNetBar.LabelX()
        Me.txt_NombreUsuario = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.dt_FamiliasDisponibles = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.dt_FamiliasAsignadas = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.lbl_PermisosAsignados = New DevComponents.DotNetBar.LabelX()
        Me.lbl_permisosDisp = New DevComponents.DotNetBar.LabelX()
        Me.btn_quitarPermisos = New DevComponents.DotNetBar.ButtonX()
        Me.btn_asignarPermisos = New DevComponents.DotNetBar.ButtonX()
        Me.btn_buscarUsuario = New DevComponents.DotNetBar.ButtonX()
        Me.cmb_tipoempleado = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Lbl_GestionUsuario = New DevComponents.DotNetBar.LabelX()
        CType(Me.dt_FamiliasDisponibles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_FamiliasAsignadas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_username
        '
        '
        '
        '
        Me.lbl_username.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_username.Location = New System.Drawing.Point(31, 100)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(112, 23)
        Me.lbl_username.TabIndex = 0
        Me.lbl_username.Text = "Nombre de usuario"
        Me.lbl_username.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txt_contraseña
        '
        Me.txt_contraseña.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_contraseña.Border.Class = "TextBoxBorder"
        Me.txt_contraseña.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_contraseña.ForeColor = System.Drawing.Color.Black
        Me.txt_contraseña.Location = New System.Drawing.Point(163, 191)
        Me.txt_contraseña.Name = "txt_contraseña"
        Me.txt_contraseña.Size = New System.Drawing.Size(221, 22)
        Me.txt_contraseña.TabIndex = 2
        Me.txt_contraseña.UseSystemPasswordChar = True
        '
        'lbl_Contraseña
        '
        '
        '
        '
        Me.lbl_Contraseña.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_Contraseña.Location = New System.Drawing.Point(31, 191)
        Me.lbl_Contraseña.Name = "lbl_Contraseña"
        Me.lbl_Contraseña.Size = New System.Drawing.Size(112, 23)
        Me.lbl_Contraseña.TabIndex = 3
        Me.lbl_Contraseña.Text = "Contraseña"
        Me.lbl_Contraseña.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_Cerrar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_Cerrar.Location = New System.Drawing.Point(451, 402)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(75, 42)
        Me.btn_Cerrar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_Cerrar.TabIndex = 15
        Me.btn_Cerrar.Text = "Cerrar"
        '
        'btn_BajaUsuario
        '
        Me.btn_BajaUsuario.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_BajaUsuario.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_BajaUsuario.Location = New System.Drawing.Point(334, 404)
        Me.btn_BajaUsuario.Name = "btn_BajaUsuario"
        Me.btn_BajaUsuario.Size = New System.Drawing.Size(75, 23)
        Me.btn_BajaUsuario.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_BajaUsuario.TabIndex = 23
        Me.btn_BajaUsuario.Text = "Baja"
        '
        'btn_AltaUsuario
        '
        Me.btn_AltaUsuario.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_AltaUsuario.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_AltaUsuario.Location = New System.Drawing.Point(110, 404)
        Me.btn_AltaUsuario.Name = "btn_AltaUsuario"
        Me.btn_AltaUsuario.Size = New System.Drawing.Size(75, 23)
        Me.btn_AltaUsuario.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_AltaUsuario.TabIndex = 22
        Me.btn_AltaUsuario.Text = "Alta"
        '
        'cmb_usuario
        '
        Me.cmb_usuario.DisplayMember = "Text"
        Me.cmb_usuario.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_usuario.FormattingEnabled = True
        Me.cmb_usuario.ItemHeight = 16
        Me.cmb_usuario.Location = New System.Drawing.Point(163, 101)
        Me.cmb_usuario.Name = "cmb_usuario"
        Me.cmb_usuario.Size = New System.Drawing.Size(221, 22)
        Me.cmb_usuario.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmb_usuario.TabIndex = 27
        '
        'btn_modificarUsuario
        '
        Me.btn_modificarUsuario.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_modificarUsuario.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_modificarUsuario.Location = New System.Drawing.Point(222, 404)
        Me.btn_modificarUsuario.Name = "btn_modificarUsuario"
        Me.btn_modificarUsuario.Size = New System.Drawing.Size(75, 23)
        Me.btn_modificarUsuario.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_modificarUsuario.TabIndex = 28
        Me.btn_modificarUsuario.Text = "Modificacion"
        '
        'lbl_nombre
        '
        '
        '
        '
        Me.lbl_nombre.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_nombre.Location = New System.Drawing.Point(31, 220)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(112, 23)
        Me.lbl_nombre.TabIndex = 30
        Me.lbl_nombre.Text = "Nombre"
        Me.lbl_nombre.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txt_nombre
        '
        Me.txt_nombre.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_nombre.Border.Class = "TextBoxBorder"
        Me.txt_nombre.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_nombre.ForeColor = System.Drawing.Color.Black
        Me.txt_nombre.Location = New System.Drawing.Point(163, 219)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(221, 22)
        Me.txt_nombre.TabIndex = 29
        '
        'lbl_apellido
        '
        '
        '
        '
        Me.lbl_apellido.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_apellido.Location = New System.Drawing.Point(31, 249)
        Me.lbl_apellido.Name = "lbl_apellido"
        Me.lbl_apellido.Size = New System.Drawing.Size(112, 23)
        Me.lbl_apellido.TabIndex = 32
        Me.lbl_apellido.Text = "Apellido"
        Me.lbl_apellido.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txt_apellido
        '
        Me.txt_apellido.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_apellido.Border.Class = "TextBoxBorder"
        Me.txt_apellido.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_apellido.ForeColor = System.Drawing.Color.Black
        Me.txt_apellido.Location = New System.Drawing.Point(163, 247)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(221, 22)
        Me.txt_apellido.TabIndex = 31
        '
        'lbl_email
        '
        '
        '
        '
        Me.lbl_email.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_email.Location = New System.Drawing.Point(31, 275)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(112, 23)
        Me.lbl_email.TabIndex = 34
        Me.lbl_email.Text = "E-Mail"
        Me.lbl_email.TextAlignment = System.Drawing.StringAlignment.Far
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
        Me.txt_email.Location = New System.Drawing.Point(163, 275)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(221, 22)
        Me.txt_email.TabIndex = 33
        '
        'lbl_domicilio
        '
        '
        '
        '
        Me.lbl_domicilio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_domicilio.Location = New System.Drawing.Point(31, 302)
        Me.lbl_domicilio.Name = "lbl_domicilio"
        Me.lbl_domicilio.Size = New System.Drawing.Size(112, 23)
        Me.lbl_domicilio.TabIndex = 36
        Me.lbl_domicilio.Text = "Domicilio"
        Me.lbl_domicilio.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txt_domicilio
        '
        Me.txt_domicilio.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_domicilio.Border.Class = "TextBoxBorder"
        Me.txt_domicilio.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_domicilio.ForeColor = System.Drawing.Color.Black
        Me.txt_domicilio.Location = New System.Drawing.Point(163, 303)
        Me.txt_domicilio.Name = "txt_domicilio"
        Me.txt_domicilio.Size = New System.Drawing.Size(221, 22)
        Me.txt_domicilio.TabIndex = 35
        '
        'lbl_telefono
        '
        '
        '
        '
        Me.lbl_telefono.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_telefono.Location = New System.Drawing.Point(31, 328)
        Me.lbl_telefono.Name = "lbl_telefono"
        Me.lbl_telefono.Size = New System.Drawing.Size(112, 23)
        Me.lbl_telefono.TabIndex = 38
        Me.lbl_telefono.Text = "Telefono"
        Me.lbl_telefono.TextAlignment = System.Drawing.StringAlignment.Far
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
        Me.txt_telefono.Location = New System.Drawing.Point(163, 331)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(221, 22)
        Me.txt_telefono.TabIndex = 37
        '
        'lbl_tipoEmpleado
        '
        '
        '
        '
        Me.lbl_tipoEmpleado.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_tipoEmpleado.Location = New System.Drawing.Point(31, 359)
        Me.lbl_tipoEmpleado.Name = "lbl_tipoEmpleado"
        Me.lbl_tipoEmpleado.Size = New System.Drawing.Size(112, 23)
        Me.lbl_tipoEmpleado.TabIndex = 40
        Me.lbl_tipoEmpleado.Text = "Tipo Empleado"
        Me.lbl_tipoEmpleado.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'lbl_usuario
        '
        '
        '
        '
        Me.lbl_usuario.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_usuario.Location = New System.Drawing.Point(31, 162)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(112, 23)
        Me.lbl_usuario.TabIndex = 42
        Me.lbl_usuario.Text = "Usuario"
        Me.lbl_usuario.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txt_NombreUsuario
        '
        Me.txt_NombreUsuario.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_NombreUsuario.Border.Class = "TextBoxBorder"
        Me.txt_NombreUsuario.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_NombreUsuario.ForeColor = System.Drawing.Color.Black
        Me.txt_NombreUsuario.Location = New System.Drawing.Point(163, 162)
        Me.txt_NombreUsuario.Name = "txt_NombreUsuario"
        Me.txt_NombreUsuario.Size = New System.Drawing.Size(221, 22)
        Me.txt_NombreUsuario.TabIndex = 41
        '
        'dt_FamiliasDisponibles
        '
        Me.dt_FamiliasDisponibles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dt_FamiliasDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dt_FamiliasDisponibles.DefaultCellStyle = DataGridViewCellStyle1
        Me.dt_FamiliasDisponibles.GridColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.dt_FamiliasDisponibles.Location = New System.Drawing.Point(843, 162)
        Me.dt_FamiliasDisponibles.Name = "dt_FamiliasDisponibles"
        Me.dt_FamiliasDisponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dt_FamiliasDisponibles.Size = New System.Drawing.Size(308, 220)
        Me.dt_FamiliasDisponibles.TabIndex = 44
        '
        'dt_FamiliasAsignadas
        '
        Me.dt_FamiliasAsignadas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dt_FamiliasAsignadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dt_FamiliasAsignadas.DefaultCellStyle = DataGridViewCellStyle2
        Me.dt_FamiliasAsignadas.GridColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.dt_FamiliasAsignadas.Location = New System.Drawing.Point(528, 162)
        Me.dt_FamiliasAsignadas.Name = "dt_FamiliasAsignadas"
        Me.dt_FamiliasAsignadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dt_FamiliasAsignadas.Size = New System.Drawing.Size(294, 220)
        Me.dt_FamiliasAsignadas.TabIndex = 43
        '
        'lbl_PermisosAsignados
        '
        '
        '
        '
        Me.lbl_PermisosAsignados.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_PermisosAsignados.Location = New System.Drawing.Point(594, 132)
        Me.lbl_PermisosAsignados.Name = "lbl_PermisosAsignados"
        Me.lbl_PermisosAsignados.Size = New System.Drawing.Size(112, 23)
        Me.lbl_PermisosAsignados.TabIndex = 45
        Me.lbl_PermisosAsignados.Text = "Permisos Asignados"
        Me.lbl_PermisosAsignados.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'lbl_permisosDisp
        '
        '
        '
        '
        Me.lbl_permisosDisp.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_permisosDisp.Location = New System.Drawing.Point(933, 132)
        Me.lbl_permisosDisp.Name = "lbl_permisosDisp"
        Me.lbl_permisosDisp.Size = New System.Drawing.Size(112, 23)
        Me.lbl_permisosDisp.TabIndex = 46
        Me.lbl_permisosDisp.Text = "Permisos Disponibles"
        Me.lbl_permisosDisp.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'btn_quitarPermisos
        '
        Me.btn_quitarPermisos.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_quitarPermisos.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_quitarPermisos.Location = New System.Drawing.Point(604, 404)
        Me.btn_quitarPermisos.Name = "btn_quitarPermisos"
        Me.btn_quitarPermisos.Size = New System.Drawing.Size(102, 23)
        Me.btn_quitarPermisos.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_quitarPermisos.TabIndex = 47
        Me.btn_quitarPermisos.Text = "Quitar Permisos"
        '
        'btn_asignarPermisos
        '
        Me.btn_asignarPermisos.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_asignarPermisos.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_asignarPermisos.Location = New System.Drawing.Point(951, 402)
        Me.btn_asignarPermisos.Name = "btn_asignarPermisos"
        Me.btn_asignarPermisos.Size = New System.Drawing.Size(94, 23)
        Me.btn_asignarPermisos.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_asignarPermisos.TabIndex = 48
        Me.btn_asignarPermisos.Text = "Asignar Permisos"
        '
        'btn_buscarUsuario
        '
        Me.btn_buscarUsuario.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_buscarUsuario.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_buscarUsuario.Location = New System.Drawing.Point(407, 100)
        Me.btn_buscarUsuario.Name = "btn_buscarUsuario"
        Me.btn_buscarUsuario.Size = New System.Drawing.Size(75, 23)
        Me.btn_buscarUsuario.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_buscarUsuario.TabIndex = 49
        Me.btn_buscarUsuario.Text = "Buscar Usuario"
        '
        'cmb_tipoempleado
        '
        Me.cmb_tipoempleado.DisplayMember = "Text"
        Me.cmb_tipoempleado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_tipoempleado.FormattingEnabled = True
        Me.cmb_tipoempleado.ItemHeight = 16
        Me.cmb_tipoempleado.Location = New System.Drawing.Point(163, 359)
        Me.cmb_tipoempleado.Name = "cmb_tipoempleado"
        Me.cmb_tipoempleado.Size = New System.Drawing.Size(221, 22)
        Me.cmb_tipoempleado.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmb_tipoempleado.TabIndex = 50
        '
        'Lbl_GestionUsuario
        '
        '
        '
        '
        Me.Lbl_GestionUsuario.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Lbl_GestionUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Lbl_GestionUsuario.Location = New System.Drawing.Point(407, 12)
        Me.Lbl_GestionUsuario.Name = "Lbl_GestionUsuario"
        Me.Lbl_GestionUsuario.Size = New System.Drawing.Size(288, 45)
        Me.Lbl_GestionUsuario.TabIndex = 51
        Me.Lbl_GestionUsuario.Text = "Gestion de Usuarios"
        '
        'Frm_GestionUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1161, 447)
        Me.Controls.Add(Me.Lbl_GestionUsuario)
        Me.Controls.Add(Me.cmb_tipoempleado)
        Me.Controls.Add(Me.btn_buscarUsuario)
        Me.Controls.Add(Me.btn_asignarPermisos)
        Me.Controls.Add(Me.btn_quitarPermisos)
        Me.Controls.Add(Me.lbl_permisosDisp)
        Me.Controls.Add(Me.lbl_PermisosAsignados)
        Me.Controls.Add(Me.dt_FamiliasDisponibles)
        Me.Controls.Add(Me.dt_FamiliasAsignadas)
        Me.Controls.Add(Me.lbl_usuario)
        Me.Controls.Add(Me.txt_NombreUsuario)
        Me.Controls.Add(Me.lbl_tipoEmpleado)
        Me.Controls.Add(Me.lbl_telefono)
        Me.Controls.Add(Me.txt_telefono)
        Me.Controls.Add(Me.lbl_domicilio)
        Me.Controls.Add(Me.txt_domicilio)
        Me.Controls.Add(Me.lbl_email)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.lbl_apellido)
        Me.Controls.Add(Me.txt_apellido)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.btn_modificarUsuario)
        Me.Controls.Add(Me.cmb_usuario)
        Me.Controls.Add(Me.btn_BajaUsuario)
        Me.Controls.Add(Me.btn_AltaUsuario)
        Me.Controls.Add(Me.btn_Cerrar)
        Me.Controls.Add(Me.lbl_Contraseña)
        Me.Controls.Add(Me.txt_contraseña)
        Me.Controls.Add(Me.lbl_username)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Frm_GestionUsuario"
        Me.Text = "MetroForm"
        CType(Me.dt_FamiliasDisponibles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_FamiliasAsignadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_username As DevComponents.DotNetBar.LabelX
    Friend WithEvents txt_contraseña As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbl_Contraseña As DevComponents.DotNetBar.LabelX
    Friend WithEvents btn_Cerrar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn_BajaUsuario As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn_AltaUsuario As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmb_usuario As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents btn_modificarUsuario As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lbl_nombre As DevComponents.DotNetBar.LabelX
    Friend WithEvents txt_nombre As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbl_apellido As DevComponents.DotNetBar.LabelX
    Friend WithEvents txt_apellido As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbl_email As DevComponents.DotNetBar.LabelX
    Friend WithEvents txt_email As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbl_domicilio As DevComponents.DotNetBar.LabelX
    Friend WithEvents txt_domicilio As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbl_telefono As DevComponents.DotNetBar.LabelX
    Friend WithEvents txt_telefono As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbl_tipoEmpleado As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbl_usuario As DevComponents.DotNetBar.LabelX
    Friend WithEvents txt_NombreUsuario As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents dt_FamiliasDisponibles As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents dt_FamiliasAsignadas As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents lbl_PermisosAsignados As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbl_permisosDisp As DevComponents.DotNetBar.LabelX
    Friend WithEvents btn_quitarPermisos As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn_asignarPermisos As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn_buscarUsuario As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmb_tipoempleado As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Lbl_GestionUsuario As DevComponents.DotNetBar.LabelX
End Class
