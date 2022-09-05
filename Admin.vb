Public Class Admin
    Public Sub clr()
        Txtaddname.Text = ""
        Txtaddress.Text = ""
        Txtaddphone.Text = ""

        Txteditname.Text = ""
        Txteditaddress.Text = ""
        Txteditphone.Text = ""
        Txtempid.Text = ""
        Txtempid.ReadOnly = False

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
        Pnladdpro.Visible = False
        Pnladdemp.Visible = False
        Pnlemp.Visible = False
        Pnlpro.Visible = False
        Pnludpro.Visible = False
        Pnlupemp.Visible = False
        Txtempid.ReadOnly = False
        Txtpro_id.ReadOnly = False
    End Sub
        
    Private Sub ADDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADDToolStripMenuItem.Click
        view()
        Pnladdemp.Visible = True
        Pnlemp.Visible = False
    End Sub

    Private Sub DELETEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DELETEToolStripMenuItem.Click
        view()
        Pnladdemp.Visible = False
        Pnlemp.Visible = True
        Btndelemp.Visible = True
        Btneditemp.Visible = False
        Btnviewemp.Visible = False
    End Sub

    Private Sub VIEWToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VIEWToolStripMenuItem.Click
        view()
        Pnladdemp.Visible = False
        Pnlemp.Visible = True
        Btneditemp.Visible = False
        Btndelemp.Visible = False
        Btnviewemp.Visible = True
    End Sub

    Private Sub EDITToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EDITToolStripMenuItem.Click
        view()
        Pnladdemp.Visible = False
        Pnlemp.Visible = True
        Btneditemp.Visible = True
        Btndelemp.Visible = False
        Btnviewemp.Visible = False
    End Sub

    Private Sub ADDToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADDToolStripMenuItem1.Click
        view()
        Pnladdpro.Visible = True
        Pnlpro.Visible = False
    End Sub

    Private Sub EDITToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EDITToolStripMenuItem1.Click
        view()
        Pnladdpro.Visible = False
        Pnlpro.Visible = True
        Btneditpro.Visible = True
        Btndelpro.Visible = False
        Btnviewpro.Visible = False
    End Sub

    Private Sub VIEWToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VIEWToolStripMenuItem1.Click
        view()
        Pnladdpro.Visible = False
        Pnlpro.Visible = True
        Btndelpro.Visible = False
        Btneditpro.Visible = False
        Btnviewpro.Visible = True
    End Sub

    Private Sub DELETEToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DELETEToolStripMenuItem1.Click
        view()
        Pnladdpro.Visible = False
        Pnlpro.Visible = True
        Btndelpro.Visible = True
        Btneditpro.Visible = False
        Btnviewpro.Visible = False
    End Sub

    Private Sub ReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportToolStripMenuItem.Click
        Bill.Show()
    End Sub

    Private Sub Btnaddemp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnaddemp.Click
        If Txtaddname.Text = "" Or Txtaddphone.Text = "" Or Txtaddress.Text = "" Or add_dob.Checked = False Then
            MsgBox("please enter all the fields")
        Else
            connect()
            cmd.CommandText = "insert into Tbl_Emp values('" + Txtaddname.Text + "','" + add_dob.Text + "','" + Txtaddress.Text + "'," + Txtaddphone.Text + ",'" + Txtaddemail.Text + "','Null','Active')"
            cmd.ExecuteNonQuery()
            MsgBox("Employee added")
            clr()
            cnn.Close()
        End If
    End Sub

    Private Sub Btneditemp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btneditemp.Click
        If Txteditname.Text = "" Or Txteditphone.Text = "" Or Txteditaddress.Text = "" Or editdob.Checked = False Or Txtempid.Text = "" Then
            MsgBox("please enter all the fields")
        Else
            connect()
            cmd.CommandText = "update Tbl_Emp set Name='" + Txteditname.Text + "', DOB='" + editdob.Text + "',Address='" + Txteditaddress.Text + "', Phone=" + Txteditphone.Text + ", Email='" + Txteditemail.Text + "' where Emp_ID=" + Txtempid.Text + ""
            cmd.ExecuteNonQuery()
            MsgBox("Employee Updated")
            clr()
            cnn.Close()
        End If
    End Sub

    Private Sub Btndelemp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btndelemp.Click
        connect()
        cmd.CommandText = "update Tbl_Emp set status='Inactive' where Emp_ID=" + Txtempid.Text + ""
        cmd.ExecuteNonQuery()
        MsgBox("Employee deleted")
        clr()
        cnn.Close()
    End Sub

    Private Sub Btnchkemp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnchkemp.Click
        If Txtempid.Text = "" Then
            MsgBox("Please enter Employee ID")
        Else
            connect()
            cmd.CommandText = "select * from Tbl_Emp where Emp_ID=" + Txtempid.Text + " and Status='Active'"
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                Pnlupemp.Visible = True
                While dr.Read()
                    Txteditname.Text = dr.Item(1)
                    editdob.Value = dr.Item(2)
                    Txteditaddress.Text = dr.Item(3)
                    Txteditphone.Text = dr.Item(4)
                    Txteditemail.Text = dr.Item(5)
                End While
                Txtempid.ReadOnly = True
                dr.Close()
            Else
                MsgBox("No record found")
                Txtempid.Text = ""
            End If
            cnn.Close()
        End If
    End Sub

    Private Sub Btnaddpro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnaddpro.Click
        If addnamepro.Text = "" Or Txtaddprice.Text = "" Or Txtaddqty.Text = "" Or Txtaddfeatures.Text = "" Then
            MsgBox("please enter all the fields")
        Else
            connect()
            cmd.CommandText = "insert into Tbl_Pro values('" + addnamepro.Text + "'," + Txtaddprice.Text + "," + Txtaddqty.Text + ",'" + Txtaddfeatures.Text + "','Active')"
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

    Private Sub Btnviewemp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnviewemp.Click
        GVemp.Visible = True
        clr()
    End Sub

    Private Sub Btnviewpro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnviewpro.Click
        GVpro.Visible = True
        clr()
    End Sub

    Private Sub Bntaddclr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bntaddclr.Click, Btnclradd.Click, Btneditclr.Click, Btnclredit.Click
        clr()
    End Sub
End Class