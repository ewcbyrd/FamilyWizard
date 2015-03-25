﻿Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO

Public Class DataFileDAO
    Implements IDataFileDAO

    Public Function Read(fn As String) As DataFileDescriptor Implements IDataFileDAO.Read

        Dim formatter As New BinaryFormatter()

        Dim dfd As DataFileDescriptor

        Using input As New FileStream(fn, FileMode.Open)
            dfd = CType(formatter.Deserialize(input), DataFileDescriptor)
        End Using

        Return dfd

    End Function

    Public Sub Write(dfd As DataFileDescriptor) Implements IDataFileDAO.Write

        Dim formatter As New BinaryFormatter()

        Dim filename As String

        filename = dfd.PathName + dfd.FileName

        Using output As New FileStream(filename, FileMode.Create)
            formatter.Serialize(output, dfd)
        End Using


    End Sub
End Class
