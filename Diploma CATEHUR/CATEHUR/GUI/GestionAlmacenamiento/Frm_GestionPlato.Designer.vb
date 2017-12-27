<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_GestionPlato
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
        Me.lbl_id_plato = New DevComponents.DotNetBar.LabelX()
        Me.lbl_idPlato = New DevComponents.DotNetBar.LabelX()
        Me.cmb_TipoMenu = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.lbl_tipoMenu = New DevComponents.DotNetBar.LabelX()
        Me.btn_cerrar = New DevComponents.DotNetBar.ButtonX()
        Me.btn_baja = New DevComponents.DotNetBar.ButtonX()
        Me.btn_Modificar = New DevComponents.DotNetBar.ButtonX()
        Me.btn_alta = New DevComponents.DotNetBar.ButtonX()
        Me.Dt_Platos = New System.Windows.Forms.DataGridView()
        Me.txt_precio = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbl_precio = New DevComponents.DotNetBar.LabelX()
        Me.txt_manoDeObra = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbl_manodeobra = New DevComponents.DotNetBar.LabelX()
        Me.txt_nombrePlato = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbl_nombrePlato = New DevComponents.DotNetBar.LabelX()
        Me.lbl_elaboracionPlatos = New System.Windows.Forms.Label()
        Me.lbl_listaIngredientes = New System.Windows.Forms.Label()
        Me.dt_ingredientes = New System.Windows.Forms.DataGridView()
        Me.Btn_QuitarIngrediente = New DevComponents.DotNetBar.ButtonX()
        Me.txt_precioIngrediente = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbl_precioIngrediente = New DevComponents.DotNetBar.LabelX()
        Me.lbl_ingrediente = New DevComponents.DotNetBar.LabelX()
        Me.txt_CantIngrediente = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbl_cantidad = New DevComponents.DotNetBar.LabelX()
        Me.btn_AgregarIngrediente = New DevComponents.DotNetBar.ButtonX()
        Me.cmb_Ingrediente = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.lbl_catering = New DevComponents.DotNetBar.LabelX()
        Me.btn_asignarCatering = New DevComponents.DotNetBar.ButtonX()
        Me.cmb_catering = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.btn_quitarCatering = New DevComponents.DotNetBar.ButtonX()
        Me.dt_catering = New System.Windows.Forms.DataGridView()
        Me.lbl_CateringAsignados = New System.Windows.Forms.Label()
        Me.lbl_listaPlatos = New DevComponents.DotNetBar.LabelX()
        CType(Me.Dt_Platos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_ingredientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_catering, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_id_plato
        '
        '
        '
        '
        Me.lbl_id_plato.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_id_plato.Location = New System.Drawing.Point(137, 71)
        Me.lbl_id_plato.Name = "lbl_id_plato"
        Me.lbl_id_plato.Size = New System.Drawing.Size(110, 23)
        Me.lbl_id_plato.TabIndex = 72
        '
        'lbl_idPlato
        '
        '
        '
        '
        Me.lbl_idPlato.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_idPlato.Location = New System.Drawing.Point(23, 71)
        Me.lbl_idPlato.Name = "lbl_idPlato"
        Me.lbl_idPlato.Size = New System.Drawing.Size(110, 23)
        Me.lbl_idPlato.TabIndex = 71
        Me.lbl_idPlato.Text = "Id_Plato"
        '
        'cmb_TipoMenu
        '
        Me.cmb_TipoMenu.DisplayMember = "Text"
        Me.cmb_TipoMenu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_TipoMenu.FormattingEnabled = True
        Me.cmb_TipoMenu.ItemHeight = 16
        Me.cmb_TipoMenu.Location = New System.Drawing.Point(137, 257)
        Me.cmb_TipoMenu.Name = "cmb_TipoMenu"
        Me.cmb_TipoMenu.Size = New System.Drawing.Size(203, 22)
        Me.cmb_TipoMenu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmb_TipoMenu.TabIndex = 70
        '
        'lbl_tipoMenu
        '
        '
        '
        '
        Me.lbl_tipoMenu.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_tipoMenu.Location = New System.Drawing.Point(21, 256)
        Me.lbl_tipoMenu.Name = "lbl_tipoMenu"
        Me.lbl_tipoMenu.Size = New System.Drawing.Size(64, 23)
        Me.lbl_tipoMenu.TabIndex = 69
        Me.lbl_tipoMenu.Text = "Tipo Menu"
        '
        'btn_cerrar
        '
        Me.btn_cerrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_cerrar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_cerrar.Location = New System.Drawing.Point(1094, 586)
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
        Me.btn_baja.Location = New System.Drawing.Point(1018, 454)
        Me.btn_baja.Name = "btn_baja"
        Me.btn_baja.Size = New System.Drawing.Size(90, 63)
        Me.btn_baja.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_baja.TabIndex = 67
        Me.btn_baja.Text = "Baja"
        '
        'btn_Modificar
        '
        Me.btn_Modificar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_Modificar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_Modificar.Location = New System.Drawing.Point(895, 454)
        Me.btn_Modificar.Name = "btn_Modificar"
        Me.btn_Modificar.Size = New System.Drawing.Size(97, 63)
        Me.btn_Modificar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_Modificar.TabIndex = 66
        Me.btn_Modificar.Text = "Modificar"
        '
        'btn_alta
        '
        Me.btn_alta.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_alta.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_alta.Location = New System.Drawing.Point(774, 454)
        Me.btn_alta.Name = "btn_alta"
        Me.btn_alta.Size = New System.Drawing.Size(101, 63)
        Me.btn_alta.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_alta.TabIndex = 65
        Me.btn_alta.Text = "Alta"
        '
        'Dt_Platos
        '
        Me.Dt_Platos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dt_Platos.Location = New System.Drawing.Point(12, 418)
        Me.Dt_Platos.Name = "Dt_Platos"
        Me.Dt_Platos.Size = New System.Drawing.Size(699, 184)
        Me.Dt_Platos.TabIndex = 64
        '
        'txt_precio
        '
        Me.txt_precio.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_precio.Border.Class = "TextBoxBorder"
        Me.txt_precio.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_precio.ForeColor = System.Drawing.Color.Black
        Me.txt_precio.Location = New System.Drawing.Point(137, 314)
        Me.txt_precio.Name = "txt_precio"
        Me.txt_precio.Size = New System.Drawing.Size(201, 22)
        Me.txt_precio.TabIndex = 61
        '
        'lbl_precio
        '
        '
        '
        '
        Me.lbl_precio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_precio.Location = New System.Drawing.Point(21, 314)
        Me.lbl_precio.Name = "lbl_precio"
        Me.lbl_precio.Size = New System.Drawing.Size(110, 23)
        Me.lbl_precio.TabIndex = 60
        Me.lbl_precio.Text = "Precio"
        '
        'txt_manoDeObra
        '
        Me.txt_manoDeObra.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_manoDeObra.Border.Class = "TextBoxBorder"
        Me.txt_manoDeObra.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_manoDeObra.ForeColor = System.Drawing.Color.Black
        Me.txt_manoDeObra.Location = New System.Drawing.Point(137, 200)
        Me.txt_manoDeObra.Name = "txt_manoDeObra"
        Me.txt_manoDeObra.Size = New System.Drawing.Size(201, 22)
        Me.txt_manoDeObra.TabIndex = 57
        '
        'lbl_manodeobra
        '
        '
        '
        '
        Me.lbl_manodeobra.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_manodeobra.Location = New System.Drawing.Point(21, 197)
        Me.lbl_manodeobra.Name = "lbl_manodeobra"
        Me.lbl_manodeobra.Size = New System.Drawing.Size(110, 23)
        Me.lbl_manodeobra.TabIndex = 56
        Me.lbl_manodeobra.Text = "Mano de Obra"
        '
        'txt_nombrePlato
        '
        Me.txt_nombrePlato.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_nombrePlato.Border.Class = "TextBoxBorder"
        Me.txt_nombrePlato.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_nombrePlato.ForeColor = System.Drawing.Color.Black
        Me.txt_nombrePlato.Location = New System.Drawing.Point(139, 141)
        Me.txt_nombrePlato.Name = "txt_nombrePlato"
        Me.txt_nombrePlato.Size = New System.Drawing.Size(201, 22)
        Me.txt_nombrePlato.TabIndex = 55
        '
        'lbl_nombrePlato
        '
        '
        '
        '
        Me.lbl_nombrePlato.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_nombrePlato.Location = New System.Drawing.Point(23, 138)
        Me.lbl_nombrePlato.Name = "lbl_nombrePlato"
        Me.lbl_nombrePlato.Size = New System.Drawing.Size(110, 23)
        Me.lbl_nombrePlato.TabIndex = 54
        Me.lbl_nombrePlato.Text = "Nombre del Plato"
        '
        'lbl_elaboracionPlatos
        '
        Me.lbl_elaboracionPlatos.AutoSize = True
        Me.lbl_elaboracionPlatos.Font = New System.Drawing.Font("Tempus Sans ITC", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_elaboracionPlatos.Location = New System.Drawing.Point(463, 9)
        Me.lbl_elaboracionPlatos.Name = "lbl_elaboracionPlatos"
        Me.lbl_elaboracionPlatos.Size = New System.Drawing.Size(248, 31)
        Me.lbl_elaboracionPlatos.TabIndex = 53
        Me.lbl_elaboracionPlatos.Text = "Elaboracion de Platos"
        Me.lbl_elaboracionPlatos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_listaIngredientes
        '
        Me.lbl_listaIngredientes.AutoSize = True
        Me.lbl_listaIngredientes.Location = New System.Drawing.Point(496, 40)
        Me.lbl_listaIngredientes.Name = "lbl_listaIngredientes"
        Me.lbl_listaIngredientes.Size = New System.Drawing.Size(114, 13)
        Me.lbl_listaIngredientes.TabIndex = 74
        Me.lbl_listaIngredientes.Text = "Lista de Ingredientes"
        '
        'dt_ingredientes
        '
        Me.dt_ingredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dt_ingredientes.Location = New System.Drawing.Point(392, 71)
        Me.dt_ingredientes.Name = "dt_ingredientes"
        Me.dt_ingredientes.Size = New System.Drawing.Size(319, 208)
        Me.dt_ingredientes.TabIndex = 76
        '
        'Btn_QuitarIngrediente
        '
        Me.Btn_QuitarIngrediente.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Btn_QuitarIngrediente.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Btn_QuitarIngrediente.Location = New System.Drawing.Point(557, 371)
        Me.Btn_QuitarIngrediente.Name = "Btn_QuitarIngrediente"
        Me.Btn_QuitarIngrediente.Size = New System.Drawing.Size(128, 25)
        Me.Btn_QuitarIngrediente.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Btn_QuitarIngrediente.TabIndex = 77
        Me.Btn_QuitarIngrediente.Text = "Quitar ingrediente"
        '
        'txt_precioIngrediente
        '
        Me.txt_precioIngrediente.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_precioIngrediente.Border.Class = "TextBoxBorder"
        Me.txt_precioIngrediente.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_precioIngrediente.ForeColor = System.Drawing.Color.Black
        Me.txt_precioIngrediente.Location = New System.Drawing.Point(499, 342)
        Me.txt_precioIngrediente.Name = "txt_precioIngrediente"
        Me.txt_precioIngrediente.Size = New System.Drawing.Size(96, 22)
        Me.txt_precioIngrediente.TabIndex = 84
        '
        'lbl_precioIngrediente
        '
        '
        '
        '
        Me.lbl_precioIngrediente.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_precioIngrediente.Location = New System.Drawing.Point(418, 342)
        Me.lbl_precioIngrediente.Name = "lbl_precioIngrediente"
        Me.lbl_precioIngrediente.Size = New System.Drawing.Size(75, 23)
        Me.lbl_precioIngrediente.TabIndex = 83
        Me.lbl_precioIngrediente.Text = "Precio"
        '
        'lbl_ingrediente
        '
        '
        '
        '
        Me.lbl_ingrediente.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_ingrediente.Location = New System.Drawing.Point(418, 284)
        Me.lbl_ingrediente.Name = "lbl_ingrediente"
        Me.lbl_ingrediente.Size = New System.Drawing.Size(75, 23)
        Me.lbl_ingrediente.TabIndex = 82
        Me.lbl_ingrediente.Text = "Ingrediente"
        '
        'txt_CantIngrediente
        '
        Me.txt_CantIngrediente.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_CantIngrediente.Border.Class = "TextBoxBorder"
        Me.txt_CantIngrediente.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_CantIngrediente.ForeColor = System.Drawing.Color.Black
        Me.txt_CantIngrediente.Location = New System.Drawing.Point(499, 314)
        Me.txt_CantIngrediente.Name = "txt_CantIngrediente"
        Me.txt_CantIngrediente.Size = New System.Drawing.Size(96, 22)
        Me.txt_CantIngrediente.TabIndex = 81
        '
        'lbl_cantidad
        '
        '
        '
        '
        Me.lbl_cantidad.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_cantidad.Location = New System.Drawing.Point(418, 314)
        Me.lbl_cantidad.Name = "lbl_cantidad"
        Me.lbl_cantidad.Size = New System.Drawing.Size(75, 23)
        Me.lbl_cantidad.TabIndex = 80
        Me.lbl_cantidad.Text = "Cantidad"
        '
        'btn_AgregarIngrediente
        '
        Me.btn_AgregarIngrediente.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_AgregarIngrediente.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_AgregarIngrediente.Location = New System.Drawing.Point(418, 371)
        Me.btn_AgregarIngrediente.Name = "btn_AgregarIngrediente"
        Me.btn_AgregarIngrediente.Size = New System.Drawing.Size(113, 25)
        Me.btn_AgregarIngrediente.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_AgregarIngrediente.TabIndex = 79
        Me.btn_AgregarIngrediente.Text = "Agregar Ingrediente"
        '
        'cmb_Ingrediente
        '
        Me.cmb_Ingrediente.DisplayMember = "Text"
        Me.cmb_Ingrediente.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_Ingrediente.FormattingEnabled = True
        Me.cmb_Ingrediente.ItemHeight = 16
        Me.cmb_Ingrediente.Location = New System.Drawing.Point(499, 285)
        Me.cmb_Ingrediente.Name = "cmb_Ingrediente"
        Me.cmb_Ingrediente.Size = New System.Drawing.Size(150, 22)
        Me.cmb_Ingrediente.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmb_Ingrediente.TabIndex = 78
        '
        'lbl_catering
        '
        '
        '
        '
        Me.lbl_catering.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_catering.Location = New System.Drawing.Point(800, 284)
        Me.lbl_catering.Name = "lbl_catering"
        Me.lbl_catering.Size = New System.Drawing.Size(75, 23)
        Me.lbl_catering.TabIndex = 92
        Me.lbl_catering.Text = "Catering"
        '
        'btn_asignarCatering
        '
        Me.btn_asignarCatering.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_asignarCatering.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_asignarCatering.Location = New System.Drawing.Point(800, 371)
        Me.btn_asignarCatering.Name = "btn_asignarCatering"
        Me.btn_asignarCatering.Size = New System.Drawing.Size(113, 25)
        Me.btn_asignarCatering.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_asignarCatering.TabIndex = 89
        Me.btn_asignarCatering.Text = "Asignar Catering"
        '
        'cmb_catering
        '
        Me.cmb_catering.DisplayMember = "Text"
        Me.cmb_catering.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_catering.FormattingEnabled = True
        Me.cmb_catering.ItemHeight = 16
        Me.cmb_catering.Location = New System.Drawing.Point(881, 285)
        Me.cmb_catering.Name = "cmb_catering"
        Me.cmb_catering.Size = New System.Drawing.Size(150, 22)
        Me.cmb_catering.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmb_catering.TabIndex = 88
        '
        'btn_quitarCatering
        '
        Me.btn_quitarCatering.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_quitarCatering.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_quitarCatering.Location = New System.Drawing.Point(939, 371)
        Me.btn_quitarCatering.Name = "btn_quitarCatering"
        Me.btn_quitarCatering.Size = New System.Drawing.Size(128, 25)
        Me.btn_quitarCatering.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_quitarCatering.TabIndex = 87
        Me.btn_quitarCatering.Text = "Quitar Catering"
        '
        'dt_catering
        '
        Me.dt_catering.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dt_catering.Location = New System.Drawing.Point(774, 71)
        Me.dt_catering.Name = "dt_catering"
        Me.dt_catering.Size = New System.Drawing.Size(319, 208)
        Me.dt_catering.TabIndex = 86
        '
        'lbl_CateringAsignados
        '
        Me.lbl_CateringAsignados.AutoSize = True
        Me.lbl_CateringAsignados.Location = New System.Drawing.Point(878, 40)
        Me.lbl_CateringAsignados.Name = "lbl_CateringAsignados"
        Me.lbl_CateringAsignados.Size = New System.Drawing.Size(145, 13)
        Me.lbl_CateringAsignados.TabIndex = 85
        Me.lbl_CateringAsignados.Text = "Lista de Catering Asignado"
        '
        'lbl_listaPlatos
        '
        '
        '
        '
        Me.lbl_listaPlatos.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_listaPlatos.Location = New System.Drawing.Point(12, 389)
        Me.lbl_listaPlatos.Name = "lbl_listaPlatos"
        Me.lbl_listaPlatos.Size = New System.Drawing.Size(110, 23)
        Me.lbl_listaPlatos.TabIndex = 95
        Me.lbl_listaPlatos.Text = "Lista de Platos"
        '
        'Frm_GestionPlato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1182, 618)
        Me.Controls.Add(Me.lbl_listaPlatos)
        Me.Controls.Add(Me.lbl_catering)
        Me.Controls.Add(Me.btn_asignarCatering)
        Me.Controls.Add(Me.cmb_catering)
        Me.Controls.Add(Me.btn_quitarCatering)
        Me.Controls.Add(Me.dt_catering)
        Me.Controls.Add(Me.lbl_CateringAsignados)
        Me.Controls.Add(Me.txt_precioIngrediente)
        Me.Controls.Add(Me.lbl_precioIngrediente)
        Me.Controls.Add(Me.lbl_ingrediente)
        Me.Controls.Add(Me.txt_CantIngrediente)
        Me.Controls.Add(Me.lbl_cantidad)
        Me.Controls.Add(Me.btn_AgregarIngrediente)
        Me.Controls.Add(Me.cmb_Ingrediente)
        Me.Controls.Add(Me.Btn_QuitarIngrediente)
        Me.Controls.Add(Me.dt_ingredientes)
        Me.Controls.Add(Me.lbl_listaIngredientes)
        Me.Controls.Add(Me.lbl_id_plato)
        Me.Controls.Add(Me.lbl_idPlato)
        Me.Controls.Add(Me.cmb_TipoMenu)
        Me.Controls.Add(Me.lbl_tipoMenu)
        Me.Controls.Add(Me.btn_cerrar)
        Me.Controls.Add(Me.btn_baja)
        Me.Controls.Add(Me.btn_Modificar)
        Me.Controls.Add(Me.btn_alta)
        Me.Controls.Add(Me.Dt_Platos)
        Me.Controls.Add(Me.txt_precio)
        Me.Controls.Add(Me.lbl_precio)
        Me.Controls.Add(Me.txt_manoDeObra)
        Me.Controls.Add(Me.lbl_manodeobra)
        Me.Controls.Add(Me.txt_nombrePlato)
        Me.Controls.Add(Me.lbl_nombrePlato)
        Me.Controls.Add(Me.lbl_elaboracionPlatos)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Frm_GestionPlato"
        Me.Text = "MetroForm"
        CType(Me.Dt_Platos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_ingredientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_catering, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_id_plato As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbl_idPlato As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmb_TipoMenu As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents lbl_tipoMenu As DevComponents.DotNetBar.LabelX
    Friend WithEvents btn_cerrar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn_baja As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn_Modificar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn_alta As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Dt_Platos As System.Windows.Forms.DataGridView
    Friend WithEvents txt_precio As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbl_precio As DevComponents.DotNetBar.LabelX
    Friend WithEvents txt_manoDeObra As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbl_manodeobra As DevComponents.DotNetBar.LabelX
    Friend WithEvents txt_nombrePlato As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbl_nombrePlato As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbl_elaboracionPlatos As System.Windows.Forms.Label
    Friend WithEvents lbl_listaIngredientes As System.Windows.Forms.Label
    Friend WithEvents dt_ingredientes As System.Windows.Forms.DataGridView
    Friend WithEvents Btn_QuitarIngrediente As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txt_precioIngrediente As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbl_precioIngrediente As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbl_ingrediente As DevComponents.DotNetBar.LabelX
    Friend WithEvents txt_CantIngrediente As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbl_cantidad As DevComponents.DotNetBar.LabelX
    Friend WithEvents btn_AgregarIngrediente As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmb_Ingrediente As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents lbl_catering As DevComponents.DotNetBar.LabelX
    Friend WithEvents btn_asignarCatering As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmb_catering As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents btn_quitarCatering As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dt_catering As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_CateringAsignados As System.Windows.Forms.Label
    Friend WithEvents lbl_listaPlatos As DevComponents.DotNetBar.LabelX
End Class
