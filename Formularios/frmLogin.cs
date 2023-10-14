using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetoCSGrupo
{
    public partial class frmLogin : Form
    {
        int mov;
        int movX;
        int movY;

        MySqlConnection conexao = new MySqlConnection("server=localhost;port=3306;uid=root;password=;database=bdjapapito2");
        public frmLogin()
        {
            InitializeComponent();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.Location = Screen.AllScreens[0].WorkingArea.Location;
            this.Location = new Point(240, 94);
        }
        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand($"select * from tbfuncionariojp where nome='{txtLogin.Text}' and cpf='{txtSenha.Text}' ", conexao);
                conexao.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                if ((txtLogin.Text == "Digite seu login") || (txtSenha.Text == "Digite seu CPF") || (string.IsNullOrEmpty(txtSenha.Text.Trim())) || (string.IsNullOrEmpty(txtLogin.Text.Trim())))
                {
                    frmAlerta.Alerta("Preencha todos os campos", frmAlerta.enmType.Campos);
                }
                else if (reader.Read())
                {
                    Properties.Settings.Default.usuarioConectado = reader["nome"].ToString();
                    Properties.Settings.Default.usuarioNivel = (int)reader["nivel"];

                    frmAlerta.Alerta("Usuário logado com sucesso", frmAlerta.enmType.Success);

                    Form1 telaPrincipal = new Form1();
                    telaPrincipal.Show();
                    this.Hide();
                }
                else
                {
                    frmAlerta.Alerta("Usuário inválido", frmAlerta.enmType.Error);
                }
            }
            catch (Exception erro)
            {
                frmAlerta.Alerta("Erro de conexão", frmAlerta.enmType.Warning);
                MessageBox.Show("Não foi possível exibir" + erro);
            }
            finally
            {
                conexao.Close();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?",
                      "Japapito Delivery's",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?",
                     "Japapito Delivery's",
                      MessageBoxButtons.YesNo,
                      MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSenha.Text.Trim()))
            {
                panelSenha.BackColor = Color.White;
            }

            else if (txtSenha.Text == "Digite seu CPF")
            {
                btnOlho.Image = Properties.Resources.icons8_hide_25px;
                panelSenha.BackColor = Color.White;
                btnOlho.Text = ".";
            }
            else
            {
                panelSenha.BackColor = Color.SeaGreen;
            }
        }
        private void txtSenha_Enter(object sender, EventArgs e)
        {
            if (txtSenha.Text == "Digite seu CPF")
            {
                txtSenha.Clear();
                txtSenha.ForeColor = Color.Silver;
                txtSenha.UseSystemPasswordChar = true;
            }
        }
        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSenha.Text.Trim()))
            {
                txtSenha.Text = "Digite seu CPF";
                txtSenha.ForeColor = Color.DimGray;
                txtSenha.UseSystemPasswordChar = false;
            }
        }
        private void btnOlho_Click(object sender, EventArgs e)
        {
            if ((txtSenha.Text == "Digite seu CPF") && (txtSenha.ForeColor == Color.DimGray))
            {
                frmAlerta.Alerta("Não há senha para ser mostrada", frmAlerta.enmType.Error);
            }
            else if (btnOlho.Text == ".")
            {

                btnOlho.Image = Properties.Resources.icons8_eye_25px;
                txtSenha.UseSystemPasswordChar = false;
                btnOlho.Text = " ";
            }
            else
            {
                btnOlho.Image = Properties.Resources.icons8_hide_25px;
                txtSenha.UseSystemPasswordChar = true;
                btnOlho.Text = ".";
            }
        }
        private void txtLogin_Enter(object sender, EventArgs e)
        {
            if (txtLogin.Text == "Digite seu login")
            {
                txtLogin.Clear();
                txtLogin.ForeColor = Color.Silver;
            }
        }
        private void txtLogin_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLogin.Text.Trim()))
            {
                txtLogin.Text = "Digite seu login";
                txtLogin.ForeColor = Color.DimGray;
            }
        }
        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLogin.Text) || (txtLogin.Text == "Digite seu login"))
            {
                panelLogin.BackColor = Color.White;
            }
            else
            {
                panelLogin.BackColor = Color.SeaGreen;
            }
        }
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }
        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }
        private void frmLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }
        private void frmLogin_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
    }
}
