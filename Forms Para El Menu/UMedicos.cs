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

namespace SIMED_V1
{
    public partial class UMedicos : UserControl
    {
        PrincipalForm window;

        public UMedicos(PrincipalForm menu)
        {
            InitializeComponent();
            window = menu;
        }

        private void btnDarAltaMedico_Click(object sender, EventArgs e)
        {
            AltaMedico ventana = new AltaMedico();
            ventana.Show();
            window.Hide();
        }

        private void btnConsultarDatosMedico_Click(object sender, EventArgs e)
        {
            ConsultaMedico ventana = new ConsultaMedico();
            ventana.Show();
            window.Hide();
        }
    }
}
