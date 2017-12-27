<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_SeleccionMenu
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
        Me.Chk_Entrada = New System.Windows.Forms.CheckedListBox()
        Me.lbl_entrada = New System.Windows.Forms.Label()
        Me.lbl_platoPrincipal = New System.Windows.Forms.Label()
        Me.Chk_platoPrincipal = New System.Windows.Forms.CheckedListBox()
        Me.lbl_postre = New System.Windows.Forms.Label()
        Me.chk_postre = New System.Windows.Forms.CheckedListBox()
        Me.lbl_bebida = New System.Windows.Forms.Label()
        Me.lbl_PrecioEntrada = New DevComponents.DotNetBar.LabelX()
        Me.lbl_ResultadoPrecioEntrada = New DevComponents.DotNetBar.LabelX()
        Me.lbl_ResultadoprecioPlatoPrincipal = New DevComponents.DotNetBar.LabelX()
        Me.lbl_precioPlatoPrincipal = New DevComponents.DotNetBar.LabelX()
        Me.lbl_ResultadoPrecioPostre = New DevComponents.DotNetBar.LabelX()
        Me.lbl_PrecioPostre = New DevComponents.DotNetBar.LabelX()
        Me.lbl_ResultadoPrecioBebida = New DevComponents.DotNetBar.LabelX()
        Me.lbl_precioBebida = New DevComponents.DotNetBar.LabelX()
        Me.lbl_PrecioTotal = New DevComponents.DotNetBar.LabelX()
        Me.lbl_preciototalEntradaPersona = New DevComponents.DotNetBar.LabelX()
        Me.btn_aceptar = New DevComponents.DotNetBar.ButtonX()
        Me.btn_cerrar = New DevComponents.DotNetBar.ButtonX()
        Me.chk_bebida = New System.Windows.Forms.CheckedListBox()
        Me.lbl_seleccionMenu = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Chk_Entrada
        '
        Me.Chk_Entrada.FormattingEnabled = True
        Me.Chk_Entrada.HorizontalScrollbar = True
        Me.Chk_Entrada.Location = New System.Drawing.Point(12, 89)
        Me.Chk_Entrada.Name = "Chk_Entrada"
        Me.Chk_Entrada.ScrollAlwaysVisible = True
        Me.Chk_Entrada.Size = New System.Drawing.Size(222, 225)
        Me.Chk_Entrada.TabIndex = 0
        '
        'lbl_entrada
        '
        Me.lbl_entrada.AutoSize = True
        Me.lbl_entrada.Location = New System.Drawing.Point(94, 70)
        Me.lbl_entrada.Name = "lbl_entrada"
        Me.lbl_entrada.Size = New System.Drawing.Size(47, 13)
        Me.lbl_entrada.TabIndex = 1
        Me.lbl_entrada.Text = "Entrada"
        '
        'lbl_platoPrincipal
        '
        Me.lbl_platoPrincipal.AutoSize = True
        Me.lbl_platoPrincipal.Location = New System.Drawing.Point(304, 70)
        Me.lbl_platoPrincipal.Name = "lbl_platoPrincipal"
        Me.lbl_platoPrincipal.Size = New System.Drawing.Size(80, 13)
        Me.lbl_platoPrincipal.TabIndex = 3
        Me.lbl_platoPrincipal.Text = "Plato Principal"
        '
        'Chk_platoPrincipal
        '
        Me.Chk_platoPrincipal.FormattingEnabled = True
        Me.Chk_platoPrincipal.HorizontalScrollbar = True
        Me.Chk_platoPrincipal.Location = New System.Drawing.Point(240, 89)
        Me.Chk_platoPrincipal.Name = "Chk_platoPrincipal"
        Me.Chk_platoPrincipal.ScrollAlwaysVisible = True
        Me.Chk_platoPrincipal.Size = New System.Drawing.Size(222, 225)
        Me.Chk_platoPrincipal.TabIndex = 2
        '
        'lbl_postre
        '
        Me.lbl_postre.AutoSize = True
        Me.lbl_postre.Location = New System.Drawing.Point(550, 70)
        Me.lbl_postre.Name = "lbl_postre"
        Me.lbl_postre.Size = New System.Drawing.Size(39, 13)
        Me.lbl_postre.TabIndex = 5
        Me.lbl_postre.Text = "Postre"
        '
        'chk_postre
        '
        Me.chk_postre.FormattingEnabled = True
        Me.chk_postre.HorizontalScrollbar = True
        Me.chk_postre.Location = New System.Drawing.Point(468, 89)
        Me.chk_postre.Name = "chk_postre"
        Me.chk_postre.ScrollAlwaysVisible = True
        Me.chk_postre.Size = New System.Drawing.Size(225, 225)
        Me.chk_postre.TabIndex = 4
        '
        'lbl_bebida
        '
        Me.lbl_bebida.AutoSize = True
        Me.lbl_bebida.Location = New System.Drawing.Point(783, 70)
        Me.lbl_bebida.Name = "lbl_bebida"
        Me.lbl_bebida.Size = New System.Drawing.Size(43, 13)
        Me.lbl_bebida.TabIndex = 9
        Me.lbl_bebida.Text = "Bebida"
        '
        'lbl_PrecioEntrada
        '
        '
        '
        '
        Me.lbl_PrecioEntrada.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_PrecioEntrada.Location = New System.Drawing.Point(42, 320)
        Me.lbl_PrecioEntrada.Name = "lbl_PrecioEntrada"
        Me.lbl_PrecioEntrada.Size = New System.Drawing.Size(75, 23)
        Me.lbl_PrecioEntrada.TabIndex = 10
        Me.lbl_PrecioEntrada.Text = "Precio"
        '
        'lbl_ResultadoPrecioEntrada
        '
        '
        '
        '
        Me.lbl_ResultadoPrecioEntrada.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_ResultadoPrecioEntrada.Location = New System.Drawing.Point(106, 320)
        Me.lbl_ResultadoPrecioEntrada.Name = "lbl_ResultadoPrecioEntrada"
        Me.lbl_ResultadoPrecioEntrada.Size = New System.Drawing.Size(75, 23)
        Me.lbl_ResultadoPrecioEntrada.TabIndex = 11
        '
        'lbl_ResultadoprecioPlatoPrincipal
        '
        '
        '
        '
        Me.lbl_ResultadoprecioPlatoPrincipal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_ResultadoprecioPlatoPrincipal.Location = New System.Drawing.Point(335, 320)
        Me.lbl_ResultadoprecioPlatoPrincipal.Name = "lbl_ResultadoprecioPlatoPrincipal"
        Me.lbl_ResultadoprecioPlatoPrincipal.Size = New System.Drawing.Size(75, 23)
        Me.lbl_ResultadoprecioPlatoPrincipal.TabIndex = 13
        '
        'lbl_precioPlatoPrincipal
        '
        '
        '
        '
        Me.lbl_precioPlatoPrincipal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_precioPlatoPrincipal.Location = New System.Drawing.Point(271, 320)
        Me.lbl_precioPlatoPrincipal.Name = "lbl_precioPlatoPrincipal"
        Me.lbl_precioPlatoPrincipal.Size = New System.Drawing.Size(75, 23)
        Me.lbl_precioPlatoPrincipal.TabIndex = 12
        Me.lbl_precioPlatoPrincipal.Text = "Precio"
        '
        'lbl_ResultadoPrecioPostre
        '
        '
        '
        '
        Me.lbl_ResultadoPrecioPostre.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_ResultadoPrecioPostre.Location = New System.Drawing.Point(578, 320)
        Me.lbl_ResultadoPrecioPostre.Name = "lbl_ResultadoPrecioPostre"
        Me.lbl_ResultadoPrecioPostre.Size = New System.Drawing.Size(75, 23)
        Me.lbl_ResultadoPrecioPostre.TabIndex = 15
        '
        'lbl_PrecioPostre
        '
        '
        '
        '
        Me.lbl_PrecioPostre.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_PrecioPostre.Location = New System.Drawing.Point(514, 320)
        Me.lbl_PrecioPostre.Name = "lbl_PrecioPostre"
        Me.lbl_PrecioPostre.Size = New System.Drawing.Size(75, 23)
        Me.lbl_PrecioPostre.TabIndex = 14
        Me.lbl_PrecioPostre.Text = "Precio"
        '
        'lbl_ResultadoPrecioBebida
        '
        '
        '
        '
        Me.lbl_ResultadoPrecioBebida.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_ResultadoPrecioBebida.Location = New System.Drawing.Point(794, 320)
        Me.lbl_ResultadoPrecioBebida.Name = "lbl_ResultadoPrecioBebida"
        Me.lbl_ResultadoPrecioBebida.Size = New System.Drawing.Size(75, 23)
        Me.lbl_ResultadoPrecioBebida.TabIndex = 17
        '
        'lbl_precioBebida
        '
        '
        '
        '
        Me.lbl_precioBebida.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_precioBebida.Location = New System.Drawing.Point(730, 320)
        Me.lbl_precioBebida.Name = "lbl_precioBebida"
        Me.lbl_precioBebida.Size = New System.Drawing.Size(75, 23)
        Me.lbl_precioBebida.TabIndex = 16
        Me.lbl_precioBebida.Text = "Precio"
        '
        'lbl_PrecioTotal
        '
        '
        '
        '
        Me.lbl_PrecioTotal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_PrecioTotal.Location = New System.Drawing.Point(553, 457)
        Me.lbl_PrecioTotal.Name = "lbl_PrecioTotal"
        Me.lbl_PrecioTotal.Size = New System.Drawing.Size(75, 23)
        Me.lbl_PrecioTotal.TabIndex = 19
        Me.lbl_PrecioTotal.Text = "0"
        '
        'lbl_preciototalEntradaPersona
        '
        '
        '
        '
        Me.lbl_preciototalEntradaPersona.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_preciototalEntradaPersona.Location = New System.Drawing.Point(355, 457)
        Me.lbl_preciototalEntradaPersona.Name = "lbl_preciototalEntradaPersona"
        Me.lbl_preciototalEntradaPersona.Size = New System.Drawing.Size(158, 23)
        Me.lbl_preciototalEntradaPersona.TabIndex = 18
        Me.lbl_preciototalEntradaPersona.Text = "Precio Total por Persona"
        '
        'btn_aceptar
        '
        Me.btn_aceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_aceptar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_aceptar.Location = New System.Drawing.Point(699, 447)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(107, 34)
        Me.btn_aceptar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_aceptar.TabIndex = 20
        Me.btn_aceptar.Text = "Aceptar"
        '
        'btn_cerrar
        '
        Me.btn_cerrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_cerrar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_cerrar.Location = New System.Drawing.Point(842, 446)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(39, 34)
        Me.btn_cerrar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_cerrar.TabIndex = 21
        Me.btn_cerrar.Text = "Cerrar"
        '
        'chk_bebida
        '
        Me.chk_bebida.FormattingEnabled = True
        Me.chk_bebida.HorizontalScrollbar = True
        Me.chk_bebida.Location = New System.Drawing.Point(699, 89)
        Me.chk_bebida.Name = "chk_bebida"
        Me.chk_bebida.ScrollAlwaysVisible = True
        Me.chk_bebida.Size = New System.Drawing.Size(222, 225)
        Me.chk_bebida.TabIndex = 22
        '
        'lbl_seleccionMenu
        '
        Me.lbl_seleccionMenu.AutoSize = True
        Me.lbl_seleccionMenu.Font = New System.Drawing.Font("Tempus Sans ITC", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_seleccionMenu.Location = New System.Drawing.Point(349, 20)
        Me.lbl_seleccionMenu.Name = "lbl_seleccionMenu"
        Me.lbl_seleccionMenu.Size = New System.Drawing.Size(218, 31)
        Me.lbl_seleccionMenu.TabIndex = 75
        Me.lbl_seleccionMenu.Text = "Seleccion de Menu"
        Me.lbl_seleccionMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Frm_SeleccionMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(923, 493)
        Me.Controls.Add(Me.lbl_seleccionMenu)
        Me.Controls.Add(Me.chk_bebida)
        Me.Controls.Add(Me.btn_cerrar)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.lbl_PrecioTotal)
        Me.Controls.Add(Me.lbl_preciototalEntradaPersona)
        Me.Controls.Add(Me.lbl_ResultadoPrecioBebida)
        Me.Controls.Add(Me.lbl_precioBebida)
        Me.Controls.Add(Me.lbl_ResultadoPrecioPostre)
        Me.Controls.Add(Me.lbl_PrecioPostre)
        Me.Controls.Add(Me.lbl_ResultadoprecioPlatoPrincipal)
        Me.Controls.Add(Me.lbl_precioPlatoPrincipal)
        Me.Controls.Add(Me.lbl_ResultadoPrecioEntrada)
        Me.Controls.Add(Me.lbl_PrecioEntrada)
        Me.Controls.Add(Me.lbl_bebida)
        Me.Controls.Add(Me.lbl_postre)
        Me.Controls.Add(Me.chk_postre)
        Me.Controls.Add(Me.lbl_platoPrincipal)
        Me.Controls.Add(Me.Chk_platoPrincipal)
        Me.Controls.Add(Me.lbl_entrada)
        Me.Controls.Add(Me.Chk_Entrada)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Frm_SeleccionMenu"
        Me.Text = "MetroForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Chk_Entrada As System.Windows.Forms.CheckedListBox
    Friend WithEvents lbl_entrada As System.Windows.Forms.Label
    Friend WithEvents lbl_platoPrincipal As System.Windows.Forms.Label
    Friend WithEvents Chk_platoPrincipal As System.Windows.Forms.CheckedListBox
    Friend WithEvents lbl_postre As System.Windows.Forms.Label
    Friend WithEvents chk_postre As System.Windows.Forms.CheckedListBox
    Friend WithEvents lbl_bebida As System.Windows.Forms.Label
    Friend WithEvents lbl_PrecioEntrada As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbl_ResultadoPrecioEntrada As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbl_ResultadoprecioPlatoPrincipal As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbl_precioPlatoPrincipal As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbl_ResultadoPrecioPostre As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbl_PrecioPostre As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbl_ResultadoPrecioBebida As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbl_precioBebida As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbl_PrecioTotal As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbl_preciototalEntradaPersona As DevComponents.DotNetBar.LabelX
    Friend WithEvents btn_aceptar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn_cerrar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents chk_bebida As System.Windows.Forms.CheckedListBox
    Friend WithEvents lbl_seleccionMenu As System.Windows.Forms.Label
End Class
