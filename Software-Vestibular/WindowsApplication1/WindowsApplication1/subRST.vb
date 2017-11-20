'Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient

Public Module subRST
    'Public Conexao As New MySqlConnection
    'Public Comando As New MySqlCommand

    'Public myAdapter As New MySqlDataAdapter
    'Public cmdBuild As MySqlCommandBuilder

    Public myData As New DataTable
    'Dim lngRow As Long
    'Public conn As New MySql.Data.MySqlClient.MySqlConnection
    'Public myConnectionString As String
    'Public VerficaConexao As Boolean = False
    Public cmd As SqlCommand
    Public dt As DataTable
    Public da As SqlDataAdapter
    Public cnnSql As SqlConnection
    Public ds As DataSet
    Public registro As Integer
    Public strcon As String

    Public fMainPrincipal As frmMain

    'Public Sub cnnMysql(ByRef strSql As String)
    'Conexao = New MySqlConnection

    'If Not Conexao Is Nothing Then Conexao.Close()
    'Conexao.ConnectionString = "server=localhost;user id=root;password='';database=bdvestibular"
    'Conexao.ConnectionString = "DRIVER={MySQL ODBC 5.1 Driver};server=localhost;user id=root;password='';database=bdvestibular"
    'Try
    'Conexao.Open()
    'Try
    'Comando.Connection = Conexao
    'Comando.CommandText = strSql
    'myAdapter.SelectCommand = Comando
    'myAdapter.Fill(myData)

    'Catch myerro As MySqlException
    '   MsgBox("Erro de leitura no banco de dados : " & myerro.Message)
    'End Try

    'Conexao.Close()
    'Catch myerro As MySqlException
    '   MessageBox.Show("Erro ao conectar com o Banco de dados : " & myerro.Message)
    'Finally
    'Conexao.Dispose()
    'End Try
    'End Sub

    Public Sub ConexaoSql()

        'strcon = "Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Felipe\Documents\bdVestibular.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"

        strcon = "data source=FELIPE-PC\SQLEXPRESS;User Id=FELIPE-PC\Felipe;Password=;Initial Catalog=bdVestibular;integrated security=true;"

        Try
            'cria um dataset , preenche e carrega a tabela clientes
            cnnSql = New SqlConnection(strcon)
        Catch ex As Exception
            MessageBox.Show("Erro: " & ex.Message, "Sem conexão", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try


    End Sub
    Private Sub FechaConexao(ByVal cnn As SqlConnection)
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
    End Sub
    'Public Sub CreateMySqlDataReader(ByVal mySelectQuery As String, ByVal myConnection As MySqlConnection)
    'Dim myCommand As New MySqlCommand(mySelectQuery, myConnection)
    '    myConnection.Open()
    'Dim myReader As MySqlDataReader
    'myReader = myCommand.ExecuteReader()
    '   Try
    '   While myReader.Read()
    'Console.WriteLine(myReader.GetString(0))
    'End While
    '  Finally
    'myReader.Close()
    '     myConnection.Close()
    'End Try
    'End Sub


    'Public Function ExecuteDR(ByVal sql As String) As MySqlDataReader

    'Dim dr As MySqlDataReader = Nothing

    'Try

    '   Comando.CommandType = CommandType.Text
    '   Comando.CommandText = sql
    '   Comando.Connection = Conexao

    'dr = Comando.ExecuteReader
    'Comando.Dispose()
    'Return dr
    '   Catch ex As Exception
    '      MsgBox(ex.Message)
    '    End Try
    'Return dr

    'End Function

    Public Sub frmLoad(ByVal frm As Form)
        'If frm.IsMdiChild = True Then frm.ShowDialog()
        If frm.Name <> "frmLista" Or frm.Name <> "frmBotoesVert" Then
            frm.ShowDialog()
        End If
    End Sub
    Public Function GetDataTable(ByVal Query As String) As DataTable
        Dim Table As New DataTable
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(Query, cnnSql)
        da.Fill(ds, Query)
        Table = ds.Tables(0)
        Return Table
    End Function

    '    Public Sub CreateMySqlCommand(ByVal myConnection As MySqlConnection, _
    'ByVal mySelectQuery As String, ByVal myParamArray() As MySqlParameter)
    '   Dim myCommand As New MySqlCommand(mySelectQuery, myConnection)
    '      myCommand.CommandText = "SELECT id, name FROM mytable WHERE age=?age"
    '     myCommand.UpdatedRowSource = UpdateRowSource.Both
    '    myCommand.Parameters.Add(myParamArray)
    'Dim j As Integer
    '    For j = 0 To myCommand.Parameters.Count - 1
    '      myCommand.Parameters.Add(myParamArray(j))
    '   Next j
    'Dim myMessage As String = ""
    'Dim i As Integer
    '    For i = 0 To myCommand.Parameters.Count - 1
    '        myMessage += myCommand.Parameters(i).ToString() & ControlChars.Cr
    '    Next i
    '    Console.WriteLine(myMessage)
    'End Sub

    'Public Sub CreateMySqlCommand1()
    '    Dim mySelectQuery As String = "SELECT * FROM mytable ORDER BY id"
    '    Dim myConnectString As String = "Persist Security Info=False;database=test;server=myServer"
    '    Dim myCommand As New MySqlCommand(mySelectQuery)
    '    myCommand.Connection = New MySqlConnection(myConnectString)
    '    myCommand.CommandType = CommandType.Text
    'End Sub
    'Public Sub CreateMySqlCommand2()
    '    Dim myCommand As New MySqlCommand()
    '    myCommand.CommandType = CommandType.Text
    'End Sub
    'Public Sub CreateMySqlCommand3()
    '    Dim myCommand As New MySqlCommand()
    '    myCommand.CommandText = "SELECT * FROM Mytable ORDER BY id"
    '    myCommand.CommandType = CommandType.Text
    'End Sub

    'Public Sub CreateMySqlCommand4(ByVal myScalarQuery As String, ByVal myConnection As MySqlConnection)
    '    Dim myCommand As New MySqlCommand(myScalarQuery, myConnection)
    '    myCommand.Connection.Open()
    '    myCommand.ExecuteScalar()
    '    myConnection.Close()
    'End Sub

End Module


