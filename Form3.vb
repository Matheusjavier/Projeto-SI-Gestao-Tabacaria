Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        carregar_dados()
    End Sub

    Private Sub dgv_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados.CellContentClick
        Try
            With dgv_dados
                If .CurrentRow.Cells(4).Selected = True Then
                    aux_cpf = .CurrentRow.Cells(1).Value
                    SQL = "select * from tb_cadastro where cpf='" & aux_cpf & "'"
                    rs = db.Execute(SQL)
                    If rs.EOF = False Then
                        resp = MsgBox("Deseja realmente alterar o status de" + vbNewLine &
                                "CPF: " & aux_cpf & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "AVISO")
                        If resp = MsgBoxResult.Yes Then
                            If .CurrentRow.Cells(3).Value = "ATIVO" Then
                                SQL = "update tb_cadastro set status='" & "BLOQUEADO" & "' where cpf='" & aux_cpf & "'"
                                rs = db.Execute(SQL)
                                carregar_dados()
                            Else
                                SQL = "update tb_cadastro set status='" & "ATIVO" & "' where cpf='" & aux_cpf & "'"
                                rs = db.Execute(SQL)
                                carregar_dados()
                            End If
                        End If
                    End If
                ElseIf .CurrentRow.Cells(5).Selected = True Then
                    aux_cpf = .CurrentRow.Cells(1).Value
                    resp = MsgBox("Deseja realmente excluir o" + vbNewLine &
                                "CPF: " & aux_cpf & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "AVISO")
                    If resp = MsgBoxResult.Yes Then
                        SQL = "delete * from tb_cadastro where cpf='" & aux_cpf & "'"
                        rs = db.Execute(SQL)
                        carregar_dados()
                    End If
                Else
                    Exit Sub
                End If
            End With
        Catch ex As Exception
            MsgBox("Erro ao processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Form3 As New Form4()
        Form4.Show()
        Me.Visible = False
        Form4.Visible = True
    End Sub

    Private Sub cmb_tipo_Click(sender As Object, e As EventArgs) Handles cmb_tipo.Click

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub txt_buscar_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar.TextChanged
        Try
            SQL = "select * from tb_cadastro where " & cmb_tipo.Text & " Like '" & txt_buscar.Text & "%'order by nome asc" 'fazendo busca e % fechando contatenação
            rs = db.Execute(SQL)
            cont = 1
            With dgv_dados
                .Rows.Clear()
                Do While rs.EOF = False 'Enquanto existir registro no banco
                    .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(6).Value, Nothing, Nothing)
                    cont = cont + 1
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub txt_buscar_Click(sender As Object, e As EventArgs) Handles txt_buscar.Click

    End Sub
End Class