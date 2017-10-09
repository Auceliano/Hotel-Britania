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
    public partial class FrmCheckOut : Form
    {
        public FrmCheckOut()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            FrmRegistrarCheckOut registrarCheckOut = new FrmRegistrarCheckOut();
            registrarCheckOut.ShowDialog();
        }
    }
}
