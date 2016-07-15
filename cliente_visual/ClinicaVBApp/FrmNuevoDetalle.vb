Imports System.Net.Http
Imports System.Text
Public Class FrmNuevoDetalle

    Private rest As New Rest
    Private paginadorApcae As Paginador

    Private idIngreso As Object = New Object

    Public Sub New(ByVal _idIngreso As Object)
        InitializeComponent()
        Me.idIngreso = _idIngreso
    End Sub

    Private Sub FrmNuevoDetalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        paginadorApcae = New Paginador(5)
        cargarApcae()
    End Sub

    Public Async Sub cargarApcae()
        Dim data As New List(Of Object())
        Try
            data = Await paginadorApcae.paginadoAPCAE
            txtPagina.Text = paginadorApcae.paginaActual & "/" & paginadorApcae.totalPaginas

            If data IsNot Nothing Then
                tblApcae.Rows.Clear()
                For Each ingreso As Object() In data
                    tblApcae.Rows.Add(ingreso)
                Next
            End If
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al cargar los ingresos...")
        End Try
    End Sub

    Private Async Sub btnAgregarDetalle_Click(sender As Object, e As EventArgs) Handles btnAgregarDetalle.Click
        Try
            If tblApcae.SelectedRows.Count > 0 Then
                'idIngreso(0), idAreaCentroEspacio(1), idAsignacionPersonalCentroArea(2), idTurno(3), fechaDetalle(4), horaDetalle(5), observaciones(6)
                Dim data As Object() = New Object() {Me.idIngreso,
                                                    tblApcae.SelectedRows(0).Cells(0).Value,
                                                    tblApcae.SelectedRows(0).Cells(1).Value,
                                                    tblApcae.SelectedRows(0).Cells(2).Value,
                                                    dtpFechaDetalle.Value,
                                                    dtpHoraDetalle.Value,
                                                    txtObservacionesDetalle.Text
                                                    }
                Await rest.postIngresoDetalle(data)
                Me.Dispose()
            Else
                MessageBox.Show("Seleccione todos los campos requeridos...")
            End If
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error a la hora de agregar el ingresoDetalle: " + ex.StackTrace.ToString)
        End Try

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub

    Private Sub tblApcae_SelectionChanged_1(sender As Object, e As EventArgs) Handles tblApcae.SelectionChanged
        If tblApcae.SelectedRows.Count > 0 Then
            Dim indexApcae As Integer = tblApcae.SelectedRows(0).Index
            txtArea.Text = tblApcae.Rows.Item(indexApcae).Cells(3).Value
            txtCentro.Text = tblApcae.Rows.Item(indexApcae).Cells(4).Value
            txtPersonal.Text = tblApcae.Rows.Item(indexApcae).Cells(6).Value + ", " + tblApcae.Rows.Item(indexApcae).Cells(5).Value
        End If
    End Sub


    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If paginadorApcae.siguiente Then
            cargarApcae()
        End If
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        If paginadorApcae.anterior Then
            cargarApcae()
        End If
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        If paginadorApcae.ultimo Then
            cargarApcae()
        End If
    End Sub

    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        If paginadorApcae.primero Then
            cargarApcae()
        End If
    End Sub

End Class