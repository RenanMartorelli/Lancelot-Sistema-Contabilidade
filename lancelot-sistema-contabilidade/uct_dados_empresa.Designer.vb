<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uct_dados_empresa
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
        Me.txt_nome_empresa = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Atividade = New System.Windows.Forms.Label()
        Me.txt_segmento = New System.Windows.Forms.TextBox()
        Me.txt_endereço = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_editar_dados = New System.Windows.Forms.Button()
        Me.btn_adicionar_usuario = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rdb_PEPS = New System.Windows.Forms.RadioButton()
        Me.rdb_UEPS = New System.Windows.Forms.RadioButton()
        Me.rdb_media = New System.Windows.Forms.RadioButton()
        Me.lbl_modo_estoque = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_nome_empresa
        '
        Me.txt_nome_empresa.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.txt_nome_empresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_nome_empresa.Font = New System.Drawing.Font("Tw Cen MT", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome_empresa.ForeColor = System.Drawing.SystemColors.Menu
        Me.txt_nome_empresa.Location = New System.Drawing.Point(109, 226)
        Me.txt_nome_empresa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_nome_empresa.Name = "txt_nome_empresa"
        Me.txt_nome_empresa.Size = New System.Drawing.Size(447, 33)
        Me.txt_nome_empresa.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tw Cen MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(111, 190)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nome da empresa"
        '
        'Atividade
        '
        Me.Atividade.AutoSize = True
        Me.Atividade.Font = New System.Drawing.Font("Tw Cen MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Atividade.Location = New System.Drawing.Point(111, 287)
        Me.Atividade.Name = "Atividade"
        Me.Atividade.Size = New System.Drawing.Size(111, 28)
        Me.Atividade.TabIndex = 4
        Me.Atividade.Text = "Segmento"
        '
        'txt_segmento
        '
        Me.txt_segmento.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.txt_segmento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_segmento.Font = New System.Drawing.Font("Tw Cen MT", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_segmento.ForeColor = System.Drawing.SystemColors.Menu
        Me.txt_segmento.Location = New System.Drawing.Point(109, 318)
        Me.txt_segmento.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_segmento.Name = "txt_segmento"
        Me.txt_segmento.Size = New System.Drawing.Size(349, 33)
        Me.txt_segmento.TabIndex = 5
        '
        'txt_endereço
        '
        Me.txt_endereço.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.txt_endereço.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_endereço.Font = New System.Drawing.Font("Tw Cen MT", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_endereço.ForeColor = System.Drawing.SystemColors.Menu
        Me.txt_endereço.Location = New System.Drawing.Point(109, 410)
        Me.txt_endereço.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_endereço.Name = "txt_endereço"
        Me.txt_endereço.Size = New System.Drawing.Size(562, 33)
        Me.txt_endereço.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tw Cen MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(111, 379)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 28)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Endereço"
        '
        'txt_email
        '
        Me.txt_email.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_email.Font = New System.Drawing.Font("Tw Cen MT", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email.ForeColor = System.Drawing.SystemColors.Menu
        Me.txt_email.Location = New System.Drawing.Point(109, 497)
        Me.txt_email.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(486, 33)
        Me.txt_email.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tw Cen MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(111, 466)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 28)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "E-mail"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Tw Cen MT", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(109, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Label6.Size = New System.Drawing.Size(283, 47)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Dados da empresa"
        '
        'btn_editar_dados
        '
        Me.btn_editar_dados.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btn_editar_dados.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_editar_dados.FlatAppearance.BorderSize = 0
        Me.btn_editar_dados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_editar_dados.Font = New System.Drawing.Font("Tw Cen MT", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_editar_dados.ForeColor = System.Drawing.Color.White
        Me.btn_editar_dados.Location = New System.Drawing.Point(109, 610)
        Me.btn_editar_dados.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_editar_dados.Name = "btn_editar_dados"
        Me.btn_editar_dados.Size = New System.Drawing.Size(311, 62)
        Me.btn_editar_dados.TabIndex = 14
        Me.btn_editar_dados.Text = "Atualizar"
        Me.btn_editar_dados.UseVisualStyleBackColor = False
        '
        'btn_adicionar_usuario
        '
        Me.btn_adicionar_usuario.BackColor = System.Drawing.Color.Transparent
        Me.btn_adicionar_usuario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btn_adicionar_usuario.FlatAppearance.BorderSize = 4
        Me.btn_adicionar_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_adicionar_usuario.Font = New System.Drawing.Font("Tw Cen MT", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_adicionar_usuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btn_adicionar_usuario.Location = New System.Drawing.Point(461, 610)
        Me.btn_adicionar_usuario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_adicionar_usuario.Name = "btn_adicionar_usuario"
        Me.btn_adicionar_usuario.Size = New System.Drawing.Size(308, 62)
        Me.btn_adicionar_usuario.TabIndex = 15
        Me.btn_adicionar_usuario.Text = "Adicionar usuário"
        Me.btn_adicionar_usuario.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(767, 190)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(3, 342)
        Me.Button2.TabIndex = 30
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tw Cen MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(775, 190)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(204, 28)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Método de estoque"
        '
        'rdb_PEPS
        '
        Me.rdb_PEPS.AutoSize = True
        Me.rdb_PEPS.Font = New System.Drawing.Font("Tw Cen MT", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb_PEPS.Location = New System.Drawing.Point(780, 319)
        Me.rdb_PEPS.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rdb_PEPS.Name = "rdb_PEPS"
        Me.rdb_PEPS.Size = New System.Drawing.Size(80, 32)
        Me.rdb_PEPS.TabIndex = 32
        Me.rdb_PEPS.TabStop = True
        Me.rdb_PEPS.Text = "PEPS"
        Me.rdb_PEPS.UseVisualStyleBackColor = True
        '
        'rdb_UEPS
        '
        Me.rdb_UEPS.AutoSize = True
        Me.rdb_UEPS.Font = New System.Drawing.Font("Tw Cen MT", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb_UEPS.Location = New System.Drawing.Point(780, 381)
        Me.rdb_UEPS.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rdb_UEPS.Name = "rdb_UEPS"
        Me.rdb_UEPS.Size = New System.Drawing.Size(83, 32)
        Me.rdb_UEPS.TabIndex = 33
        Me.rdb_UEPS.TabStop = True
        Me.rdb_UEPS.Text = "UEPS"
        Me.rdb_UEPS.UseVisualStyleBackColor = True
        '
        'rdb_media
        '
        Me.rdb_media.AutoSize = True
        Me.rdb_media.Font = New System.Drawing.Font("Tw Cen MT", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb_media.Location = New System.Drawing.Point(780, 442)
        Me.rdb_media.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rdb_media.Name = "rdb_media"
        Me.rdb_media.Size = New System.Drawing.Size(95, 32)
        Me.rdb_media.TabIndex = 34
        Me.rdb_media.TabStop = True
        Me.rdb_media.Text = "Média"
        Me.rdb_media.UseVisualStyleBackColor = True
        '
        'lbl_modo_estoque
        '
        Me.lbl_modo_estoque.AutoSize = True
        Me.lbl_modo_estoque.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lbl_modo_estoque.Font = New System.Drawing.Font("Tw Cen MT", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_modo_estoque.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_modo_estoque.Location = New System.Drawing.Point(776, 224)
        Me.lbl_modo_estoque.Name = "lbl_modo_estoque"
        Me.lbl_modo_estoque.Size = New System.Drawing.Size(24, 33)
        Me.lbl_modo_estoque.TabIndex = 35
        Me.lbl_modo_estoque.Text = "-"
        '
        'uct_dados_empresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.Controls.Add(Me.lbl_modo_estoque)
        Me.Controls.Add(Me.rdb_media)
        Me.Controls.Add(Me.rdb_UEPS)
        Me.Controls.Add(Me.rdb_PEPS)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btn_adicionar_usuario)
        Me.Controls.Add(Me.btn_editar_dados)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_endereço)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_segmento)
        Me.Controls.Add(Me.Atividade)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_nome_empresa)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "uct_dados_empresa"
        Me.Size = New System.Drawing.Size(1147, 768)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_nome_empresa As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Atividade As Label
    Friend WithEvents txt_segmento As TextBox
    Friend WithEvents txt_endereço As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_editar_dados As Button
    Friend WithEvents btn_adicionar_usuario As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents rdb_PEPS As RadioButton
    Friend WithEvents rdb_UEPS As RadioButton
    Friend WithEvents rdb_media As RadioButton
    Friend WithEvents lbl_modo_estoque As Label
End Class
