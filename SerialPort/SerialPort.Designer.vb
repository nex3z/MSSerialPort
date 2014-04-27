<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class serialPort
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(serialPort))
        Me.groupPortSetup = New System.Windows.Forms.GroupBox()
        Me.btnMsDetect = New System.Windows.Forms.Button()
        Me.btnSepuraSetup = New System.Windows.Forms.Button()
        Me.btnMotoSetup = New System.Windows.Forms.Button()
        Me.btnSetPort = New System.Windows.Forms.Button()
        Me.cboStopBits = New System.Windows.Forms.ComboBox()
        Me.cboParityBit = New System.Windows.Forms.ComboBox()
        Me.txtDataBits = New System.Windows.Forms.TextBox()
        Me.txtBaudRate = New System.Windows.Forms.TextBox()
        Me.btnClosePort = New System.Windows.Forms.Button()
        Me.btnOpenPort = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPortNumber = New System.Windows.Forms.TextBox()
        Me.timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.serialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.lstATList = New System.Windows.Forms.ListBox()
        Me.cmenuCommandList = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.menuComment = New System.Windows.Forms.ToolStripMenuItem()
        Me.groupCommand = New System.Windows.Forms.GroupBox()
        Me.chkAutoSave = New System.Windows.Forms.CheckBox()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.btnAddCommand = New System.Windows.Forms.Button()
        Me.btnClearList = New System.Windows.Forms.Button()
        Me.btnRemoveCommand = New System.Windows.Forms.Button()
        Me.btnClearAT = New System.Windows.Forms.Button()
        Me.btnAddAT = New System.Windows.Forms.Button()
        Me.openFile = New System.Windows.Forms.OpenFileDialog()
        Me.saveFile = New System.Windows.Forms.SaveFileDialog()
        Me.statusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.COMStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statSetup = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stripComment = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnSaveRecvText = New System.Windows.Forms.Button()
        Me.tabRecv = New System.Windows.Forms.TabControl()
        Me.tpageTextRecv = New System.Windows.Forms.TabPage()
        Me.rtxtRecvText = New System.Windows.Forms.RichTextBox()
        Me.btnClearRecvText = New System.Windows.Forms.Button()
        Me.tpageHexRecv = New System.Windows.Forms.TabPage()
        Me.rtxtRecvHex = New System.Windows.Forms.RichTextBox()
        Me.rtxtRecvTextToHex = New System.Windows.Forms.RichTextBox()
        Me.btnSaveRecvHex = New System.Windows.Forms.Button()
        Me.btnClearRecvHex = New System.Windows.Forms.Button()
        Me.tpageCommentRecv = New System.Windows.Forms.TabPage()
        Me.rtxtRecvComment = New System.Windows.Forms.RichTextBox()
        Me.btnSaveRecvCom = New System.Windows.Forms.Button()
        Me.btnCommentSetup = New System.Windows.Forms.Button()
        Me.btnAddComment = New System.Windows.Forms.Button()
        Me.btnSplitLine = New System.Windows.Forms.Button()
        Me.btnClearRecvCom = New System.Windows.Forms.Button()
        Me.btnClearSend = New System.Windows.Forms.Button()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtSendText = New System.Windows.Forms.TextBox()
        Me.lstComment = New System.Windows.Forms.ListBox()
        Me.isCommentEnabled = New System.Windows.Forms.CheckBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.groupPortSetup.SuspendLayout()
        Me.cmenuCommandList.SuspendLayout()
        Me.groupCommand.SuspendLayout()
        Me.statusStrip1.SuspendLayout()
        Me.tabRecv.SuspendLayout()
        Me.tpageTextRecv.SuspendLayout()
        Me.tpageHexRecv.SuspendLayout()
        Me.tpageCommentRecv.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupPortSetup
        '
        Me.groupPortSetup.Controls.Add(Me.btnMsDetect)
        Me.groupPortSetup.Controls.Add(Me.btnSepuraSetup)
        Me.groupPortSetup.Controls.Add(Me.btnMotoSetup)
        Me.groupPortSetup.Controls.Add(Me.btnSetPort)
        Me.groupPortSetup.Controls.Add(Me.cboStopBits)
        Me.groupPortSetup.Controls.Add(Me.cboParityBit)
        Me.groupPortSetup.Controls.Add(Me.txtDataBits)
        Me.groupPortSetup.Controls.Add(Me.txtBaudRate)
        Me.groupPortSetup.Controls.Add(Me.btnClosePort)
        Me.groupPortSetup.Controls.Add(Me.btnOpenPort)
        Me.groupPortSetup.Controls.Add(Me.Label4)
        Me.groupPortSetup.Controls.Add(Me.Label5)
        Me.groupPortSetup.Controls.Add(Me.Label3)
        Me.groupPortSetup.Controls.Add(Me.Label2)
        Me.groupPortSetup.Controls.Add(Me.Label1)
        Me.groupPortSetup.Controls.Add(Me.txtPortNumber)
        Me.groupPortSetup.Location = New System.Drawing.Point(12, 12)
        Me.groupPortSetup.Name = "groupPortSetup"
        Me.groupPortSetup.Size = New System.Drawing.Size(208, 158)
        Me.groupPortSetup.TabIndex = 0
        Me.groupPortSetup.TabStop = False
        Me.groupPortSetup.Text = "串口设置"
        '
        'btnMsDetect
        '
        Me.btnMsDetect.Location = New System.Drawing.Point(137, 128)
        Me.btnMsDetect.Name = "btnMsDetect"
        Me.btnMsDetect.Size = New System.Drawing.Size(62, 23)
        Me.btnMsDetect.TabIndex = 43
        Me.btnMsDetect.Text = "检测..."
        Me.btnMsDetect.UseVisualStyleBackColor = True
        '
        'btnSepuraSetup
        '
        Me.btnSepuraSetup.Enabled = False
        Me.btnSepuraSetup.Location = New System.Drawing.Point(137, 99)
        Me.btnSepuraSetup.Name = "btnSepuraSetup"
        Me.btnSepuraSetup.Size = New System.Drawing.Size(63, 23)
        Me.btnSepuraSetup.TabIndex = 9
        Me.btnSepuraSetup.Text = "SEPURA"
        Me.btnSepuraSetup.UseVisualStyleBackColor = True
        '
        'btnMotoSetup
        '
        Me.btnMotoSetup.Enabled = False
        Me.btnMotoSetup.Location = New System.Drawing.Point(137, 70)
        Me.btnMotoSetup.Name = "btnMotoSetup"
        Me.btnMotoSetup.Size = New System.Drawing.Size(63, 23)
        Me.btnMotoSetup.TabIndex = 8
        Me.btnMotoSetup.Text = "MOTO"
        Me.btnMotoSetup.UseVisualStyleBackColor = True
        '
        'btnSetPort
        '
        Me.btnSetPort.Enabled = False
        Me.btnSetPort.Location = New System.Drawing.Point(137, 41)
        Me.btnSetPort.Name = "btnSetPort"
        Me.btnSetPort.Size = New System.Drawing.Size(63, 23)
        Me.btnSetPort.TabIndex = 7
        Me.btnSetPort.Text = "设定"
        Me.btnSetPort.UseVisualStyleBackColor = True
        '
        'cboStopBits
        '
        Me.cboStopBits.Enabled = False
        Me.cboStopBits.FormattingEnabled = True
        Me.cboStopBits.Items.AddRange(New Object() {"1", "1.5", "2", "无"})
        Me.cboStopBits.Location = New System.Drawing.Point(68, 126)
        Me.cboStopBits.Name = "cboStopBits"
        Me.cboStopBits.Size = New System.Drawing.Size(63, 20)
        Me.cboStopBits.TabIndex = 6
        Me.cboStopBits.Text = "1"
        '
        'cboParityBit
        '
        Me.cboParityBit.Enabled = False
        Me.cboParityBit.FormattingEnabled = True
        Me.cboParityBit.Items.AddRange(New Object() {"奇校验", "偶校验", "无"})
        Me.cboParityBit.Location = New System.Drawing.Point(68, 100)
        Me.cboParityBit.Name = "cboParityBit"
        Me.cboParityBit.Size = New System.Drawing.Size(63, 20)
        Me.cboParityBit.TabIndex = 5
        Me.cboParityBit.Text = "无"
        '
        'txtDataBits
        '
        Me.txtDataBits.Enabled = False
        Me.txtDataBits.Location = New System.Drawing.Point(68, 72)
        Me.txtDataBits.Name = "txtDataBits"
        Me.txtDataBits.Size = New System.Drawing.Size(63, 21)
        Me.txtDataBits.TabIndex = 4
        Me.txtDataBits.Text = "8"
        '
        'txtBaudRate
        '
        Me.txtBaudRate.Enabled = False
        Me.txtBaudRate.Location = New System.Drawing.Point(68, 45)
        Me.txtBaudRate.Name = "txtBaudRate"
        Me.txtBaudRate.Size = New System.Drawing.Size(63, 21)
        Me.txtBaudRate.TabIndex = 3
        Me.txtBaudRate.Text = "9600"
        '
        'btnClosePort
        '
        Me.btnClosePort.Enabled = False
        Me.btnClosePort.Location = New System.Drawing.Point(150, 16)
        Me.btnClosePort.Name = "btnClosePort"
        Me.btnClosePort.Size = New System.Drawing.Size(42, 23)
        Me.btnClosePort.TabIndex = 2
        Me.btnClosePort.Text = "关闭"
        Me.btnClosePort.UseVisualStyleBackColor = True
        '
        'btnOpenPort
        '
        Me.btnOpenPort.Location = New System.Drawing.Point(102, 16)
        Me.btnOpenPort.Name = "btnOpenPort"
        Me.btnOpenPort.Size = New System.Drawing.Size(42, 23)
        Me.btnOpenPort.TabIndex = 1
        Me.btnOpenPort.Text = "打开"
        Me.btnOpenPort.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 12)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "校验位："
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 12)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "停止位："
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 12)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "数据位："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 12)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "波特率："
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 12)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "COM："
        '
        'txtPortNumber
        '
        Me.txtPortNumber.Location = New System.Drawing.Point(57, 16)
        Me.txtPortNumber.Name = "txtPortNumber"
        Me.txtPortNumber.Size = New System.Drawing.Size(37, 21)
        Me.txtPortNumber.TabIndex = 0
        Me.txtPortNumber.Text = "1"
        '
        'timer1
        '
        Me.timer1.Enabled = True
        '
        'serialPort1
        '
        Me.serialPort1.RtsEnable = True
        '
        'lstATList
        '
        Me.lstATList.ContextMenuStrip = Me.cmenuCommandList
        Me.lstATList.FormattingEnabled = True
        Me.lstATList.ItemHeight = 12
        Me.lstATList.Location = New System.Drawing.Point(6, 16)
        Me.lstATList.Name = "lstATList"
        Me.lstATList.Size = New System.Drawing.Size(196, 124)
        Me.lstATList.TabIndex = 11
        '
        'cmenuCommandList
        '
        Me.cmenuCommandList.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuComment})
        Me.cmenuCommandList.Name = "ContextMenuForList"
        Me.cmenuCommandList.ShowImageMargin = False
        Me.cmenuCommandList.Size = New System.Drawing.Size(76, 26)
        '
        'menuComment
        '
        Me.menuComment.Name = "menuComment"
        Me.menuComment.Size = New System.Drawing.Size(75, 22)
        Me.menuComment.Text = "test1"
        '
        'groupCommand
        '
        Me.groupCommand.Controls.Add(Me.chkAutoSave)
        Me.groupCommand.Controls.Add(Me.btnExport)
        Me.groupCommand.Controls.Add(Me.btnImport)
        Me.groupCommand.Controls.Add(Me.btnAddCommand)
        Me.groupCommand.Controls.Add(Me.btnClearList)
        Me.groupCommand.Controls.Add(Me.btnRemoveCommand)
        Me.groupCommand.Controls.Add(Me.lstATList)
        Me.groupCommand.Location = New System.Drawing.Point(12, 176)
        Me.groupCommand.Name = "groupCommand"
        Me.groupCommand.Size = New System.Drawing.Size(208, 205)
        Me.groupCommand.TabIndex = 3
        Me.groupCommand.TabStop = False
        Me.groupCommand.Text = "快捷指令"
        '
        'chkAutoSave
        '
        Me.chkAutoSave.AutoSize = True
        Me.chkAutoSave.Location = New System.Drawing.Point(135, 180)
        Me.chkAutoSave.Name = "chkAutoSave"
        Me.chkAutoSave.Size = New System.Drawing.Size(72, 16)
        Me.chkAutoSave.TabIndex = 17
        Me.chkAutoSave.Text = "自动保存"
        Me.chkAutoSave.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(73, 176)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(60, 23)
        Me.btnExport.TabIndex = 16
        Me.btnExport.Text = "导出..."
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'btnImport
        '
        Me.btnImport.Location = New System.Drawing.Point(7, 176)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(60, 23)
        Me.btnImport.TabIndex = 15
        Me.btnImport.Text = "导入..."
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'btnAddCommand
        '
        Me.btnAddCommand.Location = New System.Drawing.Point(7, 147)
        Me.btnAddCommand.Name = "btnAddCommand"
        Me.btnAddCommand.Size = New System.Drawing.Size(60, 23)
        Me.btnAddCommand.TabIndex = 44
        Me.btnAddCommand.Text = "添加"
        Me.btnAddCommand.UseVisualStyleBackColor = True
        '
        'btnClearList
        '
        Me.btnClearList.Location = New System.Drawing.Point(139, 147)
        Me.btnClearList.Name = "btnClearList"
        Me.btnClearList.Size = New System.Drawing.Size(60, 23)
        Me.btnClearList.TabIndex = 13
        Me.btnClearList.Text = "清除"
        Me.btnClearList.UseVisualStyleBackColor = True
        '
        'btnRemoveCommand
        '
        Me.btnRemoveCommand.Location = New System.Drawing.Point(73, 147)
        Me.btnRemoveCommand.Name = "btnRemoveCommand"
        Me.btnRemoveCommand.Size = New System.Drawing.Size(60, 23)
        Me.btnRemoveCommand.TabIndex = 13
        Me.btnRemoveCommand.Text = "移除"
        Me.btnRemoveCommand.UseVisualStyleBackColor = True
        '
        'btnClearAT
        '
        Me.btnClearAT.Location = New System.Drawing.Point(671, 430)
        Me.btnClearAT.Name = "btnClearAT"
        Me.btnClearAT.Size = New System.Drawing.Size(60, 23)
        Me.btnClearAT.TabIndex = 14
        Me.btnClearAT.Text = "添加..."
        Me.btnClearAT.UseVisualStyleBackColor = True
        '
        'btnAddAT
        '
        Me.btnAddAT.Location = New System.Drawing.Point(671, 401)
        Me.btnAddAT.Name = "btnAddAT"
        Me.btnAddAT.Size = New System.Drawing.Size(60, 23)
        Me.btnAddAT.TabIndex = 12
        Me.btnAddAT.Text = "添加"
        Me.btnAddAT.UseVisualStyleBackColor = True
        '
        'openFile
        '
        Me.openFile.Filter = "xml文件|*.xml"
        '
        'saveFile
        '
        Me.saveFile.Filter = "xml文件|*.xml"
        '
        'statusStrip1
        '
        Me.statusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.COMStatus, Me.statSetup, Me.stripComment})
        Me.statusStrip1.Location = New System.Drawing.Point(0, 510)
        Me.statusStrip1.Name = "statusStrip1"
        Me.statusStrip1.Size = New System.Drawing.Size(640, 22)
        Me.statusStrip1.TabIndex = 6
        Me.statusStrip1.Text = "StatusStrip1"
        '
        'COMStatus
        '
        Me.COMStatus.Margin = New System.Windows.Forms.Padding(1, 3, 0, 2)
        Me.COMStatus.Name = "COMStatus"
        Me.COMStatus.Size = New System.Drawing.Size(65, 17)
        Me.COMStatus.Text = "串口未打开"
        '
        'statSetup
        '
        Me.statSetup.Margin = New System.Windows.Forms.Padding(1, 3, 0, 2)
        Me.statSetup.Name = "statSetup"
        Me.statSetup.Size = New System.Drawing.Size(65, 17)
        Me.statSetup.Text = "设置未生效"
        '
        'stripComment
        '
        Me.stripComment.AutoSize = False
        Me.stripComment.Margin = New System.Windows.Forms.Padding(1, 3, 0, 2)
        Me.stripComment.Name = "stripComment"
        Me.stripComment.Size = New System.Drawing.Size(400, 17)
        Me.stripComment.Text = " "
        Me.stripComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnSaveRecvText
        '
        Me.btnSaveRecvText.Location = New System.Drawing.Point(317, 316)
        Me.btnSaveRecvText.Name = "btnSaveRecvText"
        Me.btnSaveRecvText.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveRecvText.TabIndex = 23
        Me.btnSaveRecvText.Text = "保存..."
        Me.btnSaveRecvText.UseVisualStyleBackColor = True
        '
        'tabRecv
        '
        Me.tabRecv.Controls.Add(Me.tpageTextRecv)
        Me.tabRecv.Controls.Add(Me.tpageHexRecv)
        Me.tabRecv.Controls.Add(Me.tpageCommentRecv)
        Me.tabRecv.Location = New System.Drawing.Point(226, 12)
        Me.tabRecv.Name = "tabRecv"
        Me.tabRecv.SelectedIndex = 0
        Me.tabRecv.Size = New System.Drawing.Size(406, 369)
        Me.tabRecv.TabIndex = 7
        '
        'tpageTextRecv
        '
        Me.tpageTextRecv.BackColor = System.Drawing.Color.Transparent
        Me.tpageTextRecv.Controls.Add(Me.rtxtRecvText)
        Me.tpageTextRecv.Controls.Add(Me.btnSaveRecvText)
        Me.tpageTextRecv.Controls.Add(Me.btnClearRecvText)
        Me.tpageTextRecv.Location = New System.Drawing.Point(4, 21)
        Me.tpageTextRecv.Name = "tpageTextRecv"
        Me.tpageTextRecv.Padding = New System.Windows.Forms.Padding(3)
        Me.tpageTextRecv.Size = New System.Drawing.Size(398, 344)
        Me.tpageTextRecv.TabIndex = 0
        Me.tpageTextRecv.Text = "文本接收"
        '
        'rtxtRecvText
        '
        Me.rtxtRecvText.Location = New System.Drawing.Point(0, 0)
        Me.rtxtRecvText.Name = "rtxtRecvText"
        Me.rtxtRecvText.ReadOnly = True
        Me.rtxtRecvText.Size = New System.Drawing.Size(398, 310)
        Me.rtxtRecvText.TabIndex = 24
        Me.rtxtRecvText.Text = ""
        '
        'btnClearRecvText
        '
        Me.btnClearRecvText.Location = New System.Drawing.Point(6, 316)
        Me.btnClearRecvText.Name = "btnClearRecvText"
        Me.btnClearRecvText.Size = New System.Drawing.Size(75, 23)
        Me.btnClearRecvText.TabIndex = 22
        Me.btnClearRecvText.Text = "清除"
        Me.btnClearRecvText.UseVisualStyleBackColor = True
        '
        'tpageHexRecv
        '
        Me.tpageHexRecv.BackColor = System.Drawing.Color.Transparent
        Me.tpageHexRecv.Controls.Add(Me.rtxtRecvHex)
        Me.tpageHexRecv.Controls.Add(Me.rtxtRecvTextToHex)
        Me.tpageHexRecv.Controls.Add(Me.btnSaveRecvHex)
        Me.tpageHexRecv.Controls.Add(Me.btnClearRecvHex)
        Me.tpageHexRecv.Location = New System.Drawing.Point(4, 21)
        Me.tpageHexRecv.Name = "tpageHexRecv"
        Me.tpageHexRecv.Padding = New System.Windows.Forms.Padding(3)
        Me.tpageHexRecv.Size = New System.Drawing.Size(398, 344)
        Me.tpageHexRecv.TabIndex = 1
        Me.tpageHexRecv.Text = "十六进制接收"
        '
        'rtxtRecvHex
        '
        Me.rtxtRecvHex.Location = New System.Drawing.Point(0, 0)
        Me.rtxtRecvHex.Name = "rtxtRecvHex"
        Me.rtxtRecvHex.ReadOnly = True
        Me.rtxtRecvHex.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.rtxtRecvHex.Size = New System.Drawing.Size(290, 310)
        Me.rtxtRecvHex.TabIndex = 24
        Me.rtxtRecvHex.Text = ""
        '
        'rtxtRecvTextToHex
        '
        Me.rtxtRecvTextToHex.BackColor = System.Drawing.SystemColors.Control
        Me.rtxtRecvTextToHex.Font = New System.Drawing.Font("SimSun", 9.0!)
        Me.rtxtRecvTextToHex.Location = New System.Drawing.Point(292, 0)
        Me.rtxtRecvTextToHex.Name = "rtxtRecvTextToHex"
        Me.rtxtRecvTextToHex.ReadOnly = True
        Me.rtxtRecvTextToHex.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.rtxtRecvTextToHex.Size = New System.Drawing.Size(106, 310)
        Me.rtxtRecvTextToHex.TabIndex = 25
        Me.rtxtRecvTextToHex.Text = ""
        Me.rtxtRecvTextToHex.WordWrap = False
        '
        'btnSaveRecvHex
        '
        Me.btnSaveRecvHex.Location = New System.Drawing.Point(317, 316)
        Me.btnSaveRecvHex.Name = "btnSaveRecvHex"
        Me.btnSaveRecvHex.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveRecvHex.TabIndex = 23
        Me.btnSaveRecvHex.Text = "保存..."
        Me.btnSaveRecvHex.UseVisualStyleBackColor = True
        '
        'btnClearRecvHex
        '
        Me.btnClearRecvHex.Location = New System.Drawing.Point(6, 316)
        Me.btnClearRecvHex.Name = "btnClearRecvHex"
        Me.btnClearRecvHex.Size = New System.Drawing.Size(75, 23)
        Me.btnClearRecvHex.TabIndex = 22
        Me.btnClearRecvHex.Text = "清除"
        Me.btnClearRecvHex.UseVisualStyleBackColor = True
        '
        'tpageCommentRecv
        '
        Me.tpageCommentRecv.BackColor = System.Drawing.Color.Transparent
        Me.tpageCommentRecv.Controls.Add(Me.rtxtRecvComment)
        Me.tpageCommentRecv.Controls.Add(Me.btnSaveRecvCom)
        Me.tpageCommentRecv.Controls.Add(Me.btnCommentSetup)
        Me.tpageCommentRecv.Controls.Add(Me.btnAddComment)
        Me.tpageCommentRecv.Controls.Add(Me.btnSplitLine)
        Me.tpageCommentRecv.Controls.Add(Me.btnClearRecvCom)
        Me.tpageCommentRecv.Location = New System.Drawing.Point(4, 21)
        Me.tpageCommentRecv.Name = "tpageCommentRecv"
        Me.tpageCommentRecv.Padding = New System.Windows.Forms.Padding(3)
        Me.tpageCommentRecv.Size = New System.Drawing.Size(398, 344)
        Me.tpageCommentRecv.TabIndex = 2
        Me.tpageCommentRecv.Text = "注释"
        '
        'rtxtRecvComment
        '
        Me.rtxtRecvComment.Location = New System.Drawing.Point(0, 0)
        Me.rtxtRecvComment.Name = "rtxtRecvComment"
        Me.rtxtRecvComment.ReadOnly = True
        Me.rtxtRecvComment.Size = New System.Drawing.Size(398, 310)
        Me.rtxtRecvComment.TabIndex = 27
        Me.rtxtRecvComment.Text = ""
        '
        'btnSaveRecvCom
        '
        Me.btnSaveRecvCom.Location = New System.Drawing.Point(317, 316)
        Me.btnSaveRecvCom.Name = "btnSaveRecvCom"
        Me.btnSaveRecvCom.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveRecvCom.TabIndex = 26
        Me.btnSaveRecvCom.Text = "保存..."
        Me.btnSaveRecvCom.UseVisualStyleBackColor = True
        '
        'btnCommentSetup
        '
        Me.btnCommentSetup.Location = New System.Drawing.Point(234, 316)
        Me.btnCommentSetup.Name = "btnCommentSetup"
        Me.btnCommentSetup.Size = New System.Drawing.Size(60, 23)
        Me.btnCommentSetup.TabIndex = 25
        Me.btnCommentSetup.Text = "设置..."
        Me.btnCommentSetup.UseVisualStyleBackColor = True
        '
        'btnAddComment
        '
        Me.btnAddComment.Location = New System.Drawing.Point(102, 316)
        Me.btnAddComment.Name = "btnAddComment"
        Me.btnAddComment.Size = New System.Drawing.Size(60, 23)
        Me.btnAddComment.TabIndex = 23
        Me.btnAddComment.Text = "注释"
        Me.btnAddComment.UseVisualStyleBackColor = True
        '
        'btnSplitLine
        '
        Me.btnSplitLine.Location = New System.Drawing.Point(168, 316)
        Me.btnSplitLine.Name = "btnSplitLine"
        Me.btnSplitLine.Size = New System.Drawing.Size(60, 23)
        Me.btnSplitLine.TabIndex = 24
        Me.btnSplitLine.Text = "分隔"
        Me.btnSplitLine.UseVisualStyleBackColor = True
        '
        'btnClearRecvCom
        '
        Me.btnClearRecvCom.Location = New System.Drawing.Point(6, 316)
        Me.btnClearRecvCom.Name = "btnClearRecvCom"
        Me.btnClearRecvCom.Size = New System.Drawing.Size(75, 23)
        Me.btnClearRecvCom.TabIndex = 22
        Me.btnClearRecvCom.Text = "清除"
        Me.btnClearRecvCom.UseVisualStyleBackColor = True
        '
        'btnClearSend
        '
        Me.btnClearSend.Location = New System.Drawing.Point(93, 481)
        Me.btnClearSend.Name = "btnClearSend"
        Me.btnClearSend.Size = New System.Drawing.Size(75, 23)
        Me.btnClearSend.TabIndex = 20
        Me.btnClearSend.Text = "清除"
        Me.btnClearSend.UseVisualStyleBackColor = True
        '
        'btnSend
        '
        Me.btnSend.Enabled = False
        Me.btnSend.Location = New System.Drawing.Point(12, 481)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(75, 23)
        Me.btnSend.TabIndex = 19
        Me.btnSend.Text = "发送"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 388)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 12)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "文本发送："
        '
        'btnHelp
        '
        Me.btnHelp.Location = New System.Drawing.Point(472, 481)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(75, 23)
        Me.btnHelp.TabIndex = 40
        Me.btnHelp.Text = "帮助..."
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(553, 481)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 41
        Me.btnExit.Text = "退出"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtSendText
        '
        Me.txtSendText.Location = New System.Drawing.Point(12, 403)
        Me.txtSendText.Multiline = True
        Me.txtSendText.Name = "txtSendText"
        Me.txtSendText.Size = New System.Drawing.Size(616, 72)
        Me.txtSendText.TabIndex = 42
        '
        'lstComment
        '
        Me.lstComment.FormattingEnabled = True
        Me.lstComment.ItemHeight = 12
        Me.lstComment.Location = New System.Drawing.Point(671, 168)
        Me.lstComment.Name = "lstComment"
        Me.lstComment.Size = New System.Drawing.Size(157, 160)
        Me.lstComment.TabIndex = 43
        '
        'isCommentEnabled
        '
        Me.isCommentEnabled.AutoSize = True
        Me.isCommentEnabled.Checked = True
        Me.isCommentEnabled.CheckState = System.Windows.Forms.CheckState.Checked
        Me.isCommentEnabled.Location = New System.Drawing.Point(88, 384)
        Me.isCommentEnabled.Name = "isCommentEnabled"
        Me.isCommentEnabled.Size = New System.Drawing.Size(132, 16)
        Me.isCommentEnabled.TabIndex = 45
        Me.isCommentEnabled.Text = "允许为指令添加注释"
        Me.isCommentEnabled.UseVisualStyleBackColor = True
        '
        'serialPort
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 532)
        Me.Controls.Add(Me.btnClearAT)
        Me.Controls.Add(Me.isCommentEnabled)
        Me.Controls.Add(Me.lstComment)
        Me.Controls.Add(Me.txtSendText)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnAddAT)
        Me.Controls.Add(Me.btnClearSend)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.tabRecv)
        Me.Controls.Add(Me.statusStrip1)
        Me.Controls.Add(Me.groupCommand)
        Me.Controls.Add(Me.groupPortSetup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "serialPort"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "手台串口调试 v2.6.1"
        Me.groupPortSetup.ResumeLayout(False)
        Me.groupPortSetup.PerformLayout()
        Me.cmenuCommandList.ResumeLayout(False)
        Me.groupCommand.ResumeLayout(False)
        Me.groupCommand.PerformLayout()
        Me.statusStrip1.ResumeLayout(False)
        Me.statusStrip1.PerformLayout()
        Me.tabRecv.ResumeLayout(False)
        Me.tpageTextRecv.ResumeLayout(False)
        Me.tpageHexRecv.ResumeLayout(False)
        Me.tpageCommentRecv.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents groupPortSetup As System.Windows.Forms.GroupBox
    Friend WithEvents btnClosePort As System.Windows.Forms.Button
    Friend WithEvents btnOpenPort As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPortNumber As System.Windows.Forms.TextBox
    Friend WithEvents timer1 As System.Windows.Forms.Timer
    Friend WithEvents serialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents cboStopBits As System.Windows.Forms.ComboBox
    Friend WithEvents cboParityBit As System.Windows.Forms.ComboBox
    Friend WithEvents txtDataBits As System.Windows.Forms.TextBox
    Friend WithEvents txtBaudRate As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSetPort As System.Windows.Forms.Button
    Friend WithEvents btnSepuraSetup As System.Windows.Forms.Button
    Friend WithEvents btnMotoSetup As System.Windows.Forms.Button
    Friend WithEvents lstATList As System.Windows.Forms.ListBox
    Friend WithEvents groupCommand As System.Windows.Forms.GroupBox
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents btnImport As System.Windows.Forms.Button
    Friend WithEvents btnRemoveCommand As System.Windows.Forms.Button
    Friend WithEvents btnAddAT As System.Windows.Forms.Button
    Friend WithEvents chkAutoSave As System.Windows.Forms.CheckBox
    Friend WithEvents btnClearAT As System.Windows.Forms.Button
    Friend WithEvents openFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents saveFile As System.Windows.Forms.SaveFileDialog
    Friend WithEvents statusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents COMStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statSetup As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnSaveRecvText As System.Windows.Forms.Button
    Friend WithEvents tabRecv As System.Windows.Forms.TabControl
    Friend WithEvents tpageTextRecv As System.Windows.Forms.TabPage
    Friend WithEvents btnClearRecvText As System.Windows.Forms.Button
    Friend WithEvents tpageHexRecv As System.Windows.Forms.TabPage
    Friend WithEvents tpageCommentRecv As System.Windows.Forms.TabPage
    Friend WithEvents btnClearSend As System.Windows.Forms.Button
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSaveRecvHex As System.Windows.Forms.Button
    Friend WithEvents btnClearRecvHex As System.Windows.Forms.Button
    Friend WithEvents btnSaveRecvCom As System.Windows.Forms.Button
    Friend WithEvents btnClearRecvCom As System.Windows.Forms.Button
    Friend WithEvents btnCommentSetup As System.Windows.Forms.Button
    Friend WithEvents btnAddComment As System.Windows.Forms.Button
    Friend WithEvents btnSplitLine As System.Windows.Forms.Button
    Friend WithEvents rtxtRecvText As System.Windows.Forms.RichTextBox
    Friend WithEvents rtxtRecvHex As System.Windows.Forms.RichTextBox
    Friend WithEvents rtxtRecvComment As System.Windows.Forms.RichTextBox
    Friend WithEvents txtSendText As System.Windows.Forms.TextBox
    Friend WithEvents btnMsDetect As System.Windows.Forms.Button
    Friend WithEvents rtxtRecvTextToHex As System.Windows.Forms.RichTextBox
    Friend WithEvents cmenuCommandList As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents menuComment As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lstComment As System.Windows.Forms.ListBox
    Friend WithEvents btnClearList As System.Windows.Forms.Button
    Friend WithEvents btnAddCommand As System.Windows.Forms.Button
    Friend WithEvents isCommentEnabled As System.Windows.Forms.CheckBox
    Friend WithEvents stripComment As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
