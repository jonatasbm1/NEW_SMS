Imports SMS.ClassFormCadPattern
Public Class FormCadPattern
    Private Sub NovoCadastroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovoCadastroToolStripMenuItem.Click

        HabilitaCadastro()

    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click

        HabilitarEdição()

    End Sub

    Private Sub ButtonCancelarCad_Click(sender As Object, e As EventArgs) Handles ButtonCancelarCad.Click

        Cancelar()

    End Sub

    Private Sub FormCadPattern_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ModoEdit = 0
        ModoAdd = 0

        CarregaCliente(ComboBoxNome)
        CarregaGridCliente(DataGridViewCliente)

    End Sub

    Private Sub ButtonSalvar_Click(sender As Object, e As EventArgs) Handles ButtonSalvar.Click


        If ModoAdd = 1 Then
            NovoCliente()
        ElseIf ModoEdit = 1 Then
            UpdateClient(ComboBoxNome.SelectedValue)
        End If

    End Sub
    Private Sub ComboBoxNome_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBoxNome.SelectionChangeCommitted

        CarregaCampos(ComboBoxNome.SelectedValue)

    End Sub

    Private Sub ExcluirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExcluirToolStripMenuItem.Click

        RemoveClient(ComboBoxNome.SelectedValue)

    End Sub

    Private Sub F2AperteParaAbilitarAEdiçãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles F2AperteParaAbilitarAEdiçãoToolStripMenuItem.Click

        If ComboBoxNome.SelectedValue = Nothing Then

            MsgBox("Favor Selecionar um Cliente antes de Continuar")
            Exit Sub

        Else

            AbilitaDesabiliraEdit(DataGridViewContact, F2AperteParaAbilitarAEdiçãoToolStripMenuItem)

        End If

    End Sub

    Private Sub DataGridViewContact_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewContact.CellEndEdit

        If DataGridViewContact.CurrentRow.Cells("ColumnID").Value Is Nothing Or DataGridViewContact.CurrentRow.Cells("ColumnID").Value.ToString = "" Then
            NovoContact(DataGridViewContact.CurrentRow)
        Else
            UpdateContact(DataGridViewContact.CurrentRow)
        End If

    End Sub

    Private Sub DataGridViewContact_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles DataGridViewContact.UserDeletingRow

        DeteleContact(DataGridViewContact.CurrentRow)

    End Sub

    Private Sub DataGridViewCliente_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewCliente.CellClick

        ComboBoxNome.SelectedValue = DataGridViewCliente.CurrentRow.Cells("ColumnCid").Value
        CarregaContact(DataGridViewContact, DataGridViewCliente.CurrentRow.Cells("ColumnCid").Value)

    End Sub

    Private Sub ExportarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportarToolStripMenuItem.Click
        ExportPlanSimples(ProgressBar, LabelStatus,, DataGridViewContact)
        ProgressBar.Value = 0
        LabelStatus.Text = ""
    End Sub

    Private Sub FiltrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FiltrarToolStripMenuItem.Click

        Dim ValorFiltro As String

        ValorFiltro = ""
        ValorFiltro = InputBox("Please enter the desired filter.")

        If ValorFiltro <> "" Then
            FiltrarDadosGrid(DataGridViewCliente.Columns(DataGridViewCliente.CurrentCell.ColumnIndex).DataPropertyName, ValorFiltro)
        Else
            FiltrarDadosGrid("", "")
        End If

    End Sub

    Private Sub LocalizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LocalizarToolStripMenuItem.Click

        FormLocalizar.Show()
        FormLocalizar.Grid = DataGridViewCliente

    End Sub
End Class