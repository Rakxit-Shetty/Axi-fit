Public Class Employee
    Public Sub clr()
        addnamepro.Text = ""
        Txtaddprice.Text = ""
        Txtaddqty.Text = ""
        Txtaddfeatures.Text = ""

        editnamepro.Text = ""
        Txteditprice.Text = ""
        Txteditqty.Text = ""
        Txteditfeatures.Text = ""
        Txtpro_id.Text = ""
        Txtpro_id.ReadOnly = False
    End Sub
    Public Sub view()
        clr()
        Pnladdpro.Visible = False
        Pnlpro.Visible = False
        Pnludpro.Visible = False
        Pnldata.Visible = False
        Txtpro_id.ReadOnly = False
    End Sub

    Private Sub Btnaddpro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnaddpro.Click
        If addnamepro.Text = "" Or Txtaddprice.Text = "" Or Txtaddqty.Text = "" Or Txtaddfeatures.Text = "" Then
            MsgBox("please enter all the fields")
        Else
            connect()
            cmd.CommandText = "insert into Tbl_Pro values('" + addnamepro.Text + "'," + Txtaddqty.Text + "," + Txtaddprice.Text + ",'" + Txtaddfeatures.Text + "','Active')"
            cmd.ExecuteNonQuery()
            MsgBox("Product added")
            clr()
            cnn.Close()
        End If
    End Sub

    Private Sub Btneditpro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btneditpro.Click
        If editnamepro.Text = "" Or Txteditprice.Text = "" Or Txteditqty.Text = "" Or Txteditfeatures.Text = "" Then
            MsgBox("please enter all the fields")
        Else
            connect()
            cmd.CommandText = "update Tbl_Pro set Name='" + editnamepro.Text + "',Price=" + Txteditprice.Text + ",Qty=" + Txteditqty.Text + ",Features='" + Txteditfeatures.Text + "' where Pro_ID=" + Txtpro_id.Text + ""
            cmd.ExecuteNonQuery()
            MsgBox("Product Updated")
            clr()
            cnn.Close()
        End If
    End Sub

    Private Sub Btndelpro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btndelpro.Click
        connect()
        cmd.CommandText = "update Tbl_Pro set status='Inactive' where Pro_ID=" + Txtpro_id.Text + ""
        cmd.ExecuteNonQuery()
        MsgBox("Product deleted")
        clr()
        cnn.Close()
    End Sub

    Private Sub Btnchkpro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnchkpro.Click
        If Txtpro_id.Text = "" Then
            MsgBox("Please enter Product ID")
        Else
            connect()
            cmd.CommandText = "select * from Tbl_Pro where Pro_ID=" + Txtpro_id.Text + ""
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                Pnludpro.Visible = True
                While dr.Read()
                    editnamepro.Text = dr.Item(1)
                    Txteditqty.Text = dr.Item(2)
                    Txteditprice.Text = dr.Item(3)
                    Txteditfeatures.Text = dr.Item(4)
                End While
                Txtpro_id.ReadOnly = True
                dr.Close()
            Else
                MsgBox("No product found")
                Txtpro_id.Text = ""
            End If
            cnn.Close()
        End If
    End Sub

    Private Sub ADDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADDToolStripMenuItem.Click
        view()
        Pnladdpro.Visible = True
        Pnlpro.Visible = False
    End Sub

    Private Sub EDITToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EDITToolStripMenuItem.Click
        view()
        Pnladdpro.Visible = False
        Pnlpro.Visible = True
        Btneditpro.Visible = True
        Btndelpro.Visible = False
        Btnviewpro.Visible = False
    End Sub

    Private Sub VIEWToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VIEWToolStripMenuItem.Click
        view()
        Pnladdpro.Visible = False
        Pnlpro.Visible = True
        Btndelpro.Visible = False
        Btneditpro.Visible = False
        Btnviewpro.Visible = True
    End Sub

    Private Sub DELETEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DELETEToolStripMenuItem.Click
        view()
        Pnladdpro.Visible = False
        Pnlpro.Visible = True
        Btndelpro.Visible = True
        Btneditpro.Visible = False
        Btnviewpro.Visible = False
    End Sub

    Private Sub ProfileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProfileToolStripMenuItem.Click
        view()
        Pnldata.Visible = True
    End Sub

    Private Sub ReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportToolStripMenuItem.Click
        view()
        Bill.Show()
    End Sub

    Private Sub Btnclradd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnclradd.Click, Btnclredit.Click
        clr()
    End Sub

    Private Sub Employee_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        cmd.CommandText = "select * from Tbl_Emp where Emp_ID=" + id.ToString + ""
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            While dr.Read()
                Txtname.Text = dr.Item(1)
                Dob.Value = dr.Item(2)
                Txtaddress.Text = dr.Item(3)
                Txtphone.Text = dr.Item(4)
                Txtemail.Text = dr.Item(5)
                Txtpass.Text = dr.Item(6)
            End While
            dr.Close()
            cnn.Close()
        End If
        dr.Close()
        cnn.Close()
        empid.Text = "You're Employee ID is:" + id.ToString
    End Sub

    Private Sub Btnupd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnupd.Click
        If Txtname.Text = "" Or Txtaddress.Text = "" Or Txtemail.Text = "" Or Txtphone.Text = "" Or Txtpass.Text = "" Then
            MsgBox("Please fill all the fields")
        Else
            connect()
            cmd.CommandText = "update Tbl_Emp set Name='" + Txtname.Text + "',DOB='" + Dob.Text + "',Address='" + Txtaddress.Text + "',Phone=" + Txtphone.Text + ",Email='" + Txtemail.Text + "',Password='" + Txtpass.Text + "' where Emp_ID=" + id.ToString + ""
            cmd.ExecuteReader()
            MsgBox("You're Details Updated...")
            cnn.Close()
        End If
    End Sub
End Class