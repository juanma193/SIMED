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
    public partial class UEnfermeros : UserControl
    {
        PrincipalForm ventana;
        public UEnfermeros(PrincipalForm menu)
        {
            InitializeComponent();
            ventana = menu;
        }

        private void UEnfermeros_Load(object sender, EventArgs e)
        {

        }


        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultaEnfermero_Click(object sender, EventArgs e)
        {
            
            ConsultaEnfermero consulta = new ConsultaEnfermero(ventana);
            consulta.Show();
            //ventana.Hide();
        }


        private void btnAltaEnfermero_Click(object sender, EventArgs e)
        {
            AltaEnfermeros alta = new AltaEnfermeros();
            alta.Show();
            //ventana.Hide();  

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEspecialidades_Click(object sender, EventArgs e)
        {
            
        }
    }
}
