Public Class Land
    Private Sub cmdAttending_Click(sender As Object, e As EventArgs) Handles cmdAttending.Click
        Dim here As New PatientData
        here.Show()
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

    Private Sub cmdDocSchedules_Click(sender As Object, e As EventArgs) Handles cmdDocSchedules.Click
        Dim schedule As New DocSchedules

    End Sub
End Class