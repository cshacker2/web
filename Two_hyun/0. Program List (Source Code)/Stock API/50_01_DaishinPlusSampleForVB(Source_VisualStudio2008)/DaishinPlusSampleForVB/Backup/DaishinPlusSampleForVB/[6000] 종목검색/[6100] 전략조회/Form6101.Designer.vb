<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6101
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6101))
        Me.TextBoxCount = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ButtonHelp = New System.Windows.Forms.Button
        Me.ButtonQuery = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LabelContinue = New System.Windows.Forms.Label
        Me.LabelMsg2 = New System.Windows.Forms.Label
        Me.LabelMsg1 = New System.Windows.Forms.Label
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBoxCount
        '
        Me.TextBoxCount.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.TextBoxCount.Location = New System.Drawing.Point(77, 16)
        Me.TextBoxCount.Name = "TextBoxCount"
        Me.TextBoxCount.Size = New System.Drawing.Size(55, 21)
        Me.TextBoxCount.TabIndex = 4
        Me.TextBoxCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 12)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "전략 개수"
        '
        'ButtonHelp
        '
        Me.ButtonHelp.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonHelp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonHelp.Location = New System.Drawing.Point(870, 12)
        Me.ButtonHelp.Name = "ButtonHelp"
        Me.ButtonHelp.Size = New System.Drawing.Size(70, 32)
        Me.ButtonHelp.TabIndex = 18
        Me.ButtonHelp.Text = "도움말" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.ButtonHelp.UseVisualStyleBackColor = False
        '
        'ButtonQuery
        '
        Me.ButtonQuery.Location = New System.Drawing.Point(770, 12)
        Me.ButtonQuery.Name = "ButtonQuery"
        Me.ButtonQuery.Size = New System.Drawing.Size(77, 30)
        Me.ButtonQuery.TabIndex = 17
        Me.ButtonQuery.Text = "조회"
        Me.ButtonQuery.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 88)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView1.Size = New System.Drawing.Size(952, 319)
        Me.DataGridView1.TabIndex = 19
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelContinue)
        Me.GroupBox1.Controls.Add(Me.LabelMsg2)
        Me.GroupBox1.Controls.Add(Me.LabelMsg1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(3, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(945, 41)
        Me.GroupBox1.TabIndex = 3
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
        'Form6101
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 407)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ButtonHelp)
        Me.Controls.Add(Me.ButtonQuery)
        Me.Controls.Add(Me.TextBoxCount)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form6101"
        Me.Text = "[6102] 예제 전략 (CpSysDib.CssStgList)"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxCount As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonHelp As System.Windows.Forms.Button
    Friend WithEvents ButtonQuery As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelContinue As System.Windows.Forms.Label
    Friend WithEvents LabelMsg2 As System.Windows.Forms.Label
    Friend WithEvents LabelMsg1 As System.Windows.Forms.Label
End Class
