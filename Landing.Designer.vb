<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.cmdAppointment = New System.Windows.Forms.Button()
        Me.cmdBooking = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdAppointment
        '
        Me.cmdAppointment.Location = New System.Drawing.Point(162, 285)
        Me.cmdAppointment.Name = "cmdAppointment"
        Me.cmdAppointment.Size = New System.Drawing.Size(200, 30)
        Me.cmdAppointment.TabIndex = 0
        Me.cmdAppointment.Text = "Here for an appointment"
        Me.cmdAppointment.UseVisualStyleBackColor = True
        '
        'cmdBooking
        '
        Me.cmdBooking.Location = New System.Drawing.Point(439, 285)
        Me.cmdBooking.Name = "cmdBooking"
        Me.cmdBooking.Size = New System.Drawing.Size(200, 30)
        Me.cmdBooking.TabIndex = 1
        Me.cmdBooking.Text = "Booking an appointment"
        Me.cmdBooking.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmdBooking)
        Me.Controls.Add(Me.cmdAppointment)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdAppointment As Button
    Friend WithEvents cmdBooking As Button
End Class
