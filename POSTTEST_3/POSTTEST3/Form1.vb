Imports System.IO

Public Class Form1
    Dim grupJK() As RadioButton

    Private Function GetHobi() As String
        Dim hasil As String = ""

        If CheckBox1.Checked = True Then hasil += CheckBox1.Text + ", "
        If CheckBox2.Checked = True Then hasil += CheckBox2.Text + ", "
        If CheckBox3.Checked = True Then hasil += CheckBox3.Text + ", "
        If CheckBox4.Checked = True Then hasil += CheckBox4.Text + ", "
        If CheckBox5.Checked = True Then hasil += CheckBox5.Text + ", "
        If CheckBox6.Checked = True Then hasil += CheckBox6.Text + ", "

        If hasil.EndsWith(", ") Then
            hasil = hasil.Substring(0, hasil.Length - 2)
        End If

        Return hasil
    End Function

    Private Function CekData() As Boolean
        grupJK = {pilihCowo, pilihCewe}

        If Not ValidasiTextBox(txtNama, "Nama Kosong!") Then Return False
        If Not ValidasiTextBox(txtUmur, "Umur Kosong!") Then Return False
        If Not ValidasiTextBox(txtNomor, "Nomor Kosong!") Then Return False
        If Not ValidasiTextBox(txtAlamat, "Alamat Kosong!") Then Return False
        If Not ValidasiRadioButton(grupJK, "Pilih Jenis Kelamin!") Then Return False

        If GetHobi() = "" Then
            MessageBox.Show("Pilih minimal satu hobi!")
            Return False
        End If

        If Not ValidasiPictureBox(pictGambar, "Foto Belum Ada!") Then Return False
        Return True
    End Function

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim ofd As New OpenFileDialog()
        ofd.Filter = "Images|*.jpg;*.png;*.jpeg"
        If ofd.ShowDialog() = DialogResult.OK Then
            DataModule.Foto = ofd.FileName
            pictGambar.Image = Image.FromFile(ofd.FileName)
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If CekData() Then
            DataModule.Nama = txtNama.Text
            DataModule.Umur = txtUmur.Text
            DataModule.NoTelp = txtNomor.Text
            DataModule.Alamat = txtAlamat.Text
            DataModule.Tglahir = tglLahir.Value.ToShortDateString()
            DataModule.JK = DataModule.GetSelectedRadioButton({pilihCowo, pilihCewe})
            DataModule.Hobi = GetHobi()

            Form2.Show()
        End If
    End Sub

    Private Sub txtNomor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNomor.KeyPress
        HanyaAngka(sender, e)
    End Sub

    Private Sub txtUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress
        HanyaAngka(sender, e)
    End Sub
End Class