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
    public partial class FrmCadastrarHospede : Form
    {
        public FrmCadastrarHospede()
        {
            InitializeComponent();
        }

        private void HabilitarCampos()
        {
            txtNome.Enabled = true;
            mktCPF.Enabled = true;
            dtpDataNascimento.Enabled = true;
            txtNaturalidade.Enabled = true;
            txtNacionalidade.Enabled = true;
            cboSexo.Enabled = true;
            cboUF.Enabled = true;
            mktTelefone.Enabled = true;
            txtEmail.Enabled = true;
        }

        private void DesabilitarCampos()
        {
            txtNome.Enabled = false;
            mktCPF.Enabled = false;
            dtpDataNascimento.Enabled = false;
            txtNaturalidade.Enabled = false;
            txtNacionalidade.Enabled = false;
            cboSexo.Enabled = false;
            cboUF.Enabled = false;
            mktTelefone.Enabled = false;
            txtEmail.Enabled = false;
        }

        //Metodo que Limpa todos os campos
        private void LimparCampos()
        {
            txtNome.Text = "";
            txtNaturalidade.Text = "";
            cboUF.Text = "";
            txtNacionalidade.Text = "Brasileira";
            mktCPF.Text = "";
            cboSexo.Text = "";
            dtpDataNascimento.Value = DateTime.Now;
            mktTelefone.Text = "";
            txtEmail.Text = "";
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            btnIncluir.Enabled = false;
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            DesabilitarCampos();

            dataGridView1.Enabled = true;

            btnIncluir.Enabled = true;
            btnSalvar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = false;
        }

        //Metodo Verifica Obrigatorios
        private bool VerificaObrigatorios()
        {
            //Verifica os campos obrigatorios
            if (txtNome.Text == "")
            {
                lblNome.Text = "Nome*";
            }
            else
            {
                lblNome.Text = "Nome:";
            }

            if (txtNaturalidade.Text == "")
            {
                lblNaturalidade.Text = "Naturalidade*";
                txtNaturalidade.Focus();
            }
            else
            {
                lblNaturalidade.Text = "Naturalidade:";
            }

            if (cboUF.Text == "")
            {
                lblUF.Text = "UF*";
                cboUF.Focus();
            }
            else
            {
                lblUF.Text = "UF:";
            }

            if (txtNacionalidade.Text == "")
            {
                lblNacionalidade.Text = "Nacionalidade*";
                txtNacionalidade.Focus();
            }
            else
            {
                lblNacionalidade.Text = "Nacionalidade:";
            }

            if (mktCPF.Text == "   .   .   -")
            {
                lblCPF.Text = "CPF*";
                mktCPF.Focus();
            }
            else
            {
                lblCPF.Text = "CPF:";
            }

            if (cboSexo.Text == "")
            {
                lblSexo.Text = "Sexo*";
                cboSexo.Focus();
            }
            else
            {
                lblSexo.Text = "Sexo:";
            }

            if (dtpDataNascimento.Value == DateTime.Now)
            {
                lblDataNascimento.Text = "Data de Nasc.*";
                dtpDataNascimento.Focus();
            }
            else
            {
                lblDataNascimento.Text = "Data de Nasc.:";
            }

            if (mktTelefone.Text == "(  ) -    -")
            {
                lblTelefone.Text = "DDD/Telefone*";
                mktTelefone.Focus();
            }
            else
            {
                lblTelefone.Text = "DDD/Telefone:";
            }

            if (txtEmail.Text == "")
            {
                lblEmail.Text = "E-Mail*";
                txtEmail.Focus();
            }
            else
            {
                lblEmail.Text = "E-Mail:";
            }//Fim do verifica campos obrigatorios

            //Verifica se todos os Campos foram preenchidos
            if (txtNome.Text == "" || txtNaturalidade.Text == "" || cboUF.Text == "" || txtNacionalidade.Text == "" || mktCPF.Text == "   .   .   -" || cboSexo.Text == "" || dtpDataNascimento.Value == DateTime.Now || mktTelefone.Text == "(  ) -    -    " || txtEmail.Text == "")
            {
                MessageBox.Show("Os campos com * são Obrigatorios", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (VerificaObrigatorios())
            {
                HospedeDal dados = new HospedeDal();
                HospedeBll entidade = new HospedeBll();

                entidade.NomeHos = txtNome.Text;
                entidade.NaturalidadeHos = txtNaturalidade.Text;
                entidade.UFHos = cboUF.Text;
                entidade.NacionalidadeHos = txtNacionalidade.Text;
                entidade.CPFHos = mktCPF.Text;
                entidade.SexoHos = cboSexo.Text;
                entidade.DataNascHos = dtpDataNascimento.Value;
                entidade.DDDTelefoneHos = mktTelefone.Text;
                entidade.EMail = txtEmail.Text;

                dados.Salvar(entidade);

                MessageBox.Show("Os dados foram salvos com sucesso!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimparCampos();
                DesabilitarCampos();
                btnIncluir.Enabled = true;
                btnSalvar.Enabled = false;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
                btnCancelar.Enabled = false;
            }
        }

        private void FrmCadastrarHospede_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'hotelBDDataSet.tbHospede'. Você pode movê-la ou removê-la conforme necessário.
            this.tbHospedeTableAdapter.Fill(this.hotelBDDataSet.tbHospede);

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DesabilitarCampos();

            txtNome.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtNaturalidade.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cboUF.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtNacionalidade.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            mktCPF.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            cboSexo.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            dtpDataNascimento.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[7].Value);
            mktTelefone.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();

            btnIncluir.Enabled = false;
            btnAlterar.Enabled = false;
            btnSalvar.Enabled = false;
            btnExcluir.Enabled = true;
            btnCancelar.Enabled = true;
            
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (VerificaObrigatorios())
            {
                HospedeDal dados = new HospedeDal();
                HospedeBll entidade = new HospedeBll();

                entidade.CodigoHos = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                entidade.NomeHos = txtNome.Text;
                entidade.NaturalidadeHos = txtNaturalidade.Text;
                entidade.UFHos = cboUF.Text;
                entidade.NacionalidadeHos = txtNacionalidade.Text;
                entidade.CPFHos = mktCPF.Text;
                entidade.SexoHos = cboSexo.Text;
                entidade.DataNascHos = dtpDataNascimento.Value;
                entidade.DDDTelefoneHos = mktTelefone.Text;
                entidade.EMail = txtEmail.Text;

                dados.Alterar(entidade);

                MessageBox.Show("Os dados foram salvos com sucesso!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimparCampos();
                DesabilitarCampos();
                dataGridView1.Enabled = true;
                btnIncluir.Enabled = true;
                btnSalvar.Enabled = false;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
                btnCancelar.Enabled = false;
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            HabilitarCampos();

            dataGridView1.Enabled = false;

            btnAlterar.Enabled = true;
            btnIncluir.Enabled = false;
            btnSalvar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            HospedeDal dados = new HospedeDal();
            HospedeBll entidade = new HospedeBll();

            entidade.CodigoHos = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            dados.Exclui(entidade.CodigoHos);

            MessageBox.Show("Os dados foram excuido com sucesso!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimparCampos();

            DesabilitarCampos();

            dataGridView1.Enabled = true;

            btnAlterar.Enabled = false;
            btnIncluir.Enabled = true;
            btnSalvar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = false;
        }
    }
}
