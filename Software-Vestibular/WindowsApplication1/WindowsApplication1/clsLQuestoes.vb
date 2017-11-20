Public Class clsLQuestoes
        Dim strsql As String
        Dim frm As frmLista

        Public Sub subMaster()
            strsql = vbNullString
        strsql = strsql & _
            "SELECT" & vbCr & _
            "QT.idQuestao AS ID," & vbCr & _
            "DS.Descricao AS Disciplina," & vbCr & _
            "QT.idMateria AS Matéria," & vbCr & _
            "QT.CaminhoImagem AS Imagem," & vbCr & _
            "ST.Descricao AS Status" & vbCr & _
            "FROM" & vbCr & _
            "[DBO].cad_questoes QT" & vbCr & _
            "LEFT JOIN cad_status ST" & vbCr & _
            "ON QT.idStatus=ST.idStatus" & vbCr & _
            "LEFT JOIN cad_disciplinas DS" & vbCr & _
            "ON QT.idDisciplina=DS.idDisciplina"

            If cnnSql.State = ConnectionState.Closed Then cnnSql.Open()

            frmLista.DataGridView1.DataSource = GetDataTable(strsql)

        End Sub
        Public Sub subOpenForm()
            frmQuestion.ShowDialog()
        End Sub


        Public Sub New()
            subMaster()
        End Sub
    End Class

