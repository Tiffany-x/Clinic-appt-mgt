Imports System.Data.OleDb

Public Class DoctorReport
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


    Private Sub cmdGenerate_Click(sender As Object, e As EventArgs) Handles cmdGenerate.Click
        Dim DateOf As String = reportDate.SelectionRange.Start.ToShortDateString

        dt.Clear()
        Dim connectString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\Users\hp\Desktop\School Stuff\Jan 23\MIS-312 Visual basic\ClinicProjectMDB.accdb'"
        Dim connection As New OleDbConnection(connectString)
        da = New OleDbDataAdapter("SELECT * FROM DoctorSchedule WHERE DateOf='" & DateOf & "'", connection)

        da.Fill(dt)

        DGReport.DataSource = dt.DefaultView
        If DGReport.RowCount > 1 Then
        Else
            dataInput.Populate(DateOf)
            cmdGenerate.PerformClick()
        End If
        Label1.Hide()
        reportDate.Hide()
        cmdGenerate.Hide()
        DGReport.Show()

        con.Close()
    End Sub

    Private Sub DoctorReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGReport.Hide()
    End Sub
End Class