Imports MySql.Data.MySqlClient

Public Class FormEntrees
    Private connectionString As String = "Server=localhost;Database=gestion_stock;Uid=root;Pwd=;"

    Private Sub FormEntrees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadArticlesCombo()
        dtpDate.Value = DateTime.Now
    End Sub

    Private Sub LoadArticlesCombo()
        Using connection As New MySqlConnection(connectionString)
            Dim query As String = "SELECT id, nom_article FROM Articles ORDER BY nom_article"
            Dim command As New MySqlCommand(query, connection)

            Try
                connection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()

                cmbArticles.Items.Clear()
                While reader.Read()
                    cmbArticles.Items.Add(New KeyValuePair(Of Integer, String)(reader.GetInt32(0), reader.GetString(1)))
                End While

                If cmbArticles.Items.Count > 0 Then
                    cmbArticles.SelectedIndex = 0
                End If
            Catch ex As Exception
                MessageBox.Show("Erreur: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnEnregistrer_Click(sender As Object, e As EventArgs) Handles btnEnregistrer.Click
        If cmbArticles.SelectedItem Is Nothing Then
            MessageBox.Show("Veuillez sélectionner un article")
            Return
        End If

        Dim selectedArticle As KeyValuePair(Of Integer, String) = DirectCast(cmbArticles.SelectedItem, KeyValuePair(Of Integer, String))

        Using connection As New MySqlConnection(connectionString)
            connection.Open()
            Dim transaction As MySqlTransaction = connection.BeginTransaction()

            Try
                ' Add entry
                Dim queryEntry As String = "INSERT INTO Entrees (article_id, quantite, date_entree) VALUES (@article_id, @quantite, @date)"
                Dim commandEntry As New MySqlCommand(queryEntry, connection, transaction)
                commandEntry.Parameters.AddWithValue("@article_id", selectedArticle.Key)
                commandEntry.Parameters.AddWithValue("@quantite", numQuantite.Value)
                commandEntry.Parameters.AddWithValue("@date", dtpDate.Value.Date)
                commandEntry.ExecuteNonQuery()

                ' Update stock
                Dim queryUpdate As String = "UPDATE Articles SET quantite_disponible = quantite_disponible + @quantite WHERE id = @id"
                Dim commandUpdate As New MySqlCommand(queryUpdate, connection, transaction)
                commandUpdate.Parameters.AddWithValue("@quantite", numQuantite.Value)
                commandUpdate.Parameters.AddWithValue("@id", selectedArticle.Key)
                commandUpdate.ExecuteNonQuery()

                transaction.Commit()
                MessageBox.Show("Entrée enregistrée avec succès!")
                numQuantite.Value = 1
            Catch ex As Exception
                transaction.Rollback()
                MessageBox.Show("Erreur: " & ex.Message)
            End Try
        End Using
    End Sub
End Class