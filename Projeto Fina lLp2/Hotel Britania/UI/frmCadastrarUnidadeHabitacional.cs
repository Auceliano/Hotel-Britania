using Hotel_Britania.BLL;
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
    public partial class FrmCadastrarUnidadeHabitacional : Form
    {
        public FrmCadastrarUnidadeHabitacional()
        {
            InitializeComponent();
        }

        private void FrmCadastrarUnidadeHabitacional_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'hotelBDDataSet.tbUnidadeHabitacional'. Você pode movê-la ou removê-la conforme necessário.
            this.tbUnidadeHabitacionalTableAdapter.Fill(this.hotelBDDataSet.tbUnidadeHabitacional);
        }

        //Metodo que verifica campos obrigatorios
        private bool VerificaObrigatorios()
        {
            if (txtNome.Text == "")
            {
                lblNomeUni.Text = "Nome*";
                txtNome.Focus();
            }
            else
            {
                lblNomeUni.Text = "Nome:";
            }

            if (txtNumero.Text == "")
            {
                lblNumeroUni.Text = "Número*";
                txtNumero.Focus();
            }
            else
            {
                lblNumeroUni.Text = "Número:";
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

            if (txtDescricao.Text == "")
            {
                lblDescricao.Text = "Descrição*";
                txtDescricao.Focus();
            }
            else
            {
                lblDescricao.Text = "Descrição:";
            }

            //IF Verifica se todos os Campos foram preenchidos 
            if (txtNome.Text == "" || txtNumero.Text == "" || txtValorDiaria.Text == "" || txtDescricao.Text == "")
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
            txtNome.Text = null;
            txtNumero.Text = null;
            txtValorDiaria.Text = null;
            txtDescricao.Text = null;
            ckbSuiteMaried.Checked = false;
            ckbSuiteSingle.Checked = false;
            ckbDuasCamas.Checked = false;
            ckbClimatizador.Checked = false;
            ckbFrigobar.Checked = false;
            ckbWireless.Checked = false;
        }

        private void HabilitarCampos(bool status)
        {
            txtNome.Enabled = status;
            txtNumero.Enabled = status;
            txtValorDiaria.Enabled = status;
            txtDescricao.Enabled = status;
            ckbSuiteMaried.Enabled = status;
            ckbSuiteSingle.Enabled = status;
            ckbDuasCamas.Enabled = status;
            ckbClimatizador.Enabled = status;
            ckbFrigobar.Enabled = status;
            ckbWireless.Enabled = status;
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            HabilitarCampos(true);

            btnIncluir.Enabled = false;
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnCancelar.Enabled = true;

            dataGridView1.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (VerificaObrigatorios())
            {
                UnidadeHabitacionalDal dados = new UnidadeHabitacionalDal();
                UnidadeHabitacionalBll entidade = new UnidadeHabitacionalBll();
                entidade.NomeUni = txtNome.Text;
                entidade.NumeroUni = txtNumero.Text;
                entidade.ValorDiariaUni = txtValorDiaria.Text;
                entidade.DescricaoUni = txtDescricao.Text;
                entidade.SuiteMarried = ckbSuiteMaried.Checked;
                entidade.SuiteSingle = ckbSuiteSingle.Checked;
                entidade.DuasCamas = ckbDuasCamas.Checked;
                entidade.Climatizador = ckbClimatizador.Checked;
                entidade.Frigobar = ckbFrigobar.Checked;
                entidade.Wireless = ckbWireless.Checked;

                dados.Salva(entidade);

                MessageBox.Show("Os dados foram salvos com sucesso!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimparCampos();
                HabilitarCampos(false);

                btnIncluir.Enabled = true;
                btnSalvar.Enabled = false;
                btnAlterar.Enabled = false;
                btnCancelar.Enabled = false;

                dataGridView1.Enabled = true;

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            HabilitarCampos(false);

            dataGridView1.Enabled = true;

            btnIncluir.Enabled = true;
            btnSalvar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (VerificaObrigatorios())
            {
                UnidadeHabitacionalDal dados = new UnidadeHabitacionalDal();
                UnidadeHabitacionalBll entidade = new UnidadeHabitacionalBll();

                entidade.Codigo = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                entidade.NomeUni = txtNome.Text;
                entidade.NumeroUni = txtNumero.Text;
                entidade.ValorDiariaUni = txtValorDiaria.Text;
                entidade.DescricaoUni = txtDescricao.Text;
                entidade.SuiteMarried = ckbSuiteMaried.Checked;
                entidade.SuiteSingle = ckbSuiteSingle.Checked;
                entidade.DuasCamas = ckbDuasCamas.Checked;
                entidade.Climatizador = ckbClimatizador.Checked;
                entidade.Frigobar = ckbFrigobar.Checked;
                entidade.Wireless = ckbWireless.Checked;

                dados.Altera(entidade);

                MessageBox.Show("Os dados foram atualizados com sucesso!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimparCampos();

                btnIncluir.Enabled = true;
                btnSalvar.Enabled = false;
                btnAlterar.Enabled = false;
                btnCancelar.Enabled = false;

                dataGridView1.Enabled = true;

            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            HabilitarCampos(false);

            txtNome.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtNumero.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtValorDiaria.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtDescricao.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            ckbSuiteMaried.Checked = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[5].Value);
            ckbSuiteSingle.Checked = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[6].Value);
            ckbDuasCamas.Checked = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[7].Value);
            ckbClimatizador.Checked = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[8].Value);
            ckbFrigobar.Checked = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[9].Value);
            ckbWireless.Checked = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[10].Value);

            btnIncluir.Enabled = false;
            btnAlterar.Enabled = false;
            btnSalvar.Enabled = false;
            btnExcluir.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            HabilitarCampos(true);

            dataGridView1.Enabled = false;

            btnAlterar.Enabled = true;
            btnIncluir.Enabled = false;
            btnSalvar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza que quer apagar os dados da Unidade Habitacional?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                UnidadeHabitacionalDal dados = new UnidadeHabitacionalDal();
                dados.Exclui(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                HabilitarCampos(false);
                LimparCampos();
                btnIncluir.Enabled = true;
                btnSalvar.Enabled = false;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
                btnCancelar.Enabled = false;
                dataGridView1.Enabled = true;
                MessageBox.Show("Dados apagados com, sucesso?", "ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}