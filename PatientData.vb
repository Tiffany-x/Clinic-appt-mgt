Imports System.Data.OleDb

Public Class PatientData
    Dim apptid As Integer
    Dim pro As String
    Dim conString As String
    Dim command As String
    Dim myconnection As OleDbConnection = New OleDbConnection
    Dim da As New OleDbDataAdapter
    Dim con As New OleDbConnection
    Dim dt As New DataTable
    Dim dr As OleDbDataReader
    Dim Qry As String
    Dim cmd As OleDbCommand
    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        If txtmemNumber.Text = "" Then
            MsgBox("Please enter the patient's membership number.")
        Else
            conString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\Users\hp\Desktop\School Stuff\Jan 23\MIS-312 Visual basic\ClinicProjectMDB.accdb'"
            myconnection.ConnectionString = conString
            myconnection.Open()

            Dim dateof As Date = dtAppt.SelectionRange.Start.ToShortDateString

            Qry = "select * from PatientHistory WHERE [MembershipNumber]='" & txtmemNumber.Text & "' AND [AppointmentDate]='" & dateof & "'"
            cmd = New OleDbCommand(Qry, myconnection)
            cmd.ExecuteNonQuery()
            dr = cmd.ExecuteReader
            If dr.Read Then
                lblID.Text = dr("AppointmentID")
                lblNames.Text = dr("PatientName")
                lblDate.Text = dr("AppointmentDate")
                lblTimeSlot.Text = dr("TimeSlot")
                lblService.Text = dr("ServiceSeeked")
                lblDoctor.Text = dr("DoctorAttended")

            Else
                MsgBox("Record not found",, "Search")
            End If

            Qry = "select * from PatientData WHERE MembershipNumber='" & txtmemNumber.Text & "'"
            cmd = New OleDbCommand(Qry, myconnection)
            cmd.ExecuteNonQuery()
            dr = cmd.ExecuteReader
            If dr.Read Then
                lblNumber.Text = dr("PhoneNumber")

            Else
                MsgBox("Appointment not found",, "Search")
            End If
            myconnection.Close()
        End If
    End Sub

    Private Sub cmdHere_Click(sender As Object, e As EventArgs) Handles cmdHere.Click
        conString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\Users\hp\Desktop\School Stuff\Jan 23\MIS-312 Visual basic\ClinicProjectMDB.accdb'"
        myconnection.ConnectionString = conString
        myconnection.Open()

        Dim commandText As String
        Dim cmd As OleDbCommand

        If lblTimeSlot.Text = "8:00" Then

            commandText = "UPDATE DoctorSchedule SET [8:00] = '""' WHERE DateOf = @Day AND docName = @name"
            cmd = New OleDbCommand(commandText, myconnection)
            cmd.Parameters.AddWithValue("@ApptID", "")
            cmd.Parameters.AddWithValue("@DateOf", dtAppt.SelectionRange.Start.ToShortDateString)
            cmd.Parameters.AddWithValue("@docName", Name)
            Try
                cmd.ExecuteNonQuery() 'Executing Update Command
            Catch ex As Exception
                MessageBox.Show(ex.Message) 'Error MEssage
            End Try
        ElseIf lblTimeSlot.Text = "10:00" Then
            commandText = "UPDATE DoctorSchedule SET [10:00] = '""' WHERE DateOf = @Day AND docName = @name"
            cmd = New OleDbCommand(commandText, myconnection)
            cmd.Parameters.AddWithValue("@ApptID", "")
            cmd.Parameters.AddWithValue("@DateOf", dtAppt.SelectionRange.Start.ToShortDateString)
            cmd.Parameters.AddWithValue("@docName", Name)
            Try
                cmd.ExecuteNonQuery() 'Executing Update Command
            Catch ex As Exception
                MessageBox.Show(ex.Message) 'Error MEssage
            End Try
        ElseIf lblTimeSlot.Text = "13:00" Then
            commandText = "UPDATE DoctorSchedule SET [13:00] = '""' WHERE DateOf = @Day AND docName = @name"
            cmd = New OleDbCommand(commandText, myconnection)
            cmd.Parameters.AddWithValue("@ApptID", "")
            cmd.Parameters.AddWithValue("@DateOf", dtAppt.SelectionRange.Start.ToShortDateString)
            cmd.Parameters.AddWithValue("@docName", Name)
            Try
                cmd.ExecuteNonQuery() 'Executing Update Command
            Catch ex As Exception
                MessageBox.Show(ex.Message) 'Error MEssage
            End Try
        Else
            commandText = "UPDATE DoctorSchedule SET [15:00] = '""' WHERE DateOf = @Day AND docName = @name"
            cmd = New OleDbCommand(commandText, myconnection)
            cmd.Parameters.AddWithValue("@ApptID", "")
            cmd.Parameters.AddWithValue("@DateOf", dtAppt.SelectionRange.Start.ToShortDateString)
            cmd.Parameters.AddWithValue("@docName", Name)
            Try
                cmd.ExecuteNonQuery() 'Executing Update Command
            Catch ex As Exception
                MessageBox.Show(ex.Message) 'Error MEssage
            End Try
        End If


        MsgBox("Time slot has been cleared.")

        myconnection.Close()
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        conString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\Users\hp\Desktop\School Stuff\Jan 23\MIS-312 Visual basic\ClinicProjectMDB.accdb'"
        myconnection.ConnectionString = conString
        myconnection.Open()
        Dim commandText As String
        Dim cmd As OleDbCommand

        If lblTimeSlot.Text = "8:00" Then

            commandText = "UPDATE DoctorSchedule SET [8:00] = '""' WHERE DateOf = @Day AND docName = @name"
            cmd = New OleDbCommand(commandText, myconnection)
            cmd.Parameters.AddWithValue("@ApptID", "")
            cmd.Parameters.AddWithValue("@DateOf", dtAppt.SelectionRange.Start.ToShortDateString)
            cmd.Parameters.AddWithValue("@docName", Name)
            Try
                cmd.ExecuteNonQuery() 'Executing Update Command
            Catch ex As Exception
                MessageBox.Show("This is an error in updating", ex.Message) 'Error MEssage
            End Try
        ElseIf lblTimeSlot.Text = "10:00" Then
            commandText = "UPDATE DoctorSchedule SET [10:00] = '""' WHERE DateOf = @Day AND docName = @name"
            cmd = New OleDbCommand(commandText, myconnection)
            cmd.Parameters.AddWithValue("@ApptID", "")
            cmd.Parameters.AddWithValue("@DateOf", dtAppt.SelectionRange.Start.ToShortDateString)
            cmd.Parameters.AddWithValue("@docName", Name)
            Try
                cmd.ExecuteNonQuery() 'Executing Update Command
            Catch ex As Exception
                MessageBox.Show(ex.Message) 'Error MEssage
            End Try
        ElseIf lblTimeSlot.Text = "13:00" Then
            commandText = "UPDATE DoctorSchedule SET [13:00] = '""' WHERE DateOf = @Day AND docName = @name"
            cmd = New OleDbCommand(commandText, myconnection)
            cmd.Parameters.AddWithValue("@ApptID", "")
            cmd.Parameters.AddWithValue("@DateOf", dtAppt.SelectionRange.Start.ToShortDateString)
            cmd.Parameters.AddWithValue("@docName", Name)
            Try
                cmd.ExecuteNonQuery() 'Executing Update Command
            Catch ex As Exception
                MessageBox.Show(ex.Message) 'Error MEssage
            End Try
        Else
            commandText = "UPDATE DoctorSchedule SET [15:00] = '""' WHERE DateOf = @Day AND docName = @name"
            cmd = New OleDbCommand(commandText, myconnection)
            cmd.Parameters.AddWithValue("@ApptID", "")
            cmd.Parameters.AddWithValue("@DateOf", dtAppt.SelectionRange.Start.ToShortDateString)
            cmd.Parameters.AddWithValue("@docName", Name)
            Try
                cmd.ExecuteNonQuery() 'Executing Update Command
            Catch ex As Exception
                MessageBox.Show(ex.Message) 'Error MEssage
            End Try
        End If


        Dim command2 As String = "DELETE * FROM PatientHistory WHERE [AppointmentID] = ?"
        cmd = New OleDbCommand(command2, myconnection)
        cmd.Parameters.AddWithValue("?", lblID.Text)
        Try
            cmd.ExecuteNonQuery() 'Executing Update Command
        Catch ex As Exception
            MessageBox.Show("this is an error in deletion", ex.Message) 'Error MEssage
        End Try

        lblID.Text = ""
        lblNames.Text = ""
        lblDate.Text = ""
        lblTimeSlot.Text = ""
        lblService.Text = ""
        lblDoctor.Text = ""
        lblNumber.Text = ""
        myconnection.Close()
    End Sub

    Private Sub cmdReschedule_Click(sender As Object, e As EventArgs) Handles cmdReschedule.Click
        conString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\Users\hp\Desktop\School Stuff\Jan 23\MIS-312 Visual basic\ClinicProjectMDB.accdb'"
        myconnection.ConnectionString = conString
        myconnection.Open()
        Dim commandText As String
        Dim cmd As OleDbCommand

        If lblTimeSlot.Text = "8:00" Then

            commandText = "UPDATE DoctorSchedule SET [8:00] = '""' WHERE DateOf = @Day AND docName = @name"
            cmd = New OleDbCommand(commandText, myconnection)
            cmd.Parameters.AddWithValue("@ApptID", vbNull)
            cmd.Parameters.AddWithValue("@DateOf", dtAppt.SelectionRange.Start.ToShortDateString)
            cmd.Parameters.AddWithValue("@docName", Name)
            Try
                cmd.ExecuteNonQuery() 'Executing Update Command
            Catch ex As Exception
                MessageBox.Show("This is an error in updating", ex.Message) 'Error MEssage
            End Try
        ElseIf lblTimeSlot.Text = "10:00" Then
            commandText = "UPDATE DoctorSchedule SET [10:00] = '""' WHERE DateOf = @Day AND docName = @name"
            cmd = New OleDbCommand(commandText, myconnection)
            cmd.Parameters.AddWithValue("@ApptID", vbNull)
            cmd.Parameters.AddWithValue("@DateOf", dtAppt.SelectionRange.Start.ToShortDateString)
            cmd.Parameters.AddWithValue("@docName", Name)
            Try
                cmd.ExecuteNonQuery() 'Executing Update Command
            Catch ex As Exception
                MessageBox.Show(ex.Message) 'Error MEssage
            End Try
        ElseIf lblTimeSlot.Text = "13:00" Then
            commandText = "UPDATE DoctorSchedule SET [13:00] = '""' WHERE DateOf = @Day AND docName = @name"
            cmd = New OleDbCommand(commandText, myconnection)
            cmd.Parameters.AddWithValue("@ApptID", vbNull)
            cmd.Parameters.AddWithValue("@DateOf", dtAppt.SelectionRange.Start.ToShortDateString)
            cmd.Parameters.AddWithValue("@docName", Name)
            Try
                cmd.ExecuteNonQuery() 'Executing Update Command
            Catch ex As Exception
                MessageBox.Show(ex.Message) 'Error MEssage
            End Try
        Else
            commandText = "UPDATE DoctorSchedule SET [15:00] = '""' WHERE DateOf = @Day AND docName = @name"
            cmd = New OleDbCommand(commandText, myconnection)
            cmd.Parameters.AddWithValue("@ApptID", vbNull)
            cmd.Parameters.AddWithValue("@DateOf", dtAppt.SelectionRange.Start.ToShortDateString)
            cmd.Parameters.AddWithValue("@docName", Name)
            Try
                cmd.ExecuteNonQuery() 'Executing Update Command
            Catch ex As Exception
                MessageBox.Show(ex.Message) 'Error MEssage
            End Try
        End If


        Dim command2 As String = "DELETE * FROM PatientHistory WHERE [AppointmentID] = ?"
        cmd = New OleDbCommand(command2, myconnection)
        cmd.Parameters.AddWithValue("?", lblID.Text)
        Try
            cmd.ExecuteNonQuery() 'Executing Update Command
        Catch ex As Exception
            MessageBox.Show("this is an error in deletion", ex.Message) 'Error MEssage
        End Try
        myconnection.Close()
        Dim newform As New dataInput
        newform.Show()
        Me.Hide()
    End Sub

    Private Sub PatientData_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class