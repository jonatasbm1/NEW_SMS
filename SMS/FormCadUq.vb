Imports SMS.ClassCadastroUq
Public Class FormCadUq
    Private Sub F2AperteParaAbilitarAEdiçãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles F2AperteParaAbilitarAEdiçãoToolStripMenuItem.Click
        AbilitaDesabiliraEdit(DataGridViewUq, F2AperteParaAbilitarAEdiçãoToolStripMenuItem)
    End Sub

    Private Sub DataGridViewType_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewUq.CellEndEdit

        If DataGridViewUq.CurrentRow.Cells("ColumnID").Value Is Nothing Or DataGridViewUq.CurrentRow.Cells("ColumnID").Value.ToString = "" Then
            NovoType(DataGridViewUq.CurrentRow)
        Else
            UpdateType(DataGridViewUq.CurrentRow)
        End If

    End Sub

    Private Sub FormCadType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregaGrid(DataGridViewUq)
    End Sub

    Private Sub DataGridViewType_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles DataGridViewUq.UserDeletingRow

        DeteleType(DataGridViewUq.CurrentRow)

    End Sub

    Private Sub ExportarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportarToolStripMenuItem.Click
        ExportPlanSimples(ProgressBar, LabelStatus,, DataGridViewUq)
    End Sub
End Class