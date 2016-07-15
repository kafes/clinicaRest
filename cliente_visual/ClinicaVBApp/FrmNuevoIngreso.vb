Public Class FrmNuevoIngreso

    Private rest As New Rest

    Private paginadorPaciente As Paginador
    Private paginadorApcae As Paginador

    Private lstIdTipoIngreso As New List(Of String)

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmIngreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        paginadorPaciente = New Paginador(5)
        paginadorApcae = New Paginador(5)
        cargarTipoIngreso()
        cargarPacientes()
        cargarApcae()
    End Sub

    Public Async Sub cargarPacientes()
        Dim data As New List(Of Object())
        Try
            data = Await paginadorPaciente.paginadoPacientes
            txtPagina.Text = paginadorPaciente.paginaActual & "/" & paginadorPaciente.totalPaginas

            If data IsNot Nothing Then
                tblPaciente.Rows.Clear()
                For Each ingreso As Object() In data
                    tblPaciente.Rows.Add(ingreso)
                Next
            End If
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al cargar los ingresos...")
        End Try
    End Sub

    Private Async Sub cargarApcae()
        tblApcae.Rows.Clear()
        Dim data As New List(Of Object())

        Try
            data = Await paginadorApcae.paginadoAPCAE()
            txtPaginaA.Text = paginadorApcae.paginaActual & "/" & paginadorApcae.totalPaginas

            If data IsNot Nothing Then
                For Each apcae As Object() In data
                    tblApcae.Rows.Add(apcae)
                Next
            End If
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al cargar las APCAE...")
        End Try

    End Sub

    Private Async Sub cargarTipoIngreso()
        Dim data As New List(Of Object())

        Try
            data = Await rest.getTiposIngreso()

            If data IsNot Nothing Then
                For Each tipoCentro As Object() In data
                    cbTipoIngreso.Items.Add(tipoCentro.GetValue(1))
                    lstIdTipoIngreso.Add(tipoCentro.GetValue(0))
                Next
            End If
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al cargar los tipos ingreso...")
        End Try

        cbTipoIngreso.SelectedIndex = 0
    End Sub

    Private Async Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            If tblPaciente.SelectedRows.Count > 0 And cbTipoIngreso.SelectedIndex >= 0 And tblApcae.SelectedRows.Count > 0 Then
                Dim egreso As Object() = New Object() {"", ""}

                If chkEgreso.Checked Then
                    egreso(0) = dtpFechaEgreso.Value
                    egreso(1) = dtpHoraEgreso.Value
                End If

                'idIngreso(0), idTipoIngreso(1), idPaciente(2), fechaIngreso(3), fechaEgreso(4), horaIngreso(5), horaEgreso(6), observaciones(7)
                Dim data As Object()
                data = New Object() {"1",
                                    lstIdTipoIngreso.Item(cbTipoIngreso.SelectedIndex),
                                    tblPaciente.SelectedRows(0).Cells(0).Value,
                                    dtpFechaIngreso.Value,
                                    egreso(0),
                                    dtpHoraIngreso.Value,
                                    egreso(1),
                                    txtObservacionesIngreso.Text
                                    }
                Dim idIngreso As Integer = 0
                idIngreso = Await rest.postIngreso(data)

                If idIngreso > 0 Then
                    'idIngreso(0), idAreaCentroEspacio(1), idAsignacionPersonalCentroArea(2), idTurno(3), fechaDetalle(4), horaDetalle(5), observaciones(6)
                    data = New Object() {idIngreso.ToString,
                                        tblApcae.SelectedRows(0).Cells(0).Value,
                                        tblApcae.SelectedRows(0).Cells(1).Value,
                                        tblApcae.SelectedRows(0).Cells(2).Value,
                                        dtpFechaIngreso.Value,
                                        dtpHoraIngreso.Value,
                                        txtObservacionesDetalle.Text
                                        }
                    Await rest.postIngresoDetalle(data)
                End If

                Me.Dispose()
            Else
                MessageBox.Show("Seleccione todos los campos requeridos...")
            End If
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error a la hora de agregar los datos: " + ex.StackTrace.ToString)
        End Try

    End Sub

    'El index de tblApcae inicia desde 3
    Private Sub tblApcae_SelectionChanged(sender As Object, e As EventArgs) Handles tblApcae.SelectionChanged
        If tblApcae.SelectedRows.Count > 0 Then
            Dim indexApcae As Integer = tblApcae.SelectedRows(0).Index
            txtArea.Text = tblApcae.Rows.Item(indexApcae).Cells(3).Value
            txtCentro.Text = tblApcae.Rows.Item(indexApcae).Cells(4).Value
            txtPersonal.Text = tblApcae.Rows.Item(indexApcae).Cells(6).Value + ", " + tblApcae.Rows.Item(indexApcae).Cells(5).Value
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

    Private Sub dtpFechaEgreso_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaEgreso.ValueChanged
        dtpFechaEgreso.Format = DateTimePickerFormat.Short
    End Sub

    Private Sub dtpHoraEgreso_ValueChanged(sender As Object, e As EventArgs) Handles dtpHoraEgreso.ValueChanged
        dtpFechaEgreso.CustomFormat = "hh:mm:ss tt"
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


    ''Paciente
    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If paginadorPaciente.siguiente Then
            cargarPacientes()
        End If
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        If paginadorPaciente.anterior Then
            cargarPacientes()
        End If
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        If paginadorPaciente.ultimo Then
            cargarPacientes()
        End If
    End Sub

    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        If paginadorPaciente.primero Then
            cargarPacientes()
        End If
    End Sub

    ''APCAE
    Private Sub btnSiguienteA_Click(sender As Object, e As EventArgs) Handles btnSiguienteA.Click
        If paginadorApcae.siguiente Then
            cargarApcae()
        End If
    End Sub

    Private Sub btnAnteriorA_Click(sender As Object, e As EventArgs) Handles btnAnteriorA.Click
        If paginadorApcae.anterior Then
            cargarApcae()
        End If
    End Sub

    Private Sub btnUltimoA_Click(sender As Object, e As EventArgs) Handles btnUltimoA.Click
        If paginadorApcae.ultimo Then
            cargarApcae()
        End If
    End Sub

    Private Sub btnPrimeroA_Click(sender As Object, e As EventArgs) Handles btnPrimeroA.Click
        If paginadorApcae.primero Then
            cargarApcae()
        End If
    End Sub

End Class