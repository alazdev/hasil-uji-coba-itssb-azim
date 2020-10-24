Public Class CRUDController
    Dim CRUD As New CRUD
    Public Sub Create(table As String, column() As String, data() As String)
        CRUD.Create(table, column, data)
    End Sub
    Public Sub Update(table As String, column() As String, data() As String, whereColumn() As String, whereData() As String)
        CRUD.Update(table, column, data, whereColumn, whereData)
    End Sub
    Public Sub Delete(table As String, whereColumn() As String, whereData() As String)
        CRUD.Delete(table, whereColumn, whereData)
    End Sub
End Class
