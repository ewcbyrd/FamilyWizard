Public Class DataFileService

    Private dfd As IDataFileDAO

    Public Sub New()
        dfd = New DataFileDAO
    End Sub

    Public Sub Write(dataFile As DataFileDescriptor)
        dfd.Write(dataFile)
    End Sub

    Public Function Read(fileName As String)
        Return dfd.Read(fileName)
    End Function

End Class
