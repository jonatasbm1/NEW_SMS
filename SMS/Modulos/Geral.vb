Imports Microsoft.Office.Interop
Module Geral

    Public Function CaminhoBase()

        Dim Caminho As String
        Caminho = Application.StartupPath
        Caminho = Replace(Caminho, "\bin\Debug", "")
        Caminho = Replace(Caminho, "\bin\Release", "")
        Return Caminho

    End Function

    Public Sub ExportPlanSimples(ByVal barra1 As ProgressBar, ByVal LabelLinha As Object, Optional ByVal Dados1 As DataTable = Nothing, Optional ByVal Dados2 As DataGridView = Nothing)

        Dim Esheet As Excel.Worksheet
        Dim excelA As Excel.Application

        LabelLinha.Text = "Preparando Dados...."
        LabelLinha.Visible = True
        System.Windows.Forms.Application.DoEvents()


        excelA = New Excel.Application
        excelA.Workbooks.Add()

        excelA.Application.Calculation = Excel.XlCalculation.xlCalculationManual
        excelA.DisplayAlerts = False
        excelA.ScreenUpdating = False

        Try

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


        Catch ex As Exception

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

        End Try

        If Dados1 Is Nothing Then
            EnvioDadosPlanilhaSimplesB(Dados2, excelA, Esheet, barra1, LabelLinha)
        Else
            EnvioDadosPlanilhaSimplesA(Dados1, excelA, Esheet, barra1, LabelLinha)
        End If

        excelA.Application.Calculation = Excel.XlCalculation.xlCalculationAutomatic
        excelA.ScreenUpdating = True
        excelA.DisplayAlerts = True
        excelA.Visible = True

        LabelLinha.Text = "Status"

    End Sub

    Private Sub EnvioDadosPlanilhaSimplesA(ByVal Dados As DataTable, ByVal excelA As Excel.Application, ByVal Esheet As Excel.Worksheet, ByVal Barra2 As ProgressBar, ByVal LabelLinha As Label)

        Dim ColunaInicial As String
        Dim Linha, LinhaExel As Long


        ColunaInicial = "A"

        Linha = 0
        LinhaExel = 1

        LabelLinha.Text = "Exportando Linha"
        LabelLinha.Visible = True
        Barra2.Maximum = Dados.Rows.Count

        For i = 0 To Dados.Columns.Count - 1

            Esheet.Range(ColunaInicial & LinhaExel).Offset(Linha, i).Value = Dados.Columns(i).ColumnName

        Next

        Linha = Linha + 1

        For Each dt As DataRow In Dados.Rows

            For i = 0 To Dados.Columns.Count - 1

                Esheet.Range(ColunaInicial & LinhaExel).Offset(Linha, i).Value = dt(i)

            Next

            LabelLinha.Text = "Exportando Linha " & Linha
            Barra2.Increment(1)
            System.Windows.Forms.Application.DoEvents()

            Linha = Linha + 1

        Next

    End Sub

    Private Sub EnvioDadosPlanilhaSimplesB(ByVal Dados As DataGridView, ByVal excelA As Excel.Application, ByVal Esheet As Excel.Worksheet, ByVal Barra2 As ProgressBar, ByVal LabelLinha As Label)

        Dim ColunaInicial As String
        Dim Linha, LinhaExel As Long


        ColunaInicial = "A"

        Linha = 0
        LinhaExel = 1

        LabelLinha.Text = "Exportando Linha"
        LabelLinha.Visible = True
        Barra2.Maximum = Dados.Rows.Count

        For i = 0 To Dados.Columns.Count - 1

            Esheet.Range(ColunaInicial & LinhaExel).Offset(Linha, i).Value = Dados.Columns(i).HeaderText

        Next

        Linha = Linha + 1

        For Each dt As DataGridViewRow In Dados.Rows

            For i = 0 To Dados.Columns.Count - 1

                Esheet.Range(ColunaInicial & LinhaExel).Offset(Linha, i).Value = dt.Cells(i).Value

            Next

            LabelLinha.Text = "Exportando Linha " & Linha
            Barra2.Increment(1)
            System.Windows.Forms.Application.DoEvents()

            Linha = Linha + 1

        Next

    End Sub

    Public Function RetornaValor(ByVal Valor)

        If Valor Is DBNull.Value Then
            Return ""
        ElseIf Valor Is Nothing Then
            Return ""
        Else
            Return Valor
        End If

    End Function

    Public Function RetornaValorNumero(ByVal Valor)

        If Valor Is DBNull.Value Then
            Return Nothing
        ElseIf Valor Is Nothing Then
            Return Nothing
        Else
            Return Valor
        End If

    End Function

    Public Sub BordasExcel(ByVal Esheet As Excel.Worksheet, ByVal Coluna_inicial As String, ByVal Coluna_final As String, ByVal Linha_Inicial As Long,
                           ByVal Linha_final As Long, ByVal Tipo_Borda_Externa As String, ByVal Tamanho_Borda_Externa As Long, ByVal Tipo_Borda_Interna As String,
                           ByVal Tamanho_Borda_Interna As Long, ByVal Tera_Bordas_externas As String, ByVal Tera_Bordas_Internas As String)

        If Tera_Bordas_externas = "SIM" Then
            Esheet.Range(Coluna_inicial & Linha_Inicial & ":" & Coluna_final & Linha_final).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Tipo_Borda_Externa
            Esheet.Range(Coluna_inicial & Linha_Inicial & ":" & Coluna_final & Linha_final).Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = Tamanho_Borda_Externa
            Esheet.Range(Coluna_inicial & Linha_Inicial & ":" & Coluna_final & Linha_final).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Tipo_Borda_Externa
            Esheet.Range(Coluna_inicial & Linha_Inicial & ":" & Coluna_final & Linha_final).Borders(Excel.XlBordersIndex.xlEdgeRight).Weight = Tamanho_Borda_Externa
            Esheet.Range(Coluna_inicial & Linha_Inicial & ":" & Coluna_final & Linha_final).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Tipo_Borda_Externa
            Esheet.Range(Coluna_inicial & Linha_Inicial & ":" & Coluna_final & Linha_final).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Tamanho_Borda_Externa
            Esheet.Range(Coluna_inicial & Linha_Inicial & ":" & Coluna_final & Linha_final).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Tipo_Borda_Externa
            Esheet.Range(Coluna_inicial & Linha_Inicial & ":" & Coluna_final & Linha_final).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = Tamanho_Borda_Externa
        End If
        If Tera_Bordas_Internas = "SIM" Then
            Esheet.Range(Coluna_inicial & Linha_Inicial & ":" & Coluna_final & Linha_final).Borders(Excel.XlBordersIndex.xlInsideVertical).LineStyle = Tipo_Borda_Interna
            Esheet.Range(Coluna_inicial & Linha_Inicial & ":" & Coluna_final & Linha_final).Borders(Excel.XlBordersIndex.xlInsideVertical).Weight = Tamanho_Borda_Interna
            Esheet.Range(Coluna_inicial & Linha_Inicial & ":" & Coluna_final & Linha_final).Borders(Excel.XlBordersIndex.xlInsideHorizontal).LineStyle = Tipo_Borda_Interna
            Esheet.Range(Coluna_inicial & Linha_Inicial & ":" & Coluna_final & Linha_final).Borders(Excel.XlBordersIndex.xlInsideHorizontal).Weight = Tamanho_Borda_Interna
        End If

    End Sub

End Module
