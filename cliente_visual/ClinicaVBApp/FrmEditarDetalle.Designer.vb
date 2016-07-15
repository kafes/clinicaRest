<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEditarDetalle
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtpHoraDetalle = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaDetalle = New System.Windows.Forms.DateTimePicker()
        Me.txtObservacionesDetalle = New System.Windows.Forms.RichTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardarCambios = New System.Windows.Forms.Button()
        Me.txtPersonal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCentro = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtArea = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(211, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(225, 18)
        Me.Label1.TabIndex = 96
        Me.Label1.Text = "EDITAR DETALLE INGRESO"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(284, 57)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 13)
        Me.Label13.TabIndex = 95
        Me.Label13.Text = "Hora Detalle:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(36, 57)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 13)
        Me.Label11.TabIndex = 94
        Me.Label11.Text = "Fecha Detalle:"
        '
        'dtpHoraDetalle
        '
        Me.dtpHoraDetalle.CustomFormat = "hh:mm:ss tt"
        Me.dtpHoraDetalle.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHoraDetalle.Location = New System.Drawing.Point(359, 57)
        Me.dtpHoraDetalle.Name = "dtpHoraDetalle"
        Me.dtpHoraDetalle.ShowUpDown = True
        Me.dtpHoraDetalle.Size = New System.Drawing.Size(135, 20)
        Me.dtpHoraDetalle.TabIndex = 93
        '
        'dtpFechaDetalle
        '
        Me.dtpFechaDetalle.CustomFormat = ""
        Me.dtpFechaDetalle.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaDetalle.Location = New System.Drawing.Point(118, 57)
        Me.dtpFechaDetalle.Name = "dtpFechaDetalle"
        Me.dtpFechaDetalle.Size = New System.Drawing.Size(135, 20)
        Me.dtpFechaDetalle.TabIndex = 92
        '
        'txtObservacionesDetalle
        '
        Me.txtObservacionesDetalle.Location = New System.Drawing.Point(118, 92)
        Me.txtObservacionesDetalle.Name = "txtObservacionesDetalle"
        Me.txtObservacionesDetalle.Size = New System.Drawing.Size(466, 45)
        Me.txtObservacionesDetalle.TabIndex = 91
        Me.txtObservacionesDetalle.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(31, 95)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 13)
        Me.Label9.TabIndex = 90
        Me.Label9.Text = "Observaciones:"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(377, 210)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(125, 23)
        Me.btnCancelar.TabIndex = 89
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardarCambios
        '
        Me.btnGuardarCambios.Location = New System.Drawing.Point(508, 210)
        Me.btnGuardarCambios.Name = "btnGuardarCambios"
        Me.btnGuardarCambios.Size = New System.Drawing.Size(125, 23)
        Me.btnGuardarCambios.TabIndex = 88
        Me.btnGuardarCambios.Text = "Guardar Cambios"
        Me.btnGuardarCambios.UseVisualStyleBackColor = True
        '
        'txtPersonal
        '
        Me.txtPersonal.Enabled = False
        Me.txtPersonal.Location = New System.Drawing.Point(118, 217)
        Me.txtPersonal.Name = "txtPersonal"
        Me.txtPersonal.ReadOnly = True
        Me.txtPersonal.Size = New System.Drawing.Size(203, 20)
        Me.txtPersonal.TabIndex = 87
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 220)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 86
        Me.Label3.Text = "Personal Médico:"
        '
        'txtCentro
        '
        Me.txtCentro.Enabled = False
        Me.txtCentro.Location = New System.Drawing.Point(118, 191)
        Me.txtCentro.Name = "txtCentro"
        Me.txtCentro.ReadOnly = True
        Me.txtCentro.Size = New System.Drawing.Size(203, 20)
        Me.txtCentro.TabIndex = 85
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 194)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 13)
        Me.Label6.TabIndex = 84
        Me.Label6.Text = "Centro de Atención:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(83, 168)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 83
        Me.Label7.Text = "Area:"
        '
        'txtArea
        '
        Me.txtArea.Enabled = False
        Me.txtArea.Location = New System.Drawing.Point(118, 165)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.ReadOnly = True
        Me.txtArea.Size = New System.Drawing.Size(203, 20)
        Me.txtArea.TabIndex = 82
        '
        'FrmEditarDetalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(656, 247)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.dtpHoraDetalle)
        Me.Controls.Add(Me.dtpFechaDetalle)
        Me.Controls.Add(Me.txtObservacionesDetalle)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardarCambios)
        Me.Controls.Add(Me.txtPersonal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCentro)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtArea)
        Me.Name = "FrmEditarDetalle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar Ingreso Detalle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents dtpHoraDetalle As DateTimePicker
    Friend WithEvents dtpFechaDetalle As DateTimePicker
    Friend WithEvents txtObservacionesDetalle As RichTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnGuardarCambios As Button
    Friend WithEvents txtPersonal As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCentro As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtArea As TextBox
End Class
