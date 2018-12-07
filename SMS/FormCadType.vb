Imports SMS.ClassCadastroType
Public Class FormCadType
    Private Sub F2AperteParaAbilitarAEdiçãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles F2AperteParaAbilitarAEdiçãoToolStripMenuItem.Click
        AbilitaDesabiliraEdit(DataGridViewType, F2AperteParaAbilitarAEdiçãoToolStripMenuItem)
    End Sub

    Private Sub DataGridViewType_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewType.CellEndEdit

        If DataGridViewType.CurrentRow.Cells("ColumnID").Value Is Nothing Or DataGridViewType.CurrentRow.Cells("ColumnID").Value.ToString = "" Then
            NovoType(DataGridViewType.CurrentRow)
        Else
            UpdateType(DataGridViewType.CurrentRow)
        End If

    End Sub

    Private Sub FormCadType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregaGrid(DataGridViewType)
    End Sub

    Private Sub DataGridViewType_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles DataGridViewType.UserDeletingRow

        DeteleType(DataGridViewType.CurrentRow)

    End Sub

    Private Sub ExportarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportarToolStripMenuItem.Click
        ExportPlanSimples(ProgressBar, LabelStatus,, DataGridViewType)
    End Sub
End Class