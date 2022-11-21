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
    public partial class frm_Requisicao : Form
    {
        conexao.validacao validando = new conexao.validacao();
        public frm_Requisicao()
        {
            InitializeComponent();
        }
        void carrega_cliente()
        {
            SqlCommand cmd = null;
            SqlConnection conn = null;
            SqlDataReader dread = null;
            try
            {
                conn = conexao.conneccao.abra_connecao();
                conn.Open();
                string bd = "select * from TB_cliente";
                cmd = new SqlCommand(bd, conn);
                dread = cmd.ExecuteReader();
                Cbo_cliente.Items.Clear();
                while (dread.Read())
                {
                    Cbo_cliente.Items.Add(dread["Nome"].ToString());
                }


            }
            catch (Exception p)
            {
                MessageBox.Show("nao tem Nome" + p);
                this.Close();
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }
        void carrega_codigo_r()
        {

            SqlCommand cmd = null;
            SqlConnection conn = null;
            SqlDataReader dread = null;
            conn = conexao.conneccao.abra_connecao();
            conn.Open();
            string bd = "select Idrequisicao from  TB_Requisicao_1  Order By (Idrequisicao)desc";
            cmd = new SqlCommand(bd, conn);
            dread = cmd.ExecuteReader();
            if (dread.Read())
            {
                txtorden.Text = (Convert.ToInt32(dread["Idrequisicao"].ToString()) + Convert.ToInt32("1")).ToString();
                
            }
            else
            {
                txtorden.Text = "1";

            }


            cmd.Dispose();
            conn.Close();

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
        private void Btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Txt_q_introduzida_KeyPress(object sender, KeyPressEventArgs e)
        {
            validando.ValidacaoNemeros(e);
        }
        void calculos()
        {

            //double soma;
            //soma = 0;

            //txt_total_quat.Text= (Convert.ToDouble(txt_total_quat.Text)+sub_total).ToString();



        }
        void calcular()
        {
            try
            {
                if ((txt_q_introduzida.Text == "0") || (txt_q_introduzida.Text == ""))
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
                    int q_introduzir = Convert.ToInt32(txt_q_introduzida.Text);
                  if(  q_introduzir > q_atual)
                    {
                        MessageBox.Show("Verifica quantidade/concata o forncedor");
                        txt_q_introduzida.BackColor = Color.Red;
                        txt_q_introduzida.Focus();
                        txt_q_introduzida.Text = string.Empty;
                        return;

                    }
                    else
                    {
                        int q_resultado = q_atual - q_introduzir;
                        txt_q_atual.Text = q_resultado.ToString();
                    }
                   
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("porfavor insra Aquantidade" + ex);
            }

        }
        void buscar_produto()
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
        private void Txt_q_introduzida_TextChanged(object sender, EventArgs e)
        {
            calcular();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            resposta= MessageBox.Show("Imprimir Recibo","imformacao",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(resposta==DialogResult.No)
            {

            }
            else
            {
                SqlCommand cmd = null;
                SqlConnection conn = null;
                try
                {
                    conn = conexao.conneccao.abra_connecao();
                    conn.Open();
                    for (int l = 0; l < dgv_requisicao.Rows.Count - 1; l++)
                    {
                        string db = "insert into TB_requisicao(Idrequisaicao,poduto,data,cliente, " +
                            "empresa,categoria,unidade,preco,quantidade,stock_dia,quantidade_atual,sub_total," +
                            "total,quantidade_total)" +
                       "values('"+dgv_requisicao.Rows[l].Cells[0].Value+ "','" + dgv_requisicao.Rows[l].Cells[1].Value + "'," +
                       "'" + dgv_requisicao.Rows[l].Cells[2].Value + "','" + dgv_requisicao.Rows[l].Cells[3].Value + "'," +
                       "'" + dgv_requisicao.Rows[l].Cells[4].Value + "','" + dgv_requisicao.Rows[l].Cells[5].Value + "'," +
                       "'" + dgv_requisicao.Rows[l].Cells[6].Value + "','" + dgv_requisicao.Rows[l].Cells[7].Value + "'," +
                       "'" + dgv_requisicao.Rows[l].Cells[8].Value + "','" + dgv_requisicao.Rows[l].Cells[9].Value + "'," +
                       "'" + dgv_requisicao.Rows[l].Cells[10].Value + "','" + dgv_requisicao.Rows[l].Cells[11].Value + "'," +
                       "'" + txt_total .Text+ "','"+ txt_total_quat .Text+ "')";
                        cmd = new SqlCommand(db, conn);
                    }
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Registro gravado com sucesso");
                        carrega_codigo_r();
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

        private void Frm_Requisicao_Load(object sender, EventArgs e)
        {
            carrega_cliente();
            carrega_codigo_r();
            buscar_produto();
            data_produto.Value = System.DateTime.Now;
        }
       
        public void somarvalor()
        {
            double soma = 0;
            foreach (DataGridViewRow linha in dgv_requisicao.Rows)
                soma = soma + Convert.ToDouble(linha.Cells[11].Value);
            txt_total.Text = soma.ToString();
        }
        public void somarquant()
        {
            double quant = 0;
            foreach (DataGridViewRow linha in dgv_requisicao.Rows)
                quant = quant + Convert.ToDouble(linha.Cells[8].Value);
            txt_total_quat.Text = quant.ToString();
        }
        public string catg, unid, cod_prod;
        double sub_total;

        private void Button5_Click(object sender, EventArgs e)
        {
            if(dgv_requisicao.Rows.Count>0)
            {
                btn_remover.Visible = true;
                dgv_requisicao.Rows.Remove(dgv_requisicao.CurrentRow);
                somarquant();
                somarvalor();
            }
            else
            {
                btn_remover.Visible = false;
            }
        }
        public string cod_cliente;
        private void Cbo_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = null;
            SqlConnection conn = null;
            SqlDataReader dread = null;
            conn = conexao.conneccao.abra_connecao();
            conn.Open();
            string bd = "select idcliente from TB_cliente where Nome like'" + Cbo_cliente.Text + "'";
            cmd = new SqlCommand(bd, conn);
            dread = cmd.ExecuteReader();
            if (dread.Read())
            {
              cod_cliente   = dread["idcliente"].ToString();
            }
            conn.Close();
            cmd.Dispose();

        }

        private void Btn_fornced_Click(object sender, EventArgs e)
        {
            Telas.FrmCliente h = new Telas.FrmCliente();
            h.ShowDialog();

        }

        private void BtnPesquisa_numero_tel_Click(object sender, EventArgs e)
        {
            Telas.Produtos j =new Telas.Produtos();
            j.ShowDialog();
        }

        private void lblCodigo_Click(object sender, EventArgs e)
        {

        }

        private void lblSexo_Click(object sender, EventArgs e)
        {

        }

        private void txt_unidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_total_quat_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            Modelos.Requisicao REQUISICAO = new Modelos.Requisicao();

            if (dgv_requisicao.Rows.Count == 0)
            { MessageBox.Show("Por favor efectue pelo menos uma REQUISICAO"); }
            else
            {

                //INSERIR EMPRESTIMO


                for (int i = 0; i <= dgv_requisicao.RowCount - 1; i += 1)
                {
                    dgv_requisicao.Rows[i].Selected = true;
                    // MessageBox.Show(i.ToString());
                    //MessageBox.Show(dgvDetalhesReserva.Rows[i].Cells[0].Value.ToString() + " " + dgvDetalhesReserva.Rows[i].Cells[1].Value.ToString() + " " + dgvDetalhesReserva.Rows[i].Cells[2].Value.ToString() + " " + dgvDetalhesReserva.Rows[i].Cells[3].Value.ToString());


                    //ATRIBUINDO VALORES AO MODELO EMPRESTIMO

                    //EMPRESTIMO.Leitor = dgv_requisicao.Rows[i].Cells[1].Value.ToString();
                    //EMPRESTIMO.Livro = dgv_requisicao.Rows[i].Cells[2].Value.ToString();
                    //EMPRESTIMO.DataRetirada = dgv_requisicao.Rows[i].Cells[3].Value.ToString();
                    //EMPRESTIMO.DataEntrega = dgv_requisicao.Rows[i].Cells[4].Value.ToString();
                    //EMPRESTIMO.DataDevolucao = dgv_requisicao.Rows[i].Cells[5].Value.ToString();
                    //EMPRESTIMO.Devolucao = dgv_requisicao.Rows[i].Cells[6].Value.ToString();
                    carrega_codigo_r();


                    REQUISICAO.IDRequisicao = txtorden.Text;

                    REQUISICAO.Produto = dgv_requisicao.Rows[i].Cells[1].Value.ToString();
                    REQUISICAO.Categoria = dgv_requisicao.Rows[i].Cells[2].Value.ToString();
                    REQUISICAO.Data = dgv_requisicao.Rows[i].Cells[3].Value.ToString();
                    REQUISICAO.Cliente = dgv_requisicao.Rows[i].Cells[4].Value.ToString();
                    REQUISICAO.Empresa = dgv_requisicao.Rows[i].Cells[5].Value.ToString();
                    REQUISICAO.Unidade = dgv_requisicao.Rows[i].Cells[6].Value.ToString();
                    REQUISICAO.Preco = dgv_requisicao.Rows[i].Cells[7].Value.ToString();
                    REQUISICAO.Quantidade = dgv_requisicao.Rows[i].Cells[8].Value.ToString();
                    REQUISICAO.StockDia = dgv_requisicao.Rows[i].Cells[9].Value.ToString();
                    REQUISICAO.QuantidadeActual = dgv_requisicao.Rows[i].Cells[10].Value.ToString();
                    REQUISICAO.Subtotal = dgv_requisicao.Rows[i].Cells[11].Value.ToString();

                    Controladores.ControladorRequisicao.Salvar(REQUISICAO);
                    //Limpa();
                    //dgvDetalhesReserva.Rows[i].Selected = false;
                }
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (txt_q_introduzida.Text == "" || Cbo_cliente.Text == string.Empty || cbo_p.Text == string.Empty )
            {
                MessageBox.Show("Porfavor preecha os campos");
                txt_q_introduzida.Focus();
                return;
            }
            else
            {


                sub_total = Convert.ToInt32(txt_preco.Text) * Convert.ToInt32(txt_q_introduzida.Text);
                dgv_requisicao.Rows.Add(txtorden.Text, cod_prod, txt_catg.Text, System.DateTime.Now, cod_cliente,
                    txt_empresa.Text, txt_unidade.Text, txt_preco.Text, txt_q_introduzida.Text, txt_q_existente.Text, txt_q_atual.Text, sub_total).ToString();
                somarvalor();
                somarquant();
                btn_remover.Visible = true;
            }
        }
        private void Cbo_p_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = null;
            SqlConnection conn = null;
            SqlDataReader dread = null;
            conn = conexao.conneccao.abra_connecao();
            conn.Open();
            string bd = "select Idproduto,TB_produto.categoria,quandide_atual,TB_produto.unidade," +
                "TB_encomenda.p_venda from TB_encomenda, TB_produto " +
                "Where TB_produto.Idproduto like TB_encomenda.produto and TB_produto.produto like '" + cbo_p.Text + "' Order by Idencomenda Desc";
            cmd = new SqlCommand(bd, conn);
            dread = cmd.ExecuteReader();
            if (dread.Read())
            {

                carrega_codigo_r();
                txt_catg.Text = string.Empty;
                Cbo_cliente.SelectedIndex = -1;
                txt_unidade.Text = string.Empty;
                
                txt_preco.Text = string.Empty;
                txt_q_atual.Text = string.Empty;
                txt_q_introduzida.Text = string.Empty;
                txt_q_existente.Text = string.Empty;
                cod_prod = dread["Idproduto"].ToString();
                catg = dread["categoria"].ToString();
                unid = dread["unidade"].ToString();
                txt_preco.Text = dread["p_venda"].ToString();
                txt_q_existente.Text = dread["quandide_atual"].ToString();
                txt_q_atual.Text = "0";
                buscar_categ();
                buscar_unidade();
                txt_q_introduzida.Enabled = true;

            }


        }
    }

    

}
