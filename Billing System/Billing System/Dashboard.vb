Imports System.Threading
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar
Imports MySql.Data.MySqlClient

Public Class Dashboard
    Public Earn, Earn1, Earn2, Earn3, total As Integer
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Vehicle_category.bicycle.Text = GetTotalBikes()
        Earn = GetTotalBikes()
        Earn = Earn * 5
        Vehicle_category.Motor.Text = GetTotalMotorcycle()
        Earn1 = GetTotalMotorcycle()
        Earn1 = Earn1 * 10
        Vehicle_category.car.Text = GetTotalCar()
        Earn2 = GetTotalCar()
        Earn2 = Earn2 * 15
        Vehicle_category.truck.Text = GetTotalTruck()
        Earn3 = GetTotalTruck()
        Earn3 = Earn3 * 20

        total = Earn + Earn1 + Earn2 + Earn3


        total_earnings.Text = Format(total, "₱ #,##.##")

        Dim totalRecords As Integer = GetTotalRecords()
        total_recors.Text = $"{totalRecords}"
        vehicles_parked.Text = $"{totalRecords}"

    End Sub
    Private Function GetTotalRecords() As Integer
        Dim connectionString As String = "Server=localhost;user id=root;password=;database=parking_system;"
        Using connection As New MySqlConnection(connectionString)
            connection.Open()
            Dim query As String = "SELECT COUNT(*) FROM records_table"
            Using command As New MySqlCommand(query, connection)
                Return Convert.ToInt32(command.ExecuteScalar())
            End Using
        End Using
    End Function

    Private Sub total_earnings_Click(sender As Object, e As EventArgs) Handles total_earnings.Click

    End Sub

    Private Sub vehicles_parked_Click(sender As Object, e As EventArgs) Handles vehicles_parked.Click

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
