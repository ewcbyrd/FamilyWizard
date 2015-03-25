<Serializable()>
Public Class DataFileDescriptor

    Public Property FileName() As String
    Public Property PathName() As String
    Public Property CurrentPersonIndex() As Integer
    Public Property CurrentEventIndex() As Integer
    Public Property CurrentMarriageIndex() As Integer
    Public Property DefaultPersonIndex() As Integer

    Public Sub New()
        FileName = ""
        PathName = ""
        CurrentPersonIndex = 1
        CurrentMarriageIndex = 1
        CurrentEventIndex = 1
        DefaultPersonIndex = 0
    End Sub

    Public Sub New(fn As String, pn As String, cpi As Integer, cei As Integer, cmi As Integer, dpi As Integer)

        FileName = fn
        PathName = pn
        CurrentPersonIndex = cpi
        CurrentMarriageIndex = cmi
        CurrentEventIndex = cei
        DefaultPersonIndex = dpi

    End Sub
End Class
