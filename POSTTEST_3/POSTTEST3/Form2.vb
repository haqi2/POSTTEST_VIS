Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNama.Text = DataModule.Nama
        lblUmur.Text = DataModule.Umur
        lblNomor.Text = DataModule.NoTelp
        lblAlamat.Text = DataModule.Alamat
        lblJK.Text = DataModule.JK
        lblTglLahir.Text = DataModule.Tglahir
        lblHobi.Text = DataModule.Hobi

        If Not String.IsNullOrEmpty(DataModule.Foto) Then
            picPoster.Image = Image.FromFile(DataModule.Foto)
            picPoster.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub
End Class