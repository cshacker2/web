<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1301
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1301))
        Me.ComboBoxQueryKind = New System.Windows.Forms.ComboBox
        Me.ButtonNext = New System.Windows.Forms.Button
        Me.ButtonHelp1 = New System.Windows.Forms.Button
        Me.ButtonQuery = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TextBoxCode = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBoxName = New System.Windows.Forms.TextBox
        Me.ButtonSelectCode = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.TextBoxAccountNo2 = New System.Windows.Forms.TextBox
        Me.ComboBoxAccountKind = New System.Windows.Forms.ComboBox
        Me.TextBoxAccountNo1 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.LabelContinue = New System.Windows.Forms.Label
        Me.LabelMsg1 = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboBoxQueryKind
        '
        Me.ComboBoxQueryKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxQueryKind.FormattingEnabled = True
        Me.ComboBoxQueryKind.Items.AddRange(New Object() {"전체 조회", "종목별 조회"})
        Me.ComboBoxQueryKind.Location = New System.Drawing.Point(466, 32)
        Me.ComboBoxQueryKind.Name = "ComboBoxQueryKind"
        Me.ComboBoxQueryKind.Size = New System.Drawing.Size(115, 20)
        Me.ComboBoxQueryKind.TabIndex = 72
        '
        'ButtonNext
        '
        Me.ButtonNext.Location = New System.Drawing.Point(666, 20)
        Me.ButtonNext.Name = "ButtonNext"
        Me.ButtonNext.Size = New System.Drawing.Size(75, 43)
        Me.ButtonNext.TabIndex = 71
        Me.ButtonNext.Text = "다음" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.ButtonNext.UseVisualStyleBackColor = True
        '
        'ButtonHelp1
        '
        Me.ButtonHelp1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonHelp1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonHelp1.Location = New System.Drawing.Point(756, 20)
        Me.ButtonHelp1.Name = "ButtonHelp1"
        Me.ButtonHelp1.Size = New System.Drawing.Size(58, 43)
        Me.ButtonHelp1.TabIndex = 70
        Me.ButtonHelp1.Text = "도움말"
        Me.ButtonHelp1.UseVisualStyleBackColor = False
        '
        'ButtonQuery
        '
        Me.ButtonQuery.Location = New System.Drawing.Point(586, 20)
        Me.ButtonQuery.Name = "ButtonQuery"
        Me.ButtonQuery.Size = New System.Drawing.Size(75, 43)
        Me.ButtonQuery.TabIndex = 69
        Me.ButtonQuery.Text = "조회"
        Me.ButtonQuery.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBoxCode)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TextBoxName)
        Me.GroupBox2.Controls.Add(Me.ButtonSelectCode)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(184, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(275, 76)
        Me.GroupBox2.TabIndex = 68
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "종목 정보"
        '
        'TextBoxCode
        '
        Me.TextBoxCode.Location = New System.Drawing.Point(75, 18)
        Me.TextBoxCode.Name = "TextBoxCode"
        Me.TextBoxCode.Size = New System.Drawing.Size(124, 21)
        Me.TextBoxCode.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "종목코드"
        '
        'TextBoxName
        '
        Me.TextBoxName.BackColor = System.Drawing.Color.White
        Me.TextBoxName.Location = New System.Drawing.Point(75, 45)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.ReadOnly = True
        Me.TextBoxName.Size = New System.Drawing.Size(124, 21)
        Me.TextBoxName.TabIndex = 5
        '
        'ButtonSelectCode
        '
        Me.ButtonSelectCode.Location = New System.Drawing.Point(209, 17)
        Me.ButtonSelectCode.Name = "ButtonSelectCode"
        Me.ButtonSelectCode.Size = New System.Drawing.Size(53, 48)
        Me.ButtonSelectCode.TabIndex = 3
        Me.ButtonSelectCode.Text = "종목" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "선택"
        Me.ButtonSelectCode.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 12)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "종목명"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TextBoxAccountNo2)
        Me.GroupBox1.Controls.Add(Me.ComboBoxAccountKind)
        Me.GroupBox1.Controls.Add(Me.TextBoxAccountNo1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(173, 76)
        Me.GroupBox1.TabIndex = 67
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "계좌 정보"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(44, 45)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(11, 12)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "-"
        '
        'TextBoxAccountNo2
        '
        Me.TextBoxAccountNo2.BackColor = System.Drawing.Color.White
        Me.TextBoxAccountNo2.Enabled = False
        Me.TextBoxAccountNo2.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.TextBoxAccountNo2.Location = New System.Drawing.Point(57, 41)
        Me.TextBoxAccountNo2.Name = "TextBoxAccountNo2"
        Me.TextBoxAccountNo2.ReadOnly = True
        Me.TextBoxAccountNo2.Size = New System.Drawing.Size(58, 21)
        Me.TextBoxAccountNo2.TabIndex = 2
        Me.TextBoxAccountNo2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ComboBoxAccountKind
        '
        Me.ComboBoxAccountKind.BackColor = System.Drawing.Color.White
        Me.ComboBoxAccountKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxAccountKind.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.ComboBoxAccountKind.FormattingEnabled = True
        Me.ComboBoxAccountKind.Location = New System.Drawing.Point(124, 42)
        Me.ComboBoxAccountKind.Name = "ComboBoxAccountKind"
        Me.ComboBoxAccountKind.Size = New System.Drawing.Size(38, 20)
        Me.ComboBoxAccountKind.TabIndex = 3
        '
        'TextBoxAccountNo1
        '
        Me.TextBoxAccountNo1.BackColor = System.Drawing.Color.White
        Me.TextBoxAccountNo1.Enabled = False
        Me.TextBoxAccountNo1.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.TextBoxAccountNo1.Location = New System.Drawing.Point(11, 41)
        Me.TextBoxAccountNo1.Name = "TextBoxAccountNo1"
        Me.TextBoxAccountNo1.ReadOnly = True
        Me.TextBoxAccountNo1.Size = New System.Drawing.Size(32, 21)
        Me.TextBoxAccountNo1.TabIndex = 1
        Me.TextBoxAccountNo1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 12)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "종합계좌번호"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(133, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 12)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "구분"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(0, 131)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(832, 370)
        Me.DataGridView1.TabIndex = 66
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LabelContinue)
        Me.GroupBox3.Controls.Add(Me.LabelMsg1)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox3.Location = New System.Drawing.Point(5, 85)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(822, 41)
        Me.GroupBox3.TabIndex = 65
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "조회 상태"
        '
        'LabelContinue
        '
        Me.LabelContinue.AutoSize = True
        Me.LabelContinue.ForeColor = System.Drawing.Color.Blue
        Me.LabelContinue.Location = New System.Drawing.Point(442, 17)
        Me.LabelContinue.Name = "LabelContinue"
        Me.LabelContinue.Size = New System.Drawing.Size(0, 12)
        Me.LabelContinue.TabIndex = 26
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
        'Form1301
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 502)
        Me.Controls.Add(Me.ComboBoxQueryKind)
        Me.Controls.Add(Me.ButtonNext)
        Me.Controls.Add(Me.ButtonHelp1)
        Me.Controls.Add(Me.ButtonQuery)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1301"
        Me.Text = "[1301] 금일 계좌별 주문체결 내역 (CpTrade.CpTd5341)"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ComboBoxQueryKind As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonNext As System.Windows.Forms.Button
    Friend WithEvents ButtonHelp1 As System.Windows.Forms.Button
    Friend WithEvents ButtonQuery As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxCode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxName As System.Windows.Forms.TextBox
    Friend WithEvents ButtonSelectCode As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBoxAccountNo2 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxAccountKind As System.Windows.Forms.ComboBox
    Friend WithEvents TextBoxAccountNo1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelContinue As System.Windows.Forms.Label
    Friend WithEvents LabelMsg1 As System.Windows.Forms.Label
End Class
