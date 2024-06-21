Public Class Form21
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Form21 As New Form20()
        Form20.Show()
        Me.Visible = False
        Form20.Visible = True
    End Sub

    Private Sub txt_cpf_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txt_preco.MaskInputRejected

    End Sub

    Private Sub txt_nome_TextChanged(sender As Object, e As EventArgs) Handles txt_id.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txt_id.Text = "" Or
           txt_produto.Text = "" Or
           txt_sabor.Text = "" Or
           txt_quantidade.Text = "" Or
           txt_preco.Text = "" Or
           cmb_data.Text = "" Then

            MsgBox("Preencha todos os campos!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

        Else
            Try
                SQL = "SELECT * FROM tb_estoque WHERE Código = '" & txt_id.Text & "'"
                rs = db.Execute(SQL)
                If rs.EOF = False Then
                    MsgBox("O Código ID já existe!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                Else
                    SQL = "INSERT INTO tb_estoque (Código, produto, sabor, quantidade, preco, dataChegada) VALUES ('" & txt_id.Text & "', " &
                          "'" & txt_produto.Text & "', " &
                          "'" & txt_sabor.Text & "', " &
                          "'" & txt_quantidade.Text & "', " &
                          "'" & txt_preco.Text & "', " &
                          "'" & cmb_data.Text & "')"

                    rs = db.Execute(UCase(SQL))
                    MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                End If
            Catch ex As Exception
                MsgBox("Erro ao gravar os dados: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
            End Try
        End If
    End Sub

    Private Sub Form17_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
    End Sub
End Class