Imports MySql.Data.MySqlClient

Module ModuleDB
    Public con As New MySqlConnection
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader

    Sub OpenCon()
        ' ************* Error Handling para sa database connection  ****************** 

        Try 'container sa mga delikado o maaaring magdulot ng error

            ' Gamitin ang connection string mula sa Settings
            Dim connectionString As String = "server=localhost;user id=root;password=root;database=db_grocery_system"

            con.ConnectionString = connectionString
            con.Open()
            cmd.Connection = con

        Catch ex As Exception ' Dito pupunta pag may error sa database connection
            MsgBox("Error sa Database Connection: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

End Module