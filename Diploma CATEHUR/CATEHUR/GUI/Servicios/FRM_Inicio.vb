'Importaciones
Imports System.Windows.Forms.Screen
Imports MiSistema.Negocios

Public NotInheritable Class FRM_Inicio

    Private Sub FRM_Inicio_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.Cursor = Cursors.WaitCursor
        Me.Opacity = 0.6

        If My.Application.Info.Title <> "" Then
            ApplicationTitle.Text = "Liquidador de Sueldos"
        End If

        Timer.Interval = 4000
        Timer.Start()

    End Sub

    Private Sub Timer_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer.Tick
 
        Dim Sesion As Form

        Timer.Stop()

        Me.Hide()

        Sesion = FRM_Login.GetInstance

        Sesion.ShowDialog()

        Me.Show()

        FRM_Login.KillInstance()

        Me.Cursor = Cursors.WaitCursor

        Timer.Start()

        Me.Cursor = Cursors.Default

    End Sub

End Class
