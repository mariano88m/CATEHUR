Imports BE
Imports DAL
Public Class IngredienteBLL
    Dim unGestorIngrediente As New MapperIngrediente

    Public Function TraerIngredientesxPlato(unPlato As PlatoEntity, Laconfig As ConfiguracionConexion) As List(Of ingredienteEntity)

        Return unGestorIngrediente.TraerIngredientesXPlato(unPlato, Laconfig)

    End Function
    Public Function TraerIngredientes(Laconfig As ConfiguracionConexion) As List(Of ingredienteEntity)

        Return unGestorIngrediente.TraerIngredientes(Laconfig)

    End Function


    Public Function TraerIngredientexID(id_ingrediente As Integer, Laconfig As ConfiguracionConexion) As ingredienteEntity

        Return unGestorIngrediente.TraerIngredientexID(id_ingrediente, Laconfig)

    End Function

    Public Function AgregarIngrediente(unIngrediente As ingredienteEntity, Laconfig As ConfiguracionConexion, Optional id_plato As Integer = 0) As Boolean

        Try
            If unGestorIngrediente.VerificarExistenciaIngrediente(unIngrediente.NombreIngrediente, Laconfig) Then

                unGestorIngrediente.AgregarIngrediente(unIngrediente, id_plato, Laconfig)

            Else

                unGestorIngrediente.AgregarIngrediente(unIngrediente, Laconfig)

                unIngrediente.id_ingrediente = unGestorIngrediente.TraerIDIngrediente(unIngrediente.NombreIngrediente, Laconfig)

                unGestorIngrediente.AgregarIngrediente(unIngrediente, id_plato, Laconfig)
            End If

            Return True
        Catch ex As Exception
            Return False
        End Try


    End Function

    Public Function quitarIngredientes(unIngrediente As ingredienteEntity, Laconfig As ConfiguracionConexion, id_plato As Integer) As Boolean

        Try
            unGestorIngrediente.quitarIngredientes(unIngrediente, id_plato, Laconfig)
            Return True
        Catch ex As Exception
            Return False
        End Try


    End Function
    Public Function BajaIngrediente(unIngrediente As ingredienteEntity, laconfig As ConfiguracionConexion) As Boolean

        Return unGestorIngrediente.BajaIngrediente(unIngrediente, laconfig)
        
    End Function

End Class
