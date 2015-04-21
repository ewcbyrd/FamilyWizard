Public Class frmEventEditor

    Private _person As Person
    Private _startString As String
    Private _event As PersonEvent

    Public Sub New(startString As String, person As Person)

        InitializeComponent()

        _startString = startString
        _person = person

        _event = New PersonEvent

    End Sub

    Private Sub frmEventEditor_Load(sender As Object, e As EventArgs) Handles Me.Load

        lblEventPerson.Text = _startString & " event for " & _person.ToString

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        Dim es As New EventService

        If cboEventType.Text <> "" Then

            Dim eventType As String = cboEventType.Text.ToUpper
            Dim dp As New DateParser(txtEventDate.Text)

            If chkAlternate.Checked = False Then
                eventType += "-PRI"
            Else
                eventType += "-ALT"
            End If

            _event.EventType = eventType
            _event.EventLocation = txtEventLocation.Text
            _event.PersonID = _person.Id

            If txtEventDate.Text <> "" Then
                If dp.GetDateString <> "Invalid" Then
                    _event.EventDate = New DateParser(txtEventDate.Text).GetEventDate
                Else
                    MsgBox("Invalid Date!")
                    Exit Sub
                End If
            End If
        Else
            MsgBox("No Event Type specified!")
            Exit Sub
        End If

        If _event.Id = 0 Then
            es.AddEvent(_event)
        End If

    End Sub
End Class