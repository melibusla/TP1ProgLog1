<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optImportado = New System.Windows.Forms.RadioButton()
        Me.optNacional = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.optRIParcial = New System.Windows.Forms.RadioButton()
        Me.optRITotal = New System.Windows.Forms.RadioButton()
        Me.optResCivil = New System.Windows.Forms.RadioButton()
        Me.gBServicios = New System.Windows.Forms.GroupBox()
        Me.chkProvVSust = New System.Windows.Forms.CheckBox()
        Me.chkCelular = New System.Windows.Forms.CheckBox()
        Me.chkAsistMed = New System.Windows.Forms.CheckBox()
        Me.chkAuxMec = New System.Windows.Forms.CheckBox()
        Me.lblLogo = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.btnNueva = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.numCuotas = New System.Windows.Forms.NumericUpDown()
        Me.lblControl = New System.Windows.Forms.Label()
        Me.lblCuota = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gBServicios.SuspendLayout()
        CType(Me.numCuotas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(32, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(355, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Compañia de Seguros"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(38, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(38, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Dirección"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(123, 92)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(192, 20)
        Me.txtNombre.TabIndex = 3
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(123, 141)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(192, 20)
        Me.txtDireccion.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optImportado)
        Me.GroupBox1.Controls.Add(Me.optNacional)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Location = New System.Drawing.Point(321, 78)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(150, 96)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de Vehículo"
        '
        'optImportado
        '
        Me.optImportado.AutoSize = True
        Me.optImportado.Location = New System.Drawing.Point(22, 61)
        Me.optImportado.Name = "optImportado"
        Me.optImportado.Size = New System.Drawing.Size(87, 20)
        Me.optImportado.TabIndex = 1
        Me.optImportado.TabStop = True
        Me.optImportado.Text = "Importado"
        Me.optImportado.UseVisualStyleBackColor = True
        '
        'optNacional
        '
        Me.optNacional.AutoSize = True
        Me.optNacional.Location = New System.Drawing.Point(22, 30)
        Me.optNacional.Name = "optNacional"
        Me.optNacional.Size = New System.Drawing.Size(80, 20)
        Me.optNacional.TabIndex = 0
        Me.optNacional.TabStop = True
        Me.optNacional.Text = "Nacional"
        Me.optNacional.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.optRIParcial)
        Me.GroupBox2.Controls.Add(Me.optRITotal)
        Me.GroupBox2.Controls.Add(Me.optResCivil)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Location = New System.Drawing.Point(38, 193)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 121)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo de Seguro"
        '
        'optRIParcial
        '
        Me.optRIParcial.AutoSize = True
        Me.optRIParcial.Location = New System.Drawing.Point(8, 76)
        Me.optRIParcial.Name = "optRIParcial"
        Me.optRIParcial.Size = New System.Drawing.Size(170, 20)
        Me.optRIParcial.TabIndex = 2
        Me.optRIParcial.TabStop = True
        Me.optRIParcial.Text = "Robo e Incendio Parcial"
        Me.optRIParcial.UseVisualStyleBackColor = True
        '
        'optRITotal
        '
        Me.optRITotal.AutoSize = True
        Me.optRITotal.Location = New System.Drawing.Point(8, 49)
        Me.optRITotal.Name = "optRITotal"
        Me.optRITotal.Size = New System.Drawing.Size(159, 20)
        Me.optRITotal.TabIndex = 1
        Me.optRITotal.TabStop = True
        Me.optRITotal.Text = "Robo e Incendio Total"
        Me.optRITotal.UseVisualStyleBackColor = True
        '
        'optResCivil
        '
        Me.optResCivil.AutoSize = True
        Me.optResCivil.Location = New System.Drawing.Point(7, 22)
        Me.optResCivil.Name = "optResCivil"
        Me.optResCivil.Size = New System.Drawing.Size(158, 20)
        Me.optResCivil.TabIndex = 0
        Me.optResCivil.TabStop = True
        Me.optResCivil.Text = "Responsabilidad Civil"
        Me.optResCivil.UseVisualStyleBackColor = True
        '
        'gBServicios
        '
        Me.gBServicios.Controls.Add(Me.chkProvVSust)
        Me.gBServicios.Controls.Add(Me.chkCelular)
        Me.gBServicios.Controls.Add(Me.chkAsistMed)
        Me.gBServicios.Controls.Add(Me.chkAuxMec)
        Me.gBServicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gBServicios.ForeColor = System.Drawing.SystemColors.Control
        Me.gBServicios.Location = New System.Drawing.Point(244, 193)
        Me.gBServicios.Name = "gBServicios"
        Me.gBServicios.Size = New System.Drawing.Size(227, 121)
        Me.gBServicios.TabIndex = 7
        Me.gBServicios.TabStop = False
        Me.gBServicios.Text = "Servicios Adicionales"
        '
        'chkProvVSust
        '
        Me.chkProvVSust.AutoSize = True
        Me.chkProvVSust.Location = New System.Drawing.Point(7, 70)
        Me.chkProvVSust.Name = "chkProvVSust"
        Me.chkProvVSust.Size = New System.Drawing.Size(210, 20)
        Me.chkProvVSust.TabIndex = 2
        Me.chkProvVSust.Text = "Provisión de Vehículo Sustituto"
        Me.chkProvVSust.UseVisualStyleBackColor = True
        '
        'chkCelular
        '
        Me.chkCelular.AutoSize = True
        Me.chkCelular.Location = New System.Drawing.Point(7, 94)
        Me.chkCelular.Name = "chkCelular"
        Me.chkCelular.Size = New System.Drawing.Size(126, 20)
        Me.chkCelular.TabIndex = 8
        Me.chkCelular.Text = "Teléfono Celular"
        Me.chkCelular.UseVisualStyleBackColor = True
        '
        'chkAsistMed
        '
        Me.chkAsistMed.AutoSize = True
        Me.chkAsistMed.Location = New System.Drawing.Point(7, 46)
        Me.chkAsistMed.Name = "chkAsistMed"
        Me.chkAsistMed.Size = New System.Drawing.Size(137, 20)
        Me.chkAsistMed.TabIndex = 1
        Me.chkAsistMed.Text = "Asistencia Médica"
        Me.chkAsistMed.UseVisualStyleBackColor = True
        '
        'chkAuxMec
        '
        Me.chkAuxMec.AutoSize = True
        Me.chkAuxMec.Location = New System.Drawing.Point(7, 22)
        Me.chkAuxMec.Name = "chkAuxMec"
        Me.chkAuxMec.Size = New System.Drawing.Size(128, 20)
        Me.chkAuxMec.TabIndex = 0
        Me.chkAuxMec.Text = "Auxilio Mecánico"
        Me.chkAuxMec.UseVisualStyleBackColor = True
        '
        'lblLogo
        '
        Me.lblLogo.Image = CType(resources.GetObject("lblLogo.Image"), System.Drawing.Image)
        Me.lblLogo.Location = New System.Drawing.Point(387, 11)
        Me.lblLogo.Name = "lblLogo"
        Me.lblLogo.Size = New System.Drawing.Size(84, 64)
        Me.lblLogo.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(35, 346)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 18)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Valor del Vehículo"
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(161, 346)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(77, 20)
        Me.txtValor.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(274, 348)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 18)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Cantidad de Cuotas"
        '
        'btnGenerar
        '
        Me.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnGenerar.Location = New System.Drawing.Point(38, 400)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(122, 36)
        Me.btnGenerar.TabIndex = 14
        Me.btnGenerar.Text = "Generar Póliza"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'btnNueva
        '
        Me.btnNueva.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNueva.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNueva.ForeColor = System.Drawing.SystemColors.Control
        Me.btnNueva.Location = New System.Drawing.Point(189, 400)
        Me.btnNueva.Name = "btnNueva"
        Me.btnNueva.Size = New System.Drawing.Size(122, 36)
        Me.btnNueva.TabIndex = 15
        Me.btnNueva.Text = "Nueva Póliza"
        Me.btnNueva.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.SystemColors.Control
        Me.btnSalir.Location = New System.Drawing.Point(339, 400)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(122, 36)
        Me.btnSalir.TabIndex = 16
        Me.btnSalir.Text = "Salir del Programa"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'numCuotas
        '
        Me.numCuotas.Location = New System.Drawing.Point(418, 346)
        Me.numCuotas.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.numCuotas.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numCuotas.Name = "numCuotas"
        Me.numCuotas.Size = New System.Drawing.Size(42, 20)
        Me.numCuotas.TabIndex = 17
        Me.numCuotas.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblControl
        '
        Me.lblControl.AutoSize = True
        Me.lblControl.BackColor = System.Drawing.Color.Honeydew
        Me.lblControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblControl.Location = New System.Drawing.Point(120, 379)
        Me.lblControl.Name = "lblControl"
        Me.lblControl.Size = New System.Drawing.Size(57, 18)
        Me.lblControl.TabIndex = 18
        Me.lblControl.Text = "Control"
        '
        'lblCuota
        '
        Me.lblCuota.AutoSize = True
        Me.lblCuota.BackColor = System.Drawing.Color.Azure
        Me.lblCuota.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuota.Location = New System.Drawing.Point(274, 379)
        Me.lblCuota.Name = "lblCuota"
        Me.lblCuota.Size = New System.Drawing.Size(43, 16)
        Me.lblCuota.TabIndex = 19
        Me.lblCuota.Text = "Cuota"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(492, 482)
        Me.Controls.Add(Me.lblCuota)
        Me.Controls.Add(Me.lblControl)
        Me.Controls.Add(Me.numCuotas)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnNueva)
        Me.Controls.Add(Me.btnGenerar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblLogo)
        Me.Controls.Add(Me.gBServicios)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de Cálculo de Prima"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.gBServicios.ResumeLayout(False)
        Me.gBServicios.PerformLayout()
        CType(Me.numCuotas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents optImportado As System.Windows.Forms.RadioButton
    Friend WithEvents optNacional As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents optRIParcial As System.Windows.Forms.RadioButton
    Friend WithEvents optRITotal As System.Windows.Forms.RadioButton
    Friend WithEvents optResCivil As System.Windows.Forms.RadioButton
    Friend WithEvents gBServicios As System.Windows.Forms.GroupBox
    Friend WithEvents chkProvVSust As System.Windows.Forms.CheckBox
    Friend WithEvents chkAsistMed As System.Windows.Forms.CheckBox
    Friend WithEvents chkAuxMec As System.Windows.Forms.CheckBox
    Friend WithEvents chkCelular As System.Windows.Forms.CheckBox
    Friend WithEvents lblLogo As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtValor As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnGenerar As System.Windows.Forms.Button
    Friend WithEvents btnNueva As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents numCuotas As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblControl As System.Windows.Forms.Label
    Friend WithEvents lblCuota As System.Windows.Forms.Label

End Class
