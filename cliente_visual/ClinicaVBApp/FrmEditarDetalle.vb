Public Class FrmEditarDetalle

    Private rest As New Rest

    Private key As Object()

    Public Sub New(ByVal data As Object())
        InitializeComponent()
        key = data
    End Sub

    Private Sub FrmNuevoDetalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDetalle()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub

    Private Async Sub cargarDetalle()
        Try
            If key IsNot Nothing Then
                Dim data = Await rest.getIngresoDetalleByPK(Me.key)
                If data IsNot Nothing Then
                    'idIngreso(0), idAreaCentroEspacio(1), idAsignacionPersonalCentroArea(2), idTurno(3), area(4), centro(5), nombrePersonal(6), apellidosPersonal(7), fechaDetalle(8), horaDetalle(9), observaciones(10)
                    txtArea.Text = data(4).ToString
                    txtCentro.Text = data(5).ToString
                    txtPersonal.Text = data(7).ToString & ", " & data(6).ToString
                    dtpFechaDetalle.Value = DateTime.Parse(data(8).ToString)
                    dtpHoraDetalle.Value = DateTime.Parse(data(9).ToString)
                    txtObservacionesDetalle.Text = data(10).ToString
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error al cargar ingresoDetalles: " + ex.StackTrace.ToString)
        End Try
    End Sub

    Private Async Sub btnGuardarCambios_Click(sender As Object, e As EventArgs) Handles btnGuardarCambios.Click
        Try
            'idIngreso(0), idAreaCentroEspacio(1), idAsignacionPersonalCentroArea(2), idTurno(3), fechaDetalle(4), horaDetalle(5), observaciones(6)
            Dim data As Object() = New Object() {Me.key(0), Me.key(1), Me.key(2), Me.key(3), dtpFechaDetalle.Value, dtpHoraDetalle.Value, txtObservacionesDetalle.Text}

            Await rest.putIngresoDetalle(data)

            Me.Dispose()
        Catch ex As Exception
            MessageBox.Show("Error al editar ingresoDetalles: " + ex.StackTrace.ToString)
        End Try

    End Sub

End Class