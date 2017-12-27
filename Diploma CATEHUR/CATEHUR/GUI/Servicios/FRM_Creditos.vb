'Importaciones
Imports System.Windows.Forms.Screen

Public NotInheritable Class FRM_Creditos

    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If My.Application.Info.Title <> "" Then
            ApplicationTitle.Text = "Liquidador de Sueldos"
        Else
            ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)

        Copyright.Text = "SOFTUAI S.A. 2011"
        Timer.Interval = 5000
        Timer.Start()

    End Sub

    Private Sub Timer_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer.Tick

        Timer.Stop()
        Me.Hide()

    End Sub

End Class
