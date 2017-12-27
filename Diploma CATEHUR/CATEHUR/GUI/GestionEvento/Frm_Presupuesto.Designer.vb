<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Presupuesto
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
        Me.lbl_solicitudPresupuesto = New System.Windows.Forms.Label()
        Me.lbl_cliente = New System.Windows.Forms.Label()
        Me.cmb_Clientes = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.btn_GenerarPresupuesto = New DevComponents.DotNetBar.ButtonX()
        Me.txt_Comentarios = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbl_Comentarios = New DevComponents.DotNetBar.LabelX()
        Me.dt_FechaEvento = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.lbl_FechaEvento = New DevComponents.DotNetBar.LabelX()
        Me.Btn_SeleccionMenu = New DevComponents.DotNetBar.ButtonX()
        Me.rd_party = New System.Windows.Forms.RadioButton()
        Me.rd_coffeeBreak = New System.Windows.Forms.RadioButton()
        Me.rd_brunch = New System.Windows.Forms.RadioButton()
        Me.rd_Fiestas = New System.Windows.Forms.RadioButton()
        Me.rd_breakfast = New System.Windows.Forms.RadioButton()
        Me.lbl_tipoCatering = New DevComponents.DotNetBar.LabelX()
        Me.lbl_localidad = New DevComponents.DotNetBar.LabelX()
        Me.txt_DireccionEvento = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbl_direccionEvento = New DevComponents.DotNetBar.LabelX()
        Me.btn_AltaCliente = New DevComponents.DotNetBar.ButtonX()
        Me.cmb_Localidad = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.txt_cantPersonas = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbl_CantPersonas = New DevComponents.DotNetBar.LabelX()
        Me.txt_nombreevento = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbl_NombreEvento = New DevComponents.DotNetBar.LabelX()
        Me.lbl_precioPersona = New DevComponents.DotNetBar.LabelX()
        Me.lbl_ResultadoPrecioPersona = New DevComponents.DotNetBar.LabelX()
        Me.btn_cerrar = New DevComponents.DotNetBar.ButtonX()
        CType(Me.dt_FechaEvento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_solicitudPresupuesto
        '
        Me.lbl_solicitudPresupuesto.AutoSize = True
        Me.lbl_solicitudPresupuesto.Font = New System.Drawing.Font("Tempus Sans ITC", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_solicitudPresupuesto.Location = New System.Drawing.Point(162, 19)
        Me.lbl_solicitudPresupuesto.Name = "lbl_solicitudPresupuesto"
        Me.lbl_solicitudPresupuesto.Size = New System.Drawing.Size(279, 31)
        Me.lbl_solicitudPresupuesto.TabIndex = 0
        Me.lbl_solicitudPresupuesto.Text = "Solicitud de Presupuesto"
        Me.lbl_solicitudPresupuesto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_cliente
        '
        Me.lbl_cliente.AutoSize = True
        Me.lbl_cliente.Location = New System.Drawing.Point(31, 65)
        Me.lbl_cliente.Name = "lbl_cliente"
        Me.lbl_cliente.Size = New System.Drawing.Size(39, 13)
        Me.lbl_cliente.TabIndex = 1
        Me.lbl_cliente.Text = "Cliente"
        '
        'cmb_Clientes
        '
        Me.cmb_Clientes.DisplayMember = "Text"
        Me.cmb_Clientes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_Clientes.FormattingEnabled = True
        Me.cmb_Clientes.ItemHeight = 14
        Me.cmb_Clientes.Location = New System.Drawing.Point(150, 65)
        Me.cmb_Clientes.Name = "cmb_Clientes"
        Me.cmb_Clientes.Size = New System.Drawing.Size(201, 20)
        Me.cmb_Clientes.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmb_Clientes.TabIndex = 3
        '
        'btn_GenerarPresupuesto
        '
        Me.btn_GenerarPresupuesto.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_GenerarPresupuesto.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_GenerarPresupuesto.Location = New System.Drawing.Point(150, 454)
        Me.btn_GenerarPresupuesto.Name = "btn_GenerarPresupuesto"
        Me.btn_GenerarPresupuesto.Size = New System.Drawing.Size(119, 30)
        Me.btn_GenerarPresupuesto.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_GenerarPresupuesto.TabIndex = 47
        Me.btn_GenerarPresupuesto.Text = "Generar Presupuesto"
        '
        'txt_Comentarios
        '
        Me.txt_Comentarios.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_Comentarios.Border.Class = "TextBoxBorder"
        Me.txt_Comentarios.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_Comentarios.ForeColor = System.Drawing.Color.Black
        Me.txt_Comentarios.Location = New System.Drawing.Point(150, 392)
        Me.txt_Comentarios.Multiline = True
        Me.txt_Comentarios.Name = "txt_Comentarios"
        Me.txt_Comentarios.Size = New System.Drawing.Size(290, 50)
        Me.txt_Comentarios.TabIndex = 46
        '
        'lbl_Comentarios
        '
        '
        '
        '
        Me.lbl_Comentarios.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_Comentarios.Location = New System.Drawing.Point(34, 389)
        Me.lbl_Comentarios.Name = "lbl_Comentarios"
        Me.lbl_Comentarios.Size = New System.Drawing.Size(75, 23)
        Me.lbl_Comentarios.TabIndex = 45
        Me.lbl_Comentarios.Text = "Comentarios"
        '
        'dt_FechaEvento
        '
        '
        '
        '
        Me.dt_FechaEvento.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dt_FechaEvento.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dt_FechaEvento.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dt_FechaEvento.ButtonDropDown.Visible = True
        Me.dt_FechaEvento.IsPopupCalendarOpen = False
        Me.dt_FechaEvento.Location = New System.Drawing.Point(150, 358)
        '
        '
        '
        Me.dt_FechaEvento.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dt_FechaEvento.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dt_FechaEvento.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.dt_FechaEvento.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dt_FechaEvento.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dt_FechaEvento.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dt_FechaEvento.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dt_FechaEvento.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dt_FechaEvento.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dt_FechaEvento.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dt_FechaEvento.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dt_FechaEvento.MonthCalendar.DisplayMonth = New Date(2017, 7, 1, 0, 0, 0, 0)
        Me.dt_FechaEvento.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dt_FechaEvento.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dt_FechaEvento.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dt_FechaEvento.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dt_FechaEvento.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dt_FechaEvento.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dt_FechaEvento.MonthCalendar.TodayButtonVisible = True
        Me.dt_FechaEvento.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dt_FechaEvento.Name = "dt_FechaEvento"
        Me.dt_FechaEvento.Size = New System.Drawing.Size(290, 20)
        Me.dt_FechaEvento.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dt_FechaEvento.TabIndex = 44
        '
        'lbl_FechaEvento
        '
        '
        '
        '
        Me.lbl_FechaEvento.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_FechaEvento.Location = New System.Drawing.Point(34, 358)
        Me.lbl_FechaEvento.Name = "lbl_FechaEvento"
        Me.lbl_FechaEvento.Size = New System.Drawing.Size(92, 23)
        Me.lbl_FechaEvento.TabIndex = 43
        Me.lbl_FechaEvento.Text = "Fecha del Evento"
        '
        'Btn_SeleccionMenu
        '
        Me.Btn_SeleccionMenu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Btn_SeleccionMenu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Btn_SeleccionMenu.Location = New System.Drawing.Point(150, 284)
        Me.Btn_SeleccionMenu.Name = "Btn_SeleccionMenu"
        Me.Btn_SeleccionMenu.Size = New System.Drawing.Size(119, 23)
        Me.Btn_SeleccionMenu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Btn_SeleccionMenu.TabIndex = 42
        Me.Btn_SeleccionMenu.Text = "Seleccionar Menu"
        '
        'rd_party
        '
        Me.rd_party.AutoSize = True
        Me.rd_party.Location = New System.Drawing.Point(150, 246)
        Me.rd_party.Name = "rd_party"
        Me.rd_party.Size = New System.Drawing.Size(91, 17)
        Me.rd_party.TabIndex = 41
        Me.rd_party.TabStop = True
        Me.rd_party.Text = "Catering Party"
        Me.rd_party.UseVisualStyleBackColor = True
        '
        'rd_coffeeBreak
        '
        Me.rd_coffeeBreak.AutoSize = True
        Me.rd_coffeeBreak.Location = New System.Drawing.Point(150, 223)
        Me.rd_coffeeBreak.Name = "rd_coffeeBreak"
        Me.rd_coffeeBreak.Size = New System.Drawing.Size(129, 17)
        Me.rd_coffeeBreak.TabIndex = 40
        Me.rd_coffeeBreak.TabStop = True
        Me.rd_coffeeBreak.Text = "Catering Coffee Break"
        Me.rd_coffeeBreak.UseVisualStyleBackColor = True
        '
        'rd_brunch
        '
        Me.rd_brunch.AutoSize = True
        Me.rd_brunch.Location = New System.Drawing.Point(150, 200)
        Me.rd_brunch.Name = "rd_brunch"
        Me.rd_brunch.Size = New System.Drawing.Size(101, 17)
        Me.rd_brunch.TabIndex = 39
        Me.rd_brunch.TabStop = True
        Me.rd_brunch.Text = "Catering Brunch"
        Me.rd_brunch.UseVisualStyleBackColor = True
        '
        'rd_Fiestas
        '
        Me.rd_Fiestas.AutoSize = True
        Me.rd_Fiestas.Location = New System.Drawing.Point(150, 177)
        Me.rd_Fiestas.Name = "rd_Fiestas"
        Me.rd_Fiestas.Size = New System.Drawing.Size(100, 17)
        Me.rd_Fiestas.TabIndex = 38
        Me.rd_Fiestas.TabStop = True
        Me.rd_Fiestas.Text = "Catering Fiestas"
        Me.rd_Fiestas.UseVisualStyleBackColor = True
        '
        'rd_breakfast
        '
        Me.rd_breakfast.AutoSize = True
        Me.rd_breakfast.Location = New System.Drawing.Point(150, 154)
        Me.rd_breakfast.Name = "rd_breakfast"
        Me.rd_breakfast.Size = New System.Drawing.Size(112, 17)
        Me.rd_breakfast.TabIndex = 37
        Me.rd_breakfast.TabStop = True
        Me.rd_breakfast.Text = "Catering Breakfast"
        Me.rd_breakfast.UseVisualStyleBackColor = True
        '
        'lbl_tipoCatering
        '
        '
        '
        '
        Me.lbl_tipoCatering.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_tipoCatering.Location = New System.Drawing.Point(34, 151)
        Me.lbl_tipoCatering.Name = "lbl_tipoCatering"
        Me.lbl_tipoCatering.Size = New System.Drawing.Size(110, 23)
        Me.lbl_tipoCatering.TabIndex = 36
        Me.lbl_tipoCatering.Text = "Tipo de Catering"
        '
        'lbl_localidad
        '
        '
        '
        '
        Me.lbl_localidad.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_localidad.Location = New System.Drawing.Point(366, 124)
        Me.lbl_localidad.Name = "lbl_localidad"
        Me.lbl_localidad.Size = New System.Drawing.Size(75, 23)
        Me.lbl_localidad.TabIndex = 34
        Me.lbl_localidad.Text = "Localidad"
        '
        'txt_DireccionEvento
        '
        Me.txt_DireccionEvento.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_DireccionEvento.Border.Class = "TextBoxBorder"
        Me.txt_DireccionEvento.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_DireccionEvento.ForeColor = System.Drawing.Color.Black
        Me.txt_DireccionEvento.Location = New System.Drawing.Point(150, 125)
        Me.txt_DireccionEvento.Name = "txt_DireccionEvento"
        Me.txt_DireccionEvento.Size = New System.Drawing.Size(201, 20)
        Me.txt_DireccionEvento.TabIndex = 33
        '
        'lbl_direccionEvento
        '
        '
        '
        '
        Me.lbl_direccionEvento.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_direccionEvento.Location = New System.Drawing.Point(34, 122)
        Me.lbl_direccionEvento.Name = "lbl_direccionEvento"
        Me.lbl_direccionEvento.Size = New System.Drawing.Size(110, 23)
        Me.lbl_direccionEvento.TabIndex = 32
        Me.lbl_direccionEvento.Text = "Direccion del Evento"
        '
        'btn_AltaCliente
        '
        Me.btn_AltaCliente.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_AltaCliente.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_AltaCliente.Location = New System.Drawing.Point(441, 65)
        Me.btn_AltaCliente.Name = "btn_AltaCliente"
        Me.btn_AltaCliente.Size = New System.Drawing.Size(119, 23)
        Me.btn_AltaCliente.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_AltaCliente.TabIndex = 49
        Me.btn_AltaCliente.Text = "Alta Cliente"
        '
        'cmb_Localidad
        '
        Me.cmb_Localidad.DisplayMember = "Text"
        Me.cmb_Localidad.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_Localidad.FormattingEnabled = True
        Me.cmb_Localidad.ItemHeight = 14
        Me.cmb_Localidad.Location = New System.Drawing.Point(441, 127)
        Me.cmb_Localidad.Name = "cmb_Localidad"
        Me.cmb_Localidad.Size = New System.Drawing.Size(142, 20)
        Me.cmb_Localidad.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmb_Localidad.TabIndex = 50
        '
        'txt_cantPersonas
        '
        Me.txt_cantPersonas.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_cantPersonas.Border.Class = "TextBoxBorder"
        Me.txt_cantPersonas.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_cantPersonas.ForeColor = System.Drawing.Color.Black
        Me.txt_cantPersonas.Location = New System.Drawing.Point(150, 323)
        Me.txt_cantPersonas.Name = "txt_cantPersonas"
        Me.txt_cantPersonas.Size = New System.Drawing.Size(57, 20)
        Me.txt_cantPersonas.TabIndex = 52
        '
        'lbl_CantPersonas
        '
        '
        '
        '
        Me.lbl_CantPersonas.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_CantPersonas.Location = New System.Drawing.Point(34, 320)
        Me.lbl_CantPersonas.Name = "lbl_CantPersonas"
        Me.lbl_CantPersonas.Size = New System.Drawing.Size(110, 23)
        Me.lbl_CantPersonas.TabIndex = 51
        Me.lbl_CantPersonas.Text = "Cantidad de Personas"
        '
        'txt_nombreevento
        '
        Me.txt_nombreevento.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_nombreevento.Border.Class = "TextBoxBorder"
        Me.txt_nombreevento.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_nombreevento.ForeColor = System.Drawing.Color.Black
        Me.txt_nombreevento.Location = New System.Drawing.Point(150, 94)
        Me.txt_nombreevento.Name = "txt_nombreevento"
        Me.txt_nombreevento.Size = New System.Drawing.Size(201, 20)
        Me.txt_nombreevento.TabIndex = 54
        '
        'lbl_NombreEvento
        '
        '
        '
        '
        Me.lbl_NombreEvento.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_NombreEvento.Location = New System.Drawing.Point(34, 91)
        Me.lbl_NombreEvento.Name = "lbl_NombreEvento"
        Me.lbl_NombreEvento.Size = New System.Drawing.Size(110, 23)
        Me.lbl_NombreEvento.TabIndex = 53
        Me.lbl_NombreEvento.Text = "Nombre del Evento"
        '
        'lbl_precioPersona
        '
        '
        '
        '
        Me.lbl_precioPersona.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_precioPersona.Location = New System.Drawing.Point(311, 200)
        Me.lbl_precioPersona.Name = "lbl_precioPersona"
        Me.lbl_precioPersona.Size = New System.Drawing.Size(139, 17)
        Me.lbl_precioPersona.TabIndex = 55
        Me.lbl_precioPersona.Text = "Precio por Persona"
        Me.lbl_precioPersona.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'lbl_ResultadoPrecioPersona
        '
        '
        '
        '
        Me.lbl_ResultadoPrecioPersona.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_ResultadoPrecioPersona.Location = New System.Drawing.Point(456, 201)
        Me.lbl_ResultadoPrecioPersona.Name = "lbl_ResultadoPrecioPersona"
        Me.lbl_ResultadoPrecioPersona.Size = New System.Drawing.Size(53, 16)
        Me.lbl_ResultadoPrecioPersona.TabIndex = 56
        Me.lbl_ResultadoPrecioPersona.Text = "0"
        '
        'btn_cerrar
        '
        Me.btn_cerrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_cerrar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_cerrar.Location = New System.Drawing.Point(452, 454)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(131, 32)
        Me.btn_cerrar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_cerrar.TabIndex = 57
        Me.btn_cerrar.Text = "Cerrar"
        '
        'Frm_Presupuesto
        '
        Me.ClientSize = New System.Drawing.Size(623, 539)
        Me.Controls.Add(Me.btn_cerrar)
        Me.Controls.Add(Me.lbl_ResultadoPrecioPersona)
        Me.Controls.Add(Me.lbl_precioPersona)
        Me.Controls.Add(Me.txt_nombreevento)
        Me.Controls.Add(Me.lbl_NombreEvento)
        Me.Controls.Add(Me.txt_cantPersonas)
        Me.Controls.Add(Me.lbl_CantPersonas)
        Me.Controls.Add(Me.cmb_Localidad)
        Me.Controls.Add(Me.btn_AltaCliente)
        Me.Controls.Add(Me.btn_GenerarPresupuesto)
        Me.Controls.Add(Me.txt_Comentarios)
        Me.Controls.Add(Me.lbl_Comentarios)
        Me.Controls.Add(Me.dt_FechaEvento)
        Me.Controls.Add(Me.lbl_FechaEvento)
        Me.Controls.Add(Me.Btn_SeleccionMenu)
        Me.Controls.Add(Me.rd_party)
        Me.Controls.Add(Me.rd_coffeeBreak)
        Me.Controls.Add(Me.rd_brunch)
        Me.Controls.Add(Me.rd_Fiestas)
        Me.Controls.Add(Me.rd_breakfast)
        Me.Controls.Add(Me.lbl_tipoCatering)
        Me.Controls.Add(Me.lbl_localidad)
        Me.Controls.Add(Me.txt_DireccionEvento)
        Me.Controls.Add(Me.lbl_direccionEvento)
        Me.Controls.Add(Me.cmb_Clientes)
        Me.Controls.Add(Me.lbl_cliente)
        Me.Controls.Add(Me.lbl_solicitudPresupuesto)
        Me.Name = "Frm_Presupuesto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Presupuesto"
        CType(Me.dt_FechaEvento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_solicitudPresupuesto As System.Windows.Forms.Label
    Friend WithEvents lbl_cliente As System.Windows.Forms.Label
    Friend WithEvents cmb_Clientes As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents btn_GenerarPresupuesto As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txt_Comentarios As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbl_Comentarios As DevComponents.DotNetBar.LabelX
    Friend WithEvents dt_FechaEvento As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents lbl_FechaEvento As DevComponents.DotNetBar.LabelX
    Friend WithEvents Btn_SeleccionMenu As DevComponents.DotNetBar.ButtonX
    Friend WithEvents rd_party As System.Windows.Forms.RadioButton
    Friend WithEvents rd_coffeeBreak As System.Windows.Forms.RadioButton
    Friend WithEvents rd_brunch As System.Windows.Forms.RadioButton
    Friend WithEvents rd_Fiestas As System.Windows.Forms.RadioButton
    Friend WithEvents rd_breakfast As System.Windows.Forms.RadioButton
    Friend WithEvents lbl_tipoCatering As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbl_localidad As DevComponents.DotNetBar.LabelX
    Friend WithEvents txt_DireccionEvento As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbl_direccionEvento As DevComponents.DotNetBar.LabelX
    Friend WithEvents btn_AltaCliente As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmb_Localidad As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents txt_cantPersonas As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbl_CantPersonas As DevComponents.DotNetBar.LabelX
    Friend WithEvents txt_nombreevento As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbl_NombreEvento As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbl_precioPersona As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbl_ResultadoPrecioPersona As DevComponents.DotNetBar.LabelX
    Friend WithEvents btn_cerrar As DevComponents.DotNetBar.ButtonX
End Class
