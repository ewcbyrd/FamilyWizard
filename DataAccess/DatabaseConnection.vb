Imports MySql.Data.MySqlClient

Public Class DatabaseConnection

    Public Shared Function GetConnection() As MySqlConnection

        Return New MySqlConnection(My.Settings.FamilyWizardMySqlConnectionString)

    End Function
End Class
