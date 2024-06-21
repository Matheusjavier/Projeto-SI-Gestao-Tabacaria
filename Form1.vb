Public Class Form1
    Private Sub img_foto_Click(sender As Object, e As EventArgs) Handles img_foto.Click
        Try
            With OpenFileDialog1
                .Title = "SELECIONE UMA FOTO DO CLIENTE"
                .InitialDirectory = Application.StartupPath & "\Fotos"
                .ShowDialog()
                diretorio = .FileName
                img_foto.Load(diretorio)
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        carregar_dados()
        carregar_tipo()
    End Sub

    Private Sub btn_gravar_Click(sender As Object, e As EventArgs) Handles btn_gravar.Click
        Try
            SQL = "select * from tb_cadastro where cpf='" & txt_cpf.Text & "'"
            rs = db.Execute(SQL)
            If rs.EOF = True Then 'Se não existir o cpf na tabela tb_cadastro
                SQL = "insert into tb_cadastro values ('" & txt_cpf.Text & "', " &
                                                    "'" & txt_nome.Text & "', " &
                                                    "'" & cmb_data_nasc.Value.Date & "', " &
                                                    "'" & txt_fone.Text & "', " &
                                                    "'" & txt_email.Text & "', " &
                                                    "'" & diretorio & "', " &
                                                    "'" & "ATIVO" & "', " &
                                                    "'" & txt_senha.Text & "')"
                rs = db.Execute(UCase(SQL))
                MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

            Else
                SQL = "update tb_cadastro set nome ='" & txt_nome.Text & "', " &
                                            "data_nasc='" & cmb_data_nasc.Value.Date & "', " &
                                            "fone='" & txt_fone.Text & "', " &
                                            "email='" & txt_email.Text & "', " &
                                            "foto='" & diretorio & "' where cpf='" & txt_cpf.Text & "'"
                rs = db.Execute(UCase(SQL))
                MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            End If
            limpar_cadastro()
            carregar_dados()
        Catch ex As Exception
            MsgBox("Erro ao gravar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub


    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Form1 As New Form4()
        Form4.Show()
        Me.Visible = False
        Form4.Visible = True
    End Sub
End Class
