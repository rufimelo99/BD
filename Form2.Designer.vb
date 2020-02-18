<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.Label1.Location = New System.Drawing.Point(57, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bem-vindo!"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Button1.Location = New System.Drawing.Point(218, 98)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(302, 63)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Histórico"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Button2.Location = New System.Drawing.Point(218, 167)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(302, 63)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Realizar Pedido"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Button3.Location = New System.Drawing.Point(218, 236)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(302, 63)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Menu"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Button4.Location = New System.Drawing.Point(218, 305)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(302, 63)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Alterar Dados de Conta"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Button5.Location = New System.Drawing.Point(702, 12)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(86, 32)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "Sair"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Button6.Location = New System.Drawing.Point(218, 374)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(302, 63)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "Carregar Saldo"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label5.Location = New System.Drawing.Point(653, 469)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 20)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Saldo: "
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(795, 512)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Label5 As Label
End Class
