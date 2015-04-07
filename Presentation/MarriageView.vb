Imports WeifenLuo.WinFormsUI.Docking

Public Class frmMarriageView
    Inherits DockContent

    Public Event MarriagesChange()

    Private Shared _marriages As New ArrayList
    Public Property IndividualEditor As frmIndividualEditor
    Public Property FamilyView As frmFamilyView

    Public Property Marriages As ArrayList
        Get
            Return _marriages
        End Get
        Set(value As ArrayList)
            _marriages = value
            RaiseEvent MarriagesChange()
        End Set
    End Property

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    
    Private Sub frmMarriageView_MarriagesChange() Handles Me.MarriagesChange

        lvMarriages.Items.Clear()

        If Marriages IsNot Nothing Then

            For Each item As Marriage In Marriages

                Dim li As New ListViewItem

                li = lvMarriages.Items.Add(item.Spouse.ToString)
                li.SubItems.Add(item.Marriage.MarriageDate.ToString)
                li.SubItems.Add(item.Marriage.MarriageLocation)
                li.Tag = item.Spouse.Id
            Next
        End If
    End Sub

    Public Sub AddMarriage(marriage As Marriage)

        _marriages.Add(marriage)
        RaiseEvent MarriagesChange()

    End Sub

    Private Sub lvMarriages_Click(sender As Object, e As EventArgs) Handles lvMarriages.Click
        Dim ps As New PersonService

        Dim lv As ListView = CType(sender, ListView)

        Dim personId As Integer = 0

        Dim items As ListView.SelectedListViewItemCollection = lv.SelectedItems

        Dim item As ListViewItem

        For Each item In items
            personId = item.Tag
        Next

        IndividualEditor.Spouse = ps.GetPersonById(personId)

        If IndividualEditor.Spouse.Gender = "M" Then
            FamilyView.UpdateFather(IndividualEditor.Spouse)
        Else
            FamilyView.UpdateMother(IndividualEditor.Spouse)
        End If

    End Sub

End Class