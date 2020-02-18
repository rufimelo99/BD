<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Estatisticas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 31)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Estatísticas"
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Button4.Location = New System.Drawing.Point(249, 297)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(302, 63)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "Ver Críticas"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Button3.Location = New System.Drawing.Point(249, 228)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(302, 63)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Ratings Cozinheiros e Empregados"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Button2.Location = New System.Drawing.Point(249, 159)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(302, 63)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Dados de Pedidos"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Button1.Location = New System.Drawing.Point(249, 90)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(302, 63)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Popularidade e Receitas"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Button6.Location = New System.Drawing.Point(702, 9)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(86, 32)
        Me.Button6.TabIndex = 16
        Me.Button6.Text = "Voltar"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Estatisticas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Estatisticas"
        Me.Text = "Estatisticas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button6 As Button
End Class
