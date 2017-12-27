<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_AsignacionPersonal
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
        Me.lbl_idEmpleado = New DevComponents.DotNetBar.LabelX()
        Me.Lbl_id_empleado = New DevComponents.DotNetBar.LabelX()
        Me.btn_cerrar = New DevComponents.DotNetBar.ButtonX()
        Me.btn_baja = New DevComponents.DotNetBar.ButtonX()
        Me.txt_telefonoEmpleado = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbl_email = New DevComponents.DotNetBar.LabelX()
        Me.txt_DomicilioEmpleado = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbl_domicilio = New DevComponents.DotNetBar.LabelX()
        Me.txt_EmailEmpleado = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbl_telefono = New DevComponents.DotNetBar.LabelX()
        Me.txt_ApellidoEmpleado = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbl_apellido = New DevComponents.DotNetBar.LabelX()
        Me.txt_nombreEmpleado = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbl_nombre = New DevComponents.DotNetBar.LabelX()
        Me.lbl_AsignacionPersonal = New System.Windows.Forms.Label()
        Me.lbl_cocinero = New DevComponents.DotNetBar.LabelX()
        Me.lbl_camarero = New DevComponents.DotNetBar.LabelX()
        Me.Lst_cocinero = New System.Windows.Forms.ListBox()
        Me.lst_camarero = New System.Windows.Forms.ListBox()
        Me.lbl_listaEventos = New DevComponents.DotNetBar.LabelX()
        Me.lbl_listaEmpleadosAsignados = New DevComponents.DotNetBar.LabelX()
        Me.dt_empleados = New System.Windows.Forms.DataGridView()
        Me.dt_eventos = New System.Windows.Forms.DataGridView()
        Me.txt_tipoEmpleado = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbl_tipoDeEmpleado = New DevComponents.DotNetBar.LabelX()
        Me.btn_AsignarEmpleado = New DevComponents.DotNetBar.ButtonX()
        Me.lbl_TipoEmpleado = New DevComponents.DotNetBar.LabelX()
        CType(Me.dt_empleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_eventos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_idEmpleado
        '
        '
        '
        '
        Me.lbl_idEmpleado.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_idEmpleado.Location = New System.Drawing.Point(760, 283)
        Me.lbl_idEmpleado.Name = "lbl_idEmpleado"
        Me.lbl_idEmpleado.Size = New System.Drawing.Size(110, 23)
        Me.lbl_idEmpleado.TabIndex = 72
        '
        'Lbl_id_empleado
        '
        '
        '
        '
        Me.Lbl_id_empleado.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Lbl_id_empleado.Location = New System.Drawing.Point(646, 283)
        Me.Lbl_id_empleado.Name = "Lbl_id_empleado"
        Me.Lbl_id_empleado.Size = New System.Drawing.Size(110, 23)
        Me.Lbl_id_empleado.TabIndex = 71
        Me.Lbl_id_empleado.Text = "IdEmpleado"
        '
        'btn_cerrar
        '
        Me.btn_cerrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_cerrar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_cerrar.Location = New System.Drawing.Point(931, 521)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(75, 25)
        Me.btn_cerrar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_cerrar.TabIndex = 68
        Me.btn_cerrar.Text = "Cerrar"
        '
        'btn_baja
        '
        Me.btn_baja.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_baja.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_baja.Location = New System.Drawing.Point(572, 521)
        Me.btn_baja.Name = "btn_baja"
        Me.btn_baja.Size = New System.Drawing.Size(43, 25)
        Me.btn_baja.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_baja.TabIndex = 67
        Me.btn_baja.Text = "Baja"
        '
        'txt_telefonoEmpleado
        '
        Me.txt_telefonoEmpleado.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_telefonoEmpleado.Border.Class = "TextBoxBorder"
        Me.txt_telefonoEmpleado.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_telefonoEmpleado.ForeColor = System.Drawing.Color.Black
        Me.txt_telefonoEmpleado.Location = New System.Drawing.Point(760, 436)
        Me.txt_telefonoEmpleado.Name = "txt_telefonoEmpleado"
        Me.txt_telefonoEmpleado.Size = New System.Drawing.Size(201, 22)
        Me.txt_telefonoEmpleado.TabIndex = 63
        '
        'lbl_email
        '
        '
        '
        '
        Me.lbl_email.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_email.Location = New System.Drawing.Point(644, 372)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(110, 23)
        Me.lbl_email.TabIndex = 62
        Me.lbl_email.Text = "Email"
        '
        'txt_DomicilioEmpleado
        '
        Me.txt_DomicilioEmpleado.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_DomicilioEmpleado.Border.Class = "TextBoxBorder"
        Me.txt_DomicilioEmpleado.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_DomicilioEmpleado.ForeColor = System.Drawing.Color.Black
        Me.txt_DomicilioEmpleado.Location = New System.Drawing.Point(760, 405)
        Me.txt_DomicilioEmpleado.Name = "txt_DomicilioEmpleado"
        Me.txt_DomicilioEmpleado.Size = New System.Drawing.Size(201, 22)
        Me.txt_DomicilioEmpleado.TabIndex = 61
        '
        'lbl_domicilio
        '
        '
        '
        '
        Me.lbl_domicilio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_domicilio.Location = New System.Drawing.Point(644, 405)
        Me.lbl_domicilio.Name = "lbl_domicilio"
        Me.lbl_domicilio.Size = New System.Drawing.Size(110, 23)
        Me.lbl_domicilio.TabIndex = 60
        Me.lbl_domicilio.Text = "Domicilio"
        '
        'txt_EmailEmpleado
        '
        Me.txt_EmailEmpleado.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_EmailEmpleado.Border.Class = "TextBoxBorder"
        Me.txt_EmailEmpleado.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_EmailEmpleado.ForeColor = System.Drawing.Color.Black
        Me.txt_EmailEmpleado.Location = New System.Drawing.Point(760, 373)
        Me.txt_EmailEmpleado.Name = "txt_EmailEmpleado"
        Me.txt_EmailEmpleado.Size = New System.Drawing.Size(201, 22)
        Me.txt_EmailEmpleado.TabIndex = 59
        '
        'lbl_telefono
        '
        '
        '
        '
        Me.lbl_telefono.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_telefono.Location = New System.Drawing.Point(644, 436)
        Me.lbl_telefono.Name = "lbl_telefono"
        Me.lbl_telefono.Size = New System.Drawing.Size(110, 23)
        Me.lbl_telefono.TabIndex = 58
        Me.lbl_telefono.Text = "Telefono"
        '
        'txt_ApellidoEmpleado
        '
        Me.txt_ApellidoEmpleado.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_ApellidoEmpleado.Border.Class = "TextBoxBorder"
        Me.txt_ApellidoEmpleado.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_ApellidoEmpleado.ForeColor = System.Drawing.Color.Black
        Me.txt_ApellidoEmpleado.Location = New System.Drawing.Point(760, 344)
        Me.txt_ApellidoEmpleado.Name = "txt_ApellidoEmpleado"
        Me.txt_ApellidoEmpleado.Size = New System.Drawing.Size(201, 22)
        Me.txt_ApellidoEmpleado.TabIndex = 57
        '
        'lbl_apellido
        '
        '
        '
        '
        Me.lbl_apellido.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_apellido.Location = New System.Drawing.Point(644, 341)
        Me.lbl_apellido.Name = "lbl_apellido"
        Me.lbl_apellido.Size = New System.Drawing.Size(110, 23)
        Me.lbl_apellido.TabIndex = 56
        Me.lbl_apellido.Text = "Apellido"
        '
        'txt_nombreEmpleado
        '
        Me.txt_nombreEmpleado.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_nombreEmpleado.Border.Class = "TextBoxBorder"
        Me.txt_nombreEmpleado.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_nombreEmpleado.ForeColor = System.Drawing.Color.Black
        Me.txt_nombreEmpleado.Location = New System.Drawing.Point(760, 315)
        Me.txt_nombreEmpleado.Name = "txt_nombreEmpleado"
        Me.txt_nombreEmpleado.Size = New System.Drawing.Size(201, 22)
        Me.txt_nombreEmpleado.TabIndex = 55
        '
        'lbl_nombre
        '
        '
        '
        '
        Me.lbl_nombre.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_nombre.Location = New System.Drawing.Point(644, 312)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(110, 23)
        Me.lbl_nombre.TabIndex = 54
        Me.lbl_nombre.Text = "Nombre"
        '
        'lbl_AsignacionPersonal
        '
        Me.lbl_AsignacionPersonal.AutoSize = True
        Me.lbl_AsignacionPersonal.Font = New System.Drawing.Font("Tempus Sans ITC", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_AsignacionPersonal.Location = New System.Drawing.Point(407, 27)
        Me.lbl_AsignacionPersonal.Name = "lbl_AsignacionPersonal"
        Me.lbl_AsignacionPersonal.Size = New System.Drawing.Size(268, 31)
        Me.lbl_AsignacionPersonal.TabIndex = 53
        Me.lbl_AsignacionPersonal.Text = "Asignacion de Personal"
        Me.lbl_AsignacionPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_cocinero
        '
        '
        '
        '
        Me.lbl_cocinero.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_cocinero.Location = New System.Drawing.Point(681, 74)
        Me.lbl_cocinero.Name = "lbl_cocinero"
        Me.lbl_cocinero.Size = New System.Drawing.Size(110, 23)
        Me.lbl_cocinero.TabIndex = 75
        Me.lbl_cocinero.Text = "Cocinero"
        '
        'lbl_camarero
        '
        '
        '
        '
        Me.lbl_camarero.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_camarero.Location = New System.Drawing.Point(878, 74)
        Me.lbl_camarero.Name = "lbl_camarero"
        Me.lbl_camarero.Size = New System.Drawing.Size(110, 23)
        Me.lbl_camarero.TabIndex = 76
        Me.lbl_camarero.Text = "Camarero"
        '
        'Lst_cocinero
        '
        Me.Lst_cocinero.FormattingEnabled = True
        Me.Lst_cocinero.Location = New System.Drawing.Point(620, 106)
        Me.Lst_cocinero.Name = "Lst_cocinero"
        Me.Lst_cocinero.Size = New System.Drawing.Size(181, 160)
        Me.Lst_cocinero.TabIndex = 77
        '
        'lst_camarero
        '
        Me.lst_camarero.FormattingEnabled = True
        Me.lst_camarero.Location = New System.Drawing.Point(825, 106)
        Me.lst_camarero.Name = "lst_camarero"
        Me.lst_camarero.Size = New System.Drawing.Size(181, 160)
        Me.lst_camarero.TabIndex = 78
        '
        'lbl_listaEventos
        '
        '
        '
        '
        Me.lbl_listaEventos.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_listaEventos.Location = New System.Drawing.Point(22, 74)
        Me.lbl_listaEventos.Name = "lbl_listaEventos"
        Me.lbl_listaEventos.Size = New System.Drawing.Size(110, 23)
        Me.lbl_listaEventos.TabIndex = 79
        Me.lbl_listaEventos.Text = "Lista de eventos"
        '
        'lbl_listaEmpleadosAsignados
        '
        '
        '
        '
        Me.lbl_listaEmpleadosAsignados.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_listaEmpleadosAsignados.Location = New System.Drawing.Point(22, 315)
        Me.lbl_listaEmpleadosAsignados.Name = "lbl_listaEmpleadosAsignados"
        Me.lbl_listaEmpleadosAsignados.Size = New System.Drawing.Size(206, 23)
        Me.lbl_listaEmpleadosAsignados.TabIndex = 81
        Me.lbl_listaEmpleadosAsignados.Text = "Lista de empleados asignados al evento"
        '
        'dt_empleados
        '
        Me.dt_empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dt_empleados.Location = New System.Drawing.Point(22, 344)
        Me.dt_empleados.Name = "dt_empleados"
        Me.dt_empleados.Size = New System.Drawing.Size(544, 200)
        Me.dt_empleados.TabIndex = 80
        '
        'dt_eventos
        '
        Me.dt_eventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dt_eventos.Location = New System.Drawing.Point(22, 106)
        Me.dt_eventos.Name = "dt_eventos"
        Me.dt_eventos.Size = New System.Drawing.Size(544, 200)
        Me.dt_eventos.TabIndex = 82
        '
        'txt_tipoEmpleado
        '
        Me.txt_tipoEmpleado.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_tipoEmpleado.Border.Class = "TextBoxBorder"
        Me.txt_tipoEmpleado.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_tipoEmpleado.ForeColor = System.Drawing.Color.Black
        Me.txt_tipoEmpleado.Location = New System.Drawing.Point(760, 465)
        Me.txt_tipoEmpleado.Name = "txt_tipoEmpleado"
        Me.txt_tipoEmpleado.Size = New System.Drawing.Size(201, 22)
        Me.txt_tipoEmpleado.TabIndex = 84
        '
        'lbl_tipoDeEmpleado
        '
        '
        '
        '
        Me.lbl_tipoDeEmpleado.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_tipoDeEmpleado.Location = New System.Drawing.Point(644, 465)
        Me.lbl_tipoDeEmpleado.Name = "lbl_tipoDeEmpleado"
        Me.lbl_tipoDeEmpleado.Size = New System.Drawing.Size(110, 23)
        Me.lbl_tipoDeEmpleado.TabIndex = 83
        Me.lbl_tipoDeEmpleado.Text = "Tipo Empleado"
        '
        'btn_AsignarEmpleado
        '
        Me.btn_AsignarEmpleado.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_AsignarEmpleado.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_AsignarEmpleado.Location = New System.Drawing.Point(760, 493)
        Me.btn_AsignarEmpleado.Name = "btn_AsignarEmpleado"
        Me.btn_AsignarEmpleado.Size = New System.Drawing.Size(97, 28)
        Me.btn_AsignarEmpleado.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_AsignarEmpleado.TabIndex = 85
        Me.btn_AsignarEmpleado.Text = "Asignar Empleado"
        '
        'lbl_TipoEmpleado
        '
        '
        '
        '
        Me.lbl_TipoEmpleado.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_TipoEmpleado.Location = New System.Drawing.Point(963, 465)
        Me.lbl_TipoEmpleado.Name = "lbl_TipoEmpleado"
        Me.lbl_TipoEmpleado.Size = New System.Drawing.Size(49, 23)
        Me.lbl_TipoEmpleado.TabIndex = 86
        Me.lbl_TipoEmpleado.Visible = False
        '
        'Frm_AsignacionPersonal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 558)
        Me.Controls.Add(Me.lbl_TipoEmpleado)
        Me.Controls.Add(Me.btn_AsignarEmpleado)
        Me.Controls.Add(Me.txt_tipoEmpleado)
        Me.Controls.Add(Me.lbl_tipoDeEmpleado)
        Me.Controls.Add(Me.dt_eventos)
        Me.Controls.Add(Me.lbl_listaEmpleadosAsignados)
        Me.Controls.Add(Me.dt_empleados)
        Me.Controls.Add(Me.lbl_listaEventos)
        Me.Controls.Add(Me.lst_camarero)
        Me.Controls.Add(Me.Lst_cocinero)
        Me.Controls.Add(Me.lbl_camarero)
        Me.Controls.Add(Me.lbl_cocinero)
        Me.Controls.Add(Me.lbl_idEmpleado)
        Me.Controls.Add(Me.Lbl_id_empleado)
        Me.Controls.Add(Me.btn_cerrar)
        Me.Controls.Add(Me.btn_baja)
        Me.Controls.Add(Me.txt_telefonoEmpleado)
        Me.Controls.Add(Me.lbl_email)
        Me.Controls.Add(Me.txt_DomicilioEmpleado)
        Me.Controls.Add(Me.lbl_domicilio)
        Me.Controls.Add(Me.txt_EmailEmpleado)
        Me.Controls.Add(Me.lbl_telefono)
        Me.Controls.Add(Me.txt_ApellidoEmpleado)
        Me.Controls.Add(Me.lbl_apellido)
        Me.Controls.Add(Me.txt_nombreEmpleado)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Controls.Add(Me.lbl_AsignacionPersonal)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Frm_AsignacionPersonal"
        Me.Text = "MetroForm"
        CType(Me.dt_empleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_eventos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_idEmpleado As DevComponents.DotNetBar.LabelX
    Friend WithEvents Lbl_id_empleado As DevComponents.DotNetBar.LabelX
    Friend WithEvents btn_cerrar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn_baja As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txt_telefonoEmpleado As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbl_email As DevComponents.DotNetBar.LabelX
    Friend WithEvents txt_DomicilioEmpleado As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbl_domicilio As DevComponents.DotNetBar.LabelX
    Friend WithEvents txt_EmailEmpleado As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbl_telefono As DevComponents.DotNetBar.LabelX
    Friend WithEvents txt_ApellidoEmpleado As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbl_apellido As DevComponents.DotNetBar.LabelX
    Friend WithEvents txt_nombreEmpleado As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbl_nombre As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbl_AsignacionPersonal As System.Windows.Forms.Label
    Friend WithEvents lbl_cocinero As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbl_camarero As DevComponents.DotNetBar.LabelX
    Friend WithEvents Lst_cocinero As System.Windows.Forms.ListBox
    Friend WithEvents lst_camarero As System.Windows.Forms.ListBox
    Friend WithEvents lbl_listaEventos As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbl_listaEmpleadosAsignados As DevComponents.DotNetBar.LabelX
    Friend WithEvents dt_empleados As System.Windows.Forms.DataGridView
    Friend WithEvents dt_eventos As System.Windows.Forms.DataGridView
    Friend WithEvents txt_tipoEmpleado As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbl_tipoDeEmpleado As DevComponents.DotNetBar.LabelX
    Friend WithEvents btn_AsignarEmpleado As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lbl_TipoEmpleado As DevComponents.DotNetBar.LabelX
End Class
