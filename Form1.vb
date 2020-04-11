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


        Dim strResult As String
        strResult = ""

        strResult = strResult & "Absolute Value of (-20) is: " & Math.Abs(-20) & Environment.NewLine
        strResult = strResult & "Ceiling Value of (2.6) is: " & Math.Ceiling(2.6) & Environment.NewLine
        strResult = strResult & "Floor Value of (2.6) is: " & Math.Floor(2.6) & Environment.NewLine
        strResult = strResult & "Biggest Value between 2 and 7 is : " & Math.Max(2, 7) & Environment.NewLine
        strResult = strResult & "2 to the power of 4 is : " & Math.Pow(2, 4) & Environment.NewLine
        strResult = strResult & "Square root of 16 is: " & Math.Sqrt(16) & Environment.NewLine
        strResult = strResult & "Rounding 7.3 results in: " & Math.Round(7.3) & Environment.NewLine

        txtOutput.Text = CType(strResult, String)
    End Sub


    '-----------------------------------------------------------------------------------------------
    '--------------------------------TESTING STRING LIBRARY-----------------------------------------

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim strResult As String
        strResult = ""

        Dim strSample = "A laptop computer"

        strResult = strResult & "The original string is: " & strSample & Environment.NewLine
        strResult = strResult & "The length of this string is: " & strSample.Length & Environment.NewLine

        'FIRST n CHARACTERS IN A STRING
        strResult = strResult & "The first four characters are: " & strSample.Substring(0, 4) & Environment.NewLine

        'REPLACING A SUBSTRING
        strResult = strResult & "Replacing 'Computer for Laptop: " & strSample.Replace("laptop", "Computer") & Environment.NewLine

        'SEARCHING FOR FIRST INSTANCE A CHARACTER OR SUBSTRING
        strResult = strResult & "Searching for the first 'i' in 'Merchandise'" & InStr(1, "Merchandise", "i", CompareMethod.Text) & Environment.NewLine 'n4 = show 4 decimals after point

        'FORMATTING NUMBER OUTPUTS
        strResult = strResult & "Formatting 3123.14159 as Thousands:  " & String.Format("{0:n3}", 3123.14159) & Environment.NewLine 'n4 = show 4 decimals after point
        strResult = strResult & "Formatting 3123.14159  as Currency:  " & String.Format("{0:c}", 3123.14159) & Environment.NewLine 'n4 = show 4 decimals after point
        strResult = strResult & "Formatting 3123.14159  with 5 digits and one decimal:  " & String.Format("{0:00000.0}", 3123.14159) & Environment.NewLine 'n4 = show 4 decimals after point
        'Other modifiers
        'g  Displays without the Thousands separator
        'f  Displays with at least one number at Left ad Right of decimal point
        'p  Displays the number times 100 with the Percent sign next to it
        'e  Displays value as Exponential notation



        'JOINING ELEMENT IN AN ARRAY OF STRING
        Dim arrayEmployees(0 To 2) As String  'Array of fixed length
        arrayEmployees(0) = "Bob"
        arrayEmployees(1) = "Sally"
        arrayEmployees(2) = "Paul"
        Dim strEmployees As String = Join(arrayEmployees, ", ") 'join all elements separated by a comma and a space
        strResult = strResult & "Joining an array of employee names:  " & strEmployees & Environment.NewLine


        'ARRAY TO STRING, ELEMETS SPLITTED BY A GIVENCHARACTERS
        strResult = strResult & "Splitting elements in an Array:" & Environment.NewLine
        'Splitting an array of strings by a set of characters (in this case, a comma and a space)
        arrayEmployees = Split(strEmployees, ", ") 'Now the String is an Array of strings
        'Displaying the characters
        For i As Integer = 0 To arrayEmployees.Length - 1
            strResult = strResult & "Employee: " & arrayEmployees(i) & Environment.NewLine
        Next


        'GETTING n CHARACTERS AT THE LEFT
        strResult = strResult & "Getting 3 characters at the left:  " & Strings.Left(strSample, 3) & Environment.NewLine

        'GETTING n CHARACTERS AT THE RIGHT
        strResult = strResult & "Getting 3 characters at the right:  " & Strings.Right(strSample, 3) & Environment.NewLine

        'UPPERCASE
        strResult = strResult & "Display string to uppercase  " & Strings.UCase(strSample) & Environment.NewLine

        'LOWERCASE
        strResult = strResult & "Display string to lowercase  " & Strings.LCase(strSample) & Environment.NewLine

        'REVERSE
        strResult = strResult & "Display string to uppercase  " & StrReverse(strSample) & Environment.NewLine

        'COMPARING
        strResult = strResult & "Comparing strings 'Dog' and 'Cat' " & StrComp("Dog", "Cat") & Environment.NewLine

        'TRIM EMPTY SPACES
        strResult = strResult & "Trimming spaces around '   a string   ': " & Trim("   a string   ") & Environment.NewLine

        'LEFT TRIM
        strResult = strResult & "Trimming spaces left side of '   a string   ': " & LTrim("   a string   ") & Environment.NewLine

        'RIGHT TRIM
        strResult = strResult & "Trimming spaces right side of '   a string   ': " & RTrim("   a string   ") & Environment.NewLine

        txtOutput.Text = strResult

        'MISC
        'Tips on using Trace
        'https://docs.microsoft.com/en-us/visualstudio/debugger/using-tracepoints?view=vs-2019

    End Sub
    '-----------------------------------------------------------------------------------------------
    '--------------------------------FORMATTING DATE TYPE----------------------------------------------

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnDateType.Click
        Dim strResult As String
        strResult = ""

        'SETTING CURRENT DATE
        Dim dteCurrent = Now

        'MONTH
        strResult = strResult & "Current Month is: " & dteCurrent.Month & Environment.NewLine

        'DAY (Actualy shows date)
        strResult = strResult & "Current day is: " & dteCurrent.Day & Environment.NewLine

        'YEAR
        strResult = strResult & "Current Year is: " & dteCurrent.Year & Environment.NewLine

        'HOUR
        strResult = strResult & "Current Hour is: " & dteCurrent.Hour & Environment.NewLine

        'MINUTE
        strResult = strResult & "Current Minute is: " & dteCurrent.Minute & Environment.NewLine

        'SECOND
        strResult = strResult & "Current Second is: " & dteCurrent.Second & Environment.NewLine

        'DAY(name of the day)
        strResult = strResult & "Current Day (name of day) is: " & dteCurrent.ToString("dddd") & Environment.NewLine

        'MONTH
        strResult = strResult & "Current Month (name of month) is: " & dteCurrent.ToString("MMMM") & Environment.NewLine

        'CREATING A CUSTOM DATE
        Dim dteImportantDate = #12/21/1974 11:32:00 AM#
        strResult = strResult & "Made up date: " & dteImportantDate & Environment.NewLine

        'PRINTING TIME IN LONG FORMAT
        strResult = strResult & "Time in Long format: " & dteImportantDate.ToLongTimeString & Environment.NewLine

        'PRINTING TIME IN SHORT FORMAT
        strResult = strResult & "Time in Short format: " & dteImportantDate.ToShortTimeString & Environment.NewLine


        'PRINTING DATE IN LONG FORMAT
        strResult = strResult & "Date in Long format: " & dteImportantDate.ToLongDateString & Environment.NewLine

        'PRINTING DATE IN SHORT FORMAT
        strResult = strResult & "Date in Short format: " & dteImportantDate.ToShortDateString & Environment.NewLine


        txtOutput.Text = strResult

    End Sub
End Class

