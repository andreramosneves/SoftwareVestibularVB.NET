Imports System.Data.SqlClient
Imports System.Data.Sql

Public Class clsQuestao

    Dim blnBotoes As Boolean
    Dim strSql As String
    Dim arrStatus() As String
    Dim objToolTip As ToolTip
    Dim blnBalao As Boolean = False
    Dim i As Integer
    Dim Tipo As TipoDeAlteracao
    Public blnEdit As Boolean
    Public blnInsert As Boolean
    Dim blnChange As Boolean
    Private Enum TipoDeAlteracao

        FORM_SALVO = 0
        FORM_CANCELADO = 1
        FORM_SEM_EDICAO = 2
        FORM_COM_EDICAO = 3
        FORM_NAO_SALVO = 4

    End Enum



    Public Sub Finaliza()
        frmDisciplinas.Dispose()
        frmDisciplinas.Close()

    End Sub
    Public Function funClose() As Boolean
        Dim str As String

        If blnEdit Or blnInsert Then

            str = IIf(blnEdit, "alterar", "incluir")

            If (MsgBox("Você realmente deseja " & str & " os dados?", MsgBoxStyle.YesNo + vbQuestion, "Atenção!!")) = vbYes Then
                If blnChange <> False Then
                    If funValidaSalvar() Then
                        Tipo = TipoDeAlteracao.FORM_NAO_SALVO

                    Else
                        Tipo = TipoDeAlteracao.FORM_COM_EDICAO
                    End If
                Else
                    Tipo = TipoDeAlteracao.FORM_SEM_EDICAO
                End If
            Else
                Tipo = TipoDeAlteracao.FORM_CANCELADO
            End If
            Select Case Tipo
                Case TipoDeAlteracao.FORM_CANCELADO, TipoDeAlteracao.FORM_SEM_EDICAO, TipoDeAlteracao.FORM_NAO_SALVO
                    str = "Alteração"
                    MsgBox(str & " não realizada!!!", vbExclamation, "Atenção")
                Case TipoDeAlteracao.FORM_COM_EDICAO
                    If funSave() Then
                        Tipo = TipoDeAlteracao.FORM_SALVO
                        MsgBox(IIf(blnEdit, "Alteração", "Inclusão") & " realizada com sucesso!!!", vbExclamation, "Atenção")
                    Else
                        Tipo = TipoDeAlteracao.FORM_SALVO
                        MsgBox(IIf(blnEdit, "Alteração", "Inclusão") & " não realizada (Erro no FunSave...) Verifique a conexão com o Banco de Dados!!", vbExclamation, "Atenção")
                    End If
            End Select
        End If


        funClose = IIf(Tipo = TipoDeAlteracao.FORM_SALVO, True, False)

        Return funClose
    End Function
    Public Function funSave() As Boolean

        If cnnSql.State = ConnectionState.Closed Then cnnSql.Open()

        Dim strData As String
        If Not blnEdit Then
            strData = Now
            strData = Convert.ToDateTime(strData).ToString("yyyy-M-dd")

            strSql = vbNullString
            strSql = "INSERT INTO [dbo].[cad_disciplinas](" & vbCr & _
                     "Descricao," & vbCr & _
                     "DataCadastro," & vbCr & _
                     "idStatus)" & vbCr

            strSql = strSql & _
                "VALUES(" & vbCr & _
                "'" & frmDisciplinas.txtDescricao.Text & "'," & vbCr & _
                "GETDATE()" & "," & vbCr & _
                IIf(frmDisciplinas.cmbStatus.Text = "Ativo", 1, 0) & ")" & vbCr

        Else
            strSql = vbNullString
            strSql = "UPDATE [dbo].[cad_disciplinas]" & vbCr & _
                "SET" & vbCr & _
                "Descricao='" & Trim(frmDisciplinas.txtDescricao.Text) & "' ," & vbCr & _
                "idStatus='" & IIf(Trim(frmDisciplinas.cmbStatus.Text) = "Ativo", 1, 0) & "'" & vbCr & _
                "WHERE IdDisciplina=" & Trim(frmDisciplinas.txtID.Text)

        End If

        cmd = New SqlCommand(strSql, cnnSql)
        cmd.ExecuteNonQuery()
        funSave = True
        Return funSave

