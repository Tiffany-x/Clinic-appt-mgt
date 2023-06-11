<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIParent2
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
        Me.components = New System.ComponentModel.Container()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PatientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookAppointmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewPatientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OldPatientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.FindAppointmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GeneratePatientReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerateDoctorsReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 431)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(632, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PatientToolStripMenuItem, Me.ReportsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PatientToolStripMenuItem
        '
        Me.PatientToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BookAppointmentToolStripMenuItem, Me.ToolStripMenuItem2, Me.FindAppointmentToolStripMenuItem})
        Me.PatientToolStripMenuItem.Name = "PatientToolStripMenuItem"
        Me.PatientToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.PatientToolStripMenuItem.Text = "Appointment"
        '
        'BookAppointmentToolStripMenuItem
        '
        Me.BookAppointmentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewPatientToolStripMenuItem, Me.OldPatientToolStripMenuItem})
        Me.BookAppointmentToolStripMenuItem.Name = "BookAppointmentToolStripMenuItem"
        Me.BookAppointmentToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.BookAppointmentToolStripMenuItem.Text = "Book Appointment"
        '
        'NewPatientToolStripMenuItem
        '
        Me.NewPatientToolStripMenuItem.Name = "NewPatientToolStripMenuItem"
        Me.NewPatientToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.NewPatientToolStripMenuItem.Text = "New Patient"
        '
        'OldPatientToolStripMenuItem
        '
        Me.OldPatientToolStripMenuItem.Name = "OldPatientToolStripMenuItem"
        Me.OldPatientToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.OldPatientToolStripMenuItem.Text = "Old Patient"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(172, 6)
        '
        'FindAppointmentToolStripMenuItem
        '
        Me.FindAppointmentToolStripMenuItem.Name = "FindAppointmentToolStripMenuItem"
        Me.FindAppointmentToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.FindAppointmentToolStripMenuItem.Text = "Find Appointment"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GeneratePatientReportToolStripMenuItem, Me.GenerateDoctorsReportToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'GeneratePatientReportToolStripMenuItem
        '
        Me.GeneratePatientReportToolStripMenuItem.Name = "GeneratePatientReportToolStripMenuItem"
        Me.GeneratePatientReportToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.GeneratePatientReportToolStripMenuItem.Text = "Generate Patients Report"
        '
        'GenerateDoctorsReportToolStripMenuItem
        '
        Me.GenerateDoctorsReportToolStripMenuItem.Name = "GenerateDoctorsReportToolStripMenuItem"
        Me.GenerateDoctorsReportToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.GenerateDoctorsReportToolStripMenuItem.Text = "Generate Doctor's Report"
        '
        'MDIParent2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PowderBlue
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.Name = "MDIParent2"
        Me.Text = "MDIParent2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PatientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BookAppointmentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewPatientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OldPatientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents FindAppointmentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GeneratePatientReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GenerateDoctorsReportToolStripMenuItem As ToolStripMenuItem
End Class
