Imports System.Windows.Forms

Public Class ComSetupDia

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        serialPort.comPrifix = txtPrifix.Text
        serialPort.comFreeEdit = chkFreeEditCheck.Checked
        serialPort.rtxtRecvComment.ReadOnly = Not chkFreeEditCheck.Checked
        serialPort.comNewLine = chkNewLineCheck.Checked
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ComSetup_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        txtPrifix.Text = serialPort.comPrifix
        chkFreeEditCheck.Checked = serialPort.comFreeEdit
        chkNewLineCheck.Checked = serialPort.comNewLine
    End Sub
End Class
