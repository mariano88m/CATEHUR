<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_gestionBebidas
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
        Me.lbl_catering = New DevComponents.DotNetBar.LabelX()
        Me.btn_asignarCatering = New DevComponents.DotNetBar.ButtonX()
        Me.cmb_catering = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.btn_quitarCatering = New DevComponents.DotNetBar.ButtonX()
        Me.dt_catering = New System.Windows.Forms.DataGridView()
        Me.lbl_ListaCateringAsignados = New System.Windows.Forms.Label()
        Me.lbl_id_bebida = New DevComponents.DotNetBar.LabelX()
        Me.lbl_idBebida = New DevComponents.DotNetBar.LabelX()
        Me.txt_precio = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbl_precio = New DevComponents.DotNetBar.LabelX()
        Me.txt_nombreBebida = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbl_nombreBebida = New DevComponents.DotNetBar.LabelX()
        Me.lbl_ListaBebida = New DevComponents.DotNetBar.LabelX()
        Me.Dt_bebidas = New System.Windows.Forms.DataGridView()
        Me.btn_cerrar = New DevComponents.DotNetBar.ButtonX()
        Me.btn_baja = New DevComponents.DotNetBar.ButtonX()
        Me.btn_Modificar = New DevComponents.DotNetBar.ButtonX()
        Me.btn_alta = New DevComponents.DotNetBar.ButtonX()
        Me.lbl_GestionBebidas = New System.Windows.Forms.Label()
        Me.btn_limpiar = New DevComponents.DotNetBar.ButtonX()
        CType(Me.dt_catering, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dt_bebidas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_catering
        '
        '
        '
        '
        Me.lbl_catering.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_catering.Location = New System.Drawing.Point(538, 290)
        Me.lbl_catering.Name = "lbl_catering"
        Me.lbl_catering.Size = New System.Drawing.Size(75, 23)
        Me.lbl_catering.TabIndex = 98
        Me.lbl_catering.Text = "Catering"
        '
        'btn_asignarCatering
        '
        Me.btn_asignarCatering.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_asignarCatering.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_asignarCatering.Location = New System.Drawing.Point(538, 319)
        Me.btn_asignarCatering.Name = "btn_asignarCatering"
        Me.btn_asignarCatering.Size = New System.Drawing.Size(113, 25)
        Me.btn_asignarCatering.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_asignarCatering.TabIndex = 97
        Me.btn_asignarCatering.Text = "Asignar Catering"
        '
        'cmb_catering
        '
        Me.cmb_catering.DisplayMember = "Text"
        Me.cmb_catering.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_catering.FormattingEnabled = True
        Me.cmb_catering.ItemHeight = 16
        Me.cmb_catering.Location = New System.Drawing.Point(619, 291)
        Me.cmb_catering.Name = "cmb_catering"
        Me.cmb_catering.Size = New System.Drawing.Size(150, 22)
        Me.cmb_catering.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmb_catering.TabIndex = 96
        '
        'btn_quitarCatering
        '
        Me.btn_quitarCatering.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_quitarCatering.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_quitarCatering.Location = New System.Drawing.Point(677, 319)
        Me.btn_quitarCatering.Name = "btn_quitarCatering"
        Me.btn_quitarCatering.Size = New System.Drawing.Size(128, 25)
        Me.btn_quitarCatering.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_quitarCatering.TabIndex = 95
        Me.btn_quitarCatering.Text = "Quitar Catering"
        '
        'dt_catering
        '
        Me.dt_catering.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dt_catering.Location = New System.Drawing.Point(503, 85)
        Me.dt_catering.Name = "dt_catering"
        Me.dt_catering.Size = New System.Drawing.Size(319, 184)
        Me.dt_catering.TabIndex = 94
        '
        'lbl_ListaCateringAsignados
        '
        Me.lbl_ListaCateringAsignados.AutoSize = True
        Me.lbl_ListaCateringAsignados.Location = New System.Drawing.Point(582, 61)
        Me.lbl_ListaCateringAsignados.Name = "lbl_ListaCateringAsignados"
        Me.lbl_ListaCateringAsignados.Size = New System.Drawing.Size(145, 13)
        Me.lbl_ListaCateringAsignados.TabIndex = 93
        Me.lbl_ListaCateringAsignados.Text = "Lista de Catering Asignado"
        '
        'lbl_id_bebida
        '
        '
        '
        '
        Me.lbl_id_bebida.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_id_bebida.Location = New System.Drawing.Point(163, 291)
        Me.lbl_id_bebida.Name = "lbl_id_bebida"
        Me.lbl_id_bebida.Size = New System.Drawing.Size(110, 23)
        Me.lbl_id_bebida.TabIndex = 108
        '
        'lbl_idBebida
        '
        '
        '
        '
        Me.lbl_idBebida.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_idBebida.Location = New System.Drawing.Point(49, 291)
        Me.lbl_idBebida.Name = "lbl_idBebida"
        Me.lbl_idBebida.Size = New System.Drawing.Size(110, 23)
        Me.lbl_idBebida.TabIndex = 107
        Me.lbl_idBebida.Text = "Id_Bebida"
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
        Me.txt_precio.Location = New System.Drawing.Point(163, 351)
        Me.txt_precio.Name = "txt_precio"
        Me.txt_precio.Size = New System.Drawing.Size(292, 22)
        Me.txt_precio.TabIndex = 104
        '
        'lbl_precio
        '
        '
        '
        '
        Me.lbl_precio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_precio.Location = New System.Drawing.Point(47, 351)
        Me.lbl_precio.Name = "lbl_precio"
        Me.lbl_precio.Size = New System.Drawing.Size(110, 23)
        Me.lbl_precio.TabIndex = 103
        Me.lbl_precio.Text = "Precio"
        '
        'txt_nombreBebida
        '
        Me.txt_nombreBebida.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_nombreBebida.Border.Class = "TextBoxBorder"
        Me.txt_nombreBebida.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_nombreBebida.ForeColor = System.Drawing.Color.Black
        Me.txt_nombreBebida.Location = New System.Drawing.Point(163, 323)
        Me.txt_nombreBebida.Name = "txt_nombreBebida"
        Me.txt_nombreBebida.Size = New System.Drawing.Size(292, 22)
        Me.txt_nombreBebida.TabIndex = 100
        '
        'lbl_nombreBebida
        '
        '
        '
        '
        Me.lbl_nombreBebida.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_nombreBebida.Location = New System.Drawing.Point(47, 323)
        Me.lbl_nombreBebida.Name = "lbl_nombreBebida"
        Me.lbl_nombreBebida.Size = New System.Drawing.Size(110, 23)
        Me.lbl_nombreBebida.TabIndex = 99
        Me.lbl_nombreBebida.Text = "Nombre de la bebida"
        '
        'lbl_ListaBebida
        '
        '
        '
        '
        Me.lbl_ListaBebida.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_ListaBebida.Location = New System.Drawing.Point(46, 56)
        Me.lbl_ListaBebida.Name = "lbl_ListaBebida"
        Me.lbl_ListaBebida.Size = New System.Drawing.Size(110, 23)
        Me.lbl_ListaBebida.TabIndex = 110
        Me.lbl_ListaBebida.Text = "Lista de Bebidas"
        '
        'Dt_bebidas
        '
        Me.Dt_bebidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dt_bebidas.Location = New System.Drawing.Point(46, 85)
        Me.Dt_bebidas.Name = "Dt_bebidas"
        Me.Dt_bebidas.Size = New System.Drawing.Size(409, 184)
        Me.Dt_bebidas.TabIndex = 109
        '
        'btn_cerrar
        '
        Me.btn_cerrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_cerrar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_cerrar.Location = New System.Drawing.Point(747, 399)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(75, 25)
        Me.btn_cerrar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_cerrar.TabIndex = 114
        Me.btn_cerrar.Text = "Cerrar"
        '
        'btn_baja
        '
        Me.btn_baja.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_baja.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_baja.Location = New System.Drawing.Point(373, 399)
        Me.btn_baja.Name = "btn_baja"
        Me.btn_baja.Size = New System.Drawing.Size(82, 25)
        Me.btn_baja.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_baja.TabIndex = 113
        Me.btn_baja.Text = "Baja"
        '
        'btn_Modificar
        '
        Me.btn_Modificar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_Modificar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_Modificar.Location = New System.Drawing.Point(270, 399)
        Me.btn_Modificar.Name = "btn_Modificar"
        Me.btn_Modificar.Size = New System.Drawing.Size(97, 25)
        Me.btn_Modificar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_Modificar.TabIndex = 112
        Me.btn_Modificar.Text = "Modificar"
        '
        'btn_alta
        '
        Me.btn_alta.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_alta.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_alta.Location = New System.Drawing.Point(163, 399)
        Me.btn_alta.Name = "btn_alta"
        Me.btn_alta.Size = New System.Drawing.Size(101, 25)
        Me.btn_alta.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_alta.TabIndex = 111
        Me.btn_alta.Text = "Alta"
        '
        'lbl_GestionBebidas
        '
        Me.lbl_GestionBebidas.AutoSize = True
        Me.lbl_GestionBebidas.Font = New System.Drawing.Font("Tempus Sans ITC", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_GestionBebidas.Location = New System.Drawing.Point(280, 9)
        Me.lbl_GestionBebidas.Name = "lbl_GestionBebidas"
        Me.lbl_GestionBebidas.Size = New System.Drawing.Size(220, 31)
        Me.lbl_GestionBebidas.TabIndex = 115
        Me.lbl_GestionBebidas.Text = "Gestion de Bebidas"
        Me.lbl_GestionBebidas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_limpiar
        '
        Me.btn_limpiar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_limpiar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_limpiar.Location = New System.Drawing.Point(46, 399)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(75, 25)
        Me.btn_limpiar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_limpiar.TabIndex = 116
        Me.btn_limpiar.Text = "Limpiar"
        '
        'Frm_gestionBebidas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(835, 435)
        Me.Controls.Add(Me.btn_limpiar)
        Me.Controls.Add(Me.lbl_GestionBebidas)
        Me.Controls.Add(Me.btn_cerrar)
        Me.Controls.Add(Me.btn_baja)
        Me.Controls.Add(Me.btn_Modificar)
        Me.Controls.Add(Me.btn_alta)
        Me.Controls.Add(Me.lbl_ListaBebida)
        Me.Controls.Add(Me.Dt_bebidas)
        Me.Controls.Add(Me.lbl_id_bebida)
        Me.Controls.Add(Me.lbl_idBebida)
        Me.Controls.Add(Me.txt_precio)
        Me.Controls.Add(Me.lbl_precio)
        Me.Controls.Add(Me.txt_nombreBebida)
        Me.Controls.Add(Me.lbl_nombreBebida)
        Me.Controls.Add(Me.lbl_catering)
        Me.Controls.Add(Me.btn_asignarCatering)
        Me.Controls.Add(Me.cmb_catering)
        Me.Controls.Add(Me.btn_quitarCatering)
        Me.Controls.Add(Me.dt_catering)
        Me.Controls.Add(Me.lbl_ListaCateringAsignados)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Frm_gestionBebidas"
        Me.Text = "MetroForm"
        CType(Me.dt_catering, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dt_bebidas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_catering As DevComponents.DotNetBar.LabelX
    Friend WithEvents btn_asignarCatering As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmb_catering As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents btn_quitarCatering As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dt_catering As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_ListaCateringAsignados As System.Windows.Forms.Label
    Friend WithEvents lbl_id_bebida As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbl_idBebida As DevComponents.DotNetBar.LabelX
    Friend WithEvents txt_precio As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbl_precio As DevComponents.DotNetBar.LabelX
    Friend WithEvents txt_nombreBebida As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbl_nombreBebida As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbl_ListaBebida As DevComponents.DotNetBar.LabelX
    Friend WithEvents Dt_bebidas As System.Windows.Forms.DataGridView
    Friend WithEvents btn_cerrar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn_baja As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn_Modificar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn_alta As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lbl_GestionBebidas As System.Windows.Forms.Label
    Friend WithEvents btn_limpiar As DevComponents.DotNetBar.ButtonX
End Class
