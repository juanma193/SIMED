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
    public partial class DatosMedico : Form
    {
        int idPerfil;
        ConsultaMedico window;
        public DatosMedico(ConsultaMedico menu, int idPerf)
        {
            InitializeComponent();
            window = menu;
            idPerfil = idPerf;
        }

        private void btnVolverConsulta_Click(object sender, EventArgs e)
        {
            window.Show();
            this.Dispose();
        }

        private void btnEliminarMedicoDato_Click(object sender, EventArgs e)
        {
            try
            {
                SeguroEliminar seguro = new SeguroEliminar();
                seguro.lblMensaje.Text = "¿Está seguro que desea eliminar el médico seleccionado?";

                if (seguro.ShowDialog() == DialogResult.OK)
                {
                    bool resultado1 = MedicoBD.EliminarMedicosDiasLaborales(int.Parse(txtMatriculaMedicoDato.PlaceholderText));
                    if (resultado1)
                    {
                        bool resultado = MedicoBD.EliminarMedico(int.Parse(txtMatriculaMedicoDato.PlaceholderText));
                        if (resultado)
                        {
                            CorrectoForm ventana = new CorrectoForm();
                            ventana.show("Se ha eliminado correctamente el médico de matrícula " + txtMatriculaMedicoDato.PlaceholderText);
                            this.Dispose();
                            window.CargarGrillaConsultaMedico();

                        }
                        else
                        {
                            ErroresForm ventana = new ErroresForm();
                            ventana.show("Se ha producido un error al eliminar el médico");
                        }
                    }
                    else
                    {
                        ErroresForm ventana = new ErroresForm();
                        ventana.show("Se ha producido un error al borrar los días laborales. No existen días laborales asociados al médico.");
                    }
                }

            }
            catch(Exception ex)
            {
                if(idPerfil == 1)
                {
                    ErroresForm ventana = new ErroresForm();
                    ventana.show("Error " + ex);
                }
                else
                {
                    throw;
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
