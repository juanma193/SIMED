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
    public partial class AltaMedico : Form
    {
        public AltaMedico()
        {
            InitializeComponent();
            CargarComboTiposDoc();
            CargarComboEspecialidades();
            CargarComboCiudades();

            cmbBarriosMedico.Enabled = false;
            lblMatriculaMed.Visible = false;
            lblNombreMed.Visible = false;
            lblApellidoMed.Visible = false;
            lblCalleMed.Visible = false;
            lblNroCalleMed.Visible = false;
            lblDocMed.Visible = false;


        }


        private void btnRegistrarMedico_Click(object sender, EventArgs e)
        {
            try
            {
                Medicos medico = new Medicos();
                MedicosxDiasLaborales diasLaborales = new MedicosxDiasLaborales();
                bool valMatricula = true;
                bool valNombre = true;
                bool valSexo = true;
                bool valDireccion = true;
                bool valEspec = true;
                bool valRelLab = true;
                bool valFechaNac = true;
                bool valDoc = true;
                bool valDiasLab = true;
                bool valHorarios = true;

                if (txtMatriculaMedico.Text == "")
                {
                    valMatricula = false;
                    ErroresForm mensaje = new ErroresForm();
                    mensaje.show("Ingrese el número de matrícula del médico" );
                    txtMatriculaMedico.Focus();
                }

                else if (txtApellidoMedico.Text == "" || txtNombreMedico.Text == "")
                {
                    valNombre = false;
                    ErroresForm mensaje = new ErroresForm();
                    mensaje.show("Ingrese nombre y apellido del médico");
                }

                else if (rdFemeninoMedico.Checked == false && rdMasculinoMedico.Checked == false && rdOtroMedico.Checked == false)
                {
                    valSexo = false;
                    ErroresForm mensaje = new ErroresForm();
                    mensaje.show("Ingrese el sexo del médico");
                }

                else if (cmbCiudadMedico.SelectedIndex == -1 || cmbBarriosMedico.SelectedIndex == -1 || txtCalleMedico.Text == "" || txtNroCalleMedico.Text == "")
                {
                    valDireccion = false;
                    ErroresForm mensaje = new ErroresForm();
                    mensaje.show("Ingrese la dirección del médico");
                }

                else if (cmbEspecialidadMedico.SelectedIndex == -1)
                {
                    valEspec = false;
                    ErroresForm mensaje = new ErroresForm();
                    mensaje.show("Ingrese la especialidad del médico");
                }

                else if (rdPlantaPermanente.Checked == false && rdContratoRenov.Checked == false && rdContratoCircuns.Checked == false)
                {
                    valRelLab = false;
                    ErroresForm mensaje = new ErroresForm();
                    mensaje.show("Ingrese la relación laboral del médico");
                }

                else if (cmbTipoDocumentoMedico.SelectedIndex == -1 || txtNroDocMedico.Text == "" || lblDocMed.Visible == true)
                {
                    valDoc = false;
                    ErroresForm mensaje = new ErroresForm();
                    mensaje.show("Ingrese el documento del médico");
                }

                else if (chkLunesMedico.Checked == false && chkMartesMedico.Checked == false && chkMiercolesMedico.Checked == false && chkJuevesMedico.Checked == false && chkViernesMedico.Checked == false && chkSabadoMedico.Checked == false && chkDomingoMedico.Checked == false)
                {
                    valDiasLab = false;
                    ErroresForm mensaje = new ErroresForm();
                    mensaje.show("Ingrese los días laborales del médico");
                }

                else if (dtHoraIngresoMedico.Value == dtHoraEgresoMedico.Value)
                {
                    valHorarios = false;
                    ErroresForm mensaje = new ErroresForm();
                    mensaje.show("Ingrese el horario del médico");
                }



                if (valMatricula && valNombre && valSexo && valDireccion && valEspec && valRelLab && valFechaNac && valDoc && valDiasLab && valHorarios)
                {
                    medico.NumeroMatricula = int.Parse(txtMatriculaMedico.Text);
                    medico.Nombre = txtNombreMedico.Text;
                    medico.Apellido = txtApellidoMedico.Text;
                    medico.FechaNacimiento = dtFechaNacMedico.Value;
                    medico.Calle = txtCalleMedico.Text;
                    medico.NroCalle = int.Parse(txtNroCalleMedico.Text);
                    medico.IdBarrio = (int)cmbBarriosMedico.SelectedValue;
                    medico.IdEspecialidad = (int)cmbEspecialidadMedico.SelectedValue;
                    medico.IdTipoDocumento = (int)cmbTipoDocumentoMedico.SelectedValue;
                    medico.NumDocumento = long.Parse(txtNroDocMedico.Text);
                    medico.HorarioIngreso = dtHoraIngresoMedico.Value.TimeOfDay;
                    medico.HorarioEgreso = dtHoraEgresoMedico.Value.TimeOfDay;


                    if (rdFemeninoMedico.Checked)
                    {
                        medico.IdSexo = 1;
                    }
                    if (rdMasculinoMedico.Checked)
                    {
                        medico.IdSexo = 2;
                    }
                    if (rdOtroMedico.Checked)
                    {
                        medico.IdSexo = 3;
                    }



                    if (rdPlantaPermanente.Checked)
                    {
                        medico.IdRelacionLaboral = 1;
                    }
                    if (rdContratoCircuns.Checked)
                    {
                        medico.IdRelacionLaboral = 2;
                    }
                    if (rdContratoRenov.Checked)
                    {
                        medico.IdRelacionLaboral = 3;
                    }


                    bool resultado = MedicoBD.InsertarMedico(medico);

                    if (resultado)
                    {

                        if (chkLunesMedico.Checked)
                        {
                            diasLaborales.IdDiaLaboral = 1;
                            diasLaborales.NumeroMatricula = int.Parse(txtMatriculaMedico.Text);
                            MedicoBD.InsertarMedicosDiasLaborales(diasLaborales);
                        }
                        if (chkMartesMedico.Checked)
                        {
                            diasLaborales.IdDiaLaboral = 2;
                            diasLaborales.NumeroMatricula = int.Parse(txtMatriculaMedico.Text);
                            MedicoBD.InsertarMedicosDiasLaborales(diasLaborales);
                        }
                        if (chkMiercolesMedico.Checked)
                        {
                            diasLaborales.IdDiaLaboral = 3;
                            diasLaborales.NumeroMatricula = int.Parse(txtMatriculaMedico.Text);
                            MedicoBD.InsertarMedicosDiasLaborales(diasLaborales);
                        }
                        if (chkJuevesMedico.Checked)
                        {
                            diasLaborales.IdDiaLaboral = 4;
                            diasLaborales.NumeroMatricula = int.Parse(txtMatriculaMedico.Text);
                            MedicoBD.InsertarMedicosDiasLaborales(diasLaborales);
                        }
                        if (chkViernesMedico.Checked)
                        {
                            diasLaborales.IdDiaLaboral = 5;
                            diasLaborales.NumeroMatricula = int.Parse(txtMatriculaMedico.Text);
                            MedicoBD.InsertarMedicosDiasLaborales(diasLaborales);
                        }
                        if (chkSabadoMedico.Checked)
                        {
                            diasLaborales.IdDiaLaboral = 6;
                            diasLaborales.NumeroMatricula = int.Parse(txtMatriculaMedico.Text);
                            MedicoBD.InsertarMedicosDiasLaborales(diasLaborales);
                        }
                        if (chkDomingoMedico.Checked)
                        {
                            diasLaborales.IdDiaLaboral = 7;
                            diasLaborales.NumeroMatricula = int.Parse(txtMatriculaMedico.Text);
                            MedicoBD.InsertarMedicosDiasLaborales(diasLaborales);
                        }

                        CorrectoForm ventana = new CorrectoForm();
                        ventana.show("Se ha registrado el médico con éxito");
                    }
                    else
                    {
                        ErroresForm ventana = new ErroresForm();
                        ventana.show("No se ha podido registrar el médico");
                    }



                }


            }
            catch(Exception ex)
            {
                ErroresForm ventana = new ErroresForm();
                ventana.show("Error" + " " + ex);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            PrincipalForm ventana = new PrincipalForm();
            ventana.Show();
            this.Dispose();
        }

        private void CargarComboTiposDoc()
        {
            try
            {
                cmbTipoDocumentoMedico.DisplayMember = "descripcionTipoDocumento";
                cmbTipoDocumentoMedico.ValueMember = "id_tipoDocumento";
                cmbTipoDocumentoMedico.DataSource = MedicoBD.ObtenerTiposDocumento();
                cmbTipoDocumentoMedico.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                ErroresForm ventana = new ErroresForm();
                ventana.show("Error" + " " + ex);
            }
        }

        private void CargarComboCiudades()
        {
            try
            {
                cmbCiudadMedico.DisplayMember = "descripcionCiudad";
                cmbCiudadMedico.ValueMember = "id_ciudad";
                cmbCiudadMedico.DataSource = MedicoBD.ObtenerCiudades();
                cmbCiudadMedico.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                ErroresForm ventana = new ErroresForm();
                ventana.show("Error" + " " + ex);
            }
        }

        private void CargarComboEspecialidades()
        {
            try
            {
                cmbEspecialidadMedico.DisplayMember = "descripcionEspecialidad";
                cmbEspecialidadMedico.ValueMember = "id_especialidad";
                cmbEspecialidadMedico.DataSource = MedicoBD.ObtenerEspecialidades();
                cmbEspecialidadMedico.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                ErroresForm ventana = new ErroresForm();
                ventana.show("Error" + " " + ex);
            }
        }

        private void CargarComboBarrios(int cmbCiudadMedico)
        {
            try
            {
                cmbBarriosMedico.DisplayMember = "nombre_barrio";
                cmbBarriosMedico.ValueMember = "id_barrio";
                cmbBarriosMedico.DataSource = MedicoBD.ObtenerBarrios(cmbCiudadMedico + 1);
                cmbBarriosMedico.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                ErroresForm ventana = new ErroresForm();
                ventana.show("Error" + " " + ex);
            }
        }

        private void txtMatriculaMedico_TextChanged(object sender, EventArgs e)
        {
            if (txtMatriculaMedico.Text.Equals(""))
            {
                lblMatriculaMed.Visible = true;
                lblMatriculaMed.Text = "Número de matrícula obligatorio";
            }
            else
            {
                lblMatriculaMed.Visible = false;
            }
        }

        private void txtNombreMedico_TextChanged(object sender, EventArgs e)
        {
            if (txtNombreMedico.Text.Equals(""))
            {
                lblNombreMed.Visible = true;
                lblNombreMed.Text = "Nombre de médico obligatorio";
            }
            else
            {
                lblNombreMed.Visible = false;
            }
        }

        private void txtApellidoMedico_TextChanged(object sender, EventArgs e)
        {
            if (txtApellidoMedico.Text.Equals(""))
            {
                lblApellidoMed.Visible = true;
                lblApellidoMed.Text = "Apellido de médico obligatorio";
            }
            else
            {
                lblApellidoMed.Visible = false;
            }
        }

        private void txtCalleMedico_TextChanged(object sender, EventArgs e)
        {
            if (txtCalleMedico.Text.Equals(""))
            {
                lblCalleMed.Visible = true;
                lblCalleMed.Text = "Calle de médico obligatoria";
            }
            else
            {
                lblCalleMed.Visible = false;
            }
        }

        private void txtNroCalleMedico_TextChanged(object sender, EventArgs e)
        {
            if (txtNroCalleMedico.Text.Equals(""))
            {
                lblNroCalleMed.Visible = true;
                lblNroCalleMed.Text = "Número de calle obligatorio";
            }
            else
            {
                lblNroCalleMed.Visible = false;
            }
        }

        private void txtNroDocMedico_TextChanged(object sender, EventArgs e)
        {
            if (txtNroDocMedico.Text.Equals(""))
            {
                lblDocMed.Visible = true;
                lblDocMed.Text = "N° de doc. de médico obligatorio";
            }
            else if (cmbTipoDocumentoMedico.SelectedIndex == 0 && txtNroDocMedico.Text.Length < 8)
            {
                lblDocMed.Visible = true;
                lblDocMed.Text = "N° de documento inválido";
            }
            else if (cmbTipoDocumentoMedico.SelectedIndex == 1 && txtNroDocMedico.Text.Length < 11)
            {
                lblDocMed.Visible = true;
                lblDocMed.Text = "N° de CUIL inválido";
            }
            else if (cmbTipoDocumentoMedico.SelectedIndex == 2 && txtNroDocMedico.Text.Length < 9)
            {
                lblDocMed.Visible = true;
                lblDocMed.Text = "N° de Pasaporte inválido";
            }
            else 
            {
                lblDocMed.Visible = false;
            }
        }

        private void txtMatriculaMedico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNombreMedico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtApellidoMedico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCalleMedico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNroCalleMedico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNroDocMedico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbTipoDocumentoMedico.SelectedIndex == -1)
            {
                if (!char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else 
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void cmbTipoDocumentoMedico_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNroDocMedico.Text = "";
            if(cmbTipoDocumentoMedico.SelectedIndex == 0)
            {
                txtNroDocMedico.MaxLength = 8;
            }
            else if(cmbTipoDocumentoMedico.SelectedIndex == 1)
            {
                txtNroDocMedico.MaxLength = 11;
            }
            else if(cmbTipoDocumentoMedico.SelectedIndex == 2)
            {
                txtNroDocMedico.MaxLength = 9;

            }
        }

        private void cmbCiudadMedico_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarComboBarrios(cmbCiudadMedico.SelectedIndex);
            cmbBarriosMedico.Enabled = true;

        }
    }
}
