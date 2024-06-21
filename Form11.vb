Imports System.Data.OleDb

Public Class Form11
    Private Sub id_produto_Leave(sender As Object, e As EventArgs) Handles id_produto.Leave
        ' Verificar se o id_produto está vazio
        If id_produto.Text.Trim() = "" Then
            Return
        End If

        ' Abrir conexão com o banco de dados
        Dim connection As OleDbConnection = Nothing
        Try
            connection = conectar_banco()
            connection.Open()

            ' Consultar os dados na tabela tb_produtos
            Dim comandoConsultar As New OleDbCommand("SELECT NOME_CERVEJA, CERVEJARIA, VALIDADE, ENTRADA, SAIDA, QUANTIDADE FROM tb_produtos WHERE ID_PRODUTO = ?", connection)
            comandoConsultar.Parameters.AddWithValue("@ID", id_produto.Text)

            Dim reader As OleDbDataReader = comandoConsultar.ExecuteReader()

            If reader.Read() Then
                ' Preencher os campos automaticamente
                nome_produto.Text = If(Not IsDBNull(reader("NOME_CERVEJA")), reader("NOME_CERVEJA").ToString(), "")
                nome_fornecedor.Text = If(Not IsDBNull(reader("CERVEJARIA")), reader("CERVEJARIA").ToString(), "")
                validade.Text = If(Not IsDBNull(reader("VALIDADE")), reader("VALIDADE").ToString(), "")
                data_entrada.Text = If(Not IsDBNull(reader("ENTRADA")), reader("ENTRADA").ToString(), "")
                data_saida.Text = If(Not IsDBNull(reader("SAIDA")), reader("SAIDA").ToString(), "")
                qtde_estoque.Text = If(Not IsDBNull(reader("QUANTIDADE")), reader("QUANTIDADE").ToString(), "")
            Else
                ' Limpar os campos se o produto não for encontrado
                nome_produto.Clear()
                nome_fornecedor.Clear()
                validade.Clear()
                data_entrada.Clear()
                data_saida.Clear()
                qtde_estoque.Clear()
                MessageBox.Show("ID de produto não encontrado na tabela.", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Erro ao conectar ao banco de dados: " & ex.Message, "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connection IsNot Nothing Then
                connection.Close()
            End If
        End Try
    End Sub



    Private Sub botao_excluir_Click(sender As Object, e As EventArgs) Handles botao_excluir.Click
        ' Verificar se o id_produto está vazio
        If id_produto.Text.Trim() = "" Then
            MessageBox.Show("Por favor, insira um ID de produto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Abrir conexão com o banco de dados
        Dim connection As OleDbConnection = Nothing
        Try
            connection = conectar_banco()
            connection.Open()

            ' Verificar se o valor de data_saida é diferente do valor da coluna SAIDA no banco de dados
            Dim comandoVerificarSaida As New OleDbCommand("SELECT SAIDA FROM tb_produtos WHERE ID_PRODUTO = ?", connection)
            comandoVerificarSaida.Parameters.AddWithValue("@ID", id_produto.Text)
            Dim saidaNoBanco As Object = comandoVerificarSaida.ExecuteScalar()

            If saidaNoBanco IsNot Nothing AndAlso data_saida.Text <> saidaNoBanco.ToString() Then
                ' Atualizar a coluna QUANTIDADE na tabela tb_produtos
                Dim comandoAtualizarQuantidade As New OleDbCommand("UPDATE tb_produtos SET QUANTIDADE = QUANTIDADE - 1 WHERE ID_PRODUTO = ?", connection)
                comandoAtualizarQuantidade.Parameters.AddWithValue("@ID", id_produto.Text)
                Dim linhasAfetadasQuantidade As Integer = comandoAtualizarQuantidade.ExecuteNonQuery()
                If linhasAfetadasQuantidade > 0 Then
                    MessageBox.Show("A quantidade do produto foi atualizada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Erro ao atualizar a quantidade do produto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If

            ' Atualizar os valores das colunas ENTRADA e SAIDA na tabela tb_produtos
            Dim comandoAtualizar As New OleDbCommand("UPDATE tb_produtos SET ENTRADA = ?, SAIDA = ? WHERE ID_PRODUTO = ?", connection)
            comandoAtualizar.Parameters.AddWithValue("@Entrada", data_entrada.Text)
            comandoAtualizar.Parameters.AddWithValue("@Saida", data_saida.Text)
            comandoAtualizar.Parameters.AddWithValue("@ID", id_produto.Text)

            Dim linhasAfetadas As Integer = comandoAtualizar.ExecuteNonQuery()
            If linhasAfetadas > 0 Then
                MessageBox.Show("Os valores de ENTRADA e SAIDA foram atualizados com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Nenhum produto encontrado com o ID especificado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Erro ao conectar ao banco de dados: " & ex.Message, "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connection IsNot Nothing Then
                connection.Close()
            End If
        End Try
    End Sub


    Private Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        ' Exibir o Form1 e fechar o formulário atual
        Dim form7 As New Form7()
        form7.Show()
        Me.Close()
    End Sub

    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        ' Verificar se o id_produto está vazio
        If id_produto.Text.Trim() = "" Then
            MessageBox.Show("Por favor, insira um ID de produto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Abrir conexão com o banco de dados
        Dim connection As OleDbConnection = Nothing
        Try
            connection = conectar_banco()
            connection.Open()

            ' Verificar se o valor de data_saida é diferente do valor da coluna SAIDA no banco de dados
            Dim comandoVerificarSaida As New OleDbCommand("SELECT SAIDA FROM tb_produtos WHERE ID_PRODUTO = ?", connection)
            comandoVerificarSaida.Parameters.AddWithValue("@ID", id_produto.Text)
            Dim saidaNoBanco As Object = comandoVerificarSaida.ExecuteScalar()

            If saidaNoBanco IsNot Nothing AndAlso data_saida.Text <> saidaNoBanco.ToString() Then
                ' Atualizar a coluna QUANTIDADE na tabela tb_produtos
                Dim comandoAtualizarQuantidade As New OleDbCommand("UPDATE tb_produtos SET QUANTIDADE = QUANTIDADE - 1 WHERE ID_PRODUTO = ?", connection)
                comandoAtualizarQuantidade.Parameters.AddWithValue("@ID", id_produto.Text)
                Dim linhasAfetadasQuantidade As Integer = comandoAtualizarQuantidade.ExecuteNonQuery()
                If linhasAfetadasQuantidade > 0 Then
                    MessageBox.Show("A quantidade do produto foi atualizada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Erro ao atualizar a quantidade do produto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If

            ' Atualizar os valores das colunas ENTRADA e SAIDA na tabela tb_produtos
            Dim comandoAtualizar As New OleDbCommand("UPDATE tb_produtos SET ENTRADA = ?, SAIDA = ? WHERE ID_PRODUTO = ?", connection)
            comandoAtualizar.Parameters.AddWithValue("@Entrada", data_entrada.Text)
            comandoAtualizar.Parameters.AddWithValue("@Saida", data_saida.Text)
            comandoAtualizar.Parameters.AddWithValue("@ID", id_produto.Text)

            Dim linhasAfetadas As Integer = comandoAtualizar.ExecuteNonQuery()
            If linhasAfetadas > 0 Then
                MessageBox.Show("Os valores de ENTRADA e SAIDA foram atualizados com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Nenhum produto encontrado com o ID especificado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Erro ao conectar ao banco de dados: " & ex.Message, "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connection IsNot Nothing Then
                connection.Close()
            End If
        End Try
    End Sub
End Class