<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Land
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmdAttending = New System.Windows.Forms.Button()
        Me.cmdBooking = New System.Windows.Forms.Button()
        Me.InsuranceComps = New System.Windows.Forms.Button()
        Me.cmdDocSchedules = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdAttending
        '
        Me.cmdAttending.Location = New System.Drawing.Point(132, 79)
        Me.cmdAttending.Name = "cmdAttending"
        Me.cmdAttending.Size = New System.Drawing.Size(200, 50)
        Me.cmdAttending.TabIndex = 0
        Me.cmdAttending.Text = "Find an appointment"
        Me.cmdAttending.UseVisualStyleBackColor = True
        '
        'cmdBooking
        '
        Me.cmdBooking.Location = New System.Drawing.Point(475, 79)
        Me.cmdBooking.Name = "cmdBooking"
        Me.cmdBooking.Size = New System.Drawing.Size(200, 50)
        Me.cmdBooking.TabIndex = 1
        Me.cmdBooking.Text = "Booking an appointment"
        Me.cmdBooking.UseVisualStyleBackColor = True
        '
        'InsuranceComps
        '
        Me.InsuranceComps.Location = New System.Drawing.Point(472, 200)
        Me.InsuranceComps.Name = "InsuranceComps"
        Me.InsuranceComps.Size = New System.Drawing.Size(200, 50)
        Me.InsuranceComps.TabIndex = 3
        Me.InsuranceComps.Text = "Insurance Companies"
        Me.InsuranceComps.UseVisualStyleBackColor = True
        '
        'cmdDocSchedules
        '
        Me.cmdDocSchedules.Location = New System.Drawing.Point(129, 200)
        Me.cmdDocSchedules.Name = "cmdDocSchedules"
        Me.cmdDocSchedules.Size = New System.Drawing.Size(200, 50)
        Me.cmdDocSchedules.TabIndex = 2
        Me.cmdDocSchedules.Text = "Doctor Schedules"
        Me.cmdDocSchedules.UseVisualStyleBackColor = True
        '
        'Land
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PowderBlue
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.InsuranceComps)
        Me.Controls.Add(Me.cmdDocSchedules)
        Me.Controls.Add(Me.cmdBooking)
        Me.Controls.Add(Me.cmdAttending)
        Me.Name = "Land"
        Me.Text = "Appointment Management System"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdAttending As Button
    Friend WithEvents cmdBooking As Button
    Friend WithEvents InsuranceComps As Button
    Friend WithEvents cmdDocSchedules As Button
End Class
