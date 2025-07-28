<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormArticles
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btnAjouter = New Button()
        btnModifier = New Button()
        dgvArticles = New DataGridView()
        txtNom = New TextBox()
        txtCategorie = New TextBox()
        numQuantite = New NumericUpDown()
        btnSupprimer = New Button()
        CType(dgvArticles, ComponentModel.ISupportInitialize).BeginInit()
        CType(numQuantite, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnAjouter
        ' 
        btnAjouter.Location = New Point(145, 331)
        btnAjouter.Name = "btnAjouter"
        btnAjouter.Size = New Size(94, 29)
        btnAjouter.TabIndex = 0
        btnAjouter.Text = "Ajouter"
        btnAjouter.UseVisualStyleBackColor = True
        ' 
        ' btnModifier
        ' 
        btnModifier.Location = New Point(270, 331)
        btnModifier.Name = "btnModifier"
        btnModifier.Size = New Size(94, 29)
        btnModifier.TabIndex = 1
        btnModifier.Text = "Modifier"
        btnModifier.UseVisualStyleBackColor = True
        ' 
        ' dgvArticles
        ' 
        dgvArticles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvArticles.Location = New Point(48, 12)
        dgvArticles.Name = "dgvArticles"
        dgvArticles.RowHeadersWidth = 51
        dgvArticles.Size = New Size(740, 205)
        dgvArticles.TabIndex = 2
        ' 
        ' txtNom
        ' 
        txtNom.Location = New Point(587, 233)
        txtNom.Name = "txtNom"
        txtNom.Size = New Size(125, 27)
        txtNom.TabIndex = 3
        ' 
        ' txtCategorie
        ' 
        txtCategorie.Location = New Point(587, 302)
        txtCategorie.Name = "txtCategorie"
        txtCategorie.Size = New Size(125, 27)
        txtCategorie.TabIndex = 4
        ' 
        ' numQuantite
        ' 
        numQuantite.Location = New Point(587, 358)
        numQuantite.Name = "numQuantite"
        numQuantite.Size = New Size(150, 27)
        numQuantite.TabIndex = 5
        ' 
        ' btnSupprimer
        ' 
        btnSupprimer.Location = New Point(421, 331)
        btnSupprimer.Name = "btnSupprimer"
        btnSupprimer.Size = New Size(94, 29)
        btnSupprimer.TabIndex = 6
        btnSupprimer.Text = "Supprimer"
        btnSupprimer.UseVisualStyleBackColor = True
        ' 
        ' FormArticles
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnSupprimer)
        Controls.Add(numQuantite)
        Controls.Add(txtCategorie)
        Controls.Add(txtNom)
        Controls.Add(dgvArticles)
        Controls.Add(btnModifier)
        Controls.Add(btnAjouter)
        Name = "FormArticles"
        Text = "FormArticles"
        CType(dgvArticles, ComponentModel.ISupportInitialize).EndInit()
        CType(numQuantite, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnAjouter As Button
    Friend WithEvents btnModifier As Button
    Friend WithEvents dgvArticles As DataGridView
    Friend WithEvents txtNom As TextBox
    Friend WithEvents txtCategorie As TextBox
    Friend WithEvents numQuantite As NumericUpDown
    Friend WithEvents btnSupprimer As Button
End Class
