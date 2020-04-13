Imports Microsoft.VisualBasic

Friend Class Animal
    Public height As Decimal = 0.0
    Public weight As Decimal = 0.0
    Public speed As Decimal = 0.0

    Private name As String


    'Properties restict acces by giving Get and Set methods
    'good for when we want to return more than just the content of the Variable name
    'readOnly vs WriteOnly
    'Also good for Encapsulation, we can test the type of incomming value before assigning it
    Public ReadOnly Property getName() As String
        Get
            Return name
        End Get
    End Property

    Public Sub setName(value As String)
        If IsNumeric(value) Then
            MessageBox.Show("Testing Error by entering invalid data", "Error")
        Else
            name = value
        End If

    End Sub

    Public Function AnimalInfo()
        Return "The name is: " & getName() & Environment.NewLine
    End Function

    '--------------------------------------------------------------------------------------------------
    '--------------------------------CONSTRUCTOR-------------------------------------------------------

    'constructors are called 'New()'  and can have a parameter sent
    Public Sub New(Optional ht As Decimal = 0.0,
                   Optional wt As Decimal = 0.0,
                   Optional spd As Decimal = 0.0,
                   Optional nam As String = "Unknown")
        height = ht
        weight = wt
        speed = spd
        name = nam
    End Sub


    'This function is 'Overridable' by sub-clasess
    Public Overridable Function Run() As String     'returns a String
        Return name & " Runs " & speed & "KPH"

    End Function
End Class

