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
    public partial class FrmCheckin : Form
    {
        public FrmCheckin()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            FrmRegistrarCheckIn registrarCheckIn = new FrmRegistrarCheckIn();
            registrarCheckIn.ShowDialog();
        }

        
        private void dataCheckIn_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnInserir.Enabled = false;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnCheckOut.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnInserir.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCheckOut.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente apagar os registros?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                CheckDal dados = new CheckDal();
                dados.Exclui(Convert.ToInt32(dataCheckIn.CurrentRow.Cells[0].Value));
                
                btnInserir.Enabled = true;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
                btnCheckOut.Enabled = false;
                btnCancelar.Enabled = false;

                MessageBox.Show("Dados apagados com, sucesso?", "ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            CheckBll check = new CheckBll();
            CheckDal dados = new CheckDal();

            check = dados.Obter(Convert.ToInt32(dataCheckIn.CurrentRow.Cells[0].Value));

            FrmRegistrarCheckOut checkOut = new FrmRegistrarCheckOut(check);
            checkOut.ShowDialog();
            
        }

        private void FrmCheckin_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'hotelBDDataSet.tbCheck'. Você pode movê-la ou removê-la conforme necessário.
            this.tbCheckTableAdapter.Fill(this.hotelBDDataSet.tbCheck);

        }

        private void dataCheckIn_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnInserir.Enabled = false;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnCheckOut.Enabled = true;
            btnCancelar.Enabled = true;
        }
    }
}
