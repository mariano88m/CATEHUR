Imports BE
Imports BLL
Public Class Frm_AsignacionPersonal
    Implements IObservador

    Dim gestorEvento As New EventoBLL
    Dim gestorEmpleado As New EmpleadoBLL
    Dim unEmpleado As New EmpleadoEntity

    Private Sub Frm_AsignacionPersonal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        FrmPantallaPrincipal.oSujetoConcreto.Unsubscribe(Me)
        Me.Dispose()
    End Sub

    Private Sub Frm_AsignacionPersonal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FrmPantallaPrincipal.oSujetoConcreto.Subscribe(Me)
        UpdateState(FrmPantallaPrincipal.oSujetoConcreto)

        dt_eventos.DataSource = gestorEvento.TraerTodosLosEventosPreparados(FrmLogin.ConfiguracionBase)

        lst_camarero.DataSource = gestorEmpleado.TraerTodosLosCamareros(FrmLogin.ConfiguracionBase)
        Lst_cocinero.DataSource = gestorEmpleado.TraerTodosLosCocineros(FrmLogin.ConfiguracionBase)
    End Sub

    Private Sub lst_camarero_Click(sender As Object, e As EventArgs) Handles lst_camarero.Click

        unEmpleado = TryCast(lst_camarero.SelectedItem, EmpleadoEntity)

        If unEmpleado IsNot Nothing Then
            txt_nombreEmpleado.Text = unEmpleado.Nombre
            txt_ApellidoEmpleado.Text = unEmpleado.Apellido
            txt_EmailEmpleado.Text = unEmpleado.email
            txt_DomicilioEmpleado.Text = unEmpleado.Domicilio

            txt_telefonoEmpleado.Text = unEmpleado.Telefono
            lbl_idEmpleado.Text = CStr(unEmpleado.IdEmpleado)
            txt_tipoEmpleado.Text = unEmpleado.unTipoEmpleado.DescripcionTipoEmpleado
            lbl_TipoEmpleado.Text = CStr(unEmpleado.unTipoEmpleado.IdTipoEmpleado)
        End If




    End Sub

    Private Sub Lst_cocinero_Click(sender As Object, e As EventArgs) Handles Lst_cocinero.Click
        unEmpleado = TryCast(Lst_cocinero.SelectedItem, EmpleadoEntity)

        If unEmpleado IsNot Nothing Then
            txt_nombreEmpleado.Text = unEmpleado.Nombre
            txt_ApellidoEmpleado.Text = unEmpleado.Apellido
            txt_EmailEmpleado.Text = unEmpleado.email
            txt_DomicilioEmpleado.Text = unEmpleado.Domicilio

            txt_telefonoEmpleado.Text = unEmpleado.Telefono
            lbl_idEmpleado.Text = CStr(unEmpleado.IdEmpleado)
            txt_tipoEmpleado.Text = unEmpleado.unTipoEmpleado.DescripcionTipoEmpleado
            lbl_TipoEmpleado.Text = CStr(unEmpleado.unTipoEmpleado.IdTipoEmpleado)
        End If



    End Sub

    Private Sub btn_AsignarEmpleado_Click(sender As Object, e As EventArgs) Handles btn_AsignarEmpleado.Click
        Try


            For Each row As DataGridViewRow In Me.dt_eventos.SelectedRows

                Dim mEvento As New EventoEntity
                mEvento = TryCast(row.DataBoundItem, EventoEntity)

                If mEvento IsNot Nothing Then
                    Dim unEmpleado As New EmpleadoEntity
                    unEmpleado.IdEmpleado = CInt(lbl_idEmpleado.Text)
                    unEmpleado.unTipoEmpleado.IdTipoEmpleado = CInt(lbl_TipoEmpleado.Text)
                    If gestorEmpleado.asignarEmpleadoEvento(unEmpleado, mEvento, gestorEmpleado.TraerEmpleadosXEvento(mEvento.id_evento, FrmLogin.ConfiguracionBase), FrmLogin.ConfiguracionBase) Then
                        MsgBox("Empleado Asignado")
                    Else
                        MsgBox("No hay cupo para otro tipo del empleado seleccionado")
                    End If
                End If


            Next

            ActualizarListaEmpleados()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dt_eventos_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dt_eventos.CellMouseClick
        Try
            For Each row As DataGridViewRow In Me.dt_eventos.SelectedRows

                Dim mEvento As New EventoEntity
                mEvento = TryCast(row.DataBoundItem, EventoEntity)

                If mEvento IsNot Nothing Then
                    dt_empleados.DataSource = gestorEmpleado.TraerEmpleadosXEvento(mEvento.id_evento, FrmLogin.ConfiguracionBase)
                End If


            Next
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ActualizarListaEmpleados()

        For Each row As DataGridViewRow In Me.dt_eventos.SelectedRows

            Dim mEvento As New EventoEntity
            mEvento = TryCast(row.DataBoundItem, EventoEntity)

            If mEvento IsNot Nothing Then
                dt_empleados.DataSource = gestorEmpleado.TraerEmpleadosXEvento(mEvento.id_evento, FrmLogin.ConfiguracionBase)
            End If


        Next
    End Sub


    Private Sub btn_baja_Click(sender As Object, e As EventArgs) Handles btn_baja.Click
        Try

            For Each row As DataGridViewRow In Me.dt_eventos.SelectedRows

                Dim mEvento As New EventoEntity
                mEvento = TryCast(row.DataBoundItem, EventoEntity)

                For Each row2 As DataGridViewRow In Me.dt_empleados.SelectedRows

                    Dim mEmpleado As New EmpleadoEntity
                    mEmpleado = TryCast(row2.DataBoundItem, EmpleadoEntity)

                    If mEmpleado IsNot Nothing Then
                        gestorEmpleado.EliminarEmpleadoEvento(mEmpleado.IdEmpleado, mEvento.id_evento, FrmLogin.ConfiguracionBase)
                        MsgBox("Empleado Desasignado del evento")
                    End If


                Next


            Next
            ActualizarListaEmpleados()

        Catch ex As Exception

        End Try
    End Sub


    Public Sub UpdateState(sender As SujetoConcreto) Implements IObservador.UpdateState
        Traductor.GetTraducir.Traducime(Me, sender)
    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Me.Close()

    End Sub
End Class