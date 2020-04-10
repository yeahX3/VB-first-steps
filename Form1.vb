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
            Dim firstNum As Integer
            Dim secondNum As Integer


            firstNum = CInt(txtSum1.Text)
            secondNum = CInt(txtSum2.Text)

            txtSum3.Text = CStr(firstNum + secondNum)

        Catch ex As System.InvalidCastException
            MessageBox.Show("The value entered should be a number", "Error")

        Catch ex As Exception
            MessageBox.Show("An ivalid error occurred", "Error")
        End Try

    End Sub
End Class

