<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlterarDadosConta
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
        Me.nome_input = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.morada_input = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.numero_input = New System.Windows.Forms.Label()
        Me.nif_input = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.confirmar_password_input = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.password_input = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(259, 31)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Definições de Conta"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(43, 340)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 59)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Alterar Dados Pessoais"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'nome_input
        '
        Me.nome_input.Location = New System.Drawing.Point(266, 83)
        Me.nome_input.Name = "nome_input"
        Me.nome_input.Size = New System.Drawing.Size(335, 20)
        Me.nome_input.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label2.Location = New System.Drawing.Point(39, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nome"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label3.Location = New System.Drawing.Point(39, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Morada"
        '
        'morada_input
        '
        Me.morada_input.Location = New System.Drawing.Point(266, 121)
        Me.morada_input.Name = "morada_input"
        Me.morada_input.Size = New System.Drawing.Size(335, 20)
        Me.morada_input.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label4.Location = New System.Drawing.Point(39, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Telemóvel"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label5.Location = New System.Drawing.Point(39, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "NIF"
        '
        'numero_input
        '
        Me.numero_input.AutoSize = True
        Me.numero_input.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.numero_input.Location = New System.Drawing.Point(262, 195)
        Me.numero_input.Name = "numero_input"
        Me.numero_input.Size = New System.Drawing.Size(98, 20)
        Me.numero_input.TabIndex = 17
        Me.numero_input.Text = "!!!Numero!!!"
        '
        'nif_input
        '
        Me.nif_input.AutoSize = True
        Me.nif_input.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.nif_input.Location = New System.Drawing.Point(262, 157)
        Me.nif_input.Name = "nif_input"
        Me.nif_input.Size = New System.Drawing.Size(65, 20)
        Me.nif_input.TabIndex = 18
        Me.nif_input.Text = "!!!NIF!!!"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label7.Location = New System.Drawing.Point(39, 269)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(162, 20)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Confirmar Password"
        '
        'confirmar_password_input
        '
        Me.confirmar_password_input.Location = New System.Drawing.Point(266, 271)
        Me.confirmar_password_input.Name = "confirmar_password_input"
        Me.confirmar_password_input.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.confirmar_password_input.Size = New System.Drawing.Size(335, 20)
        Me.confirmar_password_input.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label6.Location = New System.Drawing.Point(39, 234)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 20)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Password"
        '
        'password_input
        '
        Me.password_input.Location = New System.Drawing.Point(266, 236)
        Me.password_input.Name = "password_input"
        Me.password_input.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password_input.Size = New System.Drawing.Size(335, 20)
        Me.password_input.TabIndex = 21
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Button2.Location = New System.Drawing.Point(702, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 32)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "Voltar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'AlterarDadosConta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.confirmar_password_input)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.password_input)
        Me.Controls.Add(Me.nif_input)
        Me.Controls.Add(Me.numero_input)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.morada_input)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nome_input)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.name = "AlterarDadosConta"
        Me.Text = "AlterarDadosConta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents nome_input As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents morada_input As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents numero_input As Label
    Friend WithEvents nif_input As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents confirmar_password_input As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents password_input As TextBox
    Friend WithEvents Button2 As Button
End Class
