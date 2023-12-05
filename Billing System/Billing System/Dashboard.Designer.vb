<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.available_categories = New System.Windows.Forms.Label()
        Me.vehicles_parked = New System.Windows.Forms.Label()
        Me.parking_slots = New System.Windows.Forms.Label()
        Me.total_recors = New System.Windows.Forms.Label()
        Me.total_earnings = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'available_categories
        '
        Me.available_categories.AutoSize = True
        Me.available_categories.BackColor = System.Drawing.Color.Transparent
        Me.available_categories.Font = New System.Drawing.Font("Arial Rounded MT Bold", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.available_categories.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.available_categories.Location = New System.Drawing.Point(589, 78)
        Me.available_categories.Name = "available_categories"
        Me.available_categories.Size = New System.Drawing.Size(55, 58)
        Me.available_categories.TabIndex = 1
        Me.available_categories.Text = "4"
        '
        'vehicles_parked
        '
        Me.vehicles_parked.AutoSize = True
        Me.vehicles_parked.BackColor = System.Drawing.Color.Transparent
        Me.vehicles_parked.Font = New System.Drawing.Font("Arial Rounded MT Bold", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vehicles_parked.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.vehicles_parked.Location = New System.Drawing.Point(99, 78)
        Me.vehicles_parked.Name = "vehicles_parked"
        Me.vehicles_parked.Size = New System.Drawing.Size(85, 58)
        Me.vehicles_parked.TabIndex = 2
        Me.vehicles_parked.Text = "10"
        '
        'parking_slots
        '
        Me.parking_slots.AutoSize = True
        Me.parking_slots.BackColor = System.Drawing.Color.Transparent
        Me.parking_slots.Font = New System.Drawing.Font("Arial Rounded MT Bold", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.parking_slots.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.parking_slots.Location = New System.Drawing.Point(99, 302)
        Me.parking_slots.Name = "parking_slots"
        Me.parking_slots.Size = New System.Drawing.Size(85, 58)
        Me.parking_slots.TabIndex = 4
        Me.parking_slots.Text = "60"
        '
        'total_recors
        '
        Me.total_recors.AutoSize = True
        Me.total_recors.BackColor = System.Drawing.Color.Transparent
        Me.total_recors.Font = New System.Drawing.Font("Arial Rounded MT Bold", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_recors.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.total_recors.Location = New System.Drawing.Point(589, 302)
        Me.total_recors.Name = "total_recors"
        Me.total_recors.Size = New System.Drawing.Size(85, 58)
        Me.total_recors.TabIndex = 3
        Me.total_recors.Text = "10"
        '
        'total_earnings
        '
        Me.total_earnings.AutoSize = True
        Me.total_earnings.BackColor = System.Drawing.Color.Transparent
        Me.total_earnings.Font = New System.Drawing.Font("Arial Rounded MT Bold", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_earnings.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.total_earnings.Location = New System.Drawing.Point(343, 547)
        Me.total_earnings.Name = "total_earnings"
        Me.total_earnings.Size = New System.Drawing.Size(85, 58)
        Me.total_earnings.TabIndex = 5
        Me.total_earnings.Text = "10"
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BackgroundImage = Global.Billing_System.My.Resources.Resources.Untitled_Project__7_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1046, 724)
        Me.Controls.Add(Me.total_earnings)
        Me.Controls.Add(Me.parking_slots)
        Me.Controls.Add(Me.total_recors)
        Me.Controls.Add(Me.vehicles_parked)
        Me.Controls.Add(Me.available_categories)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Dashboard"
        Me.Text = "Dashboard"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents available_categories As Label
    Friend WithEvents vehicles_parked As Label
    Friend WithEvents parking_slots As Label
    Friend WithEvents total_recors As Label
    Friend WithEvents total_earnings As Label
End Class
