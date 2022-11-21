namespace sistema_de_gestao_stock.Telas
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCancelaR = new System.Windows.Forms.Button();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lblPalavraPassE = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtpalavrapasse = new System.Windows.Forms.TextBox();
            this.Panel_Palavra_Passe = new System.Windows.Forms.Panel();
            this.Panel_Usuario = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Panel_Usuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(28)))), ((int)(((byte)(78)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnCancelaR);
            this.panel1.Controls.Add(this.btnEntrar);
            this.panel1.Controls.Add(this.lblPalavraPassE);
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Controls.Add(this.txtusuario);
            this.panel1.Controls.Add(this.txtpalavrapasse);
            this.panel1.Controls.Add(this.Panel_Palavra_Passe);
            this.panel1.Controls.Add(this.Panel_Usuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 513);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(159, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnCancelaR
            // 
            this.btnCancelaR.FlatAppearance.BorderSize = 0;
            this.btnCancelaR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelaR.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic);
            this.btnCancelaR.ForeColor = System.Drawing.Color.White;
            this.btnCancelaR.Location = new System.Drawing.Point(15, 333);
            this.btnCancelaR.Name = "btnCancelaR";
            this.btnCancelaR.Size = new System.Drawing.Size(367, 38);
            this.btnCancelaR.TabIndex = 4;
            this.btnCancelaR.Text = "Cancelar";
            this.btnCancelaR.UseVisualStyleBackColor = true;
            this.btnCancelaR.Click += new System.EventHandler(this.btnCancelaR_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.FlatAppearance.BorderSize = 0;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic);
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.Location = new System.Drawing.Point(15, 286);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(367, 38);
            this.btnEntrar.TabIndex = 3;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPalavraPassE
            // 
            this.lblPalavraPassE.AutoSize = true;
            this.lblPalavraPassE.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic);
            this.lblPalavraPassE.ForeColor = System.Drawing.Color.White;
            this.lblPalavraPassE.Location = new System.Drawing.Point(-1, 227);
            this.lblPalavraPassE.Name = "lblPalavraPassE";
            this.lblPalavraPassE.Size = new System.Drawing.Size(109, 22);
            this.lblPalavraPassE.TabIndex = 5;
            this.lblPalavraPassE.Text = "Palavra Passe:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic);
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(37, 164);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(71, 22);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuario:";
            this.lblUsuario.Click += new System.EventHandler(this.lblUsuario_Click);
            // 
            // txtusuario
            // 
            this.txtusuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(28)))), ((int)(((byte)(78)))));
            this.txtusuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtusuario.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic);
            this.txtusuario.ForeColor = System.Drawing.Color.White;
            this.txtusuario.Location = new System.Drawing.Point(112, 161);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(270, 22);
            this.txtusuario.TabIndex = 1;
            // 
            // txtpalavrapasse
            // 
            this.txtpalavrapasse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(28)))), ((int)(((byte)(78)))));
            this.txtpalavrapasse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpalavrapasse.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic);
            this.txtpalavrapasse.ForeColor = System.Drawing.Color.White;
            this.txtpalavrapasse.Location = new System.Drawing.Point(112, 224);
            this.txtpalavrapasse.Name = "txtpalavrapasse";
            this.txtpalavrapasse.PasswordChar = '*';
            this.txtpalavrapasse.Size = new System.Drawing.Size(270, 22);
            this.txtpalavrapasse.TabIndex = 2;
            // 
            // Panel_Palavra_Passe
            // 
            this.Panel_Palavra_Passe.BackColor = System.Drawing.Color.White;
            this.Panel_Palavra_Passe.Location = new System.Drawing.Point(112, 249);
            this.Panel_Palavra_Passe.Name = "Panel_Palavra_Passe";
            this.Panel_Palavra_Passe.Size = new System.Drawing.Size(270, 2);
            this.Panel_Palavra_Passe.TabIndex = 1;
            // 
            // Panel_Usuario
            // 
            this.Panel_Usuario.BackColor = System.Drawing.Color.White;
            this.Panel_Usuario.Controls.Add(this.panel3);
            this.Panel_Usuario.Location = new System.Drawing.Point(112, 186);
            this.Panel_Usuario.Name = "Panel_Usuario";
            this.Panel_Usuario.Size = new System.Drawing.Size(270, 2);
            this.Panel_Usuario.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(0, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(296, 2);
            this.panel3.TabIndex = 1;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(394, 513);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Panel_Usuario.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPalavraPassE;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtpalavrapasse;
        private System.Windows.Forms.Panel Panel_Palavra_Passe;
        private System.Windows.Forms.Panel Panel_Usuario;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnCancelaR;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}