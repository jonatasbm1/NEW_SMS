Imports System.Data.SqlClient
Imports SMS.FormCadConsignees

Public Class ClassFormCadConsignees
    Public Shared ModoAdd, ModoEdit As Long
    Shared bs As BindingSource

    Public Shared Sub HabilitaCadastro()

        If FormCadConsignees.TextBoxParceiro.Visible = False Then

            FormCadConsignees.TextBoxParceiro.Visible = True
            FormCadConsignees.ComboBoxConsignees.Visible = False
            FormCadConsignees.TextBoxDescricao.Enabled = True
            FormCadConsignees.ButtonSalvar.Enabled = True
            FormCadConsignees.ButtonCancelarCad.Enabled = True

            ModoAdd = 1
            ModoEdit = 0
        Else
            MsgBox("O Modo de criação já está abilitado")
            ModoEdit = 0
        End If

    End Sub

    Public Shared Sub HabilitarEdição()

        FormCadConsignees.TextBoxParceiro.Visible = True
        FormCadConsignees.TextBoxParceiro.Text = FormCadConsignees.ComboBoxConsignees.Text
        FormCadConsignees.ComboBoxConsignees.Visible = False
        FormCadConsignees.TextBoxDescricao.Enabled = True
        FormCadConsignees.ButtonSalvar.Enabled = True
        FormCadConsignees.ButtonCancelarCad.Enabled = True

        ModoEdit = 1
        ModoAdd = 0

    End Sub

    Public Shared Sub Cancelar()

        FormCadConsignees.TextBoxParceiro.Text = ""
        FormCadConsignees.TextBoxParceiro.Visible = False

        FormCadConsignees.ComboBoxConsignees.Text = ""
        FormCadConsignees.ComboBoxConsignees.Visible = True

        FormCadConsignees.TextBoxDescricao.Text = ""
        FormCadConsignees.TextBoxDescricao.Enabled = False

        FormCadConsignees.ButtonSalvar.Enabled = False
        FormCadConsignees.ButtonCancelarCad.Enabled = False

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


    End Sub

    Public Shared Sub CarregaConsignees(Combo As ComboBox, IdCliente As Long, Optional ByVal ID As Long = 0)

        Dim sql As String
        Dim da As SqlDataAdapter
        Dim dt As DataTable

        sql = ""
        sql = sql & vbCrLf & "SELECT T.ID,"
        sql = sql & vbCrLf & "       T.NOME"
        sql = sql & vbCrLf & "FROM TBL_CONSIGNATARIO T"
        sql = sql & vbCrLf & "WHERE T.ID_CLIENTE = " & IdCliente


        da = New SqlDataAdapter(sql, conn)
        dt = New DataTable
        da.Fill(dt)
        Combo.DataSource = dt

        Combo.DisplayMember = "NOME"
        Combo.ValueMember = "ID"

        If ID <> 0 Then

            Combo.SelectedValue = ID
            ID = 0

        End If


    End Sub

    Public Shared Sub NovoConsignees()

        Dim Command As SqlCommand
        Dim id As Long

        If FormCadConsignees.TextBoxParceiro.Text = "" Then

            MsgBox("Atenção o Nome do Consignees não pode estar em branco!!!")
            Exit Sub

        End If

        Command = New SqlCommand()

        Command.CommandType = CommandType.StoredProcedure
        Command.CommandText = "InserirConsignees"

        Command.Connection = conn

        Command.Parameters.Add("@ID", SqlDbType.Int).Direction = ParameterDirection.Output
        Command.Parameters.Add("@ID_CLIENTE", SqlDbType.NVarChar).Value = IIf(FormCadConsignees.ComboBoxCliente.SelectedValue Is Nothing, "", FormCadConsignees.ComboBoxCliente.SelectedValue)
        Command.Parameters.Add("@NOME", SqlDbType.NVarChar).Value = IIf(FormCadConsignees.TextBoxParceiro.Text Is Nothing, "", FormCadConsignees.TextBoxParceiro.Text.ToUpper)
        Command.Parameters.Add("@DESCRICAO", SqlDbType.NVarChar).Value = IIf(FormCadConsignees.TextBoxDescricao.Text Is Nothing, "", FormCadConsignees.TextBoxDescricao.Text.ToUpper)

        ConexaoOpen()

        Command.ExecuteNonQuery()

        id = Command.Parameters("@id").Value.ToString()

        conn.Close()

        CarregaConsignees(FormCadConsignees.ComboBoxConsignees, FormCadConsignees.ComboBoxCliente.SelectedValue, id)

        Cancelar()

    End Sub

    Public Shared Sub CarregaCampos(Id As Long)

        Dim sql As String
        Dim da As SqlDataAdapter
        Dim dt As DataTable

        sql = ""
        sql = sql & vbCrLf & "SELECT T.ID,"
        sql = sql & vbCrLf & "       T.NOME,"
        sql = sql & vbCrLf & "       T.DESCRICAO"
        sql = sql & vbCrLf & "FROM TBL_CONSIGNATARIO T"
        sql = sql & vbCrLf & "WHERE T.ID = " & Id


        da = New SqlDataAdapter(sql, conn)
        dt = New DataTable
        da.Fill(dt)

        FormCadConsignees.TextBoxDescricao.Text = ""

        If dt.Rows.Count > 0 Then

            FormCadConsignees.TextBoxDescricao.Text = dt.Rows(0)("DESCRICAO").ToString

        End If

    End Sub

    Public Shared Sub UpdateConsignees(ID)


        Dim Command As SqlCommand
        Dim sql As String

        'aqui Atualiza os dados 
        sql = ""
        sql = sql & vbCrLf & "UPDATE TBL_CONSIGNATARIO "
        sql = sql & vbCrLf & "   SET NOME = @NOME, DESCRICAO = @DESCRICAO"
        sql = sql & vbCrLf & "WHERE ID = " & ID

        Command = New SqlCommand(sql, conn)
        Command.Parameters.AddWithValue("@NOME", IIf(FormCadConsignees.TextBoxParceiro.Text Is Nothing, "", FormCadConsignees.TextBoxParceiro.Text.ToUpper))
        Command.Parameters.AddWithValue("@DESCRICAO", IIf(FormCadConsignees.TextBoxDescricao.Text Is Nothing, "", FormCadConsignees.TextBoxDescricao.Text.ToUpper))

        ConexaoOpen()
        Command.ExecuteNonQuery()
        conn.Close()

        CarregaConsignees(FormCadConsignees.ComboBoxConsignees, FormCadConsignees.ComboBoxCliente.SelectedValue)
        Cancelar()

    End Sub

    Public Shared Sub RemoveConsignees(ID)

        Dim sql As String
        Dim da As SqlDataAdapter
        Dim dt As DataTable
        Dim Command As SqlCommand


        If ID = Nothing Then

            MsgBox("É necessário selecionar um Consignees antes de continuar.")
            Exit Sub

        End If


        sql = ""
        sql = sql & vbCrLf & "SELECT T.ID_CONSIGNATARIO"
        sql = sql & vbCrLf & "FROM CSRDB T"
        sql = sql & vbCrLf & "WHERE T.ID_CONSIGNATARIO = " & ID

        da = New SqlDataAdapter(sql, conn)
        dt = New DataTable
        da.Fill(dt)


        If dt.Rows.Count > 0 Then

            MsgBox("Atenção não é possivel Excluir este Consignees pois já possui movimentação de Estoque")
            Exit Sub

        End If

        sql = ""
        sql = sql & vbCrLf & "DELETE TBL_CAD_CLIENTE"
        sql = sql & vbCrLf & "WHERE ID = " & ID

        Command = New SqlCommand(sql, conn)

        ConexaoOpen()
        Command.ExecuteNonQuery()
        conn.Close()

        CarregaConsignees(FormCadConsignees.ComboBoxConsignees, FormCadConsignees.ComboBoxCliente.SelectedValue)
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

        Try

            For Each Dgr As DataGridViewRow In Grid.Rows

                If Dgr.Cells("ColumnID").Value.ToString = "" Then
                    Grid.Rows.Remove(Dgr)
                End If

            Next

        Catch ex As Exception

            For Each Dgr As DataGridViewRow In Grid.Rows

                If Dgr.Cells("ColumnAID").Value.ToString = "" Then
                    Grid.Rows.Remove(Dgr)
                End If

            Next

        End Try


    End Sub

    Public Shared Sub NovoContact(Grid As DataGridViewRow)

        Dim Command As SqlCommand

        Command = New SqlCommand()

        Command.CommandType = CommandType.StoredProcedure
        Command.CommandText = "InserirContactConsignees"

        Command.Connection = conn

        Command.Parameters.Add("@ID", SqlDbType.Int).Direction = ParameterDirection.Output
        Command.Parameters.Add("@ID_CONSIGNEE", SqlDbType.Int).Value = FormCadConsignees.DataGridViewConsignees.CurrentRow.Cells("ColumnCid").Value
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

    Public Shared Sub NovoAdress(Grid As DataGridViewRow)

        Dim Command As SqlCommand

        Command = New SqlCommand()

        Command.CommandType = CommandType.StoredProcedure
        Command.CommandText = "InserirAdressConsig"

        Command.Connection = conn
        'DataGridViewConsignees.CurrentRow.Cells("ColumnCid").Value
        Command.Parameters.Add("@ID", SqlDbType.Int).Direction = ParameterDirection.Output
        'MsgBox(FormCadConsignees.DataGridViewConsignees.CurrentRow.Cells("ColumnCid").Value)
        Command.Parameters.Add("@ID_CONSIGNEES", SqlDbType.Int).Value = FormCadConsignees.DataGridViewConsignees.CurrentRow.Cells("ColumnCid").Value
        Command.Parameters.Add("@NAME", SqlDbType.NVarChar).Value = IIf(Grid.Cells("ColumnANome").Value Is Nothing, "", Grid.Cells("ColumnANome").Value)
        Command.Parameters.Add("@ENDERECO", SqlDbType.NVarChar).Value = IIf(Grid.Cells("ColumnAEndereco").Value Is Nothing, "", Grid.Cells("ColumnAEndereco").Value)
        Command.Parameters.Add("@NUMERO", SqlDbType.NVarChar).Value = IIf(Grid.Cells("ColumnANumero").Value Is Nothing, "", Grid.Cells("ColumnANumero").Value)
        Command.Parameters.Add("@COMPLEMENTO", SqlDbType.NVarChar).Value = IIf(Grid.Cells("ColumnAComplemento").Value Is Nothing, "", Grid.Cells("ColumnAComplemento").Value)
        Command.Parameters.Add("@BAIRRO", SqlDbType.NVarChar).Value = IIf(Grid.Cells("ColumnABairro").Value Is Nothing, "", Grid.Cells("ColumnABairro").Value)
        Command.Parameters.Add("@CIDADE", SqlDbType.NVarChar).Value = IIf(Grid.Cells("ColumnACidade").Value Is Nothing, "", Grid.Cells("ColumnACidade").Value)
        Command.Parameters.Add("@ESTADO", SqlDbType.NVarChar).Value = IIf(Grid.Cells("ColumnAEstado").Value Is Nothing, "", Grid.Cells("ColumnAEstado").Value)
        Command.Parameters.Add("@EMAIL", SqlDbType.NVarChar).Value = IIf(Grid.Cells("ColumnAEmail").Value Is Nothing, "", Grid.Cells("ColumnAEmail").Value)
        Command.Parameters.Add("@TEL1", SqlDbType.NVarChar).Value = IIf(Grid.Cells("ColumnATel1").Value Is Nothing, "", Grid.Cells("ColumnATel1").Value)
        Command.Parameters.Add("@TEL2", SqlDbType.NVarChar).Value = IIf(Grid.Cells("ColumnATel2").Value Is Nothing, "", Grid.Cells("ColumnATel2").Value)
        Command.Parameters.Add("@TEL3", SqlDbType.NVarChar).Value = IIf(Grid.Cells("ColumnATel3").Value Is Nothing, "", Grid.Cells("ColumnATel3").Value)
        Command.Parameters.Add("@OBS", SqlDbType.NVarChar).Value = IIf(Grid.Cells("ColumnObs").Value Is Nothing, "", Grid.Cells("ColumnObs").Value)

        ConexaoOpen()

        Command.ExecuteNonQuery()

        Grid.Cells("ColumnAid").Value = Command.Parameters("@id").Value.ToString()

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

    Public Shared Sub UpdateAdress(Grid As DataGridViewRow)

        Dim Command As SqlCommand
        Dim sql As String

        'aqui Atualiza os dados 
        sql = ""
        sql = sql & vbCrLf & "UPDATE TBL_ADRESS_CONSIG "
        sql = sql & vbCrLf & "   SET NAME = @NAME, ENDERECO = @ENDERECO, NUMERO = @NUMERO, COMPLEMENTO = @COMPLEMENTO, BAIRRO = @BAIRRO, CIDADE = @CIDADE, ESTADO = @ESTADO, EMAIL = @EMAIL, TEL1 = @TEL1, TEL2 = @TEL2, TEL3 = @TEL3, OBS = @OBS "
        sql = sql & vbCrLf & "WHERE ID = " & Grid.Cells("ColumnAId").Value

        Command = New SqlCommand(sql, conn)

        Command.Parameters.Add("@NAME", SqlDbType.NVarChar).Value = IIf(Grid.Cells("ColumnANome").Value Is Nothing, "", Grid.Cells("ColumnANome").Value)
        Command.Parameters.Add("@ENDERECO", SqlDbType.NVarChar).Value = IIf(Grid.Cells("ColumnAEndereco").Value Is Nothing, "", Grid.Cells("ColumnAEndereco").Value)
        Command.Parameters.Add("@NUMERO", SqlDbType.NVarChar).Value = IIf(Grid.Cells("ColumnANumero").Value Is Nothing, "", Grid.Cells("ColumnANumero").Value)
        Command.Parameters.Add("@COMPLEMENTO", SqlDbType.NVarChar).Value = IIf(Grid.Cells("ColumnAComplemento").Value Is Nothing, "", Grid.Cells("ColumnAComplemento").Value)
        Command.Parameters.Add("@BAIRRO", SqlDbType.NVarChar).Value = IIf(Grid.Cells("ColumnABairro").Value Is Nothing, "", Grid.Cells("ColumnABairro").Value)
        Command.Parameters.Add("@CIDADE", SqlDbType.NVarChar).Value = IIf(Grid.Cells("ColumnACidade").Value Is Nothing, "", Grid.Cells("ColumnACidade").Value)
        Command.Parameters.Add("@ESTADO", SqlDbType.NVarChar).Value = IIf(Grid.Cells("ColumnAEstado").Value Is Nothing, "", Grid.Cells("ColumnAEstado").Value)
        Command.Parameters.Add("@EMAIL", SqlDbType.NVarChar).Value = IIf(Grid.Cells("ColumnAEmail").Value Is Nothing, "", Grid.Cells("ColumnAEmail").Value)
        Command.Parameters.Add("@TEL1", SqlDbType.NVarChar).Value = IIf(Grid.Cells("ColumnATel1").Value Is Nothing, "", Grid.Cells("ColumnATel1").Value)
        Command.Parameters.Add("@TEL2", SqlDbType.NVarChar).Value = IIf(Grid.Cells("ColumnATel2").Value Is Nothing, "", Grid.Cells("ColumnATel2").Value)
        Command.Parameters.Add("@TEL3", SqlDbType.NVarChar).Value = IIf(Grid.Cells("ColumnATel3").Value Is Nothing, "", Grid.Cells("ColumnATel3").Value)
        Command.Parameters.Add("@OBS", SqlDbType.NVarChar).Value = IIf(Grid.Cells("ColumnObs").Value Is Nothing, "", Grid.Cells("ColumnObs").Value)

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
        sql = sql & vbCrLf & "	     T.FUNCAO,"
        sql = sql & vbCrLf & "	     T.EMAIL,"
        sql = sql & vbCrLf & "	     T.TEL1,"
        sql = sql & vbCrLf & "	     T.TEL2,"
        sql = sql & vbCrLf & "	     T.TEL3 "
        sql = sql & vbCrLf & "FROM TBL_CONTACT T"
        sql = sql & vbCrLf & "WHERE T.ID_CONSIGNEE = " & id

        da = New SqlDataAdapter(sql, conn)
        dt = New DataTable
        da.Fill(dt)

        Grid.DataSource = dt

    End Sub

    Public Shared Sub CarregaAdress(Grid As DataGridView, id As Long)

        Dim sql As String
        Dim da As SqlDataAdapter
        Dim dt As DataTable

        sql = ""
        sql = sql & vbCrLf & "SELECT T.ID,"
        sql = sql & vbCrLf & "       T.NAME,"
        sql = sql & vbCrLf & "	   T.ENDERECO,"
        sql = sql & vbCrLf & "	   T.NUMERO,"
        sql = sql & vbCrLf & "	   T.COMPLEMENTO,"
        sql = sql & vbCrLf & "	   T.BAIRRO,"
        sql = sql & vbCrLf & "	   T.CIDADE,"
        sql = sql & vbCrLf & "	   T.ESTADO,"
        sql = sql & vbCrLf & "	   T.EMAIL,"
        sql = sql & vbCrLf & "	   T.TEL1,"
        sql = sql & vbCrLf & "	   T.TEL2,"
        sql = sql & vbCrLf & "	   T.TEL3,"
        sql = sql & vbCrLf & "	   T.OBS "
        sql = sql & vbCrLf & "FROM TBL_ADRESS_CONSIG T"
        sql = sql & vbCrLf & "WHERE T.ID_CONSIGNEES = " & id


        da = New SqlDataAdapter(sql, conn)
        dt = New DataTable
        da.Fill(dt)

        Grid.DataSource = dt

    End Sub

    Public Shared Sub DeteleContact(Grid As DataGridViewRow)

        Dim Command As SqlCommand
        Dim sql As String

        sql = ""
        sql = sql & vbCrLf & "DELETE TBL_CONTACT"
        sql = sql & vbCrLf & "WHERE ID = " & Grid.Cells("ColumnID").Value

        Command = New SqlCommand(sql, conn)
        ConexaoOpen()
        Command.ExecuteNonQuery()
        conn.Close()

    End Sub

    Public Shared Sub DeteleAdress(Grid As DataGridViewRow)

        Dim Command As SqlCommand
        Dim sql As String

        sql = ""
        sql = sql & vbCrLf & "DELETE TBL_ADRESS_CONSIG"
        sql = sql & vbCrLf & "WHERE ID = " & Grid.Cells("ColumnAID").Value

        Command = New SqlCommand(sql, conn)
        ConexaoOpen()
        Command.ExecuteNonQuery()
        conn.Close()

    End Sub

    Public Shared Sub CarregaGridConsignees(Grid As DataGridView, ID As Long)

        Dim sql As String
        Dim da As SqlDataAdapter
        Dim dt As DataTable

        sql = ""
        sql = sql & vbCrLf & "Select T.ID,"
        sql = sql & vbCrLf & "       T.NOME,"
        sql = sql & vbCrLf & "	     T.DESCRICAO"
        sql = sql & vbCrLf & "FROM TBL_CONSIGNATARIO T"
        sql = sql & vbCrLf & "WHERE T.ID_CLIENTE  = " & ID

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
