Public Class MainForm
    Dim CRUDController As New CRUDController
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrontOfficeNavigation.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MasterEmployee.Show()
        Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AddHousekeepingSchedule.Show()
        Me.Hide()
    End Sub
End Class