﻿namespace Hotel_Britania
{
    partial class FrmCadastrarUnidadeHabitacional
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastrarUnidadeHabitacional));
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumeroUni = new System.Windows.Forms.Label();
            this.gpbPesquisa = new System.Windows.Forms.GroupBox();
            this.btnBuscaAvancada = new System.Windows.Forms.Button();
            this.btnBuscaRapida = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.lblNomeUniP = new System.Windows.Forms.Label();
            this.txtPesquisaRapida = new System.Windows.Forms.TextBox();
            this.txtValorDiaria = new System.Windows.Forms.TextBox();
            this.lblValorDiaria = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.gpbCaracteristiacas = new System.Windows.Forms.GroupBox();
            this.ckbDuasCamas = new System.Windows.Forms.CheckBox();
            this.ckbFrigobar = new System.Windows.Forms.CheckBox();
            this.ckbClimatizador = new System.Windows.Forms.CheckBox();
            this.ckbWireless = new System.Windows.Forms.CheckBox();
            this.ckbSuiteSingle = new System.Windows.Forms.CheckBox();
            this.ckbSuiteMaried = new System.Windows.Forms.CheckBox();
            this.lblNovaUnidade = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNomeUni = new System.Windows.Forms.Label();
            this.gpbRegistros = new System.Windows.Forms.GroupBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pcbUnidade = new System.Windows.Forms.PictureBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hotelBDDataSet = new Hotel_Britania.HotelBDDataSet();
            this.tbUnidadeHabitacionalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbUnidadeHabitacionalTableAdapter = new Hotel_Britania.HotelBDDataSetTableAdapters.tbUnidadeHabitacionalTableAdapter();
            this.uniIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uniNomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uniNumeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uniValorDiariaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uniDescricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uniSuiteMariedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.uniSuiteSingleDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.uniDuasCamasDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.uniClimatizadorDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.uniFrigobarDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.uniWirelessDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gpbPesquisa.SuspendLayout();
            this.gpbCaracteristiacas.SuspendLayout();
            this.gpbRegistros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUnidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUnidadeHabitacionalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNumero
            // 
            this.txtNumero.Enabled = false;
            this.txtNumero.Location = new System.Drawing.Point(198, 22);
            this.txtNumero.MaxLength = 6;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(56, 20);
            this.txtNumero.TabIndex = 1;
            // 
            // lblNumeroUni
            // 
            this.lblNumeroUni.AutoSize = true;
            this.lblNumeroUni.Location = new System.Drawing.Point(154, 25);
            this.lblNumeroUni.Name = "lblNumeroUni";
            this.lblNumeroUni.Size = new System.Drawing.Size(47, 13);
            this.lblNumeroUni.TabIndex = 16;
            this.lblNumeroUni.Text = "Número:";
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
            this.gpbPesquisa.Controls.Add(this.lblNomeUniP);
            this.gpbPesquisa.Controls.Add(this.txtPesquisaRapida);
            this.gpbPesquisa.Location = new System.Drawing.Point(115, 8);
            this.gpbPesquisa.Name = "gpbPesquisa";
            this.gpbPesquisa.Size = new System.Drawing.Size(388, 244);
            this.gpbPesquisa.TabIndex = 40;
            this.gpbPesquisa.TabStop = false;
            this.gpbPesquisa.Text = "Pesquisa";
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
            // lblNomeUniP
            // 
            this.lblNomeUniP.AutoSize = true;
            this.lblNomeUniP.Location = new System.Drawing.Point(9, 20);
            this.lblNomeUniP.Name = "lblNomeUniP";
            this.lblNomeUniP.Size = new System.Drawing.Size(96, 13);
            this.lblNomeUniP.TabIndex = 28;
            this.lblNomeUniP.Text = "Nome da Unidade:";
            // 
            // txtPesquisaRapida
            // 
            this.txtPesquisaRapida.Location = new System.Drawing.Point(12, 36);
            this.txtPesquisaRapida.Name = "txtPesquisaRapida";
            this.txtPesquisaRapida.Size = new System.Drawing.Size(153, 20);
            this.txtPesquisaRapida.TabIndex = 0;
            // 
            // txtValorDiaria
            // 
            this.txtValorDiaria.Enabled = false;
            this.txtValorDiaria.Location = new System.Drawing.Point(89, 48);
            this.txtValorDiaria.MaxLength = 8;
            this.txtValorDiaria.Name = "txtValorDiaria";
            this.txtValorDiaria.Size = new System.Drawing.Size(59, 20);
            this.txtValorDiaria.TabIndex = 2;
            // 
            // lblValorDiaria
            // 
            this.lblValorDiaria.AutoSize = true;
            this.lblValorDiaria.Location = new System.Drawing.Point(13, 51);
            this.lblValorDiaria.Name = "lblValorDiaria";
            this.lblValorDiaria.Size = new System.Drawing.Size(79, 13);
            this.lblValorDiaria.TabIndex = 21;
            this.lblValorDiaria.Text = "Valor da Diária:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Enabled = false;
            this.txtDescricao.Location = new System.Drawing.Point(67, 76);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(187, 73);
            this.txtDescricao.TabIndex = 3;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(13, 79);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 13);
            this.lblDescricao.TabIndex = 20;
            this.lblDescricao.Text = "Descrição:";
            // 
            // gpbCaracteristiacas
            // 
            this.gpbCaracteristiacas.Controls.Add(this.ckbDuasCamas);
            this.gpbCaracteristiacas.Controls.Add(this.ckbFrigobar);
            this.gpbCaracteristiacas.Controls.Add(this.ckbClimatizador);
            this.gpbCaracteristiacas.Controls.Add(this.ckbWireless);
            this.gpbCaracteristiacas.Controls.Add(this.ckbSuiteSingle);
            this.gpbCaracteristiacas.Controls.Add(this.ckbSuiteMaried);
            this.gpbCaracteristiacas.Location = new System.Drawing.Point(268, 23);
            this.gpbCaracteristiacas.Name = "gpbCaracteristiacas";
            this.gpbCaracteristiacas.Size = new System.Drawing.Size(220, 89);
            this.gpbCaracteristiacas.TabIndex = 19;
            this.gpbCaracteristiacas.TabStop = false;
            this.gpbCaracteristiacas.Text = "Características";
            // 
            // ckbDuasCamas
            // 
            this.ckbDuasCamas.AutoSize = true;
            this.ckbDuasCamas.Enabled = false;
            this.ckbDuasCamas.Location = new System.Drawing.Point(15, 65);
            this.ckbDuasCamas.Name = "ckbDuasCamas";
            this.ckbDuasCamas.Size = new System.Drawing.Size(86, 17);
            this.ckbDuasCamas.TabIndex = 2;
            this.ckbDuasCamas.Text = "Duas Camas";
            this.ckbDuasCamas.UseVisualStyleBackColor = true;
            // 
            // ckbFrigobar
            // 
            this.ckbFrigobar.AutoSize = true;
            this.ckbFrigobar.Enabled = false;
            this.ckbFrigobar.Location = new System.Drawing.Point(133, 42);
            this.ckbFrigobar.Name = "ckbFrigobar";
            this.ckbFrigobar.Size = new System.Drawing.Size(64, 17);
            this.ckbFrigobar.TabIndex = 4;
            this.ckbFrigobar.Text = "Frigobar";
            this.ckbFrigobar.UseVisualStyleBackColor = true;
            // 
            // ckbClimatizador
            // 
            this.ckbClimatizador.AutoSize = true;
            this.ckbClimatizador.Enabled = false;
            this.ckbClimatizador.Location = new System.Drawing.Point(133, 19);
            this.ckbClimatizador.Name = "ckbClimatizador";
            this.ckbClimatizador.Size = new System.Drawing.Size(82, 17);
            this.ckbClimatizador.TabIndex = 3;
            this.ckbClimatizador.Text = "Climatizador";
            this.ckbClimatizador.UseVisualStyleBackColor = true;
            // 
            // ckbWireless
            // 
            this.ckbWireless.AutoSize = true;
            this.ckbWireless.Enabled = false;
            this.ckbWireless.Location = new System.Drawing.Point(133, 65);
            this.ckbWireless.Name = "ckbWireless";
            this.ckbWireless.Size = new System.Drawing.Size(66, 17);
            this.ckbWireless.TabIndex = 5;
            this.ckbWireless.Text = "Wireless";
            this.ckbWireless.UseVisualStyleBackColor = true;
            // 
            // ckbSuiteSingle
            // 
            this.ckbSuiteSingle.AutoSize = true;
            this.ckbSuiteSingle.Enabled = false;
            this.ckbSuiteSingle.Location = new System.Drawing.Point(15, 42);
            this.ckbSuiteSingle.Name = "ckbSuiteSingle";
            this.ckbSuiteSingle.Size = new System.Drawing.Size(82, 17);
            this.ckbSuiteSingle.TabIndex = 1;
            this.ckbSuiteSingle.Text = "Suite Single";
            this.ckbSuiteSingle.UseVisualStyleBackColor = true;
            // 
            // ckbSuiteMaried
            // 
            this.ckbSuiteMaried.AutoSize = true;
            this.ckbSuiteMaried.Enabled = false;
            this.ckbSuiteMaried.Location = new System.Drawing.Point(15, 19);
            this.ckbSuiteMaried.Name = "ckbSuiteMaried";
            this.ckbSuiteMaried.Size = new System.Drawing.Size(88, 17);
            this.ckbSuiteMaried.TabIndex = 0;
            this.ckbSuiteMaried.Text = "Suite Married";
            this.ckbSuiteMaried.UseVisualStyleBackColor = true;
            // 
            // lblNovaUnidade
            // 
            this.lblNovaUnidade.AutoSize = true;
            this.lblNovaUnidade.Location = new System.Drawing.Point(18, 9);
            this.lblNovaUnidade.Name = "lblNovaUnidade";
            this.lblNovaUnidade.Size = new System.Drawing.Size(79, 13);
            this.lblNovaUnidade.TabIndex = 32;
            this.lblNovaUnidade.Text = "Nova Unidade.";
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(48, 22);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 0;
            // 
            // lblNomeUni
            // 
            this.lblNomeUni.AutoSize = true;
            this.lblNomeUni.Location = new System.Drawing.Point(13, 25);
            this.lblNomeUni.Name = "lblNomeUni";
            this.lblNomeUni.Size = new System.Drawing.Size(38, 13);
            this.lblNomeUni.TabIndex = 14;
            this.lblNomeUni.Text = "Nome:";
            // 
            // gpbRegistros
            // 
            this.gpbRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbRegistros.Controls.Add(this.txtValorDiaria);
            this.gpbRegistros.Controls.Add(this.lblValorDiaria);
            this.gpbRegistros.Controls.Add(this.txtDescricao);
            this.gpbRegistros.Controls.Add(this.lblDescricao);
            this.gpbRegistros.Controls.Add(this.gpbCaracteristiacas);
            this.gpbRegistros.Controls.Add(this.txtNumero);
            this.gpbRegistros.Controls.Add(this.lblNumeroUni);
            this.gpbRegistros.Controls.Add(this.txtNome);
            this.gpbRegistros.Controls.Add(this.lblNomeUni);
            this.gpbRegistros.Location = new System.Drawing.Point(-1, 84);
            this.gpbRegistros.Name = "gpbRegistros";
            this.gpbRegistros.Size = new System.Drawing.Size(497, 168);
            this.gpbRegistros.TabIndex = 38;
            this.gpbRegistros.TabStop = false;
            this.gpbRegistros.Text = "Registros";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(89, 258);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(65, 23);
            this.btnSalvar.TabIndex = 34;
            this.btnSalvar.Text = "Sal&var";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Image = ((System.Drawing.Image)(resources.GetObject("btnIncluir.Image")));
            this.btnIncluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncluir.Location = new System.Drawing.Point(12, 258);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(61, 23);
            this.btnIncluir.TabIndex = 33;
            this.btnIncluir.Text = "&Incluir";
            this.btnIncluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(250, 258);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(62, 23);
            this.btnExcluir.TabIndex = 36;
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
            this.btnCancelar.Location = new System.Drawing.Point(412, 258);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 37;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pcbUnidade
            // 
            this.pcbUnidade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbUnidade.Image = global::Hotel_Britania.Properties.Resources._1378621656_aiga_hotel_information_bg;
            this.pcbUnidade.Location = new System.Drawing.Point(42, 37);
            this.pcbUnidade.Name = "pcbUnidade";
            this.pcbUnidade.Size = new System.Drawing.Size(34, 36);
            this.pcbUnidade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbUnidade.TabIndex = 39;
            this.pcbUnidade.TabStop = false;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Enabled = false;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(170, 258);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(65, 23);
            this.btnAlterar.TabIndex = 35;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uniIdDataGridViewTextBoxColumn,
            this.uniNomeDataGridViewTextBoxColumn,
            this.uniNumeroDataGridViewTextBoxColumn,
            this.uniValorDiariaDataGridViewTextBoxColumn,
            this.uniDescricaoDataGridViewTextBoxColumn,
            this.uniSuiteMariedDataGridViewCheckBoxColumn,
            this.uniSuiteSingleDataGridViewCheckBoxColumn,
            this.uniDuasCamasDataGridViewCheckBoxColumn,
            this.uniClimatizadorDataGridViewCheckBoxColumn,
            this.uniFrigobarDataGridViewCheckBoxColumn,
            this.uniWirelessDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.tbUnidadeHabitacionalBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 287);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(475, 262);
            this.dataGridView1.TabIndex = 41;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // hotelBDDataSet
            // 
            this.hotelBDDataSet.DataSetName = "HotelBDDataSet";
            this.hotelBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbUnidadeHabitacionalBindingSource
            // 
            this.tbUnidadeHabitacionalBindingSource.DataMember = "tbUnidadeHabitacional";
            this.tbUnidadeHabitacionalBindingSource.DataSource = this.hotelBDDataSet;
            // 
            // tbUnidadeHabitacionalTableAdapter
            // 
            this.tbUnidadeHabitacionalTableAdapter.ClearBeforeFill = true;
            // 
            // uniIdDataGridViewTextBoxColumn
            // 
            this.uniIdDataGridViewTextBoxColumn.DataPropertyName = "Uni_Id";
            this.uniIdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.uniIdDataGridViewTextBoxColumn.Name = "uniIdDataGridViewTextBoxColumn";
            this.uniIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uniNomeDataGridViewTextBoxColumn
            // 
            this.uniNomeDataGridViewTextBoxColumn.DataPropertyName = "Uni_Nome";
            this.uniNomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.uniNomeDataGridViewTextBoxColumn.Name = "uniNomeDataGridViewTextBoxColumn";
            this.uniNomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uniNumeroDataGridViewTextBoxColumn
            // 
            this.uniNumeroDataGridViewTextBoxColumn.DataPropertyName = "Uni_Numero";
            this.uniNumeroDataGridViewTextBoxColumn.HeaderText = "Número";
            this.uniNumeroDataGridViewTextBoxColumn.Name = "uniNumeroDataGridViewTextBoxColumn";
            this.uniNumeroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uniValorDiariaDataGridViewTextBoxColumn
            // 
            this.uniValorDiariaDataGridViewTextBoxColumn.DataPropertyName = "Uni_ValorDiaria";
            this.uniValorDiariaDataGridViewTextBoxColumn.HeaderText = "Valor da diaria";
            this.uniValorDiariaDataGridViewTextBoxColumn.Name = "uniValorDiariaDataGridViewTextBoxColumn";
            this.uniValorDiariaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uniDescricaoDataGridViewTextBoxColumn
            // 
            this.uniDescricaoDataGridViewTextBoxColumn.DataPropertyName = "Uni_Descricao";
            this.uniDescricaoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.uniDescricaoDataGridViewTextBoxColumn.Name = "uniDescricaoDataGridViewTextBoxColumn";
            this.uniDescricaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uniSuiteMariedDataGridViewCheckBoxColumn
            // 
            this.uniSuiteMariedDataGridViewCheckBoxColumn.DataPropertyName = "Uni_SuiteMaried";
            this.uniSuiteMariedDataGridViewCheckBoxColumn.HeaderText = "Suite Maried";
            this.uniSuiteMariedDataGridViewCheckBoxColumn.Name = "uniSuiteMariedDataGridViewCheckBoxColumn";
            this.uniSuiteMariedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // uniSuiteSingleDataGridViewCheckBoxColumn
            // 
            this.uniSuiteSingleDataGridViewCheckBoxColumn.DataPropertyName = "Uni_SuiteSingle";
            this.uniSuiteSingleDataGridViewCheckBoxColumn.HeaderText = "Suite Single";
            this.uniSuiteSingleDataGridViewCheckBoxColumn.Name = "uniSuiteSingleDataGridViewCheckBoxColumn";
            this.uniSuiteSingleDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // uniDuasCamasDataGridViewCheckBoxColumn
            // 
            this.uniDuasCamasDataGridViewCheckBoxColumn.DataPropertyName = "Uni_DuasCamas";
            this.uniDuasCamasDataGridViewCheckBoxColumn.HeaderText = "Duas Camas";
            this.uniDuasCamasDataGridViewCheckBoxColumn.Name = "uniDuasCamasDataGridViewCheckBoxColumn";
            this.uniDuasCamasDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // uniClimatizadorDataGridViewCheckBoxColumn
            // 
            this.uniClimatizadorDataGridViewCheckBoxColumn.DataPropertyName = "Uni_Climatizador";
            this.uniClimatizadorDataGridViewCheckBoxColumn.HeaderText = "Climatizador";
            this.uniClimatizadorDataGridViewCheckBoxColumn.Name = "uniClimatizadorDataGridViewCheckBoxColumn";
            this.uniClimatizadorDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // uniFrigobarDataGridViewCheckBoxColumn
            // 
            this.uniFrigobarDataGridViewCheckBoxColumn.DataPropertyName = "Uni_Frigobar";
            this.uniFrigobarDataGridViewCheckBoxColumn.HeaderText = "Frigobar";
            this.uniFrigobarDataGridViewCheckBoxColumn.Name = "uniFrigobarDataGridViewCheckBoxColumn";
            this.uniFrigobarDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // uniWirelessDataGridViewCheckBoxColumn
            // 
            this.uniWirelessDataGridViewCheckBoxColumn.DataPropertyName = "Uni_Wireless";
            this.uniWirelessDataGridViewCheckBoxColumn.HeaderText = "Wireless";
            this.uniWirelessDataGridViewCheckBoxColumn.Name = "uniWirelessDataGridViewCheckBoxColumn";
            this.uniWirelessDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // FrmCadastrarUnidadeHabitacional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 561);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblNovaUnidade);
            this.Controls.Add(this.pcbUnidade);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.gpbRegistros);
            this.Controls.Add(this.gpbPesquisa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastrarUnidadeHabitacional";
            this.Text = "Cadastrar Unidades Habitacionais";
            this.Load += new System.EventHandler(this.FrmCadastrarUnidadeHabitacional_Load);
            this.gpbPesquisa.ResumeLayout(false);
            this.gpbPesquisa.PerformLayout();
            this.gpbCaracteristiacas.ResumeLayout(false);
            this.gpbCaracteristiacas.PerformLayout();
            this.gpbRegistros.ResumeLayout(false);
            this.gpbRegistros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUnidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUnidadeHabitacionalBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button btnSalvar;
        protected System.Windows.Forms.Button btnBuscaAvancada;
        protected System.Windows.Forms.Button btnBuscaRapida;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumeroUni;
        protected System.Windows.Forms.Button btnAnterior;
        protected System.Windows.Forms.Button btnIncluir;
        protected System.Windows.Forms.Button btnExcluir;
        protected System.Windows.Forms.Button btnProximo;
        protected System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox gpbPesquisa;
        private System.Windows.Forms.Label lblNomeUniP;
        private System.Windows.Forms.TextBox txtPesquisaRapida;
        private System.Windows.Forms.TextBox txtValorDiaria;
        private System.Windows.Forms.Label lblValorDiaria;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.GroupBox gpbCaracteristiacas;
        private System.Windows.Forms.CheckBox ckbDuasCamas;
        private System.Windows.Forms.CheckBox ckbFrigobar;
        private System.Windows.Forms.CheckBox ckbClimatizador;
        private System.Windows.Forms.CheckBox ckbWireless;
        private System.Windows.Forms.CheckBox ckbSuiteSingle;
        private System.Windows.Forms.CheckBox ckbSuiteMaried;
        private System.Windows.Forms.Label lblNovaUnidade;
        private System.Windows.Forms.PictureBox pcbUnidade;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNomeUni;
        protected System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.GroupBox gpbRegistros;
        private System.Windows.Forms.DataGridView dataGridView1;
        private HotelBDDataSet hotelBDDataSet;
        private System.Windows.Forms.BindingSource tbUnidadeHabitacionalBindingSource;
        private HotelBDDataSetTableAdapters.tbUnidadeHabitacionalTableAdapter tbUnidadeHabitacionalTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn uniIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uniNomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uniNumeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uniValorDiariaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uniDescricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn uniSuiteMariedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn uniSuiteSingleDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn uniDuasCamasDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn uniClimatizadorDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn uniFrigobarDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn uniWirelessDataGridViewCheckBoxColumn;
    }
}