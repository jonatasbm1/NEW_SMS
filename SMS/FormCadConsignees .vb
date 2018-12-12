Imports SMS.ClassFormCadConsignees
Public Class FormCadConsignees
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

        CarregaCliente(ComboBoxCliente)
        'CarregaGridConsignees(DataGridViewConsignees, ComboBoxCliente.SelectedValue)

    End Sub

    Private Sub ButtonSalvar_Click(sender As Object, e As EventArgs) Handles ButtonSalvar.Click

        If ComboBoxCliente.SelectedValue Is Nothing Then

            MsgBox("You must select a client before continuing")
            Exit Sub

        ElseIf TextBoxParceiro.Text = "" Then

            MsgBox("It's necessary to describe a name for the consignees before continuing")
            Exit Sub

        End If

        If ModoAdd = 1 Then
            NovoConsignees()
        ElseIf ModoEdit = 1 Then
            UpdateConsignees(ComboBoxConsignees.SelectedValue)
            CarregaGridConsignees(DataGridViewConsignees, ComboBoxCliente.SelectedValue)
        End If

    End Sub
    Private Sub ComboBoxNome_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBoxCliente.SelectionChangeCommitted

        ComboBoxConsignees.DataSource = Nothing
        ComboBoxConsignees.Items.Clear()
        TextBoxDescricao.Text = ""
        CarregaConsignees(ComboBoxConsignees, ComboBoxCliente.SelectedValue)
        CarregaGridConsignees(DataGridViewConsignees, ComboBoxCliente.SelectedValue)

    End Sub

    Private Sub ExcluirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExcluirToolStripMenuItem.Click

        RemoveConsignees(ComboBoxConsignees.SelectedValue)
        CarregaGridConsignees(DataGridViewConsignees, ComboBoxConsignees.SelectedValue)

    End Sub

    Private Sub F2AperteParaAbilitarAEdiçãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles F2AperteParaAbilitarAEdiçãoToolStripMenuItem.Click

        If TabControl1.SelectedTab.Name = "TabPage1" Then

            If DataGridViewConsignees.CurrentRow.Cells("ColumnConsigness").Value = Nothing Then

                MsgBox("Please select a consignees before proceeding")
                Exit Sub

            Else

                AbilitaDesabiliraEdit(DataGridViewContact, F2AperteParaAbilitarAEdiçãoToolStripMenuItem)

            End If

        ElseIf TabControl1.SelectedTab.Name = "TabPage2" Then

            If DataGridViewConsignees.CurrentRow.Cells("ColumnConsigness").Value.ToString = Nothing Then

                MsgBox("Please select a consignees before proceeding")
                Exit Sub

            Else

                AbilitaDesabiliraEdit(DataGridViewAdress, F2AperteParaAbilitarAEdiçãoToolStripMenuItem)

            End If


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

    Private Sub DataGridViewConsignees_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewConsignees.CellClick

        ComboBoxConsignees.SelectedValue = DataGridViewConsignees.CurrentRow.Cells("ColumnCid").Value
        CarregaContact(DataGridViewContact, DataGridViewConsignees.CurrentRow.Cells("ColumnCid").Value)
        CarregaAdress(DataGridViewAdress, DataGridViewConsignees.CurrentRow.Cells("ColumnCid").Value)

    End Sub

    Private Sub ExportarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportarToolStripMenuItem.Click

        If TabControl1.SelectedTab.Name = "TabPage1" Then

            ExportPlanSimples(ProgressBar, LabelStatus,, DataGridViewContact)
            ProgressBar.Value = 0
            LabelStatus.Text = ""

        ElseIf TabControl1.SelectedTab.Name = "TabPage2" Then

            ExportPlanSimples(ProgressBar, LabelStatus,, DataGridViewAdress)
            ProgressBar.Value = 0
            LabelStatus.Text = ""

        End If

    End Sub

    Private Sub FiltrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FiltrarToolStripMenuItem.Click

        Dim ValorFiltro As String

        ValorFiltro = ""
        ValorFiltro = InputBox("Please enter the desired filter.")

        If ValorFiltro <> "" Then
            FiltrarDadosGrid(DataGridViewConsignees.Columns(DataGridViewConsignees.CurrentCell.ColumnIndex).DataPropertyName, ValorFiltro)
        Else
            FiltrarDadosGrid("", "")
        End If

    End Sub

    Private Sub LocalizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LocalizarToolStripMenuItem.Click

        FormLocalizar.Show()
        FormLocalizar.Grid = DataGridViewConsignees

    End Sub

    Private Sub ComboBoxConsignees_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBoxConsignees.SelectionChangeCommitted

        TextBoxDescricao.Text = ""
        CarregaCampos(ComboBoxConsignees.SelectedValue)

    End Sub

    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewAdress.CellEndEdit

        If DataGridViewAdress.CurrentRow.Cells("ColumnAid").Value Is Nothing Or DataGridViewAdress.CurrentRow.Cells("ColumnAid").Value.ToString = "" Then
            NovoAdress(DataGridViewAdress.CurrentRow)
        Else
            UpdateAdress(DataGridViewAdress.CurrentRow)
        End If

    End Sub

    Private Sub DataGridViewAdress_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles DataGridViewAdress.UserDeletingRow

        DeteleAdress(DataGridViewAdress.CurrentRow)

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged

        DataGridViewContact.ReadOnly = True
        DataGridViewContact.AllowUserToAddRows = False
        DataGridViewContact.AllowUserToDeleteRows = False

        DataGridViewAdress.ReadOnly = True
        DataGridViewAdress.AllowUserToAddRows = False
        DataGridViewAdress.AllowUserToDeleteRows = False

        F2AperteParaAbilitarAEdiçãoToolStripMenuItem.Text = "F3 - Press to enable editing"

    End Sub

    Private Sub TabControl_Selected(sender As Object, e As TabControlEventArgs) Handles TabControl.Selected

        Dim dt, dt2 As DataTable

        If TabControl.SelectedTab.Name = "TabPagePesquisa" Then
            F2AperteParaAbilitarAEdiçãoToolStripMenuItem.Enabled = True
            ExportarToolStripMenuItem.Enabled = True
        ElseIf TabControl.SelectedTab.Name = "TabPageCad" Then
            F2AperteParaAbilitarAEdiçãoToolStripMenuItem.Enabled = False
            ExportarToolStripMenuItem.Enabled = False

            dt = DataGridViewContact.DataSource
            dt.Rows.Clear()
            DataGridViewContact.DataSource = dt

            dt2 = DataGridViewAdress.DataSource
            dt2.Rows.Clear()
            DataGridViewAdress.DataSource = dt2

        End If

    End Sub
End Class