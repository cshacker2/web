<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1104
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1104))
        Me.GroupBoxRQ = New System.Windows.Forms.GroupBox
        Me.ButtonNext = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.ComboBoxMethod = New System.Windows.Forms.ComboBox
        Me.ButtonQuery = New System.Windows.Forms.Button
        Me.TextBoxName = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.TextBoxCode = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LabelContinue = New System.Windows.Forms.Label
        Me.LabelMsg2 = New System.Windows.Forms.Label
        Me.LabelMsg1 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.LabelSell = New System.Windows.Forms.Label
        Me.LabelBuy = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.CheckBoxTop = New System.Windows.Forms.CheckBox
        Me.GroupBoxRQ.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxRQ
        '
        Me.GroupBoxRQ.Controls.Add(Me.ButtonNext)
        Me.GroupBoxRQ.Controls.Add(Me.Label2)
        Me.GroupBoxRQ.Controls.Add(Me.ComboBoxMethod)
        Me.GroupBoxRQ.Controls.Add(Me.ButtonQuery)
        Me.GroupBoxRQ.Controls.Add(Me.TextBoxName)
        Me.GroupBoxRQ.Controls.Add(Me.Label3)
        Me.GroupBoxRQ.Controls.Add(Me.Button2)
        Me.GroupBoxRQ.Controls.Add(Me.TextBoxCode)
        Me.GroupBoxRQ.Controls.Add(Me.Label4)
        Me.GroupBoxRQ.Location = New System.Drawing.Point(3, 4)
        Me.GroupBoxRQ.Name = "GroupBoxRQ"
        Me.GroupBoxRQ.Size = New System.Drawing.Size(671, 63)
        Me.GroupBoxRQ.TabIndex = 1
        Me.GroupBoxRQ.TabStop = False
        Me.GroupBoxRQ.Text = "요청"
        '
        'ButtonNext
        '
        Me.ButtonNext.Location = New System.Drawing.Point(594, 11)
        Me.ButtonNext.Name = "ButtonNext"
        Me.ButtonNext.Size = New System.Drawing.Size(65, 48)
        Me.ButtonNext.TabIndex = 29
        Me.ButtonNext.Text = "다음"
        Me.ButtonNext.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(293, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 12)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "체결 비교방식"
        '
        'ComboBoxMethod
        '
        Me.ComboBoxMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxMethod.FormattingEnabled = True
        Me.ComboBoxMethod.Items.AddRange(New Object() {"체결가 비교방식", "호가 비교방식"})
        Me.ComboBoxMethod.Location = New System.Drawing.Point(382, 25)
        Me.ComboBoxMethod.Name = "ComboBoxMethod"
        Me.ComboBoxMethod.Size = New System.Drawing.Size(121, 20)
        Me.ComboBoxMethod.TabIndex = 27
        '
        'ButtonQuery
        '
        Me.ButtonQuery.Location = New System.Drawing.Point(523, 11)
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
        Me.Button1.Location = New System.Drawing.Point(712, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(69, 47)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "도움말" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(0, 144)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView1.Size = New System.Drawing.Size(792, 369)
        Me.DataGridView1.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelContinue)
        Me.GroupBox1.Controls.Add(Me.LabelMsg2)
        Me.GroupBox1.Controls.Add(Me.LabelMsg1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(3, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(787, 41)
        Me.GroupBox1.TabIndex = 21
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(8, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 12)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "누적 매도 체결량 :"
        '
        'LabelSell
        '
        Me.LabelSell.AutoSize = True
        Me.LabelSell.ForeColor = System.Drawing.Color.Blue
        Me.LabelSell.Location = New System.Drawing.Point(122, 122)
        Me.LabelSell.Name = "LabelSell"
        Me.LabelSell.Size = New System.Drawing.Size(0, 12)
        Me.LabelSell.TabIndex = 28
        Me.LabelSell.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelBuy
        '
        Me.LabelBuy.AutoSize = True
        Me.LabelBuy.ForeColor = System.Drawing.Color.Red
        Me.LabelBuy.Location = New System.Drawing.Point(347, 122)
        Me.LabelBuy.Name = "LabelBuy"
        Me.LabelBuy.Size = New System.Drawing.Size(0, 12)
        Me.LabelBuy.TabIndex = 30
        Me.LabelBuy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(233, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 12)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "누적 매수 체결량 :"
        '
        'CheckBoxTop
        '
        Me.CheckBoxTop.AutoSize = True
        Me.CheckBoxTop.Checked = True
        Me.CheckBoxTop.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxTop.Location = New System.Drawing.Point(583, 123)
        Me.CheckBoxTop.Name = "CheckBoxTop"
        Me.CheckBoxTop.Size = New System.Drawing.Size(202, 16)
        Me.CheckBoxTop.TabIndex = 31
        Me.CheckBoxTop.Text = "최근 데이터 보기(실시간 수신시)"
        Me.CheckBoxTop.UseVisualStyleBackColor = True
        '
        'Form1104
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(793, 513)
        Me.Controls.Add(Me.CheckBoxTop)
        Me.Controls.Add(Me.LabelBuy)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LabelSell)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBoxRQ)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1104"
        Me.Text = "[1104] 주식 시간대별 체결 (CpDib.StockBid)"
        Me.GroupBoxRQ.ResumeLayout(False)
        Me.GroupBoxRQ.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBoxRQ As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonQuery As System.Windows.Forms.Button
    Friend WithEvents TextBoxName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBoxCode As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelContinue As System.Windows.Forms.Label
    Friend WithEvents LabelMsg2 As System.Windows.Forms.Label
    Friend WithEvents LabelMsg1 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabelSell As System.Windows.Forms.Label
    Friend WithEvents LabelBuy As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxMethod As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ButtonNext As System.Windows.Forms.Button
    Friend WithEvents CheckBoxTop As System.Windows.Forms.CheckBox
End Class
