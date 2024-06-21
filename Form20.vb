Public Class Form20
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_gerenciar.Click
        Dim Form20 As New Form21()
        Form21.Show()
        Me.Visible = False
        Form21.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_controle.Click
        Dim Form20 As New Form22()
        Form22.Show()
        Me.Visible = False
        Form22.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Form20 As New Form19()
        Form19.Show()
        Me.Visible = False
        Form19.Visible = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form16_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class