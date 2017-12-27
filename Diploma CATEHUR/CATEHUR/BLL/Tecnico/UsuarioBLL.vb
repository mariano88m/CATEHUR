Imports be
Imports dal
Imports Servicios
Imports System.IO

Public Class UsuarioBLL


    Dim unEncripto As New Encripto
    Dim DalUsuario As New MapperUsuarios
    Dim dalEmpleado As New MapperEmpleado
    Dim DalFamilia As New MapperFamilia
    Dim DigitoVerificador As New DigitoVerificadorBLL

    Public Function VerificarExistencia(LaConfig As ConfiguracionConexion, NombreUser As String) As Boolean

        Return DalUsuario.VerificarExistencia(LaConfig, NombreUser)

    End Function

    Public Function VerificarContraseña(LaConfig As ConfiguracionConexion, NombreUser As String, Contraseña As String) As Boolean

        Return DalUsuario.VerificarContraseña(LaConfig, NombreUser, Contraseña)

    End Function

    Public Function VerificarBloqueo(LaConfig As ConfiguracionConexion, NombreUser As String) As Boolean

        Return DalUsuario.VerificarBloqueo(LaConfig, NombreUser)

    End Function

    'Consultas Traer Todo

    Public Function TraerTodosLosUsuarios(LaConfig As ConfiguracionConexion) As List(Of UsuarioEntity)

        Return DalUsuario.TraerTodosLosUsuarios(LaConfig)

    End Function

    Public Function TraerUsuario(LaConfig As ConfiguracionConexion, NombreUser As String, Contraseña As String) As UsuarioEntity

        Return DalUsuario.TraerUsuario(LaConfig, NombreUser, Contraseña)

    End Function

    Public Function TraerUsuario(LaConfig As ConfiguracionConexion, NombreUser As String) As UsuarioEntity

        Return DalUsuario.TraerUsuario(LaConfig, NombreUser)

    End Function

    Public Function BuscarUsuario(IdUsuario As Integer, LaConfig As ConfiguracionConexion) As UsuarioEntity

        Return DalUsuario.BuscarUsuario(IdUsuario, LaConfig)

    End Function

    Public Function TraerPatentesIndividuales(LaConfig As ConfiguracionConexion, IdFamilia As Integer) As List(Of PatenteEntity)

        Return DalUsuario.TraerPatentesIndividuales(LaConfig, IdFamilia)

    End Function


    Public Function TraerIDUsuario(unUsuario As UsuarioEntity, laConfig As ConfiguracionConexion) As Integer

        Return DalUsuario.TraerIDUsuario(unUsuario, laConfig)

    End Function



    'ABM

    Public Function ModificarUsuario(NuevoUsuario As UsuarioEntity, LaConfig As ConfiguracionConexion) As Boolean

        Try
            NuevoUsuario.Contraseña = unEncripto.EncriptaSHA(NuevoUsuario.Contraseña)
            NuevoUsuario.DDVVH = DigitoVerificador.CalcularDDVVH(CStr(NuevoUsuario.IdUsuario) + NuevoUsuario.Username + NuevoUsuario.Contraseña + CStr(NuevoUsuario.Empleado.IdEmpleado) + CStr(NuevoUsuario.DadoDeBaja))
            DalUsuario.ModificarUsuario(NuevoUsuario, LaConfig)
            DigitoVerificador.ActualizarDigitosVerificadorVerticales("Usuario", LaConfig)

            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function RegistrarUsuario(NuevoUsuario As UsuarioEntity, LaConfig As ConfiguracionConexion) As Boolean

        If Not DalUsuario.VerificarExistencia(LaConfig, NuevoUsuario.Username) Then
            NuevoUsuario.Contraseña = unEncripto.EncriptaSHA(NuevoUsuario.Contraseña)
            dalEmpleado.RegistrarEmpleado(NuevoUsuario, LaConfig)
            NuevoUsuario.Empleado.IdEmpleado = dalEmpleado.BuscarIDEmpleado(NuevoUsuario.Empleado, LaConfig)
            NuevoUsuario.DDVVH = DigitoVerificador.CalcularDDVVH(CStr(NuevoUsuario.IdUsuario) + NuevoUsuario.Username + NuevoUsuario.Contraseña + CStr(NuevoUsuario.Empleado.IdEmpleado) + CStr(NuevoUsuario.DadoDeBaja))
            DalUsuario.RegistrarUsuario(NuevoUsuario, LaConfig)
            DigitoVerificador.ActualizarDigitosVerificadorVerticales("Usuario", LaConfig)

            Return True
        End If
        Return False

    End Function

    Public Function EliminarUsuario(Username As String, LaConfig As ConfiguracionConexion)

        If DalUsuario.VerificarExistencia(LaConfig, Username) Then

            DalUsuario.EliminarUsuario(Username, LaConfig)
            Return True
        End If
        Return False
    End Function

    Public Function BloquearUsuario(NuevoUsuario As UsuarioEntity, LaConfig As ConfiguracionConexion) As Boolean

        Try
            DalUsuario.BloquearUsuario(NuevoUsuario, LaConfig)

            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function DesbloquearUsuario(NuevoUsuario As UsuarioEntity, LaConfig As ConfiguracionConexion) As Boolean

        Try
            DalUsuario.DesbloquearUsuario(NuevoUsuario, LaConfig)

            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function IntentoFallidoUsuario(NuevoUsuario As UsuarioEntity, LaConfig As ConfiguracionConexion) As Boolean

        Try
            DalUsuario.IntentoFallidoUsuario(NuevoUsuario, LaConfig)

            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function


End Class

