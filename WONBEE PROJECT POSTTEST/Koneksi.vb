Imports MySql.Data.MySqlClient
Imports MySqlConnector

Module Koneksi
    Public CONN As MySqlConnection
    Public CMD As MySqlCommand
    Public DA As MySqlDataAdapter
    Public DR As MySqlDataReader
    Public DS As DataSet

    Public Sub BukaKoneksi()
        Dim strKoneksi As String = "server=localhost;user id=root;password=;database=db_wonbee"
        Try
            CONN = New MySqlConnection(strKoneksi)
            If CONN.State = ConnectionState.Closed Then
                CONN.Open()
            End If
        Catch ex As Exception
            MsgBox("Koneksi ke Database Gagal: " & ex.Message)
        End Try
    End Sub
End Module