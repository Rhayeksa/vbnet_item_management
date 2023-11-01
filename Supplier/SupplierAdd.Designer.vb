<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SupplierAdd
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label3 = New Label()
        TextBox2 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        TextBox4 = New TextBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(23, 144)
        Label3.Name = "Label3"
        Label3.Size = New Size(66, 21)
        Label3.TabIndex = 45
        Label3.Text = "Address"
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox2.Location = New Point(23, 168)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(338, 29)
        TextBox2.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(23, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(113, 21)
        Label1.TabIndex = 44
        Label1.Text = "New Supplier"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(23, 78)
        Label2.Name = "Label2"
        Label2.Size = New Size(52, 21)
        Label2.TabIndex = 43
        Label2.Text = "Name"
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox4.Location = New Point(23, 102)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(338, 29)
        TextBox4.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(189, 20)
        Button1.Name = "Button1"
        Button1.Size = New Size(172, 31)
        Button1.TabIndex = 3
        Button1.Text = "Add"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' SupplierAdd
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(384, 242)
        Controls.Add(Label3)
        Controls.Add(TextBox2)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(TextBox4)
        Controls.Add(Button1)
        Name = "SupplierAdd"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SupplierAdd"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button1 As Button
End Class
