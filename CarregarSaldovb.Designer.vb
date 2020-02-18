<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CarregarSaldovb
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
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CVV_INPUT = New System.Windows.Forms.TextBox()
        Me.NUMERO_INPUT = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.QUANTIA_INPUT = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SALDO = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Button5.Location = New System.Drawing.Point(702, 12)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(86, 32)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "Voltar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label1.Location = New System.Drawing.Point(110, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "CVV"
        '
        'CVV_INPUT
        '
        Me.CVV_INPUT.Location = New System.Drawing.Point(114, 158)
        Me.CVV_INPUT.Name = "CVV_INPUT"
        Me.CVV_INPUT.Size = New System.Drawing.Size(100, 20)
        Me.CVV_INPUT.TabIndex = 8
        '
        'NUMERO_INPUT
        '
        Me.NUMERO_INPUT.Location = New System.Drawing.Point(239, 158)
        Me.NUMERO_INPUT.Name = "NUMERO_INPUT"
        Me.NUMERO_INPUT.Size = New System.Drawing.Size(281, 20)
        Me.NUMERO_INPUT.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label2.Location = New System.Drawing.Point(235, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Numero"
        '
        'QUANTIA_INPUT
        '
        Me.QUANTIA_INPUT.Location = New System.Drawing.Point(114, 290)
        Me.QUANTIA_INPUT.Name = "QUANTIA_INPUT"
        Me.QUANTIA_INPUT.Size = New System.Drawing.Size(100, 20)
        Me.QUANTIA_INPUT.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label3.Location = New System.Drawing.Point(110, 258)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Quantia"
        '
        'SALDO
        '
        Me.SALDO.AutoSize = True
        Me.SALDO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.SALDO.Location = New System.Drawing.Point(242, 258)
        Me.SALDO.Name = "SALDO"
        Me.SALDO.Size = New System.Drawing.Size(61, 20)
        Me.SALDO.TabIndex = 13
        Me.SALDO.Text = "Saldo: "
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Button1.Location = New System.Drawing.Point(389, 357)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 32)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Validar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CarregarSaldovb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.SALDO)
        Me.Controls.Add(Me.QUANTIA_INPUT)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.NUMERO_INPUT)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CVV_INPUT)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button5)
        Me.Name = "CarregarSaldovb"
        Me.Text = "CarregarSaldovb"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button5 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents CVV_INPUT As TextBox
    Friend WithEvents NUMERO_INPUT As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents QUANTIA_INPUT As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents SALDO As Label
    Friend WithEvents Button1 As Button
End Class
