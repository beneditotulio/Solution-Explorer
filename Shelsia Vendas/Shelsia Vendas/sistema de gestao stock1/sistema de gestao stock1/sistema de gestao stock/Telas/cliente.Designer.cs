namespace sistema_de_gestao_stock.Telas
{
    partial class FrmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCliente));
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefone2 = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtcracha = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefoneAlter = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblApelido = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblCaracha = new System.Windows.Forms.Label();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btnPesquisa_numero_tel = new System.Windows.Forms.Button();
            this.btnPesquisa_numero_Nome = new System.Windows.Forms.Button();
            this.btnApaga = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic);
            this.txtEmail.Location = new System.Drawing.Point(173, 249);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(403, 29);
            this.txtEmail.TabIndex = 93;
            // 
            // txtTelefone2
            // 
            this.txtTelefone2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic);
            this.txtTelefone2.Location = new System.Drawing.Point(173, 216);
            this.txtTelefone2.Name = "txtTelefone2";
            this.txtTelefone2.Size = new System.Drawing.Size(172, 29);
            this.txtTelefone2.TabIndex = 92;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic);
            this.txtTelefone.Location = new System.Drawing.Point(173, 184);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(172, 29);
            this.txtTelefone.TabIndex = 91;
            // 
            // txtcracha
            // 
            this.txtcracha.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic);
            this.txtcracha.Location = new System.Drawing.Point(173, 88);
            this.txtcracha.Name = "txtcracha";
            this.txtcracha.Size = new System.Drawing.Size(172, 29);
            this.txtcracha.TabIndex = 90;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic);
            this.txtNome.Location = new System.Drawing.Point(173, 119);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(374, 29);
            this.txtNome.TabIndex = 89;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.White;
            this.lblEmail.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(113, 252);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(57, 22);
            this.lblEmail.TabIndex = 88;
            this.lblEmail.Text = "Email:";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // lblTelefoneAlter
            // 
            this.lblTelefoneAlter.AutoSize = true;
            this.lblTelefoneAlter.BackColor = System.Drawing.Color.White;
            this.lblTelefoneAlter.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefoneAlter.ForeColor = System.Drawing.Color.Black;
            this.lblTelefoneAlter.Location = new System.Drawing.Point(13, 218);
            this.lblTelefoneAlter.Name = "lblTelefoneAlter";
            this.lblTelefoneAlter.Size = new System.Drawing.Size(157, 22);
            this.lblTelefoneAlter.TabIndex = 87;
            this.lblTelefoneAlter.Text = "Telefone Alternativo:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.BackColor = System.Drawing.Color.White;
            this.lblTelefone.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.ForeColor = System.Drawing.Color.Black;
            this.lblTelefone.Location = new System.Drawing.Point(97, 187);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(73, 22);
            this.lblTelefone.TabIndex = 86;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.BackColor = System.Drawing.Color.White;
            this.lblSexo.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.ForeColor = System.Drawing.Color.Black;
            this.lblSexo.Location = new System.Drawing.Point(122, 154);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(48, 22);
            this.lblSexo.TabIndex = 85;
            this.lblSexo.Text = "Sexo:";
            // 
            // lblApelido
            // 
            this.lblApelido.AutoSize = true;
            this.lblApelido.BackColor = System.Drawing.Color.White;
            this.lblApelido.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApelido.ForeColor = System.Drawing.Color.Black;
            this.lblApelido.Location = new System.Drawing.Point(33, 91);
            this.lblApelido.Name = "lblApelido";
            this.lblApelido.Size = new System.Drawing.Size(137, 22);
            this.lblApelido.TabIndex = 84;
            this.lblApelido.Text = "Numero de cracha:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.White;
            this.lblNome.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.Black;
            this.lblNome.Location = new System.Drawing.Point(115, 122);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(55, 22);
            this.lblNome.TabIndex = 83;
            this.lblNome.Text = "Nome:";
            // 
            // cboSexo
            // 
            this.cboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSexo.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic);
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Location = new System.Drawing.Point(173, 151);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(172, 30);
            this.cboSexo.TabIndex = 81;
            this.cboSexo.SelectedIndexChanged += new System.EventHandler(this.CboSexo_SelectedIndexChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic);
            this.txtCodigo.Location = new System.Drawing.Point(173, 57);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(53, 29);
            this.txtCodigo.TabIndex = 80;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.White;
            this.lblCodigo.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.Black;
            this.lblCodigo.Location = new System.Drawing.Point(108, 60);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(62, 22);
            this.lblCodigo.TabIndex = 79;
            this.lblCodigo.Text = "Codigo:";
            // 
            // lblCaracha
            // 
            this.lblCaracha.AutoSize = true;
            this.lblCaracha.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaracha.ForeColor = System.Drawing.Color.White;
            this.lblCaracha.Location = new System.Drawing.Point(51, 9);
            this.lblCaracha.Name = "lblCaracha";
            this.lblCaracha.Size = new System.Drawing.Size(64, 25);
            this.lblCaracha.TabIndex = 97;
            this.lblCaracha.Text = "Cliente";
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
            this.btn_fechar.Location = new System.Drawing.Point(745, 3);
            this.btn_fechar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(38, 35);
            this.btn_fechar.TabIndex = 96;
            this.btn_fechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_fechar.UseVisualStyleBackColor = false;
            this.btn_fechar.Click += new System.EventHandler(this.Btn_fechar_Click);
            // 
            // btnPesquisa_numero_tel
            // 
            this.btnPesquisa_numero_tel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(28)))), ((int)(((byte)(78)))));
            this.btnPesquisa_numero_tel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisa_numero_tel.ForeColor = System.Drawing.Color.White;
            this.btnPesquisa_numero_tel.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisa_numero_tel.Image")));
            this.btnPesquisa_numero_tel.Location = new System.Drawing.Point(346, 185);
            this.btnPesquisa_numero_tel.Name = "btnPesquisa_numero_tel";
            this.btnPesquisa_numero_tel.Size = new System.Drawing.Size(33, 28);
            this.btnPesquisa_numero_tel.TabIndex = 95;
            this.btnPesquisa_numero_tel.UseVisualStyleBackColor = false;
            // 
            // btnPesquisa_numero_Nome
            // 
            this.btnPesquisa_numero_Nome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(28)))), ((int)(((byte)(78)))));
            this.btnPesquisa_numero_Nome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisa_numero_Nome.ForeColor = System.Drawing.Color.White;
            this.btnPesquisa_numero_Nome.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisa_numero_Nome.Image")));
            this.btnPesquisa_numero_Nome.Location = new System.Drawing.Point(550, 119);
            this.btnPesquisa_numero_Nome.Name = "btnPesquisa_numero_Nome";
            this.btnPesquisa_numero_Nome.Size = new System.Drawing.Size(31, 29);
            this.btnPesquisa_numero_Nome.TabIndex = 94;
            this.btnPesquisa_numero_Nome.UseVisualStyleBackColor = false;
            this.btnPesquisa_numero_Nome.Click += new System.EventHandler(this.BtnPesquisa_numero_Nome_Click);
            // 
            // btnApaga
            // 
            this.btnApaga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(28)))), ((int)(((byte)(78)))));
            this.btnApaga.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnApaga.FlatAppearance.BorderSize = 0;
            this.btnApaga.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnApaga.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnApaga.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(28)))), ((int)(((byte)(78)))));
            this.btnApaga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApaga.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic);
            this.btnApaga.ForeColor = System.Drawing.Color.White;
            this.btnApaga.Image = ((System.Drawing.Image)(resources.GetObject("btnApaga.Image")));
            this.btnApaga.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApaga.Location = new System.Drawing.Point(495, 296);
            this.btnApaga.Name = "btnApaga";
            this.btnApaga.Size = new System.Drawing.Size(119, 42);
            this.btnApaga.TabIndex = 75;
            this.btnApaga.Text = "     Apagar";
            this.btnApaga.UseVisualStyleBackColor = false;
            this.btnApaga.Click += new System.EventHandler(this.BtnApaga_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(28)))), ((int)(((byte)(78)))));
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(28)))), ((int)(((byte)(78)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(373, 296);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(115, 42);
            this.btnEdit.TabIndex = 76;
            this.btnEdit.Text = "     Editar";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnSalva
            // 
            this.btnSalva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(28)))), ((int)(((byte)(78)))));
            this.btnSalva.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalva.FlatAppearance.BorderSize = 0;
            this.btnSalva.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnSalva.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSalva.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(28)))), ((int)(((byte)(78)))));
            this.btnSalva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalva.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic);
            this.btnSalva.ForeColor = System.Drawing.Color.White;
            this.btnSalva.Image = ((System.Drawing.Image)(resources.GetObject("btnSalva.Image")));
            this.btnSalva.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalva.Location = new System.Drawing.Point(254, 296);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(113, 42);
            this.btnSalva.TabIndex = 77;
            this.btnSalva.Text = "     Salvar";
            this.btnSalva.UseVisualStyleBackColor = false;
            this.btnSalva.Click += new System.EventHandler(this.BtnSalva_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(28)))), ((int)(((byte)(78)))));
            this.btnNovo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(28)))), ((int)(((byte)(78)))));
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic);
            this.btnNovo.ForeColor = System.Drawing.Color.White;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Location = new System.Drawing.Point(138, 296);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(110, 42);
            this.btnNovo.TabIndex = 78;
            this.btnNovo.Text = "     Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(28)))), ((int)(((byte)(78)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblCaracha);
            this.panel1.Controls.Add(this.btn_fechar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 42);
            this.panel1.TabIndex = 98;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 99;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(28)))), ((int)(((byte)(78)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(780, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 316);
            this.panel2.TabIndex = 99;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(28)))), ((int)(((byte)(78)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 316);
            this.panel3.TabIndex = 100;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(28)))), ((int)(((byte)(78)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(10, 348);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(770, 10);
            this.panel4.TabIndex = 101;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(790, 358);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPesquisa_numero_tel);
            this.Controls.Add(this.btnPesquisa_numero_Nome);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefone2);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtcracha);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTelefoneAlter);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblApelido);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.cboSexo);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.btnApaga);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.btnNovo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(302, 45);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cliente";
            this.Load += new System.EventHandler(this.Cliente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisa_numero_tel;
        private System.Windows.Forms.Button btnPesquisa_numero_Nome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefone2;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtcracha;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefoneAlter;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblApelido;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.ComboBox cboSexo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnApaga;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Label lblCaracha;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}