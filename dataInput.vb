Imports System.Data.OleDb

Public Class dataInput

    Public Shared DateOf As String
    Public Shared membershipNumber As String
    Public Shared publicName As String
    Public Shared publicNumber As String
    Public Shared pro As String
    Public Shared conString As String
    Public Shared command, command1, command2 As String
    Public Shared myconnection As OleDbConnection = New OleDbConnection
    Public Shared da As New OleDbDataAdapter
    Public Shared con As New OleDbConnection
    Public Shared dt As New DataTable
    Public Shared dr As OleDbDataReader
    Public Shared Qry As String
    Public Shared cmd As OleDbCommand



    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        If txtmemNumber.Text = "" Then
            MsgBox("Please enter the patient's membership number.")
        Else
            conString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\Users\hp\Desktop\School Stuff\Jan 23\MIS-312 Visual basic\ClinicProjectMDB.accdb'"
            myconnection.ConnectionString = conString
            myconnection.Open()

            Qry = "select * from PatientData WHERE MembershipNumber='" & txtmemNumber.Text & "'"
            cmd = New OleDbCommand(Qry, myconnection)
            cmd.ExecuteNonQuery()
            dr = cmd.ExecuteReader
            If dr.Read Then
                lblNames.Text = dr("Name")
                lblNumber.Text = dr("PhoneNumber")

            Else
                MsgBox("Record not found",, "Search")
            End If
            myconnection.Close()
        End If
    End Sub

    Private Sub cmdSubmit_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If lstDoctor.Text = "" Or txtService.Text = "" Or lstTime.Text = "" Then
            MsgBox("Please fill in the required information.")
        Else
            conString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\Users\hp\Desktop\School Stuff\Jan 23\MIS-312 Visual basic\ClinicProjectMDB.accdb'"
            myconnection.ConnectionString = conString
            myconnection.Open()
            command = "INSERT into PatientHistory([PatientName], [MembershipNumber], [ServiceSeeked],[DoctorAttended],[AppointmentDate], [TimeSlot]) VALUES
