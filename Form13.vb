Public Class Form13
    Private Sub Form13_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Desativar o AutoGenerateColumns
        DataGridView1.AutoGenerateColumns = False

        ' Definir manualmente as colunas do DataGridView
        Dim colID As New DataGridViewTextBoxColumn()
        colID.DataPropertyName = "ID_PRODUTO" ' Correspondente ao nome da coluna na fonte de dados
        colID.HeaderText = "ID Produto" ' Título da coluna a ser exibido
        DataGridView1.Columns.Add(colID)

        Dim colNome As New DataGridViewTextBoxColumn()
        colNome.DataPropertyName = "NOME_CERVEJA" ' Correspondente ao nome da coluna na fonte de dados
        colNome.HeaderText = "Nome Cerveja" ' Título da coluna a ser exibido
        DataGridView1.Columns.Add(colNome)

        Dim colQuantidade As New DataGridViewTextBoxColumn()
        colQuantidade.DataPropertyName = "QUANTIDADE" ' Correspondente ao nome da coluna na fonte de dados
        colQuantidade.HeaderText = "Quantidade" ' Título da coluna a ser exibido
        DataGridView1.Columns.Add(colQuantidade)

        ' Configurar DataGridView para somente leitura
        DataGridView1.ReadOnly = True

        ' Carregar os produtos com quantidade baixa
        CarregarProdutosComQuantidadeBaixa(DataGridView1)
    End Sub

    Private Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        ' Exibir o Form1 e fechar o formulário atual
        Dim form6 As New Form6()
        form6.Show()
        Me.Close()
    End Sub
End Class
