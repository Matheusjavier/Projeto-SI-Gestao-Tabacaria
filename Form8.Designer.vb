<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nome_produto = New System.Windows.Forms.TextBox()
        Me.nome_fornecedor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cnpj_fornecedor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.telefone_fornecedor = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.botao_gravar = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.botao_gravar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern Warfare", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(782, 55)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "adicionar produto"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern Warfare", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(13, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(231, 18)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "nome do produto"
        '
        'nome_produto
        '
        Me.nome_produto.BackColor = System.Drawing.SystemColors.ControlLight
        Me.nome_produto.Location = New System.Drawing.Point(16, 165)
        Me.nome_produto.Name = "nome_produto"
        Me.nome_produto.Size = New System.Drawing.Size(317, 20)
        Me.nome_produto.TabIndex = 19
        '
        'nome_fornecedor
        '
        Me.nome_fornecedor.BackColor = System.Drawing.SystemColors.ControlLight
        Me.nome_fornecedor.Location = New System.Drawing.Point(16, 223)
        Me.nome_fornecedor.Name = "nome_fornecedor"
        Me.nome_fornecedor.Size = New System.Drawing.Size(317, 20)
        Me.nome_fornecedor.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern Warfare", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(13, 202)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(275, 18)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "nome do fornecedor"
        '
        'cnpj_fornecedor
        '
        Me.cnpj_fornecedor.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cnpj_fornecedor.Location = New System.Drawing.Point(411, 223)
        Me.cnpj_fornecedor.Name = "cnpj_fornecedor"
        Me.cnpj_fornecedor.Size = New System.Drawing.Size(317, 20)
        Me.cnpj_fornecedor.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern Warfare", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(408, 202)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(267, 18)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "cnpj do fornecedor"
        '
        'telefone_fornecedor
        '
        Me.telefone_fornecedor.BackColor = System.Drawing.SystemColors.ControlLight
        Me.telefone_fornecedor.Location = New System.Drawing.Point(16, 288)
        Me.telefone_fornecedor.Name = "telefone_fornecedor"
        Me.telefone_fornecedor.Size = New System.Drawing.Size(317, 20)
        Me.telefone_fornecedor.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern Warfare", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(13, 267)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(320, 18)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "telefone do fornecedor"
        '
        'botao_gravar
        '
        Me.botao_gravar.Image = Global.prj_adsva2_24_1S.My.Resources.Resources.botão_png3
        Me.botao_gravar.Location = New System.Drawing.Point(288, 337)
        Me.botao_gravar.Name = "botao_gravar"
        Me.botao_gravar.Size = New System.Drawing.Size(203, 83)
        Me.botao_gravar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.botao_gravar.TabIndex = 26
        Me.botao_gravar.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern Warfare", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(318, 366)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 24)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "gravar"
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrange
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.botao_gravar)
        Me.Controls.Add(Me.telefone_fornecedor)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cnpj_fornecedor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nome_fornecedor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nome_produto)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form8"
        Me.Text = "Form8"
        CType(Me.botao_gravar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents nome_produto As TextBox
    Friend WithEvents nome_fornecedor As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cnpj_fornecedor As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents telefone_fornecedor As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents botao_gravar As PictureBox
    Friend WithEvents Label6 As Label
End Class
