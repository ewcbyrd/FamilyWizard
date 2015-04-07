Imports WeifenLuo.WinFormsUI.Docking

Public Class frmMainFormDocking

    Private ps As New PersonService
    Private es As New EventService
    Private dfs As New DataFileService

    Private Property PersonIndex As frmPersonIndex
    Private Property FamilyView As frmFamilyView
    Private Property AncestorView As frmAncestorView
    Private Property IndividualEditor As frmIndividualEditor
    Private Property MarriageView As frmMarriageView

    Private Shared Property DataFile As DataFileDescriptor

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        AncestorView = New frmAncestorView

        AncestorView.Show(DockPanel1, DockState.Document)

        FamilyView = New frmFamilyView

        FamilyView.Show(AncestorView.Pane, DockAlignment.Bottom, 0.66)

        IndividualEditor = New frmIndividualEditor

        IndividualEditor.Show(DockPanel1, DockState.DockRight)

        PersonIndex = New frmPersonIndex

        PersonIndex.Show(DockPanel1, DockState.DockLeft)

        MarriageView = New frmMarriageView
        MarriageView.Show(FamilyView.Pane, DockAlignment.Bottom, 0.25)

        PersonIndex.AncestorView = AncestorView
        PersonIndex.IndividualEditor = IndividualEditor
        PersonIndex.FamilyView = FamilyView
        
        IndividualEditor.AncestorView = AncestorView
        IndividualEditor.PersonIndex = PersonIndex
        IndividualEditor.FamilyView = FamilyView
        IndividualEditor.MarriageView = MarriageView

        FamilyView.IndividualEditor = IndividualEditor

        AncestorView.IndividualEditor = IndividualEditor

        MarriageView.IndividualEditor = IndividualEditor
        MarriageView.FamilyView = FamilyView

    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click

        OpenFileDialog1.Filter = "fwz files (*.fwz)|*.fwz"

        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

            DataFile = dfs.Read(OpenFileDialog1.FileName)

            Dim prefix As String = DataFile.PathName & "\" & DataFile.FileName & "_"

            Me.Text = "Family Wizard - " & DataFile.FileName

            My.Settings.CurrentPersonIndex = DataFile.CurrentPersonIndex
            My.Settings.CurrentEventIndex = DataFile.CurrentEventIndex
            My.Settings.CurrentMarriageIndex = DataFile.CurrentMarriageIndex

            es.LoadEventList(prefix & "events.dat")
            ps.LoadPersonList(prefix & "persons.dat")
            ps.LoadMarriageList(prefix & "marriages.dat")

            If DataFile.DefaultPersonIndex > 0 Then
                AncestorView.AncestorList = ps.GetAncestors(DataFile.DefaultPersonIndex)
                IndividualEditor.FocusPerson = ps.GetPersonById(DataFile.DefaultPersonIndex)

            End If

            PersonIndex.PersonList = ps.GetPersonList

            PersonIndex.lblIndex.Text = "Index: " & ps.GetPersonCount

            Timer1.Enabled = True

        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick, Me.FormClosed

        Dim filePrefix As String

        If DataFile IsNot Nothing Then

            filePrefix = DataFile.PathName & "\" & DataFile.FileName & "_"
            DataFile.CurrentPersonIndex = My.Settings.CurrentPersonIndex
            DataFile.CurrentEventIndex = My.Settings.CurrentEventIndex
            DataFile.CurrentMarriageIndex = My.Settings.CurrentMarriageIndex

            ps.WritePersonFile(filePrefix & "persons.dat")
            es.WriteFile(filePrefix & "events.dat")
            ps.WriteMarriageFile(filePrefix & "marriages.dat")
            dfs.Write(DataFile)

        End If

    End Sub

    Private Sub AddFatherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddFatherToolStripMenuItem.Click, _
        AddMotherToolStripMenuItem.Click

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

        Dim dialog As New frmNewPerson("Add " & targetString & " to " & IndividualEditor.FocusPerson.ToString, gender)

        Dim result As DialogResult = dialog.ShowDialog

        If result = Windows.Forms.DialogResult.OK Then
            If dialog.NameString <> "" Then

                Dim person As Person = dialog.ProcessNewPerson

                Dim parentId As Integer = ps.AddPerson(person)

                Select Case tsmi.Name
                    Case "AddFatherToolStripMenuItem"
                        ps.AddParent(IndividualEditor.FocusPerson.Id, parentId, "father")

                        ' Set the father id of the focus person
                        IndividualEditor.FocusPerson.FatherId = parentId

                        ' Add a new marriage event if a mother is already associated with the focus person
                        If IndividualEditor.FocusPerson.MotherId <> 0 Then
                            ps.AddMarriage(IndividualEditor.FocusPerson.FatherId, IndividualEditor.FocusPerson.MotherId)
                        End If
                    Case "AddMotherToolStripMenuItem"
                        ps.AddParent(IndividualEditor.FocusPerson.Id, parentId, "mother")

                        ' Set the mother id of the focus person
                        IndividualEditor.FocusPerson.MotherId = parentId

                        ' Add a new marriage event if a father is already associated with the focus person
                        If IndividualEditor.FocusPerson.FatherId <> 0 Then
                            ps.AddMarriage(IndividualEditor.FocusPerson.FatherId, IndividualEditor.FocusPerson.MotherId)
                        End If
                End Select

                PersonIndex.AddItemToPersonListView(ps.GetPersonById(parentId))

                AncestorView.AncestorList = ps.GetAncestors(IndividualEditor.FocusPerson.Id)

                PersonIndex.lblIndex.Text = "Index:  " & ps.GetPersonCount

            End If
        End If
    End Sub

    Private Sub AddSpouseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddSpouseToolStripMenuItem.Click

        Dim gender As String = ""

        Select Case IndividualEditor.FocusPerson.Gender
            Case "M"
                gender = "Female"
            Case "F"
                gender = "Male"
            Case "?"
                gender = "Unknown"
        End Select

        Dim dialog As New frmNewPerson("Add Spouse to " & IndividualEditor.FocusPerson.ToString, gender)

        Dim result As DialogResult = dialog.ShowDialog

        If result = Windows.Forms.DialogResult.OK Then
            If dialog.NameString <> "" Then

                ' Process the data entered in the new person dialogue
                Dim person As Person = dialog.ProcessNewPerson

                ' Add the new person to the database and assign the key to spouseId
                Dim spouseId As Integer = ps.AddPerson(person)


                ' Add a marriage record to the database
                Dim marriageId As Integer = 0

                If IndividualEditor.FocusPerson.Gender = "M" Then
                    marriageId = ps.AddMarriage(IndividualEditor.FocusPerson.Id, spouseId)
                Else
                    marriageId = ps.AddMarriage(spouseId, IndividualEditor.FocusPerson.Id)
                End If

                IndividualEditor.spouse = ps.GetPersonById(spouseId)

                IndividualEditor.btnMarriage.Text = "Marriage to " & IndividualEditor.spouse.ToString
                IndividualEditor.btnMarriage.Tag = IndividualEditor.spouse.Id
                IndividualEditor.txtMarriageDate.Clear()
                IndividualEditor.txtMarriagePlace.Clear()

                'Set the focus marriage index
                IndividualEditor.MarriageIndex = marriageId

                'Add new spouse to marriage view
                Dim marriage As New Marriage
                marriage.Spouse = person
                marriage.Marriage = ps.GetMarriage(marriageId)

                MarriageView.AddMarriage(marriage)

                'Add new person to names list
                PersonIndex.AddItemToPersonListView(IndividualEditor.spouse)

                FamilyView.LoadFamilyView()

                PersonIndex.lblIndex.Text = "Index:  " & ps.GetPersonCount

            End If

        End If
    End Sub

    Private Sub AddChildToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddChildToolStripMenuItem.Click

        Dim parentPicker As New frmParentPicker(IndividualEditor.FocusPerson)

        Dim pickResult As DialogResult = parentPicker.ShowDialog

        If pickResult = Windows.Forms.DialogResult.OK Then

            Dim spouseId As Integer = parentPicker.SelectedSpouseIndex

            Dim dialog As New frmNewPerson("Add child to " & IndividualEditor.FocusPerson.ToString & " and " & IndividualEditor.spouse.ToString, "Unknown")

            Dim result As DialogResult = dialog.ShowDialog

            If result = Windows.Forms.DialogResult.OK Then
                If dialog.NameString <> "" Then

                    Dim person As Person = dialog.ProcessNewPerson

                    If IndividualEditor.FocusPerson.Gender = "M" Then
                        person.FatherId = IndividualEditor.FocusPerson.Id
                        person.MotherId = spouseId
                    Else
                        person.FatherId = spouseId
                        person.MotherId = IndividualEditor.FocusPerson.Id
                    End If

                    Dim childId As Integer = ps.AddPerson(person)

                    person = ps.GetPersonById(childId)

                    PersonIndex.AddItemToPersonListView(person)

                    FamilyView.Children = ps.GetChildren(person.FatherId, person.MotherId)

                    PersonIndex.lblIndex.Text = "Index:  " & ps.GetPersonCount

                End If
            End If
        End If
    End Sub

    Private Sub AddUnrelatedPersonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddUnrelatedPersonToolStripMenuItem.Click

        Dim dialog As New frmNewPerson("Add Person", "Unknown")

        Dim result As DialogResult = dialog.ShowDialog

        If result = Windows.Forms.DialogResult.OK Then
            If dialog.NameString <> "" Then

                Dim person As Person = dialog.ProcessNewPerson

                Dim personId As Integer = ps.AddPerson(person)

                'PersonIndex = PersonIndex.AddItemToPersonListView(ps.GetPersonById(personId))

                PersonIndex.lblIndex.Text = "Index:  " & ps.GetPersonCount

                IndividualEditor.FocusPerson = ps.GetPersonById(personId)

            End If
        End If

    End Sub

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
                        ps.AddParent(IndividualEditor.FocusPerson.Id, selectedIndex, "father")

                        ' Set the father id of the focus person
                        IndividualEditor.FocusPerson.FatherId = selectedIndex

                        ' Add a new marriage event if a mother is already associated with the focus person
                        If IndividualEditor.FocusPerson.MotherId <> 0 Then
                            ps.AddMarriage(IndividualEditor.FocusPerson.FatherId, IndividualEditor.FocusPerson.MotherId)
                        End If
                    Case "AttachMotherToolStripMenuItem"
                        ps.AddParent(IndividualEditor.FocusPerson.Id, selectedIndex, "mother")

                        ' Set the mother id of the focus person
                        IndividualEditor.FocusPerson.MotherId = selectedIndex

                        ' Add a new marriage event if a father is already associated with the focus person
                        If IndividualEditor.FocusPerson.FatherId <> 0 Then
                            ps.AddMarriage(IndividualEditor.FocusPerson.FatherId, IndividualEditor.FocusPerson.MotherId)
                        End If
                End Select

            End If

            AncestorView.AncestorList = ps.GetAncestors(IndividualEditor.FocusPerson.Id)

        End If
    End Sub

    Private Sub DeletePersonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeletePersonToolStripMenuItem.Click

        If MessageBox.Show("Do you want to delete " & IndividualEditor.FocusPerson.ToString & " from your tree", "Delete Person", _
                           MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then

            ' Delete person 
            ps.DeletePerson(IndividualEditor.FocusPerson)

            ' Remove person from names list
            For Each listItem As ListViewItem In PersonIndex.lvNames.Items
                If listItem.Tag = IndividualEditor.FocusPerson.Id Then
                    listItem.Remove()
                    Exit For
                End If
            Next

            ' Set new focus person
            If IndividualEditor.FocusPerson.FatherId <> 0 Then
                IndividualEditor.FocusPerson = ps.GetPersonById(IndividualEditor.FocusPerson.FatherId)
            Else
                IndividualEditor.FocusPerson = ps.GetPersonById(DataFile.DefaultPersonIndex)
            End If

            PersonIndex.lblIndex.Text = "Index:  " & ps.GetPersonCount

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
                If IndividualEditor.FocusPerson.Gender = "M" Then
                    marriageId = ps.AddMarriage(IndividualEditor.FocusPerson.Id, selectedIndex)
                Else
                    marriageId = ps.AddMarriage(selectedIndex, IndividualEditor.FocusPerson.Id)
                End If

                Dim spouse As Person = ps.GetPersonById(selectedIndex)

                IndividualEditor.btnMarriage.Text = "Marriage to " & spouse.ToString
                IndividualEditor.btnMarriage.Tag = spouse.Id
                IndividualEditor.txtMarriageDate.Clear()
                IndividualEditor.txtMarriagePlace.Clear()

                'Set the focus marriage index
                IndividualEditor.MarriageIndex = marriageId

                'Add new spouse to marriage view
                MarriageView.Marriages = ps.GetMarriageList(IndividualEditor.FocusPerson)

            End If

        End If

    End Sub

    Private Sub AttachChildToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AttachChildToolStripMenuItem.Click

        Dim parentPicker As New frmParentPicker(IndividualEditor.FocusPerson)

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
                    If IndividualEditor.FocusPerson.Gender = "M" Then
                        person.FatherId = IndividualEditor.FocusPerson.Id
                        person.MotherId = spouseId
                    Else
                        person.FatherId = spouseId
                        person.MotherId = IndividualEditor.FocusPerson.Id
                    End If

                    ' Update person's parents 
                    ps.UpdateParents(person.Id, person.FatherId, person.MotherId)

                    FamilyView.Children = ps.GetChildren(person.FatherId, person.MotherId)

                End If
            End If
        End If

    End Sub

    Private Sub AncestorViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AncestorViewToolStripMenuItem.Click

        If AncestorView.IsHidden = False Then
            AncestorView.Hide()
            AncestorViewToolStripMenuItem.Checked = False
        Else
            AncestorView.Show()
            AncestorViewToolStripMenuItem.Checked = True
        End If

    End Sub

    Private Sub FamilyViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FamilyViewToolStripMenuItem.Click

        If FamilyView.IsHidden = False Then
            FamilyView.Hide()
            FamilyViewToolStripMenuItem.Checked = False
        Else
            FamilyView.Show()
            FamilyViewToolStripMenuItem.Checked = True
        End If

    End Sub
    
End Class