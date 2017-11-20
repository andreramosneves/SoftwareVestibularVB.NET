
Public Class frmBotoesVert

    Dim topCadastro As Long
    Dim topEstudar As Long
    Dim topParametros As Long
    Dim topRelatorios As Long
    Dim topPraticar As Long

    Dim X As Double

    Dim blnCadastro As Boolean
    Dim blnEstudar As Boolean
    Dim blnParametros As Boolean = False
    Dim blnRelatorios As Boolean
    Dim blnPraticar As Boolean

    Dim strSql As String

    Dim strLista As String

    Dim lstItem As ListViewItem
    Dim i As Integer


    Private Sub btnCadastro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastro.Click

        If blnCadastro = False Then
            PosicaoInicial()
            For Me.X = 0 To 8.5
                '              Me.Refresh()
                btnEstudar.Top = btnEstudar.Top + X
                btnPraticar.Top = btnPraticar.Top + X
                btnRelatorios.Top = btnRelatorios.Top + X
                'btnParametros.Top = btnParametros.Top + X
                X = X - 0.9
            Next (X)
            ListCadastro.Visible = True
            ListPraticar.Visible = False
            'ListParametros.Visible = False
            ListRelatorio.Visible = False
            ListEstudar.Visible = False

            blnEstudar = False
            blnCadastro = True
            blnParametros = False
            blnPraticar = False
            blnRelatorios = False


        End If

    End Sub


    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        topCadastro = btnCadastro.Top
        topEstudar = btnEstudar.Top
        'topParametros = btnParametros.Top
        topParametros = btnPraticar.Top
        topRelatorios = btnRelatorios.Top

        'subLoad()
    End Sub

    Private Sub PosicaoInicial()
        btnCadastro.Top = topCadastro
        btnEstudar.Top = topEstudar
        'btnParametros.Top = topParametros
        btnPraticar.Top = topParametros
        btnRelatorios.Top = topRelatorios
    End Sub

    Private Sub btnEstudar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEstudar.Click
        If blnEstudar = False Then
            PosicaoInicial()
            For Me.X = 0 To 8.5
                btnEstudar.Visible = True
                '             btnEstudar.Refresh()
                'btnParametros.Top = btnParametros.Top + X
                btnPraticar.Top = btnPraticar.Top + X
                btnRelatorios.Top = btnRelatorios.Top + X
                '               Me.Refresh()
                X = X - 0.9
            Next X
            ListCadastro.Visible = False
            ListPraticar.Visible = False
            'ListParametros.Visible = False
            ListRelatorio.Visible = False
            ListEstudar.Visible = True
            blnEstudar = True
            blnCadastro = False
            blnParametros = False
            blnPraticar = False
            blnRelatorios = False
        End If
    End Sub

    Private Sub btnPraticar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPraticar.Click
        If blnPraticar = False Then
            PosicaoInicial()
            For Me.X = 0 To 8.5
                btnPraticar.Visible = True
                '            btnPraticar.Refresh()
                btnRelatorios.Top = btnRelatorios.Top + X
                X = X - 0.9
                '               Me.Refresh()
            Next X

            ListCadastro.Visible = False
            ListPraticar.Visible = True
            'ListParametros.Visible = False
            ListRelatorio.Visible = False
            ListEstudar.Visible = False
            blnEstudar = False
            blnCadastro = False
            blnParametros = False
            blnPraticar = True
            blnRelatorios = False
        End If


    End Sub

    Private Sub btnRelatorios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRelatorios.Click
        If blnRelatorios = False Then
            PosicaoInicial()

            ListCadastro.Visible = False
            ListPraticar.Visible = False
            'ListParametros.Visible = False
            ListRelatorio.Visible = True
            ListEstudar.Visible = False

            blnEstudar = False
            blnCadastro = False
            blnParametros = False
            blnPraticar = False
            blnRelatorios = True
        End If


    End Sub

    'Private Sub btnParametros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnParametros.Click
    'If blnParametros = False Then
    'PosicaoInicial()

    '            Me.Refresh()

    '        ListCadastro.Visible = False
    '       ListPraticar.Visible = False
    'ListParametros.Visible = True
    '      ListRelatorio.Visible = False
    '     ListEstudar.Visible = False
    '
    '    blnEstudar = False
    '       blnCadastro = False
    '      blnParametros = True
    '     blnPraticar = False
    '        blnRelatorios = False
    '    End If

    'End Sub
    Private Sub ListCadastro_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListCadastro.SelectedIndexChanged

        For intI = 0 To ListCadastro.SelectedItems.Count - 1
            lstItem = Me.ListCadastro.SelectedItems.Item(intI)
        Next intI
        strLista = lstItem.Text
        strLista = Trim(strLista)

        subLoadLista(strLista)

    End Sub

    Private Sub ListEstudar_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListEstudar.SelectedIndexChanged
        For intI = 0 To ListEstudar.SelectedItems.Count - 1
            lstItem = Me.ListEstudar.SelectedItems.Item(intI)
        Next intI
        strLista = lstItem.Text
        strLista = Trim(strLista)

        subLoadLista(strLista)

    End Sub

    Private Sub ListRelatorio_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListRelatorio.SelectedIndexChanged
        For intI = 0 To ListRelatorio.SelectedItems.Count - 1
            lstItem = Me.ListRelatorio.SelectedItems.Item(intI)
        Next intI
        strLista = lstItem.Text
        strLista = Trim(strLista)

        subLoadLista(strLista)

    End Sub

    Private Sub ListPraticar_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListPraticar.SelectedIndexChanged
        For intI = 0 To ListPraticar.SelectedItems.Count - 1
            lstItem = Me.ListPraticar.SelectedItems.Item(intI)
        Next intI
        strLista = lstItem.Text
        strLista = Trim(strLista)

        subLoadLista(strLista)

    End Sub



    Private Sub subLoadLista(ByRef strLista As String)
        'Dim MDIChildLista As New frmLista

        If blnCadastro = True Then
            Select Case UCase(strLista)
                Case "DISCIPLINAS"
                    frmLista.MdiParent = frmMain
                    frmLista.Show()
                    frmLista.objLista = New clsLDisciplinas

                Case "QUESTÕES"
                    frmLista.MdiParent = frmMain
                    frmLista.Show()
                    frmLista.objLista = New clsLQuestoes

                Case "TEMAS DE REDAÇÕES"
                    frmLista.MdiParent = frmMain
                    frmLista.Show()

                Case "MATÉRIAS POR DISCIPLINA"
                    frmLista.MdiParent = frmMain
                    frmLista.Show()
                    frmLista.objLista = New clsLMatDisciplina

                Case "QUESTÕES RESOLVIDAS"
                    frmLista.MdiParent = frmMain
                    frmLista.Show()

                Case "MATERIAL DE ESTUDO"
                    frmLista.MdiParent = frmMain
                    frmLista.Show()

            End Select

        ElseIf blnEstudar = True Then
            Select Case strLista
                Case "HUMANAS"
                    frmLista.MdiParent = frmMain
                    frmLista.Show()

                Case "EXATAS"
                    frmLista.MdiParent = frmMain
                    frmLista.Show()

                Case "ANIMAÇÕES"
                    frmLista.MdiParent = frmMain
                    frmLista.Show()

            End Select

        ElseIf blnPraticar = True Then
            Select Case strLista
                Case "HUMANAS"
                    frmLista.MdiParent = frmMain
                    frmLista.Show()

                Case "EXATAS"
                    frmLista.MdiParent = frmMain
                    frmLista.Show()

                Case "BIOLÓGICAS"
                    frmLista.MdiParent = frmMain
                    frmLista.Show()

            End Select

        ElseIf blnRelatorios = True Then
            Select Case strLista
                Case "DESEMPENHO"
                    frmLista.MdiParent = frmMain
                    frmLista.Show()

                Case "PLANO DE ESTUDOS"
                    frmLista.MdiParent = frmMain
                    frmLista.Show()
                Case "PARÂMETROS"
                    frmLista.MdiParent = frmMain
                    frmLista.Show()

            End Select
        ElseIf blnParametros = True Then
            Select Case strLista
                Case "PARÂMETROS"
                    frmLista.MdiParent = frmMain
                    frmLista.Show()

            End Select
        End If
        
    End Sub
End Class