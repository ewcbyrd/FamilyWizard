Public Class frmMainForm

    Private Property FocusPerson As Person

    Private spouse As Person ' The spouse of the focus person
    Private personIndex As Integer ' The name list index of the focus person
    Private marriageIndex As Integer ' The marriage index for the focus person and spouse
    Private ps As New PersonService
    Private es As New EventService
    Private currentText As String ' The current value of the individual text box with focus

    Public WriteOnly Property PIndex() As Integer
        Set(value As Integer)
            personIndex = value
        End Set
    End Property

    Public Sub LoadNameList(list As Dictionary(Of Integer, Person))

        ' Clear all data from the names list
        lvNames.Items.Clear()

        ' Iterate through the hashtable keys. Keys contain ID's of individuals in database.
        For Each individual As Person In list.Values

            ' Call procedure to add individual to names list
            AddItemToPersonListView(individual)

        Next

    End Sub

    Private Sub LoadAncestorView()

        ' Loop through all labels in Ancestor View panel.  Set their background color to Dark Gray
        For Each lbl As Label In SplitContainer2.Panel1.Controls
            lbl.BackColor = Color.DarkGray
        Next

        ' Retrieve ancestors of focus person and assign to ancestors hashtable
        Dim ancestors As Hashtable = ps.GetAncestors(FocusPerson.Id)

        With lblIndividual1
            .Text = ancestors(1).ToString
            .Tag = DirectCast(ancestors(1), Person).Id
            .BackColor = Color.DarkOliveGreen
            .ForeColor = Color.White
        End With

        With lblIndividual2
            .Text = ancestors(2).ToString
            .Tag = DirectCast(ancestors(2), Person).Id
        End With

        With lblIndividual3
            .Text = ancestors(3).ToString
            .Tag = DirectCast(ancestors(3), Person).Id
        End With

        With lblIndividual4
            .Text = ancestors(4).ToString
            .Tag = DirectCast(ancestors(4), Person).Id
        End With

        With lblIndividual5
            .Text = ancestors(5).ToString
            .Tag = DirectCast(ancestors(5), Person).Id
        End With

        With lblIndividual6
            .Text = ancestors(6).ToString
            .Tag = DirectCast(ancestors(6), Person).Id
        End With

        With lblIndividual7
            .Text = ancestors(7).ToString
            .Tag = DirectCast(ancestors(7), Person).Id
        End With

        With lblIndividual8
            .Text = ancestors(8).ToString
            .Tag = DirectCast(ancestors(8), Person).Id
        End With

        With lblIndividual9
            .Text = ancestors(9).ToString
            .Tag = DirectCast(ancestors(9), Person).Id
        End With

        With lblIndividual10
            .Text = ancestors(10).ToString
            .Tag = DirectCast(ancestors(10), Person).Id
        End With

        With lblIndividual11
            .Text = ancestors(11).ToString
            .Tag = DirectCast(ancestors(11), Person).Id
        End With

        With lblIndividual12
            .Text = ancestors(12).ToString
            .Tag = DirectCast(ancestors(12), Person).Id
        End With

        With lblIndividual13
            .Text = ancestors(13).ToString
            .Tag = DirectCast(ancestors(13), Person).Id
        End With

        With lblIndividual14
            .Text = ancestors(14).ToString
            .Tag = DirectCast(ancestors(14), Person).Id
        End With

        With lblIndividual15
            .Text = ancestors(15).ToString
            .Tag = DirectCast(ancestors(15), Person).Id
        End With

    End Sub

    Private Sub lvNames_SelectedIndexChanged(sender As Object, e As EventArgs) Handles _
         lvNames.SelectedIndexChanged, lvChildren.SelectedIndexChanged

        Dim lv As ListView = CType(sender, ListView)

        Dim personId As Integer

        Dim items As ListView.SelectedListViewItemCollection = lv.SelectedItems

        Dim item As ListViewItem

        For Each item In items
            personId = item.Tag
            SetPersonIndex(personId)
        Next

        If personId <> 0 Then
            SetFocusPerson(personId)
        End If

    End Sub

    Private Sub LoadIndividualData()

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

                marriage = ps.GetMarriage(focusPerson.Id, spouse.Id)

                txtMarriageDate.Text = marriage.MarriageDate.ToString
                txtMarriagePlace.Text = marriage.MarriageLocation

                'Set the focus marriage index
                marriageIndex = marriage.Id

        End Select

    End Sub

    Public Sub SetFocusPerson(id As Integer)
        Dim ps As New PersonService

        FocusPerson = ps.GetPersonById(id)
        LoadAncestorView()
        LoadIndividualData()
        LoadFamilyView()

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

        If btnMarriage.Tag = 0 Then

            Dim nameString As String = InputBox("Enter the spouse's name", "Add spouse")

            Dim personName As PersonName = NameParser.ParseName(nameString)

            Dim person As New Person

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

            AddItemToPersonListView(person)

            If person.Gender = "M" Then
                marriageId = ps.AddMarriage(person.Id, FocusPerson.Id)
            Else
                marriageId = ps.AddMarriage(FocusPerson.Id, person.Id)
            End If

            FocusPerson = person

            LoadIndividualData()

            LoadAncestorView()

            lblIndex.Text = "Index:  " & ps.GetPersonCount

        End If
    End Sub

    Private Function AddItemToPersonListView(individual As Person) As Integer

        Dim li As ListViewItem

        li = lvNames.Items.Add(individual.ToStringLastFirst)
        li.SubItems.Add(individual.Gender)

        li.SubItems.Add(individual.Birth.EventDate.ToString)

        li.SubItems.Add(individual.Death.EventDate.ToString)

        li.Tag = individual.Id

        Return li.Index

    End Function

    Private Sub AttachFatherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles _
        AttachFatherToolStripMenuItem.Click, AttachMotherToolStripMenuItem.Click

        Dim tsmi As ToolStripMenuItem = CType(sender, ToolStripMenuItem)

        Dim targetString As String = ""

        Select Case tsmi.Name
            Case "AttachFatherToolStripMenuItem"
                targetString = "father"
            Case "AttachMotherToolStripMenuItem"
                targetString = "mother"
        End Select

        Dim dialog As New frmPersonPicker("Select the " & targetString & " to attach")

        Dim result As DialogResult = dialog.ShowDialog

        Dim selectedIndex As Integer = 0

        If result = Windows.Forms.DialogResult.OK Then
            selectedIndex = dialog.SelectedPersonIndex
            If selectedIndex > 0 Then
                Select Case tsmi.Name
                    Case "AttachFatherToolStripMenuItem"
                        ps.AddParent(FocusPerson.Id, selectedIndex, "father")

                        ' Set the father id of the focus person
                        FocusPerson.FatherId = selectedIndex

                        ' Add a new marriage event if a mother is already associated with the focus person
                        If FocusPerson.MotherId <> 0 Then
                            ps.AddMarriage(FocusPerson.FatherId, FocusPerson.MotherId)
                        End If
                    Case "AttachMotherToolStripMenuItem"
                        ps.AddParent(FocusPerson.Id, selectedIndex, "mother")

                        ' Set the mother id of the focus person
                        FocusPerson.MotherId = selectedIndex

                        ' Add a new marriage event if a father is already associated with the focus person
                        If FocusPerson.FatherId <> 0 Then
                            ps.AddMarriage(FocusPerson.FatherId, FocusPerson.MotherId)
                        End If
                End Select

            End If
            LoadAncestorView()
        End If

    End Sub

    Private Sub AttachSpouseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AttachSpouseToolStripMenuItem.Click

        Dim dialog As New frmPersonPicker("Select the  spouse to attach")

        Dim result As DialogResult = dialog.ShowDialog

        Dim selectedIndex As Integer = 0
        Dim marriageId As Integer = 0

        If result = Windows.Forms.DialogResult.OK Then
            selectedIndex = dialog.SelectedPersonIndex
            If selectedIndex > 0 Then
                If FocusPerson.Gender = "M" Then
                    marriageId = ps.AddMarriage(FocusPerson.Id, selectedIndex)
                Else
                    marriageId = ps.AddMarriage(selectedIndex, FocusPerson.Id)
                End If

                Dim spouse As Person = ps.GetPersonById(selectedIndex)

                btnMarriage.Text = "Marriage to " & spouse.ToString
                btnMarriage.Tag = spouse.Id

                'Set the focus marriage index
                marriageIndex = marriageId
            End If
        End If
    End Sub

    Private Sub AddFatherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles _
        AddFatherToolStripMenuItem.Click, AddMotherToolStripMenuItem.Click

        Dim tsmi As ToolStripMenuItem = CType(sender, ToolStripMenuItem)

        Dim targetString As String = ""

        Dim gender As String = ""

        Select Case tsmi.Name
            Case "AddFatherToolStripMenuItem"
                targetString = "Father"
                gender = "Male"
            Case "AddMotherToolStripMenuItem"
                targetString = "Mother"
                gender = "Female"
        End Select

        Dim dialog As New frmNewPerson("Add " & targetString & " to " & FocusPerson.ToString, gender)

        Dim result As DialogResult = dialog.ShowDialog

        If result = Windows.Forms.DialogResult.OK Then
            If dialog.NameString <> "" Then

                Dim person As Person = dialog.ProcessNewPerson

                Dim parentId As Integer = ps.AddPerson(person)

                Select Case tsmi.Name
                    Case "AddFatherToolStripMenuItem"
                        ps.AddParent(FocusPerson.Id, parentId, "father")

                        ' Set the father id of the focus person
                        FocusPerson.FatherId = parentId

                        ' Add a new marriage event if a mother is already associated with the focus person
                        If FocusPerson.MotherId <> 0 Then
                            ps.AddMarriage(FocusPerson.FatherId, FocusPerson.MotherId)
                        End If
                    Case "AddMotherToolStripMenuItem"
                        ps.AddParent(FocusPerson.Id, parentId, "mother")

                        ' Set the mother id of the focus person
                        FocusPerson.MotherId = parentId

                        ' Add a new marriage event if a father is already associated with the focus person
                        If FocusPerson.FatherId <> 0 Then
                            ps.AddMarriage(FocusPerson.FatherId, FocusPerson.MotherId)
                        End If
                End Select

                AddItemToPersonListView(ps.GetPersonById(parentId))

                LoadAncestorView()

                lblIndex.Text = "Index:  " & ps.GetPersonCount

            End If
        End If

    End Sub

    Private Sub AddSpouseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddSpouseToolStripMenuItem.Click

        Dim gender As String = ""

        Select Case FocusPerson.Gender
            Case "M"
                gender = "Female"
            Case "F"
                gender = "Male"
            Case "?"
                gender = "Unknown"
        End Select

        Dim dialog As New frmNewPerson("Add Spouse to " & FocusPerson.ToString, gender)

        Dim result As DialogResult = dialog.ShowDialog

        If result = Windows.Forms.DialogResult.OK Then
            If dialog.NameString <> "" Then

                ' Process the data entered in the new person dialogue
                Dim person As Person = dialog.ProcessNewPerson

                ' Add the new person to the database and assign the key to spouseId
                Dim spouseId As Integer = ps.AddPerson(person)


                ' Add a marriage record to the database
                Dim marriageId As Integer = 0

                If FocusPerson.Gender = "M" Then
                    marriageId = ps.AddMarriage(FocusPerson.Id, spouseId)
                Else
                    marriageId = ps.AddMarriage(spouseId, FocusPerson.Id)
                End If

                spouse = ps.GetPersonById(spouseId)

                btnMarriage.Text = "Marriage to " & spouse.ToString
                btnMarriage.Tag = spouse.Id

                'Set the focus marriage index
                marriageIndex = marriageId

                'Add new person to names list
                AddItemToPersonListView(spouse)

                LoadFamilyView()

                lblIndex.Text = "Index:  " & ps.GetPersonCount

            End If

        End If
    End Sub

    Private Sub lblIndividual1_Click(sender As Object, e As EventArgs) Handles lblIndividual1.Click, lblIndividual10.Click, lblIndividual11.Click, _
        lblIndividual12.Click, lblIndividual13.Click, lblIndividual14.Click, lblIndividual15.Click, lblIndividual2.Click, lblIndividual3.Click, _
        lblIndividual4.Click, lblIndividual5.Click, lblIndividual6.Click, lblIndividual7.Click, lblIndividual8.Click, lblIndividual9.Click

        Dim lbl As Label = CType(sender, Label)

        If Not lbl.Text.Equals(" ") Then
            For Each c As Control In SplitContainer2.Panel1.Controls

                c.BackColor = Color.DarkGray
                c.ForeColor = Color.Black

            Next

            lbl.BackColor = Color.DarkOliveGreen
            lbl.ForeColor = Color.White

            FocusPerson = ps.GetPersonById(lbl.Tag)
            LoadIndividualData()
            LoadFamilyView()

        End If

    End Sub

    Private Sub AddUnrelatedPersonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddUnrelatedPersonToolStripMenuItem.Click

        Dim dialog As New frmNewPerson("Add Person", "Unknown")

        Dim result As DialogResult = dialog.ShowDialog

        If result = Windows.Forms.DialogResult.OK Then
            If dialog.NameString <> "" Then

                Dim person As Person = dialog.ProcessNewPerson

                Dim personId As Integer = ps.AddPerson(person)

                personIndex = AddItemToPersonListView(ps.GetPersonById(personId))

                SetFocusPerson(personId)

                lblIndex.Text = "Index:  " & ps.GetPersonCount

            End If
        End If
    End Sub

    Private Sub SplitContainer2_Panel2_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer2.Panel2.Paint

        ' Resize name panels
        pnlFather.Width = (SplitContainer2.Panel2.Width - 7) / 2
        With pnlMother
            .Width = (SplitContainer2.Panel2.Width - 7) / 2
            .Left = pnlFather.Width + 7
        End With

        'Resize marriage panel
        pnlMarriage.Width = SplitContainer2.Panel2.Width

        'Resize children list columns
        lvChildren.Columns(0).Width = SplitContainer2.Panel2.Width * 0.95 * 0.2
        lvChildren.Columns(1).Width = SplitContainer2.Panel2.Width * 0.95 * 0.1
        lvChildren.Columns(2).Width = SplitContainer2.Panel2.Width * 0.95 * 0.35
        lvChildren.Columns(3).Width = SplitContainer2.Panel2.Width * 0.95 * 0.35

    End Sub

    Private Sub LoadFamilyView()

        lblFather.Text = ""
        lblMother.Text = ""
        lblMarriage.Text = ""
        lvChildren.Items.Clear()
        cmsFatherSpouses.Items.Clear()
        cmsMotherSpouses.Items.Clear()

        If spouse.Id > 0 Then

            Dim marriage As MarriageEvent = ps.GetMarriage(marriageIndex)

            Dim marriageString As String = ""

            UpdateFamilyViewMarriage(marriage.MarriageDate.ToString, marriage.MarriageLocation)

        End If

        Dim father As New Person
        Dim mother As New Person
        Dim visible As Boolean = False

        If FocusPerson.Gender = "M" Then
            father = FocusPerson
            mother = spouse
        Else
            father = spouse
            mother = FocusPerson
        End If

        If father.Id = 0 Then
            visible = False
        Else
            visible = True
        End If

        For Each c As Control In pnlFather.Controls
            c.Visible = visible
        Next

        If mother.Id = 0 Then
            visible = False
        Else
            visible = True
        End If

        For Each c As Control In pnlMother.Controls
            c.Visible = visible
        Next

        ' Add father and mother data to panels
        lblFather.Text = father.ToString
        lblMother.Text = mother.ToString
        lblFatherBirthDate.Text = father.Birth.EventDate.ToString
        lblMotherBirthDate.Text = mother.Birth.EventDate.ToString
        lblFatherBirthLocation.Text = father.Birth.EventLocation
        lblMotherBirthLocation.Text = mother.Birth.EventLocation
        lblFatherDeathDate.Text = father.Death.EventDate.ToString
        lblMotherDeathDate.Text = mother.Death.EventDate.ToString
        lblFatherDeathLocation.Text = father.Death.EventLocation
        lblMotherDeathLocation.Text = mother.Death.EventLocation

        ' Add children to children list
        UpdateChildrenList(father.Id, mother.Id)

        ' Populate marriage buttons and menus
        Dim fatherSpouseArray As ArrayList = ps.GetSpouses(father)
        Dim motherSpouseArray As ArrayList = ps.GetSpouses(mother)

        ' Populate marriage buttons
        btnFatherMarriages.Text = fatherSpouseArray.Count
        btnMotherMarriages.Text = motherSpouseArray.Count

        LoadSpousesContextMenu(cmsFatherSpouses, fatherSpouseArray)
        LoadSpousesContextMenu(cmsMotherSpouses, motherSpouseArray)

    End Sub

    Private Sub SplitContainer2_Panel1_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer2.Panel1.Paint

        ' Calculate spacing between rightmost column of labels
        ' Equals space not occupied by labels (labels occupy 200) 
        ' Plus 11 on top and bottom.  Total of 222.
        Dim spacing As Integer = (SplitContainer2.Panel1.Height - 222) / 7

        ' Set width of labels to 23.2% of total space
        For Each c As Control In SplitContainer2.Panel1.Controls
            c.Width = SplitContainer2.Panel1.Width * 0.232
        Next

        With lblIndividual1
            .Left = 10
            .Top = lblIndividual2.Top + ((lblIndividual3.Top + lblIndividual3.Height - lblIndividual2.Top) / 2) - (lblIndividual3.Height / 2)
        End With
        With lblIndividual2
            .Left = lblIndividual1.Right + 15
            .Top = lblIndividual4.Top + ((lblIndividual5.Top + lblIndividual5.Height - lblIndividual4.Top) / 2) - (lblIndividual5.Height / 2)
        End With
        With lblIndividual3
            .Left = lblIndividual1.Right + 15
            .Top = lblIndividual6.Top + ((lblIndividual7.Top + lblIndividual7.Height - lblIndividual6.Top) / 2) - (lblIndividual7.Height / 2)
        End With
        With lblIndividual4
            .Left = lblIndividual2.Right + 15
            .Top = lblIndividual8.Top + ((lblIndividual9.Top + lblIndividual9.Height - lblIndividual8.Top) / 2) - (lblIndividual9.Height / 2)
        End With
        With lblIndividual5
            .Left = lblIndividual2.Right + 15
            .Top = lblIndividual10.Top + ((lblIndividual11.Top + lblIndividual11.Height - lblIndividual10.Top) / 2) - (lblIndividual11.Height / 2)
        End With
        With lblIndividual6
            .Left = lblIndividual2.Right + 15
            .Top = lblIndividual12.Top + ((lblIndividual13.Top + lblIndividual13.Height - lblIndividual12.Top) / 2) - (lblIndividual13.Height / 2)
        End With
        With lblIndividual7
            .Left = lblIndividual2.Right + 15
            .Top = lblIndividual14.Top + ((lblIndividual15.Top + lblIndividual15.Height - lblIndividual14.Top) / 2) - (lblIndividual15.Height / 2)
        End With
        With lblIndividual8
            .Left = lblIndividual4.Right + 15
            .Top = 11
        End With
        With lblIndividual9
            .Left = lblIndividual4.Right + 15
            .Top = lblIndividual8.Top + lblIndividual8.Height + spacing
        End With
        With lblIndividual10
            .Left = lblIndividual4.Right + 15
            .Top = lblIndividual9.Top + lblIndividual9.Height + spacing
        End With
        With lblIndividual11
            .Left = lblIndividual4.Right + 15
            .Top = lblIndividual10.Top + lblIndividual10.Height + spacing
        End With
        With lblIndividual12
            .Left = lblIndividual4.Right + 15
            .Top = lblIndividual11.Top + lblIndividual11.Height + spacing
        End With
        With lblIndividual13
            .Left = lblIndividual4.Right + 15
            .Top = lblIndividual12.Top + lblIndividual12.Height + spacing
        End With
        With lblIndividual14
            .Left = lblIndividual4.Right + 15
            .Top = lblIndividual13.Top + lblIndividual13.Height + spacing
        End With
        With lblIndividual15
            .Left = lblIndividual4.Right + 15
            .Top = lblIndividual14.Top + lblIndividual14.Height + spacing
        End With
    End Sub

    Private Sub SplitContainer1_Panel1_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel1.Paint

        'Resize the names list columns based upon the size of its container
        lvNames.Columns(0).Width = (SplitContainer1.Panel1.Width * 0.95) * 0.3
        lvNames.Columns(1).Width = (SplitContainer1.Panel1.Width * 0.95) * 0.1
        lvNames.Columns(2).Width = (SplitContainer1.Panel1.Width * 0.95) * 0.3
        lvNames.Columns(3).Width = (SplitContainer1.Panel1.Width * 0.95) * 0.3

    End Sub

    Private Function CreateDatePlaceString(eventDate As String, location As String) As String

        Dim eventString As String = ""

        If eventDate.Length > 0 Then
            eventString += eventDate
        End If

        If location.Length > 0 Then
            eventString += " in " & location
        End If

        Return eventString

    End Function

    Private Sub UpdateFamilyViewMarriage(marriageDate As String, location As String)

        lblMarriage.Text = CreateDatePlaceString(marriageDate, location)

    End Sub

    Private Sub UpdateFamilyViewBirthDeath(type As String, eventDate As String, gender As Char)

        If type = "Birth" Then
            If gender = "M" Then
                lblFatherBirthDate.Text = eventDate
            Else
                lblMotherBirthDate.Text = eventDate
            End If
        Else
            If gender = "M" Then
                lblFatherDeathDate.Text = eventDate
            Else
                lblMotherDeathDate.Text = eventDate
            End If
        End If
    End Sub

    Private Sub UpdateFamilyViewBirthDeathLocation(type As String, location As String, gender As Char)

        If type = "Birth" Then
            If gender = "M" Then
                lblFatherBirthLocation.Text = location
            Else
                lblMotherBirthLocation.Text = location
            End If
        Else
            If gender = "M" Then
                lblFatherDeathLocation.Text = location
            Else
                lblMotherDeathLocation.Text = location
            End If
        End If

    End Sub

    Private Sub AddChildToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddChildToolStripMenuItem.Click

        Dim parentPicker As New frmParentPicker(FocusPerson)

        Dim pickResult As DialogResult = parentPicker.ShowDialog

        If pickResult = Windows.Forms.DialogResult.OK Then

            Dim spouseId As Integer = parentPicker.SelectedSpouseIndex

            Dim dialog As New frmNewPerson("Add child to " & FocusPerson.ToString & " and " & spouse.ToString, "Unknown")

            Dim result As DialogResult = dialog.ShowDialog

            If result = Windows.Forms.DialogResult.OK Then
                If dialog.NameString <> "" Then

                    Dim person As Person = dialog.ProcessNewPerson

                    If FocusPerson.Gender = "M" Then
                        person.FatherId = FocusPerson.Id
                        person.MotherId = spouseId
                    Else
                        person.FatherId = spouseId
                        person.MotherId = FocusPerson.Id
                    End If

                    Dim childId As Integer = ps.AddPerson(person)

                    person = ps.GetPersonById(childId)

                    AddItemToPersonListView(person)

                    UpdateChildrenList(person.FatherId, person.MotherId)

                    lblIndex.Text = "Index:  " & ps.GetPersonCount

                End If
            End If
        End If
    End Sub

    Private Sub AttachChildToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AttachChildToolStripMenuItem.Click

        Dim parentPicker As New frmParentPicker(FocusPerson)

        Dim pickResult As DialogResult = parentPicker.ShowDialog

        If pickResult = Windows.Forms.DialogResult.OK Then

            Dim spouseId As Integer = parentPicker.SelectedSpouseIndex

            Dim dialog As New frmPersonPicker("Select the child to attach")

            Dim result As DialogResult = dialog.ShowDialog

            Dim selectedIndex As Integer = 0

            If result = Windows.Forms.DialogResult.OK Then
                selectedIndex = dialog.SelectedPersonIndex
                If selectedIndex > 0 Then ' Valid person returned

                    ' Retrieve selected person
                    Dim person As Person = ps.GetPersonById(selectedIndex)

                    ' Set persons Father ID and Mother ID
                    If FocusPerson.Gender = "M" Then
                        person.FatherId = FocusPerson.Id
                        person.MotherId = spouseId
                    Else
                        person.FatherId = spouseId
                        person.MotherId = FocusPerson.Id
                    End If

                    ' Update person's parents 
                    ps.UpdateParents(person.Id, person.FatherId, person.MotherId)

                    UpdateChildrenList(person.FatherId, person.MotherId)

                End If
            End If
        End If

    End Sub

    Private Sub btnFatherMarriages_Click(sender As Object, e As EventArgs) Handles btnFatherMarriages.Click
        Dim xy As New Point(btnFatherMarriages.PointToScreen(Point.Empty))
        cmsFatherSpouses.Show(Me, xy)
    End Sub

    Sub LoadSpousesContextMenu(control As ContextMenuStrip, spouseArray As ArrayList)

        For Each i As Integer In spouseArray

            control.Items.Add(New ToolStripMenuItem With {.Text = ps.GetPersonById(i).ToString, .Tag = i})

        Next

        control.Items.Add(New ToolStripSeparator)

        control.Items.Add(New ToolStripMenuItem With {.Text = "Add new spouse...", .Tag = 0})

    End Sub

    Private Sub btnMotherMarriages_Click(sender As Object, e As EventArgs) Handles btnMotherMarriages.Click
        Dim xy As New Point(btnMotherMarriages.PointToScreen(Point.Empty))
        cmsMotherSpouses.Show(Me, xy)
    End Sub

    Private Sub cmsFatherSpouses_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles cmsFatherSpouses.ItemClicked

        Dim tag As Integer = e.ClickedItem.Tag

        If tag <> 0 Then
            SetFocusPerson(tag)
            SetPersonIndex(tag)
        End If

    End Sub

    Private Sub cmsMotherSpouses_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles cmsMotherSpouses.ItemClicked

        Dim tag As Integer = e.ClickedItem.Tag

        If tag <> 0 Then
            SetFocusPerson(tag)
            SetPersonIndex(tag)
        End If

    End Sub

    Private Sub SetPersonIndex(tag As Integer)
        For Each item As ListViewItem In lvNames.Items
            If item.Tag = tag Then
                personIndex = item.Index
                Exit For
            End If
        Next
    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick, Me.FormClosed
        ps.WritePersonFile("C:\Users\Scott Byrd\OneDrive\Visual Basic\HelloWorld\persons.dat")
        es.WriteFile("C:\Users\Scott Byrd\OneDrive\Visual Basic\HelloWorld\events.dat")
        ps.WriteMarriageFile("C:\Users\Scott Byrd\OneDrive\Visual Basic\HelloWorld\marriages.dat")
    End Sub

    Sub UpdateChildrenList(fatherId As Integer, motherId As Integer)

        lvChildren.Items.Clear()

        Dim childList As ArrayList = ps.GetChildren(fatherId, motherId)
        For Each individual As Person In childList

            Dim li As ListViewItem

            li = lvChildren.Items.Add(individual.ToString)
            li.SubItems.Add(individual.Gender)
            li.SubItems.Add(CreateDatePlaceString(individual.Birth.EventDate.ToString, individual.Birth.EventLocation))
            li.SubItems.Add(CreateDatePlaceString(individual.Death.EventDate.ToString, individual.Death.EventLocation))
            li.Tag = individual.Id

        Next
    End Sub

    Private Sub ProcessDateTextBox(sender As Object)

        Dim tb As TextBox = CType(sender, TextBox)

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
                        lvNames.Items(personIndex).SubItems(2).Text = tb.Text
                        UpdateFamilyViewBirthDeath("Birth", txtBirthDate.Text, FocusPerson.Gender)

                    Case "txtDeathDate"
                        eventDate = New DateParser(txtDeathDate.Text).GetEventDate
                        es.UpdateDate(eventDate, FocusPerson.DeathId)
                        ps.UpdatePersonsDeath(eventDate, FocusPerson.Id)
                        lvNames.Items(personIndex).SubItems(3).Text = tb.Text
                        UpdateFamilyViewBirthDeath("Death", txtDeathDate.Text, FocusPerson.Gender)

                    Case "txtMarriageDate"
                        ps.UpdateMarriageDate(New DateParser(txtMarriageDate.Text).GetEventDate, marriageIndex)
                        UpdateFamilyViewMarriage(txtMarriageDate.Text, txtMarriagePlace.Text)
                End Select
            End If
        End If

    End Sub

    Private Sub ProcessNonDateTextBox(sender As Object)

        Dim tb As TextBox = CType(sender, TextBox)

        If tb.Text <> currentText Then
            Select Case tb.Name
                Case "txtBirthPlace"
                    es.AddLocation(txtBirthPlace.Text, FocusPerson.BirthId)
                    ps.UpdatePersonsBirthLocation(txtBirthPlace.Text, FocusPerson.Id)
                    UpdateFamilyViewBirthDeathLocation("Birth", txtBirthPlace.Text, FocusPerson.Gender)
                Case "txtDeathPlace"
                    es.AddLocation(txtDeathPlace.Text, FocusPerson.DeathId)
                    ps.UpdatePersonsDeathLocation(txtDeathPlace.Text, FocusPerson.Id)
                    UpdateFamilyViewBirthDeathLocation("Death", txtDeathPlace.Text, FocusPerson.Gender)
                Case "txtMarriagePlace"
                    ps.UpdateMarriageLocation(txtMarriagePlace.Text, marriageIndex)
                    UpdateFamilyViewMarriage(txtMarriageDate.Text, txtMarriagePlace.Text)
                Case "txtName"

                    ' Update name in the database
                    ps.UpdatePersonName(FocusPerson.Id, txtName.Text)

                    ' Update name in family view
                    If FocusPerson.Gender = "M" Then
                        lblFather.Text = txtName.Text
                    Else
                        lblMother.Text = txtName.Text
                    End If

                    ' Update name in the person list
                    lvNames.Items(personIndex).SubItems(0).Text = FocusPerson.ToStringLastFirst

                    'Update the name in the ancestor view

            End Select

        End If

    End Sub

    Private Sub DeletePersonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeletePersonToolStripMenuItem.Click

        If MessageBox.Show("Do you want to delete " & FocusPerson.ToString & " from your tree", "Delete Person", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then

            ' Delete person 
            ps.DeletePerson(FocusPerson)

            ' Remove person from names list
            For Each listItem As ListViewItem In lvNames.Items
                If listItem.Tag = FocusPerson.Id Then
                    listItem.Remove()
                    Exit For
                End If
            Next

            ' Set new focus person
            If FocusPerson.FatherId <> 0 Then
                SetFocusPerson(FocusPerson.Id)
            Else
                SetFocusPerson(My.Settings.DefaultPerson)
            End If

            lblIndex.Text = "Index:  " & ps.GetPersonCount

        End If


    End Sub

    Private Sub FindName(searchString As String)

        Dim itm As ListViewItem

        With lvNames
            itm = .FindItemWithText(searchString)
            If Not itm Is Nothing Then
                .Items.Item(itm.Index).Selected = True
                .Items.Item(itm.Index).EnsureVisible()
            End If
        End With
        itm = Nothing
    End Sub

    Private Sub txtNameFind_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNameFind.KeyDown
        'FindName(txtNameFind.Text)
    End Sub


    Private Sub txtNameFind_TextChanged(sender As Object, e As EventArgs) Handles txtNameFind.TextChanged
        FindName(txtNameFind.Text)

    End Sub

    Private Sub frmMainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblIndex.Text = "Index:  " & ps.GetPersonCount
    End Sub
End Class