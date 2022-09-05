Public Class Bill
    Public flg As Integer = 0
    Public q As Integer
    Public Sub clr()
        TxtCphone.Text = ""
        TxtCname.Text = ""
        TxtCaddress.Text = ""
        TxtPname.Text = ""
        Txtprice.Text = ""
        Txtqty.Text = ""
        Txttotal.Text = ""
        Txtpid.Text = ""
        Txtpid.ReadOnly = False
    End Sub

    Private Sub BillToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BillToolStripMenuItem.Click
        Pnlbill.Visible = True
        Pnlreport.Visible = False
    End Sub

    Private Sub ReToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReToolStripMenuItem.Click
        Pnlbill.Visible = False
        Pnlreport.Visible = True
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        clr()
    End Sub

    Private Sub Btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnsearch.Click
        If Txtpid.Text = "" Then
            MsgBox("Please enter Product ID")
        Else
            connect()
            cmd.CommandText = "select * from Tbl_Pro where Pro_ID=" + Txtpid.Text + ""
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                While dr.Read()
                    TxtPname.Text = dr.Item(1)
                    q = dr.Item(2)
                    Txtprice.Text = dr.Item(3)
                End While
                Txtpid.ReadOnly = True
                dr.Close()
            Else
                MsgBox("No product found")
                Txtpid.Text = ""
            End If
            cnn.Close()
        End If
    End Sub

    Private Sub Btnbill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnbill.Click
        If TxtCphone.Text = "" Or TxtCname.Text = "" Or TxtCaddress.Text = "" Or Txtqty.Text = "" Or Txtpid.Text = "" Then
            MsgBox("Please fill all the fields")
        Else
            connect()
            cmd.CommandText = "insert into Tbl_Bill values('" + TxtCname.Text + "','" + TxtCaddress.Text + "'," + TxtCphone.Text + "," + Txtpid.Text + ",'" + TxtPname.Text + "'," + Txtprice.Text + "," + Txtqty.Text + "," + Txttotal.Text + ",'" + MOP.SelectedText + "')"
            cmd.ExecuteNonQuery()
            q = q - CInt(Txtqty.Text)
            cmd.CommandText = "update Tbl_Pro set Qty=" + q.ToString + " where Pro_ID=" + Txtpid.Text + ""
            cmd.ExecuteNonQuery()
            MsgBox("Bill Genrated")
            cnn.Close()
            clr()
        End If
    End Sub

    Private Sub Txtqty_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txtqty.TextChanged
        If Txtqty.Text = "" Then
            clr()
        Else
            Txttotal.Text = CInt(Txtqty.Text) * CInt(Txtprice.Text)
            If flg = 1 Then
                Txttotal.Text = CInt(Txttotal.Text) - 0.05
            End If
        End If
    End Sub

    Private Sub TxtCphone_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCphone.TextChanged
        If TxtCphone.Text = "" Then
            clr()
        Else
            connect()
            cmd.CommandText = "select * from Tbl_Bill where Cphone=" + TxtCphone.Text + ""
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                flg = 1
                While dr.Read()
                    TxtCname.Text = dr.Item(1)
                    TxtCaddress.Text = dr.Item(2)
                End While
                dr.Close()
            End If
            cnn.Close()
        End If
    End Sub
End Class