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
    public partial class UFuncionalidades : UserControl
    {
        public UFuncionalidades()
        {
            InitializeComponent();
        }

        private void btnRangosEtarios_Click(object sender, EventArgs e)
        {
            ABMCRangosEtarios ventana = new ABMCRangosEtarios();
            ventana.Show();
        }

        private void btnModelos_Click(object sender, EventArgs e)
        {
            UModelosMarcas ventana = new UModelosMarcas();
            ventana.Show();
        }

        private void btnTiposViajes_Click(object sender, EventArgs e)
        {
            AbmTipoViaje ventana = new AbmTipoViaje();
            ventana.Show();
        }

        private void btnEspecialidades_Click(object sender, EventArgs e)
        {
            ABMCEspecialidades ventana = new ABMCEspecialidades();
        }
        private void btnRelacionLaboral_Click(object sender, EventArgs e)
        {
            URelacionesLaborales ventana = new URelacionesLaborales();
            ventana.Show();
        }
    }
}
