<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBotoesVert
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
        Me.btnCadastro = New System.Windows.Forms.Button()
        Me.btnPraticar = New System.Windows.Forms.Button()
        Me.btnRelatorios = New System.Windows.Forms.Button()
        Me.btnEstudar = New System.Windows.Forms.Button()
        Me.ListPraticar = New System.Windows.Forms.ListView()
        Me.ListRelatorio = New System.Windows.Forms.ListView()
        Me.ListEstudar = New System.Windows.Forms.ListView()
        Me.ListCadastro = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'btnCadastro
        '
        Me.btnCadastro.AllowDrop = True
        Me.btnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastro.Location = New System.Drawing.Point(0, 0)
        Me.btnCadastro.Name = "btnCadastro"
        Me.btnCadastro.Size = New System.Drawing.Size(273, 25)
        Me.btnCadastro.TabIndex = 47
        Me.btnCadastro.Text = "Cadastro"
        Me.btnCadastro.UseVisualStyleBackColor = True
        '
        'btnPraticar
        '
        Me.btnPraticar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPraticar.Location = New System.Drawing.Point(0, 46)
        Me.btnPraticar.Name = "btnPraticar"
        Me.btnPraticar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnPraticar.Size = New System.Drawing.Size(273, 25)
        Me.btnPraticar.TabIndex = 46
        Me.btnPraticar.Text = "Praticar"
        Me.btnPraticar.UseVisualStyleBackColor = True
        '
        'btnRelatorios
        '
        Me.btnRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRelatorios.Location = New System.Drawing.Point(0, 70)
        Me.btnRelatorios.Name = "btnRelatorios"
        Me.btnRelatorios.Size = New System.Drawing.Size(273, 25)
        Me.btnRelatorios.TabIndex = 40
        Me.btnRelatorios.Text = "Relatórios"
        Me.btnRelatorios.UseVisualStyleBackColor = True
        '
        'btnEstudar
        '
        Me.btnEstudar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEstudar.Location = New System.Drawing.Point(0, 22)
        Me.btnEstudar.Name = "btnEstudar"
        Me.btnEstudar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnEstudar.Size = New System.Drawing.Size(273, 25)
        Me.btnEstudar.TabIndex = 41
        Me.btnEstudar.Text = "Estudar"
        Me.btnEstudar.UseVisualStyleBackColor = True
        '
        'ListPraticar
        '
        Me.ListPraticar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListPraticar.Location = New System.Drawing.Point(0, 70)
        Me.ListPraticar.MultiSelect = False
        Me.ListPraticar.Name = "ListPraticar"
        Me.ListPraticar.Size = New System.Drawing.Size(273, 366)
        Me.ListPraticar.TabIndex = 45
        Me.ListPraticar.UseCompatibleStateImageBehavior = False
        Me.ListPraticar.View = System.Windows.Forms.View.List
        Me.ListPraticar.Visible = False
        '
        'ListRelatorio
        '
        Me.ListRelatorio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListRelatorio.Location = New System.Drawing.Point(0, 94)
        Me.ListRelatorio.MultiSelect = False
        Me.ListRelatorio.Name = "ListRelatorio"
        Me.ListRelatorio.Size = New System.Drawing.Size(273, 363)
        Me.ListRelatorio.TabIndex = 44
        Me.ListRelatorio.UseCompatibleStateImageBehavior = False
        Me.ListRelatorio.View = System.Windows.Forms.View.List
        Me.ListRelatorio.Visible = False
        '
        'ListEstudar
        '
        Me.ListEstudar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListEstudar.Location = New System.Drawing.Point(0, 46)
        Me.ListEstudar.MultiSelect = False
        Me.ListEstudar.Name = "ListEstudar"
        Me.ListEstudar.Size = New System.Drawing.Size(273, 400)
        Me.ListEstudar.TabIndex = 43
        Me.ListEstudar.UseCompatibleStateImageBehavior = False
        Me.ListEstudar.View = System.Windows.Forms.View.List
        Me.ListEstudar.Visible = False
        '
        'ListCadastro
        '
        Me.ListCadastro.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListCadastro.Location = New System.Drawing.Point(0, 25)
        Me.ListCadastro.MultiSelect = False
        Me.ListCadastro.Name = "ListCadastro"
        Me.ListCadastro.Size = New System.Drawing.Size(273, 400)
        Me.ListCadastro.TabIndex = 42
        Me.ListCadastro.UseCompatibleStateImageBehavior = False
        Me.ListCadastro.View = System.Windows.Forms.View.List
        Me.ListCadastro.Visible = False
        '
        'frmBotoesVert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(275, 597)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCadastro)
        Me.Controls.Add(Me.btnPraticar)
        Me.Controls.Add(Me.btnRelatorios)
        Me.Controls.Add(Me.btnEstudar)
        Me.Controls.Add(Me.ListPraticar)
        Me.Controls.Add(Me.ListRelatorio)
        Me.Controls.Add(Me.ListEstudar)
        Me.Controls.Add(Me.ListCadastro)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmBotoesVert"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCadastro As System.Windows.Forms.Button
    Friend WithEvents btnPraticar As System.Windows.Forms.Button
    Friend WithEvents btnRelatorios As System.Windows.Forms.Button
    Friend WithEvents btnEstudar As System.Windows.Forms.Button
    Friend WithEvents ListPraticar As System.Windows.Forms.ListView
    Friend WithEvents ListRelatorio As System.Windows.Forms.ListView
    Friend WithEvents ListEstudar As System.Windows.Forms.ListView
    Friend WithEvents ListCadastro As System.Windows.Forms.ListView
End Class
