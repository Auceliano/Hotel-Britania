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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private Boolean bloquear = true;

        public Boolean getBloquear() {
            return bloquear;
        }
              
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text == "" && txtUsuario.Text == "")
            {
                if (true)
                {
                    this.bloquear = false;
                    this.Close();
                }
                else
                {
                    this.bloquear = true;
                    MessageBox.Show("Usuario ou senha são inválidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                this.bloquear = true;
                MessageBox.Show("Verifique Usuario e Senha.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void lblEsqueceu_Click(object sender, EventArgs e)
        {
            FrmRecuperarSenha recuperarSenha = new FrmRecuperarSenha();
            recuperarSenha.ShowDialog();
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            bloquear = false;
        }
    }
}
