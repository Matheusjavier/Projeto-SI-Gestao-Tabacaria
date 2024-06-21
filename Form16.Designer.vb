<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form16
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form16))
        Me.btn_controle = New System.Windows.Forms.Button()
        Me.btn_gerenciar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_controle
        '
        Me.btn_controle.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btn_controle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_controle.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_controle.Location = New System.Drawing.Point(510, 261)
        Me.btn_controle.Name = "btn_controle"
        Me.btn_controle.Size = New System.Drawing.Size(208, 85)
        Me.btn_controle.TabIndex = 0
        Me.btn_controle.Text = "CONTROLE DE SAÍDA"
        Me.btn_controle.UseVisualStyleBackColor = False
        '
        'btn_gerenciar
        '
        Me.btn_gerenciar.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btn_gerenciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_gerenciar.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gerenciar.Location = New System.Drawing.Point(510, 150)
        Me.btn_gerenciar.Name = "btn_gerenciar"
        Me.btn_gerenciar.Size = New System.Drawing.Size(208, 88)
        Me.btn_gerenciar.TabIndex = 1
        Me.btn_gerenciar.Text = "GERENCIAR ESTOQUE"
        Me.btn_gerenciar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(421, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(381, 40)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "GERÊNCIA DE ESTOQUE"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(715, 375)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(73, 63)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "VOLTAR"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Form16
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_gerenciar)
        Me.Controls.Add(Me.btn_controle)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form16"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GERÊNCIA DE ESTOQUE               "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_controle As Button
    Friend WithEvents btn_gerenciar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
End Class
