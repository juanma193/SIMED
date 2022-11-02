using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMED_V1.Forms_Para_Reportes
{
    public partial class PrincipalRepEst : Form
    {
        UserControl ContActivo;
        public PrincipalRepEst()
        {
            InitializeComponent();
        }

        private void btnGeneral_Click(object sender, EventArgs e)
        {
            this.pnContenido.Controls.Remove(ContActivo);
            ContActivo = new UGeneral();
            ContActivo.Dock = DockStyle.Fill;
            this.pnContenido.Controls.Add(ContActivo);
        }

    }
}
