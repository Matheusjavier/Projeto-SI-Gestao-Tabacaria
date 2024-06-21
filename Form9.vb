Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class Form9
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub botao_gravar_Click(sender As Object, e As EventArgs) Handles botao_gravar.Click
        ' Verificar se os campos estão preenchidos
        If nome_funcionario.Text.Trim() = "" Or cpf_funcionario.Text.Trim() = "" Or email_funcionario.Text.Trim() = "" Or senha_funcionario.Text.Trim() = "" Or cargo.Text.Trim() = "" Then
            MessageBox.Show("Por favor, preencha todos os campos.")
            Return
        End If

        ' Verificar se o cargo é válido
        If cargo.Text.Trim().ToLower() <> "gerente" AndAlso cargo.Text.Trim().ToLower() <> "funcionário" Then
            MessageBox.Show("Por favor, selecione um cargo válido (Gerente ou Funcionário).")
            Return
        End If

        ' Abrir conexão com o banco de dados
        Dim connection As OleDbConnection = conectar_banco()

        Try
            connection.Open()

            ' Verificar se o funcionário já existe na tabela
            Dim comando As New OleDbCommand("SELECT COUNT(*) FROM tb_funcionarios WHERE CPF = @CPF", connection)
            comando.Parameters.AddWithValue("@CPF", cpf_funcionario.Text)

            Dim count As Integer = Convert.ToInt32(comando.ExecuteScalar())

            If count > 0 Then
                MessageBox.Show("Já existe um funcionário cadastrado com este CPF.")
            Else
                ' Gravar os dados na tabela
                Dim comandoInserir As New OleDbCommand("INSERT INTO tb_funcionarios (NOME, CPF, EMAIL, SENHA, CARGO) VALUES (@Nome, @CPF, @Email, @Senha, @Cargo)", connection)
                comandoInserir.Parameters.AddWithValue("@Nome", nome_funcionario.Text)
                comandoInserir.Parameters.AddWithValue("@CPF", cpf_funcionario.Text)
                comandoInserir.Parameters.AddWithValue("@Email", email_funcionario.Text)
                comandoInserir.Parameters.AddWithValue("@Senha", senha_funcionario.Text)
                comandoInserir.Parameters.AddWithValue("@Cargo", cargo.Text)

                Dim rowsAffected As Integer = comandoInserir.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("Funcionário cadastrado com sucesso.")
                Else
                    MessageBox.Show("Erro ao cadastrar o funcionário.")
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Erro ao conectar ao banco de dados: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub





    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        ' Verificar se os campos estão preenchidos
        If nome_funcionario.Text.Trim() = "" Or cpf_funcionario.Text.Trim() = "" Or email_funcionario.Text.Trim() = "" Or senha_funcionario.Text.Trim() = "" Or cargo.Text.Trim() = "" Then
            MessageBox.Show("Por favor, preencha todos os campos.")
            Return
        End If

        ' Verificar se o cargo é válido
        If cargo.Text.Trim().ToLower() <> "gerente" AndAlso cargo.Text.Trim().ToLower() <> "funcionário" Then
            MessageBox.Show("Por favor, selecione um cargo válido (Gerente ou Funcionário).")
            Return
        End If

        ' Abrir conexão com o banco de dados
        Dim connection As OleDbConnection = conectar_banco()

        Try
            connection.Open()

            ' Verificar se o funcionário já existe na tabela
            Dim comando As New OleDbCommand("SELECT COUNT(*) FROM tb_funcionarios WHERE CPF = @CPF", connection)
            comando.Parameters.AddWithValue("@CPF", cpf_funcionario.Text)

            Dim count As Integer = Convert.ToInt32(comando.ExecuteScalar())

            If count > 0 Then
                MessageBox.Show("Já existe um funcionário cadastrado com este CPF.")
            Else
                ' Gravar os dados na tabela
                Dim comandoInserir As New OleDbCommand("INSERT INTO tb_funcionarios (NOME, CPF, EMAIL, SENHA, CARGO) VALUES (@Nome, @CPF, @Email, @Senha, @Cargo)", connection)
                comandoInserir.Parameters.AddWithValue("@Nome", nome_funcionario.Text)
                comandoInserir.Parameters.AddWithValue("@CPF", cpf_funcionario.Text)
                comandoInserir.Parameters.AddWithValue("@Email", email_funcionario.Text)
                comandoInserir.Parameters.AddWithValue("@Senha", senha_funcionario.Text)
                comandoInserir.Parameters.AddWithValue("@Cargo", cargo.Text)

                Dim rowsAffected As Integer = comandoInserir.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("Funcionário cadastrado com sucesso.")
                Else
                    MessageBox.Show("Erro ao cadastrar o funcionário.")
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Erro ao conectar ao banco de dados: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub




    Private Sub cpf_funcionario_Leave(sender As Object, e As EventArgs) Handles cpf_funcionario.Leave
        ' Remover espaços em branco e caracteres não numéricos do CPF
        Dim cpf As String = cpf_funcionario.Text.Replace(" ", "").Replace(".", "").Replace("-", "")

        ' Verificar se o CPF está preenchido
        If cpf.Trim() = "" Then
            MessageBox.Show("Por favor, insira o CPF do funcionário.")
            Return
        End If

        ' Se o CPF contiver apenas números, adicionar pontos e traços ao CPF formatado
        If IsNumeric(cpf) Then
            cpf = Convert.ToUInt64(cpf).ToString("000\.000\.000\-00")
        End If

        ' Abrir conexão com o banco de dados
        Dim connection As OleDbConnection = conectar_banco()

        Try
            connection.Open()

            ' Verificar se o funcionário existe na tabela
            Dim comando As New OleDbCommand("SELECT * FROM tb_funcionarios WHERE CPF = @CPF", connection)
            comando.Parameters.AddWithValue("@CPF", cpf)

            Dim reader As OleDbDataReader = comando.ExecuteReader()

            If reader.Read() Then
                ' Funcionário encontrado, preencher os campos automaticamente
                nome_funcionario.Text = reader("NOME").ToString()
                email_funcionario.Text = reader("EMAIL").ToString()
                senha_funcionario.Text = reader("SENHA").ToString()
                cargo.Text = reader("CARGO").ToString()

                MessageBox.Show("Funcionário encontrado. Os dados foram preenchidos automaticamente.")
            Else
                MessageBox.Show("Funcionário não encontrado na tabela.")
            End If

        Catch ex As Exception
            MessageBox.Show("Erro ao conectar ao banco de dados: " & ex.Message)
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

    Private Sub botao_excluir_Click(sender As Object, e As EventArgs) Handles botao_excluir.Click
        ' Verificar se todos os campos estão preenchidos
        If Not TodosCamposPreenchidos() Then
            MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Conectar ao banco de dados
        Dim conexao As OleDbConnection = conectar_banco()

        Try
            ' Abrir a conexão
            conexao.Open()

            ' Consulta SQL para verificar se o funcionário com os dados fornecidos existe
            Dim consultaExistencia As String = "SELECT COUNT(*) FROM tb_funcionarios WHERE CPF = ? AND NOME = ? AND EMAIL = ? AND SENHA = ? AND CARGO = ?"
            Dim comandoExistencia As New OleDbCommand(consultaExistencia, conexao)
            comandoExistencia.Parameters.AddWithValue("@CPF", cpf_funcionario.Text)
            comandoExistencia.Parameters.AddWithValue("@NOME", nome_funcionario.Text)
            comandoExistencia.Parameters.AddWithValue("@EMAIL", email_funcionario.Text)
            comandoExistencia.Parameters.AddWithValue("@SENHA", senha_funcionario.Text)
            comandoExistencia.Parameters.AddWithValue("@CARGO", cargo.Text)
            Dim quantidadeFuncionarios As Integer = Convert.ToInt32(comandoExistencia.ExecuteScalar())

            If quantidadeFuncionarios = 0 Then
                MessageBox.Show("Não existe um funcionário com os dados fornecidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Consulta SQL para excluir o funcionário com os dados fornecidos
            Dim consultaExclusao As String = "DELETE FROM tb_funcionarios WHERE CPF = ? AND NOME = ? AND EMAIL = ? AND SENHA = ? AND CARGO = ?"
            Dim comandoExclusao As New OleDbCommand(consultaExclusao, conexao)
            comandoExclusao.Parameters.AddWithValue("@CPF", cpf_funcionario.Text)
            comandoExclusao.Parameters.AddWithValue("@NOME", nome_funcionario.Text)
            comandoExclusao.Parameters.AddWithValue("@EMAIL", email_funcionario.Text)
            comandoExclusao.Parameters.AddWithValue("@SENHA", senha_funcionario.Text)
            comandoExclusao.Parameters.AddWithValue("@CARGO", cargo.Text)

            ' Executar a exclusão
            Dim linhasAfetadas As Integer = comandoExclusao.ExecuteNonQuery()

            If linhasAfetadas > 0 Then
                MessageBox.Show("Funcionário excluído com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Nenhum funcionário foi excluído.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Erro ao excluir o funcionário: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Fechar a conexão
            conexao.Close()
        End Try
    End Sub

    Private Function TodosCamposPreenchidos() As Boolean
        ' Verificar se todos os campos estão preenchidos
        Return Not String.IsNullOrEmpty(cpf_funcionario.Text) AndAlso
           Not String.IsNullOrEmpty(nome_funcionario.Text) AndAlso
           Not String.IsNullOrEmpty(email_funcionario.Text) AndAlso
           Not String.IsNullOrEmpty(senha_funcionario.Text) AndAlso
           Not String.IsNullOrEmpty(cargo.Text)
    End Function


    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        ' Verificar se todos os campos estão preenchidos
        If Not TodosCamposPreenchidos() Then
            MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Conectar ao banco de dados
        Dim conexao As OleDbConnection = conectar_banco()

        Try
            ' Abrir a conexão
            conexao.Open()

            ' Consulta SQL para verificar se o funcionário com os dados fornecidos existe
            Dim consultaExistencia As String = "SELECT COUNT(*) FROM tb_funcionarios WHERE CPF = ? AND NOME = ? AND EMAIL = ? AND SENHA = ? AND CARGO = ?"
            Dim comandoExistencia As New OleDbCommand(consultaExistencia, conexao)
            comandoExistencia.Parameters.AddWithValue("@CPF", cpf_funcionario.Text)
            comandoExistencia.Parameters.AddWithValue("@NOME", nome_funcionario.Text)
            comandoExistencia.Parameters.AddWithValue("@EMAIL", email_funcionario.Text)
            comandoExistencia.Parameters.AddWithValue("@SENHA", senha_funcionario.Text)
            comandoExistencia.Parameters.AddWithValue("@CARGO", cargo.Text)
            Dim quantidadeFuncionarios As Integer = Convert.ToInt32(comandoExistencia.ExecuteScalar())

            If quantidadeFuncionarios = 0 Then
                MessageBox.Show("Não existe um funcionário com os dados fornecidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Consulta SQL para excluir o funcionário com os dados fornecidos
            Dim consultaExclusao As String = "DELETE FROM tb_funcionarios WHERE CPF = ? AND NOME = ? AND EMAIL = ? AND SENHA = ? AND CARGO = ?"
            Dim comandoExclusao As New OleDbCommand(consultaExclusao, conexao)
            comandoExclusao.Parameters.AddWithValue("@CPF", cpf_funcionario.Text)
            comandoExclusao.Parameters.AddWithValue("@NOME", nome_funcionario.Text)
            comandoExclusao.Parameters.AddWithValue("@EMAIL", email_funcionario.Text)
            comandoExclusao.Parameters.AddWithValue("@SENHA", senha_funcionario.Text)
            comandoExclusao.Parameters.AddWithValue("@CARGO", cargo.Text)

            ' Executar a exclusão
            Dim linhasAfetadas As Integer = comandoExclusao.ExecuteNonQuery()

            If linhasAfetadas > 0 Then
                MessageBox.Show("Funcionário excluído com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Nenhum funcionário foi excluído.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Erro ao excluir o funcionário: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Fechar a conexão
            conexao.Close()
        End Try
    End Sub

End Class

