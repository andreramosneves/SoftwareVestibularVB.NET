
Public Class frmDisciplinas

    Enum Movimento
        Proximo = 1
        Anterior = 2
        Primeiro = 3
        Ultimo = 4
    End Enum

    Enum Botao
        Incluir = 5
        Editar = 6
        Gravar = 7
        Cancelar = 8
        Excluir = 9
    End Enum

    Dim objFicha As New clsDisciplina

    Private Sub btnSair_Click(sender As System.Object, e As System.EventArgs) Handles btnSair.Click
        objFicha.Finaliza()
    End Sub


    Private Sub btnUltimo_Click(sender As System.Object, e As System.EventArgs) Handles btnUltimo.Click

        objFicha.btnClick(Movimento.Ultimo)
    End Sub

    Private Sub btnAnterior_Click(sender As System.Object, e As System.EventArgs) Handles btnAnterior.Click
        objFicha.btnClick(Movimento.Anterior)
    End Sub

    Private Sub btnProximo_Click(sender As System.Object, e As System.EventArgs) Handles btnProximo.Click
        objFicha.btnClick(Movimento.Proximo)
    End Sub

    Private Sub btnPrimeiro_Click(sender As System.Object, e As System.EventArgs) Handles btnPrimeiro.Click
        objFicha.btnClick(Movimento.Primeiro)
    End Sub

    Private Sub btnIncluir_Click(sender As System.Object, e As System.EventArgs) Handles btnIncluir.Click
        Select Case btnIncluir.Text
            Case "&Incluir"
                objFicha.btnClick(Botao.Incluir)
            Case "&Gravar"
                objFicha.btnClick(Botao.Gravar)
        End Select
    End Sub

    Private Sub btnEditar_Click(sender As System.Object, e As System.EventArgs) Handles btnEditar.Click

        Select Case btnEditar.Text
            Case "&Editar"
                objFicha.btnClick(Botao.Editar)
            Case "&Cancelar"
                objFicha.btnClick(Botao.Cancelar)
        End Select

    End Sub

    Private Sub btnExluir_Click(sender As System.Object, e As System.EventArgs) Handles btnExluir.Click
        objFicha.btnClick(Botao.Excluir)
    End Sub

    Private Sub frmDisciplinas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        objFicha.subLoad()

    End Sub

    Private Sub cmbStatus_TextChanged(sender As Object, e As System.EventArgs) Handles cmbStatus.TextChanged
        objFicha.subChanged()
        objFicha.subEdit()
    End Sub

    Private Sub cmbStatus_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmbStatus.Validating

        e.Cancel = objFicha.SubValida(cmbStatus)
    End Sub

    Private Sub txtDescricao_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescricao.KeyPress

        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            SendKeys.Send("{TAB}")
        End If

    End Sub

    Private Sub txtDescricao_TextChanged(sender As Object, e As System.EventArgs) Handles txtDescricao.TextChanged
        objFicha.subEdit()
    End Sub

    Private Sub cmbStatus_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbStatus.SelectedIndexChanged

    End Sub
End Class