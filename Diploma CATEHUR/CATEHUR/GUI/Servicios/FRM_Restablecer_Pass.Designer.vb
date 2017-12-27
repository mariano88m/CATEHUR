<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_Restablecer_Pass
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_Restablecer_Pass))
        Me.TXT_Confirma_Pass = New System.Windows.Forms.TextBox
        Me.LBL_Confirma_Pass = New System.Windows.Forms.Label
        Me.BTN_Cancel = New System.Windows.Forms.Button
        Me.BTN_Aceptar = New System.Windows.Forms.Button
        Me.TXT_Nueva_Pass = New System.Windows.Forms.TextBox
        Me.LBL_Nueva_Pass = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'TXT_Confirma_Pass
        '
        Me.TXT_Confirma_Pass.Location = New System.Drawing.Point(128, 47)
        Me.TXT_Confirma_Pass.MaxLength = 10
        Me.TXT_Confirma_Pass.Name = "TXT_Confirma_Pass"
        Me.TXT_Confirma_Pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXT_Confirma_Pass.Size = New System.Drawing.Size(189, 20)
        Me.TXT_Confirma_Pass.TabIndex = 18
        '
        'LBL_Confirma_Pass
        '
        Me.LBL_Confirma_Pass.Location = New System.Drawing.Point(12, 45)
        Me.LBL_Confirma_Pass.Name = "LBL_Confirma_Pass"
        Me.LBL_Confirma_Pass.Size = New System.Drawing.Size(228, 23)
        Me.LBL_Confirma_Pass.TabIndex = 23
        Me.LBL_Confirma_Pass.Text = "Confirmar Contraseña:"
        Me.LBL_Confirma_Pass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BTN_Cancel
        '
        Me.BTN_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_Cancel.Location = New System.Drawing.Point(223, 81)
        Me.BTN_Cancel.Name = "BTN_Cancel"
        Me.BTN_Cancel.Size = New System.Drawing.Size(94, 23)
        Me.BTN_Cancel.TabIndex = 20
        Me.BTN_Cancel.Text = "Cancelar"
        '
        'BTN_Aceptar
        '
        Me.BTN_Aceptar.Location = New System.Drawing.Point(15, 81)
        Me.BTN_Aceptar.Name = "BTN_Aceptar"
        Me.BTN_Aceptar.Size = New System.Drawing.Size(94, 23)
        Me.BTN_Aceptar.TabIndex = 19
        Me.BTN_Aceptar.Text = "Aceptar"
        '
        'TXT_Nueva_Pass
        '
        Me.TXT_Nueva_Pass.Location = New System.Drawing.Point(128, 11)
        Me.TXT_Nueva_Pass.MaxLength = 10
        Me.TXT_Nueva_Pass.Name = "TXT_Nueva_Pass"
        Me.TXT_Nueva_Pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXT_Nueva_Pass.Size = New System.Drawing.Size(189, 20)
        Me.TXT_Nueva_Pass.TabIndex = 17
        '
        'LBL_Nueva_Pass
        '
        Me.LBL_Nueva_Pass.Location = New System.Drawing.Point(12, 9)
        Me.LBL_Nueva_Pass.Name = "LBL_Nueva_Pass"
        Me.LBL_Nueva_Pass.Size = New System.Drawing.Size(225, 23)
        Me.LBL_Nueva_Pass.TabIndex = 22
        Me.LBL_Nueva_Pass.Text = "Nueva Contraseña:"
        Me.LBL_Nueva_Pass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FRM_Restablecer_Pass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 113)
        Me.ControlBox = False
        Me.Controls.Add(Me.TXT_Confirma_Pass)
        Me.Controls.Add(Me.LBL_Confirma_Pass)
        Me.Controls.Add(Me.BTN_Cancel)
        Me.Controls.Add(Me.BTN_Aceptar)
        Me.Controls.Add(Me.TXT_Nueva_Pass)
        Me.Controls.Add(Me.LBL_Nueva_Pass)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRM_Restablecer_Pass"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión de Restablecimiento de Contraseña"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TXT_Confirma_Pass As System.Windows.Forms.TextBox
    Friend WithEvents LBL_Confirma_Pass As System.Windows.Forms.Label
    Friend WithEvents BTN_Cancel As System.Windows.Forms.Button
    Friend WithEvents BTN_Aceptar As System.Windows.Forms.Button
    Friend WithEvents TXT_Nueva_Pass As System.Windows.Forms.TextBox
    Friend WithEvents LBL_Nueva_Pass As System.Windows.Forms.Label
End Class
