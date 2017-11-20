<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDisciplinas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnUltimo = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnProximo = New System.Windows.Forms.Button()
        Me.btnPrimeiro = New System.Windows.Forms.Button()
        Me.btnExluir = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnIncluir = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.grbDisciplinas = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.grbDisciplinas.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnUltimo
        '
        Me.btnUltimo.Location = New System.Drawing.Point(553, 116)
        Me.btnUltimo.Name = "btnUltimo"
        Me.btnUltimo.Size = New System.Drawing.Size(84, 39)
        Me.btnUltimo.TabIndex = 8
        Me.btnUltimo.Text = "&Último"
        Me.btnUltimo.UseVisualStyleBackColor = True
        '
        'btnAnterior
        '
        Me.btnAnterior.Location = New System.Drawing.Point(463, 115)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(84, 39)
        Me.btnAnterior.TabIndex = 7
        Me.btnAnterior.Text = "&Anterior"
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'btnProximo
        '
        Me.btnProximo.Location = New System.Drawing.Point(373, 115)
        Me.btnProximo.Name = "btnProximo"
        Me.btnProximo.Size = New System.Drawing.Size(84, 39)
        Me.btnProximo.TabIndex = 6
        Me.btnProximo.Text = "&Próximo"
        Me.btnProximo.UseVisualStyleBackColor = True
        '
        'btnPrimeiro
        '
        Me.btnPrimeiro.Location = New System.Drawing.Point(283, 115)
        Me.btnPrimeiro.Name = "btnPrimeiro"
        Me.btnPrimeiro.Size = New System.Drawing.Size(84, 39)
        Me.btnPrimeiro.TabIndex = 5
        Me.btnPrimeiro.Text = "&Primeiro"
        Me.btnPrimeiro.UseVisualStyleBackColor = True
        '
        'btnExluir
        '
        Me.btnExluir.Location = New System.Drawing.Point(193, 116)
        Me.btnExluir.Name = "btnExluir"
        Me.btnExluir.Size = New System.Drawing.Size(84, 39)
        Me.btnExluir.TabIndex = 4
        Me.btnExluir.Text = "&Excluir"
        Me.btnExluir.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(103, 116)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(84, 39)
        Me.btnEditar.TabIndex = 3
        Me.btnEditar.Text = "&Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnIncluir
        '
        Me.btnIncluir.Location = New System.Drawing.Point(12, 116)
        Me.btnIncluir.Name = "btnIncluir"
        Me.btnIncluir.Size = New System.Drawing.Size(84, 39)
        Me.btnIncluir.TabIndex = 2
        Me.btnIncluir.Text = "&Incluir"
        Me.btnIncluir.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(-85, 94)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(84, 39)
        Me.Button2.TabIndex = 34
        Me.Button2.Text = "&Incluir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(643, 114)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(84, 41)
        Me.btnSair.TabIndex = 9
        Me.btnSair.Text = "&Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'grbDisciplinas
        '
        Me.grbDisciplinas.Controls.Add(Me.Label3)
        Me.grbDisciplinas.Controls.Add(Me.cmbStatus)
        Me.grbDisciplinas.Controls.Add(Me.Label2)
        Me.grbDisciplinas.Controls.Add(Me.txtID)
        Me.grbDisciplinas.Controls.Add(Me.Label1)
        Me.grbDisciplinas.Controls.Add(Me.txtDescricao)
        Me.grbDisciplinas.Enabled = False
        Me.grbDisciplinas.Location = New System.Drawing.Point(12, 13)
        Me.grbDisciplinas.Name = "grbDisciplinas"
        Me.grbDisciplinas.Size = New System.Drawing.Size(715, 95)
        Me.grbDisciplinas.TabIndex = 42
        Me.grbDisciplinas.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(209, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Status"
        '
        'cmbStatus
        '
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Location = New System.Drawing.Point(261, 23)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(184, 21)
        Me.cmbStatus.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ID"
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(91, 23)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(91, 20)
        Me.txtID.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Descrição"
        '
        'txtDescricao
        '
        Me.txtDescricao.Location = New System.Drawing.Point(91, 63)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(603, 20)
        Me.txtDescricao.TabIndex = 1
        '
        'frmDisciplinas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(739, 172)
        Me.ControlBox = False
        Me.Controls.Add(Me.grbDisciplinas)
        Me.Controls.Add(Me.btnUltimo)
        Me.Controls.Add(Me.btnAnterior)
        Me.Controls.Add(Me.btnProximo)
        Me.Controls.Add(Me.btnPrimeiro)
        Me.Controls.Add(Me.btnExluir)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnIncluir)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnSair)
        Me.Name = "frmDisciplinas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Disciplinas"
        Me.grbDisciplinas.ResumeLayout(False)
        Me.grbDisciplinas.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnUltimo As System.Windows.Forms.Button
    Friend WithEvents btnAnterior As System.Windows.Forms.Button
    Friend WithEvents btnProximo As System.Windows.Forms.Button
    Friend WithEvents btnPrimeiro As System.Windows.Forms.Button
    Friend WithEvents btnExluir As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btnIncluir As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents grbDisciplinas As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDescricao As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
