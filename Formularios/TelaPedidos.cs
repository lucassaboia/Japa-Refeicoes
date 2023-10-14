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
    public partial class TelaPedidos : UserControl
    {
        Double TotalVenda = 0;
        public TelaPedidos()
        {
            InitializeComponent();
        }
        private void TelaPedidos_Load(object sender, EventArgs e)
        {
            txtQuantidadeProduto.Enabled = false;
            btnAdicionar.Visible = false;
            txtNomeProduto.Enabled = false;
            txtDataVenda.Text = DateTime.Now.ToString();

            string sqlProduto = $"select * from tbprodutosjp";
            txtNomeProduto.DataSource = Banco.dql(sqlProduto);
            txtNomeProduto.DisplayMember = "descricao";
            txtNomeProduto.ValueMember = "codigo";
            txtNomeProduto.ResetText();
        }
        public void Alerta(string msg, frmAlerta.enmType type)
        {
            frmAlerta frm = new frmAlerta();
            frm.showAlert(msg, type);

        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            TotalVenda = 0;
            txtNomeCliente.Enabled = true;
            btnCadastrar.Visible = true;
            dgvItensVenda.Rows.Clear();
            txtNomeCliente.Text = "";
            lblTotalVenda.Text = "R$ 0,00";
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
            }
        }
        private void txtQuantidadeProduto_TextChanged_1(object sender, EventArgs e)
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
        private void txtQuantidadeProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                this.Alerta("Apenas números", frmAlerta.enmType.Virgula);
            }
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if ((txtNomeProduto.Text != "") && (txtQuantidadeProduto.Text != ""))
            {
                string id_produto = txtNomeProduto.SelectedValue.ToString();
                Double TotalProduto = Convert.ToDouble(txtTotalProduto.Text.Replace("R$ ", ""));
                TotalVenda = TotalVenda + TotalProduto;
                lblTotalVenda.Text = TotalVenda.ToString("C");
                String[] i = { id_produto, txtNomeProduto.Text, txtQuantidadeProduto.Text, txtValorProduto.Text, txtTotalProduto.Text };
                dgvItensVenda.Rows.Add(i);

                txtNomeProduto.ResetText();
                txtQuantidadeProduto.ResetText();
                txtValorProduto.Text = "R$ 0,00";
                txtTotalProduto.Text = "R$ 0,00";
                txtQuantidadeProduto.Enabled = false;
            }
        }
        private void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                string ValorSelecionado = dgvItensVenda.SelectedRows[0].Cells["dgvTotalProduto"].Value.ToString().Replace("R$ ", "");
                double TotalProduto = Convert.ToDouble(ValorSelecionado);
                TotalVenda = TotalVenda - TotalProduto;
                lblTotalVenda.Text = TotalVenda.ToString("C");
                dgvItensVenda.Rows.RemoveAt(dgvItensVenda.CurrentRow.Index);
            }
            catch
            {
                this.Alerta("Não há nada para apagar.", frmAlerta.enmType.Error);
            }
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNomeCliente.Text == "")
            {
                this.Alerta("Preencha todos os campos", frmAlerta.enmType.Campos);
            }
            else if (dgvItensVenda.RowCount == 0)
            {
                this.Alerta("Não há itens no pedido", frmAlerta.enmType.Info);
            }
            else if (MessageBox.Show("Deseja realmente salvar o produto?", "Japapito Refeições", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string id_cliente = txtNomeCliente.Text;
                string data_venda = txtDataVenda.Text;
                string status_venda = txtStatusVenda.Text;
                string total_venda = TotalVenda.ToString().Replace(",", ".");
                string sqlVenda = $"INSERT INTO `tbpedidosjp`(`idpedido`, `cliente`, `valortotal`, `data`, `status`) VALUES (null,'{id_cliente}','{total_venda}','{data_venda}','{status_venda}');select @@IDENTITY";

                Banco.dmlVenda(sqlVenda);
                this.Alerta("Pedido realizado.", frmAlerta.enmType.Success);
                int ultimo_produto = dgvItensVenda.RowCount;

                for (int i = 0; i < ultimo_produto; i++)
                {
                    string id_venda = Properties.Settings.Default.idVenda;
                    string id_produto = dgvItensVenda.Rows[i].Cells["dgvID_Produto"].Value.ToString();
                    string quantidade = dgvItensVenda.Rows[i].Cells["dgvQuantidade"].Value.ToString();
                    string total_produto = dgvItensVenda.Rows[i].Cells["dgvTotalProduto"].Value.ToString().Replace("R$ ", "").Replace(".", "").Replace(",", ".");
                    string sqlItensVenda = $"INSERT INTO `tbitenspedido`(`iditempedido`, `idpedido`, `codigo`, `quantidade`, `valor`) VALUES (null,'{id_venda}', '{id_produto}','{quantidade}', '{total_produto}')";
                    Banco.dml(sqlItensVenda);
                }

                txtNomeCliente.Enabled = false;
                txtNomeProduto.Enabled = false;
                btnCadastrar.Visible = false;
                btnAdicionar.Visible = false;
                txtQuantidadeProduto.Enabled = false;
                txtNomeCliente.ResetText();
                txtNomeProduto.ResetText();
                txtQuantidadeProduto.ResetText();
                txtValorProduto.Text = "R$ 0,00";
                txtTotalProduto.Text = "R$ 0,00";
                lblTotalVenda.Text = "R$ 0,00";
                dgvItensVenda.Rows.Clear();
                TotalVenda = 0;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string sqlProduto = $"select * from tbprodutosjp";
            txtNomeProduto.DataSource = Banco.dql(sqlProduto);
            txtNomeProduto.ResetText();
            txtQuantidadeProduto.Enabled = false;
            this.Alerta("Produtos atualizados com sucesso.", frmAlerta.enmType.Success);
        }
        private void txtNomeCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNomeProduto.Enabled = true;
        }
    }
}
