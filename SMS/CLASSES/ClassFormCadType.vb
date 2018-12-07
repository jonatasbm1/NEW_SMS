Imports System.Data.SqlClient

Public Class ClassCadastroType

    Public Shared Sub CarregaGrid(Grid As DataGridView)

        Dim sql As String
        Dim da As SqlDataAdapter
        Dim dt As DataTable

        sql = ""
        sql = sql & vbCrLf & "SELECT T.ID,"
        sql = sql & vbCrLf & "       T.TYPE,"
        sql = sql & vbCrLf & "	   T.DESCRIPTION"
        sql = sql & vbCrLf & "FROM TBL_TYPE T"

        da = New SqlDataAdapter(sql, conn)
        dt = New DataTable
        da.Fill(dt)
        Grid.DataSource = dt

    End Sub

    Public Shared Sub AbilitaDesabiliraEdit(Grid As DataGridView, Menu As ToolStripMenuItem)

        If Grid.ReadOnly = False Then

            Grid.ReadOnly = True
            Grid.AllowUserToAddRows = False
            Grid.AllowUserToDeleteRows = False

            Menu.Text = "F3 - Aperte para Abilitar a Edição"

            ExcluiEmbranco(Grid)

        Else

            Grid.ReadOnly = False
            Grid.AllowUserToAddRows = True
            Grid.AllowUserToDeleteRows = True

            Menu.Text = "F3 - Aperte para Desabilitar a Edição"

        End If


    End Sub

    Public Shared Sub NovoType(Grid As DataGridViewRow)

        Dim Command As SqlCommand

        Command = New SqlCommand()

        Command.CommandType = CommandType.StoredProcedure
        Command.CommandText = "InserirType"

        Command.Connection = conn

        Command.Parameters.Add("@ID", SqlDbType.Int).Direction = ParameterDirection.Output
        Command.Parameters.Add("@TYPE", SqlDbType.NVarChar).Value = IIf(Grid.Cells("ColumnType").Value Is Nothing, "", Grid.Cells("ColumnType").Value.ToString.ToUpper)
        Command.Parameters.Add("@DESCRIPITION", SqlDbType.NVarChar).Value = IIf(Grid.Cells("ColumnDescri").Value Is Nothing, "", Grid.Cells("ColumnDescri").Value)

        ConexaoOpen()

        Command.ExecuteNonQuery()

        Grid.Cells("ColumnId").Value = Command.Parameters("@id").Value.ToString()
        Grid.Cells("ColumnType").Value = Grid.Cells("ColumnType").Value.ToString.ToUpper

        conn.Close()

    End Sub

    Public Shared Sub UpdateType(Grid As DataGridViewRow)

        Dim Command As SqlCommand
        Dim sql As String

        'aqui Atualiza os dados 
        sql = ""
        sql = sql & vbCrLf & "UPDATE TBL_TYPE "
        sql = sql & vbCrLf & "   SET TYPE = @TYPE, DESCRIPTION = @DESCRIPTION"
        sql = sql & vbCrLf & "WHERE ID = " & Grid.Cells("ColumnId").Value

        Command = New SqlCommand(sql, conn)
        Command.Parameters.AddWithValue("@TYPE", IIf(Grid.Cells("ColumnType").Value Is Nothing, "", Grid.Cells("ColumnType").Value.ToString.ToUpper))
        Command.Parameters.AddWithValue("@DESCRIPTION", IIf(Grid.Cells("ColumnDescri").Value Is Nothing, "", Grid.Cells("ColumnDescri").Value))
        ConexaoOpen()
        Command.ExecuteNonQuery()
        conn.Close()

    End Sub

    Public Shared Sub DeteleType(Grid As DataGridViewRow)

        Dim Command As SqlCommand
        Dim sql As String
        Dim Da As SqlDataAdapter
        Dim Dt As DataTable

        sql = ""
        sql = sql & vbCrLf & "SELECT T.ID_TYPE"
        sql = Sql & vbCrLf & "FROM CSRDB T"
        sql = sql & vbCrLf & "WHERE T.ID_TYPE = " & Grid.Cells("ColumnID").Value

        Da = New SqlDataAdapter(sql, conn)
        Dt = New DataTable
        Da.Fill(Dt)

        If Dt.Rows.Count > 0 Then
            MsgBox("Atenção não é possível excluir este Type, ele já esta associado a algum item de estoque.")
        Else

            sql = ""
            sql = sql & vbCrLf & "DELETE TBL_TYPE"
            sql = sql & vbCrLf & "WHERE ID = " & Grid.Cells("ColumnID").Value

            Command = New SqlCommand(sql, conn)
            ConexaoOpen()
            Command.ExecuteNonQuery()
            conn.Close()

        End If


    End Sub
    Public Shared Sub ExcluiEmbranco(Grid As DataGridView)

        For Each Dgr As DataGridViewRow In Grid.Rows

            If Dgr.Cells("ColumnID").Value.ToString = "" Then
                Grid.Rows.Remove(Dgr)
            End If

        Next

    End Sub

End Class
