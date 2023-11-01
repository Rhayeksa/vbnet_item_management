Imports System.Data.SqlClient

Public Class ItemIn
    Private Sub ItemIn_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Call Clean()
    End Sub

    Sub Clean()
        TextBox4.Text = ""
        Call Data()
    End Sub

    Sub Data()
        Call Connect()
        Da = New SqlDataAdapter("
                                SELECT
                                    itm_in.code 'Code Item IN',
                                    spl.name 'Supplier Name'
                                FROM item_in itm_in
                                INNER JOIN supplier spl on spl.id = itm_in.id_supplier
                                GROUP BY itm_in.code, spl.name
                                ORDER BY itm_in.code DESC
                                ", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "table")
        DataGridView1.DataSource = Ds.Tables("table")
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim SelectedRow As DataGridViewRow
            SelectedRow = DataGridView1.Rows(e.RowIndex)
            Call Connect()
            Da = New SqlDataAdapter($"
                                SELECT
                                    itm.name 'Item Name',
                                    itm_in.quantity 'Quantity'
                                FROM item_in itm_in
                                INNER JOIN item itm on itm.id = itm_in.id_item
                                WHERE itm_in.code = '{SelectedRow.Cells(0).Value.ToString()}'
                                ORDER BY itm_in.code DESC
                                ", Conn)
            Ds = New DataSet
            Da.Fill(Ds, "table")
            DataGridView2.DataSource = Ds.Tables("table")
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ItemInAdd.ShowDialog()
    End Sub
End Class