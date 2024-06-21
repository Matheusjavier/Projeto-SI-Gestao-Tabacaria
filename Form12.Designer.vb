<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form12
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
        Me.id_produto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nome_fornecedor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nome_produto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.data_pedido = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.logout = New System.Windows.Forms.Label()
        Me.botao_excluir = New System.Windows.Forms.PictureBox()
        Me.botao_atualizar = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.botao_excluir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.botao_atualizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern Warfare", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(133, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(514, 37)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "gerenciar pedidos"
        '
        'id_produto
        '
        Me.id_produto.BackColor = System.Drawing.SystemColors.ControlLight
        Me.id_produto.Location = New System.Drawing.Point(15, 111)
        Me.id_produto.Name = "id_produto"
        Me.id_produto.Size = New System.Drawing.Size(317, 20)
        Me.id_produto.TabIndex = 40
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern Warfare", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(12, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(185, 18)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "ID do produto"
        '
        'nome_fornecedor
        '
        Me.nome_fornecedor.BackColor = System.Drawing.SystemColors.ControlLight
        Me.nome_fornecedor.Location = New System.Drawing.Point(15, 173)
        Me.nome_fornecedor.Name = "nome_fornecedor"
        Me.nome_fornecedor.Size = New System.Drawing.Size(317, 20)
        Me.nome_fornecedor.TabIndex = 47
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern Warfare", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(12, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(329, 17)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Fornecedor para contato"
        '
        'nome_produto
        '
        Me.nome_produto.BackColor = System.Drawing.SystemColors.ControlLight
        Me.nome_produto.Location = New System.Drawing.Point(390, 111)
        Me.nome_produto.Name = "nome_produto"
        Me.nome_produto.Size = New System.Drawing.Size(317, 20)
        Me.nome_produto.TabIndex = 45
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern Warfare", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(387, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(231, 18)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Nome do produto"
        '
        'data_pedido
        '
        Me.data_pedido.BackColor = System.Drawing.SystemColors.ControlLight
        Me.data_pedido.Location = New System.Drawing.Point(390, 172)
        Me.data_pedido.Name = "data_pedido"
        Me.data_pedido.Size = New System.Drawing.Size(317, 20)
        Me.data_pedido.TabIndex = 49
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern Warfare", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(387, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(291, 18)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "data do ultimo pedido"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Modern Warfare", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(179, 290)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(165, 22)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "ATUALIZAR"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern Warfare", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(204, 310)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 22)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "PEDIDO"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Modern Warfare", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(433, 310)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 22)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "PEDIDO"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Modern Warfare", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(427, 290)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(127, 22)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "EXCLUIR"
        '
        'logout
        '
        Me.logout.AutoSize = True
        Me.logout.Font = New System.Drawing.Font("Modern Warfare", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logout.ForeColor = System.Drawing.Color.Crimson
        Me.logout.Location = New System.Drawing.Point(736, 338)
        Me.logout.Name = "logout"
        Me.logout.Size = New System.Drawing.Size(75, 55)
        Me.logout.TabIndex = 56
        Me.logout.Text = "X"
        '
        'botao_excluir
        '
        Me.botao_excluir.Image = Global.prj_adsva2_24_1S.My.Resources.Resources.botão_png3
        Me.botao_excluir.Location = New System.Drawing.Point(390, 269)
        Me.botao_excluir.Name = "botao_excluir"
        Me.botao_excluir.Size = New System.Drawing.Size(203, 83)
        Me.botao_excluir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.botao_excluir.TabIndex = 53
        Me.botao_excluir.TabStop = False
        '
        'botao_atualizar
        '
        Me.botao_atualizar.Image = Global.prj_adsva2_24_1S.My.Resources.Resources.botão_png3
        Me.botao_atualizar.Location = New System.Drawing.Point(161, 269)
        Me.botao_atualizar.Name = "botao_atualizar"
        Me.botao_atualizar.Size = New System.Drawing.Size(203, 83)
        Me.botao_atualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.botao_atualizar.TabIndex = 50
        Me.botao_atualizar.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.prj_adsva2_24_1S.My.Resources.Resources.taptap_background
        Me.PictureBox1.Location = New System.Drawing.Point(-9, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(818, 396)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 57
        Me.PictureBox1.TabStop = False
        '
        'Form12
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrange
        Me.ClientSize = New System.Drawing.Size(800, 389)
        Me.ControlBox = False
        Me.Controls.Add(Me.logout)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.botao_excluir)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.botao_atualizar)
        Me.Controls.Add(Me.data_pedido)
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
        Me.Name = "Form12"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form12"
        CType(Me.botao_excluir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.botao_atualizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents id_produto As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents nome_fornecedor As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents nome_produto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents data_pedido As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents botao_atualizar As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents botao_excluir As PictureBox
    Friend WithEvents logout As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
