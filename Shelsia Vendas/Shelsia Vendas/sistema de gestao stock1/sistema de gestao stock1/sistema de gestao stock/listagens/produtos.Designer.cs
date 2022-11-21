namespace sistema_de_gestao_stock.listagens
{
    partial class produtos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(produtos));
            this.dgv_Produto = new System.Windows.Forms.DataGridView();
            this.orden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbo_filtra = new System.Windows.Forms.ComboBox();
            this.txt_prod_pesquiza = new System.Windows.Forms.TextBox();
            this.lbl_produto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnImpressao = new System.Windows.Forms.Button();
            this.lblListagemCliente = new System.Windows.Forms.Label();
            this.btnSai = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Produto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Produto
            // 
            this.dgv_Produto.AllowUserToAddRows = false;
            this.dgv_Produto.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Maroon;
            this.dgv_Produto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Produto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Produto.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Produto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Produto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Produto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orden,
            this.Column1,
            this.Column4,
            this.Column6,
            this.Column7});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Produto.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Produto.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgv_Produto.Location = new System.Drawing.Point(11, 78);
            this.dgv_Produto.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_Produto.Name = "dgv_Produto";
            this.dgv_Produto.ReadOnly = true;
            this.dgv_Produto.RowHeadersWidth = 51;
            this.dgv_Produto.RowTemplate.Height = 24;
            this.dgv_Produto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Produto.Size = new System.Drawing.Size(1341, 586);
            this.dgv_Produto.TabIndex = 127;
            // 
            // orden
            // 
            this.orden.HeaderText = "Orden";
            this.orden.MinimumWidth = 6;
            this.orden.Name = "orden";
            this.orden.ReadOnly = true;
            this.orden.Width = 70;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Produto";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 400;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Unidade";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 350;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Quantidade";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 120;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Categoria";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 317;
            // 
            // cbo_filtra
            // 
            this.cbo_filtra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_filtra.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic);
            this.cbo_filtra.FormattingEnabled = true;
            this.cbo_filtra.Items.AddRange(new object[] {
            "Produto",
            "Unidade",
            "Categoia"});
            this.cbo_filtra.Location = new System.Drawing.Point(96, 24);
            this.cbo_filtra.Name = "cbo_filtra";
            this.cbo_filtra.Size = new System.Drawing.Size(218, 25);
            this.cbo_filtra.TabIndex = 132;
            this.cbo_filtra.SelectedIndexChanged += new System.EventHandler(this.Cbo_filtra_SelectedIndexChanged);
            // 
            // txt_prod_pesquiza
            // 
            this.txt_prod_pesquiza.Enabled = false;
            this.txt_prod_pesquiza.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prod_pesquiza.Location = new System.Drawing.Point(407, 24);
            this.txt_prod_pesquiza.Name = "txt_prod_pesquiza";
            this.txt_prod_pesquiza.Size = new System.Drawing.Size(300, 25);
            this.txt_prod_pesquiza.TabIndex = 130;
            this.txt_prod_pesquiza.TextChanged += new System.EventHandler(this.Txt_prod_pesquiza_TextChanged);
            // 
            // lbl_produto
            // 
            this.lbl_produto.AutoSize = true;
            this.lbl_produto.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_produto.ForeColor = System.Drawing.Color.Black;
            this.lbl_produto.Location = new System.Drawing.Point(336, 26);
            this.lbl_produto.Name = "lbl_produto";
            this.lbl_produto.Size = new System.Drawing.Size(65, 18);
            this.lbl_produto.TabIndex = 129;
            this.lbl_produto.Text = "Pesquisar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(731, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 18);
            this.label1.TabIndex = 133;
            this.label1.Text = "Total:";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.ForeColor = System.Drawing.Color.Black;
            this.lbl_total.Location = new System.Drawing.Point(776, 27);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(15, 18);
            this.lbl_total.TabIndex = 134;
            this.lbl_total.Text = "0";
            // 
            // btn_fechar
            // 
            this.btn_fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_fechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(1)))));
            this.btn_fechar.FlatAppearance.BorderSize = 0;
            this.btn_fechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_fechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btn_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fechar.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fechar.ForeColor = System.Drawing.Color.Transparent;
            this.btn_fechar.Location = new System.Drawing.Point(1340, 1);
            this.btn_fechar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(38, 32);
            this.btn_fechar.TabIndex = 148;
            this.btn_fechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_fechar.UseVisualStyleBackColor = false;
            this.btn_fechar.Click += new System.EventHandler(this.Btn_fechar_Click);
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
            this.groupBox1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic);
            this.groupBox1.Location = new System.Drawing.Point(11, 669);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1341, 61);
            this.groupBox1.TabIndex = 155;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar Por:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(28)))), ((int)(((byte)(78)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnImpressao);
            this.panel1.Controls.Add(this.lblListagemCliente);
            this.panel1.Controls.Add(this.btnSai);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1378, 47);
            this.panel1.TabIndex = 164;
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
            this.lblListagemCliente.Size = new System.Drawing.Size(138, 22);
            this.lblListagemCliente.TabIndex = 176;
            this.lblListagemCliente.Text = "&Listagem Produtos";
            // 
            // btnSai
            // 
            this.btnSai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(28)))), ((int)(((byte)(78)))));
            this.btnSai.FlatAppearance.BorderSize = 0;
            this.btnSai.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSai.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(28)))), ((int)(((byte)(78)))));
            this.btnSai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSai.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSai.ForeColor = System.Drawing.Color.Transparent;
            this.btnSai.Image = ((System.Drawing.Image)(resources.GetObject("btnSai.Image")));
            this.btnSai.Location = new System.Drawing.Point(1327, 5);
            this.btnSai.Margin = new System.Windows.Forms.Padding(2);
            this.btnSai.Name = "btnSai";
            this.btnSai.Size = new System.Drawing.Size(38, 32);
            this.btnSai.TabIndex = 160;
            this.btnSai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSai.UseVisualStyleBackColor = false;
            this.btnSai.Click += new System.EventHandler(this.btnSai_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1378, 766);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.dgv_Produto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(302, 45);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "produtos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "produtos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Produtos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Produto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Produto;
        private System.Windows.Forms.ComboBox cbo_filtra;
        private System.Windows.Forms.TextBox txt_prod_pesquiza;
        private System.Windows.Forms.Label lbl_produto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnImpressao;
        private System.Windows.Forms.Label lblListagemCliente;
        private System.Windows.Forms.Button btnSai;
        private System.Windows.Forms.DataGridViewTextBoxColumn orden;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}