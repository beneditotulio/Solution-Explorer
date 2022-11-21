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
    public partial class FrmEncomenda : Form
    {
        public FrmEncomenda()
        {
            InitializeComponent();
        }
        void buscar_encomenda()

        {
            SqlCommand cmd = null;
            SqlConnection conn = null;
            SqlDataReader dread = null;
            try
            {
                conn = conexao.conneccao.abra_connecao();
                conn.Open();
                string pi = "select * from  consulta_encomenda order by(Idencomenda) desc";
                cmd = new SqlCommand(pi, conn);
                dread = cmd.ExecuteReader();
                dgv_encomenda.Rows.Clear();
                lbl_total.Text = "0";
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
                    lbl_total.Text = dgv_encomenda.RowCount.ToString();
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
        private void Btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Encomenda_Load(object sender, EventArgs e)
        {
            buscar_encomenda();
        }

        private void Cbo_filtra_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_prod_pesquiza.Enabled = true;
            txt_prod_pesquiza.Text = "";
            txt_prod_pesquiza.Focus();
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
                string pi = "select * from  consulta_encomenda WHERE "+cbo_filtra.Text+" LIKE '"+txt_prod_pesquiza.Text+"%' order by(Idencomenda) desc";
                cmd = new SqlCommand(pi, conn);
                dread = cmd.ExecuteReader();
                dgv_encomenda.Rows.Clear();
                lbl_total.Text = "0";
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
                    lbl_total.Text = dgv_encomenda.RowCount.ToString();
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

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnImpressao_Click(object sender, EventArgs e)
        {
            DGVPrinterHelper.DGVPrinter printer = new DGVPrinterHelper.DGVPrinter();
            printer.Title = "Relatório de Encomendas".ToUpper();
            printer.SubTitle = string.Format("Data: {0}", DateTime.Now);
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Solution Explorer";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgv_encomenda);
        }
    }
}
