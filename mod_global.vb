Module mod_global
    Public diretorio, SQL, aux_cpf, resp As String
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public caminho_banco = Application.StartupPath & "\banco\cadastro.mdb"
    Public cont As Integer

    Sub conectar_banco()
        'String de Conexão ADO Banco de Dados Access
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=Microsoft.JET.OLEDB.4.0;Data Source=" & caminho_banco)
        Catch ex As Exception
            MsgBox("Erro ao conectar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Sub limpar_cadastro()
        Try
            With Form1
                .txt_cpf.Clear()
                .txt_nome.Clear()
                .cmb_data_nasc.Value = Now
                .txt_fone.Clear()
                .txt_email.Clear()
                .img_foto.Load(Application.StartupPath & "\Fotos\nova_foto.png")
                .txt_cpf.Focus()
            End With
        Catch ex As Exception
            MsgBox("Erro ao processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Sub carregar_dados()
        Try
            SQL = "select * from tb_cadastro order by nome asc"
            rs = db.Execute(SQL)
            cont = 1
            With Form3.dgv_dados
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

    Sub carregar_dados_estoque()
        Try
            SQL = "SELECT * FROM tb_estoque ORDER BY Código ASC"
            rs = db.Execute(SQL)
            With Form14.dgv_gestoque
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

    Sub carregar_tipo()
        Try
            With Form3.cmb_tipo.Items
                .Add("CPF")
                .Add("Nome")
            End With
            Form3.cmb_tipo.SelectedIndex = 1 '0 vai aparecer CPF JA 1 vai aparecer o nome
        Catch ex As Exception
            MsgBox("Erro ao carregar o tipo do campo", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")

        End Try
    End Sub




End Module
