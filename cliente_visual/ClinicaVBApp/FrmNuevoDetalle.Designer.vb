<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNuevoDetalle
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
        Me.txtPersonal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCentro = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtArea = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAgregarDetalle = New System.Windows.Forms.Button()
        Me.txtObservacionesDetalle = New System.Windows.Forms.RichTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtpHoraDetalle = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaDetalle = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tblApcae = New System.Windows.Forms.DataGridView()
        Me.idArea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idAreaCentroEspacio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idTurno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellidospersonal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtPagina = New System.Windows.Forms.TextBox()
        Me.btnUltimo = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnPrimero = New System.Windows.Forms.Button()
        CType(Me.tblApcae, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPersonal
        '
        Me.txtPersonal.Enabled = False
        Me.txtPersonal.Location = New System.Drawing.Point(826, 241)
        Me.txtPersonal.Name = "txtPersonal"
        Me.txtPersonal.Size = New System.Drawing.Size(191, 20)
        Me.txtPersonal.TabIndex = 37
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(734, 244)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Personal Médico:"
        '
        'txtCentro
        '
        Me.txtCentro.Enabled = False
        Me.txtCentro.Location = New System.Drawing.Point(826, 215)
        Me.txtCentro.Name = "txtCentro"
        Me.txtCentro.Size = New System.Drawing.Size(191, 20)
        Me.txtCentro.TabIndex = 35
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(722, 218)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 13)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Centro de Atención:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(791, 192)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Area:"
        '
        'txtArea
        '
        Me.txtArea.Enabled = False
        Me.txtArea.Location = New System.Drawing.Point(826, 189)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Size = New System.Drawing.Size(191, 20)
        Me.txtArea.TabIndex = 32
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(889, 313)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(125, 23)
        Me.btnCancelar.TabIndex = 39
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAgregarDetalle
        '
        Me.btnAgregarDetalle.Location = New System.Drawing.Point(758, 313)
        Me.btnAgregarDetalle.Name = "btnAgregarDetalle"
        Me.btnAgregarDetalle.Size = New System.Drawing.Size(125, 23)
        Me.btnAgregarDetalle.TabIndex = 38
        Me.btnAgregarDetalle.Text = "Agregar  Detalle"
        Me.btnAgregarDetalle.UseVisualStyleBackColor = True
        '
        'txtObservacionesDetalle
        '
        Me.txtObservacionesDetalle.Location = New System.Drawing.Point(95, 98)
        Me.txtObservacionesDetalle.Name = "txtObservacionesDetalle"
        Me.txtObservacionesDetalle.Size = New System.Drawing.Size(466, 45)
        Me.txtObservacionesDetalle.TabIndex = 75
        Me.txtObservacionesDetalle.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 98)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 13)
        Me.Label9.TabIndex = 74
        Me.Label9.Text = "Observaciones:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(261, 63)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 13)
        Me.Label13.TabIndex = 79
        Me.Label13.Text = "Hora Detalle:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 63)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 13)
        Me.Label11.TabIndex = 78
        Me.Label11.Text = "Fecha Detalle:"
        '
        'dtpHoraDetalle
        '
        Me.dtpHoraDetalle.CustomFormat = "hh:mm:ss tt"
        Me.dtpHoraDetalle.Enabled = False
        Me.dtpHoraDetalle.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHoraDetalle.Location = New System.Drawing.Point(336, 63)
        Me.dtpHoraDetalle.Name = "dtpHoraDetalle"
        Me.dtpHoraDetalle.ShowUpDown = True
        Me.dtpHoraDetalle.Size = New System.Drawing.Size(135, 20)
        Me.dtpHoraDetalle.TabIndex = 77
        '
        'dtpFechaDetalle
        '
        Me.dtpFechaDetalle.CustomFormat = ""
        Me.dtpFechaDetalle.Enabled = False
        Me.dtpFechaDetalle.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaDetalle.Location = New System.Drawing.Point(95, 63)
        Me.dtpFechaDetalle.Name = "dtpFechaDetalle"
        Me.dtpFechaDetalle.Size = New System.Drawing.Size(135, 20)
        Me.dtpFechaDetalle.TabIndex = 76
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(407, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 18)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "NUEVO DETALLE INGRESO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 189)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 81
        Me.Label2.Text = "Asignación:"
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
        Me.tblApcae.Location = New System.Drawing.Point(95, 186)
        Me.tblApcae.MultiSelect = False
        Me.tblApcae.Name = "tblApcae"
        Me.tblApcae.ReadOnly = True
        Me.tblApcae.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tblApcae.Size = New System.Drawing.Size(609, 154)
        Me.tblApcae.TabIndex = 82
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
        'txtPagina
        '
        Me.txtPagina.Location = New System.Drawing.Point(377, 158)
        Me.txtPagina.Name = "txtPagina"
        Me.txtPagina.ReadOnly = True
        Me.txtPagina.Size = New System.Drawing.Size(41, 20)
        Me.txtPagina.TabIndex = 87
        Me.txtPagina.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnUltimo
        '
        Me.btnUltimo.Location = New System.Drawing.Point(472, 158)
        Me.btnUltimo.Name = "btnUltimo"
        Me.btnUltimo.Size = New System.Drawing.Size(42, 23)
        Me.btnUltimo.TabIndex = 86
        Me.btnUltimo.Text = ">|"
        Me.btnUltimo.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Location = New System.Drawing.Point(424, 158)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(42, 23)
        Me.btnSiguiente.TabIndex = 85
        Me.btnSiguiente.Text = ">>"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnAnterior
        '
        Me.btnAnterior.Location = New System.Drawing.Point(329, 158)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(42, 23)
        Me.btnAnterior.TabIndex = 84
        Me.btnAnterior.Text = "<<"
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'btnPrimero
        '
        Me.btnPrimero.Location = New System.Drawing.Point(281, 158)
        Me.btnPrimero.Name = "btnPrimero"
        Me.btnPrimero.Size = New System.Drawing.Size(42, 23)
        Me.btnPrimero.TabIndex = 83
        Me.btnPrimero.Text = "|<"
        Me.btnPrimero.UseVisualStyleBackColor = True
        '
        'FrmNuevoDetalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1029, 363)
        Me.Controls.Add(Me.txtPagina)
        Me.Controls.Add(Me.btnUltimo)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.btnAnterior)
        Me.Controls.Add(Me.btnPrimero)
        Me.Controls.Add(Me.tblApcae)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.dtpHoraDetalle)
        Me.Controls.Add(Me.dtpFechaDetalle)
        Me.Controls.Add(Me.txtObservacionesDetalle)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAgregarDetalle)
        Me.Controls.Add(Me.txtPersonal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCentro)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtArea)
        Me.Name = "FrmNuevoDetalle"
        Me.Text = " "
        CType(Me.tblApcae, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPersonal As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCentro As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtArea As TextBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAgregarDetalle As Button
    Friend WithEvents txtObservacionesDetalle As RichTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents dtpHoraDetalle As DateTimePicker
    Friend WithEvents dtpFechaDetalle As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tblApcae As DataGridView
    Friend WithEvents idArea As DataGridViewTextBoxColumn
    Friend WithEvents idAreaCentroEspacio As DataGridViewTextBoxColumn
    Friend WithEvents idTurno As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents apellidospersonal As DataGridViewTextBoxColumn
    Friend WithEvents txtPagina As TextBox
    Friend WithEvents btnUltimo As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnPrimero As Button
End Class
