<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ComSetupDia
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.groupPrefix = New System.Windows.Forms.GroupBox()
        Me.chkNewLineCheck = New System.Windows.Forms.CheckBox()
        Me.txtPrifix = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.groupMode = New System.Windows.Forms.GroupBox()
        Me.chkFreeEditCheck = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.groupPrefix.SuspendLayout()
        Me.groupMode.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(277, 253)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 27)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 21)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "确认"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 21)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "取消"
        '
        'groupPrefix
        '
        Me.groupPrefix.Controls.Add(Me.chkNewLineCheck)
        Me.groupPrefix.Controls.Add(Me.txtPrifix)
        Me.groupPrefix.Controls.Add(Me.Label1)
        Me.groupPrefix.Location = New System.Drawing.Point(12, 12)
        Me.groupPrefix.Name = "groupPrefix"
        Me.groupPrefix.Size = New System.Drawing.Size(411, 94)
        Me.groupPrefix.TabIndex = 1
        Me.groupPrefix.TabStop = False
        Me.groupPrefix.Text = "注释内容设置"
        '
        'chkNewLineCheck
        '
        Me.chkNewLineCheck.AutoSize = True
        Me.chkNewLineCheck.Checked = True
        Me.chkNewLineCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkNewLineCheck.Location = New System.Drawing.Point(28, 67)
        Me.chkNewLineCheck.Name = "chkNewLineCheck"
        Me.chkNewLineCheck.Size = New System.Drawing.Size(84, 16)
        Me.chkNewLineCheck.TabIndex = 2
        Me.chkNewLineCheck.Text = "注释前换行"
        Me.chkNewLineCheck.UseVisualStyleBackColor = True
        '
        'txtPrifix
        '
        Me.txtPrifix.Location = New System.Drawing.Point(28, 40)
        Me.txtPrifix.Name = "txtPrifix"
        Me.txtPrifix.Size = New System.Drawing.Size(356, 21)
        Me.txtPrifix.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "为注释添加前缀："
        '
        'groupMode
        '
        Me.groupMode.Controls.Add(Me.chkFreeEditCheck)
        Me.groupMode.Controls.Add(Me.Label2)
        Me.groupMode.Location = New System.Drawing.Point(12, 116)
        Me.groupMode.Name = "groupMode"
        Me.groupMode.Size = New System.Drawing.Size(411, 76)
        Me.groupMode.TabIndex = 2
        Me.groupMode.TabStop = False
        Me.groupMode.Text = "注释模式设置"
        '
        'chkFreeEditCheck
        '
        Me.chkFreeEditCheck.AutoSize = True
        Me.chkFreeEditCheck.Location = New System.Drawing.Point(28, 26)
        Me.chkFreeEditCheck.Name = "chkFreeEditCheck"
        Me.chkFreeEditCheck.Size = New System.Drawing.Size(72, 16)
        Me.chkFreeEditCheck.TabIndex = 2
        Me.chkFreeEditCheck.Text = "自由编辑"
        Me.chkFreeEditCheck.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(317, 12)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "允许自由编辑接收区域，容易破坏原始数据，不推荐使用。"
        '
        'ComSetupDia
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(435, 291)
        Me.Controls.Add(Me.groupMode)
        Me.Controls.Add(Me.groupPrefix)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ComSetupDia"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "注释设置"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.groupPrefix.ResumeLayout(False)
        Me.groupPrefix.PerformLayout()
        Me.groupMode.ResumeLayout(False)
        Me.groupMode.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents groupPrefix As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkNewLineCheck As System.Windows.Forms.CheckBox
    Friend WithEvents txtPrifix As System.Windows.Forms.TextBox
    Friend WithEvents groupMode As System.Windows.Forms.GroupBox
    Friend WithEvents chkFreeEditCheck As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
