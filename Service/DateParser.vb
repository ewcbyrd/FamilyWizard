Public Class DateParser

    Private _dateString As String
    Private _eventDate As EventDate

    Public Sub New(ds As String)
        _eventDate = New EventDate
        ParseToEventDate(ds)

    End Sub

    Public ReadOnly Property GetDateString()
        Get
            Return _dateString
        End Get
    End Property

    Public ReadOnly Property GetEventDate()
        Get
            Return _eventDate
        End Get
    End Property

    Private Sub ParseToEventDate(ds As String)

        Dim approxArray() As String = {"abt", "about", "c", "circa"}

        Dim dateArray(20) As Char

        Dim dateChar As Char

        dateArray = ds.ToCharArray()

        Dim items As New ArrayList
        Dim element As String = ""

        For Each dateChar In dateArray
            If (Asc(dateChar) >= 48 And Asc(dateChar) <= 57) Or (Asc(dateChar) >= 65 And Asc(dateChar) <= 90) Or (Asc(dateChar) >= 97 And Asc(dateChar) <= 122) Then
                element = element & dateChar
            Else
                If element.Length > 0 Then
                    items.Add(element)
                End If

                element = ""
            End If
        Next

        If element.Length > 0 Then
            items.Add(element)
        End If

        Dim ed As New EventDate
        Dim isAllNumbers As Boolean = True

        ' Check for an approximation indicator in the first element of items
        ' If approximation element is present set isEstimated to true and remove the 
        ' element from the items list
        For Each approx In approxArray
            If approx = items(0).ToString.ToLower Then
                _eventDate.IsEstimate = True
                items.RemoveAt(0)
            End If
        Next

        ' Check to see if the remaining elements are all numeric (i.e. 3/5/1946)
        For Each item As String In items
            If Not IsNumeric(item) Then
                isAllNumbers = False
            End If
        Next

        ' Handle all numbers with 3 elements
        If isAllNumbers And items.Count = 3 Then
            _eventDate.Month = MonthName(items(0))
            _eventDate.Day = items(1)
            _eventDate.Year = items(2)

            _dateString = _eventDate.ToString

            Exit Sub

        End If

        ' Handle all numbers with 2 elements
        If isAllNumbers And items.Count = 2 Then
            _eventDate.Month = MonthName(items(0))
            If items(1).ToString.Length = 4 Then
                _eventDate.Year = items(1)
            Else
                _eventDate.Day = items(1)
            End If

            _dateString = _eventDate.ToString

            Exit Sub

        End If

        ' Handle all numbers with 1 element
        If isAllNumbers And items.Count = 1 Then
            If items(0).length = 4 Then
                _eventDate.Year = items(0)
                _dateString = _eventDate.ToString
                Exit Sub
            End If
        End If

        If Not isAllNumbers Then
            For Each item As String In items

                If IsNumeric(item) Then
                    If item.Length = 4 Then
                        _eventDate.Year = item
                    Else
                        _eventDate.Day = item
                    End If
                Else
                    Select Case item.ToLower
                        Case "jan", "january"
                            _eventDate.Month = "January"

                        Case "feb", "february"
                            _eventDate.Month = "February"

                        Case "mar", "march"
                            _eventDate.Month = "March"

                        Case "apr", "april"
                            _eventDate.Month = "April"

                        Case "may"
                            _eventDate.Month = "May"

                        Case "jun", "june"
                            _eventDate.Month = "June"

                        Case "jul", "july"
                            _eventDate.Month = "July"

                        Case "aug", "august"
                            _eventDate.Month = "August"

                        Case "sep", "september"
                            _eventDate.Month = "September"

                        Case "oct", "october"
                            _eventDate.Month = "October"

                        Case "nov", "november"
                            _eventDate.Month = "November"

                        Case "dec", "december"
                            _eventDate.Month = "December"

                        Case Else
                            _dateString = "Invalid"

                            Exit Sub

                    End Select
                End If

            Next

            _dateString = _eventDate.ToString

            Exit Sub

        End If

        _dateString = "Invalid"

    End Sub

End Class
