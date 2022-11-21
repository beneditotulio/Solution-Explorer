namespace sistema_de_gestao_stock.listagens
{
    partial class FrmListagemRequisicao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListagemRequisicao));
            this.dgv_requisicao = new System.Windows.Forms.DataGridView();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.lbl_total = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_filtra = new System.Windows.Forms.ComboBox();
            this.txt_prod_pesquiza = new System.Windows.Forms.TextBox();
            this.lbl_produto = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnImpressao = new System.Windows.Forms.Button();
            this.lblListagemCliente = new System.Windows.Forms.Label();
            this.orden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_requisicao)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_requisicao
            // 
            this.dgv_requisicao.AllowUserToAddRows = false;
            this.dgv_requisicao.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Maroon;
            this.dgv_requisicao.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_requisicao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_requisicao.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_requisicao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_requisicao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_requisicao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orden,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column11,
            this.Column5,
            this.Column6,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column7});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_requisicao.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_requisicao.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgv_requisicao.Location = new System.Drawing.Point(9, 74);
            this.dgv_requisicao.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_requisicao.Name = "dgv_requisicao";
            this.dgv_requisicao.ReadOnly = true;
            this.dgv_requisicao.RowHeadersWidth = 51;
            this.dgv_requisicao.RowTemplate.Height = 24;
            this.dgv_requisicao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_requisicao.Size = new System.Drawing.Size(1374, 586);
            this.dgv_requisicao.TabIndex = 142;
            // 
            // btn_fechar
            // 
            this.btn_fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_fechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(28)))), ((int)(((byte)(78)))));
            this.btn_fechar.FlatAppearance.BorderSize = 0;
            this.btn_fechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_fechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(28)))), ((int)(((byte)(78)))));
            this.btn_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fechar.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fechar.ForeColor = System.Drawing.Color.Transparent;
            this.btn_fechar.Image = ((System.Drawing.Image)(resources.GetObject("btn_fechar.Image")));
            this.btn_fechar.Location = new System.Drawing.Point(1345, 2);
            this.btn_fechar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(38, 32);
            this.btn_fechar.TabIndex = 160;
            this.btn_fechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_fechar.UseVisualStyleBackColor = false;
            this.btn_fechar.Click += new System.EventHandler(this.Btn_fechar_Click);
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.BackColor = System.Drawing.Color.White;
            this.lbl_total.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic);
            this.lbl_total.ForeColor = System.Drawing.Color.Black;
            this.lbl_total.Location = new System.Drawing.Point(766, 28);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(15, 17);
            this.lbl_total.TabIndex = 159;
            this.lbl_total.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(719, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 158;
            this.label1.Text = "Total:";
            // 
            // cbo_filtra
            // 
            this.cbo_filtra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_filtra.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic);
            this.cbo_filtra.FormattingEnabled = true;
            this.cbo_filtra.Items.AddRange(new object[] {
            "Produto",
            "Unidade",
            "Categoia",
            "Cliente",
            "Preco",
            "Data"});
            this.cbo_filtra.Location = new System.Drawing.Point(75, 19);
            this.cbo_filtra.Name = "cbo_filtra";
            this.cbo_filtra.Size = new System.Drawing.Size(218, 25);
            this.cbo_filtra.TabIndex = 157;
            this.cbo_filtra.SelectedIndexChanged += new System.EventHandler(this.cbo_filtra_SelectedIndexChanged);
            // 
            // txt_prod_pesquiza
            // 
            this.txt_prod_pesquiza.Enabled = false;
            this.txt_prod_pesquiza.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic);
            this.txt_prod_pesquiza.Location = new System.Drawing.Point(369, 22);
            this.txt_prod_pesquiza.Name = "txt_prod_pesquiza";
            this.txt_prod_pesquiza.Size = new System.Drawing.Size(308, 24);
            this.txt_prod_pesquiza.TabIndex = 156;
            this.txt_prod_pesquiza.TextChanged += new System.EventHandler(this.Txt_prod_pesquiza_TextChanged);
            // 
            // lbl_produto
            // 
            this.lbl_produto.AutoSize = true;
            this.lbl_produto.BackColor = System.Drawing.Color.White;
            this.lbl_produto.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic);
            this.lbl_produto.ForeColor = System.Drawing.Color.Black;
            this.lbl_produto.Location = new System.Drawing.Point(300, 24);
            this.lbl_produto.Name = "lbl_produto";
            this.lbl_produto.Size = new System.Drawing.Size(64, 17);
            this.lbl_produto.TabIndex = 155;
            this.lbl_produto.Text = "Pesquisar:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbo_filtra);
            this.groupBox1.Controls.Add(this.lbl_produto);
            this.groupBox1.Controls.Add(this.txt_prod_pesquiza);
            this.groupBox1.Controls.Add(this.lbl_total);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 690);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1362, 64);
            this.groupBox1.TabIndex = 162;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar Por:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(28)))), ((int)(((byte)(78)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnImpressao);
            this.panel1.Controls.Add(this.lblListagemCliente);
            this.panel1.Controls.Add(this.btn_fechar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1386, 47);
            this.panel1.TabIndex = 163;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 177;
            this.pictureBox1.TabStop = false;
            // 
            // btnImpressao
            // 
            this.btnImpressao.FlatAppearance.BorderSize = 0;
            this.btnImpressao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImpressao.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImpressao.ForeColor = System.Drawing.Color.White;
            this.btnImpressao.Image = ((System.Drawing.Image)(resources.GetObject("btnImpressao.Image")));
            this.btnImpressao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImpressao.Location = new System.Drawing.Point(870, 2);
            this.btnImpressao.Name = "btnImpressao";
            this.btnImpressao.Size = new System.Drawing.Size(121, 42);
            this.btnImpressao.TabIndex = 161;
            this.btnImpressao.Text = "       Imprimir";
            this.btnImpressao.UseVisualStyleBackColor = true;
            this.btnImpressao.Click += new System.EventHandler(this.btnImpressao_Click);
            // 
            // lblListagemCliente
            // 
            this.lblListagemCliente.AutoSize = true;
            this.lblListagemCliente.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListagemCliente.ForeColor = System.Drawing.Color.White;
            this.lblListagemCliente.Location = new System.Drawing.Point(56, 11);
            this.lblListagemCliente.Name = "lblListagemCliente";
            this.lblListagemCliente.Size = new System.Drawing.Size(151, 22);
            this.lblListagemCliente.TabIndex = 176;
            this.lblListagemCliente.Text = "&Listagem Requisição";
            // 
            // orden
            // 
            this.orden.HeaderText = "Orden";
            this.orden.MinimumWidth = 6;
            this.orden.Name = "orden";
            this.orden.ReadOnly = true;
            this.orden.Width = 50;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Produto";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Categoria";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Data";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cliente";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 350;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Empresa";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Visible = false;
            this.Column11.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "unidade";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Preco";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Quantidade";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Stock em dia";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 125;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Quantidade_Atual";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "sub_total";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 125;
            // 
            // FrmListagemRequisicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1386, 766);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_requisicao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(302, 45);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmListagemRequisicao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Requisicao";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmListagemRequisicao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_requisicao)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_requisicao;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_filtra;
        private System.Windows.Forms.TextBox txt_prod_pesquiza;
        private System.Windows.Forms.Label lbl_produto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnImpressao;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblListagemCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn orden;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}