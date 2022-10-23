using SIMED.Models;
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
                    btnAgregarEnfermero.Enabled = true;
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
                
                DataTable medico = MedicoBD.ObtenerMedicos(int.Parse(txtMatriculaMedico.Text),"","");
                if (medico.Rows.Count == 1)
                {
                    txtNombreMedico.Text = medico.Rows[0][1].ToString();
                    txtApellidoMedico.Text = medico.Rows[0][2].ToString();
                    btnAgregarMedico.Enabled = true;
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
            var bandera = false;
            for (int i = 0; i < grdEnfermeros.Rows.Count; i++)
            {
                if (txtMatriculaEnfermero.Text == grdEnfermeros.Rows[i].Cells[0].Value?.ToString())
                {
                    bandera = true;
                }
            }
            if (!bandera)
            {

                grdEnfermeros.Rows.Add(txtMatriculaEnfermero.Text, txtNombreEnfermero.Text, txtApellidoEnfermero.Text);
                txtMatriculaEnfermero.Text = "";
                txtApellidoEnfermero.Text = "";
                txtNombreEnfermero.Text = "";
                btnAgregarEnfermero.Enabled = false;
            }
            else
            {
                ErroresForm window = new ErroresForm();
                window.show("Enfermero ya agregado");
                btnAgregarEnfermero.Enabled = false;
            }
        }

        private void btnAgregarMedico_Click(object sender, EventArgs e)
        {
            var bandera = false;
            for (int i = 0; i < grdMedicos.Rows.Count; i++)
            {
                if (txtMatriculaMedico.Text == grdMedicos.Rows[i].Cells[0].Value?.ToString())
                {
                    bandera = true;
                }
            }
            if (!bandera)
            {

                grdMedicos.Rows.Add(txtMatriculaMedico.Text, txtNombreMedico.Text, txtApellidoMedico.Text);
                txtMatriculaMedico.Text = "";
                txtApellidoMedico.Text = "";
                txtNombreMedico.Text = "";
                btnAgregarMedico.Enabled = false;
            }
            else
            {
                ErroresForm window = new ErroresForm();
                window.show("Medico ya agregado");
                btnAgregarMedico.Enabled = false;
            }
        }

        private void btnRegistrarViaje_Click(object sender, EventArgs e)
        {
            var enfer = false;
            var kmtot = false;
            var comrest = false;

            List<int> listaEnfermeros = new List<int>();
            for (int i = 0; i < grdEnfermeros.Rows.Count - 1 ; i++) 
            {
                //if (grdEnfermeros.Rows[i].Cells[0].Value != null) 
                //{
                    listaEnfermeros.Add(int.Parse(grdEnfermeros.Rows[i].Cells[0].Value.ToString()));
                //}
               
            }
            if(listaEnfermeros.Count > 0)
            {
                enfer = true;
            }
            if (int.Parse(txtKilometros.Text) > 0)
            {
                kmtot = true;
            }
            if (int.Parse(txtCombustiblePrevio.Text)- int.Parse(txtCombustiblePost.Text) >= 0)
            {
                comrest = true;
            }

            if (enfer && kmtot && comrest)
            {
                List<int> listaMedicos = new List<int>();
                for (int i = 0; i < grdMedicos.Rows.Count - 1; i++)
                {
                    //if (grdMedicos.Rows[i].Cells[0].Value != null)
                    //{
                    listaMedicos.Add(int.Parse(grdMedicos.Rows[i].Cells[0].Value.ToString()));
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
            else
            {
                var error = "No se pudo dar de alta el viaje";
                var detalles = "";

                if (!enfer)
                {
                    detalles = detalles + "Necesita agregar al menos un enfermero\n";
                }

                if (!kmtot)
                {
                    detalles = detalles + "Los kilometros totales tienen que ser mayores a 0 \n";
                }

                if (!comrest)
                {
                    detalles = detalles + "El combustible restante tiene que ser mayor a 0 \n";
                }

                MultiplesErrores window = new MultiplesErrores(error, detalles);
                window.Show();

            }
            
        }

       

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtMatriculaEnfermero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMatriculaMedico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtKilometros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCombustiblePrevio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCombustiblePost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cmbMoviles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ViajesNuevo_Load(object sender, EventArgs e)
        {

        }
    }
}
