Imports BE

Public Class MapperPlato
    Public Function TraerPlatos(unTipoMenu As TipoMenuEntity, id_catering As Integer, laConfig As ConfiguracionConexion) As List(Of PlatoEntity)

        Dim lstPlato As New List(Of PlatoEntity)

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)

        unaconexion.ConexionIniciar(laConfig)

        Dim resultado As IDataReader = unaconexion.Ejecutar("select Plato.id_plato,Plato.nombrePlato,Plato.id_tipoMenu,Plato.ManoDeObra from Plato,Catering,TipoMenuXCatering,TipoMenu,PlatoXCatering where Catering.id_Catering=TipoMenuXCatering.id_Catering and TipoMenuXCatering.id_TipoMenu = TipoMenu.id_TipoMenu and TipoMenu.id_TipoMenu =Plato.id_tipoMenu and Plato.id_plato = PlatoXCatering.id_plato and PlatoXCatering.id_catering = Catering.id_Catering and Catering.id_Catering = @id_catering and TipoMenu.id_TipoMenu = @id_TipoMenu and Plato.Habilitado = '1' ", False, IConexion.TipoRetorno.Tupla, id_catering, unTipoMenu.id_TipoMenu).ResultadoConectado

        lstPlato = DataReadObjeto.RealizarMapeo(Of PlatoEntity)(resultado)

        unaconexion.ConexionFinalizar()
        Return lstPlato

    End Function

    Public Function TraerPlatos(laConfig As ConfiguracionConexion) As List(Of PlatoEntity)

        Dim lstPlato As New List(Of PlatoEntity)

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)

        unaconexion.ConexionIniciar(laConfig)

        Dim resultado As IDataReader = unaconexion.Ejecutar("select Plato.id_plato,Plato.nombrePlato,Plato.id_tipoMenu,Plato.ManoDeObra from Plato where Habilitado = '1' ", False, IConexion.TipoRetorno.Tupla).ResultadoConectado

        lstPlato = DataReadObjeto.RealizarMapeo(Of PlatoEntity)(resultado)

        unaconexion.ConexionFinalizar()
        Return lstPlato

    End Function


    Public Function BuscarPrecio(unPlato As PlatoEntity, laConfig As ConfiguracionConexion) As PlatoEntity

        Dim PlatoResultado As New PlatoEntity

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)

        unaconexion.ConexionIniciar(laConfig)

        Dim resultado As IDataReader = unaconexion.Ejecutar("select IngredienteXPlato.id_plato, sum(((ingrediente.precio)*IngredienteXPlato.Cantidad))as precio from Ingrediente, IngredienteXPlato where Ingrediente.id_ingrediente= IngredienteXPlato.id_ingrediente and IngredienteXPlato.id_plato = @id_plato group by IngredienteXPlato.id_plato", False, IConexion.TipoRetorno.Tupla, unPlato.id_plato).ResultadoConectado

        PlatoResultado = DataReadObjeto.RealizarMapeoSinLista(Of PlatoEntity)(resultado)

        unaconexion.ConexionFinalizar()
        Return PlatoResultado
    End Function

    Public Function TraerPlatosXEvento(id_evento As Integer, laConfig As ConfiguracionConexion) As List(Of PlatoEntity)

        Dim lstPlato As New List(Of PlatoEntity)

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)

        unaconexion.ConexionIniciar(laConfig)

        Dim resultado As IDataReader = unaconexion.Ejecutar("select Plato.id_plato,Plato.nombrePlato,Plato.id_tipoMenu from Plato, PlatoXEvento where PlatoXEvento.id_plato = plato.id_plato and PlatoXEvento.id_evento = @id_evento and Plato.Habilitado = '1' ", False, IConexion.TipoRetorno.Tupla, id_evento).ResultadoConectado

        lstPlato = DataReadObjeto.RealizarMapeo(Of PlatoEntity)(resultado)

        unaconexion.ConexionFinalizar()
        Return lstPlato

    End Function

    Public Function TraerUnPlato(id_plato As Integer, laConfig As ConfiguracionConexion) As PlatoEntity

        Dim PlatoResultado As New PlatoEntity

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)

        unaconexion.ConexionIniciar(laConfig)

        Dim resultado As IDataReader = unaconexion.Ejecutar("select * from plato where id_plato = @id_plato and Habilitado = '1' ", False, IConexion.TipoRetorno.Tupla, id_plato).ResultadoConectado

        PlatoResultado = DataReadObjeto.RealizarMapeoSinLista(Of PlatoEntity)(resultado)

        unaconexion.ConexionFinalizar()

        Return PlatoResultado

    End Function

    Public Function AltaPlato(unPlato As PlatoEntity, LaConfig As ConfiguracionConexion) As Boolean

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        Try
            unaconexion.ConexionIniciar(LaConfig)

            unaconexion.TransaccionIniciar()

            unaconexion.Ejecutar("Insert into Plato (nombrePlato,id_tipoMenu,ManoDeObra,Habilitado) VALUES (@nombrePlato,@id_tipoMenu,@ManoDeObra,'1')", False, IConexion.TipoRetorno.SinResultado, unPlato.nombrePlato, unPlato.id_tipoMenu, unPlato.manoDeObra)

            unaconexion.TransaccionAceptar()

            Return True
        Catch ex As Exception

            unaconexion.TransaccionCancelar()
            Return False
        End Try

        unaconexion.ConexionFinalizar()

    End Function
    Public Function ModificarPlato(unPlato As PlatoEntity, LaConfig As ConfiguracionConexion) As Boolean

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        Try
            unaconexion.ConexionIniciar(LaConfig)

            unaconexion.TransaccionIniciar()

            unaconexion.Ejecutar("Update Plato set nombrePlato=@nombrePlato, id_tipoMenu= @id_tipoMenu, ManoDeObra = @ManoDeObra where id_plato=@id_plato and Habilitado = '1' ", False, IConexion.TipoRetorno.SinResultado, unPlato.nombrePlato, unPlato.id_tipoMenu, unPlato.manoDeObra, unPlato.id_plato)

            unaconexion.TransaccionAceptar()

            Return True
        Catch ex As Exception

            unaconexion.TransaccionCancelar()
            Return False
        End Try

        unaconexion.ConexionFinalizar()

    End Function

    Public Function BajaPlato(unPlato As PlatoEntity, LaConfig As ConfiguracionConexion) As Boolean

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        Try
            unaconexion.ConexionIniciar(LaConfig)

            unaconexion.TransaccionIniciar()

            unaconexion.Ejecutar("Update Plato set Habilitado ='0' where nombrePlato=@nombrePlato, id_tipoMenu= @id_tipoMenu, ManoDeObra = @ManoDeObra ", False, IConexion.TipoRetorno.SinResultado, unPlato.nombrePlato, unPlato.id_tipoMenu, unPlato.manoDeObra)

            unaconexion.TransaccionAceptar()

            Return True
        Catch ex As Exception

            unaconexion.TransaccionCancelar()
            Return False
        End Try

        unaconexion.ConexionFinalizar()

    End Function


    Public Function TraerIDPlato(mPlato As PlatoEntity, laConfig As ConfiguracionConexion) As Integer

        Dim unPlato As New PlatoEntity

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)

        unaconexion.ConexionIniciar(laConfig)

        Try
            Dim resultado As IDataReader = unaconexion.Ejecutar("select id_plato from Plato where NombrePlato=@NombrePlato and manoDeObra=@manoDeObra and id_tipoMenu=@id_tipoMenu", False, IConexion.TipoRetorno.Tupla, mPlato.nombrePlato, mPlato.manoDeObra, mPlato.id_tipoMenu).ResultadoConectado

            unPlato = DataReadObjeto.RealizarMapeoSinLista(Of PlatoEntity)(resultado)

            unaconexion.ConexionFinalizar()
            Return unPlato.id_plato
        Catch ex As Exception
            unaconexion.ConexionFinalizar()
            Return False
        End Try

    End Function



End Class
