Public Class login

    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        If Txtid.Text = "" Or Txtpass.Text = "" Then
            MsgBox("enter all the fields")
        ElseIf Txtid.Text = "admin1" And Txtpass.Text = "admin@123" Then
            Admin.Show()
            Me.Hide()
        Else
            connect()
            cmd.CommandText = "select * from Tbl_Emp where Phone=" + Txtid.Text + " and Password='" + Txtpass.Text + "'"
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                While dr.Read()
                    id = dr.Item(0)
                End While
                dr.Close()
                cnn.Close()
                Employee.Show()
                Me.Hide()
            Else
                MsgBox("Invalid inputs")
            End If
            dr.Close()
            cnn.Close()
        End If
    End Sub
End Class