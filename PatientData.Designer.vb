<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatientData
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
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.txtmemNumber = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblDoctor = New System.Windows.Forms.Label()
        Me.lblService = New System.Windows.Forms.Label()
        Me.lblNames = New System.Windows.Forms.Label()
        Me.cmdHere = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdReschedule = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtAppt = New System.Windows.Forms.MonthCalendar()
        Me.lblID = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblTimeSlot = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdSearch
        '
        Me.cmdSearch.AccessibleName = ""
        Me.cmdSearch.Font = New System.Drawing.Font("Futura Bk BT", 14.25!)
        Me.cmdSearch.Location = New System.Drawing.Point(205, 468)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(150, 30)
        Me.cmdSearch.TabIndex = 28
        Me.cmdSearch.Tag = ""
        Me.cmdSearch.Text = "Search"
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'txtmemNumber
        '
        Me.txtmemNumber.AccessibleName = ""
        Me.txtmemNumber.Font = New System.Drawing.Font("Futura Bk BT", 14.25!)
        Me.txtmemNumber.Location = New System.Drawing.Point(254, 156)
        Me.txtmemNumber.Name = "txtmemNumber"
        Me.txtmemNumber.Size = New System.Drawing.Size(200, 30)
        Me.txtmemNumber.TabIndex = 27
        Me.txtmemNumber.Tag = ""
        '
        'Label5
        '
        Me.Label5.AccessibleName = ""
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Futura Bk BT", 14.25!)
        Me.Label5.Location = New System.Drawing.Point(54, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(192, 22)
        Me.Label5.TabIndex = 26
        Me.Label5.Tag = ""
        Me.Label5.Text = "Membership number:"
        '
        'Label10
        '
        Me.Label10.AccessibleName = ""
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Futura Bk BT", 14.25!)
        Me.Label10.Location = New System.Drawing.Point(601, 322)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(182, 22)
        Me.Label10.TabIndex = 31
        Me.Label10.Tag = ""
        Me.Label10.Text = "Attending physician:"
        '
        'Label1
        '
        Me.Label1.AccessibleName = ""
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Futura Bk BT", 14.25!)
        Me.Label1.Location = New System.Drawing.Point(601, 282)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 22)
        Me.Label1.TabIndex = 30
        Me.Label1.Tag = ""
        Me.Label1.Text = "Service being seeked:"
        '
        'Label3
        '
        Me.Label3.AccessibleName = ""
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Futura Bk BT", 14.25!)
        Me.Label3.Location = New System.Drawing.Point(601, 202)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 22)
        Me.Label3.TabIndex = 29
        Me.Label3.Tag = ""
        Me.Label3.Text = "Names:"
        '
        'Label9
        '
        Me.Label9.AccessibleName = ""
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Futura Bk BT", 14.25!)
        Me.Label9.Location = New System.Drawing.Point(601, 242)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(272, 22)
        Me.Label9.TabIndex = 32
        Me.Label9.Tag = ""
        Me.Label9.Text = "Date and time of appointment:"
        '
        'lblDate
        '
        Me.lblDate.AccessibleName = ""
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Futura Bk BT", 14.25!)
        Me.lblDate.Location = New System.Drawing.Point(921, 242)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(16, 22)
        Me.lblDate.TabIndex = 36
        Me.lblDate.Tag = ""
        Me.lblDate.Text = " "
        '
        'lblDoctor
        '
        Me.lblDoctor.AccessibleName = ""
        Me.lblDoctor.AutoSize = True
        Me.lblDoctor.Font = New System.Drawing.Font("Futura Bk BT", 14.25!)
        Me.lblDoctor.Location = New System.Drawing.Point(921, 322)
        Me.lblDoctor.Name = "lblDoctor"
        Me.lblDoctor.Size = New System.Drawing.Size(16, 22)
        Me.lblDoctor.TabIndex = 35
        Me.lblDoctor.Tag = ""
        Me.lblDoctor.Text = " "
        '
        'lblService
        '
        Me.lblService.AccessibleName = ""
        Me.lblService.AutoSize = True
        Me.lblService.Font = New System.Drawing.Font("Futura Bk BT", 14.25!)
        Me.lblService.Location = New System.Drawing.Point(921, 282)
        Me.lblService.Name = "lblService"
        Me.lblService.Size = New System.Drawing.Size(16, 22)
        Me.lblService.TabIndex = 34
        Me.lblService.Tag = ""
        Me.lblService.Text = " "
        '
        'lblNames
        '
        Me.lblNames.AccessibleName = ""
        Me.lblNames.AutoSize = True
        Me.lblNames.Font = New System.Drawing.Font("Futura Bk BT", 14.25!)
        Me.lblNames.Location = New System.Drawing.Point(921, 202)
        Me.lblNames.Name = "lblNames"
        Me.lblNames.Size = New System.Drawing.Size(16, 22)
        Me.lblNames.TabIndex = 33
        Me.lblNames.Tag = ""
        Me.lblNames.Text = " "
        '
        'cmdHere
        '
        Me.cmdHere.AccessibleName = ""
        Me.cmdHere.Font = New System.Drawing.Font("Futura Bk BT", 14.25!)
        Me.cmdHere.Location = New System.Drawing.Point(717, 494)
        Me.cmdHere.Name = "cmdHere"
        Me.cmdHere.Size = New System.Drawing.Size(237, 30)
        Me.cmdHere.TabIndex = 37
        Me.cmdHere.Tag = ""
        Me.cmdHere.Text = "Here for the appointment"
        Me.cmdHere.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.AccessibleName = ""
        Me.cmdCancel.Font = New System.Drawing.Font("Futura Bk BT", 14.25!)
        Me.cmdCancel.Location = New System.Drawing.Point(605, 425)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(150, 30)
        Me.cmdCancel.TabIndex = 38
        Me.cmdCancel.Tag = ""
        Me.cmdCancel.Text = "Cancel appointment"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdReschedule
        '
        Me.cmdReschedule.AccessibleName = ""
        Me.cmdReschedule.Font = New System.Drawing.Font("Futura Bk BT", 14.25!)
        Me.cmdReschedule.Location = New System.Drawing.Point(908, 425)
        Me.cmdReschedule.Name = "cmdReschedule"
        Me.cmdReschedule.Size = New System.Drawing.Size(150, 30)
        Me.cmdReschedule.TabIndex = 39
        Me.cmdReschedule.Tag = ""
        Me.cmdReschedule.Text = "Reschedule"
        Me.cmdReschedule.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AccessibleName = ""
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Futura Bk BT", 14.25!)
        Me.Label2.Location = New System.Drawing.Point(601, 362)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 22)
        Me.Label2.TabIndex = 40
        Me.Label2.Tag = ""
        Me.Label2.Text = "Phone number:"
        '
        'lblNumber
        '
        Me.lblNumber.AccessibleName = ""
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Font = New System.Drawing.Font("Futura Bk BT", 14.25!)
        Me.lblNumber.Location = New System.Drawing.Point(921, 362)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(16, 22)
        Me.lblNumber.TabIndex = 41
        Me.lblNumber.Tag = ""
        Me.lblNumber.Text = " "
        '
        'Label4
        '
        Me.Label4.AccessibleName = ""
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Futura Bk BT", 14.25!)
        Me.Label4.Location = New System.Drawing.Point(54, 236)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 22)
        Me.Label4.TabIndex = 43
        Me.Label4.Tag = ""
        Me.Label4.Text = "Date:"
        '
        'dtAppt
        '
        Me.dtAppt.Location = New System.Drawing.Point(254, 236)
        Me.dtAppt.Name = "dtAppt"
        Me.dtAppt.ShowToday = False
        Me.dtAppt.TabIndex = 44
        '
        'lblID
        '
        Me.lblID.AccessibleName = ""
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Futura Bk BT", 14.25!)
        Me.lblID.Location = New System.Drawing.Point(921, 159)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(16, 22)
        Me.lblID.TabIndex = 46
        Me.lblID.Tag = ""
        Me.lblID.Text = " "
        '
        'Label7
        '
        Me.Label7.AccessibleName = ""
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Futura Bk BT", 14.25!)
        Me.Label7.Location = New System.Drawing.Point(601, 159)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(143, 22)
        Me.Label7.TabIndex = 45
        Me.Label7.Tag = ""
        Me.Label7.Text = "AppointmentID:"
        '
        'lblTimeSlot
        '
        Me.lblTimeSlot.AccessibleName = ""
        Me.lblTimeSlot.AutoSize = True
        Me.lblTimeSlot.Font = New System.Drawing.Font("Futura Bk BT", 14.25!)
        Me.lblTimeSlot.Location = New System.Drawing.Point(1156, 168)
        Me.lblTimeSlot.Name = "lblTimeSlot"
        Me.lblTimeSlot.Size = New System.Drawing.Size(16, 22)
        Me.lblTimeSlot.TabIndex = 47
        Me.lblTimeSlot.Tag = ""
        Me.lblTimeSlot.Text = " "
        '
        'Label6
        '
        Me.Label6.AccessibleName = ""
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Futura Bk BT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(413, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(215, 25)
        Me.Label6.TabIndex = 48
        Me.Label6.Tag = ""
        Me.Label6.Text = "Appointment Search"
        '
        'PatientData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PowderBlue
        Me.ClientSize = New System.Drawing.Size(1370, 634)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblTimeSlot)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dtAppt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblNumber)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdReschedule)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdHere)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblDoctor)
        Me.Controls.Add(Me.lblService)
        Me.Controls.Add(Me.lblNames)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmdSearch)
        Me.Controls.Add(Me.txtmemNumber)
        Me.Controls.Add(Me.Label5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "PatientData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Appointment Details"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdSearch As Button
    Public WithEvents txtmemNumber As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblDoctor As Label
    Friend WithEvents lblService As Label
    Friend WithEvents lblNames As Label
    Friend WithEvents cmdHere As Button
    Friend WithEvents cmdCancel As Button
    Friend WithEvents cmdReschedule As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblNumber As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtAppt As MonthCalendar
    Friend WithEvents lblID As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblTimeSlot As Label
    Friend WithEvents Label6 As Label
End Class
