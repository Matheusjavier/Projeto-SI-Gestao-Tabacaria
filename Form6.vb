Public Class Form6
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Dim form9 As New Form9()
        form9.Show()
        Me.Close() ' Fecha o Form6
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim form9 As New Form9()
        form9.Show()
        Me.Close() ' Fecha o Form6
    End Sub

    Private Sub botao_ger_func_Click(sender As Object, e As EventArgs) Handles botao_ger_func.Click
        Dim form9 As New Form9()
        form9.Show()
        Me.Close() ' Fecha o Form6
    End Sub



    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        ' Exibir o Form5
        Dim form5 As New Form5()
        form5.Show()

        ' Ocultar o formulário atual
        Me.Hide()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        ' Exibir o Form1 e fechar o formulário atual
        Dim form12 As New Form12()
        form12.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        ' Exibir o Form1 e fechar o formulário atual
        Dim form12 As New Form12()
        form12.Show()
        Me.Close()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        ' Exibir o Form1 e fechar o formulário atual
        Dim form12 As New Form12()
        form12.Show()
        Me.Close()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        ' Exibir o Form5
        Dim form5 As New Form5()
        form5.Show()

        ' Ocultar o formulário atual
        Me.Hide()
    End Sub


    Private Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        ' Exibir o Form1 e fechar o formulário atual
        Dim form1 As New Form1()
        form1.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim form7 As New Form7()
        form7.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        ' Exibir o Form1 e fechar o formulário atual
        Dim form13 As New Form13()
        form13.Show()
        Me.Close()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        ' Exibir o Form5
        Dim form5 As New Form5()
        form5.Show()

        ' Ocultar o formulário atual
        Me.Hide()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Dim form7 As New Form7()
        form7.Show()
        Me.Close()
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
        Dim form7 As New Form7()
        form7.Show()
        Me.Close()
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        ' Exibir o Form1 e fechar o formulário atual
        Dim form13 As New Form13()
        form13.Show()
        Me.Close()
    End Sub
End Class