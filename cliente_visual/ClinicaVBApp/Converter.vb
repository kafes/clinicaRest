Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class Converter

    Dim stringIngreso As String = "{
                                    ""fechaEgreso"":  """",
                                    ""fechaIngreso"": """",
                                    ""horaEgreso"": """",
                                    ""horaIngreso"": """",
                                    ""observaciones"": """",
                                    ""idIngreso"": 1,
                                    ""idPaciente"": {
                                        ""idPaciente"": 1},
                                    ""idTipoIngreso"": {
                                        ""idTipoIngreso"": 1}
                                    }"

    Dim stringDetalle As String = "{
	                                    ""ingresoDetallePK"": {
		                                    ""idAreaCentroEspacio"": 1,
		                                    ""idAsignacionPersonalCentroArea"": 1,
		                                    ""idIngreso"": 1,
		                                    ""idTurno"": 1
	                                    },
	                                    ""ingreso"": {
		                                    ""idIngreso"": 1
	                                    },
	                                    ""asignacionPersonalCentroAreaEspacio"": {
		                                    ""asignacionPersonalCentroArea"": {
			                                    ""idAsignacionPersonalCentroArea"": 1
		                                    },
                                            ""asignacionPersonalCentroAreaEspacioPK"": {
                                                ""idAreaCentroEspacio"": 1,
                                                ""idAsignacionPersonalCentroArea"": 1,
                                                ""idTurno"": 1
                                            }
	                                    },
	                                    ""fechaDetalle"": """",
	                                    ""horaDetalle"": """",
	                                    ""observaciones"": """"
                                    }"

    Dim jsonDetalle As JObject = JObject.Parse(stringDetalle)
    Dim jsonIngreso As JObject = JObject.Parse(stringIngreso)

    'Recibe un Object() con los datos del ingreso y devuelve un String con el json del ingreso
    'idIngreso(0), idTipoIngreso(1), idPaciente(2), fechaIngreso(3), fechaEgreso(4), horaIngreso(5), horaEgreso(6), observaciones(7)
    Public Function ingresoToJson(ByVal data As Object()) As String
        jsonIngreso.Item("idIngreso") = data(0).ToString()
        jsonIngreso.Item("idTipoIngreso").Item("idTipoIngreso") = data(1).ToString()
        jsonIngreso.Item("idPaciente").Item("idPaciente") = data(2).ToString()
        If data(3).ToString = "" Then
            jsonIngreso.Item("fechaIngreso") = ""
        Else
            jsonIngreso.Item("fechaIngreso") = DateTime.Parse(data(3))
        End If
        If data(4).ToString = "" Then
            jsonIngreso.Item("fechaEgreso") = ""
        Else
            jsonIngreso.Item("fechaEgreso") = DateTime.Parse(data(4))
        End If
        If data(5).ToString = "" Then
            jsonIngreso.Item("horaIngreso") = ""
        Else
            jsonIngreso.Item("horaIngreso") = DateTime.Parse(data(5))
        End If
        If data(6).ToString = "" Then
            jsonIngreso.Item("horaEgreso") = ""
        Else
            jsonIngreso.Item("horaEgreso") = DateTime.Parse(data(6))
        End If
        jsonIngreso.Item("observaciones") = data(7).ToString()

        Return (jsonIngreso.ToString())
    End Function


    'Recibe un Object() con los datos del detalleIngreso y devuelve un String con el json del detalleIngreso
    'idIngreso(0), idAreaCentroEspacio(1), idAsignacionPersonalCentroArea(2), idTurno(3), fechaDetalle(4), horaDetalle(5), observaciones(6)
    Public Function ingresoDetalleToJson(ByVal data As Object()) As String
        jsonDetalle.Item("ingreso").Item("idIngreso") = data(0).ToString()

        jsonDetalle.Item("asignacionPersonalCentroAreaEspacio").Item("asignacionPersonalCentroAreaEspacioPK").Item("idAreaCentroEspacio") = data(1).ToString()
        jsonDetalle.Item("asignacionPersonalCentroAreaEspacio").Item("asignacionPersonalCentroAreaEspacioPK").Item("idAsignacionPersonalCentroArea") = data(2).ToString()
        jsonDetalle.Item("asignacionPersonalCentroAreaEspacio").Item("asignacionPersonalCentroAreaEspacioPK").Item("idTurno") = data(3).ToString()

        jsonDetalle.Item("asignacionPersonalCentroAreaEspacio").Item("asignacionPersonalCentroArea").Item("idAsignacionPersonalCentroArea") = data(2).ToString

        jsonDetalle.Item("ingresoDetallePK").Item("idIngreso") = data(0).ToString()
        jsonDetalle.Item("ingresoDetallePK").Item("idAreaCentroEspacio") = data(1).ToString()
        jsonDetalle.Item("ingresoDetallePK").Item("idAsignacionPersonalCentroArea") = data(2).ToString()
        jsonDetalle.Item("ingresoDetallePK").Item("idTurno") = data(3).ToString()

        If data(4).ToString = "" Then
            jsonDetalle.Item("fechaDetalle") = ""
        Else
            jsonDetalle.Item("fechaDetalle") = DateTime.Parse(data(4))
        End If
        If data(5).ToString = "" Then
            jsonDetalle.Item("horaDetalle") = ""
        Else
            jsonDetalle.Item("horaDetalle") = DateTime.Parse(data(5))
        End If
        jsonDetalle.Item("observaciones") = data(6).ToString()

        Console.WriteLine("data: " & jsonDetalle.ToString())
        Return (jsonDetalle.ToString())
    End Function


    'Recibe un String que representa el JSON de un ingreso y devuelve un vector de Ingreso
    'idIngreso(0), { idTipoIngreso(1), tipoIngreso(2) }, { idPaciente(3), nombres(4), apellidos(5), fechaNac(6) }, fechaIngreso(7), fechaEgreso(8), horaIngreso(9), horaEgreso(10), observaciones(11)
    Public Function jsonToIngreso(ByVal data As String) As Object()
        Dim resultado As Object() = Nothing

        Try
            If data IsNot Nothing Then
                Dim ingreso As JObject
                ingreso = JsonConvert.DeserializeObject(data)

                If ingreso IsNot Nothing Then
                    Dim paciente As JObject = ingreso.Item("idPaciente")
                    Dim tipoIngreso As JObject = ingreso.Item("idTipoIngreso")
                    resultado = New Object() {ingreso.Item("idIngreso"),
                                                tipoIngreso.Item("idTipoIngreso"),
                                                tipoIngreso.Item("nombre"),
                                                paciente.Item("idPaciente"),
                                                paciente.Item("nombres"),
                                                paciente.Item("apellidos"),
                                                paciente.Item("fechaNacimiento"),
                                                ingreso.Item("fechaIngreso"),
                                                ingreso.Item("fechaEgreso"),
                                                ingreso.Item("horaIngreso"),
                                                ingreso.Item("horaEgreso"),
                                                ingreso.Item("observaciones")}

                End If
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Return resultado
    End Function


    'Recibe un String que representa el JSON de un ingresoDetalle y devuelve un vector de ingresoDetalle
    'idIngreso(0), idAreaCentroEspacio(1), idAsignacionPersonalCentroArea(2), idTurno(3), area(4), centro(5), nombrePersonal(6), apellidosPersonal(7), fechaDetalle(8), horaDetalle(9), observaciones(10) 
    Public Function jsonToIngresoDetalle(ByVal data As String) As Object()
        Dim resultado As Object() = Nothing

        Try
            If data IsNot Nothing Then
                Dim ingresoDetalle As JObject
                ingresoDetalle = JsonConvert.DeserializeObject(data)

                If ingresoDetalle IsNot Nothing Then
                    Dim ingreso As JObject = ingresoDetalle.Item("ingreso")
                    Dim apcae As JObject = ingresoDetalle.Item("asignacionPersonalCentroAreaEspacio")
                    Dim apca As JObject = apcae.Item("asignacionPersonalCentroArea")
                    Dim area As JObject = apca.Item("idAreaCentro").Item("idArea")
                    Dim centro As JObject = apca.Item("idAreaCentro").Item("idCentro")
                    Dim personal As JObject = apca.Item("idPersonal")
                    Dim observaciones As String = ""
                    If ingresoDetalle.Item("observaciones") IsNot Nothing Then
                        observaciones = ingresoDetalle.Item("observaciones")
                    End If

                    resultado = New Object() {ingreso.Item("idIngreso"),
                                                apcae.Item("asignacionPersonalCentroAreaEspacioPK").Item("idAreaCentroEspacio"),
                                                apcae.Item("asignacionPersonalCentroAreaEspacioPK").Item("idAsignacionPersonalCentroArea"),
                                                apcae.Item("asignacionPersonalCentroAreaEspacioPK").Item("idTurno"),
                                                area.Item("nombre"),
                                                centro.Item("nombreCorto"),
                                                personal.Item("nombres"),
                                                personal.Item("apellidos"),
                                                ingresoDetalle.Item("fechaDetalle"),
                                                ingresoDetalle.Item("horaDetalle"),
                                                observaciones.ToString}

                End If
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Return resultado
    End Function


    'Recibe un jsonString de ingresos y devuelve la lista de ingresos
    Public Function jsonArrayToIngreso(ByVal data As String) As List(Of Object())
        Dim resultado As New List(Of Object())

        Try
            If data IsNot Nothing Then
                Dim array As JArray
                array = JsonConvert.DeserializeObject(data)
                For Each o As JObject In array
                    Dim row As String() = New String() {o.Item("idIngreso"),
                                                        o.Item("idTipoIngreso").Item("nombre"),
                                                        o.Item("idPaciente").Item("nombres"),
                                                        o.Item("idPaciente").Item("apellidos"),
                                                        o.Item("fechaIngreso"),
                                                        o.Item("fechaEgreso")}
                    resultado.Add(row)
                Next
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Return resultado
    End Function


    'Recibe un jsonArrayString de ingresosDetalle y devuelve la lista de ingresosDetalle
    'idIngreso(0), idAreaCentroEspacio(1), idAsignacionPersonalCentroArea(2), idTurno(3), area(4), centro(5), nombrePersonal(6), apellidosPersonal(7), fechaDetalle(8) 
    Public Function jsonArrayToIngresoDetalle(ByVal data As String) As List(Of Object())
        Dim resultado As New List(Of Object())

        Try
            If data IsNot Nothing Then
                Dim array As JArray
                array = JsonConvert.DeserializeObject(data)
                For Each ingresoDetalle As JObject In array
                    Dim ingreso As JObject = ingresoDetalle.Item("ingreso")
                    Dim apcae As JObject = ingresoDetalle.Item("asignacionPersonalCentroAreaEspacio")
                    Dim apca As JObject = apcae.Item("asignacionPersonalCentroArea")
                    Dim area As JObject = apca.Item("idAreaCentro").Item("idArea")
                    Dim centro As JObject = apca.Item("idAreaCentro").Item("idCentro")
                    Dim personal As JObject = apca.Item("idPersonal")

                    Dim row As String() = New String() {ingreso.Item("idIngreso"),
                                                        apcae.Item("asignacionPersonalCentroAreaEspacioPK").Item("idAreaCentroEspacio"),
                                                        apcae.Item("asignacionPersonalCentroAreaEspacioPK").Item("idAsignacionPersonalCentroArea"),
                                                        apcae.Item("asignacionPersonalCentroAreaEspacioPK").Item("idTurno"),
                                                        area.Item("nombre"),
                                                        centro.Item("nombreCorto"),
                                                        personal.Item("nombres"),
                                                        personal.Item("apellidos"),
                                                        ingresoDetalle.Item("fechaDetalle")}
                    resultado.Add(row)
                Next
            End If
        Catch ex As Exception
            MessageBox.Show("Error en jsonArrayToIngresoDetalle: " + ex.StackTrace.ToString)
        End Try

        Return resultado
    End Function


    'Recibe un jsonString de paciente y devuelve la lista de pacientes
    Public Function jsonArrayToPaciente(ByVal data As String) As List(Of Object())
        Dim resultado As New List(Of Object())

        Try
            If data IsNot Nothing Then
                Dim array As JArray
                array = JsonConvert.DeserializeObject(data)
                For Each paciente As JObject In array
                    Dim row As String() = New String() {paciente.Item("idPaciente"),
                                                        paciente.Item("nombres"),
                                                        paciente.Item("apellidos"),
                                                        paciente.Item("fechaNacimiento")}
                    resultado.Add(row)
                Next
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Return resultado
    End Function


    'Recibe un jsonString de tipoIngreso y devuelve la lista de tipoIngresos
    Public Function jsonArrayToTipoIngreso(ByVal data As String) As List(Of Object())
        Dim resultado As New List(Of Object())

        Try
            If data IsNot Nothing Then
                Dim array As JArray
                array = JsonConvert.DeserializeObject(data)
                For Each tipoIngreso As JObject In array
                    Dim row As String() = New String() {tipoIngreso.Item("idTipoIngreso"),
                                                        tipoIngreso.Item("nombre")}
                    resultado.Add(row)
                Next
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Return resultado
    End Function


    'Recibe un jsonString de APCAE y devuelve la lista de APCAEs
    'idAreaCentroEspacio(0), idAsignacionPersonalCentroArea(1), idTurno(2), centro(3), area(4), nombresPersonal(5), apellidosPersonal(6)
    Public Function jsonArrayToAPCAE(ByVal data As String) As List(Of Object())
        Dim resultado As New List(Of Object())

        Try
            If data IsNot Nothing Then
                Dim array As JArray
                array = JsonConvert.DeserializeObject(data)
                For Each apcae As JObject In array
                    Dim apca As JObject = apcae.Item("asignacionPersonalCentroArea")
                    Dim apcaepk As JObject = apcae.Item("asignacionPersonalCentroAreaEspacioPK")
                    Dim centro As JObject = apca.Item("idAreaCentro").Item("idCentro")
                    Dim area As JObject = apca.Item("idAreaCentro").Item("idArea")
                    Dim personal As JObject = apca.Item("idPersonal")

                    Dim row As Object() = New Object() {apcaepk.Item("idAreaCentroEspacio"),
                                                        apcaepk.Item("idAsignacionPersonalCentroArea"),
                                                        apcaepk.Item("idTurno"),
                                                        area.Item("nombre"),
                                                        centro.Item("nombreCorto"),
                                                        personal.Item("nombres"),
                                                        personal.Item("apellidos")}
                    resultado.Add(row)
                Next
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Return resultado
    End Function


End Class
