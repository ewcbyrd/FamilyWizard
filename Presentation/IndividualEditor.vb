Imports WeifenLuo.WinFormsUI.Docking

Public Class frmIndividualEditor
    Inherits DockContent

    Public Event FocusPersonChanged()

    Private currentText As String ' The current value of the individual text box with focus
    'Private marriageIndex As Integer ' The marriage index for the focus person and spouse

    Private _focusPerson As Person
    Private _spouse As Person

    Public Property AncestorView As frmAncestorView
    Public Property PersonIndex As frmPersonIndex
    Public Property FamilyView As frmFamilyView

    Public Property MarriageIndex As Integer

    Public Property FocusPerson As Person
        Get
            Return _focusPerson
        End Get
        Set(value As Person)
            _focusPerson = value

            If _focusPerson IsNot Nothing Then
                RaiseEvent FocusPersonChanged()
            End If
        End Set
    End Property

    Public Property spouse As Person
        Get
            Return _spouse
        End Get
        Set(value As Person)
            _spouse = value
        End Set
    End Property


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub LoadIndividualData()

        Dim ps As New PersonService

        txtBirthDate.Clear()
        txtBirthPlace.Clear()
        txtDeathDate.Clear()
        txtDeathPlace.Clear()
        btnMarriage.Text = ""
        txtMarriageDate.Clear()
        txtMarriagePlace.Clear()

        lblName.Text = FocusPerson.ToString
        txtName.Text = FocusPerson.ToString

        Select Case FocusPerson.Gender
            Case "M"
                cboSex.Text = "Male"
            Case "F"
                cboSex.Text = "Female"
            Case "?"
                cboSex.Text = "Unknown"
        End Select

        txtBirthDate.Text = FocusPerson.Birth.EventDate.ToString

        txtBirthPlace.Text = FocusPerson.Birth.EventLocation

        txtDeathDate.Text = FocusPerson.Death.EventDate.ToString
        txtDeathPlace.Text = FocusPerson.Death.EventLocation

        Dim spouses As ArrayList = ps.GetSpouses(FocusPerson)

        spouse = New Person

        Select Case spouses.Count
            Case 0
                btnMarriage.Text = "Add Spouse..."
                btnMarriage.Tag = 0
                marriageIndex = 0
            Case Else
                spouse = ps.GetPersonById(spouses(0))
                btnMarriage.Text = "Marriage to " & spouse.ToString
                btnMarriage.Tag = spouse.Id

                Dim marriage As New MarriageEvent

                marriage = ps.GetMarriage(FocusPerson.Id, spouse.Id)

                txtMarriageDate.Text = marriage.MarriageDate.ToString
                txtMarriagePlace.Text = marriage.MarriageLocation

                'Set the focus marriage index
                marriageIndex = marriage.Id

        End Select

    End Sub

    Private Sub frmIndividualEditor_FocusPersonChanged() Handles Me.FocusPersonChanged
        LoadIndividualData()
    End Sub

    Private Sub txtBirthDate_GotFocus(sender As Object, e As EventArgs) Handles txtBirthDate.GotFocus,
        txtBirthPlace.GotFocus, txtDeathDate.GotFocus, txtDeathPlace.GotFocus, txtMarriageDate.GotFocus, txtName.GotFocus

        Dim tb As TextBox = CType(sender, TextBox)
        currentText = tb.Text

    End Sub

    Private Sub txtBirthDate_KeyDown(sender As Object, e As KeyEventArgs) Handles _
        txtBirthDate.KeyDown, txtDeathDate.KeyDown, txtMarriageDate.KeyDown

        Dim tb As TextBox = CType(sender, TextBox)

        If e.KeyCode = Keys.Return Then
            ProcessDateTextBox(sender)
            My.Computer.Keyboard.SendKeys("{TAB}")
        End If

    End Sub

    Private Sub txtBirthDate_LostFocus(sender As Object, e As EventArgs) Handles txtBirthDate.LostFocus, txtDeathDate.LostFocus, _
        txtMarriageDate.LostFocus

        ProcessDateTextBox(sender)

    End Sub

    Private Sub txtBirthPlace_KeyDown(sender As Object, e As KeyEventArgs) Handles _
        txtBirthPlace.KeyDown, txtDeathPlace.KeyDown, txtMarriagePlace.KeyDown, txtName.KeyDown

        If e.KeyCode = Keys.Return Then
            ProcessNonDateTextBox(sender)
            My.Computer.Keyboard.SendKeys("{TAB}")
        End If

    End Sub

    Private Sub txtBirthPlace_LostFocus(sender As Object, e As EventArgs) Handles _
        txtBirthPlace.LostFocus, txtDeathPlace.LostFocus, txtMarriagePlace.LostFocus, txtName.LostFocus

        ProcessNonDateTextBox(sender)

    End Sub

    Private Sub btnMarriage_Click(sender As Object, e As EventArgs) Handles btnMarriage.Click

        Dim ps As New PersonService

        If btnMarriage.Tag = 0 Then

            Dim nameString As String = InputBox("Enter the spouse's name", "Add spouse")

            Dim personName As PersonName = NameParser.ParseName(nameString)

            Dim person As New Person

            person.Id = My.Settings.CurrentPersonIndex

            Dim marriageId As Integer = 0

            person.Surname = personName.Surname

            person.GivenName = personName.GivenName

            Select Case FocusPerson.Gender
                Case "M"
                    person.Gender = "F"
                Case "F"
                    person.Gender = "M"
                Case "?"
                    person.Gender = "?"
            End Select

            Dim id As Integer = ps.AddPerson(person)

            person = ps.GetPersonById(id)

            PersonIndex.AddItemToPersonListView(person)

            If person.Gender = "M" Then
                marriageId = ps.AddMarriage(person.Id, FocusPerson.Id)
            Else
                marriageId = ps.AddMarriage(FocusPerson.Id, person.Id)
            End If

            FocusPerson = person

            LoadIndividualData()

            AncestorView.LoadAncestorView()

            PersonIndex.lblIndex.Text = "Index:  " & ps.GetPersonCount

        End If
    End Sub

    Private Sub ProcessDateTextBox(sender As Object)

        Dim tb As TextBox = CType(sender, TextBox)
        Dim es As New EventService
        Dim ps As New PersonService

        If tb.Text.Length > 0 Then

            ' Send contents of date text box to be converted to default format
            Dim dateString As String = New DateParser(tb.Text).GetDateString

            'Update date text box with converted date string unless invalid 
            If dateString <> "Invalid" Then
                tb.Text = dateString

            Else
                ' Alert user that an invalid date was entered
                MessageBox.Show("You entered an invalid date", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error)

                ' Restore date text box to previous value
                tb.Text = currentText

                ' Return focus to date text box
                tb.Focus()

            End If

        End If

        ' Check to see if change occured
        If DateString <> "Invalid" Then
            If tb.Text <> currentText Then  'Changed occured

                Dim eventDate As New EventDate

                Select Case tb.Name
                    Case "txtBirthDate"
                        eventDate = New DateParser(txtBirthDate.Text).GetEventDate
                        es.UpdateDate(eventDate, FocusPerson.BirthId)
                        ps.UpdatePersonsBirth(eventDate, FocusPerson.Id)
                        'lvNames.Items(PersonIndex).SubItems(2).Text = tb.Text
                        FamilyView.UpdateFamilyViewBirthDeath("Birth", txtBirthDate.Text, FocusPerson.Gender)

                    Case "txtDeathDate"
                        eventDate = New DateParser(txtDeathDate.Text).GetEventDate
                        es.UpdateDate(eventDate, FocusPerson.DeathId)
                        ps.UpdatePersonsDeath(eventDate, FocusPerson.Id)
                        'lvNames.Items(personIndex).SubItems(3).Text = tb.Text
                        FamilyView.UpdateFamilyViewBirthDeath("Death", txtDeathDate.Text, FocusPerson.Gender)

                    Case "txtMarriageDate"
                        ps.UpdateMarriageDate(New DateParser(txtMarriageDate.Text).GetEventDate, marriageIndex)
                        FamilyView.UpdateFamilyViewMarriage(txtMarriageDate.Text, txtMarriagePlace.Text)
                End Select
            End If
        End If

    End Sub

    Private Sub ProcessNonDateTextBox(sender As Object)

        Dim tb As TextBox = CType(sender, TextBox)
        Dim es As New EventService
        Dim ps As New PersonService

        If tb.Text <> currentText Then
            Select Case tb.Name
                Case "txtBirthPlace"
                    es.AddLocation(txtBirthPlace.Text, FocusPerson.BirthId)
                    ps.UpdatePersonsBirthLocation(txtBirthPlace.Text, FocusPerson.Id)
                    FamilyView.UpdateFamilyViewBirthDeathLocation("Birth", txtBirthPlace.Text, FocusPerson.Gender)
                Case "txtDeathPlace"
                    es.AddLocation(txtDeathPlace.Text, FocusPerson.DeathId)
                    ps.UpdatePersonsDeathLocation(txtDeathPlace.Text, FocusPerson.Id)
                    FamilyView.UpdateFamilyViewBirthDeathLocation("Death", txtDeathPlace.Text, FocusPerson.Gender)
                Case "txtMarriagePlace"
                    ps.UpdateMarriageLocation(txtMarriagePlace.Text, marriageIndex)
                    FamilyView.UpdateFamilyViewMarriage(txtMarriageDate.Text, txtMarriagePlace.Text)
                Case "txtName"

                    ' Update name in the database
                    ps.UpdatePersonName(FocusPerson.Id, txtName.Text)

                    ' Update name in family view
                    If FocusPerson.Gender = "M" Then
                        FamilyView.lblFather.Text = txtName.Text
                    Else
                        FamilyView.lblMother.Text = txtName.Text
                    End If

                    ' Update name in the person list
                    'lvNames.Items(personIndex).SubItems(0).Text = FocusPerson.ToStringLastFirst

                    'Update the name in the ancestor view

            End Select

        End If

    End Sub
End Class