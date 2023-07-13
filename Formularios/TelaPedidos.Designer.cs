namespace ProjetoCSGrupo
{
    partial class TelaPedidos
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStatusVenda = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTotalVenda = new System.Windows.Forms.Label();
            this.gbItensVenda = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.txtNomeProduto = new System.Windows.Forms.ComboBox();
            this.dgvItensVenda = new System.Windows.Forms.DataGridView();
            this.dgvID_Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvValorProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTotalProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotalProduto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtValorProduto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuantidadeProduto = new System.Windows.Forms.TextBox();
            this.txtDataVenda = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtID_Venda = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.ComboBox();
            this.gbItensVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label4.Location = new System.Drawing.Point(213, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 167;
            this.label4.Text = "STATUS DA VENDA";
            // 
            // txtStatusVenda
            // 
            this.txtStatusVenda.Enabled = false;
            this.txtStatusVenda.Location = new System.Drawing.Point(217, 138);
            this.txtStatusVenda.Name = "txtStatusVenda";
            this.txtStatusVenda.Size = new System.Drawing.Size(125, 20);
            this.txtStatusVenda.TabIndex = 166;
            this.txtStatusVenda.Text = "Ativo";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnCadastrar.ForeColor = System.Drawing.Color.Transparent;
            this.btnCadastrar.Location = new System.Drawing.Point(124, 427);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(88, 40);
            this.btnCadastrar.TabIndex = 161;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Visible = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Montserrat", 12.75F);
            this.btnNovo.ForeColor = System.Drawing.Color.Transparent;
            this.btnNovo.Location = new System.Drawing.Point(30, 427);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(88, 40);
            this.btnNovo.TabIndex = 160;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label12.Location = new System.Drawing.Point(639, 418);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 20);
            this.label12.TabIndex = 159;
            this.label12.Text = "TOTAL DA VENDA";
            // 
            // lblTotalVenda
            // 
            this.lblTotalVenda.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTotalVenda.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVenda.Location = new System.Drawing.Point(214, 438);
            this.lblTotalVenda.Name = "lblTotalVenda";
            this.lblTotalVenda.Size = new System.Drawing.Size(554, 20);
            this.lblTotalVenda.TabIndex = 158;
            this.lblTotalVenda.Text = "R$ 0,00";
            this.lblTotalVenda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbItensVenda
            // 
            this.gbItensVenda.Controls.Add(this.button1);
            this.gbItensVenda.Controls.Add(this.btnRemover);
            this.gbItensVenda.Controls.Add(this.btnAdicionar);
            this.gbItensVenda.Controls.Add(this.txtNomeProduto);
            this.gbItensVenda.Controls.Add(this.dgvItensVenda);
            this.gbItensVenda.Controls.Add(this.label10);
            this.gbItensVenda.Controls.Add(this.label9);
            this.gbItensVenda.Controls.Add(this.txtTotalProduto);
            this.gbItensVenda.Controls.Add(this.label7);
            this.gbItensVenda.Controls.Add(this.txtValorProduto);
            this.gbItensVenda.Controls.Add(this.label5);
            this.gbItensVenda.Controls.Add(this.txtQuantidadeProduto);
            this.gbItensVenda.Location = new System.Drawing.Point(19, 164);
            this.gbItensVenda.Name = "gbItensVenda";
            this.gbItensVenda.Size = new System.Drawing.Size(752, 251);
            this.gbItensVenda.TabIndex = 157;
            this.gbItensVenda.TabStop = false;
            this.gbItensVenda.Text = "Itens da Venda";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Image = global::ProjetoCSGrupo.Properties.Resources.reload;
            this.button1.Location = new System.Drawing.Point(17, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 29);
            this.button1.TabIndex = 174;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.Transparent;
            this.btnRemover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemover.FlatAppearance.BorderSize = 0;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRemover.Image = global::ProjetoCSGrupo.Properties.Resources.icons8_delete_bin_30px_1;
            this.btnRemover.Location = new System.Drawing.Point(715, 214);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(31, 31);
            this.btnRemover.TabIndex = 173;
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.Transparent;
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdicionar.Image = global::ProjetoCSGrupo.Properties.Resources.icons8_add_30px;
            this.btnAdicionar.Location = new System.Drawing.Point(682, 215);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(31, 31);
            this.btnAdicionar.TabIndex = 172;
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtNomeProduto.FormattingEnabled = true;
            this.txtNomeProduto.Location = new System.Drawing.Point(17, 36);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(130, 21);
            this.txtNomeProduto.TabIndex = 149;
            this.txtNomeProduto.SelectedIndexChanged += new System.EventHandler(this.txtNomeProduto_SelectedIndexChanged);
            // 
            // dgvItensVenda
            // 
            this.dgvItensVenda.AllowUserToAddRows = false;
            this.dgvItensVenda.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItensVenda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvItensVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItensVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvID_Produto,
            this.dgvNomeProduto,
            this.dgvQuantidade,
            this.dgvValorProduto,
            this.dgvTotalProduto});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItensVenda.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvItensVenda.EnableHeadersVisualStyles = false;
            this.dgvItensVenda.Location = new System.Drawing.Point(17, 62);
            this.dgvItensVenda.MultiSelect = false;
            this.dgvItensVenda.Name = "dgvItensVenda";
            this.dgvItensVenda.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItensVenda.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvItensVenda.RowHeadersVisible = false;
            this.dgvItensVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItensVenda.Size = new System.Drawing.Size(729, 146);
            this.dgvItensVenda.TabIndex = 148;
            // 
            // dgvID_Produto
            // 
            this.dgvID_Produto.HeaderText = "ID Produto";
            this.dgvID_Produto.Name = "dgvID_Produto";
            this.dgvID_Produto.ReadOnly = true;
            // 
            // dgvNomeProduto
            // 
            this.dgvNomeProduto.HeaderText = "Nome do Produto";
            this.dgvNomeProduto.Name = "dgvNomeProduto";
            this.dgvNomeProduto.ReadOnly = true;
            this.dgvNomeProduto.Width = 200;
            // 
            // dgvQuantidade
            // 
            this.dgvQuantidade.HeaderText = "Quantidade";
            this.dgvQuantidade.Name = "dgvQuantidade";
            this.dgvQuantidade.ReadOnly = true;
            // 
            // dgvValorProduto
            // 
            this.dgvValorProduto.HeaderText = "Valor Unitário";
            this.dgvValorProduto.Name = "dgvValorProduto";
            this.dgvValorProduto.ReadOnly = true;
            this.dgvValorProduto.Width = 150;
            // 
            // dgvTotalProduto
            // 
            this.dgvTotalProduto.HeaderText = "Valor Total";
            this.dgvTotalProduto.Name = "dgvTotalProduto";
            this.dgvTotalProduto.ReadOnly = true;
            this.dgvTotalProduto.Width = 175;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.25F);
            this.label10.Location = new System.Drawing.Point(14, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 17);
            this.label10.TabIndex = 147;
            this.label10.Text = "PRODUTO";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.25F);
            this.label9.Location = new System.Drawing.Point(604, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 17);
            this.label9.TabIndex = 145;
            this.label9.Text = "VALOR TOTAL";
            // 
            // txtTotalProduto
            // 
            this.txtTotalProduto.Enabled = false;
            this.txtTotalProduto.Location = new System.Drawing.Point(607, 36);
            this.txtTotalProduto.Name = "txtTotalProduto";
            this.txtTotalProduto.Size = new System.Drawing.Size(130, 20);
            this.txtTotalProduto.TabIndex = 144;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.25F);
            this.label7.Location = new System.Drawing.Point(451, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 17);
            this.label7.TabIndex = 143;
            this.label7.Text = "VALOR UNITÁRIO";
            // 
            // txtValorProduto
            // 
            this.txtValorProduto.Enabled = false;
            this.txtValorProduto.Location = new System.Drawing.Point(454, 36);
            this.txtValorProduto.Name = "txtValorProduto";
            this.txtValorProduto.Size = new System.Drawing.Size(130, 20);
            this.txtValorProduto.TabIndex = 142;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.25F);
            this.label5.Location = new System.Drawing.Point(161, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 141;
            this.label5.Text = "QUANTIDADE";
            // 
            // txtQuantidadeProduto
            // 
            this.txtQuantidadeProduto.Enabled = false;
            this.txtQuantidadeProduto.Location = new System.Drawing.Point(164, 37);
            this.txtQuantidadeProduto.Name = "txtQuantidadeProduto";
            this.txtQuantidadeProduto.Size = new System.Drawing.Size(130, 20);
            this.txtQuantidadeProduto.TabIndex = 140;
            this.txtQuantidadeProduto.TextChanged += new System.EventHandler(this.txtQuantidadeProduto_TextChanged_1);
            this.txtQuantidadeProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidadeProduto_KeyPress);
            // 
            // txtDataVenda
            // 
            this.txtDataVenda.Enabled = false;
            this.txtDataVenda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataVenda.Location = new System.Drawing.Point(217, 88);
            this.txtDataVenda.Name = "txtDataVenda";
            this.txtDataVenda.Size = new System.Drawing.Size(123, 20);
            this.txtDataVenda.TabIndex = 156;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label8.Location = new System.Drawing.Point(213, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 20);
            this.label8.TabIndex = 155;
            this.label8.Text = "DATA DA VENDA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label6.Location = new System.Drawing.Point(26, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 154;
            this.label6.Text = "ID_VENDA";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label11.Location = new System.Drawing.Point(27, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 20);
            this.label11.TabIndex = 153;
            this.label11.Text = "NOME";
            // 
            // txtID_Venda
            // 
            this.txtID_Venda.Enabled = false;
            this.txtID_Venda.Location = new System.Drawing.Point(30, 138);
            this.txtID_Venda.Name = "txtID_Venda";
            this.txtID_Venda.Size = new System.Drawing.Size(130, 20);
            this.txtID_Venda.TabIndex = 152;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.panel1.Location = new System.Drawing.Point(32, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 1);
            this.panel1.TabIndex = 151;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.lblTitulo.Location = new System.Drawing.Point(24, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(295, 33);
            this.lblTitulo.TabIndex = 150;
            this.lblTitulo.Text = "Cadastro de Pedidos";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtNomeCliente.Enabled = false;
            this.txtNomeCliente.FormattingEnabled = true;
            this.txtNomeCliente.Items.AddRange(new object[] {
            "MESA 1",
            "MESA 2",
            "MESA 3",
            "MESA 4",
            "MESA 5",
            "MESA 6",
            "MESA 7",
            "MESA 8",
            "MESA 9",
            "MESA 10",
            "MESA 11",
            "MESA 12",
            "MESA 13",
            "MESA 14",
            "MESA 15",
            "MESA 16",
            "MESA 17",
            "MESA 18",
            "MESA 19",
            "MESA 20"});
            this.txtNomeCliente.Location = new System.Drawing.Point(30, 87);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(136, 21);
            this.txtNomeCliente.TabIndex = 168;
            this.txtNomeCliente.SelectedIndexChanged += new System.EventHandler(this.txtNomeCliente_SelectedIndexChanged);
            // 
            // TelaPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtStatusVenda);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblTotalVenda);
            this.Controls.Add(this.gbItensVenda);
            this.Controls.Add(this.txtDataVenda);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtID_Venda);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "TelaPedidos";
            this.Size = new System.Drawing.Size(791, 481);
            this.Load += new System.EventHandler(this.TelaPedidos_Load);
            this.gbItensVenda.ResumeLayout(false);
            this.gbItensVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStatusVenda;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTotalVenda;
        private System.Windows.Forms.GroupBox gbItensVenda;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ComboBox txtNomeProduto;
        private System.Windows.Forms.DataGridView dgvItensVenda;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTotalProduto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtValorProduto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQuantidadeProduto;
        private System.Windows.Forms.DateTimePicker txtDataVenda;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtID_Venda;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID_Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvValorProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTotalProduto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox txtNomeCliente;
    }
}
