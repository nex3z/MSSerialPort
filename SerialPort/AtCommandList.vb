Imports System.Text

Public Class AtCommandList
    Inherits SerializableData
    'Private NumberOfCommand As Integer
    'Public NumberOfCommand As Integer

    Private byteCtrlZ As Byte() = {26}
    Private asciiEncoding As Encoding = New System.Text.ASCIIEncoding()
    Private ctrlZ As String = asciiEncoding.GetString(byteCtrlZ)

    Public Command() As String
    Public Comment() As String

    Public Sub New(ByVal numberOfCommand As Integer)
        'Me.NumberOfCommand = numberOfCommand
        ReDim Command(numberOfCommand)
        ReDim Comment(numberOfCommand)
    End Sub

    Public Sub New()

    End Sub

    Public Function getNumOfCommand() As Integer
        Return Command.GetLength(0)
    End Function

    Public Sub EncodeCrLf()
        For index As Integer = 0 To Command.GetLength(0) - 1
            Command(index) = Command(index).Replace(vbCr, "[CR]")
            Command(index) = Command(index).Replace(vbLf, "[LF]")
            Command(index) = Command(index).Replace(ctrlZ, "[CRTLZ]")
            Comment(index) = Comment(index).Replace(vbCr, "[CR]")
            Comment(index) = Comment(index).Replace(vbLf, "[LF]")
            Comment(index) = Comment(index).Replace(ctrlZ, "[CRTLZ]")
        Next
    End Sub

    Public Sub DecodeCrLf()
        For index As Integer = 0 To Command.GetLength(0) - 1
            Command(index) = Command(index).Replace("[CR]", vbCr)
            Command(index) = Command(index).Replace("[LF]", vbLf)
            Command(index) = Command(index).Replace("[CRTLZ]", ctrlZ)
            Comment(index) = Comment(index).Replace("[CR]", vbCr)
            Comment(index) = Comment(index).Replace("[LF]", vbLf)
            Comment(index) = Comment(index).Replace("[CRTLZ]", ctrlZ)
        Next
    End Sub
End Class
