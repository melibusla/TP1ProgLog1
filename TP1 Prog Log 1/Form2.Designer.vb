<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPoliza
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
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblDir = New System.Windows.Forms.Label()
        Me.lblTipoV = New System.Windows.Forms.Label()
        Me.lblSeguro = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblValorV = New System.Windows.Forms.Label()
        Me.lblCuotas = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtCuotas = New System.Windows.Forms.TextBox()
        Me.txtAdicionales = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(24, 24)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre"
        '
        'lblDir
        '
        Me.lblDir.AutoSize = True
        Me.lblDir.Location = New System.Drawing.Point(24, 49)
        Me.lblDir.Name = "lblDir"
        Me.lblDir.Size = New System.Drawing.Size(52, 13)
        Me.lblDir.TabIndex = 1
        Me.lblDir.Text = "Dirección"
        '
        'lblTipoV
        '
        Me.lblTipoV.AutoSize = True
        Me.lblTipoV.Location = New System.Drawing.Point(23, 73)
        Me.lblTipoV.Name = "lblTipoV"
        Me.lblTipoV.Size = New System.Drawing.Size(87, 13)
        Me.lblTipoV.TabIndex = 2
        Me.lblTipoV.Text = "Tipo de Vehiculo"
        '
        'lblSeguro
        '
        Me.lblSeguro.AutoSize = True
        Me.lblSeguro.Location = New System.Drawing.Point(23, 102)
        Me.lblSeguro.Name = "lblSeguro"
        Me.lblSeguro.Size = New System.Drawing.Size(80, 13)
        Me.lblSeguro.TabIndex = 3
        Me.lblSeguro.Text = "Tipo de Seguro"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Adicionales: "
        '
        'lblValorV
        '
        Me.lblValorV.AutoSize = True
        Me.lblValorV.Location = New System.Drawing.Point(27, 202)
        Me.lblValorV.Name = "lblValorV"
        Me.lblValorV.Size = New System.Drawing.Size(100, 13)
        Me.lblValorV.TabIndex = 7
        Me.lblValorV.Text = "Valor del Vehículo: "
        '
        'lblCuotas
        '
        Me.lblCuotas.AutoSize = True
        Me.lblCuotas.Location = New System.Drawing.Point(191, 203)
        Me.lblCuotas.Name = "lblCuotas"
        Me.lblCuotas.Size = New System.Drawing.Size(46, 13)
        Me.lblCuotas.TabIndex = 8
        Me.lblCuotas.Text = "Cuotas: "
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(27, 230)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(31, 13)
        Me.lblTotal.TabIndex = 9
        Me.lblTotal.Text = "Total"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(194, 229)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "En Cuotas de:"
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(114, 223)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(74, 20)
        Me.txtTotal.TabIndex = 11
        '
        'txtCuotas
        '
        Me.txtCuotas.Enabled = False
        Me.txtCuotas.Location = New System.Drawing.Point(274, 222)
        Me.txtCuotas.Name = "txtCuotas"
        Me.txtCuotas.Size = New System.Drawing.Size(70, 20)
        Me.txtCuotas.TabIndex = 12
        '
        'txtAdicionales
        '
        Me.txtAdicionales.Enabled = False
        Me.txtAdicionales.Location = New System.Drawing.Point(88, 123)
        Me.txtAdicionales.Multiline = True
        Me.txtAdicionales.Name = "txtAdicionales"
        Me.txtAdicionales.Size = New System.Drawing.Size(230, 76)
        Me.txtAdicionales.TabIndex = 13
        '
        'frmPoliza
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.ClientSize = New System.Drawing.Size(356, 328)
        Me.Controls.Add(Me.txtAdicionales)
        Me.Controls.Add(Me.txtCuotas)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblCuotas)
        Me.Controls.Add(Me.lblValorV)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblSeguro)
        Me.Controls.Add(Me.lblTipoV)
        Me.Controls.Add(Me.lblDir)
        Me.Controls.Add(Me.lblNombre)
        Me.Name = "frmPoliza"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Póliza - Todavia no funciono bien"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblDir As System.Windows.Forms.Label
    Friend WithEvents lblTipoV As System.Windows.Forms.Label
    Friend WithEvents lblSeguro As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblValorV As System.Windows.Forms.Label
    Friend WithEvents lblCuotas As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtCuotas As System.Windows.Forms.TextBox
    Friend WithEvents txtAdicionales As System.Windows.Forms.TextBox
End Class
