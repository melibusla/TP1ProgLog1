Public Class Form1
    'Public Nombre = txtNombre.Text
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        optNacional.Checked = True
        optResCivil.Checked = True

    End Sub

    Private Sub btnNueva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNueva.Click
        txtNombre.Text = ""
        txtDireccion.Text = ""
        txtValor.Text = ""
        chkAsistMed.Checked = False
        chkAuxMec.Checked = False
        chkCelular.Checked = False
        chkProvVSust.Checked = False
        optNacional.Checked = True
        optResCivil.Checked = True
        numCuotas.Value = 1
    End Sub

    Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerar.Click
        If txtNombre.Text = "" And txtValor.Text = "" Then
            MessageBox.Show("Ingrese su nombre y el valor del vehículo")
        End If

        Dim Prima As Decimal
        Dim Valor As Decimal
        Dim Cuota As Decimal
        Dim Poliza = New frmPoliza
        Valor = Val(txtValor.Text)
        Prima = 0

        If optResCivil.Checked = True Then
            Prima = Valor + (Valor * 5 / 100)
        Else
            If optRIParcial.Checked = True Then
                Prima = Valor + (Valor * 15 / 100)
            Else
                Prima = Valor + (Valor * 8 / 100)
            End If
        End If

        If optImportado.Checked = True Then
            Prima = Prima + (Prima * 20 / 100)
        End If

        If chkAsistMed.Checked = True Then
            Prima = Prima + 70
        End If
        If chkAuxMec.Checked = True Then
            Prima = Prima + 85
        End If
        If chkCelular.Checked = True Then
            Prima = Prima + 80
        End If
        If chkProvVSust.Checked = True Then
            Prima = Prima + 95
        End If

        If numCuotas.Value = 1 Then
            Prima = Prima - (Prima * 15 / 100)
        Else
            Prima = Prima + (Prima * 12 / 100)
        End If

        Cuota = Prima / numCuotas.Value

        lblControl.Text = Val(Prima)
        lblCuota.Text = Val(Cuota)
        Poliza.Show()
    End Sub
End Class
