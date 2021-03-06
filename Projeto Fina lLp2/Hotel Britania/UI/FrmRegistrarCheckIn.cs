﻿using Hotel_Britania.BLL;
using Hotel_Britania.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Britania
{
    public partial class FrmRegistrarCheckIn : Form
    {
        CheckBll update = null;
        UnidadeHabitacionalBll unidade = null;
        HospedeBll hospede = null;

        public FrmRegistrarCheckIn()
        {
            InitializeComponent();
        }

        public FrmRegistrarCheckIn(CheckBll update)
        {
            InitializeComponent();

            this.update = update;
            this.unidade = new UnidadeHabitacionalDal().Obter(update.CodigoUni);
            this.hospede = new HospedeDal().Obter(update.CodigoHos);
            txtNomeUni.Text = hospede.NomeHos;
            txtValorDiaria.Text = unidade.ValorDiariaUni;
            dtpDataCheckIn.Value = update.DataCheckIn;
            dtpDataCheckOut.Value = update.DataCheckOut;
            txtHospede.Text = hospede.NomeHos;
            txtCpfHos.Text = hospede.CPFHos;
            cbbStatus.Text = update.StatusCk;
            // Difference in days, hours, and minutes.
            TimeSpan ts = update.DataCheckOut - update.DataCheckOut;
            // Difference in days.
            int differenceInDays = ts.Days;
            txtDespesas.Text = Convert.ToString(differenceInDays * Convert.ToDouble(unidade.ValorDiariaUni));


            btnSalvar.Text = "&Altera";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (VerificaObrigatorios())
            {
                CheckBll entidade = new CheckBll();
                CheckDal dados = new CheckDal();
                                
                entidade.StatusCk = cbbStatus.Text;
                entidade.DataCheckIn = dtpDataCheckIn.Value;
                entidade.DataCheckOut = dtpDataCheckOut.Value;
                if (update != null)
                {
                    entidade.CodigoHos = update.CodigoHos;
                    entidade.CodigoUni = update.CodigoUni;
                }
                else
                {
                    entidade.CodigoHos = Convert.ToInt32(dgvHospede.CurrentRow.Cells[0].Value);
                    entidade.CodigoUni = Convert.ToInt32(dgvUnidadeHabitacional.CurrentRow.Cells[0].Value);
                }
                    

                if (update != null)
                    dados.Alterar(entidade);
                else
                    dados.Salva(entidade);

                MessageBox.Show("Os dados foram salvos com sucesso!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        //Metodo que verifica campos obrigatorios
        private bool VerificaObrigatorios()
        {
            if (txtHospede.Text == "")
            {
                lblHospedes.Text = "Hóspede*";
                txtHospede.Focus();
            }
            else
            {
                lblHospedes.Text = "Hóspede:";
            }

            if (txtNomeUni.Text == "")
            {
                lblNomeUni.Text = "Nome da Unidade Habitacional*";
                txtNomeUni.Focus();
            }
            else
            {
                lblNomeUni.Text = "Nome da Unidade Habitacional:";
            }

            if (txtValorDiaria.Text == "")
            {
                lblValorDiaria.Text = "Valor da Diária*";
                txtValorDiaria.Focus();
            }
            else
            {
                lblValorDiaria.Text = "Valor da Diária:";
            }

            if (dtpDataCheckIn.Value == null)
            {
                lblDataCheckIn.Text = "Data do Check-In*";
                dtpDataCheckIn.Focus();
            }
            else
            {
                lblDataCheckIn.Text = "Data do Check-In:";
            }

            if (dtpDataCheckOut.Value == null)
            {
                lblDataCheckOut.Text = "Data prevista para Check-Out*";
                dtpDataCheckOut.Focus();
            }
            else
            {
                lblDataCheckOut.Text = "Data prevista para Check-Out:";
            }

            //IF Verifica se todos os Campos foram preenchidos 
            if (txtHospede.Text == "" || txtNomeUni.Text == "" || txtValorDiaria.Text == "" || dtpDataCheckIn.Value == null || dtpDataCheckOut.Value == null)
            {
                MessageBox.Show("Os campos com * são Obrigatorios", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }


        } //Fim do Metodo que verifica campos obrigatorios

        private void LimparCampos()
        {
            txtNomeUni.Text = null;
            txtValorDiaria.Text = null;
            dtpDataCheckIn.Value = DateTime.Now;
            dtpDataCheckOut.Value = DateTime.Now;
            txtHospede.Text = null;
            txtCpfHos.Text = null;
            cbbStatus.Text = null;
            txtDespesas.Text = null;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmRegistrarCheckIn_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'hotelBDDataSet.tbUnidadeHabitacional'. Você pode movê-la ou removê-la conforme necessário.
            this.tbUnidadeHabitacionalTableAdapter.Fill(this.hotelBDDataSet.tbUnidadeHabitacional);
            // TODO: esta linha de código carrega dados na tabela 'hotelBDDataSet.tbHospede'. Você pode movê-la ou removê-la conforme necessário.
            this.tbHospedeTableAdapter.Fill(this.hotelBDDataSet.tbHospede);

        }

        private void dgvUnidadeHabitacional_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtNomeUni.Text = dgvUnidadeHabitacional.CurrentRow.Cells[2].Value.ToString();
            txtValorDiaria.Text = dgvUnidadeHabitacional.CurrentRow.Cells[3].Value.ToString();
            
        }

        private void dgvHospede_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtHospede.Text = dgvHospede.CurrentRow.Cells[1].Value.ToString();
            txtCpfHos.Text = dgvHospede.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
