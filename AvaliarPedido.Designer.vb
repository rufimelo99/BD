<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AvaliarPedido
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DomainUpDown1 = New System.Windows.Forms.DomainUpDown()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(168, 198)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(500, 169)
        Me.TextBox1.TabIndex = 0
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(168, 55)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(196, 21)
        Me.ComboBox1.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label2.Location = New System.Drawing.Point(12, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Pedido"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label3.Location = New System.Drawing.Point(12, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Rating"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label4.Location = New System.Drawing.Point(15, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 20)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Comentarios"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(647, 396)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 29)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Enviar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DomainUpDown1
        '
        Me.DomainUpDown1.Items.Add("10")
        Me.DomainUpDown1.Items.Add("9")
        Me.DomainUpDown1.Items.Add("8")
        Me.DomainUpDown1.Items.Add("7")
        Me.DomainUpDown1.Items.Add("6")
        Me.DomainUpDown1.Items.Add("5")
        Me.DomainUpDown1.Items.Add("4")
        Me.DomainUpDown1.Items.Add("3")
        Me.DomainUpDown1.Items.Add("2")
        Me.DomainUpDown1.Items.Add("1")
        Me.DomainUpDown1.Items.Add("0")
        Me.DomainUpDown1.Location = New System.Drawing.Point(168, 104)
        Me.DomainUpDown1.Name = "DomainUpDown1"
        Me.DomainUpDown1.Size = New System.Drawing.Size(120, 20)
        Me.DomainUpDown1.TabIndex = 15
        Me.DomainUpDown1.Text = "5"
        Me.DomainUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'AvaliarPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DomainUpDown1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "AvaliarPedido"
        Me.Text = "AvaliarPedido"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents DomainUpDown1 As DomainUpDown
End Class
