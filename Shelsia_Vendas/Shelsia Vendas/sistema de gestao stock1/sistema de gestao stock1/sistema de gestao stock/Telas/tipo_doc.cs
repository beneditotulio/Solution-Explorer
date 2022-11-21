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
    public partial class FrmTipoDoc : Form
    {
        public FrmTipoDoc()
        {
            InitializeComponent();
        }
        void auto_number()
    {
        SqlCommand cmd = null;
        SqlConnection conn = null;
        SqlDataReader dread = null;
        conn = conexao.conneccao.abra_connecao();
        conn.Open();
        string bd = "select Tipo_Documento from TipoDoc order by (Tipo_Documento)desc ";
        cmd =new SqlCommand (bd, conn);
        dread = cmd.ExecuteReader();
            if(dread.Read())
            {
                txt_codigo_doc.Text = (Convert.ToInt32(dread["Tipo_Documento"].ToString()) + Convert.ToInt32("1")).ToString();
            }
            else
            {
                txt_codigo_doc.Text="1";
            }
            conn.Close();
            cmd.Dispose();
            txt_des_doc.Focus();
    }
        void limpar()
        {
            txt_codigo_doc.Text = string.Empty;
            txt_des_doc.Text = string.Empty;
        }
        
        private void btnSalva_Click(object sender, EventArgs e)
        {                
                 SqlCommand cmd = null;
                SqlConnection conn = null;
                SqlDataReader dread = null;
                conn = conexao.conneccao.abra_connecao();
                conn.Open();
                string bd = "select DescricaoDoc from TipoDoc where DescricaoDoc like '"+txt_des_doc.Text+"'  ";
                cmd = new SqlCommand(bd, conn);
                dread = cmd.ExecuteReader();
                if (dread.Read())
                {
                    txt_des_doc.Text= dread["DescricaoDoc"].ToString();
                    MessageBox.Show("JA EXISTE ESTE DOCUMENTO", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    limpar();
                    auto_number();
                    erroprova.SetError(txt_des_doc, "tipo documento");
                    return;
                }
               
                else  if (txt_des_doc.Text == string.Empty)
                {
                MessageBox.Show("Porfavor o tipo documento", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_des_doc.Focus();
                erroprova.SetError(txt_des_doc, "tipo documento");
                 }
           
               else
                {
               conn = conexao.conneccao.abra_connecao();
                conn.Open();
                string databases = "insert into TipoDoc(Tipo_Documento,DescricaoDoc)" +
                   " Values('" + txt_codigo_doc.Text + "','" + txt_des_doc.Text + "')";
                cmd = new SqlCommand(databases, conn);
                int o = cmd.ExecuteNonQuery();
                if (o > 0)
                {
                    MessageBox.Show("dados salvados com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                conn.Close();
                cmd.Dispose();
                limpar();
                auto_number();
                erroprova.SetError(txt_des_doc, "");
            }
        }

        private void tipo_doc_Load(object sender, EventArgs e)
        {
            auto_number();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            limpar();
            auto_number();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