(@PatientName,@MembershipNumber,@ServiceSeeked,@DoctorAttended,@AppointmentDate,@TimeSlot)"

            Dim cmd As OleDbCommand = New OleDbCommand(command, myconnection)

            cmd.Parameters.AddWithValue("@PatientName", lblNames.Text)
            cmd.Parameters.AddWithValue("@MembershipNumber", txtmemNumber.Text)
            cmd.Parameters.AddWithValue("@ServiceSeeked", txtService.Text)
            cmd.Parameters.AddWithValue("@DoctorAttended", lstDoctor.Text)
            cmd.Parameters.AddWithValue("@AppointmentDate", dtAppointment.SelectionRange.Start.ToShortDateString)
            cmd.Parameters.AddWithValue("@TimeSlot", lstTime.Text)
            cmd.ExecuteNonQuery()


            MsgBox("An appointment has been booked for " & txtmemNumber.Text & " on " & dtAppointment.SelectionRange.Start.ToShortDateString & " at " & lstTime.Text)
            cmd.CommandText = "SELECT @@IDENTITY"
            Dim ApptID As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            cmd.ExecuteNonQuery()
            dr = cmd.ExecuteReader

            Dim name As String
            Dim day As String = dtAppointment.SelectionRange.Start
            If lstDoctor.Text = "Dr. Frank" Then
                name = lstDoctor.Text
            ElseIf lstDoctor.Text = "Dr. John" Then
                name = lstDoctor.Text
            Else
                name = lstDoctor.Text
            End If

            If lstTime.Text = "08:00" Then
                Dim commandText As String = "UPDATE DoctorSchedule SET [8:00] = @ApptID WHERE DateOf = @Day AND docName = @name"
                cmd = New OleDbCommand(commandText, myconnection)
                cmd.Parameters.AddWithValue("@ApptID", ApptID)
                cmd.Parameters.AddWithValue("@DateOf", day)
                cmd.Parameters.AddWithValue("@docName", name)
                Try
                    cmd.ExecuteNonQuery() 'Executing Update Command
                Catch ex As Exception
                    MessageBox.Show(ex.Message) 'Error MEssage
                End Try

            ElseIf lstTime.Text = "10:00" Then
                Dim commandText As String = "UPDATE DoctorSchedule SET [10:00] = @ApptID WHERE DateOf = @Day AND docName = @name"
                cmd = New OleDbCommand(commandText, myconnection)
                cmd.Parameters.AddWithValue("@ApptID", ApptID)
                cmd.Parameters.AddWithValue("@DateOf", day)
                cmd.Parameters.AddWithValue("@docName", name)
                Try
                    cmd.ExecuteNonQuery() 'Executing Update Command
                Catch ex As Exception
                    MessageBox.Show(ex.Message) 'Error MEssage
                End Try

            ElseIf lstTime.Text = "13:00" Then
                Dim commandText As String = "UPDATE DoctorSchedule SET [13:00] = @ApptID WHERE DateOf = @Day AND docName = @nam"
                cmd = New OleDbCommand(commandText, myconnection)
                cmd.Parameters.AddWithValue("@ApptID", ApptID)
                cmd.Parameters.AddWithValue("@DateOf", day)
                cmd.Parameters.AddWithValue("@docName", name)
                Try
                    cmd.ExecuteNonQuery() 'Executing Update Command
                Catch ex As Exception
                    MessageBox.Show(ex.Message) 'Error MEssage
                End Try

            Else
                Dim commandText As String = "UPDATE DoctorSchedule SET [15:00] = @ApptID WHERE DateOf = @Day AND docName = @nam"
                cmd = New OleDbCommand(commandText, myconnection)
                cmd.Parameters.AddWithValue("@ApptID", ApptID)
                cmd.Parameters.AddWithValue("@DateOf", day)
                cmd.Parameters.AddWithValue("@docName", name)
                Try
                    cmd.ExecuteNonQuery() 'Executing Update Command
                Catch ex As Exception
                    MessageBox.Show(ex.Message) 'Error MEssage
                End Try

            End If
            Try
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                myconnection.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                End Try
            End If
        myconnection.Close()
        doctorSearch.PerformClick()
    End Sub

    Private Sub doctorSearch_Click(sender As Object, e As EventArgs) Handles doctorSearch.Click
        Dim apptDate As String = dtAppointment.SelectionRange.Start.ToShortDateString

        dt.Clear()
        Dim connectString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\Users\hp\Desktop\School Stuff\Jan 23\MIS-312 Visual basic\ClinicProjectMDB.accdb'"
        Dim connection As New OleDbConnection(connectString)
        da = New OleDbDataAdapter("SELECT * FROM DoctorSchedule WHERE DateOf='" & dtAppointment.SelectionRange.Start & "'", connection)

        da.Fill(dt)

        DGrid.DataSource = dt.DefaultView
        If DGrid.RowCount > 1 Then
        Else
            Populate(apptDate)
            doctorSearch.PerformClick()
        End If

        con.Close()
    End Sub

    Private Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
        booking.Show()
        Me.Hide()
    End Sub

    Public Shared Sub Populate(dateof)
        conString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\Users\hp\Desktop\School Stuff\Jan 23\MIS-312 Visual basic\ClinicProjectMDB.accdb'"
        Using myconnection As New OleDbConnection(conString)
            myconnection.Open()

            Dim commandText As String = "INSERT into DoctorSchedule([EmployeeNumber], [docName], [DateOf], [TimeSlot1], [TimeSlot2], [TimeSlot3], [TimeSlot4]) VALUES (@EmployeeNumber, @docName, @DateOf, '', '', '', '')"

            Dim cmd As New OleDbCommand(commandText, myconnection)

            cmd.Parameters.AddWithValue("@EmployeeNumber", "20-32")
            cmd.Parameters.AddWithValue("@docName", "Dr. Frank")
            cmd.Parameters.AddWithValue("@DateOf", dateof)
            cmd.ExecuteNonQuery()

            cmd.Parameters.Clear()

            Dim commandText1 As String = "INSERT into DoctorSchedule([EmployeeNumber], [docName], [DateOf], [TimeSlot1], [TimeSlot2], [TimeSlot3], [TimeSlot4]) VALUES (@EmployeeNumber, @docName, @DateOf, '', '', '', '')"
            cmd = New OleDbCommand(commandText1, myconnection)
            cmd.Parameters.AddWithValue("@EmployeeNumber", "16-28")
            cmd.Parameters.AddWithValue("@docName", "Dr. John")
            cmd.Parameters.AddWithValue("@DateOf", dateof)
            cmd.ExecuteNonQuery()

            cmd.Parameters.Clear()

            Dim commandText2 As String = "INSERT into DoctorSchedule([EmployeeNumber], [docName], [DateOf], [TimeSlot1], [TimeSlot2], [TimeSlot3], [TimeSlot4]) VALUES (@EmployeeNumber, @docName, @DateOf, '', '', '', '')"
            cmd = New OleDbCommand(commandText2, myconnection)
            cmd.Parameters.AddWithValue("@EmployeeNumber", "19-20")
            cmd.Parameters.AddWithValue("@docName", "Dr. Mary")
            cmd.Parameters.AddWithValue("@DateOf", dateof)
            cmd.ExecuteNonQuery()

            myconnection.Close()
        End Using
    End Sub



    Private Sub dataInput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtmemNumber.Text = booking.mNumber
        lblNames.Text = booking.name
        lblNumber.Text = booking.pNumber

    End Sub
End Class