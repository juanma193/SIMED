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
    public partial class UPlanes : UserControl
    {
        public UPlanes()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AltaPlanes ventana = new AltaPlanes();
            ventana.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            ConsultaPlanes ventana = new ConsultaPlanes();
            ventana.Show();
        }
    }
}
