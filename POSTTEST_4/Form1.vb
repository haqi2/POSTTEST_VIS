Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            PictureBox8.Image = Image.FromFile(OpenFileDialog1.FileName)
            PictureBox8.SizeMode = PictureBoxSizeMode.Zoom
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtNama.Text = "" Or txtID.Text = "" Or PictureBox8.Image Is Nothing Then
            MessageBox.Show("Mohon lengkapi Nama, ID, dan Foto!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim konfirmasi As DialogResult = MessageBox.Show("Apakah data sudah benar dan siap cetak?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If konfirmasi = DialogResult.Yes Then
            Dim jk As String = If(RadioButton1.Checked, "Laki-laki", "Perempuan")

            Dim jabatan As String = ""
            If RadioButton3.Checked Then
                jabatan = "President"
            ElseIf RadioButton4.Checked Then
                jabatan = "Vice-President"
            ElseIf RadioButton7.Checked Then
                jabatan = "Public Relations"
            ElseIf RadioButton10.Checked Then
                jabatan = "Official Member"
            ElseIf RadioButton8.Checked Then
                jabatan = "Road Captain"
            ElseIf RadioButton6.Checked Then
                jabatan = "Bendahara"
            ElseIf RadioButton5.Checked Then
                jabatan = "Sekretaris"
            ElseIf RadioButton9.Checked Then
                jabatan = "Sweeper"
            End If

            Dim hobi As New List(Of String)
            If CheckBox1.Checked Then hobi.Add("Drifting")
            If CheckBox2.Checked Then hobi.Add("Touring")
            If CheckBox4.Checked Then hobi.Add("Modif")
            If CheckBox6.Checked Then hobi.Add("Sunmori")
            If CheckBox7.Checked Then hobi.Add("Night Drive")
            If CheckBox8.Checked Then hobi.Add("Charity")
            If CheckBox3.Checked Then hobi.Add("Car Photogr")
            If CheckBox5.Checked Then hobi.Add("Ngopi")

            Form2.Label1.Text = txtNama.Text
            Form2.Label2.Text = txtID.Text
            Form2.Label8.Text = MaskedTextBox1.Text
            Form2.Label3.Text = dtpTanggalLahir.Value.ToShortDateString()
            Form2.Label4.Text = jk
            Form2.Label6.Text = txtAlamat.Text
            Form2.Label5.Text = cmbDivisi.Text
            Form2.Label10.Text = jabatan
            Form2.Label9.Text = String.Join(", ", hobi)
            Form2.Label7.Text = txtEmail.Text
            Form2.PictureBox2.Image = PictureBox8.Image
            Form2.PictureBox2.SizeMode = PictureBoxSizeMode.Zoom

            Form2.Show()
        End If
    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub InputToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputToolStripMenuItem.Click
        txtNama.Clear()
        txtID.Clear()
        txtEmail.Clear()
        txtAlamat.Clear()
        MaskedTextBox1.Clear()
        cmbDivisi.SelectedIndex = -1
        dtpTanggalLahir.Value = DateTime.Now

        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton5.Checked = False
        RadioButton6.Checked = False
        RadioButton7.Checked = False
        RadioButton8.Checked = False
        RadioButton9.Checked = False
        RadioButton10.Checked = False

        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False
        CheckBox7.Checked = False
        CheckBox8.Checked = False

        PictureBox8.Image = Nothing
        MessageBox.Show("Form telah dikosongkan.", "Info")
    End Sub

    Private Sub LihatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatToolStripMenuItem.Click
        Button2.PerformClick()
    End Sub

    Private Sub SimpanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpanToolStripMenuItem.Click
        SaveFileDialog1.Filter = "Text File|*.txt"
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim jk As String = If(RadioButton1.Checked, "Laki-laki", "Perempuan")
            Dim jabatan As String = ""
            If RadioButton3.Checked Then
                jabatan = "President"
            ElseIf RadioButton4.Checked Then
                jabatan = "Vice-President"
            ElseIf RadioButton7.Checked Then
                jabatan = "Public Relations"
            ElseIf RadioButton10.Checked Then
                jabatan = "Official Member"
            ElseIf RadioButton8.Checked Then
                jabatan = "Road Captain"
            ElseIf RadioButton6.Checked Then
                jabatan = "Bendahara"
            ElseIf RadioButton5.Checked Then
                jabatan = "Sekretaris"
            ElseIf RadioButton9.Checked Then
                jabatan = "Sweeper"
            End If

            Dim hobi As New List(Of String)
            If CheckBox1.Checked Then hobi.Add("Drifting")
            If CheckBox2.Checked Then hobi.Add("Touring")
            If CheckBox4.Checked Then hobi.Add("Modif")
            If CheckBox6.Checked Then hobi.Add("Sunmori")
            If CheckBox7.Checked Then hobi.Add("Night Drive")
            If CheckBox8.Checked Then hobi.Add("Charity")
            If CheckBox3.Checked Then hobi.Add("Car Photogr")
            If CheckBox5.Checked Then hobi.Add("Ngopi")

            Dim data As String = "=== DATA ANGGOTA W82 ===" & vbCrLf &
                             "Nama          : " & txtNama.Text & vbCrLf &
                             "ID            : " & txtID.Text & vbCrLf &
                             "Tgl Lahir     : " & dtpTanggalLahir.Value.ToShortDateString() & vbCrLf &
                             "Divisi        : " & cmbDivisi.Text & vbCrLf &
                             "Gender        : " & jk & vbCrLf &
                             "No HP         : " & MaskedTextBox1.Text & vbCrLf &
                             "Email         : " & txtEmail.Text & vbCrLf &
                             "Alamat        : " & txtAlamat.Text & vbCrLf &
                             "Jabatan       : " & jabatan & vbCrLf &
                             "Hobi          : " & String.Join(", ", hobi)

            System.IO.File.WriteAllText(SaveFileDialog1.FileName, data)
            MessageBox.Show("Seluruh data berhasil disimpan!", "Sukses")
        End If
    End Sub

    Private Sub BukaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukaToolStripMenuItem.Click
        OpenFileDialog1.Filter = "Text File|*.txt"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim isi As String = System.IO.File.ReadAllText(OpenFileDialog1.FileName)
            MessageBox.Show(isi, "Isi Data Member")
        End If
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Dim dr As DialogResult = MessageBox.Show("Yakin ingin keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dr = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class