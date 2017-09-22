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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistrarCheckIn));
            this.gpbCheck = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnRemover = new System.Windows.Forms.Button();
            this.lblDataCheckIn = new System.Windows.Forms.Label();
            this.dtpDataCheckIn = new System.Windows.Forms.DateTimePicker();
            this.txtValorDiaria = new System.Windows.Forms.TextBox();
            this.lblValorDiaria = new System.Windows.Forms.Label();
            this.txtHospedes = new System.Windows.Forms.TextBox();
            this.lblHospedes = new System.Windows.Forms.Label();
            this.txtNumeroUni = new System.Windows.Forms.TextBox();
            this.lblNumeroUni = new System.Windows.Forms.Label();
            this.txtASK = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dataHosUni = new System.Windows.Forms.DataGridView();
            this.radHos = new System.Windows.Forms.RadioButton();
            this.radUniHab = new System.Windows.Forms.RadioButton();
            this.gpbAddHodUni = new System.Windows.Forms.GroupBox();
            this.lblSeleHosUni = new System.Windows.Forms.Label();
            this.pcbUnidade = new System.Windows.Forms.PictureBox();
            this.pcbHospede = new System.Windows.Forms.PictureBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.gpbCheck.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHosUni)).BeginInit();
            this.gpbAddHodUni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUnidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbHospede)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbCheck
            // 
            this.gpbCheck.Controls.Add(this.checkBox1);
            this.gpbCheck.Controls.Add(this.label1);
            this.gpbCheck.Controls.Add(this.dateTimePicker1);
            this.gpbCheck.Controls.Add(this.lblDataCheckIn);
            this.gpbCheck.Controls.Add(this.dtpDataCheckIn);
            this.gpbCheck.Controls.Add(this.txtValorDiaria);
            this.gpbCheck.Controls.Add(this.lblValorDiaria);
            this.gpbCheck.Controls.Add(this.txtHospedes);
            this.gpbCheck.Controls.Add(this.lblHospedes);
            this.gpbCheck.Controls.Add(this.txtNumeroUni);
            this.gpbCheck.Controls.Add(this.lblNumeroUni);
            this.gpbCheck.Location = new System.Drawing.Point(11, 11);
            this.gpbCheck.Name = "gpbCheck";
            this.gpbCheck.Size = new System.Drawing.Size(264, 292);
            this.gpbCheck.TabIndex = 39;
            this.gpbCheck.TabStop = false;
            this.gpbCheck.Text = "Check";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Data prevista para Check-Out:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(11, 111);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(247, 20);
            this.dateTimePicker1.TabIndex = 15;
            this.dateTimePicker1.Value = new System.DateTime(2013, 11, 2, 0, 0, 0, 0);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(146, 309);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(129, 23);
            this.btnRemover.TabIndex = 4;
            this.btnRemover.Text = "&Limpar Campos";
            this.btnRemover.UseVisualStyleBackColor = true;
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
            this.dtpDataCheckIn.Value = new System.DateTime(2013, 11, 2, 0, 0, 0, 0);
            // 
            // txtValorDiaria
            // 
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
            // txtHospedes
            // 
            this.txtHospedes.Location = new System.Drawing.Point(11, 164);
            this.txtHospedes.Multiline = true;
            this.txtHospedes.Name = "txtHospedes";
            this.txtHospedes.Size = new System.Drawing.Size(247, 20);
            this.txtHospedes.TabIndex = 3;
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
            // txtNumeroUni
            // 
            this.txtNumeroUni.Location = new System.Drawing.Point(10, 33);
            this.txtNumeroUni.MaxLength = 6;
            this.txtNumeroUni.Name = "txtNumeroUni";
            this.txtNumeroUni.Size = new System.Drawing.Size(166, 20);
            this.txtNumeroUni.TabIndex = 0;
            // 
            // lblNumeroUni
            // 
            this.lblNumeroUni.AutoSize = true;
            this.lblNumeroUni.Location = new System.Drawing.Point(8, 17);
            this.lblNumeroUni.Name = "lblNumeroUni";
            this.lblNumeroUni.Size = new System.Drawing.Size(158, 13);
            this.lblNumeroUni.TabIndex = 2;
            this.lblNumeroUni.Text = "Nome da Unidade Habitacional:";
            // 
            // txtASK
            // 
            this.txtASK.Location = new System.Drawing.Point(57, 92);
            this.txtASK.Name = "txtASK";
            this.txtASK.Size = new System.Drawing.Size(352, 20);
            this.txtASK.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(13, 95);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 40;
            this.lblNome.Text = "Nome:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(415, 92);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dataHosUni
            // 
            this.dataHosUni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHosUni.Location = new System.Drawing.Point(6, 121);
            this.dataHosUni.Name = "dataHosUni";
            this.dataHosUni.Size = new System.Drawing.Size(484, 165);
            this.dataHosUni.TabIndex = 38;
            // 
            // radHos
            // 
            this.radHos.AutoSize = true;
            this.radHos.Location = new System.Drawing.Point(300, 51);
            this.radHos.Name = "radHos";
            this.radHos.Size = new System.Drawing.Size(76, 17);
            this.radHos.TabIndex = 1;
            this.radHos.TabStop = true;
            this.radHos.Text = "Hospedes.";
            this.radHos.UseVisualStyleBackColor = true;
            // 
            // radUniHab
            // 
            this.radUniHab.AutoSize = true;
            this.radUniHab.Location = new System.Drawing.Point(56, 51);
            this.radUniHab.Name = "radUniHab";
            this.radUniHab.Size = new System.Drawing.Size(140, 17);
            this.radUniHab.TabIndex = 0;
            this.radUniHab.TabStop = true;
            this.radUniHab.Text = "Unidades Habitacionais.";
            this.radUniHab.UseVisualStyleBackColor = true;
            // 
            // gpbAddHodUni
            // 
            this.gpbAddHodUni.Controls.Add(this.txtASK);
            this.gpbAddHodUni.Controls.Add(this.lblNome);
            this.gpbAddHodUni.Controls.Add(this.btnBuscar);
            this.gpbAddHodUni.Controls.Add(this.dataHosUni);
            this.gpbAddHodUni.Controls.Add(this.radHos);
            this.gpbAddHodUni.Controls.Add(this.radUniHab);
            this.gpbAddHodUni.Controls.Add(this.lblSeleHosUni);
            this.gpbAddHodUni.Controls.Add(this.pcbUnidade);
            this.gpbAddHodUni.Controls.Add(this.pcbHospede);
            this.gpbAddHodUni.Location = new System.Drawing.Point(287, 11);
            this.gpbAddHodUni.Name = "gpbAddHodUni";
            this.gpbAddHodUni.Size = new System.Drawing.Size(496, 292);
            this.gpbAddHodUni.TabIndex = 40;
            this.gpbAddHodUni.TabStop = false;
            this.gpbAddHodUni.Text = "Adicionar Hospedes ou Unidade Habitacional";
            // 
            // lblSeleHosUni
            // 
            this.lblSeleHosUni.AutoSize = true;
            this.lblSeleHosUni.Location = new System.Drawing.Point(13, 22);
            this.lblSeleHosUni.Name = "lblSeleHosUni";
            this.lblSeleHosUni.Size = new System.Drawing.Size(238, 13);
            this.lblSeleHosUni.TabIndex = 32;
            this.lblSeleHosUni.Text = "Selecione Hospedes ou Unidades Habitacionais.";
            // 
            // pcbUnidade
            // 
            this.pcbUnidade.Cursor = System.Windows.Forms.Cursors.Default;
            this.pcbUnidade.Image = global::Hotel_Britania.Properties.Resources._1378621656_aiga_hotel_information_bg;
            this.pcbUnidade.Location = new System.Drawing.Point(16, 44);
            this.pcbUnidade.Name = "pcbUnidade";
            this.pcbUnidade.Size = new System.Drawing.Size(34, 36);
            this.pcbUnidade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbUnidade.TabIndex = 35;
            this.pcbUnidade.TabStop = false;
            // 
            // pcbHospede
            // 
            this.pcbHospede.Cursor = System.Windows.Forms.Cursors.Default;
            this.pcbHospede.Image = ((System.Drawing.Image)(resources.GetObject("pcbHospede.Image")));
            this.pcbHospede.Location = new System.Drawing.Point(262, 47);
            this.pcbHospede.Name = "pcbHospede";
            this.pcbHospede.Size = new System.Drawing.Size(32, 32);
            this.pcbHospede.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbHospede.TabIndex = 34;
            this.pcbHospede.TabStop = false;
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
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(11, 234);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 17);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Reserva?";
            this.checkBox1.UseVisualStyleBackColor = true;
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
            this.gpbCheck.ResumeLayout(false);
            this.gpbCheck.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHosUni)).EndInit();
            this.gpbAddHodUni.ResumeLayout(false);
            this.gpbAddHodUni.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUnidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbHospede)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbHospede;
        private System.Windows.Forms.GroupBox gpbCheck;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Label lblDataCheckIn;
        private System.Windows.Forms.DateTimePicker dtpDataCheckIn;
        private System.Windows.Forms.TextBox txtValorDiaria;
        private System.Windows.Forms.Label lblValorDiaria;
        private System.Windows.Forms.TextBox txtHospedes;
        private System.Windows.Forms.Label lblHospedes;
        private System.Windows.Forms.TextBox txtNumeroUni;
        private System.Windows.Forms.Label lblNumeroUni;
        private System.Windows.Forms.TextBox txtASK;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dataHosUni;
        private System.Windows.Forms.RadioButton radHos;
        private System.Windows.Forms.RadioButton radUniHab;
        private System.Windows.Forms.GroupBox gpbAddHodUni;
        private System.Windows.Forms.Label lblSeleHosUni;
        private System.Windows.Forms.PictureBox pcbUnidade;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}