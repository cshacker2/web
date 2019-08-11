<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1204
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1204))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.LabelMsg1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TextBoxCode = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBoxName = New System.Windows.Forms.TextBox
        Me.ButtonSelectCode = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.TextBoxAccountNo2 = New System.Windows.Forms.TextBox
        Me.ComboBoxAccountKind = New System.Windows.Forms.ComboBox
        Me.TextBoxAccountNo1 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.ButtonBuyUp = New System.Windows.Forms.Button
        Me.ButtonBuyDown = New System.Windows.Forms.Button
        Me.ButtonHelpBuy = New System.Windows.Forms.Button
        Me.ComboBoxBuyTrade = New System.Windows.Forms.ComboBox
        Me.ButtonBuyPrice = New System.Windows.Forms.Button
        Me.TextBoxBuyPrice = New System.Windows.Forms.TextBox
        Me.TextBoxBuyCount = New System.Windows.Forms.TextBox
        Me.ButtonOrderBuy = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.ButtonSellUp = New System.Windows.Forms.Button
        Me.ButtonSellDown = New System.Windows.Forms.Button
        Me.ButtonHelpSell = New System.Windows.Forms.Button
        Me.ComboBoxSellTrade = New System.Windows.Forms.ComboBox
        Me.ButtonSellPrice = New System.Windows.Forms.Button
        Me.TextBoxSellPrice = New System.Windows.Forms.TextBox
        Me.TextBoxSellCount = New System.Windows.Forms.TextBox
        Me.ButtonOrderSell = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.Label9 = New System.Windows.Forms.Label
        Me.TextBoxCancel = New System.Windows.Forms.TextBox
        Me.ButtonCancelQuery = New System.Windows.Forms.Button
        Me.ButtonHelp3 = New System.Windows.Forms.Button
        Me.ButtonCancelOrder = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Label19 = New System.Windows.Forms.Label
        Me.TextBoxCancelOriginNo = New System.Windows.Forms.TextBox
        Me.ButtonCancelNoneTrade = New System.Windows.Forms.Button
        Me.ButtonCancelUp = New System.Windows.Forms.Button
        Me.ButtonCancelDown = New System.Windows.Forms.Button
        Me.ButtonHelpCancel = New System.Windows.Forms.Button
        Me.TextBoxCancelCount = New System.Windows.Forms.TextBox
        Me.ButtonOrderCancel = New System.Windows.Forms.Button
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LabelMsg1)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox3.Location = New System.Drawing.Point(3, 90)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(431, 41)
        Me.GroupBox3.TabIndex = 38
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
        Me.GroupBox2.TabIndex = 36
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "종목 정보"
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
        'TextBoxName
        '
        Me.TextBoxName.BackColor = System.Drawing.Color.White
        Me.TextBoxName.Location = New System.Drawing.Point(75, 45)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.ReadOnly = True
        Me.TextBoxName.Size = New System.Drawing.Size(124, 21)
        Me.TextBoxName.TabIndex = 5
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 12)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "종목명"
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
        Me.GroupBox1.TabIndex = 35
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
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Location = New System.Drawing.Point(3, 136)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(581, 140)
        Me.TabControl1.TabIndex = 39
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.ButtonBuyUp)
        Me.TabPage1.Controls.Add(Me.ButtonBuyDown)
        Me.TabPage1.Controls.Add(Me.ButtonHelpBuy)
        Me.TabPage1.Controls.Add(Me.ComboBoxBuyTrade)
        Me.TabPage1.Controls.Add(Me.ButtonBuyPrice)
        Me.TabPage1.Controls.Add(Me.TextBoxBuyPrice)
        Me.TabPage1.Controls.Add(Me.TextBoxBuyCount)
        Me.TabPage1.Controls.Add(Me.ButtonOrderBuy)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(573, 114)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "현금매수 예약주문"
        '
        'ButtonBuyUp
        '
        Me.ButtonBuyUp.Location = New System.Drawing.Point(188, 10)
        Me.ButtonBuyUp.Name = "ButtonBuyUp"
        Me.ButtonBuyUp.Size = New System.Drawing.Size(27, 27)
        Me.ButtonBuyUp.TabIndex = 31
        Me.ButtonBuyUp.Text = "+1"
        Me.ButtonBuyUp.UseVisualStyleBackColor = True
        '
        'ButtonBuyDown
        '
        Me.ButtonBuyDown.Location = New System.Drawing.Point(160, 10)
        Me.ButtonBuyDown.Name = "ButtonBuyDown"
        Me.ButtonBuyDown.Size = New System.Drawing.Size(27, 27)
        Me.ButtonBuyDown.TabIndex = 30
        Me.ButtonBuyDown.Text = "-1"
        Me.ButtonBuyDown.UseVisualStyleBackColor = True
        '
        'ButtonHelpBuy
        '
        Me.ButtonHelpBuy.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonHelpBuy.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonHelpBuy.Location = New System.Drawing.Point(436, 10)
        Me.ButtonHelpBuy.Name = "ButtonHelpBuy"
        Me.ButtonHelpBuy.Size = New System.Drawing.Size(127, 39)
        Me.ButtonHelpBuy.TabIndex = 35
        Me.ButtonHelpBuy.Text = "도움말" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(주식현금 예약주문)"
        Me.ButtonHelpBuy.UseVisualStyleBackColor = False
        '
        'ComboBoxBuyTrade
        '
        Me.ComboBoxBuyTrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxBuyTrade.FormattingEnabled = True
        Me.ComboBoxBuyTrade.Items.AddRange(New Object() {"01 : 보통", "03 : 시장가", "05 : 조건부지정가"})
        Me.ComboBoxBuyTrade.Location = New System.Drawing.Point(75, 84)
        Me.ComboBoxBuyTrade.Name = "ComboBoxBuyTrade"
        Me.ComboBoxBuyTrade.Size = New System.Drawing.Size(140, 20)
        Me.ComboBoxBuyTrade.TabIndex = 28
        '
        'ButtonBuyPrice
        '
        Me.ButtonBuyPrice.ForeColor = System.Drawing.Color.Black
        Me.ButtonBuyPrice.Location = New System.Drawing.Point(160, 44)
        Me.ButtonBuyPrice.Name = "ButtonBuyPrice"
        Me.ButtonBuyPrice.Size = New System.Drawing.Size(55, 34)
        Me.ButtonBuyPrice.TabIndex = 7
        Me.ButtonBuyPrice.Text = "호가"
        Me.ButtonBuyPrice.UseVisualStyleBackColor = True
        '
        'TextBoxBuyPrice
        '
        Me.TextBoxBuyPrice.Location = New System.Drawing.Point(76, 50)
        Me.TextBoxBuyPrice.Name = "TextBoxBuyPrice"
        Me.TextBoxBuyPrice.Size = New System.Drawing.Size(77, 21)
        Me.TextBoxBuyPrice.TabIndex = 6
        Me.TextBoxBuyPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBoxBuyCount
        '
        Me.TextBoxBuyCount.Location = New System.Drawing.Point(76, 13)
        Me.TextBoxBuyCount.Name = "TextBoxBuyCount"
        Me.TextBoxBuyCount.Size = New System.Drawing.Size(77, 21)
        Me.TextBoxBuyCount.TabIndex = 5
        Me.TextBoxBuyCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ButtonOrderBuy
        '
        Me.ButtonOrderBuy.Font = New System.Drawing.Font("Gulim", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.ButtonOrderBuy.ForeColor = System.Drawing.Color.Red
        Me.ButtonOrderBuy.Location = New System.Drawing.Point(300, 36)
        Me.ButtonOrderBuy.Name = "ButtonOrderBuy"
        Me.ButtonOrderBuy.Size = New System.Drawing.Size(112, 46)
        Me.ButtonOrderBuy.TabIndex = 4
        Me.ButtonOrderBuy.Text = "현금 매수" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "예약 주문"
        Me.ButtonOrderBuy.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(34, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 12)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "매매"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(34, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 12)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "단가"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(34, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 12)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "수량"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.ButtonSellUp)
        Me.TabPage2.Controls.Add(Me.ButtonSellDown)
        Me.TabPage2.Controls.Add(Me.ButtonHelpSell)
        Me.TabPage2.Controls.Add(Me.ComboBoxSellTrade)
        Me.TabPage2.Controls.Add(Me.ButtonSellPrice)
        Me.TabPage2.Controls.Add(Me.TextBoxSellPrice)
        Me.TabPage2.Controls.Add(Me.TextBoxSellCount)
        Me.TabPage2.Controls.Add(Me.ButtonOrderSell)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(573, 114)
        Me.TabPage2.TabIndex = 5
        Me.TabPage2.Text = "현금매도 예약주문"
        '
        'ButtonSellUp
        '
        Me.ButtonSellUp.Location = New System.Drawing.Point(188, 10)
        Me.ButtonSellUp.Name = "ButtonSellUp"
        Me.ButtonSellUp.Size = New System.Drawing.Size(27, 27)
        Me.ButtonSellUp.TabIndex = 48
        Me.ButtonSellUp.Text = "+1"
        Me.ButtonSellUp.UseVisualStyleBackColor = True
        '
        'ButtonSellDown
        '
        Me.ButtonSellDown.Location = New System.Drawing.Point(160, 10)
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
        Me.ButtonHelpSell.Location = New System.Drawing.Point(436, 10)
        Me.ButtonHelpSell.Name = "ButtonHelpSell"
        Me.ButtonHelpSell.Size = New System.Drawing.Size(127, 39)
        Me.ButtonHelpSell.TabIndex = 50
        Me.ButtonHelpSell.Text = "도움말" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(현금매도 예약주문)"
        Me.ButtonHelpSell.UseVisualStyleBackColor = False
        '
        'ComboBoxSellTrade
        '
        Me.ComboBoxSellTrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSellTrade.FormattingEnabled = True
        Me.ComboBoxSellTrade.Items.AddRange(New Object() {"01 : 보통", "03 : 시장가", "05 : 조건부지정가"})
        Me.ComboBoxSellTrade.Location = New System.Drawing.Point(75, 84)
        Me.ComboBoxSellTrade.Name = "ComboBoxSellTrade"
        Me.ComboBoxSellTrade.Size = New System.Drawing.Size(140, 20)
        Me.ComboBoxSellTrade.TabIndex = 45
        '
        'ButtonSellPrice
        '
        Me.ButtonSellPrice.ForeColor = System.Drawing.Color.Black
        Me.ButtonSellPrice.Location = New System.Drawing.Point(160, 44)
        Me.ButtonSellPrice.Name = "ButtonSellPrice"
        Me.ButtonSellPrice.Size = New System.Drawing.Size(55, 34)
        Me.ButtonSellPrice.TabIndex = 44
        Me.ButtonSellPrice.Text = "호가"
        Me.ButtonSellPrice.UseVisualStyleBackColor = True
        '
        'TextBoxSellPrice
        '
        Me.TextBoxSellPrice.Location = New System.Drawing.Point(76, 50)
        Me.TextBoxSellPrice.Name = "TextBoxSellPrice"
        Me.TextBoxSellPrice.Size = New System.Drawing.Size(77, 21)
        Me.TextBoxSellPrice.TabIndex = 43
        Me.TextBoxSellPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBoxSellCount
        '
        Me.TextBoxSellCount.Location = New System.Drawing.Point(76, 13)
        Me.TextBoxSellCount.Name = "TextBoxSellCount"
        Me.TextBoxSellCount.Size = New System.Drawing.Size(77, 21)
        Me.TextBoxSellCount.TabIndex = 42
        Me.TextBoxSellCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ButtonOrderSell
        '
        Me.ButtonOrderSell.Font = New System.Drawing.Font("Gulim", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.ButtonOrderSell.ForeColor = System.Drawing.Color.Blue
        Me.ButtonOrderSell.Location = New System.Drawing.Point(300, 36)
        Me.ButtonOrderSell.Name = "ButtonOrderSell"
        Me.ButtonOrderSell.Size = New System.Drawing.Size(112, 46)
        Me.ButtonOrderSell.TabIndex = 41
        Me.ButtonOrderSell.Text = "현금 매도" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "예약 주문"
        Me.ButtonOrderSell.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(34, 88)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(29, 12)
        Me.Label11.TabIndex = 39
        Me.Label11.Text = "매매"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(34, 55)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(29, 12)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "단가"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(34, 17)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(29, 12)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "수량"
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.TabPage5.Controls.Add(Me.Label9)
        Me.TabPage5.Controls.Add(Me.TextBoxCancel)
        Me.TabPage5.Controls.Add(Me.ButtonCancelQuery)
        Me.TabPage5.Controls.Add(Me.ButtonHelp3)
        Me.TabPage5.Controls.Add(Me.ButtonCancelOrder)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(573, 114)
        Me.TabPage5.TabIndex = 6
        Me.TabPage5.Text = "예약 취소주문"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(42, 51)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 12)
        Me.Label9.TabIndex = 78
        Me.Label9.Text = "예약번호"
        '
        'TextBoxCancel
        '
        Me.TextBoxCancel.Location = New System.Drawing.Point(104, 47)
        Me.TextBoxCancel.Name = "TextBoxCancel"
        Me.TextBoxCancel.Size = New System.Drawing.Size(77, 21)
        Me.TextBoxCancel.TabIndex = 77
        Me.TextBoxCancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ButtonCancelQuery
        '
        Me.ButtonCancelQuery.ForeColor = System.Drawing.Color.Black
        Me.ButtonCancelQuery.Location = New System.Drawing.Point(191, 40)
        Me.ButtonCancelQuery.Name = "ButtonCancelQuery"
        Me.ButtonCancelQuery.Size = New System.Drawing.Size(80, 34)
        Me.ButtonCancelQuery.TabIndex = 75
        Me.ButtonCancelQuery.Text = "예약" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "주문현황"
        Me.ButtonCancelQuery.UseVisualStyleBackColor = True
        '
        'ButtonHelp3
        '
        Me.ButtonHelp3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonHelp3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonHelp3.Location = New System.Drawing.Point(436, 10)
        Me.ButtonHelp3.Name = "ButtonHelp3"
        Me.ButtonHelp3.Size = New System.Drawing.Size(127, 39)
        Me.ButtonHelp3.TabIndex = 76
        Me.ButtonHelp3.Text = "도움말" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(예약 취소주문)"
        Me.ButtonHelp3.UseVisualStyleBackColor = False
        '
        'ButtonCancelOrder
        '
        Me.ButtonCancelOrder.Font = New System.Drawing.Font("Gulim", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.ButtonCancelOrder.ForeColor = System.Drawing.Color.Olive
        Me.ButtonCancelOrder.Location = New System.Drawing.Point(300, 35)
        Me.ButtonCancelOrder.Name = "ButtonCancelOrder"
        Me.ButtonCancelOrder.Size = New System.Drawing.Size(112, 46)
        Me.ButtonCancelOrder.TabIndex = 69
        Me.ButtonCancelOrder.Text = "예약" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "취소 주문"
        Me.ButtonCancelOrder.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(0, 303)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView1.Size = New System.Drawing.Size(584, 45)
        Me.DataGridView1.TabIndex = 51
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
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(3, 284)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(57, 12)
        Me.Label15.TabIndex = 52
        Me.Label15.Text = "접수 결과"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(440, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 24)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "접수시간" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "15:05 ~ 익영업일 07:00"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1204
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(585, 349)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1204"
        Me.Text = "[1204] 주식 예약주문 (CpTrade.CpTdNew9061)"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelMsg1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxCode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxName As System.Windows.Forms.TextBox
    Friend WithEvents ButtonSelectCode As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBoxAccountNo2 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxAccountKind As System.Windows.Forms.ComboBox
    Friend WithEvents TextBoxAccountNo1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents ButtonBuyUp As System.Windows.Forms.Button
    Friend WithEvents ButtonBuyDown As System.Windows.Forms.Button
    Friend WithEvents ButtonHelpBuy As System.Windows.Forms.Button
    Friend WithEvents ComboBoxBuyTrade As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonBuyPrice As System.Windows.Forms.Button
    Friend WithEvents TextBoxBuyPrice As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxBuyCount As System.Windows.Forms.TextBox
    Friend WithEvents ButtonOrderBuy As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ButtonSellUp As System.Windows.Forms.Button
    Friend WithEvents ButtonSellDown As System.Windows.Forms.Button
    Friend WithEvents ButtonHelpSell As System.Windows.Forms.Button
    Friend WithEvents ComboBoxSellTrade As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonSellPrice As System.Windows.Forms.Button
    Friend WithEvents TextBoxSellPrice As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxSellCount As System.Windows.Forms.TextBox
    Friend WithEvents ButtonOrderSell As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBoxCancel As System.Windows.Forms.TextBox
    Friend WithEvents ButtonCancelQuery As System.Windows.Forms.Button
    Friend WithEvents ButtonHelp3 As System.Windows.Forms.Button
    Friend WithEvents ButtonCancelOrder As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TextBoxCancelOriginNo As System.Windows.Forms.TextBox
    Friend WithEvents ButtonCancelNoneTrade As System.Windows.Forms.Button
    Friend WithEvents ButtonCancelUp As System.Windows.Forms.Button
    Friend WithEvents ButtonCancelDown As System.Windows.Forms.Button
    Friend WithEvents ButtonHelpCancel As System.Windows.Forms.Button
    Friend WithEvents TextBoxCancelCount As System.Windows.Forms.TextBox
    Friend WithEvents ButtonOrderCancel As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
