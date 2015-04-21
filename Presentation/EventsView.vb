Imports WeifenLuo.WinFormsUI.Docking

Public Class frmEventsView
    Inherits DockContent

    Public Property IndividualEditor As frmIndividualEditor

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click

        Dim eventEditor As New frmEventEditor("Add", IndividualEditor.FocusPerson)

        Dim result As DialogResult = eventEditor.ShowDialog

    End Sub
End Class