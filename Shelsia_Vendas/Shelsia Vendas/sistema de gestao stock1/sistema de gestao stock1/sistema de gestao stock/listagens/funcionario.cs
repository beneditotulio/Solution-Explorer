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
    public partial class FrmListagemFuncionario : Form
    {
        public FrmListagemFuncionario()
        {
            InitializeComponent();
        }

        private void Btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void buscar_funcionario()

        {

            SqlCommand cmd = null;
            SqlConnection conn = null;
            SqlDataReader dread = null;
            try
            {
                conn = conexao.conneccao.abra_connecao();
                conn.Open();
                string pili = "select * from consulta_funcionario order by(idfuncionario) desc";
                cmd = new SqlCommand(pili, conn);
                dread = cmd.ExecuteReader();
                dgv_funcionario.Rows.Clear();
                lbl_total.Text = "0";
                while (dread.Read())
                {

                    dgv_funcionario.Rows.Add(dread["idfuncionario"],
                   dread["descricaoDoc"],
                   dread["número_doc"],
                   dread["nome"],
                   dread["apelido"],
                   dread["sexo"],
                   dread["contacto"],
                   dread["telefone_alternativo"],
                   dread["email"]);
                    lbl_total.Text = dgv_funcionario.RowCount.ToString();
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
        private void Funcionario_Load(object sender, EventArgs e)
        {
            buscar_funcionario();
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
                string pili = "select * from consulta_funcionario  where "+cbo_filtra.Text+" like '"+txt_prod_pesquiza.Text+ "%' order by(idfuncionario) desc";
                cmd = new SqlCommand(pili, conn);
                dread = cmd.ExecuteReader();
                dgv_funcionario.Rows.Clear();
                lbl_total.Text = "0";
                while (dread.Read())
                {

                    dgv_funcionario.Rows.Add(dread["idfuncionario"],
                   dread["descricaoDoc"],
                   dread["número_doc"],
                   dread["nome"],
                   dread["apelido"],
                   dread["sexo"],
                   dread["contacto"],
                   dread["telefone_alternativo"],
                   dread["email"]);
                    lbl_total.Text = dgv_funcionario.RowCount.ToString();
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

        private void btnmprimir_Click(object sender, EventArgs e)
        {
            DGVPrinterHelper.DGVPrinter printer = new DGVPrinterHelper.DGVPrinter();
            printer.Title = "Relatório de Funcionario".ToUpper();
            printer.SubTitle = string.Format("Data: {0}", DateTime.Now);
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Solution Explorer";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgv_funcionario);
        }
    }
}
