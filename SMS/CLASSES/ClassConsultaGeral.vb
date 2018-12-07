Imports System.Data.SqlClient
Imports Microsoft.Office.Interop

Class ClassConsultaGeral
    Shared bs As BindingSource
    Private Shared ColunProduto, CoLunDescricao, ColunDataEntrada, ColunTipo, ColunQtdMovimento, ColunDataMovimento, ColunTipoMovimento, ColunTempoEstoque, ColunSaldoEstoque, ColunTempoSaldoEstoque As String

    Private Shared excelA As Excel.Application
    Private Shared Esheet As Excel.Worksheet

    Public Shared Sub CarregaGrid(Grid As DataGridView)

        'Aqui Carrega os Dados e envia para o Grid
        'e carrega no listbox

        Dim sql As String
        Dim da As SqlDataAdapter
        Dim dt As DataTable

        sql = ""
        sql = sql & vbCrLf & "SELECT T.ID,"
        sql = sql & vbCrLf & "       T.PRODUCT,"
        sql = sql & vbCrLf & "	   T.DESCRIPTION,"
        sql = sql & vbCrLf & "	   T.REFERENCE,"
        sql = sql & vbCrLf & "	   TBL_TYPE.TYPE,"
        sql = sql & vbCrLf & "	   T.CONSIGNEE,"
        sql = sql & vbCrLf & "	   T.DATE,"
        sql = sql & vbCrLf & "	   T.QUANTITY,"
        sql = sql & vbCrLf & "	   TBL_UQ.UQ,"
        sql = sql & vbCrLf & "	   T.PLT_SPACES,"
        sql = sql & vbCrLf & "	   TBL_LOCATION.LOCATION"
        sql = sql & vbCrLf & "FROM CSRDB T"
        sql = sql & vbCrLf & "LEFT JOIN TBL_TYPE ON"
        sql = sql & vbCrLf & "T.ID_TYPE = TBL_TYPE.ID"
        sql = sql & vbCrLf & "LEFT JOIN TBL_UQ ON"
        sql = sql & vbCrLf & "T.ID_UQ = TBL_UQ.ID"
        sql = sql & vbCrLf & "LEFT JOIN TBL_LOCATION ON"
        sql = sql & vbCrLf & "T.ID_LOCATION = TBL_LOCATION.ID"
        sql = sql & vbCrLf & "ORDER BY T.PRODUCT,"
        sql = sql & vbCrLf & "T.Date"

        da = New SqlDataAdapter(sql, conn)
        dt = New DataTable
        da.Fill(dt)

        bs = New BindingSource()
        bs.DataSource = dt
        Grid.DataSource = bs

    End Sub

    Public Shared Sub FiltrarDadosGrid(Coluna, Filtro)

        If Coluna = "" Then
            bs.Filter = ""
        Else

            Try
                bs.Filter = Coluna & " Like '%" & Filtro & "%'"
            Catch ex As Exception
                bs.Filter = Coluna & " = " & Filtro
            End Try
        End If


    End Sub

    Public Shared Sub HabilitarCampos()

        FormConsultaBase.txtProduct.Enabled = True
        FormConsultaBase.txtDescription.Enabled = True
        FormConsultaBase.txtReference.Enabled = True
        FormConsultaBase.ComboBoxType.Enabled = True
        FormConsultaBase.txtConsignee.Enabled = True
        FormConsultaBase.txtQuantity.Enabled = True
        FormConsultaBase.ComboBoxUq.Enabled = True
        FormConsultaBase.txtPLT_Spaces.Enabled = True
        FormConsultaBase.ComboBoxLocation.Enabled = True

    End Sub

    Public Shared Sub DesabilitarCampos()

        FormConsultaBase.txtProduct.Enabled = False
        FormConsultaBase.txtDescription.Enabled = False
        FormConsultaBase.txtReference.Enabled = False
        FormConsultaBase.ComboBoxType.Enabled = False
        FormConsultaBase.txtConsignee.Enabled = False
        FormConsultaBase.txtQuantity.Enabled = False
        FormConsultaBase.ComboBoxUq.Enabled = False
        FormConsultaBase.txtPLT_Spaces.Enabled = False
        FormConsultaBase.ComboBoxLocation.Enabled = False

    End Sub

    Public Shared Sub CarregaCampoFiltro(Grid As DataGridView, Campo As ComboBox)

        Dim Dt As New DataTable

        Dt.Columns.Add("ID")
        Dt.Columns.Add("DESCRICAO")

        For Each Colunns As DataGridViewColumn In Grid.Columns
            If Colunns.Name.ToUpper <> "ID" Then
                Dt.Rows.Add(Colunns.Name, Colunns.HeaderText)
            End If
        Next

        Campo.DataSource = Dt
        Campo.DisplayMember = "DESCRICAO"
        Campo.ValueMember = "ID"

    End Sub

    Public Shared Sub GerarExcelValidaEstoque(DataCorte As Date, LabelStatus As Label, Barra As ProgressBar)

        Dim dt, DtItens, DtItensEntrada As DataTable
        Dim Da As SqlDataAdapter
        Dim LinhaNivel1, LinhaNivel2, LinhaNivel3 As Long
        Dim MaxRegistros As Long

        LinhaNivel1 = 7
        LinhaNivel2 = 0
        LinhaNivel3 = 0

        ColunProduto = "A"
        CoLunDescricao = "B"
        ColunTipoMovimento = "C"
        ColunQtdMovimento = "D"
        ColunDataMovimento = "E"
        ColunTempoEstoque = "F"
        ColunSaldoEstoque = "G"
        ColunTempoSaldoEstoque = "H"

        excelA = New Excel.Application
        'excelA.Visible = True
        excelA.Workbooks.Add()

        excelA.Application.Calculation = Excel.XlCalculation.xlCalculationManual

        If excelA.Worksheets.Count = 1 Then

            Esheet = excelA.Worksheets(1)
            Esheet.Name = "Novo Relatório"

        Else

            Esheet = excelA.Worksheets(3)
            Esheet.Delete()
            Esheet = excelA.Worksheets(2)
            Esheet.Delete()
            Esheet = excelA.Worksheets(1)
            Esheet.Name = "Novo Relatório"

        End If

        Da = New SqlDataAdapter(ConsultaExcelValidaEstoque(DataCorte), conn)
        dt = New DataTable
        Da.Fill(dt)

        Dim Dtv As DataView = dt.DefaultView

        PreparaCabecalho(DataCorte)

        DtItens = Dtv.ToTable(True, "PRODUCT", "DESCRIPTION")
        DtItensEntrada = Dtv.ToTable(True, "PRODUCT", "DESCRIPTION", "ID", "TYPE_ENTRADA", "QUANTITY_ENTRADA", "DATA_ENTRADA")
        Esheet.Outline.SummaryRow = Excel.XlSummaryRow.xlSummaryAbove

        MaxRegistros = dt.Rows.Count

        Barra.Maximum = MaxRegistros

        LabelStatus.Text = ""
        LabelStatus.Visible = True
        LabelStatus.Text = "Exportando Linha " & Barra.Value & " de " & MaxRegistros

        Application.DoEvents()

        For Each DrItens As DataRow In DtItens.Select("", "PRODUCT ASC")

            LinhaNivel2 = LinhaNivel1 + 1

            Esheet.Range(ColunProduto & LinhaNivel1).Value2 = DrItens("PRODUCT")
            Esheet.Range(CoLunDescricao & LinhaNivel1).Value2 = DrItens("DESCRIPTION")

            Esheet.Range(ColunProduto & LinhaNivel1 & ":" & ColunTempoSaldoEstoque & LinhaNivel1).Interior.Color = RGB(197, 190, 151)

            Barra.Increment(+1)

            LabelStatus.Text = "Exportando Linha " & Barra.Value & " de " & MaxRegistros

            Application.DoEvents()

            For Each DrItensEntrada As DataRow In DtItensEntrada.Select("PRODUCT = " & DrItens("PRODUCT"), "PRODUCT, DATA_ENTRADA, ID  ASC")

                Esheet.Range(ColunProduto & LinhaNivel2).Value2 = DrItensEntrada("PRODUCT")
                Esheet.Range(CoLunDescricao & LinhaNivel2).Value2 = DrItensEntrada("DESCRIPTION")
                Esheet.Range(ColunTipoMovimento & LinhaNivel2).Value2 = DrItensEntrada("TYPE_ENTRADA")
                Esheet.Range(ColunQtdMovimento & LinhaNivel2).Value2 = DrItensEntrada("QUANTITY_ENTRADA")
                Esheet.Range(ColunDataMovimento & LinhaNivel2).Value2 = CDate(DrItensEntrada("DATA_ENTRADA"))

                Esheet.Range(ColunProduto & LinhaNivel2 & ":" & ColunTempoSaldoEstoque & LinhaNivel2).Interior.Color = RGB(165, 165, 165)

                LinhaNivel2 = LinhaNivel2 + 1
                LinhaNivel3 = LinhaNivel2

                Barra.Increment(+1)

                LabelStatus.Text = "Exportando Linha " & Barra.Value & " de " & MaxRegistros

                Application.DoEvents()

                For Each DrItensMovi As DataRow In dt.Select("ID = " & DrItensEntrada("ID"), "DATA_SAIDA ASC")

                    If DrItensMovi("TYPE_SAIDA").ToString = "" Then

                        Esheet.Range(ColunProduto & LinhaNivel3).Value2 = DrItensMovi("PRODUCT")
                        Esheet.Range(CoLunDescricao & LinhaNivel3).Value2 = DrItensMovi("DESCRIPTION")
                        'Esheet.Range(ColunTipoMovimento & LinhaNivel3).Value2 = DrItensMovi("TYPE_SAIDA")
                        'Esheet.Range(ColunQtdMovimento & LinhaNivel3).Value2 = DrItensMovi("QUANTITY_SAIDA")
                        'Esheet.Range(ColunDataMovimento & LinhaNivel3).Value2 = CDate(DrItensMovi("DATA_SAIDA"))
                        'Esheet.Range(ColunTempoEstoque & LinhaNivel3).Value2 = DrItensMovi("DIF_SEMANA2")

                    Else

                        Esheet.Range(ColunProduto & LinhaNivel3).Value2 = DrItensMovi("PRODUCT")
                        Esheet.Range(CoLunDescricao & LinhaNivel3).Value2 = DrItensMovi("DESCRIPTION")
                        Esheet.Range(ColunTipoMovimento & LinhaNivel3).Value2 = DrItensMovi("TYPE_SAIDA")
                        Esheet.Range(ColunQtdMovimento & LinhaNivel3).Value2 = DrItensMovi("QUANTITY_SAIDA")
                        Esheet.Range(ColunDataMovimento & LinhaNivel3).Value2 = CDate(DrItensMovi("DATA_SAIDA"))
                        Esheet.Range(ColunTempoEstoque & LinhaNivel3).Value2 = DrItensMovi("DIF_SEMANA2")

                    End If



                    If Esheet.Range(ColunTempoEstoque & LinhaNivel3 - 1).Interior.Color = RGB(165, 165, 165) Then

                        Esheet.Range(ColunSaldoEstoque & LinhaNivel3).Value2 = "=" & ColunQtdMovimento & LinhaNivel3 - 1 & "+" & ColunQtdMovimento & LinhaNivel3

                    Else

                        Esheet.Range(ColunSaldoEstoque & LinhaNivel3).Value2 = "=" & ColunSaldoEstoque & LinhaNivel3 - 1 & "+" & ColunQtdMovimento & LinhaNivel3

                    End If

                    LinhaNivel3 = LinhaNivel3 + 1

                    Barra.Increment(+1)

                    LabelStatus.Text = "Exportando Linha " & Barra.Value & " de " & MaxRegistros

                    Application.DoEvents()

                Next


                Esheet.Range(ColunTempoEstoque & LinhaNivel2 - 1).Formula = "=IFERROR(ROUNDUP(SUMIF(" & ColunTipoMovimento & LinhaNivel2 & ":" & ColunTipoMovimento & LinhaNivel3 - 1 & ",""ORD""," & ColunTempoEstoque & LinhaNivel2 & ":" & ColunTempoEstoque & LinhaNivel3 - 1 & ")/COUNTIF(" & ColunTipoMovimento & LinhaNivel2 & ":" & ColunTipoMovimento & LinhaNivel3 - 1 & ",""ORD""),0),0)"

                Esheet.Range(ColunTempoSaldoEstoque & LinhaNivel2 - 1).Formula = "=IF(" & ColunSaldoEstoque & LinhaNivel2 - 1 & ">0,ROUNDUP(((TODAY()-" & ColunDataMovimento & LinhaNivel2 - 1 & ")/7),0),0)"

                Esheet.Range(ColunSaldoEstoque & LinhaNivel2 - 1).Formula = "=SUBTOTAL(9," & ColunQtdMovimento & LinhaNivel2 - 1 & ":" & ColunQtdMovimento & LinhaNivel3 - 1 & ")"

                Esheet.Range(ColunProduto & LinhaNivel2 & ":" & ColunProduto & LinhaNivel3 - 1).Rows.Group()

                LinhaNivel2 = LinhaNivel3

            Next


            Esheet.Range(ColunTempoEstoque & LinhaNivel1).Formula = "=IFERROR(ROUNDUP(SUMIF(" & ColunTipoMovimento & LinhaNivel1 + 1 & ":" & ColunTipoMovimento & LinhaNivel3 - 1 & ",""ORD""," & ColunTempoEstoque & LinhaNivel1 + 1 & ":" & ColunTempoEstoque & LinhaNivel3 - 1 & ")/COUNTIF(" & ColunTipoMovimento & LinhaNivel1 + 1 & ":" & ColunTipoMovimento & LinhaNivel3 - 1 & ",""ORD""),0),0)"

            Esheet.Range(ColunSaldoEstoque & LinhaNivel1).Formula = "=SUMIF(" & ColunTipoMovimento & LinhaNivel1 + 1 & ":" & ColunTipoMovimento & LinhaNivel3 - 1 & ",""INW""," & ColunSaldoEstoque & LinhaNivel1 + 1 & ":" & ColunSaldoEstoque & LinhaNivel3 - 1 & ")"

            Esheet.Range(ColunTempoSaldoEstoque & LinhaNivel1).Formula = "=IFERROR(ROUNDUP(SUMIF(" & ColunTipoMovimento & LinhaNivel1 + 1 & ":" & ColunTipoMovimento & LinhaNivel3 - 1 & ",""INW""," & ColunTempoSaldoEstoque & LinhaNivel1 + 1 & ":" & ColunTempoSaldoEstoque & LinhaNivel3 - 1 & ")/COUNTIFS(" & ColunTipoMovimento & LinhaNivel1 + 1 & ":" & ColunTipoMovimento & LinhaNivel3 - 1 & ",""INW""," & ColunTempoSaldoEstoque & LinhaNivel1 + 1 & ":" & ColunTempoSaldoEstoque & LinhaNivel3 - 1 & ","">0""),0),0)"

            Esheet.Range(ColunProduto & LinhaNivel1 + 1 & ":" & ColunProduto & LinhaNivel3 - 1).Rows.Group()

            LinhaNivel1 = LinhaNivel3

        Next

        Esheet.Range(ColunTempoEstoque & 6).Formula = "=IFERROR(ROUNDUP(SUMIF(" & ColunTipoMovimento & 6 + 1 & ":" & ColunTipoMovimento & LinhaNivel3 - 1 & ",""ORD""," & ColunTempoEstoque & 6 + 1 & ":" & ColunTempoEstoque & LinhaNivel3 - 1 & ")/COUNTIF(" & ColunTipoMovimento & 6 + 1 & ":" & ColunTipoMovimento & LinhaNivel3 - 1 & ",""ORD""),0),0)"

        Esheet.Range(ColunTempoSaldoEstoque & 6).Formula = "=IFERROR(ROUNDUP(SUMIF(" & ColunTipoMovimento & 6 + 1 & ":" & ColunTipoMovimento & LinhaNivel3 - 1 & ",""INW""," & ColunTempoSaldoEstoque & 6 + 1 & ":" & ColunTempoSaldoEstoque & LinhaNivel3 - 1 & ")/COUNTIFS(" & ColunTipoMovimento & 6 + 1 & ":" & ColunTipoMovimento & LinhaNivel3 - 1 & ",""INW""," & ColunTempoSaldoEstoque & 6 + 1 & ":" & ColunTempoSaldoEstoque & LinhaNivel3 - 1 & ","">0""),0),0)"

        excelA.Application.Calculation = Excel.XlCalculation.xlCalculationAutomatic

        Esheet.Shapes.AddPicture(CaminhoBase() & "\IMAGENS\Logo Geral.png", Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, 18.054409, 40.10866, 129.821182, 33.54).Name = "Logo1"

        excelA.Visible = True


    End Sub

    Private Shared Sub PreparaCabecalho(DataCorte As Date)

        Dim Linha As Long

        Linha = 1

        Esheet.Range(ColunProduto & Linha & ":" & ColunTempoSaldoEstoque & Linha).Merge()
        Esheet.Range(ColunProduto & Linha & ":" & ColunTempoSaldoEstoque & Linha).Font.Bold = True
        Esheet.Range(ColunProduto & Linha & ":" & ColunTempoSaldoEstoque & Linha).Font.Size = 18
        Esheet.Range(ColunProduto & Linha & ":" & ColunTempoSaldoEstoque & Linha).HorizontalAlignment = 3
        Esheet.Range(ColunProduto & Linha & ":" & ColunTempoSaldoEstoque & Linha).VerticalAlignment = 2
        Esheet.Range(ColunProduto & Linha & ":" & ColunTempoSaldoEstoque & Linha).Interior.Color = RGB(216, 216, 216)
        Esheet.Range(ColunProduto & Linha & ":" & ColunTempoSaldoEstoque & Linha).Value2 = "Analysis Report and Weekly Averages Adjustment"
        Esheet.Range(ColunProduto & Linha & ":" & ColunTempoSaldoEstoque & Linha).RowHeight = 114

        Linha = Linha + 1

        Esheet.Range(ColunProduto & Linha & ":" & CoLunDescricao & Linha).Merge()
        Esheet.Range(ColunProduto & Linha & ":" & CoLunDescricao & Linha).Font.Bold = True
        Esheet.Range(ColunProduto & Linha & ":" & CoLunDescricao & Linha).Font.Size = 11
        Esheet.Range(ColunProduto & Linha & ":" & ColunTempoSaldoEstoque & Linha).Interior.Color = RGB(191, 191, 191)
        Esheet.Range(ColunProduto & Linha & ":" & CoLunDescricao & Linha).Value2 = "Update Date"
        Esheet.Range(ColunTipoMovimento & Linha).NumberFormat = "m/d/yyyy"
        Esheet.Range(ColunTipoMovimento & Linha).Value2 = DataCorte


        Linha = Linha + 1

        Esheet.Range(ColunProduto & Linha & ":" & CoLunDescricao & Linha).Merge()
        Esheet.Range(ColunProduto & Linha & ":" & CoLunDescricao & Linha).Font.Bold = True
        Esheet.Range(ColunProduto & Linha & ":" & CoLunDescricao & Linha).Font.Size = 11
        Esheet.Range(ColunProduto & Linha & ":" & ColunTempoSaldoEstoque & Linha).Interior.Color = RGB(191, 191, 191)
        Esheet.Range(ColunProduto & Linha & ":" & CoLunDescricao & Linha).Value2 = "Current Average Stock Holding"
        Esheet.Range(ColunTipoMovimento & Linha).Value2 = "15"

        Linha = Linha + 1

        Esheet.Range(ColunProduto & Linha & ":" & CoLunDescricao & Linha).Merge()
        Esheet.Range(ColunProduto & Linha & ":" & CoLunDescricao & Linha).Font.Bold = True
        Esheet.Range(ColunProduto & Linha & ":" & CoLunDescricao & Linha).Font.Size = 11
        Esheet.Range(ColunProduto & Linha & ":" & ColunTempoSaldoEstoque & Linha).Interior.Color = RGB(191, 191, 191)
        Esheet.Range(ColunProduto & Linha & ":" & CoLunDescricao & Linha).Value2 = "New Average Stock Holding"
        Esheet.Range(ColunTipoMovimento & Linha).Value2 = "=ROUNDUP((C3+F6+H6)/3,0)"


        Linha = 5

        Esheet.Range(ColunProduto & Linha).Value2 = "Product"
        Esheet.Range(ColunProduto & Linha).ColumnWidth = 14

        Esheet.Range(CoLunDescricao & Linha).Value2 = "Description"
        Esheet.Range(CoLunDescricao & Linha).ColumnWidth = 42

        Esheet.Range(ColunTipoMovimento & Linha).Value2 = "Movement Type"
        Esheet.Range(ColunTipoMovimento & Linha).ColumnWidth = 18

        Esheet.Range(ColunQtdMovimento & Linha).Value2 = "Quantity"
        Esheet.Range(ColunDataMovimento & Linha).Value2 = "Movement Date"
        Esheet.Range(ColunDataMovimento & ":" & ColunDataMovimento).NumberFormat = "m/d/yyyy"

        Esheet.Range(ColunTempoEstoque & Linha).Value2 = "Time in Stock"
        Esheet.Range(ColunSaldoEstoque & Linha).Value2 = "Stock Balance"
        Esheet.Range(ColunTempoSaldoEstoque & Linha).Value2 = "Stock Balance Time in Weeks"

        Esheet.Range(ColunQtdMovimento & Linha & ":" & ColunTempoSaldoEstoque & Linha).ColumnWidth = 18

        Esheet.Range(ColunProduto & Linha & ":" & ColunTempoSaldoEstoque & Linha).Font.Bold = True
        Esheet.Range(ColunProduto & Linha & ":" & ColunTempoSaldoEstoque & Linha).Font.Size = 12
        Esheet.Range(ColunProduto & Linha & ":" & ColunTempoSaldoEstoque & Linha).HorizontalAlignment = 3
        Esheet.Range(ColunProduto & Linha & ":" & ColunTempoSaldoEstoque & Linha).VerticalAlignment = 2

        Esheet.Range(ColunProduto & Linha & ":" & ColunTempoSaldoEstoque & Linha).WrapText = True
        Esheet.Range(ColunProduto & Linha & ":" & ColunTempoSaldoEstoque & Linha).Interior.Color = RGB(184, 204, 228)
        Esheet.Range(ColunProduto & Linha & ":" & ColunTempoSaldoEstoque & Linha).RowHeight = 42

        Linha = Linha + 1
        Esheet.Range(ColunProduto & Linha & ":" & ColunTempoSaldoEstoque & Linha).Interior.Color = RGB(147, 205, 221)

    End Sub


    Private Shared Function ConsultaExcelValidaEstoque(DataCorte As Date)

        Dim sql As String

        sql = ""
        sql = sql & vbCrLf & "SELECT ENTRADAS.ID,"
        sql = sql & vbCrLf & "       ENTRADAS.PRODUCT,"
        sql = sql & vbCrLf & "       ENTRADAS.DESCRIPTION,"
        sql = sql & vbCrLf & "	   ISNULL(ENTRADAS.Date,'') AS DATA_ENTRADA,"
        sql = sql & vbCrLf & "	   ENTRADAS.QUANTITY AS QUANTITY_ENTRADA,"
        sql = sql & vbCrLf & "	   ENTRADAS.TYPE As TYPE_ENTRADA,"
        sql = sql & vbCrLf & "	   MOVIMENTOS.QUANTITY AS QUANTITY_SAIDA,"
        sql = sql & vbCrLf & "	   ISNULL(MOVIMENTOS.Date,'') AS DATA_SAIDA,"
        sql = sql & vbCrLf & "	   MOVIMENTOS.TYPE AS TYPE_SAIDA,"
        sql = sql & vbCrLf & "	   DATEDIFF(DAY,ENTRADAS.Date,MOVIMENTOS.Date) As DIAS,"
        sql = sql & vbCrLf & "	   (CAST(DATEDIFF(DAY,ENTRADAS.DATE,MOVIMENTOS.DATE) AS DECIMAL)/7) AS DIF_SEMANA,"
        sql = sql & vbCrLf & "	   CEILING((CAST(DATEDIFF(DAY,ENTRADAS.Date,MOVIMENTOS.Date) As Decimal)/7)) As DIF_SEMANA2"
        sql = sql & vbCrLf & ""
        sql = sql & vbCrLf & "FROM CSRDB ENTRADAS"
        sql = sql & vbCrLf & "LEFT JOIN CSRDB MOVIMENTOS ON"
        sql = sql & vbCrLf & "     MOVIMENTOS.ID_LIGACAO = ENTRADAS.ID"
        sql = sql & vbCrLf & " AND FORMAT(MOVIMENTOS.Date,'yyyy/MM/dd') <= '" & Format(DataCorte, "yyyy/MM/dd") & "'"
        sql = sql & vbCrLf & ""
        sql = sql & vbCrLf & "WHERE ENTRADAS.TYPE = 'INW'"
        sql = sql & vbCrLf & " AND Format(ENTRADAS.DATE,'yyyy/MM/dd') <= '" & Format(DataCorte, "yyyy/MM/dd") & "'"
        sql = sql & vbCrLf & ""
        sql = sql & vbCrLf & "ORDER BY ENTRADAS.PRODUCT,"
        sql = sql & vbCrLf & "         ENTRADAS.DATE,"
        sql = sql & vbCrLf & "		   MOVIMENTOS.Date"


        Return sql

    End Function

    Public Shared Sub CarregaType(Combo As ComboBox)

        Dim sql As String
        Dim da As SqlDataAdapter
        Dim dt As DataTable

        sql = ""
        sql = sql & vbCrLf & "SELECT T.ID,"
        sql = sql & vbCrLf & "       T.TYPE,"
        sql = sql & vbCrLf & "	   T.DESCRIPTION"
        sql = sql & vbCrLf & "FROM TBL_TYPE T"

        da = New SqlDataAdapter(sql, conn)
        dt = New DataTable
        da.Fill(dt)
        Combo.DataSource = dt
        Combo.DisplayMember = "TYPE"
        Combo.ValueMember = "ID"

    End Sub

    Public Shared Sub CarregaUq(Combo As ComboBox)

        Dim sql As String
        Dim da As SqlDataAdapter
        Dim dt As DataTable

        sql = ""
        sql = sql & vbCrLf & "SELECT T.ID,"
        sql = sql & vbCrLf & "       T.UQ,"
        sql = sql & vbCrLf & "	     T.DESCRIPTION"
        sql = sql & vbCrLf & "FROM TBL_UQ T"

        da = New SqlDataAdapter(sql, conn)
        dt = New DataTable
        da.Fill(dt)

        Combo.DataSource = dt
        Combo.DisplayMember = "UQ"
        Combo.ValueMember = "ID"

    End Sub

    Public Shared Sub CarregaLocation(Combo As ComboBox)

        Dim sql As String
        Dim da As SqlDataAdapter
        Dim dt As DataTable

        sql = ""
        sql = sql & vbCrLf & "SELECT T.ID,"
        sql = sql & vbCrLf & "       T.LOCATION,"
        sql = sql & vbCrLf & "	     T.DESCRIPTION"
        sql = sql & vbCrLf & "FROM TBL_LOCATION T"

        da = New SqlDataAdapter(sql, conn)
        dt = New DataTable
        da.Fill(dt)

        Combo.DataSource = dt
        Combo.DisplayMember = "LOCATION"
        Combo.ValueMember = "ID"

    End Sub

End Class
