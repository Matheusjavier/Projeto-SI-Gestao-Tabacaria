Public Class Form14
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form14_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        carregar_dados_estoque()
    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click

    End Sub
    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub cmb_tipo_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub dgv_gestoque_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_gestoque.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Form14 As New Form4()
        Form4.Show()
        Me.Visible = False
        Form4.Visible = True
    End Sub

    Private Sub txt_buscar_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar.TextChanged
        Try
            SQL = "select * from tb_estoque where " & cmb_tipo.Text & " Like '" & txt_buscar.Text & "%'ORDER by Código ASC"
            rs = db.Execute(SQL)
            With dgv_gestoque
                .Rows.Clear()
                Do While rs.EOF = False 'Enquanto existir registro no banco
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(5).Value, rs.Fields(6).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, Nothing, Nothing)
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