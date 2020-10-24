Public Class MasterRoomType
    Dim CRUDController As New CRUDController
    Private insertUpdate = ""
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        FrontOfficeNavigation.Show()
        Me.Hide()
    End Sub

    Private Sub MasterRoomType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PC_SBDataSet.RoomType' table. You can move, or remove it, as needed.
        Me.RoomTypeTableAdapter.Fill(Me.PC_SBDataSet.RoomType)

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
            NumericUpDown1.Enabled = False
            TextBox2.Enabled = False
        Else
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False

            Button4.Enabled = True
            Button5.Enabled = True

            TextBox1.Enabled = True
            NumericUpDown1.Enabled = True
            TextBox2.Enabled = True
        End If
        Clear()
    End Sub
    Private Sub Clear()
        TextBox1.Text = ""
        TextBox2.Text = ""

        NumericUpDown1.Value = 0
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
        Dim Data As Integer = DataGridView1.CurrentRow.Index

        If Data > -1 Then
            MessageBox.Show("Are you sure to delete this record?", "Alert", MessageBoxButtons.OKCancel)
        Else
            MsgBox("Select The Table first!")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If insertUpdate = "insert" Then
            If Validation() = True Then
                CRUDController.Create("RoomType",
                                      {"Name", "Capacity", "RoomPrice"},
                                      {TextBox1.Text, NumericUpDown1.Value.ToString, TextBox2.Text})
                Me.RoomTypeTableAdapter.Fill(Me.PC_SBDataSet.RoomType)

                Mode(0)
            End If
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Mode(0)
    End Sub

    Private Function Validation() As Boolean
        If String.IsNullOrEmpty(TextBox1.Text) Then
            MsgBox("Name cannot NULL")
        ElseIf NumericUpDown1.Value < 1 Then
            MsgBox("Capacity Incorrect value")
        ElseIf String.IsNullOrEmpty(TextBox2.Text) Then
            MsgBox("Room Price cannot NULL")
        ElseIf Not IsNumeric(TextBox2.Text) Then
            MsgBox("Room Price must numeric")
        Else
            Return True
        End If
        Return False
    End Function
End Class