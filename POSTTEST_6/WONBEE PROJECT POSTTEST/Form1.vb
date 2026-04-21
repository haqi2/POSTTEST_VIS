Imports MySql.Data.MySqlClient
Imports MySqlConnector

Public Class MenuUtama
    Sub MunculKategori()
        Try
            Call BukaKoneksi()
            DA = New MySqlDataAdapter("SELECT * FROM tb_kategori", CONN)
            Dim dt As New DataTable
            DA.Fill(dt)
            cbKategori.DataSource = dt
            cbKategori.DisplayMember = "nama_kategori"
            cbKategori.ValueMember = "id_kategori"
        Catch ex As Exception
            MsgBox("Gagal muat kategori: " & ex.Message)
        End Try
    End Sub

    Sub TampilData()
        Try
            Call BukaKoneksi()
            Dim sql As String = "SELECT a.id_akun, a.username, a.level, k.nama_kategori, a.keterangan " &
                               "FROM tb_akun a INNER JOIN tb_kategori k ON a.id_kategori = k.id_kategori"
            DA = New MySqlDataAdapter(sql, CONN)
            DS = New DataSet
            DA.Fill(DS, "akun")
            dgvAkun.DataSource = DS.Tables("akun")
        Catch ex As Exception
            MsgBox("Gagal tampil data: " & ex.Message)
        End Try
    End Sub

    Private Sub MenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call MunculKategori()
        Call TampilData()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Data belum lengkap!")
            Exit Sub
        End If

        Try
            Call BukaKoneksi()
            Dim simpan As String = "INSERT INTO tb_akun (username, password, level, id_kategori, keterangan) VALUES " &
                "('" & txtUsername.Text & "', '" & txtPassword.Text & "', '" & txtLevel.Text & "', '" & cbKategori.SelectedValue & "', '" & txtKet.Text & "')"

            CMD = New MySqlCommand(simpan, CONN)
            CMD.ExecuteNonQuery()

            MsgBox("Data Berhasil Disimpan!")
            Call TampilData()
        Catch ex As Exception
            MsgBox("Gagal Simpan: " & ex.Message)
        End Try
    End Sub
End Class