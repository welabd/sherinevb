Imports MySql.Data.MySqlClient

Public Class FormEtatStock
    Private connectionString As String = "Server=localhost;Database=gestion_stock;Uid=root;Pwd=;"

    Private Sub FormEtatStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStock()
    End Sub

    Private Sub LoadStock()
        Using connection As New MySqlConnection(connectionString)
            Dim query As String = "SELECT id, nom_article, categorie, quantite_disponible FROM Articles ORDER BY categorie, nom_article"
            Dim adapter As New MySqlDataAdapter(query, connection)
            Dim table As New DataTable()

            Try
                adapter.Fill(table)
                dgvStock.DataSource = table

                ' Format the DataGridView
                dgvStock.Columns("id").Visible = False
                dgvStock.Columns("nom_article").HeaderText = "Article"
                dgvStock.Columns("categorie").HeaderText = "Catégorie"
                dgvStock.Columns("quantite_disponible").HeaderText = "Quantité disponible"

                ' Color rows with low stock
                For Each row As DataGridViewRow In dgvStock.Rows
                    If Convert.ToInt32(row.Cells("quantite_disponible").Value) < 5 Then
                        row.DefaultCellStyle.BackColor = Color.LightSalmon
                    End If
                Next
            Catch ex As Exception
                MessageBox.Show("Erreur: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnActualiser_Click(sender As Object, e As EventArgs) Handles btnActualiser.Click
        LoadStock()
    End Sub
End Class