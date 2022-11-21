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
    public partial class FrmListagemFornecedor : Form
    {
        public FrmListagemFornecedor()
        {
            InitializeComponent();
        }
        void buscar_fornecedor()

        {
            SqlCommand cmd = null;
            SqlConnection conn = null;
            SqlDataReader dread = null;
            try
            {
                conn = conexao.conneccao.abra_connecao();
                conn.Open();
                string pi = "select * from  consulta_fornecedor order by(Idfornecedor) desc";
                cmd = new SqlCommand(pi, conn);
                dread = cmd.ExecuteReader();
                dgv_cliente.Rows.Clear();
                DGVFornecedor.Rows.Clear();
                lbl_total.Text = "0";
                while (dread.Read())
                {

                    dgv_cliente.Rows.Add(dread["Idfornecedor"],
                   dread["nome"],
                   dread["Apelido"],
                   dread["sexo"],
                   dread["contacto"],
                   dread["Telefone_Alternativo"],
                   dread["email"]);

                    DGVFornecedor.Rows.Add(dread["Idfornecedor"],
                   dread["nome"],
                   dread["Apelido"],
                   dread["sexo"],
                   dread["contacto"],
                   dread["Telefone_Alternativo"],
                   dread["email"]);
                    lbl_total.Text = dgv_cliente.RowCount.ToString();
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
        private void Txt_prod_pesquiza_TextChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = null;
            SqlConnection conn = null;
            SqlDataReader dread = null;
            try
            {
                conn = conexao.conneccao.abra_connecao();
                conn.Open();
                string pi = "select * from  consulta_fornecedor where "+cbo_filtra.Text+" like '"+txt_prod_pesquiza.Text+"%' order by(Idfornecedor) desc";
                cmd = new SqlCommand(pi, conn);
                dread = cmd.ExecuteReader();
                dgv_cliente.Rows.Clear();
                DGVFornecedor.Rows.Clear();
                lbl_total.Text = "0";
                while (dread.Read())
                {

                    dgv_cliente.Rows.Add(dread["Idfornecedor"],
                   dread["nome"],
                   dread["Apelido"],
                   dread["sexo"],
                   dread["contacto"],
                   dread["Telefone_Alternativo"],
                   dread["email"]);

                    DGVFornecedor.Rows.Add(dread["Idfornecedor"],
                   dread["nome"],
                   dread["Apelido"],
                   dread["sexo"],
                   dread["contacto"],
                   dread["Telefone_Alternativo"],
                   dread["email"]);
                    lbl_total.Text = dgv_cliente.RowCount.ToString();
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

        private void Fornecedor_Load(object sender, EventArgs e)
        {
            buscar_fornecedor();
        }

        private void Cbo_filtra_SelectedIndexChanged(object sender, EventArgs e)
        {

            txt_prod_pesquiza.Enabled = true;
            txt_prod_pesquiza.Text = "";
            txt_prod_pesquiza.Focus();
        }

        private void Btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImpressao_Click(object sender, EventArgs e)
        {
            DGVPrinterHelper.DGVPrinter printer = new DGVPrinterHelper.DGVPrinter();
            printer.Title = "Relatório de Fornecedores".ToUpper();
            printer.SubTitle = string.Format("Data: {0}", DateTime.Now);
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Solution Explorer";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgv_cliente);
        }
    }
}
