Imports System.Data.OleDb

Public Class PatientsReport
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


    Private Sub PatientsReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGReport.Hide()
    End Sub

    Private Sub cmdGenerate_Click(sender As Object, e As EventArgs) Handles cmdGenerate.Click
        Dim mem As String = memNumber.Text

        dt.Clear()
        Dim connectString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\Users\hp\Desktop\School Stuff\Jan 23\MIS-312 Visual basic\ClinicProjectMDB.accdb'"
        Dim connection As New OleDbConnection(connectString)
        da = New OleDbDataAdapter("SELECT * FROM PatientHistory WHERE MembershipNumber='" & mem & "'", connection)

        da.Fill(dt)

        DGReport.DataSource = dt.DefaultView
        If DGReport.RowCount > 1 Then
            Label1.Hide()
            memNumber.Hide()
            cmdGenerate.Hide()
            DGReport.Show()
        Else
            MsgBox("This patient does not have any past records.")
        End If


        con.Close()
    End Sub
End Class