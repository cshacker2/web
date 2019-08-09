<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1205
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1205))
        Me.ButtonNext = New System.Windows.Forms.Button
        Me.ButtonHelp1 = New System.Windows.Forms.Button
        Me.ButtonQuery = New System.Windows.Forms.Button
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
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonNext
        '
        Me.ButtonNext.Location = New System.Drawing.Point(276, 23)
        Me.ButtonNext.Name = "ButtonNext"
        Me.ButtonNext.Size = New System.Drawing.Size(75, 43)
        Me.ButtonNext.TabIndex = 63
        Me.ButtonNext.Text = "다음" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.ButtonNext.UseVisualStyleBackColor = True
        '
        'ButtonHelp1
        '
        Me.ButtonHelp1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonHelp1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonHelp1.Location = New System.Drawing.Point(834, 18)
        Me.ButtonHelp1.Name = "ButtonHelp1"
        Me.ButtonHelp1.Size = New System.Drawing.Size(58, 43)
        Me.ButtonHelp1.TabIndex = 62
        Me.ButtonHelp1.Text = "도움말"
        Me.ButtonHelp1.UseVisualStyleBackColor = False
        '
        'ButtonQuery
        '
        Me.ButtonQuery.Location = New System.Drawing.Point(196, 23)
        Me.ButtonQuery.Name = "ButtonQuery"
        Me.ButtonQuery.Size = New System.Drawing.Size(75, 43)
        Me.ButtonQuery.TabIndex = 61
        Me.ButtonQuery.Text = "조회"
        Me.ButtonQuery.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TextBoxAccountNo2)
        Me.GroupBox1.Controls.Add(Me.ComboBoxAccountKind)
        Me.GroupBox1.Controls.Add(Me.TextBoxAccountNo1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(173, 76)
        Me.GroupBox1.TabIndex = 59
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
        Me.DataGridView1.Location = New System.Drawing.Point(0, 84)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(903, 266)
        Me.DataGridView1.TabIndex = 58
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LabelContinue)
        Me.GroupBox3.Controls.Add(Me.LabelMsg1)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox3.Location = New System.Drawing.Point(360, 10)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(448, 62)
        Me.GroupBox3.TabIndex = 57
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "조회 상태"
        '
        'LabelContinue
        '
        Me.LabelContinue.AutoSize = True
        Me.LabelContinue.ForeColor = System.Drawing.Color.Blue
        Me.LabelContinue.Location = New System.Drawing.Point(17, 40)
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
        'Form1205
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 350)
        Me.Controls.Add(Me.ButtonNext)
        Me.Controls.Add(Me.ButtonHelp1)
        Me.Controls.Add(Me.ButtonQuery)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1205"
        Me.Text = "[1205] 주식 예약주문현황 (CpTrade.CpTd9065)"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonNext As System.Windows.Forms.Button
    Friend WithEvents ButtonHelp1 As System.Windows.Forms.Button
    Friend WithEvents ButtonQuery As System.Windows.Forms.Button
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
