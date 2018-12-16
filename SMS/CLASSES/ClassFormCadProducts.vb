Imports System.Data.SqlClient

Public Class ClassFormCadProducts

    Public Shared Sub CarregaGrid(Grid As DataGridView, id As Long)

        Dim sql As String
        Dim da As SqlDataAdapter
        Dim dt, DtUnid As DataTable

        sql = ""
        sql = sql & vbCrLf & "SELECT T.ID,"
        sql = sql & vbCrLf & "       T.UQ,"
        sql = sql & vbCrLf & "	   T.DESCRIPTION"
        sql = sql & vbCrLf & "FROM TBL_UQ T"

        da = New SqlDataAdapter(sql, conn)
        DtUnid = New DataTable
        da.Fill(DtUnid)

        'Popular os Combobox do grid

        Dim Unid_med As New DataGridViewComboBoxColumn()
        Unid_med = Grid.Columns("ColumnUnid")
        Unid_med.DataSource = DtUnid
        Unid_med.DisplayMember = "UQ"
        Unid_med.ValueMember = "ID"

        Dim TIPO_DI_A As New DataGridViewComboBoxColumn()
        Unid_med = Grid.Columns("ColumnMedA")
        Unid_med.DataSource = DtUnid
        Unid_med.DisplayMember = "UQ"
        Unid_med.ValueMember = "ID"

        Dim TIPO_DI_B As New DataGridViewComboBoxColumn()
        Unid_med = Grid.Columns("ColumnMedB")
        Unid_med.DataSource = DtUnid
        Unid_med.DisplayMember = "UQ"
        Unid_med.ValueMember = "ID"

        Dim TIPO_DI_C As New DataGridViewComboBoxColumn()
        Unid_med = Grid.Columns("ColumnMedC")
        Unid_med.DataSource = DtUnid
        Unid_med.DisplayMember = "UQ"
        Unid_med.ValueMember = "ID"

        Dim TIPO_PADRAO As New DataGridViewComboBoxColumn()
        Unid_med = Grid.Columns("ColumnTipoP")
        Unid_med.DataSource = DtUnid
        Unid_med.DisplayMember = "UQ"
        Unid_med.ValueMember = "ID"

        sql = ""
        sql = sql & vbCrLf & "SELECT  T.ID,"
        sql = sql & vbCrLf & "        T.ID_CLIENTE,"
        sql = sql & vbCrLf & "		T.PRODUTO,"
        sql = sql & vbCrLf & "		T.DESCRI_RESUMIDA,"
        sql = sql & vbCrLf & "		T.DESCRI_COMPLETA,"
        sql = sql & vbCrLf & "		T.ID_UNID_MED,"
        sql = sql & vbCrLf & "		T.DIMENCAO_A,"
        sql = sql & vbCrLf & "		T.ID_TIPO_DI_A,"
        sql = sql & vbCrLf & "		T.DIMENCAO_B,"
        sql = sql & vbCrLf & "		T.ID_TIPO_DI_B,"
        sql = sql & vbCrLf & "		T.DIMENCAO_C,"
        sql = sql & vbCrLf & "		T.ID_TIPO_DI_C,"
        sql = sql & vbCrLf & "		T.PESO,"
        sql = sql & vbCrLf & "		T.ID_TIPO_PADRAO,"
        sql = sql & vbCrLf & "		T.QTD_PADRAO"
        sql = sql & vbCrLf & "FROM TBL_PRODUTOS T"
        sql = sql & vbCrLf & "WHERE T.ID_CLIENTE = " & id


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

    Public Shared Sub NovoProduto(Grid As DataGridViewRow, id_cliente As Long)

        Dim Command As SqlCommand
        Dim Maiuscula As String

        Command = New SqlCommand()
        Maiuscula = ""

        Command.CommandType = CommandType.StoredProcedure
        Command.CommandText = "InserirProduto"

        Command.Connection = conn

        Command.Parameters.Add("@ID", SqlDbType.Int).Direction = ParameterDirection.Output
        Command.Parameters.Add("@ID_CLIENTE", SqlDbType.Int).Value = id_cliente

        Maiuscula = ""
        Maiuscula = IIf(Grid.Cells("ColumnProduto").Value Is DBNull.Value, "", Grid.Cells("ColumnProduto").Value)
        Command.Parameters.Add("@PRODUTO", SqlDbType.NVarChar).Value = Maiuscula.ToUpper

        Maiuscula = ""
        Maiuscula = IIf(Grid.Cells("ColumnDescriR").Value Is DBNull.Value, "", Grid.Cells("ColumnDescriR").Value)
        Command.Parameters.Add("@DESCRI_RESUMIDA", SqlDbType.NVarChar).Value = Maiuscula.ToUpper

        Maiuscula = ""
        Maiuscula = IIf(Grid.Cells("ColumnDescriC").Value Is DBNull.Value, "", Grid.Cells("ColumnDescriC").Value)
        Command.Parameters.Add("@DESCRI_COMPLETA", SqlDbType.Text).Value = Maiuscula.ToUpper

        Command.Parameters.Add("@ID_UNID_MED", SqlDbType.Int).Value = IIf(Grid.Cells("ColumnUnid").Value Is DBNull.Value, DBNull.Value, Grid.Cells("ColumnUnid").Value)
        Command.Parameters.Add("@DIMENCAO_A", SqlDbType.NVarChar).Value = IIf(Grid.Cells("ColumnDimenA").Value Is DBNull.Value, DBNull.Value, Grid.Cells("ColumnDimenA").Value)
        Command.Parameters.Add("@ID_TIPO_DI_A", SqlDbType.Int).Value = IIf(Grid.Cells("ColumnMedA").Value Is DBNull.Value, DBNull.Value, Grid.Cells("ColumnMedA").Value)
        Command.Parameters.Add("@DIMENCAO_B", SqlDbType.NVarChar).Value = IIf(Grid.Cells("ColumnDminB").Value Is DBNull.Value, DBNull.Value, Grid.Cells("ColumnDminB").Value)
        Command.Parameters.Add("@ID_TIPO_DI_B", SqlDbType.Int).Value = IIf(Grid.Cells("ColumnMedB").Value Is DBNull.Value, DBNull.Value, Grid.Cells("ColumnMedB").Value)
        Command.Parameters.Add("@DIMENCAO_C", SqlDbType.NVarChar).Value = IIf(Grid.Cells("ColumnDimenC").Value Is DBNull.Value, DBNull.Value, Grid.Cells("ColumnDimenC").Value)
        Command.Parameters.Add("@ID_TIPO_DI_C", SqlDbType.Int).Value = IIf(Grid.Cells("ColumnMedC").Value Is DBNull.Value, DBNull.Value, Grid.Cells("ColumnMedC").Value)

        Command.Parameters.AddWithValue("@PESO", SqlDbType.Decimal)
        Command.Parameters("@PESO").Precision = 18
        Command.Parameters("@PESO").Scale = 3
        Command.Parameters("@PESO").Value = IIf(Grid.Cells("ColumnPeso").Value Is DBNull.Value, DBNull.Value, Grid.Cells("ColumnPeso").Value)

        Command.Parameters.AddWithValue("@ID_TIPO_PADRAO", SqlDbType.Int).Value = IIf(Grid.Cells("ColumnTipoP").Value Is DBNull.Value, DBNull.Value, Grid.Cells("ColumnTipoP").Value)

        Command.Parameters.AddWithValue("@QTD_PADRAO", SqlDbType.Decimal)
        Command.Parameters("@QTD_PADRAO").Precision = 18
        Command.Parameters("@QTD_PADRAO").Scale = 3
        Command.Parameters("@QTD_PADRAO").Value = IIf(Grid.Cells("ColumnQtdP").Value Is DBNull.Value, DBNull.Value, Grid.Cells("ColumnQtdP").Value)

        ConexaoOpen()

        Command.ExecuteNonQuery()

        Grid.Cells("ColumnId").Value = Command.Parameters("@id").Value.ToString()
        Grid.Cells("ColumnProduto").Value = Grid.Cells("ColumnProduto").Value.ToString.ToUpper

        conn.Close()

    End Sub

    Public Shared Sub CarregaCliente(Combo As ComboBox, Optional ByVal ID As Long = 0)

        Dim sql As String
        Dim da As SqlDataAdapter
        Dim dt As DataTable

        sql = ""
        sql = sql & vbCrLf & "SELECT T.ID,"
        sql = sql & vbCrLf & "       T.CLIENTE"
        sql = sql & vbCrLf & "FROM TBL_CAD_CLIENTE T"
        sql = sql & vbCrLf & "ORDER BY T.CLIENTE"

        da = New SqlDataAdapter(sql, conn)
        dt = New DataTable
        da.Fill(dt)
        Combo.DataSource = dt

        Combo.DisplayMember = "CLIENTE"
        Combo.ValueMember = "ID"

    End Sub

    Public Shared Sub UpdateProduto(Grid As DataGridViewRow)

        Dim Command As SqlCommand
        Dim sql As String
        Dim Maiuscula As String

        'aqui Atualiza os dados 
        sql = ""
        sql = sql & vbCrLf & "UPDATE TBL_PRODUTOS "
        sql = sql & vbCrLf & "   SET PRODUTO = @PRODUTO, DESCRI_RESUMIDA = @DESCRI_RESUMIDA, DESCRI_COMPLETA = @DESCRI_COMPLETA,"
        sql = sql & vbCrLf & "       ID_UNID_MED = @ID_UNID_MED, DIMENCAO_A = @DIMENCAO_A, DIMENCAO_B = @DIMENCAO_B, ID_TIPO_DI_A = @ID_TIPO_DI_A,"
        sql = sql & vbCrLf & "       ID_TIPO_DI_B = @ID_TIPO_DI_B, DIMENCAO_C = @DIMENCAO_C, ID_TIPO_DI_C = @ID_TIPO_DI_C, PESO = @PESO, ID_TIPO_PADRAO = @ID_TIPO_PADRAO, QTD_PADRAO = @QTD_PADRAO"
        sql = sql & vbCrLf & "WHERE ID = " & Grid.Cells("ColumnId").Value

        Command = New SqlCommand(sql, conn)

        Maiuscula = ""
        Maiuscula = IIf(Grid.Cells("ColumnProduto").Value Is DBNull.Value, "", Grid.Cells("ColumnProduto").Value)
        Command.Parameters.AddWithValue("@PRODUTO", SqlDbType.NVarChar).Value = Maiuscula.ToUpper

        Maiuscula = ""
        Maiuscula = IIf(Grid.Cells("ColumnDescriR").Value Is DBNull.Value, "", Grid.Cells("ColumnDescriR").Value)
        Command.Parameters.AddWithValue("@DESCRI_RESUMIDA", SqlDbType.NVarChar).Value = Maiuscula.ToUpper

        Maiuscula = ""
        Maiuscula = IIf(Grid.Cells("ColumnDescriC").Value Is DBNull.Value, "", Grid.Cells("ColumnDescriC").Value)
        Command.Parameters.AddWithValue("@DESCRI_COMPLETA", SqlDbType.Text).Value = Maiuscula.ToUpper

        Command.Parameters.AddWithValue("@ID_UNID_MED", SqlDbType.Int).Value = IIf(Grid.Cells("ColumnUnid").Value Is DBNull.Value, DBNull.Value, Grid.Cells("ColumnUnid").Value)
        Command.Parameters.AddWithValue("@DIMENCAO_A", SqlDbType.NVarChar).Value = IIf(Grid.Cells("ColumnDimenA").Value Is DBNull.Value, DBNull.Value, Grid.Cells("ColumnDimenA").Value)
        Command.Parameters.AddWithValue("@ID_TIPO_DI_A", SqlDbType.Int).Value = IIf(Grid.Cells("ColumnMedA").Value Is DBNull.Value, DBNull.Value, Grid.Cells("ColumnMedA").Value)
        Command.Parameters.AddWithValue("@DIMENCAO_B", SqlDbType.NVarChar).Value = IIf(Grid.Cells("ColumnDminB").Value Is DBNull.Value, DBNull.Value, Grid.Cells("ColumnDminB").Value)
        Command.Parameters.AddWithValue("@ID_TIPO_DI_B", SqlDbType.Int).Value = IIf(Grid.Cells("ColumnMedB").Value Is DBNull.Value, DBNull.Value, Grid.Cells("ColumnMedB").Value)
        Command.Parameters.AddWithValue("@DIMENCAO_C", SqlDbType.NVarChar).Value = IIf(Grid.Cells("ColumnDimenC").Value Is DBNull.Value, DBNull.Value, Grid.Cells("ColumnDimenC").Value)
        Command.Parameters.AddWithValue("@ID_TIPO_DI_C", SqlDbType.Int).Value = IIf(Grid.Cells("ColumnMedC").Value Is DBNull.Value, DBNull.Value, Grid.Cells("ColumnMedC").Value)

        Command.Parameters.AddWithValue("@PESO", SqlDbType.Decimal)
        Command.Parameters("@PESO").Precision = 18
        Command.Parameters("@PESO").Scale = 3
        Command.Parameters("@PESO").Value = IIf(Grid.Cells("ColumnPeso").Value Is DBNull.Value, DBNull.Value, Grid.Cells("ColumnPeso").Value)

        Command.Parameters.AddWithValue("@ID_TIPO_PADRAO", SqlDbType.Int).Value = IIf(Grid.Cells("ColumnTipoP").Value Is DBNull.Value, DBNull.Value, Grid.Cells("ColumnTipoP").Value)

        Command.Parameters.AddWithValue("@QTD_PADRAO", SqlDbType.Decimal)
        Command.Parameters("@QTD_PADRAO").Precision = 18
        Command.Parameters("@QTD_PADRAO").Scale = 3
        Command.Parameters("@QTD_PADRAO").Value = IIf(Grid.Cells("ColumnQtdP").Value Is DBNull.Value, DBNull.Value, Grid.Cells("ColumnQtdP").Value)

        ConexaoOpen()
        Command.ExecuteNonQuery()
        conn.Close()

    End Sub

    Public Shared Function VerificaDuplicado(Grid As DataGridView, Produto As String, IdCliente As Long)

        Dim sql As String
        Dim Da As SqlDataAdapter
        Dim Dt As DataTable

        If Grid.Columns(Grid.CurrentCell.ColumnIndex).Name = "ColumnProduto" Then

            sql = ""
            sql = sql & vbCrLf & "SELECT T.PRODUTO"
            sql = sql & vbCrLf & "FROM TBL_PRODUTOS T"
            sql = sql & vbCrLf & "WHERE UPPER(T.PRODUTO) = '" & Produto & "'"
            sql = sql & vbCrLf & "  AND ID_CLIENTE =" & IdCliente

            Da = New SqlDataAdapter(sql, conn)
            Dt = New DataTable
            Da.Fill(Dt)

            If Dt.Rows.Count = 0 Then
                Return False
            Else
                Return True
            End If

        Else

            Return False

        End If

    End Function

    Public Shared Sub DeteleProduto(Grid As DataGridViewRow)

        Dim Command As SqlCommand
        Dim sql As String
        Dim Da As SqlDataAdapter
        Dim Dt As DataTable

        sql = ""
        sql = sql & vbCrLf & "SELECT T.ID_PRODUTO"
        sql = sql & vbCrLf & "FROM CSRDB T"
        sql = sql & vbCrLf & "WHERE T.ID_PRODUTO = " & Grid.Cells("ColumnID").Value

        Da = New SqlDataAdapter(sql, conn)
        Dt = New DataTable
        Da.Fill(Dt)

        If Dt.Rows.Count > 0 Then
            MsgBox("Atenção não é possível excluir este Peroduto, ele já esta associado a algum movimento de estoque.")
        Else

            sql = ""
            sql = sql & vbCrLf & "DELETE TBL_PRODUTOS"
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
