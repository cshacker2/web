<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1304
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1304))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.CheckBoxTop = New System.Windows.Forms.CheckBox
        Me.ButtonHelp1 = New System.Windows.Forms.Button
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(0, 43)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1241, 271)
        Me.DataGridView1.TabIndex = 6
        '
        'CheckBoxTop
        '
        Me.CheckBoxTop.AutoSize = True
        Me.CheckBoxTop.Checked = True
        Me.CheckBoxTop.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxTop.Location = New System.Drawing.Point(7, 15)
        Me.CheckBoxTop.Name = "CheckBoxTop"
        Me.CheckBoxTop.Size = New System.Drawing.Size(202, 16)
        Me.CheckBoxTop.TabIndex = 32
        Me.CheckBoxTop.Text = "최근 데이터 보기(실시간 수신시)"
        Me.CheckBoxTop.UseVisualStyleBackColor = True
        '
        'ButtonHelp1
        '
        Me.ButtonHelp1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonHelp1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonHelp1.Location = New System.Drawing.Point(228, 7)
        Me.ButtonHelp1.Name = "ButtonHelp1"
        Me.ButtonHelp1.Size = New System.Drawing.Size(58, 29)
        Me.ButtonHelp1.TabIndex = 63
        Me.ButtonHelp1.Text = "도움말"
        Me.ButtonHelp1.UseVisualStyleBackColor = False
        '
        'Form1304
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1241, 314)
        Me.Controls.Add(Me.ButtonHelp1)
        Me.Controls.Add(Me.CheckBoxTop)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1304"
        Me.Text = "[1304] 주식 체결 실시간 (CpDib.CpConclusion)"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents CheckBoxTop As System.Windows.Forms.CheckBox
    Friend WithEvents ButtonHelp1 As System.Windows.Forms.Button
End Class
