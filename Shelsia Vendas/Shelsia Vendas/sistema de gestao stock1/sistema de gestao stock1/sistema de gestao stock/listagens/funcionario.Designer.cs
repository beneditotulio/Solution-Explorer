namespace sistema_de_gestao_stock.listagens
{
    partial class FrmListagemFuncionario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListagemFuncionario));
            this.dgv_funcionario = new System.Windows.Forms.DataGridView();
            this.orden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.lbl_total = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_filtra = new System.Windows.Forms.ComboBox();
            this.txt_prod_pesquiza = new System.Windows.Forms.TextBox();
            this.lbl_produto = new System.Windows.Forms.Label();
            this.groupBoxPesqisarPor = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblListagemCliente = new System.Windows.Forms.Label();
            this.btnmprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_funcionario)).BeginInit();
            this.groupBoxPesqisarPor.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_funcionario
            // 
            this.dgv_funcionario.AllowUserToAddRows = false;
            this.dgv_funcionario.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Maroon;
            this.dgv_funcionario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_funcionario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_funcionario.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_funcionario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_funcionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_funcionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orden,
            this.Column1,
            this.Column4,
            this.Column6,
            this.Column7,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column8});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_funcionario.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_funcionario.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgv_funcionario.Location = new System.Drawing.Point(2, 81);
            this.dgv_funcionario.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_funcionario.Name = "dgv_funcionario";
            this.dgv_funcionario.ReadOnly = true;
            this.dgv_funcionario.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic);
            this.dgv_funcionario.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_funcionario.RowTemplate.Height = 24;
            this.dgv_funcionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_funcionario.Size = new System.Drawing.Size(1275, 554);
            this.dgv_funcionario.TabIndex = 128;
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
            this.Column1.HeaderText = "Tipo documento";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Número";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Nome";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 150;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Apelido";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Sexo";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Telfone_1";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Telfone_2";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Email";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 200;
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
            this.btn_fechar.Location = new System.Drawing.Point(1243, 2);
            this.btn_fechar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(38, 35);
            this.btn_fechar.TabIndex = 129;
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
            this.lbl_total.Location = new System.Drawing.Point(756, 23);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(15, 17);
            this.lbl_total.TabIndex = 139;
            this.lbl_total.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(709, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 138;
            this.label1.Text = "Total:";
            // 
            // cbo_filtra
            // 
            this.cbo_filtra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_filtra.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic);
            this.cbo_filtra.FormattingEnabled = true;
            this.cbo_filtra.Items.AddRange(new object[] {
            "Nome",
            "Apelido",
            "Sexo",
            "Contacto",
            "Número"});
            this.cbo_filtra.Location = new System.Drawing.Point(68, 19);
            this.cbo_filtra.Name = "cbo_filtra";
            this.cbo_filtra.Size = new System.Drawing.Size(218, 25);
            this.cbo_filtra.TabIndex = 137;
            this.cbo_filtra.SelectedIndexChanged += new System.EventHandler(this.Cbo_filtra_SelectedIndexChanged);
            // 
            // txt_prod_pesquiza
            // 
            this.txt_prod_pesquiza.Enabled = false;
            this.txt_prod_pesquiza.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic);
            this.txt_prod_pesquiza.Location = new System.Drawing.Point(361, 20);
            this.txt_prod_pesquiza.Name = "txt_prod_pesquiza";
            this.txt_prod_pesquiza.Size = new System.Drawing.Size(324, 24);
            this.txt_prod_pesquiza.TabIndex = 136;
            this.txt_prod_pesquiza.TextChanged += new System.EventHandler(this.Txt_prod_pesquiza_TextChanged);
            // 
            // lbl_produto
            // 
            this.lbl_produto.AutoSize = true;
            this.lbl_produto.BackColor = System.Drawing.Color.White;
            this.lbl_produto.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic);
            this.lbl_produto.ForeColor = System.Drawing.Color.Black;
            this.lbl_produto.Location = new System.Drawing.Point(291, 22);
            this.lbl_produto.Name = "lbl_produto";
            this.lbl_produto.Size = new System.Drawing.Size(64, 17);
            this.lbl_produto.TabIndex = 135;
            this.lbl_produto.Text = "Pesquisar:";
            // 
            // groupBoxPesqisarPor
            // 
            this.groupBoxPesqisarPor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPesqisarPor.Controls.Add(this.cbo_filtra);
            this.groupBoxPesqisarPor.Controls.Add(this.lbl_produto);
            this.groupBoxPesqisarPor.Controls.Add(this.lbl_total);
            this.groupBoxPesqisarPor.Controls.Add(this.txt_prod_pesquiza);
            this.groupBoxPesqisarPor.Controls.Add(this.label1);
            this.groupBoxPesqisarPor.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPesqisarPor.Location = new System.Drawing.Point(12, 677);
            this.groupBoxPesqisarPor.Name = "groupBoxPesqisarPor";
            this.groupBoxPesqisarPor.Size = new System.Drawing.Size(1259, 59);
            this.groupBoxPesqisarPor.TabIndex = 156;
            this.groupBoxPesqisarPor.TabStop = false;
            this.groupBoxPesqisarPor.Text = "Pesquisar Por:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(28)))), ((int)(((byte)(78)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblListagemCliente);
            this.panel1.Controls.Add(this.btnmprimir);
            this.panel1.Controls.Add(this.btn_fechar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1283, 45);
            this.panel1.TabIndex = 157;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 179;
            this.pictureBox1.TabStop = false;
            // 
            // lblListagemCliente
            // 
            this.lblListagemCliente.AutoSize = true;
            this.lblListagemCliente.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListagemCliente.ForeColor = System.Drawing.Color.White;
            this.lblListagemCliente.Location = new System.Drawing.Point(54, 10);
            this.lblListagemCliente.Name = "lblListagemCliente";
            this.lblListagemCliente.Size = new System.Drawing.Size(162, 22);
            this.lblListagemCliente.TabIndex = 178;
            this.lblListagemCliente.Text = "&Listagem Funcionario";
            // 
            // btnmprimir
            // 
            this.btnmprimir.FlatAppearance.BorderSize = 0;
            this.btnmprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmprimir.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmprimir.ForeColor = System.Drawing.Color.White;
            this.btnmprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnmprimir.Image")));
            this.btnmprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmprimir.Location = new System.Drawing.Point(832, 3);
            this.btnmprimir.Name = "btnmprimir";
            this.btnmprimir.Size = new System.Drawing.Size(116, 39);
            this.btnmprimir.TabIndex = 158;
            this.btnmprimir.Text = "        Imprimir";
            this.btnmprimir.UseVisualStyleBackColor = true;
            this.btnmprimir.Click += new System.EventHandler(this.btnmprimir_Click);
            // 
            // FrmListagemFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1283, 748);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBoxPesqisarPor);
            this.Controls.Add(this.dgv_funcionario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(302, 45);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmListagemFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "funcionario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Funcionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_funcionario)).EndInit();
            this.groupBoxPesqisarPor.ResumeLayout(false);
            this.groupBoxPesqisarPor.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_funcionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn orden;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_filtra;
        private System.Windows.Forms.TextBox txt_prod_pesquiza;
        private System.Windows.Forms.Label lbl_produto;
        private System.Windows.Forms.GroupBox groupBoxPesqisarPor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnmprimir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblListagemCliente;
    }
}