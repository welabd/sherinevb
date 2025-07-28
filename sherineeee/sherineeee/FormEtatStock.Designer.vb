<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEtatStock
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
        dgvStock = New DataGridView()
        btnActualiser = New Button()
        CType(dgvStock, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvStock
        ' 
        dgvStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvStock.Location = New Point(51, 27)
        dgvStock.Name = "dgvStock"
        dgvStock.RowHeadersWidth = 51
        dgvStock.Size = New Size(700, 188)
        dgvStock.TabIndex = 0
        ' 
        ' btnActualiser
        ' 
        btnActualiser.Location = New Point(512, 285)
        btnActualiser.Name = "btnActualiser"
        btnActualiser.Size = New Size(94, 29)
        btnActualiser.TabIndex = 1
        btnActualiser.Text = "Actualiser"
        btnActualiser.UseVisualStyleBackColor = True
        ' 
        ' FormEtatStock
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnActualiser)
        Controls.Add(dgvStock)
        Name = "FormEtatStock"
        Text = "FormEtatStock"
        CType(dgvStock, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvStock As DataGridView
    Friend WithEvents btnActualiser As Button
End Class
