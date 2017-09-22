namespace Hotel_Britania
{
    partial class FrmCadastrarHospede
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastrarHospede));
            this.btnIncluir = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.lblContatos = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.cboUF = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.btnProximo = new System.Windows.Forms.Button();
            this.lblNomeP = new System.Windows.Forms.Label();
            this.txtPesquisaRapida = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNaturalidade = new System.Windows.Forms.Label();
            this.mktTelefone = new System.Windows.Forms.MaskedTextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.mktCPF = new System.Windows.Forms.MaskedTextBox();
            this.btnBuscaRapida = new System.Windows.Forms.Button();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtNaturalidade = new System.Windows.Forms.TextBox();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.lblNovoHospede = new System.Windows.Forms.Label();
            this.pcbHospede = new System.Windows.Forms.PictureBox();
            this.gpbPesquisa = new System.Windows.Forms.GroupBox();
            this.btnBuscaAvancada = new System.Windows.Forms.Button();
            this.txtNacionalidade = new System.Windows.Forms.TextBox();
            this.lblNacionalidade = new System.Windows.Forms.Label();
            this.lblUF = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.gpbRegistros = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pcbHospede)).BeginInit();
            this.gpbPesquisa.SuspendLayout();
            this.gpbRegistros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIncluir
            // 
            this.btnIncluir.Image = ((System.Drawing.Image)(resources.GetObject("btnIncluir.Image")));
            this.btnIncluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncluir.Location = new System.Drawing.Point(12, 268);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(61, 23);
            this.btnIncluir.TabIndex = 17;
            this.btnIncluir.Text = "&Incluir";
            this.btnIncluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIncluir.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 13);
            this.label11.TabIndex = 39;
            this.label11.Text = "Informações pessoais:";
            // 
            // lblContatos
            // 
            this.lblContatos.AutoSize = true;
            this.lblContatos.Location = new System.Drawing.Point(272, 90);
            this.lblContatos.Name = "lblContatos";
            this.lblContatos.Size = new System.Drawing.Size(52, 13);
            this.lblContatos.TabIndex = 38;
            this.lblContatos.Text = "Contatos:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(13, 53);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // cboUF
            // 
            this.cboUF.Enabled = false;
            this.cboUF.FormattingEnabled = true;
            this.cboUF.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cboUF.Location = new System.Drawing.Point(437, 52);
            this.cboUF.Name = "cboUF";
            this.cboUF.Size = new System.Drawing.Size(49, 21);
            this.cboUF.TabIndex = 6;
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(51, 50);
            this.txtNome.MaxLength = 30;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(176, 20);
            this.txtNome.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(313, 141);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(175, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.CustomFormat = "dd/MM/yyyy";
            this.dtpDataNascimento.Enabled = false;
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(91, 111);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(137, 20);
            this.dtpDataNascimento.TabIndex = 2;
            this.dtpDataNascimento.Value = new System.DateTime(2013, 11, 2, 0, 0, 0, 0);
            // 
            // btnProximo
            // 
            this.btnProximo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProximo.BackgroundImage")));
            this.btnProximo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProximo.Location = new System.Drawing.Point(340, 29);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(32, 32);
            this.btnProximo.TabIndex = 4;
            this.btnProximo.UseVisualStyleBackColor = true;
            // 
            // lblNomeP
            // 
            this.lblNomeP.AutoSize = true;
            this.lblNomeP.Location = new System.Drawing.Point(12, 20);
            this.lblNomeP.Name = "lblNomeP";
            this.lblNomeP.Size = new System.Drawing.Size(38, 13);
            this.lblNomeP.TabIndex = 7;
            this.lblNomeP.Text = "Nome:";
            // 
            // txtPesquisaRapida
            // 
            this.txtPesquisaRapida.Location = new System.Drawing.Point(12, 36);
            this.txtPesquisaRapida.Name = "txtPesquisaRapida";
            this.txtPesquisaRapida.Size = new System.Drawing.Size(153, 20);
            this.txtPesquisaRapida.TabIndex = 0;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(272, 144);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 13);
            this.lblEmail.TabIndex = 17;
            this.lblEmail.Text = "E-Mail:";
            // 
            // lblNaturalidade
            // 
            this.lblNaturalidade.AutoSize = true;
            this.lblNaturalidade.Location = new System.Drawing.Point(12, 144);
            this.lblNaturalidade.Name = "lblNaturalidade";
            this.lblNaturalidade.Size = new System.Drawing.Size(70, 13);
            this.lblNaturalidade.TabIndex = 2;
            this.lblNaturalidade.Text = "Naturalidade:";
            // 
            // mktTelefone
            // 
            this.mktTelefone.Enabled = false;
            this.mktTelefone.Location = new System.Drawing.Point(359, 115);
            this.mktTelefone.Mask = "(00) 0 0000-0000";
            this.mktTelefone.Name = "mktTelefone";
            this.mktTelefone.Size = new System.Drawing.Size(129, 20);
            this.mktTelefone.TabIndex = 7;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(89, 268);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(65, 23);
            this.btnSalvar.TabIndex = 18;
            this.btnSalvar.Text = "Sal&var";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // mktCPF
            // 
            this.mktCPF.Enabled = false;
            this.mktCPF.Location = new System.Drawing.Point(47, 81);
            this.mktCPF.Mask = "000,000,000-00";
            this.mktCPF.Name = "mktCPF";
            this.mktCPF.Size = new System.Drawing.Size(181, 20);
            this.mktCPF.TabIndex = 1;
            // 
            // btnBuscaRapida
            // 
            this.btnBuscaRapida.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscaRapida.BackgroundImage")));
            this.btnBuscaRapida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscaRapida.Location = new System.Drawing.Point(180, 29);
            this.btnBuscaRapida.Name = "btnBuscaRapida";
            this.btnBuscaRapida.Size = new System.Drawing.Size(32, 32);
            this.btnBuscaRapida.TabIndex = 1;
            this.btnBuscaRapida.UseVisualStyleBackColor = true;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(272, 118);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(81, 13);
            this.lblTelefone.TabIndex = 14;
            this.lblTelefone.Text = "DDD/Telefone:";
            // 
            // txtNaturalidade
            // 
            this.txtNaturalidade.Enabled = false;
            this.txtNaturalidade.Location = new System.Drawing.Point(88, 141);
            this.txtNaturalidade.MaxLength = 30;
            this.txtNaturalidade.Name = "txtNaturalidade";
            this.txtNaturalidade.Size = new System.Drawing.Size(140, 20);
            this.txtNaturalidade.TabIndex = 3;
            this.txtNaturalidade.Text = "Aracati";
            // 
            // cboSexo
            // 
            this.cboSexo.Enabled = false;
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cboSexo.Location = new System.Drawing.Point(306, 52);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(99, 21);
            this.cboSexo.TabIndex = 5;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(13, 84);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(30, 13);
            this.lblCPF.TabIndex = 8;
            this.lblCPF.Text = "CPF:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(272, 55);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(34, 13);
            this.lblSexo.TabIndex = 10;
            this.lblSexo.Text = "Sexo:";
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAnterior.BackgroundImage")));
            this.btnAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAnterior.Location = new System.Drawing.Point(307, 29);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(32, 32);
            this.btnAnterior.TabIndex = 3;
            this.btnAnterior.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(250, 268);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(62, 23);
            this.btnExcluir.TabIndex = 20;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(410, 268);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(12, 115);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(79, 13);
            this.lblDataNascimento.TabIndex = 12;
            this.lblDataNascimento.Text = "Data de Nasc.:";
            // 
            // lblNovoHospede
            // 
            this.lblNovoHospede.AutoSize = true;
            this.lblNovoHospede.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNovoHospede.Location = new System.Drawing.Point(17, 9);
            this.lblNovoHospede.Name = "lblNovoHospede";
            this.lblNovoHospede.Size = new System.Drawing.Size(82, 13);
            this.lblNovoHospede.TabIndex = 16;
            this.lblNovoHospede.Text = "Novo Hóspede.";
            // 
            // pcbHospede
            // 
            this.pcbHospede.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbHospede.Image = ((System.Drawing.Image)(resources.GetObject("pcbHospede.Image")));
            this.pcbHospede.Location = new System.Drawing.Point(41, 31);
            this.pcbHospede.Name = "pcbHospede";
            this.pcbHospede.Size = new System.Drawing.Size(32, 32);
            this.pcbHospede.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbHospede.TabIndex = 23;
            this.pcbHospede.TabStop = false;
            // 
            // gpbPesquisa
            // 
            this.gpbPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbPesquisa.Controls.Add(this.btnBuscaAvancada);
            this.gpbPesquisa.Controls.Add(this.btnBuscaRapida);
            this.gpbPesquisa.Controls.Add(this.btnAnterior);
            this.gpbPesquisa.Controls.Add(this.btnProximo);
            this.gpbPesquisa.Controls.Add(this.lblNomeP);
            this.gpbPesquisa.Controls.Add(this.txtPesquisaRapida);
            this.gpbPesquisa.Location = new System.Drawing.Point(115, 8);
            this.gpbPesquisa.Name = "gpbPesquisa";
            this.gpbPesquisa.Size = new System.Drawing.Size(390, 254);
            this.gpbPesquisa.TabIndex = 24;
            this.gpbPesquisa.TabStop = false;
            this.gpbPesquisa.Text = "Pesquisar";
            // 
            // btnBuscaAvancada
            // 
            this.btnBuscaAvancada.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaAvancada.Image")));
            this.btnBuscaAvancada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscaAvancada.Location = new System.Drawing.Point(226, 29);
            this.btnBuscaAvancada.Name = "btnBuscaAvancada";
            this.btnBuscaAvancada.Size = new System.Drawing.Size(67, 32);
            this.btnBuscaAvancada.TabIndex = 2;
            this.btnBuscaAvancada.Text = "&Buscar";
            this.btnBuscaAvancada.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscaAvancada.UseVisualStyleBackColor = true;
            // 
            // txtNacionalidade
            // 
            this.txtNacionalidade.Enabled = false;
            this.txtNacionalidade.Location = new System.Drawing.Point(350, 24);
            this.txtNacionalidade.MaxLength = 30;
            this.txtNacionalidade.Name = "txtNacionalidade";
            this.txtNacionalidade.Size = new System.Drawing.Size(137, 20);
            this.txtNacionalidade.TabIndex = 4;
            this.txtNacionalidade.Text = "Brasileiro";
            // 
            // lblNacionalidade
            // 
            this.lblNacionalidade.AutoSize = true;
            this.lblNacionalidade.Location = new System.Drawing.Point(271, 27);
            this.lblNacionalidade.Name = "lblNacionalidade";
            this.lblNacionalidade.Size = new System.Drawing.Size(78, 13);
            this.lblNacionalidade.TabIndex = 4;
            this.lblNacionalidade.Text = "Nacionalidade:";
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(411, 55);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(24, 13);
            this.lblUF.TabIndex = 5;
            this.lblUF.Text = "UF:";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Enabled = false;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(170, 268);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(65, 23);
            this.btnAlterar.TabIndex = 19;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // gpbRegistros
            // 
            this.gpbRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbRegistros.Controls.Add(this.label11);
            this.gpbRegistros.Controls.Add(this.lblContatos);
            this.gpbRegistros.Controls.Add(this.lblNome);
            this.gpbRegistros.Controls.Add(this.cboUF);
            this.gpbRegistros.Controls.Add(this.txtNome);
            this.gpbRegistros.Controls.Add(this.txtEmail);
            this.gpbRegistros.Controls.Add(this.dtpDataNascimento);
            this.gpbRegistros.Controls.Add(this.lblEmail);
            this.gpbRegistros.Controls.Add(this.lblNaturalidade);
            this.gpbRegistros.Controls.Add(this.mktTelefone);
            this.gpbRegistros.Controls.Add(this.mktCPF);
            this.gpbRegistros.Controls.Add(this.lblTelefone);
            this.gpbRegistros.Controls.Add(this.txtNaturalidade);
            this.gpbRegistros.Controls.Add(this.cboSexo);
            this.gpbRegistros.Controls.Add(this.lblCPF);
            this.gpbRegistros.Controls.Add(this.lblSexo);
            this.gpbRegistros.Controls.Add(this.lblDataNascimento);
            this.gpbRegistros.Controls.Add(this.txtNacionalidade);
            this.gpbRegistros.Controls.Add(this.lblNacionalidade);
            this.gpbRegistros.Controls.Add(this.lblUF);
            this.gpbRegistros.Location = new System.Drawing.Point(-1, 84);
            this.gpbRegistros.Name = "gpbRegistros";
            this.gpbRegistros.Size = new System.Drawing.Size(499, 178);
            this.gpbRegistros.TabIndex = 22;
            this.gpbRegistros.TabStop = false;
            this.gpbRegistros.Text = "Registros";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 297);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(474, 232);
            this.dataGridView1.TabIndex = 25;
            // 
            // frmCadastrarHospede
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 541);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblNovoHospede);
            this.Controls.Add(this.pcbHospede);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.gpbRegistros);
            this.Controls.Add(this.gpbPesquisa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastrarHospede";
            this.Text = "Cadastrar Hóspede";
            ((System.ComponentModel.ISupportInitialize)(this.pcbHospede)).EndInit();
            this.gpbPesquisa.ResumeLayout(false);
            this.gpbPesquisa.PerformLayout();
            this.gpbRegistros.ResumeLayout(false);
            this.gpbRegistros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblContatos;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.ComboBox cboUF;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        protected System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Label lblNomeP;
        private System.Windows.Forms.TextBox txtPesquisaRapida;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNaturalidade;
        private System.Windows.Forms.MaskedTextBox mktTelefone;
        protected System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.MaskedTextBox mktCPF;
        protected System.Windows.Forms.Button btnBuscaRapida;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtNaturalidade;
        private System.Windows.Forms.ComboBox cboSexo;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblSexo;
        protected System.Windows.Forms.Button btnAnterior;
        protected System.Windows.Forms.Button btnExcluir;
        protected System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.Label lblNovoHospede;
        private System.Windows.Forms.PictureBox pcbHospede;
        private System.Windows.Forms.GroupBox gpbPesquisa;
        protected System.Windows.Forms.Button btnBuscaAvancada;
        private System.Windows.Forms.TextBox txtNacionalidade;
        private System.Windows.Forms.Label lblNacionalidade;
        private System.Windows.Forms.Label lblUF;
        protected System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.GroupBox gpbRegistros;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}