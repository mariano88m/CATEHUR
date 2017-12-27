Imports BE
Imports DAL
Imports System.Reflection
Imports System
Imports System.Security
Imports System.Security.Cryptography
Imports System.Text

Public Class DigitoVerificadorBLL

    Public Function CalcularDDVVH(ByVal Concatenacion As String) As Long
        Dim ConversionAscii As String = funcionHASH(Concatenacion)
        Dim acum As Long = 0
        For i = 0 To ConversionAscii.Length - 1
            acum += Asc(ConversionAscii.Chars(i))
        Next
        Return acum
    End Function

    Private Shared Function funcionHASH(ByVal palabra As String) As String

        Dim tmpSource() As Byte
        Dim tmpHash() As Byte
        Dim i As Integer
        tmpSource = ASCIIEncoding.ASCII.GetBytes(palabra)
        tmpHash = New MD5CryptoServiceProvider().ComputeHash(tmpSource)
        Dim sOutput As New StringBuilder(tmpHash.Length)
        For i = 0 To tmpHash.Length - 1
            sOutput.Append(tmpHash(i).ToString("X2"))
        Next
        Return sOutput.ToString

    End Function 'FUNCIONA

    Private Function CalcularDigitosVerticales(ByVal nombreTabla As String, laconfig As ConfiguracionConexion) As Long 'Concateno todos los DVH de la tabla y le aplico la funcionHash
        ' LO TENGO QUE HACER CUANDO HAGO UN ABM DE USUARIO

        Dim lstUsuario As New List(Of UsuarioEntity)
        Dim lstEvento As New List(Of EventoEntity)
        Dim AcumuladorDDVVH As Long

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        unaconexion.ConexionIniciar(laconfig)

        Try

            Dim una_Query As String = "Select DDVVH from " & nombreTabla & " "

            Dim resultado As IDataReader = CType(unaconexion.Ejecutar(una_Query, False, IConexion.TipoRetorno.Tupla).ResultadoConectado, IDataReader)

            Try
                lstUsuario = DataReadObjeto.RealizarMapeo(Of UsuarioEntity)(resultado)
                AcumuladorDDVVH = 0
                For Each unDDVVH As UsuarioEntity In lstUsuario

                    AcumuladorDDVVH = AcumuladorDDVVH + unDDVVH.DDVVH

                Next
            Catch ex As Exception

            End Try

            Try
                lstEvento = DataReadObjeto.RealizarMapeo(Of EventoEntity)(resultado)
                AcumuladorDDVVH = 0
                For Each unDDVVH As EventoEntity In lstEvento

                    AcumuladorDDVVH = AcumuladorDDVVH + unDDVVH.DDVVH

                Next
            Catch ex As Exception

            End Try

        Catch ex As Exception
            'Lanzar exception
        End Try
        Return AcumuladorDDVVH
    End Function

    Public Sub ActualizarDigitosVerificadorVerticales(nombreTabla As String, LaConfig As ConfiguracionConexion)

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        Dim DDVVV As Long = CalcularDigitosVerticales(nombreTabla, LaConfig)

        unaconexion.ConexionIniciar(LaConfig)

        unaconexion.Ejecutar("Update DDVVV set DDVVV=@DDVVV where Descripcion=@nombreTabla", False, IConexion.TipoRetorno.SinResultado, DDVVV, nombreTabla)

        unaconexion.ConexionFinalizar()

    End Sub

    Public Function TraerDDVVV(nombreTabla As String, LaConfig As ConfiguracionConexion) As Long

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)

        Dim una_Query As String = "Select DDVVV from DDVVV where Descripcion = '" & nombreTabla & "'"

        unaconexion.ConexionIniciar(LaConfig)

        Dim Resultado As String = unaconexion.Ejecutar(una_Query, False, IConexion.TipoRetorno.Escalar).ResultadoEscalar

        Dim ResultadoDDVVV As Long = CLng(Resultado)

        unaconexion.ConexionFinalizar()

        Return ResultadoDDVVV

    End Function

    Public Function VerificarIntegridad(nombreTabla As String, LaConfig As ConfiguracionConexion) As Boolean

        If TraerDDVVV(nombreTabla, LaConfig) = CalcularDigitosVerticales(nombreTabla, LaConfig) Then
            Return True
        End If

        Return False
    End Function



End Class
