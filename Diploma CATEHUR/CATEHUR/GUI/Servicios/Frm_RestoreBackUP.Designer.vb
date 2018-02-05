<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_RestoreBackUP
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
        Me.lbl_ubicacion = New DevComponents.DotNetBar.LabelX()
        Me.btn_examinar = New DevComponents.DotNetBar.ButtonX()
        Me.txt_ubicacion = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btn_cerrar = New DevComponents.DotNetBar.ButtonX()
        Me.btn_restaurar = New DevComponents.DotNetBar.ButtonX()
        Me.SuspendLayout()
        '
        'lbl_ubicacion
        '
        '
        '
        '
        Me.lbl_ubicacion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl_ubicacion.Location = New System.Drawing.Point(3, 34)
        Me.lbl_ubicacion.Name = "lbl_ubicacion"
        Me.lbl_ubicacion.Size = New System.Drawing.Size(184, 23)
        Me.lbl_ubicacion.TabIndex = 0
        Me.lbl_ubicacion.Text = "Ubicacion del archivo a restaurar"
        '
        'btn_examinar
        '
        Me.btn_examinar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_examinar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_examinar.Location = New System.Drawing.Point(346, 34)
        Me.btn_examinar.Name = "btn_examinar"
        Me.btn_examinar.Size = New System.Drawing.Size(75, 23)
        Me.btn_examinar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_examinar.TabIndex = 1
        Me.btn_examinar.Text = "Examinar"
        '
        'txt_ubicacion
        '
        Me.txt_ubicacion.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_ubicacion.Border.Class = "TextBoxBorder"
        Me.txt_ubicacion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_ubicacion.ForeColor = System.Drawing.Color.Black
        Me.txt_ubicacion.Location = New System.Drawing.Point(3, 63)
        Me.txt_ubicacion.Name = "txt_ubicacion"
        Me.txt_ubicacion.Size = New System.Drawing.Size(418, 22)
        Me.txt_ubicacion.TabIndex = 2
        '
        'btn_cerrar
        '
        Me.btn_cerrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_cerrar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_cerrar.Location = New System.Drawing.Point(346, 105)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cerrar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_cerrar.TabIndex = 3
        Me.btn_cerrar.Text = "Salir"
        '
        'btn_restaurar
        '
        Me.btn_restaurar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_restaurar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_restaurar.Location = New System.Drawing.Point(3, 105)
        Me.btn_restaurar.Name = "btn_restaurar"
        Me.btn_restaurar.Size = New System.Drawing.Size(75, 23)
        Me.btn_restaurar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_restaurar.TabIndex = 4
        Me.btn_restaurar.Text = "Restaurar"
        '
        'Frm_RestoreBackUP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 145)
        Me.Controls.Add(Me.btn_restaurar)
        Me.Controls.Add(Me.btn_cerrar)
        Me.Controls.Add(Me.txt_ubicacion)
        Me.Controls.Add(Me.btn_examinar)
        Me.Controls.Add(Me.lbl_ubicacion)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Frm_RestoreBackUP"
        Me.Text = "MetroForm"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_ubicacion As DevComponents.DotNetBar.LabelX
    Friend WithEvents btn_examinar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txt_ubicacion As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btn_cerrar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn_restaurar As DevComponents.DotNetBar.ButtonX
End Class
