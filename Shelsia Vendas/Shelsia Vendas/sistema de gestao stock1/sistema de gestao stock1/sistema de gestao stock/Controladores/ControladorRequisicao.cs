using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace sistema_de_gestao_stock.Controladores
{
    class ControladorRequisicao
    {
        public static void Salvar(Modelos.Requisicao Requisicao)
        {
            SqlCommand cmd = null;
            SqlConnection con = null;
            if (Requisicao.IDRequisicao == "0")
            {
                MessageBox.Show("Por favor adicione pelo menos uma requisicao");
            }
            else
            {
                SqlConnection conn = null;
                //SqlCommand cmd = null;
                SqlDataReader Dread = null;


                conn = conexao.conneccao.abra_connecao();
                conn.Open();
                {
                    string SQl = "Select * from TB_Requisicao_1  Where IdRequisicao like '" + Requisicao.IDRequisicao + "'";
                    cmd = new SqlCommand(SQl, conn);
                    Dread = cmd.ExecuteReader();
                    if (Dread.Read())
                    {
                        MessageBox.Show("Esta RESERVA ja existe.");
                    }
                    else
                    {
                        try
                        {
                            con = conexao.conneccao.abra_connecao();
                            con.Open();
                            string SQL = "Insert Into TB_Requisicao_1(Idrequisicao, Produto, Data, Cliente, Empresa, Categoria, Unidade, Preco, quantidade, stock_dia, quantidade_atual, sub_total)"
                                + "Values('" + Requisicao.IDRequisicao+ "', '" + Requisicao.Produto + "', '" + Requisicao.Data + "', '" + Requisicao.Cliente + "', '" + Requisicao.Empresa + "', '" + Requisicao.Categoria + "', '" + Requisicao.Unidade + "', '" + Requisicao.Preco + "', '"+Requisicao.Quantidade+"', '"+Requisicao.StockDia+"', '"+Requisicao.QuantidadeActual+"', '"+Requisicao.Subtotal+"')";
                            cmd = new SqlCommand(SQL, con);
                            int i = cmd.ExecuteNonQuery();
                            if (i > 0)
                            {
                                MessageBox.Show("Registo gravado com sucesso!");

                                con = conexao.conneccao.abra_connecao();
                                con.Open();
                                string SQL1 = "Update TB_Produto set Quandide_atual = '"+Requisicao.QuantidadeActual+"' Where idproduto like '"+Requisicao.Produto+"'";
                                cmd = new SqlCommand(SQL1, con);
                                int ic = cmd.ExecuteNonQuery();
                                if (ic > 0)
                                {
                                    MessageBox.Show("Quantidade actualizada com sucesso");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Nao foi possivel gravar o registo. Por favor tente novamente.\n" + ex.Message);
                        }
                        finally
                        {
                            //Limpa();
                            con.Close();

                        }
                    }
                }
            }
        }


    }
}
