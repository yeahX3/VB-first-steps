Imports System         '<---Imports Used in the "Save to file, Opening file" section
Imports System.IO
Public Class btnSharedP
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
    '--------------------------------------------------------------------------------------------------
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

    '--------------------------------------------------------------------------------------------------
    '--------------------------------TESTING FUCTIONS--------------------------------------------------
    Private Sub btnFunc_Click(sender As Object, e As EventArgs) Handles btnFunc.Click
        showMessage()

        Dim result As String = CType(SumNumbers(5, 6), String)

        txtOutput.Text = ""
        txtOutput.Text = txtOutput.Text & "The sum of 5 and 6 equals to: " & result & Environment.NewLine

        Dim number As Integer = 10
        paramByValue(number)
        txtOutput.Text = txtOutput.Text & "Passing 10 by Value does NOT change original: " & number & Environment.NewLine

        paramByReference(number)
        txtOutput.Text = txtOutput.Text & "Passing 10 by Reference DOES change original: " & number & Environment.NewLine


        txtOutput.Text = txtOutput.Text & "Function that receives many parameters 'sum 2,4,6,8': " & manyParamSum(2, 4, 6, 8) & Environment.NewLine




    End Sub


    ' FUNCTIONS MADE BY ME TO TEST
    Private Sub showMessage()
        MessageBox.Show("Message from inside a function", "Tittlebar")
    End Sub

    'NOTE: If declared as Sub, it cannot return a value
    Private Function SumNumbers(num1 As Integer, num2 As Integer)
        Return num1 + num2
    End Function

    'FUNCTION RECEIVES PARAMETER BY VALUE
    Private Function paramByValue(num1 As Integer)
        'changing value here will not affect tha value of original variable
        num1 = 35
    End Function


    'FUNCTION RECEIVES PARAMETER BY REFERENCE
    Private Function paramByReference(ByRef num1 As Integer)
        'Changing value here WILL affect original variable
        num1 = 40
    End Function


    'FUNCTION RECEIVES A VARIABLE AMOUNT OF PARAMETERS IN AN ARRAY, (AND SUMS THEM)
    Private Function manyParamSum(ByVal ParamArray numbers() As Integer)
        Dim sum As Integer

        For i As Integer = 0 To numbers.Length - 1
            sum = sum + numbers(i)
        Next
        Return sum
    End Function


    '--------------------------------------------------------------------------------------------------
    '--------------------------------IF, CASE, FOR, DoUNTIL,DoWHILE, ----------------------------------

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click

        Dim var1 As Integer

        Dim sampleAnswer As Boolean

        'SHORT IF
        If var1 = 18 Then sampleAnswer = True : sampleAnswer = False    '<--- equals is only one equal symbol

        'OTHER SHORT IF
        sampleAnswer = If(var1 >= 18, True, False)

        'REGULAR  IF
        If 20 > 10 Then
            var1 = 1
        Else
            var1 = 2
        End If


        'USING ELSE IF
        If 20 > 10 Then
            var1 = 1
        ElseIf 30 > 20 Then
            var1 = 2
        Else
            var1 = 3
        End If

        'CASE
        Dim intAge As Integer = 20
        Dim message As String

        Select Case intAge
            Case 1, 2, 3, 4
                message = "too young for school"
            Case 5
                message = "can go to Kindergarten"
            Case 6 To 18
                message = "go to grade " & intAge - 5
            Case Else           '<---------Case Else is equal to Default situation
                message = "Go to College"
        End Select

        'FOR
        For i As Integer = 1 To 10
            'print something
        Next

        'FOR WITH DIFFERENT INCREMENT
        For i As Integer = 1 To 50 Step 10
            If i = 40 Then Exit For  '<---To exit For loop prematurely. Also, Exit Sub can be used
        Next

        'FOR EACH (good to use with Arrays)
        Dim Employees = New String() {"Paul", "Sally", "Jack"}
        For Each person As String In Employees     'creating a variable of the same type, holds one position of the array at the time
            Console.WriteLine(person & Environment.NewLine) 'printing that variable
        Next

        'DO WHILE (Means loop while condition is true, break when condition is false)
        'DO UNTIL (Means loop while condition is False, break when condition is True)
        Dim numberGuessed As Integer = 0
        Do Until numberGuessed = 10
            numberGuessed += 1
        Loop




        'CREATE A RANDOM VALUE (in the range we want)
        Dim UpperBound = 0
        Dim LowerBound = 10
        Dim RandomValue = CInt(Math.Floor((UpperBound - LowerBound + 1) * Rnd())) + LowerBound


    End Sub

    '--------------------------------------------------------------------------------------------------
    '--------------------------------ARRAYS------------------------- ----------------------------------
    Private Sub btnArray_Click(sender As Object, e As EventArgs) Handles btnArray.Click
        Dim strOutput As String = ""

        'CREATING AN ARRAY 
        Dim customers() As String = {"Bob", "Sally", "Manny"}
        'CREATING AN ARRAY
        Dim Employees = New String() {"Paul", "Sally", "Jack"}

        'LOOK AT A SPECIFIC POSITION
        Console.WriteLine(customers(2))

        'SORT CUSTOMERS ALPHABETICALLY
        Array.Sort(customers)

        'REVERSE ARRAY
        Array.Reverse(customers)

        'CHANGE SIZE OF ARRAY PRESERVING CURRENT VALUES
        ReDim Preserve customers(5) '<--if the word Preserve was not included, i would get an empty array 

        'cycle through the elements        
        For Each person As String In Employees     'creating a variable of the same type, holds one position of the array at the time
            Console.WriteLine(person & Environment.NewLine) 'printing that variable
        Next

        'CREATE MULTI DIMENSIONAL ARRAY
        Dim matrix(4, 4) As String

        'POPULATE MULTI DIMENSIONAL ARRAY
        For i As Integer = 0 To 2
            For j As Integer = 0 To 2
                matrix(i, j) = i & j
                strOutput += (i & j & " ")
            Next
            strOutput += Environment.NewLine
        Next

        txtOutput.Text = strOutput
    End Sub

    '--------------------------------------------------------------------------------------------------
    '--------------------------------RANDON (IN A GIVEN RANGE)-----------------------------------------
    Private Sub btnRandom_Click(sender As Object, e As EventArgs) Handles btnRandom.Click
        'CREATE A RANDOM VALUE (in the range we want)
        Dim UpperBound = 0
        Dim LowerBound = 10
        Dim RandomValue = CInt(Math.Floor((UpperBound - LowerBound + 1) * Rnd())) + LowerBound

        txtOutput.Text = "Random vlue between 0 ans 10 is: " & RandomValue
    End Sub
    '--------------------------------------------------------------------------------------------------
    '--------------------------------ARRAYLIST---------------------------------------------------------

    Private Sub btnArrayList_Click(sender As Object, e As EventArgs) Handles btnArrayList.Click
        Dim strOutput As String = ""

        'CREATE ARRAYLIST
        Dim customers As New ArrayList

        'INPUT VALUES
        strOutput += "Inserting names'Bob' and 'John' "
        customers.Add("Bob")
        customers.Add("John")

        'SIZE
        strOutput += "Current size of ArrayList is: " & customers.Count & Environment.NewLine

        'MAX SIZE
        strOutput += "Maximun capaciyt is: " & customers.Capacity & Environment.NewLine

        'INSERTING AT A SPECIFIC POSITION
        strOutput += "Inserting name 'Vin Diesel' at position 1" & Environment.NewLine
        customers.Insert(1, "Vin Diesel")

        'REMOVING AN ELEMENT ASED ON ITS CONTENT
        strOutput += "Removing an element based on its content, rempoving John" & Environment.NewLine
        customers.Remove("John")

        'SORTING ELEMENTS ALPHABETICALLY
        strOutput += "Sorting elements alphabetically" & Environment.NewLine
        customers.Sort()

        'REVERSING ELEMENTS
        strOutput += "Reversing elements" & Environment.NewLine
        customers.Reverse()

        'SEARCHING IF ARRAYLIST CONTAINS A VALUE
        strOutput += "Searching if ArrayList contains Value 'Bob' : " & customers.Contains("Bob") & Environment.NewLine

        'INDEX OF A VALUE
        strOutput += "Searching index of Value 'Bob' : " & customers.IndexOf("Bob") & Environment.NewLine

        'COPYING ARRAYLIST INTO AN ARRAY
        strOutput += "Copying ArrayLst into an array" & Environment.NewLine
        Dim arrayCustomers(2) As String
        customers.CopyTo(arrayCustomers)

        For i As Integer = 0 To arrayCustomers.Length - 1
            strOutput += arrayCustomers(i) & Environment.NewLine
        Next

        txtOutput.Text = strOutput
    End Sub
    '--------------------------------------------------------------------------------------------------
    '--------------------------------ENUMERATIONS------------------------------------------------------
    'DECLARING AN ENUM (very importatnt to declare it outside any SubRoutine)
    Private Enum Season As Integer
        Spring = 0
        Summer = 1
        Fall = 2
        Winter = 3
    End Enum

    Private Sub btnEnum_Click(sender As Object, e As EventArgs) Handles btnEnum.Click
        Dim strOutput As String = ""

        'DECLARING A VARIABLE WITH OUR ENUM TYPE
        Dim currentSeason As Season

        'ASSIGNING A VALUE TO IT
        currentSeason = Season.Spring

        strOutput += "The current Season is " & currentSeason.ToString & Environment.NewLine


    End Sub

    '--------------------------------------------------------------------------------------------------
    '--------------------------------STRUCTURES, CLASSES, INHERITANCE, POLYMOPHISM---------------------
    'LIKE CLASSES IN JAVA
    'Keep structures outside Subroutines
    Public Structure Employee
        Public name As String
        Public position As String
        Public salary As Decimal

        Public ReadOnly Property fullInfo() As String
            Get
                Return name & " is a " & position & " and makes $" & salary & Environment.NewLine
            End Get
        End Property
    End Structure

    Private Sub btnStructures_Click(sender As Object, e As EventArgs) Handles btnStructures.Click
        Dim strOutput As String = ""

        strOutput += "Creating a structure called 'bobSmith' which has information about him'" & Environment.NewLine

        Dim bobSmith As Employee
        'populating information
        bobSmith.name = "Bob Smith"
        bobSmith.position = "Manager"
        bobSmith.salary = 50000

        'displaying information

        strOutput += bobSmith.name & " is a " & bobSmith.position & " and makes $" & bobSmith.salary & Environment.NewLine


        'Creating an instance of the class Animal
        Dim dog As New Animal With {
            .weight = 77.5,
            .height = 25.5,
            .speed = 30.0
            }

        dog.setName("10") 'Testing giving an invalid value for name

        strOutput += "Testing creating an instance of Animal Class" & Environment.NewLine
        strOutput += "The name of dog is: " & dog.getName() & Environment.NewLine


        strOutput += "Creating instance of Cat, who inherits from Animal" & Environment.NewLine



        'INHERITANCE---------------------------------
        Dim myCat As New Cat()
        myCat.setName("Mittens")

        strOutput += myCat.aboutCat()


        'POLYMORPHISM---------------------------------
        'A subclass(in this case Cat) can be refered by the type of its parent class
        strOutput += "Testing Polymorphism by refering to cat as Animal class" & Environment.NewLine
        strOutput += showDetails(myCat) 'Function declared outside this form (see at bottom of file)
        strOutput += testPoplymorphism(myCat) 'Function declared outside this form (see at bottom of file)



        txtOutput.Text = strOutput

    End Sub
    Public Function showDetails(theAnimal As Animal)
        Return theAnimal.AnimalInfo()
    End Function

    Public Function testPoplymorphism(beast As Animal) As String
        'Testing by referencing by parent class, then calling overridable function
        Return beast.getAnimalType()
    End Function

    '--------------------------------------------------------------------------------------------------
    '--------------------------------SHARED PROPERTIES-------------------------------------------------
    'Shared properties is equal to static variables in Java, in java define a class variable as
    'static to have it shared by all instances of the class (one copy for all opposed to one copy per instance)
    'The Animal Class (parent class) has a 'shared' variable (static in java) called numOfAnimals, 
    'that is used to count how many instances have been created.
    Private Sub btnClasses_Click(sender As Object, e As EventArgs) Handles btnClasses.Click

        Dim strOutput As String = ""

        strOutput += CType(Animal.numOfAnimals, String) & " instances o Animal or its subclasses have been created " & Environment.NewLine

        strOutput += Animal.createInstance()
        strOutput += Animal.createInstance()
        strOutput += Animal.createInstance()

        strOutput += CType(Animal.numOfAnimals, String) & " instances o Animal or its subclasses have been created" & Environment.NewLine
        txtOutput.Text = strOutput

    End Sub
    '--------------------------------------------------------------------------------------------------
    '-----------------------SAVING TO FILE,APPENDING TO FILE, OPENING FILE-----------------------------
    'Imports System         <---This imports are needed, but must be on top line of file
    'Imports System.IO
    Private Sub btnFiles_Click(sender As Object, e As EventArgs) Handles btnFiles.Click
        Dim strOutput As String = ""

        Dim linesOfText() As String = {"Line1", "Line2", "Line3"}       '<---This contains the text to be saved

        'showing original content to form
        strOutput += "writting on file" & Environment.NewLine
        For Each str1 As String In linesOfText
            strOutput += str1 & Environment.NewLine
        Next


        Dim myDocPath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) '<--- Save to my documents folder, an folder path is also allowed

        'Declaring file to be writen into
        Using outputFile As New StreamWriter(myDocPath & Convert.ToString("\myOutputFile.txt"))
            For Each line As String In linesOfText  'For each loop, save into variable 'line'
                outputFile.WriteLine(line)             'Write current content of variable 'line'
            Next
        End Using

        strOutput += "Written on file" & Environment.NewLine & "Appending " & Environment.NewLine

        'Appending to file
        Using outputFile As New StreamWriter(myDocPath & Convert.ToString("\myOutputFile.txt"), True) '<-- True means it will append instead of overwritting
            outputFile.WriteLine("New line" & Environment.NewLine)
        End Using

        'Reading from file

        Try
            Using strInput As New StreamReader(myDocPath & Convert.ToString("\myOutputFile.txt"))
                Dim line As String
                line = strInput.ReadToEnd()

                strOutput += line & Environment.NewLine

            End Using
        Catch ex As Exception
            MessageBox.Show("Couldn'True read file", "Error")
        End Try



        txtOutput.Text = strOutput



    End Sub

    '--------------------------------------------------------------------------------------------------
    '-----------------------------------MESSAGEBOX-----------------------------------------------------
    Private Sub btnMsgBox_Click(sender As Object, e As EventArgs) Handles btnMsgBox.Click
        Dim strOutput As String = ""
        'Multiple icons can be used:
        'Asterisk, Error, Exclamation, Hand, Information, 
        'Question, Stop, Warning, None

        'Multiple buttons can be used:
        'AbortRetryIgnore, Ok, OkCancel, RetryCancel, YesNo, YesNoCancel

        'Can set the default highlighted button wit:
        'Button1, Button2, Button3

        ' A more complicated messagebox
        MessageBox.Show("Message", "message on title", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)

        'To find out which button the user pressed, compare it with an If statement
        If MessageBox.Show("Message", "message on title", MessageBoxButtons.AbortRetryIgnore,
                           MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) =
                                        System.Windows.Forms.DialogResult.Abort Then
            strOutput += "The user pressed the 'Abort button'"

        Else
            strOutput += "Something else was clicked"

        End If
    End Sub

    '--------------------------------------------------------------------------------------------------
    '-----------------------------------OPEN FILE DIALOG WINDOW----------------------------------------
    Private Sub btnOpenDialog_Click(sender As Object, e As EventArgs) Handles btnOpenDialog.Click
        Dim strOutput As String = ""

        'Creating instance that contains an openFileDialog
        Dim OpenFileDialogEx As New OpenFileDialog() With {
            .Filter = "Text Documents (*.txt)|*.txt|All Files(*.*)|*.*",  '<-- | means 'OR',this filers what type of files to search for.
            .FilterIndex = 2,  '<-- which filter is used by default, to choose 'All files *.*' use number 2 (starts counting from zero?)
            .Title = "Open important file"
            }

        'Now to determine which file was chosen
        Dim fileSelected As String  '<-- This will hold the file name

        If OpenFileDialogEx.ShowDialog = System.Windows.Forms.DialogResult.OK Then '<if user pressed OK button means a file was choosen
            'but we still are prone to find an error

            Try
                fileSelected = OpenFileDialogEx.FileName '<--obtain the name of the file selected
                strOutput += "File Selected : " & fileSelected & Environment.NewLine
            Catch ex As Exception
                MessageBox.Show("Error Opening file", "Error")
            End Try
        End If
        txtOutput.Text = strOutput
    End Sub

End Class

