Public Class Customer_UI
    Public rates As Integer
    Public availableSlots As New List(Of String)

    Private Sub Customer_UI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateAvailableSlots()
    End Sub

    Private Sub PopulateAvailableSlots()
        availableSlots.Clear()

        If Guna2ComboBox1.SelectedItem IsNot Nothing Then
            Dim selectedSection As Char = Guna2ComboBox1.SelectedItem.ToString()(0)

            For slotNumber As Integer = 1 To 15
                availableSlots.Add(selectedSection & "-" & slotNumber.ToString())
            Next

            Guna2ComboBox2.DataSource = availableSlots.ToList()
        End If
    End Sub

    Private Sub Guna2ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Guna2ComboBox1.SelectedIndexChanged
        PopulateAvailableSlots()
    End Sub
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If String.IsNullOrWhiteSpace(Cname.Text) OrElse String.IsNullOrWhiteSpace(Guna2TextBox1.Text) OrElse String.IsNullOrWhiteSpace(Guna2TextBox3.Text) Then
            MsgBox("Make Sure you fill all the required details")
        ElseIf Not IsNumeric(Guna2TextBox1.Text) Then
            MsgBox("Contact Number Only")
        Else
            If Guna2ComboBox2.SelectedIndex <> -1 OrElse Guna2ComboBox1.SelectedIndex <> -1 OrElse Guna2ComboBox3.SelectedIndex <> -1 Then
                Dim selectedSlot As String = Guna2ComboBox2.SelectedItem.ToString()

                availableSlots.Remove(selectedSlot)

                Customers_Mainform.Show()
                Confirmation.Guna2TextBox4.Text = Customers_Mainform.Label1.Text
                Confirmation.Cname.Text = Cname.Text
                Confirmation.plate_number.Text = Guna2TextBox3.Text
                Confirmation.ParkingDetails.Text = selectedSlot
                Confirmation.VehicleType.Text = Guna2ComboBox3.Text
                Confirmation.Guna2TextBox3.Text = "₱" & rates
                Customers_Mainform.Panel1.Visible = False
                Customers_Mainform.Panel2.Visible = True
                Customers_Mainform.Panel3.Visible = True
                Customers_Mainform.switchPanel2(ticket)
                Customers_Mainform.switchPanel1(Confirmation)
            Else
                MessageBox.Show("Please select a Prking Section/Parking Number And Vehicle Number ")
            End If

        End If

    End Sub

    Private Sub guna2combobox3_selectedindexchanged(sender As Object, e As EventArgs) Handles Guna2ComboBox3.SelectedIndexChanged
        Select Case Guna2ComboBox3.SelectedIndex
            Case 0
                rates = 5
                Guna2HtmlLabel6.Text = rates
            Case 1
                rates = 10
                Guna2HtmlLabel6.Text = rates
            Case 2
                rates = 15
                Guna2HtmlLabel6.Text = rates
            Case 3
                rates = 20
                Guna2HtmlLabel6.Text = rates
        End Select
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        ParkNow.Show()
        Me.Close()
        Customers_Mainform.Close()
    End Sub

    'Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox1.TextChanged
    '    MsgBox("Invalid Contact Number")

    '    If Guna2TextBox1.Text.Length < 10 Then
    '        '  Label1.Visible = True
    '        MsgBox("Invalid Contact Number")

    '    Else
    '        ' Label1.Visible = False
    '    End If

    'End Sub

    'Private Sub Guna2TextBox3_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox3.TextChanged

    'End Sub
    'Private Sub Guna2TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Guna2TextBox1.KeyPress

    '    If Not Char.IsDigit(e.KeyChar) Then
    '        MsgBox("Numbers Only ")
    '        e.Handled = True
    '    End If
    'End Sub
End Class
