Imports System.Data.SqlClient

Public Class Home
    Private Sub ItemInToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItemInToolStripMenuItem.Click
        Item.ShowDialog()
    End Sub

    Private Sub SupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupplierToolStripMenuItem.Click
        Supplier.ShowDialog()
    End Sub

    Private Sub CustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerToolStripMenuItem.Click
        Customer.ShowDialog()
    End Sub

    Private Sub ItemOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItemOutToolStripMenuItem.Click
        ItemIn.ShowDialog()
    End Sub

    Private Sub ItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItemToolStripMenuItem.Click
        ItemOut.ShowDialog()
    End Sub
End Class
