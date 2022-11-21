using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_de_gestao_stock.Telas
{
    public partial class frm_menu_cadastro : Form
    {
        public frm_menu_cadastro()
        {
            InitializeComponent();
        }

        private void btn_Funcinario_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void frm_menu_cadastro_Move(object sender, EventArgs e)
        {

            //label1.Text = this.Location.ToString();
        }

        private void frm_menu_cadastro_Load(object sender, EventArgs e)
        {

        }

        private void frm_menu_cadastro_SizeChanged(object sender, EventArgs e)
        {
           // label2.Text = this.Size.ToString();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Telas.fornecedor k = new Telas.fornecedor();
            k.ShowDialog();
        }
    }
}
