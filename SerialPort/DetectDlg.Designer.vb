<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MsDetect
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
        Me.btnStartDetect = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.progbarDetect = New System.Windows.Forms.ProgressBar()
        Me.txtDetectResult = New System.Windows.Forms.TextBox()
        Me.PortForDetection = New System.IO.Ports.SerialPort(Me.components)
        Me.btnViewPort = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnClearResult = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtNumberLength = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnStartDetect
        '
        Me.btnStartDetect.Location = New System.Drawing.Point(329, 16)
        Me.btnStartDetect.Name = "btnStartDetect"
        Me.btnStartDetect.Size = New System.Drawing.Size(75, 23)
        Me.btnStartDetect.TabIndex = 1
        Me.btnStartDetect.Text = "开始检测"
        Me.btnStartDetect.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(414, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "    请确认各手台已经正确连接，且各串口未被占用。点击""开始检测""对连接的手台进行检测。"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.progbarDetect)
        Me.GroupBox1.Controls.Add(Me.txtDetectResult)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 94)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(411, 231)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "检测结果"
        '
        'progbarDetect
        '
        Me.progbarDetect.Location = New System.Drawing.Point(6, 202)
        Me.progbarDetect.Name = "progbarDetect"
        Me.progbarDetect.Size = New System.Drawing.Size(399, 23)
        Me.progbarDetect.TabIndex = 6
        '
        'txtDetectResult
        '
        Me.txtDetectResult.Location = New System.Drawing.Point(6, 20)
        Me.txtDetectResult.Multiline = True
        Me.txtDetectResult.Name = "txtDetectResult"
        Me.txtDetectResult.ReadOnly = True
        Me.txtDetectResult.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtDetectResult.Size = New System.Drawing.Size(399, 176)
        Me.txtDetectResult.TabIndex = 0
        '
        'PortForDetection
        '
        Me.PortForDetection.DtrEnable = True
        Me.PortForDetection.RtsEnable = True
        '
        'btnViewPort
        '
        Me.btnViewPort.Location = New System.Drawing.Point(12, 335)
        Me.btnViewPort.Name = "btnViewPort"
        Me.btnViewPort.Size = New System.Drawing.Size(75, 23)
        Me.btnViewPort.TabIndex = 4
        Me.btnViewPort.Text = "查看..."
        Me.btnViewPort.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(76, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(67, 21)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "关闭"
        '
        'btnOK
        '
        Me.btnOK.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnOK.Location = New System.Drawing.Point(3, 3)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(67, 21)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "OK"
        Me.btnOK.Visible = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnOK, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnCancel, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(277, 333)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 27)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'btnClearResult
        '
        Me.btnClearResult.Location = New System.Drawing.Point(93, 335)
        Me.btnClearResult.Name = "btnClearResult"
        Me.btnClearResult.Size = New System.Drawing.Size(75, 23)
        Me.btnClearResult.TabIndex = 5
        Me.btnClearResult.Text = "清除结果"
        Me.btnClearResult.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtNumberLength)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.btnStartDetect)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 41)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(411, 47)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "检测设置"
        '
        'txtNumberLength
        '
        Me.txtNumberLength.Location = New System.Drawing.Point(69, 17)
        Me.txtNumberLength.Name = "txtNumberLength"
        Me.txtNumberLength.Size = New System.Drawing.Size(36, 21)
        Me.txtNumberLength.TabIndex = 7
        Me.txtNumberLength.Text = "3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 12)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "号码长度："
        '
        'MsDetect
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(435, 371)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClearResult)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.btnViewPort)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MsDetect"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "手台检测"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnStartDetect As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDetectResult As System.Windows.Forms.TextBox
    Friend WithEvents PortForDetection As System.IO.Ports.SerialPort
    Friend WithEvents btnViewPort As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnClearResult As System.Windows.Forms.Button
    Friend WithEvents progbarDetect As System.Windows.Forms.ProgressBar
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNumberLength As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
