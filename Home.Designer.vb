<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        MenuStrip1 = New MenuStrip()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        ItemInToolStripMenuItem = New ToolStripMenuItem()
        ItemOutToolStripMenuItem = New ToolStripMenuItem()
        ItemToolStripMenuItem = New ToolStripMenuItem()
        SupplierToolStripMenuItem = New ToolStripMenuItem()
        CustomerToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {ToolStripMenuItem1, SupplierToolStripMenuItem, CustomerToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(484, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.DropDownItems.AddRange(New ToolStripItem() {ItemInToolStripMenuItem, ItemOutToolStripMenuItem, ItemToolStripMenuItem})
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(43, 20)
        ToolStripMenuItem1.Text = "Item"
        ' 
        ' ItemInToolStripMenuItem
        ' 
        ItemInToolStripMenuItem.Name = "ItemInToolStripMenuItem"
        ItemInToolStripMenuItem.Size = New Size(180, 22)
        ItemInToolStripMenuItem.Text = "Item"
        ' 
        ' ItemOutToolStripMenuItem
        ' 
        ItemOutToolStripMenuItem.Name = "ItemOutToolStripMenuItem"
        ItemOutToolStripMenuItem.Size = New Size(180, 22)
        ItemOutToolStripMenuItem.Text = "Item In"
        ' 
        ' ItemToolStripMenuItem
        ' 
        ItemToolStripMenuItem.Name = "ItemToolStripMenuItem"
        ItemToolStripMenuItem.Size = New Size(180, 22)
        ItemToolStripMenuItem.Text = "Item Out"
        ' 
        ' SupplierToolStripMenuItem
        ' 
        SupplierToolStripMenuItem.Name = "SupplierToolStripMenuItem"
        SupplierToolStripMenuItem.Size = New Size(62, 20)
        SupplierToolStripMenuItem.Text = "Supplier"
        ' 
        ' CustomerToolStripMenuItem
        ' 
        CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        CustomerToolStripMenuItem.RightToLeft = RightToLeft.No
        CustomerToolStripMenuItem.Size = New Size(71, 20)
        CustomerToolStripMenuItem.Text = "Customer"
        ' 
        ' Home
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(484, 162)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        MaximumSize = New Size(500, 200)
        MinimumSize = New Size(500, 200)
        Name = "Home"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Home"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SupplierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ItemInToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ItemOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ItemToolStripMenuItem As ToolStripMenuItem
End Class
