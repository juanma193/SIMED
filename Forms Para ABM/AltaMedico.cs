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
    public partial class AltaMedico : Form
    {
        bool cambios = false;
        int idPerfil;
        public AltaMedico(int idPerf)
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
            cambios = false;
            idPerfil = idPerf;

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
                    bool existe = false;

                if (txtMatriculaMedico.Text == "")
                {
                    valMatricula = false;
                    ErroresForm mensaje = new ErroresForm();
                    mensaje.show("Ingrese el número de matrícula del médico");
                    txtMatriculaMedico.Focus();
                }

                existe = MedicoBD.ObtenerMedicoCompleto(int.Parse(txtMatriculaMedico.Text)).Rows.Count != 0;
                if (existe)
                {
                    ErroresForm ventana = new ErroresForm();
                    ventana.show("Ya esta registrado ese número de matricula");
                }
                else
                {

                    if (txtApellidoMedico.Text == "" || txtNombreMedico.Text == "")
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
                        SeguroModificar seguro = new SeguroModificar();
                        seguro.btnModificar.Text = "Registrar";
                        seguro.lblMensaje.Text = "¿Está seguro que desea registrar el médico?";
                        if (seguro.ShowDialog() == DialogResult.OK)
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
                                this.Dispose();

                            }
                            else
                            {
                                ErroresForm ventana = new ErroresForm();
                                ventana.show("No se ha podido registrar el médico");
                            }


                        }
                        else
                        {
                            cambios = true;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                if(idPerfil == 1)
                {
                    ErroresForm ventana = new ErroresForm();
                    ventana.show("Error " + ex);
                }
                
            }


            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            if (cambios)
            {
                SeguroModificar seguro = new SeguroModificar();
                seguro.btnModificar.Text = "Aceptar";
                seguro.lblMensaje.Text = "¿Está seguro que desea descartar los cambios?";
                if (seguro.ShowDialog() == DialogResult.OK)
                {
                    this.Dispose();
                }
            }
            else
            {
                this.Dispose();
            }
                  
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

        private void CargarComboBarrios(int cmbCiudadMedico)
        {
            try
            {
                cmbBarriosMedico.DisplayMember = "nombre_barrio";
                cmbBarriosMedico.ValueMember = "id_barrio";
                cmbBarriosMedico.DataSource = MedicoBD.ObtenerBarrios(cmbCiudadMedico + 1);
                cmbBarriosMedico.SelectedIndex = -1;
                cambios = true;
            }
            catch (Exception ex)
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
                cambios = true;
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
                cambios = true;
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
                cambios = true;
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
                cambios = true;
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
                cambios = true;
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
                cambios = true;
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

            cambios = true;
            if(cmbTipoDocumentoMedico.SelectedIndex == -1)
            {
                cambios = false;
            }
        }

        private void cmbCiudadMedico_SelectedIndexChanged(object sender, EventArgs e)
        {

            CargarComboBarrios(cmbCiudadMedico.SelectedIndex);
            cmbBarriosMedico.Enabled = true;

            cambios = true;
            if (cmbCiudadMedico.SelectedIndex == -1)
            {
                cambios = false;
            }

        }

        private void btnCerrarApp_Click(object sender, EventArgs e)
        {
            if (cambios)
            {
                SeguroModificar seguro = new SeguroModificar();
                seguro.btnModificar.Text = "Aceptar";
                seguro.lblMensaje.Text = "¿Está seguro que desea descartar los cambios?";
                if (seguro.ShowDialog() == DialogResult.OK)
                {
                    this.Dispose();
                }
            }
            else
            {
                this.Dispose();
            }
                

        }

        private void lblMatriculaMed_VisibleChanged(object sender, EventArgs e)
        {
            if(txtMatriculaMedico.Text != "")
            {
                cambios = true;
            }
        }

        private void lblNombreMed_VisibleChanged(object sender, EventArgs e)
        {
            if (txtNombreMedico.Text != "")
            {
                cambios = true;
            }
        }

        private void lblApellidoMed_VisibleChanged(object sender, EventArgs e)
        {
            if (txtApellidoMedico.Text != "")
            {
                cambios = true;
            }
        }

        private void lblCalleMed_VisibleChanged(object sender, EventArgs e)
        {
            if (txtCalleMedico.Text != "")
            {
                cambios = true;
            }
        }

        private void lblNroCalleMed_VisibleChanged(object sender, EventArgs e)
        {
            if (txtNroCalleMedico.Text != "")
            {
                cambios = true;
            }
        }

        private void lblDocMed_VisibleChanged(object sender, EventArgs e)
        {
            if (txtNroDocMedico.Text != "")
            {
                cambios = true;
            }
        }

        private void cmbEspecialidadMedico_SelectedIndexChanged(object sender, EventArgs e)
        {
            cambios = true;
            if (cmbEspecialidadMedico.SelectedIndex == -1)
            {
                cambios = false;
            }
        }

        private void dtFechaNacMedico_Click(object sender, EventArgs e)
        {
            cambios = true;
        }

        private void rdFemeninoMedico_CheckedChanged(object sender, EventArgs e)
        {
            cambios = true;
        }

        private void rdMasculinoMedico_CheckedChanged(object sender, EventArgs e)
        {
            cambios = true;
        }

        private void rdOtroMedico_CheckedChanged(object sender, EventArgs e)
        {
            cambios = true;
        }

        private void rdPlantaPermanente_CheckedChanged(object sender, EventArgs e)
        {
            cambios = true;
        }

        private void rdContratoCircuns_CheckedChanged(object sender, EventArgs e)
        {
            cambios = true;
        }

        private void rdContratoRenov_CheckedChanged(object sender, EventArgs e)
        {
            cambios = true;
        }

        private void chkLunesMedico_CheckedChanged(object sender, EventArgs e)
        {
            cambios = true;
        }

        private void chkMartesMedico_CheckedChanged(object sender, EventArgs e)
        {
            cambios = true;
        }

        private void chkMiercolesMedico_CheckedChanged(object sender, EventArgs e)
        {
            cambios = true;
        }

        private void chkJuevesMedico_CheckedChanged(object sender, EventArgs e)
        {
            cambios = true;
        }

        private void chkViernesMedico_CheckedChanged(object sender, EventArgs e)
        {
            cambios = true;
        }

        private void chkSabadoMedico_CheckedChanged(object sender, EventArgs e)
        {
            cambios = true;
        }

        private void chkDomingoMedico_CheckedChanged(object sender, EventArgs e)
        {
            cambios = true;
        }
    }
}
