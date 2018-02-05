Public Class EmpleadoEntity


    Public Property IdEmpleado As Integer

    Public Property Nombre As String

    Public Property Apellido As String

    Public Property email As String

    Public Property Domicilio As String

    Public Property Telefono As String

    Public Property unTipoEmpleado As New TipoEmpleadoEntity


    Public Overrides Function ToString() As String

        Return Me.Nombre.ToString() + " " + Me.Apellido.ToString()
        
    End Function

End Class

