namespace Hotel_Britania
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
            this.btnEntrar = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.ckbLembrarme = new System.Windows.Forms.CheckBox();
            this.lblEsqueceu = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.pcbKey = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbKey)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEntrar
            // 
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.Location = new System.Drawing.Point(226, 109);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(75, 23);
            this.btnEntrar.TabIndex = 13;
            this.btnEntrar.Text = "&Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(159, 73);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(142, 20);
            this.txtSenha.TabIndex = 7;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(159, 36);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(142, 20);
            this.txtUsuario.TabIndex = 5;
            // 
            // ckbLembrarme
            // 
            this.ckbLembrarme.AutoSize = true;
            this.ckbLembrarme.Location = new System.Drawing.Point(110, 99);
            this.ckbLembrarme.Name = "ckbLembrarme";
            this.ckbLembrarme.Size = new System.Drawing.Size(81, 17);
            this.ckbLembrarme.TabIndex = 9;
            this.ckbLembrarme.Text = "Lembrar-me";
            this.ckbLembrarme.UseVisualStyleBackColor = true;
            // 
            // lblEsqueceu
            // 
            this.lblEsqueceu.AutoSize = true;
            this.lblEsqueceu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEsqueceu.Location = new System.Drawing.Point(107, 119);
            this.lblEsqueceu.Name = "lblEsqueceu";
            this.lblEsqueceu.Size = new System.Drawing.Size(113, 13);
            this.lblEsqueceu.TabIndex = 11;
            this.lblEsqueceu.Text = "Esqueceu sua senha?";
            this.lblEsqueceu.Click += new System.EventHandler(this.lblEsqueceu_Click);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(107, 76);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(41, 13);
            this.lblSenha.TabIndex = 12;
            this.lblSenha.Text = "Senha:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(107, 39);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 10;
            this.lblUsuario.Text = "Usuário:";
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.Location = new System.Drawing.Point(9, 9);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(207, 13);
            this.lblBemVindo.TabIndex = 6;
            this.lblBemVindo.Text = "Bem Vindo ao Software Hoteleiro do IFCE.";
            // 
            // pcbKey
            // 
            this.pcbKey.Image = global::Hotel_Britania.Properties.Resources._key;
            this.pcbKey.Location = new System.Drawing.Point(12, 39);
            this.pcbKey.Name = "pcbKey";
            this.pcbKey.Size = new System.Drawing.Size(89, 93);
            this.pcbKey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbKey.TabIndex = 8;
            this.pcbKey.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 146);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.ckbLembrarme);
            this.Controls.Add(this.lblEsqueceu);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.pcbKey);
            this.Controls.Add(this.lblBemVindo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pcbKey)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.CheckBox ckbLembrarme;
        private System.Windows.Forms.Label lblEsqueceu;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.PictureBox pcbKey;
        private System.Windows.Forms.Label lblBemVindo;
    }
}