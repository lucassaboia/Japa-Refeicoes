using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetoCSGrupo
{
    public partial class TelaEstoque : UserControl
    {
        public TelaEstoque()
        {
            InitializeComponent();
        }
        public void Alerta(string msg, frmAlerta.enmType type)
        {
            frmAlerta frm = new frmAlerta();
            frm.showAlert(msg, type);
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtCodigo.ResetText();
            txtLucro.ResetText();
            txtDescricao.Enabled = true;
            txtCategoria.Enabled = true;
            txtTipo.Enabled = true;
            txtEstoque.Enabled = true;
            txtMarca.Enabled = true;
            txtCusto.Enabled = true;
            txtVenda.Enabled = true;
            txtSubcategoria.Enabled = true;
            btnCadastrar.Visible = true;
            btnNovo.Visible = true;
            btnEditar.Visible = false;
            btnSalvar.Visible = false;
            btnApagar.Visible = false;
            txtPesquisar.Enabled = true;
            pbPesquisar.Enabled = true;
            btnCadastrar.Location = new Point(118, 410);    

            txtDescricao.ResetText();
            txtCategoria.ResetText();
            txtSubcategoria.ResetText();
            txtTipo.ResetText();
            txtEstoque.ResetText();
            txtMarca.ResetText();
            txtCusto.ResetText();
            txtVenda.ResetText();

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(txtDescricao.Text.Trim())) || (string.IsNullOrEmpty(txtMarca.Text.Trim())) || (string.IsNullOrEmpty(txtCusto.Text.Trim())) || (string.IsNullOrEmpty(txtTipo.Text.Trim())) || (string.IsNullOrEmpty(txtCategoria.Text.Trim())) || (string.IsNullOrEmpty(txtSubcategoria.Text.Trim())) || (string.IsNullOrEmpty(txtEstoque.Text.Trim())) || (string.IsNullOrEmpty(txtVenda.Text.Trim())))
            {
                this.Alerta("Preencha todos os campos.", frmAlerta.enmType.Campos);
            }

            else
            {
                System.Text.RegularExpressions.Regex num = new System.Text.RegularExpressions.Regex("[^0-9-,]");
                System.Text.RegularExpressions.Regex num2 = new System.Text.RegularExpressions.Regex("[^0-9]");
                if ((num.IsMatch(txtVenda.Text)) || (num.IsMatch(txtCusto.Text)))
                {
                    this.Alerta("Preços só podem ser números", frmAlerta.enmType.Virgula);
                }
                else if (num2.IsMatch(txtEstoque.Text))
                {
                    this.Alerta("Campo estoque só pode ser número", frmAlerta.enmType.Virgula);
                }
                else
                {
                    //CALCULAR LUCRO
                    Double lucro, precovenda, precocusto;
                    precocusto = Convert.ToDouble(txtCusto.Text);
                    precovenda = Convert.ToDouble(txtVenda.Text);
                    lucro = precovenda - precocusto;
                    txtLucro.Text = lucro.ToString("C");


                    if (lucro < 0)
                    {
                        this.Alerta("O lucro não pode ser negativo.", frmAlerta.enmType.Error);
                    }

                    else if (MessageBox.Show("Deseja realmente salvar o produto?", "Japapito Refeições", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        MySqlConnection conexao = new MySqlConnection("server=localhost; port=3306; uid=root; password=; database=bdjapapito2");
                        try
                        {
                            conexao.Open();
                            MySqlCommand cmd = new MySqlCommand("insert into tbprodutosjp(codigo, descricao, marca, tipo, categoria, subcategoria, estoque, custo, venda, lucro) values (null, @descricao, @marca, @tipo, @categoria, @subcategoria, @estoque, @custo, @venda, @lucro)", conexao);
                            cmd.Parameters.AddWithValue("@marca", txtMarca.Text);
                            cmd.Parameters.AddWithValue("@categoria", txtCategoria.Text);
                            cmd.Parameters.AddWithValue("@subcategoria", txtSubcategoria.Text);
                            cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                            cmd.Parameters.AddWithValue("@tipo", txtTipo.Text);
                            cmd.Parameters.AddWithValue("@estoque", txtEstoque.Text);
                            cmd.Parameters.AddWithValue("@custo", txtCusto.Text);
                            cmd.Parameters.AddWithValue("@venda", txtVenda.Text);
                            cmd.Parameters.AddWithValue("@lucro", txtLucro.Text);
                            cmd.ExecuteNonQuery();
                            this.Alerta("Produto cadastrado.", frmAlerta.enmType.Success);

                            txtDescricao.Enabled = false;
                            txtCategoria.Enabled = false;
                            txtSubcategoria.Enabled = false;
                            txtTipo.Enabled = false;
                            txtEstoque.Enabled = false;
                            txtMarca.Enabled = false;
                            txtCusto.Enabled = false;
                            txtVenda.Enabled = false;

                            btnCadastrar.Visible = false;
                            btnNovo.Visible = true;
                            btnEditar.Visible = true;

                            txtPesquisar.Enabled = true;
                            txtPesquisar.ResetText();

                            txtDescricao.ResetText();
                            txtCategoria.ResetText();
                            txtSubcategoria.ResetText();
                            txtTipo.ResetText();
                            txtEstoque.ResetText();
                            txtMarca.ResetText();
                            txtCusto.ResetText();
                            txtVenda.ResetText();
                            txtLucro.ResetText();

                            timer1.Start();

                            pbPesquisar.Enabled = true;
                        }
                        catch
                        {
                            this.Alerta("Falha ao cadastrar.", frmAlerta.enmType.Error);
                        }
                        finally
                        {
                            conexao.Close();
                        }
                    }
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtPesquisar.Enabled = false;
            txtPesquisar.ResetText();
            btnSalvar.Location = new Point(118, 410);
            txtDescricao.Enabled = true;
            txtCategoria.Enabled = true;
            btnApagar.Location = new Point(210, 410);

            txtTipo.Enabled = true;
            txtEstoque.Enabled = true;
            txtMarca.Enabled = true;
            txtCusto.Enabled = true;
            txtVenda.Enabled = true;
            txtSubcategoria.Enabled = true;

            btnSalvar.Visible = true;
            btnEditar.Visible = false;
            btnApagar.Visible = true;
           
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(txtDescricao.Text.Trim())) || (string.IsNullOrEmpty(txtMarca.Text.Trim())) || (string.IsNullOrEmpty(txtCusto.Text.Trim())) || (string.IsNullOrEmpty(txtTipo.Text.Trim())) || (string.IsNullOrEmpty(txtCategoria.Text.Trim())) || (string.IsNullOrEmpty(txtSubcategoria.Text.Trim())) || (string.IsNullOrEmpty(txtEstoque.Text.Trim())) || (string.IsNullOrEmpty(txtVenda.Text.Trim())))
            {
                this.Alerta("Preencha todos os campos.", frmAlerta.enmType.Campos);
            }

            else
            {
                System.Text.RegularExpressions.Regex num = new System.Text.RegularExpressions.Regex("[^0-9-,]");
                System.Text.RegularExpressions.Regex num2 = new System.Text.RegularExpressions.Regex("[^0-9]");
                if ((num.IsMatch(txtVenda.Text)) || (num.IsMatch(txtCusto.Text)))
                {
                    this.Alerta("Preços só podem ser números", frmAlerta.enmType.Virgula);
                }
                else if (num2.IsMatch(txtEstoque.Text))
                {
                    this.Alerta("Campo estoque só pode ser número", frmAlerta.enmType.Virgula);
                }
                else
                {
                    //CALCULAR LUCRO
                    Double lucro, precovenda, precocusto;
                    precocusto = Convert.ToDouble(txtCusto.Text);
                    precovenda = Convert.ToDouble(txtVenda.Text);
                    lucro = precovenda - precocusto;
                    txtLucro.Text = lucro.ToString("C");


                    if (lucro < 0)
                    {
                        this.Alerta("O lucro não pode ser negativo.", frmAlerta.enmType.Error);
                    }

                    else if (MessageBox.Show("Deseja realmente salvar o produto?", "Japapito Refeições", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        MySqlConnection conexao = new MySqlConnection("server=localhost; port=3306; uid=root; password=; database=bdjapapito2");
                        try
                        {

                            conexao.Open();
                            MySqlCommand cmd = new MySqlCommand("update tbprodutosjp set descricao=@descricao, marca=@marca, tipo=@tipo, categoria=@categoria,subcategoria=@subcategoria, estoque=@estoque, custo=@custo, lucro=@lucro, venda=@venda where codigo=@codigo", conexao);

                            cmd.Parameters.AddWithValue("@codigo", txtCodigo.Text);
                            cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                            cmd.Parameters.AddWithValue("@marca", txtMarca.Text);
                            cmd.Parameters.AddWithValue("@tipo", txtTipo.Text);
                            cmd.Parameters.AddWithValue("@categoria", txtCategoria.Text);
                            cmd.Parameters.AddWithValue("@subcategoria", txtSubcategoria.Text);
                            cmd.Parameters.AddWithValue("@estoque", txtEstoque.Text);
                            cmd.Parameters.AddWithValue("@custo", txtCusto.Text);
                            cmd.Parameters.AddWithValue("@venda", txtVenda.Text);
                            cmd.Parameters.AddWithValue("@lucro", txtLucro.Text);

                            cmd.ExecuteNonQuery();
                            this.Alerta("Alteração salva.", frmAlerta.enmType.Success);

                            txtDescricao.Enabled = false;
                            txtCategoria.Enabled = false;
                            txtSubcategoria.Enabled = false;
                            txtTipo.Enabled = false;
                            txtEstoque.Enabled = false;
                            txtMarca.Enabled = false;
                            txtCusto.Enabled = false;
                            txtVenda.Enabled = false;

                            btnSalvar.Visible = false;
                            btnEditar.Visible = true;
                            btnApagar.Visible = false;

                            txtPesquisar.Enabled = true;
                            txtPesquisar.ResetText();

                            timer1.Start();

                            pbPesquisar.Enabled = true;
                        }
                        catch
                        {
                            this.Alerta("Não foi possível salvar", frmAlerta.enmType.Error);
                        }
                        finally
                        {
                            conexao.Close();
                        }
                    }
                }
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente apagar o produto?", "Japapito Refeições", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MySqlConnection conexao = new MySqlConnection("server=localhost; port=3306; uid=root; password=; database=bdjapapito2");
                try
                {
                    conexao.Open();
                    MySqlCommand cmd = new MySqlCommand("delete from tbprodutosjp where codigo=@codigo", conexao);
                    cmd.Parameters.AddWithValue("@codigo", txtCodigo.Text);
                    cmd.ExecuteNonQuery();
                    this.Alerta("Produto apagado com sucesso.", frmAlerta.enmType.Success);

                    txtDescricao.Enabled = false;
                    txtCategoria.Enabled = false;
                    txtSubcategoria.Enabled = false;
                    txtTipo.Enabled = false;
                    txtEstoque.Enabled = false;
                    txtMarca.Enabled = false;
                    txtCusto.Enabled = false;
                    txtVenda.Enabled = false;

                    txtDescricao.ResetText();
                    txtCategoria.ResetText();
                    txtSubcategoria.ResetText();
                    txtTipo.ResetText();
                    txtEstoque.ResetText();
                    txtMarca.ResetText();
                    txtCusto.ResetText();
                    txtVenda.ResetText();
                    txtLucro.ResetText();


                    btnApagar.Visible = false;
                    btnSalvar.Visible = false;
                    btnCadastrar.Visible = false;
                    btnEditar.Visible = false;

                    txtPesquisar.Enabled = true;
                    txtPesquisar.ResetText();
                    pbPesquisar.Enabled = true;
                    timer1.Start();

                }
                catch
                {
                    this.Alerta("Não foi possível apagar.", frmAlerta.enmType.Error);
                }
                finally
                {
                    conexao.Close();
                }
            }
        }

        private void TelaEstoque_Load(object sender, EventArgs e)
        {
            MySqlConnection conexao = new MySqlConnection("server=localhost; port=3306; uid=root; password=; database=bdjapapito2");
            try
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand("select codigo as ID, descricao as Descrição, estoque as Estoque from tbprodutosjp", conexao);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dgvEstoque.DataSource = dt;
                    dgvEstoque.Columns[0].Width = 50;
                    dgvEstoque.Columns[1].Width = 140;
                    dgvEstoque.Columns[2].Width = 50;

                }


            }
            catch
            {
                this.Alerta("Não foi possível encontrar.", frmAlerta.enmType.Error);
            }
            finally
            {
                conexao.Close();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MySqlConnection conexao = new MySqlConnection("server=localhost; port=3306; uid=root; password=; database=bdjapapito2");
            try
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand("select codigo as ID, descricao as Descrição, estoque as Estoque from tbprodutosjp", conexao);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dgvEstoque.DataSource = dt;
                    dgvEstoque.Columns[0].Width = 50;
                    dgvEstoque.Columns[1].Width = 140;
                    dgvEstoque.Columns[2].Width = 50;

                }


            }
            catch
            {
                this.Alerta("Não foi possível encontrar.", frmAlerta.enmType.Error);
            }
            finally
            {
                conexao.Close();
            }
            timer1.Stop();
        }

        private void pbPesquisar_Click(object sender, EventArgs e)
        {
            int contlinhas = dgvEstoque.SelectedRows.Count;
            if (contlinhas > 0)
            {
                MySqlConnection conexao = new MySqlConnection("server=localhost; port=3306; uid=root; password=; database=bdjapapito2");

                try
                {
                    conexao.Open();
                    MySqlCommand cmd = new MySqlCommand("select * from tbprodutosjp where codigo = @codigo", conexao);
                    cmd.Parameters.AddWithValue("@codigo", txtPesquisar.Text.ToString());
                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                        txtCodigo.Text = reader["codigo"].ToString();
                        txtDescricao.Text = reader["descricao"].ToString();
                        txtMarca.Text = reader["marca"].ToString();
                        txtCategoria.Text = reader["categoria"].ToString();
                        txtSubcategoria.Text = reader["subcategoria"].ToString();
                        txtEstoque.Text = reader["estoque"].ToString();
                        txtTipo.Text = reader["tipo"].ToString();
                        txtCusto.Text = reader["custo"].ToString();
                        txtVenda.Text = reader["venda"].ToString();
                        txtLucro.Text = reader["lucro"].ToString();
                    this.Alerta("Cadastro encontrado com sucesso.", frmAlerta.enmType.Success);
                    btnSalvar.Visible = false;
                    btnEditar.Visible = true;
                    btnCadastrar.Visible = false;
                    txtCategoria.Enabled = false;
                    txtCodigo.Enabled = false;
                    txtCusto.Enabled = false;
                    txtDescricao.Enabled = false;
                    txtEstoque.Enabled = false;
                    txtLucro.Enabled = false;
                    txtMarca.Enabled = false;
                    txtSubcategoria.Enabled = false;
                    txtTipo.Enabled = false;
                    txtVenda.Enabled = false;
                    
                 



                }
                catch
                {
                    this.Alerta("Não foi possível encontrar.", frmAlerta.enmType.Error);

                }
                finally
                {
                    conexao.Close();
                }
            }
        }

        private void dgvEstoque_SelectionChanged(object sender, EventArgs e)
        {
            /*
             O CODIGO DO DGV NÃO É ESSE, É O OUTRO QUE TA LÁ NO FINAL.
            int contlinhas = dgvEstoque.SelectedRows.Count;
            if (contlinhas > 0)
            {
                MySqlConnection conexao = new MySqlConnection("server=localhost; port=3306; uid=root; password=; database=bdjapapito2");

                try
                {
                    conexao.Open();
                    MySqlCommand cmd = new MySqlCommand("select * from tbprodutosjp where codigo = @codigo", conexao);
                    cmd.Parameters.AddWithValue("@codigo", dgvEstoque.SelectedRows[0].Cells[0].Value.ToString());
                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();

                    txtCodigo.Text = reader["codigo"].ToString();
                    txtDescricao.Text = reader["descricao"].ToString();
                    txtMarca.Text = reader["marca"].ToString();
                    txtCategoria.Text = reader["categoria"].ToString();
                    txtSubcategoria.Text = reader["subcategoria"].ToString();
                    txtEstoque.Text = reader["estoque"].ToString();
                    txtTipo.Text = reader["tipo"].ToString();
                    txtCusto.Text = reader["custo"].ToString();
                    txtVenda.Text = reader["venda"].ToString();
                    txtLucro.Text = reader["lucro"].ToString();

                    btnEditar.Enabled = true;


                }
                catch (Exception erro)
                {
                    MessageBox.Show("Não foi possível exibir os dados dos produtos" + erro, "Erro ao exibir dados dos produtos", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    conexao.Close();
                }
            }
            */
        }

        private void txtCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (txtCategoria.Text)
            {
                case "REFEIÇÕES":

                    txtSubcategoria.Items.Clear();
                    txtSubcategoria.Items.Add("ARROZ");
                    txtSubcategoria.Items.Add("PRATOS QUENTES");
                    txtSubcategoria.Items.Add("SUSHIS NACIONAIS");
                    txtSubcategoria.Items.Add("SUSHIS IMPORTADOS");
                    txtSubcategoria.Items.Add("TEMPURÁS");
                    txtSubcategoria.Items.Add("TEMAKI");
                    break;

                case "ENTRADAS":

                    txtSubcategoria.Items.Clear();
                    txtSubcategoria.Items.Add("ATUM");
                    txtSubcategoria.Items.Add("OVOS");
                    txtSubcategoria.Items.Add("OVAS");
                    txtSubcategoria.Items.Add("ROLINHOS");
                    txtSubcategoria.Items.Add("SIRIS");
                    break;

                case "BEBIDAS":

                    txtSubcategoria.Items.Clear();
                    txtSubcategoria.Items.Add("ÁGUA");
                    txtSubcategoria.Items.Add("SUCOS");
                    txtSubcategoria.Items.Add("REFRIGERANTES");
                    txtSubcategoria.Items.Add("LICOR");
                    txtSubcategoria.Items.Add("VINHOS");
                    txtSubcategoria.Items.Add("VODKAS");
                    txtSubcategoria.Items.Add("WHISKYS");
                    break;

                case "ACOMPANHAMENTOS":

                    txtSubcategoria.Items.Clear();
                    txtSubcategoria.Items.Add("MOLHOS");
                    txtSubcategoria.Items.Add("SAKÊS");
                    break;

                case "SOBREMESAS":
                    txtSubcategoria.Items.Clear();
                    txtSubcategoria.Items.Add("BOLOS");
                    txtSubcategoria.Items.Add("SORVETES");
                    break;

                default:
                    txtSubcategoria.Items.Clear();
                    break;
            }
        }

        private void txtCategoria_Leave(object sender, EventArgs e)
        {
            
        }

        private void dgvEstoque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvEstoque_SelectionChanged_1(object sender, EventArgs e)
        {
            int contlinhas = dgvEstoque.SelectedRows.Count;
            if (contlinhas > 0)
            {
                MySqlConnection conexao = new MySqlConnection("server=localhost; port=3306; uid=root; password=; database=bdjapapito2");

                try
                {
                    conexao.Open();
                    MySqlCommand cmd = new MySqlCommand("select * from tbprodutosjp where codigo = @codigo", conexao);
                    cmd.Parameters.AddWithValue("@codigo", dgvEstoque.SelectedRows[0].Cells[0].Value.ToString());
                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    if (!reader.HasRows)
                    {

                    }
                    else
                    {
                        btnApagar.Location = new Point(210, 410);
                        txtCodigo.Text = reader["codigo"].ToString();
                        txtDescricao.Text = reader["descricao"].ToString();
                        txtMarca.Text = reader["marca"].ToString();
                        txtCategoria.Text = reader["categoria"].ToString();
                        txtSubcategoria.Text = reader["subcategoria"].ToString();
                        txtEstoque.Text = reader["estoque"].ToString();
                        txtTipo.Text = reader["tipo"].ToString();
                        txtCusto.Text = reader["custo"].ToString();
                        txtVenda.Text = reader["venda"].ToString();
                        txtLucro.Text = reader["lucro"].ToString();

                        btnSalvar.Visible = false;
                        btnEditar.Visible = true;
                        btnApagar.Visible = false;
                        btnCadastrar.Visible = false;
                        txtPesquisar.Enabled = true;
                        txtCategoria.Enabled = false;
                        txtCodigo.Enabled = false;
                        txtCusto.Enabled = false;
                        txtEstoque.Enabled = false;
                        txtLucro.Enabled = false;
                        txtMarca.Enabled = false;
                        txtSubcategoria.Enabled = false;
                        txtTipo.Enabled = false;
                        txtVenda.Enabled = false;
                        txtDescricao.Enabled = false;
                        
                    }
                    
                }
                catch 
                {
                    this.Alerta("Não foi possível encontrar.", frmAlerta.enmType.Error);

                }
                finally
                {
                    conexao.Close();
                }
            }
        }

        private void txtCusto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                this.Alerta("Apenas números e virgulas", frmAlerta.enmType.Virgula);
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                this.Alerta("Apenas números e virgulas", frmAlerta.enmType.Virgula);
            }
        }

        private void txtVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                this.Alerta("Apenas números e virgulas", frmAlerta.enmType.Virgula);
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                this.Alerta("O campo só aceita uma virgula", frmAlerta.enmType.Virgula);
            }
        }

        private void txtEstoque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                this.Alerta("Apenas números", frmAlerta.enmType.Virgula);
            }
        }

        private void txtCusto_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtVenda_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtVenda_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void txtCusto_MouseDown(object sender, MouseEventArgs e)
        {
            
        }
    }
}
