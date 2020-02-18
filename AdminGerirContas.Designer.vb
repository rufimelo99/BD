<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminGerirContas
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.confirmar_password_input = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.password_input = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.morada_input = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nome_input = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Saldo_input = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 31)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Contas Utilizadores"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(18, 52)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(992, 333)
        Me.DataGridView1.TabIndex = 4
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Button5.Location = New System.Drawing.Point(939, 8)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(86, 32)
        Me.Button5.TabIndex = 11
        Me.Button5.Text = "Voltar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label7.Location = New System.Drawing.Point(415, 528)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(162, 20)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Confirmar Password"
        '
        'confirmar_password_input
        '
        Me.confirmar_password_input.Location = New System.Drawing.Point(642, 528)
        Me.confirmar_password_input.Name = "confirmar_password_input"
        Me.confirmar_password_input.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.confirmar_password_input.Size = New System.Drawing.Size(335, 20)
        Me.confirmar_password_input.TabIndex = 35
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label6.Location = New System.Drawing.Point(415, 493)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 20)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Password"
        '
        'password_input
        '
        Me.password_input.Location = New System.Drawing.Point(642, 493)
        Me.password_input.Name = "password_input"
        Me.password_input.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password_input.Size = New System.Drawing.Size(335, 20)
        Me.password_input.TabIndex = 33
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label3.Location = New System.Drawing.Point(415, 455)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 20)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Morada"
        '
        'morada_input
        '
        Me.morada_input.Location = New System.Drawing.Point(642, 455)
        Me.morada_input.Name = "morada_input"
        Me.morada_input.Size = New System.Drawing.Size(335, 20)
        Me.morada_input.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label2.Location = New System.Drawing.Point(415, 417)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 20)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Nome"
        '
        'nome_input
        '
        Me.nome_input.Location = New System.Drawing.Point(642, 417)
        Me.nome_input.Name = "nome_input"
        Me.nome_input.Size = New System.Drawing.Size(335, 20)
        Me.nome_input.TabIndex = 26
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(419, 674)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 59)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Alterar Dados Pessoais"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(863, 589)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(114, 47)
        Me.Button2.TabIndex = 37
        Me.Button2.Text = "Alterar Dados Pessoais"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(18, 457)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(265, 21)
        Me.ComboBox1.TabIndex = 38
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label4.Location = New System.Drawing.Point(14, 415)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(172, 20)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Numero de Telemóvel"
        '
        'Saldo_input
        '
        Me.Saldo_input.AutoSize = True
        Me.Saldo_input.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Saldo_input.Location = New System.Drawing.Point(415, 563)
        Me.Saldo_input.Name = "Saldo_input"
        Me.Saldo_input.Size = New System.Drawing.Size(51, 20)
        Me.Saldo_input.TabIndex = 41
        Me.Saldo_input.Text = "Saldo"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(642, 563)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(335, 20)
        Me.TextBox1.TabIndex = 40
        '
        'AdminGerirContas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1037, 648)
        Me.Controls.Add(Me.Saldo_input)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.confirmar_password_input)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.password_input)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.morada_input)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nome_input)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AdminGerirContas"
        Me.Text = "AdminGerirContas"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button5 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents confirmar_password_input As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents password_input As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents morada_input As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents nome_input As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Saldo_input As Label
    Friend WithEvents TextBox1 As TextBox
End Class
