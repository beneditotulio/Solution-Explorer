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
    public partial class Produtos : Form
    {
        public Produtos()
        {
            InitializeComponent();
        }
        void buscar_produto()

        {
            SqlCommand cmd = null;
            SqlConnection conn = null;
            SqlDataReader dread = null;
            try
            {
                conn = conexao.conneccao.abra_connecao();
                conn.Open();
                string pil = "select * from consulta_produto order by(idproduto)desc";
                cmd = new SqlCommand(pil, conn);
                dread = cmd.ExecuteReader();
                dgv_Produto.Rows.Clear();
                while (dread.Read())
                {

                    dgv_Produto.Rows.Add(dread["idproduto"],
                   dread["produto"],
                   dread["unidade"],
                   dread["Quandide_atual"],
                   dread["categoia"],
                   dread["unidade"]);
                }
            }
            catch (Exception p)
            {
                MessageBox.Show("eroo" + p);
            }
            finally
            {
                conn.Close();
            }

        }
        void limpar()
        {
            txt_cod_p.Text = string.Empty;
            txt_prod.Text = string.Empty;
            cbo_unidade.SelectedIndex = -1;
            txtquatidade.Text = string.Empty;
            cbo_categoria.SelectedIndex = -1;
            txtquatidade.Text = "0";
        }
        void carrega_codigo_p()
        {
            SqlCommand cmd = null;
            SqlConnection conn = null;
            SqlDataReader dread = null;
            conn = conexao.conneccao.abra_connecao();
            conn.Open();
            string bd = "select Idproduto from  TB_produto Order By (Idproduto)desc";
            cmd = new SqlCommand(bd, conn);
            dread = cmd.ExecuteReader();
            if (dread.Read())
            {
                txt_cod_p.Text = (Convert.ToInt32(dread["Idproduto"].ToString()) + Convert.ToInt32("1")).ToString();
            }
            else
            {
                txt_cod_p.Text = "1";

            }
            cmd.Dispose();
            conn.Close();

        }
        void buscar_unidade()
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlDataReader dread = null;
            conn = conexao.conneccao.abra_connecao();
            conn.Open();
            string databases = "select unidade from TB_unidade";
            cmd = new SqlCommand(databases, conn);
            dread = cmd.ExecuteReader();
            cbo_unidade.Items.Clear();
            while (dread.Read())
            {
              cbo_unidade.Items.Add(dread["unidade"].ToString());
            }
            conn.Close();
            cmd.Dispose();
        }
        void buscar_categoria()
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlDataReader dread = null;
            conn = conexao.conneccao.abra_connecao();
            conn.Open();
            string databases = "select categoia from TB_categoria";
            cmd = new SqlCommand(databases, conn);
            dread = cmd.ExecuteReader();
            cbo_categoria.Items.Clear();
            while (dread.Read())
            {
                cbo_categoria.Items.Add(dread["categoia"].ToString());

            }
            conn.Close();
            cmd.Dispose();
        }

        private void Produtos_Load(object sender, EventArgs e)
        {
            buscar_produto();
            txt_prod.Focus();
            carrega_codigo_p();
            buscar_categoria();
            buscar_unidade();
            
 
        }

        private void btnSalva_enc_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = null;
            SqlConnection conn = null;
            SqlDataReader dread=null;
            conn=conexao.conneccao.abra_connecao();
            conn.Open();
            string bd="select produto from TB_produto where produto like '"+txt_prod.Text+"' ";
            cmd=new SqlCommand(bd,conn);
            dread=cmd.ExecuteReader();
            if (dread.Read())
            {
                MessageBox.Show("Descricao ja existente");
                txt_prod.BackColor = Color.Aqua;
                return;
            }


            else if (txt_prod.Text == string.Empty || cbo_unidade.Text == string.Empty || cbo_categoria.Text == string.Empty)
            {
                MessageBox.Show("Porfavor precher os campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {

                try
                {
                    conn = conexao.conneccao.abra_connecao();
                    conn.Open();
                    string db = "insert into TB_produto(Idproduto,produto,unidade,quandide_atual,categoria)" +
                        "values('" + txt_cod_p.Text + "','" + txt_prod.Text + "', '" + cod_unidade + "','" + txtquatidade.Text + "','" + id_categoria + "')";
                    cmd = new SqlCommand(db, conn);
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Registro gravado com sucesso");
                        limpar();
                        carrega_codigo_p();

                    }

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
        public string cod_unidade;
        private void button2_Click(object sender, EventArgs e)
        {
            Telas.FrmCadastroUnidade k = new Telas.FrmCadastroUnidade();
            k.ShowDialog();
        }
        private void cbo_unidade_TextChanged(object sender, EventArgs e)
        {
            

         }
        private void button1_Click(object sender, EventArgs e)
        {
            Telas.categoria k = new Telas.categoria();
            k.ShowDialog();
        }
        public string id_categoria;
        private void cbo_categoria_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void cbo_unidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = null;
            SqlConnection conn = null;
            SqlDataReader dread = null;
            conn = conexao.conneccao.abra_connecao();
            conn.Open();
            string bd = "select Id_unidade from TB_unidade where unidade like'" + cbo_unidade.Text + "'";
            cmd = new SqlCommand(bd, conn);
            dread = cmd.ExecuteReader();
            if (dread.Read())
            {
                cod_unidade = dread["Id_unidade"].ToString();
               
            }
            conn.Close();
            cmd.Dispose();
        }

        private void cbo_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = null;
            SqlConnection conn = null;
            SqlDataReader dread = null;
            conn = conexao.conneccao.abra_connecao();
            conn.Open();
            string bd = "select Idcategoria from TB_categoria where categoia  like'" + cbo_categoria.Text + "'";
            cmd = new SqlCommand(bd, conn);
            dread = cmd.ExecuteReader();
            if (dread.Read())
            {
                id_categoria = dread["Idcategoria"].ToString();
             
            }
            conn.Close();
            cmd.Dispose();
        }

        private void Btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string busca = Interaction.InputBox("Por favor introduza os dados para pesquisa do Produto");
            if (busca == "")
            {

            }
            else
            {
                SqlCommand cmd = null;
                SqlConnection conn = null;
                SqlDataReader dread = null;
                try
                {
                    conn = conexao.conneccao.abra_connecao();
                    conn.Open();
                    string dabases = "Select Idproduto,produto,unidade," +
                        "quandide_atual,categoria From TB_produto  Where(Produto like '" + busca + "')";
                    cmd = new SqlCommand(dabases,conn);
                    dread= cmd.ExecuteReader();
                    if (dread.Read())
                    {
                        txt_cod_p.Text = dread["Idproduto"].ToString();
                        txt_prod.Text = dread["produto"].ToString();
                        cod_unidade = dread["unidade"].ToString();
                        txtquatidade.Text = dread["quandide_atual"].ToString();
                        id_categoria = dread["categoria"].ToString();

                        conn = conexao.conneccao.abra_connecao();
                        conn.Open();
                        string po = "select unidade from TB_unidade where Id_unidade like '"+cod_unidade+"' ";
                        cmd = new SqlCommand(po, conn);
                        dread = cmd.ExecuteReader();
                        if(dread.Read())
                        {
                            cbo_unidade.Text = dread["unidade"].ToString();
                        }
                        conn = conexao.conneccao.abra_connecao();
                        conn.Open();
                        string p = "select categoia from TB_categoria where idcategoria like '" + id_categoria + "' ";
                        cmd = new SqlCommand(p, conn);
                        dread = cmd.ExecuteReader();
                        if (dread.Read())
                        {
                            cbo_categoria.Text = dread["categoia"].ToString();
                        }

                    }
                    else
                    {
                        limpar();
                        carrega_codigo_p();
                        btnSalva_enc.Enabled = true;
                        MessageBox.Show("Registo não encontrado!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro de connecao " + ex);
                }
            }


        }

        private void BtnNovo_enc_Click(object sender, EventArgs e)
        {
            limpar();
            carrega_codigo_p();
        }

        private void Dgv_encomenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           txt_cod_p.Text = (dgv_Produto.CurrentRow.Cells[0].Value).ToString();
            txt_prod.Text = (dgv_Produto.CurrentRow.Cells[1].Value).ToString();
            cbo_unidade.Text = (dgv_Produto.CurrentRow.Cells[2].Value).ToString();
            txtquatidade.Text= (dgv_Produto.CurrentRow.Cells[3].Value).ToString();
            cbo_categoria.Text = (dgv_Produto.CurrentRow.Cells[4].Value).ToString();
        }

        private void Dgv_Produto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnEdit_enc_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = null;
            SqlConnection conn = null;
            try
            {
                conn = conexao.conneccao.abra_connecao();
                conn.Open();
                string SQL = "Update TB_produto Set produto = '" + txt_prod.Text + "', unidade = '" + cod_unidade + "'" +
                    ",quandide_atual  = '" + txtquatidade.Text + "' ,categoria = '" + id_categoria+ "'"+
                     " Where idproduto = '" + txt_cod_p.Text + "'";
                cmd = new SqlCommand(SQL, conn);
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Registo actualizado com sucesso!");
                    limpar();
                    carrega_codigo_p();
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

            }

        private void BtnApaga_enc_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = null;
            SqlConnection conn = null;
            try
            {
                conn = conexao.conneccao.abra_connecao();
                conn.Open();
                string SQL = "delete from TB_produto Where idproduto = '" + txt_cod_p.Text + "'";
                cmd = new SqlCommand(SQL, conn);
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Registo apagado com sucesso!");
                    limpar();
                    carrega_codigo_p();
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

        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buscar_categoria();
            buscar_unidade();
            buscar_produto();
        }
    }
               
   }

