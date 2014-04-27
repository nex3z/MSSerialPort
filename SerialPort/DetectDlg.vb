Imports System.Windows.Forms

Public Class MsDetect
    Dim progressStep As Integer = 1
    Dim currentType As String
    Dim currentNumber As String
    Dim isHytera As Boolean = False
    Dim numberLength As Integer = 3

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnStartDetect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartDetect.Click
        EnableControl(False)

        Try
            numberLength = Convert.ToInt32(txtNumberLength.Text)
            If numberLength < 1 Or numberLength > 16 Then
                MessageBox.Show("号码长度设置错误，长度范围为1~16。", "错误")
                EnableControl(True)
                Return
            End If
        Catch ex As Exception
            MessageBox.Show("号码长度设置错误，长度范围为1~16。", "错误")
            EnableControl(True)
            Return
        End Try

        progbarDetect.Value = 0

        Dim portList() As String
        Dim portNumber As Integer
        Dim baudRate As Integer
        portList = IO.Ports.SerialPort.GetPortNames()
        portList = SortPortNames(portList)
        portNumber = portList.Length
        txtDetectResult.AppendText("当前存在" & portNumber & "个端口..." & vbCrLf)

        progbarDetect.Value = 100 / (portNumber + 1)

        For index As Integer = 0 To portNumber - 1
            Try
                OpenPort(portList(index))
            Catch ex As Exception
                txtDetectResult.AppendText(portList(index) & "--被占用" & vbCrLf)
                progbarDetect.Value = progbarDetect.Value + 100 / (portNumber + 1) - 1
                Continue For
            End Try

            If (PortForDetection.IsOpen) Then
                baudRate = DetectBaudRate()
                If baudRate > 0 Then
                    currentType = DetectType(baudRate)
                Else
                    currentType = "未知"
                End If

                progbarDetect.Value = progbarDetect.Value + 100 / (portNumber + 1) * 0.5 - 1

                currentNumber = DetectNumber(currentType)
                progbarDetect.Value = progbarDetect.Value + 100 / (portNumber + 1) * 0.5 - 1

                txtDetectResult.AppendText(portList(index) & "--连接的手台类型为：" & currentType)
                txtDetectResult.AppendText(",号码为：" & currentNumber & vbCrLf)

            End If
            PortForDetection.Close()

        Next

        txtDetectResult.AppendText("检测完毕。" & vbCrLf & vbCrLf)
        progbarDetect.Value = 100

        EnableControl(True)
    End Sub

    Private Function DetectBaudRate() As Integer
        Dim buffer As String

        SetBaudRate(9600)
        buffer = PortForDetection.ReadExisting()
        PortForDetection.Write("AT" & vbCrLf)
        Delay()
        buffer = PortForDetection.ReadExisting()
        If (buffer.IndexOf("OK") <> -1 Or buffer.IndexOf("CME") <> -1) Then
            Return 9600
        End If

        SetBaudRate(38400)
        PortForDetection.ReadExisting()
        PortForDetection.Write("AT" & vbCrLf)
        Delay()
        buffer = PortForDetection.ReadExisting()
        If (buffer.IndexOf("OK") <> -1 Or buffer.IndexOf("CME") <> -1) Then
            Return 38400
        End If

        Return -1
    End Function
    Private Sub OpenPort(ByVal portName As String)
        PortForDetection.PortName = portName
        PortForDetection.Open()
    End Sub
    Private Sub SetBaudRate(ByVal baudRate As String)
        PortForDetection.BaudRate = baudRate
    End Sub
    Private Function DetectType(ByVal baudRate As Integer) As String
        Dim buffer As String

        SetBaudRate(baudRate)
        PortForDetection.ReadExisting()

        If baudRate = 9600 Then
            PortForDetection.Write("AT+GMI?" & vbCrLf)
            Delay()
            buffer = PortForDetection.ReadExisting()
            If buffer.IndexOf("MOTO") <> -1 Or buffer.IndexOf("moto") <> -1 Then
                Return "MOTO"
            ElseIf buffer.IndexOf("HYTERA") <> -1 Then
                Return "HYTERA"
            End If

            PortForDetection.Write("AT+GMI" & vbCrLf)
            Delay()
            buffer = PortForDetection.ReadExisting()
            If buffer.IndexOf("EADS") <> -1 Then
                Return "EADS"
            End If

        ElseIf baudRate = 38400 Then
            Return "SEPURA"
        End If

        Return "未知"
    End Function
    Private Function DetectNumber(ByVal msType As String) As String
        Dim buffer As String
        Dim msNumber As String
        Dim endIndex As Integer

        Select Case msType
            Case "HYTERA"
                PortForDetection.Write("AT+CNUM?" & vbCrLf)
                Delay()
                buffer = PortForDetection.ReadExisting()
                endIndex = buffer.IndexOf(",", buffer.IndexOf("0,") + 2)
            Case "MOTO"
                PortForDetection.Write("AT+CNUMF?" & vbCrLf)
                Delay()
                buffer = PortForDetection.ReadExisting()
                endIndex = buffer.IndexOf(vbCrLf, buffer.IndexOf("0,") + 2)
            Case "EADS"
                PortForDetection.Write("AT+CNUMF?" & vbCrLf)
                Delay()
                buffer = PortForDetection.ReadExisting()
                endIndex = buffer.IndexOf(vbCrLf, buffer.IndexOf("0,") + 2)
                If buffer(endIndex - 1) = " " Then
                    endIndex = endIndex - 1
                End If
            Case "SEPURA"
                PortForDetection.Write("AT+CNUM?" & vbCrLf)
                Delay()
                buffer = PortForDetection.ReadExisting()
                endIndex = buffer.IndexOf(",", buffer.IndexOf("0,") + 2)
            Case "未知"
                Return "未知"
        End Select

        If String.IsNullOrEmpty(buffer) Then
            Return "未知"
        Else
            msNumber = buffer.Substring(endIndex - numberLength, numberLength)
            Return msNumber
        End If
    End Function
    Private Sub Delay()
        System.Threading.Thread.Sleep(500)
    End Sub

    Private Sub btnClearResult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearResult.Click
        txtDetectResult.Clear()
        progbarDetect.Value = 0
    End Sub

    Private Sub btnViewPort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewPort.Click
        Shell("cmd.exe /k" & " devmgmt.msc", vbHide)
    End Sub

    Private Sub EnableControl(ByVal flag As Boolean)
        btnClearResult.Enabled = flag
        btnViewPort.Enabled = flag
        btnCancel.Enabled = flag
        btnStartDetect.Enabled = flag
        txtNumberLength.Enabled = flag
    End Sub

    Private Function SortPortNames(ByVal portNames() As String)
        Dim temp As String
        For j As Integer = 1 To portNames.Length - 1
            For i As Integer = 1 To portNames.Length - 1
                If portNames(i - 1) > portNames(i) Then
                    temp = portNames(i - 1)
                    portNames(i - 1) = portNames(i)
                    portNames(i) = temp
                End If
            Next
        Next

        Return portNames
    End Function
End Class
