Public Class Form19
    Private Sub btn_gestoque_Click(sender As Object, e As EventArgs) Handles btn_gestoque.Click
        Dim Form4 As New Form20()
        Form20.Show()
        Me.Visible = False
        Form20.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Form19 As New Form2()
        Form2.Show()
        Me.Visible = False
        Form2.Visible = True
    End Sub
End Class