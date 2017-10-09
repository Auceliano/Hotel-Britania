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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            
        }

        
 
        private void cadastroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmCadastrarHospede cadastrarHospede = new FrmCadastrarHospede();
            cadastrarHospede.Show();
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastrarFuncionario cadastrarFuncionario = new FrmCadastrarFuncionario();
            cadastrarFuncionario.Show();
        }

        private void trocarUsuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            do{
                if (login.getBloquear())
                    login.ShowDialog();
                else
                    this.Close();

            } while (login.getBloquear());
            
        }


        private void unidadesHabitacionaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastrarUnidadeHabitacional cadastrarUnidadeHabitacional = new FrmCadastrarUnidadeHabitacional();
            cadastrarUnidadeHabitacional.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void entradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCheckin reserva = new FrmCheckin();
            reserva.Show();
        }

        private void saidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCheckOut checkOut = new FrmCheckOut();
            checkOut.Show();
            
        }

        private void logoffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRecuperarSenha recuperarSenha = new FrmRecuperarSenha();
            recuperarSenha.ShowDialog();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            do
            {
                if (login.getBloquear())
                    login.ShowDialog();
                else
                    this.Close();

            } while (login.getBloquear());
        }
    }
}
