﻿namespace Hotel_Britania
{
    partial class FrmRegistrarCheckOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistrarCheckOut));
            this.gpbCheck = new System.Windows.Forms.GroupBox();
            this.lblHospedes = new System.Windows.Forms.Label();
            this.dtpDataCheckOut = new System.Windows.Forms.DateTimePicker();
            this.lblDataCheckOut = new System.Windows.Forms.Label();
            this.lblNUni = new System.Windows.Forms.Label();
            this.dataDispesas = new System.Windows.Forms.DataGridView();
            this.txtNUni = new System.Windows.Forms.TextBox();
            this.lblDespesas = new System.Windows.Forms.Label();
            this.txtNomeUni = new System.Windows.Forms.TextBox();
            this.lblNomeUni = new System.Windows.Forms.Label();
            this.txtNUnidade = new System.Windows.Forms.TextBox();
            this.lblNUnidade = new System.Windows.Forms.Label();
            this.txtNomeHos = new System.Windows.Forms.TextBox();
            this.lblNomeHos = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gpbBuscaCheckIn = new System.Windows.Forms.GroupBox();
            this.dataBusCheck = new System.Windows.Forms.DataGridView();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.gpbCheck.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDispesas)).BeginInit();
            this.gpbBuscaCheckIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBusCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbCheck
            // 
            this.gpbCheck.Controls.Add(this.textBox2);
            this.gpbCheck.Controls.Add(this.label1);
            this.gpbCheck.Controls.Add(this.textBox1);
            this.gpbCheck.Controls.Add(this.lblHospedes);
            this.gpbCheck.Controls.Add(this.dtpDataCheckOut);
            this.gpbCheck.Controls.Add(this.lblDataCheckOut);
            this.gpbCheck.Controls.Add(this.lblNUni);
            this.gpbCheck.Controls.Add(this.dataDispesas);
            this.gpbCheck.Controls.Add(this.txtNUni);
            this.gpbCheck.Controls.Add(this.lblDespesas);
            this.gpbCheck.Controls.Add(this.txtNomeUni);
            this.gpbCheck.Controls.Add(this.lblNomeUni);
            this.gpbCheck.Location = new System.Drawing.Point(12, 12);
            this.gpbCheck.Name = "gpbCheck";
            this.gpbCheck.Size = new System.Drawing.Size(276, 292);
            this.gpbCheck.TabIndex = 42;
            this.gpbCheck.TabStop = false;
            this.gpbCheck.Text = "Check";
            // 
            // lblHospedes
            // 
            this.lblHospedes.AutoSize = true;
            this.lblHospedes.Location = new System.Drawing.Point(9, 116);
            this.lblHospedes.Name = "lblHospedes";
            this.lblHospedes.Size = new System.Drawing.Size(58, 13);
            this.lblHospedes.TabIndex = 23;
            this.lblHospedes.Text = "Hóspedes:";
            // 
            // dtpDataCheckOut
            // 
            this.dtpDataCheckOut.Enabled = false;
            this.dtpDataCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataCheckOut.Location = new System.Drawing.Point(12, 89);
            this.dtpDataCheckOut.Name = "dtpDataCheckOut";
            this.dtpDataCheckOut.Size = new System.Drawing.Size(253, 20);
            this.dtpDataCheckOut.TabIndex = 2;
            this.dtpDataCheckOut.Value = new System.DateTime(2013, 11, 2, 0, 0, 0, 0);
            // 
            // lblDataCheckOut
            // 
            this.lblDataCheckOut.AutoSize = true;
            this.lblDataCheckOut.Location = new System.Drawing.Point(9, 70);
            this.lblDataCheckOut.Name = "lblDataCheckOut";
            this.lblDataCheckOut.Size = new System.Drawing.Size(102, 13);
            this.lblDataCheckOut.TabIndex = 21;
            this.lblDataCheckOut.Text = "Data do Check-Out:";
            // 
            // lblNUni
            // 
            this.lblNUni.AutoSize = true;
            this.lblNUni.Location = new System.Drawing.Point(185, 22);
            this.lblNUni.Name = "lblNUni";
            this.lblNUni.Size = new System.Drawing.Size(83, 13);
            this.lblNUni.TabIndex = 20;
            this.lblNUni.Text = "Nº. da Unidade:";
            // 
            // dataDispesas
            // 
            this.dataDispesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDispesas.Location = new System.Drawing.Point(11, 202);
            this.dataDispesas.Name = "dataDispesas";
            this.dataDispesas.Size = new System.Drawing.Size(254, 79);
            this.dataDispesas.TabIndex = 3;
            // 
            // txtNUni
            // 
            this.txtNUni.Enabled = false;
            this.txtNUni.Location = new System.Drawing.Point(187, 42);
            this.txtNUni.Name = "txtNUni";
            this.txtNUni.Size = new System.Drawing.Size(78, 20);
            this.txtNUni.TabIndex = 1;
            // 
            // lblDespesas
            // 
            this.lblDespesas.AutoSize = true;
            this.lblDespesas.Location = new System.Drawing.Point(9, 186);
            this.lblDespesas.Name = "lblDespesas";
            this.lblDespesas.Size = new System.Drawing.Size(57, 13);
            this.lblDespesas.TabIndex = 10;
            this.lblDespesas.Text = "Despesas:";
            // 
            // txtNomeUni
            // 
            this.txtNomeUni.Enabled = false;
            this.txtNomeUni.Location = new System.Drawing.Point(11, 42);
            this.txtNomeUni.MaxLength = 6;
            this.txtNomeUni.Name = "txtNomeUni";
            this.txtNomeUni.Size = new System.Drawing.Size(160, 20);
            this.txtNomeUni.TabIndex = 0;
            // 
            // lblNomeUni
            // 
            this.lblNomeUni.AutoSize = true;
            this.lblNomeUni.Location = new System.Drawing.Point(8, 22);
            this.lblNomeUni.Name = "lblNomeUni";
            this.lblNomeUni.Size = new System.Drawing.Size(158, 13);
            this.lblNomeUni.TabIndex = 2;
            this.lblNomeUni.Text = "Nome da Unidade Habitacional:";
            // 
            // txtNUnidade
            // 
            this.txtNUnidade.Location = new System.Drawing.Point(319, 54);
            this.txtNUnidade.Name = "txtNUnidade";
            this.txtNUnidade.Size = new System.Drawing.Size(83, 20);
            this.txtNUnidade.TabIndex = 2;
            // 
            // lblNUnidade
            // 
            this.lblNUnidade.AutoSize = true;
            this.lblNUnidade.Location = new System.Drawing.Point(316, 34);
            this.lblNUnidade.Name = "lblNUnidade";
            this.lblNUnidade.Size = new System.Drawing.Size(83, 13);
            this.lblNUnidade.TabIndex = 44;
            this.lblNUnidade.Text = "Nº. da Unidade:";
            // 
            // txtNomeHos
            // 
            this.txtNomeHos.Location = new System.Drawing.Point(17, 54);
            this.txtNomeHos.Name = "txtNomeHos";
            this.txtNomeHos.Size = new System.Drawing.Size(296, 20);
            this.txtNomeHos.TabIndex = 0;
            // 
            // lblNomeHos
            // 
            this.lblNomeHos.AutoSize = true;
            this.lblNomeHos.Location = new System.Drawing.Point(14, 34);
            this.lblNomeHos.Name = "lblNomeHos";
            this.lblNomeHos.Size = new System.Drawing.Size(99, 13);
            this.lblNomeHos.TabIndex = 40;
            this.lblNomeHos.Text = "Nome do Hóspede:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(408, 54);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // gpbBuscaCheckIn
            // 
            this.gpbBuscaCheckIn.Controls.Add(this.txtNUnidade);
            this.gpbBuscaCheckIn.Controls.Add(this.lblNUnidade);
            this.gpbBuscaCheckIn.Controls.Add(this.txtNomeHos);
            this.gpbBuscaCheckIn.Controls.Add(this.lblNomeHos);
            this.gpbBuscaCheckIn.Controls.Add(this.btnBuscar);
            this.gpbBuscaCheckIn.Controls.Add(this.dataBusCheck);
            this.gpbBuscaCheckIn.Location = new System.Drawing.Point(294, 12);
            this.gpbBuscaCheckIn.Name = "gpbBuscaCheckIn";
            this.gpbBuscaCheckIn.Size = new System.Drawing.Size(489, 292);
            this.gpbBuscaCheckIn.TabIndex = 43;
            this.gpbBuscaCheckIn.TabStop = false;
            this.gpbBuscaCheckIn.Text = "Buscar por Check-In";
            // 
            // dataBusCheck
            // 
            this.dataBusCheck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBusCheck.Location = new System.Drawing.Point(6, 89);
            this.dataBusCheck.Name = "dataBusCheck";
            this.dataBusCheck.Size = new System.Drawing.Size(477, 192);
            this.dataBusCheck.TabIndex = 4;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Location = new System.Drawing.Point(12, 310);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 40;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Location = new System.Drawing.Point(708, 310);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 41;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(11, 132);
            this.textBox1.MaxLength = 6;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(254, 20);
            this.textBox1.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "CPF:";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(44, 158);
            this.textBox2.MaxLength = 6;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(221, 20);
            this.textBox2.TabIndex = 26;
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(159, 310);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(129, 23);
            this.btnRemover.TabIndex = 44;
            this.btnRemover.Text = "&Limpar Campos";
            this.btnRemover.UseVisualStyleBackColor = true;
            // 
            // FrmRegistrarCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 343);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.gpbCheck);
            this.Controls.Add(this.gpbBuscaCheckIn);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRegistrarCheckOut";
            this.Text = "Registrar Check-Out";
            this.gpbCheck.ResumeLayout(false);
            this.gpbCheck.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDispesas)).EndInit();
            this.gpbBuscaCheckIn.ResumeLayout(false);
            this.gpbBuscaCheckIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBusCheck)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gpbCheck;
        private System.Windows.Forms.Label lblHospedes;
        private System.Windows.Forms.DateTimePicker dtpDataCheckOut;
        private System.Windows.Forms.Label lblDataCheckOut;
        private System.Windows.Forms.Label lblNUni;
        private System.Windows.Forms.DataGridView dataDispesas;
        private System.Windows.Forms.TextBox txtNUni;
        private System.Windows.Forms.Label lblDespesas;
        private System.Windows.Forms.TextBox txtNomeUni;
        private System.Windows.Forms.Label lblNomeUni;
        private System.Windows.Forms.TextBox txtNUnidade;
        private System.Windows.Forms.Label lblNUnidade;
        private System.Windows.Forms.TextBox txtNomeHos;
        private System.Windows.Forms.Label lblNomeHos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox gpbBuscaCheckIn;
        private System.Windows.Forms.DataGridView dataBusCheck;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnRemover;
    }
}