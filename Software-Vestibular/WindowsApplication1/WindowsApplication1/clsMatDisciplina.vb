Imports System.Data.SqlClient
Imports System.Data.Sql

Public Class clsMatDisciplina

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
        frmMatDisciplinas.Dispose()
        frmMatDisciplinas.Close()

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
            strSql = "INSERT INTO [dbo].[cad_matdisciplina](" & vbCr & _
                     "idDisciplina," & vbCr & _
                     "Descricao," & vbCr & _
                     "DataCadastro," & vbCr & _
                     "idStatus)" & vbCr

            strSql = strSql & _
                "VALUES(" & vbCr & _
                subPegaID() & "," & vbCr & _
                "'" & frmMatDisciplinas.txtDescricao.Text & "'," & vbCr & _
                "GETDATE()" & "," & vbCr & _
                IIf(frmMatDisciplinas.cmbStatus.Text = "Ativo", 1, 0) & ")" & vbCr

        Else
            strSql = vbNullString
            strSql = "UPDATE [dbo].[cad_matdisciplina]" & vbCr & _
                "SET" & vbCr & _
                "idDisciplina=" & subPegaID() & "," & vbCr & _
                "Descricao='" & Trim(frmMatDisciplinas.txtDescricao.Text) & "' ," & vbCr & _
                "idStatus='" & IIf(Trim(frmMatDisciplinas.cmbStatus.Text) = "Ativo", 1, 0) & "'" & vbCr & _
                "WHERE IdMatDisciplina=" & Trim(frmMatDisciplinas.txtID.Text)

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
        If Trim(frmMatDisciplinas.txtDescricao.Text) = vbNullString Then
            funValidaSalvar = True
            MsgBox("Campo Matéria não pode ser em branco...", vbInformation, "Vestibular")
            obj = frmMatDisciplinas.txtDescricao
            GoTo fim
        ElseIf Trim(frmMatDisciplinas.cmbStatus.Text) = vbNullString Then
            funValidaSalvar = True
            MsgBox("O campo Status não pode ser em branco...", vbInformation, "Vestibular")
            obj = frmMatDisciplinas.cmbStatus
            GoTo fim
        ElseIf Trim(frmMatDisciplinas.cmbDisciplina.Text) = vbNullString Then
            funValidaSalvar = True
            MsgBox("Campo Disciplina não pode ser em branco...", vbInformation, "Vestibular")
            obj = frmMatDisciplinas.cmbStatus
            GoTo fim

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
            Case frmMatDisciplinas.Movimento.Ultimo
                subMovimenta(frmMatDisciplinas.Movimento.Ultimo)
            Case frmMatDisciplinas.Movimento.Proximo
                subMovimenta(frmMatDisciplinas.Movimento.Proximo)
            Case frmMatDisciplinas.Movimento.Primeiro
                subMovimenta(frmMatDisciplinas.Movimento.Primeiro)
            Case frmMatDisciplinas.Movimento.Anterior
                subMovimenta(frmMatDisciplinas.Movimento.Anterior)
            Case frmMatDisciplinas.Botao.Excluir

            Case frmMatDisciplinas.Botao.Incluir
                blnBotoes = False
                blnChange = False
                subBTN(blnBotoes)
                subInsert()
                blnInsert = True

                frmMatDisciplinas.cmbStatus.Focus()


            Case frmMatDisciplinas.Botao.Cancelar
                blnBotoes = True
                blnChange = False

                subBTN(blnBotoes)
                subCarregaDados()

                blnInsert = False
                blnEdit = False

            Case frmMatDisciplinas.Botao.Editar
                blnBotoes = False
                blnChange = False
                blnEdit = True

                subBTN(blnBotoes)


            Case frmMatDisciplinas.Botao.Gravar
                blnBotoes = True

                subBTN(blnBotoes)
                If funClose() = True Then

                    blnInsert = False
                    blnEdit = False

                    frmLista.objLista.subMaster()

                    i = frmLista.DataGridView1.RowCount - 1
                    frmLista.DataGridView1.CurrentCell = frmLista.DataGridView1.Rows(i).Cells(0)

                    subCarregaDados()
                Else
                    blnInsert = False
                    blnEdit = False

                    subCarregaDados()

                End If
        End Select


    End Sub
    Private Sub subMovimenta(ByRef Botao As Byte)
        Select Case Botao
            Case frmMatDisciplinas.Movimento.Ultimo
                If frmLista.DataGridView1.RowCount > 0 Then
                    i = frmLista.DataGridView1.RowCount - 1
                    subCarregaDados()
                    frmLista.DataGridView1.CurrentCell = frmLista.DataGridView1.Rows(i).Cells(0)
                End If
            Case frmMatDisciplinas.Movimento.Proximo
                If frmLista.DataGridView1.RowCount > 0 Then
                    If i <> frmLista.DataGridView1.RowCount - 1 Then
                        i = i + 1
                        subCarregaDados()
                        frmLista.DataGridView1.CurrentCell = frmLista.DataGridView1.Rows(i).Cells(0)
                    Else
                        MsgBox("Atenção você já está no último registro...", vbExclamation, "Atenção")
                    End If
                End If
            Case frmMatDisciplinas.Movimento.Primeiro
                If frmLista.DataGridView1.RowCount > 0 Then
                    i = 0
                    subCarregaDados()
                    frmLista.DataGridView1.CurrentCell = frmLista.DataGridView1.Rows(i).Cells(0)
                End If

            Case frmMatDisciplinas.Movimento.Anterior
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

        With frmMatDisciplinas

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

            If frmLista.DataGridView1.RowCount = 0 Then
                .btnEditar.Enabled = True
            Else
                .btnEditar.Enabled = False
            End If

        End With
    End Sub
    Private Sub subInsert()

        blnEdit = False

        With frmMatDisciplinas
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

        With frmMatDisciplinas
            .txtID.Text = frmLista.DataGridView1.Item("ID", i).Value
            .txtDescricao.Text = frmLista.DataGridView1.Item("Matéria", i).Value
            .cmbStatus.Text = frmLista.DataGridView1.Item("Status", i).Value
            .cmbDisciplina.Text = Trim(frmLista.DataGridView1.Item("Disciplina", i).Value) & " - " & frmLista.DataGridView1.Item(4, i).Value
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

        Dim f As SByte
        f = 0
        If dr.HasRows Then

            While dr.Read
                arrStatus(i) = Trim(dr.Item(1).ToString)
                frmMatDisciplinas.cmbStatus.Items.Add(Trim(dr.Item(1).ToString))
                f = f + 1
            End While
        End If

        cmd.Cancel()
        dr.Close()

        strSql = vbNullString
        strSql = "SELECT idDisciplina,Descricao FROM [DBO].cad_disciplinas WHERE idStatus=1"


        '==================DISCIPLINA========================

        cmd.CommandText = strSql.ToString
        cmd.CommandType = CommandType.Text
        cmd.Connection = cnnSql
        If cnnSql.State = ConnectionState.Closed Then cnnSql.Open() : cmd.ExecuteNonQuery() Else cmd.ExecuteNonQuery()

        dr = cmd.ExecuteReader(CommandBehavior.SingleResult)
        
        If dr.HasRows Then

            While dr.Read
                'arrStatus(i) = Trim(dr.Item(1).ToString)
                frmMatDisciplinas.cmbDisciplina.Items.Add(Trim(dr.Item(1).ToString) & " - " & Trim(dr.Item(0).ToString))
                'i = i + 1
            End While
        End If


        dr.Close()
        cnnSql.Close()
    End Sub
    Private Sub InitializeComponent()

    End Sub
    Private Sub subCMBFormat()
        With frmMatDisciplinas
            .cmbStatus.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .cmbStatus.AutoCompleteSource = AutoCompleteSource.ListItems
            .cmbDisciplina.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .cmbDisciplina.AutoCompleteSource = AutoCompleteSource.ListItems

        End With
    End Sub

    Public Sub subChanged()
        If Not IsNothing(objToolTip) Then objToolTip.Dispose() : blnBalao = False

    End Sub
    Public Function SubValida(ByRef obj As Object)
        Dim blnvalida As Boolean
        Dim strMensagem As String
        If InStr(obj.ToString, "ComboBox", CompareMethod.Text) >= 1 Then
            '        If TypeOf obj Is ComboBox Then
            If obj.FindStringExact(Trim(obj.Text)) = -1 Then
                strMensagem = IIf(obj.name = "cmbStatus", " O Campo Status ", " O Campo Disciplina ")
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
            objToolTip.SetToolTip(obj, strMensagem & "Inválido")
            objToolTip.Show(strMensagem & "Incorreto...", obj)
            blnBalao = True
        End If
        'AddHandler cmbStatus.MouseClick, AddressOf cmbStatus_Click
        Return blnvalida
    End Function


    Public Sub subEdit()
        blnChange = True
    End Sub

    Private Function subPegaID() As String
        Dim str() As String

        str = Split(frmMatDisciplinas.cmbDisciplina.Text, "-")
        subPegaID = Trim(str(UBound(str)))

    End Function
End Class
