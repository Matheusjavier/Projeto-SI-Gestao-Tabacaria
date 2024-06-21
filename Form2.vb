Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        carregar_dados()
        carregar_tipo()
    End Sub

    Private Sub btn_logar_Click(sender As Object, e As EventArgs) Handles btn_logar.Click
        SQL = "select * from tb_cadastro where (nome='" & txt_usuario.Text & "') and (senha='" & txt_senha.Text & "') and status='" & "ATIVO" & "'"
        rs = db.Execute(SQL)
        If txt_usuario.Text = "" Or
           txt_senha.Text = Text Then
            MsgBox("Preencha todos os campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
        ElseIf txt_usuario.Text = "admin" And txt_senha.Text = "admin" Then
            Dim Form2 As New Form4()
            Form4.Show()
            Me.Visible = False
            MsgBox("Conta admin logada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        ElseIf rs.EOF = False Then
            MsgBox("Conta logada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            Dim Form2 As New Form19()
            Form19.Show()
            Me.Visible = False
        Else
            SQL = "select * from tb_cadastro where (nome='" & txt_usuario.Text & "') and (senha='" & txt_senha.Text & "') and status='" & "BLOQUEADO" & "'"
            rs = db.Execute(SQL)
            If rs.EOF = False Then
                MsgBox("Usuário bloqueado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            Else
                MsgBox("Usuário não cadastrado ou dados incorretos!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                txt_usuario.Clear()
                txt_senha.Clear()
                txt_usuario.Focus()
            End If
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txt_senha.PasswordChar = ""
        Else
            txt_senha.PasswordChar = "*"
        End If
    End Sub

    Private Sub txt_usuario_TextChanged(sender As Object, e As EventArgs) Handles txt_usuario.TextChanged

    End Sub
End Class