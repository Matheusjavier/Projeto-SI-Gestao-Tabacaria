Public Class Form16
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_gerenciar.Click
        Dim Form4 As New Form17()
        Form17.Show()
        Me.Visible = False
        Form2.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_controle.Click
        Dim Form16 As New Form18()
        Form18.Show()
        Me.Visible = False
        Form18.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Form17 As New Form4()
        Form4.Show()
        Me.Visible = False
        Form4.Visible = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form16_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class