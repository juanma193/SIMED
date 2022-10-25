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
    public partial class AltaEnfermeros : Form
    {

        bool cambios = false;
        public AltaEnfermeros()
        {
            InitializeComponent();
            CargarComboTiposDoc();
            CargarComboEspecialidades();
            CargarComboCiudades();
            CargarComboBarrios();
            cmbBarrioEnfermero.Enabled = false;
            cambios = false;
        }


        private void btnRegistrarEnfermero_Click(object sender, EventArgs e)
        {
            try
            {
                Enfermeros enfermero = new Enfermeros();
                bool valNroMatE = true;
                bool valNomE = true;
                bool valFechaE = true;
                bool valTelE = true;
                bool valDocE = true;
                bool valCalleE = true;
                bool valSexoE = true;
                bool valEspE = true;
                bool existe = false;

                if (txtMatriculaEnfermero.Text == "")
                {
                    valNroMatE = false;
                    ErroresForm mensaje = new ErroresForm();
                    mensaje.show("Ingrese el número de matrícula del enfermero.");
                }
                existe = EnfermeroBD.ObtenerEnfermeroCompleto(int.Parse(txtMatriculaEnfermero.Text)).Rows.Count != 0;
                if (existe)
                {
                    ErroresForm ventana = new ErroresForm();
                    ventana.show("Ya esta registrado ese número de matricula");
                }
                else
                {

                    if (txtApellidoEnfermero.Text == "" || txtNombreEnfermero.Text == "")
                    {
                        valNomE = false;
                        ErroresForm mensaje = new ErroresForm();
                        mensaje.show("Ingrese nombre y apellido del enfermero.");
                    }

                    else if (txtTelefonoEnfermero.Text == "")
                    {
                        valTelE = false;
                        ErroresForm mensaje = new ErroresForm();
                        mensaje.show("Ingrese el número de teléfono del enfermero.");
                    }

                    else if (rdFemeninoEnfermero.Checked == false && rdMasculinoEnfermero.Checked == false && rdOtroEnfermero.Checked == false)
                    {
                        valSexoE = false;
                        ErroresForm mensaje = new ErroresForm();
                        mensaje.show("Ingrese el sexo del enfermero.");
                    }

                    else if (cmbTipoDocEnfermero.SelectedIndex == -1 || txtNumeroDocEnfermero.Text == "" || lblNumeroDocEnfermero.Visible == true)
                    {
                        valDocE = false;
                        ErroresForm mensaje = new ErroresForm();
                        mensaje.show("Ingrese el tipo y el número de documento del enfermero.");
                    }

                    else if (cmbBarrioEnfermero.SelectedIndex == -1 || txtCalleEnfermero.Text == "" || txtNumeroCalleEnfermero.Text == "")
                    {
                        valCalleE = false;
                        ErroresForm mensaje = new ErroresForm();
                        mensaje.show("Ingrese la dirección del enfermero.");
                    }



                    else if (cmbEspecialidadEnfermero.SelectedIndex == -1)
                    {
                        valEspE = false;
                        ErroresForm mensaje = new ErroresForm();
                        mensaje.show("Seleccione la especialidad del enfermero.");
                    }


                    if (valNroMatE && valNomE && valFechaE && valTelE && valDocE && valCalleE && valSexoE && valEspE)
                    {
                        SeguroModificar seguro = new SeguroModificar();
                        seguro.btnModificar.Text = "Registrar";
                        seguro.lblMensaje.Text = "¿Está seguro que desea registrar el médico?";
                        if (seguro.ShowDialog() == DialogResult.OK)
                        {
                            enfermero.NumeroMatricula = int.Parse(txtMatriculaEnfermero.Text);
                            enfermero.Nombre = txtNombreEnfermero.Text;
                            enfermero.Apellido = txtApellidoEnfermero.Text;
                            //DateTime fechaNacEnfermero = DateTime.Parse(dtFechaNacimientoEnfermero.Text);
                            enfermero.FechaNacimiento = dtFechaNacimientoEnfermero.Value;
                            //CORREGIR MENSAJE DE ERROR CUANDO SE PONEN LETRAS EN LUGAR DE NUMEROS (TEL, NRO DOC, NRO CALLE)
                            enfermero.Telefono = long.Parse(txtTelefonoEnfermero.Text);
                            enfermero.NumeroDocumento = long.Parse(txtNumeroDocEnfermero.Text);
                            enfermero.Calle = txtCalleEnfermero.Text;
                            enfermero.NroCalle = int.Parse(txtNumeroCalleEnfermero.Text);

                            enfermero.IdBarrio = (int)cmbBarrioEnfermero.SelectedValue;
                            enfermero.IdTipoDocumento = (int)cmbTipoDocEnfermero.SelectedValue;
                            enfermero.IdEspecialidad = (int)cmbEspecialidadEnfermero.SelectedValue;

                            if (rdFemeninoEnfermero.Checked)
                            {
                                enfermero.IdSexo = 1;
                            }
                            if (rdMasculinoEnfermero.Checked)
                            {
                                enfermero.IdSexo = 2;
                            }
                            if (rdOtroEnfermero.Checked)
                            {
                                enfermero.IdSexo = 3;
                            }

                            //bool resultado = EnfermeroBD.InsertarEnfermero(nroMatEnfermero, nomEnfermero, apeEnfermo, fechaNacEnfermero, telEnfermero, numDocEnfermero, tipoDocEnfermero, especialidadEnfermero, calle, numCalleEnfermero, barrioEnfermero, sexoEnfermero);

                            bool resultado = EnfermeroBD.InsertarEnfermero(enfermero);

                            if (resultado)
                            {
                                CorrectoForm ventana = new CorrectoForm();
                                ventana.show("Se ha registrado el enfermero con éxito.");
                                this.Dispose();
                            }
                            else
                            {
                                ErroresForm ventana = new ErroresForm();
                                ventana.show("No se ha podido registrar el enfermero.");
                            }

                        }
                    }
                    else
                    {
                        cambios = true;
                    }
                }
            }
            catch (Exception ex)
            {
                ErroresForm window = new ErroresForm();
                window.show("Error" + " " + ex);
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
                cmbTipoDocEnfermero.DisplayMember = "descripcionTipoDocumento";
                cmbTipoDocEnfermero.ValueMember = "id_tipoDocumento";
                cmbTipoDocEnfermero.DataSource = EnfermeroBD.ObtenerTiposDocumento();
                cmbTipoDocEnfermero.SelectedIndex = -1;


            }
            catch (Exception ex)
            {
                ErroresForm window = new ErroresForm();
                window.show("Error: No se ha cargado correctamente el combo de Tipos de Doc." + ex);
            }
        }

        private void CargarComboCiudades()
        {
            try
            {
                cmbCiudadesEnfermero.DisplayMember = "descripcionCiudad";
                cmbCiudadesEnfermero.ValueMember = "id_ciudad";
                cmbCiudadesEnfermero.DataSource = EnfermeroBD.ObtenerCiudades();
                cmbCiudadesEnfermero.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                ErroresForm window = new ErroresForm();
                window.show("Error: No se ha cargado correctamente el combo de Especialidades." + ex);
            }
        }
        private void CargarComboEspecialidades()
        {
            try
            {
                cmbEspecialidadEnfermero.DisplayMember = "descripcionEspecialidad";
                cmbEspecialidadEnfermero.ValueMember = "id_especialidad";
                cmbEspecialidadEnfermero.DataSource = EnfermeroBD.ObtenerEspecialidades();
                cmbEspecialidadEnfermero.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                ErroresForm window = new ErroresForm();
                window.show("Error: No se ha cargado correctamente el combo de Especialidades." + ex);
            }
        }

        private void CargarComboBarrios()
        {
            try
            {
                cmbBarrioEnfermero.DisplayMember = "nombre_barrio";
                cmbBarrioEnfermero.ValueMember = "id_barrio";
                cmbBarrioEnfermero.DataSource = EnfermeroBD.ObtenerBarrios(cmbCiudadesEnfermero.SelectedIndex + 1);
                cmbBarrioEnfermero.SelectedIndex = -1;
                cambios = true;
                //string ciudad = EnfermeroBD.ObtenerCiudad(1);
                //txtCiudadEnfermero.PlaceholderText = ciudad;

            }
            catch (Exception ex)
            {
                ErroresForm window = new ErroresForm();
                window.show("Error: No se ha cargado correctamente el combo de Barrios." + ex);
            }
        }

        private void txtMatriculaEnfermero_TextChanged(object sender, EventArgs e)
        {
            if (txtMatriculaEnfermero.Text.Equals(""))
            {
                lblMatriculaEnfermero.Visible = true;
                lblMatriculaEnfermero.Text = "Número de matricula obligatorio";
            }
            else
            {
                lblMatriculaEnfermero.Visible = false;
                cambios = true;
            }
        }
        private void txtNombreEnfermero_TextChanged(object sender, EventArgs e)
        {
            if (txtNombreEnfermero.Text.Equals(""))
            {
                lblNombreEnfermero.Visible = true;
                lblNombreEnfermero.Text = "Nombre de enfermero obligatorio";
            }
            else
            {
                lblNombreEnfermero.Visible = false;
                cambios = true;
            }
        }
        private void txtApellidoEnfermero_TextChanged(object sender, EventArgs e)
        {
            if (txtApellidoEnfermero.Text.Equals(""))
            {
                lblApellidoEnfermero.Visible = true;
                lblApellidoEnfermero.Text = "Apellido de enfermero obligatorio";
            }
            else
            {
                lblApellidoEnfermero.Visible = false;
                cambios = true;
            }
        }
        private void txtTelefonoEnfermero_TextChanged(object sender, EventArgs e)
        {
            if (txtTelefonoEnfermero.Text.Equals(""))
            {
                lblTelefonoEnfermero.Visible = true;
                lblTelefonoEnfermero.Text = "Teléfono de enfermero obligatorio";
            }
            else
            {
                lblTelefonoEnfermero.Visible = false;
                cambios = true;
            }
        }
        private void txtNumeroDocEnfermero_TextChanged(object sender, EventArgs e)
        {
            if (txtNumeroDocEnfermero.Text.Equals(""))
            {
                lblNumeroDocEnfermero.Visible = true;
                lblNumeroDocEnfermero.Text = "N° de doc. de enfermero obligatorio";
            }
            else if (cmbTipoDocEnfermero.SelectedIndex == 0 && txtNumeroDocEnfermero.Text.Length < 8)
            {
                lblNumeroDocEnfermero.Visible = true;
                lblNumeroDocEnfermero.Text = "N° de documento inválido";
            }
            else if (cmbTipoDocEnfermero.SelectedIndex == 1 && txtNumeroDocEnfermero.Text.Length < 11)
            {
                lblNumeroDocEnfermero.Visible = true;
                lblNumeroDocEnfermero.Text = "N° de CUIL inválido";
            }
            else if (cmbTipoDocEnfermero.SelectedIndex == 2 && txtNumeroDocEnfermero.Text.Length < 9)
            {
                lblNumeroDocEnfermero.Visible = true;
                lblNumeroDocEnfermero.Text = "N° de Pasaporte inválido";
            }
            else
            {
                lblNumeroDocEnfermero.Visible = false;
                cambios = true;
            }
        }
        private void txtCalleEnfermero_TextChanged(object sender, EventArgs e)
        {
            if (txtCalleEnfermero.Text.Equals(""))
            {
                lblCalleEnfermero.Visible = true;
                lblCalleEnfermero.Text = "Calle de enfermero obligatorio";
            }
            else
            {
                lblCalleEnfermero.Visible = false;
                cambios = true;
            }
        }
        private void txtNumeroCalleEnfermero_TextChanged(object sender, EventArgs e)
        {
            if (txtNumeroCalleEnfermero.Text.Equals(""))
            {
                lblNumeroCalleEnfermero.Visible = true;
                lblNumeroCalleEnfermero.Text = "N° de calle de enfermero obligatorio";
            }
            else
            {
                lblNumeroCalleEnfermero.Visible = false;
                cambios = true;
            }
        }

        private void txtMatriculaEnfermero_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar que la tecla presionada no sea CTRL u otra tecla no numerica
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtTelefonoEnfermero_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar que la tecla presionada no sea CTRL u otra tecla no numerica
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNumeroCalleEnfermero_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar que la tecla presionada no sea CTRL u otra tecla no numerica
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void txtNumeroDocEnfermero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbTipoDocEnfermero.SelectedIndex == -1)
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

        private void txtNombreEnfermero_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar que la tecla presionada no sea CTRL u otra tecla numerica
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtApellidoEnfermero_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar que la tecla presionada no sea CTRL u otra tecla numerica
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtCalleEnfermero_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar que la tecla presionada no sea CTRL u otra tecla numerica
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cmbCiudadesEnfermero_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarComboBarrios();
            cmbBarrioEnfermero.Enabled = true;
            cambios = true;
            if (cmbCiudadesEnfermero.SelectedIndex == -1)
            {
                cambios = false;
            }
        }
        private void cmbTipoDocEnfermero_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNumeroDocEnfermero.Text = "";
            if (cmbTipoDocEnfermero.SelectedIndex == 0)
            {
                txtNumeroDocEnfermero.MaxLength = 8;
            }
            else if (cmbTipoDocEnfermero.SelectedIndex == 1)
            {
                txtNumeroDocEnfermero.MaxLength = 11;
            }
            else if (cmbTipoDocEnfermero.SelectedIndex == 2)
            {
                txtNumeroDocEnfermero.MaxLength = 9;

            }
            cambios = true;
            if (cmbTipoDocEnfermero.SelectedIndex == -1)
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

        private void lblMatriculaEnfermero_VisibleChanged(object sender, EventArgs e)
        {
            if (txtMatriculaEnfermero.Text != "")
            {
                cambios = true;
            }
        }

        private void lblNombreEnfermero_VisibleChanged(object sender, EventArgs e)
        {
            if (txtNombreEnfermero.Text != "")
            {
                cambios = true;
            }
        }

        private void lblApellidoEnfermero_VisibleChanged(object sender, EventArgs e)
        {
            if (txtApellidoEnfermero.Text != "")
            {
                cambios = true;
            }
        }

        private void lblTelefonoEnfermero_VisibleChanged(object sender, EventArgs e)
        {
            if (txtTelefonoEnfermero.Text != "")
            {
                cambios = true;
            }
        }

        private void lblCalleEnfermero_VisibleChanged(object sender, EventArgs e)
        {
            if (txtCalleEnfermero.Text != "")
            {
                cambios = true;
            }
        }

        private void lblNumeroCalleEnfermero_VisibleChanged(object sender, EventArgs e)
        {
            if (txtNumeroCalleEnfermero.Text != "")
            {
                cambios = true;
            }
        }

        private void lblNumeroDocEnfermero_VisibleChanged(object sender, EventArgs e)
        {
            if (txtNumeroDocEnfermero.Text != "")
            {
                cambios = true;
            }
        }

        private void cmbEspecialidadEnfermero_SelectedIndexChanged(object sender, EventArgs e)
        {
            cambios = true;
            if (cmbEspecialidadEnfermero.SelectedIndex == -1)
            {
                cambios = false;
            }
        }

        private void dtFechaNacimientoEnfermero_Click(object sender, EventArgs e)
        {
            cambios = true;
        }

        private void rdFemeninoEnfermero_CheckedChanged(object sender, EventArgs e)
        {
            cambios = true;
        }

        private void rdMasculinoEnfermero_CheckedChanged(object sender, EventArgs e)
        {
            cambios = true;
        }

        private void rdOtroEnfermero_CheckedChanged(object sender, EventArgs e)
        {
            cambios = true;
        }



        private void btnMinimizar_Click(object sender, EventArgs e)
        {

        }

    }
}
