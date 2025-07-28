Public Class Form1
    Private Sub btnArticles_Click(sender As Object, e As EventArgs) Handles btnArticles.Click
        Dim formArticles As New FormArticles()
        formArticles.Show()
    End Sub

    Private Sub btnEntrees_Click(sender As Object, e As EventArgs) Handles btnEntrees.Click
        Dim formEntrees As New FormEntrees()
        formEntrees.Show()
    End Sub

    Private Sub btnSorties_Click(sender As Object, e As EventArgs) Handles btnSorties.Click
        Dim formSorties As New FormSorties()
        formSorties.Show()
    End Sub

    Private Sub btnEtatStock_Click(sender As Object, e As EventArgs) Handles btnEtatStock.Click
        Dim formEtatStock As New FormEtatStock()
        formEtatStock.Show()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
