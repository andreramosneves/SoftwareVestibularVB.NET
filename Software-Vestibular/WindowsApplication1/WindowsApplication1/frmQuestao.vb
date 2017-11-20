
Public Class frmQuestion

    Private Sub frm_cadQuestion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        'If e.KeyChar = Convert.ToChar(Keys.Return) Then
        '   SendKeys.Send(Keys.Return)
        'End If
        'TEM que ativar para funcionar no formularário para que funcione

    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim strSql As String
        strSql = "SELECT * FROM cad_questoes"
        'cnnMysql(strSql)

        Me.btnIncluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10, FontStyle.Bold, GraphicsUnit.Point, (0))
    End Sub

End Class
