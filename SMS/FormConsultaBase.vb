
Imports SMS.ClassConsultaGeral
Public Class FormConsultaBase
    Private Sub FormConsultaBase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.WaitCursor
        CarregaGrid(GridConsulta)
        CarregaCampoFiltro(GridConsulta, ComboBoxCampoFiltro)
        CarregaType(ComboBoxType)
        CarregaUq(ComboBoxUq)
        CarregaLocation(ComboBoxLocation)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub FiltrarCrtFToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FiltrarCrtFToolStripMenuItem.Click

        Dim ValorFiltro As String

        ValorFiltro = ""
        ValorFiltro = InputBox("Please enter the desired filter.")

        If ValorFiltro <> "" Then
            FiltrarDadosGrid(GridConsulta.Columns(GridConsulta.CurrentCell.ColumnIndex).Name, ValorFiltro)
        Else
            FiltrarDadosGrid("", "")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

        Ligar_Filhos()

    End Sub

End Class
