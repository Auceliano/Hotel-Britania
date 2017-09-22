namespace Hotel_Britania
{
    partial class FrmCheckOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCheckOut));
            this.lblNovoHospede = new System.Windows.Forms.Label();
            this.pcbFuncionario = new System.Windows.Forms.PictureBox();
            this.gpbPesquisa = new System.Windows.Forms.GroupBox();
            this.btnBuscaAvancada = new System.Windows.Forms.Button();
            this.btnBuscaRapida = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.lblNomePesquisa = new System.Windows.Forms.Label();
            this.txtPesquisaRapida = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.gpbRegistrosCheckIn = new System.Windows.Forms.GroupBox();
            this.dataCheckIn = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFuncionario)).BeginInit();
            this.gpbPesquisa.SuspendLayout();
            this.gpbRegistrosCheckIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCheckIn)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNovoHospede
            // 
            this.lblNovoHospede.AutoSize = true;
            this.lblNovoHospede.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNovoHospede.Location = new System.Drawing.Point(12, 9);
            this.lblNovoHospede.Name = "lblNovoHospede";
            this.lblNovoHospede.Size = new System.Drawing.Size(108, 13);
            this.lblNovoHospede.TabIndex = 44;
            this.lblNovoHospede.Text = "Registros Check-Out.";
            // 
            // pcbFuncionario
            // 
            this.pcbFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbFuncionario.Image = global::Hotel_Britania.Properties.Resources._1379623049_put_out;
            this.pcbFuncionario.Location = new System.Drawing.Point(55, 30);
            this.pcbFuncionario.Name = "pcbFuncionario";
            this.pcbFuncionario.Size = new System.Drawing.Size(32, 32);
            this.pcbFuncionario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFuncionario.TabIndex = 45;
            this.pcbFuncionario.TabStop = false;
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
            this.gpbPesquisa.Location = new System.Drawing.Point(128, 9);
            this.gpbPesquisa.Name = "gpbPesquisa";
            this.gpbPesquisa.Size = new System.Drawing.Size(637, 204);
            this.gpbPesquisa.TabIndex = 46;
            this.gpbPesquisa.TabStop = false;
            this.gpbPesquisa.Text = "Pesquisa";
            // 
            // btnBuscaAvancada
            // 
            this.btnBuscaAvancada.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaAvancada.Image")));
            this.btnBuscaAvancada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscaAvancada.Location = new System.Drawing.Point(377, 30);
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
            this.btnAnterior.Location = new System.Drawing.Point(458, 30);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(32, 32);
            this.btnAnterior.TabIndex = 3;
            this.btnAnterior.UseVisualStyleBackColor = true;
            // 
            // btnProximo
            // 
            this.btnProximo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProximo.BackgroundImage")));
            this.btnProximo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProximo.Location = new System.Drawing.Point(491, 30);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(32, 32);
            this.btnProximo.TabIndex = 4;
            this.btnProximo.UseVisualStyleBackColor = true;
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
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(174, 317);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 49;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnInserir
            // 
            this.btnInserir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnInserir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInserir.Location = new System.Drawing.Point(12, 317);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 47;
            this.btnInserir.Text = "&Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Location = new System.Drawing.Point(576, 317);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 50;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.Enabled = false;
            this.btnAlterar.Location = new System.Drawing.Point(93, 317);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 48;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // gpbRegistrosCheckIn
            // 
            this.gpbRegistrosCheckIn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbRegistrosCheckIn.Controls.Add(this.dataCheckIn);
            this.gpbRegistrosCheckIn.Location = new System.Drawing.Point(-1, 77);
            this.gpbRegistrosCheckIn.Name = "gpbRegistrosCheckIn";
            this.gpbRegistrosCheckIn.Size = new System.Drawing.Size(664, 234);
            this.gpbRegistrosCheckIn.TabIndex = 51;
            this.gpbRegistrosCheckIn.TabStop = false;
            this.gpbRegistrosCheckIn.Text = "Registros";
            // 
            // dataCheckIn
            // 
            this.dataCheckIn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataCheckIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCheckIn.Location = new System.Drawing.Point(13, 19);
            this.dataCheckIn.Name = "dataCheckIn";
            this.dataCheckIn.Size = new System.Drawing.Size(639, 209);
            this.dataCheckIn.TabIndex = 0;
            // 
            // FrmCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 352);
            this.Controls.Add(this.lblNovoHospede);
            this.Controls.Add(this.pcbFuncionario);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.gpbRegistrosCheckIn);
            this.Controls.Add(this.gpbPesquisa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCheckOut";
            this.Text = "Check-Out";
            ((System.ComponentModel.ISupportInitialize)(this.pcbFuncionario)).EndInit();
            this.gpbPesquisa.ResumeLayout(false);
            this.gpbPesquisa.PerformLayout();
            this.gpbRegistrosCheckIn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataCheckIn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNovoHospede;
        private System.Windows.Forms.PictureBox pcbFuncionario;
        private System.Windows.Forms.GroupBox gpbPesquisa;
        protected System.Windows.Forms.Button btnBuscaAvancada;
        protected System.Windows.Forms.Button btnBuscaRapida;
        protected System.Windows.Forms.Button btnAnterior;
        protected System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Label lblNomePesquisa;
        private System.Windows.Forms.TextBox txtPesquisaRapida;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.GroupBox gpbRegistrosCheckIn;
        private System.Windows.Forms.DataGridView dataCheckIn;
    }
}