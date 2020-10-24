Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class CRUD
    Dim Conn As New Conn
    Public Sub Create(table As String, column() As String, data() As String)
        Try
            Conn.Open()

            Dim cmd As SqlCommand
            Dim Insert As String = "INSERT INTO " & table & " (" & String.Join(", ", column) & ") VALUES ("

            For i As Integer = 0 To data.Length - 1
                If i = data.Length - 1 Then
                    Insert &= "'" & data(i) & "'"
                Else
                    Insert &= "'" & data(i) & "', "
                End If
            Next
            Insert &= ")"

            cmd = New SqlCommand(Insert, Conn.connection)
            cmd.ExecuteNonQuery()

            MsgBox("Insert success")
        Catch ex As Exception
            MsgBox("Insert failed!")
            MsgBox(ex.ToString)
        Finally
            Conn.connection.Close()
        End Try
    End Sub
    Public Sub Update(table As String, column() As String, data() As String, whereColumn() As String, whereData() As String)

    End Sub
    Public Sub Delete(table As String, whereColumn() As String, whereData() As String)

    End Sub
End Class
