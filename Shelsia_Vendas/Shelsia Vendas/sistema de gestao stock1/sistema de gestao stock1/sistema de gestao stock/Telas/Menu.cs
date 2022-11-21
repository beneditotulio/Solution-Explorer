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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private int imagenumero=1;
            private void imagennext()
            {
            if (imagenumero==10)
            {
                imagenumero = 1;
            
            }
            imagen_slid.ImageLocation = string.Format(@"imagens\{0}.jpg", imagenumero);
            imagenumero++;
            }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            panel3.Height = btn_cadastra.Height;
            panel3.Top = btn_cadastra.Top;
            panel_cadastro.Visible = true;
            panel_listagens.Visible = false;
         
            //using (Telas.frm_menu_cadastro KM = new Telas.frm_menu_cadastro())
            //{
            // //   KM.Location = new Point();
            //    KM.ShowDialog();
            //}

        }

        private void btn_listagens_Click(object sender, EventArgs e)
        {
            panel3.Height = btn_listagens.Height;
            panel3.Top = btn_listagens.Top;
            panel_listagens.Visible = true;

        }

        private void btn_ajuda_Click(object sender, EventArgs e)
        {
            panel3.Height = btn_ajuda.Height;
            panel3.Top = btn_ajuda.Top;
        }

        private void btn_cadastro_Click(object sender, EventArgs e)
        {
            panel_cadastro.Visible = false;
            panel3.Height = btn_inicio.Height;
            panel3.Top = btn_inicio.Top;
            panel_listagens.Visible = false;
        
        }
   
        private void Menu_Load(object sender, EventArgs e)
        {
           
            panel_cadastro.Visible = false;
            panel_listagens.Visible = false;
       

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            imagennext();
            lbl_data.Text= System.DateTime.Now.ToString();


        }

        private void imagen_slid_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Lbl_tempo_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Usuário_Click(object sender, EventArgs e)
        {
            panel3.Height = btn_Usuário.Height;
            panel3.Top = btn_Usuário.Top;
            Telas.user l = new Telas.user();
            l.ShowDialog();
        }

        private void Btn_Factura_Click(object sender, EventArgs e)
        {
            //panel3.Height = btn_Factura.Height;
            //panel3.Top = btn_Factura.Top;
        }

        private void Data_menu_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Telas.Produtos k = new Telas.Produtos();
            k.ShowDialog();
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            Telas.FrmCadastroEncomenda l = new Telas.FrmCadastroEncomenda();
            l.ShowDialog();
        }

        private void Btn_Funcinario_Click(object sender, EventArgs e)
        {
            using (Telas.FrmFuncionario KM = new Telas.FrmFuncionario())
            {
                KM.ShowDialog();
            }
        }

        private void Panel_cadastro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Telas.fornecedor k = new Telas.fornecedor();
            k.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            frm_Requisicao k = new frm_Requisicao();
            k.ShowDialog();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Telas.FrmCliente l =new Telas.FrmCliente();
            l.ShowDialog();
            
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            listagens.produtos k = new listagens.produtos();
            k.ShowDialog();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button17_Click(object sender, EventArgs e)
        {
            listagens.FrmListagemFuncionario l = new listagens.FrmListagemFuncionario();
            l.ShowDialog();
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            listagens.FrmEncomenda l = new listagens.FrmEncomenda();
            l.ShowDialog();
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            listagens.FrmEncomenda l = new listagens.FrmEncomenda();
            l.ShowDialog();
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            listagens.FrmListagemCliente l =new listagens.FrmListagemCliente();
            l.ShowDialog();
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            listagens.FrmListagemFornecedor l = new listagens.FrmListagemFornecedor();
            l.ShowDialog();
        }
    }
}
