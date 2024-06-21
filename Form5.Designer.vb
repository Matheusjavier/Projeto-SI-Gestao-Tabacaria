<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.id_produto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nome_produto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nome_fornecedor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.validade_produto = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.logout = New System.Windows.Forms.Label()
        Me.botao_atualizar = New System.Windows.Forms.PictureBox()
        Me.botao_excluir = New System.Windows.Forms.PictureBox()
        Me.botao_cadastrar = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.botao_atualizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.botao_excluir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.botao_cadastrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern Warfare", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(72, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(649, 43)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "gerenciar produtos"
        '
        'id_produto
        '
        Me.id_produto.BackColor = System.Drawing.SystemColors.ControlLight
        Me.id_produto.Location = New System.Drawing.Point(21, 129)
        Me.id_produto.Name = "id_produto"
        Me.id_produto.Size = New System.Drawing.Size(317, 20)
        Me.id_produto.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern Warfare", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(18, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(185, 18)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "ID do produto"
        '
        'nome_produto
        '
        Me.nome_produto.BackColor = System.Drawing.SystemColors.ControlLight
        Me.nome_produto.Location = New System.Drawing.Point(21, 195)
        Me.nome_produto.Name = "nome_produto"
        Me.nome_produto.Size = New System.Drawing.Size(317, 20)
        Me.nome_produto.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern Warfare", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(18, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(231, 18)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Nome do produto"
        '
        'nome_fornecedor
        '
        Me.nome_fornecedor.BackColor = System.Drawing.SystemColors.ControlLight
        Me.nome_fornecedor.Location = New System.Drawing.Point(21, 266)
        Me.nome_fornecedor.Name = "nome_fornecedor"
        Me.nome_fornecedor.Size = New System.Drawing.Size(317, 20)
        Me.nome_fornecedor.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern Warfare", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(18, 245)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(259, 18)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Nome do fonecedor"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Modern Warfare", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(387, 189)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(154, 18)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Cadastrar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Modern Warfare", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(615, 188)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 18)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Excluir"
        '
        'validade_produto
        '
        Me.validade_produto.BackColor = System.Drawing.SystemColors.ControlLight
        Me.validade_produto.Location = New System.Drawing.Point(381, 129)
        Me.validade_produto.Name = "validade_produto"
        Me.validade_produto.Size = New System.Drawing.Size(317, 20)
        Me.validade_produto.TabIndex = 33
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Modern Warfare", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(378, 108)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(279, 18)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Validade do produto"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Modern Warfare", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(400, 271)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(138, 18)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "atualizar"
        '
        'logout
        '
        Me.logout.AutoSize = True
        Me.logout.Font = New System.Drawing.Font("Modern Warfare", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logout.ForeColor = System.Drawing.Color.Crimson
        Me.logout.Location = New System.Drawing.Point(736, 279)
        Me.logout.Name = "logout"
        Me.logout.Size = New System.Drawing.Size(75, 55)
        Me.logout.TabIndex = 36
        Me.logout.Text = "X"
        '
        'botao_atualizar
        '
        Me.botao_atualizar.Image = Global.prj_adsva2_24_1S.My.Resources.Resources.botão_png3
        Me.botao_atualizar.Location = New System.Drawing.Point(382, 245)
        Me.botao_atualizar.Name = "botao_atualizar"
        Me.botao_atualizar.Size = New System.Drawing.Size(174, 65)
        Me.botao_atualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.botao_atualizar.TabIndex = 34
        Me.botao_atualizar.TabStop = False
        '
        'botao_excluir
        '
        Me.botao_excluir.Image = Global.prj_adsva2_24_1S.My.Resources.Resources.botão_png3
        Me.botao_excluir.Location = New System.Drawing.Point(579, 164)
        Me.botao_excluir.Name = "botao_excluir"
        Me.botao_excluir.Size = New System.Drawing.Size(174, 65)
        Me.botao_excluir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.botao_excluir.TabIndex = 30
        Me.botao_excluir.TabStop = False
        '
        'botao_cadastrar
        '
        Me.botao_cadastrar.Image = Global.prj_adsva2_24_1S.My.Resources.Resources.botão_png3
        Me.botao_cadastrar.Location = New System.Drawing.Point(379, 164)
        Me.botao_cadastrar.Name = "botao_cadastrar"
        Me.botao_cadastrar.Size = New System.Drawing.Size(174, 65)
        Me.botao_cadastrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.botao_cadastrar.TabIndex = 28
        Me.botao_cadastrar.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.prj_adsva2_24_1S.My.Resources.Resources.taptap_background
        Me.PictureBox1.Location = New System.Drawing.Point(-9, -9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(818, 343)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrange
        Me.ClientSize = New System.Drawing.Size(800, 328)
        Me.ControlBox = False
        Me.Controls.Add(Me.logout)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.botao_atualizar)
        Me.Controls.Add(Me.validade_produto)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.botao_excluir)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.botao_cadastrar)
        Me.Controls.Add(Me.nome_fornecedor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nome_produto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.id_produto)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.Color.DarkOrange
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form5"
        CType(Me.botao_atualizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.botao_excluir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.botao_cadastrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents id_produto As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents nome_produto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents nome_fornecedor As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents botao_cadastrar As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents botao_excluir As PictureBox
    Friend WithEvents validade_produto As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents botao_atualizar As PictureBox
    Friend WithEvents logout As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
