Imports MySql.Data.MySqlClient

Public Class Main_Form
    Public Earn, Earn1, Earn2, Earn3, total As Integer
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)

        Login.Show()
        Me.Close()

    End Sub


    Sub switchPanel(ByVal panel As Form)
        Panel1.Controls.Clear()
        panel.TopLevel = False
        Panel1.Controls.Add(panel)
        panel.Show()

    End Sub

    Private Sub pslots_btn_Click(sender As Object, e As EventArgs) Handles pslots_btn.Click
        pslots_btn.ForeColor = Color.FromArgb(174, 99, 169)
        pslots_btn.FocusedColor = Color.DimGray
        Guna2Button2.ForeColor = Color.FromArgb(80, 58, 74)
        Guna2Button1.ForeColor = Color.FromArgb(80, 58, 74)
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


        Dashboard.total_earnings.Text = Format(total, "₱ #,##.##")
        switchPanel(Dashboard)
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        switchPanel(Vehicle_category)
        pslots_btn.ForeColor = Color.FromArgb(80, 58, 74)
        Guna2Button2.FocusedColor = Color.DimGray
        Guna2Button2.ForeColor = Color.FromArgb(174, 99, 169)
        Guna2Button1.ForeColor = Color.FromArgb(80, 58, 74)
    End Sub

    Private Sub Guna2Button1_Click_1(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        pslots_btn.ForeColor = Color.FromArgb(80, 58, 74)
        Guna2Button2.ForeColor = Color.FromArgb(80, 58, 74)
        Guna2Button1.ForeColor = Color.FromArgb(174, 99, 169)
        Guna2Button1.FocusedColor = Color.DimGray
        switchPanel(Manage_reports)
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Dim Confirm As DialogResult = MessageBox.Show("Are you sure you want to logout ?", "Confirmation ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Confirm = DialogResult.Yes Then
            ParkNow.Show()
            Me.Close()
        End If
    End Sub


    Private Sub Main_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        switchPanel(Dashboard)
        pslots_btn.ForeColor = Color.FromArgb(174, 99, 169)
        pslots_btn.FocusedColor = Color.DimGray
        Guna2Button2.ForeColor = Color.FromArgb(80, 58, 74)
        Guna2Button1.ForeColor = Color.FromArgb(80, 58, 74)

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


        Dashboard.total_earnings.Text = Format(total, "₱ #,##.##")

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