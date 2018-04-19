Public Class Form1
    'Public Nombre = txtNombre.Text
    Dim Prima As Decimal
    Dim Valor As Decimal
    Dim Cuota As Decimal
    Dim Poliza = New frmPoliza
   
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
        'txtTotal.Text = ""
        'txtCuota.Text = ""
    End Sub

    Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerar.Click
        If txtNombre.Text <> "" And txtValor.Text <> "" Then
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
            Prima = Format(Prima, "0.00")
            Cuota = Format(Cuota, "0.00")
            'Control sin msg box. 
            'txtTotal.Text = Val(Prima)
            'txtCuota.Text = Val(Cuota)

            MessageBox.Show("***POLIZA***" & Environment.NewLine &
                            "Nombre: " & txtNombre.Text & Environment.NewLine &
                            "Direccion: " & txtDireccion.Text & Environment.NewLine &
                            "Valor del Vehículo: $" & txtValor.Text & Environment.NewLine &
                            "Costo Total de la Poliza: $" & Prima & Environment.NewLine &
                            "Costo de cada cuota: $" & Cuota
                            )
        Else
            MessageBox.Show("Para Continuar, ingrese su nombre y el valor del vehículo")
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnGenerar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerar2.Click
        Poliza.Show()
    End Sub
End Class
