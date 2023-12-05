<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Vehicle_category
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Vehicle_category))
        Me.bicycle = New System.Windows.Forms.Label()
        Me.Motor = New System.Windows.Forms.Label()
        Me.truck = New System.Windows.Forms.Label()
        Me.car = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'bicycle
        '
        Me.bicycle.AutoSize = True
        Me.bicycle.BackColor = System.Drawing.Color.Transparent
        Me.bicycle.Font = New System.Drawing.Font("Arial Rounded MT Bold", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bicycle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.bicycle.Location = New System.Drawing.Point(304, 60)
        Me.bicycle.Name = "bicycle"
        Me.bicycle.Size = New System.Drawing.Size(57, 38)
        Me.bicycle.TabIndex = 0
        Me.bicycle.Text = "10"
        '
        'Motor
        '
        Me.Motor.AutoSize = True
        Me.Motor.BackColor = System.Drawing.Color.Transparent
        Me.Motor.Font = New System.Drawing.Font("Arial Rounded MT Bold", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Motor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Motor.Location = New System.Drawing.Point(821, 62)
        Me.Motor.Name = "Motor"
        Me.Motor.Size = New System.Drawing.Size(57, 38)
        Me.Motor.TabIndex = 1
        Me.Motor.Text = "10"
        '
        'truck
        '
        Me.truck.AutoSize = True
        Me.truck.BackColor = System.Drawing.Color.Transparent
        Me.truck.Font = New System.Drawing.Font("Arial Rounded MT Bold", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.truck.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.truck.Location = New System.Drawing.Point(817, 401)
        Me.truck.Name = "truck"
        Me.truck.Size = New System.Drawing.Size(57, 38)
        Me.truck.TabIndex = 3
        Me.truck.Text = "10"
        '
        'car
        '
        Me.car.AutoSize = True
        Me.car.BackColor = System.Drawing.Color.Transparent
        Me.car.Font = New System.Drawing.Font("Arial Rounded MT Bold", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.car.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.car.Location = New System.Drawing.Point(300, 399)
        Me.car.Name = "car"
        Me.car.Size = New System.Drawing.Size(57, 38)
        Me.car.TabIndex = 2
        Me.car.Text = "10"
        '
        'Vehicle_category
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Billing_System.My.Resources.Resources.Web_Photo_Editor
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1046, 724)
        Me.Controls.Add(Me.truck)
        Me.Controls.Add(Me.car)
        Me.Controls.Add(Me.Motor)
        Me.Controls.Add(Me.bicycle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Vehicle_category"
        Me.Text = "Vehicle_category"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bicycle As Label
    Friend WithEvents Motor As Label
    Friend WithEvents truck As Label
    Friend WithEvents car As Label
End Class
