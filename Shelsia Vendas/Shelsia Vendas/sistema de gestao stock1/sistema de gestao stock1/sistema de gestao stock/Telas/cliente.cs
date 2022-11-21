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
using Microsoft.VisualBasic;


namespace sistema_de_gestao_stock.Telas
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void BtnSalva_Click(object sender, EventArgs e)
        {

            if (txtNome.Text == string.Empty || txtcracha.Text == string.Empty
                || cboSexo.Text == string.Empty || txtTelefone.Text == string.Empty)
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
                    string db = "insert into TB_cliente(Idcliente,cracha,Nome,Sexo,Contacto1,contacto,Email)" +
                        "values('" + txtCodigo.Text + "','" +txtcracha.Text+ "','" + txtNome.Text + "', '" + sexo_fornecedor + "','" + txtTelefone.Text + "','" + txtTelefone2.Text + "','" + txtEmail.Text + "')";
                    cmd = new SqlCommand(db, conn);
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Registro gravado com sucesso");

                    }
                    limpa();
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
        void limpa()
        {
            txtCodigo.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtcracha.Text = string.Empty;
            cboSexo.SelectedIndex = -1;
            txtTelefone.Text = string.Empty;
            txtTelefone2.Text = string.Empty;
            txtEmail.Text = string.Empty;
        }
        void carrega_codigo()
        {
            SqlCommand cmd = null;
            SqlConnection conn = null;
            SqlDataReader dread = null;
            conn = conexao.conneccao.abra_connecao();
            conn.Open();
            string bd = "select idcliente from TB_cliente Order By(idcliente) desc";
            cmd = new SqlCommand(bd, conn);
            dread = cmd.ExecuteReader();
            if (dread.Read())
            {
                txtCodigo.Text = (Convert.ToInt32(dread["Idcliente"].ToString()) + Convert.ToInt32("1")).ToString();
            }
            else
            {
                txtCodigo.Text = "1";

            }
        }
        void carrega_sexo()
        {
            SqlCommand cmd = null;
            SqlConnection conn = null;
            SqlDataReader dread = null;
            conn = conexao.conneccao.abra_connecao();
            conn.Open();
            string bd = "select sexo from TB_sexo";
            cmd = new SqlCommand(bd, conn);
            dread = cmd.ExecuteReader();
            cboSexo.Items.Clear();
            while (dread.Read())
            {
                cboSexo.Items.Add(dread["sexo"].ToString());
            }
        }
        public string sexo_fornecedor;
        private void BtnNovo_Click(object sender, EventArgs e)
        {
            limpa();
            carrega_codigo();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {

            limpa();
            carrega_sexo();
            carrega_codigo();
        }

        private void CboSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = null;
            SqlConnection conn = null;
            SqlDataReader dread = null;
            conn = conexao.conneccao.abra_connecao();
            conn.Open();
            string bd = "select IdSexo from TB_sexo where Sexo like '" + cboSexo.Text + "'";
            cmd = new SqlCommand(bd, conn);
            dread = cmd.ExecuteReader();
            if (dread.Read())
            {
                sexo_fornecedor = dread["Idsexo"].ToString();
            }

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = null;
            SqlConnection conn = null;
            try
            {
                conn = conexao.conneccao.abra_connecao();
                conn.Open();
                string SQL = "Update TB_cliente Set Nome = '" + txtNome.Text + "', cracha = '" + txtcracha.Text + "'" +
                  " ,Sexo = '" + sexo_fornecedor + "', Contacto1 = '" + txtTelefone.Text + "',Contacto  = '" + txtTelefone2.Text + "', Email = '" + txtEmail.Text + "'" +
                     " Where idcliente like '" + txtCodigo.Text + "'";
                cmd = new SqlCommand(SQL, conn);
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Registo actualizado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar estabelecer conexao com o servidor\n" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            limpa();
            carrega_codigo();

        }

        private void BtnPesquisa_numero_Nome_Click(object sender, EventArgs e)
        {
            string busca = Interaction.InputBox("Por favor introduza os dados para pesquisa do nome");
            if (busca == "")
            {

            }
            else
            {
                SqlCommand cmd = null;
                SqlConnection conn = null;
                SqlDataReader dread = null;
                conn = conexao.conneccao.abra_connecao();
                conn.Open();
                string bd = "Select * From TB_cliente Where( Nome like '" + busca + "')";
                cmd = new SqlCommand(bd, conn);
                dread = cmd.ExecuteReader();
                if (dread.Read())
                {
                    txtCodigo.Text = dread["Idcliente"].ToString();
                    txtNome.Text = dread["Nome"].ToString();
                    txtcracha.Text = dread["cracha"].ToString();
                    sexo_fornecedor = dread["Sexo"].ToString();
                    txtTelefone.Text = dread["contacto1"].ToString();
                    txtTelefone2.Text = dread["contacto"].ToString();
                    txtEmail.Text = dread["Email"].ToString();

                    conn = conexao.conneccao.abra_connecao();
                    conn.Open();
                    string bds = "select sexo from TB_sexo where idsexo like'" + sexo_fornecedor + "'";
                    cmd = new SqlCommand(bds, conn);
                    dread = cmd.ExecuteReader();
                    cboSexo.Items.Clear();
                    while (dread.Read())
                    {
                        cboSexo.Text = (dread["sexo"].ToString());
                    }
                }
                else
                {
                    limpa();
                    carrega_codigo();
                    MessageBox.Show("Registo não encontrado!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }




            }
        }

        private void BtnApaga_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = null;
            SqlConnection conn = null;
            try
            {
                conn = conexao.conneccao.abra_connecao();
                conn.Open();
                string SQL = "delete from TB_cliente Where idcliente like '" + txtCodigo.Text + "'";
                cmd = new SqlCommand(SQL, conn);
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Registo apagado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar estabelecer conexao com o servidor\n" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            limpa();
            carrega_codigo();

        }

        private void Btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }
    }
}
