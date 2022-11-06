using SIMED_V1.Entidades;
using SIMED_V1.Bases_de_datos;
using SIMED_V1.Forms_Mensajes_Personalizados;
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
    public partial class AltaMarcas : Form
    {
        private static bool bandera = false;
        public AltaMarcas()
        {
            InitializeComponent();
        }

        private void txtNombreMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && (Keys)e.KeyChar != Keys.Back && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtNombreMarca_TextChanged(object sender, EventArgs e)
        {
            if (!bandera)
            {
                if (txtNombreMarca.Text.Equals(""))
                {
                    lblNombreMarca.Visible = true;
                    lblNombreMarca.Text = "Nombre de marca obligatorio";
                }
                else
                {
                    lblNombreMarca.Visible = false;
                }
            }
        }

        private void LimpiarCampos()
        {
            bandera = true;
            txtNombreMarca.Text = "";
            bandera = false;  
        }

        private void btnAltaMarca_Click(object sender, EventArgs e)
        {
            //VALIDACION
            if (txtNombreMarca.Text.Equals(""))
            {
                ErroresForm ventana = new ErroresForm();
                ventana.show("Debe ingresar un nombre");
            }
            else
            {
                Marcas m = ObtenerDatosMarca();
                try
                {
                    bool rdo = ModelosMarcasRLBD.MarcaYaExiste(m);
                    if (rdo)
                    {
                        ErroresForm ventana = new ErroresForm();
                        ventana.show("La marca ya es existente");
                    }
                    else
                    {
                        bool resultado = ModelosMarcasRLBD.AgregarMarcaABD(m);
                        if (resultado)
                        {
                            CorrectoForm cf = new CorrectoForm();
                            cf.show("Marca agregada con éxito");
                            LimpiarCampos();
                        }
                    }
                }
                catch (Exception)
                {
                    ErroresForm ventana = new ErroresForm();
                    ventana.show("Error al crear marca");
                }
            }
        }

        private Marcas ObtenerDatosMarca()
        {
            Marcas m = new Marcas();
            m.NombreMarca = txtNombreMarca.Text;

            return m;
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            UModelosMarcas ventana = new UModelosMarcas();
            ventana.Show();
        }

        private void AltaMarcas_Load(object sender, EventArgs e)
        {
            lblNombreMarca.Visible = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            UModelosMarcas nue = new UModelosMarcas();
            nue.Show();
            this.Dispose();
        }
    }
}
