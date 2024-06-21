Imports System.Data.OleDb

Public Class Form10
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
            Dim comandoConsultar As New OleDbCommand("SELECT NOME_CERVEJA, CERVEJARIA, VALIDADE, QUANTIDADE FROM tb_produtos WHERE ID_PRODUTO = ?", connection)
            comandoConsultar.Parameters.AddWithValue("@ID", id_produto.Text)

            Dim reader As OleDbDataReader = comandoConsultar.ExecuteReader()

            If reader.Read() Then
                ' Preencher os campos automaticamente
                nome_produto.Text = If(Not IsDBNull(reader("NOME_CERVEJA")), reader("NOME_CERVEJA").ToString(), "")
                nome_fornecedor.Text = If(Not IsDBNull(reader("CERVEJARIA")), reader("CERVEJARIA").ToString(), "")
                validade.Text = If(Not IsDBNull(reader("VALIDADE")), reader("VALIDADE").ToString(), "")
                qtde_barril.Text = If(Not IsDBNull(reader("QUANTIDADE")), reader("QUANTIDADE").ToString(), "")
            Else
                ' Limpar os campos se o produto não for encontrado
                nome_produto.Clear()
                nome_fornecedor.Clear()
                validade.Clear()
                qtde_barril.Clear()
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









    Private Sub botao_atualizar_Click(sender As Object, e As EventArgs) Handles botao_atualizar.Click
        ' Verificar se os campos obrigatórios estão preenchidos
        If id_produto.Text.Trim() = "" Or qtde_barril.Text.Trim() = "" Then
            MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Abrir conexão com o banco de dados
        Dim connection As OleDbConnection = conectar_banco()

        Try
            connection.Open()

            ' Consultar os dados na tabela tb_produtos
            Dim comandoConsultar As New OleDbCommand("SELECT VALIDADE FROM tb_produtos WHERE id_produto = @ID", connection)
            comandoConsultar.Parameters.AddWithValue("@ID", id_produto.Text)

            Dim reader As OleDbDataReader = comandoConsultar.ExecuteReader()

            If reader.Read() Then
                ' Preencher o campo validade com a data obtida do banco de dados
                validade.Text = reader("VALIDADE").ToString()

                ' Atualizar o campo QUANTIDADE na tabela tb_produtos
                Dim comandoAtualizarQuantidade As New OleDbCommand("UPDATE tb_produtos SET QUANTIDADE = @Quantidade WHERE id_produto = @ID", connection)
                comandoAtualizarQuantidade.Parameters.AddWithValue("@Quantidade", qtde_barril.Text)
                comandoAtualizarQuantidade.Parameters.AddWithValue("@ID", id_produto.Text)

                Dim rowsAffected As Integer = comandoAtualizarQuantidade.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Quantidade atualizada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Erro ao atualizar a quantidade.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Produto não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Erro ao conectar ao banco de dados: " & ex.Message, "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Close()
        End Try
    End Sub


    Private Sub botao_limpar_Click(sender As Object, e As EventArgs) Handles botao_limpar.Click
        nome_produto.Text = ""
        nome_fornecedor.Text = ""
        qtde_barril.Text = ""
        validade.Text = ""  ' Adicionamos esta linha para limpar o campo de validade
        id_produto.Text = ""
    End Sub

    Private Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        ' Exibir o Form1 e fechar o formulário atual
        Dim form7 As New Form7()
        form7.Show()
        Me.Close()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        nome_produto.Text = ""
        nome_fornecedor.Text = ""
        qtde_barril.Text = ""
        validade.Text = ""  ' Adicionamos esta linha para limpar o campo de validade
        id_produto.Text = ""
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        ' Verificar se os campos obrigatórios estão preenchidos
        If id_produto.Text.Trim() = "" Or qtde_barril.Text.Trim() = "" Then
            MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Abrir conexão com o banco de dados
        Dim connection As OleDbConnection = conectar_banco()

        Try
            connection.Open()

            ' Consultar os dados na tabela tb_produtos
            Dim comandoConsultar As New OleDbCommand("SELECT VALIDADE FROM tb_produtos WHERE id_produto = @ID", connection)
            comandoConsultar.Parameters.AddWithValue("@ID", id_produto.Text)

            Dim reader As OleDbDataReader = comandoConsultar.ExecuteReader()

            If reader.Read() Then
                ' Preencher o campo validade com a data obtida do banco de dados
                validade.Text = reader("VALIDADE").ToString()

                ' Atualizar o campo QUANTIDADE na tabela tb_produtos
                Dim comandoAtualizarQuantidade As New OleDbCommand("UPDATE tb_produtos SET QUANTIDADE = @Quantidade WHERE id_produto = @ID", connection)
                comandoAtualizarQuantidade.Parameters.AddWithValue("@Quantidade", qtde_barril.Text)
                comandoAtualizarQuantidade.Parameters.AddWithValue("@ID", id_produto.Text)

                Dim rowsAffected As Integer = comandoAtualizarQuantidade.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Quantidade atualizada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Erro ao atualizar a quantidade.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Produto não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Erro ao conectar ao banco de dados: " & ex.Message, "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class