Module MainModule

    Public Sub Main()

        Dim mainForm As New frmMainForm
        Dim ps As New PersonService
        Dim es As New EventService

        es.LoadEventList()
        ps.LoadPersonList()
        ps.LoadMarriageList()

        mainForm.PIndex = My.Settings.DefaultPerson
        mainForm.SetFocusPerson(My.Settings.DefaultPerson)
        mainForm.LoadNameList(ps.GetPersonList)

        Application.Run(mainForm)

    End Sub
End Module
