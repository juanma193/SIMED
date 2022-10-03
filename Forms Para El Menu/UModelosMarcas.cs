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
    public partial class UModelosMarcas : Form
    {
        public UModelosMarcas()
        {
            InitializeComponent();
        }

        private void btnAltaModelo_Click(object sender, EventArgs e)
        {
            AltaModelos ventana = new AltaModelos();
            ventana.Show();
            this.Dispose();
        }

        private void btnConsultaModelo_Click(object sender, EventArgs e)
        {
            ConsultaModelos ventana = new ConsultaModelos();
            ventana.Show();
            this.Dispose();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            UFuncionalidades ventana = new UFuncionalidades();
            ventana.Show();
            this.Dispose();
        }

        private void btnAltaMarca_Click(object sender, EventArgs e)
        {
            AltaMarcas ventana = new AltaMarcas();
            ventana.Show();
            this.Dispose();
        }

        private void btnConsultaMarca_Click(object sender, EventArgs e)
        {
            ConsultaMarcas ventana = new ConsultaMarcas();
            ventana.Show();
            this.Dispose();
        }
    }
}
