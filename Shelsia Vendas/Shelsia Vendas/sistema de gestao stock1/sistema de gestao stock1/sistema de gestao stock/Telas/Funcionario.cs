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
using Microsoft.VisualBasic;
namespace sistema_de_gestao_stock.Telas
{

    public partial class FrmFuncionario : Form
    {
        conexao.validacao vld = new conexao.validacao();

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
        void carrega_codigo()
        {
            txtNumeroBI.Enabled = false;
            SqlCommand cmd = null;
            SqlConnection conn = null;
            SqlDataReader dread = null;


            conn = conexao.conneccao.abra_connecao();
            conn.Open();
            string bd = "select IdFuncionario from TB_Funcionario Order By(IdFuncionario) desc";
            cmd = new SqlCommand(bd, conn);
            dread = cmd.ExecuteReader();
            if (dread.Read())
            {
                txtCodigo.Text = (Convert.ToInt32(dread["IdFuncionario"].ToString()) + Convert.ToInt32("1")).ToString();
            }
            else
            {
                txtCodigo.Text = "1";

            }


            cmd.Dispose();
            conn.Close();

        }
        void limpa()
        {
            txtCodigo.Text = string.Empty;
            CboTipoDoc.SelectedIndex = -1;
            txtNumeroDoc.Text = string.Empty;
            //txtNumeroBI.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtApelido.Text = string.Empty;
            cboSexo.SelectedIndex = -1;
            txtTelefone.Text = string.Empty;
            txtTelefone2.Text = string.Empty;
            txtEmail.Text = string.Empty;
        }
        void buscar_tipo_doc()
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlDataReader dread = null;
            conn = conexao.conneccao.abra_connecao();
            conn.Open();
            string databases = "select DescricaoDoc from TipoDoc order by( DescricaoDoc)asc ";
            cmd = new SqlCommand(databases, conn);
            dread = cmd.ExecuteReader();
            CboTipoDoc.Items.Clear();
            while (dread.Read())
            {
                CboTipoDoc.Items.Add(dread["DescricaoDoc"].ToString());

            }
            conn.Close();
            cmd.Dispose();
        }

