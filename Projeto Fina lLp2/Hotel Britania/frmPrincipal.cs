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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCadastrarHospede aaaa = new frmCadastrarHospede();
            aaaa.Show();
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroFuncionario ffff = new frmCadastroFuncionario();
            ffff.Show();
        }

        private void trocarUsuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmLogin llll = new frmLogin();
            llll.Show();
        }
    }
}
