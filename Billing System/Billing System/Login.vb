Imports MySql.Data.MySqlClient

Public Class Login
    Dim AdminJenny As String = "jenny@gmail.com"
    Dim passjen As String = "Admin1"
    Dim AdminMark As String = "marktalavera@gmail.com"
    Dim passmark As String = "Admin2"
    Dim AdminGabo As String = "Gabriel894@gmail.com"
    Dim passgabo As String = "Admin3"
    Dim AdminDar As String = "Darwin@gmail.com"
    Dim passdar As String = "Admin4"
    Public Admin1, Admin2, Admin3, Admin4 As String

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Dim yes_no As DialogResult = MessageBox.Show("Are you sure you want to go back?", "Confrimation", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If yes_no = DialogResult.Yes Then
            ParkNow.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2Button1.FillColor = ColorTranslator.FromHtml("#A269B3")

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If My.Computer.Network.IsAvailable Then
            If IsDatabaseConnected() Then
                If Pass.Text = passjen Then
                    MsgBox("Succesfully Login ")
                    Admin1 = "Jenny Santos"
                    Main_Form.Label1.Text = Admin1
                    Main_Form.Guna2CirclePictureBox2.Image = My.Resources.jeni
                    Main_Form.Show()
                    Me.Close()

                ElseIf Pass.Text = passmark Then
                    MsgBox("Succesfully Login ")
                    Admin2 = "Mark Edrian Talavera"
                    Main_Form.Label1.Text = Admin2
                    Main_Form.Guna2CirclePictureBox2.Image = My.Resources.mark
                    Main_Form.Show()
                    Me.Close()
                ElseIf Pass.Text = passgabo Then
                    MsgBox("Succesfully Login ")
                    Admin3 = "Gabriel Dean Cayabyab"
                    Main_Form.Label1.Text = Admin3
                    Main_Form.Guna2CirclePictureBox2.Image = My.Resources.gab
                    Main_Form.Show()
                    Me.Close()
                ElseIf Pass.Text = passdar Then
                    MsgBox("Succesfully Login ")
                    Admin4 = "Darwin Moran"
                    Main_Form.Label1.Text = Admin4
                    Main_Form.Guna2CirclePictureBox2.Image = My.Resources.moran
                    Main_Form.Show()
                    Me.Close()
                ElseIf String.IsNullOrWhiteSpace(Pass.Text) Then
                    MsgBox("Fill in All Fields ")
                Else
                    MsgBox("Username and Passwor does not match !")
                End If
            Else
                MsgBox("Error connecting to the database. Please check your database connection settings.")
            End If
        Else
            MsgBox("No internet connection. Please check your internet connection and try again.")

        End If

    End Sub
    Private Function IsDatabaseConnected() As Boolean
        Dim connectionString As String = "Server=localhost;user id=root;password=;database=parking_system;"
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Return True
            Catch ex As Exception
                MsgBox("Error connecting to the database. Please check your database connection settings.")
                Return False
            End Try
        End Using
    End Function
    'Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
    '    Dim yes_no As DialogResult = MessageBox.Show("", "Confrimation", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
    '    If yes_no = DialogResult.Yes Then
    '        ParkNow.Show()
    '        Me.Close()
    '    End If
    'End Sub
End Class