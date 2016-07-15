Public Class Paginador

    Property tamanioPagina As Integer
    Property totalPaginas As Double
    Property paginaActual As Integer

    Private Rest As New Rest

    Public Sub New(ByVal tamanioPagina As Integer)
        Me.tamanioPagina = tamanioPagina
        Me.paginaActual = 1
    End Sub

    Public Async Function paginadoPacientes() As Task(Of List(Of Object()))
        Dim data As New List(Of Object())
        Dim first = (tamanioPagina * (paginaActual - 1))

        Try
            Dim totalRegistros As Integer = Await Rest.getCountPacientes()
            totalPaginas = Math.Floor(totalRegistros / tamanioPagina)

            If totalRegistros Mod tamanioPagina > 0 Then
                totalPaginas = totalPaginas + 1
            End If

            data = Await Rest.getRangoPacientes(first, tamanioPagina)
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al realizar el paginado de los ingresos..." & ex.StackTrace)
        End Try

        Return data
    End Function

    Public Async Function paginadoAPCAE() As Task(Of List(Of Object()))
        Dim data As New List(Of Object())
        Dim first = (tamanioPagina * (paginaActual - 1))

        Try
            Dim totalRegistros As Integer = Await Rest.getCountAPCAE()
            totalPaginas = Math.Floor(totalRegistros / tamanioPagina)

            If totalRegistros Mod tamanioPagina > 0 Then
                totalPaginas = totalPaginas + 1
            End If
            data = Await Rest.getRangoAPCAE(first, tamanioPagina)
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al realizar el paginado de los APCAE..." & ex.StackTrace)
        End Try

        Return data
    End Function

    Public Async Function paginadoIngreso() As Task(Of List(Of Object()))
        Dim data As New List(Of Object())
        Dim first = (tamanioPagina * (paginaActual - 1))

        Try
            Dim totalRegistros = Await Rest.getCountIngresos()
            totalPaginas = Math.Floor(totalRegistros / tamanioPagina)

            If totalRegistros Mod tamanioPagina > 0 Then
                totalPaginas = totalPaginas + 1
            End If

            data = Await Rest.getRangoIngresos(first, tamanioPagina)
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al realizar el paginado de los ingresos...")
        End Try

        Return data
    End Function

    Public Function siguiente() As Boolean
        If paginaActual < totalPaginas Then
            paginaActual = paginaActual + 1
            Return True
        End If
        Return False
    End Function

    Public Function anterior() As Boolean
        If paginaActual > 1 Then
            paginaActual = paginaActual - 1
            Return True
        End If
        Return False
    End Function

    Public Function ultimo() As Boolean
        If totalPaginas > 0 Then
            paginaActual = totalPaginas
            Return True
        End If
        Return False
    End Function

    Public Function primero() As Boolean
        If totalPaginas > 0 Then
            paginaActual = 1
            Return True
        End If
        Return False
    End Function

End Class
