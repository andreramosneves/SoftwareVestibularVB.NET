'Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Data.Sql

Public Class frmMain

    Dim strSql As String
    Dim lngRow As Long
    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        subLoad()
    End Sub


    Private Sub subLoad()

        strSql = vbNullString
        strSql = "SELECT * " & vbCr & _
                "FROM" & vbCr & _
                "[DBO]._ROTINAS"

        ConexaoSql()

        cnnSql.Open()

        Dim cmd As New SqlCommand

        With cmd
            .CommandText = strSql.ToString
            .CommandType = CommandType.Text
            .Connection = cnnSql
            .ExecuteNonQuery()
        End With


        

        Dim MDIChildBotao As New frmBotoesVert()

        'Pega as Colunas de  um Objeto 
        'For i = 0 To ds.Tables(0).Columns.Count - 1
        'MDIChildBotao.ListCadastro.Items.Add(ds.Tables(0).Columns(i).ColumnName.ToString)
        'Next i
        'Termina Aqui

        '================ROTINA PARA PREENCHER AS LISTAS==================
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader(CommandBehavior.SingleResult)

        If dr.HasRows Then
            While dr.Read
                If CLng(dr.Item(3).ToString) = 1 And CLng(dr.Item(2).ToString) Then
                    MDIChildBotao.ListCadastro.Items.Add(dr.Item(1).ToString & "                              ")
                ElseIf CLng(dr.Item(3).ToString) = 2 And CLng(dr.Item(2).ToString) = 1 Then
                    MDIChildBotao.ListEstudar.Items.Add(dr.Item(1).ToString & "                               ")
                ElseIf CLng(dr.Item(3).ToString) = 3 And CLng(dr.Item(2).ToString) = 1 Then
                    MDIChildBotao.ListPraticar.Items.Add(dr.Item(1).ToString & "                              ")
                ElseIf CLng(dr.Item(3).ToString) = 4 And CLng(dr.Item(2).ToString) = 1 Then
                    MDIChildBotao.ListRelatorio.Items.Add(dr.Item(1).ToString & "                             ")
                End If
            End While

        End If

        '===========TERMINA AQUI====================
        dr.Close()
        cnnSql.Close()

        MDIChildBotao.MdiParent = Me
        MDIChildBotao.Show()

        'cmd.Cancel()
        
        'MDIChildLista.DataGridView1.DataSource = cmd
        'dr = cmd.ExecuteReader
        '========IDÉIA CAMPIN ANALISE DE LIVROS PARA O VESTIBULAR===========
    End Sub

    Private Sub SairToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SairToolStripMenuItem.Click

        Me.Close()
    End Sub

    'frmLoad(frmLista)
    'End Sub
    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub


End Class