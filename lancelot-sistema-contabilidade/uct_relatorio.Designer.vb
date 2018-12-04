<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uct_relatorio
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgv_vendas_com_receita = New System.Windows.Forms.DataGridView()
        Me.rdb_lancamentos_banco = New System.Windows.Forms.RadioButton()
        Me.rdb_vendas_com_receita = New System.Windows.Forms.RadioButton()
        Me.cmb_produtos = New System.Windows.Forms.ComboBox()
        Me.dgv_lancamentos_banco = New System.Windows.Forms.DataGridView()
        Me.rdb_produtos_em_estoque = New System.Windows.Forms.RadioButton()
        Me.dgv_produtos_em_estoque = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.data_lancamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nome_produto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantidade_vendida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valor_venda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.custo_total_prod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valor_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.receita = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_vendas_com_receita, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_lancamentos_banco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_produtos_em_estoque, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Tw Cen MT", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(88, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Padding = New System.Windows.Forms.Padding(4)
        Me.Label6.Size = New System.Drawing.Size(150, 47)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Relatório"
        '
        'dgv_vendas_com_receita
        '
        Me.dgv_vendas_com_receita.AllowUserToAddRows = False
        Me.dgv_vendas_com_receita.AllowUserToDeleteRows = False
        Me.dgv_vendas_com_receita.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tw Cen MT", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(100, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_vendas_com_receita.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_vendas_com_receita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_vendas_com_receita.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.data_lancamento, Me.nome_produto, Me.quantidade_vendida, Me.valor_venda, Me.custo_total_prod, Me.valor_total, Me.receita})
        Me.dgv_vendas_com_receita.Location = New System.Drawing.Point(95, 209)
        Me.dgv_vendas_com_receita.Name = "dgv_vendas_com_receita"
        Me.dgv_vendas_com_receita.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tw Cen MT", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_vendas_com_receita.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgv_vendas_com_receita.RowHeadersVisible = False
        Me.dgv_vendas_com_receita.RowTemplate.Height = 24
        Me.dgv_vendas_com_receita.Size = New System.Drawing.Size(928, 415)
        Me.dgv_vendas_com_receita.TabIndex = 25
        Me.dgv_vendas_com_receita.Visible = False
        '
        'rdb_lancamentos_banco
        '
        Me.rdb_lancamentos_banco.AutoSize = True
        Me.rdb_lancamentos_banco.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb_lancamentos_banco.Location = New System.Drawing.Point(317, 63)
        Me.rdb_lancamentos_banco.Name = "rdb_lancamentos_banco"
        Me.rdb_lancamentos_banco.Size = New System.Drawing.Size(200, 27)
        Me.rdb_lancamentos_banco.TabIndex = 26
        Me.rdb_lancamentos_banco.TabStop = True
        Me.rdb_lancamentos_banco.Text = "Lançamentos banco"
        Me.rdb_lancamentos_banco.UseVisualStyleBackColor = True
        '
        'rdb_vendas_com_receita
        '
        Me.rdb_vendas_com_receita.AutoSize = True
        Me.rdb_vendas_com_receita.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb_vendas_com_receita.Location = New System.Drawing.Point(859, 63)
        Me.rdb_vendas_com_receita.Name = "rdb_vendas_com_receita"
        Me.rdb_vendas_com_receita.Size = New System.Drawing.Size(205, 27)
        Me.rdb_vendas_com_receita.TabIndex = 27
        Me.rdb_vendas_com_receita.TabStop = True
        Me.rdb_vendas_com_receita.Text = "Vendas com receitas"
        Me.rdb_vendas_com_receita.UseVisualStyleBackColor = True
        '
        'cmb_produtos
        '
        Me.cmb_produtos.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.cmb_produtos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_produtos.Font = New System.Drawing.Font("Tw Cen MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_produtos.ForeColor = System.Drawing.SystemColors.Info
        Me.cmb_produtos.FormattingEnabled = True
        Me.cmb_produtos.Location = New System.Drawing.Point(608, 128)
        Me.cmb_produtos.Name = "cmb_produtos"
        Me.cmb_produtos.Size = New System.Drawing.Size(444, 35)
        Me.cmb_produtos.TabIndex = 28
        Me.cmb_produtos.Visible = False
        '
        'dgv_lancamentos_banco
        '
        Me.dgv_lancamentos_banco.AllowUserToAddRows = False
        Me.dgv_lancamentos_banco.AllowUserToDeleteRows = False
        Me.dgv_lancamentos_banco.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Tw Cen MT", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(100, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_lancamentos_banco.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgv_lancamentos_banco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_lancamentos_banco.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn3})
        Me.dgv_lancamentos_banco.Location = New System.Drawing.Point(95, 209)
        Me.dgv_lancamentos_banco.Name = "dgv_lancamentos_banco"
        Me.dgv_lancamentos_banco.ReadOnly = True
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Tw Cen MT", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_lancamentos_banco.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgv_lancamentos_banco.RowHeadersVisible = False
        Me.dgv_lancamentos_banco.RowTemplate.Height = 24
        Me.dgv_lancamentos_banco.Size = New System.Drawing.Size(928, 415)
        Me.dgv_lancamentos_banco.TabIndex = 29
        Me.dgv_lancamentos_banco.Visible = False
        '
        'rdb_produtos_em_estoque
        '
        Me.rdb_produtos_em_estoque.AutoSize = True
        Me.rdb_produtos_em_estoque.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb_produtos_em_estoque.Location = New System.Drawing.Point(608, 63)
        Me.rdb_produtos_em_estoque.Name = "rdb_produtos_em_estoque"
        Me.rdb_produtos_em_estoque.Size = New System.Drawing.Size(209, 27)
        Me.rdb_produtos_em_estoque.TabIndex = 30
        Me.rdb_produtos_em_estoque.TabStop = True
        Me.rdb_produtos_em_estoque.Text = "Produtos em estoque"
        Me.rdb_produtos_em_estoque.UseVisualStyleBackColor = True
        '
        'dgv_produtos_em_estoque
        '
        Me.dgv_produtos_em_estoque.AllowUserToAddRows = False
        Me.dgv_produtos_em_estoque.AllowUserToDeleteRows = False
        Me.dgv_produtos_em_estoque.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Tw Cen MT", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(100, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_produtos_em_estoque.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgv_produtos_em_estoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_produtos_em_estoque.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.dgv_produtos_em_estoque.Location = New System.Drawing.Point(95, 209)
        Me.dgv_produtos_em_estoque.Name = "dgv_produtos_em_estoque"
        Me.dgv_produtos_em_estoque.ReadOnly = True
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Tw Cen MT", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_produtos_em_estoque.RowHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.dgv_produtos_em_estoque.RowHeadersVisible = False
        Me.dgv_produtos_em_estoque.RowTemplate.Height = 24
        Me.dgv_produtos_em_estoque.Size = New System.Drawing.Size(928, 415)
        Me.dgv_produtos_em_estoque.TabIndex = 31
        Me.dgv_produtos_em_estoque.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewTextBoxColumn6.HeaderText = "Data"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridViewTextBoxColumn7.HeaderText = "Nome do produto"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 200
        '
        'DataGridViewTextBoxColumn8
        '
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle14
        Me.DataGridViewTextBoxColumn8.HeaderText = "Quant. em estoque"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 75
        '
        'DataGridViewTextBoxColumn9
        '
        DataGridViewCellStyle15.Format = "N2"
        DataGridViewCellStyle15.NullValue = Nothing
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle15
        Me.DataGridViewTextBoxColumn9.HeaderText = "Valor unitário"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 75
        '
        'DataGridViewTextBoxColumn10
        '
        DataGridViewCellStyle16.Format = "N2"
        DataGridViewCellStyle16.NullValue = Nothing
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle16
        Me.DataGridViewTextBoxColumn10.HeaderText = "Valor total"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Data"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nome do banco"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 300
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "crédito/débito"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        DataGridViewCellStyle9.Format = "N2"
        DataGridViewCellStyle9.NullValue = Nothing
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn3.HeaderText = "Valor lançamento"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 75
        '
        'data_lancamento
        '
        Me.data_lancamento.HeaderText = "Data"
        Me.data_lancamento.Name = "data_lancamento"
        Me.data_lancamento.ReadOnly = True
        '
        'nome_produto
        '
        Me.nome_produto.HeaderText = "Nome do produto"
        Me.nome_produto.Name = "nome_produto"
        Me.nome_produto.ReadOnly = True
        Me.nome_produto.Width = 200
        '
        'quantidade_vendida
        '
        Me.quantidade_vendida.HeaderText = "Quant. Vendida"
        Me.quantidade_vendida.Name = "quantidade_vendida"
        Me.quantidade_vendida.ReadOnly = True
        Me.quantidade_vendida.Width = 75
        '
        'valor_venda
        '
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.valor_venda.DefaultCellStyle = DataGridViewCellStyle2
        Me.valor_venda.HeaderText = "Valor unit. venda"
        Me.valor_venda.Name = "valor_venda"
        Me.valor_venda.ReadOnly = True
        Me.valor_venda.Width = 75
        '
        'custo_total_prod
        '
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.custo_total_prod.DefaultCellStyle = DataGridViewCellStyle3
        Me.custo_total_prod.HeaderText = "CMV"
        Me.custo_total_prod.Name = "custo_total_prod"
        Me.custo_total_prod.ReadOnly = True
        '
        'valor_total
        '
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.valor_total.DefaultCellStyle = DataGridViewCellStyle4
        Me.valor_total.HeaderText = "Valor total"
        Me.valor_total.Name = "valor_total"
        Me.valor_total.ReadOnly = True
        '
        'receita
        '
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.receita.DefaultCellStyle = DataGridViewCellStyle5
        Me.receita.HeaderText = "Receita"
        Me.receita.Name = "receita"
        Me.receita.ReadOnly = True
        '
        'uct_relatorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.Controls.Add(Me.dgv_produtos_em_estoque)
        Me.Controls.Add(Me.rdb_produtos_em_estoque)
        Me.Controls.Add(Me.dgv_lancamentos_banco)
        Me.Controls.Add(Me.cmb_produtos)
        Me.Controls.Add(Me.rdb_vendas_com_receita)
        Me.Controls.Add(Me.rdb_lancamentos_banco)
        Me.Controls.Add(Me.dgv_vendas_com_receita)
        Me.Controls.Add(Me.Label6)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "uct_relatorio"
        Me.Size = New System.Drawing.Size(1147, 768)
        CType(Me.dgv_vendas_com_receita, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_lancamentos_banco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_produtos_em_estoque, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As Label
    Friend WithEvents dgv_vendas_com_receita As DataGridView
    Friend WithEvents rdb_lancamentos_banco As RadioButton
    Friend WithEvents rdb_vendas_com_receita As RadioButton
    Friend WithEvents cmb_produtos As ComboBox
    Friend WithEvents dgv_lancamentos_banco As DataGridView
    Friend WithEvents rdb_produtos_em_estoque As RadioButton
    Friend WithEvents dgv_produtos_em_estoque As DataGridView
    Friend WithEvents data_lancamento As DataGridViewTextBoxColumn
    Friend WithEvents nome_produto As DataGridViewTextBoxColumn
    Friend WithEvents quantidade_vendida As DataGridViewTextBoxColumn
    Friend WithEvents valor_venda As DataGridViewTextBoxColumn
    Friend WithEvents custo_total_prod As DataGridViewTextBoxColumn
    Friend WithEvents valor_total As DataGridViewTextBoxColumn
    Friend WithEvents receita As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
End Class
