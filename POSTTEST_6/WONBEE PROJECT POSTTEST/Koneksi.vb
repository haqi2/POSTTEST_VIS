Imports MySql.Data.MySqlClient
Imports MySqlConnector

Module Koneksi
    Public CONN As MySqlConnection
    Public CMD As MySqlCommand
    Public DA As MySqlDataAdapter
    Public DS As DataSet

    Public Sub BukaKoneksi()
        ' Pastikan database name sudah sesuai
        Dim str As String = "server=localhost;user id=root;password=;database=db_wonbee"
        Try
            CONN = New MySqlConnection(str)
            If CONN.State = ConnectionState.Closed Then CONN.Open()
        Catch ex As Exception
            MsgBox("Koneksi Gagal: " & ex.Message)
        End Try
    End Sub
End Module