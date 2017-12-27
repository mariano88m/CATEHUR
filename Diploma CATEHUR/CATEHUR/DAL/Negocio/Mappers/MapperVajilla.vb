Imports BE
Public Class MapperVajilla
    Public Function AsignarVajillas(CantPersonas As Integer, laconfig As ConfiguracionConexion) As Boolean

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        unaconexion.ConexionIniciar(laconfig)

        Try

            unaconexion.Ejecutar("Update Vajilla set CantidadVajilla = CantidadVajilla - @CantPersonas", False, IConexion.TipoRetorno.SinResultado, CantPersonas)

            unaconexion.ConexionFinalizar()
            Return True


        Catch ex As Exception

            Return False
        Finally
            unaconexion.ConexionFinalizar()
        End Try

    End Function

    Public Function DevolverVajillas(CantPersonas As Integer, laconfig As ConfiguracionConexion) As Boolean

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        unaconexion.ConexionIniciar(laconfig)

        Try

            unaconexion.Ejecutar("Update Vajilla set CantidadVajilla = CantidadVajilla + @CantPersonas", False, IConexion.TipoRetorno.SinResultado, CantPersonas)

            unaconexion.ConexionFinalizar()
            Return True


        Catch ex As Exception

            Return False
        Finally
            unaconexion.ConexionFinalizar()
        End Try

    End Function

    Public Function TraerVajillas(laconfig As ConfiguracionConexion) As List(Of VajillaEntity)

        Dim lstVajillas As New List(Of VajillaEntity)
        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        unaconexion.ConexionIniciar(laconfig)

        Dim resultado As IDataReader = unaconexion.Ejecutar("Select * from Vajilla", False, IConexion.TipoRetorno.Tupla).ResultadoConectado

        lstVajillas = DataReadObjeto.RealizarMapeo(Of VajillaEntity)(resultado)

        unaconexion.ConexionFinalizar()
        Return lstVajillas


    End Function

    Public Function RegistrarPerdida(unaVajila As Integer, cantVajillasPerdidas As Integer, laconfig As ConfiguracionConexion) As Boolean

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        unaconexion.ConexionIniciar(laconfig)

        Try

            unaconexion.Ejecutar("Update Vajilla set CantidadVajilla = CantidadVajilla - @cantVajillasPerdidas where Vajilla.id_Vajilla = @id_Vajilla", False, IConexion.TipoRetorno.SinResultado, cantVajillasPerdidas, unaVajila)

            unaconexion.ConexionFinalizar()
            Return True


        Catch ex As Exception

            Return False
        Finally
            unaconexion.ConexionFinalizar()
        End Try

    End Function

    Public Function ReponerVajillas(unaVajila As VajillaEntity, cantVajillasNuevas As Integer, laconfig As ConfiguracionConexion) As Boolean

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        unaconexion.ConexionIniciar(laconfig)

        Try

            unaconexion.Ejecutar("Update Vajilla set CantidadVajilla = CantidadVajilla + @cantVajillasNuevas where Vajilla.id_Vajilla = @id_Vajilla", False, IConexion.TipoRetorno.SinResultado, cantVajillasNuevas, unaVajila.id_Vajilla)

            unaconexion.ConexionFinalizar()
            Return True


        Catch ex As Exception

            Return False
        Finally
            unaconexion.ConexionFinalizar()
        End Try

    End Function


End Class
