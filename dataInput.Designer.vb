<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dataInput
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
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblNames = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.txtmemNumber = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtService = New System.Windows.Forms.TextBox()
        Me.ClinicProjectMDBDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClinicProjectMDBDataSet = New Final_project.ClinicProjectMDBDataSet()
        Me.ClinicProjectMDBDataSet1 = New Final_project.ClinicProjectMDBDataSet1()
        Me.DoctorScheduleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DoctorScheduleTableAdapter = New Final_project.ClinicProjectMDBDataSet1TableAdapters.DoctorScheduleTableAdapter()
        Me.DGrid = New System.Windows.Forms.DataGridView()
        Me.ClinicProjectMDBDataSet2 = New Final_project.ClinicProjectMDBDataSet()
        Me.doctorSearch = New System.Windows.Forms.Button()
        Me.dtAppointment = New System.Windows.Forms.MonthCalendar()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lstDoctor = New System.Windows.Forms.ComboBox()
        Me.lstTime = New System.Windows.Forms.ComboBox()
        Me.cmdBack = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.ClinicProjectMDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClinicProjectMDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClinicProjectMDBDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DoctorScheduleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClinicProjectMDBDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNumber
        '
        Me.lblNumber.AccessibleName = ""
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Font = New System.Drawing.Font("Futura Bk BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumber.Location = New System.Drawing.Point(237, 231)
        Me.lblNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(16, 22)
        Me.lblNumber.TabIndex = 54
        Me.lblNumber.Tag = ""
        Me.lblNumber.Text = " "
        '
        'Label2
        '
        Me.Label2.AccessibleName = ""
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Futura Bk BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(86, 231)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 22)
        Me.Label2.TabIndex = 53
        Me.Label2.Tag = ""
        Me.Label2.Text = "Phone number:"
        '
        'lblNames
        '
        Me.lblNames.AccessibleName = ""
        Me.lblNames.AutoSize = True
        Me.lblNames.Font = New System.Drawing.Font("Futura Bk BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNames.Location = New System.Drawing.Point(237, 194)
        Me.lblNames.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNames.Name = "lblNames"
        Me.lblNames.Size = New System.Drawing.Size(16, 22)
        Me.lblNames.TabIndex = 49
        Me.lblNames.Tag = ""
        Me.lblNames.Text = " "
        '
        'Label9
        '
        Me.Label9.AccessibleName = ""
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Futura Bk BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(438, 231)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(191, 22)
        Me.Label9.TabIndex = 48
        Me.Label9.Tag = ""
        Me.Label9.Text = "Date of appointment:"
        '
        'Label1
        '
        Me.Label1.AccessibleName = ""
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Futura Bk BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(440, 189)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 22)
        Me.Label1.TabIndex = 46
        Me.Label1.Tag = ""
        Me.Label1.Text = "Service being seeked:"
        '
        'Label3
        '
        Me.Label3.AccessibleName = ""
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Futura Bk BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(85, 194)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 22)
        Me.Label3.TabIndex = 45
        Me.Label3.Tag = ""
        Me.Label3.Text = "Names:"
        '
        'cmdSearch
        '
        Me.cmdSearch.AccessibleName = ""
        Me.cmdSearch.Font = New System.Drawing.Font("Futura Bk BT", 14.25!)
        Me.cmdSearch.Location = New System.Drawing.Point(795, 109)
        Me.cmdSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(116, 37)
        Me.cmdSearch.TabIndex = 44
        Me.cmdSearch.Tag = ""
        Me.cmdSearch.Text = "Search"
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'txtmemNumber
        '
        Me.txtmemNumber.AccessibleName = ""
        Me.txtmemNumber.Location = New System.Drawing.Point(503, 112)
        Me.txtmemNumber.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtmemNumber.Name = "txtmemNumber"
        Me.txtmemNumber.Size = New System.Drawing.Size(232, 23)
        Me.txtmemNumber.TabIndex = 43
        Me.txtmemNumber.Tag = ""
        '
        'Label5
        '
        Me.Label5.AccessibleName = ""
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Futura Bk BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(270, 120)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(192, 22)
        Me.Label5.TabIndex = 42
        Me.Label5.Tag = ""
        Me.Label5.Text = "Membership number:"
        '
        'Button1
        '
        Me.Button1.AccessibleName = ""
        Me.Button1.Font = New System.Drawing.Font("Futura Bk BT", 14.25!)
        Me.Button1.Location = New System.Drawing.Point(503, 627)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(182, 37)
        Me.Button1.TabIndex = 60
        Me.Button1.Tag = ""
        Me.Button1.Text = "Book Appointment"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtService
        '
        Me.txtService.AccessibleName = ""
        Me.txtService.Location = New System.Drawing.Point(634, 181)
        Me.txtService.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtService.Name = "txtService"
        Me.txtService.Size = New System.Drawing.Size(232, 23)
        Me.txtService.TabIndex = 61
        Me.txtService.Tag = ""
        '
        'ClinicProjectMDBDataSetBindingSource
        '
        Me.ClinicProjectMDBDataSetBindingSource.DataSource = Me.ClinicProjectMDBDataSet
        Me.ClinicProjectMDBDataSetBindingSource.Position = 0
        '
        'ClinicProjectMDBDataSet
        '
        Me.ClinicProjectMDBDataSet.DataSetName = "ClinicProjectMDBDataSet"
        Me.ClinicProjectMDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClinicProjectMDBDataSet1
        '
        Me.ClinicProjectMDBDataSet1.DataSetName = "ClinicProjectMDBDataSet1"
        Me.ClinicProjectMDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DoctorScheduleBindingSource
        '
        Me.DoctorScheduleBindingSource.DataMember = "DoctorSchedule"
        Me.DoctorScheduleBindingSource.DataSource = Me.ClinicProjectMDBDataSet1
        '
        'DoctorScheduleTableAdapter
        '
        Me.DoctorScheduleTableAdapter.ClearBeforeFill = True
        '
        'DGrid
        '
        Me.DGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGrid.Location = New System.Drawing.Point(94, 445)
        Me.DGrid.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DGrid.Name = "DGrid"
        Me.DGrid.Size = New System.Drawing.Size(893, 137)
        Me.DGrid.TabIndex = 67
        '
        'ClinicProjectMDBDataSet2
        '
        Me.ClinicProjectMDBDataSet2.DataSetName = "ClinicProjectMDBDataSet"
        Me.ClinicProjectMDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'doctorSearch
        '
        Me.doctorSearch.AccessibleName = ""
        Me.doctorSearch.Font = New System.Drawing.Font("Futura Bk BT", 14.25!)
        Me.doctorSearch.Location = New System.Drawing.Point(899, 272)
        Me.doctorSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.doctorSearch.Name = "doctorSearch"
        Me.doctorSearch.Size = New System.Drawing.Size(165, 37)
        Me.doctorSearch.TabIndex = 63
        Me.doctorSearch.Tag = ""
        Me.doctorSearch.Text = "Load Schedule"
        Me.doctorSearch.UseVisualStyleBackColor = True
        '
        'dtAppointment
        '
        Me.dtAppointment.Location = New System.Drawing.Point(639, 231)
        Me.dtAppointment.Margin = New System.Windows.Forms.Padding(11, 11, 11, 11)
        Me.dtAppointment.MaxSelectionCount = 1
        Me.dtAppointment.Name = "dtAppointment"
        Me.dtAppointment.ShowToday = False
        Me.dtAppointment.TabIndex = 69
        '
        'Label4
        '
        Me.Label4.AccessibleName = ""
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Futura Bk BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(86, 299)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 22)
        Me.Label4.TabIndex = 70
        Me.Label4.Tag = ""
        Me.Label4.Text = "Doctor:"
        '
        'Label6
        '
        Me.Label6.AccessibleName = ""
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Futura Bk BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(86, 360)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 22)
        Me.Label6.TabIndex = 71
        Me.Label6.Tag = ""
        Me.Label6.Text = "Time slot:"
        '
        'lstDoctor
        '
        Me.lstDoctor.FormattingEnabled = True
        Me.lstDoctor.Items.AddRange(New Object() {"Dr. Frank", "Dr. John", "Dr. Mary"})
        Me.lstDoctor.Location = New System.Drawing.Point(237, 299)
        Me.lstDoctor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstDoctor.Name = "lstDoctor"
        Me.lstDoctor.Size = New System.Drawing.Size(141, 24)
        Me.lstDoctor.Sorted = True
        Me.lstDoctor.TabIndex = 72
        '
        'lstTime
        '
        Me.lstTime.FormattingEnabled = True
        Me.lstTime.Items.AddRange(New Object() {"08:00", "10:00", "13:00", "15:00"})
        Me.lstTime.Location = New System.Drawing.Point(237, 357)
        Me.lstTime.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstTime.Name = "lstTime"
        Me.lstTime.Size = New System.Drawing.Size(141, 24)
        Me.lstTime.TabIndex = 73
        '
        'cmdBack
        '
        Me.cmdBack.Location = New System.Drawing.Point(88, 50)
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.Size = New System.Drawing.Size(170, 23)
        Me.cmdBack.TabIndex = 74
        Me.cmdBack.Text = "Back to patient info input"
        Me.cmdBack.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AccessibleName = ""
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Futura Bk BT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(448, 46)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(229, 25)
        Me.Label7.TabIndex = 75
        Me.Label7.Tag = ""
        Me.Label7.Text = "Appointment Booking"
        '
        'dataInput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PowderBlue
        Me.ClientSize = New System.Drawing.Size(1090, 749)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmdBack)
        Me.Controls.Add(Me.lstTime)
        Me.Controls.Add(Me.lstDoctor)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtAppointment)
        Me.Controls.Add(Me.DGrid)
        Me.Controls.Add(Me.doctorSearch)
        Me.Controls.Add(Me.txtService)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblNumber)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblNames)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmdSearch)
        Me.Controls.Add(Me.txtmemNumber)
        Me.Controls.Add(Me.Label5)
        Me.Font = New System.Drawing.Font("Futura Bk BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "dataInput"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Appointment Booking"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ClinicProjectMDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClinicProjectMDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClinicProjectMDBDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DoctorScheduleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClinicProjectMDBDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmdSearch As Button
    Public WithEvents txtmemNumber As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Public WithEvents txtService As TextBox
    Friend WithEvents ClinicProjectMDBDataSetBindingSource As BindingSource
    Friend WithEvents ClinicProjectMDBDataSet As ClinicProjectMDBDataSet
    Friend WithEvents ClinicProjectMDBDataSet1 As ClinicProjectMDBDataSet1
    Friend WithEvents DoctorScheduleBindingSource As BindingSource
    Friend WithEvents DoctorScheduleTableAdapter As ClinicProjectMDBDataSet1TableAdapters.DoctorScheduleTableAdapter
    Friend WithEvents DGrid As DataGridView
    Friend WithEvents ClinicProjectMDBDataSet2 As ClinicProjectMDBDataSet
    Public WithEvents lblNumber As Label
    Public WithEvents lblNames As Label
    Friend WithEvents doctorSearch As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lstDoctor As ComboBox
    Friend WithEvents lstTime As ComboBox
    Public WithEvents dtAppointment As MonthCalendar
    Friend WithEvents cmdBack As Button
    Friend WithEvents Label7 As Label
End Class
