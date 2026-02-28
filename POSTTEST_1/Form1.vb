Public Class Form1
    Dim totalIP As Double = 0
    Dim jumlahSmt As Integer = 0

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim inputBaru As Double = Val(txtIPS.Text)

        If inputBaru > 0 And inputBaru <= 4 Then
            totalIP = totalIP + inputBaru
            jumlahSmt = jumlahSmt + 1
            Dim ipk As Double = totalIP / jumlahSmt

            txtIPK.Text = ipk.ToString("N2")

            ' Logika Predikat (Ditambah kondisi untuk IP di bawah 2.0)
            If ipk < 2.0 Then
                lblRanking.Text = "Predikat: ........."
            ElseIf ipk >= 2.0 And ipk <= 2.75 Then
                lblRanking.Text = "Predikat: Okelah"
            ElseIf ipk > 2.75 And ipk <= 3.0 Then
                lblRanking.Text = "Predikat: Keren"
            ElseIf ipk > 3.0 Then
                lblRanking.Text = "Predikat: Gacor "
            End If

            txtIPS.Clear()
            txtIPS.Focus()
        Else
            MsgBox("Masukkan nilai IP antara 0 - 4 Gaboleh selain itu !")
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        totalIP = 0
        jumlahSmt = 0
        txtIPS.Clear()
        txtIPK.Text = "0.00"
        lblRanking.Text = "Predikat: -"
    End Sub
End Class