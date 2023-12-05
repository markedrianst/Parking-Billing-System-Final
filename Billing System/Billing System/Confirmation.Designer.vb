<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Confirmation
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Confirmation))
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Cname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ParkingDetails = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TextBox3 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TextBox4 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.VehicleType = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.plate_number = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.BorderRadius = 50
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.DragForm = False
        Me.Guna2BorderlessForm1.ResizeForm = False
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.AutoSize = False
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Arial Black", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(38, 30)
        Me.Guna2HtmlLabel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(337, 43)
        Me.Guna2HtmlLabel1.TabIndex = 0
        Me.Guna2HtmlLabel1.Text = "Confirm Details"
        '
        'Cname
        '
        Me.Cname.Animated = True
        Me.Cname.BorderColor = System.Drawing.Color.Gray
        Me.Cname.BorderRadius = 5
        Me.Cname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Cname.DefaultText = ""
        Me.Cname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Cname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Cname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Cname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Cname.Enabled = False
        Me.Cname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cname.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!)
        Me.Cname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cname.Location = New System.Drawing.Point(72, 111)
        Me.Cname.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Cname.Name = "Cname"
        Me.Cname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Cname.PlaceholderText = ""
        Me.Cname.SelectedText = ""
        Me.Cname.Size = New System.Drawing.Size(372, 55)
        Me.Cname.TabIndex = 1
        '
        'ParkingDetails
        '
        Me.ParkingDetails.Animated = True
        Me.ParkingDetails.BorderColor = System.Drawing.Color.Gray
        Me.ParkingDetails.BorderRadius = 5
        Me.ParkingDetails.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ParkingDetails.DefaultText = ""
        Me.ParkingDetails.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.ParkingDetails.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ParkingDetails.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ParkingDetails.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ParkingDetails.Enabled = False
        Me.ParkingDetails.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ParkingDetails.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!)
        Me.ParkingDetails.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ParkingDetails.Location = New System.Drawing.Point(72, 370)
        Me.ParkingDetails.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ParkingDetails.Name = "ParkingDetails"
        Me.ParkingDetails.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ParkingDetails.PlaceholderText = ""
        Me.ParkingDetails.SelectedText = ""
        Me.ParkingDetails.Size = New System.Drawing.Size(372, 55)
        Me.ParkingDetails.TabIndex = 2
        '
        'Guna2TextBox3
        '
        Me.Guna2TextBox3.Animated = True
        Me.Guna2TextBox3.BorderColor = System.Drawing.Color.Gray
        Me.Guna2TextBox3.BorderRadius = 5
        Me.Guna2TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox3.DefaultText = ""
        Me.Guna2TextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox3.Enabled = False
        Me.Guna2TextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!)
        Me.Guna2TextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox3.Location = New System.Drawing.Point(72, 544)
        Me.Guna2TextBox3.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Guna2TextBox3.Name = "Guna2TextBox3"
        Me.Guna2TextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox3.PlaceholderText = ""
        Me.Guna2TextBox3.SelectedText = ""
        Me.Guna2TextBox3.Size = New System.Drawing.Size(372, 55)
        Me.Guna2TextBox3.TabIndex = 4
        '
        'Guna2TextBox4
        '
        Me.Guna2TextBox4.Animated = True
        Me.Guna2TextBox4.BorderColor = System.Drawing.Color.Gray
        Me.Guna2TextBox4.BorderRadius = 5
        Me.Guna2TextBox4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox4.DefaultText = ""
        Me.Guna2TextBox4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox4.Enabled = False
        Me.Guna2TextBox4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!)
        Me.Guna2TextBox4.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox4.Location = New System.Drawing.Point(72, 458)
        Me.Guna2TextBox4.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Guna2TextBox4.Name = "Guna2TextBox4"
        Me.Guna2TextBox4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox4.PlaceholderText = ""
        Me.Guna2TextBox4.SelectedText = ""
        Me.Guna2TextBox4.Size = New System.Drawing.Size(372, 55)
        Me.Guna2TextBox4.TabIndex = 3
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Animated = True
        Me.Guna2Button1.BorderRadius = 10
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.Snow
        Me.Guna2Button1.Location = New System.Drawing.Point(100, 629)
        Me.Guna2Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(309, 59)
        Me.Guna2Button1.TabIndex = 5
        Me.Guna2Button1.Text = "Print Ticket"
        '
        'VehicleType
        '
        Me.VehicleType.Animated = True
        Me.VehicleType.BorderColor = System.Drawing.Color.Gray
        Me.VehicleType.BorderRadius = 5
        Me.VehicleType.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.VehicleType.DefaultText = ""
        Me.VehicleType.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.VehicleType.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.VehicleType.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.VehicleType.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.VehicleType.Enabled = False
        Me.VehicleType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.VehicleType.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!)
        Me.VehicleType.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.VehicleType.Location = New System.Drawing.Point(72, 196)
        Me.VehicleType.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.VehicleType.Name = "VehicleType"
        Me.VehicleType.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.VehicleType.PlaceholderText = ""
        Me.VehicleType.SelectedText = ""
        Me.VehicleType.Size = New System.Drawing.Size(372, 55)
        Me.VehicleType.TabIndex = 60
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(72, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 17)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(72, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 17)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Vehicle Type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(72, 351)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 17)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Parking Slot"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(72, 439)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 17)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "Time and Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(72, 525)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 17)
        Me.Label5.TabIndex = 65
        Me.Label5.Text = "Amount"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(72, 264)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 17)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "Plate Number"
        '
        'plate_number
        '
        Me.plate_number.Animated = True
        Me.plate_number.BorderColor = System.Drawing.Color.Gray
        Me.plate_number.BorderRadius = 5
        Me.plate_number.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.plate_number.DefaultText = ""
        Me.plate_number.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.plate_number.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.plate_number.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.plate_number.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.plate_number.Enabled = False
        Me.plate_number.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.plate_number.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!)
        Me.plate_number.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.plate_number.Location = New System.Drawing.Point(72, 283)
        Me.plate_number.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.plate_number.Name = "plate_number"
        Me.plate_number.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.plate_number.PlaceholderText = ""
        Me.plate_number.SelectedText = ""
        Me.plate_number.Size = New System.Drawing.Size(372, 55)
        Me.plate_number.TabIndex = 66
        '
        'Guna2Button3
        '
        Me.Guna2Button3.Animated = True
        Me.Guna2Button3.BorderRadius = 10
        Me.Guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button3.FillColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Guna2Button3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button3.ForeColor = System.Drawing.Color.Snow
        Me.Guna2Button3.Location = New System.Drawing.Point(100, 629)
        Me.Guna2Button3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.Size = New System.Drawing.Size(309, 59)
        Me.Guna2Button3.TabIndex = 69
        Me.Guna2Button3.Text = "Another Transaction"
        Me.Guna2Button3.Visible = False
        '
        'Confirmation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Billing_System.My.Resources.Resources.bgg1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(513, 693)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.plate_number)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.VehicleType)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.Guna2TextBox3)
        Me.Controls.Add(Me.Guna2TextBox4)
        Me.Controls.Add(Me.ParkingDetails)
        Me.Controls.Add(Me.Cname)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.Guna2Button3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Confirmation"
        Me.Text = "Confirmation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Cname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ParkingDetails As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBox3 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBox4 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents VehicleType As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents plate_number As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
End Class
