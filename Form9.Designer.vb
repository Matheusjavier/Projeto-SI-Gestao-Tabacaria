<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        Me.nome_funcionario = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cpf_funcionario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.email_funcionario = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.senha_funcionario = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cargo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.logout = New System.Windows.Forms.Label()
        Me.botao_excluir = New System.Windows.Forms.PictureBox()
        Me.botao_gravar = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.botao_excluir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.botao_gravar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Modern Warfare", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(760, 43)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "gerenciar funcionarios"
        '
        'nome_funcionario
        '
        Me.nome_funcionario.BackColor = System.Drawing.SystemColors.ControlLight
        Me.nome_funcionario.Location = New System.Drawing.Point(15, 195)
        Me.nome_funcionario.Name = "nome_funcionario"
        Me.nome_funcionario.Size = New System.Drawing.Size(317, 20)
        Me.nome_funcionario.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern Warfare", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(12, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(276, 18)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "nome do funcionario"
        '
        'cpf_funcionario
        '
        Me.cpf_funcionario.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cpf_funcionario.Location = New System.Drawing.Point(15, 129)
        Me.cpf_funcionario.Name = "cpf_funcionario"
        Me.cpf_funcionario.Size = New System.Drawing.Size(317, 20)
        Me.cpf_funcionario.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern Warfare", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(12, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(250, 18)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "cpf do funcionario"
        '
        'email_funcionario
        '
        Me.email_funcionario.BackColor = System.Drawing.SystemColors.ControlLight
        Me.email_funcionario.Location = New System.Drawing.Point(15, 266)
        Me.email_funcionario.Name = "email_funcionario"
        Me.email_funcionario.Size = New System.Drawing.Size(317, 20)
        Me.email_funcionario.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern Warfare", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(12, 245)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(277, 18)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "email do funcionario"
        '
        'senha_funcionario
        '
        Me.senha_funcionario.BackColor = System.Drawing.SystemColors.ControlLight
        Me.senha_funcionario.Location = New System.Drawing.Point(16, 329)
        Me.senha_funcionario.Name = "senha_funcionario"
        Me.senha_funcionario.Size = New System.Drawing.Size(317, 20)
        Me.senha_funcionario.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern Warfare", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(13, 308)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(288, 18)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "senha do funcionario"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern Warfare", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(429, 249)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 18)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "gravar"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Modern Warfare", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(620, 249)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 18)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "excluir"
        '
        'cargo
        '
        Me.cargo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cargo.Location = New System.Drawing.Point(403, 129)
        Me.cargo.Name = "cargo"
        Me.cargo.Size = New System.Drawing.Size(317, 20)
        Me.cargo.TabIndex = 33
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Modern Warfare", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(400, 108)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 18)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "cargo"
        '
        'logout
        '
        Me.logout.AutoSize = True
        Me.logout.BackColor = System.Drawing.Color.Transparent
        Me.logout.Font = New System.Drawing.Font("Modern Warfare", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logout.ForeColor = System.Drawing.Color.Crimson
        Me.logout.Location = New System.Drawing.Point(738, 346)
        Me.logout.Name = "logout"
        Me.logout.Size = New System.Drawing.Size(75, 55)
        Me.logout.TabIndex = 34
        Me.logout.Text = "X"
        '
        'botao_excluir
        '
        Me.botao_excluir.Image = Global.prj_adsva2_24_1S.My.Resources.Resources.botão_png3
        Me.botao_excluir.Location = New System.Drawing.Point(592, 225)
        Me.botao_excluir.Name = "botao_excluir"
        Me.botao_excluir.Size = New System.Drawing.Size(165, 65)
        Me.botao_excluir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.botao_excluir.TabIndex = 30
        Me.botao_excluir.TabStop = False
        '
        'botao_gravar
        '
        Me.botao_gravar.Image = Global.prj_adsva2_24_1S.My.Resources.Resources.botão_png3
        Me.botao_gravar.Location = New System.Drawing.Point(403, 225)
        Me.botao_gravar.Name = "botao_gravar"
        Me.botao_gravar.Size = New System.Drawing.Size(165, 65)
        Me.botao_gravar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.botao_gravar.TabIndex = 28
        Me.botao_gravar.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.prj_adsva2_24_1S.My.Resources.Resources.taptap_background
        Me.PictureBox1.Location = New System.Drawing.Point(-9, -9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(818, 410)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'Form9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrange
        Me.ClientSize = New System.Drawing.Size(800, 395)
        Me.ControlBox = False
        Me.Controls.Add(Me.logout)
        Me.Controls.Add(Me.cargo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.botao_excluir)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.botao_gravar)
        Me.Controls.Add(Me.senha_funcionario)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.email_funcionario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cpf_funcionario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nome_funcionario)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form9"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form9"
        CType(Me.botao_excluir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.botao_gravar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents nome_funcionario As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cpf_funcionario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents email_funcionario As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents senha_funcionario As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents botao_gravar As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents botao_excluir As PictureBox
    Friend WithEvents cargo As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents logout As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
