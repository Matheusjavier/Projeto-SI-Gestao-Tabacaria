<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form11
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
        Me.logout = New System.Windows.Forms.Label()
        Me.validade = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nome_fornecedor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nome_produto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.id_produto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.data_entrada = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.data_saida = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.qtde_estoque = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.botao_excluir = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.botao_excluir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'logout
        '
        Me.logout.AutoSize = True
        Me.logout.Font = New System.Drawing.Font("Modern Warfare", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logout.ForeColor = System.Drawing.Color.Crimson
        Me.logout.Location = New System.Drawing.Point(682, 360)
        Me.logout.Name = "logout"
        Me.logout.Size = New System.Drawing.Size(75, 55)
        Me.logout.TabIndex = 52
        Me.logout.Text = "X"
        '
        'validade
        '
        Me.validade.BackColor = System.Drawing.SystemColors.ControlLight
        Me.validade.Location = New System.Drawing.Point(367, 142)
        Me.validade.Name = "validade"
        Me.validade.Size = New System.Drawing.Size(317, 20)
        Me.validade.TabIndex = 49
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Modern Warfare", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(364, 121)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(279, 18)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Validade do produto"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Modern Warfare", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(518, 346)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 18)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "concluido"
        '
        'nome_fornecedor
        '
        Me.nome_fornecedor.BackColor = System.Drawing.SystemColors.ControlLight
        Me.nome_fornecedor.Location = New System.Drawing.Point(7, 279)
        Me.nome_fornecedor.Name = "nome_fornecedor"
        Me.nome_fornecedor.Size = New System.Drawing.Size(317, 20)
        Me.nome_fornecedor.TabIndex = 43
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern Warfare", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(4, 258)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(259, 18)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Nome do fonecedor"
        '
        'nome_produto
        '
        Me.nome_produto.BackColor = System.Drawing.SystemColors.ControlLight
        Me.nome_produto.Location = New System.Drawing.Point(7, 208)
        Me.nome_produto.Name = "nome_produto"
        Me.nome_produto.Size = New System.Drawing.Size(317, 20)
        Me.nome_produto.TabIndex = 41
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern Warfare", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(4, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(231, 18)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Nome do produto"
        '
        'id_produto
        '
        Me.id_produto.BackColor = System.Drawing.SystemColors.ControlLight
        Me.id_produto.Location = New System.Drawing.Point(7, 142)
        Me.id_produto.Name = "id_produto"
        Me.id_produto.Size = New System.Drawing.Size(317, 20)
        Me.id_produto.TabIndex = 39
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern Warfare", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(4, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(185, 18)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "ID do produto"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern Warfare", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(0, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(754, 37)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "entrada e saida de estoque"
        '
        'data_entrada
        '
        Me.data_entrada.BackColor = System.Drawing.SystemColors.ControlLight
        Me.data_entrada.Location = New System.Drawing.Point(367, 208)
        Me.data_entrada.Name = "data_entrada"
        Me.data_entrada.Size = New System.Drawing.Size(317, 20)
        Me.data_entrada.TabIndex = 54
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern Warfare", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(364, 187)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(224, 18)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "data de entrada"
        '
        'data_saida
        '
        Me.data_saida.BackColor = System.Drawing.SystemColors.ControlLight
        Me.data_saida.Location = New System.Drawing.Point(367, 279)
        Me.data_saida.Name = "data_saida"
        Me.data_saida.Size = New System.Drawing.Size(317, 20)
        Me.data_saida.TabIndex = 56
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Modern Warfare", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(364, 258)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(185, 18)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "data de saida"
        '
        'qtde_estoque
        '
        Me.qtde_estoque.BackColor = System.Drawing.SystemColors.ControlLight
        Me.qtde_estoque.Location = New System.Drawing.Point(7, 343)
        Me.qtde_estoque.Name = "qtde_estoque"
        Me.qtde_estoque.Size = New System.Drawing.Size(317, 20)
        Me.qtde_estoque.TabIndex = 58
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Modern Warfare", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(4, 322)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(310, 18)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "Quantidade no estoque"
        '
        'botao_excluir
        '
        Me.botao_excluir.Image = Global.prj_adsva2_24_1S.My.Resources.Resources.botão_png3
        Me.botao_excluir.Location = New System.Drawing.Point(502, 322)
        Me.botao_excluir.Name = "botao_excluir"
        Me.botao_excluir.Size = New System.Drawing.Size(174, 65)
        Me.botao_excluir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.botao_excluir.TabIndex = 46
        Me.botao_excluir.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.prj_adsva2_24_1S.My.Resources.Resources.taptap_background
        Me.PictureBox1.Location = New System.Drawing.Point(-37, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(818, 417)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 59
        Me.PictureBox1.TabStop = False
        '
        'Form11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrange
        Me.ClientSize = New System.Drawing.Size(745, 408)
        Me.ControlBox = False
        Me.Controls.Add(Me.qtde_estoque)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.data_saida)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.data_entrada)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.logout)
        Me.Controls.Add(Me.validade)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.botao_excluir)
        Me.Controls.Add(Me.nome_fornecedor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nome_produto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.id_produto)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form11"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form11"
        CType(Me.botao_excluir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents logout As Label
    Friend WithEvents validade As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents botao_excluir As PictureBox
    Friend WithEvents nome_fornecedor As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents nome_produto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents id_produto As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents data_entrada As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents data_saida As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents qtde_estoque As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
