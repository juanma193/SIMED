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
    
    public partial class ModificarMedico : Form
    {
        ConsultaMedico window;

        public ModificarMedico(ConsultaMedico windowCons)
        {
            InitializeComponent();
            CargarComboTiposDoc();
            CargarComboEspecialidades();
            CargarComboCiudades();

            cmbModificarBarriosMedico.Enabled = false;
            lblMatriculaMed.Visible = false;
            lblNombreMed.Visible = false;
            lblApellidoMed.Visible = false;
            lblCalleMed.Visible = false;
            lblNroCalleMed.Visible = false;
            lblDocMed.Visible = false;

            window = windowCons;
        }

        private void btnModificarMedico_Click(object sender, EventArgs e)
        {
            SeguroModificar seguro = new SeguroModificar();
            seguro.lblMensaje.Text = "¿Está seguro que desea guardar los cambios?";
            if (seguro.ShowDialog() == DialogResult.OK)
            {
                txtModificarMatriculaMedico.Enabled = false;
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


                    if (txtModificarApellidoMedico.Text == "" || txtModificarNombreMedico.Text == "")
                    {
                        valNombre = false;
                        ErroresForm mensaje = new ErroresForm();
                        mensaje.show("Ingrese nombre y apellido del médico.");
                    }


                    else if (rdModificarFemeninoMedico.Checked == false && rdModificarMasculinoMedico.Checked == false && rdModificarOtroMedico.Checked == false)
                    {
                        valSexo = false;
                        ErroresForm mensaje = new ErroresForm();
                        mensaje.show("Ingrese el sexo del médico.");
                    }

                    else if (rdModificarPlantaPermanente.Checked == false && rdModificarContratoRenov.Checked == false && rdModificarContratoCircuns.Checked == false)
                    {
                        valRelLab = false;
                        ErroresForm mensaje = new ErroresForm();
                        mensaje.show("Ingrese la relación laboral del médico");
                    }

                    else if (cmbModificarTipoDocumentoMedico.SelectedIndex == -1 || txtModificarNroDocMedico.Text == "" || lblDocMed.Visible == true)
                    {
                        valDoc = false;
                        ErroresForm mensaje = new ErroresForm();
                        mensaje.show("Ingrese el tipo y el número de documento del médico.");
                    }

                    else if (cmbModificarBarriosMedico.SelectedIndex == -1 || txtModificarCalleMedico.Text == "" || txtModificarNroCalleMedico.Text == "")
                    {
                        valDireccion = false;
                        ErroresForm mensaje = new ErroresForm();
                        mensaje.show("Ingrese la dirección del médico.");
                    }

                    else if (cmbModificarEspecialidadMedico.SelectedIndex == -1)
                    {
                        valEspec = false;
                        ErroresForm mensaje = new ErroresForm();
                        mensaje.show("Seleccione la especialidad del médico.");
                    }

                    else if (chkModificarLunesMedico.Checked == false && chkModificarMartesMedico.Checked == false && chkModificarMiercolesMedico.Checked == false && chkModificarJuevesMedico.Checked == false && chkModificarViernesMedico.Checked == false && chkModificarSabadoMedico.Checked == false && chkModificarDomingoMedico.Checked == false)
                    {
                        valDiasLab = false;
                        ErroresForm mensaje = new ErroresForm();
                        mensaje.show("Ingrese los días laborales del médico");
                    }

                    else if (dtModificarHoraIngresoMedico.Value == dtModificarHoraEgresoMedico.Value)
                    {
                        valHorarios = false;
                        ErroresForm mensaje = new ErroresForm();
                        mensaje.show("Ingrese el horario del médico");
                    }



                    if (valMatricula && valNombre && valFechaNac && valDoc && valDireccion && valEspec && valSexo && valDiasLab && valHorarios && valRelLab)
                    {
                        medico.NumeroMatricula = int.Parse(txtModificarMatriculaMedico.Text);
                        medico.Nombre = txtModificarNombreMedico.Text;
                        medico.Apellido = txtModificarApellidoMedico.Text;
                        medico.FechaNacimiento = dtModificarFechaNacMedico.Value;
                        medico.Calle = txtModificarCalleMedico.Text;
                        medico.NroCalle = int.Parse(txtModificarNroCalleMedico.Text);
                        medico.IdBarrio = (int)cmbModificarBarriosMedico.SelectedValue;
                        medico.IdEspecialidad = (int)cmbModificarEspecialidadMedico.SelectedValue;
                        medico.IdTipoDocumento = (int)cmbModificarTipoDocumentoMedico.SelectedValue;
                        medico.NumDocumento = long.Parse(txtModificarNroDocMedico.Text);
                        medico.HorarioIngreso = dtModificarHoraIngresoMedico.Value.TimeOfDay;
                        medico.HorarioEgreso = dtModificarHoraEgresoMedico.Value.TimeOfDay;


                        if (rdModificarFemeninoMedico.Checked)
                        {
                            medico.IdSexo = 1;
                        }
                        if (rdModificarMasculinoMedico.Checked)
                        {
                            medico.IdSexo = 2;
                        }
                        if (rdModificarOtroMedico.Checked)
                        {
                            medico.IdSexo = 3;
                        }



                        if (rdModificarPlantaPermanente.Checked)
                        {
                            medico.IdRelacionLaboral = 1;
                        }
                        if (rdModificarContratoCircuns.Checked)
                        {
                            medico.IdRelacionLaboral = 2;
                        }
                        if (rdModificarContratoRenov.Checked)
                        {
                            medico.IdRelacionLaboral = 3;
                        }


                        bool resultado = MedicoBD.ModificarMedico(medico);

                        if (resultado)
                        {

                            if (chkModificarLunesMedico.Checked)
                            {
                                diasLaborales.IdDiaLaboral = 1;
                                diasLaborales.NumeroMatricula = int.Parse(txtModificarMatriculaMedico.Text);
                                MedicoBD.ModificarMedicosDiasLaborales(diasLaborales);
                            }
                            else if (chkModificarLunesMedico.Checked == false)
                            {
                                diasLaborales.IdDiaLaboral = 1;
                                diasLaborales.NumeroMatricula = int.Parse(txtModificarMatriculaMedico.Text);
                                MedicoBD.ModificarMedicosDiasLaboralesUnchecked(diasLaborales);
                            }


                            if (chkModificarMartesMedico.Checked)
                            {
                                diasLaborales.IdDiaLaboral = 2;
                                diasLaborales.NumeroMatricula = int.Parse(txtModificarMatriculaMedico.Text);
                                MedicoBD.ModificarMedicosDiasLaborales(diasLaborales);
                            }
                            else if (chkModificarMartesMedico.Checked == false)
                            {
                                diasLaborales.IdDiaLaboral = 2;
                                diasLaborales.NumeroMatricula = int.Parse(txtModificarMatriculaMedico.Text);
                                MedicoBD.ModificarMedicosDiasLaboralesUnchecked(diasLaborales);
                            }


                            if (chkModificarMiercolesMedico.Checked)
                            {
                                diasLaborales.IdDiaLaboral = 3;
                                diasLaborales.NumeroMatricula = int.Parse(txtModificarMatriculaMedico.Text);
                                MedicoBD.ModificarMedicosDiasLaborales(diasLaborales);
                            }
                            else if (chkModificarMiercolesMedico.Checked == false)
                            {
                                diasLaborales.IdDiaLaboral = 3;
                                diasLaborales.NumeroMatricula = int.Parse(txtModificarMatriculaMedico.Text);
                                MedicoBD.ModificarMedicosDiasLaboralesUnchecked(diasLaborales);
                            }


                            if (chkModificarJuevesMedico.Checked)
                            {
                                diasLaborales.IdDiaLaboral = 4;
                                diasLaborales.NumeroMatricula = int.Parse(txtModificarMatriculaMedico.Text);
                                MedicoBD.ModificarMedicosDiasLaborales(diasLaborales);
                            }
                            else if (chkModificarJuevesMedico.Checked == false)
                            {
                                diasLaborales.IdDiaLaboral = 4;
                                diasLaborales.NumeroMatricula = int.Parse(txtModificarMatriculaMedico.Text);
                                MedicoBD.ModificarMedicosDiasLaboralesUnchecked(diasLaborales);
                            }


                            if (chkModificarViernesMedico.Checked)
                            {
                                diasLaborales.IdDiaLaboral = 5;
                                diasLaborales.NumeroMatricula = int.Parse(txtModificarMatriculaMedico.Text);
                                MedicoBD.ModificarMedicosDiasLaborales(diasLaborales);
                            }
                            else if (chkModificarViernesMedico.Checked == false)
                            {
                                diasLaborales.IdDiaLaboral = 5;
                                diasLaborales.NumeroMatricula = int.Parse(txtModificarMatriculaMedico.Text);
                                MedicoBD.ModificarMedicosDiasLaboralesUnchecked(diasLaborales);
                            }


                            if (chkModificarSabadoMedico.Checked)
                            {
                                diasLaborales.IdDiaLaboral = 6;
                                diasLaborales.NumeroMatricula = int.Parse(txtModificarMatriculaMedico.Text);
                                MedicoBD.ModificarMedicosDiasLaborales(diasLaborales);
                            }
                            else if (chkModificarSabadoMedico.Checked == false)
                            {
                                diasLaborales.IdDiaLaboral = 6;
                                diasLaborales.NumeroMatricula = int.Parse(txtModificarMatriculaMedico.Text);
                                MedicoBD.ModificarMedicosDiasLaboralesUnchecked(diasLaborales);
                            }


                            if (chkModificarDomingoMedico.Checked)
                            {
                                diasLaborales.IdDiaLaboral = 7;
                                diasLaborales.NumeroMatricula = int.Parse(txtModificarMatriculaMedico.Text);
                                MedicoBD.ModificarMedicosDiasLaborales(diasLaborales);
                            }
                            else if (chkModificarDomingoMedico.Checked == false)
                            {
                                diasLaborales.IdDiaLaboral = 7;
                                diasLaborales.NumeroMatricula = int.Parse(txtModificarMatriculaMedico.Text);
                                MedicoBD.ModificarMedicosDiasLaboralesUnchecked(diasLaborales);
                            }

                            window.CargarGrillaConsultaMedico();
                            CorrectoForm ventana = new CorrectoForm();
                            ventana.show("Se ha registrado el médico con éxito");
                            this.Dispose();
                        }
                        else
                        {
                            ErroresForm ventana = new ErroresForm();
                            ventana.show("No se ha podido registrar el médico");
                        }
                    }

                }
                catch (Exception ex)
                {
                    ErroresForm window = new ErroresForm();
                    window.show("Error" + " " + ex);
                }
            }
            
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
                SeguroModificar seguro = new SeguroModificar();
                seguro.btnModificar.Text = "Aceptar";
                seguro.lblMensaje.Text = "¿Está seguro que desea descartar los cambios?";
                if (seguro.ShowDialog() == DialogResult.OK)
                {
                    window.Show();
                    this.Dispose();
                }

        }

        private void CargarComboTiposDoc()
        {
            try
            {
                cmbModificarTipoDocumentoMedico.DisplayMember = "descripcionTipoDocumento";
                cmbModificarTipoDocumentoMedico.ValueMember = "id_tipoDocumento";
                cmbModificarTipoDocumentoMedico.DataSource = MedicoBD.ObtenerTiposDocumento();
                cmbModificarTipoDocumentoMedico.SelectedIndex = -1;
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
                cmbModificarCiudadMedico.DisplayMember = "descripcionCiudad";
                cmbModificarCiudadMedico.ValueMember = "id_ciudad";
                cmbModificarCiudadMedico.DataSource = MedicoBD.ObtenerCiudades();
                cmbModificarCiudadMedico.SelectedIndex = -1;
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
                cmbModificarEspecialidadMedico.DisplayMember = "descripcionEspecialidad";
                cmbModificarEspecialidadMedico.ValueMember = "id_especialidad";
                cmbModificarEspecialidadMedico.DataSource = MedicoBD.ObtenerEspecialidades();
                cmbModificarEspecialidadMedico.SelectedIndex = -1;
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
                cmbModificarBarriosMedico.DisplayMember = "nombre_barrio";
                cmbModificarBarriosMedico.ValueMember = "id_barrio";
                cmbModificarBarriosMedico.DataSource = MedicoBD.ObtenerBarrios(cmbCiudadMedico + 1);
                cmbModificarBarriosMedico.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                ErroresForm ventana = new ErroresForm();
                ventana.show("Error" + " " + ex);
            }
        }

        private void txtModificarMatriculaMedico_TextChanged(object sender, EventArgs e)
        {
            if (txtModificarMatriculaMedico.Text.Equals(""))
            {
                lblMatriculaMed.Visible = true;
                lblMatriculaMed.Text = "Número de matrícula obligatorio";
            }
            else
            {
                lblMatriculaMed.Visible = false;
            }
        }

        private void txtModificarNombreMedico_TextChanged(object sender, EventArgs e)
        {
            if (txtModificarNombreMedico.Text.Equals(""))
            {
                lblNombreMed.Visible = true;
                lblNombreMed.Text = "Nombre de médico obligatorio";
            }
            else
            {
                lblNombreMed.Visible = false;
            }
        }

        private void txtModificarApellidoMedico_TextChanged(object sender, EventArgs e)
        {

            if (txtModificarApellidoMedico.Text.Equals(""))
            {
                lblApellidoMed.Visible = true;
                lblApellidoMed.Text = "Apellido de médico obligatorio";
            }
            else
            {
                lblApellidoMed.Visible = false;
            }
        }

        private void txtModificarCalleMedico_TextChanged(object sender, EventArgs e)
        {

            if (txtModificarCalleMedico.Text.Equals(""))
            {
                lblCalleMed.Visible = true;
                lblCalleMed.Text = "Calle de médico obligatoria";
            }
            else
            {
                lblCalleMed.Visible = false;
            }
        }

        private void txtModificarNroCalleMedico_TextChanged(object sender, EventArgs e)
        {

            if (txtModificarNroCalleMedico.Text.Equals(""))
            {
                lblNroCalleMed.Visible = true;
                lblNroCalleMed.Text = "Número de calle obligatorio";
            }
            else
            {
                lblNroCalleMed.Visible = false;
            }
        }

        private void txtModificarNroDocMedico_TextChanged(object sender, EventArgs e)
        {

            if (txtModificarNroDocMedico.Text.Equals(""))
            {
                lblDocMed.Visible = true;
                lblDocMed.Text = "N° de doc. de médico obligatorio";
            }
            else if (cmbModificarTipoDocumentoMedico.SelectedIndex == 0 && txtModificarNroDocMedico.Text.Length < 8)
            {
                lblDocMed.Visible = true;
                lblDocMed.Text = "N° de documento inválido";
            }
            else if (cmbModificarTipoDocumentoMedico.SelectedIndex == 1 && txtModificarNroDocMedico.Text.Length < 11)
            {
                lblDocMed.Visible = true;
                lblDocMed.Text = "N° de CUIL inválido";
            }
            else if (cmbModificarTipoDocumentoMedico.SelectedIndex == 2 && txtModificarNroDocMedico.Text.Length < 9)
            {
                lblDocMed.Visible = true;
                lblDocMed.Text = "N° de Pasaporte inválido";
            }
            else
            {
                lblDocMed.Visible = false;
            }
        }

        private void txtModificarMatriculaMedico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtModificarNombreMedico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtModificarApellidoMedico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtModificarCalleMedico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtModificarNroCalleMedico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtModificarNroDocMedico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbModificarTipoDocumentoMedico.SelectedIndex == -1)
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

        private void cmbModificarTipoDocumentoMedico_SelectedIndexChanged(object sender, EventArgs e)
        {

            txtModificarNroDocMedico.Text = "";
            if (cmbModificarTipoDocumentoMedico.SelectedIndex == 0)
            {
                txtModificarNroDocMedico.MaxLength = 8;
            }
            else if (cmbModificarTipoDocumentoMedico.SelectedIndex == 1)
            {
                txtModificarNroDocMedico.MaxLength = 11;
            }
            else if (cmbModificarTipoDocumentoMedico.SelectedIndex == 2)
            {
                txtModificarNroDocMedico.MaxLength = 9;

            }
        }

        private void cmbModificarCiudadMedico_SelectedIndexChanged(object sender, EventArgs e)
        {

            CargarComboBarrios(cmbModificarCiudadMedico.SelectedIndex);
            cmbModificarBarriosMedico.Enabled = true;

        }

        private void btnCerrarApp_Click(object sender, EventArgs e)
        {

                SeguroModificar seguro = new SeguroModificar();
                seguro.btnModificar.Text = "Aceptar";
                seguro.lblMensaje.Text = "¿Está seguro que desea descartar los cambios?";
                if (seguro.ShowDialog() == DialogResult.OK)
                {
                    window.Show();
                    this.Dispose();
                }

        }

        private void ModificarMedico_Load(object sender, EventArgs e)
        {

        }
    }
}
