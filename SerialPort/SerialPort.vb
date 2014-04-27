Imports System.IO
Public Class serialPort
    Public comPrifix As String = "//"
    Public comNewLine As Boolean = True
    Public comFreeEdit As Boolean = False
    Private isCtrlEnter As Boolean = False
    Private charCount As Integer = 0
    Private recvTextToHexCol As Integer = 16
    Private mousePos As System.Windows.Forms.MouseEventArgs
    'Private isAutoSave As Boolean = True

    Dim appendText As String = ""

    Private Sub Form1_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Dim dir As String = Application.StartupPath
        Dim path As String = dir & "\ATList.xml"
        Dim fileInfo As New FileInfo(path)
        If fileInfo.Exists = True Then
            chkAutoSave.Checked = True
            'ReadATFile("ATList.txt")
            Try
                ReadXmlFile(path)
            Catch ex As Exception
                Try
                    Dim xmlException As System.Xml.XmlException = ex.InnerException
                    MsgBox("指令读取失败：第" & xmlException.LineNumber & "行，第" & xmlException.LinePosition & "个字符。", MsgBoxStyle.Critical)
                Catch ex2 As Exception
                    MsgBox("指令读取失败。", MsgBoxStyle.Critical)
                End Try
                Me.Close()
            End Try

        End If
    End Sub

    Private Sub Form1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Dim path As String = Application.StartupPath & "\ATList.xml"
        If chkAutoSave.Checked = True Then
            'WriteATFile(path)
            WriteXmlFile(path)
        Else
            Shell("cmd /c del ATList.xml", vbHide)
        End If
    End Sub

    Private Sub ReadATFile(ByVal dir As String)
        Dim sr As System.IO.StreamReader = New System.IO.StreamReader(dir)
        Dim commandLine As String
        Dim commentLine As String
        lstATList.Items.Clear()
        lstComment.Items.Clear()
        commandLine = sr.ReadLine()
        commentLine = sr.ReadLine()
        If commentLine IsNot Nothing Then
            Do
                commandLine = commandLine.Replace("<CR>", vbCr)
                commandLine = commandLine.Replace("<LF>", vbLf)
                lstATList.Items.Add(commandLine)
                commentLine = commentLine.Replace("<CR>", vbCr)
                commentLine = commentLine.Replace("<LF>", vbLf)
                lstComment.Items.Add(commentLine)

                commandLine = sr.ReadLine()
                commentLine = sr.ReadLine()
            Loop Until commentLine Is Nothing
        End If
        'End If
        sr.Close()
    End Sub

    Private Sub WriteATFile(ByVal dir As String)
        Dim wr As System.IO.StreamWriter = New System.IO.StreamWriter(dir, False)
        Dim commandLine As String
        Dim commentLine As String
        For index As Integer = 0 To lstATList.Items.Count - 1
            commandLine = lstATList.Items(index).ToString
            commandLine = commandLine.Replace(vbCr, "<CR>")
            commandLine = commandLine.Replace(vbLf, "<LF>")
            wr.WriteLine(commandLine)

            commentLine = lstComment.Items(index).ToString
            commentLine = commentLine.Replace(vbCr, "<CR>")
            commentLine = commentLine.Replace(vbLf, "<LF>")
            wr.WriteLine(commentLine)
        Next
        wr.Close()
    End Sub

    Private Sub WriteXmlFile(ByVal dir As String)
        Dim saveAtCommandList As AtCommandList = New AtCommandList(lstATList.Items.Count - 1)
        Dim test As Integer = saveAtCommandList.getNumOfCommand
        PopulateAtCommandFormList(saveAtCommandList)
        saveAtCommandList.EncodeCrLf()
        Dim filename As String = dir
        saveAtCommandList.Save(filename)
    End Sub

    Private Sub ReadXmlFile(ByVal dir As String)
        Dim filename As String = dir
        Dim readAtCommandList As AtCommandList = SerializableData.Load(filename, GetType(AtCommandList))
        readAtCommandList.DecodeCrLf()
        PopulateListFormAtCommand(readAtCommandList)
    End Sub

    Private Sub PopulateAtCommandFormList(ByVal atCommandList As AtCommandList)
        Dim numberOfCommand As Integer = lstATList.Items.Count - 1
        For index As Integer = 0 To numberOfCommand
            atCommandList.Command(index) = lstATList.Items(index).ToString
            atCommandList.Comment(index) = lstComment.Items(index).ToString
        Next
    End Sub

    Private Sub PopulateListFormAtCommand(ByVal atCommandList As AtCommandList)
        Dim numberOfCommand As Integer = atCommandList.getNumOfCommand
        For index As Integer = 0 To numberOfCommand - 1
            lstATList.Items.Add(atCommandList.Command(index))
            lstComment.Items.Add(atCommandList.Comment(index))
        Next
    End Sub

    Private Sub PortConfig()
        On Error GoTo ErrorPortConfig
        If serialPort1.IsOpen = True Then
            serialPort1.BaudRate = txtBaudRate.Text
            serialPort1.DataBits = txtDataBits.Text
            Select Case cboParityBit.SelectedItem
                Case "奇校验"
                    serialPort1.Parity = IO.Ports.Parity.Odd
                Case "偶校验"
                    serialPort1.Parity = IO.Ports.Parity.Even
                Case "无"
                    serialPort1.Parity = IO.Ports.Parity.None
            End Select
            Select Case cboStopBits.SelectedItem
                Case "1"
                    serialPort1.StopBits = IO.Ports.StopBits.One
                Case "1.5"
                    serialPort1.StopBits = IO.Ports.StopBits.OnePointFive
                Case "2"
                    serialPort1.StopBits = IO.Ports.StopBits.Two
                Case "无"
                    serialPort1.StopBits = IO.Ports.StopBits.None
            End Select
            statSetup.Text = "设置已生效"
        End If
        Exit Sub
