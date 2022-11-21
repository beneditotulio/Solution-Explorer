using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace sistema_de_gestao_stock.Telas
{
    public partial class FrmCadastroUnidade : Form
    {
        public FrmCadastroUnidade()
        {
            InitializeComponent();
        }
        void carrega_codigo()
        {
       
            SqlCommand cmd = null;
            SqlConnection conn = null;
            SqlDataReader dread = null;


            conn = conexao.conneccao.abra_connecao();
            conn.Open();
            string bd = "select Id_unidade from TB_unidade Order By(Id_unidade) desc";
            cmd = new SqlCommand(bd, conn);
            dread = cmd.ExecuteReader();
            if (dread.Read())
            {
                txt_unidade_cod.Text = (Convert.ToInt32(dread["Id_unidade"].ToString()) + Convert.ToInt32("1")).ToString();
                
            }
            else
            {
                txt_unidade_cod.Text = "1";

            }


            cmd.Dispose();
            conn.Close();

        }
        void limpar()
        {
            txt_unidade.Text = "";
        }

        private void btnSalva_enc_Click(object sender, EventArgs e)
        {
            if (txt_unidade.Text == string.Empty)
            {
                MessageBox.Show("Porfavor precher os campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                SqlCommand cmd = null;
                SqlConnection conn = null;
                try
                {
                    conn = conexao.conneccao.abra_connecao();
                    conn.Open();
                    string db = "insert into TB_unidade(Id_unidade,unidade)" +
                        "values('" + txt_unidade_cod.Text + "','" + txt_unidade.Text + "')";
                    cmd = new SqlCommand(db, conn);
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Registro gravado com sucesso");

                    }
                    limpar();
                    carrega_codigo();
                }


                catch (Exception ex)
                {
                    MessageBox.Show("erro de insercao" + ex);
                }
                finally
                {

                    conn.Close();
                    cmd.Dispose();
                }
            }

        }

        private void unidade_Load(object sender, EventArgs e)
        {
            carrega_codigo();
        }

        private void btnSai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
