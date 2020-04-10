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


            firstNum = CInt(txtSum1.Text)               'Casting types
            secondNum = CInt(txtSum2.Text)

            txtSum3.Text = CStr(firstNum + secondNum)

        Catch ex As System.InvalidCastException
            MessageBox.Show("The value entered should be a number", "Error")
            Console.WriteLine("Error shown in programmer's console: a value different than a number was entered")
        Catch ex As Exception
            MessageBox.Show("An ivalid error occurred", "Error")
            Console.WriteLine("Error shown in programmer's console: Unlnown error")
        End Try

    End Sub

    '-----------------------------------------------------------------------------------------------
    '--------------------------------TESTING MATH LIBRARY-------------------------------------------


    Private Sub btnDivision_Click(sender As Object, e As EventArgs) Handles btnDivision.Click
        Dim FirstIntNumber As Integer
        Dim SecondIntNumber As Integer

        Dim strResult As String

        strResult = strResult & "Absolute Value of (-20) is: " & Math.Abs(-20) & Environment.NewLine
        strResult = strResult & "Ceiling Value of (2.6) is: " & Math.Ceiling(2.6) & Environment.NewLine
        strResult = strResult & "Floor Value of (2.6) is: " & Math.Floor(2.6) & Environment.NewLine
        strResult = strResult & "Biggest Value between 2 and 7 is : " & Math.Max(2, 7) & Environment.NewLine
        strResult = strResult & "2 to the power of 4 is : " & Math.Pow(2, 4) & Environment.NewLine
        strResult = strResult & "Square root of 16 is: " & Math.Sqrt(16) & Environment.NewLine
        strResult = strResult & "Rounding 7.3 results in: " & Math.Round(7.3) & Environment.NewLine

        txtMathLibrary.Text = CType(strResult, String)
    End Sub
End Class


