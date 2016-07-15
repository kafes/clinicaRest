Imports System.Net.Http
Imports System.Text

Public Class Rest

    Private converter As New Converter
    Private urlBase As String = "http://localhost:8080/Clinica1/ws/"

    'findById Ingreso
    Public Async Function getIngresoById(ByVal idIngreso As Long) As Task(Of Object())
        Dim url As String = urlBase & "Ingreso/" & idIngreso
        Dim result As String = Nothing

        Console.WriteLine("2: " & idIngreso)
        Console.WriteLine("url: " & url)

        Try
            Using client As HttpClient = New HttpClient()
                result = Await client.GetStringAsync(url)
            End Using
        Catch ex As Exception
            Console.Write(ex.Message)
        End Try

        Return converter.jsonToIngreso(result)
    End Function

    'findAll Ingreso
    Public Async Function getIngresos() As Task(Of List(Of Object()))
        Dim url As String = urlBase + "Ingreso"
        Dim result As String = Nothing

        Try
            Using client As HttpClient = New HttpClient()
                result = Await client.GetStringAsync(url)
            End Using
        Catch ex As Exception
            Console.Write(ex.Message)
        End Try

        Return converter.jsonArrayToIngreso(result)

    End Function

    'findAll Paciente
    Public Async Function getPacientes() As Task(Of List(Of Object()))
        Dim url As String = urlBase + "Paciente"
        Dim result As String = Nothing

        Try
            Using client As HttpClient = New HttpClient()
                result = Await client.GetStringAsync(url)
            End Using
        Catch ex As Exception
            Console.Write(ex.Message)
        End Try

        Return converter.jsonArrayToPaciente(result)

    End Function

    'findAll TipoIngreso
    Public Async Function getTiposIngreso() As Task(Of List(Of Object()))
        Dim url As String = urlBase + "TipoIngreso"
        Dim result As String = Nothing

        Try
            Using client As HttpClient = New HttpClient()
                result = Await client.GetStringAsync(url)
            End Using
        Catch ex As Exception
            Console.Write(ex.Message)
        End Try

        Return converter.jsonArrayToTipoIngreso(result)

    End Function

    'findAll APCAE
    Public Async Function getAPCAEs() As Task(Of List(Of Object()))
        Dim url As String = urlBase + "APCAE"
        Dim result As String = Nothing

        Try
            Using client As HttpClient = New HttpClient()
                result = Await client.GetStringAsync(url)
            End Using
        Catch ex As Exception
            Console.Write(ex.Message)
        End Try

        Return converter.jsonArrayToAPCAE(result)

    End Function


    'findByIdIngreso IngresoDetalle
    Public Async Function getIngresosDetallesByIdIngreso(ByVal idIngreso As Long) As Task(Of List(Of Object()))
        Dim url As String = urlBase & "IngresoDetalle/" & idIngreso
        Dim result As String = Nothing

        Try
            Using client As HttpClient = New HttpClient()
                result = Await client.GetStringAsync(url)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error en getIngresosDetallesByIdIngreso: " + ex.StackTrace.ToString)
        End Try

        Return converter.jsonArrayToIngresoDetalle(result)

    End Function

    'findById IngresoDetalle
    Public Async Function getIngresoDetalleByPK(ByVal key As Object()) As Task(Of Object())
        Dim url As String = urlBase & "IngresoDetalle/" & key(0) & "/" & key(2) & "/" & key(1) & "/" & key(3)
        Dim result As String = Nothing

        Try
            Using client As HttpClient = New HttpClient()
                result = Await client.GetStringAsync(url)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error en getIngresosDetallesByIdIngreso: " + ex.StackTrace.ToString)
        End Try

        Return converter.jsonToIngresoDetalle(result)
        Return Nothing
    End Function


    'update Ingreso
    Public Async Function putIngreso(ByVal ingreso As Object()) As Task(Of Boolean)
        Dim url As String = urlBase + "Ingreso"
        Dim ok As Boolean = False

        Try
            Using client As HttpClient = New HttpClient()
                Dim jsonIngreso As String = Nothing
                jsonIngreso = converter.ingresoToJson(ingreso)
                Dim dataContent As New StringContent(jsonIngreso.ToString, Encoding.UTF8, "application/json")
                Dim response As HttpResponseMessage = Await client.PutAsync(url, dataContent)
                ok = True
            End Using
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error a la hora de modificar el ingreso: " + ex.StackTrace.ToString)
        End Try

        Return ok
    End Function

    'update IngresoDetalle
    Public Async Function putIngresoDetalle(ByVal ingresoDetalle As Object()) As Task(Of Boolean)
        Dim url As String = urlBase & "IngresoDetalle"
        Dim ok As Boolean = False

        Try
            Using client As HttpClient = New HttpClient()
                Dim jsonIngresoDetalle As String = Nothing
                jsonIngresoDetalle = converter.ingresoDetalleToJson(ingresoDetalle)
                Dim dataContent As New StringContent(jsonIngresoDetalle.ToString, Encoding.UTF8, "application/json")
                Dim response As HttpResponseMessage = Await client.PutAsync(url, dataContent)
                ok = True
            End Using
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error a la hora de modificar el ingresoDetalle: " + ex.StackTrace.ToString)
        End Try

        Return ok
    End Function


    'create Ingreso
    Public Async Function postIngreso(ByVal ingreso As Object()) As Task(Of Integer)
        Dim val As Integer = 0
        Dim url As String = urlBase & "Ingreso"

        Try
            Using client As HttpClient = New HttpClient()
                Dim jsonIngreso As String = Nothing
                jsonIngreso = converter.ingresoToJson(ingreso)
                Dim dataContent As New StringContent(jsonIngreso.ToString, Encoding.UTF8, "application/json")
                Dim response As HttpResponseMessage = Await client.PostAsync(url, dataContent)
                Dim content As HttpContent = response.Content
                Dim result As String = Await content.ReadAsStringAsync()

                val = result
            End Using
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error a la hora de agregar el ingreso: " + ex.StackTrace.ToString)
        End Try

        Return val
    End Function

    'create IngresoDetalle
    Public Async Function postIngresoDetalle(ByVal ingresoDetalle As Object()) As Task(Of Boolean)
        Dim ok As Boolean = False
        Dim url As String = urlBase & "IngresoDetalle"

        Try
            Using client As HttpClient = New HttpClient()
                Dim jsonIngresoDetalle As String = Nothing
                jsonIngresoDetalle = converter.ingresoDetalleToJson(ingresoDetalle)
                Dim dataContent As New StringContent(jsonIngresoDetalle.ToString, Encoding.UTF8, "application/json")
                Dim response As HttpResponseMessage = Await client.PostAsync(url, dataContent)
                ok = True
            End Using
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error a la hora de agregar el ingresoDetalle: " + ex.StackTrace.ToString)
        End Try

        Return ok
    End Function


    'delete Ingreso
    Public Async Function deleteIngreso(ByVal idIngreso As Long) As Task(Of Boolean)
        Dim url As String = urlBase & "Ingreso/" & idIngreso
        Dim ok As Boolean = False

        Try
            Using client As HttpClient = New HttpClient()
                Dim response As HttpResponseMessage = Await client.DeleteAsync(url)
                ok = True
            End Using
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error a la hora de eliminar el ingreso: " + ex.StackTrace.ToString)
        End Try

        Return ok
    End Function

    'delete IngresoDetalle
    Public Async Function deleteIngresoDetalle(ByVal key As Object()) As Task(Of Boolean)
        Dim url As String = urlBase & "IngresoDetalle/" & key(0) & "/" & key(2) & "/" & key(1) & "/" & key(3)
        Dim ok As Boolean = False

        Console.WriteLine("delte id url: " & url)
        Try
            Using client As HttpClient = New HttpClient()
                Dim response As HttpResponseMessage = Await client.DeleteAsync(url)
                ok = True
            End Using
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error a la hora de eliminar el ingresoDetalle: " + ex.StackTrace.ToString)
        End Try

        Return ok
    End Function


    'getCount Ingreso
    Public Async Function getCountIngresos() As Task(Of Integer)
        Dim url As String = urlBase + "Ingreso/count"
        Dim result As String = Nothing

        Try
            Using client As HttpClient = New HttpClient()
                result = Await client.GetStringAsync(url)
            End Using
        Catch ex As Exception
            Console.Write(ex.Message)
        End Try

        Return CInt(result)

    End Function

    'getCount Paciente
    Public Async Function getCountPacientes() As Task(Of Integer)
        Dim url As String = urlBase + "Paciente/count"
        Dim result As String = Nothing

        Try
            Using client As HttpClient = New HttpClient()
                result = Await client.GetStringAsync(url)
            End Using
        Catch ex As Exception
            Console.Write(ex.Message)
        End Try

        Return CInt(result)

    End Function


    'findRango Ingreso
    Public Async Function getRangoIngresos(ByVal first As Integer, ByVal tamanioPagina As Integer) As Task(Of List(Of Object()))
        Dim url As String = urlBase & "Ingreso/paginador/" & first & "/" & tamanioPagina
        Dim result As String = Nothing

        Try
            Using client As HttpClient = New HttpClient()
                result = Await client.GetStringAsync(url)
            End Using
        Catch ex As Exception
            Console.Write(ex.Message)
        End Try

        Return converter.jsonArrayToIngreso(result)

    End Function

    'findRango Paciente
    Public Async Function getRangoPacientes(ByVal first As Integer, ByVal tamanioPagina As Integer) As Task(Of List(Of Object()))
        Dim url As String = urlBase & "Paciente/paginador/" & first & "/" & tamanioPagina
        Dim result As String = Nothing

        Try
            Using client As HttpClient = New HttpClient()
                result = Await client.GetStringAsync(url)
            End Using
        Catch ex As Exception
            Console.Write(ex.Message)
        End Try

        Return converter.jsonArrayToPaciente(result)

    End Function


    'getCount APCAE
    Public Async Function getCountAPCAE() As Task(Of Integer)
        Dim url As String = urlBase + "APCAE/count"
        Dim result As String = Nothing

        Try
            Using client As HttpClient = New HttpClient()
                result = Await client.GetStringAsync(url)
            End Using
        Catch ex As Exception
            Console.Write(ex.Message)
        End Try

        Return CInt(result)

    End Function

    'findRango APCAE
    Public Async Function getRangoAPCAE(ByVal first As Integer, ByVal tamanioPagina As Integer) As Task(Of List(Of Object()))
        Dim url As String = urlBase & "APCAE/paginador/" & first & "/" & tamanioPagina
        Dim result As String = Nothing

        Try
            Using client As HttpClient = New HttpClient()
                result = Await client.GetStringAsync(url)
            End Using
        Catch ex As Exception
            Console.Write(ex.Message)
        End Try

        Return converter.jsonArrayToAPCAE(result)

    End Function


End Class
