<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btncarica = New System.Windows.Forms.Button()
        Me.btnmostra = New System.Windows.Forms.Button()
        Me.lstris = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btncarica
        '
        Me.btncarica.Location = New System.Drawing.Point(149, 197)
        Me.btncarica.Name = "btncarica"
        Me.btncarica.Size = New System.Drawing.Size(123, 46)
        Me.btncarica.TabIndex = 0
        Me.btncarica.Text = "Carica(InputBox)"
        Me.btncarica.UseVisualStyleBackColor = True
        '
        'btnmostra
        '
        Me.btnmostra.Location = New System.Drawing.Point(316, 197)
        Me.btnmostra.Name = "btnmostra"
        Me.btnmostra.Size = New System.Drawing.Size(144, 46)
        Me.btnmostra.TabIndex = 1
        Me.btnmostra.Text = "Mostra"
        Me.btnmostra.UseVisualStyleBackColor = True
        '
        'lstris
        '
        Me.lstris.FormattingEnabled = True
        Me.lstris.Location = New System.Drawing.Point(140, 56)
        Me.lstris.Name = "lstris"
        Me.lstris.Size = New System.Drawing.Size(319, 69)
        Me.lstris.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lstris)
        Me.Controls.Add(Me.btnmostra)
        Me.Controls.Add(Me.btncarica)
        Me.Name = "Form1"
        Me.Text = "Carica array"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btncarica As Button
    Friend WithEvents btnmostra As Button
    Friend WithEvents lstris As ListBox
End Class
