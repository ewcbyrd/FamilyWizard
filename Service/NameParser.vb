Public Class NameParser

    Public Shared Function ParseName(nameString As String) As PersonName

        Dim nameArray() As Char = nameString.ToCharArray()

        Dim element As String = ""
        Dim elementList As New ArrayList
        Dim pn As New PersonName

        For Each nameChar As Char In nameArray

            If Asc(nameChar) = 32 Then
                elementList.Add(element)
                element = ""
            Else
                element = element & nameChar
            End If
        Next

        elementList.Add(element)

        pn.Surname = elementList(elementList.Count - 1)

        Dim last As Integer = elementList.Count - 2
        For i = 0 To elementList.Count - 2
            If i = last Then
                pn.GivenName = pn.GivenName + elementList(i)
            Else
                pn.GivenName = pn.GivenName + elementList(i) + " "
            End If
        Next

        Return pn

    End Function

End Class
