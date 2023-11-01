Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class ItemInAdd
    Private Sub ItemInAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = ""
        TextBox5.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call Connect()
        Dim sql As String = $"
                            INSERT INTO item_in(code, id_supplier, id_item, quantity)
                            VALUES(
                                '{TextBox1.Text}',
                                '{TextBox5.Text}',
                                '{TextBox2.Text}',
                                '{TextBox3.Text}'
                            )
                            "
        Cmd = New SqlCommand(sql, Conn)
        Cmd.ExecuteNonQuery()
        MessageBox.Show("Add Data Success", "Message")
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub
End Class