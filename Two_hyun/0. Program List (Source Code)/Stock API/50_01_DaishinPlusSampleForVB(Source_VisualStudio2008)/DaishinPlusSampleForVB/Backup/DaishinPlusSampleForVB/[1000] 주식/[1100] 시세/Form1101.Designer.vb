<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1101
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1101))
        Me.GroupBoxRQ = New System.Windows.Forms.GroupBox
        Me.TextBoxName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.ButtonSelectCode = New System.Windows.Forms.Button
        Me.ButtonReal = New System.Windows.Forms.Button
        Me.ButtonRQ = New System.Windows.Forms.Button
        Me.TextBoxCode = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LabelContinue = New System.Windows.Forms.Label
        Me.LabelMsg2 = New System.Windows.Forms.Label
        Me.LabelMsg1 = New System.Windows.Forms.Label
        Me.GroupBoxRQ.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxRQ
        '
        Me.GroupBoxRQ.Controls.Add(Me.TextBoxName)
        Me.GroupBoxRQ.Controls.Add(Me.Label2)
        Me.GroupBoxRQ.Controls.Add(Me.ButtonSelectCode)
        Me.GroupBoxRQ.Controls.Add(Me.ButtonReal)
        Me.GroupBoxRQ.Controls.Add(Me.ButtonRQ)
        Me.GroupBoxRQ.Controls.Add(Me.TextBoxCode)
        Me.GroupBoxRQ.Controls.Add(Me.Label1)
        Me.GroupBoxRQ.Location = New System.Drawing.Point(9, 10)
        Me.GroupBoxRQ.Name = "GroupBoxRQ"
        Me.GroupBoxRQ.Size = New System.Drawing.Size(452, 64)
        Me.GroupBoxRQ.TabIndex = 0
        Me.GroupBoxRQ.TabStop = False
        Me.GroupBoxRQ.Text = "요청"
        '
        'TextBoxName
        '
        Me.TextBoxName.BackColor = System.Drawing.Color.White
        Me.TextBoxName.Location = New System.Drawing.Point(77, 39)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.ReadOnly = True
        Me.TextBoxName.Size = New System.Drawing.Size(148, 21)
        Me.TextBoxName.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 12)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "종목명"
        '
        'ButtonSelectCode
        '
        Me.ButtonSelectCode.Location = New System.Drawing.Point(233, 11)
        Me.ButtonSelectCode.Name = "ButtonSelectCode"
        Me.ButtonSelectCode.Size = New System.Drawing.Size(53, 48)
        Me.ButtonSelectCode.TabIndex = 3
        Me.ButtonSelectCode.Text = "종목" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "선택"
        Me.ButtonSelectCode.UseVisualStyleBackColor = True
        '
        'ButtonReal
        '
        Me.ButtonReal.Location = New System.Drawing.Point(351, 12)
        Me.ButtonReal.Name = "ButtonReal"
        Me.ButtonReal.Size = New System.Drawing.Size(95, 48)
        Me.ButtonReal.TabIndex = 1
        Me.ButtonReal.Text = "실시간(시작)"
        Me.ButtonReal.UseVisualStyleBackColor = True
        '
        'ButtonRQ
        '
        Me.ButtonRQ.Location = New System.Drawing.Point(295, 12)
        Me.ButtonRQ.Name = "ButtonRQ"
        Me.ButtonRQ.Size = New System.Drawing.Size(53, 48)
        Me.ButtonRQ.TabIndex = 2
        Me.ButtonRQ.Text = "조회"
        Me.ButtonRQ.UseVisualStyleBackColor = True
        '
        'TextBoxCode
        '
        Me.TextBoxCode.Location = New System.Drawing.Point(77, 12)
        Me.TextBoxCode.Name = "TextBoxCode"
        Me.TextBoxCode.Size = New System.Drawing.Size(148, 21)
        Me.TextBoxCode.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "종목코드"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(0, 127)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView1.Size = New System.Drawing.Size(586, 45)
        Me.DataGridView1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(478, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 35)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "도움말" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(현재가 조회)"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Location = New System.Drawing.Point(478, 45)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 34)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "도움말" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(현재가 실시간)"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelContinue)
        Me.GroupBox1.Controls.Add(Me.LabelMsg2)
        Me.GroupBox1.Controls.Add(Me.LabelMsg1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(9, 80)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(571, 41)
        Me.GroupBox1.TabIndex = 19
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
        'Form1101
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 173)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBoxRQ)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1101"
        Me.Text = "[1101] 주식현재가 (단일종목) (CpDib.StockMst)"
        Me.GroupBoxRQ.ResumeLayout(False)
        Me.GroupBoxRQ.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBoxRQ As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonReal As System.Windows.Forms.Button
    Friend WithEvents TextBoxCode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonRQ As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonSelectCode As System.Windows.Forms.Button
    Friend WithEvents TextBoxName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelContinue As System.Windows.Forms.Label
    Friend WithEvents LabelMsg2 As System.Windows.Forms.Label
    Friend WithEvents LabelMsg1 As System.Windows.Forms.Label
End Class
