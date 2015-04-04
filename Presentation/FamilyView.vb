Imports WeifenLuo.WinFormsUI.Docking

Public Class frmFamilyView
    Implements IDockContent

    Public Property IndividualEditor As frmIndividualEditor

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frmFamilyView_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint

        ' Resize name panels
        pnlFather.Width = (Me.Width - 7) / 2
        With pnlMother
            .Width = (Me.Width - 7) / 2
            .Left = pnlFather.Width + 7
        End With

        'Resize marriage panel
        pnlMarriage.Width = Me.Width

        'Resize children list columns
        lvChildren.Columns(0).Width = Me.Width * 0.95 * 0.2
        lvChildren.Columns(1).Width = Me.Width * 0.95 * 0.1
        lvChildren.Columns(2).Width = Me.Width * 0.95 * 0.35
        lvChildren.Columns(3).Width = Me.Width * 0.95 * 0.35

    End Sub

    Public Sub LoadFamilyView()

        Dim ps As New PersonService

        lblFather.Text = ""
        lblMother.Text = ""
        lblMarriage.Text = ""
        lvChildren.Items.Clear()
        'cmsFatherSpouses.Items.Clear()
        'cmsMotherSpouses.Items.Clear()

        If IndividualEditor.spouse.Id > 0 Then

            Dim marriage As MarriageEvent = ps.GetMarriage(IndividualEditor.marriageIndex)

            Dim marriageString As String = ""

            UpdateFamilyViewMarriage(marriage.MarriageDate.ToString, marriage.MarriageLocation)

        End If

        Dim father As New Person
        Dim mother As New Person
        Dim visible As Boolean = False

        If IndividualEditor.FocusPerson.Gender = "M" Then
            father = IndividualEditor.FocusPerson
            mother = IndividualEditor.spouse
        Else
            father = IndividualEditor.spouse
            mother = IndividualEditor.FocusPerson
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

        'LoadSpousesContextMenu(cmsFatherSpouses, fatherSpouseArray)
        'LoadSpousesContextMenu(cmsMotherSpouses, motherSpouseArray)

    End Sub

    Public Sub UpdateFamilyViewMarriage(marriageDate As String, location As String)

        lblMarriage.Text = CreateDatePlaceString(marriageDate, location)

    End Sub

    Public Sub UpdateFamilyViewBirthDeath(type As String, eventDate As String, gender As Char)

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

    Public Sub UpdateFamilyViewBirthDeathLocation(type As String, location As String, gender As Char)

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

    Public Sub UpdateChildrenList(fatherId As Integer, motherId As Integer)

        Dim ps As New PersonService

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
End Class