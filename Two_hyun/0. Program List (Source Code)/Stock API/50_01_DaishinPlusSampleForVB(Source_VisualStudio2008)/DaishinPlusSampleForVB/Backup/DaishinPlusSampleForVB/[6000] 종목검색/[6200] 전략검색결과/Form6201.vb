Public Class Form6201
    Private _parent As Main
    Dim _Table As DataTable = New DataTable
    Private _CssStgFind As CPSYSDIBLib.CssStgFind
    Private _stgID As String
    Private _index
    Private _arrCode As ArrayList = New ArrayList
    Private _marketEye As CPSYSDIBLib.MarketEye
    Public WithEvents _stockCur As DSCBO1Lib.StockCur

    Private Sub Form6201_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.KeyPreview = True

        _stgID = ""
        _index = 1

        _parent = Me.ParentForm

        _marketEye = New CPSYSDIBLib.MarketEye
        _stockCur = New DSCBO1Lib.StockCur
        _CssStgFind = New CPSYSDIBLib.CssStgFind

        _Table.Columns.Add("종목코드")
        _Table.Columns.Add("순번")
        _Table.Columns.Add("종목명")
        _Table.Columns.Add("시간")
        _Table.Columns.Add("현재가")
        _Table.Columns.Add("전일대비")
        _Table.Columns.Add("시가")
        _Table.Columns.Add("고가")
        _Table.Columns.Add("저가")
        _Table.Columns.Add("거래량")

        DataGridView1.DataSource = _Table

        Dim button1 As New DataGridViewButtonColumn()
        DataGridView1.Columns.Add(button1)
        button1.HeaderText = "매수"
        button1.Text = "매수"
        button1.UseColumnTextForButtonValue = True

        Dim button2 As New DataGridViewButtonColumn()
        DataGridView1.Columns.Add(button2)
        button2.HeaderText = "매도"
        button2.Text = "매도"
        button2.UseColumnTextForButtonValue = True

        DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.Columns("순번").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns("종목명").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridView1.Columns("시간").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns("현재가").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns("전일대비").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns("시가").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns("고가").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns("저가").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns("거래량").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns("종목코드").Visible = False
        DataGridView1.Refresh()
    End Sub

    Public Sub SetSTGInfo(ByVal id As String, ByVal name As String)
        _stgID = id
        TextBoxName.Text = name

        Me.Request()
    End Sub

    Private Sub Form6201_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub ButtonQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonQuery.Click
        Me.Request()
    End Sub

    Private Sub ButtonHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHelp.Click
        _parent.ShowHelp("6201")
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        DataGridView1.ClearSelection()

        If DataGridView1.Columns(e.ColumnIndex).HeaderText = "매수" Then
            _parent.ShowStockOrder(Me, 0)
            _parent.ChangedStockCode(DataGridView1.Rows(e.RowIndex).Cells("종목코드").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("종목명").Value.ToString())
        ElseIf DataGridView1.Columns(e.ColumnIndex).HeaderText = "매도" Then
            _parent.ShowStockOrder(Me, 1)
            _parent.ChangedStockCode(DataGridView1.Rows(e.RowIndex).Cells("종목코드").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("종목명").Value.ToString())
        Else
            _parent.ChangedStockCode(DataGridView1.Rows(e.RowIndex).Cells("종목코드").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("종목명").Value.ToString())
        End If
    End Sub

    Private Sub DataGridView1_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        If DataGridView1.Columns(e.ColumnIndex).HeaderText = "전일대비" Then
            Dim value As Double = Convert.ToDouble(e.Value.ToString())
            If value > 0 Then
                DataGridView1.Rows(e.RowIndex).Cells("현재가").Style.ForeColor = Color.Red
            ElseIf value < 0 Then
                DataGridView1.Rows(e.RowIndex).Cells("현재가").Style.ForeColor = Color.Blue
            Else
                DataGridView1.Rows(e.RowIndex).Cells("현재가").Style.ForeColor = Color.Black
            End If
        End If
    End Sub

    Private Sub DataGridView1_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles DataGridView1.DataBindingComplete
        DataGridView1.ClearSelection()
    End Sub

    Private Sub Request()
        If _stgID = "" Then
            MessageBox.Show("전략이 존재하지 않습니다. 전략조회 화면으로부터 연동이 되어야합니다.")
            Return
        End If

        _Table.Clear()
        DataGridView1.Refresh()

        TextBoxCount.Text = "0"
        TextBoxDateTime.Text = "0"
        _index = 1
        _arrCode.Clear()

        _CssStgFind.SetInputValue(0, _stgID)

        Me.JustRequest()
    End Sub

    Private Sub JustRequest()
        If _CssStgFind.GetDibStatus() = 1 Then
            Trace.TraceInformation("DibRq 요청 수신대기 중 입니다. 수신이 완료된 후 다시 호출 하십시오.")
            Exit Sub
        End If

        LabelMsg1.Text = ""
        LabelMsg2.Text = ""
        LabelContinue.Text = ""

        Dim result As Integer = -1
        result = _CssStgFind.BlockRequest()

        LabelMsg1.Text = _CssStgFind.GetDibMsg1()
        LabelMsg2.Text = _CssStgFind.GetDibMsg2()

        TextBoxCount.Text = _CssStgFind.GetHeaderValue(1).ToString()
        TextBoxDateTime.Text = _CssStgFind.GetHeaderValue(2).ToString()

        If result = 0 Then
            For i As Integer = 0 To _CssStgFind.GetHeaderValue(0) - 1
                _arrCode.Add(_CssStgFind.GetDataValue(0, i))
            Next i
        End If

        If _CssStgFind.Continue = 1 Then
            Me.JustRequest()
            LabelMsg1.Text = "조회중입니다."
        Else
            Me.Unsubscribe()

            Me.RequestMarketEye()
        End If

    End Sub

    Private Sub RequestMarketEye()
        _index = 1
        Dim bOver200 As Boolean = False
        If _arrCode.Count > 200 Then
            bOver200 = True
        End If

        While _arrCode.Count > 0
            Dim toIndex As Integer = 0
            Dim arrTemp As ArrayList = New ArrayList

            If _arrCode.Count > 200 Then
                For i As Int32 = 0 To 199
                    arrTemp.Add(_arrCode.Item(i))
                Next
                toIndex = 200
            Else
                For i As Int32 = 0 To _arrCode.Count - 1
                    arrTemp.Add(_arrCode.Item(i))
                Next
                toIndex = _arrCode.Count
            End If

            _arrCode.RemoveRange(0, toIndex)

            Dim items() As Integer = {0, 1, 2, 3, 4, 5, 6, 7, 10, 11, 17}
            _marketEye.SetInputValue(0, items)

            Dim sCodes(0 To arrTemp.Count - 1) As String

            For i As Integer = 0 To arrTemp.Count - 1
                sCodes(i) = arrTemp.Item(i)
            Next i

            _marketEye.SetInputValue(1, sCodes)

            Dim resultMarketEye As Int32 = _marketEye.BlockRequest()

            LabelMsg1.Text = _marketEye.GetDibMsg1()

            If resultMarketEye = 0 Then
                For j As Integer = 0 To _marketEye.GetHeaderValue(2) - 1
                    Dim row As DataRow = _Table.NewRow
                    row("순번") = _index.ToString()
                    row("종목코드") = _marketEye.GetDataValue(0, j)
                    row("종목명") = _marketEye.GetDataValue(10, j)
                    row("시간") = TextBoxDateTime.Text
                    row("현재가") = _marketEye.GetDataValue(4, j)
                    row("전일대비") = _marketEye.GetDataValue(3, j)
                    row("시가") = _marketEye.GetDataValue(5, j)
                    row("고가") = _marketEye.GetDataValue(6, j)
                    row("저가") = _marketEye.GetDataValue(7, j)
                    row("거래량") = _marketEye.GetDataValue(8, j)

                    _Table.Rows.Add(row)
                    _index += 1
                Next

                For j As Integer = 0 To _Table.Rows.Count - 1
                    If _parent.GetRemainSB() > 0 And bOver200 = False Then
                        _stockCur.SetInputValue(0, _Table.Rows(j).Item("종목코드"))
                        _stockCur.Subscribe()
                    End If
                Next
            End If
        End While

        LabelMsg1.Text = "조회가 완료되었습니다."
        TextBoxCount.Text = _Table.Rows.Count.ToString()
        DataGridView1.Refresh()
    End Sub

    Private Sub Form6201_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Unsubscribe()
    End Sub

    Private Sub Unsubscribe()
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            _stockCur.SetInputValue(0, DataGridView1.Rows(i).Cells("종목코드").Value.ToString())
            _stockCur.Unsubscribe()
        Next
    End Sub

    Private Sub _stockCur_Received() Handles _stockCur.Received
        For i As Integer = 0 To _Table.Rows.Count - 1
            If _Table.Rows(i).Item(0) = _stockCur.GetHeaderValue(0) Then
                _Table.Rows(i).Item("현재가") = _stockCur.GetHeaderValue(13)
                _Table.Rows(i).Item("전일대비") = _stockCur.GetHeaderValue(2)
                _Table.Rows(i).Item("시간") = ClassUtil.ConvertToDateTime(_stockCur.GetHeaderValue(18))
                _Table.Rows(i).Item("고가") = _stockCur.GetHeaderValue(5)
                _Table.Rows(i).Item("저가") = _stockCur.GetHeaderValue(6)
                _Table.Rows(i).Item("거래량") = _stockCur.GetHeaderValue(9)

                DataGridView1.Refresh()
                Exit For
            End If
        Next i
    End Sub
End Class