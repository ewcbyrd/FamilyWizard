Imports WeifenLuo.WinFormsUI.Docking

Public Class frmAncestorView
    Implements IDockContent

    Public Event AncestorListChanged()
    Public Property IndividualEditor As frmIndividualEditor

    Private Shared _ancestorList As Dictionary(Of Integer, Person)

    Public Property AncestorList As Dictionary(Of Integer, Person)
        Get
            Return _ancestorList
        End Get
        Set(value As Dictionary(Of Integer, Person))
            _ancestorList = value
            If _ancestorList.Count > 0 Then
                RaiseEvent AncestorListChanged()
            End If
        End Set
    End Property

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub LoadAncestorView()

        ' Loop through all labels in Ancestor View panel.  Set their background color to Dark Gray
        For Each lbl As Label In Me.Controls
            lbl.BackColor = Color.DarkGray
        Next

        ' Retrieve ancestors of focus person and assign to ancestors hashtable
        'Dim ancestors As Dictionary(Of Integer, Person) = ps.GetAncestors(FocusPerson.Id)

        With lblIndividual1
            .Text = GetAncestorString(_ancestorList(1))
            .Tag = _ancestorList(1).Id
            .BackColor = Color.DarkOliveGreen
            .ForeColor = Color.White
        End With

        With lblIndividual2
            .Text = GetAncestorString(_ancestorList(2))
            .Tag = _ancestorList(2).Id
        End With

        With lblIndividual3
            .Text = GetAncestorString(_ancestorList(3))
            .Tag = _ancestorList(3).Id
        End With

        With lblIndividual4
            .Text = GetAncestorString(_ancestorList(4))
            .Tag = _ancestorList(4).Id
        End With

        With lblIndividual5
            .Text = GetAncestorString(_ancestorList(5))
            .Tag = _ancestorList(5).Id
        End With

        With lblIndividual6
            .Text = GetAncestorString(_ancestorList(6))
            .Tag = _ancestorList(6).Id
        End With

        With lblIndividual7
            .Text = GetAncestorString(_ancestorList(7))
            .Tag = _ancestorList(7).Id
        End With

        With lblIndividual8
            .Text = GetAncestorString(_ancestorList(8))
            .Tag = _ancestorList(8).Id
        End With

        With lblIndividual9
            .Text = GetAncestorString(_ancestorList(9))
            .Tag = _ancestorList(9).Id
        End With

        With lblIndividual10
            .Text = GetAncestorString(_ancestorList(10))
            .Tag = _ancestorList(10).Id
        End With

        With lblIndividual11
            .Text = GetAncestorString(_ancestorList(11))
            .Tag = _ancestorList(11).Id
        End With

        With lblIndividual12
            .Text = GetAncestorString(_ancestorList(12))
            .Tag = _ancestorList(12).Id
        End With

        With lblIndividual13
            .Text = GetAncestorString(_ancestorList(13))
            .Tag = _ancestorList(13).Id
        End With

        With lblIndividual14
            .Text = GetAncestorString(_ancestorList(14))
            .Tag = _ancestorList(14).Id
        End With

        With lblIndividual15
            .Text = GetAncestorString(_ancestorList(15))
            .Tag = _ancestorList(15).Id
        End With

        Me.Refresh()

    End Sub

    Private Function GetAncestorString(person As Person) As String

        Dim ancestorString As String = ""

        If person.Id > 0 Then
            ancestorString += person.ToString & " " & "(" & person.Birth.EventDate.Year & _
                " - " & person.Death.EventDate.Year & ")"
        End If

        Return ancestorString

    End Function

    Private Sub frmAncestorView_AncestorListChanged() Handles Me.AncestorListChanged
        LoadAncestorView()
    End Sub


    Private Sub frmAncestorView_Load(sender As Object, e As EventArgs) Handles Me.Load
        

    End Sub

    Private Sub frmAncestorView_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        ' Calculate spacing between rightmost column of labels
        ' Equals space not occupied by labels (labels occupy 200) 
        ' Plus 11 on top and bottom.  Total of 222.
        Dim spacing As Integer = (Me.Height - 222) / 7

        ' Set width of labels to 23.2% of total space
        For Each c As Control In Me.Controls
            c.Width = Me.Width * 0.232
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

    Private Sub lblIndividual1_Click(sender As Object, e As EventArgs) Handles lblIndividual1.Click, lblIndividual10.Click, lblIndividual11.Click, _
        lblIndividual12.Click, lblIndividual13.Click, lblIndividual14.Click, lblIndividual15.Click, lblIndividual2.Click, lblIndividual3.Click, _
        lblIndividual4.Click, lblIndividual5.Click, lblIndividual6.Click, lblIndividual7.Click, lblIndividual8.Click, lblIndividual9.Click

        Dim ps As New PersonService
        Dim lbl As Label = CType(sender, Label)

        If Not lbl.Text.Equals("") Then
            For Each c As Control In Me.Controls

                c.BackColor = Color.DarkGray
                c.ForeColor = Color.Black

            Next

            lbl.BackColor = Color.DarkOliveGreen
            lbl.ForeColor = Color.White

            IndividualEditor.FocusPerson = ps.GetPersonById(lbl.Tag)

        End If

    End Sub

End Class