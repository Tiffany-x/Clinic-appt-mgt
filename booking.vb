Imports System.Data.OleDb

Public Class booking


    Public Shared mNumber As String
    Public Shared name As String
    Public Shared pNumber As String
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





    Private Sub ConDB() 'This procedure opens the database and leaves it open. this is a method to be called
        conString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\Users\hp\Desktop\School Stuff\Jan 23\MIS-312 Visual basic\ClinicProjectMDB.accdb'"
        myconnection.ConnectionString = conString
        myconnection.Open()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdSubmit.Click
        Call ConDB() 'Calling the method ConDB
        command = "INSERT into PatientData([MembershipNumber],[Name],[InsuranceCompany],[DOB],[PhoneNumber],[NOK]) VALUES
('" & txtmemNumber.Text & "','" & txtNames.Text & "','" & txtInsurance.Text & "','" & dateBirth.Value & "','" & txtnumPhone.Text & "','" & txtnoKin.Text & "')"
        'INSERT is a method to enter these VALUES into the DB
        'the sequence is very important, i.e, regno, fullnames and address - 1-1 direct mapping
        '3 inputs on the form so there should also be 3 fields on the DB
        Dim cmd As OleDbCommand = New OleDbCommand(command, myconnection)
        cmd.Parameters.Add(New OleDbParameter("Membership number", CType(txtmemNumber.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Name", CType(txtNames.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Insurance company", CType(txtInsurance.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Date of birth", CType(dateBirth.Value, String)))
        cmd.Parameters.Add(New OleDbParameter("Phone number", CType(txtnumPhone.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Next of kin", CType(txtnoKin.Text, String)))


        MsgBox("A record has been made for " & txtNames.Text)

        mNumber = txtmemNumber.Text
        name = txtNames.Text
        pNumber = txtnumPhone.Text


        Dim data As New dataInput
        data.Show()
        Me.Hide()

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub booking_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class