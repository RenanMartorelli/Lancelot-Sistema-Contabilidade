<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uct_plano_contas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_valor_total = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_qtde = New System.Windows.Forms.TextBox()
        Me.dgv_plano_contas = New System.Windows.Forms.DataGridView()
        Me.btn_verificar_saldo = New System.Windows.Forms.Button()
        Me.btn_adicionar_novo_estoque = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nome_conta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_estoque = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_plano_contas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Tw Cen MT", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(105, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Padding = New System.Windows.Forms.Padding(4)
        Me.Label6.Size = New System.Drawing.Size(255, 47)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Plano de  contas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tw Cen MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(93, 654)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 28)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Saldo total"
        '
        'txt_valor_total
        '
        Me.txt_valor_total.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.txt_valor_total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_valor_total.Font = New System.Drawing.Font("Tw Cen MT", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_valor_total.ForeColor = System.Drawing.SystemColors.Menu
        Me.txt_valor_total.Location = New System.Drawing.Point(99, 683)
        Me.txt_valor_total.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_valor_total.Name = "txt_valor_total"
        Me.txt_valor_total.Size = New System.Drawing.Size(157, 33)
        Me.txt_valor_total.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tw Cen MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(299, 654)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 28)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Quantidade"
        '
        'txt_qtde
        '
        Me.txt_qtde.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.txt_qtde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_qtde.Font = New System.Drawing.Font("Tw Cen MT", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_qtde.ForeColor = System.Drawing.SystemColors.Menu
        Me.txt_qtde.Location = New System.Drawing.Point(305, 683)
        Me.txt_qtde.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_qtde.Name = "txt_qtde"
        Me.txt_qtde.Size = New System.Drawing.Size(166, 33)
        Me.txt_qtde.TabIndex = 23
        '
        'dgv_plano_contas
        '
        Me.dgv_plano_contas.AllowUserToAddRows = False
        Me.dgv_plano_contas.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tw Cen MT", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(100, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.AppWorkspace
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_plano_contas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_plano_contas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_plano_contas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.nome_conta, Me.id_estoque})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(100, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_plano_contas.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_plano_contas.Location = New System.Drawing.Point(101, 146)
        Me.dgv_plano_contas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgv_plano_contas.Name = "dgv_plano_contas"
        Me.dgv_plano_contas.ReadOnly = True
        Me.dgv_plano_contas.RowHeadersVisible = False
        Me.dgv_plano_contas.RowTemplate.Height = 24
        Me.dgv_plano_contas.Size = New System.Drawing.Size(939, 361)
        Me.dgv_plano_contas.TabIndex = 25
        '
        'btn_verificar_saldo
        '
        Me.btn_verificar_saldo.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btn_verificar_saldo.FlatAppearance.BorderSize = 0
        Me.btn_verificar_saldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_verificar_saldo.Font = New System.Drawing.Font("Tw Cen MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_verificar_saldo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_verificar_saldo.Location = New System.Drawing.Point(99, 572)
        Me.btn_verificar_saldo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_verificar_saldo.Name = "btn_verificar_saldo"
        Me.btn_verificar_saldo.Size = New System.Drawing.Size(209, 57)
        Me.btn_verificar_saldo.TabIndex = 27
        Me.btn_verificar_saldo.Text = "Verificar"
        Me.btn_verificar_saldo.UseVisualStyleBackColor = False
        '
        'btn_adicionar_novo_estoque
        '
        Me.btn_adicionar_novo_estoque.BackColor = System.Drawing.Color.Transparent
        Me.btn_adicionar_novo_estoque.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btn_adicionar_novo_estoque.FlatAppearance.BorderSize = 4
        Me.btn_adicionar_novo_estoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_adicionar_novo_estoque.Font = New System.Drawing.Font("Tw Cen MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_adicionar_novo_estoque.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btn_adicionar_novo_estoque.Location = New System.Drawing.Point(725, 625)
        Me.btn_adicionar_novo_estoque.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_adicionar_novo_estoque.Name = "btn_adicionar_novo_estoque"
        Me.btn_adicionar_novo_estoque.Size = New System.Drawing.Size(300, 57)
        Me.btn_adicionar_novo_estoque.TabIndex = 28
        Me.btn_adicionar_novo_estoque.Text = "Adicionar novo estoque"
        Me.btn_adicionar_novo_estoque.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(617, 562)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(3, 170)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tw Cen MT", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(104, 519)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(741, 20)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Selecione a célula da conta desejada e clique em ""Verficar"" para consultar seu sa" &
    "ldo e outras informações."
        '
        'codigo
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.codigo.DefaultCellStyle = DataGridViewCellStyle2
        Me.codigo.HeaderText = "Código"
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        '
        'nome_conta
        '
        Me.nome_conta.HeaderText = "Nome da conta"
        Me.nome_conta.Name = "nome_conta"
        Me.nome_conta.ReadOnly = True
        Me.nome_conta.Width = 500
        '
        'id_estoque
        '
        Me.id_estoque.HeaderText = "id_estoque"
        Me.id_estoque.Name = "id_estoque"
        Me.id_estoque.ReadOnly = True
        Me.id_estoque.Visible = False
        '
        'uct_plano_contas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_adicionar_novo_estoque)
        Me.Controls.Add(Me.btn_verificar_saldo)
        Me.Controls.Add(Me.dgv_plano_contas)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_qtde)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_valor_total)
        Me.Controls.Add(Me.Label6)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "uct_plano_contas"
        Me.Size = New System.Drawing.Size(1147, 768)
        CType(Me.dgv_plano_contas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_valor_total As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_qtde As TextBox
    Friend WithEvents dgv_plano_contas As DataGridView
    Friend WithEvents btn_verificar_saldo As Button
    Friend WithEvents btn_adicionar_novo_estoque As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents nome_conta As DataGridViewTextBoxColumn
    Friend WithEvents id_estoque As DataGridViewTextBoxColumn
End Class
