<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class booking
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNames = New System.Windows.Forms.TextBox()
        Me.txtmemNumber = New System.Windows.Forms.TextBox()
        Me.txtnoKin = New System.Windows.Forms.TextBox()
        Me.cmdSubmit = New System.Windows.Forms.Button()
        Me.txtnumPhone = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dateBirth = New System.Windows.Forms.DateTimePicker()
        Me.txtInsurance = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AccessibleName = ""
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Futura Bk BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(340, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(198, 22)
        Me.Label2.TabIndex = 3
        Me.Label2.Tag = ""
        Me.Label2.Text = "Enter Patient details"
        '
        'Label3
        '
        Me.Label3.AccessibleName = ""
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Futura Bk BT", 14.25!)
        Me.Label3.Location = New System.Drawing.Point(200, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 22)
        Me.Label3.TabIndex = 4
        Me.Label3.Tag = ""
        Me.Label3.Text = "Names:"
        '
        'Label4
        '
        Me.Label4.AccessibleName = ""
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Futura Bk BT", 14.25!)
        Me.Label4.Location = New System.Drawing.Point(200, 230)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(175, 22)
        Me.Label4.TabIndex = 5
        Me.Label4.Tag = ""
        Me.Label4.Text = "Insurance company"
        '
        'Label5
        '
        Me.Label5.AccessibleName = ""
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Futura Bk BT", 14.25!)
        Me.Label5.Location = New System.Drawing.Point(200, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(192, 22)
        Me.Label5.TabIndex = 6
        Me.Label5.Tag = ""
        Me.Label5.Text = "Membership number:"
        '
        'Label7
        '
        Me.Label7.AccessibleName = ""
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Futura Bk BT", 14.25!)
        Me.Label7.Location = New System.Drawing.Point(200, 310)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(140, 22)
        Me.Label7.TabIndex = 8
        Me.Label7.Tag = ""
        Me.Label7.Text = "Phone number:"
        '
        'Label8
        '
        Me.Label8.AccessibleName = ""
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Futura Bk BT", 14.25!)
        Me.Label8.Location = New System.Drawing.Point(200, 350)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 22)
        Me.Label8.TabIndex = 9
        Me.Label8.Tag = ""
        Me.Label8.Text = "Next of kin:"
        '
        'txtNames
        '
        Me.txtNames.AccessibleName = ""
        Me.txtNames.Font = New System.Drawing.Font("Futura Bk BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNames.Location = New System.Drawing.Point(410, 190)
        Me.txtNames.Name = "txtNames"
        Me.txtNames.Size = New System.Drawing.Size(277, 25)
        Me.txtNames.TabIndex = 10
        Me.txtNames.Tag = ""
        '
        'txtmemNumber
        '
        Me.txtmemNumber.AccessibleName = ""
        Me.txtmemNumber.Font = New System.Drawing.Font("Futura Bk BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmemNumber.Location = New System.Drawing.Point(409, 150)
        Me.txtmemNumber.Name = "txtmemNumber"
        Me.txtmemNumber.Size = New System.Drawing.Size(277, 25)
        Me.txtmemNumber.TabIndex = 1
        Me.txtmemNumber.Tag = ""
        '
        'txtnoKin
        '
        Me.txtnoKin.AccessibleName = ""
        Me.txtnoKin.Font = New System.Drawing.Font("Futura Bk BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnoKin.Location = New System.Drawing.Point(410, 350)
        Me.txtnoKin.Name = "txtnoKin"
        Me.txtnoKin.Size = New System.Drawing.Size(277, 25)
        Me.txtnoKin.TabIndex = 14
        Me.txtnoKin.Tag = ""
        '
        'cmdSubmit
        '
        Me.cmdSubmit.AccessibleName = ""
        Me.cmdSubmit.Font = New System.Drawing.Font("Futura Bk BT", 14.25!)
        Me.cmdSubmit.Location = New System.Drawing.Point(330, 400)
        Me.cmdSubmit.Name = "cmdSubmit"
        Me.cmdSubmit.Size = New System.Drawing.Size(227, 50)
        Me.cmdSubmit.TabIndex = 18
        Me.cmdSubmit.Tag = ""
        Me.cmdSubmit.Text = "Submit"
        Me.cmdSubmit.UseVisualStyleBackColor = True
        '
        'txtnumPhone
        '
        Me.txtnumPhone.AccessibleName = ""
        Me.txtnumPhone.AllowPromptAsInput = False
        Me.txtnumPhone.Font = New System.Drawing.Font("Futura Bk BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnumPhone.HidePromptOnLeave = True
        Me.txtnumPhone.Location = New System.Drawing.Point(410, 310)
        Me.txtnumPhone.Mask = "#############"
        Me.txtnumPhone.Name = "txtnumPhone"
        Me.txtnumPhone.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtnumPhone.Size = New System.Drawing.Size(277, 25)
        Me.txtnumPhone.TabIndex = 19
        Me.txtnumPhone.Tag = ""
        Me.txtnumPhone.Text = "+254"
        '
        'Label6
        '
        Me.Label6.AccessibleName = ""
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Futura Bk BT", 14.25!)
        Me.Label6.Location = New System.Drawing.Point(200, 270)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 22)
        Me.Label6.TabIndex = 7
        Me.Label6.Tag = ""
        Me.Label6.Text = "Date of birth:"
        '
        'dateBirth
        '
        Me.dateBirth.AccessibleName = ""
        Me.dateBirth.Font = New System.Drawing.Font("Futura Bk BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateBirth.Location = New System.Drawing.Point(410, 270)
        Me.dateBirth.Name = "dateBirth"
        Me.dateBirth.Size = New System.Drawing.Size(277, 25)
        Me.dateBirth.TabIndex = 15
        Me.dateBirth.Tag = ""
        '
        'txtInsurance
        '
        Me.txtInsurance.Font = New System.Drawing.Font("Futura Bk BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInsurance.FormattingEnabled = True
        Me.txtInsurance.Items.AddRange(New Object() {"AAR", "ICEA Lion Group", "Madison Insurance"})
        Me.txtInsurance.Location = New System.Drawing.Point(410, 230)
        Me.txtInsurance.Name = "txtInsurance"
        Me.txtInsurance.Size = New System.Drawing.Size(277, 26)
        Me.txtInsurance.TabIndex = 20
        '
        'booking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PowderBlue
        Me.ClientSize = New System.Drawing.Size(951, 544)
        Me.Controls.Add(Me.txtInsurance)
        Me.Controls.Add(Me.txtnumPhone)
        Me.Controls.Add(Me.cmdSubmit)
        Me.Controls.Add(Me.dateBirth)
        Me.Controls.Add(Me.txtnoKin)
        Me.Controls.Add(Me.txtmemNumber)
        Me.Controls.Add(Me.txtNames)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "booking"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Patient Details"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtnoKin As TextBox
    Friend WithEvents cmdSubmit As Button
    Friend WithEvents Label6 As Label
    Public WithEvents txtmemNumber As TextBox
    Friend WithEvents dateBirth As DateTimePicker
    Friend WithEvents txtInsurance As ComboBox
    Public WithEvents txtNames As TextBox
    Public WithEvents txtnumPhone As MaskedTextBox
End Class
