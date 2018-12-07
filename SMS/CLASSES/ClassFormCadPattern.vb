Imports System.Data.SqlClient
Imports SMS.FormCadPattern

Public Class ClassFormCadPattern
    Public Shared ModoAdd, ModoEdit As Long
    Shared bs As BindingSource

    Public Shared Sub HabilitaCadastro()

        If FormCadPattern.TextBoxNome.Visible = False Then

            FormCadPattern.TextBoxNome.Visible = True
            FormCadPattern.ComboBoxNome.Visible = False
            FormCadPattern.TextBoxAccount.Enabled = True
            FormCadPattern.TextBoxTax.Enabled = True
            FormCadPattern.TextBoxEmail.Enabled = True
            FormCadPattern.ButtonSalvar.Enabled = True
            FormCadPattern.ButtonCancelarCad.Enabled = True

            ModoAdd = 1
            ModoEdit = 0
        Else
            MsgBox("O Modo de criação já está abilitado")
            ModoEdit = 0
        End If

    End Sub

    Public Shared Sub HabilitarEdição()

        FormCadPattern.TextBoxNome.Visible = True
        FormCadPattern.TextBoxNome.Text = FormCadPattern.ComboBoxNome.Text
        FormCadPattern.ComboBoxNome.Visible = False
        FormCadPattern.TextBoxAccount.Enabled = True
        FormCadPattern.TextBoxTax.Enabled = True
        FormCadPattern.TextBoxEmail.Enabled = True
        FormCadPattern.ButtonSalvar.Enabled = True
        FormCadPattern.ButtonCancelarCad.Enabled = True

        ModoEdit = 1
        ModoAdd = 0

    End Sub

    Public Shared Sub Cancelar()

        FormCadPattern.TextBoxNome.Text = ""
        FormCadPattern.TextBoxNome.Visible = False

        FormCadPattern.ComboBoxNome.Text = ""
        FormCadPattern.ComboBoxNome.Visible = True

        FormCadPattern.TextBoxAccount.Text = ""
        FormCadPattern.TextBoxAccount.Enabled = False

        FormCadPattern.TextBoxTax.Text = ""
        FormCadPattern.TextBoxTax.Enabled = False

        FormCadPattern.TextBoxEmail.Text = ""
        FormCadPattern.TextBoxEmail.Enabled = False

        FormCadPattern.ButtonSalvar.Enabled = False
        FormCadPattern.ButtonCancelarCad.Enabled = False

        ModoEdit = 0
        ModoAdd = 0

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

        If ID <> 0 Then

            Combo.SelectedValue = ID
            ID = 0

        End If


    End Sub

    Public Shared Sub NovoCliente()

        Dim Command As SqlCommand
        Dim id As Long

        If FormCadPattern.TextBoxNome.Text = "" Then

            MsgBox("Atenção o Nome do cliente não pode estar em branco!!!")
            Exit Sub

        End If


        Command = New SqlCommand()

        Command.CommandType = CommandType.StoredProcedure
        Command.CommandText = "InserirCliente"

        Command.Connection = conn

        Command.Parameters.Add("@ID", SqlDbType.Int).Direction = ParameterDirection.Output
        Command.Parameters.Add("@CLIENTE", SqlDbType.NVarChar).Value = IIf(FormCadPattern.TextBoxNome.Text Is Nothing, "", FormCadPattern.TextBoxNome.Text.ToUpper)
        Command.Parameters.Add("@ACCOUNT", SqlDbType.NVarChar).Value = IIf(FormCadPattern.TextBoxAccount.Text Is Nothing, "", FormCadPattern.TextBoxAccount.Text.ToUpper)
        Command.Parameters.Add("@TAX", SqlDbType.NVarChar).Value = IIf(FormCadPattern.TextBoxTax.Text Is Nothing, "", FormCadPattern.TextBoxTax.Text.ToUpper)
        Command.Parameters.Add("@EMAIL", SqlDbType.NVarChar).Value = IIf(FormCadPattern.TextBoxEmail.Text Is Nothing, "", FormCadPattern.TextBoxEmail.Text)

        ConexaoOpen()

        Command.ExecuteNonQuery()

        id = Command.Parameters("@id").Value.ToString()

        conn.Close()

        CarregaCliente(FormCadPattern.ComboBoxNome, id)

        Cancelar()

    End Sub

    Public Shared Sub CarregaCampos(Id As Long)

        Dim sql As String
        Dim da As SqlDataAdapter
        Dim dt As DataTable

        sql = ""
        sql = sql & vbCrLf & "SELECT T.ID,"
        sql = sql & vbCrLf & "       T.CLIENTE,"
        sql = sql & vbCrLf & "	   T.ACCOUNT,"
        sql = sql & vbCrLf & "	   T.TAX,"
        sql = sql & vbCrLf & "	   T.EMAIL"
        sql = sql & vbCrLf & "FROM TBL_CAD_CLIENTE T"
        sql = sql & vbCrLf & "WHERE T.ID = " & Id

        da = New SqlDataAdapter(sql, conn)
        dt = New DataTable
        da.Fill(dt)

        FormCadPattern.TextBoxAccount.Text = ""
        FormCadPattern.TextBoxTax.Text = ""
        FormCadPattern.TextBoxEmail.Text = ""

        If dt.Rows.Count > 0 Then

            FormCadPattern.TextBoxAccount.Text = dt.Rows(0)("ACCOUNT").ToString
            FormCadPattern.TextBoxTax.Text = dt.Rows(0)("TAX").ToString
            FormCadPattern.TextBoxEmail.Text = dt.Rows(0)("EMAIL").ToString

        End If

    End Sub

    Public Shared Sub UpdateClient(ID)


        Dim Command As SqlCommand
        Dim sql As String

        'aqui Atualiza os dados 
        sql = ""
        sql = sql & vbCrLf & "UPDATE TBL_CAD_CLIENTE "
        sql = sql & vbCrLf & "   SET CLIENTE = @CLIENTE, ACCOUNT = @ACCOUNT, TAX = @TAX, EMAIL = @EMAIL"
        sql = sql & vbCrLf & "WHERE ID = " & ID

        Command = New SqlCommand(sql, conn)
        Command.Parameters.AddWithValue("@CLIENTE", IIf(FormCadPattern.TextBoxNome.Text Is Nothing, "", FormCadPattern.TextBoxNome.Text.ToUpper))
        Command.Parameters.AddWithValue("@ACCOUNT", IIf(FormCadPattern.TextBoxAccount.Text Is Nothing, "", FormCadPattern.TextBoxAccount.Text.ToUpper))
        Command.Parameters.AddWithValue("@TAX", IIf(FormCadPattern.TextBoxTax.Text Is Nothing, "", FormCadPattern.TextBoxTax.Text.ToUpper))
        Command.Parameters.AddWithValue("@EMAIL", IIf(FormCadPattern.TextBoxEmail.Text Is Nothing, "", FormCadPattern.TextBoxEmail.Text))

        ConexaoOpen()
        Command.ExecuteNonQuery()
        conn.Close()

        CarregaCliente(FormCadPattern.ComboBoxNome)
        Cancelar()

    End Sub

    Public Shared Sub RemoveClient(ID)

        Dim sql As String
        Dim da As SqlDataAdapter
        Dim dt As DataTable
        Dim Command As SqlCommand

        sql = ""
        Sql = Sql & vbCrLf & "SELECT T.ID_CLIENTE"
        Sql = Sql & vbCrLf & "FROM CSRDB T"
        sql = sql & vbCrLf & "WHERE T.ID_CLIENTE = " & ID

        da = New SqlDataAdapter(sql, conn)
        dt = New DataTable
        da.Fill(dt)


        If dt.Rows.Count > 0 Then

            MsgBox("Atenção não é possivel Excluir este cliente pois já possui movimentação de Estoque")
            Exit Sub

        End If


        sql = ""
        sql = sql & vbCrLf & "SELECT T.ID_CLIENTE"
        sql = sql & vbCrLf & "FROM TBL_CONSIGNATARIO T"
        sql = sql & vbCrLf & "WHERE T.ID_CLIENTE  = " & ID

        da = New SqlDataAdapter(sql, conn)
        dt = New DataTable
        da.Fill(dt)


        If dt.Rows.Count > 0 Then

            MsgBox("Atenção não é possivel Excluir este cliente pois já possui um consignatário associado")
            Exit Sub

        End If

        sql = ""
        sql = sql & vbCrLf & "DELETE TBL_CAD_CLIENTE"
        sql = sql & vbCrLf & "WHERE ID = " & ID

        Command = New SqlCommand(sql, conn)

        ConexaoOpen()
        Command.ExecuteNonQuery()
        conn.Close()

        CarregaCliente(FormCadPattern.ComboBoxNome)
        Cancelar()


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

    Public Shared Sub ExcluiEmbranco(Grid As DataGridView)

        For Each Dgr As DataGridViewRow In Grid.Rows

            If Dgr.Cells("ColumnID").Value.ToString = "" Then
                Grid.Rows.Remove(Dgr)
            End If

        Next

    End Sub

    Public Shared Sub NovoContact(Grid As DataGridViewRow)

        Dim Command As SqlCommand

        Command = New SqlCommand()

        Command.CommandType = CommandType.StoredProcedure
        Command.CommandText = "InserirContact"

        Command.Connection = conn

        Command.Parameters.Add("@ID", SqlDbType.Int).Direction = ParameterDirection.Output
        Command.Parameters.Add("@ID_CLIENTE", SqlDbType.Int).Value = FormCadPattern.ComboBoxNome.SelectedValue
        Command.Parameters.Add("@NOME", SqlDbType.NVarChar).Value = IIf(Grid.Cells("ColumnNome").Value Is Nothing, "", Grid.Cells("ColumnNome").Value)
        Command.Parameters.Add("@FUNCAO", SqlDbType.NVarChar).Value = IIf(Grid.Cells("ColumnFuncao").Value Is Nothing, "", Grid.Cells("ColumnFuncao").Value)
        Command.Parameters.Add("@EMAIL", SqlDbType.NVarChar).Value = IIf(Grid.Cells("ColumnEmail").Value Is Nothing, "", Grid.Cells("ColumnEmail").Value)
        Command.Parameters.Add("@TEL1", SqlDbType.NVarChar).Value = IIf(Grid.Cells("ColumnTelefone1").Value Is Nothing, "", Grid.Cells("ColumnTelefone1").Value)
        Command.Parameters.Add("@TEL2", SqlDbType.NVarChar).Value = IIf(Grid.Cells("ColumnTelefone2").Value Is Nothing, "", Grid.Cells("ColumnTelefone2").Value)
        Command.Parameters.Add("@TEL3", SqlDbType.NVarChar).Value = IIf(Grid.Cells("ColumnTelefone3").Value Is Nothing, "", Grid.Cells("ColumnTelefone3").Value)

        ConexaoOpen()

        Command.ExecuteNonQuery()

        Grid.Cells("ColumnId").Value = Command.Parameters("@id").Value.ToString()

        conn.Close()

    End Sub

    Public Shared Sub UpdateContact(Grid As DataGridViewRow)

        Dim Command As SqlCommand
        Dim sql As String

        'aqui Atualiza os dados 
        sql = ""
        sql = sql & vbCrLf & "UPDATE TBL_CONTACT "
        sql = sql & vbCrLf & "   SET NOME = @NOME, FUNCAO = @FUNCAO, EMAIL = @EMAIL, TEL1 = @TEL1, TEL2 = @TEL2, TEL3 = @TEL3"
        sql = sql & vbCrLf & "WHERE ID = " & Grid.Cells("ColumnId").Value

        Command = New SqlCommand(sql, conn)

        Command.Parameters.Add("@NOME", SqlDbType.NVarChar).Value = IIf(Grid.Cells("ColumnNome").Value Is Nothing, "", Grid.Cells("ColumnNome").Value)
        Command.Parameters.Add("@FUNCAO", SqlDbType.NVarChar).Value = IIf(Grid.Cells("ColumnFuncao").Value Is Nothing, "", Grid.Cells("ColumnFuncao").Value)
        Command.Parameters.Add("@EMAIL", SqlDbType.NVarChar).Value = IIf(Grid.Cells("ColumnEmail").Value Is Nothing, "", Grid.Cells("ColumnEmail").Value)
        Command.Parameters.Add("@TEL1", SqlDbType.NVarChar).Value = IIf(Grid.Cells("ColumnTelefone1").Value Is Nothing, "", Grid.Cells("ColumnTelefone1").Value)
        Command.Parameters.Add("@TEL2", SqlDbType.NVarChar).Value = IIf(Grid.Cells("ColumnTelefone2").Value Is Nothing, "", Grid.Cells("ColumnTelefone2").Value)
        Command.Parameters.Add("@TEL3", SqlDbType.NVarChar).Value = IIf(Grid.Cells("ColumnTelefone3").Value Is Nothing, "", Grid.Cells("ColumnTelefone3").Value)

        ConexaoOpen()
        Command.ExecuteNonQuery()
        conn.Close()

    End Sub

    Public Shared Sub CarregaContact(Grid As DataGridView, id As Long)

        Dim sql As String
        Dim da As SqlDataAdapter
        Dim dt As DataTable

        sql = ""
        sql = sql & vbCrLf & "SELECT T.ID,"
        sql = sql & vbCrLf & "       T.NOME,"
        sql = sql & vbCrLf & "	   T.FUNCAO,"
        sql = sql & vbCrLf & "	   T.EMAIL,"
        sql = sql & vbCrLf & "	   T.TEL1,"
        sql = sql & vbCrLf & "	   T.TEL2,"
        sql = sql & vbCrLf & "	   T.TEL3 "
        sql = sql & vbCrLf & "FROM TBL_CONTACT T"
        sql = sql & vbCrLf & "WHERE T.ID_CLIENTE = " & id

        da = New SqlDataAdapter(sql, conn)
        dt = New DataTable
        da.Fill(dt)

        Grid.DataSource = dt

    End Sub

    Public Shared Sub DeteleContact(Grid As DataGridViewRow)

        Dim Command As SqlCommand
        Dim sql As String

        sql = ""
        sql = sql & vbCrLf & "DELETE TBL_TYPE"
        sql = sql & vbCrLf & "WHERE ID = " & Grid.Cells("ColumnID").Value

        Command = New SqlCommand(sql, conn)
        ConexaoOpen()
        Command.ExecuteNonQuery()
        conn.Close()

    End Sub

    Public Shared Sub CarregaGridCliente(Grid As DataGridView)

        Dim sql As String
        Dim da As SqlDataAdapter
        Dim dt As DataTable

        sql = ""
        sql = sql & vbCrLf & "SELECT T.ID,"
        sql = sql & vbCrLf & "       T.CLIENTE,"
        sql = sql & vbCrLf & "	     T.ACCOUNT,"
        sql = sql & vbCrLf & "	     T.TAX,"
        sql = sql & vbCrLf & "	     T.EMAIL"
        sql = sql & vbCrLf & "FROM TBL_CAD_CLIENTE T"

        da = New SqlDataAdapter(sql, conn)
        dt = New DataTable
        da.Fill(dt)

        bs = New BindingSource()
        bs.DataSource = dt
        Grid.DataSource = bs

    End Sub

    Public Shared Sub FiltrarDadosGrid(Coluna, Filtro)

        If Coluna = "" Then
            bs.Filter = ""
        Else

            Try
                bs.Filter = Coluna & " Like '%" & Filtro & "%'"
            Catch ex As Exception
                bs.Filter = Coluna & " = " & Filtro
            End Try
        End If


    End Sub


End Class
