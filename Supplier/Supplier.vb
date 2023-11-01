Imports System.Data.SqlClient

Public Class Supplier
    Dim index As Integer

    Private Sub Supplier_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Call Clean()
        Call Data()
    End Sub

    Sub Clean()
        TextBox4.Text = ""
        Call Data()
    End Sub

    Sub Data()
        Call Connect()
        Da = New SqlDataAdapter("SELECT * FROM supplier ORDER BY id DESC", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "table")
        DataGridView1.DataSource = Ds.Tables("table")
    End Sub

    'Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
    '    Call Connect()
    '    Da = New SqlDataAdapter("SELECT * FROM customer WHERE id = 1", Conn)
    '    Ds = New DataSet
    '    Da.Fill(Ds, "table")
    '    DataGridView1.DataSource = Ds.Tables("table")
    'End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Call Connect()
        Da = New SqlDataAdapter($"SELECT * FROM supplier WHERE name LIKE '%{TextBox4.Text}%'", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "table")
        DataGridView1.DataSource = Ds.Tables("table")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SupplierAdd.ShowDialog()
    End Sub

    Public Shared Property SelectedRow As DataGridViewRow
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            SelectedRow = DataGridView1.Rows(e.RowIndex)
            SupplierDetail.ShowDialog()
        End If
    End Sub

End Class