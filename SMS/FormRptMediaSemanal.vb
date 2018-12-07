Imports SMS.ClassConsultaGeral
Public Class FormRptMediaSemanal
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonGerar.Click

        Me.Cursor = Cursors.WaitCursor
        GerarExcelValidaEstoque(MonthCalendarCorte.SelectionStart.Date, LabelExportStatus, PbExportTempMedio)
        Me.Cursor = Cursors.Default

        PbExportTempMedio.Value = 0
        LabelExportStatus.Text = ""

        MsgBox("Concluido")

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        Ligar_Filhos()
    End Sub
End Class