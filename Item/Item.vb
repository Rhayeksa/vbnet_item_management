Imports System.Data.SqlClient

Public Class Item
    Private Sub Item_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Call Clean()
        Call Data()
    End Sub

    Sub Clean()
        TextBox4.Text = ""
        Call Data()
    End Sub

    Sub Data()
        Call Connect()
        Da = New SqlDataAdapter("SELECT * FROM item ORDER BY id DESC", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "table")
        DataGridView1.DataSource = Ds.Tables("table")
    End Sub

    'Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
    '    Call Connect()
    '    Da = New SqlDataAdapter("SELECT * FROM item WHERE id = 1", Conn)
    '    Ds = New DataSet
    '    Da.Fill(Ds, "table")
    '    DataGridView1.DataSource = Ds.Tables("table")
    'End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Call Connect()
        Da = New SqlDataAdapter($"SELECT * FROM item WHERE name LIKE '%{TextBox4.Text}%'", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "table")
        DataGridView1.DataSource = Ds.Tables("table")
    End Sub

End Class