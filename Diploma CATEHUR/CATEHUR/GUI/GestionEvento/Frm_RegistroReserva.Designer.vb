<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_RegistroReserva
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
        Me.txt_nombreevento = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbl_NombreEvento = New DevComponents.DotNetBar.LabelX()
        Me.Dt_Eventos = New System.Windows.Forms.DataGridView()
        Me.txt_idevento = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbl_id_evento = New DevComponents.DotNetBar.LabelX()
        Me.btn_buscar = New DevComponents.DotNetBar.ButtonX()
        Me.txt_reserva = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbl_Reserva = New DevComponents.DotNetBar.LabelX()
        Me.btn_registrarReserva = New DevComponents.DotNetBar.ButtonX()
        Me.btn_CancelarEvento = New DevComponents.DotNetBar.ButtonX()
        Me.lbl_registroReserva = New System.Windows.Forms.Label()
        CType(Me.Dt_Eventos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.txt_nombreevento.Location = New System.Drawing.Point(128, 101)
        Me.txt_nombreevento.Name = "txt_nombreevento"
        Me.txt_nombreevento.Size = New System.Drawing.Size(201, 22)
        Me.txt_nombreevento.TabIndex = 63
        '
        'lbl_NombreEvento
        '
        '
        '
        '
        Me.lbl_NombreEvento.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_NombreEvento.Location = New System.Drawing.Point(12, 98)
        Me.lbl_NombreEvento.Name = "lbl_NombreEvento"
        Me.lbl_NombreEvento.Size = New System.Drawing.Size(110, 23)
        Me.lbl_NombreEvento.TabIndex = 62
        Me.lbl_NombreEvento.Text = "Nombre del Evento"
        '
        'Dt_Eventos
        '
        Me.Dt_Eventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dt_Eventos.Location = New System.Drawing.Point(5, 146)
        Me.Dt_Eventos.Name = "Dt_Eventos"
        Me.Dt_Eventos.Size = New System.Drawing.Size(536, 133)
        Me.Dt_Eventos.TabIndex = 64
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
        Me.txt_idevento.Location = New System.Drawing.Point(128, 62)
        Me.txt_idevento.Name = "txt_idevento"
        Me.txt_idevento.Size = New System.Drawing.Size(201, 22)
        Me.txt_idevento.TabIndex = 67
        '
        'lbl_id_evento
        '
        '
        '
        '
        Me.lbl_id_evento.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_id_evento.Location = New System.Drawing.Point(12, 62)
        Me.lbl_id_evento.Name = "lbl_id_evento"
        Me.lbl_id_evento.Size = New System.Drawing.Size(110, 23)
        Me.lbl_id_evento.TabIndex = 68
        Me.lbl_id_evento.Text = "Id Evento"
        '
        'btn_buscar
        '
        Me.btn_buscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_buscar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_buscar.Location = New System.Drawing.Point(354, 101)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(104, 22)
        Me.btn_buscar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_buscar.TabIndex = 69
        Me.btn_buscar.Text = "Buscar Evento"
        '
        'txt_reserva
        '
        Me.txt_reserva.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_reserva.Border.Class = "TextBoxBorder"
        Me.txt_reserva.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_reserva.ForeColor = System.Drawing.Color.Black
        Me.txt_reserva.Location = New System.Drawing.Point(128, 301)
        Me.txt_reserva.Name = "txt_reserva"
        Me.txt_reserva.Size = New System.Drawing.Size(201, 22)
        Me.txt_reserva.TabIndex = 71
        '
        'lbl_Reserva
        '
        '
        '
        '
        Me.lbl_Reserva.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_Reserva.Location = New System.Drawing.Point(12, 301)
        Me.lbl_Reserva.Name = "lbl_Reserva"
        Me.lbl_Reserva.Size = New System.Drawing.Size(110, 23)
        Me.lbl_Reserva.TabIndex = 70
        Me.lbl_Reserva.Text = "Reserva"
        '
        'btn_registrarReserva
        '
        Me.btn_registrarReserva.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_registrarReserva.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_registrarReserva.Location = New System.Drawing.Point(128, 340)
        Me.btn_registrarReserva.Name = "btn_registrarReserva"
        Me.btn_registrarReserva.Size = New System.Drawing.Size(93, 40)
        Me.btn_registrarReserva.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_registrarReserva.TabIndex = 72
        Me.btn_registrarReserva.Text = "Registrar Reserva"
        '
        'btn_CancelarEvento
        '
        Me.btn_CancelarEvento.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_CancelarEvento.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_CancelarEvento.Location = New System.Drawing.Point(266, 340)
        Me.btn_CancelarEvento.Name = "btn_CancelarEvento"
        Me.btn_CancelarEvento.Size = New System.Drawing.Size(93, 40)
        Me.btn_CancelarEvento.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_CancelarEvento.TabIndex = 73
        Me.btn_CancelarEvento.Text = "Cancelar Evento"
        '
        'lbl_registroReserva
        '
        Me.lbl_registroReserva.AutoSize = True
        Me.lbl_registroReserva.Font = New System.Drawing.Font("Tempus Sans ITC", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_registroReserva.Location = New System.Drawing.Point(161, 9)
        Me.lbl_registroReserva.Name = "lbl_registroReserva"
        Me.lbl_registroReserva.Size = New System.Drawing.Size(225, 31)
        Me.lbl_registroReserva.TabIndex = 74
        Me.lbl_registroReserva.Text = "Registro de Reserva"
        Me.lbl_registroReserva.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Frm_RegistroReserva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 387)
        Me.Controls.Add(Me.lbl_registroReserva)
        Me.Controls.Add(Me.btn_CancelarEvento)
        Me.Controls.Add(Me.btn_registrarReserva)
        Me.Controls.Add(Me.txt_reserva)
        Me.Controls.Add(Me.lbl_Reserva)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.lbl_id_evento)
        Me.Controls.Add(Me.txt_idevento)
        Me.Controls.Add(Me.Dt_Eventos)
        Me.Controls.Add(Me.txt_nombreevento)
        Me.Controls.Add(Me.lbl_NombreEvento)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Frm_RegistroReserva"
        Me.Text = "MetroForm"
        CType(Me.Dt_Eventos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_nombreevento As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbl_NombreEvento As DevComponents.DotNetBar.LabelX
    Friend WithEvents Dt_Eventos As System.Windows.Forms.DataGridView
    Friend WithEvents txt_idevento As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbl_id_evento As DevComponents.DotNetBar.LabelX
    Friend WithEvents btn_buscar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lbl_Reserva As DevComponents.DotNetBar.LabelX
    Friend WithEvents txt_reserva As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btn_registrarReserva As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn_CancelarEvento As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lbl_registroReserva As System.Windows.Forms.Label
End Class
