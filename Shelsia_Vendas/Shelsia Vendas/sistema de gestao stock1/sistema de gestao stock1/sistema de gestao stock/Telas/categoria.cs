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
    public partial class categoria : Form
    {
        public categoria()
        {
            InitializeComponent();
        }
        void limpar()
        {
            txt_categoria_cod.Text = "";
            txt_categoria.Text = "";
        }
        void carrega_codigo()
        {
            SqlCommand cmd = null;
            SqlConnection conn = null;
            SqlDataReader dread = null;


            conn = conexao.conneccao.abra_connecao();
            conn.Open();
            string bd = "select Idcategoria from TB_categoria Order By(Idcategoria) desc";
            cmd = new SqlCommand(bd, conn);
            dread = cmd.ExecuteReader();
            if (dread.Read())
            {
                txt_categoria_cod.Text = (Convert.ToInt32(dread["Idcategoria"].ToString()) + Convert.ToInt32("1")).ToString();

            }
            else
            {
                txt_categoria_cod.Text = "1";

            }


            cmd.Dispose();
            conn.Close();

        }
        private void btnSalva_enc_Click(object sender, EventArgs e)
        {
            if (txt_categoria.Text == string.Empty)
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
                    string db = "insert into TB_categoria(Idcategoria,categoia)" +
                        "values('" + txt_categoria_cod.Text + "','" + txt_categoria.Text + "')";
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

        private void categoria_Load(object sender, EventArgs e)
        {
            limpar();
            carrega_codigo();
        }

        private void BtnSai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


        
    



