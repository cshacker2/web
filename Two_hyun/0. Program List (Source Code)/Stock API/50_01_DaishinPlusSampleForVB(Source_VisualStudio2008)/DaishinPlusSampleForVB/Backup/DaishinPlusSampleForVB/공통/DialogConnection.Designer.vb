<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DialogConnection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DialogConnection))
        Me.Label1 = New System.Windows.Forms.Label
        Me.ButtonCybos = New System.Windows.Forms.Button
        Me.ButtonCreon = New System.Windows.Forms.Button
        Me.ButtonCancle = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(15, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(262, 48)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "대신증권 플러스에 접속되어 있지 않습니다." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "접속하시겠습니까?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'ButtonCybos
        '
        Me.ButtonCybos.ForeColor = System.Drawing.Color.Blue
        Me.ButtonCybos.Location = New System.Drawing.Point(14, 66)
        Me.ButtonCybos.Name = "ButtonCybos"
        Me.ButtonCybos.Size = New System.Drawing.Size(136, 44)
        Me.ButtonCybos.TabIndex = 1
        Me.ButtonCybos.Text = "사이보스 플러스 접속"
        Me.ButtonCybos.UseVisualStyleBackColor = True
        '
        'ButtonCreon
        '
        Me.ButtonCreon.ForeColor = System.Drawing.Color.Red
        Me.ButtonCreon.Location = New System.Drawing.Point(14, 116)
        Me.ButtonCreon.Name = "ButtonCreon"
        Me.ButtonCreon.Size = New System.Drawing.Size(136, 44)
        Me.ButtonCreon.TabIndex = 2
        Me.ButtonCreon.Text = "크레온 플러스 접속"
        Me.ButtonCreon.UseVisualStyleBackColor = True
        '
        'ButtonCancle
        '
        Me.ButtonCancle.Location = New System.Drawing.Point(170, 81)
        Me.ButtonCancle.Name = "ButtonCancle"
        Me.ButtonCancle.Size = New System.Drawing.Size(87, 62)
        Me.ButtonCancle.TabIndex = 3
        Me.ButtonCancle.Text = "취 소"
        Me.ButtonCancle.UseVisualStyleBackColor = True
        '
        'DialogConnection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(274, 168)
        Me.Controls.Add(Me.ButtonCancle)
        Me.Controls.Add(Me.ButtonCreon)
        Me.Controls.Add(Me.ButtonCybos)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DialogConnection"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "대신 플러스 접속"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonCybos As System.Windows.Forms.Button
    Friend WithEvents ButtonCreon As System.Windows.Forms.Button
    Friend WithEvents ButtonCancle As System.Windows.Forms.Button

End Class
