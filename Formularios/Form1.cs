using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCSGrupo
{
    public partial class Form1 : Form
    {
        int mov;
        int movX;
        int movY;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            panelLateral.Height = btnHome.Height;
            panelLateral.Top = btnHome.Top;

            this.Location = new Point(150, 40);

            int nivel = Properties.Settings.Default.usuarioNivel;

            if (nivel == 1)
            {
                lblUsuario.Text = "Bem vindo - Funcionário " + Properties.Settings.Default.usuarioConectado;
                btnFuncionarios.Visible = false;
                btnEstoque.Visible = false;
                btnPedidos.Visible = true;
                btnVenda.Visible = true;


            }
            else if (nivel == 2)
            {
                lblUsuario.Text = "Bem vindo - Funcionário " + Properties.Settings.Default.usuarioConectado;
                btnFuncionarios.Visible = true;
                btnEstoque.Visible = true;
                btnPedidos.Visible = false;
                btnVenda.Visible = false;
                btnEstoque.Location = new Point(10, 116);
                btnFuncionarios.Location = new Point(10, 176);
            }
            else
            {
                lblUsuario.Text = "Você está usando o modo demonstração.";
                btnFuncionarios.Visible = true;
                btnEstoque.Visible = true;
                btnPedidos.Visible = true;
                btnVenda.Visible = true;
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
        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente deslogar?",
                      "Japapito Refeições",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Information) == DialogResult.Yes)
            {
                frmLogin TelaLogin = new frmLogin();
                TelaLogin.Show();
                Dispose();
            }
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?",
                      "Japapito Refeições",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
        private void btnPedidos_Click(object sender, EventArgs e)
        {
            panelLateral.Height = btnPedidos.Height;
            panelLateral.Top = btnPedidos.Top;
            telaPedidos1.Visible = true;
            telaEstoque1.Visible = false;
            telaFuncionarios1.Visible = false;
            telaSobre1.Visible = false;
            telaVendas1.Visible = false;
            firstCustomControl1.Visible = false;
        }
        private void btnEstoque_Click(object sender, EventArgs e)
        {
            panelLateral.Height = btnEstoque.Height;
            panelLateral.Top = btnEstoque.Top;
            telaPedidos1.Visible = false;
            telaEstoque1.Visible = true;
            telaFuncionarios1.Visible = false;
            telaSobre1.Visible = false;
            telaVendas1.Visible = false;
            firstCustomControl1.Visible = false;
        }
        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            panelLateral.Height = btnFuncionarios.Height;
            panelLateral.Top = btnFuncionarios.Top;
            telaPedidos1.Visible = false;
            telaEstoque1.Visible = false;
            telaFuncionarios1.Visible = true;
            telaSobre1.Visible = false;
            telaVendas1.Visible = false;
            firstCustomControl1.Visible = false;
        }
        private void btnVenda_Click(object sender, EventArgs e)
        {
            panelLateral.Height = btnVenda.Height;
            panelLateral.Top = btnVenda.Top;
            telaVendas1.Visible = true;
            firstCustomControl1.Visible = false;
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            panelLateral.Height = btnHome.Height;
            panelLateral.Top = btnHome.Top;
            telaVendas1.Visible = false;
            firstCustomControl1.Visible = true;
            telaPedidos1.Visible = false;
            telaEstoque1.Visible = false;
            telaFuncionarios1.Visible = false;
        }
        private void btnSobre_Click(object sender, EventArgs e)
        {
            panelLateral.Height = btnSobre.Height;
            panelLateral.Top = btnSobre.Top;
            telaPedidos1.Visible = false;
            telaEstoque1.Visible = false;
            telaFuncionarios1.Visible = false;
            telaSobre1.Visible = true;
            telaVendas1.Visible = false;
            firstCustomControl1.Visible = false;
        }
    }
}
