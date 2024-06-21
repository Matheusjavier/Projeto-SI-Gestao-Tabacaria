<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form10
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
        Me.qtde_barril = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.validade = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.logout = New System.Windows.Forms.Label()
        Me.botao_atualizar = New System.Windows.Forms.PictureBox()
        Me.botao_limpar = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.botao_atualizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.botao_limpar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern Warfare", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(712, 55)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "NIVEIS DE ESTOQUE"
        '
        'id_produto
        '
        Me.id_produto.BackColor = System.Drawing.SystemColors.ControlLight
        Me.id_produto.Location = New System.Drawing.Point(37, 131)
        Me.id_produto.Name = "id_produto"
        Me.id_produto.Size = New System.Drawing.Size(317, 20)
        Me.id_produto.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern Warfare", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(34, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(185, 18)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "id do produto"
        '
        'nome_produto
        '
        Me.nome_produto.BackColor = System.Drawing.SystemColors.ControlLight
        Me.nome_produto.Location = New System.Drawing.Point(37, 190)
        Me.nome_produto.Name = "nome_produto"
        Me.nome_produto.Size = New System.Drawing.Size(317, 20)
        Me.nome_produto.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern Warfare", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(34, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(231, 18)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "nome do produto"
        '
        'nome_fornecedor
        '
        Me.nome_fornecedor.BackColor = System.Drawing.SystemColors.ControlLight
        Me.nome_fornecedor.Location = New System.Drawing.Point(37, 249)
        Me.nome_fornecedor.Name = "nome_fornecedor"
        Me.nome_fornecedor.Size = New System.Drawing.Size(317, 20)
        Me.nome_fornecedor.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern Warfare", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(34, 228)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 18)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "fornecedor"
        '
        'qtde_barril
        '
        Me.qtde_barril.BackColor = System.Drawing.SystemColors.ControlLight
        Me.qtde_barril.Location = New System.Drawing.Point(37, 309)
        Me.qtde_barril.Name = "qtde_barril"
        Me.qtde_barril.Size = New System.Drawing.Size(317, 20)
        Me.qtde_barril.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern Warfare", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(34, 288)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(286, 18)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "quantidade de barris"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern Warfare", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(440, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 18)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "limpar"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Modern Warfare", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(600, 135)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(138, 18)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "atualizar"
        '
        'validade
        '
        Me.validade.BackColor = System.Drawing.SystemColors.ControlLight
        Me.validade.Location = New System.Drawing.Point(37, 366)
        Me.validade.Name = "validade"
        Me.validade.Size = New System.Drawing.Size(317, 20)
        Me.validade.TabIndex = 39
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Modern Warfare", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(34, 345)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(229, 18)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "data de validade"
        '
        'logout
        '
        Me.logout.AutoSize = True
        Me.logout.Font = New System.Drawing.Font("Modern Warfare", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logout.ForeColor = System.Drawing.Color.Crimson
        Me.logout.Location = New System.Drawing.Point(736, 399)
        Me.logout.Name = "logout"
        Me.logout.Size = New System.Drawing.Size(75, 55)
        Me.logout.TabIndex = 40
        Me.logout.Text = "X"
        '
        'botao_atualizar
        '
        Me.botao_atualizar.Image = Global.prj_adsva2_24_1S.My.Resources.Resources.botão_png3
        Me.botao_atualizar.Location = New System.Drawing.Point(584, 110)
        Me.botao_atualizar.Name = "botao_atualizar"
        Me.botao_atualizar.Size = New System.Drawing.Size(165, 68)
        Me.botao_atualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.botao_atualizar.TabIndex = 36
        Me.botao_atualizar.TabStop = False
        '
        'botao_limpar
        '
        Me.botao_limpar.Image = Global.prj_adsva2_24_1S.My.Resources.Resources.botão_png3
        Me.botao_limpar.Location = New System.Drawing.Point(404, 110)
        Me.botao_limpar.Name = "botao_limpar"
        Me.botao_limpar.Size = New System.Drawing.Size(165, 68)
        Me.botao_limpar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.botao_limpar.TabIndex = 34
        Me.botao_limpar.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.prj_adsva2_24_1S.My.Resources.Resources.taptap_background
        Me.PictureBox1.Location = New System.Drawing.Point(-9, -6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(818, 471)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 41
        Me.PictureBox1.TabStop = False
        '
        'Form10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrange
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.logout)
        Me.Controls.Add(Me.validade)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.botao_atualizar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.botao_limpar)
        Me.Controls.Add(Me.qtde_barril)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.nome_fornecedor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nome_produto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.id_produto)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form10"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form10"
        CType(Me.botao_atualizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.botao_limpar, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents qtde_barril As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents botao_limpar As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents botao_atualizar As PictureBox
    Friend WithEvents validade As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents logout As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
