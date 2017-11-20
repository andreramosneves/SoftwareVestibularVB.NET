'Imports MySql.Data.MySqlClient
'Imports System.Data.SqlClient
Public Class frmLista
    Public objLista As Object


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub




    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        objLista.subOpenForm()
    End Sub

    Private Sub DataGridView1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles DataGridView1.KeyPress
        Select Case e.KeyChar
            Case Convert.ToChar(Keys.Return)
                objLista.subOpenForm()
                'ElseIf e.KeyChar = "."c Then
                '' converte o ponto para virgula
                'e.Handled = True
                'SendKeys.Send(",")
        End Select
    End Sub
End Class