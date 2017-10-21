namespace Hotel_Britania
{
    partial class FrmCadastrarFuncionario
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastrarFuncionario));
            this.lblInformacoesPessoais = new System.Windows.Forms.Label();
            this.lblContatos = new System.Windows.Forms.Label();
            this.cboUF = new System.Windows.Forms.ComboBox();
            this.dtpDataEntrada = new System.Windows.Forms.DateTimePicker();
            this.lblDataEntrada = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblNomePesquisa = new System.Windows.Forms.Label();
            this.txtPesquisaRapida = new System.Windows.Forms.TextBox();
            this.lblNovoHospede = new System.Windows.Forms.Label();
            this.txtConfirmar = new System.Windows.Forms.TextBox();
            this.lblConfirmar = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.ckbPermitirLogin = new System.Windows.Forms.CheckBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.gpbPesquisa = new System.Windows.Forms.GroupBox();
            this.btnBuscaAvancada = new System.Windows.Forms.Button();
            this.btnBuscaRapida = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.lblCargo = new System.Windows.Forms.Label();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.mktCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.mktTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtNacionalidade = new System.Windows.Forms.TextBox();
            this.lblUF = new System.Windows.Forms.Label();
            this.lblNacionalidade = new System.Windows.Forms.Label();
            this.txtNaturalidade = new System.Windows.Forms.TextBox();
            this.lblNaturalidade = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.gpbRegistros = new System.Windows.Forms.GroupBox();
            this.pcbKey = new System.Windows.Forms.PictureBox();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.pcbFuncionario = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hotelBDDataSet = new Hotel_Britania.HotelBDDataSet();
            this.tbFuncionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbFuncionarioTableAdapter = new Hotel_Britania.HotelBDDataSetTableAdapters.tbFuncionarioTableAdapter();
            this.funIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funNomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funNaturalidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funUfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funNacionalidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funCpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funSexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funDataNascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funTelefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funEMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funDataEntradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funCargoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funSenhaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funSalarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbPesquisa.SuspendLayout();
            this.gpbRegistros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFuncionarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInformacoesPessoais
            // 
            this.lblInformacoesPessoais.AutoSize = true;
            this.lblInformacoesPessoais.Location = new System.Drawing.Point(16, 23);
            this.lblInformacoesPessoais.Name = "lblInformacoesPessoais";
            this.lblInformacoesPessoais.Size = new System.Drawing.Size(112, 13);
            this.lblInformacoesPessoais.TabIndex = 68;
            this.lblInformacoesPessoais.Text = "Informações pessoais:";
            // 
            // lblContatos
            // 
            this.lblContatos.AutoSize = true;
            this.lblContatos.Location = new System.Drawing.Point(269, 200);
            this.lblContatos.Name = "lblContatos";
            this.lblContatos.Size = new System.Drawing.Size(52, 13);
            this.lblContatos.TabIndex = 67;
            this.lblContatos.Text = "Contatos:";
            // 
            // cboUF
            // 
            this.cboUF.Enabled = false;
            this.cboUF.FormattingEnabled = true;
            this.cboUF.Items.AddRange(new object[] {
            "",
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
            this.cboUF.Location = new System.Drawing.Point(183, 200);
            this.cboUF.Name = "cboUF";
            this.cboUF.Size = new System.Drawing.Size(49, 21);
            this.cboUF.TabIndex = 6;
            // 
            // dtpDataEntrada
            // 
            this.dtpDataEntrada.CustomFormat = "dd/MM/yyyy";
            this.dtpDataEntrada.Enabled = false;
            this.dtpDataEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataEntrada.Location = new System.Drawing.Point(106, 291);
            this.dtpDataEntrada.Name = "dtpDataEntrada";
            this.dtpDataEntrada.Size = new System.Drawing.Size(126, 20);
            this.dtpDataEntrada.TabIndex = 9;
            this.dtpDataEntrada.Value = new System.DateTime(2013, 11, 2, 0, 0, 0, 0);
            // 
            // lblDataEntrada
            // 
            this.lblDataEntrada.AutoSize = true;
            this.lblDataEntrada.Location = new System.Drawing.Point(16, 295);
            this.lblDataEntrada.Name = "lblDataEntrada";
            this.lblDataEntrada.Size = new System.Drawing.Size(88, 13);
            this.lblDataEntrada.TabIndex = 66;
            this.lblDataEntrada.Text = "Data de Entrada:";
            // 
            // txtSalario
            // 
            this.txtSalario.Enabled = false;
            this.txtSalario.Location = new System.Drawing.Point(60, 261);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(172, 20);
            this.txtSalario.TabIndex = 8;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(16, 264);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(42, 13);
            this.lblSalario.TabIndex = 65;
            this.lblSalario.Text = "Salário:";
            // 
            // lblNomePesquisa
            // 
            this.lblNomePesquisa.AutoSize = true;
            this.lblNomePesquisa.Location = new System.Drawing.Point(11, 21);
            this.lblNomePesquisa.Name = "lblNomePesquisa";
            this.lblNomePesquisa.Size = new System.Drawing.Size(38, 13);
            this.lblNomePesquisa.TabIndex = 22;
            this.lblNomePesquisa.Text = "Nome:";
            // 
            // txtPesquisaRapida
            // 
            this.txtPesquisaRapida.Location = new System.Drawing.Point(11, 37);
            this.txtPesquisaRapida.Name = "txtPesquisaRapida";
            this.txtPesquisaRapida.Size = new System.Drawing.Size(153, 20);
            this.txtPesquisaRapida.TabIndex = 0;
            // 
            // lblNovoHospede
            // 
            this.lblNovoHospede.AutoSize = true;
            this.lblNovoHospede.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNovoHospede.Location = new System.Drawing.Point(10, 8);
            this.lblNovoHospede.Name = "lblNovoHospede";
            this.lblNovoHospede.Size = new System.Drawing.Size(94, 13);
            this.lblNovoHospede.TabIndex = 27;
            this.lblNovoHospede.Text = "Novo Funcionário.";
            // 
            // txtConfirmar
            // 
            this.txtConfirmar.Enabled = false;
            this.txtConfirmar.Location = new System.Drawing.Point(321, 139);
            this.txtConfirmar.MaxLength = 10;
            this.txtConfirmar.Name = "txtConfirmar";
            this.txtConfirmar.PasswordChar = '*';
            this.txtConfirmar.Size = new System.Drawing.Size(166, 20);
            this.txtConfirmar.TabIndex = 13;
            // 
            // lblConfirmar
            // 
            this.lblConfirmar.AutoSize = true;
            this.lblConfirmar.Location = new System.Drawing.Point(269, 142);
            this.lblConfirmar.Name = "lblConfirmar";
            this.lblConfirmar.Size = new System.Drawing.Size(54, 13);
            this.lblConfirmar.TabIndex = 63;
            this.lblConfirmar.Text = "Confirmar:";
            // 
            // txtSenha
            // 
            this.txtSenha.Enabled = false;
            this.txtSenha.Location = new System.Drawing.Point(321, 109);
            this.txtSenha.MaxLength = 10;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(166, 20);
            this.txtSenha.TabIndex = 12;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(269, 112);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(41, 13);
            this.lblSenha.TabIndex = 62;
            this.lblSenha.Text = "Senha:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Location = new System.Drawing.Point(321, 79);
            this.txtUsuario.MaxLength = 15;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(166, 20);
            this.txtUsuario.TabIndex = 11;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(269, 82);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 61;
            this.lblUsuario.Text = "Usuário:";
            // 
            // ckbPermitirLogin
            // 
            this.ckbPermitirLogin.AutoSize = true;
            this.ckbPermitirLogin.CausesValidation = false;
            this.ckbPermitirLogin.Enabled = false;
            this.ckbPermitirLogin.Location = new System.Drawing.Point(272, 31);
            this.ckbPermitirLogin.Name = "ckbPermitirLogin";
            this.ckbPermitirLogin.Size = new System.Drawing.Size(95, 17);
            this.ckbPermitirLogin.TabIndex = 10;
            this.ckbPermitirLogin.Text = "Permitir Login?";
            this.ckbPermitirLogin.UseVisualStyleBackColor = true;
            this.ckbPermitirLogin.CheckedChanged += new System.EventHandler(this.ckbPermitirLogin_CheckedChanged_1);
            // 
            // txtCargo
            // 
            this.txtCargo.Enabled = false;
            this.txtCargo.Location = new System.Drawing.Point(52, 231);
            this.txtCargo.MaxLength = 15;
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(180, 20);
            this.txtCargo.TabIndex = 7;
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
            this.gpbPesquisa.Controls.Add(this.lblNomePesquisa);
            this.gpbPesquisa.Controls.Add(this.txtPesquisaRapida);
            this.gpbPesquisa.Location = new System.Drawing.Point(113, 8);
            this.gpbPesquisa.Name = "gpbPesquisa";
            this.gpbPesquisa.Size = new System.Drawing.Size(388, 355);
            this.gpbPesquisa.TabIndex = 35;
            this.gpbPesquisa.TabStop = false;
            this.gpbPesquisa.Text = "Pesquisa";
            // 
            // btnBuscaAvancada
            // 
            this.btnBuscaAvancada.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaAvancada.Image")));
            this.btnBuscaAvancada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscaAvancada.Location = new System.Drawing.Point(225, 30);
            this.btnBuscaAvancada.Name = "btnBuscaAvancada";
            this.btnBuscaAvancada.Size = new System.Drawing.Size(67, 32);
            this.btnBuscaAvancada.TabIndex = 2;
            this.btnBuscaAvancada.Text = "&Buscar";
            this.btnBuscaAvancada.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscaAvancada.UseVisualStyleBackColor = true;
            // 
            // btnBuscaRapida
            // 
            this.btnBuscaRapida.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscaRapida.BackgroundImage")));
            this.btnBuscaRapida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscaRapida.Location = new System.Drawing.Point(179, 30);
            this.btnBuscaRapida.Name = "btnBuscaRapida";
            this.btnBuscaRapida.Size = new System.Drawing.Size(32, 32);
            this.btnBuscaRapida.TabIndex = 1;
            this.btnBuscaRapida.UseVisualStyleBackColor = true;
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAnterior.BackgroundImage")));
            this.btnAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAnterior.Location = new System.Drawing.Point(306, 30);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(32, 32);
            this.btnAnterior.TabIndex = 3;
            this.btnAnterior.UseVisualStyleBackColor = true;
            // 
            // btnProximo
            // 
            this.btnProximo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProximo.BackgroundImage")));
            this.btnProximo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProximo.Location = new System.Drawing.Point(339, 30);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(32, 32);
            this.btnProximo.TabIndex = 4;
            this.btnProximo.UseVisualStyleBackColor = true;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(16, 234);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(38, 13);
            this.lblCargo.TabIndex = 60;
            this.lblCargo.Text = "Cargo:";
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.CustomFormat = "dd/MM/yyyy";
            this.dtpDataNascimento.Enabled = false;
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(95, 110);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(137, 20);
            this.dtpDataNascimento.TabIndex = 2;
            this.dtpDataNascimento.Value = new System.DateTime(2013, 11, 2, 0, 0, 0, 0);
            // 
            // mktCPF
            // 
            this.mktCPF.Enabled = false;
            this.mktCPF.Location = new System.Drawing.Point(52, 80);
            this.mktCPF.Mask = "000,000,000-00";
            this.mktCPF.Name = "mktCPF";
            this.mktCPF.Size = new System.Drawing.Size(180, 20);
            this.mktCPF.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(307, 253);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(180, 20);
            this.txtEmail.TabIndex = 15;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(269, 256);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 13);
            this.lblEmail.TabIndex = 59;
            this.lblEmail.Text = "E-Mail:";
            // 
            // mktTelefone
            // 
            this.mktTelefone.Enabled = false;
            this.mktTelefone.Location = new System.Drawing.Point(348, 223);
            this.mktTelefone.Mask = "(00) 0 0000-0000";
            this.mktTelefone.Name = "mktTelefone";
            this.mktTelefone.Size = new System.Drawing.Size(139, 20);
            this.mktTelefone.TabIndex = 14;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(269, 226);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(81, 13);
            this.lblTelefone.TabIndex = 56;
            this.lblTelefone.Text = "DDD/Telefone:";
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(14, 114);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(79, 13);
            this.lblDataNascimento.TabIndex = 54;
            this.lblDataNascimento.Text = "Data de Nasc.:";
            // 
            // cboSexo
            // 
            this.cboSexo.Enabled = false;
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Items.AddRange(new object[] {
            "",
            "Masculino",
            "Feminino"});
            this.cboSexo.Location = new System.Drawing.Point(50, 200);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(99, 21);
            this.cboSexo.TabIndex = 5;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(16, 203);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(34, 13);
            this.lblSexo.TabIndex = 51;
            this.lblSexo.Text = "Sexo:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(16, 83);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(30, 13);
            this.lblCPF.TabIndex = 48;
            this.lblCPF.Text = "CPF:";
            // 
            // txtNacionalidade
            // 
            this.txtNacionalidade.Enabled = false;
            this.txtNacionalidade.Location = new System.Drawing.Point(95, 170);
            this.txtNacionalidade.MaxLength = 30;
            this.txtNacionalidade.Name = "txtNacionalidade";
            this.txtNacionalidade.Size = new System.Drawing.Size(137, 20);
            this.txtNacionalidade.TabIndex = 4;
            this.txtNacionalidade.Text = "Brasileira";
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(157, 203);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(24, 13);
            this.lblUF.TabIndex = 44;
            this.lblUF.Text = "UF:";
            // 
            // lblNacionalidade
            // 
            this.lblNacionalidade.AutoSize = true;
            this.lblNacionalidade.Location = new System.Drawing.Point(14, 173);
            this.lblNacionalidade.Name = "lblNacionalidade";
            this.lblNacionalidade.Size = new System.Drawing.Size(78, 13);
            this.lblNacionalidade.TabIndex = 42;
            this.lblNacionalidade.Text = "Nacionalidade:";
            // 
            // txtNaturalidade
            // 
            this.txtNaturalidade.Enabled = false;
            this.txtNaturalidade.Location = new System.Drawing.Point(90, 140);
            this.txtNaturalidade.MaxLength = 30;
            this.txtNaturalidade.Name = "txtNaturalidade";
            this.txtNaturalidade.Size = new System.Drawing.Size(142, 20);
            this.txtNaturalidade.TabIndex = 3;
            // 
            // lblNaturalidade
            // 
            this.lblNaturalidade.AutoSize = true;
            this.lblNaturalidade.Location = new System.Drawing.Point(14, 143);
            this.lblNaturalidade.Name = "lblNaturalidade";
            this.lblNaturalidade.Size = new System.Drawing.Size(70, 13);
            this.lblNaturalidade.TabIndex = 39;
            this.lblNaturalidade.Text = "Naturalidade:";
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(52, 50);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(180, 20);
            this.txtNome.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(16, 50);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 36;
            this.lblNome.Text = "Nome:";
            // 
            // gpbRegistros
            // 
            this.gpbRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbRegistros.Controls.Add(this.lblInformacoesPessoais);
            this.gpbRegistros.Controls.Add(this.lblContatos);
            this.gpbRegistros.Controls.Add(this.cboUF);
            this.gpbRegistros.Controls.Add(this.dtpDataEntrada);
            this.gpbRegistros.Controls.Add(this.lblDataEntrada);
            this.gpbRegistros.Controls.Add(this.txtSalario);
            this.gpbRegistros.Controls.Add(this.lblSalario);
            this.gpbRegistros.Controls.Add(this.pcbKey);
            this.gpbRegistros.Controls.Add(this.txtConfirmar);
            this.gpbRegistros.Controls.Add(this.lblConfirmar);
            this.gpbRegistros.Controls.Add(this.txtSenha);
            this.gpbRegistros.Controls.Add(this.lblSenha);
            this.gpbRegistros.Controls.Add(this.txtUsuario);
            this.gpbRegistros.Controls.Add(this.lblUsuario);
            this.gpbRegistros.Controls.Add(this.ckbPermitirLogin);
            this.gpbRegistros.Controls.Add(this.txtCargo);
            this.gpbRegistros.Controls.Add(this.lblCargo);
            this.gpbRegistros.Controls.Add(this.dtpDataNascimento);
            this.gpbRegistros.Controls.Add(this.mktCPF);
            this.gpbRegistros.Controls.Add(this.txtEmail);
            this.gpbRegistros.Controls.Add(this.lblEmail);
            this.gpbRegistros.Controls.Add(this.mktTelefone);
            this.gpbRegistros.Controls.Add(this.lblTelefone);
            this.gpbRegistros.Controls.Add(this.lblDataNascimento);
            this.gpbRegistros.Controls.Add(this.cboSexo);
            this.gpbRegistros.Controls.Add(this.lblSexo);
            this.gpbRegistros.Controls.Add(this.lblCPF);
            this.gpbRegistros.Controls.Add(this.txtNacionalidade);
            this.gpbRegistros.Controls.Add(this.lblUF);
            this.gpbRegistros.Controls.Add(this.lblNacionalidade);
            this.gpbRegistros.Controls.Add(this.txtNaturalidade);
            this.gpbRegistros.Controls.Add(this.lblNaturalidade);
            this.gpbRegistros.Controls.Add(this.txtNome);
            this.gpbRegistros.Controls.Add(this.lblNome);
            this.gpbRegistros.Location = new System.Drawing.Point(-3, 84);
            this.gpbRegistros.Name = "gpbRegistros";
            this.gpbRegistros.Size = new System.Drawing.Size(497, 333);
            this.gpbRegistros.TabIndex = 33;
            this.gpbRegistros.TabStop = false;
            this.gpbRegistros.Text = "Registros";
            // 
            // pcbKey
            // 
            this.pcbKey.Image = global::Hotel_Britania.Properties.Resources._key;
            this.pcbKey.Location = new System.Drawing.Point(442, 26);
            this.pcbKey.Name = "pcbKey";
            this.pcbKey.Size = new System.Drawing.Size(45, 47);
            this.pcbKey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbKey.TabIndex = 64;
            this.pcbKey.TabStop = false;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Image = ((System.Drawing.Image)(resources.GetObject("btnIncluir.Image")));
            this.btnIncluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncluir.Location = new System.Drawing.Point(12, 423);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(61, 23);
            this.btnIncluir.TabIndex = 28;
            this.btnIncluir.Text = "&Incluir";
            this.btnIncluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(89, 423);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(65, 23);
            this.btnSalvar.TabIndex = 29;
            this.btnSalvar.Text = "Sal&var";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(250, 423);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(62, 23);
            this.btnExcluir.TabIndex = 31;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(407, 423);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 32;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Enabled = false;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(170, 423);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(65, 23);
            this.btnAlterar.TabIndex = 30;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // pcbFuncionario
            // 
            this.pcbFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("pcbFuncionario.Image")));
            this.pcbFuncionario.Location = new System.Drawing.Point(39, 31);
            this.pcbFuncionario.Name = "pcbFuncionario";
            this.pcbFuncionario.Size = new System.Drawing.Size(32, 32);
            this.pcbFuncionario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFuncionario.TabIndex = 34;
            this.pcbFuncionario.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.funIdDataGridViewTextBoxColumn,
            this.funNomeDataGridViewTextBoxColumn,
            this.funNaturalidadeDataGridViewTextBoxColumn,
            this.funUfDataGridViewTextBoxColumn,
            this.funNacionalidadeDataGridViewTextBoxColumn,
            this.funCpfDataGridViewTextBoxColumn,
            this.funSexoDataGridViewTextBoxColumn,
            this.funDataNascimentoDataGridViewTextBoxColumn,
            this.funTelefoneDataGridViewTextBoxColumn,
            this.funEMailDataGridViewTextBoxColumn,
            this.funDataEntradaDataGridViewTextBoxColumn,
            this.funCargoDataGridViewTextBoxColumn,
            this.funUsuarioDataGridViewTextBoxColumn,
            this.funSenhaDataGridViewTextBoxColumn,
            this.funSalarioDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbFuncionarioBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 452);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(470, 232);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // hotelBDDataSet
            // 
            this.hotelBDDataSet.DataSetName = "HotelBDDataSet";
            this.hotelBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbFuncionarioBindingSource
            // 
            this.tbFuncionarioBindingSource.DataMember = "tbFuncionario";
            this.tbFuncionarioBindingSource.DataSource = this.hotelBDDataSet;
            // 
            // tbFuncionarioTableAdapter
            // 
            this.tbFuncionarioTableAdapter.ClearBeforeFill = true;
            // 
            // funIdDataGridViewTextBoxColumn
            // 
            this.funIdDataGridViewTextBoxColumn.DataPropertyName = "Fun_Id";
            this.funIdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.funIdDataGridViewTextBoxColumn.Name = "funIdDataGridViewTextBoxColumn";
            this.funIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // funNomeDataGridViewTextBoxColumn
            // 
            this.funNomeDataGridViewTextBoxColumn.DataPropertyName = "Fun_Nome";
            this.funNomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.funNomeDataGridViewTextBoxColumn.Name = "funNomeDataGridViewTextBoxColumn";
            this.funNomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // funNaturalidadeDataGridViewTextBoxColumn
            // 
            this.funNaturalidadeDataGridViewTextBoxColumn.DataPropertyName = "Fun_Naturalidade";
            this.funNaturalidadeDataGridViewTextBoxColumn.HeaderText = "Naturalidade";
            this.funNaturalidadeDataGridViewTextBoxColumn.Name = "funNaturalidadeDataGridViewTextBoxColumn";
            this.funNaturalidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // funUfDataGridViewTextBoxColumn
            // 
            this.funUfDataGridViewTextBoxColumn.DataPropertyName = "Fun_Uf";
            this.funUfDataGridViewTextBoxColumn.HeaderText = "UF";
            this.funUfDataGridViewTextBoxColumn.Name = "funUfDataGridViewTextBoxColumn";
            this.funUfDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // funNacionalidadeDataGridViewTextBoxColumn
            // 
            this.funNacionalidadeDataGridViewTextBoxColumn.DataPropertyName = "Fun_Nacionalidade";
            this.funNacionalidadeDataGridViewTextBoxColumn.HeaderText = "Nacionalidade";
            this.funNacionalidadeDataGridViewTextBoxColumn.Name = "funNacionalidadeDataGridViewTextBoxColumn";
            this.funNacionalidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // funCpfDataGridViewTextBoxColumn
            // 
            this.funCpfDataGridViewTextBoxColumn.DataPropertyName = "Fun_Cpf";
            this.funCpfDataGridViewTextBoxColumn.HeaderText = "Cpf";
            this.funCpfDataGridViewTextBoxColumn.Name = "funCpfDataGridViewTextBoxColumn";
            this.funCpfDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // funSexoDataGridViewTextBoxColumn
            // 
            this.funSexoDataGridViewTextBoxColumn.DataPropertyName = "Fun_Sexo";
            this.funSexoDataGridViewTextBoxColumn.HeaderText = "Sexo";
            this.funSexoDataGridViewTextBoxColumn.Name = "funSexoDataGridViewTextBoxColumn";
            this.funSexoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // funDataNascimentoDataGridViewTextBoxColumn
            // 
            this.funDataNascimentoDataGridViewTextBoxColumn.DataPropertyName = "Fun_DataNascimento";
            this.funDataNascimentoDataGridViewTextBoxColumn.HeaderText = "Data de Nascimento";
            this.funDataNascimentoDataGridViewTextBoxColumn.Name = "funDataNascimentoDataGridViewTextBoxColumn";
            this.funDataNascimentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // funTelefoneDataGridViewTextBoxColumn
            // 
            this.funTelefoneDataGridViewTextBoxColumn.DataPropertyName = "Fun_Telefone";
            this.funTelefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.funTelefoneDataGridViewTextBoxColumn.Name = "funTelefoneDataGridViewTextBoxColumn";
            this.funTelefoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // funEMailDataGridViewTextBoxColumn
            // 
            this.funEMailDataGridViewTextBoxColumn.DataPropertyName = "Fun_EMail";
            this.funEMailDataGridViewTextBoxColumn.HeaderText = "EMail";
            this.funEMailDataGridViewTextBoxColumn.Name = "funEMailDataGridViewTextBoxColumn";
            this.funEMailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // funDataEntradaDataGridViewTextBoxColumn
            // 
            this.funDataEntradaDataGridViewTextBoxColumn.DataPropertyName = "Fun_DataEntrada";
            this.funDataEntradaDataGridViewTextBoxColumn.HeaderText = "Data Entrada";
            this.funDataEntradaDataGridViewTextBoxColumn.Name = "funDataEntradaDataGridViewTextBoxColumn";
            this.funDataEntradaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // funCargoDataGridViewTextBoxColumn
            // 
            this.funCargoDataGridViewTextBoxColumn.DataPropertyName = "Fun_Cargo";
            this.funCargoDataGridViewTextBoxColumn.HeaderText = "Cargo";
            this.funCargoDataGridViewTextBoxColumn.Name = "funCargoDataGridViewTextBoxColumn";
            this.funCargoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // funUsuarioDataGridViewTextBoxColumn
            // 
            this.funUsuarioDataGridViewTextBoxColumn.DataPropertyName = "Fun_Usuario";
            this.funUsuarioDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.funUsuarioDataGridViewTextBoxColumn.Name = "funUsuarioDataGridViewTextBoxColumn";
            this.funUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // funSenhaDataGridViewTextBoxColumn
            // 
            this.funSenhaDataGridViewTextBoxColumn.DataPropertyName = "Fun_Senha";
            this.funSenhaDataGridViewTextBoxColumn.HeaderText = "Senha";
            this.funSenhaDataGridViewTextBoxColumn.Name = "funSenhaDataGridViewTextBoxColumn";
            this.funSenhaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // funSalarioDataGridViewTextBoxColumn
            // 
            this.funSalarioDataGridViewTextBoxColumn.DataPropertyName = "Fun_Salario";
            this.funSalarioDataGridViewTextBoxColumn.HeaderText = "Salario";
            this.funSalarioDataGridViewTextBoxColumn.Name = "funSalarioDataGridViewTextBoxColumn";
            this.funSalarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmCadastrarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 693);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblNovoHospede);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.pcbFuncionario);
            this.Controls.Add(this.gpbRegistros);
            this.Controls.Add(this.gpbPesquisa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastrarFuncionario";
            this.Text = " Cadastrar Funcionários";
            this.Load += new System.EventHandler(this.FrmCadastrarFuncionario_Load);
            this.gpbPesquisa.ResumeLayout(false);
            this.gpbPesquisa.PerformLayout();
            this.gpbRegistros.ResumeLayout(false);
            this.gpbRegistros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFuncionarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Label lblInformacoesPessoais;
        private System.Windows.Forms.Label lblContatos;
        private System.Windows.Forms.ComboBox cboUF;
        private System.Windows.Forms.DateTimePicker dtpDataEntrada;
        private System.Windows.Forms.Label lblDataEntrada;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblNomePesquisa;
        private System.Windows.Forms.TextBox txtPesquisaRapida;
        private System.Windows.Forms.Label lblNovoHospede;
        private System.Windows.Forms.PictureBox pcbKey;
        private System.Windows.Forms.TextBox txtConfirmar;
        private System.Windows.Forms.Label lblConfirmar;
        protected System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.TextBox txtSenha;
        protected System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.CheckBox ckbPermitirLogin;
        private System.Windows.Forms.TextBox txtCargo;
        protected System.Windows.Forms.Button btnSalvar;
        protected System.Windows.Forms.Button btnBuscaRapida;
        private System.Windows.Forms.GroupBox gpbPesquisa;
        protected System.Windows.Forms.Button btnBuscaAvancada;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.MaskedTextBox mktCPF;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.MaskedTextBox mktTelefone;
        private System.Windows.Forms.Label lblTelefone;
        protected System.Windows.Forms.Button btnExcluir;
        protected System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.ComboBox cboSexo;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txtNacionalidade;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.Label lblNacionalidade;
        private System.Windows.Forms.TextBox txtNaturalidade;
        private System.Windows.Forms.Label lblNaturalidade;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        protected System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.PictureBox pcbFuncionario;
        private System.Windows.Forms.GroupBox gpbRegistros;
        private System.Windows.Forms.DataGridView dataGridView1;
        private HotelBDDataSet hotelBDDataSet;
        private System.Windows.Forms.BindingSource tbFuncionarioBindingSource;
        private HotelBDDataSetTableAdapters.tbFuncionarioTableAdapter tbFuncionarioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn funIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funNomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funNaturalidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funUfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funNacionalidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funCpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funSexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funDataNascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funTelefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funEMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funDataEntradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funCargoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funSenhaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funSalarioDataGridViewTextBoxColumn;
    }
}

