Imports WeifenLuo.WinFormsUI.Docking

Public Class frmFamilyView
    Implements IDockContent


    Public Event ChildrenChanged()

    Private _children As ArrayList

    Public Property IndividualEditor As frmIndividualEditor

    Public Property Children As ArrayList
        Get
            Return _children
        End Get
        Set(value As ArrayList)
            _children = value
            RaiseEvent ChildrenChanged()
        End Set
    End Property

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frmFamilyView_ChildrenChanged() Handles Me.ChildrenChanged

        lvChildren.Items.Clear()

        For Each individual As Person In Children

            Dim li As ListViewItem

            li = lvChildren.Items.Add(individual.ToString)
            li.SubItems.Add(individual.Gender)
            li.SubItems.Add(CreateDatePlaceString(individual.Birth.EventDate.ToString, individual.Birth.EventLocation))
            li.SubItems.Add(CreateDatePlaceString(individual.Death.EventDate.ToString, individual.Death.EventLocation))
            li.Tag = individual.Id

        Next

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
        'lvChildren.Items.Clear()

        If IndividualEditor.Spouse IsNot Nothing Then

            Dim marriage As MarriageEvent = ps.GetMarriage(IndividualEditor.MarriageIndex)

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

        If father Is Nothing Then
            visible = False
        Else
            visible = True
        End If

        For Each c As Control In pnlFather.Controls
            c.Visible = visible
        Next

        If mother Is Nothing Then
            visible = False
        Else
            visible = True
        End If

        For Each c As Control In pnlMother.Controls
            c.Visible = visible
        Next

        ' Add father and mother data to panels
        If father IsNot Nothing Then
            UpdateFather(father)
        End If

        If mother IsNot Nothing Then
            UpdateMother(mother)
        End If

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

    Public Sub UpdateFather(father As Person)

        lblFather.Text = father.ToString
        lblFatherBirthDate.Text = father.Birth.EventDate.ToString
        lblFatherBirthLocation.Text = father.Birth.EventLocation
        lblFatherDeathDate.Text = father.Death.EventDate.ToString
        lblFatherDeathLocation.Text = father.Death.EventLocation

    End Sub

    Public Sub UpdateMother(mother As Person)

        lblMother.Text = mother.ToString
        lblMotherBirthDate.Text = mother.Birth.EventDate.ToString
        lblMotherBirthLocation.Text = mother.Birth.EventLocation
        lblMotherDeathDate.Text = mother.Death.EventDate.ToString
        lblMotherDeathLocation.Text = mother.Death.EventLocation

    End Sub
End Class