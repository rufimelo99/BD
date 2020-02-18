<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Login_username_input = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Login_password_input = New System.Windows.Forms.TextBox()
        Me.Login_Login_Button = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Login_username_input
        '
        Me.Login_username_input.Location = New System.Drawing.Point(297, 207)
        Me.Login_username_input.Name = "Login_username_input"
        Me.Login_username_input.Size = New System.Drawing.Size(277, 20)
        Me.Login_username_input.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label1.Location = New System.Drawing.Point(146, 205)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Telemóvel"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label2.Location = New System.Drawing.Point(146, 263)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password"
        '
        'Login_password_input
        '
        Me.Login_password_input.Location = New System.Drawing.Point(297, 263)
        Me.Login_password_input.Name = "Login_password_input"
        Me.Login_password_input.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Login_password_input.Size = New System.Drawing.Size(277, 20)
        Me.Login_password_input.TabIndex = 2
        '
        'Login_Login_Button
        '
        Me.Login_Login_Button.Location = New System.Drawing.Point(297, 326)
        Me.Login_Login_Button.Name = "Login_Login_Button"
        Me.Login_Login_Button.Size = New System.Drawing.Size(121, 41)
        Me.Login_Login_Button.TabIndex = 4
        Me.Login_Login_Button.Text = "Login"
        Me.Login_Login_Button.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(453, 326)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 41)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Criar Conta"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.BD1.My.Resources.Resources.hamburger_3278191_960_720
        Me.PictureBox1.Location = New System.Drawing.Point(279, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(309, 321)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Minerva", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(114, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 43)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Burguers"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Login_Login_Button)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Login_password_input)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Login_username_input)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Login"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Login_username_input As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Login_password_input As TextBox
    Friend WithEvents Login_Login_Button As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
End Class
