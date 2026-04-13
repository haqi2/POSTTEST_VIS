Module DataModule
    Public Nama, Umur, NoTelp, Alamat, JK, Foto, Tglahir, Hobi As String

    Public Function GetSelectedRadioButton(grupRadio() As RadioButton) As String
        For Each rb As RadioButton In grupRadio
            If rb.Checked Then Return rb.Text
        Next
        Return ""
    End Function
End Module