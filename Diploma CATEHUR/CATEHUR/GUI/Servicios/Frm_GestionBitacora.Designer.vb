<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_GestionBitacora
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
        Me.lbl_FechaDesde = New DevComponents.DotNetBar.LabelX()
        Me.lbl_fechaHasta = New DevComponents.DotNetBar.LabelX()
        Me.lbl_usuario = New DevComponents.DotNetBar.LabelX()
        Me.lbl_Descripcion = New DevComponents.DotNetBar.LabelX()
        Me.dti_Fechadesde = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.dti_fechaHasta = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.Cmb_usuario = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cmb_Descripcion = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.grilla_bitacora = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.btn_cerrar = New DevComponents.DotNetBar.ButtonX()
        Me.btn_buscar = New DevComponents.DotNetBar.ButtonX()
        CType(Me.dti_Fechadesde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dti_fechaHasta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grilla_bitacora, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_FechaDesde
        '
        '
        '
        '
        Me.lbl_FechaDesde.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_FechaDesde.Location = New System.Drawing.Point(34, 15)
        Me.lbl_FechaDesde.Name = "lbl_FechaDesde"
        Me.lbl_FechaDesde.Size = New System.Drawing.Size(73, 23)
        Me.lbl_FechaDesde.TabIndex = 0
        Me.lbl_FechaDesde.Text = "Fecha Desde"
        Me.lbl_FechaDesde.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'lbl_fechaHasta
        '
        '
        '
        '
        Me.lbl_fechaHasta.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_fechaHasta.Location = New System.Drawing.Point(34, 43)
        Me.lbl_fechaHasta.Name = "lbl_fechaHasta"
        Me.lbl_fechaHasta.Size = New System.Drawing.Size(73, 23)
        Me.lbl_fechaHasta.TabIndex = 1
        Me.lbl_fechaHasta.Text = "Fecha Hasta"
        Me.lbl_fechaHasta.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'lbl_usuario
        '
        '
        '
        '
        Me.lbl_usuario.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_usuario.Location = New System.Drawing.Point(34, 103)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(73, 23)
        Me.lbl_usuario.TabIndex = 2
        Me.lbl_usuario.Text = "Usuario"
        Me.lbl_usuario.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'lbl_Descripcion
        '
        '
        '
        '
        Me.lbl_Descripcion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_Descripcion.Location = New System.Drawing.Point(14, 132)
        Me.lbl_Descripcion.Name = "lbl_Descripcion"
        Me.lbl_Descripcion.Size = New System.Drawing.Size(93, 23)
        Me.lbl_Descripcion.TabIndex = 3
        Me.lbl_Descripcion.Text = "Descripcion"
        Me.lbl_Descripcion.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'dti_Fechadesde
        '
        '
        '
        '
        Me.dti_Fechadesde.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dti_Fechadesde.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dti_Fechadesde.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dti_Fechadesde.ButtonDropDown.Visible = True
        Me.dti_Fechadesde.IsPopupCalendarOpen = False
        Me.dti_Fechadesde.Location = New System.Drawing.Point(141, 15)
        '
        '
        '
        Me.dti_Fechadesde.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dti_Fechadesde.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dti_Fechadesde.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.dti_Fechadesde.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dti_Fechadesde.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dti_Fechadesde.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dti_Fechadesde.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dti_Fechadesde.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dti_Fechadesde.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dti_Fechadesde.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dti_Fechadesde.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dti_Fechadesde.MonthCalendar.DisplayMonth = New Date(2017, 7, 1, 0, 0, 0, 0)
        Me.dti_Fechadesde.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dti_Fechadesde.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dti_Fechadesde.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dti_Fechadesde.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dti_Fechadesde.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dti_Fechadesde.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dti_Fechadesde.MonthCalendar.TodayButtonVisible = True
        Me.dti_Fechadesde.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dti_Fechadesde.Name = "dti_Fechadesde"
        Me.dti_Fechadesde.Size = New System.Drawing.Size(200, 22)
        Me.dti_Fechadesde.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dti_Fechadesde.TabIndex = 4
        '
        'dti_fechaHasta
        '
        '
        '
        '
        Me.dti_fechaHasta.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dti_fechaHasta.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dti_fechaHasta.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dti_fechaHasta.ButtonDropDown.Visible = True
        Me.dti_fechaHasta.IsPopupCalendarOpen = False
        Me.dti_fechaHasta.Location = New System.Drawing.Point(141, 43)
        '
        '
        '
        Me.dti_fechaHasta.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dti_fechaHasta.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dti_fechaHasta.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.dti_fechaHasta.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dti_fechaHasta.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dti_fechaHasta.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dti_fechaHasta.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dti_fechaHasta.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dti_fechaHasta.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dti_fechaHasta.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dti_fechaHasta.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dti_fechaHasta.MonthCalendar.DisplayMonth = New Date(2017, 7, 1, 0, 0, 0, 0)
        Me.dti_fechaHasta.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dti_fechaHasta.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dti_fechaHasta.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dti_fechaHasta.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dti_fechaHasta.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dti_fechaHasta.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dti_fechaHasta.MonthCalendar.TodayButtonVisible = True
        Me.dti_fechaHasta.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dti_fechaHasta.Name = "dti_fechaHasta"
        Me.dti_fechaHasta.Size = New System.Drawing.Size(200, 22)
        Me.dti_fechaHasta.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dti_fechaHasta.TabIndex = 5
        '
        'Cmb_usuario
        '
        Me.Cmb_usuario.DisplayMember = "Text"
        Me.Cmb_usuario.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Cmb_usuario.FormattingEnabled = True
        Me.Cmb_usuario.ItemHeight = 16
        Me.Cmb_usuario.Location = New System.Drawing.Point(141, 105)
        Me.Cmb_usuario.Name = "Cmb_usuario"
        Me.Cmb_usuario.Size = New System.Drawing.Size(200, 22)
        Me.Cmb_usuario.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Cmb_usuario.TabIndex = 6
        '
        'cmb_Descripcion
        '
        Me.cmb_Descripcion.DisplayMember = "Text"
        Me.cmb_Descripcion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_Descripcion.FormattingEnabled = True
        Me.cmb_Descripcion.ItemHeight = 16
        Me.cmb_Descripcion.Location = New System.Drawing.Point(141, 133)
        Me.cmb_Descripcion.Name = "cmb_Descripcion"
        Me.cmb_Descripcion.Size = New System.Drawing.Size(200, 22)
        Me.cmb_Descripcion.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmb_Descripcion.TabIndex = 7
        '
        'grilla_bitacora
        '
        Me.grilla_bitacora.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.grilla_bitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grilla_bitacora.DefaultCellStyle = DataGridViewCellStyle1
        Me.grilla_bitacora.GridColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grilla_bitacora.Location = New System.Drawing.Point(371, 15)
        Me.grilla_bitacora.Name = "grilla_bitacora"
        Me.grilla_bitacora.ReadOnly = True
        Me.grilla_bitacora.Size = New System.Drawing.Size(563, 255)
        Me.grilla_bitacora.TabIndex = 8
        '
        'btn_cerrar
        '
        Me.btn_cerrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_cerrar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_cerrar.Location = New System.Drawing.Point(60, 235)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(113, 32)
        Me.btn_cerrar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_cerrar.TabIndex = 9
        Me.btn_cerrar.Text = "Cerrar"
        '
        'btn_buscar
        '
        Me.btn_buscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_buscar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_buscar.Location = New System.Drawing.Point(210, 235)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(131, 32)
        Me.btn_buscar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_buscar.TabIndex = 10
        Me.btn_buscar.Text = "Buscar"
        '
        'Frm_GestionBitacora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(946, 279)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.btn_cerrar)
        Me.Controls.Add(Me.grilla_bitacora)
        Me.Controls.Add(Me.cmb_Descripcion)
        Me.Controls.Add(Me.Cmb_usuario)
        Me.Controls.Add(Me.dti_fechaHasta)
        Me.Controls.Add(Me.dti_Fechadesde)
        Me.Controls.Add(Me.lbl_Descripcion)
        Me.Controls.Add(Me.lbl_usuario)
        Me.Controls.Add(Me.lbl_fechaHasta)
        Me.Controls.Add(Me.lbl_FechaDesde)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Frm_GestionBitacora"
        Me.Text = "MetroForm"
        CType(Me.dti_Fechadesde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dti_fechaHasta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grilla_bitacora, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_FechaDesde As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbl_fechaHasta As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbl_usuario As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbl_Descripcion As DevComponents.DotNetBar.LabelX
    Friend WithEvents dti_Fechadesde As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents dti_fechaHasta As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents Cmb_usuario As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cmb_Descripcion As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents grilla_bitacora As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents btn_cerrar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn_buscar As DevComponents.DotNetBar.ButtonX
End Class