ErrorPortConfig:
        statSetup.Text = "设置失败"
    End Sub

    Private Sub WriteRecvFile(ByRef container As System.Windows.Forms.RichTextBox)
        If saveFile.ShowDialog() = Windows.Forms.DialogResult.OK And saveFile.FileName <> "" Then
            Dim wr As System.IO.StreamWriter = New System.IO.StreamWriter(saveFile.FileName, False)
            wr.Write(container.Text)
            wr.Close()
        End If
        saveFile.FileName = ""
    End Sub

    Public Function StrToHex(ByVal str As String) As String
        On Error Resume Next
        Dim out As String = ""

        Dim ascii As System.Text.Encoding = System.Text.Encoding.ASCII
        Dim bytesOfString() As Byte = ascii.GetBytes(str)
        For index As Integer = 0 To UBound(bytesOfString)
            If (bytesOfString(index) < 16) Then
                out &= "0" & Hex(bytesOfString(index)) & " "
            Else
                out &= Hex(bytesOfString(index)) & " "
            End If
        Next
        StrToHex = out

    End Function

    Private Sub SendTxt()
        If serialPort1.IsOpen = True Then
            serialPort1.Write(txtSendText.Text)
        End If
    End Sub

    Private Sub OpenPort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenPort.Click
        On Error GoTo ErrorOpenPort
        If serialPort1.IsOpen = False Then
            serialPort1.PortName = "COM" & txtPortNumber.Text
            'SerialPort1.BaudRate = BaudRate.Text
            serialPort1.Open()
            COMStatus.Text = "COM" & txtPortNumber.Text & "已打开"
            'PortConfig()
            'SetupStatus.Text = "设置已生效"
            btnOpenPort.Enabled = False
            txtPortNumber.Enabled = False
            btnClosePort.Enabled = True
            txtBaudRate.Enabled = True
            txtDataBits.Enabled = True
            cboParityBit.Enabled = True
            cboStopBits.Enabled = True
            btnSetPort.Enabled = True
            btnMotoSetup.Enabled = True
            btnSepuraSetup.Enabled = True
            btnSend.Enabled = True
        End If

        Exit Sub
ErrorOpenPort:
        COMStatus.Text = "串口打开失败，请检查串口是否存在或被占用"
        statSetup.Text = "设置未生效"
    End Sub

    Private Sub ClosePort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClosePort.Click
        On Error GoTo ErrorClosePort
        If serialPort1.IsOpen = True Then
            serialPort1.Close()
            COMStatus.Text = "COM" & txtPortNumber.Text & "已关闭"
            statSetup.Text = "设置未生效"
            btnOpenPort.Enabled = True
            txtPortNumber.Enabled = True
            btnClosePort.Enabled = False
            txtBaudRate.Enabled = False
            txtDataBits.Enabled = False
            cboParityBit.Enabled = False
            cboStopBits.Enabled = False
            btnSetPort.Enabled = False
            btnMotoSetup.Enabled = False
            btnSepuraSetup.Enabled = False
            btnSend.Enabled = False
        End If

        Exit Sub