        void carrega_sexo()
        {
            SqlCommand cmd = null;
            SqlConnection conn = null;
            SqlDataReader dread = null;
            try
            {
                conn = conexao.conneccao.abra_connecao();
                conn.Open();
                string bd = "select * from TB_sexo";
                cmd = new SqlCommand(bd, conn);
                dread = cmd.ExecuteReader();
                cboSexo.Items.Clear();
                while (dread.Read())
                {
                    cboSexo.Items.Add(dread["sexo"].ToString());
                }


            }
            catch (Exception p)
            {
                MessageBox.Show("nao tem sexo" + p);
                this.Close();
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }
        public FrmFuncionario()
        {
            InitializeComponent();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Funcionario_Load(object sender, EventArgs e)
        {
            limpa();
            carrega_codigo();
            carrega_sexo();
            buscar_tipo_doc();
            buscar_funcionario();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (CboTipoDoc.Text == string.Empty | txtNumeroDoc.Text == string.Empty | txtNome.Text == string.Empty
               || txtApelido.Text == string.Empty | cboSexo.Text == string.Empty | txtTelefone.Text == string.Empty)
            {
                MessageBox.Show("Os campos Tipo Documento, Numero Documento, Nome, Apelido, Sexo & Telefone não podem ficar vazios!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                SqlCommand cmd = null;
                SqlConnection conn = null;
                try
                {
                    conn = conexao.conneccao.abra_connecao();
                    conn.Open();
                    string db = "insert into TB_Funcionario(IdFuncionario,Tipo_Doc,Número_doc,Nome,Apelido,Sexo,Contacto,Telefone_Alternativo,Email)" +
                        "values('" + txtCodigo.Text + "','" + desc_tipo_doc + "','" + txtNumeroDoc.Text + "','" + txtNome.Text + "','" + txtApelido.Text + "', '" + funcionario_sexo + "','" + txtTelefone.Text + "','" + txtTelefone2.Text + "','" + txtEmail.Text + "')";
                    cmd = new SqlCommand(db, conn);
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Registro gravado com sucesso");
                        limpa();
                        carrega_codigo();
                        buscar_funcionario();
                    }
                    
                }


                catch (Exception ex)
                {
                    MessageBox.Show("erro de insercao" + ex);
                }
                finally
                {

                    conn.Close();
                    cmd.Dispose();
                }
            }

        }

        public string funcionario_sexo;
        private void cboSexo_TextChanged(object sender, EventArgs e)
        {

            SqlCommand cmd = null;
            SqlConnection conn = null;
            SqlDataReader dread = null;
            conn = conexao.conneccao.abra_connecao();
            conn.Open();
            string bd = "select IdSexo from TB_Sexo where Sexo like '" + cboSexo.Text + "'";
            cmd = new SqlCommand(bd, conn);
            dread = cmd.ExecuteReader();
            if (dread.Read())
            {
                funcionario_sexo = dread["IdSexo"].ToString();
            }
            conn.Close();
            cmd.Dispose();
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {

            vld.ValidacaoNemeros(e);

        }

        private void txtTelefone2_KeyPress(object sender, KeyPressEventArgs e)
        {
            vld.ValidacaoNemeros(e);
        }

        private void btn_doc_Click(object sender, EventArgs e)
        {
            Telas.FrmTipoDoc k = new Telas.FrmTipoDoc();
            k.ShowDialog();
        }

        private void cboSexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public string desc_tipo_doc;
        private void CboTipoDoc_TextChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = null;
            SqlConnection conn = null;
            SqlDataReader dread = null;
            conn = conexao.conneccao.abra_connecao();
            conn.Open();
            string bd = "select Tipo_Documento from TipoDoc where DescricaoDoc like'" + CboTipoDoc.Text + "'";
            cmd = new SqlCommand(bd, conn);
            dread = cmd.ExecuteReader();
            if (dread.Read())
            {
                desc_tipo_doc = dread["Tipo_Documento"].ToString();
            }
            conn.Close();
            cmd.Dispose();

        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void CboTipoDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            


            
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            limpa();
            carrega_codigo();
            buscar_funcionario();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = null;
            SqlConnection conn = null;
            try
            {
                conn = conexao.conneccao.abra_connecao();
                conn.Open();
                string SQL = "Update TB_Funcionario Set Nome = '" + txtNome.Text + "', Apelido = '" + txtApelido.Text + "', Tipo_Doc = '" + desc_tipo_doc + "', Número_doc = '" + txtNumeroBI.Text + "'" +
                  " ,Sexo = '" + funcionario_sexo + "', Contacto = '" + txtTelefone.Text + "',Telefone_Alternativo  = '" + txtTelefone2.Text + "', Email = '" + txtEmail.Text + "'"+
                     " Where idFuncionario = '" + txtCodigo.Text+ "'";
                cmd = new SqlCommand(SQL, conn);
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Registo actualizado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar estabelecer conexao com o servidor\n" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            limpa();
            carrega_codigo();
            buscar_funcionario();

        }

        private void txtTelefone2_TextChanged(object sender, EventArgs e)
        {

        }
        public int opcao;
        private void Txt_filtra_TextChanged(object sender, EventArgs e)
        {
           
            switch (opcao)
            {
                case 1:
                    SqlCommand cmd = null;
                    SqlConnection conn = null;
                    SqlDataReader dread = null;
                    conn = conexao.conneccao.abra_connecao();
                    conn.Open();
                    string pili = "select * from consulta_funcionario where  Nome like '" + txt_filtra.Text + "%'";
                    cmd = new SqlCommand(pili, conn);
                    dread = cmd.ExecuteReader();
                    dgv_funcionario.Rows.Clear();
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
                    break;
                case 2:
                    conn = conexao.conneccao.abra_connecao();
                    conn.Open();
                    string li = "select * from consulta_funcionario where  Contacto like '" + txt_filtra.Text + "%'";
                    cmd = new SqlCommand(li, conn);
                    dread = cmd.ExecuteReader();
                    dgv_funcionario.Rows.Clear();
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
                    break;
                case 3:
                    conn = conexao.conneccao.abra_connecao();
                    conn.Open();
                    string i ="select* from consulta_funcionario where  sexo like '" + txt_filtra.Text + "%'";
                    cmd = new SqlCommand(i, conn);
                    dread = cmd.ExecuteReader();
                    dgv_funcionario.Rows.Clear();
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
                    break;


            }
        }

        private void Rb_nome_Click(object sender, EventArgs e)
        {
        
            opcao = 1;
            txt_filtra.Focus();
            switch (opcao)
            {
                case 1:
                    SqlCommand cmd = null;
                    SqlConnection conn = null;
                    SqlDataReader dread = null;
                    conn = conexao.conneccao.abra_connecao();
                    conn.Open();
                    string pili = "select* from consulta_funcionario where  Nome like '" + txt_filtra.Text + "%'";
                    cmd = new SqlCommand(pili, conn);
                    dread = cmd.ExecuteReader();
                    dgv_funcionario.Rows.Clear();
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
                    break;

            }
        }

        private void Rb_Telefone_Click(object sender, EventArgs e)
        {
        
            opcao = 2;
            txt_filtra.Focus();
            switch (opcao)
            { 
            case 2:
                SqlCommand cmd = null;
                SqlConnection conn = null;
                SqlDataReader dread = null;
                conn = conexao.conneccao.abra_connecao();
                conn.Open();
                string li = "select* from consulta_funcionario where contacto like '" + txt_filtra.Text + "%'";
                cmd = new SqlCommand(li, conn);
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
                break;
            }
        }

        private void Rb_Sexo_Click(object sender, EventArgs e)
        {
         
            opcao = 3;
            txt_filtra.Focus();
            switch (opcao)
            {
                case 3:
                    SqlCommand cmd = null;
                    SqlConnection conn = null;
                    SqlDataReader dread = null;
                    conn = conexao.conneccao.abra_connecao();
                    conn.Open();
                    string li = "select * from consulta_funcionario where  sexo like '" + txt_filtra.Text + "%'";
                    cmd = new SqlCommand(li, conn);
                    dread = cmd.ExecuteReader();
                    dgv_funcionario.Rows.Clear();
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
                    break;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Telas.FrmTipoDoc k = new Telas.FrmTipoDoc();
            k.ShowDialog();
        }

        private void Dgv_funcionario_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
      
           txtCodigo.Text = (dgv_funcionario.CurrentRow.Cells[0].Value).ToString();
            CboTipoDoc.Text = (dgv_funcionario.CurrentRow.Cells[1].Value).ToString();
            txtNumeroBI.Text = (dgv_funcionario.CurrentRow.Cells[2].Value).ToString();
            txtNome.Text = (dgv_funcionario.CurrentRow.Cells[3].Value).ToString();
            txtApelido.Text = (dgv_funcionario.CurrentRow.Cells[4].Value).ToString();
            cboSexo.Text= (dgv_funcionario.CurrentRow.Cells[5].Value).ToString();
            txtTelefone.Text = (dgv_funcionario.CurrentRow.Cells[6].Value).ToString();
            txtTelefone2.Text = (dgv_funcionario.CurrentRow.Cells[7].Value).ToString();
            txtEmail.Text = (dgv_funcionario.CurrentRow.Cells[8].Value).ToString();
        
        }

        private void Dgv_funcionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnApaga_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = null;
            SqlConnection conn = null;

            try
            {
                conn = conexao.conneccao.abra_connecao();
                conn.Open();
                string SQL = "delete from TB_Funcionario  Where idFuncionario like '" + txtCodigo.Text + "'";
                cmd = new SqlCommand(SQL, conn);
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Registo eliminado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar estabelecer conexao com o servidor\n" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            limpa();
            carrega_codigo();
            buscar_funcionario();
        }

        private void Rb_nome_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtNumeroBI_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
