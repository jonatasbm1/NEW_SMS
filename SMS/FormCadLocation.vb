Imports SMS.ClassFormCadLocation
Public Class FormCadLocation
    Private Sub F2AperteParaAbilitarAEdiçãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles F2AperteParaAbilitarAEdiçãoToolStripMenuItem.Click
        AbilitaDesabiliraEdit(DataGridViewLocation, F2AperteParaAbilitarAEdiçãoToolStripMenuItem)
    End Sub

    Private Sub DataGridViewType_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewLocation.CellEndEdit

        If DataGridViewLocation.CurrentRow.Cells("ColumnID").Value Is Nothing Or DataGridViewLocation.CurrentRow.Cells("ColumnID").Value.ToString = "" Then
            NovoType(DataGridViewLocation.CurrentRow)
        Else
            UpdateType(DataGridViewLocation.CurrentRow)
        End If

    End Sub

    Private Sub FormCadType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregaGrid(DataGridViewLocation)
    End Sub

    Private Sub DataGridViewType_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles DataGridViewLocation.UserDeletingRow

        DeteleType(DataGridViewLocation.CurrentRow)

    End Sub

    Private Sub ExportarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportarToolStripMenuItem.Click
        ExportPlanSimples(ProgressBar, LabelStatus,, DataGridViewLocation)
    End Sub


End Class