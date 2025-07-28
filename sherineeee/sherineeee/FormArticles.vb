Imports MySql.Data.MySqlClient
Public Class FormArticles
    Private connectionString As String = "Server=localhost;Database=gestion_stock;Uid=root;Pwd=;"
    Private currentArticleId As Integer = -1

    Private Sub FormArticles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadArticles()
    End Sub

    Private Sub LoadArticles()
        Using connection As New MySqlConnection(connectionString)
            Dim query As String = "SELECT id, nom_article, categorie, quantite_disponible FROM Articles"
            Dim adapter As New MySqlDataAdapter(query, connection)
            Dim table As New DataTable()
            adapter.Fill(table)
            dgvArticles.DataSource = table
        End Using
    End Sub

    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click
        If String.IsNullOrEmpty(txtNom.Text) Or String.IsNullOrEmpty(txtCategorie.Text) Then
            MessageBox.Show("Veuillez remplir tous les champs")
            Return
        End If

        Using connection As New MySqlConnection(connectionString)
            Dim query As String = "INSERT INTO Articles (nom_article, categorie, quantite_disponible) VALUES (@nom, @categorie, @quantite)"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@nom", txtNom.Text)
            command.Parameters.AddWithValue("@categorie", txtCategorie.Text)
            command.Parameters.AddWithValue("@quantite", numQuantite.Value)

            Try
                connection.Open()
                command.ExecuteNonQuery()
                ClearFields()
                LoadArticles()
            Catch ex As Exception
                MessageBox.Show("Erreur: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnModifier_Click(sender As Object, e As EventArgs) Handles btnModifier.Click
        If currentArticleId = -1 Then
            MessageBox.Show("Veuillez sélectionner un article à modifier")
            Return
        End If

        Using connection As New MySqlConnection(connectionString)
            Dim query As String = "UPDATE Articles SET nom_article=@nom, categorie=@categorie, quantite_disponible=@quantite WHERE id=@id"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@nom", txtNom.Text)
            command.Parameters.AddWithValue("@categorie", txtCategorie.Text)
            command.Parameters.AddWithValue("@quantite", numQuantite.Value)
            command.Parameters.AddWithValue("@id", currentArticleId)

            Try
                connection.Open()
                command.ExecuteNonQuery()
                ClearFields()
                LoadArticles()
                currentArticleId = -1
            Catch ex As Exception
                MessageBox.Show("Erreur: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnSupprimer_Click(sender As Object, e As EventArgs) Handles btnSupprimer.Click
        If currentArticleId = -1 Then
            MessageBox.Show("Veuillez sélectionner un article à supprimer")
            Return
        End If

        If MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet article et toutes ses entrées/sorties?",
                     "Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes Then

            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim transaction As MySqlTransaction = connection.BeginTransaction()

                Try
                    ' First delete related entries
                    Dim deleteEntrees As String = "DELETE FROM Entrees WHERE article_id = @id"
                    Dim deleteSorties As String = "DELETE FROM Sorties WHERE article_id = @id"
                    Dim deleteArticle As String = "DELETE FROM Articles WHERE id = @id"

                    ' Delete from Entrees
                    Dim cmdEntrees As New MySqlCommand(deleteEntrees, connection, transaction)
                    cmdEntrees.Parameters.AddWithValue("@id", currentArticleId)
                    cmdEntrees.ExecuteNonQuery()

                    ' Delete from Sorties
                    Dim cmdSorties As New MySqlCommand(deleteSorties, connection, transaction)
                    cmdSorties.Parameters.AddWithValue("@id", currentArticleId)
                    cmdSorties.ExecuteNonQuery()

                    ' Finally delete the article
                    Dim cmdArticle As New MySqlCommand(deleteArticle, connection, transaction)
                    cmdArticle.Parameters.AddWithValue("@id", currentArticleId)
                    cmdArticle.ExecuteNonQuery()

                    transaction.Commit()
                    MessageBox.Show("Article supprimé avec succès!")
                    ClearFields()
                    LoadArticles()
                    currentArticleId = -1
                Catch ex As Exception
                    transaction.Rollback()
                    MessageBox.Show("Erreur lors de la suppression: " & ex.Message)
                End Try
            End Using
        End If
    End Sub

    Private Sub dgvArticles_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvArticles.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvArticles.Rows(e.RowIndex)
            currentArticleId = Convert.ToInt32(row.Cells("id").Value)
            txtNom.Text = row.Cells("nom_article").Value.ToString()
            txtCategorie.Text = row.Cells("categorie").Value.ToString()
            numQuantite.Value = Convert.ToDecimal(row.Cells("quantite_disponible").Value)
        End If
    End Sub

    Private Sub ClearFields()
        txtNom.Text = ""
        txtCategorie.Text = ""
        numQuantite.Value = 0
    End Sub

    Private Sub txtNom_TextChanged(sender As Object, e As EventArgs) Handles txtNom.TextChanged

    End Sub

    Private Sub dgvArticles_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvArticles.CellContentClick

    End Sub
End Class