<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1201
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1201))
        Me.TextBoxName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.ButtonSelectCode = New System.Windows.Forms.Button
        Me.TextBoxCode = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBoxAccountNo1 = New System.Windows.Forms.TextBox
        Me.ComboBoxAccountKind = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.TextBoxAccountNo2 = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.LabelMsg1 = New System.Windows.Forms.Label
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.Label19 = New System.Windows.Forms.Label
        Me.TextBoxCancelOriginNo = New System.Windows.Forms.TextBox
        Me.ButtonCancelNoneTrade = New System.Windows.Forms.Button
        Me.ButtonCancelUp = New System.Windows.Forms.Button
        Me.ButtonCancelDown = New System.Windows.Forms.Button
        Me.ButtonHelpCancel = New System.Windows.Forms.Button
        Me.TextBoxCancelCount = New System.Windows.Forms.TextBox
        Me.ButtonOrderCancel = New System.Windows.Forms.Button
        Me.Label20 = New System.Windows.Forms.Label
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.Label18 = New System.Windows.Forms.Label
        Me.TextBoxOriginNo = New System.Windows.Forms.TextBox
        Me.ButtonModifyNoneTrade = New System.Windows.Forms.Button
        Me.ButtonModifyUp = New System.Windows.Forms.Button
        Me.ButtonModifyDown = New System.Windows.Forms.Button
        Me.ButtonHelpModify = New System.Windows.Forms.Button
        Me.ComboBoxModifyCondition = New System.Windows.Forms.ComboBox
        Me.ComboBoxModifyTrade = New System.Windows.Forms.ComboBox
        Me.ButtonModifyPrice = New System.Windows.Forms.Button
        Me.TextBoxModifyPrice = New System.Windows.Forms.TextBox
        Me.TextBoxModifyCount = New System.Windows.Forms.TextBox
        Me.ButtonOrderModify = New System.Windows.Forms.Button
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.ButtonSellAble = New System.Windows.Forms.Button
        Me.ButtonSellUp = New System.Windows.Forms.Button
        Me.ButtonSellDown = New System.Windows.Forms.Button
        Me.ButtonHelpSell = New System.Windows.Forms.Button
        Me.ComboBoxSellCondition = New System.Windows.Forms.ComboBox
        Me.ComboBoxSellTrade = New System.Windows.Forms.ComboBox
        Me.ButtonSellPrice = New System.Windows.Forms.Button
        Me.TextBoxSellPrice = New System.Windows.Forms.TextBox
        Me.TextBoxSellCount = New System.Windows.Forms.TextBox
        Me.ButtonOrderSell = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.ButtonBuyAble = New System.Windows.Forms.Button
        Me.ButtonBuyUp = New System.Windows.Forms.Button
        Me.ButtonBuyDown = New System.Windows.Forms.Button
        Me.ButtonHelp1 = New System.Windows.Forms.Button
        Me.ComboBoxBuyCondition = New System.Windows.Forms.ComboBox
        Me.ComboBoxBuyTrade = New System.Windows.Forms.ComboBox
        Me.ButtonBuyPrice = New System.Windows.Forms.Button
        Me.TextBoxBuyPrice = New System.Windows.Forms.TextBox
        Me.TextBoxBuyCount = New System.Windows.Forms.TextBox
        Me.ButtonOrderBuy = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 12)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "종목명"
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 12)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "종합계좌번호"
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(133, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 12)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "구분"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TextBoxAccountNo2)
        Me.GroupBox1.Controls.Add(Me.ComboBoxAccountKind)
        Me.GroupBox1.Controls.Add(Me.TextBoxAccountNo1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(173, 76)
        Me.GroupBox1.TabIndex = 18
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBoxCode)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TextBoxName)
        Me.GroupBox2.Controls.Add(Me.ButtonSelectCode)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(187, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(275, 76)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "종목 정보"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LabelMsg1)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox3.Location = New System.Drawing.Point(3, 90)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(459, 41)
        Me.GroupBox3.TabIndex = 34
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "주문요청 상태"
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
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.TabPage5.Controls.Add(Me.Label19)
        Me.TabPage5.Controls.Add(Me.TextBoxCancelOriginNo)
        Me.TabPage5.Controls.Add(Me.ButtonCancelNoneTrade)
        Me.TabPage5.Controls.Add(Me.ButtonCancelUp)
        Me.TabPage5.Controls.Add(Me.ButtonCancelDown)
        Me.TabPage5.Controls.Add(Me.ButtonHelpCancel)
        Me.TabPage5.Controls.Add(Me.TextBoxCancelCount)
        Me.TabPage5.Controls.Add(Me.ButtonOrderCancel)
        Me.TabPage5.Controls.Add(Me.Label20)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(456, 170)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "취소 주문"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(12, 15)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(41, 12)
        Me.Label19.TabIndex = 78
        Me.Label19.Text = "원주문"
        '
        'TextBoxCancelOriginNo
        '
        Me.TextBoxCancelOriginNo.Location = New System.Drawing.Point(63, 11)
        Me.TextBoxCancelOriginNo.Name = "TextBoxCancelOriginNo"
        Me.TextBoxCancelOriginNo.Size = New System.Drawing.Size(77, 21)
        Me.TextBoxCancelOriginNo.TabIndex = 77
        Me.TextBoxCancelOriginNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ButtonCancelNoneTrade
        '
        Me.ButtonCancelNoneTrade.ForeColor = System.Drawing.Color.Black
        Me.ButtonCancelNoneTrade.Location = New System.Drawing.Point(149, 6)
        Me.ButtonCancelNoneTrade.Name = "ButtonCancelNoneTrade"
        Me.ButtonCancelNoneTrade.Size = New System.Drawing.Size(55, 32)
        Me.ButtonCancelNoneTrade.TabIndex = 75
        Me.ButtonCancelNoneTrade.Text = "미체결"
        Me.ButtonCancelNoneTrade.UseVisualStyleBackColor = True
        '
        'ButtonCancelUp
        '
        Me.ButtonCancelUp.Location = New System.Drawing.Point(177, 43)
        Me.ButtonCancelUp.Name = "ButtonCancelUp"
        Me.ButtonCancelUp.Size = New System.Drawing.Size(27, 27)
        Me.ButtonCancelUp.TabIndex = 74
        Me.ButtonCancelUp.Text = "+1"
        Me.ButtonCancelUp.UseVisualStyleBackColor = True
        '
        'ButtonCancelDown
        '
        Me.ButtonCancelDown.Location = New System.Drawing.Point(149, 43)
        Me.ButtonCancelDown.Name = "ButtonCancelDown"
        Me.ButtonCancelDown.Size = New System.Drawing.Size(27, 27)
        Me.ButtonCancelDown.TabIndex = 73
        Me.ButtonCancelDown.Text = "-1"
        Me.ButtonCancelDown.UseVisualStyleBackColor = True
        '
        'ButtonHelpCancel
        '
        Me.ButtonHelpCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonHelpCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonHelpCancel.Location = New System.Drawing.Point(333, 84)
        Me.ButtonHelpCancel.Name = "ButtonHelpCancel"
        Me.ButtonHelpCancel.Size = New System.Drawing.Size(78, 39)
        Me.ButtonHelpCancel.TabIndex = 76
        Me.ButtonHelpCancel.Text = "도움말" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(취소)"
        Me.ButtonHelpCancel.UseVisualStyleBackColor = False
        '
        'TextBoxCancelCount
        '
        Me.TextBoxCancelCount.Location = New System.Drawing.Point(65, 46)
        Me.TextBoxCancelCount.Name = "TextBoxCancelCount"
        Me.TextBoxCancelCount.Size = New System.Drawing.Size(77, 21)
        Me.TextBoxCancelCount.TabIndex = 70
        Me.TextBoxCancelCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ButtonOrderCancel
        '
        Me.ButtonOrderCancel.Font = New System.Drawing.Font("Gulim", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.ButtonOrderCancel.ForeColor = System.Drawing.Color.Olive
        Me.ButtonOrderCancel.Location = New System.Drawing.Point(315, 21)
        Me.ButtonOrderCancel.Name = "ButtonOrderCancel"
        Me.ButtonOrderCancel.Size = New System.Drawing.Size(112, 46)
        Me.ButtonOrderCancel.TabIndex = 69
        Me.ButtonOrderCancel.Text = "취소 주문"
        Me.ButtonOrderCancel.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(23, 50)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(29, 12)
        Me.Label20.TabIndex = 66
        Me.Label20.Text = "수량"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.Label18)
        Me.TabPage3.Controls.Add(Me.TextBoxOriginNo)
        Me.TabPage3.Controls.Add(Me.ButtonModifyNoneTrade)
        Me.TabPage3.Controls.Add(Me.ButtonModifyUp)
        Me.TabPage3.Controls.Add(Me.ButtonModifyDown)
        Me.TabPage3.Controls.Add(Me.ButtonHelpModify)
        Me.TabPage3.Controls.Add(Me.ComboBoxModifyCondition)
        Me.TabPage3.Controls.Add(Me.ComboBoxModifyTrade)
        Me.TabPage3.Controls.Add(Me.ButtonModifyPrice)
        Me.TabPage3.Controls.Add(Me.TextBoxModifyPrice)
        Me.TabPage3.Controls.Add(Me.TextBoxModifyCount)
        Me.TabPage3.Controls.Add(Me.ButtonOrderModify)
        Me.TabPage3.Controls.Add(Me.Label14)
        Me.TabPage3.Controls.Add(Me.Label15)
        Me.TabPage3.Controls.Add(Me.Label16)
        Me.TabPage3.Controls.Add(Me.Label17)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(456, 170)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "정정 주문"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(12, 15)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(41, 12)
        Me.Label18.TabIndex = 66
        Me.Label18.Text = "원주문"
        '
        'TextBoxOriginNo
        '
        Me.TextBoxOriginNo.Location = New System.Drawing.Point(64, 11)
        Me.TextBoxOriginNo.Name = "TextBoxOriginNo"
        Me.TextBoxOriginNo.Size = New System.Drawing.Size(78, 21)
        Me.TextBoxOriginNo.TabIndex = 65
        Me.TextBoxOriginNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ButtonModifyNoneTrade
        '
        Me.ButtonModifyNoneTrade.ForeColor = System.Drawing.Color.Black
        Me.ButtonModifyNoneTrade.Location = New System.Drawing.Point(149, 6)
        Me.ButtonModifyNoneTrade.Name = "ButtonModifyNoneTrade"
        Me.ButtonModifyNoneTrade.Size = New System.Drawing.Size(55, 32)
        Me.ButtonModifyNoneTrade.TabIndex = 63
        Me.ButtonModifyNoneTrade.Text = "미체결"
        Me.ButtonModifyNoneTrade.UseVisualStyleBackColor = True
        '
        'ButtonModifyUp
        '
        Me.ButtonModifyUp.Location = New System.Drawing.Point(177, 43)
        Me.ButtonModifyUp.Name = "ButtonModifyUp"
        Me.ButtonModifyUp.Size = New System.Drawing.Size(27, 27)
        Me.ButtonModifyUp.TabIndex = 62
        Me.ButtonModifyUp.Text = "+1"
        Me.ButtonModifyUp.UseVisualStyleBackColor = True
        '
        'ButtonModifyDown
        '
        Me.ButtonModifyDown.Location = New System.Drawing.Point(149, 43)
        Me.ButtonModifyDown.Name = "ButtonModifyDown"
        Me.ButtonModifyDown.Size = New System.Drawing.Size(27, 27)
        Me.ButtonModifyDown.TabIndex = 61
        Me.ButtonModifyDown.Text = "-1"
        Me.ButtonModifyDown.UseVisualStyleBackColor = True
        '
        'ButtonHelpModify
        '
        Me.ButtonHelpModify.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonHelpModify.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonHelpModify.Location = New System.Drawing.Point(333, 84)
        Me.ButtonHelpModify.Name = "ButtonHelpModify"
        Me.ButtonHelpModify.Size = New System.Drawing.Size(78, 39)
        Me.ButtonHelpModify.TabIndex = 64
        Me.ButtonHelpModify.Text = "도움말" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(정정)"
        Me.ButtonHelpModify.UseVisualStyleBackColor = False
        '
        'ComboBoxModifyCondition
        '
        Me.ComboBoxModifyCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxModifyCondition.FormattingEnabled = True
        Me.ComboBoxModifyCondition.Items.AddRange(New Object() {"0 : 없음 (매매조건 없음)", "1 : IOC (즉시체결 및 잔량취소)", "2 : FOK (전부체결 또는 잔량취소)"})
        Me.ComboBoxModifyCondition.Location = New System.Drawing.Point(64, 142)
        Me.ComboBoxModifyCondition.Name = "ComboBoxModifyCondition"
        Me.ComboBoxModifyCondition.Size = New System.Drawing.Size(211, 20)
        Me.ComboBoxModifyCondition.TabIndex = 60
        '
        'ComboBoxModifyTrade
        '
        Me.ComboBoxModifyTrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxModifyTrade.FormattingEnabled = True
        Me.ComboBoxModifyTrade.Items.AddRange(New Object() {"01 : 보통", "03 : 시장가", "05 : 조건부지정가", "12 : 최유리지정가", "13 : 최우선지정가"})
        Me.ComboBoxModifyTrade.Location = New System.Drawing.Point(64, 115)
        Me.ComboBoxModifyTrade.Name = "ComboBoxModifyTrade"
        Me.ComboBoxModifyTrade.Size = New System.Drawing.Size(211, 20)
        Me.ComboBoxModifyTrade.TabIndex = 59
        '
        'ButtonModifyPrice
        '
        Me.ButtonModifyPrice.ForeColor = System.Drawing.Color.Black
        Me.ButtonModifyPrice.Location = New System.Drawing.Point(149, 76)
        Me.ButtonModifyPrice.Name = "ButtonModifyPrice"
        Me.ButtonModifyPrice.Size = New System.Drawing.Size(55, 32)
        Me.ButtonModifyPrice.TabIndex = 58
        Me.ButtonModifyPrice.Text = "호가"
        Me.ButtonModifyPrice.UseVisualStyleBackColor = True
        '
        'TextBoxModifyPrice
        '
        Me.TextBoxModifyPrice.Location = New System.Drawing.Point(65, 81)
        Me.TextBoxModifyPrice.Name = "TextBoxModifyPrice"
        Me.TextBoxModifyPrice.Size = New System.Drawing.Size(77, 21)
        Me.TextBoxModifyPrice.TabIndex = 57
        Me.TextBoxModifyPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBoxModifyCount
        '
        Me.TextBoxModifyCount.Location = New System.Drawing.Point(65, 46)
        Me.TextBoxModifyCount.Name = "TextBoxModifyCount"
        Me.TextBoxModifyCount.Size = New System.Drawing.Size(77, 21)
        Me.TextBoxModifyCount.TabIndex = 56
        Me.TextBoxModifyCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ButtonOrderModify
        '
        Me.ButtonOrderModify.Font = New System.Drawing.Font("Gulim", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.ButtonOrderModify.ForeColor = System.Drawing.Color.Green
        Me.ButtonOrderModify.Location = New System.Drawing.Point(315, 21)
        Me.ButtonOrderModify.Name = "ButtonOrderModify"
        Me.ButtonOrderModify.Size = New System.Drawing.Size(112, 46)
        Me.ButtonOrderModify.TabIndex = 55
        Me.ButtonOrderModify.Text = "정정 주문"
        Me.ButtonOrderModify.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(22, 147)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(29, 12)
        Me.Label14.TabIndex = 54
        Me.Label14.Text = "조건"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(23, 119)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(29, 12)
        Me.Label15.TabIndex = 53
        Me.Label15.Text = "매매"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(23, 84)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(29, 12)
        Me.Label16.TabIndex = 52
        Me.Label16.Text = "단가"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(23, 50)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(29, 12)
        Me.Label17.TabIndex = 51
        Me.Label17.Text = "수량"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.ButtonSellAble)
        Me.TabPage2.Controls.Add(Me.ButtonSellUp)
        Me.TabPage2.Controls.Add(Me.ButtonSellDown)
        Me.TabPage2.Controls.Add(Me.ButtonHelpSell)
        Me.TabPage2.Controls.Add(Me.ComboBoxSellCondition)
        Me.TabPage2.Controls.Add(Me.ComboBoxSellTrade)
        Me.TabPage2.Controls.Add(Me.ButtonSellPrice)
        Me.TabPage2.Controls.Add(Me.TextBoxSellPrice)
        Me.TabPage2.Controls.Add(Me.TextBoxSellCount)
        Me.TabPage2.Controls.Add(Me.ButtonOrderSell)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(456, 170)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "매도 주문"
        '
        'ButtonSellAble
        '
        Me.ButtonSellAble.ForeColor = System.Drawing.Color.Black
        Me.ButtonSellAble.Location = New System.Drawing.Point(208, 7)
        Me.ButtonSellAble.Name = "ButtonSellAble"
        Me.ButtonSellAble.Size = New System.Drawing.Size(69, 34)
        Me.ButtonSellAble.TabIndex = 49
        Me.ButtonSellAble.Text = "매도 가능"
        Me.ButtonSellAble.UseVisualStyleBackColor = True
        '
        'ButtonSellUp
        '
        Me.ButtonSellUp.Location = New System.Drawing.Point(177, 10)
        Me.ButtonSellUp.Name = "ButtonSellUp"
        Me.ButtonSellUp.Size = New System.Drawing.Size(27, 27)
        Me.ButtonSellUp.TabIndex = 48
        Me.ButtonSellUp.Text = "+1"
        Me.ButtonSellUp.UseVisualStyleBackColor = True
        '
        'ButtonSellDown
        '
        Me.ButtonSellDown.Location = New System.Drawing.Point(149, 10)
        Me.ButtonSellDown.Name = "ButtonSellDown"
        Me.ButtonSellDown.Size = New System.Drawing.Size(27, 27)
        Me.ButtonSellDown.TabIndex = 47
        Me.ButtonSellDown.Text = "-1"
        Me.ButtonSellDown.UseVisualStyleBackColor = True
        '
        'ButtonHelpSell
        '
        Me.ButtonHelpSell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonHelpSell.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonHelpSell.Location = New System.Drawing.Point(333, 84)
        Me.ButtonHelpSell.Name = "ButtonHelpSell"
        Me.ButtonHelpSell.Size = New System.Drawing.Size(78, 39)
        Me.ButtonHelpSell.TabIndex = 50
        Me.ButtonHelpSell.Text = "도움말" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(매도)"
        Me.ButtonHelpSell.UseVisualStyleBackColor = False
        '
        'ComboBoxSellCondition
        '
        Me.ComboBoxSellCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSellCondition.FormattingEnabled = True
        Me.ComboBoxSellCondition.Items.AddRange(New Object() {"0 : 없음 (매매조건 없음)", "1 : IOC (즉시체결 및 잔량취소)", "2 : FOK (전부체결 또는 잔량취소)"})
        Me.ComboBoxSellCondition.Location = New System.Drawing.Point(64, 115)
        Me.ComboBoxSellCondition.Name = "ComboBoxSellCondition"
        Me.ComboBoxSellCondition.Size = New System.Drawing.Size(211, 20)
        Me.ComboBoxSellCondition.TabIndex = 46
        '
        'ComboBoxSellTrade
        '
        Me.ComboBoxSellTrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSellTrade.FormattingEnabled = True
        Me.ComboBoxSellTrade.Items.AddRange(New Object() {"01 : 보통", "03 : 시장가", "05 : 조건부지정가", "12 : 최유리지정가", "13 : 최우선지정가"})
        Me.ComboBoxSellTrade.Location = New System.Drawing.Point(64, 84)
        Me.ComboBoxSellTrade.Name = "ComboBoxSellTrade"
        Me.ComboBoxSellTrade.Size = New System.Drawing.Size(211, 20)
        Me.ComboBoxSellTrade.TabIndex = 45
        '
        'ButtonSellPrice
        '
        Me.ButtonSellPrice.ForeColor = System.Drawing.Color.Black
        Me.ButtonSellPrice.Location = New System.Drawing.Point(149, 44)
        Me.ButtonSellPrice.Name = "ButtonSellPrice"
        Me.ButtonSellPrice.Size = New System.Drawing.Size(55, 34)
        Me.ButtonSellPrice.TabIndex = 44
        Me.ButtonSellPrice.Text = "호가"
        Me.ButtonSellPrice.UseVisualStyleBackColor = True
        '
        'TextBoxSellPrice
        '
        Me.TextBoxSellPrice.Location = New System.Drawing.Point(65, 50)
        Me.TextBoxSellPrice.Name = "TextBoxSellPrice"
        Me.TextBoxSellPrice.Size = New System.Drawing.Size(77, 21)
        Me.TextBoxSellPrice.TabIndex = 43
        Me.TextBoxSellPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBoxSellCount
        '
        Me.TextBoxSellCount.Location = New System.Drawing.Point(65, 13)
        Me.TextBoxSellCount.Name = "TextBoxSellCount"
        Me.TextBoxSellCount.Size = New System.Drawing.Size(77, 21)
        Me.TextBoxSellCount.TabIndex = 42
        Me.TextBoxSellCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ButtonOrderSell
        '
        Me.ButtonOrderSell.Font = New System.Drawing.Font("Gulim", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.ButtonOrderSell.ForeColor = System.Drawing.Color.Blue
        Me.ButtonOrderSell.Location = New System.Drawing.Point(315, 21)
        Me.ButtonOrderSell.Name = "ButtonOrderSell"
        Me.ButtonOrderSell.Size = New System.Drawing.Size(112, 46)
        Me.ButtonOrderSell.TabIndex = 41
        Me.ButtonOrderSell.Text = "매도 주문"
        Me.ButtonOrderSell.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 12)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "조건"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(23, 88)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(29, 12)
        Me.Label11.TabIndex = 39
        Me.Label11.Text = "매매"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(23, 55)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(29, 12)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "단가"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(23, 17)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(29, 12)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "수량"
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.ButtonBuyAble)
        Me.TabPage1.Controls.Add(Me.ButtonBuyUp)
        Me.TabPage1.Controls.Add(Me.ButtonBuyDown)
        Me.TabPage1.Controls.Add(Me.ButtonHelp1)
        Me.TabPage1.Controls.Add(Me.ComboBoxBuyCondition)
        Me.TabPage1.Controls.Add(Me.ComboBoxBuyTrade)
        Me.TabPage1.Controls.Add(Me.ButtonBuyPrice)
        Me.TabPage1.Controls.Add(Me.TextBoxBuyPrice)
        Me.TabPage1.Controls.Add(Me.TextBoxBuyCount)
        Me.TabPage1.Controls.Add(Me.ButtonOrderBuy)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(456, 170)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "매수 주문"
        '
        'ButtonBuyAble
        '
        Me.ButtonBuyAble.ForeColor = System.Drawing.Color.Black
        Me.ButtonBuyAble.Location = New System.Drawing.Point(208, 7)
        Me.ButtonBuyAble.Name = "ButtonBuyAble"
        Me.ButtonBuyAble.Size = New System.Drawing.Size(69, 34)
        Me.ButtonBuyAble.TabIndex = 32
        Me.ButtonBuyAble.Text = "매수 가능"
        Me.ButtonBuyAble.UseVisualStyleBackColor = True
        '
        'ButtonBuyUp
        '
        Me.ButtonBuyUp.Location = New System.Drawing.Point(177, 10)
        Me.ButtonBuyUp.Name = "ButtonBuyUp"
        Me.ButtonBuyUp.Size = New System.Drawing.Size(27, 27)
        Me.ButtonBuyUp.TabIndex = 31
        Me.ButtonBuyUp.Text = "+1"
        Me.ButtonBuyUp.UseVisualStyleBackColor = True
        '
        'ButtonBuyDown
        '
        Me.ButtonBuyDown.Location = New System.Drawing.Point(149, 10)
        Me.ButtonBuyDown.Name = "ButtonBuyDown"
        Me.ButtonBuyDown.Size = New System.Drawing.Size(27, 27)
        Me.ButtonBuyDown.TabIndex = 30
        Me.ButtonBuyDown.Text = "-1"
        Me.ButtonBuyDown.UseVisualStyleBackColor = True
        '
        'ButtonHelp1
        '
        Me.ButtonHelp1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonHelp1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonHelp1.Location = New System.Drawing.Point(333, 84)
        Me.ButtonHelp1.Name = "ButtonHelp1"
        Me.ButtonHelp1.Size = New System.Drawing.Size(78, 39)
        Me.ButtonHelp1.TabIndex = 35
        Me.ButtonHelp1.Text = "도움말" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(매수)"
        Me.ButtonHelp1.UseVisualStyleBackColor = False
        '
        'ComboBoxBuyCondition
        '
        Me.ComboBoxBuyCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxBuyCondition.FormattingEnabled = True
        Me.ComboBoxBuyCondition.Items.AddRange(New Object() {"0 : 없음 (매매조건 없음)", "1 : IOC (즉시체결 및 잔량취소)", "2 : FOK (전부체결 또는 잔량취소)"})
        Me.ComboBoxBuyCondition.Location = New System.Drawing.Point(64, 115)
        Me.ComboBoxBuyCondition.Name = "ComboBoxBuyCondition"
        Me.ComboBoxBuyCondition.Size = New System.Drawing.Size(211, 20)
        Me.ComboBoxBuyCondition.TabIndex = 29
        '
        'ComboBoxBuyTrade
        '
        Me.ComboBoxBuyTrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxBuyTrade.FormattingEnabled = True
        Me.ComboBoxBuyTrade.Items.AddRange(New Object() {"01 : 보통", "03 : 시장가", "05 : 조건부지정가", "12 : 최유리지정가", "13 : 최우선지정가"})
        Me.ComboBoxBuyTrade.Location = New System.Drawing.Point(64, 84)
        Me.ComboBoxBuyTrade.Name = "ComboBoxBuyTrade"
        Me.ComboBoxBuyTrade.Size = New System.Drawing.Size(211, 20)
        Me.ComboBoxBuyTrade.TabIndex = 28
        '
        'ButtonBuyPrice
        '
        Me.ButtonBuyPrice.ForeColor = System.Drawing.Color.Black
        Me.ButtonBuyPrice.Location = New System.Drawing.Point(149, 44)
        Me.ButtonBuyPrice.Name = "ButtonBuyPrice"
        Me.ButtonBuyPrice.Size = New System.Drawing.Size(55, 34)
        Me.ButtonBuyPrice.TabIndex = 7
        Me.ButtonBuyPrice.Text = "호가"
        Me.ButtonBuyPrice.UseVisualStyleBackColor = True
        '
        'TextBoxBuyPrice
        '
        Me.TextBoxBuyPrice.Location = New System.Drawing.Point(65, 50)
        Me.TextBoxBuyPrice.Name = "TextBoxBuyPrice"
        Me.TextBoxBuyPrice.Size = New System.Drawing.Size(77, 21)
        Me.TextBoxBuyPrice.TabIndex = 6
        Me.TextBoxBuyPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBoxBuyCount
        '
        Me.TextBoxBuyCount.Location = New System.Drawing.Point(65, 13)
        Me.TextBoxBuyCount.Name = "TextBoxBuyCount"
        Me.TextBoxBuyCount.Size = New System.Drawing.Size(77, 21)
        Me.TextBoxBuyCount.TabIndex = 5
        Me.TextBoxBuyCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ButtonOrderBuy
        '
        Me.ButtonOrderBuy.Font = New System.Drawing.Font("Gulim", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.ButtonOrderBuy.ForeColor = System.Drawing.Color.Red
        Me.ButtonOrderBuy.Location = New System.Drawing.Point(315, 21)
        Me.ButtonOrderBuy.Name = "ButtonOrderBuy"
        Me.ButtonOrderBuy.Size = New System.Drawing.Size(112, 46)
        Me.ButtonOrderBuy.TabIndex = 4
        Me.ButtonOrderBuy.Text = "매수 주문"
        Me.ButtonOrderBuy.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(22, 120)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 12)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "조건"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 12)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "매매"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 12)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "단가"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 12)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "수량"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Location = New System.Drawing.Point(3, 138)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(464, 196)
        Me.TabControl1.TabIndex = 20
        '
        'Form1201
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 341)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1201"
        Me.Text = "[1201] 주식 현금주문 (CpTrade.CpTd0311)"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TextBoxName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ButtonSelectCode As System.Windows.Forms.Button
    Friend WithEvents TextBoxCode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxAccountNo1 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxAccountKind As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelMsg1 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBoxAccountNo2 As System.Windows.Forms.TextBox
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents ButtonBuyAble As System.Windows.Forms.Button
    Friend WithEvents ButtonBuyUp As System.Windows.Forms.Button
    Friend WithEvents ButtonBuyDown As System.Windows.Forms.Button
    Friend WithEvents ButtonHelp1 As System.Windows.Forms.Button
    Friend WithEvents ComboBoxBuyCondition As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxBuyTrade As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonBuyPrice As System.Windows.Forms.Button
    Friend WithEvents TextBoxBuyPrice As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxBuyCount As System.Windows.Forms.TextBox
    Friend WithEvents ButtonOrderBuy As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents ButtonSellAble As System.Windows.Forms.Button
    Friend WithEvents ButtonSellUp As System.Windows.Forms.Button
    Friend WithEvents ButtonSellDown As System.Windows.Forms.Button
    Friend WithEvents ButtonHelpSell As System.Windows.Forms.Button
    Friend WithEvents ComboBoxSellCondition As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxSellTrade As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonSellPrice As System.Windows.Forms.Button
    Friend WithEvents TextBoxSellPrice As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxSellCount As System.Windows.Forms.TextBox
    Friend WithEvents ButtonOrderSell As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TextBoxOriginNo As System.Windows.Forms.TextBox
    Friend WithEvents ButtonModifyNoneTrade As System.Windows.Forms.Button
    Friend WithEvents ButtonModifyUp As System.Windows.Forms.Button
    Friend WithEvents ButtonModifyDown As System.Windows.Forms.Button
    Friend WithEvents ButtonHelpModify As System.Windows.Forms.Button
    Friend WithEvents ComboBoxModifyCondition As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxModifyTrade As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonModifyPrice As System.Windows.Forms.Button
    Friend WithEvents TextBoxModifyPrice As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxModifyCount As System.Windows.Forms.TextBox
    Friend WithEvents ButtonOrderModify As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TextBoxCancelOriginNo As System.Windows.Forms.TextBox
    Friend WithEvents ButtonCancelNoneTrade As System.Windows.Forms.Button
    Friend WithEvents ButtonCancelUp As System.Windows.Forms.Button
    Friend WithEvents ButtonCancelDown As System.Windows.Forms.Button
    Friend WithEvents ButtonHelpCancel As System.Windows.Forms.Button
    Friend WithEvents TextBoxCancelCount As System.Windows.Forms.TextBox
    Friend WithEvents ButtonOrderCancel As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
End Class
