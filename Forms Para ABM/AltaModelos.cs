using SIMED.Models;
using SIMED_V1.Bases_de_datos;
using SIMED_V1.Forms_Mensajes_Personalizados;
using SIMED_V1.Forms_Para_El_Menu;
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
    public partial class AltaModelos : Form
    {
        private static bool bandera = false;

        public AltaModelos()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            if(!bandera)
            {
                if (txtNombreModelo.Text.Equals(""))
                {
                    lblNombreModelo.Visible = true;
                    lblNombreModelo.Text = "Nombre de modelo obligatorio";
                }
                else
                {
                    lblNombreModelo.Visible = false;
                }
            }
        }


        private void AltaModelo_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            txtNombreModelo.Focus();
            lblNombreModelo.Visible = false;
            try
            {
                CargarComboMarcas();
            }
            catch (Exception ex)
            {
                ErroresForm ventana = new ErroresForm();
                ventana.show("Error al cargar marcas");
            }
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            //VALIDACIONES
            if (txtNombreModelo.Text.Equals("") || cmbMarcaModelo.SelectedIndex == -1)
            {
                //No hay nombre ni marca
                if(txtNombreModelo.Text.Equals("") && cmbMarcaModelo.SelectedIndex == -1)
                {
                    string error = "Campos incompletos";
                    string errorAdicional = "Ingrese nombre de modelo \n" + "Ingrese marca de modelo";
                    MultiplesErrores ventana = new MultiplesErrores(error, errorAdicional);
                    ventana.Show();
                }
                //No hay nombre
                else if(txtNombreModelo.Text.Equals("") && cmbMarcaModelo.SelectedIndex != -1)
                {
                    ErroresForm ventana = new ErroresForm();
                    ventana.show("Ingrese nombre de modelo");
                }
                //No hay marca
                else if(!txtNombreModelo.Text.Equals("") && cmbMarcaModelo.SelectedIndex == -1)
                {
                    ErroresForm ventana = new ErroresForm();
                    ventana.show("Ingrese marca de modelo");
                }
            }
            else
            {
                Modelos m = ObtenerDatosModelo();
                try
                {
                    bool rdo = ModelosMarcasBD.ModeloYaExiste(m);
                    if(rdo)
                    {
                        ErroresForm ventana = new ErroresForm();
                        ventana.show("El modelo ya es existente");
                    }
                    else
                    {
                        bool resultado = ModelosMarcasBD.AgregarModeloABD(m);
                        if (resultado)
                        {
                            CorrectoForm cf = new CorrectoForm();
                            cf.show("Modelo agregado con éxito");
                            LimpiarCampos();
                            CargarComboMarcas();
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private Modelos ObtenerDatosModelo()
        {
            Modelos m = new Modelos();
            m.NombreModelo = txtNombreModelo.Text;
            m.IdMarca = (int)cmbMarcaModelo.SelectedValue;

            return m;
        }

        private void LimpiarCampos()
        {
            bandera = true;
            txtNombreModelo.Text = "";
            cmbMarcaModelo.SelectedIndex = -1;
            bandera = false;
        }

        private void CargarComboMarcas()
        {
            try
            {
                cmbMarcaModelo.DataSource = ModelosMarcasBD.ObtenerMarcas();
                cmbMarcaModelo.DisplayMember = "nombre_marca";
                cmbMarcaModelo.ValueMember = "id_marca";
                cmbMarcaModelo.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                ErroresForm ventana = new ErroresForm();
                ventana.show("Error al cargar marcas");
            }
        }

        private void txtNombreModelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && (Keys)e.KeyChar != Keys.Back && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            UFuncionalidades ventana = new UFuncionalidades();
            ventana.Show();
            this.Dispose();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            UModelosMarcas ventana = new UModelosMarcas();
            ventana.Show();
        }
    }
 }
