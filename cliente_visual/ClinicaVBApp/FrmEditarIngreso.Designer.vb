<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEditarIngreso
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.chkEgreso = New System.Windows.Forms.CheckBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtpHoraEgreso = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaEgreso = New System.Windows.Forms.DateTimePicker()
        Me.dtpHoraIngreso = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaIngreso = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbTipoIngreso = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNacimiento = New System.Windows.Forms.TextBox()
        Me.txtNombrePaciente = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtIdPaciente = New System.Windows.Forms.TextBox()
        Me.tblPaciente = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellidos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaNacimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardarCambios = New System.Windows.Forms.Button()
        Me.rtbObservaciones = New System.Windows.Forms.RichTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtPagina = New System.Windows.Forms.TextBox()
        Me.btnUltimo = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnPrimero = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.tblPaciente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkEgreso
        '
        Me.chkEgreso.AutoSize = True
        Me.chkEgreso.Location = New System.Drawing.Point(369, 16)
        Me.chkEgreso.Name = "chkEgreso"
        Me.chkEgreso.Size = New System.Drawing.Size(59, 17)
        Me.chkEgreso.TabIndex = 67
        Me.chkEgreso.Text = "Egreso"
        Me.chkEgreso.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(297, 71)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(69, 13)
        Me.Label14.TabIndex = 65
        Me.Label14.Text = "Hora Egreso:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(31, 71)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 13)
        Me.Label13.TabIndex = 64
        Me.Label13.Text = "Hora Ingreso:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(290, 45)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(76, 13)
        Me.Label12.TabIndex = 63
        Me.Label12.Text = "Fecha Egreso:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(24, 45)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 13)
        Me.Label11.TabIndex = 62
        Me.Label11.Text = "Fecha Ingreso:"
        '
        'dtpHoraEgreso
        '
        Me.dtpHoraEgreso.CustomFormat = "hh:mm:ss tt"
        Me.dtpHoraEgreso.Enabled = False
        Me.dtpHoraEgreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHoraEgreso.Location = New System.Drawing.Point(369, 65)
        Me.dtpHoraEgreso.Name = "dtpHoraEgreso"
        Me.dtpHoraEgreso.ShowUpDown = True
        Me.dtpHoraEgreso.Size = New System.Drawing.Size(148, 20)
        Me.dtpHoraEgreso.TabIndex = 61
        '
        'dtpFechaEgreso
        '
        Me.dtpFechaEgreso.CustomFormat = " "
        Me.dtpFechaEgreso.Enabled = False
        Me.dtpFechaEgreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaEgreso.Location = New System.Drawing.Point(369, 39)
        Me.dtpFechaEgreso.Name = "dtpFechaEgreso"
        Me.dtpFechaEgreso.Size = New System.Drawing.Size(148, 20)
        Me.dtpFechaEgreso.TabIndex = 60
        '
        'dtpHoraIngreso
        '
        Me.dtpHoraIngreso.CustomFormat = "hh:mm:ss tt"
        Me.dtpHoraIngreso.Enabled = False
        Me.dtpHoraIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHoraIngreso.Location = New System.Drawing.Point(105, 65)
        Me.dtpHoraIngreso.Name = "dtpHoraIngreso"
        Me.dtpHoraIngreso.ShowUpDown = True
        Me.dtpHoraIngreso.Size = New System.Drawing.Size(135, 20)
        Me.dtpHoraIngreso.TabIndex = 59
        '
        'dtpFechaIngreso
        '
        Me.dtpFechaIngreso.CustomFormat = "dd/MM/yyyy"
        Me.dtpFechaIngreso.Enabled = False
        Me.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaIngreso.Location = New System.Drawing.Point(105, 39)
        Me.dtpFechaIngreso.Name = "dtpFechaIngreso"
        Me.dtpFechaIngreso.Size = New System.Drawing.Size(135, 20)
        Me.dtpFechaIngreso.TabIndex = 58
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(18, 109)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 13)
        Me.Label10.TabIndex = 57
        Me.Label10.Text = "Tipo de Ingreso:"
        '
        'cbTipoIngreso
        '
        Me.cbTipoIngreso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoIngreso.FormattingEnabled = True
        Me.cbTipoIngreso.Location = New System.Drawing.Point(108, 106)
        Me.cbTipoIngreso.Name = "cbTipoIngreso"
        Me.cbTipoIngreso.Size = New System.Drawing.Size(196, 21)
        Me.cbTipoIngreso.TabIndex = 56
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(654, 289)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 13)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "Fecha Nacimiento:"
        '
        'txtNacimiento
        '
        Me.txtNacimiento.Enabled = False
        Me.txtNacimiento.Location = New System.Drawing.Point(751, 286)
        Me.txtNacimiento.Name = "txtNacimiento"
        Me.txtNacimiento.Size = New System.Drawing.Size(194, 20)
        Me.txtNacimiento.TabIndex = 54
        '
        'txtNombrePaciente
        '
        Me.txtNombrePaciente.Enabled = False
        Me.txtNombrePaciente.Location = New System.Drawing.Point(751, 260)
        Me.txtNombrePaciente.Name = "txtNombrePaciente"
        Me.txtNombrePaciente.Size = New System.Drawing.Size(194, 20)
        Me.txtNombrePaciente.TabIndex = 53
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(654, 263)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 13)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Nombre Completo:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(682, 237)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "ID Paciente:"
        '
        'txtIdPaciente
        '
        Me.txtIdPaciente.Enabled = False
        Me.txtIdPaciente.Location = New System.Drawing.Point(751, 234)
        Me.txtIdPaciente.Name = "txtIdPaciente"
        Me.txtIdPaciente.Size = New System.Drawing.Size(60, 20)
        Me.txtIdPaciente.TabIndex = 50
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
        Me.tblPaciente.Location = New System.Drawing.Point(105, 230)
        Me.tblPaciente.MultiSelect = False
        Me.tblPaciente.Name = "tblPaciente"
        Me.tblPaciente.ReadOnly = True
        Me.tblPaciente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tblPaciente.Size = New System.Drawing.Size(534, 138)
        Me.tblPaciente.TabIndex = 48
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
        Me.nombres.Width = 135
        '
        'apellidos
        '
        Me.apellidos.HeaderText = "Apellidos"
        Me.apellidos.Name = "apellidos"
        Me.apellidos.ReadOnly = True
        Me.apellidos.Width = 135
        '
        'fechaNacimiento
        '
        Me.fechaNacimiento.HeaderText = "Fecha Ingreso"
        Me.fechaNacimiento.Name = "fechaNacimiento"
        Me.fechaNacimiento.ReadOnly = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(808, 345)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(125, 23)
        Me.btnCancelar.TabIndex = 69
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardarCambios
        '
        Me.btnGuardarCambios.Location = New System.Drawing.Point(677, 345)
        Me.btnGuardarCambios.Name = "btnGuardarCambios"
        Me.btnGuardarCambios.Size = New System.Drawing.Size(125, 23)
        Me.btnGuardarCambios.TabIndex = 68
        Me.btnGuardarCambios.Text = "Guardar Cambios"
        Me.btnGuardarCambios.UseVisualStyleBackColor = True
        '
        'rtbObservaciones
        '
        Me.rtbObservaciones.Location = New System.Drawing.Point(105, 139)
        Me.rtbObservaciones.Name = "rtbObservaciones"
        Me.rtbObservaciones.Size = New System.Drawing.Size(466, 45)
        Me.rtbObservaciones.TabIndex = 71
        Me.rtbObservaciones.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(21, 139)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 13)
        Me.Label9.TabIndex = 70
        Me.Label9.Text = "Observaciones:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtPagina)
        Me.GroupBox1.Controls.Add(Me.btnUltimo)
        Me.GroupBox1.Controls.Add(Me.btnSiguiente)
        Me.GroupBox1.Controls.Add(Me.btnAnterior)
        Me.GroupBox1.Controls.Add(Me.btnPrimero)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.chkEgreso)
        Me.GroupBox1.Controls.Add(Me.rtbObservaciones)
        Me.GroupBox1.Controls.Add(Me.tblPaciente)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtIdPaciente)
        Me.GroupBox1.Controls.Add(Me.btnCancelar)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.btnGuardarCambios)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtNombrePaciente)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtNacimiento)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.cbTipoIngreso)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.dtpHoraEgreso)
        Me.GroupBox1.Controls.Add(Me.dtpFechaIngreso)
        Me.GroupBox1.Controls.Add(Me.dtpFechaEgreso)
        Me.GroupBox1.Controls.Add(Me.dtpHoraIngreso)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(955, 381)
        Me.GroupBox1.TabIndex = 72
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso"
        '
        'txtPagina
        '
        Me.txtPagina.Location = New System.Drawing.Point(369, 204)
        Me.txtPagina.Name = "txtPagina"
        Me.txtPagina.ReadOnly = True
        Me.txtPagina.Size = New System.Drawing.Size(41, 20)
        Me.txtPagina.TabIndex = 77
        Me.txtPagina.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnUltimo
        '
        Me.btnUltimo.Location = New System.Drawing.Point(464, 204)
        Me.btnUltimo.Name = "btnUltimo"
        Me.btnUltimo.Size = New System.Drawing.Size(42, 23)
        Me.btnUltimo.TabIndex = 76
        Me.btnUltimo.Text = ">|"
        Me.btnUltimo.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Location = New System.Drawing.Point(416, 204)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(42, 23)
        Me.btnSiguiente.TabIndex = 75
        Me.btnSiguiente.Text = ">>"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnAnterior
        '
        Me.btnAnterior.Location = New System.Drawing.Point(321, 204)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(42, 23)
        Me.btnAnterior.TabIndex = 74
        Me.btnAnterior.Text = "<<"
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'btnPrimero
        '
        Me.btnPrimero.Location = New System.Drawing.Point(273, 204)
        Me.btnPrimero.Name = "btnPrimero"
        Me.btnPrimero.Size = New System.Drawing.Size(42, 23)
        Me.btnPrimero.TabIndex = 73
        Me.btnPrimero.Text = "|<"
        Me.btnPrimero.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 234)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Paciente:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(449, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(148, 18)
        Me.Label7.TabIndex = 73
        Me.Label7.Text = "EDITAR INGRESO"
        '
        'FrmEditarIngreso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(979, 427)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmEditarIngreso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar Ingreso"
        CType(Me.tblPaciente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkEgreso As CheckBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents dtpHoraEgreso As DateTimePicker
    Friend WithEvents dtpFechaEgreso As DateTimePicker
    Friend WithEvents dtpHoraIngreso As DateTimePicker
    Friend WithEvents dtpFechaIngreso As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents cbTipoIngreso As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNacimiento As TextBox
    Friend WithEvents txtNombrePaciente As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtIdPaciente As TextBox
    Friend WithEvents tblPaciente As DataGridView
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnGuardarCambios As Button
    Friend WithEvents rtbObservaciones As RichTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents nombres As DataGridViewTextBoxColumn
    Friend WithEvents apellidos As DataGridViewTextBoxColumn
    Friend WithEvents fechaNacimiento As DataGridViewTextBoxColumn
    Friend WithEvents txtPagina As TextBox
    Friend WithEvents btnUltimo As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnPrimero As Button
End Class