ErrorClosePort:
        COMStatus.Text = "串口关闭失败"
    End Sub

    Private Sub SetPort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetPort.Click
        On Error GoTo ErrorSetPort
        serialPort1.BaudRate = txtBaudRate.Text
        PortConfig()
        Exit Sub
ErrorSetPort:
        statSetup.Text = "设置失败"
    End Sub

    Private Sub DefaultSetup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If serialPort1.IsOpen = True Then
            txtBaudRate.Text = 9600
            txtDataBits.Text = 8
            cboParityBit.Text = "奇校验"
            cboStopBits.Text = "无"
            PortConfig()
            statSetup.Text = "默认设置已生效"
        End If
    End Sub

    Private Sub MotoSetup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMotoSetup.Click
        If serialPort1.IsOpen = True Then
            serialPort1.BaudRate = 9600
            txtBaudRate.Text = 9600
            cboStopBits.Text = "无"
            statSetup.Text = "MOTO设置已生效"
        End If
    End Sub

    Private Sub SepuraSetup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSepuraSetup.Click
        If serialPort1.IsOpen = True Then
            serialPort1.BaudRate = 38400
            txtBaudRate.Text = 38400
            cboStopBits.Text = "无"
            statSetup.Text = "SEPURA设置已生效"
        End If
    End Sub

    Private Sub AddAT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddAT.Click
        If (txtSendText.Text <> "") Then
            lstATList.Items.Add(txtSendText.Text)
        End If
    End Sub

    Private Sub RemoveAT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveCommand.Click
        Dim index As Integer = lstATList.SelectedIndex
        If (index <> -1) Then
            lstATList.Items.Remove(lstATList.Items.Item(index))
            lstComment.Items.Remove(lstComment.Items.Item(index))
            'stripComment.Text = lstComment.Items.Item(lstATList.SelectedIndex).ToString
        End If

    End Sub

    Private Sub ClearAT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearAT.Click
        'ATList.Items.Clear()
        CommandDlg.ShowDialog()
    End Sub

    Private Sub ATList_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstATList.Click
        txtSendText.Text = lstATList.SelectedItem
        If lstATList.SelectedIndex <> -1 Then
            stripComment.Text = lstComment.Items.Item(lstATList.SelectedIndex)
        End If
    End Sub

    Private Sub ATList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstATList.DoubleClick
        If serialPort1.IsOpen = True And lstATList.SelectedItem <> "" Then
            serialPort1.Write(lstATList.SelectedItem)
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timer1.Tick
        Dim buff As String
        'Dim hexNumber As SByte
        Dim hexBuff As String
        If serialPort1.IsOpen = True Then
            buff = serialPort1.ReadExisting
            If buff <> "" Then
                rtxtRecvText.Text &= buff
                rtxtRecvText.Select(Len(rtxtRecvText.Text), 0)
                rtxtRecvText.ScrollToCaret()

                rtxtRecvComment.Text &= buff
                rtxtRecvComment.Select(Len(rtxtRecvComment.Text), 0)
                rtxtRecvComment.ScrollToCaret()

                hexBuff = StrToHex(buff)
                rtxtRecvHex.Text &= hexBuff
                rtxtRecvHex.Select(Len(rtxtRecvHex.Text), 0)
                rtxtRecvHex.ScrollToCaret()

                rtxtRecvTextToHex.Text &= CRLFFilter(buff)
                rtxtRecvTextToHex.Select(Len(rtxtRecvTextToHex.Text), 0)
                rtxtRecvTextToHex.ScrollToCaret()

                'RecvTextToHex2.Text &= CRLFFilter(buff)
                'RecvTextToHex2.Select(Len(RecvTextToHex2.Text), 0)
                'RecvTextToHex2.ScrollToCaret()

                'hexBuff = Hex(hexNumber)
                'RecvHex.Text &= hexBuff
            End If
        End If
    End Sub

    Private Function CRLFFilter(ByVal str As String) As String
        Dim newStr As String = ""

        For index As Integer = 0 To str.Length - 1
            If (str(index) = vbCr) Then
                newStr &= "."
            ElseIf (str(index) = vbLf) Then
                newStr &= "."
            Else
                newStr &= str(index)
            End If

            charCount = charCount + 1
            If (charCount = recvTextToHexCol) Then
                newStr &= vbCr
                charCount = 0
            End If
        Next
        Return newStr
    End Function

    Private Sub Import_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImport.Click
        If openFile.ShowDialog() = Windows.Forms.DialogResult.OK And openFile.FileName <> "" Then
            'ReadATFile(openFile.FileName)
            Try
                ReadXmlFile(openFile.FileName)
            Catch ex As System.InvalidOperationException
                Try
                    Dim xmlException As System.Xml.XmlException = ex.InnerException
                    MsgBox("指令读取失败：第" & xmlException.LineNumber & "行，第" & xmlException.LinePosition & "个字符。", MsgBoxStyle.Critical)
                Catch ex2 As Exception
                    MsgBox("指令读取失败。", MsgBoxStyle.Critical)
                End Try         
            End Try
        End If
        openFile.FileName = ""
        Exit Sub
    End Sub

    Private Sub Export_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click
        On Error GoTo ErrorExport
        If saveFile.ShowDialog() = Windows.Forms.DialogResult.OK And saveFile.FileName <> "" Then
            'WriteATFile(saveFile.FileName)
            WriteXmlFile(saveFile.FileName)
        End If
        saveFile.FileName = ""
        Exit Sub
