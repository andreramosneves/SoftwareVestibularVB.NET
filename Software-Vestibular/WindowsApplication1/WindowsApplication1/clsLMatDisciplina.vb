Public Class clsLMatDisciplina

    Dim strsql As String
    Dim frm As frmLista

    Public Sub subMaster()
        strsql = vbNullString
        strsql = strsql & _
            "SELECT" & vbCr & _
            "MTD.idMatDisciplina AS ID," & vbCr & _
            "MTD.Descricao AS Matéria," & vbCr & _
            "MT.Descricao AS Disciplina," & vbCr & _
            "ST.Descricao AS Status," & vbCr & _
            "MTD.idDisciplina AS IdDisciplina" & vbCr & _
            "FROM" & vbCr & _
            "[DBO].cad_matdisciplina MTD" & vbCr & _
            "LEFT JOIN cad_status ST" & vbCr & _
            "ON MTD.idStatus=ST.idStatus" & vbCr & _
            "LEFT JOIN cad_disciplinas MT" & vbCr & _
            "ON MTD.idDisciplina=MT.idDisciplina"

        If cnnSql.State = ConnectionState.Closed Then cnnSql.Open()

        frmLista.DataGridView1.DataSource = GetDataTable(strsql)
        frmLista.DataGridView1.Columns(4).Visible = False
        'Dim fi As String
        'fi = frmLista.DataGridView1.Item("Status", 0).Value

    End Sub
    Public Sub subOpenForm()
        frmMatDisciplinas.ShowDialog()
    End Sub


    Public Sub New()
        subMaster()
    End Sub
End Class


