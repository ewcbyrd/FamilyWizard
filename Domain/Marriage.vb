Public Class Marriage

    Public Property Spouse As Person
    Public Property Marriage As MarriageEvent

    Public Sub New()
        Spouse = New Person
        Marriage = New MarriageEvent
    End Sub

End Class
