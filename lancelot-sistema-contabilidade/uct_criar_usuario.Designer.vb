<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uct_criar_usuario
    Inherits System.Windows.Forms.UserControl

    'O UserControl substitui o descarte para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_sobrenome = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_confirma_senha = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.rdb_administrador = New System.Windows.Forms.RadioButton()
        Me.rdb_operador = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_confirmar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_nome
        '
        Me.txt_nome.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.txt_nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_nome.Font = New System.Drawing.Font("Tw Cen MT", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome.ForeColor = System.Drawing.SystemColors.Menu
        Me.txt_nome.Location = New System.Drawing.Point(82, 181)
        Me.txt_nome.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(227, 28)
        Me.txt_nome.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tw Cen MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(83, 150)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nome"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tw Cen MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(334, 150)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 22)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Sobrenome"
        '
        'txt_sobrenome
        '
        Me.txt_sobrenome.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.txt_sobrenome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_sobrenome.Font = New System.Drawing.Font("Tw Cen MT", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_sobrenome.ForeColor = System.Drawing.SystemColors.Menu
        Me.txt_sobrenome.Location = New System.Drawing.Point(330, 181)
        Me.txt_sobrenome.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_sobrenome.Name = "txt_sobrenome"
        Me.txt_sobrenome.Size = New System.Drawing.Size(295, 28)
        Me.txt_sobrenome.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tw Cen MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(83, 230)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 22)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Usuário"
        '
        'txt_usuario
        '
        Me.txt_usuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.txt_usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_usuario.Font = New System.Drawing.Font("Tw Cen MT", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_usuario.ForeColor = System.Drawing.SystemColors.Menu
        Me.txt_usuario.Location = New System.Drawing.Point(82, 255)
        Me.txt_usuario.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(327, 28)
        Me.txt_usuario.TabIndex = 5
        '
        'txt_senha
        '
        Me.txt_senha.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.txt_senha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_senha.Font = New System.Drawing.Font("Tw Cen MT", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha.ForeColor = System.Drawing.SystemColors.Menu
        Me.txt_senha.Location = New System.Drawing.Point(82, 330)
        Me.txt_senha.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_senha.Size = New System.Drawing.Size(227, 28)
        Me.txt_senha.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tw Cen MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(83, 305)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 22)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Senha"
        '
        'txt_confirma_senha
        '
        Me.txt_confirma_senha.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.txt_confirma_senha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_confirma_senha.Font = New System.Drawing.Font("Tw Cen MT", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_confirma_senha.ForeColor = System.Drawing.SystemColors.Menu
        Me.txt_confirma_senha.Location = New System.Drawing.Point(326, 330)
        Me.txt_confirma_senha.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_confirma_senha.Name = "txt_confirma_senha"
        Me.txt_confirma_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_confirma_senha.Size = New System.Drawing.Size(227, 28)
        Me.txt_confirma_senha.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tw Cen MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(326, 305)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(141, 22)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Confirmar senha"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Tw Cen MT", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(82, 57)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Padding = New System.Windows.Forms.Padding(3)
        Me.Label6.Size = New System.Drawing.Size(272, 37)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Registrar novo usuário"
        '
        'rdb_administrador
        '
        Me.rdb_administrador.AutoSize = True
        Me.rdb_administrador.Font = New System.Drawing.Font("Tw Cen MT", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb_administrador.Location = New System.Drawing.Point(86, 426)
        Me.rdb_administrador.Margin = New System.Windows.Forms.Padding(2)
        Me.rdb_administrador.Name = "rdb_administrador"
        Me.rdb_administrador.Size = New System.Drawing.Size(131, 26)
        Me.rdb_administrador.TabIndex = 11
        Me.rdb_administrador.TabStop = True
        Me.rdb_administrador.Text = "Administrador"
        Me.rdb_administrador.UseVisualStyleBackColor = True
        '
        'rdb_operador
        '
        Me.rdb_operador.AutoSize = True
        Me.rdb_operador.Font = New System.Drawing.Font("Tw Cen MT", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb_operador.Location = New System.Drawing.Point(245, 426)
        Me.rdb_operador.Margin = New System.Windows.Forms.Padding(2)
        Me.rdb_operador.Name = "rdb_operador"
        Me.rdb_operador.Size = New System.Drawing.Size(105, 26)
        Me.rdb_operador.TabIndex = 12
        Me.rdb_operador.TabStop = True
        Me.rdb_operador.Text = "Operador"
        Me.rdb_operador.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tw Cen MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(83, 390)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 22)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Grau de acesso"
        '
        'btn_confirmar
        '
        Me.btn_confirmar.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btn_confirmar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_confirmar.FlatAppearance.BorderSize = 4
        Me.btn_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_confirmar.Font = New System.Drawing.Font("Tw Cen MT", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_confirmar.ForeColor = System.Drawing.Color.White
        Me.btn_confirmar.Location = New System.Drawing.Point(76, 488)
        Me.btn_confirmar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_confirmar.Name = "btn_confirmar"
        Me.btn_confirmar.Size = New System.Drawing.Size(274, 50)
        Me.btn_confirmar.TabIndex = 14
        Me.btn_confirmar.Text = "Confirmar"
        Me.btn_confirmar.UseVisualStyleBackColor = False
        '
        'uct_criar_usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.Controls.Add(Me.btn_confirmar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.rdb_operador)
        Me.Controls.Add(Me.rdb_administrador)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_confirma_senha)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_sobrenome)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_nome)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "uct_criar_usuario"
        Me.Size = New System.Drawing.Size(860, 624)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_nome As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_sobrenome As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_confirma_senha As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents rdb_administrador As RadioButton
    Friend WithEvents rdb_operador As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_confirmar As Button
End Class
