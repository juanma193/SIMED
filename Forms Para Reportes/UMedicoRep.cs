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
    public partial class UMedicoRep : UserControl
    {
        public UMedicoRep()
        {
            InitializeComponent();
        }

        private void btnGenerarReportes_Click(object sender, EventArgs e)
        {
            ReporteMedico rep = new ReporteMedico();
            rep.ShowDialog();
        }
    }
}
