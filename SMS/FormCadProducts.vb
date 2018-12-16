Imports SMS.ClassFormCadProducts
Public Class FormCadProducts
    Private Sub F2AperteParaAbilitarAEdiçãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles F2AperteParaAbilitarAEdiçãoToolStripMenuItem.Click
        AbilitaDesabiliraEdit(DataGridViewProdutos, F2AperteParaAbilitarAEdiçãoToolStripMenuItem)
    End Sub

    Private Sub DataGridViewProdutos_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewProdutos.CellEndEdit

        If DataGridViewProdutos.CurrentRow.Cells("ColumnProduto").Value Is Nothing Then

        ElseIf DataGridViewProdutos.CurrentRow.Cells("ColumnProduto").Value.ToString = "" Then

        Else
            'Vericar Item Duplicado ("Mesmo Nome")

            If VerificaDuplicado(DataGridViewProdutos, DataGridViewProdutos.CurrentRow.Cells("ColumnProduto").Value, ComboBoxCliente.SelectedValue) = True Then

                MsgBox("Atenção já existe um produto com o mesmo Nome !", MsgBoxStyle.Exclamation, "Item Duplicado")
                Exit Sub

            Else

                If DataGridViewProdutos.CurrentRow.Cells("ColumnID").Value Is Nothing Then
                    NovoProduto(DataGridViewProdutos.CurrentRow, ComboBoxCliente.SelectedValue)
                ElseIf DataGridViewProdutos.CurrentRow.Cells("ColumnID").Value Is DBNull.Value Then
                    NovoProduto(DataGridViewProdutos.CurrentRow, ComboBoxCliente.SelectedValue)
                Else
                    UpdateProduto(DataGridViewProdutos.CurrentRow)
                End If

            End If

        End If

    End Sub

    Private Sub FormCadType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregaCliente(ComboBoxCliente)
    End Sub

    Private Sub DataGridViewType_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles DataGridViewProdutos.UserDeletingRow

        DeteleProduto(DataGridViewProdutos.CurrentRow)

    End Sub

    Private Sub ExportarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportarToolStripMenuItem.Click
        ExportPlanSimples(ProgressBar, LabelStatus,, DataGridViewProdutos)
    End Sub

    Private Sub DataGridViewProdutos_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBoxCliente.SelectionChangeCommitted

        CarregaGrid(DataGridViewProdutos, ComboBoxCliente.SelectedValue)

        DataGridViewProdutos.ReadOnly = True
        DataGridViewProdutos.AllowUserToAddRows = False
        DataGridViewProdutos.AllowUserToDeleteRows = False

        F2AperteParaAbilitarAEdiçãoToolStripMenuItem.Text = "F3 - Aperte para Abilitar a Edição"

        ExcluiEmbranco(DataGridViewProdutos)

    End Sub
End Class