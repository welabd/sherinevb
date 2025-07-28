Imports MySql.Data.MySqlClient

Public Class FormSorties
    Private connectionString As String = "Server=localhost;Database=gestion_stock;Uid=root;Pwd=;"

    Private Sub FormSorties_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        If String.IsNullOrEmpty(txtRaison.Text) Then
            MessageBox.Show("Veuillez indiquer une raison")
            Return
        End If

        Dim selectedArticle As KeyValuePair(Of Integer, String) = DirectCast(cmbArticles.SelectedItem, KeyValuePair(Of Integer, String))

        Using connection As New MySqlConnection(connectionString)
            ' Check available quantity first
            Dim checkQuery As String = "SELECT quantite_disponible FROM Articles WHERE id = @id"
            Dim checkCommand As New MySqlCommand(checkQuery, connection)
            checkCommand.Parameters.AddWithValue("@id", selectedArticle.Key)

            Try
                connection.Open()
                Dim availableQty As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())

                If availableQty < numQuantite.Value Then
                    MessageBox.Show("Quantité insuffisante en stock! Disponible: " & availableQty)
                    Return
                End If

                ' Start transaction
                Dim transaction As MySqlTransaction = connection.BeginTransaction()

                Try
                    ' Add output
                    Dim queryOutput As String = "INSERT INTO Sorties (article_id, quantite, date_sortie, raison) VALUES (@article_id, @quantite, @date, @raison)"
                    Dim commandOutput As New MySqlCommand(queryOutput, connection, transaction)
                    commandOutput.Parameters.AddWithValue("@article_id", selectedArticle.Key)
                    commandOutput.Parameters.AddWithValue("@quantite", numQuantite.Value)
                    commandOutput.Parameters.AddWithValue("@date", dtpDate.Value.Date)
                    commandOutput.Parameters.AddWithValue("@raison", txtRaison.Text)
                    commandOutput.ExecuteNonQuery()

                    ' Update stock
                    Dim queryUpdate As String = "UPDATE Articles SET quantite_disponible = quantite_disponible - @quantite WHERE id = @id"
                    Dim commandUpdate As New MySqlCommand(queryUpdate, connection, transaction)
                    commandUpdate.Parameters.AddWithValue("@quantite", numQuantite.Value)
                    commandUpdate.Parameters.AddWithValue("@id", selectedArticle.Key)
                    commandUpdate.ExecuteNonQuery()

                    transaction.Commit()
                    MessageBox.Show("Sortie enregistrée avec succès!")
                    numQuantite.Value = 1
                    txtRaison.Text = ""
                Catch ex As Exception
                    transaction.Rollback()
                    MessageBox.Show("Erreur lors de l'enregistrement: " & ex.Message)
                End Try
            Catch ex As Exception
                MessageBox.Show("Erreur: " & ex.Message)
            End Try
        End Using
    End Sub
End Class