ErrorExport:
        MsgBox("文件保存失败。")
    End Sub

    Private Sub Send_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
        SendTxt()
    End Sub

    Private Sub ClearSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearSend.Click
        txtSendText.Clear()
    End Sub

    Private Sub ClearRecvText_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearRecvText.Click
        rtxtRecvText.Clear()
    End Sub

    Private Sub Help_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        HelpDialog.ShowDialog()
    End Sub

    Private Sub ATList_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstATList.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Dim sPoint As Point = New Point(e.X, e.Y)
            Dim sIndex As Integer = lstATList.IndexFromPoint(sPoint.X, sPoint.Y)
            cmenuCommandList.Items.Clear()
            If sIndex <> -1 Then
                'ATList.SelectedItem = ATList.Items.Item(sIndex)
                lstATList.SetSelected(sIndex, True)
                'SendText.Text &= ATList.Items.Item(sIndex)
                cmenuCommandList.Items.Add(lstComment.Items.Item(sIndex))
                stripComment.Text = lstComment.Items.Item(sIndex).ToString
            Else
                'ContextMenuForList.Items.Add("")
            End If
        End If

    End Sub

    Private Sub ExitProgram_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub ClearRecvHex_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearRecvHex.Click
        rtxtRecvHex.Clear()
        rtxtRecvTextToHex.Clear()

    End Sub

    Private Sub ClearRecvCom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearRecvCom.Click
        rtxtRecvComment.Clear()
    End Sub

    Private Sub SaveRecvText_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveRecvText.Click
        WriteRecvFile(rtxtRecvText)
    End Sub

    Private Sub AddCom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddComment.Click
        Dim comString As String = ""
        If comNewLine = True Then
            comString &= vbCrLf
        End If
        comString &= comPrifix & txtSendText.Text & vbCrLf
        rtxtRecvComment.Text &= comString
        rtxtRecvComment.Select(Len(rtxtRecvComment.Text), 0)
        rtxtRecvComment.ScrollToCaret()
    End Sub

    Private Sub SplitLine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSplitLine.Click
        rtxtRecvComment.Text &= vbCrLf & "-----------------------------------------------------------" & vbCrLf
        rtxtRecvComment.Select(Len(rtxtRecvComment.Text), 0)
        rtxtRecvComment.ScrollToCaret()
    End Sub

    Private Sub ComSetup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommentSetup.Click
        ComSetupDia.ShowDialog()
    End Sub

    Private Sub SaveRecvHex_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveRecvHex.Click
        WriteRecvFile(rtxtRecvHex)
    End Sub

    Private Sub SaveRecvCom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveRecvCom.Click
        WriteRecvFile(rtxtRecvComment)
    End Sub

    Private Sub SendText_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSendText.KeyDown
        If e.Control And e.KeyCode = Keys.Enter Then
            e.Handled = True
            isCtrlEnter = True
            txtSendText.Text.Remove(Len(txtSendText.Text) - 1, 1)
            SendTxt()
        End If
    End Sub

    Private Sub SendText_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSendText.KeyPress
        If isCtrlEnter Then
            e.Handled = True
            isCtrlEnter = False
        End If
    End Sub

    Private Sub ViewPort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Shell("cmd.exe /k" & " devmgmt.msc", vbHide)
    End Sub

    Private Sub btnMsDetect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMsDetect.Click
        MsDetect.ShowDialog()
    End Sub

    Private Sub rtxtRecvTextToHex_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles rtxtRecvTextToHex.MouseUp
        rtxtRecvHex.SelectAll()
        rtxtRecvHex.SelectionColor = Color.Black
        'rtxtRecvTextToHex.SelectAll()
        'rtxtRecvTextToHex.SelectionColor = Color.Black
        Dim selStart As Integer
        Dim selLength As Integer
        Dim txt As String = rtxtRecvTextToHex.Text
        selStart = rtxtRecvTextToHex.SelectionStart
        selLength = rtxtRecvTextToHex.SelectionLength

        Dim newSelStart As Integer = selStart
        Dim newSelLength As Integer = selLength
        For index As Integer = 0 To selStart - 1
            If (txt(index) = vbLf) Then
                newSelStart = newSelStart - 1
            End If
        Next

        For index As Integer = selStart To selStart + selLength - 1
            If (txt(index) = vbLf) Then
                newSelLength = newSelLength - 1
            End If
        Next

        ' rtxtRecvHex.SelectionStart = selStart
        ' rtxtRecvHex.SelectionLength = selStart
        newSelStart = newSelStart * 3
        newSelLength = newSelLength * 3

        rtxtRecvHex.Select(newSelStart, newSelLength)
        rtxtRecvHex.SelectionColor = Color.Red

    End Sub

    Private Sub RecvTextToHex_VScroll(ByVal sender As Object, ByVal e As System.EventArgs) Handles rtxtRecvTextToHex.VScroll
        Dim position As Integer
        position = rtxtRecvTextToHex.GetCharIndexFromPosition(New Point(0, 0))
        rtxtRecvText.Select(position, 1)
        rtxtRecvText.ScrollToCaret()

    End Sub

    Private Sub ClearList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearList.Click
        lstATList.Items.Clear()
        lstComment.Items.Clear()
        stripComment.Text = ""

    End Sub

    ' Private indexOfCommand As Integer = 0
    Private Sub btnAddAT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddCommand.Click
        Dim sendString As String = txtSendText.Text
        If (isCommentEnabled.Checked) Then
            Dim indexOfSlash As Integer = sendString.IndexOf("//")
            If (indexOfSlash = -1) Then
                lstATList.Items.Add(txtSendText.Text)
                lstComment.Items.Add("")
                'atCommandList.Command(indexOfCommand) = txtSendText.Text
                'atCommandList.Comment(indexOfCommand) = ""
            Else
                Dim command As String
                command = sendString.Substring(0, indexOfSlash)
                Dim indexOfComment As Integer = indexOfSlash + 2
                Dim comment As String = sendString.Substring(indexOfComment, sendString.Length - indexOfComment)
                lstATList.Items.Add(command)
                lstComment.Items.Add(comment)
                'atCommandList.Command(indexOfCommand) = command
                'atCommandList.Comment(indexOfCommand) = comment
            End If
        Else
            lstATList.Items.Add(sendString)
            lstComment.Items.Add("")
            'atCommandList.Command(indexOfCommand) = txtSendText.Text
            'atCommandList.Comment(indexOfCommand) = ""
        End If
        'indexOfCommand = indexOfCommand + 1
    End Sub

    Private Sub rtxtRecvHex_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles rtxtRecvHex.GotFocus
        rtxtRecvHex.SelectAll()
        rtxtRecvHex.SelectionColor = Color.Black
        rtxtRecvHex.Select(0, 0)
    End Sub

End Class
