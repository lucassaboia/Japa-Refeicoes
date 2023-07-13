using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetoCSGrupo
{
    class Banco
    {
        private static MySqlConnection conexao;

        private static MySqlConnection ConexaoBanco()
        {
            conexao = new MySqlConnection("server=localhost; port=3306; uid=root; password =; database=bdjapapito2");
            conexao.Open();
            return conexao;
        }

        public static DataTable dql(string sql) // SELECT
        {
            MySqlDataReader reader = null;
            DataTable dt = new DataTable();

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, ConexaoBanco());
                reader = cmd.ExecuteReader();
                dt.Load(reader);
                return dt;
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                ConexaoBanco().Close();
            }
             ;
        }
        public void Alerta(string msg, frmAlerta.enmType type)
        {
            frmAlerta frm = new frmAlerta();
            frm.showAlert(msg, type);
        }
        public static void dml(string sql, string msgOK = null, string msgERRO = null) // DATA MANIPULATION LANGUAEG (INSERT,DELETE,UPDATE)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, ConexaoBanco());
                cmd.ExecuteNonQuery();

                if (msgOK != null)
                {
                    MessageBox.Show(msgOK, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(msgERRO, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw erro;
            }
            finally
            {

            }
        }

        public static void dmlVenda(string sql, string msgOK = null, string msgERRO = null) // DATA MANIPULATION LANGUAEG (INSERT,DELETE,UPDATE)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, ConexaoBanco());
                Properties.Settings.Default.idVenda = cmd.ExecuteScalar().ToString();

                if (msgOK != null)
                {
                    MessageBox.Show(msgOK, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(msgERRO, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw erro;
            }
            finally
            {

            }
        }
    }
}
