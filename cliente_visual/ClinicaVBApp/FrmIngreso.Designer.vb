<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmIngreso
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
        Me.tblIngreso = New System.Windows.Forms.DataGridView()
        Me.idIngreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipoIngreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellidos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaIngreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaEgreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtIdIngreso = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFechaIngreso = New System.Windows.Forms.TextBox()
        Me.txtFechaEgreso = New System.Windows.Forms.TextBox()
        Me.txtTipoIngreso = New System.Windows.Forms.TextBox()
        Me.txtIdPaciente = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnNuevoIngreso = New System.Windows.Forms.Button()
        Me.btnEliminarIngreso = New System.Windows.Forms.Button()
        Me.btnModificarIngreso = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tblDetalle = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idAreaCentroEspacio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idAsignacionPersonalCentroArea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idTurno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAgregarDetalle = New System.Windows.Forms.Button()
        Me.btnModificarDetalle = New System.Windows.Forms.Button()
        Me.btnEliminarDetalle = New System.Windows.Forms.Button()
        Me.txtCentro = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtArea = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtIdIngresoDetalle = New System.Windows.Forms.TextBox()
        Me.txtPersonal = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtFechaDetalle = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnPrimero = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnUltimo = New System.Windows.Forms.Button()
        Me.txtPagina = New System.Windows.Forms.TextBox()
        CType(Me.tblIngreso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tblIngreso
        '
        Me.tblIngreso.AllowUserToAddRows = False
        Me.tblIngreso.AllowUserToDeleteRows = False
        Me.tblIngreso.AllowUserToResizeColumns = False
        Me.tblIngreso.AllowUserToResizeRows = False
        Me.tblIngreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblIngreso.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idIngreso, Me.tipoIngreso, Me.apellidos, Me.nombres, Me.fechaIngreso, Me.fechaEgreso})
        Me.tblIngreso.Location = New System.Drawing.Point(12, 68)
        Me.tblIngreso.MultiSelect = False
        Me.tblIngreso.Name = "tblIngreso"
        Me.tblIngreso.ReadOnly = True
        Me.tblIngreso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tblIngreso.Size = New System.Drawing.Size(824, 163)
        Me.tblIngreso.TabIndex = 0
        '
        'idIngreso
        '
        Me.idIngreso.HeaderText = "ID Ingreso"
        Me.idIngreso.Name = "idIngreso"
        Me.idIngreso.ReadOnly = True
        '
        'tipoIngreso
        '
        Me.tipoIngreso.HeaderText = "Tipo Ingreso"
        Me.tipoIngreso.Name = "tipoIngreso"
        Me.tipoIngreso.ReadOnly = True
        Me.tipoIngreso.Width = 150
        '
        'apellidos
        '
        Me.apellidos.HeaderText = "Apellidos Paciente"
        Me.apellidos.Name = "apellidos"
        Me.apellidos.ReadOnly = True
        Me.apellidos.Width = 125
        '
        'nombres
        '
        Me.nombres.HeaderText = "Nombres Paciente"
        Me.nombres.Name = "nombres"
        Me.nombres.ReadOnly = True
        Me.nombres.Width = 125
        '
        'fechaIngreso
        '
        Me.fechaIngreso.HeaderText = "Fecha Ingreso"
        Me.fechaIngreso.Name = "fechaIngreso"
        Me.fechaIngreso.ReadOnly = True
        Me.fechaIngreso.Width = 125
        '
        'fechaEgreso
        '
        Me.fechaEgreso.HeaderText = "Fecha Egreso"
        Me.fechaEgreso.Name = "fechaEgreso"
        Me.fechaEgreso.ReadOnly = True
        Me.fechaEgreso.Width = 125
        '
        'txtIdIngreso
        '
        Me.txtIdIngreso.Location = New System.Drawing.Point(93, 242)
        Me.txtIdIngreso.Name = "txtIdIngreso"
        Me.txtIdIngreso.ReadOnly = True
        Me.txtIdIngreso.Size = New System.Drawing.Size(73, 20)
        Me.txtIdIngreso.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 245)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ID Ingreso:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(335, 245)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Fecha Ingreso:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(337, 271)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Fecha Egreso:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 271)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Tipo Ingreso:"
        '
        'txtFechaIngreso
        '
        Me.txtFechaIngreso.Location = New System.Drawing.Point(419, 242)
        Me.txtFechaIngreso.Name = "txtFechaIngreso"
        Me.txtFechaIngreso.ReadOnly = True
        Me.txtFechaIngreso.Size = New System.Drawing.Size(192, 20)
        Me.txtFechaIngreso.TabIndex = 7
        '
        'txtFechaEgreso
        '
        Me.txtFechaEgreso.Location = New System.Drawing.Point(419, 268)
        Me.txtFechaEgreso.Name = "txtFechaEgreso"
        Me.txtFechaEgreso.ReadOnly = True
        Me.txtFechaEgreso.Size = New System.Drawing.Size(192, 20)
        Me.txtFechaEgreso.TabIndex = 8
        '
        'txtTipoIngreso
        '
        Me.txtTipoIngreso.Location = New System.Drawing.Point(93, 268)
        Me.txtTipoIngreso.Name = "txtTipoIngreso"
        Me.txtTipoIngreso.ReadOnly = True
        Me.txtTipoIngreso.Size = New System.Drawing.Size(204, 20)
        Me.txtTipoIngreso.TabIndex = 9
        '
        'txtIdPaciente
        '
        Me.txtIdPaciente.Location = New System.Drawing.Point(93, 294)
        Me.txtIdPaciente.Name = "txtIdPaciente"
        Me.txtIdPaciente.ReadOnly = True
        Me.txtIdPaciente.Size = New System.Drawing.Size(204, 20)
        Me.txtIdPaciente.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 297)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Paciente:"
        '
        'btnNuevoIngreso
        '
        Me.btnNuevoIngreso.Location = New System.Drawing.Point(674, 235)
        Me.btnNuevoIngreso.Name = "btnNuevoIngreso"
        Me.btnNuevoIngreso.Size = New System.Drawing.Size(162, 23)
        Me.btnNuevoIngreso.TabIndex = 14
        Me.btnNuevoIngreso.Text = "Nuevo Ingreso"
        Me.btnNuevoIngreso.UseVisualStyleBackColor = True
        '
        'btnEliminarIngreso
        '
        Me.btnEliminarIngreso.Location = New System.Drawing.Point(674, 291)
        Me.btnEliminarIngreso.Name = "btnEliminarIngreso"
        Me.btnEliminarIngreso.Size = New System.Drawing.Size(162, 23)
        Me.btnEliminarIngreso.TabIndex = 15
        Me.btnEliminarIngreso.Text = "Eliminar Ingreso"
        Me.btnEliminarIngreso.UseVisualStyleBackColor = True
        '
        'btnModificarIngreso
        '
        Me.btnModificarIngreso.Location = New System.Drawing.Point(674, 264)
        Me.btnModificarIngreso.Name = "btnModificarIngreso"
        Me.btnModificarIngreso.Size = New System.Drawing.Size(162, 23)
        Me.btnModificarIngreso.TabIndex = 16
        Me.btnModificarIngreso.Text = "Editar Ingreso"
        Me.btnModificarIngreso.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(393, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 18)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "INGRESOS"
        '
        'tblDetalle
        '
        Me.tblDetalle.AllowUserToAddRows = False
        Me.tblDetalle.AllowUserToDeleteRows = False
        Me.tblDetalle.AllowUserToResizeColumns = False
        Me.tblDetalle.AllowUserToResizeRows = False
        Me.tblDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.idAreaCentroEspacio, Me.idAsignacionPersonalCentroArea, Me.idTurno, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.tblDetalle.Location = New System.Drawing.Point(12, 364)
        Me.tblDetalle.MultiSelect = False
        Me.tblDetalle.Name = "tblDetalle"
        Me.tblDetalle.ReadOnly = True
        Me.tblDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tblDetalle.Size = New System.Drawing.Size(824, 176)
        Me.tblDetalle.TabIndex = 19
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID Ingreso"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'idAreaCentroEspacio
        '
        Me.idAreaCentroEspacio.HeaderText = "ID ACE"
        Me.idAreaCentroEspacio.Name = "idAreaCentroEspacio"
        Me.idAreaCentroEspacio.ReadOnly = True
        Me.idAreaCentroEspacio.Visible = False
        '
        'idAsignacionPersonalCentroArea
        '
        Me.idAsignacionPersonalCentroArea.HeaderText = "ID APCA"
        Me.idAsignacionPersonalCentroArea.Name = "idAsignacionPersonalCentroArea"
        Me.idAsignacionPersonalCentroArea.ReadOnly = True
        Me.idAsignacionPersonalCentroArea.Visible = False
        '
        'idTurno
        '
        Me.idTurno.HeaderText = "ID Turno"
        Me.idTurno.Name = "idTurno"
        Me.idTurno.ReadOnly = True
        Me.idTurno.Visible = False
        '
        'Column2
        '
        Me.Column2.HeaderText = "Area"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "Centro"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "Nombres Personal"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 130
        '
        'Column5
        '
        Me.Column5.HeaderText = "Apellidos Personal"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 130
        '
        'Column6
        '
        Me.Column6.HeaderText = "Fecha Detalle"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 125
        '
        'btnAgregarDetalle
        '
        Me.btnAgregarDetalle.Location = New System.Drawing.Point(674, 549)
        Me.btnAgregarDetalle.Name = "btnAgregarDetalle"
        Me.btnAgregarDetalle.Size = New System.Drawing.Size(162, 23)
        Me.btnAgregarDetalle.TabIndex = 21
        Me.btnAgregarDetalle.Text = "Agregar Detalle"
        Me.btnAgregarDetalle.UseVisualStyleBackColor = True
        '
        'btnModificarDetalle
        '
        Me.btnModificarDetalle.Location = New System.Drawing.Point(674, 577)
        Me.btnModificarDetalle.Name = "btnModificarDetalle"
        Me.btnModificarDetalle.Size = New System.Drawing.Size(162, 23)
        Me.btnModificarDetalle.TabIndex = 23
        Me.btnModificarDetalle.Text = "Editar Detalle"
        Me.btnModificarDetalle.UseVisualStyleBackColor = True
        '
        'btnEliminarDetalle
        '
        Me.btnEliminarDetalle.Location = New System.Drawing.Point(674, 606)
        Me.btnEliminarDetalle.Name = "btnEliminarDetalle"
        Me.btnEliminarDetalle.Size = New System.Drawing.Size(162, 23)
        Me.btnEliminarDetalle.TabIndex = 22
        Me.btnEliminarDetalle.Text = "Eliminar Detalle"
        Me.btnEliminarDetalle.UseVisualStyleBackColor = True
        '
        'txtCentro
        '
        Me.txtCentro.Location = New System.Drawing.Point(93, 607)
        Me.txtCentro.Name = "txtCentro"
        Me.txtCentro.ReadOnly = True
        Me.txtCentro.Size = New System.Drawing.Size(204, 20)
        Me.txtCentro.TabIndex = 29
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(46, 610)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Centro:"
        '
        'txtArea
        '
        Me.txtArea.Location = New System.Drawing.Point(93, 633)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.ReadOnly = True
        Me.txtArea.Size = New System.Drawing.Size(204, 20)
        Me.txtArea.TabIndex = 27
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(55, 636)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 13)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Area:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(30, 558)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 13)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "ID Ingreso:"
        '
        'txtIdIngresoDetalle
        '
        Me.txtIdIngresoDetalle.Location = New System.Drawing.Point(93, 555)
        Me.txtIdIngresoDetalle.Name = "txtIdIngresoDetalle"
        Me.txtIdIngresoDetalle.ReadOnly = True
        Me.txtIdIngresoDetalle.Size = New System.Drawing.Size(73, 20)
        Me.txtIdIngresoDetalle.TabIndex = 24
        '
        'txtPersonal
        '
        Me.txtPersonal.Location = New System.Drawing.Point(93, 581)
        Me.txtPersonal.Name = "txtPersonal"
        Me.txtPersonal.ReadOnly = True
        Me.txtPersonal.Size = New System.Drawing.Size(204, 20)
        Me.txtPersonal.TabIndex = 31
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(36, 584)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 13)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Personal:"
        '
        'txtFechaDetalle
        '
        Me.txtFechaDetalle.Location = New System.Drawing.Point(417, 553)
        Me.txtFechaDetalle.Name = "txtFechaDetalle"
        Me.txtFechaDetalle.ReadOnly = True
        Me.txtFechaDetalle.Size = New System.Drawing.Size(192, 20)
        Me.txtFechaDetalle.TabIndex = 33
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(335, 558)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(76, 13)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "Fecha Detalle:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(360, 330)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(161, 18)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "INGRESO DETALLE"
        '
        'btnPrimero
        '
        Me.btnPrimero.Location = New System.Drawing.Point(327, 39)
        Me.btnPrimero.Name = "btnPrimero"
        Me.btnPrimero.Size = New System.Drawing.Size(42, 23)
        Me.btnPrimero.TabIndex = 35
        Me.btnPrimero.Text = "|<"
        Me.btnPrimero.UseVisualStyleBackColor = True
        '
        'btnAnterior
        '
        Me.btnAnterior.Location = New System.Drawing.Point(375, 39)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(42, 23)
        Me.btnAnterior.TabIndex = 36
        Me.btnAnterior.Text = "<<"
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Location = New System.Drawing.Point(470, 39)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(42, 23)
        Me.btnSiguiente.TabIndex = 37
        Me.btnSiguiente.Text = ">>"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnUltimo
        '
        Me.btnUltimo.Location = New System.Drawing.Point(518, 39)
        Me.btnUltimo.Name = "btnUltimo"
        Me.btnUltimo.Size = New System.Drawing.Size(42, 23)
        Me.btnUltimo.TabIndex = 38
        Me.btnUltimo.Text = ">|"
        Me.btnUltimo.UseVisualStyleBackColor = True
        '
        'txtPagina
        '
        Me.txtPagina.Location = New System.Drawing.Point(423, 39)
        Me.txtPagina.Name = "txtPagina"
        Me.txtPagina.ReadOnly = True
        Me.txtPagina.Size = New System.Drawing.Size(41, 20)
        Me.txtPagina.TabIndex = 39
        Me.txtPagina.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FrmIngreso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 665)
        Me.Controls.Add(Me.txtPagina)
        Me.Controls.Add(Me.btnUltimo)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.btnAnterior)
        Me.Controls.Add(Me.btnPrimero)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtFechaDetalle)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtPersonal)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtCentro)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtArea)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtIdIngresoDetalle)
        Me.Controls.Add(Me.btnModificarDetalle)
        Me.Controls.Add(Me.btnEliminarDetalle)
        Me.Controls.Add(Me.btnAgregarDetalle)
        Me.Controls.Add(Me.tblDetalle)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnModificarIngreso)
        Me.Controls.Add(Me.btnEliminarIngreso)
        Me.Controls.Add(Me.btnNuevoIngreso)
        Me.Controls.Add(Me.txtIdPaciente)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTipoIngreso)
        Me.Controls.Add(Me.txtFechaEgreso)
        Me.Controls.Add(Me.txtFechaIngreso)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtIdIngreso)
        Me.Controls.Add(Me.tblIngreso)
        Me.Name = "FrmIngreso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso"
        CType(Me.tblIngreso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tblIngreso As DataGridView
    Friend WithEvents txtIdIngreso As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtFechaIngreso As TextBox
    Friend WithEvents txtFechaEgreso As TextBox
    Friend WithEvents txtTipoIngreso As TextBox
    Friend WithEvents txtIdPaciente As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnNuevoIngreso As Button
    Friend WithEvents btnEliminarIngreso As Button
    Friend WithEvents btnModificarIngreso As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents tblDetalle As DataGridView
    Friend WithEvents btnAgregarDetalle As Button
    Friend WithEvents btnModificarDetalle As Button
    Friend WithEvents btnEliminarDetalle As Button
    Friend WithEvents txtCentro As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtArea As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtIdIngresoDetalle As TextBox
    Friend WithEvents txtPersonal As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtFechaDetalle As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnPrimero As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnUltimo As Button
    Friend WithEvents txtPagina As TextBox
    Friend WithEvents idIngreso As DataGridViewTextBoxColumn
    Friend WithEvents tipoIngreso As DataGridViewTextBoxColumn
    Friend WithEvents apellidos As DataGridViewTextBoxColumn
    Friend WithEvents nombres As DataGridViewTextBoxColumn
    Friend WithEvents fechaIngreso As DataGridViewTextBoxColumn
    Friend WithEvents fechaEgreso As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents idAreaCentroEspacio As DataGridViewTextBoxColumn
    Friend WithEvents idAsignacionPersonalCentroArea As DataGridViewTextBoxColumn
    Friend WithEvents idTurno As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
End Class
