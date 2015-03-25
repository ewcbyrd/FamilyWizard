Public Interface IDataFileDAO

    Sub Write(dfd As DataFileDescriptor)
    Function Read(fn As String) As DataFileDescriptor

End Interface
