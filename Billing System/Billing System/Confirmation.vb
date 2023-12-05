Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient

Public Class Confirmation
    Public Property SelectedSlot As String

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click

        ticket.type.Text = VehicleType.Text
        ticket.plate.Text = plate_number.Text
        ticket.slot.Text = ParkingDetails.Text
        ticket.pay.Text = Guna2TextBox3.Text
        ticket.Label4.Text = Guna2TextBox4.Text
        ticket.Guna2ShadowPanel1.BackgroundImage = My.Resources.Untitled_Project__11_
        ticket.Label1.Visible = True
        ticket.Label6.Visible = True
        ticket.Label3.Visible = True
        ticket.Label5.Visible = True
        ticket.Label2.Visible = True
        ticket.Label4.Visible = True
        Customer_UI.Cname.Text = Nothing
        Customer_UI.Guna2TextBox1.Text = Nothing
        Customer_UI.Guna2TextBox3.Text = Nothing
        Customer_UI.Guna2ComboBox1.Text = Nothing
        Customer_UI.Guna2ComboBox2.Text = Nothing
        Customer_UI.Guna2ComboBox3.Text = Nothing


        ' Retrieve values from textboxes
        Dim customerName As String = Cname.Text
        Dim vehicleType2 As String = VehicleType.Text
        Dim parkingDetails2 As String = ParkingDetails.Text
        '   Dim plate As String = Guna2TextBox3.Text
        Dim textBox3Value As String = Guna2TextBox3.Text
        Dim textBox4Value As String = Guna2TextBox4.Text

        ' Create a connection string (modify it with your database details)
        Dim connectionString As String = "Server=localhost;user id=root;password=;database=parking_system;"

        ' Create a MySqlConnection
        Using connection As New MySqlConnection(connectionString)
            ' Open the connection
            connection.Open()

            ' Create an INSERT query with parameters to avoid SQL injection
            Dim query As String = "INSERT INTO records_table (name,plate_num,vehicle_type,parking_slot,time_date,charge) VALUES (@param1, @param2, @param3, @param4,@param5,@param6)"
            Dim lastId As Integer = 1 + GetTotalRecords()
            ticket.id.Text = $"{lastId}"
            ' Create a MySqlCommand
            Using command As New MySqlCommand(query, connection)
                ' Add parameters to the command
                command.Parameters.AddWithValue("@param1", Cname.Text)
                command.Parameters.AddWithValue("@param2", plate_number.Text)

                command.Parameters.AddWithValue("@param3", VehicleType.Text)
                command.Parameters.AddWithValue("@param4", ParkingDetails.Text)
                command.Parameters.AddWithValue("@param6", Guna2TextBox3.Text)
                command.Parameters.AddWithValue("@param5", Guna2TextBox4.Text)





                ' Execute the query
                command.ExecuteNonQuery()

                ' Optionally display a success message
                MessageBox.Show("Ticket print successfully.")
                Guna2Button1.Enabled = False
                Guna2Button1.Visible = False
                Guna2Button3.Visible = True
                Customers_Mainform.Guna2Button3.Visible = False


            End Using
        End Using

        'Dim lastId As Integer = GetTotalRecords()
        'ticket.id.Text = $"{lastId}"

    End Sub

    'Private Function GetTotalRecords() As Integer
    '    Dim connectionString As String = "Server=localhost;user id=root;password=;database=parking_system;"
    '    Using connection As New MySqlConnection(connectionString)
    '        connection.Open()
    '        Dim query As String = "SELECT COUNT(*) FROM records_table"
    '        Using command As New MySqlCommand(query, connection)
    '            Return Convert.ToInt32(command.ExecuteScalar())
    '        End Using
    '    End Using
    'End Function

    Private Function GetTotalRecords() As Integer
        Dim connectionString As String = "Server=localhost;user id=root;password=;database=parking_system;"
        Using connection As New MySqlConnection(connectionString)
            connection.Open()
            Dim query As String = "SELECT MAX(id) FROM records_table"
            Using command As New MySqlCommand(query, connection)
                Dim result As Object = command.ExecuteScalar()

                If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                    Return Convert.ToInt32(result)
                Else
                    Return 0 ' Return 0 if no records are found
                End If
            End Using
        End Using
    End Function


    'Private Sub Guna2Button2_Click(sender As Object, e As EventArgs)
    '    Customers_Mainform.Panel1.Visible = True
    '    Customers_Mainform.Panel2.Visible = False
    '    Customers_Mainform.Panel3.Visible = False
    '    '  Customers_Mainform.switchPanel(Customer_UI)
    '    ' Customers_Mainform.switchPanel1(ticket)
    'End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs)
        Customers_Mainform.Panel1.Visible = True
        Customers_Mainform.Panel2.Visible = False
        Customers_Mainform.Panel3.Visible = False
        '  Customers_Mainform.switchPanel(Customer_UI)
        ' Customers_Mainform.switchPanel1(ticket)
    End Sub



    Private Sub Confirmation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2Button1.Enabled = True
        Guna2Button1.Visible = True
        Guna2Button3.Visible = False
    End Sub

    Private Sub Guna2Button3_Click_1(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Dim confirm2 As DialogResult = MessageBox.Show("Another transac?", "Questioning ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirm2 = DialogResult.Yes Then
            Customers_Mainform.Guna2Button3.Visible = True
            Customers_Mainform.Panel1.Show()
            ticket.Guna2ShadowPanel1.BackgroundImage = Nothing
            Me.Close()
            ticket.Close()
        End If
    End Sub
End Class