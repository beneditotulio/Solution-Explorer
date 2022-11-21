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
    public partial class fornecedor : Form
    {
        conexao.validacao valida =new conexao.validacao();
        public fornecedor()
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
            string bd = "select Idfornecedor from TB_fornecedor Order By(Idfornecedor) desc";
            cmd = new SqlCommand(bd, conn);
            dread = cmd.ExecuteReader();
            if (dread.Read())
            {
                txtCodigo.Text = (Convert.ToInt32(dread["Idfornecedor"].ToString()) + Convert.ToInt32("1")).ToString();
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
        void limpa()
        {
            txtCodigo.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtApelido.Text = string.Empty;
            cboSexo.SelectedIndex = -1;
            txtTelefone.Text = string.Empty;
            txtTelefone2.Text = string.Empty;
            txtEmail.Text = string.Empty;
        }

        private void fornecedor_Load(object sender, EventArgs e)
        {
            limpa();
            carrega_sexo();
            carrega_codigo();
        }
        public string sexo_fornecedor;
        private void cboSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = null;
            SqlConnection conn = null;
            SqlDataReader dread = null;
            conn = conexao.conneccao.abra_connecao();
            conn.Open();
            string bd = "select IdSexo from TB_sexo where Sexo like '"+cboSexo.Text+"'";
            cmd = new SqlCommand(bd, conn);
            dread = cmd.ExecuteReader();
            if(dread.Read())
            {
              sexo_fornecedor= dread["Idsexo"].ToString();
            }
                
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {

            if ( txtNome.Text == string.Empty|| txtApelido.Text == string.Empty 
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
                    string db = "insert into TB_fornecedor(Idfornecedor,Nome,Apelido,Sexo,Contacto,Telefone_Alternativo,Email)" +
                        "values('" + txtCodigo.Text + "','" + txtNome.Text + "','" + txtApelido.Text + "', '" + sexo_fornecedor + "','" + txtTelefone.Text + "','" + txtTelefone2.Text + "','" + txtEmail.Text + "')";
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

        private void btnNovo_Click(object sender, EventArgs e)
        {
            limpa();
            carrega_codigo();
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            valida.ValidacaoNemeros(e);
        }

        private void txtTelefone2_KeyPress(object sender, KeyPressEventArgs e)
        {
            valida.ValidacaoNemeros(e);
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = null;
            SqlConnection conn = null;
            try
            {
                conn = conexao.conneccao.abra_connecao();
                conn.Open();
                string SQL = "Update TB_fornecedor Set Nome = '" + txtNome.Text + "', Apelido = '" + txtApelido.Text + "'" +
                  " ,Sexo = '" + sexo_fornecedor + "', Contacto = '" + txtTelefone.Text + "',Telefone_Alternativo  = '" + txtTelefone2.Text + "', Email = '" + txtEmail.Text + "'" +
                     " Where idfornecedor= '" + txtCodigo.Text+ "'";
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
                string bd = "Select * From TB_fornecedor Where( Nome like '" + busca + "')";
                cmd = new SqlCommand(bd, conn);
                dread = cmd.ExecuteReader();
                if (dread.Read())
                {
                    txtCodigo.Text = dread["Idfornecedor"].ToString();
                    txtNome.Text =dread["Nome"].ToString();
                    txtApelido.Text =dread["Apelido"].ToString();
                    sexo_fornecedor = dread["Sexo"].ToString();
                    txtTelefone.Text =dread["contacto"].ToString();
                    txtTelefone2.Text =dread["Telefone_Alternativo"].ToString();
                    txtEmail.Text = dread["Email"].ToString();

                    conn = conexao.conneccao.abra_connecao();
                    conn.Open();
                    string bds = "select sexo from TB_sexo where idsexo like'"+sexo_fornecedor+"'" ;
                    cmd = new SqlCommand(bds, conn);
                    dread = cmd.ExecuteReader();
                    cboSexo.Items.Clear();
                    while (dread.Read())
                    {
                        cboSexo.Text=(dread["sexo"].ToString());
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

        private void BtnPesquisa_numero_tel_Click(object sender, EventArgs e)
        {

        }

        private void Btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnApaga_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = null;
            SqlConnection conn = null;
            try
            {
                conn = conexao.conneccao.abra_connecao();
                conn.Open();
                string SQL = "delete from TB_fornecedor Where idfornecedor like '" + txtCodigo.Text + "'";
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
    }
}