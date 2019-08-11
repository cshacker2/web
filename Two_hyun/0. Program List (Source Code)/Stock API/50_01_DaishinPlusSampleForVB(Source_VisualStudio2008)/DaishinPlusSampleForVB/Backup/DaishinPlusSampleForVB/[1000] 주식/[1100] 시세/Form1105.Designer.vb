<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1105
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1105))
        Me.GroupBoxRQ = New System.Windows.Forms.GroupBox
        Me.ButtonNext = New System.Windows.Forms.Button
        Me.ButtonQuery = New System.Windows.Forms.Button
        Me.TextBoxName = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.TextBoxCode = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LabelContinue = New System.Windows.Forms.Label
        Me.LabelMsg2 = New System.Windows.Forms.Label
        Me.LabelMsg1 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.GroupBoxRQ.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxRQ
        '
        Me.GroupBoxRQ.Controls.Add(Me.ButtonNext)
        Me.GroupBoxRQ.Controls.Add(Me.ButtonQuery)
        Me.GroupBoxRQ.Controls.Add(Me.TextBoxName)
        Me.GroupBoxRQ.Controls.Add(Me.Label3)
        Me.GroupBoxRQ.Controls.Add(Me.Button2)
        Me.GroupBoxRQ.Controls.Add(Me.TextBoxCode)
        Me.GroupBoxRQ.Controls.Add(Me.Label4)
        Me.GroupBoxRQ.Location = New System.Drawing.Point(3, 4)
        Me.GroupBoxRQ.Name = "GroupBoxRQ"
        Me.GroupBoxRQ.Size = New System.Drawing.Size(461, 63)
        Me.GroupBoxRQ.TabIndex = 2
        Me.GroupBoxRQ.TabStop = False
        Me.GroupBoxRQ.Text = "요청"
        '
        'ButtonNext
        '
        Me.ButtonNext.Location = New System.Drawing.Point(384, 10)
        Me.ButtonNext.Name = "ButtonNext"
        Me.ButtonNext.Size = New System.Drawing.Size(65, 48)
        Me.ButtonNext.TabIndex = 29
        Me.ButtonNext.Text = "다음"
        Me.ButtonNext.UseVisualStyleBackColor = True
        '
        'ButtonQuery
        '
        Me.ButtonQuery.Location = New System.Drawing.Point(313, 10)
        Me.ButtonQuery.Name = "ButtonQuery"
        Me.ButtonQuery.Size = New System.Drawing.Size(65, 48)
        Me.ButtonQuery.TabIndex = 6
        Me.ButtonQuery.Text = "조회"
        Me.ButtonQuery.UseVisualStyleBackColor = True
        '
        'TextBoxName
        '
        Me.TextBoxName.BackColor = System.Drawing.Color.White
        Me.TextBoxName.Location = New System.Drawing.Point(76, 39)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.ReadOnly = True
        Me.TextBoxName.Size = New System.Drawing.Size(148, 21)
        Me.TextBoxName.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 12)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "종목명"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(232, 11)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(53, 48)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "종목" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "선택"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBoxCode
        '
        Me.TextBoxCode.Location = New System.Drawing.Point(76, 12)
        Me.TextBoxCode.Name = "TextBoxCode"
        Me.TextBoxCode.Size = New System.Drawing.Size(148, 21)
        Me.TextBoxCode.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 12)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "종목코드"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(892, 15)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(69, 47)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "도움말" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelContinue)
        Me.GroupBox1.Controls.Add(Me.LabelMsg2)
        Me.GroupBox1.Controls.Add(Me.LabelMsg1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(3, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(966, 41)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "조회 상태"
        '
        'LabelContinue
        '
        Me.LabelContinue.AutoSize = True
        Me.LabelContinue.ForeColor = System.Drawing.Color.Blue
        Me.LabelContinue.Location = New System.Drawing.Point(610, 18)
        Me.LabelContinue.Name = "LabelContinue"
        Me.LabelContinue.Size = New System.Drawing.Size(0, 12)
        Me.LabelContinue.TabIndex = 25
        '
        'LabelMsg2
        '
        Me.LabelMsg2.AutoSize = True
        Me.LabelMsg2.ForeColor = System.Drawing.Color.Blue
        Me.LabelMsg2.Location = New System.Drawing.Point(360, 18)
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
        Me.DataGridView1.Location = New System.Drawing.Point(0, 119)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(974, 369)
        Me.DataGridView1.TabIndex = 32
        '
        'Form1105
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(974, 488)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBoxRQ)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1105"
        Me.Text = "[1105] 주식 일자별 주가 (CpDib.StockWeek)"
        Me.GroupBoxRQ.ResumeLayout(False)
        Me.GroupBoxRQ.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBoxRQ As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonNext As System.Windows.Forms.Button
    Friend WithEvents ButtonQuery As System.Windows.Forms.Button
    Friend WithEvents TextBoxName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBoxCode As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelContinue As System.Windows.Forms.Label
    Friend WithEvents LabelMsg2 As System.Windows.Forms.Label
    Friend WithEvents LabelMsg1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
