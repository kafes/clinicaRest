Public Class FrmIngreso

    Private rest As New Rest
    Private converter As New Converter()
    Private paginadorIngreso As Paginador

    Private Sub frmIngreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        paginadorIngreso = New Paginador(5)
        cargarIngresos()
    End Sub

    Public Async Sub cargarIngresos()
        Dim data As New List(Of Object())
        Try
            data = Await paginadorIngreso.paginadoIngreso()
            txtPagina.Text = paginadorIngreso.paginaActual & "/" & paginadorIngreso.totalPaginas

            If data IsNot Nothing Then
                tblIngreso.Rows.Clear()
                For Each ingreso As Object() In data
                    tblIngreso.Rows.Add(ingreso)
                Next
            End If
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al cargar los ingresos...")
        End Try
    End Sub


    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnNuevoIngreso.Click
        Dim nuevoIngreso As New FrmNuevoIngreso()
        nuevoIngreso.ShowDialog(Me)
        cargarIngresos()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificarIngreso.Click
        If tblIngreso.SelectedRows.Count > 0 Then
            Dim index As Integer = tblIngreso.SelectedRows(0).Index
            Dim modificarIngreso As New FrmEditarIngreso(tblIngreso.Rows.Item(index).Cells(0).Value)
            modificarIngreso.ShowDialog(Me)
            cargarIngresos()
        Else
            MessageBox.Show("Seleccione un ingreso a modificar...")
        End If
    End Sub

    Private Async Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminarIngreso.Click
        Try
            If tblIngreso.SelectedRows.Count > 0 Then
                If MsgBox("Desea eliminar permanente este ingreso y sus detalles?", vbYesNo, "Eliminar") = vbYes Then
                    Await rest.deleteIngreso(txtIdIngreso.Text)
                    paginadorIngreso.paginaActual = 1
                    cargarIngresos()
                End If
            Else
                MessageBox.Show("Seleccione Ingreso a eliminar...")
            End If
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al eliminar el ingreso...")
        End Try

    End Sub

    Private Sub tblIngreso_SelectionChanged(sender As Object, e As EventArgs) Handles tblIngreso.SelectionChanged
        Try
            If tblIngreso.SelectedRows.Count > 0 Then
                Dim index As Integer = tblIngreso.SelectedRows(0).Index
                txtIdIngreso.Text = tblIngreso.Rows.Item(index).Cells(0).Value
                txtTipoIngreso.Text = tblIngreso.Rows.Item(index).Cells(1).Value
                txtIdPaciente.Text = tblIngreso.Rows.Item(index).Cells(3).Value + ", " + tblIngreso.Rows.Item(index).Cells(2).Value
                txtFechaIngreso.Text = tblIngreso.Rows.Item(index).Cells(4).Value
                txtFechaEgreso.Text = tblIngreso.Rows.Item(index).Cells(5).Value

                cargarDetalles(tblIngreso.Rows.Item(index).Cells(0).Value)
            Else
                tblDetalle.Rows.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al cargar los datos del ingreso seleccionado...")
        End Try
    End Sub

    Private Sub tblDetalle_SelectionChanged(sender As Object, e As EventArgs) Handles tblDetalle.SelectionChanged
        'idIngreso(0), idAreaCentroEspacio(1), idAsignacionPersonalCentroArea(2), idTurno(3), area(4), centro(5), nombrePersonal(6), apellidosPersonal(7), fechaDetalle(8) 
        Try
            If tblDetalle.SelectedRows.Count > 0 Then
                Dim index As Integer = tblDetalle.SelectedRows(0).Index
                txtIdIngresoDetalle.Text = tblDetalle.Rows.Item(index).Cells(0).Value
                txtArea.Text = tblDetalle.Rows.Item(index).Cells(4).Value
                txtCentro.Text = tblDetalle.Rows.Item(index).Cells(5).Value
                txtPersonal.Text = tblDetalle.Rows.Item(index).Cells(7).Value + ", " + tblDetalle.Rows.Item(index).Cells(7).Value
                txtFechaDetalle.Text = tblDetalle.Rows.Item(index).Cells(8).Value
            End If
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al cargar los datos del ingreso detalle seleccionado...")
        End Try
    End Sub

    Private Async Sub cargarDetalles(ByVal idIngreso As Long)
        'idIngreso(0), idAreaCentroEspacio(1), idAsignacionPersonalCentroArea(2), idTurno(3), area(4), centro(5), nombrePersonal(6), apellidosPersonal(7), fechaDetalle(8) 
        tblDetalle.Rows.Clear()
        Try
            If idIngreso > 0 Then
                Dim data As New List(Of Object())
                data = Await rest.getIngresosDetallesByIdIngreso(idIngreso)
                If data IsNot Nothing Then
                    For Each ingresoDetalle As Object() In data
                        tblDetalle.Rows.Add(ingresoDetalle)
                    Next
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error al cargar los ingreso detalles: " + ex.StackTrace.ToString)
        End Try

    End Sub

    Private Sub btnAgregarDetalle_Click(sender As Object, e As EventArgs) Handles btnAgregarDetalle.Click
        If tblIngreso.SelectedRows.Count > 0 Then
            Dim index As Integer = tblIngreso.SelectedRows(0).Index
            Dim nuevoDetalle As New FrmNuevoDetalle(txtIdIngreso.Text)
            nuevoDetalle.ShowDialog(Me)
            cargarIngresos()
        End If

    End Sub

    Private Sub btnModificarDetalle_Click(sender As Object, e As EventArgs) Handles btnModificarDetalle.Click
        If tblDetalle.SelectedRows.Count > 0 Then
            Dim index As Integer = tblDetalle.SelectedRows(0).Index
            Dim key As Object() = New Object() {tblDetalle.Rows.Item(index).Cells(0).Value,
                                                tblDetalle.Rows.Item(index).Cells(1).Value,
                                                tblDetalle.Rows.Item(index).Cells(2).Value,
                                                tblDetalle.Rows.Item(index).Cells(3).Value
                                                }
            Dim editarDetalle As New FrmEditarDetalle(key)
            editarDetalle.ShowDialog(Me)
            cargarDetalles(tblIngreso.SelectedRows(0).Cells(0).Value)
        Else
            MessageBox.Show("Seleccione un ingreso detalle a editar...")
        End If

    End Sub

    Private Async Sub btnEliminarDetalle_Click(sender As Object, e As EventArgs) Handles btnEliminarDetalle.Click
        If tblDetalle.SelectedRows.Count > 0 Then
            If MsgBox("Desea eliminar permanente este registro y sus detalles?", vbYesNo, "Eliminar") = vbYes Then
                'If the Yes button is clicked ...
                Dim index As Integer = tblDetalle.SelectedRows(0).Index
                Dim key As Object() = New Object() {tblDetalle.Rows.Item(index).Cells(0).Value,
                                                tblDetalle.Rows.Item(index).Cells(1).Value,
                                                tblDetalle.Rows.Item(index).Cells(2).Value,
                                                tblDetalle.Rows.Item(index).Cells(3).Value
                                                }
                Await rest.deleteIngresoDetalle(key)
                cargarDetalles(tblIngreso.SelectedRows(0).Cells(0).Value)
            End If
        Else
            MessageBox.Show("Seleccione Ingreso detalle a eliminar...")
        End If
    End Sub


    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If paginadorIngreso.siguiente Then
            cargarIngresos()
        End If
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        If paginadorIngreso.anterior Then
            cargarIngresos()
        End If
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        If paginadorIngreso.ultimo Then
            cargarIngresos()
        End If
    End Sub

    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        If paginadorIngreso.primero Then
            cargarIngresos()
        End If
    End Sub


End Class
