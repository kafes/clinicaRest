Public Class FrmEditarIngreso

    Private rest As New Rest

    Private idIngreso As String
    Private lstIdTipoIngreso As New List(Of String)
    Private idPaciente As String

    Private paginadorPaciente As Paginador

    Public Sub New(ByVal _idIngreso As Long)
        InitializeComponent()
        Me.idIngreso = _idIngreso
        paginadorPaciente = New Paginador(5)
        cargar(_idIngreso)
    End Sub

    Public Async Sub cargar(ByVal _idIngreso As Long)
        Dim data As Object()
        data = Await rest.getIngresoById(_idIngreso)

        If data IsNot Nothing Then
            Dim ingreso As Object() = New Object() {data(0), data(7), data(8), data(9), data(10), data(11)}
            cargarIngreso(ingreso)
            Dim tipoIngreso As Object() = New Object() {data(1), data(2)}
            cargarTipoIngreso(tipoIngreso)
            Dim paciente As Object() = New Object() {data(3), data(4), data(5), data(6)}
            cargarPaciente(paciente)
            Me.idPaciente = paciente(0).ToString
        End If
    End Sub

    Private Async Sub btnGuardarCambios_Click(sender As Object, e As EventArgs) Handles btnGuardarCambios.Click
        Try
            Dim egreso As Object() = New Object() {"", ""}
            If chkEgreso.Checked Then
                egreso(0) = dtpFechaEgreso.Value
                egreso(1) = dtpHoraEgreso.Value
            End If

            Dim ingreso As Object() = New Object() {Me.idIngreso,
                                                    lstIdTipoIngreso.Item(cbTipoIngreso.SelectedIndex()),
                                                    txtIdPaciente.Text,
                                                    dtpFechaIngreso.Value,
                                                    egreso(0),
                                                    dtpHoraIngreso.Value,
                                                    egreso(1),
                                                    rtbObservaciones.Text
                }

            'idIngreso(0), idTipoIngreso(1), idPaciente(2), fechaIngreso(3), fechaEgreso(4), horaIngreso(5), horaEgreso(6)
            Dim ok As Boolean = Await rest.putIngreso(ingreso)
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al modificar el ingreso..." & ex.StackTrace.ToString)
        Finally
            Me.Dispose()
        End Try
    End Sub

    'idIngreso(0), fechaIngreso(1), fechaEgreso(2), horaIngreso(3), horaEgreso(4), observaciones(5)
    Private Sub cargarIngreso(_ingreso As Object())
        If _ingreso IsNot Nothing Then
            If _ingreso(1) IsNot Nothing Then
                dtpFechaIngreso.Value = DateTime.Parse(_ingreso(1).ToString)
            End If
            If _ingreso(3) IsNot Nothing Then
                dtpHoraIngreso.Value = DateTime.Parse(_ingreso(3).ToString)
            End If
            If _ingreso(2) IsNot Nothing Then
                dtpFechaEgreso.Value = DateTime.Parse(_ingreso(2).ToString)
            End If
            If _ingreso(4) IsNot Nothing Then
                dtpHoraEgreso.Value = DateTime.Parse(_ingreso(4).ToString)
            End If
            If _ingreso(5) IsNot Nothing Then
                rtbObservaciones.Text = _ingreso(5).ToString
            End If
        End If
    End Sub

    'idPaciente(0), nombres(1), apellidos(2), fechaNacimiento(3)
    Private Async Sub cargarPaciente(ByVal _paciente As Object())
        Dim data As New List(Of Object())
        Dim founded As Boolean = False

        If _paciente Is Nothing Then
            founded = True
        End If

        Try
            Do
                data = Await paginadorPaciente.paginadoPacientes

                If data IsNot Nothing Then
                    tblPaciente.Rows.Clear()
                    For Each paciente As Object() In data
                        tblPaciente.Rows.Add(paciente)
                        If paciente(0) = Me.idPaciente Then
                            tblPaciente.Rows(tblPaciente.RowCount - 1).Selected = True
                            founded = True
                        End If
                    Next
                End If
                If Not founded Then
                    paginadorPaciente.paginaActual = paginadorPaciente.paginaActual + 1
                    tblPaciente.Rows.Clear()
                Else
                    txtPagina.Text = paginadorPaciente.paginaActual & "/" & paginadorPaciente.totalPaginas
                End If
            Loop While Not founded

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al cargar los pacientes..." & ex.StackTrace)
        End Try
    End Sub

    'idTipoIngreso(0), nombre(1)
    Private Async Sub cargarTipoIngreso(ByVal _tipoIngreso As Object())
        cbTipoIngreso.Items.Clear()
        Dim data As New List(Of Object())

        Try
            data = Await rest.getTiposIngreso()

            If data IsNot Nothing Then
                For Each tipoIngreso As Object() In data
                    cbTipoIngreso.Items.Add(tipoIngreso(1))
                    lstIdTipoIngreso.Add(tipoIngreso(0))
                    If tipoIngreso(0) = _tipoIngreso(0) Then
                        cbTipoIngreso.SelectedIndex = (cbTipoIngreso.Items.Count - 1)
                    End If
                Next
            End If
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al cargar tipoIngreso...")
        End Try

    End Sub

    Private Sub chkEgreso_CheckedChanged(sender As Object, e As EventArgs) Handles chkEgreso.CheckedChanged
        If chkEgreso.Checked Then
            dtpFechaEgreso.Enabled = True
            dtpHoraEgreso.Enabled = True
        ElseIf Not chkEgreso.Checked Then
            dtpFechaEgreso.Enabled = False
            dtpHoraEgreso.Enabled = False
        End If
    End Sub

    Private Sub tblPaciente_SelectionChanged(sender As Object, e As EventArgs) Handles tblPaciente.SelectionChanged
        If tblPaciente.SelectedRows.Count > 0 Then
            Dim indexPaciente As Integer = tblPaciente.SelectedRows(0).Index
            txtIdPaciente.Text = tblPaciente.Rows.Item(indexPaciente).Cells(0).Value
            txtNombrePaciente.Text = tblPaciente.Rows.Item(indexPaciente).Cells(2).Value + ", " + tblPaciente.Rows.Item(indexPaciente).Cells(1).Value
            txtNacimiento.Text = tblPaciente.Rows.Item(indexPaciente).Cells(3).Value
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If paginadorPaciente.siguiente Then
            cargarPaciente(Nothing)
        End If
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        If paginadorPaciente.anterior Then
            cargarPaciente(Nothing)
        End If
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        If paginadorPaciente.ultimo Then
            cargarPaciente(Nothing)
        End If
    End Sub

    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        If paginadorPaciente.primero Then
            cargarPaciente(Nothing)
        End If
    End Sub

End Class