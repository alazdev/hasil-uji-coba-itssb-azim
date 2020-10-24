Public Class MasterRoom
    Dim CRUDController As New CRUDController
    Private insertUpdate = ""
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        FrontOfficeNavigation.Show()
        Me.Hide()

        Mode(0)
    End Sub
    'Code Mode
    Private Sub Mode(int As Integer)
        If int = 0 Then
            Button1.Enabled = True
            Button2.Enabled = True
            Button3.Enabled = True

            Button4.Enabled = False
            Button5.Enabled = False

            TextBox1.Enabled = False
            ComboBox1.Enabled = False
            TextBox2.Enabled = False
            RichTextBox1.Enabled = False
        Else
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False

            Button4.Enabled = True
            Button5.Enabled = True

            TextBox1.Enabled = True
            ComboBox1.Enabled = True
            TextBox2.Enabled = True
            RichTextBox1.Enabled = False
        End If
        Clear()
    End Sub
    Private Sub Clear()
        TextBox1.Text = ""
        TextBox2.Text = ""
        RichTextBox1.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Mode(1)
        insertUpdate = "insert"

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Mode(1)
        insertUpdate = "update"

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Dim Data As Integer = DataGridView1.CurrentRow.Index

        'If Data > -1 Then
        '    MessageBox.Show("Are you sure to delete this record?", "Alert", MessageBoxButtons.OKCancel)
        'Else
        '    MsgBox("Select The Table first!")
        'End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If insertUpdate = "insert" Then

        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Mode(0)
    End Sub

    Private Function Validation() As Boolean
        Return False
    End Function

    Private Sub MasterRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PC_SBDataSet.RoomType' table. You can move, or remove it, as needed.
        Me.RoomTypeTableAdapter.Fill(Me.PC_SBDataSet.RoomType)

    End Sub
End Class