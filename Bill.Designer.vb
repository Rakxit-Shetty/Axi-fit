<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bill
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.BillToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Pnlreport = New System.Windows.Forms.Panel
        Me.Label12 = New System.Windows.Forms.Label
        Me.Total = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Pnlbill = New System.Windows.Forms.Panel
        Me.Label11 = New System.Windows.Forms.Label
        Me.MOP = New System.Windows.Forms.ComboBox
        Me.btnclear = New System.Windows.Forms.Button
        Me.Btnbill = New System.Windows.Forms.Button
        Me.Btnsearch = New System.Windows.Forms.Button
        Me.Txtpid = New System.Windows.Forms.TextBox
        Me.TxtPname = New System.Windows.Forms.TextBox
        Me.Txtprice = New System.Windows.Forms.TextBox
        Me.Txtqty = New System.Windows.Forms.TextBox
        Me.Txttotal = New System.Windows.Forms.TextBox
        Me.TxtCaddress = New System.Windows.Forms.TextBox
        Me.TxtCname = New System.Windows.Forms.TextBox
        Me.TxtCphone = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.MenuStrip1.SuspendLayout()
        Me.Pnlreport.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnlbill.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BillToolStripMenuItem, Me.ReToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1008, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BillToolStripMenuItem
        '
        Me.BillToolStripMenuItem.Name = "BillToolStripMenuItem"
        Me.BillToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.BillToolStripMenuItem.Text = "Bill"
        '
        'ReToolStripMenuItem
        '
        Me.ReToolStripMenuItem.Name = "ReToolStripMenuItem"
        Me.ReToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.ReToolStripMenuItem.Text = "Report"
        '
        'Pnlreport
        '
        Me.Pnlreport.Controls.Add(Me.Label12)
        Me.Pnlreport.Controls.Add(Me.Total)
        Me.Pnlreport.Controls.Add(Me.Label10)
        Me.Pnlreport.Controls.Add(Me.DataGridView1)
        Me.Pnlreport.Location = New System.Drawing.Point(220, 318)
        Me.Pnlreport.Margin = New System.Windows.Forms.Padding(2)
        Me.Pnlreport.Name = "Pnlreport"
        Me.Pnlreport.Size = New System.Drawing.Size(593, 249)
        Me.Pnlreport.TabIndex = 5
        Me.Pnlreport.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(260, 15)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 29)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Report"
        '
        'Total
        '
        Me.Total.Location = New System.Drawing.Point(166, 210)
        Me.Total.Margin = New System.Windows.Forms.Padding(2)
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.Size = New System.Drawing.Size(76, 20)
        Me.Total.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(32, 210)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Total"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(35, 59)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(523, 131)
        Me.DataGridView1.TabIndex = 0
        '
        'Pnlbill
        '
        Me.Pnlbill.Controls.Add(Me.Label11)
        Me.Pnlbill.Controls.Add(Me.MOP)
        Me.Pnlbill.Controls.Add(Me.btnclear)
        Me.Pnlbill.Controls.Add(Me.Btnbill)
        Me.Pnlbill.Controls.Add(Me.Btnsearch)
        Me.Pnlbill.Controls.Add(Me.Txtpid)
        Me.Pnlbill.Controls.Add(Me.TxtPname)
        Me.Pnlbill.Controls.Add(Me.Txtprice)
        Me.Pnlbill.Controls.Add(Me.Txtqty)
        Me.Pnlbill.Controls.Add(Me.Txttotal)
        Me.Pnlbill.Controls.Add(Me.TxtCaddress)
        Me.Pnlbill.Controls.Add(Me.TxtCname)
        Me.Pnlbill.Controls.Add(Me.TxtCphone)
        Me.Pnlbill.Controls.Add(Me.Label9)
        Me.Pnlbill.Controls.Add(Me.Label8)
        Me.Pnlbill.Controls.Add(Me.Label7)
        Me.Pnlbill.Controls.Add(Me.Label6)
        Me.Pnlbill.Controls.Add(Me.Label5)
        Me.Pnlbill.Controls.Add(Me.Label4)
        Me.Pnlbill.Controls.Add(Me.Label3)
        Me.Pnlbill.Controls.Add(Me.Label2)
        Me.Pnlbill.Controls.Add(Me.Label1)
        Me.Pnlbill.Location = New System.Drawing.Point(220, 38)
        Me.Pnlbill.Margin = New System.Windows.Forms.Padding(2)
        Me.Pnlbill.Name = "Pnlbill"
        Me.Pnlbill.Size = New System.Drawing.Size(593, 276)
        Me.Pnlbill.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(278, 11)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 29)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Bill"
        '
        'MOP
        '
        Me.MOP.FormattingEnabled = True
        Me.MOP.Items.AddRange(New Object() {"Check", "Cash", "UPI", "Card"})
        Me.MOP.Location = New System.Drawing.Point(156, 195)
        Me.MOP.Margin = New System.Windows.Forms.Padding(2)
        Me.MOP.Name = "MOP"
        Me.MOP.Size = New System.Drawing.Size(76, 21)
        Me.MOP.TabIndex = 21
        '
        'btnclear
        '
        Me.btnclear.Location = New System.Drawing.Point(476, 244)
        Me.btnclear.Margin = New System.Windows.Forms.Padding(2)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(56, 19)
        Me.btnclear.TabIndex = 20
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'Btnbill
        '
        Me.Btnbill.Location = New System.Drawing.Point(387, 244)
        Me.Btnbill.Margin = New System.Windows.Forms.Padding(2)
        Me.Btnbill.Name = "Btnbill"
        Me.Btnbill.Size = New System.Drawing.Size(56, 19)
        Me.Btnbill.TabIndex = 19
        Me.Btnbill.Text = "Bill"
        Me.Btnbill.UseVisualStyleBackColor = True
        '
        'Btnsearch
        '
        Me.Btnsearch.Location = New System.Drawing.Point(389, 58)
        Me.Btnsearch.Margin = New System.Windows.Forms.Padding(2)
        Me.Btnsearch.Name = "Btnsearch"
        Me.Btnsearch.Size = New System.Drawing.Size(56, 19)
        Me.Btnsearch.TabIndex = 18
        Me.Btnsearch.Text = "Search"
        Me.Btnsearch.UseVisualStyleBackColor = True
        '
        'Txtpid
        '
        Me.Txtpid.Location = New System.Drawing.Point(258, 57)
        Me.Txtpid.Margin = New System.Windows.Forms.Padding(2)
        Me.Txtpid.Name = "Txtpid"
        Me.Txtpid.Size = New System.Drawing.Size(76, 20)
        Me.Txtpid.TabIndex = 17
        '
        'TxtPname
        '
        Me.TxtPname.Location = New System.Drawing.Point(378, 102)
        Me.TxtPname.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPname.Name = "TxtPname"
        Me.TxtPname.ReadOnly = True
        Me.TxtPname.Size = New System.Drawing.Size(76, 20)
        Me.TxtPname.TabIndex = 16
        '
        'Txtprice
        '
        Me.Txtprice.Location = New System.Drawing.Point(378, 132)
        Me.Txtprice.Margin = New System.Windows.Forms.Padding(2)
        Me.Txtprice.Name = "Txtprice"
        Me.Txtprice.ReadOnly = True
        Me.Txtprice.Size = New System.Drawing.Size(76, 20)
        Me.Txtprice.TabIndex = 15
        '
        'Txtqty
        '
        Me.Txtqty.Location = New System.Drawing.Point(378, 164)
        Me.Txtqty.Margin = New System.Windows.Forms.Padding(2)
        Me.Txtqty.Name = "Txtqty"
        Me.Txtqty.Size = New System.Drawing.Size(76, 20)
        Me.Txtqty.TabIndex = 14
        '
        'Txttotal
        '
        Me.Txttotal.Location = New System.Drawing.Point(378, 197)
        Me.Txttotal.Margin = New System.Windows.Forms.Padding(2)
        Me.Txttotal.Name = "Txttotal"
        Me.Txttotal.ReadOnly = True
        Me.Txttotal.Size = New System.Drawing.Size(76, 20)
        Me.Txttotal.TabIndex = 13
        '
        'TxtCaddress
        '
        Me.TxtCaddress.Location = New System.Drawing.Point(156, 165)
        Me.TxtCaddress.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtCaddress.Name = "TxtCaddress"
        Me.TxtCaddress.Size = New System.Drawing.Size(76, 20)
        Me.TxtCaddress.TabIndex = 11
        '
        'TxtCname
        '
        Me.TxtCname.Location = New System.Drawing.Point(156, 132)
        Me.TxtCname.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtCname.Name = "TxtCname"
        Me.TxtCname.Size = New System.Drawing.Size(76, 20)
        Me.TxtCname.TabIndex = 10
        '
        'TxtCphone
        '
        Me.TxtCphone.Location = New System.Drawing.Point(156, 99)
        Me.TxtCphone.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtCphone.Name = "TxtCphone"
        Me.TxtCphone.Size = New System.Drawing.Size(76, 20)
        Me.TxtCphone.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(22, 195)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(118, 17)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Mode of Payment"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(22, 162)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(124, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Customer Address"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(22, 128)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Customer Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(22, 96)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Customer Phone"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(252, 197)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Total"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(252, 164)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Quantity"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(252, 132)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Product Price"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(255, 102)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Product Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(54, 61)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter the Product_ID"
        '
        'Bill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 546)
        Me.Controls.Add(Me.Pnlreport)
        Me.Controls.Add(Me.Pnlbill)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Bill"
        Me.Text = "Bill"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Pnlreport.ResumeLayout(False)
        Me.Pnlreport.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnlbill.ResumeLayout(False)
        Me.Pnlbill.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents BillToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Pnlreport As System.Windows.Forms.Panel
    Friend WithEvents Total As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Pnlbill As System.Windows.Forms.Panel
    Friend WithEvents MOP As System.Windows.Forms.ComboBox
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents Btnbill As System.Windows.Forms.Button
    Friend WithEvents Btnsearch As System.Windows.Forms.Button
    Friend WithEvents Txtpid As System.Windows.Forms.TextBox
    Friend WithEvents TxtPname As System.Windows.Forms.TextBox
    Friend WithEvents Txtprice As System.Windows.Forms.TextBox
    Friend WithEvents Txtqty As System.Windows.Forms.TextBox
    Friend WithEvents Txttotal As System.Windows.Forms.TextBox
    Friend WithEvents TxtCaddress As System.Windows.Forms.TextBox
    Friend WithEvents TxtCname As System.Windows.Forms.TextBox
    Friend WithEvents TxtCphone As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
