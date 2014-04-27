Imports System.Windows.Forms

Public Class HelpDialog

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub


    Private Sub OpenHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHistory.Click
        If btnHistory.Text = "版本历史↓" Then
            Me.Height = 562
            btnHistory.Text = "版本历史↑"
        Else
            Me.Height = 328
            btnHistory.Text = "版本历史↓"
        End If
    End Sub

    Private Sub HelpDialog_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Label1.Text = serialPort.Text & " 简易帮助"
    End Sub
End Class
