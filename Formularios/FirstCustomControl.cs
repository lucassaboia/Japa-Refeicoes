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
    public partial class FirstCustomControl : UserControl
    {
        public FirstCustomControl()
        {
            InitializeComponent();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {



            lblHora.Text = DateTime.Now.ToString("HH");
            int tempo = Convert.ToInt32(lblHora.Text);


            if ((tempo >= 08) && (tempo <= 14))
            {
                lblSJM.Text = "ABERTO";
                lblPavuna.Text = "ABERTO";
                lblTiradentes.Text = "ABERTO";
                lblEden.Text = "ABERTO";
                lblSJM.Text = "ABERTO";

                lblSJM.ForeColor = Color.MediumSeaGreen;
                lblPavuna.ForeColor = Color.MediumSeaGreen;
                lblTiradentes.ForeColor = Color.MediumSeaGreen;
                lblEden.ForeColor = Color.MediumSeaGreen;
                lblSJM.ForeColor = Color.MediumSeaGreen;
            }

            else
            {
                lblSJM.Text = "FECHADO";
                lblPavuna.Text = "FECHADO";
                lblTiradentes.Text = "FECHADO";
                lblEden.Text = "FECHADO";
                lblSJM.Text = "FECHADO";

                lblSJM.ForeColor = Color.Red;
                lblPavuna.ForeColor = Color.Red;
                lblTiradentes.ForeColor = Color.Red;
                lblEden.ForeColor = Color.Red;
                lblSJM.ForeColor = Color.Red;
            }

            if ((tempo >= 12) && (tempo <= 21))
            {
                lblBelford.Text = "ABERTO";
                lblCoelhoneto.Text = "ABERTO";

                lblBelford.ForeColor = Color.MediumSeaGreen;
                lblCoelhoneto.ForeColor = Color.MediumSeaGreen;
            }
            else
            {
                lblBelford.Text = "FECHADO";
                lblCoelhoneto.Text = "FECHADO";

                lblBelford.ForeColor = Color.Red;
                lblCoelhoneto.ForeColor = Color.Red;
            }
        }
    

        private void FirstCustomControl_Load(object sender, EventArgs e)
        {
          
        }
    }
}
