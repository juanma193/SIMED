using SIMED.Models;
using SIMED_V1.Bases_de_datos;
using SIMED_V1.Forms_Mensajes_Personalizados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SIMED_V1.Forms_Para_ABM
{
    public partial class ConsultarAmbulancias : Form
    {
        public ConsultarAmbulancias()
        {
            InitializeComponent();
        }

        private void ConsultarAmbulancias_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarComboModelos();
            CargarGrilla();
            btn_modificar.Enabled = false;
            btn_eliminar.Enabled = false;
            lblNroIdMovil.Enabled = false;
            lblIdMovil.Visible = false;
        }

        private void LimpiarCampos()
        {
            txt_patente.Text = "";
            cmbModelo.SelectedIndex = -1;
            rbAltaComplejidad.Checked = false;
            rbBajaComplejidad.Checked = false;
        }

        private void CargarGrilla()
        {
            try
            {
                gdr_ambulancias.DataSource = AmbulanciasBD.ObtenerListadoAmbulancias();
            }
            catch (Exception)
            {
                ErroresForm ventana = new ErroresForm();
                ventana.show("Error al cargar grilla");
            }
        }

        private void CargarGrilla(string patente)
        {
            try
            {
                gdr_ambulancias.DataSource = AmbulanciasBD.ObtenerListadoAmbulancias(patente);
            }
            catch (Exception)
            {
                ErroresForm ventana = new ErroresForm();
                ventana.show("Error al cargar grilla");
            }
        }

        private bool ChequeoRdsvacios()
        {
            bool resultado = true;

            if (rbAltaComplejidad.Checked == false && rbBajaComplejidad.Checked == false)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private bool ValidarCampos()
        {
            bool resultado = false;
            if (txt_patente.Text.Equals("") || cmbModelo.SelectedIndex == -1 || ChequeoRdsvacios())
            {
                //No hay patente ni modelo ni rds 000
                if (txt_patente.Text.Equals("") && cmbModelo.SelectedIndex == -1 && ChequeoRdsvacios())
                {
                    string error = "Campos incompletos";
                    string errorAdicional = "Ingrese patente de ambulancia \n" + "Ingrese modelo de ambulancia \n" + "Ingrese complejidad de ambulancia";
                    MultiplesErrores ventana = new MultiplesErrores(error, errorAdicional);
                    ventana.Show();
                }
                //No hay patente ni rds
                else if (txt_patente.Text.Equals("") && cmbModelo.SelectedIndex != -1 && ChequeoRdsvacios())
                {
                    string error = "Campos incompletos";
                    string errorAdicional = "Ingrese patente de ambulancia \n" + "Ingrese complejidad de ambulancia";
                    MultiplesErrores ventana = new MultiplesErrores(error, errorAdicional);
                    ventana.Show();
                }
                //No hay patente ni modelo
                else if (txt_patente.Text.Equals("") && cmbModelo.SelectedIndex == -1 && !ChequeoRdsvacios())
                {
                    string error = "Campos incompletos";
                    string errorAdicional = "Ingrese patente de ambulancia \n" + "Ingrese modelo de ambulancia";
                    MultiplesErrores ventana = new MultiplesErrores(error, errorAdicional);
                    ventana.Show();
                }
                //No hay modelo ni rds
                else if (!txt_patente.Text.Equals("") && cmbModelo.SelectedIndex == -1 && ChequeoRdsvacios())
                {
                    string error = "Campos incompletos";
                    string errorAdicional = "Ingrese modelo de ambulancia \n" + "Ingrese complejidad de ambulancia";
                    MultiplesErrores ventana = new MultiplesErrores(error, errorAdicional);
                    ventana.Show();
                }
                //No hay patente
                else if (txt_patente.Text.Equals("") && cmbModelo.SelectedIndex != -1 && !ChequeoRdsvacios())
                {
                    ErroresForm ventana = new ErroresForm();
                    ventana.show("Ingrese patente de ambulancia");
                }
                //No hay modelo
                else if (!txt_patente.Text.Equals("") && cmbModelo.SelectedIndex == -1 && !ChequeoRdsvacios())
                {
                    ErroresForm ventana = new ErroresForm();
                    ventana.show("Ingrese modelo de ambulancia");
                }
                //No hay complejidad
                else if (!txt_patente.Text.Equals("") && cmbModelo.SelectedIndex != -1 && ChequeoRdsvacios())
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
                    resultado = true;
                }
                else
                {
                    ErroresForm ventana = new ErroresForm();
                    ventana.show("Patentes aceptadas:\n\nAAA-999\nAA-999-AA");
                }
            }
            return resultado;
        }

        private void CargarCampos(Ambulancias a)
        {
            txt_patente.Text = a.Patente;
            CargarComboModelos();
            cmbModelo.SelectedValue = a.IdModelo;
            lblIdMovil.Text = a.IdMovil.ToString();
            if (a.IdCategoria == 1)
            {
                rbAltaComplejidad.Checked = true;
            }
            else
            {
                rbBajaComplejidad.Checked = true;
            }
        }

        private void CargarComboModelos()
        {
            try
            {
                cmbModelo.DataSource = ModelosMarcasRLBD.ObtenerModelos();
                cmbModelo.DisplayMember = "nombre_modelo";
                cmbModelo.ValueMember = "id_modelo";
                cmbModelo.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                ErroresForm ventana = new ErroresForm();
                ventana.show("Error al cargar marcas");
            }
        }

        private void txt_patente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && (Keys)e.KeyChar != Keys.Back && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (!txt_patente.Text.Equals(""))
            {
                CargarGrilla(txt_patente.Text);
            }
            else
            {
                CargarGrilla();
            }
        }

        private Ambulancias ObtenerDatosAmbulancia()
        {
            Ambulancias a = new Ambulancias();
            a.Patente = txt_patente.Text;
            a.IdModelo = (int)cmbModelo.SelectedValue;
            a.IdMovil = int.Parse(lblIdMovil.Text.ToString());
            if(rbAltaComplejidad.Checked)
            {
                a.IdCategoria = 1;
            }
            else if(rbBajaComplejidad.Checked)
            {
                a.IdCategoria = 2;
            }

            return a;
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            bool r = ValidarCampos();
            if (r)
            {
                Ambulancias a = ObtenerDatosAmbulancia();
                bool resultado = AmbulanciasBD.ActualizarAmbulancia(a);
                if (resultado)
                {
                    CorrectoForm cf = new CorrectoForm();
                    cf.show("Modelo actualizado con éxito");
                    LimpiarCampos();
                    CargarGrilla();
                }
                else
                {
                    ErroresForm ventana = new ErroresForm();
                    ventana.show("Error al actualizar ambulancia");
                }
            }
        }

        private void gdr_ambulancias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (indice.Equals(-1))
            {
                ErroresForm ventana = new ErroresForm();
                ventana.show("Seleccione una celda válida");
            }
            else
            {
                btn_modificar.Enabled = true;
                btn_eliminar.Enabled = true;
                DataGridViewRow fila = gdr_ambulancias.Rows[indice];
                string patente = fila.Cells["patenteAm"].Value.ToString();
                Ambulancias a = AmbulanciasBD.ObtenerAmbulancia(patente);
                lblNroIdMovil.Enabled = true;
                lblIdMovil.Visible = true;
                LimpiarCampos();
                CargarCampos(a);
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            SeguroEliminar seguro = new SeguroEliminar();
            seguro.lblMensaje.Text = "¿Está seguro que desea eliminar la ambulancia seleccionada?";

            if (seguro.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    Ambulancias a = ObtenerDatosAmbulancia();
                    bool resultado = AmbulanciasBD.EliminarAmbulancia(a);
                    if (resultado)
                    {
                        LimpiarCampos();
                        CargarGrilla();
                        CorrectoForm cor = new CorrectoForm();
                        cor.show("Ambulancia eliminada con éxito");
                    }
                }
                catch (Exception)
                {
                    ErroresForm ventana = new ErroresForm();
                    ventana.show("Error al eliminar persona");
                }
            }
        }

        private void btnCerrarApp_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            UAmbulancias nue = new UAmbulancias();
            nue.Show();
            this.Dispose();
        }
    }
}
