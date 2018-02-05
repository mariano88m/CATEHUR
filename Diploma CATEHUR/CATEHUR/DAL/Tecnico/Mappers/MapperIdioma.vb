Imports BE
Imports System.IO

Public Class MapperIdioma

    Public Function SeleccionarIdioma(UnIdioma As IdiomaEntity, LaConfig As ConfiguracionConexion) As IdiomaEntity

        Dim traduccion As New IdiomaEntity
        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        unaconexion.ConexionIniciar(LaConfig)

        Dim resultado As IDataReader = unaconexion.Ejecutar("select Traduccion from Traduccion, IdiomaControl  where Traduccion.id_idioma = @id_idioma and IdiomaControl.id_control = Traduccion.id_control and IdiomaControl.NombreControl = @NombreControl", False, IConexion.TipoRetorno.Tupla, UnIdioma.id, UnIdioma.name).ResultadoConectado

        traduccion = DataReadObjeto.RealizarMapeoSinLista(Of IdiomaEntity)(resultado)
        unaconexion.ConexionFinalizar()
        Return Traduccion

    End Function

    Public Function traerIdiomas(LaConfig As ConfiguracionConexion) As List(Of IdiomaEntity)

        Dim lstIdioma As New List(Of IdiomaEntity)

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        unaconexion.ConexionIniciar(LaConfig)

        Dim resultado As IDataReader = unaconexion.Ejecutar("select name from Idioma", False, IConexion.TipoRetorno.Tupla).ResultadoConectado

        lstIdioma = DataReadObjeto.RealizarMapeo(Of IdiomaEntity)(resultado)
        unaconexion.ConexionFinalizar()
        Return lstIdioma

    End Function
    Public Function Traducime(ByVal unFormName As String, unIdioma As String) As List(Of IdiomaControlEntity)

        Dim ConfiguracionBase As New ConfiguracionConexion

        Dim sr As New StreamReader("D:\Configuracion.xml")
        Dim ms As New System.IO.MemoryStream(System.Text.Encoding.ASCII.GetBytes(sr.ReadToEnd()))

        ConfiguracionBase = XML.DeSerializar(Of ConfiguracionConexion)(ms)
        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        unaconexion.ConexionIniciar(ConfiguracionBase)

        unaconexion.TransaccionIniciar()
        Dim listaControles As New List(Of IdiomaControlEntity)

        Try

            Dim resultadoemp As IDataReader = CType(unaconexion.Ejecutar("select IdiomaControl.namecontrol, IdiomaControl.text from IdiomaControl,Idioma where IdiomaControl.LANG_ID = Idioma.LANG_ID and IdiomaControl.page = @unFormName and Idioma.name = @name ", False, IConexion.TipoRetorno.Tupla, unFormName, unIdioma).ResultadoConectado, IDataReader)

            listaControles = DataReadObjeto.RealizarMapeo(Of IdiomaControlEntity)(resultadoemp)

            unaconexion.TransaccionAceptar()

        Catch ex As Exception

            unaconexion.TransaccionCancelar()

        Finally

            unaconexion.ConexionFinalizar()

        End Try

        Return listaControles

    End Function

    'Public Function TraerControles(LaConfig As ConfiguracionConexion, page As String) As List(Of IdiomaControlEntity)

    '    Dim UnUsuario As List(Of IdiomaControlEntity)

    '    Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
    '    unaconexion.ConexionIniciar(LaConfig)


    '    Dim resultado As IDataReader = unaconexion.Ejecutar("Select * from Usuario where Contraseña=@Contraseña and Username=@Username ", False, IConexion.TipoRetorno.Tupla, page).ResultadoConectado

    '    UnUsuario = DataReadObjeto.RealizarMapeo(Of IdiomaControlEntity)(resultado)

    '    Return UnUsuario

    'End Function








End Class
