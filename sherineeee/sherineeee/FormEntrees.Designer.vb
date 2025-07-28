<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEntrees
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
        cmbArticles = New ComboBox()
        numQuantite = New NumericUpDown()
        dtpDate = New DateTimePicker()
        btnEnregistrer = New Button()
        CType(numQuantite, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cmbArticles
        ' 
        cmbArticles.FormattingEnabled = True
        cmbArticles.Location = New Point(514, 62)
        cmbArticles.Name = "cmbArticles"
        cmbArticles.Size = New Size(151, 28)
        cmbArticles.TabIndex = 0
        ' 
        ' numQuantite
        ' 
        numQuantite.Location = New Point(515, 108)
        numQuantite.Name = "numQuantite"
        numQuantite.Size = New Size(150, 27)
        numQuantite.TabIndex = 1
        ' 
        ' dtpDate
        ' 
        dtpDate.Location = New Point(471, 168)
        dtpDate.Name = "dtpDate"
        dtpDate.Size = New Size(250, 27)
        dtpDate.TabIndex = 2
        ' 
        ' btnEnregistrer
        ' 
        btnEnregistrer.Location = New Point(543, 225)
        btnEnregistrer.Name = "btnEnregistrer"
        btnEnregistrer.Size = New Size(94, 29)
        btnEnregistrer.TabIndex = 3
        btnEnregistrer.Text = "Enregistrer"
        btnEnregistrer.UseVisualStyleBackColor = True
        ' 
        ' FormEntrees
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnEnregistrer)
        Controls.Add(dtpDate)
        Controls.Add(numQuantite)
        Controls.Add(cmbArticles)
        Name = "FormEntrees"
        Text = "FormEntrees"
        CType(numQuantite, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents cmbArticles As ComboBox
    Friend WithEvents numQuantite As NumericUpDown
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents btnEnregistrer As Button
End Class
