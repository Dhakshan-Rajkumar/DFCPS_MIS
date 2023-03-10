Imports System.Data.SqlClient

Public Class payable_class
    Public command As Integer
    Public transNo As String
    Public src As String
    Public totAmount As Double
    Public paymentType As String
    Public dueDate As DateTime
    Public paymentDesc As String
    Public status As String
    Public Sub insert_update_payables()
        Try
            Dim cmd As New SqlCommand("insert_update_payables", conn)
            checkConn()
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@command", SqlDbType.Int).Value = command
                .Parameters.AddWithValue("@refno", SqlDbType.VarChar).Value = transNo
                .Parameters.AddWithValue("@SRC", SqlDbType.VarChar).Value = Form.ActiveForm.Text
                .Parameters.AddWithValue("@paymenttype", SqlDbType.Decimal).Value = paymentType
                .Parameters.AddWithValue("@duedate", SqlDbType.VarChar).Value = dueDate
                .Parameters.AddWithValue("@paymentdesc", SqlDbType.VarChar).Value = paymentDesc
                .Parameters.AddWithValue("@amount", SqlDbType.Decimal).Value = totAmount
                .Parameters.AddWithValue("@status", SqlDbType.VarChar).Value = status
            End With
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
