<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_CronogramaEventos
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
        Me.btn_buscar = New DevComponents.DotNetBar.ButtonX()
        Me.btn_cerrar = New DevComponents.DotNetBar.ButtonX()
        Me.dt_eventos = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.dti_fechaHasta = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.dti_Fechadesde = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.lbl_fechaHasta = New DevComponents.DotNetBar.LabelX()
        Me.lbl_FechaDesde = New DevComponents.DotNetBar.LabelX()
        Me.lbl_CronogramaEventos = New System.Windows.Forms.Label()
        CType(Me.dt_eventos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dti_fechaHasta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dti_Fechadesde, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_buscar
        '
        Me.btn_buscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_buscar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_buscar.Location = New System.Drawing.Point(766, 44)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(131, 32)
        Me.btn_buscar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_buscar.TabIndex = 21
        Me.btn_buscar.Text = "Buscar"
        '
        'btn_cerrar
        '
        Me.btn_cerrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_cerrar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_cerrar.Location = New System.Drawing.Point(766, 432)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(131, 32)
        Me.btn_cerrar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_cerrar.TabIndex = 20
        Me.btn_cerrar.Text = "Cerrar"
        '
        'dt_eventos
        '
        Me.dt_eventos.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.dt_eventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dt_eventos.DefaultCellStyle = DataGridViewCellStyle1
        Me.dt_eventos.GridColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.dt_eventos.Location = New System.Drawing.Point(12, 100)
        Me.dt_eventos.Name = "dt_eventos"
        Me.dt_eventos.ReadOnly = True
        Me.dt_eventos.Size = New System.Drawing.Size(885, 312)
        Me.dt_eventos.TabIndex = 19
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
        Me.dti_fechaHasta.Location = New System.Drawing.Point(500, 53)
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
        Me.dti_fechaHasta.TabIndex = 16
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
        Me.dti_Fechadesde.Location = New System.Drawing.Point(120, 52)
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
        Me.dti_Fechadesde.TabIndex = 15
        '
        'lbl_fechaHasta
        '
        '
        '
        '
        Me.lbl_fechaHasta.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_fechaHasta.Location = New System.Drawing.Point(401, 53)
        Me.lbl_fechaHasta.Name = "lbl_fechaHasta"
        Me.lbl_fechaHasta.Size = New System.Drawing.Size(73, 23)
        Me.lbl_fechaHasta.TabIndex = 12
        Me.lbl_fechaHasta.Text = "Fecha Hasta"
        Me.lbl_fechaHasta.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'lbl_FechaDesde
        '
        '
        '
        '
        Me.lbl_FechaDesde.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_FechaDesde.Location = New System.Drawing.Point(21, 52)
        Me.lbl_FechaDesde.Name = "lbl_FechaDesde"
        Me.lbl_FechaDesde.Size = New System.Drawing.Size(73, 23)
        Me.lbl_FechaDesde.TabIndex = 11
        Me.lbl_FechaDesde.Text = "Fecha Desde"
        Me.lbl_FechaDesde.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'lbl_CronogramaEventos
        '
        Me.lbl_CronogramaEventos.AutoSize = True
        Me.lbl_CronogramaEventos.Font = New System.Drawing.Font("Tempus Sans ITC", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CronogramaEventos.Location = New System.Drawing.Point(319, 9)
        Me.lbl_CronogramaEventos.Name = "lbl_CronogramaEventos"
        Me.lbl_CronogramaEventos.Size = New System.Drawing.Size(276, 31)
        Me.lbl_CronogramaEventos.TabIndex = 75
        Me.lbl_CronogramaEventos.Text = "Cronograma de Eventos"
        Me.lbl_CronogramaEventos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Frm_CronogramaEventos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(909, 473)
        Me.Controls.Add(Me.lbl_CronogramaEventos)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.btn_cerrar)
        Me.Controls.Add(Me.dt_eventos)
        Me.Controls.Add(Me.dti_fechaHasta)
        Me.Controls.Add(Me.dti_Fechadesde)
        Me.Controls.Add(Me.lbl_fechaHasta)
        Me.Controls.Add(Me.lbl_FechaDesde)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Frm_CronogramaEventos"
        Me.Text = "MetroForm"
        CType(Me.dt_eventos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dti_fechaHasta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dti_Fechadesde, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_buscar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn_cerrar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dt_eventos As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents dti_fechaHasta As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents dti_Fechadesde As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents lbl_fechaHasta As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbl_FechaDesde As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbl_CronogramaEventos As System.Windows.Forms.Label
End Class
