<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmNuevoIngreso
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.tblPaciente = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellidos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaNacimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tblApcae = New System.Windows.Forms.DataGridView()
        Me.idArea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idAreaCentroEspacio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idTurno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellidospersonal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtNombrePaciente = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtIdPaciente = New System.Windows.Forms.TextBox()
        Me.txtPersonal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCentro = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtArea = New System.Windows.Forms.TextBox()
        Me.txtNacimiento = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtObservacionesIngreso = New System.Windows.Forms.RichTextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.cbTipoIngreso = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtpFechaIngreso = New System.Windows.Forms.DateTimePicker()
        Me.dtpHoraIngreso = New System.Windows.Forms.DateTimePicker()
        Me.dtpHoraEgreso = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dtpFechaEgreso = New System.Windows.Forms.DateTimePicker()
        Me.chkEgreso = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtPagina = New System.Windows.Forms.TextBox()
        Me.btnUltimo = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnPrimero = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtPaginaA = New System.Windows.Forms.TextBox()
        Me.btnUltimoA = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnSiguienteA = New System.Windows.Forms.Button()
        Me.btnAnteriorA = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnPrimeroA = New System.Windows.Forms.Button()
        Me.txtObservacionesDetalle = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.tblPaciente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblApcae, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tblPaciente
        '
        Me.tblPaciente.AllowUserToAddRows = False
        Me.tblPaciente.AllowUserToDeleteRows = False
        Me.tblPaciente.AllowUserToResizeColumns = False
        Me.tblPaciente.AllowUserToResizeRows = False
        Me.tblPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblPaciente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.nombres, Me.apellidos, Me.fechaNacimiento})
        Me.tblPaciente.GridColor = System.Drawing.SystemColors.ControlText
        Me.tblPaciente.Location = New System.Drawing.Point(119, 190)
        Me.tblPaciente.MultiSelect = False
        Me.tblPaciente.Name = "tblPaciente"
        Me.tblPaciente.ReadOnly = True
        Me.tblPaciente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tblPaciente.Size = New System.Drawing.Size(602, 142)
        Me.tblPaciente.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID Paciente"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'nombres
        '
        Me.nombres.HeaderText = "Nombres"
        Me.nombres.Name = "nombres"
        Me.nombres.ReadOnly = True
        Me.nombres.Width = 150
        '
        'apellidos
        '
        Me.apellidos.HeaderText = "Apellidos"
        Me.apellidos.Name = "apellidos"
        Me.apellidos.ReadOnly = True
        Me.apellidos.Width = 150
        '
        'fechaNacimiento
        '
        Me.fechaNacimiento.HeaderText = "Fecha Ingreso"
        Me.fechaNacimiento.Name = "fechaNacimiento"
        Me.fechaNacimiento.ReadOnly = True
        '
        'tblApcae
        '
        Me.tblApcae.AllowUserToAddRows = False
        Me.tblApcae.AllowUserToDeleteRows = False
        Me.tblApcae.AllowUserToResizeColumns = False
        Me.tblApcae.AllowUserToResizeRows = False
        Me.tblApcae.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblApcae.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idArea, Me.idAreaCentroEspacio, Me.idTurno, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.apellidospersonal})
        Me.tblApcae.GridColor = System.Drawing.SystemColors.ControlText
        Me.tblApcae.Location = New System.Drawing.Point(117, 93)
        Me.tblApcae.MultiSelect = False
        Me.tblApcae.Name = "tblApcae"
        Me.tblApcae.ReadOnly = True
        Me.tblApcae.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tblApcae.Size = New System.Drawing.Size(602, 154)
        Me.tblApcae.TabIndex = 3
        '
        'idArea
        '
        Me.idArea.HeaderText = "ID APCA"
        Me.idArea.Name = "idArea"
        Me.idArea.ReadOnly = True
        Me.idArea.Visible = False
        '
        'idAreaCentroEspacio
        '
        Me.idAreaCentroEspacio.HeaderText = "ID ACE"
        Me.idAreaCentroEspacio.Name = "idAreaCentroEspacio"
        Me.idAreaCentroEspacio.ReadOnly = True
        Me.idAreaCentroEspacio.Visible = False
        '
        'idTurno
        '
        Me.idTurno.HeaderText = "ID Turno"
        Me.idTurno.Name = "idTurno"
        Me.idTurno.ReadOnly = True
        Me.idTurno.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Area"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Centro"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nombre Personal"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 120
        '
        'apellidospersonal
        '
        Me.apellidospersonal.HeaderText = "Apellidos Personal"
        Me.apellidospersonal.Name = "apellidospersonal"
        Me.apellidospersonal.ReadOnly = True
        Me.apellidospersonal.Width = 120
        '
        'txtNombrePaciente
        '
        Me.txtNombrePaciente.Enabled = False
        Me.txtNombrePaciente.Location = New System.Drawing.Point(832, 216)
        Me.txtNombrePaciente.Name = "txtNombrePaciente"
        Me.txtNombrePaciente.Size = New System.Drawing.Size(206, 20)
        Me.txtNombrePaciente.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(735, 219)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Nombre Completo:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(763, 193)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "ID Paciente:"
        '
        'txtIdPaciente
        '
        Me.txtIdPaciente.Enabled = False
        Me.txtIdPaciente.Location = New System.Drawing.Point(832, 190)
        Me.txtIdPaciente.Name = "txtIdPaciente"
        Me.txtIdPaciente.Size = New System.Drawing.Size(59, 20)
        Me.txtIdPaciente.TabIndex = 14
        '
        'txtPersonal
        '
        Me.txtPersonal.Enabled = False
        Me.txtPersonal.Location = New System.Drawing.Point(830, 145)
        Me.txtPersonal.Name = "txtPersonal"
        Me.txtPersonal.Size = New System.Drawing.Size(208, 20)
        Me.txtPersonal.TabIndex = 29
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(738, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Personal Medico:"
        '
        'txtCentro
        '
        Me.txtCentro.Enabled = False
        Me.txtCentro.Location = New System.Drawing.Point(830, 119)
        Me.txtCentro.Name = "txtCentro"
        Me.txtCentro.Size = New System.Drawing.Size(208, 20)
        Me.txtCentro.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(726, 122)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Centro de Atención:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(795, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Area:"
        '
        'txtArea
        '
        Me.txtArea.Enabled = False
        Me.txtArea.Location = New System.Drawing.Point(830, 93)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Size = New System.Drawing.Size(208, 20)
        Me.txtArea.TabIndex = 24
        '
        'txtNacimiento
        '
        Me.txtNacimiento.Enabled = False
        Me.txtNacimiento.Location = New System.Drawing.Point(832, 242)
        Me.txtNacimiento.Name = "txtNacimiento"
        Me.txtNacimiento.Size = New System.Drawing.Size(206, 20)
        Me.txtNacimiento.TabIndex = 30
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(735, 245)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Fecha Nacimiento:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(35, 128)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 13)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Observaciones:"
        '
        'txtObservacionesIngreso
        '
        Me.txtObservacionesIngreso.Location = New System.Drawing.Point(117, 128)
        Me.txtObservacionesIngreso.Name = "txtObservacionesIngreso"
        Me.txtObservacionesIngreso.Size = New System.Drawing.Size(329, 45)
        Me.txtObservacionesIngreso.TabIndex = 33
        Me.txtObservacionesIngreso.Text = ""
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(777, 219)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(125, 23)
        Me.btnAgregar.TabIndex = 34
        Me.btnAgregar.Text = "Agregar Ingreso"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(908, 219)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(125, 23)
        Me.btnCancelar.TabIndex = 35
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'cbTipoIngreso
        '
        Me.cbTipoIngreso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoIngreso.FormattingEnabled = True
        Me.cbTipoIngreso.Location = New System.Drawing.Point(119, 97)
        Me.cbTipoIngreso.Name = "cbTipoIngreso"
        Me.cbTipoIngreso.Size = New System.Drawing.Size(251, 21)
        Me.cbTipoIngreso.TabIndex = 36
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(29, 100)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 13)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Tipo de Ingreso:"
        '
        'dtpFechaIngreso
        '
        Me.dtpFechaIngreso.CustomFormat = ""
        Me.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaIngreso.Location = New System.Drawing.Point(119, 37)
        Me.dtpFechaIngreso.Name = "dtpFechaIngreso"
        Me.dtpFechaIngreso.Size = New System.Drawing.Size(170, 20)
        Me.dtpFechaIngreso.TabIndex = 38
        '
        'dtpHoraIngreso
        '
        Me.dtpHoraIngreso.CustomFormat = "hh:mm:ss tt"
        Me.dtpHoraIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHoraIngreso.Location = New System.Drawing.Point(119, 63)
        Me.dtpHoraIngreso.Name = "dtpHoraIngreso"
        Me.dtpHoraIngreso.ShowUpDown = True
        Me.dtpHoraIngreso.Size = New System.Drawing.Size(170, 20)
        Me.dtpHoraIngreso.TabIndex = 39
        '
        'dtpHoraEgreso
        '
        Me.dtpHoraEgreso.CustomFormat = "hh:mm:ss tt"
        Me.dtpHoraEgreso.Enabled = False
        Me.dtpHoraEgreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHoraEgreso.Location = New System.Drawing.Point(463, 62)
        Me.dtpHoraEgreso.Name = "dtpHoraEgreso"
        Me.dtpHoraEgreso.ShowUpDown = True
        Me.dtpHoraEgreso.Size = New System.Drawing.Size(170, 20)
        Me.dtpHoraEgreso.TabIndex = 41
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(38, 43)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 13)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "Fecha Ingreso:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(384, 42)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(76, 13)
        Me.Label12.TabIndex = 43
        Me.Label12.Text = "Fecha Egreso:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(45, 69)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 13)
        Me.Label13.TabIndex = 44
        Me.Label13.Text = "Hora Ingreso:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(391, 68)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(69, 13)
        Me.Label14.TabIndex = 45
        Me.Label14.Text = "Hora Egreso:"
        '
        'dtpFechaEgreso
        '
        Me.dtpFechaEgreso.CustomFormat = " "
        Me.dtpFechaEgreso.Enabled = False
        Me.dtpFechaEgreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaEgreso.Location = New System.Drawing.Point(463, 36)
        Me.dtpFechaEgreso.Name = "dtpFechaEgreso"
        Me.dtpFechaEgreso.Size = New System.Drawing.Size(170, 20)
        Me.dtpFechaEgreso.TabIndex = 40
        '
        'chkEgreso
        '
        Me.chkEgreso.AutoSize = True
        Me.chkEgreso.Location = New System.Drawing.Point(387, 17)
        Me.chkEgreso.Name = "chkEgreso"
        Me.chkEgreso.Size = New System.Drawing.Size(59, 17)
        Me.chkEgreso.TabIndex = 47
        Me.chkEgreso.Text = "Egreso"
        Me.chkEgreso.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtPagina)
        Me.GroupBox1.Controls.Add(Me.btnUltimo)
        Me.GroupBox1.Controls.Add(Me.btnSiguiente)
        Me.GroupBox1.Controls.Add(Me.btnAnterior)
        Me.GroupBox1.Controls.Add(Me.btnPrimero)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.chkEgreso)
        Me.GroupBox1.Controls.Add(Me.tblPaciente)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtIdPaciente)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtNombrePaciente)
        Me.GroupBox1.Controls.Add(Me.dtpHoraEgreso)
        Me.GroupBox1.Controls.Add(Me.txtNacimiento)
        Me.GroupBox1.Controls.Add(Me.dtpFechaEgreso)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.dtpHoraIngreso)
        Me.GroupBox1.Controls.Add(Me.txtObservacionesIngreso)
        Me.GroupBox1.Controls.Add(Me.dtpFechaIngreso)
        Me.GroupBox1.Controls.Add(Me.cbTipoIngreso)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1058, 348)
        Me.GroupBox1.TabIndex = 48
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso"
        '
        'txtPagina
        '
        Me.txtPagina.Location = New System.Drawing.Point(583, 150)
        Me.txtPagina.Name = "txtPagina"
        Me.txtPagina.ReadOnly = True
        Me.txtPagina.Size = New System.Drawing.Size(41, 20)
        Me.txtPagina.TabIndex = 53
        Me.txtPagina.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnUltimo
        '
        Me.btnUltimo.Location = New System.Drawing.Point(678, 150)
        Me.btnUltimo.Name = "btnUltimo"
        Me.btnUltimo.Size = New System.Drawing.Size(42, 23)
        Me.btnUltimo.TabIndex = 52
        Me.btnUltimo.Text = ">|"
        Me.btnUltimo.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Location = New System.Drawing.Point(630, 150)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(42, 23)
        Me.btnSiguiente.TabIndex = 51
        Me.btnSiguiente.Text = ">>"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnAnterior
        '
        Me.btnAnterior.Location = New System.Drawing.Point(535, 150)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(42, 23)
        Me.btnAnterior.TabIndex = 50
        Me.btnAnterior.Text = "<<"
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'btnPrimero
        '
        Me.btnPrimero.Location = New System.Drawing.Point(487, 150)
        Me.btnPrimero.Name = "btnPrimero"
        Me.btnPrimero.Size = New System.Drawing.Size(42, 23)
        Me.btnPrimero.TabIndex = 49
        Me.btnPrimero.Text = "|<"
        Me.btnPrimero.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 193)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Paciente:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtPaginaA)
        Me.GroupBox2.Controls.Add(Me.btnUltimoA)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.btnSiguienteA)
        Me.GroupBox2.Controls.Add(Me.btnCancelar)
        Me.GroupBox2.Controls.Add(Me.btnAnteriorA)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.btnPrimeroA)
        Me.GroupBox2.Controls.Add(Me.btnAgregar)
        Me.GroupBox2.Controls.Add(Me.tblApcae)
        Me.GroupBox2.Controls.Add(Me.txtObservacionesDetalle)
        Me.GroupBox2.Controls.Add(Me.txtArea)
        Me.GroupBox2.Controls.Add(Me.txtPersonal)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtCentro)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 390)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1057, 263)
        Me.GroupBox2.TabIndex = 49
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ingreso Detalle"
        '
        'txtPaginaA
        '
        Me.txtPaginaA.Location = New System.Drawing.Point(582, 52)
        Me.txtPaginaA.Name = "txtPaginaA"
        Me.txtPaginaA.ReadOnly = True
        Me.txtPaginaA.Size = New System.Drawing.Size(41, 20)
        Me.txtPaginaA.TabIndex = 55
        Me.txtPaginaA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnUltimoA
        '
        Me.btnUltimoA.Location = New System.Drawing.Point(677, 52)
        Me.btnUltimoA.Name = "btnUltimoA"
        Me.btnUltimoA.Size = New System.Drawing.Size(42, 23)
        Me.btnUltimoA.TabIndex = 54
        Me.btnUltimoA.Text = ">|"
        Me.btnUltimoA.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(30, 30)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(81, 13)
        Me.Label16.TabIndex = 49
        Me.Label16.Text = "Observaciones:"
        '
        'btnSiguienteA
        '
        Me.btnSiguienteA.Location = New System.Drawing.Point(629, 52)
        Me.btnSiguienteA.Name = "btnSiguienteA"
        Me.btnSiguienteA.Size = New System.Drawing.Size(42, 23)
        Me.btnSiguienteA.TabIndex = 53
        Me.btnSiguienteA.Text = ">>"
        Me.btnSiguienteA.UseVisualStyleBackColor = True
        '
        'btnAnteriorA
        '
        Me.btnAnteriorA.Location = New System.Drawing.Point(534, 52)
        Me.btnAnteriorA.Name = "btnAnteriorA"
        Me.btnAnteriorA.Size = New System.Drawing.Size(42, 23)
        Me.btnAnteriorA.TabIndex = 52
        Me.btnAnteriorA.Text = "<<"
        Me.btnAnteriorA.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(51, 93)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(62, 13)
        Me.Label15.TabIndex = 49
        Me.Label15.Text = "Asignación:"
        '
        'btnPrimeroA
        '
        Me.btnPrimeroA.Location = New System.Drawing.Point(486, 52)
        Me.btnPrimeroA.Name = "btnPrimeroA"
        Me.btnPrimeroA.Size = New System.Drawing.Size(42, 23)
        Me.btnPrimeroA.TabIndex = 51
        Me.btnPrimeroA.Text = "|<"
        Me.btnPrimeroA.UseVisualStyleBackColor = True
        '
        'txtObservacionesDetalle
        '
        Me.txtObservacionesDetalle.Location = New System.Drawing.Point(117, 30)
        Me.txtObservacionesDetalle.Name = "txtObservacionesDetalle"
        Me.txtObservacionesDetalle.Size = New System.Drawing.Size(328, 45)
        Me.txtObservacionesDetalle.TabIndex = 50
        Me.txtObservacionesDetalle.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(459, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 18)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "NUEVO INGRESO"
        '
        'FrmNuevoIngreso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1083, 665)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmNuevoIngreso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo Ingreso"
        CType(Me.tblPaciente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblApcae, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tblPaciente As DataGridView
    Friend WithEvents tblApcae As DataGridView
    Friend WithEvents txtNombrePaciente As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtIdPaciente As TextBox
    Friend WithEvents txtPersonal As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCentro As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtArea As TextBox
    Friend WithEvents txtNacimiento As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtObservacionesIngreso As RichTextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents cbTipoIngreso As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents dtpFechaIngreso As DateTimePicker
    Friend WithEvents dtpHoraIngreso As DateTimePicker
    Friend WithEvents dtpHoraEgreso As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents dtpFechaEgreso As DateTimePicker
    Friend WithEvents chkEgreso As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents idArea As DataGridViewTextBoxColumn
    Friend WithEvents idAreaCentroEspacio As DataGridViewTextBoxColumn
    Friend WithEvents idTurno As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents apellidospersonal As DataGridViewTextBoxColumn
    Friend WithEvents Label16 As Label
    Friend WithEvents txtObservacionesDetalle As RichTextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents nombres As DataGridViewTextBoxColumn
    Friend WithEvents apellidos As DataGridViewTextBoxColumn
    Friend WithEvents fechaNacimiento As DataGridViewTextBoxColumn
    Friend WithEvents txtPagina As TextBox
    Friend WithEvents btnUltimo As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnPrimero As Button
    Friend WithEvents txtPaginaA As TextBox
    Friend WithEvents btnUltimoA As Button
    Friend WithEvents btnSiguienteA As Button
    Friend WithEvents btnAnteriorA As Button
    Friend WithEvents btnPrimeroA As Button
End Class
