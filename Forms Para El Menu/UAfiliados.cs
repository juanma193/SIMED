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
    public partial class UAfiliados : UserControl
    {
        public UAfiliados()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AltaAfiliado ventana = new AltaAfiliado();
            ventana.Show();
            this.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            ConsultarAfiliado ventana = new ConsultarAfiliado();
            ventana.Show();
            this.Hide();
        }
    }
}
