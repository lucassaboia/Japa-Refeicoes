using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCSGrupo
{
    public partial class TelaVendas : UserControl
    {
        double totalvenda = 0;
        public TelaVendas()
        {
            InitializeComponent();

        }
        public void Alerta(string msg, frmAlerta.enmType type)
        {
            frmAlerta frm = new frmAlerta();
            frm.showAlert(msg, type);
        }
        private void CarregarVendas()
        {
            string sqlCarregarVendas = $"select tbp.idpedido as 'ID', tbp.cliente as 'Cliente', tbp.valortotal as 'Valor Total',tbp.status as 'Status',tbp.data as 'Data'  FROM tbpedidosjp as tbp";
            dgvVendas.DataSource = Banco.dql(sqlCarregarVendas);
            dgvVendas.Columns[0].Width = 24;
            dgvVendas.Columns[1].Width = 60;
            dgvVendas.Columns[2].Width = 80;
            dgvVendas.Columns[3].Width = 80;
            dgvVendas.Columns[4].Width = 100;
            dgvVendas.Columns[2].DefaultCellStyle.Format = "C";
        }
        private void CarregarItensVenda()
        {
            string id_venda = txtID_Venda.Text;
            string sqlCarregarItens = $"select tbiv.iditempedido, tbiv.idpedido as 'ID Produto', tbpr.descricao as 'Nome do Produto', tbiv.quantidade as 'Quantidade', tbiv.valor as 'Valor Total' from tbitenspedido as tbiv inner join tbprodutosjp as tbpr on tbpr.codigo = tbiv.codigo where tbiv.idpedido = '{id_venda}'";
            dgvItensVenda.DataSource = Banco.dql(sqlCarregarItens);
            dgvItensVenda.Columns[0].Visible = false;
            dgvItensVenda.Columns[1].Width = 50;
            dgvItensVenda.Columns[2].Width = 200;
            dgvItensVenda.Columns[3].Width = 100;
            dgvItensVenda.Columns[4].Width = 164;
            dgvItensVenda.Columns["Valor Total"].DefaultCellStyle.Format = "C";
        }
        private void TelaVendas_Load(object sender, EventArgs e)
        {
            btnAdicionar.Visible = false;
            CarregarVendas();
            string sqlProduto = $"select * from tbprodutosjp";
            txtNomeProduto.DataSource = Banco.dql(sqlProduto);
            txtNomeProduto.DisplayMember = "descricao";
            txtNomeProduto.ValueMember = "codigo";
            txtNomeProduto.ResetText();
        }
        private void dgvVendas_SelectionChanged(object sender, EventArgs e)
        {
            int contlinhas = dgvVendas.SelectedRows.Count;
            if (contlinhas > 0)
            {
                totalvenda = 0;

                txtValorProduto.Enabled = false;
                txtTotalProduto.Enabled = false;
                txtQuantidadeProduto.Enabled = false;
                txtValorProduto.Text = "R$ 0,00";
                txtQuantidadeProduto.ResetText();
                txtTotalProduto.Text = "R$ 0,00";
                txtStatusVenda.Enabled = false;
                txtID_Venda.Enabled = false;
                txtNomeCliente.Enabled = false;
                txtDataVenda.Enabled = false;
                btnSalvar.Visible = false;
                btnApagar.Visible = false;
                dgvItensVenda.Enabled = false;
                btnEditar.Visible = true;
                btnRemover.Visible = false;
                txtNomeProduto.Enabled = false;


                string id_venda = dgvVendas.SelectedRows[0].Cells[0].Value.ToString();
                string sqlRegistroVenda = $"select tbp.idpedido,tbp.cliente,tbp.data, tbp.status, tbp.valortotal from tbpedidosjp as tbp where tbp.idpedido = '{id_venda}'";
                DataTable dt = new DataTable();
                dt = Banco.dql(sqlRegistroVenda);
                txtID_Venda.Text = dt.Rows[0]["idpedido"].ToString();
                txtNomeCliente.Text = dt.Rows[0]["cliente"].ToString();
                txtDataVenda.Text = dt.Rows[0]["data"].ToString();
                txtStatusVenda.Text = dt.Rows[0]["status"].ToString();
                lblTotalVenda.Text = dt.Rows[0]["valortotal"].ToString();
                lblTotalVenda.Text = Convert.ToDouble(lblTotalVenda.Text).ToString("C");
                totalvenda = Convert.ToDouble(dt.Rows[0]["valortotal"].ToString());
                CarregarItensVenda();

            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtNomeProduto.Enabled = true;
            txtStatusVenda.Enabled = true;
            btnSalvar.Visible = true;
            dgvItensVenda.Enabled = true;
            btnEditar.Visible = false;
            txtNomeCliente.Enabled = true;
            btnApagar.Visible = true;
            btnRemover.Visible = true;
            btnSalvar.Location = new Point(15, 420);
            btnApagar.Location = new Point(108, 420);
            dgvVendas.Enabled = false;
        }
        private void txtNomeProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtNomeProduto.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                string id_produto = txtNomeProduto.SelectedValue.ToString();
                string sqlProduto = $"select * from tbprodutosjp where codigo = '{id_produto}' ";
                DataTable dt = new DataTable();
                dt = Banco.dql(sqlProduto);
                txtQuantidadeProduto.Enabled = true;
                txtQuantidadeProduto.ResetText();
                txtValorProduto.Text = dt.Rows[0]["venda"].ToString();
                txtValorProduto.Text = Convert.ToDouble(txtValorProduto.Text).ToString("C");
                txtTotalProduto.Text = "R$ 0,00";
                txtQuantidadeProduto.Enabled = true;
                txtQuantidadeProduto.ResetText();
            }
        }
        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja apagar o registro de venda ?", "Registro de Venda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string id_venda = txtID_Venda.Text;
                string sqlApagarVenda = $"DELETE FROM `tbpedidosjp` WHERE idpedido = '{id_venda}' ";
                Banco.dml(sqlApagarVenda);

                txtStatusVenda.Enabled = false;
                txtNomeProduto.Enabled = false;
                txtQuantidadeProduto.Enabled = false;
                btnSalvar.Visible = false;
                btnEditar.Visible = true;
                btnApagar.Visible = false;
                dgvItensVenda.Enabled = false;
                btnRemover.Visible = false;
                dgvVendas.Enabled = true;
                txtNomeCliente.Enabled = false;
                txtQuantidadeProduto.Text = "";
                CarregarVendas();
            }
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (dgvItensVenda.RowCount == 0)
            {
                this.Alerta("Não há itens no pedido", frmAlerta.enmType.Info);
            }
            else if (MessageBox.Show("Deseja atualizar o registro de venda ?", "Registro de Venda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string id_venda = txtID_Venda.Text;
                string status = txtStatusVenda.Text;
                string total_venda = totalvenda.ToString();
                string nome = txtNomeCliente.Text;
                string sqlAtualizarVenda = $"UPDATE `tbpedidosjp` SET `status` = '{status}',cliente = '{nome}',valortotal = '{total_venda}' WHERE idpedido = '{id_venda}'";
                Banco.dml(sqlAtualizarVenda);

                txtStatusVenda.Enabled = false;
                txtNomeProduto.Enabled = false;
                txtQuantidadeProduto.Enabled = false;
                btnSalvar.Visible = false;
                btnEditar.Visible = true;
                btnApagar.Visible = false;
                dgvItensVenda.Enabled = false;
                btnRemover.Visible = false;
                btnAdicionar.Visible = false;
                dgvVendas.Enabled = true;

                CarregarVendas();
            }
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if ((txtNomeProduto.Text != "") || (txtQuantidadeProduto.Text != "") || (txtNomeCliente.Text != "") || (txtDataVenda.Text != ""))
            {
                string id_venda = txtID_Venda.Text;
                string id_produto = txtNomeProduto.SelectedValue.ToString();
                string quantidade = txtQuantidadeProduto.Text;
                string total_produto = txtTotalProduto.Text.Replace("R$ ", "").Replace(".", "").Replace(",", ".");
                string sqlItensVenda = $"INSERT INTO `tbitenspedido`(`iditempedido`, `idpedido`, `codigo`, `quantidade`, `valor`) VALUES(null, '{id_venda}','{id_produto}','{quantidade}','{total_produto}')";
                Banco.dml(sqlItensVenda);

                string total_exibir = txtTotalProduto.Text.Replace("R$ ", "");
                Double TotalProduto = Convert.ToDouble(total_exibir);
                totalvenda = totalvenda + TotalProduto;
                lblTotalVenda.Text = totalvenda.ToString("C");

                CarregarItensVenda();

                txtQuantidadeProduto.Enabled = false;
                txtValorProduto.Text = "R$ 0,00";
                txtQuantidadeProduto.ResetText();
                txtTotalProduto.Text = "R$ 0,00";
                txtNomeProduto.ResetText();
            }
        }
        private void btnAtualizarVendas_Click(object sender, EventArgs e)
        {
            CarregarVendas();
            this.Alerta("Vendas atualizadas com sucesso.", frmAlerta.enmType.Success);
        }
        private void btnAtualizarProdutos_Click(object sender, EventArgs e)
        {
            string sqlProduto = $"select * from tbprodutosjp";
            txtNomeProduto.DataSource = Banco.dql(sqlProduto);
            txtNomeProduto.ResetText();
            txtQuantidadeProduto.Enabled = false;
            this.Alerta("Produtos atualizados com sucesso.", frmAlerta.enmType.Success);
        }
        private void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                string id_itemvenda = dgvItensVenda.SelectedRows[0].Cells["iditempedido"].Value.ToString();
                string ValorSelecionado = dgvItensVenda.SelectedRows[0].Cells["Valor Total"].Value.ToString().Replace("R$ ", "");
                string sqlApagarProduto = $"DELETE FROM `tbitenspedido` WHERE iditempedido = '{id_itemvenda}'";
                Banco.dml(sqlApagarProduto);
                double TotalProduto = Convert.ToDouble(ValorSelecionado);
                totalvenda = totalvenda - TotalProduto;
                lblTotalVenda.Text = totalvenda.ToString("C");
                dgvItensVenda.Rows.RemoveAt(dgvItensVenda.CurrentRow.Index);
                CarregarItensVenda();
                txtQuantidadeProduto.Enabled = false;
                txtQuantidadeProduto.ResetText();
                txtNomeProduto.ResetText();
            }
            catch
            {
                this.Alerta("Não há nada para apagar.", frmAlerta.enmType.Error);
            }
        }
        private void txtQuantidadeProduto_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantidadeProduto.Text == "")
            {
                btnAdicionar.Visible = false;
                txtTotalProduto.Text = "R$ 0,00";
            }
            else
            {
                btnAdicionar.Visible = true;
                Double Quantidade = Convert.ToDouble(txtQuantidadeProduto.Text);
                Double ValorProduto = Convert.ToDouble(txtValorProduto.Text.Replace("R$ ", ""));
                Double TotalProduto = Quantidade * ValorProduto;
                txtTotalProduto.Text = TotalProduto.ToString("C");
            }
        }
    }
}