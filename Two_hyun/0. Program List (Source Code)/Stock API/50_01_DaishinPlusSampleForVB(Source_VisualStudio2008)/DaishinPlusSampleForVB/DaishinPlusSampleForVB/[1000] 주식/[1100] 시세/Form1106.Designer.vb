<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1106
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1106))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.ButtonHelpRQ = New System.Windows.Forms.Button
        Me.GroupBoxRQ = New System.Windows.Forms.GroupBox
        Me.TextBoxName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.ButtonSelectCode = New System.Windows.Forms.Button
        Me.ButtonRQ = New System.Windows.Forms.Button
        Me.TextBoxCode = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ButtonHelpSB = New System.Windows.Forms.Button
        Me.LabelBuy = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.LabelSell = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.LabelTime = New System.Windows.Forms.Label
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxRQ.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(0, 124)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(300, 485)
        Me.DataGridView1.TabIndex = 21
        '
        'ButtonHelpRQ
        '
        Me.ButtonHelpRQ.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonHelpRQ.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonHelpRQ.Location = New System.Drawing.Point(158, 75)
        Me.ButtonHelpRQ.Name = "ButtonHelpRQ"
        Me.ButtonHelpRQ.Size = New System.Drawing.Size(67, 40)
        Me.ButtonHelpRQ.TabIndex = 22
        Me.ButtonHelpRQ.Text = "도움말" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(조회)"
        Me.ButtonHelpRQ.UseVisualStyleBackColor = False
        '
        'GroupBoxRQ
        '
        Me.GroupBoxRQ.Controls.Add(Me.TextBoxName)
        Me.GroupBoxRQ.Controls.Add(Me.Label2)
        Me.GroupBoxRQ.Controls.Add(Me.ButtonSelectCode)
        Me.GroupBoxRQ.Controls.Add(Me.ButtonRQ)
        Me.GroupBoxRQ.Controls.Add(Me.TextBoxCode)
        Me.GroupBoxRQ.Controls.Add(Me.Label1)
        Me.GroupBoxRQ.Location = New System.Drawing.Point(3, 2)
        Me.GroupBoxRQ.Name = "GroupBoxRQ"
        Me.GroupBoxRQ.Size = New System.Drawing.Size(301, 64)
        Me.GroupBoxRQ.TabIndex = 20
        Me.GroupBoxRQ.TabStop = False
        Me.GroupBoxRQ.Text = "요청"
        '
        'TextBoxName
        '
        Me.TextBoxName.BackColor = System.Drawing.Color.White
        Me.TextBoxName.Location = New System.Drawing.Point(77, 39)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.ReadOnly = True
        Me.TextBoxName.Size = New System.Drawing.Size(101, 21)
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
        Me.ButtonSelectCode.Location = New System.Drawing.Point(183, 11)
        Me.ButtonSelectCode.Name = "ButtonSelectCode"
        Me.ButtonSelectCode.Size = New System.Drawing.Size(53, 48)
        Me.ButtonSelectCode.TabIndex = 3
        Me.ButtonSelectCode.Text = "종목" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "선택"
        Me.ButtonSelectCode.UseVisualStyleBackColor = True
        '
        'ButtonRQ
        '
        Me.ButtonRQ.Location = New System.Drawing.Point(243, 12)
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
        Me.TextBoxCode.Size = New System.Drawing.Size(101, 21)
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
        'ButtonHelpSB
        '
        Me.ButtonHelpSB.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonHelpSB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonHelpSB.Location = New System.Drawing.Point(231, 75)
        Me.ButtonHelpSB.Name = "ButtonHelpSB"
        Me.ButtonHelpSB.Size = New System.Drawing.Size(67, 40)
        Me.ButtonHelpSB.TabIndex = 24
        Me.ButtonHelpSB.Text = "도움말" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(실시간)"
        Me.ButtonHelpSB.UseVisualStyleBackColor = False
        '
        'LabelBuy
        '
        Me.LabelBuy.AutoSize = True
        Me.LabelBuy.ForeColor = System.Drawing.Color.Red
        Me.LabelBuy.Location = New System.Drawing.Point(95, 107)
        Me.LabelBuy.Name = "LabelBuy"
        Me.LabelBuy.Size = New System.Drawing.Size(0, 12)
        Me.LabelBuy.TabIndex = 34
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(12, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 12)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "총 매수 잔량 :"
        '
        'LabelSell
        '
        Me.LabelSell.AutoSize = True
        Me.LabelSell.ForeColor = System.Drawing.Color.Blue
        Me.LabelSell.Location = New System.Drawing.Point(95, 89)
        Me.LabelSell.Name = "LabelSell"
        Me.LabelSell.Size = New System.Drawing.Size(0, 12)
        Me.LabelSell.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(12, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 12)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "총 매도 잔량 :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 12)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "시간 : "
        '
        'LabelTime
        '
        Me.LabelTime.AutoSize = True
        Me.LabelTime.Location = New System.Drawing.Point(50, 71)
        Me.LabelTime.Name = "LabelTime"
        Me.LabelTime.Size = New System.Drawing.Size(0, 12)
        Me.LabelTime.TabIndex = 35
        '
        'Form1106
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(301, 610)
        Me.Controls.Add(Me.LabelTime)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LabelBuy)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LabelSell)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ButtonHelpSB)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ButtonHelpRQ)
        Me.Controls.Add(Me.GroupBoxRQ)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1106"
        Me.Text = "[1106] 주식 호가 (CpDib.StrockJpBid2)"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxRQ.ResumeLayout(False)
        Me.GroupBoxRQ.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonHelpRQ As System.Windows.Forms.Button
    Friend WithEvents GroupBoxRQ As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ButtonSelectCode As System.Windows.Forms.Button
    Friend WithEvents ButtonRQ As System.Windows.Forms.Button
    Friend WithEvents TextBoxCode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonHelpSB As System.Windows.Forms.Button
    Friend WithEvents LabelBuy As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LabelSell As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LabelTime As System.Windows.Forms.Label
End Class
