Imports System.Data.OleDb

Public Class Form12
    Private Sub id_produto_LostFocus(sender As Object, e As EventArgs) Handles id_produto.LostFocus
        ' Verificar se o campo id_produto não está vazio
        If Not String.IsNullOrEmpty(id_produto.Text) Then
            ' Conectar ao banco de dados
            Dim conexao As OleDbConnection = conectar_banco()

            Try
                ' Abrir a conexão
                conexao.Open()

                ' Consulta SQL para obter as informações do produto
                Dim sql As String = $"SELECT NOME_CERVEJA, CERVEJARIA, PEDIDO FROM tb_produtos WHERE ID_PRODUTO = {id_produto.Text}"

                ' Criar o comando para executar a consulta
                Dim comando As New OleDbCommand(sql, conexao)

                ' Executar a consulta e obter o resultado
                Dim resultado As OleDbDataReader = comando.ExecuteReader()

                ' Verificar se há linhas retornadas
                If resultado.Read() Then
                    ' Preencher os campos de texto com as informações do produto
                    nome_produto.Text = resultado("NOME_CERVEJA").ToString()
                    nome_fornecedor.Text = resultado("CERVEJARIA").ToString()
                    data_pedido.Text = resultado("PEDIDO").ToString()
                Else
                    ' Limpar os campos de texto se nenhum resultado for encontrado
                    nome_produto.Text = ""
                    nome_fornecedor.Text = ""
                    data_pedido.Text = ""
                End If

            Catch ex As Exception
                ' Lidar com exceções, se houver
                MessageBox.Show("Erro ao buscar informações do produto: " & ex.Message)

            Finally
                ' Fechar a conexão
                conexao.Close()
            End Try
        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        ' Verificar se o campo id_produto está vazio
        If String.IsNullOrEmpty(id_produto.Text) Then
            MessageBox.Show("Por favor, insira o ID do produto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Verificar se o campo data_pedido está vazio
        If String.IsNullOrEmpty(data_pedido.Text) Then
            MessageBox.Show("Não foi possível atualizar o pedido porque o campo está vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Conectar ao banco de dados
        Dim conexao As OleDbConnection = conectar_banco()

        Try
            ' Abrir a conexão
            conexao.Open()

            ' Consulta SQL para verificar se o produto com o id_produto especificado existe na tabela
            Dim consultaExistencia As String = "SELECT COUNT(*) FROM tb_produtos WHERE ID_PRODUTO = ?"
            Dim comandoExistencia As New OleDbCommand(consultaExistencia, conexao)
            comandoExistencia.Parameters.AddWithValue("@ID", id_produto.Text)
            Dim quantidadeProdutos As Integer = Convert.ToInt32(comandoExistencia.ExecuteScalar())

            If quantidadeProdutos = 0 Then
                MessageBox.Show("Não existe um produto com o ID especificado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Consulta SQL para atualizar o valor da coluna PEDIDO do produto correspondente ao id_produto
            Dim consultaAtualizacao As String = "UPDATE tb_produtos SET PEDIDO = ? WHERE ID_PRODUTO = ?"
            Dim comandoAtualizacao As New OleDbCommand(consultaAtualizacao, conexao)
            comandoAtualizacao.Parameters.AddWithValue("@Pedido", data_pedido.Text)
            comandoAtualizacao.Parameters.AddWithValue("@ID", id_produto.Text)

            ' Executar a atualização
            Dim linhasAfetadas As Integer = comandoAtualizacao.ExecuteNonQuery()

            If linhasAfetadas > 0 Then
                MessageBox.Show("Pedido atualizado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Nenhum dado foi atualizado.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Erro ao atualizar o pedido: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Fechar a conexão
            conexao.Close()
        End Try
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        ' Verificar se o campo id_produto está vazio
        If String.IsNullOrEmpty(id_produto.Text) Then
            MessageBox.Show("Por favor, insira o ID do produto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Verificar se o campo data_pedido está vazio
        If String.IsNullOrEmpty(data_pedido.Text) Then
            MessageBox.Show("Não foi possível atualizar o pedido porque o campo está vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Conectar ao banco de dados
        Dim conexao As OleDbConnection = conectar_banco()

        Try
            ' Abrir a conexão
            conexao.Open()

            ' Consulta SQL para verificar se o produto com o id_produto especificado existe na tabela
            Dim consultaExistencia As String = "SELECT COUNT(*) FROM tb_produtos WHERE ID_PRODUTO = ?"
            Dim comandoExistencia As New OleDbCommand(consultaExistencia, conexao)
            comandoExistencia.Parameters.AddWithValue("@ID", id_produto.Text)
            Dim quantidadeProdutos As Integer = Convert.ToInt32(comandoExistencia.ExecuteScalar())

            If quantidadeProdutos = 0 Then
                MessageBox.Show("Não existe um produto com o ID especificado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Consulta SQL para atualizar o valor da coluna PEDIDO do produto correspondente ao id_produto
            Dim consultaAtualizacao As String = "UPDATE tb_produtos SET PEDIDO = ? WHERE ID_PRODUTO = ?"
            Dim comandoAtualizacao As New OleDbCommand(consultaAtualizacao, conexao)
            comandoAtualizacao.Parameters.AddWithValue("@Pedido", data_pedido.Text)
            comandoAtualizacao.Parameters.AddWithValue("@ID", id_produto.Text)

            ' Executar a atualização
            Dim linhasAfetadas As Integer = comandoAtualizacao.ExecuteNonQuery()

            If linhasAfetadas > 0 Then
                MessageBox.Show("Pedido atualizado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Nenhum dado foi atualizado.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Erro ao atualizar o pedido: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Fechar a conexão
            conexao.Close()
        End Try
    End Sub

    Private Sub Form12_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub botao_atualizar_Click(sender As Object, e As EventArgs) Handles botao_atualizar.Click
        ' Verificar se o campo id_produto está vazio
        If String.IsNullOrEmpty(id_produto.Text) Then
            MessageBox.Show("Por favor, insira o ID do produto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Verificar se o campo data_pedido está vazio
        If String.IsNullOrEmpty(data_pedido.Text) Then
            MessageBox.Show("Não foi possível atualizar o pedido porque o campo está vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Conectar ao banco de dados
        Dim conexao As OleDbConnection = conectar_banco()

        Try
            ' Abrir a conexão
            conexao.Open()

            ' Consulta SQL para verificar se o produto com o id_produto especificado existe na tabela
            Dim consultaExistencia As String = "SELECT COUNT(*) FROM tb_produtos WHERE ID_PRODUTO = ?"
            Dim comandoExistencia As New OleDbCommand(consultaExistencia, conexao)
            comandoExistencia.Parameters.AddWithValue("@ID", id_produto.Text)
            Dim quantidadeProdutos As Integer = Convert.ToInt32(comandoExistencia.ExecuteScalar())

            If quantidadeProdutos = 0 Then
                MessageBox.Show("Não existe um produto com o ID especificado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Consulta SQL para atualizar o valor da coluna PEDIDO do produto correspondente ao id_produto
            Dim consultaAtualizacao As String = "UPDATE tb_produtos SET PEDIDO = ? WHERE ID_PRODUTO = ?"
            Dim comandoAtualizacao As New OleDbCommand(consultaAtualizacao, conexao)
            comandoAtualizacao.Parameters.AddWithValue("@Pedido", data_pedido.Text)
            comandoAtualizacao.Parameters.AddWithValue("@ID", id_produto.Text)

            ' Executar a atualização
            Dim linhasAfetadas As Integer = comandoAtualizacao.ExecuteNonQuery()

            If linhasAfetadas > 0 Then
                MessageBox.Show("Pedido atualizado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Nenhum dado foi atualizado.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Erro ao atualizar o pedido: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Fechar a conexão
            conexao.Close()
        End Try
    End Sub



    Private Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        ' Exibir o Form1 e fechar o formulário atual
        Dim form6 As New Form6()
        form6.Show()
        Me.Close()
    End Sub

    Private Sub botao_excluir_Click(sender As Object, e As EventArgs) Handles botao_excluir.Click
        ' Verificar se o campo id_produto está vazio
        If String.IsNullOrEmpty(id_produto.Text) Then
            ' Exibir mensagem de erro
            MessageBox.Show("Por favor, insira um ID de produto válido para excluir.")
            Return
        End If

        ' Conectar ao banco de dados
        Dim conexao As OleDbConnection = conectar_banco()

        Try
            ' Abrir a conexão
            conexao.Open()

            ' Consulta SQL para atualizar o valor da coluna PEDIDO para NULL
            Dim sql As String = $"UPDATE tb_produtos SET PEDIDO = NULL WHERE ID_PRODUTO = {id_produto.Text}"

            ' Criar o comando para executar a atualização
            Dim comando As New OleDbCommand(sql, conexao)

            ' Executar a atualização
            Dim linhasAfetadas As Integer = comando.ExecuteNonQuery()

            ' Verificar se algum registro foi atualizado
            If linhasAfetadas > 0 Then
                ' Exibir mensagem de sucesso
                MessageBox.Show("Pedido do produto excluído com sucesso.")
            Else
                ' Exibir mensagem se nenhum registro foi encontrado para atualizar
                MessageBox.Show("Nenhum registro encontrado com o ID fornecido.")
            End If

        Catch ex As Exception
            ' Lidar com exceções, se houver
            MessageBox.Show("Erro ao excluir o pedido do produto: " & ex.Message)

        Finally
            ' Fechar a conexão
            conexao.Close()
        End Try
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        ' Verificar se o campo id_produto está vazio
        If String.IsNullOrEmpty(id_produto.Text) Then
            ' Exibir mensagem de erro
            MessageBox.Show("Por favor, insira um ID de produto válido para excluir.")
            Return
        End If

        ' Conectar ao banco de dados
        Dim conexao As OleDbConnection = conectar_banco()

        Try
            ' Abrir a conexão
            conexao.Open()

            ' Consulta SQL para atualizar o valor da coluna PEDIDO para NULL
            Dim sql As String = $"UPDATE tb_produtos SET PEDIDO = NULL WHERE ID_PRODUTO = {id_produto.Text}"

            ' Criar o comando para executar a atualização
            Dim comando As New OleDbCommand(sql, conexao)

            ' Executar a atualização
            Dim linhasAfetadas As Integer = comando.ExecuteNonQuery()

            ' Verificar se algum registro foi atualizado
            If linhasAfetadas > 0 Then
                ' Exibir mensagem de sucesso
                MessageBox.Show("Pedido do produto excluído com sucesso.")
            Else
                ' Exibir mensagem se nenhum registro foi encontrado para atualizar
                MessageBox.Show("Nenhum registro encontrado com o ID fornecido.")
            End If

        Catch ex As Exception
            ' Lidar com exceções, se houver
            MessageBox.Show("Erro ao excluir o pedido do produto: " & ex.Message)

        Finally
            ' Fechar a conexão
            conexao.Close()
        End Try
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        ' Verificar se o campo id_produto está vazio
        If String.IsNullOrEmpty(id_produto.Text) Then
            ' Exibir mensagem de erro
            MessageBox.Show("Por favor, insira um ID de produto válido para excluir.")
            Return
        End If

        ' Conectar ao banco de dados
        Dim conexao As OleDbConnection = conectar_banco()

        Try
            ' Abrir a conexão
            conexao.Open()

            ' Consulta SQL para atualizar o valor da coluna PEDIDO para NULL
            Dim sql As String = $"UPDATE tb_produtos SET PEDIDO = NULL WHERE ID_PRODUTO = {id_produto.Text}"

            ' Criar o comando para executar a atualização
            Dim comando As New OleDbCommand(sql, conexao)

            ' Executar a atualização
            Dim linhasAfetadas As Integer = comando.ExecuteNonQuery()

            ' Verificar se algum registro foi atualizado
            If linhasAfetadas > 0 Then
                ' Exibir mensagem de sucesso
                MessageBox.Show("Pedido do produto excluído com sucesso.")
            Else
                ' Exibir mensagem se nenhum registro foi encontrado para atualizar
                MessageBox.Show("Nenhum registro encontrado com o ID fornecido.")
            End If

        Catch ex As Exception
            ' Lidar com exceções, se houver
            MessageBox.Show("Erro ao excluir o pedido do produto: " & ex.Message)

        Finally
            ' Fechar a conexão
            conexao.Close()
        End Try
    End Sub
End Class