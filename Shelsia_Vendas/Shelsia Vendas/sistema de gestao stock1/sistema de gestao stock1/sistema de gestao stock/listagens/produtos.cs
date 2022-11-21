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


namespace sistema_de_gestao_stock.listagens
{
    public partial class produtos : Form
    {
        public produtos()
        {
            InitializeComponent();
        }

        private void Btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
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
                lbl_total.Text = "0";
                while (dread.Read())
                {

                    dgv_Produto.Rows.Add(dread["idproduto"],
                   dread["produto"],
                   dread["unidade"],
                   dread["Quandide_atual"],
                   dread["categoia"],
                   dread["unidade"]);
                    lbl_total.Text = dgv_Produto.RowCount.ToString();
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
        private void Produtos_Load(object sender, EventArgs e)
        {
            buscar_produto();
        }

        private void Txt_prod_pesquiza_TextChanged(object sender, EventArgs e)
        {
            
                SqlCommand cmd = null;
                SqlConnection conn = null;
                SqlDataReader dread = null;
                try
                {
                    conn = conexao.conneccao.abra_connecao();
                    conn.Open();
                    string pil = "select * from consulta_produto where "+cbo_filtra.Text+" like '"+txt_prod_pesquiza.Text+ "%' order by(idproduto)desc";
                    cmd = new SqlCommand(pil, conn);
                    dread = cmd.ExecuteReader();
                    dgv_Produto.Rows.Clear();
                    lbl_total.Text = "0";
                    while (dread.Read())
                    {

                        dgv_Produto.Rows.Add(dread["idproduto"],
                       dread["produto"],
                       dread["unidade"],
                       dread["Quandide_atual"],
                       dread["categoia"],
                       dread["unidade"]);
                        lbl_total.Text = dgv_Produto.RowCount.ToString();
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

        private void Cbo_filtra_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_prod_pesquiza.Enabled = true;
            txt_prod_pesquiza.Text = "";
            txt_prod_pesquiza.Focus();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btnSai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImpressao_Click(object sender, EventArgs e)
        {
            DGVPrinterHelper.DGVPrinter printer = new DGVPrinterHelper.DGVPrinter();
            printer.Title = "Relatório de Produtos".ToUpper();
            printer.SubTitle = string.Format("Data: {0}", DateTime.Now);
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Solution Explorer";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgv_Produto);
        }
    }
}
