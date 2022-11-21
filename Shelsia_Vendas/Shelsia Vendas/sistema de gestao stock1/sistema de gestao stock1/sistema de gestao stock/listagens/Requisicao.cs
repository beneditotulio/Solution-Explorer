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
    public partial class FrmListagemRequisicao : Form
    {
        public FrmListagemRequisicao()
        {
            InitializeComponent();
        }

        private void CarregaDGV()
        {
            SqlCommand cmd = null;
            SqlConnection conn = null;
            SqlDataReader dread = null;
            try
            {
                conn = conexao.conneccao.abra_connecao();
                conn.Open();
                string pi = "Select * From  ConsultaRequisicao  order by(IdRequisicao) desc";
                cmd = new SqlCommand(pi, conn);
                dread = cmd.ExecuteReader();
                dgv_requisicao.Rows.Clear();
                lbl_total.Text = "0";
                while (dread.Read())
                {

                    dgv_requisicao.Rows.Add(dread["IdRequisicao"],
                   dread["produto"],
                   dread["categoria"],
                   dread["data"],
                   dread["Cliente"],
                   dread["Empresa"],
                   dread["unidade"],
                   dread["preco"],
                   dread["quantidade"],
                   dread["stock_dia"],
                   dread["quantidade_atual"],
                   dread["sub_total"]);
                    lbl_total.Text = dgv_requisicao.RowCount.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel efectuar a Leitura dos dados.");
            }


        }
        private void Btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
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
                string pi = "Select * From  ConsultaRequisicao WHERE " + cbo_filtra.Text + " LIKE '" + txt_prod_pesquiza.Text + "%' order by(IdRequisicao) desc";
                cmd = new SqlCommand(pi, conn);
                dread = cmd.ExecuteReader();
                dgv_requisicao.Rows.Clear();
                lbl_total.Text = "0";
                while (dread.Read())
                {

                    dgv_requisicao.Rows.Add(dread["IdRequisicao"],
                   dread["produto"],
                   dread["categoria"],
                   dread["data"],
                   dread["Cliente"],
                   dread["Empresa"],
                   dread["unidade"],
                   dread["preco"],
                   dread["quantidade"],
                   dread["stock_dia"],
                   dread["quantidade_atual"],
                   dread["sub_total"]);
                    lbl_total.Text = dgv_requisicao.RowCount.ToString();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Não foi possivel efectuar a Leitura dos dados.");
            }

            }

        private void btnImpressao_Click(object sender, EventArgs e)
        {
            DGVPrinterHelper.DGVPrinter printer = new DGVPrinterHelper.DGVPrinter();
            printer.Title = "Relatório de Requisição".ToUpper();
            printer.SubTitle = string.Format("Data: {0}", DateTime.Now);
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Solution Explorer";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgv_requisicao);
        }

        private void FrmListagemRequisicao_Load(object sender, EventArgs e)
        {
            CarregaDGV();
        }

        private void cbo_filtra_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_prod_pesquiza.Enabled = true;
            txt_prod_pesquiza.Text = "";
            txt_prod_pesquiza.Focus();
        }
    }
}
