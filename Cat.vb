Friend Class Cat
    Inherits Animal  'Inherits is equal to 'Extends' in Java

    Public Function Cleans() As String
        Return "Cat is cleaning itself"
    End Function

    Public Function aboutCat() As String
        Return AnimalInfo() & Cleans() & Environment.NewLine
    End Function
End Class
