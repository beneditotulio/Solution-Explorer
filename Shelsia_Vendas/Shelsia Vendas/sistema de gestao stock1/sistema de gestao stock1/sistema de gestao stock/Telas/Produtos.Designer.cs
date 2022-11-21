namespace sistema_de_gestao_stock.Telas
{
    partial class Produtos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Produtos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button3 = new System.Windows.Forms.Button();
            this.txt_cod_p = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_prod = new System.Windows.Forms.TextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblApelido = new System.Windows.Forms.Label();
            this.lbl_produto = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtquatidade = new System.Windows.Forms.TextBox();
            this.cbo_categoria = new System.Windows.Forms.ComboBox();
            this.btnApaga_enc = new System.Windows.Forms.Button();
            this.btnEdit_enc = new System.Windows.Forms.Button();
            this.btnSalva_enc = new System.Windows.Forms.Button();
            this.btnNovo_enc = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.cbo_unidade = new System.Windows.Forms.ComboBox();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.dgv_Produto = new System.Windows.Forms.DataGridView();
            this.orden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.actualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Produto)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(28)))), ((int)(((byte)(78)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(28)))), ((int)(((byte)(78)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(453, 95);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(31, 31);
            this.button3.TabIndex = 111;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // txt_cod_p
            // 
            this.txt_cod_p.Enabled = false;
            this.txt_cod_p.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic);
            this.txt_cod_p.Location = new System.Drawing.Point(131, 62);
            this.txt_cod_p.Name = "txt_cod_p";
            this.txt_cod_p.Size = new System.Drawing.Size(66, 29);
            this.txt_cod_p.TabIndex = 109;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(28)))), ((int)(((byte)(78)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(28)))), ((int)(((byte)(78)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(351, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 29);
            this.button1.TabIndex = 108;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_prod
            // 
            this.txt_prod.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic);
            this.txt_prod.Location = new System.Drawing.Point(131, 95);
            this.txt_prod.Name = "txt_prod";
            this.txt_prod.Size = new System.Drawing.Size(321, 29);
            this.txt_prod.TabIndex = 106;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic);
            this.lblSexo.ForeColor = System.Drawing.Color.Black;
            this.lblSexo.Location = new System.Drawing.Point(47, 198);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(81, 22);
            this.lblSexo.TabIndex = 105;
            this.lblSexo.Text = "Categoria:";
            // 
            // lblApelido
            // 
            this.lblApelido.AutoSize = true;
            this.lblApelido.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic);
            this.lblApelido.ForeColor = System.Drawing.Color.Black;
            this.lblApelido.Location = new System.Drawing.Point(43, 164);
            this.lblApelido.Name = "lblApelido";
            this.lblApelido.Size = new System.Drawing.Size(85, 22);
            this.lblApelido.TabIndex = 104;
            this.lblApelido.Text = "Quatidade:";
            // 
            // lbl_produto
            // 
            this.lbl_produto.AutoSize = true;
            this.lbl_produto.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic);
            this.lbl_produto.ForeColor = System.Drawing.Color.Black;
            this.lbl_produto.Location = new System.Drawing.Point(58, 98);
            this.lbl_produto.Name = "lbl_produto";
            this.lbl_produto.Size = new System.Drawing.Size(70, 22);
            this.lbl_produto.TabIndex = 102;
            this.lbl_produto.Text = "Produto:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic);
            this.lblCodigo.ForeColor = System.Drawing.Color.Black;
            this.lblCodigo.Location = new System.Drawing.Point(52, 65);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(76, 22);
            this.lblCodigo.TabIndex = 101;
            this.lblCodigo.Text = "N Ordem:";
            // 
            // txtquatidade
            // 
            this.txtquatidade.Enabled = false;
            this.txtquatidade.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic);
            this.txtquatidade.Location = new System.Drawing.Point(131, 161);
            this.txtquatidade.Name = "txtquatidade";
            this.txtquatidade.Size = new System.Drawing.Size(66, 29);
            this.txtquatidade.TabIndex = 100;
            this.txtquatidade.Text = "0";
            // 
            // cbo_categoria
            // 
            this.cbo_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_categoria.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic);
            this.cbo_categoria.FormattingEnabled = true;
            this.cbo_categoria.Location = new System.Drawing.Point(131, 195);
            this.cbo_categoria.Name = "cbo_categoria";
            this.cbo_categoria.Size = new System.Drawing.Size(218, 30);
            this.cbo_categoria.TabIndex = 99;
            this.cbo_categoria.SelectedIndexChanged += new System.EventHandler(this.cbo_categoria_SelectedIndexChanged);
            this.cbo_categoria.TextChanged += new System.EventHandler(this.cbo_categoria_TextChanged);
            // 
            // btnApaga_enc
            // 
            this.btnApaga_enc.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnApaga_enc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(28)))), ((int)(((byte)(78)))));
            this.btnApaga_enc.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnApaga_enc.FlatAppearance.BorderSize = 0;
            this.btnApaga_enc.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnApaga_enc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnApaga_enc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(28)))), ((int)(((byte)(78)))));
            this.btnApaga_enc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApaga_enc.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic);
            this.btnApaga_enc.ForeColor = System.Drawing.Color.White;
            this.btnApaga_enc.Image = ((System.Drawing.Image)(resources.GetObject("btnApaga_enc.Image")));
            this.btnApaga_enc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApaga_enc.Location = new System.Drawing.Point(731, 648);
            this.btnApaga_enc.Name = "btnApaga_enc";
            this.btnApaga_enc.Size = new System.Drawing.Size(119, 42);
            this.btnApaga_enc.TabIndex = 112;
            this.btnApaga_enc.Text = "      Apagar";
            this.btnApaga_enc.UseVisualStyleBackColor = false;
            this.btnApaga_enc.Click += new System.EventHandler(this.BtnApaga_enc_Click);
            // 
            // btnEdit_enc
            // 
            this.btnEdit_enc.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEdit_enc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(28)))), ((int)(((byte)(78)))));
            this.btnEdit_enc.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEdit_enc.FlatAppearance.BorderSize = 0;
            this.btnEdit_enc.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnEdit_enc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEdit_enc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(28)))), ((int)(((byte)(78)))));
            this.btnEdit_enc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit_enc.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic);
            this.btnEdit_enc.ForeColor = System.Drawing.Color.White;
            this.btnEdit_enc.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit_enc.Image")));
            this.btnEdit_enc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit_enc.Location = new System.Drawing.Point(610, 648);
            this.btnEdit_enc.Name = "btnEdit_enc";
            this.btnEdit_enc.Size = new System.Drawing.Size(115, 42);
            this.btnEdit_enc.TabIndex = 113;
            this.btnEdit_enc.Text = "      Editar";
            this.btnEdit_enc.UseVisualStyleBackColor = false;
            this.btnEdit_enc.Click += new System.EventHandler(this.BtnEdit_enc_Click);
            // 
            // btnSalva_enc
            // 
            this.btnSalva_enc.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSalva_enc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(28)))), ((int)(((byte)(78)))));
            this.btnSalva_enc.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalva_enc.FlatAppearance.BorderSize = 0;
            this.btnSalva_enc.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnSalva_enc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSalva_enc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(28)))), ((int)(((byte)(78)))));
            this.btnSalva_enc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalva_enc.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic);
            this.btnSalva_enc.ForeColor = System.Drawing.Color.White;
            this.btnSalva_enc.Image = ((System.Drawing.Image)(resources.GetObject("btnSalva_enc.Image")));
            this.btnSalva_enc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalva_enc.Location = new System.Drawing.Point(491, 648);
            this.btnSalva_enc.Name = "btnSalva_enc";
            this.btnSalva_enc.Size = new System.Drawing.Size(113, 42);
            this.btnSalva_enc.TabIndex = 114;
            this.btnSalva_enc.Text = "      Salvar";
            this.btnSalva_enc.UseVisualStyleBackColor = false;
            this.btnSalva_enc.Click += new System.EventHandler(this.btnSalva_enc_Click);
            // 
            // btnNovo_enc
            // 
            this.btnNovo_enc.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNovo_enc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(28)))), ((int)(((byte)(78)))));
            this.btnNovo_enc.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNovo_enc.FlatAppearance.BorderSize = 0;
            this.btnNovo_enc.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnNovo_enc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnNovo_enc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(28)))), ((int)(((byte)(78)))));
            this.btnNovo_enc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo_enc.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic);
            this.btnNovo_enc.ForeColor = System.Drawing.Color.White;
            this.btnNovo_enc.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo_enc.Image")));
            this.btnNovo_enc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo_enc.Location = new System.Drawing.Point(375, 648);
            this.btnNovo_enc.Name = "btnNovo_enc";
            this.btnNovo_enc.Size = new System.Drawing.Size(110, 42);
            this.btnNovo_enc.TabIndex = 115;
            this.btnNovo_enc.Text = "     Novo";
            this.btnNovo_enc.UseVisualStyleBackColor = false;
            this.btnNovo_enc.Click += new System.EventHandler(this.BtnNovo_enc_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic);
            this.lblNome.ForeColor = System.Drawing.Color.Black;
            this.lblNome.Location = new System.Drawing.Point(54, 132);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(74, 22);
            this.lblNome.TabIndex = 103;
            this.lblNome.Text = "Unidade:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(28)))), ((int)(((byte)(78)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(28)))), ((int)(((byte)(78)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(350, 129);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 29);
            this.button2.TabIndex = 110;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbo_unidade
            // 
            this.cbo_unidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_unidade.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic);
            this.cbo_unidade.FormattingEnabled = true;
            this.cbo_unidade.Location = new System.Drawing.Point(131, 129);
            this.cbo_unidade.Name = "cbo_unidade";
            this.cbo_unidade.Size = new System.Drawing.Size(218, 30);
            this.cbo_unidade.TabIndex = 117;
            this.cbo_unidade.SelectedIndexChanged += new System.EventHandler(this.cbo_unidade_SelectedIndexChanged);
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
            this.btn_fechar.Location = new System.Drawing.Point(1241, 5);
            this.btn_fechar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(38, 32);
            this.btn_fechar.TabIndex = 125;
            this.btn_fechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_fechar.UseVisualStyleBackColor = false;
            this.btn_fechar.Click += new System.EventHandler(this.Btn_fechar_Click);
            // 
            // dgv_Produto
            // 
            this.dgv_Produto.AllowUserToAddRows = false;
            this.dgv_Produto.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(28)))), ((int)(((byte)(78)))));
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
            this.dgv_Produto.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Produto.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Produto.GridColor = System.Drawing.Color.White;
            this.dgv_Produto.Location = new System.Drawing.Point(30, 231);
            this.dgv_Produto.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_Produto.Name = "dgv_Produto";
            this.dgv_Produto.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Produto.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_Produto.RowHeadersWidth = 51;
            this.dgv_Produto.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Produto.RowTemplate.Height = 24;
            this.dgv_Produto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Produto.Size = new System.Drawing.Size(1205, 336);
            this.dgv_Produto.TabIndex = 126;
            this.dgv_Produto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_encomenda_CellContentClick);
            this.dgv_Produto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Produto_CellContentClick);
            // 
            // orden
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orden.DefaultCellStyle = dataGridViewCellStyle3;
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
            this.Column6.HeaderText = "Quant.";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 80;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Categoria";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 250;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(28)))), ((int)(((byte)(78)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_fechar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1284, 42);
            this.panel1.TabIndex = 127;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 129;
            this.label1.Text = "Productos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 128;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actualizarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(127, 26);
            // 
            // actualizarToolStripMenuItem
            // 
            this.actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            this.actualizarToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.actualizarToolStripMenuItem.Text = "Actualizar";
            this.actualizarToolStripMenuItem.Click += new System.EventHandler(this.actualizarToolStripMenuItem_Click);
            // 
            // Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1284, 709);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_Produto);
            this.Controls.Add(this.cbo_unidade);
            this.Controls.Add(this.btnApaga_enc);
            this.Controls.Add(this.btnEdit_enc);
            this.Controls.Add(this.btnSalva_enc);
            this.Controls.Add(this.btnNovo_enc);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_cod_p);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_prod);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblApelido);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lbl_produto);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtquatidade);
            this.Controls.Add(this.cbo_categoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(302, 45);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Produtos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Produtos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Produto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txt_cod_p;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_prod;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblApelido;
        private System.Windows.Forms.Label lbl_produto;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtquatidade;
        private System.Windows.Forms.ComboBox cbo_categoria;
        private System.Windows.Forms.Button btnApaga_enc;
        private System.Windows.Forms.Button btnEdit_enc;
        private System.Windows.Forms.Button btnSalva_enc;
        private System.Windows.Forms.Button btnNovo_enc;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbo_unidade;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.DataGridView dgv_Produto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orden;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem;
    }
}