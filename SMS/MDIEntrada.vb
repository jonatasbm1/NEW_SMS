Imports System.Windows.Forms

Public Class MDIEntrada

    Private Sub ColsultaGeralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColsultaGeralToolStripMenuItem.Click

        FormConsultaBase.MdiParent = Me
        FormConsultaBase.Show()
        FormConsultaBase.WindowState = FormWindowState.Maximized
        FormConsultaBase.BringToFront()

    End Sub

    Private Sub RelatóriosGerenciaisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelatóriosGerenciaisToolStripMenuItem.Click

        FormRptMediaSemanal.MdiParent = Me
        FormRptMediaSemanal.Show()
        FormConsultaBase.BringToFront()

    End Sub

    Private Sub TiposToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiposToolStripMenuItem.Click

        FormCadType.MdiParent = Me
        FormCadType.Show()
        FormCadType.BringToFront()

    End Sub

    Private Sub UnidadeDeMedidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnidadeDeMedidaToolStripMenuItem.Click

        FormCadUq.MdiParent = Me
        FormCadUq.Show()
        FormCadUq.BringToFront()

    End Sub

    Private Sub TesteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TesteToolStripMenuItem.Click
        AtualizaTypeUq()
    End Sub

    Private Sub LocaisDeEstoqueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LocaisDeEstoqueToolStripMenuItem.Click

        FormCadLocation.MdiParent = Me
        FormCadLocation.Show()
        FormCadLocation.BringToFront()

    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click

        FormCadPattern.MdiParent = Me
        FormCadPattern.Show()
        FormCadPattern.BringToFront()

    End Sub

    Private Sub ClientesDosClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesDosClientesToolStripMenuItem.Click

        FormCadConsignees.MdiParent = Me
        FormCadConsignees.Show()
        FormCadConsignees.BringToFront()

    End Sub
End Class
