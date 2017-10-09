namespace Hotel_Britania
{
    partial class FrmRecuperarSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRecuperarSenha));
            this.btnEntrar = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblEsqueceu = new System.Windows.Forms.Label();
            this.lblEMail = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.pcbKey = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbKey)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEntrar
            // 
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.Location = new System.Drawing.Point(229, 109);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(72, 23);
            this.btnEntrar.TabIndex = 15;
            this.btnEntrar.Text = "&Enviar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(159, 63);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(142, 20);
            this.txtSenha.TabIndex = 14;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(159, 36);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(142, 20);
            this.txtUsuario.TabIndex = 13;
            // 
            // lblEsqueceu
            // 
            this.lblEsqueceu.AutoSize = true;
            this.lblEsqueceu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEsqueceu.Location = new System.Drawing.Point(103, 92);
            this.lblEsqueceu.Name = "lblEsqueceu";
            this.lblEsqueceu.Size = new System.Drawing.Size(176, 13);
            this.lblEsqueceu.TabIndex = 16;
            this.lblEsqueceu.Text = "A senha será válida por duas horas.";
            // 
            // lblEMail
            // 
            this.lblEMail.AutoSize = true;
            this.lblEMail.Location = new System.Drawing.Point(107, 66);
            this.lblEMail.Name = "lblEMail";
            this.lblEMail.Size = new System.Drawing.Size(39, 13);
            this.lblEMail.TabIndex = 20;
            this.lblEMail.Text = "E-Mail:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(107, 39);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 19;
            this.lblUsuario.Text = "Usuário:";
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.Location = new System.Drawing.Point(9, 9);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(294, 13);
            this.lblBemVindo.TabIndex = 17;
            this.lblBemVindo.Text = "Sua senha temporária será enviada para o Email cadastrado.";
            // 
            // pcbKey
            // 
            this.pcbKey.Image = ((System.Drawing.Image)(resources.GetObject("pcbKey.Image")));
            this.pcbKey.Location = new System.Drawing.Point(12, 39);
            this.pcbKey.Name = "pcbKey";
            this.pcbKey.Size = new System.Drawing.Size(89, 93);
            this.pcbKey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbKey.TabIndex = 18;
            this.pcbKey.TabStop = false;
            // 
            // frmRecuperarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 147);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblEsqueceu);
            this.Controls.Add(this.lblEMail);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.pcbKey);
            this.Controls.Add(this.lblBemVindo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRecuperarSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recuperar Senha";
            ((System.ComponentModel.ISupportInitialize)(this.pcbKey)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblEsqueceu;
        private System.Windows.Forms.Label lblEMail;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.PictureBox pcbKey;
        private System.Windows.Forms.Label lblBemVindo;
    }
}