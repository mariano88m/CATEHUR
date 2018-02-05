<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_GestionFamilia
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
        Me.cmb_Familia = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.lbl_Familia = New DevComponents.DotNetBar.LabelX()
        Me.btn_AltaPermiso = New DevComponents.DotNetBar.ButtonX()
        Me.btn_modificacion = New DevComponents.DotNetBar.ButtonX()
        Me.btn_bajaPermiso = New DevComponents.DotNetBar.ButtonX()
        Me.btn_cerrar = New DevComponents.DotNetBar.ButtonX()
        Me.Lbl_PermisosUsados = New DevComponents.DotNetBar.LabelX()
        Me.Lbl_PermisosDisp = New DevComponents.DotNetBar.LabelX()
        Me.DTPermisosDisponibles = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.DTPermisosUsados = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Btn_UsarFamilia = New DevComponents.DotNetBar.ButtonX()
        Me.btn_quitarFamilia = New DevComponents.DotNetBar.ButtonX()
        CType(Me.DTPermisosDisponibles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTPermisosUsados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmb_Familia
        '
        Me.cmb_Familia.DisplayMember = "Text"
        Me.cmb_Familia.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_Familia.FormattingEnabled = True
        Me.cmb_Familia.ItemHeight = 16
        Me.cmb_Familia.Location = New System.Drawing.Point(124, 38)
        Me.cmb_Familia.Name = "cmb_Familia"
        Me.cmb_Familia.Size = New System.Drawing.Size(291, 22)
        Me.cmb_Familia.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmb_Familia.TabIndex = 0
        '
        'lbl_Familia
        '
        '
        '
        '
        Me.lbl_Familia.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_Familia.Location = New System.Drawing.Point(29, 37)
        Me.lbl_Familia.Name = "lbl_Familia"
        Me.lbl_Familia.Size = New System.Drawing.Size(75, 23)
        Me.lbl_Familia.TabIndex = 1
        Me.lbl_Familia.Text = "Familia"
        '
        'btn_AltaPermiso
        '
        Me.btn_AltaPermiso.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_AltaPermiso.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_AltaPermiso.Location = New System.Drawing.Point(438, 38)
        Me.btn_AltaPermiso.Name = "btn_AltaPermiso"
        Me.btn_AltaPermiso.Size = New System.Drawing.Size(75, 23)
        Me.btn_AltaPermiso.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_AltaPermiso.TabIndex = 5
        Me.btn_AltaPermiso.Text = "Alta"
        '
        'btn_modificacion
        '
        Me.btn_modificacion.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_modificacion.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_modificacion.Location = New System.Drawing.Point(520, 38)
        Me.btn_modificacion.Name = "btn_modificacion"
        Me.btn_modificacion.Size = New System.Drawing.Size(75, 23)
        Me.btn_modificacion.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_modificacion.TabIndex = 9
        Me.btn_modificacion.Text = "Modificacion"
        '
        'btn_bajaPermiso
        '
        Me.btn_bajaPermiso.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_bajaPermiso.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_bajaPermiso.Location = New System.Drawing.Point(601, 38)
        Me.btn_bajaPermiso.Name = "btn_bajaPermiso"
        Me.btn_bajaPermiso.Size = New System.Drawing.Size(75, 23)
        Me.btn_bajaPermiso.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_bajaPermiso.TabIndex = 10
        Me.btn_bajaPermiso.Text = "Baja"
        '
        'btn_cerrar
        '
        Me.btn_cerrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_cerrar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_cerrar.Location = New System.Drawing.Point(307, 532)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(75, 42)
        Me.btn_cerrar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_cerrar.TabIndex = 14
        Me.btn_cerrar.Text = "Cerrar"
        '
        'Lbl_PermisosUsados
        '
        '
        '
        '
        Me.Lbl_PermisosUsados.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Lbl_PermisosUsados.Location = New System.Drawing.Point(29, 82)
        Me.Lbl_PermisosUsados.Name = "Lbl_PermisosUsados"
        Me.Lbl_PermisosUsados.Size = New System.Drawing.Size(171, 23)
        Me.Lbl_PermisosUsados.TabIndex = 20
        Me.Lbl_PermisosUsados.Text = "Permisos Usados"
        '
        'Lbl_PermisosDisp
        '
        '
        '
        '
        Me.Lbl_PermisosDisp.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Lbl_PermisosDisp.Location = New System.Drawing.Point(388, 82)
        Me.Lbl_PermisosDisp.Name = "Lbl_PermisosDisp"
        Me.Lbl_PermisosDisp.Size = New System.Drawing.Size(125, 23)
        Me.Lbl_PermisosDisp.TabIndex = 19
        Me.Lbl_PermisosDisp.Text = "Permisos Disponibles"
        '
        'DTPermisosDisponibles
        '
        Me.DTPermisosDisponibles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DTPermisosDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DTPermisosDisponibles.DefaultCellStyle = DataGridViewCellStyle1
        Me.DTPermisosDisponibles.GridColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.DTPermisosDisponibles.Location = New System.Drawing.Point(388, 111)
        Me.DTPermisosDisponibles.Name = "DTPermisosDisponibles"
        Me.DTPermisosDisponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DTPermisosDisponibles.Size = New System.Drawing.Size(288, 415)
        Me.DTPermisosDisponibles.TabIndex = 18
        '
        'DTPermisosUsados
        '
        Me.DTPermisosUsados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DTPermisosUsados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DTPermisosUsados.DefaultCellStyle = DataGridViewCellStyle2
        Me.DTPermisosUsados.GridColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.DTPermisosUsados.Location = New System.Drawing.Point(29, 111)
        Me.DTPermisosUsados.Name = "DTPermisosUsados"
        Me.DTPermisosUsados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DTPermisosUsados.Size = New System.Drawing.Size(272, 415)
        Me.DTPermisosUsados.TabIndex = 15
        '
        'Btn_UsarFamilia
        '
        Me.Btn_UsarFamilia.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Btn_UsarFamilia.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.Btn_UsarFamilia.Image = Global.GUI.My.Resources.Resources.izq
        Me.Btn_UsarFamilia.ImageFixedSize = New System.Drawing.Size(40, 40)
        Me.Btn_UsarFamilia.Location = New System.Drawing.Point(317, 302)
        Me.Btn_UsarFamilia.Name = "Btn_UsarFamilia"
        Me.Btn_UsarFamilia.Size = New System.Drawing.Size(55, 51)
        Me.Btn_UsarFamilia.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Btn_UsarFamilia.TabIndex = 17
        Me.Btn_UsarFamilia.Visible = False
        '
        'btn_quitarFamilia
        '
        Me.btn_quitarFamilia.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_quitarFamilia.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btn_quitarFamilia.Image = Global.GUI.My.Resources.Resources.Derecha
        Me.btn_quitarFamilia.ImageFixedSize = New System.Drawing.Size(40, 40)
        Me.btn_quitarFamilia.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf
        Me.btn_quitarFamilia.Location = New System.Drawing.Point(317, 219)
        Me.btn_quitarFamilia.Name = "btn_quitarFamilia"
        Me.btn_quitarFamilia.Size = New System.Drawing.Size(55, 51)
        Me.btn_quitarFamilia.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_quitarFamilia.TabIndex = 16
        Me.btn_quitarFamilia.Visible = False
        '
        'Frm_GestionFamilia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 578)
        Me.Controls.Add(Me.Lbl_PermisosUsados)
        Me.Controls.Add(Me.Lbl_PermisosDisp)
        Me.Controls.Add(Me.DTPermisosDisponibles)
        Me.Controls.Add(Me.Btn_UsarFamilia)
        Me.Controls.Add(Me.btn_quitarFamilia)
        Me.Controls.Add(Me.DTPermisosUsados)
        Me.Controls.Add(Me.btn_cerrar)
        Me.Controls.Add(Me.btn_bajaPermiso)
        Me.Controls.Add(Me.btn_modificacion)
        Me.Controls.Add(Me.btn_AltaPermiso)
        Me.Controls.Add(Me.lbl_Familia)
        Me.Controls.Add(Me.cmb_Familia)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Frm_GestionFamilia"
        Me.Text = "MetroForm"
        CType(Me.DTPermisosDisponibles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTPermisosUsados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmb_Familia As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents lbl_Familia As DevComponents.DotNetBar.LabelX
    Friend WithEvents btn_AltaPermiso As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn_modificacion As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn_bajaPermiso As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn_cerrar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Lbl_PermisosUsados As DevComponents.DotNetBar.LabelX
    Friend WithEvents Lbl_PermisosDisp As DevComponents.DotNetBar.LabelX
    Friend WithEvents DTPermisosDisponibles As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Btn_UsarFamilia As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn_quitarFamilia As DevComponents.DotNetBar.ButtonX
    Friend WithEvents DTPermisosUsados As DevComponents.DotNetBar.Controls.DataGridViewX
End Class
