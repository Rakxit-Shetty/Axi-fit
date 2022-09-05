Imports System.Data.SqlClient
Module Connection
    Public cmd As New SqlCommand
    Public cnn As New SqlConnection
    Public dr As SqlDataReader
    Public id As Integer
    Public Sub connect()
        cnn.ConnectionString = "Data Source=ZED_AIR_CX3\SQLEXPRESS;Initial Catalog=fun_shop;Integrated Security=True"
        cnn.Open()
        cmd.Connection = cnn
    End Sub
End Module
