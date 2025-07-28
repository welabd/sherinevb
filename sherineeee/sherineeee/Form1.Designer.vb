<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnArticles = New Button()
        btnEtatStock = New Button()
        btnSorties = New Button()
        btnEntrees = New Button()
        SuspendLayout()
        ' 
        ' btnArticles
        ' 
        btnArticles.Location = New Point(84, 340)
        btnArticles.Name = "btnArticles"
        btnArticles.Size = New Size(94, 29)
        btnArticles.TabIndex = 0
        btnArticles.Text = "Articles"
        btnArticles.UseVisualStyleBackColor = True
        ' 
        ' btnEtatStock
        ' 
        btnEtatStock.Location = New Point(567, 340)
        btnEtatStock.Name = "btnEtatStock"
        btnEtatStock.Size = New Size(94, 29)
        btnEtatStock.TabIndex = 1
        btnEtatStock.Text = "EtatStock"
        btnEtatStock.UseVisualStyleBackColor = True
        ' 
        ' btnSorties
        ' 
        btnSorties.Location = New Point(390, 340)
        btnSorties.Name = "btnSorties"
        btnSorties.Size = New Size(94, 29)
        btnSorties.TabIndex = 2
        btnSorties.Text = "Sorties"
        btnSorties.UseVisualStyleBackColor = True
        ' 
        ' btnEntrees
        ' 
        btnEntrees.Location = New Point(226, 340)
        btnEntrees.Name = "btnEntrees"
        btnEntrees.Size = New Size(94, 29)
        btnEntrees.TabIndex = 3
        btnEntrees.Text = "Entrees"
        btnEntrees.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnEntrees)
        Controls.Add(btnSorties)
        Controls.Add(btnEtatStock)
        Controls.Add(btnArticles)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnArticles As Button
    Friend WithEvents btnEtatStock As Button
    Friend WithEvents btnSorties As Button
    Friend WithEvents btnEntrees As Button

End Class
