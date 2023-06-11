Public Class Form1
    Private Sub cmdAppointment_Click(sender As Object, e As EventArgs) Handles cmdAppointment.Click
        Dim data As New dataInput
        data.Show()
        Me.Hide()
    End Sub


    Private Sub cmdBooking_Click(sender As Object, e As EventArgs) Handles cmdBooking.Click
        Dim answer As String = MsgBox("Has the patient been here before?", vbQuestion + vbYesNo)
        If answer = vbYes Then
            Dim newForm As New dataInput
            newForm.Show()
            Me.Hide()
        Else
            Dim data As New booking
            booking.Show()
            Me.Hide()
        End If

    End Sub
End Class
