Imports System.Data.SqlClient

Public Class SupplierDetail
    Private Sub SupplierDetail_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Call Clean()
    End Sub

    Sub Clean()
        TextBox1.Text = Supplier.SelectedRow.Cells(0).Value.ToString()
        Call Connect()
        Cmd = New SqlCommand($"SELECT name FROM supplier WHERE id = '{TextBox1.Text}'", Conn)
        TextBox4.Text = IIf(IsDBNull(Cmd.ExecuteScalar), "", Cmd.ExecuteScalar)
        Cmd = New SqlCommand($"SELECT address FROM supplier WHERE id = '{TextBox1.Text}'", Conn)
        TextBox2.Text = IIf(IsDBNull(Cmd.ExecuteScalar), "", Cmd.ExecuteScalar)
        TextBox4.ReadOnly = True
        TextBox2.ReadOnly = True
        Button4.Visible = True
        Button1.Text = "Edit"
        Button1.Width = 75
        Button1.Height = 31
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "Edit" Then
            TextBox4.ReadOnly = False
            TextBox2.ReadOnly = False
            Button4.Visible = False
            Button1.Text = "Save"
            Button1.Width = 172
            Button1.Height = 31
        Else
            TextBox4.ReadOnly = True
            TextBox2.ReadOnly = True
            Button4.Visible = True
            Button1.Text = "Edit"
            Button1.Width = 75
            Button1.Height = 31
            Call Connect()
            Dim sql As String = $"
                                UPDATE supplier
                                SET
                                    name = '{TextBox4.Text}', 
                                    address='{TextBox2.Text}'
                                WHERE id = '{TextBox1.Text}'
                                "
            Cmd = New SqlCommand(sql, Conn)
            Cmd.ExecuteNonQuery()
            MessageBox.Show("Edit Data Success!", "Message")
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim result As DialogResult = MessageBox.Show("Are You sure delete this data...?", "Warning", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Call Connect()
            Dim sql As String = $"
                                DELETE FROM supplier
                                WHERE id = '{TextBox1.Text}'
                                "
            Cmd = New SqlCommand(sql, Conn)
            Cmd.ExecuteNonQuery()
            MessageBox.Show("Delete Data Success!", "Message")
            Me.Close()
        End If
    End Sub
End Class