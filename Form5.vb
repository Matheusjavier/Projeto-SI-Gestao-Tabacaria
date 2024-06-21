Imports System.Data.OleDb

Public Class Form5
    Private Sub botao_cadastrar_Click(sender As Object, e As EventArgs) Handles botao_cadastrar.Click
        ' Verificar se os campos obrigatórios estão preenchidos
        If nome_produto.Text.Trim() = "" Or nome_fornecedor.Text.Trim() = "" Or validade_produto.Text.Trim() = "" Then
            MessageBox.Show("Todos os campos devem estar preenchidos.", "Erro de Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Abrir conexão com o banco de dados
        Dim connection As OleDbConnection = conectar_banco()

        Try
            connection.Open()

            ' Verificar se o produto já está cadastrado na tabela
            Dim comandoVerificar As New OleDbCommand("SELECT COUNT(*) FROM tb_produtos WHERE CERVEJARIA = @Fornecedor AND NOME_CERVEJA = @Produto", connection)
            comandoVerificar.Parameters.AddWithValue("@Fornecedor", nome_fornecedor.Text)
            comandoVerificar.Parameters.AddWithValue("@Produto", nome_produto.Text)

            Dim count As Integer = Convert.ToInt32(comandoVerificar.ExecuteScalar())
            If count > 0 Then
                MessageBox.Show("Este produto já foi cadastrado.", "Erro de Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return ' Sai do método sem fazer mais nada
            End If

            ' Verificar o próximo id_produto disponível
            Dim comandoNextID As New OleDbCommand("SELECT MAX(id_produto) + 1 FROM tb_produtos", connection)
            Dim nextID As Object = comandoNextID.ExecuteScalar()
            Dim newID As Integer = If(nextID IsNot DBNull.Value, Convert.ToInt32(nextID), 1)

            ' Inserir o novo produto na tabela
            Dim comandoInserir As New OleDbCommand("INSERT INTO tb_produtos (id_produto, CERVEJARIA, NOME_CERVEJA, VALIDADE) VALUES (@ID, @Fornecedor, @Produto, @Validade)", connection)
            comandoInserir.Parameters.AddWithValue("@ID", newID)
            comandoInserir.Parameters.AddWithValue("@Fornecedor", nome_fornecedor.Text)
            comandoInserir.Parameters.AddWithValue("@Produto", nome_produto.Text)
            comandoInserir.Parameters.AddWithValue("@Validade", validade_produto.Text)

            Dim rowsAffected As Integer = comandoInserir.ExecuteNonQuery()
            If rowsAffected > 0 Then
                MessageBox.Show("Produto cadastrado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Erro ao cadastrar o produto.", "Erro de Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Erro ao conectar ao banco de dados: " & ex.Message, "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Close()
        End Try
    End Sub





    Private Sub id_produto_Leave(sender As Object, e As EventArgs) Handles id_produto.Leave
        ' Verificar se o id_produto está vazio
        If id_produto.Text.Trim() = "" Then
            Return
        End If

        ' Abrir conexão com o banco de dados
        Dim connection As OleDbConnection = conectar_banco()

        Try
            connection.Open()

            ' Consultar o nome_produto, nome_fornecedor e validade_produto correspondentes ao id_produto
            Dim comandoConsultar As New OleDbCommand("SELECT NOME_CERVEJA, CERVEJARIA, VALIDADE FROM tb_produtos WHERE id_produto = @ID", connection)
            comandoConsultar.Parameters.AddWithValue("@ID", id_produto.Text)

            Dim reader As OleDbDataReader = comandoConsultar.ExecuteReader()
            If reader.Read() Then
                ' Preencher os campos automaticamente
                nome_produto.Text = reader("NOME_CERVEJA").ToString()
                nome_fornecedor.Text = reader("CERVEJARIA").ToString()
                validade_produto.Text = reader("VALIDADE").ToString()
            Else
                MessageBox.Show("ID de produto não encontrado na tabela.", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Erro ao conectar ao banco de dados: " & ex.Message, "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Close()
        End Try
    End Sub


    Private Sub botao_excluir_Click(sender As Object, e As EventArgs) Handles botao_excluir.Click
        ' Verificar se os campos obrigatórios estão preenchidos
        If id_produto.Text.Trim() = "" Or nome_produto.Text.Trim() = "" Or nome_fornecedor.Text.Trim() = "" Or validade_produto.Text.Trim() = "" Then
            MessageBox.Show("Todos os campos devem estar preenchidos.", "Erro de Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Abrir conexão com o banco de dados
        Dim connection As OleDbConnection = conectar_banco()

        Try
            connection.Open()

            ' Excluir o registro da tabela
            Dim comandoExcluir As New OleDbCommand("DELETE FROM tb_produtos WHERE id_produto = @ID AND NOME_CERVEJA = @NomeProduto AND CERVEJARIA = @Fornecedor AND VALIDADE = @Validade", connection)
            comandoExcluir.Parameters.AddWithValue("@ID", id_produto.Text)
            comandoExcluir.Parameters.AddWithValue("@NomeProduto", nome_produto.Text)
            comandoExcluir.Parameters.AddWithValue("@Fornecedor", nome_fornecedor.Text)
            comandoExcluir.Parameters.AddWithValue("@Validade", validade_produto.Text)

            Dim rowsAffected As Integer = comandoExcluir.ExecuteNonQuery()
            If rowsAffected > 0 Then
                MessageBox.Show("Dados excluídos com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' Limpar os campos após a exclusão
                id_produto.Text = ""
                nome_produto.Text = ""
                nome_fornecedor.Text = ""
                validade_produto.Text = ""
            Else
                MessageBox.Show("Nenhum registro encontrado para excluir.", "Erro de Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Erro ao conectar ao banco de dados: " & ex.Message, "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub botao_atualizar_Click(sender As Object, e As EventArgs) Handles botao_atualizar.Click
        ' Verificar se os campos obrigatórios estão preenchidos
        If id_produto.Text.Trim() = "" Or nome_produto.Text.Trim() = "" Or nome_fornecedor.Text.Trim() = "" Or validade_produto.Text.Trim() = "" Then
            MessageBox.Show("Todos os campos devem estar preenchidos.", "Erro de Atualização", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Abrir conexão com o banco de dados
        Dim connection As OleDbConnection = conectar_banco()

        Try
            connection.Open()

            ' Verificar se o produto já existe na tabela
            Dim comandoVerificar As New OleDbCommand("SELECT COUNT(*) FROM tb_produtos WHERE id_produto = @ID", connection)
            comandoVerificar.Parameters.AddWithValue("@ID", id_produto.Text)

            Dim count As Integer = Convert.ToInt32(comandoVerificar.ExecuteScalar())
            If count = 0 Then
                MessageBox.Show("ID de produto não encontrado na tabela.", "Erro de Atualização", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return ' Sai do método sem fazer mais nada
            End If

            ' Verificar se alguma informação foi alterada
            Dim comandoConsultar As New OleDbCommand("SELECT NOME_CERVEJA, CERVEJARIA, VALIDADE FROM tb_produtos WHERE id_produto = @ID", connection)
            comandoConsultar.Parameters.AddWithValue("@ID", id_produto.Text)

            Dim reader As OleDbDataReader = comandoConsultar.ExecuteReader()
            If reader.Read() Then
                Dim nomeProdutoDB As String = reader("NOME_CERVEJA").ToString()
                Dim fornecedorDB As String = reader("CERVEJARIA").ToString()
                Dim validadeDB As String = reader("VALIDADE").ToString()

                If nome_produto.Text = nomeProdutoDB AndAlso nome_fornecedor.Text = fornecedorDB AndAlso validade_produto.Text = validadeDB Then
                    MessageBox.Show("Nenhum dado foi alterado.", "Sem Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return ' Sai do método sem fazer mais nada
                End If
            End If

            ' Atualizar o produto na tabela
            Dim comandoAtualizar As New OleDbCommand("UPDATE tb_produtos SET NOME_CERVEJA = @NomeProduto, CERVEJARIA = @Fornecedor, VALIDADE = @Validade WHERE id_produto = @ID", connection)
            comandoAtualizar.Parameters.AddWithValue("@NomeProduto", nome_produto.Text)
            comandoAtualizar.Parameters.AddWithValue("@Fornecedor", nome_fornecedor.Text)
            comandoAtualizar.Parameters.AddWithValue("@Validade", validade_produto.Text)
            comandoAtualizar.Parameters.AddWithValue("@ID", id_produto.Text)

            Dim rowsAffected As Integer = comandoAtualizar.ExecuteNonQuery()
            If rowsAffected > 0 Then
                MessageBox.Show("Produto atualizado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Erro ao atualizar o produto.", "Erro de Atualização", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Erro ao conectar ao banco de dados: " & ex.Message, "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        ' Exibir o Form1 e fechar o formulário atual
        Dim form6 As New Form6()
        form6.Show()
        Me.Close()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub id_produto_TextChanged(sender As Object, e As EventArgs) Handles id_produto.TextChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        ' Verificar se os campos obrigatórios estão preenchidos
        If nome_produto.Text.Trim() = "" Or nome_fornecedor.Text.Trim() = "" Or validade_produto.Text.Trim() = "" Then
            MessageBox.Show("Todos os campos devem estar preenchidos.", "Erro de Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Abrir conexão com o banco de dados
        Dim connection As OleDbConnection = conectar_banco()

        Try
            connection.Open()

            ' Verificar se o produto já está cadastrado na tabela
            Dim comandoVerificar As New OleDbCommand("SELECT COUNT(*) FROM tb_produtos WHERE CERVEJARIA = @Fornecedor AND NOME_CERVEJA = @Produto", connection)
            comandoVerificar.Parameters.AddWithValue("@Fornecedor", nome_fornecedor.Text)
            comandoVerificar.Parameters.AddWithValue("@Produto", nome_produto.Text)

            Dim count As Integer = Convert.ToInt32(comandoVerificar.ExecuteScalar())
            If count > 0 Then
                MessageBox.Show("Este produto já foi cadastrado.", "Erro de Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return ' Sai do método sem fazer mais nada
            End If

            ' Verificar o próximo id_produto disponível
            Dim comandoNextID As New OleDbCommand("SELECT MAX(id_produto) + 1 FROM tb_produtos", connection)
            Dim nextID As Object = comandoNextID.ExecuteScalar()
            Dim newID As Integer = If(nextID IsNot DBNull.Value, Convert.ToInt32(nextID), 1)

            ' Inserir o novo produto na tabela
            Dim comandoInserir As New OleDbCommand("INSERT INTO tb_produtos (id_produto, CERVEJARIA, NOME_CERVEJA, VALIDADE) VALUES (@ID, @Fornecedor, @Produto, @Validade)", connection)
            comandoInserir.Parameters.AddWithValue("@ID", newID)
            comandoInserir.Parameters.AddWithValue("@Fornecedor", nome_fornecedor.Text)
            comandoInserir.Parameters.AddWithValue("@Produto", nome_produto.Text)
            comandoInserir.Parameters.AddWithValue("@Validade", validade_produto.Text)

            Dim rowsAffected As Integer = comandoInserir.ExecuteNonQuery()
            If rowsAffected > 0 Then
                MessageBox.Show("Produto cadastrado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Erro ao cadastrar o produto.", "Erro de Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Erro ao conectar ao banco de dados: " & ex.Message, "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        ' Verificar se os campos obrigatórios estão preenchidos
        If id_produto.Text.Trim() = "" Or nome_produto.Text.Trim() = "" Or nome_fornecedor.Text.Trim() = "" Or validade_produto.Text.Trim() = "" Then
            MessageBox.Show("Todos os campos devem estar preenchidos.", "Erro de Atualização", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Abrir conexão com o banco de dados
        Dim connection As OleDbConnection = conectar_banco()

        Try
            connection.Open()

            ' Verificar se o produto já existe na tabela
            Dim comandoVerificar As New OleDbCommand("SELECT COUNT(*) FROM tb_produtos WHERE id_produto = @ID", connection)
            comandoVerificar.Parameters.AddWithValue("@ID", id_produto.Text)

            Dim count As Integer = Convert.ToInt32(comandoVerificar.ExecuteScalar())
            If count = 0 Then
                MessageBox.Show("ID de produto não encontrado na tabela.", "Erro de Atualização", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return ' Sai do método sem fazer mais nada
            End If

            ' Verificar se alguma informação foi alterada
            Dim comandoConsultar As New OleDbCommand("SELECT NOME_CERVEJA, CERVEJARIA, VALIDADE FROM tb_produtos WHERE id_produto = @ID", connection)
            comandoConsultar.Parameters.AddWithValue("@ID", id_produto.Text)

            Dim reader As OleDbDataReader = comandoConsultar.ExecuteReader()
            If reader.Read() Then
                Dim nomeProdutoDB As String = reader("NOME_CERVEJA").ToString()
                Dim fornecedorDB As String = reader("CERVEJARIA").ToString()
                Dim validadeDB As String = reader("VALIDADE").ToString()

                If nome_produto.Text = nomeProdutoDB AndAlso nome_fornecedor.Text = fornecedorDB AndAlso validade_produto.Text = validadeDB Then
                    MessageBox.Show("Nenhum dado foi alterado.", "Sem Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return ' Sai do método sem fazer mais nada
                End If
            End If

            ' Atualizar o produto na tabela
            Dim comandoAtualizar As New OleDbCommand("UPDATE tb_produtos SET NOME_CERVEJA = @NomeProduto, CERVEJARIA = @Fornecedor, VALIDADE = @Validade WHERE id_produto = @ID", connection)
            comandoAtualizar.Parameters.AddWithValue("@NomeProduto", nome_produto.Text)
            comandoAtualizar.Parameters.AddWithValue("@Fornecedor", nome_fornecedor.Text)
            comandoAtualizar.Parameters.AddWithValue("@Validade", validade_produto.Text)
            comandoAtualizar.Parameters.AddWithValue("@ID", id_produto.Text)

            Dim rowsAffected As Integer = comandoAtualizar.ExecuteNonQuery()
            If rowsAffected > 0 Then
                MessageBox.Show("Produto atualizado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Erro ao atualizar o produto.", "Erro de Atualização", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Erro ao conectar ao banco de dados: " & ex.Message, "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        ' Verificar se os campos obrigatórios estão preenchidos
        If id_produto.Text.Trim() = "" Or nome_produto.Text.Trim() = "" Or nome_fornecedor.Text.Trim() = "" Or validade_produto.Text.Trim() = "" Then
            MessageBox.Show("Todos os campos devem estar preenchidos.", "Erro de Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Abrir conexão com o banco de dados
        Dim connection As OleDbConnection = conectar_banco()

        Try
            connection.Open()

            ' Excluir o registro da tabela
            Dim comandoExcluir As New OleDbCommand("DELETE FROM tb_produtos WHERE id_produto = @ID AND NOME_CERVEJA = @NomeProduto AND CERVEJARIA = @Fornecedor AND VALIDADE = @Validade", connection)
            comandoExcluir.Parameters.AddWithValue("@ID", id_produto.Text)
            comandoExcluir.Parameters.AddWithValue("@NomeProduto", nome_produto.Text)
            comandoExcluir.Parameters.AddWithValue("@Fornecedor", nome_fornecedor.Text)
            comandoExcluir.Parameters.AddWithValue("@Validade", validade_produto.Text)

            Dim rowsAffected As Integer = comandoExcluir.ExecuteNonQuery()
            If rowsAffected > 0 Then
                MessageBox.Show("Dados excluídos com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' Limpar os campos após a exclusão
                id_produto.Text = ""
                nome_produto.Text = ""
                nome_fornecedor.Text = ""
                validade_produto.Text = ""
            Else
                MessageBox.Show("Nenhum registro encontrado para excluir.", "Erro de Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Erro ao conectar ao banco de dados: " & ex.Message, "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Close()
        End Try
    End Sub
End Class