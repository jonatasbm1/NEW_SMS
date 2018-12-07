Imports System.Data.SqlClient

Module ModuleConexao

    Public conn As New SqlConnection("Data Source=ROBSON-PC\SQLEXPRESS;Initial Catalog=CSRDataBase;Persist Security Info=True;User ID=user_teste;Password=123")
    'Public conn As New SqlConnection("Data Source=PFT-SAMLPT;Initial Catalog=CSRDataBase;Integrated Security=True")

    Public Sub ConexaoOpen()
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
    End Sub

    Public Sub ExportGridExcellGeral()

    End Sub

End Module
