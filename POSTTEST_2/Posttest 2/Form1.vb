Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtTambahJudul.Focus()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If txtTambahJudul.Text = "" Or txtGenre.Text = "" Then
            MsgBox("Lengkapi Judul dan Genre !", MsgBoxStyle.Exclamation, "Peringatan")
        Else
            dgvBuku.Rows.Add(txtTambahJudul.Text, txtGenre.Text)
            txtTambahJudul.Clear()
            txtGenre.Clear()
            txtTambahJudul.Focus()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim ditemukan As Boolean = False
        Dim judulCari As String = txtHapusJudul.Text

        If judulCari = "" Then
            MsgBox("Ketikkan judul yang kamu hapus!", MsgBoxStyle.Information)
            Exit Sub
        End If

        For i As Integer = 0 To dgvBuku.Rows.Count - 1
            If dgvBuku.Rows(i).Cells(0).Value.ToString.ToLower = judulCari.ToLower Then
                dgvBuku.Rows.RemoveAt(i)
                ditemukan = True
                Exit For
            End If
        Next

        If ditemukan = True Then
            MsgBox("Buku dihapus!", MsgBoxStyle.Information, "Sukses")
            txtHapusJudul.Clear()
        Else
            MsgBox("Bukunya Gada!", MsgBoxStyle.Critical, "Gagal")
        End If
    End Sub

End Class