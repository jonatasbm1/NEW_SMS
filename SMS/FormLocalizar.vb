Public Class FormLocalizar
    Public Grid As DataGridView
    Public IndexBusca As Long

    Private Sub ButtonLocalizar_Click(sender As Object, e As EventArgs) Handles ButtonLocalizar.Click

        Dim filtro As String = ""
        Dim index As Integer = 0

        If Grid.RowCount = 1 Then

            Exit Sub

        End If

        filtro = TextBoxFiltro.Text.ToUpper
        'Grid.ClearSelection()

        For Each Drv As DataGridViewRow In Grid.Rows

            Drv.Selected = Nothing

            If Drv.Cells(Grid.Columns(Grid.CurrentCell.ColumnIndex).Name).Value.ToString.Replace(" ", "").ToUpper Like "*" & filtro.Replace(" ", "") & "*" Then

                Grid.FirstDisplayedScrollingRowIndex = Drv.Index
                Drv.Cells(Grid.Columns(Grid.CurrentCell.ColumnIndex).Name).Selected = True
                IndexBusca = Drv.Index

                Exit For
            End If

        Next

    End Sub

    Private Sub ButtonProximo_Click(sender As Object, e As EventArgs) Handles ButtonProximo.Click

        Dim filtro As String = ""
        Dim index As Integer = 0

        If Grid.RowCount = 1 Then

            Exit Sub

        End If

        filtro = TextBoxFiltro.Text.ToUpper

        Grid.ClearSelection()

        For Each Drv As DataGridViewRow In Grid.Rows

            Drv.Selected = Nothing

            If IndexBusca < Drv.Index Then

                If Drv.Cells(Grid.Columns(Grid.CurrentCell.ColumnIndex).Name).Value.ToString.Replace(" ", "").ToUpper Like "*" & filtro.Replace(" ", "") & "*" Then

                    Grid.FirstDisplayedScrollingRowIndex = Drv.Index
                    Drv.Cells(Grid.Columns(Grid.CurrentCell.ColumnIndex).Name).Selected = True
                    IndexBusca = Drv.Index

                    Exit For

                End If

                If Drv.Index = Grid.Rows.Count - 1 Then
                    IndexBusca = 0
                End If

            End If

            If IndexBusca = Drv.Index Then
                IndexBusca = 0
            End If

        Next

    End Sub

    Private Sub FormLocalizar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        TextBoxFiltro.Focus()
        TextBoxFiltro.SelectionStart = 0
    End Sub
End Class
