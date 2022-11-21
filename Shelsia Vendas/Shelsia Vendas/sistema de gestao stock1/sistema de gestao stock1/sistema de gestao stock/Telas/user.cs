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
    public partial class user : Form
    {
        public user()
        {
            InitializeComponent();
        }

        private void Btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
