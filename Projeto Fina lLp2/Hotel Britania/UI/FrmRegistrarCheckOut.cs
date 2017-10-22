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
    public partial class FrmRegistrarCheckOut : Form
    {
        CheckBll check = new CheckBll();
        HospedeBll hospede = new HospedeBll();
        UnidadeHabitacionalBll unidade = new UnidadeHabitacionalBll();

        public FrmRegistrarCheckOut(CheckBll check)
        {
            InitializeComponent();
            this.check = check;
            this.hospede = new HospedeDal().Obter(check.CodigoHos);
            this.unidade = new UnidadeHabitacionalDal().Obter(check.CodigoUni);

            txtNomeUni.Text = unidade.NomeUni;
            txtNUni.Text = unidade.NumeroUni;
            dtpDataCheckOut.Value = check.DataCheckOut;
            txtNomeHospede.Text = hospede.NomeHos;
            txtCpfHos.Text = hospede.CPFHos;
            // Difference in days, hours, and minutes.
            TimeSpan ts = check.DataCheckOut - check.DataCheckOut;
            // Difference in days.
            int differenceInDays = ts.Days;
            txtDespesas.Text = Convert.ToString(differenceInDays * Convert.ToDouble(unidade.ValorDiariaUni));
        }

    }
}
