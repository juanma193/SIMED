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
    public partial class URelacionesLaborales : Form
    {
        public URelacionesLaborales()
        {
            InitializeComponent();
        }

        private void btnAltaRL_Click(object sender, EventArgs e)
        {
            AltaRelacionLaboral ventana = new AltaRelacionLaboral();
            ventana.Show();
            this.Dispose();
        }

        private void btnConsultaRL_Click(object sender, EventArgs e)
        {
            ConsultaRelacionLaboral ventana = new ConsultaRelacionLaboral();
            ventana.Show();
            this.Dispose();
        }
    }
}
