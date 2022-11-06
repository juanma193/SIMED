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
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMED_V1.Forms_Para_ABM
{
    public partial class AltaAmbulancias : Form
    {
        private static bool bandera = false;

        public AltaAmbulancias()
        {
            InitializeComponent();
        }

        private void AltaAmbulancias_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            txt_patente.Focus();
            lblPatenteAmbulancia.Visible = false;
            try
            {
                CargarComboModelos();
            }
            catch (Exception ex)
            {
                ErroresForm ventana = new ErroresForm();
                ventana.show("Error al cargar modelos");
            }
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnCrearAmbulancia_Click(object sender, EventArgs e)
        {

        }

        private void LimpiarCampos()
        {
            bandera = true;
            txt_patente.Text = "";
            cmb_modelo.SelectedIndex = -1;
            guna2RadioButton_altacom.Checked = false;
            guna2RadioButton_bajacom.Checked = false;
            bandera = false;
        }

        private Ambulancias ObtenerDatosAmbulancia()
        {
            Ambulancias a = new Ambulancias();
            a.Patente = txt_patente.Text;
            a.IdModelo = (int)cmb_modelo.SelectedValue;
            if (guna2RadioButton_altacom.Checked)
            {
                a.IdCategoria = 1;
            }
            else if (guna2RadioButton_bajacom.Checked)
            {
                a.IdCategoria = 2;
            }

            return a;
        }

        private bool ChequeoRdsvacios()
        {
            bool resultado = true;

            if (guna2RadioButton_bajacom.Checked == false && guna2RadioButton_altacom.Checked == false)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void CargarComboModelos()
        {
            try
            {
                cmb_modelo.DataSource = ModelosMarcasRLBD.ObtenerModelos();
                cmb_modelo.DisplayMember = "nombre_modelo";
                cmb_modelo.ValueMember = "id_modelo";
                cmb_modelo.SelectedIndex = -1;
            }
            catch (Exception)
            {
                ErroresForm ventana = new ErroresForm();
                ventana.show("Error al cargar modelos");
            }
        }

        private void txt_patente_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && (Keys)e.KeyChar != Keys.Back && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void txt_patente_TextChanged(object sender, EventArgs e)
        {
            if (!bandera)
            {
                if (txt_patente.Text.Equals(""))
                {
                    lblPatenteAmbulancia.Visible = true;
                    lblPatenteAmbulancia.Text = "*Campo obligatorio";
                }
                else
                {
                    lblPatenteAmbulancia.Visible = false;
                }
            }
        }

        private void btnCrearAmbulancia_Click_1(object sender, EventArgs e)
        {
            if (txt_patente.Text.Equals("") || cmb_modelo.SelectedIndex == -1 || ChequeoRdsvacios())
            {
                //No hay patente ni modelo ni rds 000
                if (txt_patente.Text.Equals("") && cmb_modelo.SelectedIndex == -1 && ChequeoRdsvacios())
                {
                    string error = "Campos incompletos";
                    string errorAdicional = "Ingrese patente de ambulancia \n" + "Ingrese modelo de ambulancia \n" + "Ingrese complejidad de ambulancia";
                    MultiplesErrores ventana = new MultiplesErrores(error, errorAdicional);
                    ventana.Show();
                }
                //No hay patente ni rds
                else if (txt_patente.Text.Equals("") && cmb_modelo.SelectedIndex != -1 && ChequeoRdsvacios())
                {
                    string error = "Campos incompletos";
                    string errorAdicional = "Ingrese patente de ambulancia \n" + "Ingrese complejidad de ambulancia";
                    MultiplesErrores ventana = new MultiplesErrores(error, errorAdicional);
                    ventana.Show();
                }
                //No hay patente ni modelo
                else if (txt_patente.Text.Equals("") && cmb_modelo.SelectedIndex == -1 && !ChequeoRdsvacios())
                {
                    string error = "Campos incompletos";
                    string errorAdicional = "Ingrese patente de ambulancia \n" + "Ingrese modelo de ambulancia";
                    MultiplesErrores ventana = new MultiplesErrores(error, errorAdicional);
                    ventana.Show();
                }
                //No hay modelo ni rds
                else if (!txt_patente.Text.Equals("") && cmb_modelo.SelectedIndex == -1 && ChequeoRdsvacios())
                {
                    string error = "Campos incompletos";
                    string errorAdicional = "Ingrese modelo de ambulancia \n" + "Ingrese complejidad de ambulancia";
                    MultiplesErrores ventana = new MultiplesErrores(error, errorAdicional);
                    ventana.Show();
                }
                //No hay patente
                else if (txt_patente.Text.Equals("") && cmb_modelo.SelectedIndex != -1 && !ChequeoRdsvacios())
                {
                    ErroresForm ventana = new ErroresForm();
                    ventana.show("Ingrese patente de ambulancia");
                }
                //No hay modelo
                else if (!txt_patente.Text.Equals("") && cmb_modelo.SelectedIndex == -1 && !ChequeoRdsvacios())
                {
                    ErroresForm ventana = new ErroresForm();
                    ventana.show("Ingrese modelo de ambulancia");
                }
                //No hay complejidad
                else if (!txt_patente.Text.Equals("") && cmb_modelo.SelectedIndex != -1 && ChequeoRdsvacios())
                {
                    ErroresForm ventana = new ErroresForm();
                    ventana.show("Ingrese complejidad de ambulancia");
                }
            }
            else
            {
                string patente = txt_patente.Text;
                Regex reggaeton = new Regex(@"^([A-Z]{3}\-[0-9]{3})|([A-Z]{2}\-[0-9]{3}\-[A-Z]{2})$");
                if (reggaeton.IsMatch(txt_patente.Text))
                {
                    Ambulancias a = ObtenerDatosAmbulancia();
                    try
                    {
                        bool rdo = AmbulanciasBD.AmbulanciaYaExiste(a);
                        if (rdo)
                        {
                            ErroresForm ventana = new ErroresForm();
                            ventana.show("La ambulancia ya existe");
                        }
                        else
                        {
                            bool resultado = AmbulanciasBD.AgregarAmbulanciaABD(a);
                            if (resultado)
                            {
                                CorrectoForm cf = new CorrectoForm();
                                cf.show("Ambulancia agregada con éxito");
                                LimpiarCampos();
                                CargarComboModelos();
                            }
                        }
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
                else
                {
                    ErroresForm ventana = new ErroresForm();
                    ventana.show("Patentes aceptadas:\n\nAAA-999\nAA-999-AA");
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            UAmbulancias nue = new UAmbulancias();
            nue.Show();
            this.Dispose();
        }
    }
}
