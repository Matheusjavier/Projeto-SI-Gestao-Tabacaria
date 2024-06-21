Imports System.Data.OleDb
Imports ADODB

Public Class Form22

    Public db As New Connection
    Public rs As New Recordset
    Public caminho_banco As String = Application.StartupPath & "\banco\cadastro.mdb"

    Private Sub Form18_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
    End Sub

    Private Sub conectar_banco()
        Try
            If Not System.IO.File.Exists(caminho_banco) Then
                Throw New Exception("O arquivo de banco de dados não foi encontrado: " & caminho_banco)
            End If

            db = New ADODB.Connection
            db.Open("Provider=Microsoft.JET.OLEDB.4.0;Data Source=" & caminho_banco)

            If db.State = 1 Then
                MsgBox("Conexão bem sucedida!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            Else
                Throw New Exception("Falha ao abrir a conexão com o banco de dados.")
            End If

        Catch ex As Exception
            MsgBox("Erro ao conectar: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Form22 As New Form20()
        Form20.Show()
        Me.Visible = False
        Form20.Visible = True
    End Sub

    Private Sub txt_id_TextChanged(sender As Object, e As EventArgs) Handles txt_id.TextChanged
        SQL = "SELECT * FROM tb_estoque WHERE Código='" & txt_id.Text & "'"
        rs = db.Execute(SQL)
        If Not rs.EOF Then
            txt_prod.Text = rs.Fields(1).Value.ToString()
            txt_sabor.Text = rs.Fields(2).Value.ToString()
            txt_qtd.Text = rs.Fields(3).Value.ToString()

            ' Definir o valor do DateTimePicker1 para a data atual
            DateTimePicker1.Value = DateTime.Now
        End If
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Verificar se o txt_id está preenchido
        If txt_id.Text <> "" Then
            ' Verificar se o DateTimePicker1 tem uma data selecionada
            If DateTimePicker1.Value <> DateTime.MinValue Then
                ' Verificar se o txt_qtd contém um valor numérico válido
                Dim quantidade As Integer
                If Integer.TryParse(txt_qtd.Text, quantidade) Then
                    ' Verificar se a quantidade é maior que zero antes de diminuir
                    If quantidade > 0 Then
                        Try
                            ' Atualizar a tabela tb_estoque diminuindo a quantidade em 1
                            SQL = "UPDATE tb_estoque SET dataSaida = ?, Quantidade = Quantidade - 1 WHERE Código = ?"

                            ' Obter a data do DateTimePicker1 no formato desejado (dia/mês/ano)
                            Dim dataSaida As String = DateTimePicker1.Value.ToString("dd/MM/yyyy")

                            ' Criar um comando e adicionar os parâmetros
                            Dim cmd As New ADODB.Command
                            cmd.ActiveConnection = db
                            cmd.CommandText = SQL
                            cmd.CommandType = ADODB.CommandTypeEnum.adCmdText
                            cmd.Parameters.Append(cmd.CreateParameter("param1", ADODB.DataTypeEnum.adVarChar, ADODB.ParameterDirectionEnum.adParamInput, 10, dataSaida))
                            cmd.Parameters.Append(cmd.CreateParameter("param2", ADODB.DataTypeEnum.adVarChar, ADODB.ParameterDirectionEnum.adParamInput, 50, txt_id.Text))

                            ' Executar o comando
                            cmd.Execute()

                            ' Atualizar o txt_qtd localmente após a atualização no banco de dados
                            txt_qtd.Text = (quantidade - 1).ToString()

                            MsgBox("Quantidade atualizada com sucesso.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

                        Catch ex As Exception
                            MsgBox("Erro ao atualizar quantidade: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
                        End Try
                    Else
                        MsgBox("A quantidade disponível é zero ou negativa.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    End If
                Else
                    MsgBox("O campo Quantidade deve conter um valor numérico válido.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                End If
            Else
                MsgBox("Selecione uma data no DateTimePicker1.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            End If
        Else
            MsgBox("Preencha o campo ID antes de atualizar a quantidade.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End If
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub
End Class
