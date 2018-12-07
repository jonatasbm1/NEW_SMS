Imports System.Data.SqlClient
Module MigraDadosAntigo

    Public Sub Ligar_Filhos()

        'Aqui Carrega os Dados e envia para o Grid
        'e carrega no listbox

        Dim sql As String
        Dim da As SqlDataAdapter
        Dim dt, DtItensEntrada As DataTable

        sql = ""
        sql = sql & vbCrLf & "SELECT T.ID,"
        sql = sql & vbCrLf & "       T.ID_LIGACAO,"
        sql = sql & vbCrLf & "       T.PRODUCT,"
        sql = sql & vbCrLf & "	     T.DESCRIPTION,"
        sql = sql & vbCrLf & "	     T.REFERENCE,"
        sql = sql & vbCrLf & "	     T.TYPE,"
        sql = sql & vbCrLf & "	     T.CONSIGNEE,"
        sql = sql & vbCrLf & "	     T.DATE,"
        sql = sql & vbCrLf & "	     T.QUANTITY,"
        sql = sql & vbCrLf & "	     T.UQ,"
        sql = sql & vbCrLf & "	     T.PLT_SPACES,"
        sql = sql & vbCrLf & "	     T.LOCATION"
        sql = sql & vbCrLf & "FROM CSRDB T"
        sql = sql & vbCrLf & "ORDER BY T.PRODUCT,"
        sql = sql & vbCrLf & "T.Date, T.ID"

        da = New SqlDataAdapter(sql, conn)
        dt = New DataTable
        da.Fill(dt)

        Dim Dtv As DataView = dt.DefaultView

        'Aqui faço um filtro Simples pegando os codigos dos itens de Forma unica sem Repetição
        'Fernando Existe Varias Formas de fazer isso ue estou Fazendo kkkkk 
        'Poderia ser Filtro Dentro da Propria consulta porem eu preferi Fazer uma Consulta que traz tudo 
        'e saio fazendo filtros dentro do data table ou dentro do Dtviwer sem a nessecidade de fazer varias consultas ao Banco
        'Apenas Trabalhando com os dados já alocado na memoria.
        'Bora lá ?

        'Aqui copia os dados que está no Dtviwer para o DtTable, Copiando Apenas o Campo Product e eliminando os Duplicados
        'este TRUE aqui em embaixo Siguinifica que ele vai eliminar os Duplicados
        DtItensEntrada = Dtv.ToTable(True, "PRODUCT")


        'Agora Vamos Fazer um For para Percorrer estes registros e usa-los de filtro para os Proximos passos
        For Each DrProdutosBase As DataRow In DtItensEntrada.Rows

            'Agora Vamos Trabalhar Item a Item e fazer as Analises para fazer as ligações corretas dos itens Pais para os Itens Filhos
            'Observe que Abaixo ele Apenas ira pegar os Itens do primeiro Laço e mais a condição ORD
            For Each DrItensPai As DataRow In dt.Select("PRODUCT = " & DrProdutosBase("PRODUCT") & " AND TYPE = 'INW'", "DATE, ID ASC")

                Dim ValorEntrada As Long

                ValorEntrada = 0
                ValorEntrada = DrItensPai("QUANTITY")

                'Agora Vamos Fazer mais laço porem desta vez pegaremos todos os movimentos menos os de Entrada
                'e desta forma Vamos Fazer os Vinculos de Itens Pai e filho
                'Vamos Declarar uma Variavel Para Carregar a Quantidade de Entrada de Estoque do Item Pai e Usarmos ela de Parametro Para Mudar para a 
                'proxima entrada olu Item Pai

                For Each DrItensFilho As DataRow In dt.Select("PRODUCT = " & DrItensPai("PRODUCT") & " AND TYPE <> 'INW'", "DATE, ID ASC")

                    'Agora aqui Vamos Fazer algumas Tratativas de acordo com Cada tipo ou parametro de lançamento
                    'Tudo que for ORD ou Baixa de estoque iremos subtrair do valor de entrada e iremos colocar o id do item pai no Item filho
                    'Tudo que for ADJ ou Ajuste de estoque iremos somar do valor de entrada e iremos colocar o id do item pai no Item filho
                    'Tudo que for TFR ou tranferencia iremos apenas colocar o id do item pai no Item filho
                    'Lembrando que na Consulta Principal os item vem ordenado por Item e por data de execução Sendo assim iremos seguir a ordem Cronologica dos acontecimentos

                    If DrItensFilho("TYPE").ToString = "ORD" Then
                        ValorEntrada = ValorEntrada + DrItensFilho("QUANTITY")
                        AtualizaItemFilho(DrItensPai("ID"), DrItensFilho("ID"))
                    ElseIf DrItensFilho("TYPE").ToString = "ADJ" Then
                        ValorEntrada = ValorEntrada + DrItensFilho("QUANTITY")
                        AtualizaItemFilho(DrItensPai("ID"), DrItensFilho("ID"))
                    ElseIf DrItensFilho("TYPE").ToString = "TFR" Then
                        AtualizaItemFilho(DrItensPai("ID"), DrItensFilho("ID"))
                    End If

                    DrItensFilho.Delete()

                    If ValorEntrada <= 0 Then
                        Exit For
                    End If

                Next

            Next

        Next

        MsgBox("OK")
    End Sub

    Private Sub AtualizaItemFilho(IdPai, IdFilho)

        Dim Command As SqlCommand
        Dim sql As String

        'aqui Atualiza os dados 
        sql = ""
        sql = sql & vbCrLf & "UPDATE CSRDB "
        sql = sql & vbCrLf & "   SET ID_LIGACAO = @ID_LIGACAO"
        sql = sql & vbCrLf & "WHERE ID = " & IdFilho

        Command = New SqlCommand(sql, conn)
        Command.Parameters.AddWithValue("@ID_LIGACAO", IdPai)
        ConexaoOpen()
        Command.ExecuteNonQuery()
        conn.Close()

    End Sub

    Public Sub AtualizaTypeUq()

        Dim Command As SqlCommand
        Dim sql As String

        'aqui Atualiza os dados 
        sql = ""
        sql = sql & vbCrLf & "UPDATE CSRDB SET"
        sql = sql & vbCrLf & "CSRDB.ID_TYPE = GERAL.ID_TYPE,"
        sql = sql & vbCrLf & "CSRDB.ID_UQ = GERAL.ID_UQ,"
        sql = sql & vbCrLf & "CSRDB.ID_LOCATION = Geral.ID_LOCATION"
        sql = sql & vbCrLf & "FROM (Select CSRDB.ID,"
        sql = sql & vbCrLf & "			 CSRDB.PRODUCT,"
        sql = sql & vbCrLf & "			 CSRDB.TYPE,"
        sql = sql & vbCrLf & "			 CSRDB.UQ,"
        sql = sql & vbCrLf & "			 TBL_TYPE.ID As ID_TYPE,"
        sql = sql & vbCrLf & "			 TBL_UQ.ID AS ID_UQ,"
        sql = sql & vbCrLf & "			 TBL_LOCATION.ID AS ID_LOCATION"
        sql = sql & vbCrLf & "	 FROM CSRDB"
        sql = sql & vbCrLf & "	 LEFT JOIN TBL_TYPE ON"
        sql = sql & vbCrLf & "	 TBL_TYPE.TYPE = CSRDB.TYPE"
        sql = sql & vbCrLf & "	 LEFT JOIN TBL_UQ ON"
        sql = sql & vbCrLf & "	 TBL_UQ.UQ = CSRDB.UQ"
        sql = sql & vbCrLf & "	 LEFT JOIN TBL_LOCATION ON"
        sql = sql & vbCrLf & "	 TBL_LOCATION.LOCATION = CSRDB.LOCATION"
        sql = sql & vbCrLf & "	 ) GERAL"
        sql = sql & vbCrLf & "WHERE CSRDB.ID = GERAL.ID "

        Command = New SqlCommand(sql, conn)
        ConexaoOpen()
        Command.ExecuteNonQuery()
        conn.Close()

    End Sub

End Module
