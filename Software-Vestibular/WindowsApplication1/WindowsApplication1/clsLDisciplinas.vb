Public Class clsLDisciplinas
    Dim strsql As String
    Dim frm As frmLista

    Public Sub subMaster()
        strsql = vbNullString
        strsql = strsql & _
            "SELECT" & vbCr & _
            "DP.idDisciplina AS ID," & vbCr & _
            "DP.Descricao AS Descrição," & vbCr & _
            "ST.Descricao AS Status" & vbCr & _
            "FROM" & vbCr & _
            "[DBO].cad_disciplinas DP" & vbCr & _
            "LEFT JOIN cad_status ST" & vbCr & _
            "ON DP.idStatus=ST.idStatus"

        If cnnSql.State = ConnectionState.Closed Then cnnSql.Open()

        frmLista.DataGridView1.DataSource = GetDataTable(strsql)

    End Sub
    Public Sub subOpenForm()
        frmDisciplinas.ShowDialog()
    End Sub


    Public Sub New()
        subMaster()
    End Sub
End Class
