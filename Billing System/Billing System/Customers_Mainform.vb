Public Class Customers_Mainform
    Private Sub Customers_Mainform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        switchPanel(Customer_UI)
        Timer1.Start()
    End Sub

    Public Sub switchPanel(ByVal panel As Form)
        Panel1.Controls.Clear()
        panel.TopLevel = False
        Panel1.Controls.Add(panel)
        panel.Show()

    End Sub
    Public Sub switchPanel1(ByVal panel As Form)
        Panel2.Controls.Clear()
        panel.TopLevel = False
        Panel2.Controls.Add(panel)
        panel.Show()

    End Sub
    Public Sub switchPanel2(ByVal panel As Form)
        Panel3.Controls.Clear()
        panel.TopLevel = False
        Panel3.Controls.Add(panel)
        panel.Show()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Visible = False
        Label1.Text = DateTime.Now.ToShortTimeString() & "  " & DateTime.Now.ToShortDateString()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Panel1.Show()
        ticket.Guna2ShadowPanel1.BackgroundImage = Nothing
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class