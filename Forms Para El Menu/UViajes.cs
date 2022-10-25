using SIMED_V1.Forms_Para_ABM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMED_V1.Forms_Para_El_Menu
{
    public partial class UViajes : UserControl
    {
        PrincipalForm princ;
        public UViajes(PrincipalForm principal)
        {
            InitializeComponent();
            princ = principal;
        }

        private void btnRegistrarViaje_Click(object sender, EventArgs e)
        {
            ViajesNuevo ventana = new ViajesNuevo();
            ventana.ShowDialog();
        }

        private void btnConsultarViaje_Click(object sender, EventArgs e)
        {
            ConsultarViaje window = new ConsultarViaje(princ);
            window.ShowDialog();
        }
    }
}
