Public Class Form1
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        txtName.Text = "Hello " & txtName.Text


    End Sub

    Private Sub btnMessage_Click(sender As Object, e As EventArgs) Handles btnMessage.Click
        MessageBox.Show("hello " & txtName.Text, "Message at the top")


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub




    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        Try
            Dim n1 As Integer
            Dim n2 As Integer


            n1 = CInt(txtSum1.Text)
            n2 = CInt(txtSum2.Text)

            txtSum3.Text = n1 + n2
        Catch ex As Exception

        End Try

    End Sub
End Class
