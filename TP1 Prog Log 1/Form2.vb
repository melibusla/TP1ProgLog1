Public Class frmPoliza

    Private Sub frmPoliza_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim AsistMed As String
        Dim AuxMec As String
        Dim Celular As String
        Dim ProvV As String
        lblNombre.Text = "Nombre: " + Form1.txtNombre.Text
        lblDir.Text = "Dirección: " + Form1.txtDireccion.Text

        If Form1.optNacional.Checked Then
            lblTipoV.Text = "Vehiculo Nacional"
        Else
            lblTipoV.Text = "Vehiculo Importado"
        End If
        If Form1.optResCivil.Checked Then
            lblSeguro.Text = "Tipo de Seguro: Responsabilidad Civil"
        Else
            If Form1.optRIParcial.Checked Then
                lblSeguro.Text = "Tipo de Seguro: Robo e Incendio Parcial"
            Else
                lblSeguro.Text = "Tipo de Seguro: Robo e Incendio Total"
            End If
        End If
        If Form1.chkAsistMed.Checked Then
            AsistMed = "Asistencia Medica"
        End If
        If Form1.chkAuxMec.Checked Then
            AuxMec = "Auxilio Mecanico"
        End If
        If Form1.chkCelular.Checked Then
            Celular = "Teléfono Celular"
        End If
        If Form1.chkProvVSust.Checked Then
            ProvV = "Provisión de vehículo sustituto"
        End If
        txtAdicionales.Text = AuxMec + " " + AsistMed + " " + Celular + " " + ProvV

        lblValorV.Text = "Valor del Vehículo: " + Form1.txtValor.Text
        lblCuotas.Text = "Cuotas: " + Form1.numCuotas.Value
        txtTotal.Text = Form1.lblControl.Text
        txtCuotas.Text = Form1.lblCuota.Text

        'vbCrLf
    End Sub
End Class