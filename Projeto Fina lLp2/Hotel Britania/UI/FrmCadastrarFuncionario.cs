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
    public partial class FrmCadastrarFuncionario : Form
    {
        public FrmCadastrarFuncionario()
        {
            InitializeComponent();
        }

        //Verifica todos os campos se ckbPermitirLogin.Checked ou NoChecked
        private bool VerificaObriChecked()
        {

            if (ckbPermitirLogin.Checked)
            {
                //Verificãção dos campos obrigatorios do usuario 
                if (txtUsuario.Text == "")
                {
                    lblUsuario.Text = "Usuário*";
                    txtUsuario.Focus();
                }
                else
                {
                    lblUsuario.Text = "Usuário:";
                }


                if (txtSenha.Text == "")
                {
                    lblSenha.Text = "Senha*";
                    txtSenha.Focus();
                }
                else
                {
                    lblSenha.Text = "Senha:";
                }

                if (txtConfirmar.Text == "")
                {
                    lblConfirmar.Text = "Confirmar*";
                    txtConfirmar.Focus();
                }
                else
                {
                    lblConfirmar.Text = "Confirmar:";
                }

            }

            //Verificação dos campos obrigatorios
            if (txtNome.Text == "")
            {
                lblNome.Text = "Nome*";
                txtNome.Focus();
            }
            else
            {
                lblNome.Text = "Nome:";
            }

            if (txtCargo.Text == "")
            {
                lblCargo.Text = "Cargo*";
                txtCargo.Focus();
            }
            else
            {
                lblCargo.Text = "Cargo:";
            }

            if (txtSalario.Text == "")
            {
                lblSalario.Text = "Salário*";
                txtSalario.Focus();
            }
            else
            {
                lblSalario.Text = "Salario:";
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
                lblSexo.Text = "Sexo";
            }

            if (dtpDataNascimento.Value == DateTime.Now)
            {
                lblDataNascimento.Text = "Data de Nascimento*";
                dtpDataNascimento.Focus();
            }
            else
            {
                lblDataNascimento.Text = "Data de Nascimento:";
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
            }
            //Fim da verificação dos campos obrigatorios


            if (ckbPermitirLogin.Checked)
            {

                //If Verifica se todos os campos estam preenchidos, se ckbPermitirLogin.Checked e retorna verdadeiro ou falso.
                if (txtSenha.Text.Length < 6 || txtSenha.Text != txtConfirmar.Text || txtUsuario.Text == "" || txtSenha.Text == "" || txtConfirmar.Text == "" || txtNome.Text == "" || txtCargo.Text == "" || txtSalario.Text == "" || txtNaturalidade.Text == "" || cboUF.Text == "" || txtNaturalidade.Text == "" || mktCPF.Text == "   .   .   -" || cboSexo.Text == "" || dtpDataNascimento.Value == DateTime.Now || mktTelefone.Text == "(  ) -    -" || txtEmail.Text == "")
                {
                    if (txtSenha.Text.Length < 6 || txtSenha.Text != txtConfirmar.Text)
                    {
                        MessageBox.Show("A senha não confere, mínimo de 6 caracteres! Digite novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        MessageBox.Show("Os campos com * são Obrigatorios.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                    return false;
                }
                else
                {
                    return true;
                }

            }
            else
            {

                //If Verifica se todos os campos estam preenchidos e retorna verdadeiro ou falso.
                if (txtNome.Text == "" || txtCargo.Text == "" || txtSalario.Text == "" || txtNaturalidade.Text == "" || cboUF.Text == "" || txtNaturalidade.Text == "" || mktCPF.Text == "   .   .   -" || cboSexo.Text == "" || dtpDataNascimento.Value == DateTime.Now || mktTelefone.Text == "(  ) -    -" || txtEmail.Text == "")
                {

                    MessageBox.Show("Os campos com * são Obrigatorios.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    return true;
                }

            }
        }

        //Método que limpa todos os campos
        private void limparCampos()
        {
            txtNome.Text = "";
            txtCargo.Text = "";
            txtUsuario.Text = null;
            txtSenha.Text = null;
            txtConfirmar.Text = null;
            txtSalario.Text = "";
            dtpDataEntrada.Value = DateTime.Now; ;
            txtNaturalidade.Text = "";
            cboUF.Text = "";
            txtNacionalidade.Text = "Brasileira";
            mktCPF.Text = "";
            cboSexo.Text = "";
            dtpDataNascimento.Value = DateTime.Now;
            txtEmail.Text = "";
            mktTelefone.Text = "";
        }

        //Método que Habilita os Campos
        private void HabilitarCampos()
        {
            ckbPermitirLogin.Enabled = true;
            
            txtNome.Enabled = true;
            txtCargo.Enabled = true;


            txtSalario.Enabled = true;
            dtpDataEntrada.Enabled = true;
            txtNaturalidade.Enabled = true;
            cboUF.Enabled = true;
            txtNacionalidade.Enabled = true;
            mktCPF.Enabled = true;
            cboSexo.Enabled = true;
            dtpDataNascimento.Enabled = true;
            txtEmail.Enabled = true;
            mktTelefone.Enabled = true;
        }

        

    //Método que Desabilita os campos
    private void desabilitarCampos()
        {
           
           

            txtUsuario.Enabled = false;
            txtSenha.Enabled = false;
            txtConfirmar.Enabled = false;

            ckbPermitirLogin.Checked = false;
            ckbPermitirLogin.Enabled = false;
            txtNome.Enabled = false;
            txtCargo.Enabled = false;
            txtSalario.Enabled = false;
            dtpDataEntrada.Enabled = false;
            txtNaturalidade.Enabled = false;
            cboUF.Enabled = false;
            txtNacionalidade.Enabled = false;
            mktCPF.Enabled = false;
            cboSexo.Enabled = false;
            dtpDataNascimento.Enabled = false;
            txtEmail.Enabled = false;
            mktTelefone.Enabled = false;

        }

        //Método corrige as Labels
        private void corrigeLabels()
        {

            lblUsuario.Text = "Usuário:";
            lblSenha.Text = "Senha:";
            lblConfirmar.Text = "Confirmar:";
            lblNome.Text = "Nome:";
            lblCargo.Text = "Cargo:";
            lblSalario.Text = "Salario:";
            lblNaturalidade.Text = "Naturalidade:";
            lblUF.Text = "UF:";
            lblNacionalidade.Text = "Nacionalidade:";
            lblCPF.Text = "CPF:";
            lblSexo.Text = "Sexo";
            lblDataNascimento.Text = "Data de Nascimento:";
            lblTelefone.Text = "DDD/Telefone:";
            lblEmail.Text = "E-Mail:";

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnIncluir.Enabled = false;
            dataGridView1.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            corrigeLabels();
            desabilitarCampos();
            limparCampos();
            btnSalvar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = false;
            btnIncluir.Enabled = true;
            dataGridView1.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (VerificaObriChecked())
            {

                FuncionarioDal dados = new FuncionarioDal();
                FuncionarioBll entidade = new FuncionarioBll();


                entidade.NomeFun = txtNome.Text;
                entidade.CargoFun = txtCargo.Text;
                entidade.UsuarioFun = txtUsuario.Text;
                entidade.SenhaFun = txtSenha.Text;
                entidade.SalarioFun = txtSalario.Text;
                entidade.DataEntradaFun = dtpDataEntrada.Value;
                entidade.NaturalidadeFun = txtNaturalidade.Text;
                entidade.UFFun = cboUF.Text;
                entidade.NacionalidadeFun = txtNacionalidade.Text;
                entidade.CPFFun = mktCPF.Text;
                entidade.SexoFun = cboSexo.Text;
                entidade.DataNasFun = dtpDataNascimento.Value;
                entidade.EMailFun = txtEmail.Text;
                entidade.DDDTelefoneFun = mktTelefone.Text;

                dados.Salva(entidade);

                MessageBox.Show("Os dados foram salvos com sucesso!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

                limparCampos();
                desabilitarCampos();
                btnIncluir.Enabled = true;
                btnSalvar.Enabled = false;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
                btnCancelar.Enabled = false;
                dataGridView1.Enabled = true;
            }
        }

        private void FrmCadastrarFuncionario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'hotelBDDataSet.tbFuncionario'. Você pode movê-la ou removê-la conforme necessário.
            this.tbFuncionarioTableAdapter.Fill(this.hotelBDDataSet.tbFuncionario);

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza que quer apagar os dados do Funcionário?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                FuncionarioDal dados = new FuncionarioDal();
                dados.Exclui(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                desabilitarCampos();
                limparCampos();
                btnIncluir.Enabled = true;
                btnSalvar.Enabled = false;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
                btnCancelar.Enabled = false;
                dataGridView1.Enabled = true;
                MessageBox.Show("Dados apagados com, sucesso?", "ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza que quer alterar os dados do Funcionário?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                if (VerificaObriChecked())
                {

                    FuncionarioDal dados = new FuncionarioDal();
                    FuncionarioBll entidade = new FuncionarioBll();

                    if (txtUsuario.Text != "")
                    {
                        ckbPermitirLogin.Checked = true;
                    }
                    else
                    {
                        ckbPermitirLogin.Checked = false;
                    }


                    entidade.CodigoFun = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    entidade.NomeFun = txtNome.Text;
                    entidade.CargoFun = txtCargo.Text;
                    entidade.UsuarioFun = txtUsuario.Text;
                    entidade.SenhaFun = txtSenha.Text;
                    entidade.SalarioFun = txtSalario.Text;
                    entidade.DataEntradaFun = dtpDataEntrada.Value;
                    entidade.NaturalidadeFun = txtNaturalidade.Text;
                    entidade.UFFun = cboUF.Text;
                    entidade.NacionalidadeFun = txtNacionalidade.Text;
                    entidade.CPFFun = mktCPF.Text;
                    entidade.SexoFun = cboSexo.Text;
                    entidade.DataNasFun = dtpDataNascimento.Value;
                    entidade.EMailFun = txtEmail.Text;
                    entidade.DDDTelefoneFun = mktTelefone.Text;

                    dados.Altera(entidade);

                    MessageBox.Show("Os dados foram salvos com sucesso!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    limparCampos();
                    desabilitarCampos();
                    btnIncluir.Enabled = true;
                    btnSalvar.Enabled = false;
                    btnAlterar.Enabled = false;
                    btnExcluir.Enabled = false;
                    btnCancelar.Enabled = false;
                    dataGridView1.Enabled = true;
                }
            }
            }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            desabilitarCampos();

            btnIncluir.Enabled = false;
            btnSalvar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = true;
            btnCancelar.Enabled = true;

            txtNome.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtNaturalidade.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cboUF.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtNacionalidade.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            mktCPF.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            cboSexo.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            dtpDataNascimento.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[7].Value);
            mktTelefone.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            dtpDataEntrada.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[10].Value);
            txtCargo.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            txtUsuario.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            txtSenha.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            txtConfirmar.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            txtSalario.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            HabilitarCampos();

            if(dataGridView1.CurrentRow.Cells[12].Value.ToString() != null)
                ckbPermitirLogin.Checked = true;

            dataGridView1.Enabled = false;

            btnAlterar.Enabled = true;
            btnIncluir.Enabled = false;
            btnSalvar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;
        }

        //Permitir ou Não Cadastrar Usuario e Senha Para do Sistema ao Usuário. 
        private void ckbPermitirLogin_CheckedChanged_1(object sender, EventArgs e)
        {            
            if (ckbPermitirLogin.Checked)
            {
                txtUsuario.Enabled = true;
                txtSenha.Enabled = true;
                txtConfirmar.Enabled = true;
            }
            else
            {
                txtUsuario.Enabled = false;
                txtUsuario.Text = null;
                txtSenha.Enabled = false;
                txtSenha.Text = null;
                txtConfirmar.Enabled = false;
                txtConfirmar.Text = null;
            }
        }
    }
}
