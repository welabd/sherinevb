<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSorties
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
        txtRaison = New TextBox()
        btnEnregistrer = New Button()
        CType(numQuantite, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cmbArticles
        ' 
        cmbArticles.FormattingEnabled = True
        cmbArticles.Location = New Point(561, 68)
        cmbArticles.Name = "cmbArticles"
        cmbArticles.Size = New Size(151, 28)
        cmbArticles.TabIndex = 0
        ' 
        ' numQuantite
        ' 
        numQuantite.Location = New Point(561, 123)
        numQuantite.Name = "numQuantite"
        numQuantite.Size = New Size(150, 27)
        numQuantite.TabIndex = 1
        ' 
        ' dtpDate
        ' 
        dtpDate.Location = New Point(508, 177)
        dtpDate.Name = "dtpDate"
        dtpDate.Size = New Size(250, 27)
        dtpDate.TabIndex = 2
        ' 
        ' txtRaison
        ' 
        txtRaison.Location = New Point(561, 228)
        txtRaison.Name = "txtRaison"
        txtRaison.Size = New Size(125, 27)
        txtRaison.TabIndex = 3
        ' 
        ' btnEnregistrer
        ' 
        btnEnregistrer.Location = New Point(576, 280)
        btnEnregistrer.Name = "btnEnregistrer"
        btnEnregistrer.Size = New Size(94, 29)
        btnEnregistrer.TabIndex = 4
        btnEnregistrer.Text = "Enregistrer"
        btnEnregistrer.UseVisualStyleBackColor = True
        ' 
        ' FormSorties
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnEnregistrer)
        Controls.Add(txtRaison)
        Controls.Add(dtpDate)
        Controls.Add(numQuantite)
        Controls.Add(cmbArticles)
        Name = "FormSorties"
        Text = "FormSorties"
        CType(numQuantite, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmbArticles As ComboBox
    Friend WithEvents numQuantite As NumericUpDown
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents txtRaison As TextBox
    Friend WithEvents btnEnregistrer As Button
End Class
