namespace Hotel_Britania
{
    partial class FrmRegistrarCheckIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistrarCheckIn));
            this.gpbCheck = new System.Windows.Forms.GroupBox();
            this.cboStatus = new System.Windows.Forms.CheckBox();
            this.lblDataCheckOut = new System.Windows.Forms.Label();
            this.dtpDataCheckOut = new System.Windows.Forms.DateTimePicker();
            this.lblDataCheckIn = new System.Windows.Forms.Label();
            this.dtpDataCheckIn = new System.Windows.Forms.DateTimePicker();
            this.txtValorDiaria = new System.Windows.Forms.TextBox();
            this.lblValorDiaria = new System.Windows.Forms.Label();
            this.txtHospede = new System.Windows.Forms.TextBox();
            this.lblHospedes = new System.Windows.Forms.Label();
            this.txtNomeUni = new System.Windows.Forms.TextBox();
            this.lblNomeUni = new System.Windows.Forms.Label();
            this.btnRemover = new System.Windows.Forms.Button();
            this.gpbAddHodUni = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabpUnidadeHabitacional = new System.Windows.Forms.TabPage();
            this.txtASK = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tabpHospede = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvHospede = new System.Windows.Forms.DataGridView();
            this.hotelBDDataSet = new Hotel_Britania.HotelBDDataSet();
            this.tbHospedeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbHospedeTableAdapter = new Hotel_Britania.HotelBDDataSetTableAdapters.tbHospedeTableAdapter();
            this.hosIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hosNomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hosNaturalidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hosUfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hosNacionalidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hosCpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hosSexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hosDataNascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hosTelefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hosEMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUnidadeHabitacional = new System.Windows.Forms.DataGridView();
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
            this.gpbCheck.SuspendLayout();
            this.gpbAddHodUni.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabpUnidadeHabitacional.SuspendLayout();
            this.tabpHospede.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHospede)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbHospedeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnidadeHabitacional)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUnidadeHabitacionalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbCheck
            // 
            this.gpbCheck.Controls.Add(this.cboStatus);
            this.gpbCheck.Controls.Add(this.lblDataCheckOut);
            this.gpbCheck.Controls.Add(this.dtpDataCheckOut);
            this.gpbCheck.Controls.Add(this.lblDataCheckIn);
            this.gpbCheck.Controls.Add(this.dtpDataCheckIn);
            this.gpbCheck.Controls.Add(this.txtValorDiaria);
            this.gpbCheck.Controls.Add(this.lblValorDiaria);
            this.gpbCheck.Controls.Add(this.txtHospede);
            this.gpbCheck.Controls.Add(this.lblHospedes);
            this.gpbCheck.Controls.Add(this.txtNomeUni);
            this.gpbCheck.Controls.Add(this.lblNomeUni);
            this.gpbCheck.Location = new System.Drawing.Point(11, 11);
            this.gpbCheck.Name = "gpbCheck";
            this.gpbCheck.Size = new System.Drawing.Size(264, 292);
            this.gpbCheck.TabIndex = 39;
            this.gpbCheck.TabStop = false;
            this.gpbCheck.Text = "Check";
            // 
            // cboStatus
            // 
            this.cboStatus.AutoSize = true;
            this.cboStatus.Location = new System.Drawing.Point(11, 234);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(72, 17);
            this.cboStatus.TabIndex = 17;
            this.cboStatus.Text = "Reserva?";
            this.cboStatus.UseVisualStyleBackColor = true;
            // 
            // lblDataCheckOut
            // 
            this.lblDataCheckOut.AutoSize = true;
            this.lblDataCheckOut.Location = new System.Drawing.Point(10, 95);
            this.lblDataCheckOut.Name = "lblDataCheckOut";
            this.lblDataCheckOut.Size = new System.Drawing.Size(151, 13);
            this.lblDataCheckOut.TabIndex = 16;
            this.lblDataCheckOut.Text = "Data prevista para Check-Out:";
            // 
            // dtpDataCheckOut
            // 
            this.dtpDataCheckOut.Location = new System.Drawing.Point(11, 111);
            this.dtpDataCheckOut.Name = "dtpDataCheckOut";
            this.dtpDataCheckOut.Size = new System.Drawing.Size(247, 20);
            this.dtpDataCheckOut.TabIndex = 15;
            this.dtpDataCheckOut.Value = new System.DateTime(2017, 10, 22, 0, 0, 0, 0);
            // 
            // lblDataCheckIn
            // 
            this.lblDataCheckIn.AutoSize = true;
            this.lblDataCheckIn.Location = new System.Drawing.Point(8, 56);
            this.lblDataCheckIn.Name = "lblDataCheckIn";
            this.lblDataCheckIn.Size = new System.Drawing.Size(94, 13);
            this.lblDataCheckIn.TabIndex = 14;
            this.lblDataCheckIn.Text = "Data do Check-In:";
            // 
            // dtpDataCheckIn
            // 
            this.dtpDataCheckIn.Location = new System.Drawing.Point(11, 72);
            this.dtpDataCheckIn.Name = "dtpDataCheckIn";
            this.dtpDataCheckIn.Size = new System.Drawing.Size(247, 20);
            this.dtpDataCheckIn.TabIndex = 2;
            this.dtpDataCheckIn.Value = new System.DateTime(2017, 10, 22, 0, 0, 0, 0);
            // 
            // txtValorDiaria
            // 
            this.txtValorDiaria.Enabled = false;
            this.txtValorDiaria.Location = new System.Drawing.Point(182, 33);
            this.txtValorDiaria.MaxLength = 8;
            this.txtValorDiaria.Name = "txtValorDiaria";
            this.txtValorDiaria.Size = new System.Drawing.Size(76, 20);
            this.txtValorDiaria.TabIndex = 1;
            // 
            // lblValorDiaria
            // 
            this.lblValorDiaria.AutoSize = true;
            this.lblValorDiaria.Location = new System.Drawing.Point(179, 17);
            this.lblValorDiaria.Name = "lblValorDiaria";
            this.lblValorDiaria.Size = new System.Drawing.Size(79, 13);
            this.lblValorDiaria.TabIndex = 12;
            this.lblValorDiaria.Text = "Valor da Diária:";
            // 
            // txtHospede
            // 
            this.txtHospede.Enabled = false;
            this.txtHospede.Location = new System.Drawing.Point(11, 164);
            this.txtHospede.Multiline = true;
            this.txtHospede.Name = "txtHospede";
            this.txtHospede.Size = new System.Drawing.Size(247, 20);
            this.txtHospede.TabIndex = 3;
            // 
            // lblHospedes
            // 
            this.lblHospedes.AutoSize = true;
            this.lblHospedes.Location = new System.Drawing.Point(8, 148);
            this.lblHospedes.Name = "lblHospedes";
            this.lblHospedes.Size = new System.Drawing.Size(48, 13);
            this.lblHospedes.TabIndex = 10;
            this.lblHospedes.Text = "Hópede:";
            // 
            // txtNomeUni
            // 
            this.txtNomeUni.Enabled = false;
            this.txtNomeUni.Location = new System.Drawing.Point(10, 33);
            this.txtNomeUni.MaxLength = 6;
            this.txtNomeUni.Name = "txtNomeUni";
            this.txtNomeUni.Size = new System.Drawing.Size(166, 20);
            this.txtNomeUni.TabIndex = 0;
            // 
            // lblNomeUni
            // 
            this.lblNomeUni.AutoSize = true;
            this.lblNomeUni.Location = new System.Drawing.Point(8, 17);
            this.lblNomeUni.Name = "lblNomeUni";
            this.lblNomeUni.Size = new System.Drawing.Size(158, 13);
            this.lblNomeUni.TabIndex = 2;
            this.lblNomeUni.Text = "Nome da Unidade Habitacional:";
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(146, 309);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(129, 23);
            this.btnRemover.TabIndex = 4;
            this.btnRemover.Text = "&Limpar Campos";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // gpbAddHodUni
            // 
            this.gpbAddHodUni.Controls.Add(this.tabControl1);
            this.gpbAddHodUni.Location = new System.Drawing.Point(287, 11);
            this.gpbAddHodUni.Name = "gpbAddHodUni";
            this.gpbAddHodUni.Size = new System.Drawing.Size(496, 292);
            this.gpbAddHodUni.TabIndex = 40;
            this.gpbAddHodUni.TabStop = false;
            this.gpbAddHodUni.Text = "Adicionar Hospedes ou Unidade Habitacional";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabpUnidadeHabitacional);
            this.tabControl1.Controls.Add(this.tabpHospede);
            this.tabControl1.Location = new System.Drawing.Point(0, 15);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(496, 277);
            this.tabControl1.TabIndex = 41;
            // 
            // tabpUnidadeHabitacional
            // 
            this.tabpUnidadeHabitacional.Controls.Add(this.dgvUnidadeHabitacional);
            this.tabpUnidadeHabitacional.Controls.Add(this.txtASK);
            this.tabpUnidadeHabitacional.Controls.Add(this.lblNome);
            this.tabpUnidadeHabitacional.Controls.Add(this.btnBuscar);
            this.tabpUnidadeHabitacional.Location = new System.Drawing.Point(4, 22);
            this.tabpUnidadeHabitacional.Name = "tabpUnidadeHabitacional";
            this.tabpUnidadeHabitacional.Padding = new System.Windows.Forms.Padding(3);
            this.tabpUnidadeHabitacional.Size = new System.Drawing.Size(488, 251);
            this.tabpUnidadeHabitacional.TabIndex = 0;
            this.tabpUnidadeHabitacional.Text = "Unidade Habitacional";
            this.tabpUnidadeHabitacional.UseVisualStyleBackColor = true;
            // 
            // txtASK
            // 
            this.txtASK.Location = new System.Drawing.Point(50, 11);
            this.txtASK.Name = "txtASK";
            this.txtASK.Size = new System.Drawing.Size(352, 20);
            this.txtASK.TabIndex = 41;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(6, 14);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 43;
            this.lblNome.Text = "Nome:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(408, 10);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 42;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // tabpHospede
            // 
            this.tabpHospede.Controls.Add(this.dgvHospede);
            this.tabpHospede.Controls.Add(this.textBox1);
            this.tabpHospede.Controls.Add(this.label2);
            this.tabpHospede.Controls.Add(this.button1);
            this.tabpHospede.Location = new System.Drawing.Point(4, 22);
            this.tabpHospede.Name = "tabpHospede";
            this.tabpHospede.Padding = new System.Windows.Forms.Padding(3);
            this.tabpHospede.Size = new System.Drawing.Size(488, 251);
            this.tabpHospede.TabIndex = 1;
            this.tabpHospede.Text = "Hóspede";
            this.tabpHospede.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(50, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(352, 20);
            this.textBox1.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Nome:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(408, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 46;
            this.button1.Text = "&Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Location = new System.Drawing.Point(11, 309);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 37;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Location = new System.Drawing.Point(708, 309);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 38;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvHospede
            // 
            this.dgvHospede.AllowUserToAddRows = false;
            this.dgvHospede.AllowUserToDeleteRows = false;
            this.dgvHospede.AllowUserToOrderColumns = true;
            this.dgvHospede.AutoGenerateColumns = false;
            this.dgvHospede.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHospede.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hosIdDataGridViewTextBoxColumn,
            this.hosNomeDataGridViewTextBoxColumn,
            this.hosNaturalidadeDataGridViewTextBoxColumn,
            this.hosUfDataGridViewTextBoxColumn,
            this.hosNacionalidadeDataGridViewTextBoxColumn,
            this.hosCpfDataGridViewTextBoxColumn,
            this.hosSexoDataGridViewTextBoxColumn,
            this.hosDataNascimentoDataGridViewTextBoxColumn,
            this.hosTelefoneDataGridViewTextBoxColumn,
            this.hosEMailDataGridViewTextBoxColumn});
            this.dgvHospede.DataSource = this.tbHospedeBindingSource;
            this.dgvHospede.Location = new System.Drawing.Point(3, 37);
            this.dgvHospede.Name = "dgvHospede";
            this.dgvHospede.ReadOnly = true;
            this.dgvHospede.Size = new System.Drawing.Size(483, 214);
            this.dgvHospede.TabIndex = 48;
            this.dgvHospede.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvHospede_CellMouseClick_1);
            // 
            // hotelBDDataSet
            // 
            this.hotelBDDataSet.DataSetName = "HotelBDDataSet";
            this.hotelBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbHospedeBindingSource
            // 
            this.tbHospedeBindingSource.DataMember = "tbHospede";
            this.tbHospedeBindingSource.DataSource = this.hotelBDDataSet;
            // 
            // tbHospedeTableAdapter
            // 
            this.tbHospedeTableAdapter.ClearBeforeFill = true;
            // 
            // hosIdDataGridViewTextBoxColumn
            // 
            this.hosIdDataGridViewTextBoxColumn.DataPropertyName = "Hos_Id";
            this.hosIdDataGridViewTextBoxColumn.HeaderText = "Hos_Id";
            this.hosIdDataGridViewTextBoxColumn.Name = "hosIdDataGridViewTextBoxColumn";
            this.hosIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hosNomeDataGridViewTextBoxColumn
            // 
            this.hosNomeDataGridViewTextBoxColumn.DataPropertyName = "Hos_Nome";
            this.hosNomeDataGridViewTextBoxColumn.HeaderText = "Hos_Nome";
            this.hosNomeDataGridViewTextBoxColumn.Name = "hosNomeDataGridViewTextBoxColumn";
            this.hosNomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hosNaturalidadeDataGridViewTextBoxColumn
            // 
            this.hosNaturalidadeDataGridViewTextBoxColumn.DataPropertyName = "Hos_Naturalidade";
            this.hosNaturalidadeDataGridViewTextBoxColumn.HeaderText = "Hos_Naturalidade";
            this.hosNaturalidadeDataGridViewTextBoxColumn.Name = "hosNaturalidadeDataGridViewTextBoxColumn";
            this.hosNaturalidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hosUfDataGridViewTextBoxColumn
            // 
            this.hosUfDataGridViewTextBoxColumn.DataPropertyName = "Hos_Uf";
            this.hosUfDataGridViewTextBoxColumn.HeaderText = "Hos_Uf";
            this.hosUfDataGridViewTextBoxColumn.Name = "hosUfDataGridViewTextBoxColumn";
            this.hosUfDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hosNacionalidadeDataGridViewTextBoxColumn
            // 
            this.hosNacionalidadeDataGridViewTextBoxColumn.DataPropertyName = "Hos_Nacionalidade";
            this.hosNacionalidadeDataGridViewTextBoxColumn.HeaderText = "Hos_Nacionalidade";
            this.hosNacionalidadeDataGridViewTextBoxColumn.Name = "hosNacionalidadeDataGridViewTextBoxColumn";
            this.hosNacionalidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hosCpfDataGridViewTextBoxColumn
            // 
            this.hosCpfDataGridViewTextBoxColumn.DataPropertyName = "Hos_Cpf";
            this.hosCpfDataGridViewTextBoxColumn.HeaderText = "Hos_Cpf";
            this.hosCpfDataGridViewTextBoxColumn.Name = "hosCpfDataGridViewTextBoxColumn";
            this.hosCpfDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hosSexoDataGridViewTextBoxColumn
            // 
            this.hosSexoDataGridViewTextBoxColumn.DataPropertyName = "Hos_Sexo";
            this.hosSexoDataGridViewTextBoxColumn.HeaderText = "Hos_Sexo";
            this.hosSexoDataGridViewTextBoxColumn.Name = "hosSexoDataGridViewTextBoxColumn";
            this.hosSexoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hosDataNascimentoDataGridViewTextBoxColumn
            // 
            this.hosDataNascimentoDataGridViewTextBoxColumn.DataPropertyName = "Hos_DataNascimento";
            this.hosDataNascimentoDataGridViewTextBoxColumn.HeaderText = "Hos_DataNascimento";
            this.hosDataNascimentoDataGridViewTextBoxColumn.Name = "hosDataNascimentoDataGridViewTextBoxColumn";
            this.hosDataNascimentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hosTelefoneDataGridViewTextBoxColumn
            // 
            this.hosTelefoneDataGridViewTextBoxColumn.DataPropertyName = "Hos_Telefone";
            this.hosTelefoneDataGridViewTextBoxColumn.HeaderText = "Hos_Telefone";
            this.hosTelefoneDataGridViewTextBoxColumn.Name = "hosTelefoneDataGridViewTextBoxColumn";
            this.hosTelefoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hosEMailDataGridViewTextBoxColumn
            // 
            this.hosEMailDataGridViewTextBoxColumn.DataPropertyName = "Hos_EMail";
            this.hosEMailDataGridViewTextBoxColumn.HeaderText = "Hos_EMail";
            this.hosEMailDataGridViewTextBoxColumn.Name = "hosEMailDataGridViewTextBoxColumn";
            this.hosEMailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dgvUnidadeHabitacional
            // 
            this.dgvUnidadeHabitacional.AllowUserToAddRows = false;
            this.dgvUnidadeHabitacional.AllowUserToDeleteRows = false;
            this.dgvUnidadeHabitacional.AllowUserToOrderColumns = true;
            this.dgvUnidadeHabitacional.AutoGenerateColumns = false;
            this.dgvUnidadeHabitacional.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnidadeHabitacional.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgvUnidadeHabitacional.DataSource = this.tbUnidadeHabitacionalBindingSource;
            this.dgvUnidadeHabitacional.Location = new System.Drawing.Point(3, 39);
            this.dgvUnidadeHabitacional.Name = "dgvUnidadeHabitacional";
            this.dgvUnidadeHabitacional.ReadOnly = true;
            this.dgvUnidadeHabitacional.Size = new System.Drawing.Size(483, 212);
            this.dgvUnidadeHabitacional.TabIndex = 44;
            this.dgvUnidadeHabitacional.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUnidadeHabitacional_CellMouseClick_1);
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
            this.uniIdDataGridViewTextBoxColumn.HeaderText = "Uni_Id";
            this.uniIdDataGridViewTextBoxColumn.Name = "uniIdDataGridViewTextBoxColumn";
            this.uniIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uniNomeDataGridViewTextBoxColumn
            // 
            this.uniNomeDataGridViewTextBoxColumn.DataPropertyName = "Uni_Nome";
            this.uniNomeDataGridViewTextBoxColumn.HeaderText = "Uni_Nome";
            this.uniNomeDataGridViewTextBoxColumn.Name = "uniNomeDataGridViewTextBoxColumn";
            this.uniNomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uniNumeroDataGridViewTextBoxColumn
            // 
            this.uniNumeroDataGridViewTextBoxColumn.DataPropertyName = "Uni_Numero";
            this.uniNumeroDataGridViewTextBoxColumn.HeaderText = "Uni_Numero";
            this.uniNumeroDataGridViewTextBoxColumn.Name = "uniNumeroDataGridViewTextBoxColumn";
            this.uniNumeroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uniValorDiariaDataGridViewTextBoxColumn
            // 
            this.uniValorDiariaDataGridViewTextBoxColumn.DataPropertyName = "Uni_ValorDiaria";
            this.uniValorDiariaDataGridViewTextBoxColumn.HeaderText = "Uni_ValorDiaria";
            this.uniValorDiariaDataGridViewTextBoxColumn.Name = "uniValorDiariaDataGridViewTextBoxColumn";
            this.uniValorDiariaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uniDescricaoDataGridViewTextBoxColumn
            // 
            this.uniDescricaoDataGridViewTextBoxColumn.DataPropertyName = "Uni_Descricao";
            this.uniDescricaoDataGridViewTextBoxColumn.HeaderText = "Uni_Descricao";
            this.uniDescricaoDataGridViewTextBoxColumn.Name = "uniDescricaoDataGridViewTextBoxColumn";
            this.uniDescricaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uniSuiteMariedDataGridViewCheckBoxColumn
            // 
            this.uniSuiteMariedDataGridViewCheckBoxColumn.DataPropertyName = "Uni_SuiteMaried";
            this.uniSuiteMariedDataGridViewCheckBoxColumn.HeaderText = "Uni_SuiteMaried";
            this.uniSuiteMariedDataGridViewCheckBoxColumn.Name = "uniSuiteMariedDataGridViewCheckBoxColumn";
            this.uniSuiteMariedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // uniSuiteSingleDataGridViewCheckBoxColumn
            // 
            this.uniSuiteSingleDataGridViewCheckBoxColumn.DataPropertyName = "Uni_SuiteSingle";
            this.uniSuiteSingleDataGridViewCheckBoxColumn.HeaderText = "Uni_SuiteSingle";
            this.uniSuiteSingleDataGridViewCheckBoxColumn.Name = "uniSuiteSingleDataGridViewCheckBoxColumn";
            this.uniSuiteSingleDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // uniDuasCamasDataGridViewCheckBoxColumn
            // 
            this.uniDuasCamasDataGridViewCheckBoxColumn.DataPropertyName = "Uni_DuasCamas";
            this.uniDuasCamasDataGridViewCheckBoxColumn.HeaderText = "Uni_DuasCamas";
            this.uniDuasCamasDataGridViewCheckBoxColumn.Name = "uniDuasCamasDataGridViewCheckBoxColumn";
            this.uniDuasCamasDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // uniClimatizadorDataGridViewCheckBoxColumn
            // 
            this.uniClimatizadorDataGridViewCheckBoxColumn.DataPropertyName = "Uni_Climatizador";
            this.uniClimatizadorDataGridViewCheckBoxColumn.HeaderText = "Uni_Climatizador";
            this.uniClimatizadorDataGridViewCheckBoxColumn.Name = "uniClimatizadorDataGridViewCheckBoxColumn";
            this.uniClimatizadorDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // uniFrigobarDataGridViewCheckBoxColumn
            // 
            this.uniFrigobarDataGridViewCheckBoxColumn.DataPropertyName = "Uni_Frigobar";
            this.uniFrigobarDataGridViewCheckBoxColumn.HeaderText = "Uni_Frigobar";
            this.uniFrigobarDataGridViewCheckBoxColumn.Name = "uniFrigobarDataGridViewCheckBoxColumn";
            this.uniFrigobarDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // uniWirelessDataGridViewCheckBoxColumn
            // 
            this.uniWirelessDataGridViewCheckBoxColumn.DataPropertyName = "Uni_Wireless";
            this.uniWirelessDataGridViewCheckBoxColumn.HeaderText = "Uni_Wireless";
            this.uniWirelessDataGridViewCheckBoxColumn.Name = "uniWirelessDataGridViewCheckBoxColumn";
            this.uniWirelessDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // FrmRegistrarCheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 343);
            this.Controls.Add(this.gpbCheck);
            this.Controls.Add(this.gpbAddHodUni);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRegistrarCheckIn";
            this.Text = "Reservar ou realizar Check-In ";
            this.Load += new System.EventHandler(this.FrmRegistrarCheckIn_Load);
            this.gpbCheck.ResumeLayout(false);
            this.gpbCheck.PerformLayout();
            this.gpbAddHodUni.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabpUnidadeHabitacional.ResumeLayout(false);
            this.tabpUnidadeHabitacional.PerformLayout();
            this.tabpHospede.ResumeLayout(false);
            this.tabpHospede.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHospede)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbHospedeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnidadeHabitacional)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUnidadeHabitacionalBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gpbCheck;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Label lblDataCheckIn;
        private System.Windows.Forms.DateTimePicker dtpDataCheckIn;
        private System.Windows.Forms.TextBox txtValorDiaria;
        private System.Windows.Forms.Label lblValorDiaria;
        private System.Windows.Forms.TextBox txtHospede;
        private System.Windows.Forms.Label lblHospedes;
        private System.Windows.Forms.TextBox txtNomeUni;
        private System.Windows.Forms.Label lblNomeUni;
        private System.Windows.Forms.GroupBox gpbAddHodUni;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblDataCheckOut;
        private System.Windows.Forms.DateTimePicker dtpDataCheckOut;
        private System.Windows.Forms.CheckBox cboStatus;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabpUnidadeHabitacional;
        private System.Windows.Forms.TextBox txtASK;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TabPage tabpHospede;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvHospede;
        private HotelBDDataSet hotelBDDataSet;
        private System.Windows.Forms.BindingSource tbHospedeBindingSource;
        private HotelBDDataSetTableAdapters.tbHospedeTableAdapter tbHospedeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn hosIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hosNomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hosNaturalidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hosUfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hosNacionalidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hosCpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hosSexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hosDataNascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hosTelefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hosEMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvUnidadeHabitacional;
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