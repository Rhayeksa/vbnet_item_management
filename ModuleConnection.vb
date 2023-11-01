'Imports System.Data
'Imports System.Data.Sql
Imports System.Data.SqlClient
Module ModuleConnection
    Public Conn As SqlConnection
    Public Da As SqlDataAdapter
    Public Ds As DataSet
    Public Dr As SqlDataReader
    Public Cmd As SqlCommand
    Public DB As String

    Public Sub Connect()
        Dim host As String = "172.17.0.1"
        Dim port As String = "1435"
        Dim database As String = "dot_net_app_inventory"
        Dim userId As String = "sa"
        Dim password As String = "Rds12345"
        DB = "Server=" + host + "," + port + ";Database=" + database + ";User Id=" + userId + ";Password=" + password
        Conn = New SqlConnection(DB)
        If Conn.State = ConnectionState.Closed Then Conn.Open()
    End Sub

End Module