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
namespace sistema_de_gestao_stock.Telas
{
    public partial class FrmMenuPrincipal : Form
    {
        int Quantidade = 0;
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }
        private void CarregaNotificacoes()
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
                    Quantidade = Convert.ToInt32(dread["Quandide_atual"].ToString());

                    if (Quantidade < 11)
                    {
                      //  MessageBox.Show("A quantidade é inferior");
                        dgv_Produto.Rows.Add(dread["produto"], dread["categoia"], dread["Quandide_atual"]);
                    }
                    else
                    {
                        
                    }
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
        private void desabilitaMenus()
        {
            panelInicio.Visible = false;
            panelCadastro.Visible = false;
            panelListagens.Visible = false;
            panelReltorios.Visible = false;
            panelAjuda.Visible = false;
        }
        private void movepanel(Control btn)
        {
            panelSlide.Width = btn.Width;
            panelSlide.Left = btn.Left;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (listagens.FrmListagemFuncionario KM = new listagens.FrmListagemFuncionario())
                KM.ShowDialog(); 
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            movepanel(btnInicio);
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            movepanel(btnCadastro);
        }

        private void btnListagens_Click(object sender, EventArgs e)
        {
            movepanel(btnListagens);
        }

        private void btnAjuda_Click(object sender, EventArgs e)
        {
            movepanel(btnRelatorios);
        }

        private void btnhelp_Click(object sender, EventArgs e)
        {
            movepanel(btnhelp);
        }

        private void btnSai_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInicio_MouseHover(object sender, EventArgs e)
        {
           // panelInicio.Visible = true;
        }

        private void panelInicio_MouseEnter(object sender, EventArgs e)
        {
          //  panelInicio.Visible = false;
        }

        private void btnInicio_MouseLeave(object sender, EventArgs e)
        {
            //panelInicio.Visible = false;
        }

        private void panelInicio_MouseLeave(object sender, EventArgs e)
        {
          // panelInicio.Visible = false;
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            //panelInicio.Visible = false;
            desabilitaMenus();
            CarregaNotificacoes();
        }

        private void btnInicio_MouseMove(object sender, MouseEventArgs e)
        {
            desabilitaMenus();
            panelInicio.Visible = true;
            movepanel(btnInicio);
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            //panelInicio.Visible = false;
            desabilitaMenus();
            
        }

        private void btnCadastro_MouseMove(object sender, MouseEventArgs e)
        {
            desabilitaMenus();
            panelCadastro.Visible = true;
            movepanel(btnCadastro);
        }

        private void btnListagens_MouseMove(object sender, MouseEventArgs e)
        {
            desabilitaMenus();
            panelListagens.Visible = true;
            movepanel(btnListagens);
        }

        private void btnAjuda_MouseMove(object sender, MouseEventArgs e)
        {
            desabilitaMenus();
            panelReltorios.Visible = true;
            movepanel(btnRelatorios);
        }

        private void btnhelp_MouseMove(object sender, MouseEventArgs e)
        {
            desabilitaMenus();
            panelAjuda.Visible = true;
            movepanel(btnhelp);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            using (Telas.Produtos KM = new Telas.Produtos())
                KM.ShowDialog();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            using (Telas.FrmCliente KM = new Telas.FrmCliente())
                KM.ShowDialog();
        }

        private void btnAjudaV2_Click(object sender, EventArgs e)
        {
            using (Telas.AboutBox1 KM = new Telas.AboutBox1())
                KM.ShowDialog();
        }

        private void btnCadastroFornecedorV1_Click(object sender, EventArgs e)
        {
            using (Telas.fornecedor KM = new Telas.fornecedor())
                KM.ShowDialog();          
        }

        private void btnFornecedorV1_Click(object sender, EventArgs e)
        {
            using (listagens.FrmListagemFornecedor KM = new listagens.FrmListagemFornecedor())
                KM.ShowDialog();
        }

        private void btnGraficoParcela_Click(object sender, EventArgs e)
        {
            using (Relatorio.FrmBuscaRelatorio KM = new Relatorio.FrmBuscaRelatorio())
                KM.ShowDialog();
           
        }

        private void btnCadastroFuncionario_Click(object sender, EventArgs e)
        {
            using (Telas.FrmFuncionario KM = new Telas.FrmFuncionario())
                KM.ShowDialog();
        }

        private void btnListarClientes_Click(object sender, EventArgs e)
        {
            using (listagens.FrmListagemCliente KM = new listagens.FrmListagemCliente())
                KM.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //using (listagens.FrmProdutos_V_II KM = new listagens.FrmProdutos_V_II())
            //   KM.ShowDialog();
            using (listagens.produtos KM = new listagens.produtos())
                KM.ShowDialog();
        }

        private void btnListarEncomendas_Click(object sender, EventArgs e)
        {
            using (listagens.FrmEncomenda KM = new listagens.FrmEncomenda())
                KM.ShowDialog();
        }

        private void btnLisatgemRequisicao_Click(object sender, EventArgs e)
        {
            using (listagens.FrmListagemRequisicao KM = new listagens.FrmListagemRequisicao())
                KM.ShowDialog();
        }

        private void btnCadastroEncomenda_Click(object sender, EventArgs e)
        {
            using (Telas.FrmCadastroEncomenda KM = new Telas.FrmCadastroEncomenda())
                KM.ShowDialog();
        }

        private void btnChamaProductosv_II_Click(object sender, EventArgs e)
        {
            listagens.FrmJogoArtigos KM = new listagens.FrmJogoArtigos();
            KM.ShowDialog();
        }

        private void btnRequisicao_Click(object sender, EventArgs e)
        {
            using (Telas.frm_Requisicao KM = new Telas.frm_Requisicao())
                KM.ShowDialog();
         
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //Application.Exit();

            DialogResult Resultado = MessageBox.Show("Deseja sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Resultado.Equals(DialogResult.Yes))
            {
                Application.Exit();
            }
            else
            {

            }
        }

        private void btnTerminarSessaoV1_Click(object sender, EventArgs e)
        {
            DialogResult Resultado = MessageBox.Show("Tem certeza que deseja terminar sessao?", "terminar Sessao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Resultado.Equals(DialogResult.Yes))
            {
              this.Visible = false;
              FrmLogin log = new FrmLogin();
               log.ShowDialog();
            }
            else
            {

            }
        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            using (Vendas.FrmVendas KM = new Vendas.FrmVendas())
                KM.ShowDialog();
        }
    }
}
