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
        PrincipalForm window;
        public UFuncionalidades(PrincipalForm menu)
        {
            InitializeComponent();
            window = menu;
        }

        private void btnRangosEtarios_Click(object sender, EventArgs e)
        {
            ABMCRangosEtarios ventana = new ABMCRangosEtarios(window);
            ventana.Show();
            window.Hide();
        }
    }
}
