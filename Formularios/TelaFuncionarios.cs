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
using System.IO;

namespace ProjetoCSGrupo
{
    public partial class TelaFuncionarios : UserControl
    {
        MySqlConnection conexao = new MySqlConnection("server=localhost;port=3306;uid=root;password=;database=bdjapapito2");
        public TelaFuncionarios()
        {
            InitializeComponent();
        }
        private void btnnovo_Click(object sender, EventArgs e)
        {
            btnCadastrar.Location = new Point(118, 410);
            txtnome.Enabled = true;
            txtnascimento.Enabled = true;
            txttelefone.Enabled = true;
            txtgenero.Enabled = true;
            txtcpf.Enabled = true;
            txtemail.Enabled = true;
            txtendereco.Enabled = true;
            txtsalariobase.Enabled = true;
            txtcargo.Enabled = true;
            txtadmissao.Enabled = true;
            btnEditar.Visible = false;
            btnApagar.Visible = false;
            btnSalvar.Visible = false;
            btnCadastrar.Visible = true;
            txtNivel.Enabled = true;

            txtCodigo.ResetText();
            txtnome.ResetText();
            txtnascimento.ResetText();
            txttelefone.ResetText();
            txtgenero.ResetText();
            txtcpf.ResetText();
            txtemail.ResetText();
            txtendereco.ResetText();
            txtsalariobase.ResetText();
            txtcargo.ResetText();
            txtadmissao.ResetText();
            txtNivel.ResetText();

            btnCadastrar.Enabled = true;
        }
        private void btncadastrar_Click(object sender, EventArgs e)
        {
            this.txtnascimento.CustomFormat = "dd/MM/yy";
            DateTime DataNascimento = txtnascimento.Value;
            DateTime DataAdmissao = txtadmissao.Value;
            DateTime DataAtual = DateTime.Now;

            if ((string.IsNullOrEmpty(txtadmissao.Text.Trim())) ||
                (!txtcpf.MaskCompleted) || (!txttelefone.MaskCompleted) ||
                (string.IsNullOrEmpty(txtcargo.Text.Trim())) || (string.IsNullOrEmpty(txtcpf.Text.Trim())) ||
                (string.IsNullOrEmpty(txtemail.Text.Trim())) || (string.IsNullOrEmpty(txtendereco.Text.Trim())) ||
                (string.IsNullOrEmpty(txtgenero.Text.Trim())) || (string.IsNullOrEmpty(txtnascimento.Text.Trim())) ||
                (string.IsNullOrEmpty(txtnome.Text.Trim())) || (string.IsNullOrEmpty(txtsalariobase.Text.Trim())) ||
                (string.IsNullOrEmpty(txttelefone.Text.Trim())))
            {
                frmAlerta.Alerta("Preencha todos os campos.", frmAlerta.enmType.Campos);
            }
            else
            {
                if (txtNivel.Text != "1" && txtNivel.Text != "2")
                {
                    txtNivel.ResetText();
                    frmAlerta.Alerta("Níveis apenas 1 ou 2", frmAlerta.enmType.Virgula);
                }
                else
                {
                    if ((DataNascimento > DataAtual) || (DataAdmissao > DataAtual) || (DataNascimento > DataAdmissao))
                    {
                        frmAlerta.Alerta("A data inserida é inválida.", frmAlerta.enmType.Info);
                    }
                    else if (!Validacoes.ValidaCPF(txtcpf.Text))
                    {
                        frmAlerta.Alerta("CPF inválido", frmAlerta.enmType.Virgula);
                    }
                    else
                    {
                        if (MessageBox.Show("Deseja cadastrar o funcionário?", "Japapito Refeições", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            try
                            {
                                conexao.Open();
                                MySqlCommand cmd = new MySqlCommand("insert into tbfuncionariojp (idfuncionario, nome, email, genero, salario, endereco, telefone, cpf, nascimento, admissao, cargo, nivel) values (null,@nome,@email,@genero,@salario,@endereco,@telefone,@cpf,@nascimento,@admissao,@cargo,@nivel)", conexao);
                                cmd.Parameters.AddWithValue("@nome", txtnome.Text);
                                cmd.Parameters.AddWithValue("@email", txtemail.Text);
                                cmd.Parameters.AddWithValue("@genero", txtgenero.Text);
                                cmd.Parameters.AddWithValue("@salario", txtsalariobase.Text);
                                cmd.Parameters.AddWithValue("@endereco", txtendereco.Text);
                                cmd.Parameters.AddWithValue("@telefone", txttelefone.Text);
                                cmd.Parameters.AddWithValue("@cpf", txtcpf.Text);
                                cmd.Parameters.AddWithValue("@nascimento", txtnascimento.Text);
                                cmd.Parameters.AddWithValue("@admissao", txtadmissao.Text);
                                cmd.Parameters.AddWithValue("@cargo", txtcargo.Text);
                                cmd.Parameters.AddWithValue("@nivel", txtNivel.Text);
                                cmd.ExecuteNonQuery();

                                frmAlerta.Alerta("Usuário cadastrado.", frmAlerta.enmType.Success);

                                txtnome.Enabled = false;
                                txtnascimento.Enabled = false;
                                txttelefone.Enabled = false;
                                txtgenero.Enabled = false;
                                txtcpf.Enabled = false;
                                txtemail.Enabled = false;
                                txtendereco.Enabled = false;
                                txtsalariobase.Enabled = false;
                                txtcargo.Enabled = false;
                                txtadmissao.Enabled = false;
                                btnEditar.Visible = true;
                                btnApagar.Visible = true;
                                txtNivel.Enabled = false;
                                btnApagar.Location = new Point(212, 410);
                                btnCadastrar.Visible = false;

                                timer1.Start();
                            }
                            catch
                            {
                                frmAlerta.Alerta("Ocorreu um erro.", frmAlerta.enmType.Error);
                            }
                            finally
                            {
                                conexao.Close();
                            }
                        }
                    }
                }
            }
        }
        private void btnapagar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja realmente apagar o funcionário?", "Japapito Refeições ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    conexao.Open();
                    MySqlCommand cmd = new MySqlCommand("delete from tbfuncionariojp where idfuncionario=@codigo", conexao);
                    cmd.Parameters.AddWithValue("@codigo", txtCodigo.Text);
                    cmd.ExecuteNonQuery();
                    frmAlerta.Alerta("Cliente removido com sucesso.", frmAlerta.enmType.Success);
                    conexao.Close();

                    txtadmissao.Enabled = false;
                    txtcargo.Enabled = false;
                    txtCodigo.Enabled = false;
                    txtcpf.Enabled = false;
                    txtemail.Enabled = false;
                    txtendereco.Enabled = false;
                    txtgenero.Enabled = false;
                    txtnascimento.Enabled = false;
                    txtnome.Enabled = false;
                    txtsalariobase.Enabled = false;
                    txttelefone.Enabled = false;
                    txtNivel.Enabled = false;
                    btnApagar.Visible = false;
                    btnCadastrar.Visible = false;
                    btnEditar.Visible = false;
                    btnSalvar.Visible = false;

                    txtadmissao.ResetText();
                    txtcargo.ResetText();
                    txtCodigo.ResetText();
                    txtcpf.ResetText();
                    txtemail.ResetText();
                    txtendereco.ResetText();
                    txtgenero.ResetText();
                    txtnascimento.ResetText();
                    txtnome.ResetText();
                    txtsalariobase.ResetText();
                    txttelefone.ResetText();
                    txttelefone.ResetText();
                    txtNivel.ResetText();

                    timer1.Start();
                }
                catch
                {
                    frmAlerta.Alerta("Ocorreu um erro.", frmAlerta.enmType.Error);
                }
                finally
                {
                    conexao.Close();
                }
            }
        }
        private void btneditar_Click(object sender, EventArgs e)
        {
            btnApagar.Location = new Point(210, 410);
            btnSalvar.Location = new Point(118, 410);

            txtnome.Enabled = true;
            txtnascimento.Enabled = true;
            txttelefone.Enabled = true;
            txtgenero.Enabled = true;
            txtcpf.Enabled = true;
            txtemail.Enabled = true;
            txtendereco.Enabled = true;
            txtsalariobase.Enabled = true;
            txtcargo.Enabled = true;
            txtadmissao.Enabled = true;
            txtNivel.Enabled = true;

            btnEditar.Visible = false;
            btnSalvar.Visible = true;
            btnSalvar.Location = new Point(118, 410);
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            this.txtnascimento.CustomFormat = "dd/MM/yy";
            DateTime DataNascimento = txtnascimento.Value;
            DateTime DataAdmissao = txtadmissao.Value;
            DateTime DataAtual = DateTime.Now;
            if (!Validacoes.ValidaCPF(txtcpf.Text))
            {
                frmAlerta.Alerta("CPF inválido", frmAlerta.enmType.Virgula);
            }
            else
            {
                if (txtNivel.Text != "1" && txtNivel.Text != "2")
                {
                    txtNivel.ResetText();
                    frmAlerta.Alerta("Níveis apenas 1 ou 2", frmAlerta.enmType.Virgula);
                }
                else
                {
                    if ((string.IsNullOrEmpty(txtadmissao.Text.Trim())) || (!txtcpf.MaskCompleted) || (!txttelefone.MaskCompleted) || (string.IsNullOrEmpty(txtcargo.Text.Trim())) || (string.IsNullOrEmpty(txtcpf.Text.Trim())) || (string.IsNullOrEmpty(txtemail.Text.Trim())) || (string.IsNullOrEmpty(txtendereco.Text.Trim())) || (string.IsNullOrEmpty(txtgenero.Text.Trim())) || (string.IsNullOrEmpty(txtnascimento.Text.Trim())) || (string.IsNullOrEmpty(txtnome.Text.Trim())) || (string.IsNullOrEmpty(txtsalariobase.Text.Trim())) || (string.IsNullOrEmpty(txttelefone.Text.Trim())))
                    {
                        frmAlerta.Alerta("Preencha todos os campos.", frmAlerta.enmType.Campos);
                    }
                    else if ((DataNascimento > DataAtual) || (DataAdmissao > DataAtual))
                    {
                        frmAlerta.Alerta("Insira uma data válida.", frmAlerta.enmType.Error);
                    }
                    else
                    {
                        if (MessageBox.Show("Deseja realmente salvar a edição do registro?", "Refeições", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            try
                            {
                                conexao.Open();

                                MySqlCommand cmd = new MySqlCommand("update tbfuncionariojp set nome = @nome, email = @email, genero = @genero, salario = @salario, endereco = @endereco, telefone = @telefone, cpf = @cpf, nascimento = @nascimento, admissao = @admissao, cargo = @cargo, nivel = @nivel where idfuncionario=@codigo", conexao);

                                cmd.Parameters.AddWithValue("@codigo", txtCodigo.Text);
                                cmd.Parameters.AddWithValue("@nome", txtnome.Text);
                                cmd.Parameters.AddWithValue("@email", txtemail.Text);
                                cmd.Parameters.AddWithValue("@genero", txtgenero.Text);
                                cmd.Parameters.AddWithValue("@salario", txtsalariobase.Text);
                                cmd.Parameters.AddWithValue("@endereco", txtendereco.Text);
                                cmd.Parameters.AddWithValue("@telefone", txttelefone.Text);
                                cmd.Parameters.AddWithValue("@cpf", txtcpf.Text);
                                cmd.Parameters.AddWithValue("@nascimento", txtnascimento.Text);
                                cmd.Parameters.AddWithValue("@admissao", txtadmissao.Text);
                                cmd.Parameters.AddWithValue("@cargo", txtcargo.Text);
                                cmd.Parameters.AddWithValue("@nivel", txtNivel.Text);

                                cmd.ExecuteNonQuery();

                                frmAlerta.Alerta("Usuário atualizado com sucesso", frmAlerta.enmType.Success);

                                btnSalvar.Visible = true;
                                txtadmissao.Enabled = false;
                                txtcargo.Enabled = false;
                                txtCodigo.Enabled = false;
                                txtcpf.Enabled = false;
                                txtemail.Enabled = false;
                                txtendereco.Enabled = false;
                                txtgenero.Enabled = false;
                                txtnascimento.Enabled = false;
                                txtnome.Enabled = false;
                                txtsalariobase.Enabled = false;
                                txttelefone.Enabled = false;
                                txtNivel.Enabled = false;

                                btnEditar.Visible = true;
                                btnSalvar.Visible = false;
                                timer1.Start();
                            }
                            catch
                            {
                                frmAlerta.Alerta("Ocorreu um erro.", frmAlerta.enmType.Error);
                            }
                            finally
                            {
                                conexao.Close();
                            }
                        }
                    }
                }
            }
        }
        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand("select * from tbfuncionariojp where idfuncionario = @codigo", conexao);
                cmd.Parameters.AddWithValue("@codigo", txtPesquisar.Text);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                txtCodigo.Text = reader["idfuncionario"].ToString();
                txtnome.Text = reader["nome"].ToString();
                txtnascimento.Text = reader["nascimento"].ToString();
                txttelefone.Text = reader["telefone"].ToString();
                txtgenero.Text = reader["genero"].ToString();
                txtcpf.Text = reader["cpf"].ToString();
                txtemail.Text = reader["email"].ToString();
                txtendereco.Text = reader["endereco"].ToString();
                txtsalariobase.Text = reader["salario"].ToString();
                txtcargo.Text = reader["cargo"].ToString();
                txtadmissao.Text = reader["admissao"].ToString();
                txtNivel.Text = reader["nivel"].ToString();

                frmAlerta.Alerta("Usuário encontrado", frmAlerta.enmType.Success);
                btnCadastrar.Visible = false;
                btnEditar.Visible = true;
                btnSalvar.Visible = false;
                btnApagar.Visible = true;
                txtnome.Enabled = false;
                txtnascimento.Enabled = false;
                txttelefone.Enabled = false;
                txtgenero.Enabled = false;
                txtcpf.Enabled = false;
                txtemail.Enabled = false;
                txtendereco.Enabled = false;
                txtsalariobase.Enabled = false;
                txtcargo.Enabled = false;
                txtadmissao.Enabled = false;
                txtNivel.Enabled = false;

                btnEditar.Visible = true;
                btnApagar.Visible = true;
                btnApagar.Location = new Point(212, 410);
            }
            catch
            {
                frmAlerta.Alerta("Usuário não encontrado.", frmAlerta.enmType.Error);
            }
            finally
            {
                conexao.Close();
            }
        }
        private void txtgenero_Leave(object sender, EventArgs e)
        {
            if ((txtgenero.Text == "MASCULINO") || (txtgenero.Text == "Feminino") || (txtgenero.Text == "Masculino") || (txtgenero.Text == "FEMININO"))
            {

            }
            else
            {
                frmAlerta.Alerta("Masculino ou Feminino.", frmAlerta.enmType.Virgula);
                txtgenero.ResetText();
            }
        }
        private void txtsalariobase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                frmAlerta.Alerta("Apenas números e virgulas", frmAlerta.enmType.Virgula);
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                frmAlerta.Alerta("O campo só aceita uma virgula", frmAlerta.enmType.Virgula);
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                frmAlerta.Alerta("Apenas números e virgulas", frmAlerta.enmType.Virgula);
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                frmAlerta.Alerta("O campo só aceita uma virgula", frmAlerta.enmType.Virgula);
            }
        }
        private void TelaFuncionarios_Load(object sender, EventArgs e)
        {
            MySqlConnection conexao2 = new MySqlConnection("server=localhost;port=3306;uid=root;password=;database=bdjapapito2");
            try
            {
                conexao2.Open();
                MySqlCommand cmd = new MySqlCommand("select idfuncionario as ID, nome as Nome, nivel as Nível from tbfuncionariojp", conexao2);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dgvFuncionarios.DataSource = dt;
                    dgvFuncionarios.Columns[0].Width = 50;
                    dgvFuncionarios.Columns[1].Width = 140;
                    dgvFuncionarios.Columns[2].Width = 50;
                }
            }
            catch
            {
                frmAlerta.Alerta("Não foi possível encontrar.", frmAlerta.enmType.Error);
            }
            finally
            {
                conexao2.Close();
            }
        }
        private void txtNivel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                frmAlerta.Alerta("Apenas números", frmAlerta.enmType.Virgula);
            }
        }
        public class Validacoes
        {
            public static bool ValidaCPF(string vrCPF)
            {
                {
                    string valor = vrCPF.Replace(".", "");
                    valor = valor.Replace("-", "");
                    if (valor.Length != 11)
                        return false;
                    bool igual = true;
                    for (int i = 1; i < 11 && igual; i++)
                        if (valor[i] != valor[0])
                            igual = false;
                    if (igual || valor == "12345678909")
                        return false;
                    int[] numeros = new int[11];
                    for (int i = 0; i < 11; i++)
                        numeros[i] = int.Parse(
                          valor[i].ToString());
                    int soma = 0;
                    for (int i = 0; i < 9; i++)
                        soma += (10 - i) * numeros[i];
                    int resultado = soma % 11;
                    if (resultado == 1 || resultado == 0)
                    {
                        if (numeros[9] != 0)

                            return false;
                    }
                    else if (numeros[9] != 11 - resultado)
                        return false;
                    soma = 0;
                    for (int i = 0; i < 10; i++)
                        soma += (11 - i) * numeros[i];
                    resultado = soma % 11;
                    if (resultado == 1 || resultado == 0)
                    {
                        if (numeros[10] != 0)
                            return false;
                    }
                    else
                        if (numeros[10] != 11 - resultado)
                        return false;
                    return true;
                }
            }
        }
        private void txtsalariobase_Leave(object sender, EventArgs e)
        {
            if (txtsalariobase.Text == "")
                return;
            try
            {
                double valor = Convert.ToDouble(txtsalariobase.Text.Replace("R$", ""));
                txtsalariobase.Text = String.Format("{0:c}", valor);
            }
            catch
            {
                txtsalariobase.Text = "";
                frmAlerta.Alerta("Valor inválido.", frmAlerta.enmType.Info);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            MySqlConnection conexao2 = new MySqlConnection("server=localhost;port=3306;uid=root;password=;database=bdjapapito2");
            try
            {
                conexao2.Open();
                MySqlCommand cmd = new MySqlCommand("select idfuncionario ID, nome as Nome, nivel as Nível from tbfuncionariojp", conexao2);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dgvFuncionarios.DataSource = dt;
                    dgvFuncionarios.Columns[0].Width = 50;
                    dgvFuncionarios.Columns[1].Width = 140;
                    dgvFuncionarios.Columns[2].Width = 50;
                }
            }
            catch
            {
                frmAlerta.Alerta("Não foi possível encontrar.", frmAlerta.enmType.Error);
            }
            finally
            {
                conexao2.Close();
            }
            timer1.Stop();
        }
        private void dgvFuncionarios_SelectionChanged(object sender, EventArgs e)
        {
            int contlinhas = dgvFuncionarios.SelectedRows.Count;
            if (contlinhas > 0)
            {
                MySqlConnection conexao2 = new MySqlConnection("server=localhost;port=3306;uid=root;password=;database=bdjapapito2");
                try
                {
                    conexao2.Open();
                    MySqlCommand cmd = new MySqlCommand("select * from tbfuncionariojp where idfuncionario = @codigo", conexao2);
                    cmd.Parameters.AddWithValue("@codigo", dgvFuncionarios.SelectedRows[0].Cells[0].Value.ToString());
                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {
                        txtCodigo.Text = reader["idfuncionario"].ToString();
                        txtnome.Text = reader["nome"].ToString();
                        txtnascimento.Text = reader["nascimento"].ToString();
                        txttelefone.Text = reader["telefone"].ToString();
                        txtgenero.Text = reader["genero"].ToString();
                        txtcpf.Text = reader["cpf"].ToString();
                        txtemail.Text = reader["email"].ToString();
                        txtendereco.Text = reader["endereco"].ToString();
                        txtsalariobase.Text = reader["salario"].ToString();
                        txtcargo.Text = reader["cargo"].ToString();
                        txtadmissao.Text = reader["admissao"].ToString();
                        txtNivel.Text = reader["nivel"].ToString();

                        btnCadastrar.Visible = false;
                        btnEditar.Visible = true;
                        btnSalvar.Visible = false;
                        btnApagar.Visible = true;
                        txtnome.Enabled = false;
                        txtnascimento.Enabled = false;
                        txttelefone.Enabled = false;
                        txtgenero.Enabled = false;
                        txtcpf.Enabled = false;
                        txtemail.Enabled = false;
                        txtendereco.Enabled = false;
                        txtsalariobase.Enabled = false;
                        txtcargo.Enabled = false;
                        txtadmissao.Enabled = false;
                        txtNivel.Enabled = false;

                        btnEditar.Visible = true;
                        btnApagar.Visible = true;
                        btnApagar.Location = new Point(212, 410);
                    }
                }
                catch
                {
                    frmAlerta.Alerta("Usuário não encontrado.", frmAlerta.enmType.Error);
                }
                finally
                {
                    conexao2.Close();
                }
            }
        }
        private void txtcpf_Leave(object sender, EventArgs e)
        {
            string cpfInput = txtcpf.Text.Replace(" ", "").Replace("-", "");
            if (!Validacoes.ValidaCPF(cpfInput) && (!string.IsNullOrWhiteSpace(cpfInput)))
            {
                frmAlerta.Alerta("CPF inválido", frmAlerta.enmType.Virgula);
                txtcpf.ResetText();
            }
        }
        private void txtnascimento_Leave(object sender, EventArgs e)
        {
            this.txtnascimento.CustomFormat = "dd/MM/yy";
            DateTime DataNascimento = txtnascimento.Value;
            DateTime DataAdmissao = txtadmissao.Value;
            DateTime DataAtual = DateTime.Now;

            if (DataNascimento > DataAtual)
            {
                frmAlerta.Alerta("A data de nascimento é inválida.", frmAlerta.enmType.Info);
            }
        }
        private void txtadmissao_Leave(object sender, EventArgs e)
        {
            this.txtnascimento.CustomFormat = "dd/MM/yy";
            DateTime DataNascimento = txtnascimento.Value;
            DateTime DataAdmissao = txtadmissao.Value;
            DateTime DataAtual = DateTime.Now;

            if ((DataAdmissao > DataAtual) || (DataAdmissao < DataNascimento))
            {
                frmAlerta.Alerta("A data de admissão é inválida.", frmAlerta.enmType.Info);
            }
        }
        private void txtNivel_Leave(object sender, EventArgs e)
        {
            if (txtNivel.Text != "1" && txtNivel.Text != "2" && !string.IsNullOrEmpty(txtNivel.Text.Trim()))
            {
                txtNivel.ResetText();
                frmAlerta.Alerta("Níveis apenas 1 ou 2", frmAlerta.enmType.Virgula);
            }
        }
        private void txttelefone_Leave(object sender, EventArgs e)
        {
            string telefoneInput = new string(txttelefone.Text.Where(char.IsDigit).ToArray());
            if (!string.IsNullOrWhiteSpace(telefoneInput) && telefoneInput.Length != 11)
            {
                txttelefone.ResetText();
                frmAlerta.Alerta("Telefone incompleto.", frmAlerta.enmType.Virgula);
            }
        }
    }
}