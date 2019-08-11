<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1102
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1102))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.GroupBoxRQ = New System.Windows.Forms.GroupBox
        Me.Button5 = New System.Windows.Forms.Button
        Me.TextBoxName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.ButtonSelectCode = New System.Windows.Forms.Button
        Me.TextBoxCode = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LabelMsg1 = New System.Windows.Forms.Label
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxRQ.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(0, 130)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(695, 397)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupBoxRQ
        '
        Me.GroupBoxRQ.Controls.Add(Me.Button5)
        Me.GroupBoxRQ.Controls.Add(Me.TextBoxName)
        Me.GroupBoxRQ.Controls.Add(Me.Label2)
        Me.GroupBoxRQ.Controls.Add(Me.ButtonSelectCode)
        Me.GroupBoxRQ.Controls.Add(Me.TextBoxCode)
        Me.GroupBoxRQ.Controls.Add(Me.Label1)
        Me.GroupBoxRQ.Location = New System.Drawing.Point(12, 12)
        Me.GroupBoxRQ.Name = "GroupBoxRQ"
        Me.GroupBoxRQ.Size = New System.Drawing.Size(393, 67)
        Me.GroupBoxRQ.TabIndex = 2
        Me.GroupBoxRQ.TabStop = False
        Me.GroupBoxRQ.Text = "요청"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(303, 13)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(73, 49)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "관심종목" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "조회"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TextBoxName
        '
        Me.TextBoxName.BackColor = System.Drawing.Color.White
        Me.TextBoxName.Location = New System.Drawing.Point(78, 41)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.ReadOnly = True
        Me.TextBoxName.Size = New System.Drawing.Size(148, 21)
        Me.TextBoxName.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 12)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "종목명"
        '
        'ButtonSelectCode
        '
        Me.ButtonSelectCode.Location = New System.Drawing.Point(234, 13)
        Me.ButtonSelectCode.Name = "ButtonSelectCode"
        Me.ButtonSelectCode.Size = New System.Drawing.Size(53, 48)
        Me.ButtonSelectCode.TabIndex = 8
        Me.ButtonSelectCode.Text = "종목" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "선택"
        Me.ButtonSelectCode.UseVisualStyleBackColor = True
        '
        'TextBoxCode
        '
        Me.TextBoxCode.Location = New System.Drawing.Point(78, 14)
        Me.TextBoxCode.Name = "TextBoxCode"
        Me.TextBoxCode.Size = New System.Drawing.Size(148, 21)
        Me.TextBoxCode.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "종목코드"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(593, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 38)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "도움말" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(관심종목 조회)"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Location = New System.Drawing.Point(593, 44)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(99, 39)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "도움말" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(실시간)"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(411, 24)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(132, 49)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "그리드 선택종목 삭제"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelMsg1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(12, 83)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(683, 41)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "조회 상태"
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
        'Form1102
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(695, 526)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBoxRQ)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1102"
        Me.Text = "[1102] 관심종목 (CpSysDib.MarketEye)"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxRQ.ResumeLayout(False)
        Me.GroupBoxRQ.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBoxRQ As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents TextBoxName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ButtonSelectCode As System.Windows.Forms.Button
    Friend WithEvents TextBoxCode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelMsg1 As System.Windows.Forms.Label
End Class
