Imports BE
Public Class MapperIngrediente
    Public Function TraerIngredientesXPlato(unPlato As PlatoEntity, laConfig As ConfiguracionConexion) As List(Of ingredienteEntity)

        Dim LstIngredientes As New List(Of ingredienteEntity)

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)

        unaconexion.ConexionIniciar(laConfig)

        Dim resultado As IDataReader = unaconexion.Ejecutar("select Ingrediente.id_ingrediente, Ingrediente.nombreIngrediente, Ingrediente.precio, IngredienteXPlato.Cantidad from Ingrediente,IngredienteXPlato,Plato where Ingrediente.id_ingrediente=IngredienteXPlato.id_ingrediente and IngredienteXPlato.id_plato = Plato.id_plato and Plato.id_plato=@id_plato", False, IConexion.TipoRetorno.Tupla, unPlato.id_plato).ResultadoConectado

        LstIngredientes = DataReadObjeto.RealizarMapeo(Of ingredienteEntity)(resultado)

        unaconexion.ConexionFinalizar()

        Return LstIngredientes

    End Function

    Public Function TraerIngredientes(laConfig As ConfiguracionConexion) As List(Of ingredienteEntity)

        Dim LstIngredientes As New List(Of ingredienteEntity)

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)

        unaconexion.ConexionIniciar(laConfig)

        Dim resultado As IDataReader = unaconexion.Ejecutar("select Ingrediente.id_ingrediente, Ingrediente.nombreIngrediente, Ingrediente.precio from Ingrediente", False, IConexion.TipoRetorno.Tupla).ResultadoConectado

        LstIngredientes = DataReadObjeto.RealizarMapeo(Of ingredienteEntity)(resultado)

        unaconexion.ConexionFinalizar()

        Return LstIngredientes

    End Function

    Public Function TraerIngredientexID(id_ingrediente As Integer, laConfig As ConfiguracionConexion) As ingredienteEntity

        Dim unIngrediente As New ingredienteEntity

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)

        unaconexion.ConexionIniciar(laConfig)

        Dim resultado As IDataReader = unaconexion.Ejecutar("select Ingrediente.id_ingrediente, Ingrediente.nombreIngrediente, Ingrediente.precio from Ingrediente where Ingrediente.id_ingrediente =@id_ingrediente", False, IConexion.TipoRetorno.Tupla, id_ingrediente).ResultadoConectado

        unIngrediente = DataReadObjeto.RealizarMapeoSinLista(Of ingredienteEntity)(resultado)

        unaconexion.ConexionFinalizar()

        Return unIngrediente

    End Function



    Public Function AgregarIngrediente(unIngrediente As ingredienteEntity, id_plato As Integer, LaConfig As ConfiguracionConexion) As Boolean


        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        Try
            unaconexion.ConexionIniciar(LaConfig)

            unaconexion.TransaccionIniciar()

            unaconexion.Ejecutar("Insert into IngredienteXPlato (id_plato,id_ingrediente,Cantidad) VALUES (@id_plato,@id_ingrediente,@Cantidad)", False, IConexion.TipoRetorno.SinResultado, id_plato, unIngrediente.id_ingrediente, unIngrediente.Cantidad)

            unaconexion.TransaccionAceptar()

            Return True
        Catch ex As Exception

            unaconexion.TransaccionCancelar()
            Return False
        End Try

        unaconexion.ConexionFinalizar()


    End Function

    Public Function quitarIngredientes(unIngrediente As ingredienteEntity, id_plato As Integer, LaConfig As ConfiguracionConexion) As Boolean


        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        Try
            unaconexion.ConexionIniciar(LaConfig)

            unaconexion.TransaccionIniciar()

            unaconexion.Ejecutar("DELETE FROM IngredienteXPlato WHERE id_plato =@id_plato and id_ingrediente=@id_ingrediente and Cantidad=@Cantidad ", False, IConexion.TipoRetorno.SinResultado, id_plato, unIngrediente.id_ingrediente, unIngrediente.Cantidad)

            unaconexion.TransaccionAceptar()

            Return True
        Catch ex As Exception

            unaconexion.TransaccionCancelar()
            Return False
        End Try

        unaconexion.ConexionFinalizar()


    End Function


    Public Function AgregarIngrediente(unIngrediente As ingredienteEntity, LaConfig As ConfiguracionConexion) As Boolean


        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        Try
            unaconexion.ConexionIniciar(LaConfig)

            unaconexion.TransaccionIniciar()

            unaconexion.Ejecutar("Insert into Ingrediente (NombreIngrediente,Precio) VALUES (@NombreIngrediente,@Precio)", False, IConexion.TipoRetorno.SinResultado, unIngrediente.NombreIngrediente, unIngrediente.precio)

            unaconexion.TransaccionAceptar()

            Return True
        Catch ex As Exception

            unaconexion.TransaccionCancelar()
            Return False
        End Try

        unaconexion.ConexionFinalizar()


    End Function

    Public Function BajaIngrediente(unIngrediente As ingredienteEntity, LaConfig As ConfiguracionConexion) As Boolean


        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)
        Try
            unaconexion.ConexionIniciar(LaConfig)

            unaconexion.TransaccionIniciar()

            unaconexion.Ejecutar("delete from Ingrediente where NombreIngrediente=@NombreIngrediente and precio=@Precio", False, IConexion.TipoRetorno.SinResultado, unIngrediente.NombreIngrediente, unIngrediente.precio)

            unaconexion.TransaccionAceptar()

            Return True
        Catch ex As Exception

            unaconexion.TransaccionCancelar()
            Return False
        End Try

        unaconexion.ConexionFinalizar()


    End Function









    Public Function VerificarExistenciaIngrediente(NombreIngrediente As String, laConfig As ConfiguracionConexion) As Boolean

        Dim LstIngredientes As New List(Of ingredienteEntity)

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)

        unaconexion.ConexionIniciar(laConfig)

        Dim resultado As IDataReader = unaconexion.Ejecutar("select * from Ingrediente where NombreIngrediente=@NombreIngrediente", False, IConexion.TipoRetorno.Tupla, NombreIngrediente).ResultadoConectado

        LstIngredientes = DataReadObjeto.RealizarMapeo(Of ingredienteEntity)(resultado)

        unaconexion.ConexionFinalizar()

        If LstIngredientes.Count = 0 Then
            Return False
        Else
            Return True
        End If

    End Function

    Public Function TraerIDIngrediente(NombreIngrediente As String, laConfig As ConfiguracionConexion) As Integer

        Dim unIngrediente As New ingredienteEntity

        Dim unaconexion As New Conexion(Conexion.MotoresDisponibles.SqlServerClient)

        unaconexion.ConexionIniciar(laConfig)

        Try
            Dim resultado As IDataReader = unaconexion.Ejecutar("select id_ingrediente from Ingrediente where NombreIngrediente=@NombreIngrediente", False, IConexion.TipoRetorno.Tupla, NombreIngrediente).ResultadoConectado

            unIngrediente = DataReadObjeto.RealizarMapeoSinLista(Of ingredienteEntity)(resultado)

            unaconexion.ConexionFinalizar()
            Return unIngrediente.id_ingrediente
        Catch ex As Exception
            unaconexion.ConexionFinalizar()
            Return False
        End Try

    End Function


End Class
