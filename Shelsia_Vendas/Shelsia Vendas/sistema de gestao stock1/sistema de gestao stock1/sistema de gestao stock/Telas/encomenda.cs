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
    public partial class FrmCadastroEncomenda : Form
    {
        conexao.validacao validando = new conexao.validacao();
        public FrmCadastroEncomenda()
        {
            InitializeComponent();
        }
        public static bool validacaoNRdecimal_compra(TextBox txt_compra)
        {
            try
            {

                Decimal d = Convert.ToDecimal(txt_compra.Text);
                return true;
            }
            catch (Exception)
            {
                txt_compra.Text = "0";
                txt_compra.Select(0, txt_compra.Text.Length);
                return false;
            }
        }
        public static bool validacaoNRdecimal_venda(TextBox txt_venda)
        {
            try
            {

                Decimal d = Convert.ToDecimal(txt_venda.Text);
                return true;
            }
            catch (Exception)
            {
                txt_venda.Text = "0";
                txt_venda.Select(0, txt_venda.Text.Length);
                return false;
            }
        }

        void limpa()
        {
            txtorden.Text = "";
            cbo_p.SelectedIndex = -1;
            txt_catg.Text = string.Empty;
            Cbo_fornecedor.SelectedIndex = -1;
            txt_unidade.Text = string.Empty;
            txt_venda.Text = string.Empty;
            txt_compra.Text = string.Empty;
            txt_q_atual.Text = string.Empty;
            txt_q_introduzida.Text = string.Empty;
            txt_q_existente.Text = string.Empty;
        }
        public string id_encomenda, nome_produto, categoroia, data, fornecedor, unidade, p_venda, p_existente, q_existente, q_introduza_q_actual;

        void buscar_encomenda()
        {
            SqlCommand cmd = null;
            SqlConnection conn = null;
            SqlDataReader dread = null;
            try
            {
                conn = conexao.conneccao.abra_connecao();
                conn.Open();
                string pi = "select TB_encomenda.Idencomenda,TB_produto.produto ,TB_encomenda.categoria,TB_encomenda.data," +
                    "TB_fornecedor.nome,TB_encomenda.unidade,TB_encomenda.p_compra,p_venda,TB_encomenda.q_existente," +
                    "TB_encomenda.q_introduzir,TB_encomenda.q_atual from TB_encomenda,TB_produto,TB_fornecedor" +
                    " where (TB_produto.idproduto=TB_encomenda.produto)and(TB_fornecedor.Idfornecedor=TB_encomenda.fornecedor) order by(Idencomenda) desc";
                cmd = new SqlCommand(pi, conn);
                dread = cmd.ExecuteReader();
                dgv_encomenda.Rows.Clear();
                while (dread.Read())
                {
                    dgv_encomenda.Rows.Add(dread["Idencomenda"],
                    dread["produto"],
                    dread["categoria"],
                    dread["data"],
                    dread["Nome"],
                    dread["unidade"],
                    dread["p_compra"],
                    dread["p_venda"],
                    dread["q_existente"],
                    dread["q_introduzir"],
                    dread["q_atual"]);
                }
                //dread["Idencomenda"]=(dgv_encomenda.CurrentRow.Cells[0].Value).ToString());
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
        void atulizar_quatindade()
        {
            SqlCommand cmd = null;
            SqlConnection conn = null;
            try
            {
                conn = conexao.conneccao.abra_connecao();
                conn.Open();
                string data_bases = "Update TB_produto Set quandide_atual = '" + txt_q_atual.Text + "'where Idproduto like '" + cod_prod + "'";
                cmd = new SqlCommand(data_bases, conn);
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("quantiade atuliuzado");
                }
            }
            catch (Exception W)
            {
                MessageBox.Show("error" + W);
            }

        }
        void carrega_codigo_p()
        {

            SqlCommand cmd = null;
            SqlConnection conn = null;
            SqlDataReader dread = null;
            conn = conexao.conneccao.abra_connecao();
            conn.Open();
            string bd = "select Idencomenda from  TB_encomenda Order By (Idencomenda)desc";
            cmd = new SqlCommand(bd, conn);
            dread = cmd.ExecuteReader();
            if (dread.Read())
            {
                txtorden.Text = (Convert.ToInt32(dread["Idencomenda"].ToString()) + Convert.ToInt32("1")).ToString();

            }
            else
            {
                txtorden.Text = "1";

            }


            cmd.Dispose();
            conn.Close();

        }
        void calculos()
        {
        }
        void buscar_categ()
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlDataReader dread = null;
            conn = conexao.conneccao.abra_connecao();
            conn.Open();
            string databases = "select categoia from TB_categoria where idcategoria like '" + catg + "'";
            cmd = new SqlCommand(databases, conn);
            dread = cmd.ExecuteReader();
            while (dread.Read())
            {
                txt_catg.Text = dread["categoia"].ToString();
            }
            conn.Close();
            cmd.Dispose();
        }
        void buscar_unidade()
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlDataReader dread = null;
            conn = conexao.conneccao.abra_connecao();
            conn.Open();
            string databases = "select unidade from TB_unidade where Id_unidade like '" + unid + "'";
            cmd = new SqlCommand(databases, conn);
            dread = cmd.ExecuteReader();
            while (dread.Read())
            {
                txt_unidade.Text = dread["unidade"].ToString();
            }
            conn.Close();
            cmd.Dispose();
        }
        void buscar_fornecedor()
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlDataReader dread = null;
            conn = conexao.conneccao.abra_connecao();
            conn.Open();
            string databases = "select nome from TB_fornecedor";
            cmd = new SqlCommand(databases, conn);
            dread = cmd.ExecuteReader();
            
            Cbo_fornecedor.Items.Clear();
            //cbo_p.Items.Clear();
            while (dread.Read())
            {
                Cbo_fornecedor.Items.Add(dread["nome"].ToString());

            }
            conn.Close();
            cmd.Dispose();
        }
        void buscar_produ()
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlDataReader dread = null;
            conn = conexao.conneccao.abra_connecao();
            conn.Open();
            string databases = "select produto from TB_produto";
            cmd = new SqlCommand(databases, conn);
            dread = cmd.ExecuteReader();
            cbo_p.Items.Clear();
            while (dread.Read())
            {
                cbo_p.Items.Add(dread["produto"].ToString());

            }
            conn.Close();
            cmd.Dispose();
        }

        private void frm_produt_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(System.DateTime.Now.ToString());
            data_produto.Value = System.DateTime.Now;
            carrega_codigo_p();
            buscar_fornecedor();
            buscar_produ();
            buscar_encomenda();

        }

        private void btnPesquisa_numero_tel_Click(object sender, EventArgs e)
        {
            Telas.Produtos k = new Telas.Produtos();
            k.ShowDialog();

        }

        private void btnSalva_enc_Click(object sender, EventArgs e)
        {
            if ((cbo_p.Text == "") || (txt_catg.Text == string.Empty) || (Cbo_fornecedor.Text == "") ||
               (txt_unidade.Text == string.Empty) || (txt_venda.Text == string.Empty) || (txt_compra.Text == string.Empty) ||
               (txt_q_atual.Text == string.Empty) || (txt_q_introduzida.Text == string.Empty) || (txt_q_existente.Text == string.Empty))
            {
                MessageBox.Show("Porfavor Insira Dados ");
                return;
            }
            else
            {

                SqlCommand cmd = null;
                SqlConnection conn = null;
                try
                {
                    conn = conexao.conneccao.abra_connecao();
                    conn.Open();
                    string data_bases = " insert into TB_encomenda (Idencomenda,produto, categoria,data,fornecedor,unidade,p_compra,p_venda,q_existente,q_introduzir,q_atual)" +
                        "values('" + txtorden.Text + "','" + cod_prod + "','" + txt_catg.Text + "', '" + System.DateTime.Now.ToString() + "'," +
                        "'" + cod_forncedor + "','" + txt_unidade.Text + "','" + txt_compra.Text + "','" + txt_venda.Text + "','" + txt_q_existente.Text + "','" + txt_q_introduzida.Text + "','" + txt_q_atual.Text + "')"; ;
                    cmd = new SqlCommand(data_bases, conn);
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Registro gravado com sucesso");
                        atulizar_quatindade();
                        limpa();
                        carrega_codigo_p();
                        buscar_encomenda();
                        txt_ordem_dgv.Visible = false;
                        txt_q_introduzida.Enabled = false;
                    }
                }
                catch (Exception W)
                {
                    MessageBox.Show("REGISTRO NAO gravdo" + W);
                }
                finally
                {
                    conn.Close();
                }
            }

        }

        public string catg, unid, cod_prod;
        private void cbo_p_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlCommand cmd = null;
            SqlConnection conn = null;
            SqlDataReader dread = null;
            conn = conexao.conneccao.abra_connecao();
            conn.Open();
            string bd = "select Idproduto,categoria,quandide_atual,unidade from TB_produto where produto like'" + cbo_p.Text + "'";
            cmd = new SqlCommand(bd, conn);
            dread = cmd.ExecuteReader();
            if (dread.Read())
            {

                carrega_codigo_p();
                txt_catg.Text = string.Empty;
                Cbo_fornecedor.SelectedIndex = -1;
                txt_unidade.Text = string.Empty;
                txt_venda.Text = string.Empty;
                txt_compra.Text = string.Empty;
                txt_q_atual.Text = string.Empty;
                txt_q_introduzida.Text = string.Empty;
                txt_q_existente.Text = string.Empty;
                cod_prod = dread["Idproduto"].ToString();
                catg = dread["categoria"].ToString();
                unid = dread["unidade"].ToString();
                txt_q_existente.Text = dread["quandide_atual"].ToString();
                txt_q_atual.Text = "0";
                buscar_categ();
                buscar_unidade();
                txt_q_introduzida.Enabled = true;

            }


        }

        private void txt_catg_TextChanged(object sender, EventArgs e)
        {


        }

        private void txtquatidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            validando.ValidacaoNemeros(e);
        }

        private void btn_fornced_Click(object sender, EventArgs e)
        {
            Telas.fornecedor k = new Telas.fornecedor();
            k.ShowDialog();
        }
        public string cod_forncedor;
        private void Cbo_fornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlCommand cmd = null;
            SqlConnection conn = null;
            SqlDataReader dread = null;
            conn = conexao.conneccao.abra_connecao();
            conn.Open();
            string bd = "select Idfornecedor from TB_fornecedor where nome like'" + Cbo_fornecedor.Text + "'";
            cmd = new SqlCommand(bd, conn);
            dread = cmd.ExecuteReader();
            if (dread.Read())
            {
                cod_forncedor = dread["Idfornecedor"].ToString();


            }



        }

        private void Dgv_encomenda_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Txt_compra_KeyUp(object sender, KeyEventArgs e)
        {
            validacaoNRdecimal_compra((TextBox)sender);
        }

        private void Txt_compra_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_venda_KeyUp(object sender, KeyEventArgs e)
        {
            validacaoNRdecimal_venda((TextBox)sender);
        }

        private void Data_produto_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblTelefone_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = null;
            SqlConnection conn = null;
            try
            {
                conn = conexao.conneccao.abra_connecao();
                conn.Open();
                string data_bases = "Update TB_produto Set quandide_atual = '" + txt_q_atual.Text + "'where Idproduto like '" + cod_prod + "'";
                cmd = new SqlCommand(data_bases, conn);
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Quantidade actualizada com sucesso!","Informação",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            catch (Exception W)
            {
                MessageBox.Show("error" + W);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            limpa();
            //btnSalva_enc.Enabled = true;
            btnSalva.Enabled = true;
            cbo_p.Enabled = true;
            cbo_p.Enabled = true;
            carrega_codigo_p();
            txt_ordem_dgv.Visible = false;
            buscar_encomenda();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            if ((cbo_p.Text == "") || (txt_catg.Text == string.Empty) || (Cbo_fornecedor.Text == "") ||
               (txt_unidade.Text == string.Empty) || (txt_venda.Text == string.Empty) || (txt_compra.Text == string.Empty) ||
               (txt_q_atual.Text == string.Empty) || (txt_q_introduzida.Text == string.Empty) || (txt_q_existente.Text == string.Empty))
            {
                MessageBox.Show("Os campos Produto, Categoria & Fornecedor não podem ficar vazios. Porfavor preecha os campos e tente novamente!!!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
              //MessageBox.Show("Porfavor Insira Dados ");
                return;
            }
            else
            {

                SqlCommand cmd = null;
                SqlConnection conn = null;
                try
                {
                    conn = conexao.conneccao.abra_connecao();
                    conn.Open();
                    string data_bases = " insert into TB_encomenda (Idencomenda,produto, categoria,data,fornecedor,unidade,p_compra,p_venda,q_existente,q_introduzir,q_atual)" +
                        "values('" + txtorden.Text + "','" + cod_prod + "','" + txt_catg.Text + "', '" + System.DateTime.Now.ToString() + "'," +
                        "'" + cod_forncedor + "','" + txt_unidade.Text + "','" + txt_compra.Text + "','" + txt_venda.Text + "','" + txt_q_existente.Text + "','" + txt_q_introduzida.Text + "','" + txt_q_atual.Text + "')"; ;
                    cmd = new SqlCommand(data_bases, conn);
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Registro gravado com sucesso!");
                        atulizar_quatindade();
                        limpa();
                        carrega_codigo_p();
                        buscar_encomenda();
                        txt_ordem_dgv.Visible = false;
                        txt_q_introduzida.Enabled = false;
                    }
                }
                catch (Exception W)
                {
                    MessageBox.Show("Registo não gravado!" + W);
                }
                finally
                {
                    conn.Close();
                }

            }
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buscar_fornecedor();
            buscar_produ();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        //        if ((txt_catg.Text == "") | (txt_catg.Text == "") | (Cbo_fornecedor.Text == ""))
        //    {
        //        MessageBox.Show("Os campos Produto, Categoria & Fornecedor não podem ficar vazios. Porfavor preecha os campos e tente novamente!!!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    else
        //    {
        //        SqlCommand cmd = null;
        //        SqlConnection conn = null;
        //        try
        //        {
        //            conn = conexao.conneccao.abra_connecao();
        //            conn.Open();
        //            string db = "insert into TB_encomenda(Idencomenda, produto, categoria, data, fornecedor, unidade, p_compra, p_venda, q_existente, q_introduzir, q_atual)" +
        //                "values('" + txtorden.Text + "','" + cbo_p.Text + "','" + txt_catg + "','" + data_produto.Text + "','" + Cbo_fornecedor.Text + "', '" + txt_unidade.Text + "','" + txt_compra.Text + "','" + txt_venda.Text + "','" + txt_q_existente.Text + "','" + txt_q_introduzida.Text + "','" + txt_q_atual.Text + "')";
        //            cmd = new SqlCommand(db, conn);
        //            int i = cmd.ExecuteNonQuery();
        //            if (i > 0)
        //            {
        //                MessageBox.Show("Registro gravado com sucesso");
        //                limpa();
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Erro ao tentar estabelecer conexão com o servidor" + ex);
        //        }

        //        }
        //}

        private void txt_compra_KeyPress(object sender, KeyPressEventArgs e)
        {
         
        }

        private void txt_venda_KeyPress(object sender, KeyPressEventArgs e)
        {
            validando.ValidacaoNemeros(e);
        }

        private void Txt_q_introduzida_TextChanged(object sender, EventArgs e)
        {
            
            calcular();
        }

        private void Txt_q_introduzida_KeyPress(object sender, KeyPressEventArgs e)
        {
            validando.ValidacaoNemeros(e);
        }

        void calcular()
        {
            try
            {
                if ((txt_q_introduzida.Text =="0")||(txt_q_introduzida.Text==""))
                {
                   
                    //txt_q_atual.Text=string.Empty;
                    txt_q_introduzida.Text = string.Empty;
                    txt_q_atual.Text = "0";
                    //MessageBox.Show("porfavor insira aquantidade");
                    //return;
                }
                else
                {
                    txt_q_atual.Text = "0";
                    int q_atual = Convert.ToInt32(txt_q_existente.Text);
                    //q_atual = int.Parse(txt_q_introduzida.Text);
                    int q_introduzir = Convert.ToInt32(txt_q_introduzida.Text);
                    int q_resultado = q_atual + q_introduzir;
                    txt_q_atual.Text = q_resultado.ToString();
                } 
            }

            catch (Exception ex)
            {
                MessageBox.Show("porfavor insra a quantidade" + ex);
            }
            
        }
           
        private void txtquatidade_Click(object sender, EventArgs e)
        {
           
        
       
        }

        private void btnNovo_enc_Click(object sender, EventArgs e)
        {
            limpa();
            btnSalva_enc.Enabled = true;
            cbo_p.Enabled = true;
            cbo_p.Enabled = true;
            carrega_codigo_p();
            txt_ordem_dgv.Visible = false;
            buscar_encomenda();
        }

        private void txt_q_atual_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEdit_enc_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = null;
            SqlConnection conn = null;
            try
            {
            conn = conexao.conneccao.abra_connecao();
            conn.Open();
            string df = "update TB_encomenda set produto='" + cod_prod + "',categoria='" + cod_forncedor + "',p_compra='" + txt_compra.Text + "',p_venda='" + txt_venda.Text + "',q_introduzir='" + txt_q_introduzida.Text + "'where Idencomenda like '" + txt_ordem_dgv.Text+ "' ";
            cmd = new SqlCommand(df, conn);
            int i = cmd.ExecuteNonQuery();
            if(i>0)
            {
                MessageBox.Show("Registo Actualizado com sucesso.");
                limpa();
                    txt_ordem_dgv.Visible = false;
                carrega_codigo_p();
                    cbo_p.Enabled = true;
                    cbo_p.Enabled = true;
                    btnSalva_enc.Enabled = true;
                    buscar_encomenda();
                }
            }
            catch(Exception p)
            {
                MessageBox.Show("erro da connecao"+p);
            }
            finally
            {
                conn.Close();
            }

        }

        private void btnApaga_enc_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = null;
            SqlConnection conn = null;
            try
            {
                conn = conexao.conneccao.abra_connecao();
                conn.Open();
                string loi = "delete from TB_encomenda where Idencomenda like '"+txt_ordem_dgv.Text+"'";
                cmd = new SqlCommand(loi, conn);
                int po = cmd.ExecuteNonQuery();
                if(po>0)
                {
                    MessageBox.Show("Registo Eliminado com sucesso.");
                    limpa();
                    txt_ordem_dgv.Visible = false;
                    carrega_codigo_p();
                    cbo_p.Enabled = true;
                    cbo_p.Enabled = true;
                    btnSalva_enc.Enabled = true;
                    buscar_encomenda();
                }

            }
            catch(Exception po)
            {
                MessageBox.Show("Erro ao tentar estabelecer conexão com o servidor"+po);
            }
            finally
            {
                conn.Close();
            }
        }

        private void dgv_encomenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_q_introduzida.Enabled= false;
            txt_ordem_dgv.Visible = true;
            btnSalva_enc.Enabled = false;
            cbo_p.Enabled = false;
            cbo_p.Enabled = false;
            txt_ordem_dgv.Text = (dgv_encomenda.CurrentRow.Cells[0].Value).ToString();
            cbo_p.Text= (dgv_encomenda.CurrentRow.Cells[1].Value).ToString();
            txt_catg.Text = (dgv_encomenda.CurrentRow.Cells[2].Value).ToString();
            data_produto.CustomFormat = (dgv_encomenda.CurrentRow.Cells[3].Value).ToString();
            Cbo_fornecedor.Text =( dgv_encomenda.CurrentRow.Cells[4].Value).ToString();
            txt_unidade.Text = (dgv_encomenda.CurrentRow.Cells[5].Value).ToString();
            txt_compra.Text = (dgv_encomenda.CurrentRow.Cells[6].Value).ToString();
            txt_venda.Text = (dgv_encomenda.CurrentRow.Cells[7].Value).ToString();
            txt_q_existente.Text = (dgv_encomenda.CurrentRow.Cells[8].Value).ToString();
            txt_q_introduzida.Text = (dgv_encomenda.CurrentRow.Cells[9].Value).ToString();
            txt_q_atual.Text = (dgv_encomenda.CurrentRow.Cells[10].Value).ToString();
          

        }
    }
}
