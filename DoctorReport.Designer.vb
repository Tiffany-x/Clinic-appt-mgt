<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DoctorReport
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.reportDate = New System.Windows.Forms.MonthCalendar()
        Me.cmdGenerate = New System.Windows.Forms.Button()
        Me.DGReport = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DGReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Futura Bk BT", 12.25!)
        Me.Label1.Location = New System.Drawing.Point(362, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(435, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select the date from which you want to generate a report:"
        '
        'reportDate
        '
        Me.reportDate.Location = New System.Drawing.Point(447, 198)
        Me.reportDate.Name = "reportDate"
        Me.reportDate.ShowToday = False
        Me.reportDate.TabIndex = 1
        '
        'cmdGenerate
        '
        Me.cmdGenerate.Font = New System.Drawing.Font("Futura Bk BT", 12.25!)
        Me.cmdGenerate.Location = New System.Drawing.Point(503, 372)
        Me.cmdGenerate.Name = "cmdGenerate"
        Me.cmdGenerate.Size = New System.Drawing.Size(150, 30)
        Me.cmdGenerate.TabIndex = 2
        Me.cmdGenerate.Text = "Generate"
        Me.cmdGenerate.UseVisualStyleBackColor = True
        '
        'DGReport
        '
        Me.DGReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGReport.BackgroundColor = System.Drawing.Color.White
        Me.DGReport.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Futura Bk BT", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGReport.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Futura Bk BT", 10.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGReport.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGReport.Location = New System.Drawing.Point(180, 174)
        Me.DGReport.Name = "DGReport"
        Me.DGReport.Size = New System.Drawing.Size(952, 150)
        Me.DGReport.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Futura Bk BT", 16.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(499, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 26)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Doctors' report"
        '
        'DoctorReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1335, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DGReport)
        Me.Controls.Add(Me.cmdGenerate)
        Me.Controls.Add(Me.reportDate)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "DoctorReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "DoctorReport"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DGReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents reportDate As MonthCalendar
    Friend WithEvents cmdGenerate As Button
    Friend WithEvents DGReport As DataGridView
    Friend WithEvents Label2 As Label
End Class