erro:   MsgBox("Erro")

    End Function
    Public Function funValidaSalvar() As Boolean
        Dim str As String
        Dim obj As Object
        str = "Valor não pode ser em Branco!!"
        If Trim(frmDisciplinas.txtDescricao.Text) = vbNullString Then
            funValidaSalvar = True
            obj = frmDisciplinas.txtDescricao
            GoTo fim
        ElseIf Trim(frmDisciplinas.cmbStatus.Text) = vbNullString Then
            funValidaSalvar = True
            obj = frmDisciplinas.cmbStatus
            GoTo fim
        ElseIf SubValida(frmDisciplinas.cmbStatus) = True Then
            funValidaSalvar = True
            Return funValidaSalvar
        End If

        funValidaSalvar = False
        Return funValidaSalvar
fim:

        If blnBalao = False Then
            objToolTip = New ToolTip
            objToolTip.ToolTipTitle = "Atenção"
            objToolTip.UseFading = True
            objToolTip.UseAnimation = True
            objToolTip.IsBalloon = True
            objToolTip.ShowAlways = True
            'objToolTip.AutoPopDelay = 5000
            'objToolTip.InitialDelay = 1000
            'objToolTip.ReshowDelay = 500
            objToolTip.IsBalloon = True
            objToolTip.SetToolTip(obj, str)
            objToolTip.Show(str, obj)
            blnBalao = True
        End If
        'AddHandler cmbStatus.MouseClick, AddressOf cmbStatus_Click
        funValidaSalvar = True
        Return funValidaSalvar
    End Function
    Public Sub btnClick(ByVal Botao As SByte)
        Select Case Botao
            Case frmDisciplinas.Movimento.Ultimo
                subMovimenta(frmDisciplinas.Movimento.Ultimo)
            Case frmDisciplinas.Movimento.Proximo
                subMovimenta(frmDisciplinas.Movimento.Proximo)
            Case frmDisciplinas.Movimento.Primeiro
                subMovimenta(frmDisciplinas.Movimento.Primeiro)
            Case frmDisciplinas.Movimento.Anterior
                subMovimenta(frmDisciplinas.Movimento.Anterior)
            Case frmDisciplinas.Botao.Excluir

            Case frmDisciplinas.Botao.Incluir
                blnBotoes = False
                blnChange = False
                subBTN(blnBotoes)
                subInsert()
                blnInsert = True

                frmDisciplinas.cmbStatus.Focus()


            Case frmDisciplinas.Botao.Cancelar
                blnBotoes = True
                blnChange = False

                subBTN(blnBotoes)
                subCarregaDados()

                blnInsert = False
                blnEdit = False

            Case frmDisciplinas.Botao.Editar
                blnBotoes = False
                blnChange = False
                blnEdit = True

                subBTN(blnBotoes)


            Case frmDisciplinas.Botao.Gravar
                blnBotoes = True

                subBTN(blnBotoes)
                funClose()

                blnInsert = False
                blnEdit = False

                frmLista.objLista.subMaster()

                i = frmLista.DataGridView1.RowCount - 1
                subCarregaDados()
                frmLista.DataGridView1.CurrentCell = frmLista.DataGridView1.Rows(i).Cells(0)

        End Select


    End Sub
    Private Sub subMovimenta(ByRef Botao As Byte)
        Select Case Botao
            Case frmDisciplinas.Movimento.Ultimo
                If frmLista.DataGridView1.RowCount > 0 Then
                    i = frmLista.DataGridView1.RowCount - 1
                    subCarregaDados()
                    frmLista.DataGridView1.CurrentCell = frmLista.DataGridView1.Rows(i).Cells(0)
                End If
            Case frmDisciplinas.Movimento.Proximo
                If frmLista.DataGridView1.RowCount > 0 Then
                    If i <> frmLista.DataGridView1.RowCount - 1 Then
                        i = i + 1
                        subCarregaDados()
                        frmLista.DataGridView1.CurrentCell = frmLista.DataGridView1.Rows(i).Cells(0)
                    Else
                        MsgBox("Atenção você já está no último registro...", vbExclamation, "Atenção")
                    End If
                End If
            Case frmDisciplinas.Movimento.Primeiro
                If frmLista.DataGridView1.RowCount > 0 Then
                    i = 0
                    subCarregaDados()
                    frmLista.DataGridView1.CurrentCell = frmLista.DataGridView1.Rows(i).Cells(0)
                End If

            Case frmDisciplinas.Movimento.Anterior
                If frmLista.DataGridView1.RowCount > 0 Then
                    If i <> 0 Then
                        i = i - 1
                        subCarregaDados()
                        frmLista.DataGridView1.CurrentCell = frmLista.DataGridView1.Rows(i).Cells(0)
                    Else
                        MsgBox("Atenção você já está no Primeiro registro...", vbExclamation, "Atenção")
                    End If
                End If

        End Select
    End Sub
    Private Sub subBTN(ByRef blnBotoes As Boolean)

        With frmDisciplinas

            If Not blnBotoes Then
                .btnIncluir.Text = "&Gravar"
                .btnEditar.Text = "&Cancelar"
            Else
                .btnIncluir.Text = "&Incluir"
                .btnEditar.Text = "&Editar"
            End If

            .btnExluir.Enabled = blnBotoes
            .btnAnterior.Enabled = blnBotoes
            .btnPrimeiro.Enabled = blnBotoes
            .btnUltimo.Enabled = blnBotoes
            .btnProximo.Enabled = blnBotoes

            .grbDisciplinas.Enabled = Not blnBotoes

        End With
    End Sub
    Private Sub subInsert()

        blnEdit = False

        With frmDisciplinas
            .cmbStatus.Text = vbNullString
            .txtDescricao.Text = vbNullString
            .txtID.Text = 0
        End With
    End Sub

    Public Sub subLoad()
        subcmbRST()
        subCMBFormat()

        If frmLista.DataGridView1.CurrentRow.Index > 0 Then
            i = frmLista.DataGridView1.CurrentRow.Index
        End If
        subCarregaDados()

        blnEdit = False
        blnInsert = False

    End Sub

    Private Sub subCarregaDados()


        With frmDisciplinas
            .txtDescricao.Text = frmLista.DataGridView1.Item("Descrição", i).Value
            .txtID.Text = frmLista.DataGridView1.Item("ID", i).Value
            .cmbStatus.Text = frmLista.DataGridView1.Item("Status", i).Value
        End With

        'frmLista.DataGridView1.SelectedRows(0).Cells(0).Value()
    End Sub
    Private Sub subcmbRST()
        strSql = vbNullString
        strSql = "SELECT * FROM [DBO].cad_status WHERE idRotina=1"

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = strSql.ToString
        cmd.CommandType = CommandType.Text
        cmd.Connection = cnnSql
        If cnnSql.State = ConnectionState.Closed Then cnnSql.Open() : cmd.ExecuteNonQuery() Else cmd.ExecuteNonQuery()


        dr = cmd.ExecuteReader(CommandBehavior.SingleResult)
        ReDim arrStatus(1)

        Dim i As SByte
        i = 0
        If dr.HasRows Then

            While dr.Read
                arrStatus(i) = Trim(dr.Item(1).ToString)
                frmDisciplinas.cmbStatus.Items.Add(Trim(dr.Item(1).ToString))
                i = i + 1
            End While
        End If

        dr.Close()
        cnnSql.Close()
    End Sub
    Private Sub InitializeComponent()

    End Sub
    Private Sub subCMBFormat()
        With frmDisciplinas
            .cmbStatus.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .cmbStatus.AutoCompleteSource = AutoCompleteSource.ListItems
        End With
    End Sub

    Public Sub subChanged()
        If Not IsNothing(objToolTip) Then objToolTip.Dispose() : blnBalao = False

    End Sub
    Public Function SubValida(ByRef obj As Object)
        Dim blnvalida As Boolean

        If InStr(obj.ToString, "ComboBox", CompareMethod.Text) >= 1 Then
            '        If TypeOf obj Is ComboBox Then
            If obj.FindString(Trim(obj.Text)) = -1 Then
                blnvalida = True
                GoTo fim
            End If
            'Stop
            'blnvalida = obj.FindString(obj.text)


        End If
        Return blnvalida

fim:

        If blnBalao = False Then
            objToolTip = New ToolTip
            objToolTip.ToolTipTitle = "Atenção"
            objToolTip.UseFading = True
            objToolTip.UseAnimation = True
            objToolTip.IsBalloon = True
            objToolTip.ShowAlways = True
            'objToolTip.AutoPopDelay = 5000
            'objToolTip.InitialDelay = 1000
            'objToolTip.ReshowDelay = 500
            objToolTip.IsBalloon = True
            objToolTip.SetToolTip(obj, "Status Inválido")
            objToolTip.Show("Status Inválido", obj)
            blnBalao = True
        End If
        'AddHandler cmbStatus.MouseClick, AddressOf cmbStatus_Click
        Return blnvalida
    End Function


    Public Sub subEdit()
        blnChange = True
    End Sub


End Class
