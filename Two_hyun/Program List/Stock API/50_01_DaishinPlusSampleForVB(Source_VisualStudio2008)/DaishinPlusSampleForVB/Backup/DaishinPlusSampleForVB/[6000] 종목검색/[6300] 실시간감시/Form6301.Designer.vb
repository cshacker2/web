<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6301
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6301))
        Me.TextBoxProfit = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBoxCount = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.ButtonHelp = New System.Windows.Forms.Button
        Me.TextBoxName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.CheckBoxDelete = New System.Windows.Forms.CheckBox
        Me.ButtonStart = New System.Windows.Forms.Button
        Me.LabelMonitor = New System.Windows.Forms.Label
        Me.ButtonOrder = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LabelContinue = New System.Windows.Forms.Label
        Me.LabelMsg2 = New System.Windows.Forms.Label
        Me.LabelMsg1 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxProfit
        '
        Me.TextBoxProfit.Location = New System.Drawing.Point(486, 12)
        Me.TextBoxProfit.Name = "TextBoxProfit"
        Me.TextBoxProfit.Size = New System.Drawing.Size(59, 21)
        Me.TextBoxProfit.TabIndex = 49
        Me.TextBoxProfit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(392, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 12)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "포착 평균수익률"
        '
        'TextBoxCount
        '
        Me.TextBoxCount.Location = New System.Drawing.Point(346, 11)
        Me.TextBoxCount.Name = "TextBoxCount"
        Me.TextBoxCount.Size = New System.Drawing.Size(39, 21)
        Me.TextBoxCount.TabIndex = 47
        Me.TextBoxCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(275, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 12)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "포착 종목수"
        '
        'ButtonHelp
        '
        Me.ButtonHelp.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonHelp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonHelp.Location = New System.Drawing.Point(835, 4)
        Me.ButtonHelp.Name = "ButtonHelp"
        Me.ButtonHelp.Size = New System.Drawing.Size(70, 32)
        Me.ButtonHelp.TabIndex = 45
        Me.ButtonHelp.Text = "도움말" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.ButtonHelp.UseVisualStyleBackColor = False
        '
        'TextBoxName
        '
        Me.TextBoxName.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.TextBoxName.Location = New System.Drawing.Point(49, 12)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(219, 21)
        Me.TextBoxName.TabIndex = 55
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 12)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "전략명"
        '
        'CheckBoxDelete
        '
        Me.CheckBoxDelete.AutoSize = True
        Me.CheckBoxDelete.Location = New System.Drawing.Point(555, 8)
        Me.CheckBoxDelete.Name = "CheckBoxDelete"
        Me.CheckBoxDelete.Size = New System.Drawing.Size(72, 28)
        Me.CheckBoxDelete.TabIndex = 50
        Me.CheckBoxDelete.Text = "퇴출종목" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "자동삭제"
        Me.CheckBoxDelete.UseVisualStyleBackColor = True
        '
        'ButtonStart
        '
        Me.ButtonStart.BackColor = System.Drawing.Color.Blue
        Me.ButtonStart.ForeColor = System.Drawing.Color.White
        Me.ButtonStart.Location = New System.Drawing.Point(637, 4)
        Me.ButtonStart.Name = "ButtonStart"
        Me.ButtonStart.Size = New System.Drawing.Size(43, 32)
        Me.ButtonStart.TabIndex = 51
        Me.ButtonStart.Text = "▶"
        Me.ButtonStart.UseVisualStyleBackColor = False
        '
        'LabelMonitor
        '
        Me.LabelMonitor.AutoSize = True
        Me.LabelMonitor.Location = New System.Drawing.Point(685, 14)
        Me.LabelMonitor.Name = "LabelMonitor"
        Me.LabelMonitor.Size = New System.Drawing.Size(57, 12)
        Me.LabelMonitor.TabIndex = 52
        Me.LabelMonitor.Text = "감시 정지"
        '
        'ButtonOrder
        '
        Me.ButtonOrder.ForeColor = System.Drawing.Color.Red
        Me.ButtonOrder.Location = New System.Drawing.Point(747, 4)
        Me.ButtonOrder.Name = "ButtonOrder"
        Me.ButtonOrder.Size = New System.Drawing.Size(82, 32)
        Me.ButtonOrder.TabIndex = 53
        Me.ButtonOrder.Text = "전략" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "매수주문"
        Me.ButtonOrder.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelContinue)
        Me.GroupBox1.Controls.Add(Me.LabelMsg2)
        Me.GroupBox1.Controls.Add(Me.LabelMsg1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(3, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(902, 41)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "조회 상태"
        '
        'LabelContinue
        '
        Me.LabelContinue.AutoSize = True
        Me.LabelContinue.ForeColor = System.Drawing.Color.Blue
        Me.LabelContinue.Location = New System.Drawing.Point(512, 18)
        Me.LabelContinue.Name = "LabelContinue"
        Me.LabelContinue.Size = New System.Drawing.Size(0, 12)
        Me.LabelContinue.TabIndex = 25
        '
        'LabelMsg2
        '
        Me.LabelMsg2.AutoSize = True
        Me.LabelMsg2.ForeColor = System.Drawing.Color.Blue
        Me.LabelMsg2.Location = New System.Drawing.Point(262, 18)
        Me.LabelMsg2.Name = "LabelMsg2"
        Me.LabelMsg2.Size = New System.Drawing.Size(0, 12)
        Me.LabelMsg2.TabIndex = 24
        '
        'LabelMsg1
        '
        Me.LabelMsg1.AutoSize = True
        Me.LabelMsg1.ForeColor = System.Drawing.Color.Blue
        Me.LabelMsg1.Location = New System.Drawing.Point(17, 18)
        Me.LabelMsg1.Name = "LabelMsg1"
        Me.LabelMsg1.Size = New System.Drawing.Size(0, 12)
        Me.LabelMsg1.TabIndex = 23
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 80)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView1.Size = New System.Drawing.Size(908, 275)
        Me.DataGridView1.TabIndex = 54
        '
        'Form6301
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(908, 355)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ButtonOrder)
        Me.Controls.Add(Me.LabelMonitor)
        Me.Controls.Add(Me.ButtonStart)
        Me.Controls.Add(Me.CheckBoxDelete)
        Me.Controls.Add(Me.TextBoxProfit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxCount)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ButtonHelp)
        Me.Controls.Add(Me.TextBoxName)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form6301"
        Me.Text = "[6301] 실시간 감시(CpSysDib.CssWatchStgSubscribe)"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxProfit As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxCount As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ButtonHelp As System.Windows.Forms.Button
    Friend WithEvents TextBoxName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CheckBoxDelete As System.Windows.Forms.CheckBox
    Friend WithEvents ButtonStart As System.Windows.Forms.Button
    Friend WithEvents LabelMonitor As System.Windows.Forms.Label
    Friend WithEvents ButtonOrder As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelContinue As System.Windows.Forms.Label
    Friend WithEvents LabelMsg2 As System.Windows.Forms.Label
    Friend WithEvents LabelMsg1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
