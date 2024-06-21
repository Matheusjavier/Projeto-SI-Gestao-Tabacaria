Public Class Form4
    Private Sub btn_gerenciar_Click(sender As Object, e As EventArgs) Handles btn_gerenciar.Click
        Dim Form4 As New Form3()
        Form3.Show()
        Me.Visible = False
        Form3.Visible = True
    End Sub

    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        Dim Form4 As New Form3()
        Form1.Show()
        Me.Visible = False
        Form1.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Form4 As New Form2()
        Form2.Show()
        Me.Visible = False
        Form2.Visible = True
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btn_gestoque_Click(sender As Object, e As EventArgs) Handles btn_gestoque.Click
        Dim Form4 As New Form16()
        Form16.Show()
        Me.Visible = False
        Form2.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Form4 As New Form14()
        Form14.Show()
        Me.Visible = False
        Form2.Visible = False
        Form14.Visible = True
    End Sub
End Class