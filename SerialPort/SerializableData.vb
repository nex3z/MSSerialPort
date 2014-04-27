Imports System.IO
Imports System.Xml.Serialization
Public Class SerializableData
    Public Sub Save(ByVal filename As String)
        Dim tempFilename As String
        tempFilename = filename & ".tmp"

        Dim tempFileInfo As New FileInfo(tempFilename)
        If tempFileInfo.Exists = True Then
            tempFileInfo.Delete()
        End If

        Dim stream As New FileStream(tempFilename, FileMode.Create)
        Save(stream)
        stream.Close()
        Try
            tempFileInfo.CopyTo(filename, True)
            tempFileInfo.Delete()
        Catch ex As Exception

        End Try

    End Sub

    Public Sub Save(ByVal stream As Stream)
        Dim serializer As New XmlSerializer(Me.GetType)
        serializer.Serialize(stream, Me)

    End Sub
    Public Shared Function Load(ByVal filename As String, ByVal newType As Type) As Object
        Dim fileInfo As New FileInfo(filename)
        If fileInfo.Exists = False Then
            Return System.Activator.CreateInstance(newType)
        End If
        Dim stream As New FileStream(filename, FileMode.Open)
        Dim newObject As Object = Load(stream, newType)
        stream.Close()
        Return newObject
    End Function

    Public Shared Function Load(ByVal stream As Stream, ByVal newType As Type) As Object
        Dim serializer As New XmlSerializer(newType)
        Dim newObject As Object = serializer.Deserialize(stream)
        Return newObject
    End Function

End Class
