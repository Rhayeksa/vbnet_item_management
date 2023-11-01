Imports System.Data.SqlClient

Public Class CustomerAdd

    Private Sub CustomerAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Clean()
    End Sub

    Sub Clean()
        TextBox4.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call Connect()
        Dim sql As String = $"
                            INSERT INTO customer(name, address)
                            VALUES(
                                '{TextBox4.Text}',
                                '{TextBox2.Text}'
                            )
                            "
        Cmd = New SqlCommand(sql, Conn)
        Cmd.ExecuteNonQuery()
        MessageBox.Show("Add Data Success", "Message")
        Me.Close()
    End Sub

End Class