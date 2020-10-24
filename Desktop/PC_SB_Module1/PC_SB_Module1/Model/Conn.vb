Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Conn
    Public connection As New SqlConnection

    Public Data As DataSet
    Public SQL As String = "Data Source=DESKTOP-S7CELPR\SQLEXPRESS;Initial Catalog=PC_SB;Integrated Security=True"
    Public Sub Open()
        connection = New SqlConnection(SQL)
        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            Else
                MsgBox("Check your connection!")
            End If
        Catch ex As Exception
            MsgBox("Check your connection!")
        End Try
    End Sub
    Public Sub Close()
        connection = New SqlConnection(SQL)
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            Else
                MsgBox("Check your connection!")
            End If
        Catch ex As Exception
            MsgBox("Check your connection!")
        End Try
    End Sub
End Class
