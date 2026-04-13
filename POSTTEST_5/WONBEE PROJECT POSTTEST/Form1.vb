Imports MySql.Data.MySqlClient
Imports MySqlConnector

Public Class MenuUtama
    Sub TampilData()
        Try
            Call BukaKoneksi()
            DA = New MySqlDataAdapter("SELECT * FROM tb_akun", CONN)
            DS = New DataSet
            DA.Fill(DS, "tb_akun")
            dgvAkun.DataSource = DS.Tables("tb_akun")
            dgvAkun.ReadOnly = True
        Catch ex As Exception
            MsgBox("Gagal menampilkan data: " & ex.Message)
        End Try
    End Sub

    Private Sub txtLevel_TextChanged(sender As Object, e As EventArgs) Handles txtLevel.TextChanged
        Dim level As Integer
        If Integer.TryParse(txtLevel.Text, level) Then
            If level < 20 Then
                txtTipe.Text = "Akun Smurf"
            ElseIf level >= 20 And level < 50 Then
                txtTipe.Text = "Akun Biasa"
            ElseIf level >= 50 Then
                txtTipe.Text = "Akun Gacor"
            End If
        Else
            txtTipe.Text = ""
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Or txtLevel.Text = "" Then
            MsgBox("Lengkapi data akun dulu!")
        Else
            Try
                Call BukaKoneksi()
                Dim simpan As String = "INSERT INTO tb_akun (username, password, level, tipe_akun, keterangan) VALUES " &
                    "('" & txtUsername.Text & "', '" & txtPassword.Text & "', '" & txtLevel.Text & "', '" & txtTipe.Text & "', '" & txtKet.Text & "')"

                CMD = New MySqlCommand(simpan, CONN)
                CMD.ExecuteNonQuery()

                MsgBox("Akun Berhasil Disimpan!")

                Call TampilData()
                txtUsername.Clear()
                txtPassword.Clear()
                txtLevel.Clear()
                txtTipe.Text = ""
                txtKet.Clear()
                txtUsername.Focus()
            Catch ex As Exception
                MsgBox("Gagal Simpan: " & ex.Message)
            End Try
        End If
    End Sub
End Class