using SIMED_V1.Entidades;
using SIMED_V1.Bases_de_datos;
using SIMED_V1.Forms_Para_El_Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMED_V1.Forms_Para_ABM
{
    public partial class AltaRelacionLaboral : Form
    {
        private static bool bandera = false;
        public AltaRelacionLaboral()
        {
            InitializeComponent();
        }

        private void AltaRelacionLaboral_Load(object sender, EventArgs e)
        {
            lblRLObligatorio.Visible = false;
        }

        private void txtRL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (Keys)e.KeyChar != Keys.Back && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        private void txtRL_TextChanged(object sender, EventArgs e)
        {
            if (!bandera)
            {
                if (txtRL.Text.Equals(""))
                {
                    lblRLObligatorio.Visible = true;
                    lblRLObligatorio.Text = "* Campo obligatorio";
                }
                else
                {
                    lblRLObligatorio.Visible = false;
                }
            }
        }
        private RelacionesLaborales ObtenerDatosRL()
        {
            RelacionesLaborales rl = new RelacionesLaborales();
            rl.DescripcionRelacionLaboral = txtRL.Text;

            return rl;
        }
        private void LimpiarCampos()
        {
            bandera = true;
            txtRL.Text = "";
            bandera = false;
        }

        private void btnAltaModelo_Click(object sender, EventArgs e)
        {
            //VALIDACION
            if (txtRL.Text.Equals(""))
            {
                ErroresForm ventana = new ErroresForm();
                ventana.show("Debe ingresar una relación laboral a agregar");
            }
            else
            {
                RelacionesLaborales rl = ObtenerDatosRL();
                try
                {
                    bool rdo = ModelosMarcasRLBD.RLYaExiste(rl);
                    if (rdo)
                    {
                        ErroresForm ventana = new ErroresForm();
                        ventana.show("La relación laboral ya existe");
                    }
                    else
                    {
                        bool resultado = ModelosMarcasRLBD.AgregarRLABD(rl);
                        if (resultado)
                        {
                            CorrectoForm cf = new CorrectoForm();
                            cf.show("Relacion laboral agregada con éxito");
                            LimpiarCampos();
                        }
                    }
                }
                catch (Exception)
                {
                    ErroresForm ventana = new ErroresForm();
                    ventana.show("Error al crear relación laboral");
                }
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            URelacionesLaborales ventana = new URelacionesLaborales();
            ventana.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            URelacionesLaborales nue = new URelacionesLaborales();
            nue.Show();
            this.Dispose();
        }
    }
}
