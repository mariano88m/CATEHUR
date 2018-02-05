<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_PreparacionEntrega
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
        Me.lbl_PreparacionEntrega = New System.Windows.Forms.Label()
        Me.btn_confirmarEntrega = New DevComponents.DotNetBar.ButtonX()
        Me.btn_buscar = New DevComponents.DotNetBar.ButtonX()
        Me.lbl_id_evento = New DevComponents.DotNetBar.LabelX()
        Me.txt_idevento = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Dt_Eventos = New System.Windows.Forms.DataGridView()
        Me.txt_nombreevento = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbl_nombreEvento = New DevComponents.DotNetBar.LabelX()
        Me.btn_ConfeccionarOrdenCompra = New DevComponents.DotNetBar.ButtonX()
        Me.chk_ingredientes = New System.Windows.Forms.CheckBox()
        Me.chk_vajillas = New System.Windows.Forms.CheckBox()
        Me.chk_platos = New System.Windows.Forms.CheckBox()
        CType(Me.Dt_Eventos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_PreparacionEntrega
        '
        Me.lbl_PreparacionEntrega.AutoSize = True
        Me.lbl_PreparacionEntrega.Font = New System.Drawing.Font("Tempus Sans ITC", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PreparacionEntrega.Location = New System.Drawing.Point(206, 9)
        Me.lbl_PreparacionEntrega.Name = "lbl_PreparacionEntrega"
        Me.lbl_PreparacionEntrega.Size = New System.Drawing.Size(262, 31)
        Me.lbl_PreparacionEntrega.TabIndex = 85
        Me.lbl_PreparacionEntrega.Text = "Preparacion de entrega"
        Me.lbl_PreparacionEntrega.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_confirmarEntrega
        '
        Me.btn_confirmarEntrega.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_confirmarEntrega.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_confirmarEntrega.Location = New System.Drawing.Point(246, 395)
        Me.btn_confirmarEntrega.Name = "btn_confirmarEntrega"
        Me.btn_confirmarEntrega.Size = New System.Drawing.Size(93, 40)
        Me.btn_confirmarEntrega.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_confirmarEntrega.TabIndex = 83
        Me.btn_confirmarEntrega.Text = "Confirmar Entrega"
        '
        'btn_buscar
        '
        Me.btn_buscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_buscar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_buscar.Location = New System.Drawing.Point(364, 101)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(104, 22)
        Me.btn_buscar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_buscar.TabIndex = 80
        Me.btn_buscar.Text = "Buscar Evento"
        '
        'lbl_id_evento
        '
        '
        '
        '
        Me.lbl_id_evento.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_id_evento.Location = New System.Drawing.Point(22, 62)
        Me.lbl_id_evento.Name = "lbl_id_evento"
        Me.lbl_id_evento.Size = New System.Drawing.Size(110, 23)
        Me.lbl_id_evento.TabIndex = 79
        Me.lbl_id_evento.Text = "Id Evento"
        '
        'txt_idevento
        '
        Me.txt_idevento.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_idevento.Border.Class = "TextBoxBorder"
        Me.txt_idevento.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_idevento.ForeColor = System.Drawing.Color.Black
        Me.txt_idevento.Location = New System.Drawing.Point(138, 62)
        Me.txt_idevento.Name = "txt_idevento"
        Me.txt_idevento.Size = New System.Drawing.Size(201, 22)
        Me.txt_idevento.TabIndex = 78
        '
        'Dt_Eventos
        '
        Me.Dt_Eventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dt_Eventos.Location = New System.Drawing.Point(15, 146)
        Me.Dt_Eventos.Name = "Dt_Eventos"
        Me.Dt_Eventos.Size = New System.Drawing.Size(671, 133)
        Me.Dt_Eventos.TabIndex = 77
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
        Me.txt_nombreevento.Location = New System.Drawing.Point(138, 101)
        Me.txt_nombreevento.Name = "txt_nombreevento"
        Me.txt_nombreevento.Size = New System.Drawing.Size(201, 22)
        Me.txt_nombreevento.TabIndex = 76
        '
        'lbl_nombreEvento
        '
        '
        '
        '
        Me.lbl_nombreEvento.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_nombreEvento.Location = New System.Drawing.Point(22, 98)
        Me.lbl_nombreEvento.Name = "lbl_nombreEvento"
        Me.lbl_nombreEvento.Size = New System.Drawing.Size(110, 23)
        Me.lbl_nombreEvento.TabIndex = 75
        Me.lbl_nombreEvento.Text = "Nombre del Evento"
        '
        'btn_ConfeccionarOrdenCompra
        '
        Me.btn_ConfeccionarOrdenCompra.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_ConfeccionarOrdenCompra.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_ConfeccionarOrdenCompra.Location = New System.Drawing.Point(448, 285)
        Me.btn_ConfeccionarOrdenCompra.Name = "btn_ConfeccionarOrdenCompra"
        Me.btn_ConfeccionarOrdenCompra.Size = New System.Drawing.Size(239, 40)
        Me.btn_ConfeccionarOrdenCompra.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_ConfeccionarOrdenCompra.TabIndex = 86
        Me.btn_ConfeccionarOrdenCompra.Text = "Confeccionar Orden de Compra"
        '
        'chk_ingredientes
        '
        Me.chk_ingredientes.AutoSize = True
        Me.chk_ingredientes.Location = New System.Drawing.Point(186, 319)
        Me.chk_ingredientes.Name = "chk_ingredientes"
        Me.chk_ingredientes.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chk_ingredientes.Size = New System.Drawing.Size(153, 17)
        Me.chk_ingredientes.TabIndex = 88
        Me.chk_ingredientes.Text = "Ingredientes Comprados"
        Me.chk_ingredientes.UseVisualStyleBackColor = True
        '
        'chk_vajillas
        '
        Me.chk_vajillas.AutoSize = True
        Me.chk_vajillas.Location = New System.Drawing.Point(236, 365)
        Me.chk_vajillas.Name = "chk_vajillas"
        Me.chk_vajillas.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chk_vajillas.Size = New System.Drawing.Size(103, 17)
        Me.chk_vajillas.TabIndex = 90
        Me.chk_vajillas.Text = "Asignar Vajillas"
        Me.chk_vajillas.UseVisualStyleBackColor = True
        '
        'chk_platos
        '
        Me.chk_platos.AutoSize = True
        Me.chk_platos.Location = New System.Drawing.Point(221, 342)
        Me.chk_platos.Name = "chk_platos"
        Me.chk_platos.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chk_platos.Size = New System.Drawing.Size(118, 17)
        Me.chk_platos.TabIndex = 92
        Me.chk_platos.Text = "Platos Preparados"
        Me.chk_platos.UseVisualStyleBackColor = True
        '
        'Frm_PreparacionEntrega
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 447)
        Me.Controls.Add(Me.chk_platos)
        Me.Controls.Add(Me.chk_vajillas)
        Me.Controls.Add(Me.chk_ingredientes)
        Me.Controls.Add(Me.btn_ConfeccionarOrdenCompra)
        Me.Controls.Add(Me.lbl_PreparacionEntrega)
        Me.Controls.Add(Me.btn_confirmarEntrega)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.lbl_id_evento)
        Me.Controls.Add(Me.txt_idevento)
        Me.Controls.Add(Me.Dt_Eventos)
        Me.Controls.Add(Me.txt_nombreevento)
        Me.Controls.Add(Me.lbl_nombreEvento)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Frm_PreparacionEntrega"
        Me.Text = "MetroForm"
        CType(Me.Dt_Eventos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_PreparacionEntrega As System.Windows.Forms.Label
    Friend WithEvents btn_confirmarEntrega As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn_buscar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lbl_id_evento As DevComponents.DotNetBar.LabelX
    Friend WithEvents txt_idevento As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Dt_Eventos As System.Windows.Forms.DataGridView
    Friend WithEvents txt_nombreevento As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbl_nombreEvento As DevComponents.DotNetBar.LabelX
    Friend WithEvents btn_ConfeccionarOrdenCompra As DevComponents.DotNetBar.ButtonX
    Friend WithEvents chk_ingredientes As System.Windows.Forms.CheckBox
    Friend WithEvents chk_vajillas As System.Windows.Forms.CheckBox
    Friend WithEvents chk_platos As System.Windows.Forms.CheckBox
End Class
