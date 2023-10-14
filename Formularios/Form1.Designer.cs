namespace ProjetoCSGrupo
{
    partial class Form1
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.panelLateral = new System.Windows.Forms.Panel();
            this.btnSobre = new System.Windows.Forms.Button();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.btnVenda = new System.Windows.Forms.Button();
            this.btnFuncionarios = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.firstCustomControl1 = new ProjetoCSGrupo.FirstCustomControl();
            this.telaVendas1 = new ProjetoCSGrupo.TelaVendas();
            this.telaSobre1 = new ProjetoCSGrupo.TelaSobre();
            this.telaFuncionarios1 = new ProjetoCSGrupo.TelaFuncionarios();
            this.telaEstoque1 = new ProjetoCSGrupo.TelaEstoque();
            this.telaPedidos1 = new ProjetoCSGrupo.TelaPedidos();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.btnEstoque);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.panelLateral);
            this.panel1.Controls.Add(this.btnSobre);
            this.panel1.Controls.Add(this.btnPedidos);
            this.panel1.Controls.Add(this.btnVenda);
            this.panel1.Controls.Add(this.btnFuncionarios);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Location = new System.Drawing.Point(0, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 591);
            this.panel1.TabIndex = 1;
            // 
            // btnEstoque
            // 
            this.btnEstoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEstoque.FlatAppearance.BorderSize = 0;
            this.btnEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstoque.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstoque.ForeColor = System.Drawing.Color.White;
            this.btnEstoque.Image = global::ProjetoCSGrupo.Properties.Resources.icons8_deliver_food_25px;
            this.btnEstoque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstoque.Location = new System.Drawing.Point(10, 236);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(145, 54);
            this.btnEstoque.TabIndex = 14;
            this.btnEstoque.Text = "  Estoque";
            this.btnEstoque.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEstoque.UseVisualStyleBackColor = true;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ProjetoCSGrupo.Properties.Resources.icons8_japan_25px;
            this.pictureBox3.Location = new System.Drawing.Point(133, 558);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProjetoCSGrupo.Properties.Resources.icons8_brazil_25px;
            this.pictureBox2.Location = new System.Drawing.Point(104, 558);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Image = global::ProjetoCSGrupo.Properties.Resources.icons8_exit_25px;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(3, 552);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(38, 37);
            this.btnSair.TabIndex = 11;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(26)))), ((int)(((byte)(24)))));
            this.panelLateral.Location = new System.Drawing.Point(0, 28);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(10, 42);
            this.panelLateral.TabIndex = 3;
            // 
            // btnSobre
            // 
            this.btnSobre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSobre.FlatAppearance.BorderSize = 0;
            this.btnSobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSobre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSobre.ForeColor = System.Drawing.Color.White;
            this.btnSobre.Image = global::ProjetoCSGrupo.Properties.Resources.icons8_info_25px;
            this.btnSobre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSobre.Location = new System.Drawing.Point(10, 478);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(145, 68);
            this.btnSobre.TabIndex = 7;
            this.btnSobre.Text = "  Sobre";
            this.btnSobre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSobre.UseVisualStyleBackColor = true;
            this.btnSobre.Click += new System.EventHandler(this.btnSobre_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPedidos.FlatAppearance.BorderSize = 0;
            this.btnPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedidos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidos.ForeColor = System.Drawing.Color.White;
            this.btnPedidos.Image = global::ProjetoCSGrupo.Properties.Resources.icons8_contacts_25px;
            this.btnPedidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPedidos.Location = new System.Drawing.Point(10, 116);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(145, 54);
            this.btnPedidos.TabIndex = 6;
            this.btnPedidos.Text = "  Pedidos";
            this.btnPedidos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPedidos.UseVisualStyleBackColor = true;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // btnVenda
            // 
            this.btnVenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVenda.FlatAppearance.BorderSize = 0;
            this.btnVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenda.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenda.ForeColor = System.Drawing.Color.White;
            this.btnVenda.Image = global::ProjetoCSGrupo.Properties.Resources.icons8_shopping_cart_25px;
            this.btnVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVenda.Location = new System.Drawing.Point(10, 176);
            this.btnVenda.Name = "btnVenda";
            this.btnVenda.Size = new System.Drawing.Size(145, 54);
            this.btnVenda.TabIndex = 5;
            this.btnVenda.Text = "  Venda";
            this.btnVenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVenda.UseVisualStyleBackColor = true;
            this.btnVenda.Click += new System.EventHandler(this.btnVenda_Click);
            // 
            // btnFuncionarios
            // 
            this.btnFuncionarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFuncionarios.FlatAppearance.BorderSize = 0;
            this.btnFuncionarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionarios.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionarios.ForeColor = System.Drawing.Color.White;
            this.btnFuncionarios.Image = global::ProjetoCSGrupo.Properties.Resources.icons8_management_25px;
            this.btnFuncionarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFuncionarios.Location = new System.Drawing.Point(10, 296);
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Size = new System.Drawing.Size(145, 54);
            this.btnFuncionarios.TabIndex = 4;
            this.btnFuncionarios.Text = "  Funcionários";
            this.btnFuncionarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFuncionarios.UseVisualStyleBackColor = true;
            this.btnFuncionarios.Click += new System.EventHandler(this.btnFuncionarios_Click);
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::ProjetoCSGrupo.Properties.Resources.icons8_home_page_25px_1;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(10, 30);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(145, 54);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "  Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(26)))), ((int)(((byte)(24)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(966, 15);
            this.panel2.TabIndex = 2;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(26)))), ((int)(((byte)(24)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(15, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(110, 105);
            this.panel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Refeições";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetoCSGrupo.Properties.Resources.japapitologo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.lblUsuario);
            this.panel5.Controls.Add(this.btnMinimizar);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.btnFechar);
            this.panel5.Location = new System.Drawing.Point(166, -7);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(800, 126);
            this.panel5.TabIndex = 5;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(144, 52);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(153, 21);
            this.lblUsuario.TabIndex = 11;
            this.lblUsuario.Text = "Bem-vindo Usuário";
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::ProjetoCSGrupo.Properties.Resources.icons8_minimize_window_25px;
            this.btnMinimizar.Location = new System.Drawing.Point(738, 27);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(25, 25);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnMinimizar.TabIndex = 9;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Image = global::ProjetoCSGrupo.Properties.Resources.icons8_close_window_25px;
            this.btnFechar.Location = new System.Drawing.Point(763, 27);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(25, 25);
            this.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnFechar.TabIndex = 8;
            this.btnFechar.TabStop = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel6.Controls.Add(this.firstCustomControl1);
            this.panel6.Controls.Add(this.telaVendas1);
            this.panel6.Controls.Add(this.telaSobre1);
            this.panel6.Controls.Add(this.telaFuncionarios1);
            this.panel6.Controls.Add(this.telaEstoque1);
            this.panel6.Controls.Add(this.telaPedidos1);
            this.panel6.Location = new System.Drawing.Point(175, 125);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(791, 481);
            this.panel6.TabIndex = 6;
            // 
            // firstCustomControl1
            // 
            this.firstCustomControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.firstCustomControl1.Location = new System.Drawing.Point(0, -8);
            this.firstCustomControl1.Name = "firstCustomControl1";
            this.firstCustomControl1.Size = new System.Drawing.Size(791, 489);
            this.firstCustomControl1.TabIndex = 8;
            // 
            // telaVendas1
            // 
            this.telaVendas1.Location = new System.Drawing.Point(0, -5);
            this.telaVendas1.Name = "telaVendas1";
            this.telaVendas1.Size = new System.Drawing.Size(788, 486);
            this.telaVendas1.TabIndex = 7;
            // 
            // telaSobre1
            // 
            this.telaSobre1.Location = new System.Drawing.Point(0, -5);
            this.telaSobre1.Name = "telaSobre1";
            this.telaSobre1.Size = new System.Drawing.Size(788, 486);
            this.telaSobre1.TabIndex = 2;
            // 
            // telaFuncionarios1
            // 
            this.telaFuncionarios1.BackColor = System.Drawing.SystemColors.Control;
            this.telaFuncionarios1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.telaFuncionarios1.Location = new System.Drawing.Point(-3, -5);
            this.telaFuncionarios1.Name = "telaFuncionarios1";
            this.telaFuncionarios1.Size = new System.Drawing.Size(791, 486);
            this.telaFuncionarios1.TabIndex = 1;
            // 
            // telaEstoque1
            // 
            this.telaEstoque1.Location = new System.Drawing.Point(0, -5);
            this.telaEstoque1.Name = "telaEstoque1";
            this.telaEstoque1.Size = new System.Drawing.Size(791, 486);
            this.telaEstoque1.TabIndex = 0;
            // 
            // telaPedidos1
            // 
            this.telaPedidos1.Location = new System.Drawing.Point(0, -8);
            this.telaPedidos1.Name = "telaPedidos1";
            this.telaPedidos1.Size = new System.Drawing.Size(791, 481);
            this.telaPedidos1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(966, 606);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Japapito Delivery\'s";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Button btnSobre;
        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.Button btnVenda;
        private System.Windows.Forms.Button btnFuncionarios;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnFechar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnEstoque;
        private TelaEstoque telaEstoque1;
        private TelaFuncionarios telaFuncionarios1;
        private TelaSobre telaSobre1;
        private TelaPedidos telaPedidos1;
        private TelaVendas telaVendas1;
        private System.Windows.Forms.Label lblUsuario;
        private FirstCustomControl firstCustomControl1;
    }
}

