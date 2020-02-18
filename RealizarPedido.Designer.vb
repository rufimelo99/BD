<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RealizarPedido
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Total_preco = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 31)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Realizar Pedido"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(325, 160)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label3.Location = New System.Drawing.Point(321, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Quantidade"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label2.Location = New System.Drawing.Point(64, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Hamburguer"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(68, 160)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(196, 21)
        Me.ComboBox1.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(67, 207)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Adionar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(482, 166)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(291, 243)
        Me.DataGridView1.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label4.Location = New System.Drawing.Point(583, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Carrinho"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Button2.Location = New System.Drawing.Point(144, 344)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(160, 48)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Check Out"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(68, 251)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(122, 23)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Limpar Pedido"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Button4.Location = New System.Drawing.Point(702, 9)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(86, 32)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "Voltar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Total_preco
        '
        Me.Total_preco.AutoSize = True
        Me.Total_preco.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Total_preco.Location = New System.Drawing.Point(321, 358)
        Me.Total_preco.Name = "Total_preco"
        Me.Total_preco.Size = New System.Drawing.Size(56, 20)
        Me.Total_preco.TabIndex = 16
        Me.Total_preco.Text = "Total: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label5.Location = New System.Drawing.Point(488, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 20)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Saldo: "
        '
        'RealizarPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Total_preco)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "RealizarPedido"
        Me.Text = "RealizarPedido"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Total_preco As Label
    Friend WithEvents Label5 As Label
End Class
