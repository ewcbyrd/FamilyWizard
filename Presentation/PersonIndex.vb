Imports WeifenLuo.WinFormsUI.Docking

Public Class frmPersonIndex
    Implements IDockContent

    Private Shared _personList As Dictionary(Of Integer, Person)

    Public Property AncestorView As frmAncestorView
    Public Property IndividualEditor As frmIndividualEditor
    Public Property FamilyView As frmFamilyView
    Public Property CurrentPersonIndex As Integer
    
    Public Event PersonListUpdated()

    Public Property PersonList As Dictionary(Of Integer, Person)
        Get
            Return _personList
        End Get
        Set(value As Dictionary(Of Integer, Person))
            _personList = value
            If _personList.Count > 0 Then
                RaiseEvent PersonListUpdated()
            End If
        End Set
    End Property

    Public Sub New()

        PersonList = New Dictionary(Of Integer, Person)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub LoadNameList()

        ' Clear all data from the names list
        lvNames.Items.Clear()

        ' Iterate through the hashtable keys. Keys contain ID's of individuals in database.
        For Each individual As Person In PersonList.Values

            ' Call procedure to add individual to names list
            AddItemToPersonListView(individual)

        Next

    End Sub

    Public Function AddItemToPersonListView(individual As Person) As Integer

        Dim li As ListViewItem
        Dim dateString As String = ""

        li = Me.lvNames.Items.Add(individual.ToStringLastFirst)

        li.SubItems.Add(individual.Birth.EventDate.Year)

        li.SubItems.Add(individual.Death.EventDate.Year)

        li.Tag = individual.Id

        Return li.Index

    End Function

    Private Sub frmPersonIndex_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        'Resize the names list columns based upon the size of its container
        lvNames.Columns(0).Width = (Me.Width * 0.95) * 0.4
        lvNames.Columns(1).Width = (Me.Width * 0.95) * 0.25
        lvNames.Columns(2).Width = (Me.Width * 0.95) * 0.25
    End Sub


    Private Sub frmPersonIndex_PersonListUpdated() Handles Me.PersonListUpdated
        LoadNameList()
    End Sub

    

    Private Sub lvNames_Click(sender As Object, e As EventArgs) Handles lvNames.Click

        Dim ps As New PersonService

        Dim lv As ListView = CType(sender, ListView)

        Dim personId As Integer

        Dim items As ListView.SelectedListViewItemCollection = lv.SelectedItems

        Dim item As ListViewItem

        Dim selectedItemIndex As Integer = -1

        For Each item In items
            personId = item.Tag

            selectedItemIndex = item.Index
            ' SetPersonIndex(personId)
        Next

        AncestorView.AncestorList = ps.GetAncestors(personId)
        individualEditor.FocusPerson = ps.GetPersonById(personId)
        FamilyView.LoadFamilyView()

        'If personId <> 0 Then
        '    SetFocusPerson(personId)
        'End If

    End Sub

    Public Sub SetCurrentPersonIndex(tag As Integer)
        For Each item As ListViewItem In lvNames.Items
            If item.Tag = tag Then
                CurrentPersonIndex = item.Index
                Exit For
            End If
        Next
    End Sub

End Class