<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employee
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
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ADDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EDITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VIEWToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DELETEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Pnlpro = New System.Windows.Forms.Panel
        Me.Label18 = New System.Windows.Forms.Label
        Me.Pnludpro = New System.Windows.Forms.Panel
        Me.Btndelpro = New System.Windows.Forms.Button
        Me.Btnviewpro = New System.Windows.Forms.Button
        Me.Txteditqty = New System.Windows.Forms.TextBox
        Me.Txteditfeatures = New System.Windows.Forms.TextBox
        Me.Txteditprice = New System.Windows.Forms.TextBox
        Me.editnamepro = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Btnclredit = New System.Windows.Forms.Button
        Me.Btneditpro = New System.Windows.Forms.Button
        Me.Btnchkpro = New System.Windows.Forms.Button
        Me.GVpro = New System.Windows.Forms.DataGridView
        Me.Txtpro_id = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Pnladdpro = New System.Windows.Forms.Panel
        Me.Label13 = New System.Windows.Forms.Label
        Me.Txtaddqty = New System.Windows.Forms.TextBox
        Me.Btnclradd = New System.Windows.Forms.Button
        Me.Btnaddpro = New System.Windows.Forms.Button
        Me.Txtaddfeatures = New System.Windows.Forms.TextBox
        Me.Txtaddprice = New System.Windows.Forms.TextBox
        Me.addnamepro = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Pnldata = New System.Windows.Forms.Panel
        Me.Txtemail = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Txtpass = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.empid = New System.Windows.Forms.Label
        Me.Btnupd = New System.Windows.Forms.Button
        Me.Dob = New System.Windows.Forms.DateTimePicker
        Me.Txtphone = New System.Windows.Forms.TextBox
        Me.Txtaddress = New System.Windows.Forms.TextBox
        Me.Txtname = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.MenuStrip1.SuspendLayout()
        Me.Pnlpro.SuspendLayout()
        Me.Pnludpro.SuspendLayout()
        CType(Me.GVpro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnladdpro.SuspendLayout()
        Me.Pnldata.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportToolStripMenuItem, Me.ProductsToolStripMenuItem, Me.ProfileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(813, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.ReportToolStripMenuItem.Text = "Bill"
        '
        'ProductsToolStripMenuItem
        '
        Me.ProductsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ADDToolStripMenuItem, Me.EDITToolStripMenuItem, Me.VIEWToolStripMenuItem, Me.DELETEToolStripMenuItem})
        Me.ProductsToolStripMenuItem.Name = "ProductsToolStripMenuItem"
        Me.ProductsToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.ProductsToolStripMenuItem.Text = "Products"
        '
        'ADDToolStripMenuItem
        '
        Me.ADDToolStripMenuItem.Name = "ADDToolStripMenuItem"
        Me.ADDToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.ADDToolStripMenuItem.Text = "ADD"
        '
        'EDITToolStripMenuItem
        '
        Me.EDITToolStripMenuItem.Name = "EDITToolStripMenuItem"
        Me.EDITToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.EDITToolStripMenuItem.Text = "EDIT"
        '
        'VIEWToolStripMenuItem
        '
        Me.VIEWToolStripMenuItem.Name = "VIEWToolStripMenuItem"
        Me.VIEWToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.VIEWToolStripMenuItem.Text = "VIEW"
        '
        'DELETEToolStripMenuItem
        '
        Me.DELETEToolStripMenuItem.Name = "DELETEToolStripMenuItem"
        Me.DELETEToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.DELETEToolStripMenuItem.Text = "DELETE"
        '
        'ProfileToolStripMenuItem
        '
        Me.ProfileToolStripMenuItem.Name = "ProfileToolStripMenuItem"
        Me.ProfileToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.ProfileToolStripMenuItem.Text = "Profile"
        '
        'Pnlpro
        '
        Me.Pnlpro.Controls.Add(Me.Label18)
        Me.Pnlpro.Controls.Add(Me.Btnviewpro)
        Me.Pnlpro.Controls.Add(Me.Pnludpro)
        Me.Pnlpro.Controls.Add(Me.Btnchkpro)
        Me.Pnlpro.Controls.Add(Me.GVpro)
        Me.Pnlpro.Controls.Add(Me.Txtpro_id)
        Me.Pnlpro.Controls.Add(Me.Label4)
        Me.Pnlpro.Location = New System.Drawing.Point(25, 287)
        Me.Pnlpro.Margin = New System.Windows.Forms.Padding(2)
        Me.Pnlpro.Name = "Pnlpro"
        Me.Pnlpro.Size = New System.Drawing.Size(464, 336)
        Me.Pnlpro.TabIndex = 12
        Me.Pnlpro.Visible = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(158, 11)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(121, 29)
        Me.Label18.TabIndex = 30
        Me.Label18.Text = "Products"
        '
        'Pnludpro
        '
        Me.Pnludpro.Controls.Add(Me.Btndelpro)
        Me.Pnludpro.Controls.Add(Me.Txteditqty)
        Me.Pnludpro.Controls.Add(Me.Txteditfeatures)
        Me.Pnludpro.Controls.Add(Me.Txteditprice)
        Me.Pnludpro.Controls.Add(Me.editnamepro)
        Me.Pnludpro.Controls.Add(Me.Btneditpro)
        Me.Pnludpro.Controls.Add(Me.Label14)
        Me.Pnludpro.Controls.Add(Me.Label15)
        Me.Pnludpro.Controls.Add(Me.Label16)
        Me.Pnludpro.Controls.Add(Me.Label17)
        Me.Pnludpro.Controls.Add(Me.Btnclredit)
        Me.Pnludpro.Location = New System.Drawing.Point(37, 88)
        Me.Pnludpro.Name = "Pnludpro"
        Me.Pnludpro.Size = New System.Drawing.Size(411, 185)
        Me.Pnludpro.TabIndex = 29
        Me.Pnludpro.Visible = False
        '
        'Btndelpro
        '
        Me.Btndelpro.Location = New System.Drawing.Point(249, 152)
        Me.Btndelpro.Margin = New System.Windows.Forms.Padding(2)
        Me.Btndelpro.Name = "Btndelpro"
        Me.Btndelpro.Size = New System.Drawing.Size(70, 23)
        Me.Btndelpro.TabIndex = 25
        Me.Btndelpro.Text = "Delete"
        Me.Btndelpro.UseVisualStyleBackColor = True
        Me.Btndelpro.Visible = False
        '
        'Btnviewpro
        '
        Me.Btnviewpro.Location = New System.Drawing.Point(376, 53)
        Me.Btnviewpro.Margin = New System.Windows.Forms.Padding(2)
        Me.Btnviewpro.Name = "Btnviewpro"
        Me.Btnviewpro.Size = New System.Drawing.Size(56, 23)
        Me.Btnviewpro.TabIndex = 26
        Me.Btnviewpro.Text = "View all"
        Me.Btnviewpro.UseVisualStyleBackColor = True
        Me.Btnviewpro.Visible = False
        '
        'Txteditqty
        '
        Me.Txteditqty.Location = New System.Drawing.Point(142, 47)
        Me.Txteditqty.Margin = New System.Windows.Forms.Padding(2)
        Me.Txteditqty.Name = "Txteditqty"
        Me.Txteditqty.Size = New System.Drawing.Size(76, 20)
        Me.Txteditqty.TabIndex = 36
        '
        'Txteditfeatures
        '
        Me.Txteditfeatures.Location = New System.Drawing.Point(142, 116)
        Me.Txteditfeatures.Margin = New System.Windows.Forms.Padding(2)
        Me.Txteditfeatures.Multiline = True
        Me.Txteditfeatures.Name = "Txteditfeatures"
        Me.Txteditfeatures.Size = New System.Drawing.Size(76, 19)
        Me.Txteditfeatures.TabIndex = 35
        '
        'Txteditprice
        '
        Me.Txteditprice.Location = New System.Drawing.Point(142, 81)
        Me.Txteditprice.Margin = New System.Windows.Forms.Padding(2)
        Me.Txteditprice.Name = "Txteditprice"
        Me.Txteditprice.Size = New System.Drawing.Size(76, 20)
        Me.Txteditprice.TabIndex = 34
        '
        'editnamepro
        '
        Me.editnamepro.Location = New System.Drawing.Point(142, 12)
        Me.editnamepro.Margin = New System.Windows.Forms.Padding(2)
        Me.editnamepro.Name = "editnamepro"
        Me.editnamepro.Size = New System.Drawing.Size(76, 20)
        Me.editnamepro.TabIndex = 33
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(37, 116)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 17)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "Features"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(37, 84)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 17)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "Price"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(34, 50)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(61, 17)
        Me.Label16.TabIndex = 30
        Me.Label16.Text = "Quantity"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(37, 13)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(45, 17)
        Me.Label17.TabIndex = 29
        Me.Label17.Text = "Name"
        '
        'Btnclredit
        '
        Me.Btnclredit.Location = New System.Drawing.Point(339, 152)
        Me.Btnclredit.Margin = New System.Windows.Forms.Padding(2)
        Me.Btnclredit.Name = "Btnclredit"
        Me.Btnclredit.Size = New System.Drawing.Size(56, 23)
        Me.Btnclredit.TabIndex = 28
        Me.Btnclredit.Text = "Clear"
        Me.Btnclredit.UseVisualStyleBackColor = True
        '
        'Btneditpro
        '
        Me.Btneditpro.Location = New System.Drawing.Point(157, 152)
        Me.Btneditpro.Margin = New System.Windows.Forms.Padding(2)
        Me.Btneditpro.Name = "Btneditpro"
        Me.Btneditpro.Size = New System.Drawing.Size(63, 23)
        Me.Btneditpro.TabIndex = 27
        Me.Btneditpro.Text = "Update"
        Me.Btneditpro.UseVisualStyleBackColor = True
        Me.Btneditpro.Visible = False
        '
        'Btnchkpro
        '
        Me.Btnchkpro.Location = New System.Drawing.Point(286, 50)
        Me.Btnchkpro.Name = "Btnchkpro"
        Me.Btnchkpro.Size = New System.Drawing.Size(70, 23)
        Me.Btnchkpro.TabIndex = 28
        Me.Btnchkpro.Text = "Check"
        Me.Btnchkpro.UseVisualStyleBackColor = True
        '
        'GVpro
        '
        Me.GVpro.AllowUserToAddRows = False
        Me.GVpro.AllowUserToDeleteRows = False
        Me.GVpro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GVpro.Location = New System.Drawing.Point(139, 263)
        Me.GVpro.Margin = New System.Windows.Forms.Padding(2)
        Me.GVpro.Name = "GVpro"
        Me.GVpro.ReadOnly = True
        Me.GVpro.RowTemplate.Height = 24
        Me.GVpro.Size = New System.Drawing.Size(180, 73)
        Me.GVpro.TabIndex = 27
        Me.GVpro.Visible = False
        '
        'Txtpro_id
        '
        Me.Txtpro_id.Location = New System.Drawing.Point(179, 55)
        Me.Txtpro_id.Margin = New System.Windows.Forms.Padding(2)
        Me.Txtpro_id.Name = "Txtpro_id"
        Me.Txtpro_id.Size = New System.Drawing.Size(76, 20)
        Me.Txtpro_id.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(63, 59)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 17)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Enter Pro_ID"
        '
        'Pnladdpro
        '
        Me.Pnladdpro.Controls.Add(Me.Label13)
        Me.Pnladdpro.Controls.Add(Me.Txtaddqty)
        Me.Pnladdpro.Controls.Add(Me.Btnclradd)
        Me.Pnladdpro.Controls.Add(Me.Btnaddpro)
        Me.Pnladdpro.Controls.Add(Me.Txtaddfeatures)
        Me.Pnladdpro.Controls.Add(Me.Txtaddprice)
        Me.Pnladdpro.Controls.Add(Me.addnamepro)
        Me.Pnladdpro.Controls.Add(Me.Label21)
        Me.Pnladdpro.Controls.Add(Me.Label22)
        Me.Pnladdpro.Controls.Add(Me.Label23)
        Me.Pnladdpro.Controls.Add(Me.Label24)
        Me.Pnladdpro.Location = New System.Drawing.Point(25, 43)
        Me.Pnladdpro.Margin = New System.Windows.Forms.Padding(2)
        Me.Pnladdpro.Name = "Pnladdpro"
        Me.Pnladdpro.Size = New System.Drawing.Size(464, 231)
        Me.Pnladdpro.TabIndex = 13
        Me.Pnladdpro.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(158, 11)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(121, 29)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Products"
        '
        'Txtaddqty
        '
        Me.Txtaddqty.Location = New System.Drawing.Point(181, 92)
        Me.Txtaddqty.Margin = New System.Windows.Forms.Padding(2)
        Me.Txtaddqty.Name = "Txtaddqty"
        Me.Txtaddqty.Size = New System.Drawing.Size(76, 20)
        Me.Txtaddqty.TabIndex = 12
        '
        'Btnclradd
        '
        Me.Btnclradd.Location = New System.Drawing.Point(376, 188)
        Me.Btnclradd.Margin = New System.Windows.Forms.Padding(2)
        Me.Btnclradd.Name = "Btnclradd"
        Me.Btnclradd.Size = New System.Drawing.Size(56, 19)
        Me.Btnclradd.TabIndex = 11
        Me.Btnclradd.Text = "Clear"
        Me.Btnclradd.UseVisualStyleBackColor = True
        '
        'Btnaddpro
        '
        Me.Btnaddpro.Location = New System.Drawing.Point(286, 188)
        Me.Btnaddpro.Margin = New System.Windows.Forms.Padding(2)
        Me.Btnaddpro.Name = "Btnaddpro"
        Me.Btnaddpro.Size = New System.Drawing.Size(70, 19)
        Me.Btnaddpro.TabIndex = 10
        Me.Btnaddpro.Text = "ADD"
        Me.Btnaddpro.UseVisualStyleBackColor = True
        '
        'Txtaddfeatures
        '
        Me.Txtaddfeatures.Location = New System.Drawing.Point(181, 171)
        Me.Txtaddfeatures.Margin = New System.Windows.Forms.Padding(2)
        Me.Txtaddfeatures.Multiline = True
        Me.Txtaddfeatures.Name = "Txtaddfeatures"
        Me.Txtaddfeatures.Size = New System.Drawing.Size(76, 19)
        Me.Txtaddfeatures.TabIndex = 9
        '
        'Txtaddprice
        '
        Me.Txtaddprice.Location = New System.Drawing.Point(181, 131)
        Me.Txtaddprice.Margin = New System.Windows.Forms.Padding(2)
        Me.Txtaddprice.Name = "Txtaddprice"
        Me.Txtaddprice.Size = New System.Drawing.Size(76, 20)
        Me.Txtaddprice.TabIndex = 8
        '
        'addnamepro
        '
        Me.addnamepro.Location = New System.Drawing.Point(181, 54)
        Me.addnamepro.Margin = New System.Windows.Forms.Padding(2)
        Me.addnamepro.Name = "addnamepro"
        Me.addnamepro.Size = New System.Drawing.Size(76, 20)
        Me.addnamepro.TabIndex = 5
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(68, 171)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(64, 17)
        Me.Label21.TabIndex = 3
        Me.Label21.Text = "Features"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(68, 131)
        Me.Label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(40, 17)
        Me.Label22.TabIndex = 2
        Me.Label22.Text = "Price"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(68, 95)
        Me.Label23.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(61, 17)
        Me.Label23.TabIndex = 1
        Me.Label23.Text = "Quantity"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(68, 60)
        Me.Label24.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(45, 17)
        Me.Label24.TabIndex = 0
        Me.Label24.Text = "Name"
        '
        'Pnldata
        '
        Me.Pnldata.Controls.Add(Me.Txtemail)
        Me.Pnldata.Controls.Add(Me.Label7)
        Me.Pnldata.Controls.Add(Me.Txtpass)
        Me.Pnldata.Controls.Add(Me.Label8)
        Me.Pnldata.Controls.Add(Me.empid)
        Me.Pnldata.Controls.Add(Me.Btnupd)
        Me.Pnldata.Controls.Add(Me.Dob)
        Me.Pnldata.Controls.Add(Me.Txtphone)
        Me.Pnldata.Controls.Add(Me.Txtaddress)
        Me.Pnldata.Controls.Add(Me.Txtname)
        Me.Pnldata.Controls.Add(Me.Label6)
        Me.Pnldata.Controls.Add(Me.Label5)
        Me.Pnldata.Controls.Add(Me.Label3)
        Me.Pnldata.Controls.Add(Me.Label2)
        Me.Pnldata.Controls.Add(Me.Label1)
        Me.Pnldata.Location = New System.Drawing.Point(494, 43)
        Me.Pnldata.Name = "Pnldata"
        Me.Pnldata.Size = New System.Drawing.Size(307, 358)
        Me.Pnldata.TabIndex = 15
        Me.Pnldata.Visible = False
        '
        'Txtemail
        '
        Me.Txtemail.Location = New System.Drawing.Point(165, 244)
        Me.Txtemail.Name = "Txtemail"
        Me.Txtemail.Size = New System.Drawing.Size(100, 20)
        Me.Txtemail.TabIndex = 30
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(38, 244)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 17)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Email"
        '
        'Txtpass
        '
        Me.Txtpass.Location = New System.Drawing.Point(165, 277)
        Me.Txtpass.Name = "Txtpass"
        Me.Txtpass.Size = New System.Drawing.Size(100, 20)
        Me.Txtpass.TabIndex = 28
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(38, 280)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 17)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Password"
        '
        'empid
        '
        Me.empid.AutoSize = True
        Me.empid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.empid.Location = New System.Drawing.Point(37, 57)
        Me.empid.Name = "empid"
        Me.empid.Size = New System.Drawing.Size(157, 20)
        Me.empid.TabIndex = 26
        Me.empid.Text = "Your Employee ID is "
        '
        'Btnupd
        '
        Me.Btnupd.Location = New System.Drawing.Point(123, 321)
        Me.Btnupd.Name = "Btnupd"
        Me.Btnupd.Size = New System.Drawing.Size(87, 23)
        Me.Btnupd.TabIndex = 25
        Me.Btnupd.Text = "Update"
        Me.Btnupd.UseVisualStyleBackColor = True
        '
        'Dob
        '
        Me.Dob.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dob.Location = New System.Drawing.Point(165, 134)
        Me.Dob.Name = "Dob"
        Me.Dob.Size = New System.Drawing.Size(100, 20)
        Me.Dob.TabIndex = 24
        '
        'Txtphone
        '
        Me.Txtphone.Location = New System.Drawing.Point(165, 211)
        Me.Txtphone.Name = "Txtphone"
        Me.Txtphone.Size = New System.Drawing.Size(100, 20)
        Me.Txtphone.TabIndex = 23
        '
        'Txtaddress
        '
        Me.Txtaddress.Location = New System.Drawing.Point(165, 173)
        Me.Txtaddress.Name = "Txtaddress"
        Me.Txtaddress.Size = New System.Drawing.Size(100, 20)
        Me.Txtaddress.TabIndex = 22
        '
        'Txtname
        '
        Me.Txtname.Location = New System.Drawing.Point(165, 92)
        Me.Txtname.Name = "Txtname"
        Me.Txtname.Size = New System.Drawing.Size(100, 20)
        Me.Txtname.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(38, 210)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 17)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Phone Number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(38, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 17)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 17)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Date of Birth"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(118, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 29)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Profile"
        '
        'Employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(813, 606)
        Me.Controls.Add(Me.Pnldata)
        Me.Controls.Add(Me.Pnlpro)
        Me.Controls.Add(Me.Pnladdpro)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Employee"
        Me.Text = "Employee"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Pnlpro.ResumeLayout(False)
        Me.Pnlpro.PerformLayout()
        Me.Pnludpro.ResumeLayout(False)
        Me.Pnludpro.PerformLayout()
        CType(Me.GVpro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnladdpro.ResumeLayout(False)
        Me.Pnladdpro.PerformLayout()
        Me.Pnldata.ResumeLayout(False)
        Me.Pnldata.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ProductsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ADDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EDITToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VIEWToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DELETEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProfileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Pnlpro As System.Windows.Forms.Panel
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Pnludpro As System.Windows.Forms.Panel
    Friend WithEvents Btndelpro As System.Windows.Forms.Button
    Friend WithEvents Btnviewpro As System.Windows.Forms.Button
    Friend WithEvents Txteditqty As System.Windows.Forms.TextBox
    Friend WithEvents Txteditfeatures As System.Windows.Forms.TextBox
    Friend WithEvents Txteditprice As System.Windows.Forms.TextBox
    Friend WithEvents editnamepro As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Btnclredit As System.Windows.Forms.Button
    Friend WithEvents Btneditpro As System.Windows.Forms.Button
    Friend WithEvents Btnchkpro As System.Windows.Forms.Button
    Friend WithEvents GVpro As System.Windows.Forms.DataGridView
    Friend WithEvents Txtpro_id As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Pnladdpro As System.Windows.Forms.Panel
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Txtaddqty As System.Windows.Forms.TextBox
    Friend WithEvents Btnclradd As System.Windows.Forms.Button
    Friend WithEvents Btnaddpro As System.Windows.Forms.Button
    Friend WithEvents Txtaddfeatures As System.Windows.Forms.TextBox
    Friend WithEvents Txtaddprice As System.Windows.Forms.TextBox
    Friend WithEvents addnamepro As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Pnldata As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Dob As System.Windows.Forms.DateTimePicker
    Friend WithEvents Txtphone As System.Windows.Forms.TextBox
    Friend WithEvents Txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents Txtname As System.Windows.Forms.TextBox
    Friend WithEvents Btnupd As System.Windows.Forms.Button
    Friend WithEvents Txtpass As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents empid As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Txtemail As System.Windows.Forms.TextBox
End Class
