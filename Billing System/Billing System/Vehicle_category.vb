Imports MySql.Data.MySqlClient

Public Class Vehicle_category
    Public Earn, Earn1, Earn2, Earn3, total As Integer
    Private Sub Vehicle_category_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bicycle.Text = GetTotalBikes()
        Earn = GetTotalBikes()
        Earn = Earn * 5
        Motor.Text = GetTotalMotorcycle()
        Earn1 = GetTotalMotorcycle()
        Earn1 = Earn1 * 10
        car.Text = GetTotalCar()
        Earn2 = GetTotalCar()
        Earn2 = Earn2 * 15
        truck.Text = GetTotalTruck()
        Earn3 = GetTotalTruck()
        Earn3 = Earn3 * 20

        total = Earn + Earn1 + Earn2 + Earn3

        Dashboard.total_earnings.Text = total
    End Sub
    Private Function GetTotalBikes() As Integer
        Dim connectionString As String = "Server=localhost;user id=root;password=;database=parking_system;"
        Using connection As New MySqlConnection(connectionString)
            connection.Open()
            ' Assuming you have a column named 'vehicle_type' in your 'records_table'
            Dim query As String = "SELECT COUNT(*) FROM records_table WHERE vehicle_type = 'Bike'"
            Using command As New MySqlCommand(query, connection)
                Return Convert.ToInt32(command.ExecuteScalar())
            End Using
        End Using
    End Function

    Private Function GetTotalMotorcycle() As Integer
        Dim connectionString As String = "Server=localhost;user id=root;password=;database=parking_system;"
        Using connection As New MySqlConnection(connectionString)
            connection.Open()
            ' Assuming you have a column named 'vehicle_type' in your 'records_table'
            Dim query As String = "SELECT COUNT(*) FROM records_table WHERE vehicle_type = 'Motorcycle'"
            Using command As New MySqlCommand(query, connection)
                Return Convert.ToInt32(command.ExecuteScalar())
            End Using
        End Using
    End Function

    Private Function GetTotalCar() As Integer
        Dim connectionString As String = "Server=localhost;user id=root;password=;database=parking_system;"
        Using connection As New MySqlConnection(connectionString)
            connection.Open()
            ' Assuming you have a column named 'vehicle_type' in your 'records_table'
            Dim query As String = "SELECT COUNT(*) FROM records_table WHERE vehicle_type = 'Car'"
            Using command As New MySqlCommand(query, connection)
                Return Convert.ToInt32(command.ExecuteScalar())
            End Using
        End Using
    End Function
    Private Function GetTotalTruck() As Integer
        Dim connectionString As String = "Server=localhost;user id=root;password=;database=parking_system;"
        Using connection As New MySqlConnection(connectionString)
            connection.Open()
            ' Assuming you have a column named 'vehicle_type' in your 'records_table'
            Dim query As String = "SELECT COUNT(*) FROM records_table WHERE vehicle_type = 'Truck'"
            Using command As New MySqlCommand(query, connection)
                Return Convert.ToInt32(command.ExecuteScalar())
            End Using
        End Using
    End Function

End Class