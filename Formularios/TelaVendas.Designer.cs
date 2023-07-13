namespace ProjetoCSGrupo
{
    partial class TelaVendas
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtStatusVenda = new System.Windows.Forms.ComboBox();
            this.btnApagar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTotalVenda = new System.Windows.Forms.Label();
            this.gbItensVenda = new System.Windows.Forms.GroupBox();
            this.btnAtualizarProdutos = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.txtNomeProduto = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotalProduto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtValorProduto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuantidadeProduto = new System.Windows.Forms.TextBox();
            this.dgvItensVenda = new System.Windows.Forms.DataGridView();
            this.txtDataVenda = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtID_Venda = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvVendas = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnAtualizarVendas = new System.Windows.Forms.Button();
            this.txtNomeCliente = new System.Windows.Forms.ComboBox();
            this.gbItensVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtStatusVenda
            // 
            this.txtStatusVenda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtStatusVenda.Enabled = false;
            this.txtStatusVenda.FormattingEnabled = true;
            this.txtStatusVenda.Items.AddRange(new object[] {
            "Ativo",
            "Cancelado",
            "Finalizado"});
            this.txtStatusVenda.Location = new System.Drawing.Point(167, 122);
            this.txtStatusVenda.Name = "txtStatusVenda";
            this.txtStatusVenda.Size = new System.Drawing.Size(123, 21);
            this.txtStatusVenda.TabIndex = 192;
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.DarkRed;
            this.btnApagar.FlatAppearance.BorderSize = 0;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagar.Font = new System.Drawing.Font("Montserrat", 12.75F);
            this.btnApagar.ForeColor = System.Drawing.Color.Transparent;
            this.btnApagar.Location = new System.Drawing.Point(202, 420);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(88, 40);
            this.btnApagar.TabIndex = 190;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Visible = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label4.Location = new System.Drawing.Point(163, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 186;
            this.label4.Text = "STATUS DA VENDA";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Montserrat", 12.75F);
            this.btnSalvar.ForeColor = System.Drawing.Color.Transparent;
            this.btnSalvar.Location = new System.Drawing.Point(108, 420);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(88, 40);
            this.btnSalvar.TabIndex = 189;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Visible = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Goldenrod;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Montserrat", 12.75F);
            this.btnEditar.ForeColor = System.Drawing.Color.Transparent;
            this.btnEditar.Location = new System.Drawing.Point(15, 420);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(88, 40);
            this.btnEditar.TabIndex = 188;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label12.Location = new System.Drawing.Point(417, 418);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 20);
            this.label12.TabIndex = 181;
            this.label12.Text = "TOTAL DA VENDA";
            // 
            // lblTotalVenda
            // 
            this.lblTotalVenda.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTotalVenda.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVenda.Location = new System.Drawing.Point(321, 440);
            this.lblTotalVenda.Name = "lblTotalVenda";
            this.lblTotalVenda.Size = new System.Drawing.Size(216, 20);
            this.lblTotalVenda.TabIndex = 180;
            this.lblTotalVenda.Text = "R$ 0,00";
            this.lblTotalVenda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbItensVenda
            // 
            this.gbItensVenda.Controls.Add(this.btnAtualizarProdutos);
            this.gbItensVenda.Controls.Add(this.btnRemover);
            this.gbItensVenda.Controls.Add(this.btnAdicionar);
            this.gbItensVenda.Controls.Add(this.txtNomeProduto);
            this.gbItensVenda.Controls.Add(this.label10);
            this.gbItensVenda.Controls.Add(this.label9);
            this.gbItensVenda.Controls.Add(this.txtTotalProduto);
            this.gbItensVenda.Controls.Add(this.label7);
            this.gbItensVenda.Controls.Add(this.txtValorProduto);
            this.gbItensVenda.Controls.Add(this.label5);
            this.gbItensVenda.Controls.Add(this.txtQuantidadeProduto);
            this.gbItensVenda.Controls.Add(this.dgvItensVenda);
            this.gbItensVenda.Location = new System.Drawing.Point(3, 159);
            this.gbItensVenda.Name = "gbItensVenda";
            this.gbItensVenda.Size = new System.Drawing.Size(546, 237);
            this.gbItensVenda.TabIndex = 179;
            this.gbItensVenda.TabStop = false;
            this.gbItensVenda.Text = "Itens da Venda";
            // 
            // btnAtualizarProdutos
            // 
            this.btnAtualizarProdutos.BackColor = System.Drawing.Color.Transparent;
            this.btnAtualizarProdutos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizarProdutos.FlatAppearance.BorderSize = 0;
            this.btnAtualizarProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizarProdutos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAtualizarProdutos.Image = global::ProjetoCSGrupo.Properties.Resources.reload;
            this.btnAtualizarProdutos.Location = new System.Drawing.Point(17, 202);
            this.btnAtualizarProdutos.Name = "btnAtualizarProdutos";
            this.btnAtualizarProdutos.Size = new System.Drawing.Size(31, 29);
            this.btnAtualizarProdutos.TabIndex = 193;
            this.btnAtualizarProdutos.UseVisualStyleBackColor = false;
            this.btnAtualizarProdutos.Click += new System.EventHandler(this.btnAtualizarProdutos_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.Transparent;
            this.btnRemover.FlatAppearance.BorderSize = 0;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRemover.Image = global::ProjetoCSGrupo.Properties.Resources.icons8_delete_bin_30px_1;
            this.btnRemover.Location = new System.Drawing.Point(503, 200);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(31, 31);
            this.btnRemover.TabIndex = 171;
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.Transparent;
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdicionar.Image = global::ProjetoCSGrupo.Properties.Resources.icons8_add_30px;
            this.btnAdicionar.Location = new System.Drawing.Point(466, 202);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(31, 31);
            this.btnAdicionar.TabIndex = 170;
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtNomeProduto.Enabled = false;
            this.txtNomeProduto.FormattingEnabled = true;
            this.txtNomeProduto.Location = new System.Drawing.Point(17, 36);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(130, 21);
            this.txtNomeProduto.TabIndex = 149;
            this.txtNomeProduto.SelectedIndexChanged += new System.EventHandler(this.txtNomeProduto_SelectedIndexChanged);
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
            this.label9.Location = new System.Drawing.Point(430, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 17);
            this.label9.TabIndex = 145;
            this.label9.Text = "VALOR TOTAL";
            // 
            // txtTotalProduto
            // 
            this.txtTotalProduto.Enabled = false;
            this.txtTotalProduto.Location = new System.Drawing.Point(433, 37);
            this.txtTotalProduto.Name = "txtTotalProduto";
            this.txtTotalProduto.Size = new System.Drawing.Size(101, 20);
            this.txtTotalProduto.TabIndex = 144;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.25F);
            this.label7.Location = new System.Drawing.Point(312, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 17);
            this.label7.TabIndex = 143;
            this.label7.Text = "VALOR UNITÁRIO";
            // 
            // txtValorProduto
            // 
            this.txtValorProduto.Enabled = false;
            this.txtValorProduto.Location = new System.Drawing.Point(316, 36);
            this.txtValorProduto.Name = "txtValorProduto";
            this.txtValorProduto.Size = new System.Drawing.Size(108, 20);
            this.txtValorProduto.TabIndex = 142;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.25F);
            this.label5.Location = new System.Drawing.Point(150, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 141;
            this.label5.Text = "QUANTIDADE";
            // 
            // txtQuantidadeProduto
            // 
            this.txtQuantidadeProduto.Enabled = false;
            this.txtQuantidadeProduto.Location = new System.Drawing.Point(153, 36);
            this.txtQuantidadeProduto.Name = "txtQuantidadeProduto";
            this.txtQuantidadeProduto.Size = new System.Drawing.Size(87, 20);
            this.txtQuantidadeProduto.TabIndex = 140;
            this.txtQuantidadeProduto.TextChanged += new System.EventHandler(this.txtQuantidadeProduto_TextChanged);
            // 
            // dgvItensVenda
            // 
            this.dgvItensVenda.AllowUserToAddRows = false;
            this.dgvItensVenda.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.dgvItensVenda.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItensVenda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvItensVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItensVenda.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvItensVenda.EnableHeadersVisualStyles = false;
            this.dgvItensVenda.Location = new System.Drawing.Point(17, 62);
            this.dgvItensVenda.MultiSelect = false;
            this.dgvItensVenda.Name = "dgvItensVenda";
            this.dgvItensVenda.ReadOnly = true;
            this.dgvItensVenda.RowHeadersVisible = false;
            this.dgvItensVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItensVenda.Size = new System.Drawing.Size(517, 135);
            this.dgvItensVenda.TabIndex = 198;
            // 
            // txtDataVenda
            // 
            this.txtDataVenda.Enabled = false;
            this.txtDataVenda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataVenda.Location = new System.Drawing.Point(167, 73);
            this.txtDataVenda.Name = "txtDataVenda";
            this.txtDataVenda.Size = new System.Drawing.Size(123, 20);
            this.txtDataVenda.TabIndex = 178;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label8.Location = new System.Drawing.Point(163, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 20);
            this.label8.TabIndex = 177;
            this.label8.Text = "DATA DA VENDA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label6.Location = new System.Drawing.Point(16, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 176;
            this.label6.Text = "ID_VENDA";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label11.Location = new System.Drawing.Point(16, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 20);
            this.label11.TabIndex = 175;
            this.label11.Text = "NOME";
            // 
            // txtID_Venda
            // 
            this.txtID_Venda.Enabled = false;
            this.txtID_Venda.Location = new System.Drawing.Point(20, 121);
            this.txtID_Venda.Name = "txtID_Venda";
            this.txtID_Venda.Size = new System.Drawing.Size(132, 20);
            this.txtID_Venda.TabIndex = 174;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.panel1.Location = new System.Drawing.Point(16, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 1);
            this.panel1.TabIndex = 173;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.lblTitulo.Location = new System.Drawing.Point(8, 8);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(270, 33);
            this.lblTitulo.TabIndex = 172;
            this.lblTitulo.Text = "Registro de Vendas";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(26)))), ((int)(((byte)(24)))));
            this.panel3.Location = new System.Drawing.Point(558, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(6, 485);
            this.panel3.TabIndex = 194;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 19F);
            this.label13.Location = new System.Drawing.Point(569, 7);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(219, 32);
            this.label13.TabIndex = 195;
            this.label13.Text = "Lista de Pedidos";
            // 
            // dgvVendas
            // 
            this.dgvVendas.AllowUserToAddRows = false;
            this.dgvVendas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.dgvVendas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVendas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVendas.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvVendas.EnableHeadersVisualStyles = false;
            this.dgvVendas.Location = new System.Drawing.Point(569, 49);
            this.dgvVendas.MultiSelect = false;
            this.dgvVendas.Name = "dgvVendas";
            this.dgvVendas.ReadOnly = true;
            this.dgvVendas.RowHeadersVisible = false;
            this.dgvVendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVendas.Size = new System.Drawing.Size(218, 395);
            this.dgvVendas.TabIndex = 196;
            this.dgvVendas.SelectionChanged += new System.EventHandler(this.dgvVendas_SelectionChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.panel2.Location = new System.Drawing.Point(569, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(219, 1);
            this.panel2.TabIndex = 197;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnAtualizarVendas
            // 
            this.btnAtualizarVendas.BackColor = System.Drawing.Color.Transparent;
            this.btnAtualizarVendas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizarVendas.FlatAppearance.BorderSize = 0;
            this.btnAtualizarVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizarVendas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAtualizarVendas.Image = global::ProjetoCSGrupo.Properties.Resources.reload;
            this.btnAtualizarVendas.Location = new System.Drawing.Point(756, 449);
            this.btnAtualizarVendas.Name = "btnAtualizarVendas";
            this.btnAtualizarVendas.Size = new System.Drawing.Size(31, 29);
            this.btnAtualizarVendas.TabIndex = 199;
            this.btnAtualizarVendas.UseVisualStyleBackColor = false;
            this.btnAtualizarVendas.Click += new System.EventHandler(this.btnAtualizarVendas_Click);
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
            this.txtNomeCliente.Location = new System.Drawing.Point(20, 76);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(130, 21);
            this.txtNomeCliente.TabIndex = 200;
            // 
            // TelaVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.btnAtualizarVendas);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvVendas);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtStatusVenda);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnEditar);
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
            this.Name = "TelaVendas";
            this.Size = new System.Drawing.Size(791, 481);
            this.Load += new System.EventHandler(this.TelaVendas_Load);
            this.gbItensVenda.ResumeLayout(false);
            this.gbItensVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtStatusVenda;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTotalVenda;
        private System.Windows.Forms.GroupBox gbItensVenda;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ComboBox txtNomeProduto;
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
        private System.Windows.Forms.Button btnAtualizarProdutos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvVendas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvItensVenda;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnAtualizarVendas;
        private System.Windows.Forms.ComboBox txtNomeCliente;
    }
}
