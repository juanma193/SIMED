using SIMED.Models;
using SIMED_V1.Bases_de_datos;
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
    public partial class ViajesNuevo : Form
    {
        public ViajesNuevo()
        {
            InitializeComponent();
            CargarComboMoviles();
            CargarComboTiposViaje();
        }

        private void CargarComboMoviles()
        {
            try
            {
                cmbMoviles.DisplayMember = "patente";
                cmbMoviles.ValueMember = "id_movil";
                cmbMoviles.DataSource = ViajesBD.ObtenerMoviles();
                cmbMoviles.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                ErroresForm ventana = new ErroresForm();
                ventana.show("Error " + ex);
            }
        }
        private void CargarComboTiposViaje()
        {
            try
            {
                cmbTiposViaje.DisplayMember = "descripcionTipoViaje";
                cmbTiposViaje.ValueMember = "id_tipoViaje";
                cmbTiposViaje.DataSource = ViajesBD.ObtenerTiposViajes();
                cmbTiposViaje.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                ErroresForm ventana = new ErroresForm();
                ventana.show("Error " + ex);
            }
        }


        private void btnBuscarEnfermero_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable enfermero = EnfermeroBD.ObtenerEnfermeroCompleto(int.Parse(txtMatriculaEnfermero.Text));
                if (enfermero.Rows.Count == 1)
                {
                    txtNombreEnfermero.Text = enfermero.Rows[0][1].ToString();
                    txtApellidoEnfermero.Text = enfermero.Rows[0][2].ToString();
                }
                else
                {
                    ErroresForm window = new ErroresForm();
                    window.show("Enfermero inexistente.");
                    txtMatriculaEnfermero.Focus();
                    txtApellidoEnfermero.Text = "";
                    txtNombreEnfermero.Text = "";
                }
            }
            catch (Exception ex)
            {

                ErroresForm window = new ErroresForm();
                window.show("Error" + " " + ex);
                
            }

        }

        private void btnBuscarMedico_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable medico = MedicoBD.ObtenerMedicoCompleto(int.Parse(txtMatriculaMedico.Text));
                if (medico.Rows.Count == 1)
                {
                    txtNombreMedico.Text = medico.Rows[0][1].ToString();
                    txtApellidoMedico.Text = medico.Rows[0][2].ToString();
                }
                else
                {
                    ErroresForm window = new ErroresForm();
                    window.show("Médico inexistente.");
                    txtMatriculaMedico.Focus();
                    txtApellidoMedico.Text = "";
                    txtNombreMedico.Text = "";
                }
            }
            catch (Exception ex)
            {

                ErroresForm window = new ErroresForm();
                window.show("Error" + " " + ex);

            }
        }

        private void btnAgregarEnfermero_Click(object sender, EventArgs e)
        {
            grdEnfermeros.Rows.Add(txtMatriculaEnfermero.Text, txtNombreEnfermero.Text, txtApellidoEnfermero.Text);
            txtMatriculaEnfermero.Text ="";
            txtApellidoEnfermero.Text = "";
            txtNombreEnfermero.Text = "";
        }

        private void btnAgregarMedico_Click(object sender, EventArgs e)
        {
            grdMedicos.Rows.Add(txtMatriculaMedico.Text, txtNombreMedico.Text, txtApellidoMedico.Text);
            txtMatriculaMedico.Text = "";
            txtApellidoMedico.Text = "";
            txtNombreMedico.Text = "";
        }

        private void btnRegistrarViaje_Click(object sender, EventArgs e)
        {
            List<int> listaEnfermeros = new List<int>();
            for (int i = 0; i < grdEnfermeros.Rows.Count; i++) 
            {
                //if (grdEnfermeros.Rows[i].Cells[0].Value != null) 
                //{
                    listaEnfermeros.Add(int.Parse(grdEnfermeros.Rows[i].Cells[0].Value.ToString()));
                //}
               
            }

            List<int> listaMedicos = new List<int>();
            for (int i = 0; i < grdEnfermeros.Rows.Count; i++)
            {
                //if (grdMedicos.Rows[i].Cells[0].Value != null)
                //{
                    listaMedicos.Add(int.Parse(grdEnfermeros.Rows[i].Cells[0].Value.ToString()));
                //}
            }

            int turno = -1;
            if (rdMañana.Checked)
            {
                turno = 0;
            }
            if (rdTarde.Checked)
            {
                turno = 1;
            }
            if (rdNoche.Checked)
            {
                turno = 2;
            }



            bool resultado = ViajesBD.InsertarViaje(dtFechaViaje.Value,
                                                    (int)cmbMoviles.SelectedValue,
                                                    Convert.ToDateTime(dtHoraSalida.Value),
                                                    Convert.ToDateTime(dtHoraLlegada.Value),
                                                    listaEnfermeros,
                                                    listaMedicos,
                                                    turno,
                                                    (int)cmbTiposViaje.SelectedValue,
                                                    float.Parse(txtCombustiblePrevio.Text),
                                                    float.Parse(txtCombustiblePost.Text),
                                                    float.Parse(txtKilometros.Text));
            if (resultado) 
            {
                CorrectoForm window = new CorrectoForm();
                window.show("Viaje dado de alta con éxito...");
            }
            else 
            {
                ErroresForm window = new ErroresForm();
                window.show("Error al dar de alta un nuevo viaje...");
            }
        }

       

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
