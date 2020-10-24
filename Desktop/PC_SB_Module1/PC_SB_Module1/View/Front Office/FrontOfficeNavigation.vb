Public Class FrontOfficeNavigation
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MainForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MasterRoomType.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MasterRoom.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MasterItem.Show()
        Me.Hide()
    End Sub
End Class