using SIMED_V1.Bases_de_datos;
using SIMED_V1.Forms_Mensajes_Personalizados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMED_V1.Forms_Para_ABM
{
    public partial class DatosEnfermero : Form
    {
        ConsultaEnfermero window;
        public DatosEnfermero(ConsultaEnfermero ventanaConsulta)
        {
            InitializeComponent();
            window = ventanaConsulta;
        }

        private void btnVolverDatosEnfermero_Click(object sender, EventArgs e)
        {
            window.Show();
            this.Dispose();
        }

        public void btnEliminarEnfermeroDato_Click(object sender, EventArgs e)
        {
            SeguroEliminar seguro = new SeguroEliminar();
            seguro.lblMensaje.Text = "¿Está seguro que desea eliminar el médico seleccionado?";

            if (seguro.ShowDialog() == DialogResult.OK)
            {
                bool res = EnfermeroBD.EliminarEnfermero(int.Parse(txtMatriculaEnfermeroDato.PlaceholderText));
                if (res)
                {
                    this.Dispose();
                    window.CargarGrillaConsultaEnfermero();
                    CorrectoForm error = new CorrectoForm();
                    error.show("Se eliminó el enfermero MAT:" + txtMatriculaEnfermeroDato.PlaceholderText);
                }

            }

        }

        private void btnCerrarApp_Click(object sender, EventArgs e)
        {
            window.Show();
            this.Dispose();
        }
    }
}
