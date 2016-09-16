Imports MySql.Data.MySqlClient
Public Class CDArneses

    'conectando la DB de MySql
    Private MysqlCommand As New MySqlCommand
        Const MysqlConnString As String = "server=localhost;user id=root;password=Prospot;database=prospot"
        Public MysqlConexion As MySqlConnection = New MySqlConnection(MysqlConnString)
        Public Sub Probarconexion()
            Try
                MysqlConexion.Open()
                MsgBox("la conexión fue exitosa")
                MysqlConexion.Close()
            Catch ex As Exception
                MsgBox("La conexión no fue exitosa")
            End Try
        End Sub


End Class
