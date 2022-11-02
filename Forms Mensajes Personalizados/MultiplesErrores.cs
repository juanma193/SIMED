using SIMED_V1.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMED_V1.Forms_Mensajes_Personalizados
{
    public partial class MultiplesErrores : Form
    {
        string aditionalMistakes;
        MusicPlayer player = MusicPlayer.Instance;
        public MultiplesErrores(string error, string erroresAdicionales)
        {
            InitializeComponent();
            //player.Play("C:\\Program Files (x86)\\SIMED\\archivos\\sonidoPayaso.wav");
            lblMensaje.Text = error;
            aditionalMistakes = erroresAdicionales;
            lblDetalles.Visible = false;
        }

        private void mostrarDetalles_Click(object sender, EventArgs e)
        {
            btnMostrarDetalles.Image = Resources.trianglebajo;
            lblDetalles.Visible = true;
            lblDetalles.Text = aditionalMistakes;
            if (btnMostrarDetalles.Checked)
            {
                lblDetalles.Visible = false;
            }
            if (btnMostrarDetalles.Checked)
            {
                lblDetalles.Visible = false;
            }
            
        }

        private void MultiplesErrores_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
