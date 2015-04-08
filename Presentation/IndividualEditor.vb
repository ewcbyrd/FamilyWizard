Imports WeifenLuo.WinFormsUI.Docking

Public Class frmIndividualEditor
    Implements IDockContent

    Public Event FocusPersonChanged()
    Public Event SpouseChanged()

    Private currentText As String ' The current value of the individual text box with focus
    'Private marriageIndex As Integer ' The marriage index for the focus person and spouse

    Private _focusPerson As Person
    Private _spouse As Person

    Public Property AncestorView As frmAncestorView
    Public Property PersonIndex As frmPersonIndex
    Public Property FamilyView As frmFamilyView
    Public Property MarriageView As frmMarriageView

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

    Public Property Spouse As Person
        Get
            Return _spouse
        End Get
        Set(value As Person)
            _spouse = value
            If Spouse IsNot Nothing Then
                RaiseEvent SpouseChanged()
            End If
        End Set
    End Property


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _spouse = New Person

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

        Select Case spouses.Count
            Case 0
                btnMarriage.Text = "Add Spouse..."
                btnMarriage.Tag = 0
                MarriageIndex = 0
            Case Else
                Spouse = ps.GetPersonById(spouses(0))

        End Select

    End Sub

    Private Sub frmIndividualEditor_FocusPersonChanged() Handles Me.FocusPersonChanged

        Dim ps As New PersonService

        Spouse = Nothing

        LoadIndividualData()
        AncestorView.AncestorList = ps.GetAncestors(FocusPerson.Id)
        FamilyView.LoadFamilyView()
        'MarriageView.Marriages = ps.GetMarriageList(FocusPerson)

        ' Update the appropriate individual in the Familyview
        If FocusPerson.Gender = "M" Then
            FamilyView.UpdateFather(FocusPerson)
        Else
            FamilyView.UpdateMother(FocusPerson)
        End If

        ' Populate the children list of Family View when no spouse exists
        If MarriageView.Marriages Is Nothing Then
            If FocusPerson.Gender = "M" Then
                FamilyView.Children = ps.GetChildren(FocusPerson.Id, 0)
            Else
                FamilyView.Children = ps.GetChildren(0, FocusPerson.Id)
            End If
        End If

        ' Set CurrentPersonIndex to the index of the aplicable Name list item
        PersonIndex.SetCurrentPersonIndex(FocusPerson.Id)

        My.Application.Log.WriteEntry("Focus person changed to " & FocusPerson.ToString & "(ID #" & FocusPerson.Id & ")")

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

            ' Add new spouse to Person Index
            PersonIndex.AddItemToPersonListView(person)

            ' Recalculate the Current Person Index for the Focus Person
            PersonIndex.SetCurrentPersonIndex(FocusPerson.Id)

            ' Update the Index Count of the Person Index view
            PersonIndex.lblIndex.Text = "Index:  " & ps.GetPersonCount

            If person.Gender = "M" Then
                marriageId = ps.AddMarriage(person.Id, FocusPerson.Id)
            Else
                marriageId = ps.AddMarriage(FocusPerson.Id, person.Id)
            End If

            Spouse = person



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
                        PersonIndex.lvNames.Items(PersonIndex.CurrentPersonIndex).SubItems(1).Text = FocusPerson.Birth.EventDate.Year
                        FamilyView.UpdateFamilyViewBirthDeath("Birth", txtBirthDate.Text, FocusPerson.Gender)
                        AncestorView.AncestorList = ps.GetAncestors(FocusPerson.Id)

                    Case "txtDeathDate"
                        eventDate = New DateParser(txtDeathDate.Text).GetEventDate
                        es.UpdateDate(eventDate, FocusPerson.DeathId)
                        ps.UpdatePersonsDeath(eventDate, FocusPerson.Id)
                        PersonIndex.lvNames.Items(PersonIndex.CurrentPersonIndex).SubItems(2).Text = FocusPerson.Death.EventDate.Year
                        FamilyView.UpdateFamilyViewBirthDeath("Death", txtDeathDate.Text, FocusPerson.Gender)
                        AncestorView.AncestorList = ps.GetAncestors(FocusPerson.Id)

                    Case "txtMarriageDate"
                        ps.UpdateMarriageDate(New DateParser(txtMarriageDate.Text).GetEventDate, marriageIndex)
                        FamilyView.UpdateFamilyViewMarriage(txtMarriageDate.Text, txtMarriagePlace.Text)
                        MarriageView.Marriages = ps.GetMarriageList(FocusPerson)

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
                    MarriageView.Marriages = ps.GetMarriageList(FocusPerson)
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
                    PersonIndex.lvNames.Items(PersonIndex.CurrentPersonIndex).SubItems(0).Text = FocusPerson.ToStringLastFirst

                    'Update the name in the ancestor view
                    AncestorView.AncestorList = ps.GetAncestors(FocusPerson.Id)

                    ' Update Individual Editor name banner
                    lblName.Text = FocusPerson.ToString

            End Select

        End If

    End Sub

    Private Sub frmIndividualEditor_SpouseChanged() Handles Me.SpouseChanged

        Dim ps As New PersonService

        ' Update the marriage button on the Individual Editor
        btnMarriage.Text = "Marriage to " & Spouse.ToString
        btnMarriage.Tag = Spouse.Id

        ' Retrieve marriage between focus person and focus spouses
        Dim marriage As MarriageEvent = ps.GetMarriage(FocusPerson.Id, Spouse.Id)

        ' Store the marriage date and location in the appropriate Individual Editor text boxes
        txtMarriageDate.Text = marriage.MarriageDate.ToString
        txtMarriagePlace.Text = marriage.MarriageLocation

        ' Set the focus marriage index
        MarriageIndex = marriage.Id

        ' Update children in Family View
        If FocusPerson.Gender = "M" Then
            FamilyView.Children = ps.GetChildren(FocusPerson.Id, Spouse.Id)
        Else
            FamilyView.Children = ps.GetChildren(Spouse.Id, FocusPerson.Id)
        End If

        ' Refresh the family view
        FamilyView.LoadFamilyView()

        ' Refresh the Marriage view
        MarriageView.Marriages = ps.GetMarriageList(FocusPerson)

        My.Application.Log.WriteEntry("Focus spouse changed to " & Spouse.ToString & "(ID #" & Spouse.Id & ")")

    End Sub
End Class