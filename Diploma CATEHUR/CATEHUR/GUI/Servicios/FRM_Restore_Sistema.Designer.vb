<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_Restore_Sistema
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_Restore_Sistema))
        Me.ofdRestore = New System.Windows.Forms.OpenFileDialog
        Me.BTN_Restore = New System.Windows.Forms.Button
        Me.BTN_Salir = New System.Windows.Forms.Button
        Me.LBL_Ubicacion = New System.Windows.Forms.Label
        Me.TXT_Ubicacion = New System.Windows.Forms.TextBox
        Me.BTN_Examinar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'ofdRestore
        '
        Me.ofdRestore.FileName = "OpenFileDialog1"
        '
        'BTN_Restore
        '
        Me.BTN_Restore.Location = New System.Drawing.Point(15, 75)
        Me.BTN_Restore.Name = "BTN_Restore"
        Me.BTN_Restore.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Restore.TabIndex = 0
        Me.BTN_Restore.Text = "Restaurar"
        Me.BTN_Restore.UseVisualStyleBackColor = True
        '
        'BTN_Salir
        '
        Me.BTN_Salir.Location = New System.Drawing.Point(251, 75)
        Me.BTN_Salir.Name = "BTN_Salir"
        Me.BTN_Salir.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Salir.TabIndex = 1
        Me.BTN_Salir.Text = "Salir"
        Me.BTN_Salir.UseVisualStyleBackColor = True
        '
        'LBL_Ubicacion
        '
        Me.LBL_Ubicacion.AutoSize = True
        Me.LBL_Ubicacion.Location = New System.Drawing.Point(12, 9)
        Me.LBL_Ubicacion.Name = "LBL_Ubicacion"
        Me.LBL_Ubicacion.Size = New System.Drawing.Size(166, 13)
        Me.LBL_Ubicacion.TabIndex = 2
        Me.LBL_Ubicacion.Text = "Ubicación del archivo a restaurar:"
        '
        'TXT_Ubicacion
        '
        Me.TXT_Ubicacion.Location = New System.Drawing.Point(15, 41)
        Me.TXT_Ubicacion.Name = "TXT_Ubicacion"
        Me.TXT_Ubicacion.ReadOnly = True
        Me.TXT_Ubicacion.Size = New System.Drawing.Size(311, 20)
        Me.TXT_Ubicacion.TabIndex = 3
        '
        'BTN_Examinar
        '
        Me.BTN_Examinar.Location = New System.Drawing.Point(251, 4)
        Me.BTN_Examinar.Name = "BTN_Examinar"
        Me.BTN_Examinar.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Examinar.TabIndex = 4
        Me.BTN_Examinar.Text = "Examinar"
        Me.BTN_Examinar.UseVisualStyleBackColor = True
        '
        'FRM_Restore_Sistema
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 103)
        Me.ControlBox = False
        Me.Controls.Add(Me.BTN_Examinar)
        Me.Controls.Add(Me.TXT_Ubicacion)
        Me.Controls.Add(Me.LBL_Ubicacion)
        Me.Controls.Add(Me.BTN_Salir)
        Me.Controls.Add(Me.BTN_Restore)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRM_Restore_Sistema"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión de Restauración del Sistema"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ofdRestore As System.Windows.Forms.OpenFileDialog
    Friend WithEvents BTN_Restore As System.Windows.Forms.Button
    Friend WithEvents BTN_Salir As System.Windows.Forms.Button
    Friend WithEvents LBL_Ubicacion As System.Windows.Forms.Label
    Friend WithEvents TXT_Ubicacion As System.Windows.Forms.TextBox
    Friend WithEvents BTN_Examinar As System.Windows.Forms.Button
End Class
