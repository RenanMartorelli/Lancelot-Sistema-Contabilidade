<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class uct_novo_lançamento
    Inherits System.Windows.Forms.UserControl

    'O UserControl substitui o descarte para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txt_valor_unitario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_confirmar = New System.Windows.Forms.Button()
        Me.cmb_conta_debito = New System.Windows.Forms.ComboBox()
        Me.lbl_debito = New System.Windows.Forms.Label()
        Me.lbl_credito = New System.Windows.Forms.Label()
        Me.cmb_conta_credito = New System.Windows.Forms.ComboBox()
        Me.cmb_comp_debito = New System.Windows.Forms.ComboBox()
        Me.cmb_comp_credito = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_valor_total = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_qtde = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_data = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_valor_unitario
        '
        Me.txt_valor_unitario.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.txt_valor_unitario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_valor_unitario.Font = New System.Drawing.Font("Tw Cen MT", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_valor_unitario.ForeColor = System.Drawing.SystemColors.Menu
        Me.txt_valor_unitario.Location = New System.Drawing.Point(180, 404)
        Me.txt_valor_unitario.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_valor_unitario.Name = "txt_valor_unitario"
        Me.txt_valor_unitario.Size = New System.Drawing.Size(118, 28)
        Me.txt_valor_unitario.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tw Cen MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(111, 185)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Valor Unitário"
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
        Me.Label6.Size = New System.Drawing.Size(318, 37)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Registrar novo lançamento"
        '
        'btn_confirmar
        '
        Me.btn_confirmar.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btn_confirmar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_confirmar.FlatAppearance.BorderSize = 4
        Me.btn_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_confirmar.Font = New System.Drawing.Font("Tw Cen MT", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_confirmar.ForeColor = System.Drawing.Color.White
        Me.btn_confirmar.Location = New System.Drawing.Point(247, 480)
        Me.btn_confirmar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_confirmar.Name = "btn_confirmar"
        Me.btn_confirmar.Size = New System.Drawing.Size(274, 50)
        Me.btn_confirmar.TabIndex = 14
        Me.btn_confirmar.Text = "Lançar!"
        Me.btn_confirmar.UseVisualStyleBackColor = False
        '
        'cmb_conta_debito
        '
        Me.cmb_conta_debito.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.cmb_conta_debito.FormattingEnabled = True
        Me.cmb_conta_debito.IntegralHeight = False
        Me.cmb_conta_debito.ItemHeight = 13
        Me.cmb_conta_debito.Location = New System.Drawing.Point(88, 230)
        Me.cmb_conta_debito.Name = "cmb_conta_debito"
        Me.cmb_conta_debito.Size = New System.Drawing.Size(226, 21)
        Me.cmb_conta_debito.TabIndex = 15
        '
        'lbl_debito
        '
        Me.lbl_debito.AutoSize = True
        Me.lbl_debito.Font = New System.Drawing.Font("Tw Cen MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_debito.Location = New System.Drawing.Point(85, 164)
        Me.lbl_debito.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_debito.Name = "lbl_debito"
        Me.lbl_debito.Size = New System.Drawing.Size(61, 22)
        Me.lbl_debito.TabIndex = 16
        Me.lbl_debito.Text = "Débito"
        '
        'lbl_credito
        '
        Me.lbl_credito.AutoSize = True
        Me.lbl_credito.Font = New System.Drawing.Font("Tw Cen MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_credito.Location = New System.Drawing.Point(500, 164)
        Me.lbl_credito.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_credito.Name = "lbl_credito"
        Me.lbl_credito.Size = New System.Drawing.Size(66, 22)
        Me.lbl_credito.TabIndex = 18
        Me.lbl_credito.Text = "Crédito"
        '
        'cmb_conta_credito
        '
        Me.cmb_conta_credito.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.cmb_conta_credito.FormattingEnabled = True
        Me.cmb_conta_credito.IntegralHeight = False
        Me.cmb_conta_credito.ItemHeight = 13
        Me.cmb_conta_credito.Location = New System.Drawing.Point(503, 230)
        Me.cmb_conta_credito.Name = "cmb_conta_credito"
        Me.cmb_conta_credito.Size = New System.Drawing.Size(226, 21)
        Me.cmb_conta_credito.TabIndex = 17
        '
        'cmb_comp_debito
        '
        Me.cmb_comp_debito.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.cmb_comp_debito.FormattingEnabled = True
        Me.cmb_comp_debito.IntegralHeight = False
        Me.cmb_comp_debito.ItemHeight = 13
        Me.cmb_comp_debito.Location = New System.Drawing.Point(88, 300)
        Me.cmb_comp_debito.Name = "cmb_comp_debito"
        Me.cmb_comp_debito.Size = New System.Drawing.Size(226, 21)
        Me.cmb_comp_debito.TabIndex = 19
        '
        'cmb_comp_credito
        '
        Me.cmb_comp_credito.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.cmb_comp_credito.FormattingEnabled = True
        Me.cmb_comp_credito.IntegralHeight = False
        Me.cmb_comp_credito.ItemHeight = 13
        Me.cmb_comp_credito.Location = New System.Drawing.Point(504, 300)
        Me.cmb_comp_credito.Name = "cmb_comp_credito"
        Me.cmb_comp_credito.Size = New System.Drawing.Size(226, 21)
        Me.cmb_comp_credito.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tw Cen MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(500, 380)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 22)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Total"
        '
        'txt_valor_total
        '
        Me.txt_valor_total.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.txt_valor_total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_valor_total.Font = New System.Drawing.Font("Tw Cen MT", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_valor_total.ForeColor = System.Drawing.SystemColors.Menu
        Me.txt_valor_total.Location = New System.Drawing.Point(504, 404)
        Me.txt_valor_total.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_valor_total.Name = "txt_valor_total"
        Me.txt_valor_total.Size = New System.Drawing.Size(118, 28)
        Me.txt_valor_total.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tw Cen MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(340, 380)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 22)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Quantidade"
        '
        'txt_qtde
        '
        Me.txt_qtde.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.txt_qtde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_qtde.Font = New System.Drawing.Font("Tw Cen MT", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_qtde.ForeColor = System.Drawing.SystemColors.Menu
        Me.txt_qtde.Location = New System.Drawing.Point(344, 404)
        Me.txt_qtde.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_qtde.Name = "txt_qtde"
        Me.txt_qtde.Size = New System.Drawing.Size(118, 28)
        Me.txt_qtde.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tw Cen MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(84, 128)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 22)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Data:"
        '
        'txt_data
        '
        Me.txt_data.Location = New System.Drawing.Point(162, 130)
        Me.txt_data.Mask = "99/99/9999"
        Me.txt_data.Name = "txt_data"
        Me.txt_data.Size = New System.Drawing.Size(67, 20)
        Me.txt_data.SkipLiterals = False
        Me.txt_data.TabIndex = 26
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tw Cen MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(500, 205)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 22)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Conta"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tw Cen MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(85, 205)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 22)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Conta"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tw Cen MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(500, 275)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(119, 22)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Complemento"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tw Cen MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(85, 275)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(119, 22)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Complemento"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.Menu
        Me.Label12.Location = New System.Drawing.Point(614, 62)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(116, 28)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "ID"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tw Cen MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(540, 65)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 22)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Código:"
        '
        'uct_novo_lançamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_data)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_qtde)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_valor_total)
        Me.Controls.Add(Me.cmb_comp_credito)
        Me.Controls.Add(Me.cmb_comp_debito)
        Me.Controls.Add(Me.lbl_credito)
        Me.Controls.Add(Me.cmb_conta_credito)
        Me.Controls.Add(Me.lbl_debito)
        Me.Controls.Add(Me.cmb_conta_debito)
        Me.Controls.Add(Me.btn_confirmar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_valor_unitario)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "uct_novo_lançamento"
        Me.Size = New System.Drawing.Size(860, 624)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_valor_unitario As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_confirmar As Button
    Friend WithEvents cmb_conta_debito As ComboBox
    Friend WithEvents lbl_debito As Label
    Friend WithEvents lbl_credito As Label
    Friend WithEvents cmb_conta_credito As ComboBox
    Friend WithEvents cmb_comp_debito As ComboBox
    Friend WithEvents cmb_comp_credito As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_valor_total As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_qtde As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_data As MaskedTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
End Class
