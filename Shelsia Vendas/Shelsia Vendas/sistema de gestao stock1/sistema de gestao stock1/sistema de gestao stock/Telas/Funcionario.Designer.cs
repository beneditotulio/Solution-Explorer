namespace sistema_de_gestao_stock.Telas
{
    partial class FrmFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFuncionario));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnApaga = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefone2 = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtApelido = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtNumeroBI = new System.Windows.Forms.TextBox();
            this.CboTipoDoc = new System.Windows.Forms.ComboBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefoneAlter = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblApelido = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCaracha = new System.Windows.Forms.Label();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.lblNumeroBI = new System.Windows.Forms.Label();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
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
            this.lbl_total = new System.Windows.Forms.Label();
            this.txt_filtra = new System.Windows.Forms.TextBox();
            this.rb_Sexo = new System.Windows.Forms.RadioButton();
            this.rb_Telefone = new System.Windows.Forms.RadioButton();
            this.rb_nome = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.groupBoxCarregaFoto = new System.Windows.Forms.GroupBox();
            this.btnBuscarFoto = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtNumeroDoc = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_funcionario)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.btnApaga.Location = new System.Drawing.Point(620, 15);
            this.btnApaga.Name = "btnApaga";
            this.btnApaga.Size = new System.Drawing.Size(119, 42);
            this.btnApaga.TabIndex = 21;
            this.btnApaga.Text = "      Apagar";
            this.btnApaga.UseVisualStyleBackColor = false;
            this.btnApaga.Click += new System.EventHandler(this.BtnApaga_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic);
            this.txtEmail.Location = new System.Drawing.Point(171, 279);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(403, 29);
            this.txtEmail.TabIndex = 44;
            // 
            // txtTelefone2
            // 
            this.txtTelefone2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic);
            this.txtTelefone2.Location = new System.Drawing.Point(171, 247);
            this.txtTelefone2.Name = "txtTelefone2";
            this.txtTelefone2.Size = new System.Drawing.Size(172, 29);
            this.txtTelefone2.TabIndex = 43;
            this.txtTelefone2.TextChanged += new System.EventHandler(this.txtTelefone2_TextChanged);
            this.txtTelefone2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefone2_KeyPress);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic);
            this.txtTelefone.Location = new System.Drawing.Point(171, 215);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(172, 29);
            this.txtTelefone.TabIndex = 42;
            this.txtTelefone.TextChanged += new System.EventHandler(this.txtTelefone_TextChanged);
            this.txtTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefone_KeyPress);
            // 
            // txtApelido
            // 
            this.txtApelido.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic);
            this.txtApelido.Location = new System.Drawing.Point(171, 150);
            this.txtApelido.Name = "txtApelido";
            this.txtApelido.Size = new System.Drawing.Size(172, 29);
            this.txtApelido.TabIndex = 41;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic);
            this.txtNome.Location = new System.Drawing.Point(171, 118);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(374, 29);
            this.txtNome.TabIndex = 40;
            // 
            // txtNumeroBI
            // 
            this.txtNumeroBI.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic);
            this.txtNumeroBI.Location = new System.Drawing.Point(753, 22);
            this.txtNumeroBI.Name = "txtNumeroBI";
            this.txtNumeroBI.Size = new System.Drawing.Size(172, 29);
            this.txtNumeroBI.TabIndex = 38;
            this.txtNumeroBI.TextChanged += new System.EventHandler(this.txtNumeroBI_TextChanged);
            // 
            // CboTipoDoc
            // 
            this.CboTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboTipoDoc.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic);
            this.CboTipoDoc.FormattingEnabled = true;
            this.CboTipoDoc.Location = new System.Drawing.Point(478, 85);
            this.CboTipoDoc.Name = "CboTipoDoc";
            this.CboTipoDoc.Size = new System.Drawing.Size(248, 30);
            this.CboTipoDoc.TabIndex = 37;
            this.CboTipoDoc.SelectedIndexChanged += new System.EventHandler(this.CboTipoDoc_SelectedIndexChanged);
            this.CboTipoDoc.TextChanged += new System.EventHandler(this.CboTipoDoc_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic);
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(111, 282);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(57, 22);
            this.lblEmail.TabIndex = 36;
            this.lblEmail.Text = "Email:";
            // 
            // lblTelefoneAlter
            // 
            this.lblTelefoneAlter.AutoSize = true;
            this.lblTelefoneAlter.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic);
            this.lblTelefoneAlter.ForeColor = System.Drawing.Color.Black;
            this.lblTelefoneAlter.Location = new System.Drawing.Point(11, 249);
            this.lblTelefoneAlter.Name = "lblTelefoneAlter";
            this.lblTelefoneAlter.Size = new System.Drawing.Size(157, 22);
            this.lblTelefoneAlter.TabIndex = 35;
            this.lblTelefoneAlter.Text = "Telefone Alternativo:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic);
            this.lblTelefone.ForeColor = System.Drawing.Color.Black;
            this.lblTelefone.Location = new System.Drawing.Point(95, 218);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(73, 22);
            this.lblTelefone.TabIndex = 34;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic);
            this.lblSexo.ForeColor = System.Drawing.Color.Black;
            this.lblSexo.Location = new System.Drawing.Point(120, 185);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(48, 22);
            this.lblSexo.TabIndex = 33;
            this.lblSexo.Text = "Sexo:";
            // 
            // lblApelido
            // 
            this.lblApelido.AutoSize = true;
            this.lblApelido.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic);
            this.lblApelido.ForeColor = System.Drawing.Color.Black;
            this.lblApelido.Location = new System.Drawing.Point(100, 153);
            this.lblApelido.Name = "lblApelido";
            this.lblApelido.Size = new System.Drawing.Size(68, 22);
            this.lblApelido.TabIndex = 32;
            this.lblApelido.Text = "Apelido:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic);
            this.lblNome.ForeColor = System.Drawing.Color.Black;
            this.lblNome.Location = new System.Drawing.Point(113, 121);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(55, 22);
            this.lblNome.TabIndex = 31;
            this.lblNome.Text = "Nome:";
            // 
            // lblCaracha
            // 
            this.lblCaracha.AutoSize = true;
            this.lblCaracha.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaracha.ForeColor = System.Drawing.Color.White;
            this.lblCaracha.Location = new System.Drawing.Point(45, 11);
            this.lblCaracha.Name = "lblCaracha";
            this.lblCaracha.Size = new System.Drawing.Size(107, 25);
            this.lblCaracha.TabIndex = 30;
            this.lblCaracha.Text = " Funcionário";
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic);
            this.lblTipoDoc.ForeColor = System.Drawing.Color.Black;
            this.lblTipoDoc.Location = new System.Drawing.Point(346, 88);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(129, 22);
            this.lblTipoDoc.TabIndex = 29;
            this.lblTipoDoc.Text = "Tipo Documento:";
            // 
            // lblNumeroBI
            // 
            this.lblNumeroBI.AutoSize = true;
            this.lblNumeroBI.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic);
            this.lblNumeroBI.ForeColor = System.Drawing.Color.Black;
            this.lblNumeroBI.Location = new System.Drawing.Point(98, 88);
            this.lblNumeroBI.Name = "lblNumeroBI";
            this.lblNumeroBI.Size = new System.Drawing.Size(70, 22);
            this.lblNumeroBI.TabIndex = 28;
            this.lblNumeroBI.Text = "Número:";
            // 
            // cboSexo
            // 
            this.cboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSexo.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic);
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Location = new System.Drawing.Point(171, 182);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(172, 30);
            this.cboSexo.TabIndex = 27;
            this.cboSexo.SelectedIndexChanged += new System.EventHandler(this.cboSexo_SelectedIndexChanged);
            this.cboSexo.TextChanged += new System.EventHandler(this.cboSexo_TextChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic);
            this.txtCodigo.Location = new System.Drawing.Point(171, 53);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(53, 29);
            this.txtCodigo.TabIndex = 26;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic);
            this.lblCodigo.ForeColor = System.Drawing.Color.Black;
            this.lblCodigo.Location = new System.Drawing.Point(106, 56);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(62, 22);
            this.lblCodigo.TabIndex = 25;
            this.lblCodigo.Text = "Codigo:";
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
            this.btn_fechar.Location = new System.Drawing.Point(921, 4);
            this.btn_fechar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(38, 35);
            this.btn_fechar.TabIndex = 46;
            this.btn_fechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_fechar.UseVisualStyleBackColor = false;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
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
            this.btnEdit.Location = new System.Drawing.Point(499, 15);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(115, 42);
            this.btnEdit.TabIndex = 22;
            this.btnEdit.Text = "      Editar";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
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
            this.btnSalva.Location = new System.Drawing.Point(380, 15);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(113, 42);
            this.btnSalva.TabIndex = 23;
            this.btnSalva.Text = "      Salvar";
            this.btnSalva.UseVisualStyleBackColor = false;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
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
            this.btnNovo.Location = new System.Drawing.Point(264, 15);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(110, 42);
            this.btnNovo.TabIndex = 24;
            this.btnNovo.Text = "     Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // dgv_funcionario
            // 
            this.dgv_funcionario.AllowUserToAddRows = false;
            this.dgv_funcionario.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Maroon;
            this.dgv_funcionario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_funcionario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_funcionario.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_funcionario.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_funcionario.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgv_funcionario.Location = new System.Drawing.Point(-95, 205);
            this.dgv_funcionario.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_funcionario.Name = "dgv_funcionario";
            this.dgv_funcionario.ReadOnly = true;
            this.dgv_funcionario.RowHeadersWidth = 51;
            this.dgv_funcionario.RowTemplate.Height = 24;
            this.dgv_funcionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_funcionario.Size = new System.Drawing.Size(52, 23);
            this.dgv_funcionario.TabIndex = 127;
            this.dgv_funcionario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_funcionario_CellContentClick);
            this.dgv_funcionario.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_funcionario_CellContentDoubleClick);
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
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic);
            this.lbl_total.ForeColor = System.Drawing.Color.Black;
            this.lbl_total.Location = new System.Drawing.Point(995, 24);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(18, 22);
            this.lbl_total.TabIndex = 129;
            this.lbl_total.Text = "0";
            // 
            // txt_filtra
            // 
            this.txt_filtra.BackColor = System.Drawing.Color.White;
            this.txt_filtra.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic);
            this.txt_filtra.ForeColor = System.Drawing.Color.Black;
            this.txt_filtra.Location = new System.Drawing.Point(454, 20);
            this.txt_filtra.Name = "txt_filtra";
            this.txt_filtra.Size = new System.Drawing.Size(368, 29);
            this.txt_filtra.TabIndex = 129;
            this.txt_filtra.TextChanged += new System.EventHandler(this.Txt_filtra_TextChanged);
            // 
            // rb_Sexo
            // 
            this.rb_Sexo.AutoSize = true;
            this.rb_Sexo.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic);
            this.rb_Sexo.Location = new System.Drawing.Point(374, 19);
            this.rb_Sexo.Margin = new System.Windows.Forms.Padding(2);
            this.rb_Sexo.Name = "rb_Sexo";
            this.rb_Sexo.Size = new System.Drawing.Size(61, 26);
            this.rb_Sexo.TabIndex = 2;
            this.rb_Sexo.TabStop = true;
            this.rb_Sexo.Text = "Sexo";
            this.rb_Sexo.UseVisualStyleBackColor = true;
            this.rb_Sexo.Click += new System.EventHandler(this.Rb_Sexo_Click);
            // 
            // rb_Telefone
            // 
            this.rb_Telefone.AutoSize = true;
            this.rb_Telefone.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic);
            this.rb_Telefone.Location = new System.Drawing.Point(218, 19);
            this.rb_Telefone.Margin = new System.Windows.Forms.Padding(2);
            this.rb_Telefone.Name = "rb_Telefone";
            this.rb_Telefone.Size = new System.Drawing.Size(86, 26);
            this.rb_Telefone.TabIndex = 1;
            this.rb_Telefone.TabStop = true;
            this.rb_Telefone.Text = "Telefone";
            this.rb_Telefone.UseVisualStyleBackColor = true;
            this.rb_Telefone.Click += new System.EventHandler(this.Rb_Telefone_Click);
            // 
            // rb_nome
            // 
            this.rb_nome.AutoSize = true;
            this.rb_nome.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic);
            this.rb_nome.Location = new System.Drawing.Point(89, 19);
            this.rb_nome.Margin = new System.Windows.Forms.Padding(2);
            this.rb_nome.Name = "rb_nome";
            this.rb_nome.Size = new System.Drawing.Size(68, 26);
            this.rb_nome.TabIndex = 0;
            this.rb_nome.TabStop = true;
            this.rb_nome.Text = "Nome";
            this.rb_nome.UseVisualStyleBackColor = true;
            this.rb_nome.CheckedChanged += new System.EventHandler(this.Rb_nome_CheckedChanged);
            this.rb_nome.Click += new System.EventHandler(this.Rb_nome_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(28)))), ((int)(((byte)(78)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(730, 84);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(44, 31);
            this.button3.TabIndex = 129;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(28)))), ((int)(((byte)(78)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lblCaracha);
            this.panel2.Controls.Add(this.btn_fechar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(963, 48);
            this.panel2.TabIndex = 130;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Controls.Add(this.lbl_total);
            this.groupBox1.Controls.Add(this.rb_nome);
            this.groupBox1.Controls.Add(this.txt_filtra);
            this.groupBox1.Controls.Add(this.rb_Telefone);
            this.groupBox1.Controls.Add(this.rb_Sexo);
            this.groupBox1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(104, 327);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(52, 24);
            this.groupBox1.TabIndex = 131;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar Por:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(948, 27);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(41, 18);
            this.lblTotal.TabIndex = 130;
            this.lblTotal.Text = "Total:";
            // 
            // groupBoxCarregaFoto
            // 
            this.groupBoxCarregaFoto.Location = new System.Drawing.Point(791, 62);
            this.groupBoxCarregaFoto.Name = "groupBoxCarregaFoto";
            this.groupBoxCarregaFoto.Size = new System.Drawing.Size(146, 127);
            this.groupBoxCarregaFoto.TabIndex = 132;
            this.groupBoxCarregaFoto.TabStop = false;
            // 
            // btnBuscarFoto
            // 
            this.btnBuscarFoto.FlatAppearance.BorderSize = 0;
            this.btnBuscarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarFoto.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic);
            this.btnBuscarFoto.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarFoto.Image")));
            this.btnBuscarFoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarFoto.Location = new System.Drawing.Point(806, 190);
            this.btnBuscarFoto.Name = "btnBuscarFoto";
            this.btnBuscarFoto.Size = new System.Drawing.Size(131, 33);
            this.btnBuscarFoto.TabIndex = 133;
            this.btnBuscarFoto.Text = "   Imagem";
            this.btnBuscarFoto.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.btnApaga);
            this.panel1.Controls.Add(this.btnNovo);
            this.panel1.Controls.Add(this.btnSalva);
            this.panel1.Controls.Add(this.txtNumeroBI);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Location = new System.Drawing.Point(12, 314);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 68);
            this.panel1.TabIndex = 134;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(28)))), ((int)(((byte)(78)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(953, 48);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 343);
            this.panel3.TabIndex = 136;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(28)))), ((int)(((byte)(78)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 48);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 343);
            this.panel4.TabIndex = 137;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(28)))), ((int)(((byte)(78)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(10, 381);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(943, 10);
            this.panel5.TabIndex = 138;
            // 
            // txtNumeroDoc
            // 
            this.txtNumeroDoc.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic);
            this.txtNumeroDoc.Location = new System.Drawing.Point(171, 85);
            this.txtNumeroDoc.Name = "txtNumeroDoc";
            this.txtNumeroDoc.Size = new System.Drawing.Size(172, 29);
            this.txtNumeroDoc.TabIndex = 139;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(745, 15);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(180, 43);
            this.panel6.TabIndex = 39;
            // 
            // FrmFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(963, 391);
            this.Controls.Add(this.txtNumeroDoc);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.CboTipoDoc);
            this.Controls.Add(this.lblTipoDoc);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBuscarFoto);
            this.Controls.Add(this.groupBoxCarregaFoto);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dgv_funcionario);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefone2);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtApelido);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTelefoneAlter);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblApelido);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblNumeroBI);
            this.Controls.Add(this.cboSexo);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(302, 45);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionario";
            this.Load += new System.EventHandler(this.frm_Funcionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_funcionario)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnApaga;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefone2;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtApelido;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtNumeroBI;
        private System.Windows.Forms.ComboBox CboTipoDoc;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefoneAlter;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblApelido;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCaracha;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.Label lblNumeroBI;
        private System.Windows.Forms.ComboBox cboSexo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.DataGridView dgv_funcionario;
        private System.Windows.Forms.TextBox txt_filtra;
        private System.Windows.Forms.RadioButton rb_Sexo;
        private System.Windows.Forms.RadioButton rb_Telefone;
        private System.Windows.Forms.RadioButton rb_nome;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn orden;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox groupBoxCarregaFoto;
        private System.Windows.Forms.Button btnBuscarFoto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtNumeroDoc;
        private System.Windows.Forms.Panel panel6;
        //private System.Windows.Forms.Button btn_doc;
    }
}