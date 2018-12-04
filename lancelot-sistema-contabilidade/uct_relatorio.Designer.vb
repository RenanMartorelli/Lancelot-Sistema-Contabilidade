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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgv_relatório = New System.Windows.Forms.DataGridView()
        Me.data_lancamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nome_produto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantidade_vendida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valor_venda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valor_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rdb_venda_bruta = New System.Windows.Forms.RadioButton()
        Me.rdb_vendas_lucro = New System.Windows.Forms.RadioButton()
        Me.cmb_produtos = New System.Windows.Forms.ComboBox()
        CType(Me.dgv_relatório, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'dgv_relatório
        '
        Me.dgv_relatório.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_relatório.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_relatório.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.data_lancamento, Me.nome_produto, Me.quantidade_vendida, Me.valor_venda, Me.valor_total})
        Me.dgv_relatório.Location = New System.Drawing.Point(95, 222)
        Me.dgv_relatório.Name = "dgv_relatório"
        Me.dgv_relatório.RowTemplate.Height = 24
        Me.dgv_relatório.Size = New System.Drawing.Size(928, 415)
        Me.dgv_relatório.TabIndex = 25
        '
        'data_lancamento
        '
        Me.data_lancamento.HeaderText = "Data"
        Me.data_lancamento.Name = "data_lancamento"
        '
        'nome_produto
        '
        Me.nome_produto.HeaderText = "Nome do produto"
        Me.nome_produto.Name = "nome_produto"
        Me.nome_produto.Width = 300
        '
        'quantidade_vendida
        '
        Me.quantidade_vendida.HeaderText = "Quant. Vendida"
        Me.quantidade_vendida.Name = "quantidade_vendida"
        Me.quantidade_vendida.Width = 75
        '
        'valor_venda
        '
        Me.valor_venda.HeaderText = "Valor venda"
        Me.valor_venda.Name = "valor_venda"
        Me.valor_venda.Width = 75
        '
        'valor_total
        '
        Me.valor_total.HeaderText = "Valor total"
        Me.valor_total.Name = "valor_total"
        '
        'rdb_venda_bruta
        '
        Me.rdb_venda_bruta.AutoSize = True
        Me.rdb_venda_bruta.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb_venda_bruta.Location = New System.Drawing.Point(407, 65)
        Me.rdb_venda_bruta.Name = "rdb_venda_bruta"
        Me.rdb_venda_bruta.Size = New System.Drawing.Size(154, 27)
        Me.rdb_venda_bruta.TabIndex = 26
        Me.rdb_venda_bruta.TabStop = True
        Me.rdb_venda_bruta.Text = "Vendas brutas"
        Me.rdb_venda_bruta.UseVisualStyleBackColor = True
        '
        'rdb_vendas_lucro
        '
        Me.rdb_vendas_lucro.AutoSize = True
        Me.rdb_vendas_lucro.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb_vendas_lucro.Location = New System.Drawing.Point(644, 65)
        Me.rdb_vendas_lucro.Name = "rdb_vendas_lucro"
        Me.rdb_vendas_lucro.Size = New System.Drawing.Size(191, 27)
        Me.rdb_vendas_lucro.TabIndex = 27
        Me.rdb_vendas_lucro.TabStop = True
        Me.rdb_vendas_lucro.Text = "Vendas com lucros"
        Me.rdb_vendas_lucro.UseVisualStyleBackColor = True
        '
        'cmb_produtos
        '
        Me.cmb_produtos.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.cmb_produtos.Font = New System.Drawing.Font("Tw Cen MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_produtos.ForeColor = System.Drawing.SystemColors.Info
        Me.cmb_produtos.FormattingEnabled = True
        Me.cmb_produtos.Location = New System.Drawing.Point(397, 128)
        Me.cmb_produtos.Name = "cmb_produtos"
        Me.cmb_produtos.Size = New System.Drawing.Size(438, 35)
        Me.cmb_produtos.TabIndex = 28
        '
        'uct_relatorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.Controls.Add(Me.cmb_produtos)
        Me.Controls.Add(Me.rdb_vendas_lucro)
        Me.Controls.Add(Me.rdb_venda_bruta)
        Me.Controls.Add(Me.dgv_relatório)
        Me.Controls.Add(Me.Label6)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "uct_relatorio"
        Me.Size = New System.Drawing.Size(1147, 768)
        CType(Me.dgv_relatório, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As Label
    Friend WithEvents dgv_relatório As DataGridView
    Friend WithEvents rdb_venda_bruta As RadioButton
    Friend WithEvents rdb_vendas_lucro As RadioButton
    Friend WithEvents cmb_produtos As ComboBox
    Friend WithEvents data_lancamento As DataGridViewTextBoxColumn
    Friend WithEvents nome_produto As DataGridViewTextBoxColumn
    Friend WithEvents quantidade_vendida As DataGridViewTextBoxColumn
    Friend WithEvents valor_venda As DataGridViewTextBoxColumn
    Friend WithEvents valor_total As DataGridViewTextBoxColumn
End Class
