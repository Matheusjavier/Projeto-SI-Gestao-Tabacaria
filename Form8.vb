Public Class Form8
    Private Sub botao_gravar_Click(sender As Object, e As EventArgs) Handles botao_gravar.Click
        ' Verificação de campos vazios
        If String.IsNullOrWhiteSpace(nome_produto.Text) Or
           String.IsNullOrWhiteSpace(nome_fornecedor.Text) Or
           String.IsNullOrWhiteSpace(cnpj_fornecedor.Text) Or
           String.IsNullOrWhiteSpace(telefone_fornecedor.Text) Then
            MessageBox.Show("Preencha todos os campos!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        Exit Sub
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        ' Verificação de campos vazios
        If String.IsNullOrWhiteSpace(nome_produto.Text) Or
           String.IsNullOrWhiteSpace(nome_fornecedor.Text) Or
           String.IsNullOrWhiteSpace(cnpj_fornecedor.Text) Or
           String.IsNullOrWhiteSpace(telefone_fornecedor.Text) Then
            MessageBox.Show("Preencha todos os campos!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        Exit Sub
    End Sub

End Class
