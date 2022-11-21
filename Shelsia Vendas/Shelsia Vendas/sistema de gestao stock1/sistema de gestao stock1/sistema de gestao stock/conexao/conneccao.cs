using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace sistema_de_gestao_stock.conexao
{
    class conneccao
    {
  
        public static SqlConnection abra_connecao()
        {
            SqlConnection conn = null;
            try
            {
                string sqlConexao = @"Data Source=DESKTOP-QP7TB34\SQLEXPRESS;Initial Catalog=sistema_gestao_stock;Integrated Security=True";
                conn = new SqlConnection(sqlConexao);
                //MessageBox.Show("connetaco sucesessefull");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro da conecao"+ex);
                
            }
            return conn;
        }
    }
}
